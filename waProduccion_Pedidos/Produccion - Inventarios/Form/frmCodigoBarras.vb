Public Class frmCodigoBarras

    Dim pBorrar As Boolean


    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGenerarCodigoBarras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGenerarCodigoBarras.ItemClick
        Try
            pBorrar = False
            'Variables
            Dim pUPCDisponible As String = mFunciones.FCN_UPC_Disponible()
            Dim pUPC As String = String.Empty
            Dim pCodigoBarras As String = String.Empty
            Dim pDUN14 As String = String.Empty

            'Validar
            If pUPCDisponible = String.Empty Then
                Exit Sub
            End If

            If Not Len(txtCodigoBarras.EditValue) = 12 And Not Len(txtUPC.EditValue) = 6 Then
                MsgBox("Debe ingresar un Codigo de Barras o UPC Valido para poder generar un Codigo DUN 14.")
                Exit Sub
            End If

            pUPC = txtUPC.EditValue
            pCodigoBarras = txtCodigoBarras.EditValue

            If pCodigoBarras = String.Empty Then

                'GenerarBARRAS
                pCodigoBarras = mFunciones.FCN_CODIGOBARRAS(pUPC)
                txtCodigoBarras.EditValue = pCodigoBarras

                'UPC PROPORCIONADO POR EL USUARIO

                'GenerarDUN14
                pDUN14 = mFunciones.FCN_DUN14(pUPC)
                txtDUN14.EditValue = pDUN14

            ElseIf pUPC = String.Empty Then
                'CODIGO BARRAS PROPORCIONADO POR EL USUARIO

                txtUPC.EditValue = txtCodigoBarras.EditValue.ToString.Substring(Len(txtCodigoBarras.EditValue) - 6, 6)

                pUPC = txtUPC.EditValue

                'GenerarDUN14
                pDUN14 = mFunciones.FCN_DUN14(pUPC)
                txtDUN14.EditValue = pDUN14


            End If



            ''ValidarExistencia de UPC
            '    'GenerarUPC
            '    pUPC = mFunciones.FCN_UPC(pUPCDisponible)
            '    txtUPC.EditValue = pUPC


            
            ''GenerarBARRAS
            'pCodigoBarras = mFunciones.FCN_CODIGOBARRAS(txtUPC.EditValue.ToString)
            'txtCodigoBarras.EditValue = pCodigoBarras

            ''GenerarDUN14
            'pDUN14 = mFunciones.FCN_DUN14(txtUPC.EditValue.ToString)
            'txtDUN14.EditValue = pDUN14



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            pBorrar = True
        End Try
    End Sub

    Private Sub txtUPC_EditValueChanged(sender As Object, e As EventArgs) Handles txtUPC.EditValueChanged
        Try
            If pBorrar = True Then
                txtCodigoBarras.EditValue = String.Empty
                txtDUN14.EditValue = String.Empty
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtCodigoBarras_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigoBarras.EditValueChanged
        Try
            If pBorrar = True Then
                txtUPC.EditValue = String.Empty
                txtDUN14.EditValue = String.Empty
            End If

            bccCodigoBarras.Text = txtCodigoBarras.EditValue.ToString

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmCodigoBarras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pBorrar = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtDUN14_EditValueChanged(sender As Object, e As EventArgs) Handles txtDUN14.EditValueChanged
        Try
            bccDUN14.Text = txtDUN14.EditValue.ToString
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBorrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBorrar.ItemClick
        Try
            txtCodigoBarras.EditValue = String.Empty
            txtUPC.EditValue = String.Empty
            txtDUN14.EditValue = String.Empty
            bccCodigoBarras.Text = String.Empty
            bccDUN14.Text = String.Empty

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class