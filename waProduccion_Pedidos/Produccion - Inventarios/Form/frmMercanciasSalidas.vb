Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class frmMercanciasSalidas

    Private Sub frmTrasladosMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Sub_Seguridad_APG()
            ValoresDefault()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnSAP)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ValoresDefault()
        Try
            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("ListaPrecios", Type.GetType("System.Int16"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("Comentarios", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("FechaConta", Type.GetType("System.DateTime"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("FechaDocumento", Type.GetType("System.DateTime"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("AsientoContable", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)

            Dim row As DataRow = dt.NewRow()
            row("ListaPrecios") = "1"
            row("FechaConta") = DateTime.Now()
            row("FechaDocumento") = DateTime.Now()
            row("AsientoContable") = "Salida de Mercancías"
            dt.Rows.Add(row)

            'Vaciar Vertical Grid de Maquinas
            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaEncabezado").Clear() 'Vaciar Controles
            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaEncabezado").Merge(dt)

            mFunciones.FCN_FILL_SearchLookUpEdit(vrslueListaPrecios, mSQLSelect.GET_Catalogo_ListaPrecios(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoArticulo, mSQLSelect.GET_Catalogo_OITM(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueBodegas, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(vrslueCuentaContable, mSQLSelect.GET_Catalogo_CuentasContables(), "CodigoCuenta", "CodigoFormato")

            vpListaPrecios = "1"

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub rslueCodigoArticulo_EditValueChanged(sender As Object, e As EventArgs) Handles rslueCodigoArticulo.EditValueChanged
        Try
            Dim dt As New DataTable("dtCodigoArticulo")
            Dim pCodigoArticulo As String = vpCodigoArticulo

            If pCodigoArticulo = String.Empty Then
                Exit Sub
            End If

            dt = mSQLSelect.GET_Catalogo_OITM(pCodigoArticulo)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "CodigoArticulo", dt.Rows(0)("CodigoArticulo").ToString)
            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "NombreArticulo", dt.Rows(0)("NombreArticulo").ToString)
            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "UnidadMedida", dt.Rows(0)("UnidadMedida").ToString)


            mFunciones.FCN_FILL_SearchLookUpEdit(rslueBodegas, mSQLSelect.GET_Stock_Bodegas(pCodigoArticulo), "Id", "Nombre")

            Sub_Stock()
            Sub_Precio()

            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "Cantidad", "0") 'Llenar rslueBodegas

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
        End Try


    End Sub

    Private Sub rslueCodigoArticulo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles rslueCodigoArticulo.EditValueChanging
        Try
            vpCodigoArticulo = e.NewValue
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub rslueBodegas_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles rslueBodegas.EditValueChanging
        Try
            vpBodega = e.NewValue
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Stock()
        Try
            If vpCodigoArticulo = String.Empty Or vpBodega = String.Empty Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtStock")

            dt = mSQLSelect.GET_Stock(vpCodigoArticulo, vpBodega)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "Stock", dt.Rows(0)("Stock").ToString)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_Precio()
        Try
            If vpCodigoArticulo = String.Empty Or vpListaPrecios = String.Empty Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtStock")
            dt = mSQLSelect.GET_Catalogo_ListaPrecios(vpCodigoArticulo, vpListaPrecios)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "Precio", dt.Rows(0)("Precio").ToString)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub rslueBodegas_EditValueChanged(sender As Object, e As EventArgs) Handles rslueBodegas.EditValueChanged
        Try
            Sub_Stock()
            grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "Cantidad", "0")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vrslueListaPrecios_EditValueChanged(sender As Object, e As EventArgs) Handles vrslueListaPrecios.EditValueChanged
        Try
            Sub_Precio()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vrslueListaPrecios_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles vrslueListaPrecios.EditValueChanging
        Try
            vpListaPrecios = e.NewValue
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTrasladosMercaderia_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewTrasladosMercaderia.CellValueChanged
        Try
            If e.Column.FieldName = "Cantidad" Then
                Dim pStock As String = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Stock")
                If pStock = String.Empty Then
                    Exit Sub
                End If
                If e.Value > 0 Then
                    If e.Value > pStock Then

                        'grdviewTrasladosMercaderia.SetRowCellValue(grdviewTrasladosMercaderia.FocusedRowHandle, "Cantidad", "0")
                        grdviewTrasladosMercaderia.SetRowCellValue(e.RowHandle, "Cantidad", "0")
                        mMensajes.msg_Error("El valor ingresado no puede ser mayor a " + pStock)
                    End If
                ElseIf e.Value < 0 Then
                    grdviewTrasladosMercaderia.SetRowCellValue(e.RowHandle, "Cantidad", "0")
                    mMensajes.msg_Error("El valor ingresado no puede ser Negativo [" + pStock + "]")
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)


        End Try
    End Sub


    Private Sub grdviewTrasladosMercaderia_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grdviewTrasladosMercaderia.RowUpdated
        'grdviewTrasladosMercaderia.Columns("CodigoArticulo").OptionsColumn.AllowEdit = False
        'grdviewTrasladosMercaderia.OptionsBehavior.ReadOnly = True
    End Sub

    Private Sub grdviewTrasladosMercaderia_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewTrasladosMercaderia.InitNewRow
        'grdviewTrasladosMercaderia.Columns("CodigoArticulo").OptionsColumn.AllowEdit = True
        'grdviewTrasladosMercaderia.OptionsBehavior.ReadOnly = False
    End Sub

    Private Sub grdviewTrasladosMercaderia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewTrasladosMercaderia.FocusedRowChanged
        Try
            If e.FocusedRowHandle < 0 Then
                grdviewTrasladosMercaderia.OptionsBehavior.Editable = True
                grdviewTrasladosMercaderia.OptionsBehavior.ReadOnly = False
            Else
                grdviewTrasladosMercaderia.OptionsBehavior.Editable = False
                grdviewTrasladosMercaderia.OptionsBehavior.ReadOnly = True
            End If



            vpCodigoArticulo = String.Empty
            vpBodega = String.Empty

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub


    

    Public Function Sub_Get_TrasladoMercaderia_Encabezado() As DataTable
        Try
            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("ListaPrecios", Type.GetType("System.Int16"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("FechaConta", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("FechaDocumento", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("NumReferencia", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("Comentarios", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("AsientoContable", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)


            Dim row As DataRow = dt.NewRow()
            row("ListaPrecios") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "ListaPrecios")
            row("FechaConta") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "FechaConta").Substring(0, 10).ToString
            row("FechaDocumento") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "FechaDocumento").Substring(0, 10).ToString
            row("NumReferencia") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "NumReferencia")
            row("Comentarios") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "Comentarios")
            row("AsientoContable") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "AsientoContable")
            dt.Rows.Add(row)

            Return dt
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Private Function Sub_Get_Detalle() As DataTable
        Try
            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("CodigoArticulo", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("Bodega", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("Cantidad", Type.GetType("System.Decimal"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("CuentaContable", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)


            For i = 0 To grdviewTrasladosMercaderia.RowCount - 1

                Dim row As DataRow = dt.NewRow()
                row("CodigoArticulo") = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "CodigoArticulo", i)
                row("Bodega") = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Bodega", i)
                row("Cantidad") = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Cantidad", i)
                row("CuentaContable") = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "CuentaContable")
                dt.Rows.Add(row)

            Next


            Return dt
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Private Sub grdviewTrasladosMercaderia_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdviewTrasladosMercaderia.ValidateRow
        Try
            Dim CodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "CodigoArticulo")
            Dim Bodega As String = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Bodega")
            Dim Stock As String = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Stock")
            Dim Cantidad As String = mFunciones.FCN_GetCellValue(grdviewTrasladosMercaderia, "Cantidad")
            Dim CuentaContable As String = mFunciones.FCN_GetCellValue(vgrdTrasladosMercaderia, "CuentaContable")

            If CodigoArticulo = String.Empty Then
                If mMensajes.msg_InformacionIncompleta2("CodigoArticulo") Then
                    e.Valid = False
                Else
                    grdviewTrasladosMercaderia.CancelUpdateCurrentRow()
                End If
                Exit Sub
            ElseIf Bodega = String.Empty Then
                If mMensajes.msg_InformacionIncompleta2("Bodega") Then
                    e.Valid = False
                Else
                    grdviewTrasladosMercaderia.CancelUpdateCurrentRow()
                End If
                Exit Sub
            ElseIf Cantidad = String.Empty Or Cantidad = "0" Then
                If mMensajes.msg_InformacionIncompleta2("Cantidad") Then
                    e.Valid = False
                Else
                    grdviewTrasladosMercaderia.CancelUpdateCurrentRow()
                End If
                Exit Sub
            ElseIf Val(Cantidad) > Val(Stock) Then
                mMensajes.msg_Error("La Cantidad no puede Ser mayor al Stock Disponible")
                e.Valid = False
                Exit Sub
            ElseIf CuentaContable = String.Empty Then
                If mMensajes.msg_InformacionIncompleta2("Cuenta Contable") Then
                    e.Valid = False
                Else
                    grdviewTrasladosMercaderia.CancelUpdateCurrentRow()
                End If
                Exit Sub
            End If

            e.Valid = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTrasladosMercaderia_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdviewTrasladosMercaderia.InvalidRowException

        Try
            If Len(e.ErrorText.ToString) > "23" Then
                If e.ErrorText.ToString.Substring(0, 23) = "Column 'CodigoArticulo'" Then
                    mMensajes.msg_Error("El codigo de Articulo ya existe en la lista. No puede ingresar Duplicados")
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        End Try


    End Sub

    Private Sub grdviewTrasladosMercaderia_KeyDown(sender As Object, e As KeyEventArgs) Handles grdviewTrasladosMercaderia.KeyDown
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            If (MessageBox.Show("Desea eliminar la fila seleccionada?", "Confirmacion", _
              MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If


    End Sub


    Public Sub Sub_TrasladosMercaderia_Impresion(ByVal pDocnum As String)
        Try
            Dim dtImpresionEncabezado As New DataTable
            Dim dtImpresionDetalle As New DataTable
            dtImpresionEncabezado = mSQLSelect.GET_TrasladosMercaderia_ImpresionEncabezado(pDocnum)
            dtImpresionDetalle = mSQLSelect.GET_TrasladosMercaderia_ImpresionDetalle(pDocnum)

            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresionEncabezado").Clear()
            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresionEncabezado").Merge(dtImpresionEncabezado)

            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresionDetalle").Clear()
            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresionDetalle").Merge(dtImpresionDetalle)

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New rptTraladosMercaderiaSalidas
            RPTdocumento.DataSource = Me.DsTrasladosMercaderia1
            RPTdocumento.DataMember = "dsdtTrasladosMercaderiaImpresionDetalle"
            'dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)
            'ssmReporte.CloseWaitForm()
            PrintTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try

            If grdviewTrasladosMercaderia.RowCount = 0 Then
                mMensajes.msg_Informacion("Debe de ingresar por lo menos 1 Articulo para poder continuar")
                Exit Sub
            End If

            ssmEsperar.ShowWaitForm()
            If mDIAPI.SAP_DIAPI_SalidasMercaderia(Sub_Get_TrasladoMercaderia_Encabezado, Sub_Get_Detalle, ssmEsperar) Then
                Dim dt As New DataTable
                Dim columnsMaster As DataColumn
                columnsMaster = New DataColumn("ListaPrecios", Type.GetType("System.Int16"))
                dt.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("Comentarios", Type.GetType("System.String"))
                dt.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("FechaConta", Type.GetType("System.DateTime"))
                dt.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("FechaDocumento", Type.GetType("System.DateTime"))
                dt.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("AsientoContable", Type.GetType("System.String"))
                dt.Columns.Add(columnsMaster)


                Dim row As DataRow = dt.NewRow()
                row("ListaPrecios") = "1"
                row("FechaConta") = DateTime.Now()
                row("FechaDocumento") = DateTime.Now()
                row("AsientoContable") = "Salida de Mercancías"
                dt.Rows.Add(row)


                'Vaciar Vertical Grid de Maquinas
                DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaEncabezado").Clear() 'Vaciar Controles
                DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaEncabezado").Merge(dt)

                DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaDetalle").Clear() 'Vaciar Controles
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub


End Class