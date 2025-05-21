Public Class frmTemporal_DeudaCampana
    Private pCodigoArticulo As String

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)

            pCodigoArticulo = Value
        End Set
    End Property
    Private Sub frmTemporal_DeudaCampana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable


            dt = mSQLSelect.GET_DeudaCampana_XArticulo(pCodigoArticulo)

            If dt.Rows.Count = 0 Then
                mMensajes.msg_Informacion("Este articulo no tiene Deuda en ninguna Campaña")
                Me.Close()
            Else
                Dim dtArticulo As New DataTable
                dtArticulo = mSQLSelect.GET_Articulo(pCodigoArticulo)
                If Not dtArticulo.Rows.Count = 0 Then
                    txtCodigoArticulo.EditValue = dtArticulo.Rows(0)("CodigoArticulo").ToString
                    txtNombreArticulo.EditValue = dtArticulo.Rows(0)("NombreArticulo").ToString
                    txtDeLinea.EditValue = dtArticulo.Rows(0)("DeLinea").ToString
                End If

                DsTemporal_DeudaCampana.Tables("dsdtTemporal_DeudaCampana").Clear() 'Borrar DataSet
                DsTemporal_DeudaCampana.Tables("dsdtTemporal_DeudaCampana").Merge(dt) 'Llenar DSDT con Qry

            End If

        Catch ex As Exception
            Me.Close()
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtDeLinea_EditValueChanged(sender As Object, e As EventArgs) Handles txtDeLinea.EditValueChanged
        If txtDeLinea.EditValue = "SI" Then
            txtDeLinea.BackColor = Color.Green
            txtDeLinea.ForeColor = Color.White
        Else
            txtDeLinea.BackColor = Color.Red
            txtDeLinea.ForeColor = Color.White
        End If
    End Sub

#Region "Botones"
    
#End Region


    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewTemporal_DeudaCampana.ExportToXlsx(sfdSave.FileName)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewTemporal_DeudaCampana.ShowRibbonPrintPreview()
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
End Class