Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Module mFunciones
    Public Function FCN_AgregarComillas(ByVal pPalabra As String) As String
        Try
            pPalabra = "'" + pPalabra + "'"
            Return pPalabra
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Sub FCN_FILL_LookUpEdit(ByVal pLookUpEdit As DevExpress.XtraEditors.LookUpEdit, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try
            pLookUpEdit.Properties.DataSource = pDT
            pLookUpEdit.Properties.ValueMember = pValue
            pLookUpEdit.Properties.DisplayMember = pDisplay
            pLookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pLookUpEdit.Properties.PopupSizeable = False
            pLookUpEdit.Properties.ShowFooter = False
            pLookUpEdit.Properties.NullText = String.Empty
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Public Sub FCN_FILL_SearchLookUpEdit(ByVal pSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try

            pSearchLookUpEdit.Properties.DataSource = pDT
            pSearchLookUpEdit.Properties.ValueMember = pValue
            pSearchLookUpEdit.Properties.DisplayMember = pDisplay
            pSearchLookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pSearchLookUpEdit.Properties.PopupSizeable = False
            pSearchLookUpEdit.Properties.ShowFooter = False
            pSearchLookUpEdit.Properties.NullText = String.Empty
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Public Sub FCN_FILL_SearchLookUpEdit(ByVal pSearchLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try

            pSearchLookUpEdit.DataSource = pDT
            pSearchLookUpEdit.ValueMember = pValue
            pSearchLookUpEdit.DisplayMember = pDisplay
            pSearchLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup
            pSearchLookUpEdit.PopupSizeable = False
            pSearchLookUpEdit.ShowFooter = False
            pSearchLookUpEdit.NullText = String.Empty
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Public Sub FCN_FILL_LookUpEdit(ByVal pLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try
            pLookUpEdit.DataSource = pDT
            pLookUpEdit.ValueMember = pValue
            pLookUpEdit.DisplayMember = pDisplay
            pLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup
            pLookUpEdit.PopupSizeable = False
            pLookUpEdit.ShowFooter = False
            pLookUpEdit.NullText = String.Empty

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FCN_FILL_ComboBox(ByVal pLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemComboBox, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try
            pLookUpEdit.Items.Clear()
            For i = 0 To pDT.Rows.Count - 1
                pLookUpEdit.Items.Add(pDT.Rows(i)(pDisplay).ToString)
            Next


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_FILL_ComboBoxEdit(ByVal pLookUpEdit As DevExpress.XtraEditors.ComboBoxEdit, ByVal pDT As DataTable, ByVal pValue As String, ByVal pDisplay As String)
        Try
            pLookUpEdit.Properties.Items.Clear()
            For i = 0 To pDT.Rows.Count - 1
                pLookUpEdit.Properties.Items.Add(pDT.Rows(i)(pDisplay).ToString)
            Next


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Public Sub FCN_XTRAGRID_EliminarFilasSeleccionadas(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If pGridView.SelectedRowsCount = 0 Then
                MsgBox("No puede eliminar la fila seleccionada", vbOKOnly, "Eliminar...")
            Else
                If MsgBox("Desea eliminar la(s) fila(s) seleccionada?", vbYesNo, "Eliminar...") = MsgBoxResult.Yes Then
                    pGridView.DeleteSelectedRows()
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_EliminarFilasSeleccionadas(ByVal pGridView As DevExpress.XtraGrid.Views.Tile.TileView)
        Try
            If pGridView.SelectedRowsCount = 0 Then
                MsgBox("No puede eliminar la fila seleccionada", vbOKOnly, "Eliminar...")
            Else
                If MsgBox("Desea eliminar la(s) fila(s) seleccionada?", vbYesNo, "Eliminar...") = MsgBoxResult.Yes Then
                    pGridView.DeleteSelectedRows()
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Public Sub FCN_BarButtonItem_Enabled(ByVal pControl As DevExpress.XtraBars.BarButtonItem)
        Try
            Dim pStatus As Boolean = pControl.Enabled

            Select Case [pStatus]
                Case True
                    pControl.Enabled = False
                Case False
                    pControl.Enabled = True
            End Select

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FCN_GridControl_Enabled(ByVal pControl As DevExpress.XtraGrid.GridControl)
        Try
            Dim pStatus As Boolean = pControl.Enabled

            Select Case [pStatus]
                Case True
                    pControl.Enabled = False
                Case False
                    pControl.Enabled = True
            End Select

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FCN_VerticalGridRow_Enabled(ByVal pRow As DevExpress.XtraVerticalGrid.Rows.EditorRow)
        Try
            Dim pStatus As Boolean = pRow.Enabled

            Select Case [pStatus]
                Case True
                    pRow.Enabled = False
                Case False
                    pRow.Enabled = True
            End Select

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Public Function ConvertirFecha(ByVal pControl As Object) As String

        Dim DIA As Integer = pControl.DateTime.Day
        Dim MES As Integer = pControl.DateTime.Month
        Dim AÑO As Integer = pControl.DateTime.Year
        Dim FECHA As String = DIA.ToString + "/" + MES.ToString + "/" + AÑO.ToString

        Return FECHA
    End Function
    Public Function ConvertirFechaSQL(ByVal pControl As Object) As String

        Dim DIA As Integer = pControl.DateTime.Day
        Dim MES As Integer = pControl.DateTime.Month
        Dim AÑO As Integer = pControl.DateTime.Year
        Dim FECHA As String = AÑO.ToString + "-" + MES.ToString + "-" + DIA.ToString

        Return FECHA
    End Function


    Public Function GetFecha_Ano(ByVal pControl As Object) As String

        Dim AÑO As Integer = pControl.DateTime.Year

        Return AÑO
    End Function
    'Public Sub LimpiarControles_TXT(ByVal pForm As Control)
    '    For Each ctrl As Control In pForm.Controls
    '        LimpiarControles_TXT(ctrl)
    '        If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
    '            CType(ctrl, DevExpress.XtraEditors.TextEdit).Text = String.Empty
    '        End If
    '    Next ctrl
    'End Sub

    Public Function ValidarCaracteresEspeciales(e As KeyPressEventArgs) As Boolean
        Try

            Select Case e.KeyChar
                Case Is = "'"
                    msg_Validacion_CaracteresEspeciales(e.KeyChar.ToString)
                    Return False
                Case Is = """"
                    msg_Validacion_CaracteresEspeciales(e.KeyChar.ToString)
                    Return False
                Case Is = "("
                    msg_Validacion_CaracteresEspeciales(e.KeyChar.ToString)
                    Return False
                Case Is = ")"
                    msg_Validacion_CaracteresEspeciales(e.KeyChar.ToString)
                    Return False
            End Select

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Public Function ValidarNumeros_NO(e As KeyPressEventArgs) As Boolean
        Try

            Select Case e.KeyChar
                Case Is = Keys.Back.ToString
                    Return True
                Case Is = "0"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "1"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "2"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "3"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "4"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "5"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "6"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "7"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "8"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
                Case Is = "9"
                    msg_Validacion_Numeros_NO(e.KeyChar.ToString)
                    Return False
            End Select

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function ValidarNumeros_SI(e As KeyPressEventArgs) As Boolean
        Try
            
            If Char.IsNumber(e.KeyChar) Then
                Return True
            End If

            mMensajes.msg_Validacion_Numeros_SI()
            Return False

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function




    Public Function FCN_XTRAGRID_GetFilasSeleccionadas(ByVal pGridView As Object) As ArrayList
        Try
            Dim Rows As New ArrayList()

            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next
            Return Rows

        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function

    Public Function FCN_XTRAGRID_GetColumn_DataTable(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pColumn As String) As DataTable
        Try
            Dim dt As New DataTable()
            Dim pColumns As New DataColumn
            pColumns = New DataColumn(pColumn, Type.GetType("System.String"))
            dt.Columns.Add(pColumn)

            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Dim pList As New ArrayList()
                    Dim R As DataRow = dt.NewRow
                    pList.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                    R(pColumn) = pList(0)(pColumn)

                    dt.Rows.Add(R)
                End If
            Next
            Return dt

        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function





    Public Function FCN_XTRAGRID_GetFilas(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView) As ArrayList
        Try
            Dim Rows As New ArrayList()

            For i = 0 To pGridView.RowCount - 1
                Rows.Add(pGridView.GetDataRow(i))
            Next
            Return Rows

        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function

    
    Public Function FCN_GET_Columna(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            For i = 0 To pGridView.RowCount - 1
                Rows.Add(pGridView.GetDataRow(i))
            Next

            Dim pLista As String = String.Empty ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = "'" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + "'"
                    Else
                        pLista += ",'" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + "'"
                    End If
                Next
                Return pLista
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function
    Public Function FCN_GET_Columna(ByVal pDt As DataTable, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            
            Dim pLista As String = String.Empty
            For I = 0 To pDt.Rows.Count - 1
                If I = 0 Then
                    pLista = "'" + LTrim(RTrim(pDt.Rows(I)(pColumna).ToString)) + "'"
                Else
                    pLista += ",'" + LTrim(RTrim(pDt.Rows(I)(pColumna).ToString)) + "'"
                End If
            Next
            Return pLista

        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function



    Public Function FCN_XTRAGRID_GetFilasSeleccionadas(ByVal pGridView As Object, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next


            Dim pLista As String = String.Empty ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = "'" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + "'"
                    Else
                        pLista += ",'" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + "'"
                    End If
                Next
                Return pLista
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function
    Public Function FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(ByVal pGridView As Object, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next


            Dim pLista As String = String.Empty ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = "" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + ""
                    Else
                        pLista += "," + LTrim(RTrim(Rows(I)(pColumna).ToString)) + ""
                    End If
                Next
                Return pLista
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function

    Public Function FCN_XTRAGRID_GetRowCellValue_Integer(ByVal pGridView As Object, ByVal pColumna As String) As Integer 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next


            Dim pLista As Integer = 0 ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = LTrim(RTrim(Rows(I)(pColumna)))
                    End If
                Next
                Return pLista
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function

    Public Function FCN_XTRAGRID_GetCodigoPadre(ByVal pGridView As Object, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next


            Dim pLista As String = String.Empty ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = "" + LTrim(RTrim(Rows(I)(pColumna).ToString)) + ""
                    Else
                        pLista += "," + LTrim(RTrim(Rows(I)(pColumna).ToString)) + ""
                    End If
                Next
                Return pLista.Substring(0, 8)
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function
    Public Function FCN_XTRAGRID_GetFilasSeleccionadas(ByVal pDataTable As DataTable, ByVal pColumna As String) As String 'Obtiene una lista especifica
        Try
            ' Create an empty list.
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer

            For I = 0 To pDataTable.Rows.Count - 1
                Rows.Add(pDataTable.Rows(I)(pColumna).ToString)
            Next

            Dim pLista As String = String.Empty ' ref =  'a','b','c','d'

            If Not Rows.Count = 0 Then
                For I = 0 To Rows.Count - 1
                    If I = 0 Then
                        pLista = "'" + Rows(I) + "'"
                    Else
                        pLista += ",'" + Rows(I) + "'"
                    End If
                Next
                Return pLista
            Else
                Return Nothing
            End If


        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function

    Public Function FCN_SEARCH_Articulos_XPadres(ByVal pArrayList As ArrayList) As String
        Try
            If pArrayList.Count = 0 Then
                Return Nothing
            Else
                Dim dt As New DataTable("dtListadoARH")
                Dim dtConcatenado As New DataTable("dtListadoARH")
                Dim pLista As String = String.Empty

                For i = 0 To pArrayList.Count - 1
                    If dtConcatenado.Rows.Count = 0 Then
                        dtConcatenado = mSQLSelect.GET_ArticulosRelacionados_XArticuloPadre(pArrayList(i)("CodigoArticulo").ToString)
                    Else
                        dt = mSQLSelect.GET_ArticulosRelacionados_XArticuloPadre(pArrayList(i)("CodigoArticulo").ToString)
                        dtConcatenado.Merge(dt)
                    End If
                Next
                If Not dtConcatenado.Rows.Count = 0 Then
                    For I = 0 To dtConcatenado.Rows.Count - 1
                        If I = 0 Then
                            pLista = "'" + dtConcatenado.Rows(I)(0).ToString + "'"
                        Else
                            pLista += ",'" + dtConcatenado.Rows(I)(0).ToString + "'"
                        End If
                    Next
                    Return pLista

                End If
            End If
            Return Nothing
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

#Region "Funciones Generales"
    Public Sub FCN_XTRAGRID_Buscar(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        If pGrid.OptionsFind.AlwaysVisible = False Then
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = True
        Else
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = False
        End If

    End Sub
    Public Sub FCN_XTRAGRID_Buscar(ByVal pGrid As DevExpress.XtraGrid.Views.Tile.TileView)
        If pGrid.OptionsFind.AlwaysVisible = False Then
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = True
        Else
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = False
        End If

    End Sub
    Public Sub FCN_XTRAGRID_Buscar(ByVal pGrid As DevExpress.XtraGrid.Views.Layout.LayoutView)
        If pGrid.OptionsFind.AlwaysVisible = False Then
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = True
        Else
            pGrid.ApplyFindFilter("")
            pGrid.OptionsFind.AlwaysVisible = False
        End If

    End Sub
    Public Sub FCN_XTRAGRID_Buscar(ByVal pGrid1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGrid2 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGrid3 As DevExpress.XtraGrid.Views.Grid.GridView)

        If pGrid1.IsFocusedView() Then
            If pGrid1.OptionsFind.AlwaysVisible = False Then
                pGrid1.ApplyFindFilter("")
                pGrid1.OptionsFind.AlwaysVisible = True
            Else
                pGrid1.ApplyFindFilter("")
                pGrid1.OptionsFind.AlwaysVisible = False
            End If
        End If
        
        If pGrid2.IsFocusedView() Then
            If pGrid2.OptionsFind.AlwaysVisible = False Then
                pGrid2.ApplyFindFilter("")
                pGrid2.OptionsFind.AlwaysVisible = True
            Else
                pGrid2.ApplyFindFilter("")
                pGrid2.OptionsFind.AlwaysVisible = False
            End If
        End If


        If pGrid3.IsFocusedView() Then
            If pGrid3.OptionsFind.AlwaysVisible = False Then
                pGrid3.ApplyFindFilter("")
                pGrid3.OptionsFind.AlwaysVisible = True
            Else
                pGrid3.ApplyFindFilter("")
                pGrid3.OptionsFind.AlwaysVisible = False
            End If
        End If

    End Sub





    Public Sub FCN_XTRAGRID_ImprimirGrid(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            pGridView1.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ImprimirGrid(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If pGridView1.IsFocusedView() Then
                pGridView1.ShowRibbonPrintPreview()
            ElseIf pGridView2.IsFocusedView() Then
                pGridView2.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ImprimirGrid(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Tile.TileView)
        Try
            If pGridView1.IsFocusedView() Then
                pGridView1.ShowRibbonPrintPreview()
            ElseIf pGridView2.IsFocusedView() Then
                pGridView2.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ImprimirGrid(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView3 As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If pGridView1.IsFocusedView() Then
                pGridView1.ShowRibbonPrintPreview()
            ElseIf pGridView2.IsFocusedView() Then
                pGridView2.ShowRibbonPrintPreview()
            ElseIf pGridView3.IsFocusedView() Then
                pGridView3.ShowRibbonPrintPreview()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FCN_XTRAGRID_ExportarExcel(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sfd As System.Windows.Forms.FileDialog)
        Try
            sfd.Filter = "Archivos Excel | *.xlsx"
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pGridView1.ExportToXlsx(sfd.FileName)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ExportarExcel(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sfd As System.Windows.Forms.FileDialog)
        Try
            If pGridView1.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView1.ExportToXlsx(sfd.FileName)
                End If
            ElseIf pGridView2.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView2.ExportToXlsx(sfd.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ExportarExcel(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Tile.TileView, ByVal sfd As System.Windows.Forms.FileDialog)
        Try
            If pGridView1.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView1.ExportToXlsx(sfd.FileName)
                End If
            ElseIf pGridView2.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView2.ExportToXlsx(sfd.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub FCN_XTRAGRID_ExportarExcel(ByVal pGridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView2 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pGridView3 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sfd As System.Windows.Forms.FileDialog)
        Try
            If pGridView1.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView1.ExportToXlsx(sfd.FileName)
                End If
            ElseIf pGridView2.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView2.ExportToXlsx(sfd.FileName)
                End If
            ElseIf pGridView3.IsFocusedView() Then
                sfd.Filter = "Archivos Excel | *.xlsx"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pGridView3.ExportToXlsx(sfd.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region


    Public Function ValidarBotones(ByVal pUsuario As String, ByVal pAplicacion As String, ByVal pOpcion As String) As Boolean

        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try

            qry = "SELECT A.IdUsuario,A.IdRol,B.IdAplicacion,B.IdPermiso,B.Estatus "
            qry += " FROM APGS.dbo.SeguridadRolesUsuarios A"
            qry += " LEFT JOIN APGS.dbo.SeguridadPermisosAplicaciones B ON B.IdRol = A.IdRol"
            qry += " WHERE a.IdUsuario = '" + pUsuario + "' and B.IdAplicacion = '" + pAplicacion + "' and B.IdPermiso = '" + pOpcion + "'"
            qry += " ORDER BY Estatus DESC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            If dt.Rows.Count = 0 Then
                Return True
            Else
                If dt.Rows(0)("Estatus").ToString = "True" Then
                    Return True
                Else
                    Return False
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function FCN_GetCellValue(ByVal pLayoutView As DevExpress.XtraGrid.Views.Layout.LayoutView, ByVal pColumn As String) As String
        Try
            Dim Resultado As String = pLayoutView.GetRowCellValue(pLayoutView.FocusedRowHandle, pColumn).ToString
            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Public Function FCN_GetCellValue(ByVal pTileView As DevExpress.XtraGrid.Views.Tile.TileView, ByVal pColumn As String) As String
        Try
            Dim Resultado As String = pTileView.GetRowCellValue(pTileView.FocusedRowHandle, pColumn).ToString
            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Public Function FCN_GetCellValue(ByVal pVerticalGrid As DevExpress.XtraVerticalGrid.VGridControl, ByVal pRow As String) As String
        Try
            Dim Resultado As String = pVerticalGrid.GetCellValue(pVerticalGrid.Rows.GetRowByFieldName(pRow), pVerticalGrid.FocusedRecord).ToString
            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Public Function FCN_GetCellValue(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pColumn As String) As String
        Try
            Dim Resultado As String = pGridView.GetRowCellValue(pGridView.FocusedRowHandle, pColumn).ToString
            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Public Function FCN_GetCellValue(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pColumn As String, ByVal pRowHandle As Integer) As String
        Try
            Dim Resultado As String = pGridView.GetRowCellValue(pRowHandle, pColumn).ToString
            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Public Function FCN_GetColumn(ByVal pGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pColumn As String) As String
        Try
            Dim Resultado As String = String.Empty
            For i = 0 To pGridView.RowCount - 1
                If i > 0 Then
                    Resultado = Resultado + ",'" + pGridView.GetRowCellValue(i, pColumn).ToString + "'"
                Else
                    Resultado = "'" + pGridView.GetRowCellValue(i, pColumn).ToString + "'"
                End If
            Next


            Return Resultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Public Function FCN_ValidarDisponiblidad_CP(ByVal pCodigoArticulo As String, ByVal pVentana As String) As Boolean
        Try

            Dim dt As New DataTable("dtListado")
            Dim dtOcupados As New DataTable("dtListadoOcupado")
            Dim dtResultado As New DataTable("dtResultado")
            Dim row As DataRow

            'DELETE Codigos de Articulos que esten congelados en la tabla
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", pVentana)

            dt = mSQLSelect.GET_Validacion_Disponibilidad_CP(pCodigoArticulo)
            dtOcupados = mSQLSelect.GET_Validacion_CP_OtrosUsuarios(My.Settings.log_Usuario.ToString)
            dtResultado = mSQLSelect.GET_Validacion_CP_Formato()

            If Not dt.Rows.Count = Nothing Then
                For i = 0 To dt.Rows.Count - 1
                    For j = 0 To dtOcupados.Rows.Count - 1
                        If dt.Rows(i)("CodigoArticulo").ToString = dtOcupados.Rows(j)("CodigoArticulo").ToString Then
                            row = dtOcupados.Rows(j)
                            dtResultado.Rows.Add(row.ItemArray)
                        End If
                    Next
                Next
            End If

            If Not dtResultado.Rows.Count = Nothing Then
                vpTabla1 = dtResultado
                frmTemporal_ArticulosOcupados.ShowDialog()
                Return False
            End If

            'Si no existe ningun articulo de los que se utilizaran en la base de datos de ocupados se puede proceder a hacer el insert de los codigos que se utilizaran
            '-------------------------------------------
            '-------------------------------------
            '--------------------------
            mSQLInsert.SET_ValidarDisponibilidad_Insertar("ProduccionPedidos", pVentana, dt)

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function FCN_ValidarDisponiblidad_CerrarOrdenes(ByVal pCodigoArticulo As String, ByVal pVentana As String) As Boolean
        Try

            Dim dt As New DataTable("dtListado")
            Dim dtOcupados As New DataTable("dtListadoOcupado")
            Dim dtResultado As New DataTable("dtResultado")
            Dim row As DataRow

            'DELETE Codigos de Articulos que esten congelados en la tabla
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", pVentana, pCodigoArticulo)

            dt = mSQLSelect.GET_Validacion_Disponibilidad_CP(pCodigoArticulo)
            dtOcupados = mSQLSelect.GET_Validacion_CP_OtrosUsuarios(My.Settings.log_Usuario.ToString)
            dtResultado = mSQLSelect.GET_Validacion_CP_Formato()

            If Not dt.Rows.Count = Nothing Then
                For i = 0 To dt.Rows.Count - 1
                    For j = 0 To dtOcupados.Rows.Count - 1
                        If dt.Rows(i)("CodigoArticulo").ToString = dtOcupados.Rows(j)("CodigoArticulo").ToString Then
                            row = dtOcupados.Rows(j)
                            dtResultado.Rows.Add(row.ItemArray)
                        End If
                    Next
                Next
            End If

            If Not dtResultado.Rows.Count = Nothing Then
                vpTabla1 = dtResultado
                frmTemporal_ArticulosOcupados.ShowDialog()
                Return False
            End If

            'Si no existe ningun articulo de los que se utilizaran en la base de datos de ocupados se puede proceder a hacer el insert de los codigos que se utilizaran
            '-------------------------------------------
            '-------------------------------------
            '--------------------------
            mSQLInsert.SET_ValidarDisponibilidad_Insertar("ProduccionPedidos", pVentana, dt)

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function FCN_UPC(ByVal pNumero As String) As String
        Try
            Dim pUPC As String = String.Empty
            Dim pCodeBars As String = String.Empty
            Dim pImpares As Integer = 0
            Dim pPares As Integer = 0
            Dim pSuma As Integer = 0
            Dim pDivision As Integer = 0
            Dim pDecenaProx As Integer = 0
            Dim pCodigoVerificador As Integer = 0
            Dim pTotal As String

            pUPC = LTrim(pNumero.PadLeft(5, "0"))

            pCodeBars = "018595" + pUPC

            If Len(pCodeBars) = 11 Then
                'Paso 1 Sumar posiciones Impares
                pImpares = Val(pCodeBars.ToString.Substring(0, 1)) + _
                    Val(pCodeBars.ToString.Substring(2, 1)) + _
                    Val(pCodeBars.ToString.Substring(4, 1)) + _
                    Val(pCodeBars.ToString.Substring(6, 1)) + _
                    Val(pCodeBars.ToString.Substring(8, 1)) + _
                    Val(pCodeBars.ToString.Substring(10, 1))

                'Paso 2 multiplicar el resultado del paso 1 por 3 (Paso1 * 3)
                pImpares = pImpares * 3

                'Paso 3 Sumar posiciones Pares
                pPares = Val(pCodeBars.ToString.Substring(1, 1)) + _
                    Val(pCodeBars.ToString.Substring(3, 1)) + _
                    Val(pCodeBars.ToString.Substring(5, 1)) + _
                    Val(pCodeBars.ToString.Substring(7, 1)) + _
                    Val(pCodeBars.ToString.Substring(9, 1))

                'Paso 4 Sumar Resultado de Paso 2 y Paso 3
                pSuma = pImpares + pPares

                'Paso 5 Encontrar proxima decena
                pDivision = Math.Ceiling(pSuma / 10)
                pDecenaProx = pDivision * 10

                'Paso 6 Restar Paso 5 menos paso 4
                pCodigoVerificador = pDecenaProx - pSuma

                'Paso 7 Agregar pCodigo de Barras el codigo Verificador (Este se sustituye por el digito de la posicion 14)
                pTotal = pCodeBars + pCodigoVerificador.ToString

                Return pTotal.ToString.Substring(6, 6)

            End If

            Return Nothing
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Public Function FCN_UPC_Disponible() As String

        Try
            Dim dtUPC As New DataTable()
            Dim pUPC As String = String.Empty

            dtUPC = mSQLSelect.GETALL_UPC()
            If dtUPC.Rows.Count = Nothing Then
                Return Nothing
            End If

            For i = 0 To dtUPC.Rows.Count - 1
                If (dtUPC.Rows(i + 1)("U_UPC") - dtUPC.Rows(i)("U_UPC")) > 1 Then
                    pUPC = dtUPC.Rows(i)("U_UPC") + 1
                    Exit For
                End If
            Next

            Return pUPC
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try

    End Function

    Public Function FCN_DUN14(ByVal pNumero As String) As String
        Try
            Dim pCodeBars As String = String.Empty
            Dim pImpares As Integer = 0
            Dim pPares As Integer = 0
            Dim pSuma As Integer = 0
            Dim pDivision As Integer = 0
            Dim pDecenaProx As Integer = 0
            Dim pCodigoVerificador As Integer = 0
            Dim pTotal As String

            If Len(pNumero) = 4 Then ' 42923 sin cero
                pCodeBars = "100185950" + pNumero
            ElseIf Len(pNumero) = 5 Then ' 42923 sin cero
                pCodeBars = "100185950" + pNumero
            ElseIf Len(pNumero) = 6 Then '042923
                pCodeBars = "10018595" + pNumero
            ElseIf Len(pNumero) = 11 Then '18595042923 sin cero
                pCodeBars = "100" + pNumero
            ElseIf Len(pNumero) = 12 Then '018595042923
                pCodeBars = "10" + pNumero
            End If

            If Len(pCodeBars) = 14 Then
                'Paso 1 Sumar posiciones Impares
                pImpares = Val(pCodeBars.ToString.Substring(0, 1)) + _
                    Val(pCodeBars.ToString.Substring(2, 1)) + _
                    Val(pCodeBars.ToString.Substring(4, 1)) + _
                    Val(pCodeBars.ToString.Substring(6, 1)) + _
                    Val(pCodeBars.ToString.Substring(8, 1)) + _
                    Val(pCodeBars.ToString.Substring(10, 1)) + _
                    Val(pCodeBars.ToString.Substring(12, 1))

                'Paso 2 multiplicar el resultado del paso 1 por 3 (Paso1 * 3)
                pImpares = pImpares * 3

                'Paso 3 Sumar posiciones Pares
                pPares = Val(pCodeBars.ToString.Substring(1, 1)) + _
                    Val(pCodeBars.ToString.Substring(3, 1)) + _
                    Val(pCodeBars.ToString.Substring(5, 1)) + _
                    Val(pCodeBars.ToString.Substring(7, 1)) + _
                    Val(pCodeBars.ToString.Substring(9, 1)) + _
                    Val(pCodeBars.ToString.Substring(11, 1))

                'Paso 4 Sumar Resultado de Paso 2 y Paso 3
                pSuma = pImpares + pPares

                'Paso 5 Encontrar proxima decena
                pDivision = Math.Ceiling(pSuma / 10)
                pDecenaProx = pDivision * 10

                'Paso 6 Restar Paso 5 menos paso 4
                pCodigoVerificador = pDecenaProx - pSuma

                'Paso 7 Agregar pCodigo de Barras el codigo Verificador (Este se sustituye por el digito de la posicion 14)
                pTotal = pCodeBars.ToString.Substring(0, 13).ToString + pCodigoVerificador.ToString

                Return pTotal.ToString
            End If

            Return Nothing
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Function FCN_CODIGOBARRAS(ByVal pNumero As String) As String
        Try
            Dim pCodeBars As String = String.Empty
            Dim pImpares As Integer = 0
            Dim pPares As Integer = 0
            Dim pSuma As Integer = 0
            Dim pDivision As Integer = 0
            Dim pDecenaProx As Integer = 0
            Dim pCodigoVerificador As Integer = 0
            'Dim pTotal As String
            If Len(pNumero) = 4 Then ' 42923 sin cero
                pCodeBars = "100185950" + pNumero
            ElseIf Len(pNumero) = 5 Then ' 42923 sin cero
                pCodeBars = "0185950" + pNumero
            ElseIf Len(pNumero) = 6 Then '042923
                pCodeBars = "018595" + pNumero
            End If
            Return pCodeBars

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Public Sub ExportToPNG(ByVal pReporte As DevExpress.XtraReports.UI.XtraReport, ByVal pNameAtt As String)
        ' A path to export a report.
        Dim reportPath As String = Application.StartupPath.ToString + "\Att\" + pNameAtt + ".png"

        ' Create a report instance.
        'Dim report As New xrptImpresionOrden

        ' Get its Image export options.
        Dim imageOptions As ImageExportOptions = pReporte.ExportOptions.Image

        ' Set Image-specific export options.
        imageOptions.Format = ImageFormat.Png

        ' Export the report to Image.
        pReporte.ExportToImage(reportPath)

        ' Show the result.
        'ExportToPNG_StartProcess(reportPath)
    End Sub
    Public Sub ExportToPNG_StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub

    Public Function FCN_ProduccionHoras(ByVal pCodigoArticulo As String, ByVal pUnidadesTotales As String) As String
        Try
            'HORAS REQUERIDAS
            Dim dtParametros As New DataTable()
            Dim pHorasRequeridas As Decimal
            Application.DoEvents()
            'dtParametros = GET_MoldesProduccionParametros(pCodigoArticulo)
            dtParametros = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProduccionParametros " + pCodigoArticulo)


            If Not dtParametros.Rows.Count = Nothing Then

                If Not dtParametros(0)("CicloHora").ToString = String.Empty Then
                    pHorasRequeridas = Val(pUnidadesTotales) / Val(dtParametros.Rows(0)("ArticulosHora"))
                    pHorasRequeridas = Math.Ceiling(pHorasRequeridas)
                    Return pHorasRequeridas
                Else
                    Return Nothing
                End If

            End If
            Application.DoEvents()

            Return Nothing

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function



    Public Function Convertir_ArrayToDataTable(ByVal pArrayList As Object()) As DataTable
        Try
            Dim dataTable As New DataTable()
            For i = 0 To pArrayList.Count - 1
                dataTable.LoadDataRow(pArrayList, True)
            Next
            Return dataTable
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


End Module

