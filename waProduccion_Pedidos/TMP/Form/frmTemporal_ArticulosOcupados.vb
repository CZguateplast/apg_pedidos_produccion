Public Class frmTemporal_ArticulosOcupados

    Private Sub frmTemporal_ArticulosOcupados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not vpTabla1.Rows.Count = Nothing Then
                DsTemporal_ArticulosOcupados1.Tables("dsdtTemporal_ArticulosOcupados").Clear()
                DsTemporal_ArticulosOcupados1.Tables("dsdtTemporal_ArticulosOcupados").Merge(vpTabla1)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class