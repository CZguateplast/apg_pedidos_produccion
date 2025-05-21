Imports System.Data
Imports System.IO

Public Class FrmCargaMasivaDatosProduccion
    Private Sub FrmCargaMasivaDatosProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TbxRutaDelArchivo.Enabled = False ' Deshabilita el TextBox
        DGVListado.ReadOnly = True
    End Sub

    Private Sub btnSubirArchivo_Click(sender As Object, e As EventArgs) Handles btnSubirArchivo.Click
        Using ofd As OpenFileDialog = New OpenFileDialog()
            ' Configuración de ofd
            ofd.Filter = "Archivos CSV (*.csv)|*.csv"
            ofd.Title = "Seleccionar archivo .csv"
            ofd.Multiselect = False

            If ofd.ShowDialog() = DialogResult.OK Then
                ' Obtener la ruta del archivo
                Dim rutaArchivo As String = ofd.FileName

                ' Modificamos los valores del Txtbox
                TbxRutaDelArchivo.Text = rutaArchivo
                TbxRutaDelArchivo.Enabled = False ' Deshabilita el TextBox
                btnSubirArchivo.Enabled = False 'Deshabilita el Boton

                If Path.GetExtension(rutaArchivo).ToLower() = ".csv" Then
                    ' Llenar el DataGripView con los datos del archivo
                    LlenarDataGridViewConCSV(rutaArchivo, DGVListado)
                Else
                    MessageBox.Show("Por favor seleccione un archivo con extensión .csv.")
                End If
            End If
        End Using
    End Sub

    'Funcion para llenar un DataGripView con un archivo .csv
    'El cual toma la primera linea como los encabezados de DataGripView
    'La segunda linea son los datos
    Public Sub LlenarDataGridViewConCSV(rutaCSV As String, dgv As DataGridView)
        Try
            ' Limpiar contenido previo
            dgv.Columns.Clear()
            dgv.Rows.Clear()

            ' Leer todas las líneas del CSV
            Dim lineas As String() = System.IO.File.ReadAllLines(rutaCSV)

            ' Definir las cabeceras requeridas (exactas)
            Dim requiredHeaders As String() = {
            "Codigo",
            "Descripcion",
            "Ciclo Hora",
            "Peso Unitario Gramos",
            "Material1",
            "Material1Porc",
            "Material2",
            "Material2Porc",
            "Molde",
            "Maquina"
        }

            If lineas.Length > 0 Then
                ' 1) Tomar la primera línea para los encabezados, separando por comas
                Dim encabezados As String() = lineas(0).Split(","c)

                ' Limpieza de espacios a cada encabezado
                For i As Integer = 0 To encabezados.Length - 1
                    encabezados(i) = encabezados(i).Trim()
                Next

                ' 2) Validar que la primera línea contenga al menos las columnas requeridas
                For Each colObligatoria In requiredHeaders
                    If Not encabezados.Contains(colObligatoria) Then
                        MessageBox.Show("El archivo CSV no contiene la columna requerida: " & colObligatoria,
                                    "Error de validación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                ' (Opcional) Validar que NO haya columnas de más o exigir un orden específico
                ' Por ejemplo, si quieres EXACTAMENTE esas 10 columnas y en el mismo orden:
                '
                'If encabezados.Length <> requiredHeaders.Length Then
                '    MessageBox.Show("El archivo CSV no tiene exactamente las 10 columnas requeridas.")
                '    Exit Sub
                'End If

                For i As Integer = 0 To requiredHeaders.Length - 1
                    If encabezados(i) <> requiredHeaders(i) Then
                        MessageBox.Show("El archivo CSV no respeta el orden exacto de columnas requeridas.")
                        Limpiar()
                        Exit Sub
                    End If
                Next

                ' 3) Crear columnas en el DataGridView
                Dim columnasValidas As New List(Of Integer)

                For i As Integer = 0 To encabezados.Length - 1
                    If Not String.IsNullOrWhiteSpace(encabezados(i)) Then
                        dgv.Columns.Add(encabezados(i), encabezados(i))
                        columnasValidas.Add(i)
                    End If
                Next

                ' 4) Cargar las filas (a partir de la segunda línea)
                For i As Integer = 1 To lineas.Length - 1
                    Dim valores As String() = lineas(i).Split(","c)
                    dgv.Rows.Add(valores)
                Next
            End If

            ' Mostrar cuántas filas se cargaron (menos la de encabezados, si procede)
            lblCantProcesada.Text = dgv.Rows.Count.ToString()

        Catch ex As Exception
            MessageBox.Show("Error al cargar CSV: " & ex.Message)
        End Try
    End Sub


    'Limpiar el DataGripView, Textbox, 
    Public Sub Limpiar()
        'Limpiar DataGripView
        DGVListado.Rows.Clear()
        DGVListado.Columns.Clear()

        'Limpiar Ruta
        TbxRutaDelArchivo.Text = ""
        btnSubirArchivo.Enabled = True

        'Uncheck
        CbAceptar.Checked = False

        'Limpiar lblCantProcesada
        lblCantProcesada.Text = ""

        'Reiniciar el progressbar
        PBCargaMasiva.Value = 0
    End Sub

    Private Sub BtnProcesar_Click(sender As Object, e As EventArgs) Handles BtnProcesar.Click

        '1. Validar que CbAceptar sea true
        If (CbAceptar.CheckState = CheckState.Unchecked) Then
            MessageBox.Show("Debe de Aprobar la Actualizacion de Parametros.")
            Exit Sub
        End If

        '2. Validar que DGVListado no Sea nulo
        If DGVListado Is Nothing Then
            MessageBox.Show("Archivo Invalido")
            Exit Sub
        End If

        '3. Validar que DGVListado tenga registros
        If (DGVListado.Rows.Count = 0) Then
            MessageBox.Show("Sin Registros para Actualizar")
            Limpiar()
            Exit Sub
        End If

        ' --- CONFIGURAR PROGRESSBAR ---
        ' Ponemos el mínimo en 0 y el máximo en la cantidad de filas reales.
        ' Si AllowUserToAddRows es True, la última fila podría ser la "nueva fila",
        ' conviene restarle 1 si no quieres contar esa fila fantasma.
        PBCargaMasiva.Minimum = 0
        PBCargaMasiva.Maximum = DGVListado.Rows.Count
        PBCargaMasiva.Value = 0

        ' --- RECORRER CADA FILA ---
        ' Usamos un bucle "For i" para llevar la cuenta exacta del índice
        For i As Integer = 0 To DGVListado.Rows.Count - 1

            Dim fila As DataGridViewRow = DGVListado.Rows(i)

            ' (Opcional) Ignorar si es la fila "nueva" (fila vacía adicional).
            If fila.IsNewRow Then
                Continue For
            End If

            'Contar cuantas dieron error
            Dim valor1 As Integer = 0
            Dim valor2 As Integer = 0
            Dim valor3 As Integer = 0

            ' --- Valores por fila ---
            Dim CodigoArticulo As Object = fila.Cells(0).Value
            Dim Descripcion As Object = fila.Cells(1).Value
            Dim Ciclo_Hora As Object = fila.Cells(2).Value
            Dim Peso_Unitario_Gramos As Object = fila.Cells(3).Value
            Dim Material1 As Object = fila.Cells(4).Value
            Dim Material1Porc As Object = fila.Cells(5).Value
            Dim Material2 As Object = fila.Cells(6).Value
            Dim Material2Porc As Object = fila.Cells(7).Value
            Dim Molde As Object = fila.Cells(8).Value
            Dim Maquina As Object = fila.Cells(9).Value

            ' --- Obtener Parametros por articulo (ejemplo) ---
            Dim ParametosArticulo As DataTable = mStoreProcedure.GetMoldesProduccionParametros(CodigoArticulo)

            '6. Actualizar la asignacion de maquina y molde
            Dim Prioridad As Integer = mStoreProcedure.Prioridad_Mas_Alta_PROD_ComponentesMaquinas(CodigoArticulo) + 1
            Dim validar3 As Boolean = mFunciones.SET_ComponentesMaquinas(CodigoArticulo, Maquina, Prioridad)
            If Not (validar3) Then
                mMensajes.msg_Error("Error: ¡Maquina solo se puede asignar una vez!" + "    No. De Linea: " + (i + 1).ToString)
                'Exit Sub
                valor3 += valor3
                lblMolde.Text = valor3
            End If

            '4. Actualizar parametros de produccion
            Dim validar1 As Boolean = mFunciones.UPDATE_ProduccionParametros(CodigoArticulo, Peso_Unitario_Gramos, ParametosArticulo.Rows(0)(9), Ciclo_Hora)
            If Not (validar1) Then
                'MessageBox.Show("Actualizar parametros de produccion")
                'Exit Sub
                valor1 += valor1
                lblParametros.Text = valor1
            End If

            '5. Actualizar los CP Materiales
            Dim validar2 As Boolean = mFunciones.UPDATE_CodigosProducidos(CodigoArticulo, Descripcion, Material1, Material1Porc, Material2, Material2Porc, Molde)
            If Not (validar2) Then
                'MessageBox.Show("Actualizar los CP Materiales")
                'Exit Sub
                valor2 += valor2
                lblMateriales.Text = valor2
            End If

            '6. Actualizar la asignacion de maquina y molde
            'Dim Prioridad As Integer = mStoreProcedure.Prioridad_Mas_Alta_PROD_ComponentesMaquinas(CodigoArticulo) + 1
            'Dim validar3 As Boolean = mFunciones.SET_ComponentesMaquinas(CodigoArticulo, Maquina, Prioridad)
            'If Not (validar3) Then
            '    'MessageBox.Show("Actualizar los CP Materiales")
            '    'Exit Sub
            '    valor3 += valor3
            '    lblMolde.Text = valor3
            'End If

            ' --- ACTUALIZAR PROGRESO ---
            ' a) Actualizas el valor del ProgressBar
            PBCargaMasiva.Value = i + 1   ' (i inicia en 0, así que +1 para que se vea 1/..., 2/..., etc.)

            ' b) Actualizas el Label con el progreso
            lblCantProcesada.Text = $"{i + 1}/{DGVListado.Rows.Count}"

            ' (Opcional) Forzar la actualización inmediata del UI
            ' Application.DoEvents() 
        Next

        MessageBox.Show("Proceso completado")
        Limpiar()
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

    Private Sub BtnDescargarF_Click(sender As Object, e As EventArgs) Handles BtnDescargarF.Click
        ' Crear el cuadro de diálogo para guardar archivos
        Dim sfd As New SaveFileDialog()
        sfd.Title = "Guardar archivo CSV"
        sfd.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
        sfd.FileName = "CargaMasivaParametros.csv"  ' Nombre sugerido

        ' Mostrar el cuadro de diálogo y, si el usuario confirma, escribir el CSV
        If sfd.ShowDialog() = DialogResult.OK Then
            ' Ruta seleccionada
            Dim rutaArchivo As String = sfd.FileName

            ' Encabezados requeridos
            Dim encabezados As String = "Codigo,Descripcion,Ciclo Hora,Peso Unitario Gramos,Material1,Material1Porc,Material2,Material2Porc,Molde,Maquina"

            ' Escribirlos en el archivo
            System.IO.File.WriteAllText(rutaArchivo, encabezados)

            MessageBox.Show("Archivo CSV creado con éxito.", "Descarga completada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class