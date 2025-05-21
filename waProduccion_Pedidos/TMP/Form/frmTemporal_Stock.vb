Public Class frmTemporal_Stock


    Private pCodigoArticulo As String

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)
            pCodigoArticulo = Value
        End Set
    End Property

    Private Sub frmTemporal_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = mSQLSelect.GET_Stock_XArticulo(pCodigoArticulo)
            If Not dt.Rows.Count = Nothing Then
                txtCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dt.Rows(0)("NombreArticulo").ToString
                txtDeLinea.EditValue = dt.Rows(0)("DeLinea").ToString
                DsTemporal_Stock.Tables("dsdtTemporal_Stock").Clear() 'Borrar DataSet
                DsTemporal_Stock.Tables("dsdtTemporal_Stock").Merge(dt) 'Llenar DSDT con Qry
            Else
                mMensajes.msg_Informacion("Este articulo no tiene Stock")
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
#Region "Botones"

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        grdviewTemporal_Stock.ShowRibbonPrintPreview()
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewTemporal_Stock.ExportToXlsx(sfdSave.FileName)
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

#End Region
    
    
End Class