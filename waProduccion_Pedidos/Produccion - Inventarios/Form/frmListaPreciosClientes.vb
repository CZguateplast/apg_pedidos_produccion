Public Class frmListaPreciosClientes

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmListaPreciosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueListaPreciosDe, mSQLSelect.GET_Catalogo_ListaPrecios(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueListaPreciosPara, mSQLSelect.GET_Catalogo_ListaPrecios(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueDueno, mSQLSelect.GET_Catalogo_Dueños(), "Dueno", "Dueno")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub slueListaPrecios_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueListaPreciosDe.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                mmeListaPreciosNombreDe.EditValue = Nothing
                Exit Sub
            End If
            Dim pNombreLista As String = String.Empty

            pNombreLista = mSQLSelect.GET_ListaPrecios(e.NewValue.ToString)

            If pNombreLista = String.Empty Then
                Exit Sub
            End If

            mmeListaPreciosNombreDe.EditValue = pNombreLista

            Dim dt As New DataTable()
            dt = GET_ListaPreciosClientes(e.NewValue.ToString)
            If dt.Rows.Count = Nothing Then
                mMensajes.msg_Informacion("No existen Clientes con este numero de Lista de Precios [ " + e.NewValue.ToString + " ]")
                Exit Sub
            End If

            If Not grdviewListaPreciosCliente.RowCount = Nothing Then
                If MsgBox("Desea borrar los clientes en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Clear()
                End If
            Else
            End If

            DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Merge(dt)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueListaPreciosPara_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueListaPreciosPara.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                mmeListaPreciosNombreDe.EditValue = Nothing
                Exit Sub
            End If
            Dim pNombreLista As String = String.Empty

            pNombreLista = mSQLSelect.GET_ListaPrecios(e.NewValue.ToString)

            If pNombreLista = String.Empty Then
                Exit Sub
            End If

            mmeListaPreciosNombrePara.EditValue = pNombreLista



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewListaPreciosCliente)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnNuevo.ItemClick
        Try
            slueListaPreciosDe.EditValue = Nothing
            slueListaPreciosPara.EditValue = Nothing
            mmeListaPreciosNombreDe.EditValue = Nothing
            mmeListaPreciosNombrePara.EditValue = Nothing
            DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Clear()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try

            If grdviewListaPreciosCliente.RowCount = Nothing Then
                mMensajes.msg_Informacion("No existe Clientes para Actualizar.")
                Exit Sub
            End If

            If slueListaPreciosPara.EditValue = Nothing Then
                mMensajes.msg_Informacion("No existe Lista de Precios para Actualizar.")
                Exit Sub
            End If


            MsgBox("Lista Precios para Actualizar [ " + slueListaPreciosPara.EditValue.ToString + " ] " + Environment.NewLine _
                   + "Cantidad de Clientes [ " + grdviewListaPreciosCliente.RowCount.ToString + " ] " + Environment.NewLine + Environment.NewLine _
                   + "¿Desea continuar con la actualizacion? ", MsgBoxStyle.YesNo, "Actualizar")

            Dim pCodigoCliente As String = String.Empty
            Dim pListaPrecios As String = slueListaPreciosPara.EditValue.ToString

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If

            For i = 0 To grdviewListaPreciosCliente.RowCount - 1
                pCodigoCliente = mFunciones.FCN_GetCellValue(grdviewListaPreciosCliente, "CodigoCliente", i)
                ssmEsperar.SetWaitFormCaption("Actualizando " + i.ToString + " de " + grdviewListaPreciosCliente.RowCount.ToString)
                ssmEsperar.SetWaitFormDescription("Cliente " + pCodigoCliente)

                SAP_DIAPI_ListasPreciosCliente_Actualizar(pCodigoCliente, pListaPrecios)
            Next
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If

            mMensajes.msg_Proceso_ok()

        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoCliente_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueCodigoCliente.EditValueChanging
        Try
            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Cliente [" + e.NewValue.ToString + "] a la lista?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ListaPreciosCliente_CodigoCliente(e.NewValue.ToString)

            If dt.Rows.Count = Nothing Then
                slueCodigoCliente.EditValue = String.Empty
                Exit Sub
            End If

            DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Merge(dt)
            grdListaPreciosCliente.Focus()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueDueno_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueDueno.EditValueChanging
        Try
            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Dueño [" + e.NewValue.ToString + "] a la lista?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ListaPreciosCliente_Dueño(e.NewValue.ToString)

            If dt.Rows.Count = Nothing Then
                slueCodigoCliente.EditValue = String.Empty
                Exit Sub
            End If

            DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Merge(dt)
            grdListaPreciosCliente.Focus()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub frmListaPreciosClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            slueListaPreciosDe.EditValue = Nothing
            slueListaPreciosPara.EditValue = Nothing
            mmeListaPreciosNombreDe.EditValue = Nothing
            mmeListaPreciosNombrePara.EditValue = Nothing
            DsListaPreciosClientes1.Tables(DsListaPreciosClientes1.dsdtListaPreciosCliente.TableName.ToString).Clear()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class