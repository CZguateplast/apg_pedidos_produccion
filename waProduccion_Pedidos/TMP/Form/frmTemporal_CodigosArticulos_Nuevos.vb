Public Class frmTemporal_CodigosArticulos_Nuevos

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmTemporal_CodigosArticulos_Nuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'vpBoolean = False
            'FCN_FILL_SearchLookUpEdit(slueCodigoArticulos, mSQLSelect.GET_Listado_CodigosArticulos_Nuevos(), "CodigoArticulo", "CodigoArticulo")
            'txtNombreArticulo.EditValue = String.Empty
            'slueCodigoArticulos.EditValue = String.Empty

            vpBoolean = False
            FCN_FILL_SearchLookUpEdit(slueCodigoArticulos, vpTabla1, "CodigoArticulo", "CodigoArticulo")
            txtNombreArticulo.EditValue = String.Empty
            slueCodigoArticulos.EditValue = String.Empty


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulos_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigoArticulos.EditValueChanged
        Try
            Dim dt As New DataTable("dtCodigoArticulo")
            dt = mSQLSelect.GET_Search_CodigoProducido(slueCodigoArticulos.EditValue)
            If Not dt.Rows.Count = Nothing Then
                txtNombreArticulo.EditValue = dt.Rows(0)("ItemName").ToString
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            vpCodigoArticulo = slueCodigoArticulos.EditValue
            vpNombreArticulo = txtNombreArticulo.EditValue
            vpBoolean = True
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub slueCodigoArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles slueCodigoArticulos.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If Not slueCodigoArticulos.Text = String.Empty Then
                vpCodigoArticulo = slueCodigoArticulos.EditValue
                vpNombreArticulo = txtNombreArticulo.EditValue
                vpBoolean = True
                Me.Close()
            End If

        End If

    End Sub
End Class