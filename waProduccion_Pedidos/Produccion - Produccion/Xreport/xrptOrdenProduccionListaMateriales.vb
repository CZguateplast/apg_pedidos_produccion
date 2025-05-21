Public Class xrptOrdenProduccionListaMateriales

    Private Sub xrptOrdenProduccionListaMateriales_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionListaMateriales.TableName.ToString).Clear()
            Dim dtListaMateriales As New DataTable("dtListaMateriales")
            dtListaMateriales = GET_ListaMaterialesCC_XArticulo("'" + pId.Value.ToString + "'")
            If Not dtListaMateriales.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionListaMateriales.TableName.ToString).Merge(dtListaMateriales)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class