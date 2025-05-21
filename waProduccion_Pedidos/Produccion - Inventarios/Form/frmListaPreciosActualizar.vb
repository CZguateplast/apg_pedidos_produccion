Public Class frmListaPreciosActualizar

    Private Sub frmListaPreciosActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueGrupoArticulo, mSQLSelect.GET_Catalogo_GrupoArticulos(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueListaPreciosDe, mSQLSelect.GET_Catalogo_ListaPrecios(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueListaPreciosPara, mSQLSelect.GET_Catalogo_ListaPrecios(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueMonedaAplicar, mSQLSelect.GET_Listado("Monedas"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueMoneda, mSQLSelect.GET_Listado("Monedas"), "Id", "Nombre")

            FCN_Nuevo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_Enter(sender As Object, e As EventArgs) Handles slueCodigoArticulo.Enter
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_ArticulosARconEx(mFunciones.FCN_GET_Columna(grdviewListaPrecios, "CodigoArticulo")), "CodigoArticulo", "CodigoArticulo")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueCodigoArticulo.EditValueChanging
        Try
            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Articulo [" + e.NewValue.ToString + "] para actualizar?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            If slueListaPreciosDe.EditValue = Nothing Then
                MsgBox("Debe de ingresar una lista de Precios Origen para continuar.")
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ListaPrecios_CodigoArticulo("'" + e.NewValue.ToString + "'", slueListaPreciosDe.EditValue.ToString)

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Merge(dt)
            grdListaPrecios.Focus()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueGrupoArticulo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueGrupoArticulo.EditValueChanging
        Try
            If slueListaPreciosDe.EditValue = Nothing Then


                MsgBox("Debe de ingresar una lista de precios como referencia." + Environment.NewLine + "Intente de Nuevo!!")
                e.Cancel = True
                Exit Sub
            End If

            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Grupo [" + e.NewValue.ToString + "] para actualizar?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ListaPrecios_GrupoArticulos(e.NewValue.ToString, slueListaPreciosDe.EditValue.ToString)

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            If Not grdviewListaPrecios.RowCount = Nothing Then
                If MsgBox("Desea limpiar la lista actual?", MsgBoxStyle.YesNo, "[Borrar]") = MsgBoxResult.Yes Then
                    DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Clear()
                End If
            End If
            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Merge(dt)
            grdListaPrecios.Focus()
            mMensajes.msg_Proceso_ok()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            If slueListaPreciosPara.EditValue = Nothing Then
                MsgBox("Debe ingresar una lista de Precios Destino")
                Exit Sub
            End If

            If Not ssmEsperar.IsSplashFormVisible() Then
                ssmEsperar.ShowWaitForm()
            End If

            Dim pCodigoArticulo As String = String.Empty
            Dim pListaprecios As String = slueListaPreciosPara.EditValue.ToString
            Dim pMoneda As String = String.Empty
            Dim pPrecio As String = String.Empty

            For i = 0 To grdviewListaPrecios.RowCount - 1
                pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewListaPrecios, "CodigoArticulo", i)
                pMoneda = mFunciones.FCN_GetCellValue(grdviewListaPrecios, "Moneda", i)
                pPrecio = mFunciones.FCN_GetCellValue(grdviewListaPrecios, "Precio", i)

                ssmEsperar.SetWaitFormCaption("Cargando...")
                ssmEsperar.SetWaitFormDescription(pCodigoArticulo + "/" + pPrecio + " " + pMoneda)


                mDIAPI.SAP_DIAPI_ListasPrecios_Actualizar(pListaprecios, pCodigoArticulo, pPrecio, pMoneda)
                SET_PROD_ListaPrecios_LOG(pListaprecios, pCodigoArticulo, pPrecio, pMoneda)
            Next

            If ssmEsperar.IsSplashFormVisible() Then
                ssmEsperar.CloseWaitForm()
            End If
            mMensajes.msg_Proceso_ok()
        Catch ex As Exception

            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then
                ssmEsperar.CloseWaitForm()
            End If
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewListaPrecios)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPrecioAplicar_Click(sender As Object, e As EventArgs) Handles btnPrecioAplicar.Click
        Try
            If grdviewListaPrecios.RowCount = Nothing Then
                mMensajes.msg_Informacion("No existen Articulos para actualizar el Precio. " + Environment.NewLine + " Intente de Nuevo.!!")
                Exit Sub
            End If

            For i = 0 To grdviewListaPrecios.RowCount - 1
                grdviewListaPrecios.SetRowCellValue(i, "Precio", spinPrecioLista.EditValue.ToString)
            Next

            mMensajes.msg_Proceso_ok()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnMonedaAplicar_Click(sender As Object, e As EventArgs) Handles btnMonedaAplicar.Click
        Try
            If grdviewListaPrecios.RowCount = Nothing Then
                mMensajes.msg_Informacion("No existen Articulos para actualizar La Moneda. " + Environment.NewLine + " Intente de Nuevo.!!")
                Exit Sub
            End If

            For i = 0 To grdviewListaPrecios.RowCount - 1
                grdviewListaPrecios.SetRowCellValue(i, "Moneda", slueMonedaAplicar.EditValue.ToString)
            Next

            mMensajes.msg_Proceso_ok()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueListaPreciosDe_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueListaPreciosDe.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                memoListaPreciosDeNombre.EditValue = Nothing
                Exit Sub
            End If
            Dim pNombreLista As String = String.Empty

            pNombreLista = mSQLSelect.GET_ListaPrecios(e.NewValue.ToString)

            If pNombreLista = String.Empty Then
                Exit Sub
            End If

            memoListaPreciosDeNombre.EditValue = pNombreLista

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueListaPreciosPara_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueListaPreciosPara.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                memoListaPreciosParaNombre.EditValue = Nothing
                Exit Sub
            End If
            Dim pNombreLista As String = String.Empty

            pNombreLista = mSQLSelect.GET_ListaPrecios(e.NewValue.ToString)

            If pNombreLista = String.Empty Then
                Exit Sub
            End If

            memoListaPreciosParaNombre.EditValue = pNombreLista

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnArticulosTodos_Click(sender As Object, e As EventArgs) Handles btnArticulosTodos.Click
        Try
            Dim dt As New DataTable()
            dt = GET_ListaPrecios_ArticulosTodos(slueListaPreciosDe.EditValue.ToString)

            If dt.Rows.Count = Nothing Then
                MsgBox("No existen articulos para agregar.")
                Exit Sub
            End If

            If Not grdviewListaPrecios.RowCount = Nothing Then
                If MsgBox("Desea limpiar la lista actual?", MsgBoxStyle.YesNo, "Borrar.") = MsgBoxResult.Yes Then
                    DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Clear()
                End If
            End If
            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Merge(dt)
            grdListaPrecios.Focus()
            mMensajes.msg_Proceso_ok()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnArticulosPrecioCero_Click(sender As Object, e As EventArgs) Handles btnArticulosPrecioCero.Click
        Try
            Dim dt As New DataTable()
            dt = GET_ListaPrecios_ArticulosSinPrecios(slueListaPreciosDe.EditValue.ToString)

            If dt.Rows.Count = Nothing Then
                MsgBox("No existen articulos para agregar.")
                Exit Sub
            End If

            If Not grdviewListaPrecios.RowCount = Nothing Then
                If MsgBox("Desea limpiar la lista actual?", MsgBoxStyle.YesNo, "Borrar.") = MsgBoxResult.Yes Then
                    DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Clear()
                End If
            End If
            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Merge(dt)
            grdListaPrecios.Focus()

            mMensajes.msg_Proceso_ok()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnArticulosConPrecio_Click(sender As Object, e As EventArgs) Handles btnArticulosConPrecio.Click
        Try
            Dim dt As New DataTable()
            dt = GET_ListaPrecios_ArticulosConPrecios(slueListaPreciosDe.EditValue.ToString)

            If dt.Rows.Count = Nothing Then
                MsgBox("No existen articulos para agregar.")
                Exit Sub
            End If

            If Not grdviewListaPrecios.RowCount = Nothing Then
                If MsgBox("Desea limpiar la lista actual?", MsgBoxStyle.YesNo, "[Borrar]") = MsgBoxResult.Yes Then
                    DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Clear()
                End If
            End If
            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Merge(dt)
            grdListaPrecios.Focus()
            mMensajes.msg_Proceso_ok()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnNuevo.ItemClick
        Try
            FCN_Nuevo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_Nuevo()
        Try
            slueListaPreciosDe.EditValue = Nothing
            memoListaPreciosDeNombre.EditValue = Nothing
            slueCodigoArticulo.EditValue = Nothing
            slueGrupoArticulo.EditValue = Nothing

            slueListaPreciosPara.EditValue = Nothing
            memoListaPreciosParaNombre.EditValue = Nothing
            spinPrecioLista.EditValue = Nothing
            slueMonedaAplicar.EditValue = Nothing

            DsListaPreciosActualizar1.Tables(DsListaPreciosActualizar1.dsdtListaPreciosActualizar.TableName.ToString).Clear()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

End Class