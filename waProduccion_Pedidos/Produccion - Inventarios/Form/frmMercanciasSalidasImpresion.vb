Public Class frmMercanciasSalidasImpresion

    Private Sub frmTrasladosmercaderiaImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ValoresDefault()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ValoresDefault()
        Try
            Dim dt As New DataTable

            dt = mSQLSelect.GET_TrasladosMercaderia_ImpresionEncabezado()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresion").Clear()
            DsTrasladosMercaderia1.Tables("dsdtTrasladosMercaderiaImpresion").Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            Dim pNumSAP As String
            pNumSAP = mFunciones.FCN_GetCellValue(grdviewTrasladoMercaderiaImpresion, "NumSAP")
            frmMercanciasSalidas.Sub_TrasladosMercaderia_Impresion(pNumSAP)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTrasladoMercaderiaImpresion_DoubleClick(sender As Object, e As EventArgs) Handles grdviewTrasladoMercaderiaImpresion.DoubleClick
        Try
            Dim pNumSAP As String
            pNumSAP = mFunciones.FCN_GetCellValue(grdviewTrasladoMercaderiaImpresion, "NumSAP")
            frmMercanciasSalidas.Sub_TrasladosMercaderia_Impresion(pNumSAP)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class