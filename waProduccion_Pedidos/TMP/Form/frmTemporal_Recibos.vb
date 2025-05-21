Public Class frmTemporal_Recibos

    Private pNumeroSAP As String

    Public Property ppNumeroSAP() As String
        Get
            Return pNumeroSAP
        End Get
        Set(ByVal Value As String)
            pNumeroSAP = Value
        End Set
    End Property


    Private Sub frmTemporal_Recibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = mSQLSelect.GET_Temporal_Recibos(pNumeroSAP)
            If Not dt.Rows.Count = Nothing Then
                txtNumOrden.EditValue = dt.Rows(0)("NumOrden").ToString
                txtCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dt.Rows(0)("NombreArticulo").ToString
                txtDeLinea.EditValue = dt.Rows(0)("DeLinea").ToString
                txtPlaneado.EditValue = dt.Rows(0)("Planeado").ToString
                DsTemporal_Recibos.Tables("dsdtTemporal_Recibos").Clear() 'Borrar DataSet
                DsTemporal_Recibos.Tables("dsdtTemporal_Recibos").Merge(dt) 'Llenar DSDT con Qry
            Else
                mMensajes.msg_Informacion("La orden SAP# [" + pNumeroSAP + "] NO tiene aplicado ningun recibo.")
                Me.Close()
            End If

        Catch ex As Exception
            Me.Close()
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub txtDeLinea_EditValueChanged(sender As Object, e As EventArgs) Handles txtDeLinea.EditValueChanged
        Try
            If txtDeLinea.EditValue = "SI" Then
                txtDeLinea.BackColor = Color.Green
                txtDeLinea.ForeColor = Color.White
            Else
                txtDeLinea.BackColor = Color.Red
                txtDeLinea.ForeColor = Color.White
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Me.Close()
    End Sub
End Class