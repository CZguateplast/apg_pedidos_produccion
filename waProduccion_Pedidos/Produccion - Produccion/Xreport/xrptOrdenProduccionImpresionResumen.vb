Imports System
Imports DevExpress.XtraReports.UI


Public Class xrptOrdenProduccionImpresionResumen

    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            ' Validar si el ReportSource está instanciado
            Dim subReport = CType(sender, DevExpress.XtraReports.UI.XRSubreport)

            If subReport.ReportSource Is Nothing Then
                ' Si no está instanciado, creamos una nueva instancia
                subReport.ReportSource = New xrptOrdenProduccionListaMateriales()
            End If

            ' Asignar valores a los parámetros
            CType(subReport.ReportSource, xrptOrdenProduccionListaMateriales).pCodigoArticulo.Value = Convert.ToString(GetCurrentColumnValue("CodigoArticulo"))
            CType(subReport.ReportSource, xrptOrdenProduccionListaMateriales).pId.Value = Convert.ToString(GetCurrentColumnValue("Id"))
        Catch ex As Exception
            ' Manejo de errores
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub xrptOrdenProduccionImpresionResumen_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class