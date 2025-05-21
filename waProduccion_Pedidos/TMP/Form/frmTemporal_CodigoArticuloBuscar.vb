Public Class frmTemporal_CodigoArticuloBuscar

    Private Sub frmCodigoArticuloBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            vpCodigoArticulo = String.Empty
            slueCodigoArticulo.EditValue = String.Empty
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            slueCodigoArticulo.Focus()
        End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If Not slueCodigoArticulo.Text = String.Empty Then
            vpCodigoArticulo = "'" + slueCodigoArticulo.EditValue + "'"
            Me.Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        vpCodigoArticulo = String.Empty
    End Sub

    
    Private Sub slueCodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles slueCodigoArticulo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If Not slueCodigoArticulo.Text = String.Empty Then
                vpCodigoArticulo = "'" + slueCodigoArticulo.EditValue + "'"
                Me.Close()
            End If

        End If

    End Sub
End Class