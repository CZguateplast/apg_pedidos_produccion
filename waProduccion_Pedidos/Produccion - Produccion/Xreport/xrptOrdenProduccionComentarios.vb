Public Class xrptOrdenProduccionComentarios

    Private Sub xrptOrdenProduccionComentarios_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            Dim dtOrdenComentarios As New DataTable("dtOrdenComentarios")

            dtOrdenComentarios = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[SP_ImpresionOrdenesProduccionComentarios] " + vpCodigoArticulo.ToString + "," + vpTipoOrden.ToString)

            If Not dtOrdenComentarios.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtOrdenesComentarios.TableName.ToString).Clear()
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtOrdenesComentarios.TableName.ToString).Merge(dtOrdenComentarios)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try



    End Sub

End Class