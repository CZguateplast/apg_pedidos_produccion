Public Class frmTemporal_CodigosProducidos_Nuevos

    Private Sub frmTemporal_CodigosProducidos_Nuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            vpBoolean = False
            FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_Listado_CodigosProducidos_Nuevos(), "CodigoArticulo", "CodigoArticulo")


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigoArticulo.EditValueChanged
        Try
            Dim dt As New DataTable("dtCodigoArticulo")
            dt = mSQLSelect.GET_Search_CodigoProducido(slueCodigoArticulo.EditValue)
            If Not dt.Rows.Count = Nothing Then
                txtNombreArticulo.EditValue = dt.Rows(0)("ItemName").ToString
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub sbtnCancelar_Click(sender As Object, e As EventArgs) Handles sbtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub sbtnOk_Click(sender As Object, e As EventArgs) Handles sbtnOk.Click
        Try
            mSQLInsert.INSERT_CodigoProducido_Nuevo(slueCodigoArticulo.EditValue, txtNombreArticulo.EditValue)
            vpCodigoArticulo = slueCodigoArticulo.EditValue
            vpNombreArticulo = txtNombreArticulo.EditValue
            vpBoolean = True
            Me.Close()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class