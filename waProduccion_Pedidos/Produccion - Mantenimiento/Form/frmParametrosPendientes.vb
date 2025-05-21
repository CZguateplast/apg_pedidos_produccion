Public Class frmParametrosPendientes

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(bgvParametrosPendientes, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(bgvParametrosPendientes)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)

        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            bgvParametrosPendientes.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmParametrosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable()

            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[PROD_ParametrosPendientes]")

            If dt.Rows.Count = Nothing Then
                mMensajes.msg_NoData()
                Exit Sub
            End If

            DsParametrosPendientes1.Tables(DsParametrosPendientes1.dsdtParametrosPendientes.TableName.ToString).Clear()
            DsParametrosPendientes1.Tables(DsParametrosPendientes1.dsdtParametrosPendientes.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class