Imports System.IO
Imports System.Data ' Necesario para DataTable/DataRow
Imports Microsoft.VisualBasic.FileIO ' Necesario para TextFieldParser (opcional pero recomendado)
Imports SAPbobsCOM

Public Class frmAjustedeInvetario
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        CenterPanel()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txbArchivo.Enabled = False ' Deshabilita el TextBox
        DGVDatos.ReadOnly = True
        ' Configuración inicial del DataGridView (opcional, mejora la performance visual)
        DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' O el modo que prefieras
        DGVDatos.AllowUserToAddRows = False ' Importante para el bucle de procesamiento
    End Sub

    Private Sub frmAjustedeInventario_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        ' Asumiendo que los controles están dentro de un Panel llamado pnlControles
        If pnlControles IsNot Nothing Then ' Buena práctica: verificar que el panel existe
            pnlControles.Left = (Me.ClientSize.Width - pnlControles.Width) \ 2 ' Usar \ para división entera
            pnlControles.Top = (Me.ClientSize.Height - pnlControles.Height) \ 2
        End If
    End Sub

    ' --- LECTURA DEL ARCHIVO CSV ---

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Using ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Filter = "Archivos CSV (*.csv)|*.csv"
            ofd.Title = "Seleccionar archivo .csv"
            ofd.Multiselect = False

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim rutaArchivo As String = ofd.FileName
                txbArchivo.Text = rutaArchivo
                txbArchivo.Enabled = False

                ' Limpiar ANTES de intentar cargar nuevos datos
                LimpiarDataGridView()

                ' Validar extensión (redundante si el filtro funciona, pero seguro)
                If Path.GetExtension(rutaArchivo).ToLowerInvariant() = ".csv" Then
                    ' --- CORRECCIÓN AQUÍ ---
                    ' Llenar el DataGridView con los datos del archivo usando StreamReader
                    LlenarDataGridViewConStreamReader(rutaArchivo)
                    ' --- FIN CORRECCIÓN ---
                Else
                    MessageBox.Show("Por favor seleccione un archivo con extensión .csv.", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End Using
    End Sub

    ' Opción 1: Usando StreamReader (menos robusto para CSV complejos)
    Private Sub LlenarDataGridViewConStreamReader(rutaArchivo As String)
        Dim dt As New DataTable()
        Try
            Using reader As New StreamReader(rutaArchivo)
                Dim linea As String

                ' Asumir que la primera línea NO es encabezado y solo hay una columna
                dt.Columns.Add("Articulo") ' O el nombre que prefieras

                ' --- Corrección Aquí ---
                linea = reader.ReadLine() ' Leer la primera línea

                While linea IsNot Nothing ' Comprobar si la línea leída no es Nothing
                    ' Procesar la línea actual
                    Dim values As String() = linea.Split(","c)
                    If values.Length > 0 Then ' Asegurarse de que hay datos
                        dt.Rows.Add(values(0)) ' Añadir solo el primer valor
                    End If

                    ' Leer la SIGUIENTE línea al final del bucle
                    linea = reader.ReadLine()
                End While
                ' --- Fin Corrección ---

            End Using
            DGVDatos.DataSource = dt
        Catch ex As IOException
            MessageBox.Show("Error de E/S al leer el archivo: " & ex.Message, "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error inesperado al leer el archivo CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- PROCESAMIENTO DE DATOS CON SAP ---

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If String.IsNullOrWhiteSpace(txbArchivo.Text) OrElse DGVDatos.DataSource Is Nothing OrElse DirectCast(DGVDatos.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un archivo CSV válido y cargarlo antes de procesar.", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmationResult As DialogResult = MessageBox.Show("Se actualizará la fecha de recuento para los artículos listados." & vbCrLf & "¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmationResult <> DialogResult.Yes Then
            MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not ConectarDIAPIGT() Then ' Verificar conexión PRIMERO
            MessageBox.Show("No se pudo conectar a SAP Business One. Verifique la configuración y el servicio DI API.", "Error de Conexión SAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Si la conexión es exitosa, proceder
        MessageBox.Show("Conectado a SAP. Iniciando procesamiento...", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ProcesarDatos()

    End Sub

    Private Sub ProcesarDatos()
        ' Obtener la tabla de datos directamente desde el DataSource
        Dim dt As DataTable = TryCast(DGVDatos.DataSource, DataTable)
        If dt Is Nothing Then
            MessageBox.Show("No se pudieron obtener los datos para procesar.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Configurar la barra de progreso
        pbar.Minimum = 0
        pbar.Maximum = dt.Rows.Count ' El máximo es el número total de filas a procesar
        pbar.Value = 0
        lblActPbar.Text = $"Procesando 0 de {pbar.Maximum}..."
        lblActPbar.Visible = True
        pbar.Visible = True
        Me.Cursor = Cursors.WaitCursor ' Cambiar cursor a espera

        ' *** OPTIMIZACIÓN PRINCIPAL: Crear el objeto Items UNA SOLA VEZ fuera del bucle ***
        Dim businessObject As SAPbobsCOM.Items = Nothing
        Dim articulosConError As New List(Of String)()
        Dim lRetCode As Integer = 0 ' Para almacenar el código de retorno de Update()
        Dim sErrMsg As String = "" ' Para almacenar el mensaje de error de SAP

        Try
            businessObject = CType(oCompanyGT.GetBusinessObject(BoObjectTypes.oItems), Items)

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim itemCode As String = Convert.ToString(dr("Articulo")) ' Asume que la columna se llama "Articulo"

                If String.IsNullOrWhiteSpace(itemCode) Then
                    articulosConError.Add($"(Fila {i + 1}): Código vacío") ' Registrar error si el código está vacío
                    Continue For ' Saltar a la siguiente iteración
                End If

                Try
                    If businessObject.GetByKey(itemCode) Then
                        ' Actualizar el campo de usuario
                        businessObject.UserFields.Fields.Item("U_Fecha_Recuento").Value = dtpFechaAct.Value '.ToString("yyyyMMdd") ' SAP suele preferir formato yyyyMMdd para fechas en UDF

                        lRetCode = businessObject.Update()

                        If lRetCode <> 0 Then
                            ' Error al actualizar
                            oCompanyGT.GetLastError(lRetCode, sErrMsg)
                            articulosConError.Add($"{itemCode}: {sErrMsg} (Código: {lRetCode})")
                        End If
                    Else
                        ' El artículo no existe en SAP
                        articulosConError.Add($"{itemCode}: No encontrado en SAP.")
                    End If

                Catch exCOM As System.Runtime.InteropServices.COMException
                    ' Captura errores específicos de COM (DI API)
                    oCompanyGT.GetLastError(lRetCode, sErrMsg) ' Intenta obtener el último error de SAP
                    articulosConError.Add($"{itemCode}: Error COM - {sErrMsg} ({exCOM.Message})")
                Catch ex As Exception
                    ' Captura cualquier otro error durante el procesamiento de esta fila
                    articulosConError.Add($"{itemCode}: Error General - {ex.Message}")
                End Try

                ' Actualizar la barra de progreso y etiqueta DESPUÉS de procesar la fila
                pbar.Value = i + 1
                lblActPbar.Text = $"Procesando artículo {pbar.Value} de {pbar.Maximum}"
                Application.DoEvents() ' Permitir que la UI se actualice
            Next

            ' Mostrar resumen final
            If articulosConError.Count = 0 Then
                MessageBox.Show($"Proceso completado exitosamente. Se procesaron {dt.Rows.Count} artículos.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Proceso completado con {articulosConError.Count} errores de {dt.Rows.Count} artículos procesados.", "Proceso Completado con Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MostrarErrores(articulosConError)
            End If

        Catch ex As Exception
            ' Error general durante la inicialización o el bucle principal
            MessageBox.Show("Error crítico durante el procesamiento: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' *** Liberar el objeto COM explícitamente (buena práctica) ***
            If businessObject IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(businessObject)
                businessObject = Nothing
            End If
            GC.Collect() ' Sugerir recolección de basura

            ' Restablecer UI independientemente de si hubo éxito o error
            pbar.Value = 0
            lblActPbar.Text = "Proceso finalizado."
            lblActPbar.Visible = False
            pbar.Visible = False
            Me.Cursor = Cursors.Default
            LimpiarDataGridView() ' Limpiar la grilla AL FINAL del proceso
            txbArchivo.Text = "" ' Limpiar el textbox del archivo
            ' Nota: No limpiamos la lista de errores aquí, ya se mostró si era necesario
        End Try
    End Sub

    Private Sub MostrarErrores(articulosConError As List(Of String))
        ' Crear un mensaje más detallado y potencialmente mostrarlo en un TextBox multilínea si son muchos errores
        Dim mensajeError As New System.Text.StringBuilder()
        mensajeError.AppendLine("Se encontraron los siguientes problemas durante la actualización:")
        mensajeError.AppendLine("---------------------------------------------------------")
        For Each err As String In articulosConError
            mensajeError.AppendLine(err)
        Next
        mensajeError.AppendLine("---------------------------------------------------------")
        mensajeError.AppendLine("Revise los códigos de artículo y los mensajes de error para corregirlos.")

        ' Para muchos errores, un MessageBox no es ideal. Considera un formulario nuevo o un TextBox.
        ' Por simplicidad, se usa MessageBox aquí, pero ten cuidado con la longitud del mensaje.
        If mensajeError.Length > 1000 Then ' Aproximado
            ' Podrías escribir los errores a un archivo de log o mostrarlos en un control diferente
            MessageBox.Show("Se encontraron demasiados errores para mostrar en este cuadro. Revise el log o la consola.", "Múltiples Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Console.WriteLine(mensajeError.ToString()) ' Escribir a la salida de depuración/consola
        Else
            MessageBox.Show(mensajeError.ToString(), "Errores de Procesamiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub LimpiarDataGridView()
        ' La forma más segura de limpiar un DataGridView enlazado a datos es limpiar la fuente
        DGVDatos.DataSource = Nothing
        ' Opcionalmente, si usaste un DataTable y quieres mantenerlo pero vacío:
        ' Dim dt As DataTable = TryCast(DGVDatos.DataSource, DataTable)
        ' If dt IsNot Nothing Then
        '    dt.Rows.Clear()
        ' End If
        ' DGVDatos.Rows.Clear() ' Evitar si está enlazado a DataSource
        DGVDatos.Columns.Clear() ' Limpia también las columnas
        DGVDatos.Refresh()
    End Sub

End Class