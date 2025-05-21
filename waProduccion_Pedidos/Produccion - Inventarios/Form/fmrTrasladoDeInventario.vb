Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports DevExpress.XtraSplashScreen
Imports System.Data
Public Class fmrTrasladoDeInventario
    'Instancias Globales
    Private toolTip As New ToolTip()
    Dim dvDatos As New DataView
    Dim source1 As New BindingSource()
    Private Sub fmrTrasladoDeInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataTable de Bodega Destino
        Dim dtBodegas As Data.DataTable = Nothing

        'Asignar a un boton btExcel
        toolTip.SetToolTip(btnExcel, "Exportar a Excel")
        'Asignar a un boton Iniciar Traslado
        toolTip.SetToolTip(btnSAP, "Iniciar traslados")

        'Cargar Dropdownlist Bodega Destino
        Try
            dtBodegas = GetAlmacenes()

            If dtBodegas IsNot Nothing Then
                For Each pRow As DataRow In dtBodegas.Rows
                    If pRow("whscode").ToString() <> "*" Then
                        'Llena el Listado de bodegas disponibles para definir prioridad
                        lstAvailableWarehouses.Items.Add(pRow("whscode"))

                        'Llena el combo de bodega destino
                        cboBodegaDestino.Items.Add(pRow("whscode"))
                    End If
                Next
            Else
                MessageBox.Show("No se encontraron datos de almacenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar bodegas: " & ex.Message)
        Finally
            If dtBodegas IsNot Nothing Then
                dtBodegas.Dispose()
            End If
        End Try

        'Cargar Dropdownlist Lista de Precios
        cboListaPrecios.SelectedIndex = 0

        'Habilitar solo saldos negativos
        chkVerNegativos.Checked = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            If Not IsNothing(Me.lstAvailableWarehouses.SelectedItem) Then
                Me.lstSelectedWarehouses.Items.Add(Me.lstAvailableWarehouses.SelectedItem) 'Destino
                Me.lstAvailableWarehouses.Items.Remove(Me.lstAvailableWarehouses.SelectedItem) 'Origen

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUnselect_Click(sender As Object, e As EventArgs) Handles btnUnselect.Click
        Try
            If Not IsNothing(Me.lstSelectedWarehouses.SelectedItem) Then
                Me.lstAvailableWarehouses.Items.Add(Me.lstSelectedWarehouses.SelectedItem) 'Destino
                Me.lstSelectedWarehouses.Items.Remove(Me.lstSelectedWarehouses.SelectedItem) 'Origen
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkSeleccionarTodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionarTodo.CheckedChanged
        On Error Resume Next
        Cursor = Cursors.WaitCursor
        For i = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(i).Cells("seleccionar").Value = chkSeleccionarTodo.Checked
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub btnAnalizar_Click(sender As Object, e As EventArgs) Handles btnAnalizar.Click
        Dim dtDatos As Data.DataTable
        Try
            Dim pResult As String = ""

            If Me.lstSelectedWarehouses.Items.Count = 0 Then
                MessageBox.Show("Debe seleccionar alguna bodega (Prioridad) de donde Sacará los productos")
                Me.lstAvailableWarehouses.Focus()
            ElseIf IsNothing(cboBodegaDestino.SelectedItem) Then
                MessageBox.Show("Debe seleccionar la bodega destino")
                Me.cboBodegaDestino.Focus()
            ElseIf Not ValidarBodegas() Then
                MessageBox.Show("La bodega DESTINO no puede se parte de las bodegas de donde se sacarán los productos (Prioridad)")
                Me.cboBodegaDestino.Focus()
            End If

            Cursor = Cursors.WaitCursor

            'crea el array de bodegas origen
            Dim x As System.Windows.Forms.ListBox.ObjectCollection
            Dim arrBodegasOrigen(lstSelectedWarehouses.Items.Count - 1) As String
            lstSelectedWarehouses.Items.CopyTo(arrBodegasOrigen, 0)
            dtDatos = GetAnalisisTrasladoBodegas(cboBodegaDestino.SelectedItem, arrBodegasOrigen, chkVerNegativos.Checked, pResult)

            AddUnboundColumn(dtDatos)

            DataGridView1.Columns.Clear()

            dvDatos = New DataView(dtDatos)
            source1 = New BindingSource

            source1.DataSource = dvDatos
            DataGridView1.DataSource = source1

            If IsNothing(dtDatos) Then
                MessageBox.Show("No hay productos en esta bodega")
            ElseIf dtDatos.Rows.Count = 0 Then
                MessageBox.Show("No hay productos en esta bodega")
            End If

            ConfigureGrid()
            Me.chkSeleccionarTodo.Checked = False

            Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ValidarBodegas() As Boolean
        Try
            For Each itemSelectedBodega In lstSelectedWarehouses.Items
                If itemSelectedBodega.ToString() = cboBodegaDestino.SelectedItem.ToString Then Return False
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub AddUnboundColumn(ByRef pDTDatos As Data.DataTable)
        Try

            Dim col As DataColumn
            Dim sumatoria As String = ""
            Dim expresion As String = ""

            If pDTDatos IsNot Nothing AndAlso pDTDatos.Columns IsNot Nothing AndAlso pDTDatos.Columns.Count > 0 Then
                For Each col In pDTDatos.Columns
                    If col.ColumnName.ToLower.Contains("sacar") Then
                        If sumatoria.Length > 0 Then sumatoria += " + "
                        sumatoria += "[" + col.ColumnName + "]"
                    End If
                Next
                expresion = "IIF([A Pedir] >= (" + sumatoria + "), [A Pedir] - (" + sumatoria + "), 0)"
                pDTDatos.Columns.Add("Pendiente", GetType(System.Decimal), expresion)

                pDTDatos.Columns.Add("seleccionar", GetType(System.Boolean))
            Else
                Throw New System.Exception("Error: Sin Datos")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConfigureGrid()

        DataGridView1.AllowUserToAddRows = False

        For Each xcolumn As DataGridViewColumn In Me.DataGridView1.Columns

            If xcolumn.Name.ToLower.Contains("sacar") Then

                xcolumn.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
                xcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                xcolumn.Width = 80

            Else

                If xcolumn.Name.ToLower.Contains("pendiente") Then
                    xcolumn.Width = 80
                    xcolumn.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                    xcolumn.DefaultCellStyle.ForeColor = Color.Maroon
                    xcolumn.DefaultCellStyle.Format = String.Format("#")
                    xcolumn.ReadOnly = True
                ElseIf xcolumn.Name.ToLower.Contains("seleccionar") Then
                    xcolumn.ReadOnly = False
                ElseIf xcolumn.Name.ToLower.Contains("nada") Then
                    xcolumn.Visible = False
                    xcolumn.ReadOnly = True
                End If


                If xcolumn.ValueType.ToString.ToLower.Contains("string") Then
                    xcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf xcolumn.ValueType.ToString.ToLower.Contains("decimal") Then
                    xcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Else
                    xcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If xcolumn.Name.ToLower.Contains("producto") Then
                    xcolumn.Frozen = True
                    xcolumn.Width = 110
                ElseIf xcolumn.Name.ToLower.Contains("descripcion") Then
                    xcolumn.Frozen = True
                    xcolumn.Width = 300
                ElseIf xcolumn.Name.ToLower.Contains("pedir") Then
                    xcolumn.Width = 80
                    xcolumn.DefaultCellStyle.ForeColor = Color.Blue
                Else
                    xcolumn.Width = 80
                End If

            End If

        Next

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim ssmSperar As SplashScreenManager = Nothing
        Dim excelApp As Application = Nothing
        Dim workBook As Workbook = Nothing
        Dim workSheet As Worksheet = Nothing

        Try
            ' Pregunta si el usuario desea exportar a Excel
            If MsgBox("Desea exportar a Excel?", MsgBoxStyle.YesNo, "Exportar") = MsgBoxResult.No Then
                Exit Sub
            End If

            ' Valida que el SplashScreenManager esté instanciado antes de usarlo
            If ssmSperar Is Nothing Then
                ssmSperar = New SplashScreenManager(Me, GetType(splEsperar), True, True)
            End If

            ' Mostrar el formulario de espera si no está visible
            If Not ssmSperar.IsSplashFormVisible() Then
                ssmSperar.ShowWaitForm()
            End If

            ' Configurar el mensaje del formulario de espera
            ssmSperar.SetWaitFormCaption("Exportando a Excel...")
            ssmSperar.SetWaitFormDescription("Por favor, espere...")

            ' Crear un SaveFileDialog para permitir al usuario elegir dónde guardar el archivo
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Excel Files|*.xlsx"
                sfd.Title = "Guardar archivo Excel"
                sfd.FileName = "Exportacion.xlsx"

                If sfd.ShowDialog() = DialogResult.OK Then
                    ' Crear una instancia de la aplicación Excel
                    excelApp = New Application()
                    workBook = excelApp.Workbooks.Add()
                    workSheet = CType(workBook.Sheets(1), Worksheet)

                    ' Configurar la hoja de trabajo
                    Dim currentRow As Integer = 1
                    Dim currentColumn As Integer = 1

                    ' Agregar los encabezados (excepto la columna "seleccionar")
                    For Each col As DataGridViewColumn In DataGridView1.Columns
                        If col.HeaderText.ToLower() <> "seleccionar" Then
                            workSheet.Cells(currentRow, currentColumn).Value = col.HeaderText
                            currentColumn += 1
                        End If
                    Next

                    ' Agregar los datos (excepto la columna "seleccionar")
                    currentRow = 2
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            currentColumn = 1
                            For Each col As DataGridViewColumn In DataGridView1.Columns
                                If col.HeaderText.ToLower() <> "seleccionar" Then
                                    workSheet.Cells(currentRow, currentColumn).Value = row.Cells(col.Index).Value
                                    currentColumn += 1
                                End If
                            Next
                            currentRow += 1
                        End If
                    Next

                    ' Ajustar el ancho de las columnas
                    workSheet.Columns.AutoFit()

                    ' Guardar el archivo en la ubicación seleccionada por el usuario
                    workBook.SaveAs(sfd.FileName)
                    MessageBox.Show("Exportación completada exitosamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' Manejo de errores, cerrando el formulario de espera si está visible
            If ssmSperar IsNot Nothing AndAlso ssmSperar.IsSplashFormVisible() Then
                ssmSperar.CloseWaitForm()
            End If
            mMensajes.msg_Error(ex.Message)
        Finally
            ' Asegurarse de cerrar los recursos de Excel y el formulario de espera
            If workBook IsNot Nothing Then
                workBook.Close(False)
                Marshal.ReleaseComObject(workBook)
            End If
            If excelApp IsNot Nothing Then
                excelApp.Quit()
                Marshal.ReleaseComObject(excelApp)
            End If
            If ssmSperar IsNot Nothing AndAlso ssmSperar.IsSplashFormVisible() Then
                ssmSperar.CloseWaitForm()
            End If
        End Try
    End Sub

    Private Sub btnTransAnteriores_Click(sender As Object, e As EventArgs) Handles btnTransAnteriores.Click
        If lstSelectedWarehouses.Items.Count > 0 AndAlso cboBodegaDestino.SelectedItem IsNot Nothing Then
            ' Obtener las bodegas seleccionadas
            Dim bodegaOrigen As New List(Of String)
            For Each item In lstSelectedWarehouses.Items
                bodegaOrigen.Add(item.ToString())
            Next

            ' Obtener la bodega destino
            Dim bodegaDestino As String = cboBodegaDestino.SelectedItem.ToString()

            ' Obtener las transacciones anteriores llamando a la función
            Dim transacciones As Data.DataTable = GetTransaccionesAnteriores(bodegaDestino, bodegaOrigen)

            ' Crear una instancia del formulario y asignar el DataTable
            Dim frm As New frmConsultaTransferenciasBodega()
            frm.Transacciones = transacciones

            ' Mostrar el formulario
            frm.ShowDialog()
        Else
            MessageBox.Show("Para poder ver Transacciones Anteriores debe de seleccionar una Bodega de Destino y Prioridad")
            Me.cboBodegaDestino.Focus()
            Me.lstSelectedWarehouses.Focus()
        End If
    End Sub

    Private Sub btnSAP_Click(sender As Object, e As EventArgs) Handles btnSAP.Click

    End Sub
End Class