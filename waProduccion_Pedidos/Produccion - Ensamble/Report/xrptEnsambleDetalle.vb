Imports System
Imports DevExpress.XtraReports.UI

Public Class xrptEnsambleDetalle

    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            CType((CType(sender, XRSubreport)).ReportSource, xrptEnsambleListaMateriales).pCodigoArticulo.Value = Convert.ToString(GetCurrentColumnValue("CodigoArticulo"))
            CType((CType(sender, XRSubreport)).ReportSource, xrptEnsambleListaMateriales).pId.Value = Convert.ToString(GetCurrentColumnValue("Id"))
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class