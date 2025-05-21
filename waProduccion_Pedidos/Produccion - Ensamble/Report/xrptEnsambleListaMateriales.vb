Public Class xrptEnsambleListaMateriales

    Private Sub xrptEnsambleListaMateriales_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtEnsambleListaMateriales.TableName.ToString).Clear()
            Dim dtListaMateriales As New DataTable("dtListaMateriales")
            dtListaMateriales = GET_ListaMaterialesCC_XArticulo("'" + pId.Value.ToString + "'")
            If Not dtListaMateriales.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtEnsambleListaMateriales.TableName.ToString).Merge(dtListaMateriales)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class