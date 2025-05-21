Public Class frmTemporal_Ensamble
    Private pCodigoArticulo As String
    Private pOrigenesBodegas As String

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)

            pCodigoArticulo = Value
        End Set
    End Property
    Public Property ppOrigenesBodegas() As String
        Get
            Return pOrigenesBodegas
        End Get
        Set(ByVal Value As String)
            pOrigenesBodegas = Value
        End Set
    End Property

    Private Sub frmTemporal_Ensamble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Dim dt2 As New DataTable

            dt = mSQLSelect.GET_EnsamblePlaneado_XArticulo(pCodigoArticulo, pOrigenesBodegas)
            dt2 = mSQLSelect.GET_EnsambleLiberado_XArticulo(pCodigoArticulo, pOrigenesBodegas)

            If dt.Rows.Count = 0 And dt2.Rows.Count = 0 Then
                mMensajes.msg_Informacion("Este articulo no tiene ningun tipo de Ensamble")
                Me.Close()
            Else
                Dim dtArticulo As New DataTable
                dtArticulo = mSQLSelect.GET_Articulo(pCodigoArticulo)
                If Not dtArticulo.Rows.Count = 0 Then
                    txtCodigoArticulo.EditValue = dtArticulo.Rows(0)("CodigoArticulo").ToString
                    txtNombreArticulo.EditValue = dtArticulo.Rows(0)("NombreArticulo").ToString
                    txtDeLinea.EditValue = dtArticulo.Rows(0)("DeLinea").ToString
                End If

                DsTemporal_Ensamble.Tables("dsdtTemporal_EmsamblePlaneado").Clear() 'Borrar DataSet
                DsTemporal_Ensamble.Tables("dsdtTemporal_EmsamblePlaneado").Merge(dt) 'Llenar DSDT con Qry

                DsTemporal_Ensamble.Tables("dsdtTemporal_EmsambleLiberado").Clear() 'Borrar DataSet
                DsTemporal_Ensamble.Tables("dsdtTemporal_EmsambleLiberado").Merge(dt2) 'Llenar DSDT con Qry
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
    
    
    Private Sub barbtnImprimir2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir2.ItemClick
        grdviewTemporal_EnsambleLiberado.PrintDialog()
    End Sub
    Private Sub barbtnExportarXLSX2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXLSX2.ItemClick
        
    End Sub
#End Region


    Private Sub barbtnRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRecibos.ItemClick
        
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            If grdviewTemporal_EnsamblePlaneado.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewTemporal_EnsamblePlaneado.ExportToXlsx(sfdSave.FileName)
                End If
            ElseIf grdviewTemporal_EnsambleLiberado.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewTemporal_EnsambleLiberado.ExportToXlsx(sfdSave.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdviewTemporal_EnsamblePlaneado.IsFocusedView() Then
                grdviewTemporal_EnsamblePlaneado.ShowRibbonPrintPreview()
            ElseIf grdviewTemporal_EnsambleLiberado.IsFocusedView() Then
                grdviewTemporal_EnsambleLiberado.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnDetalleRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleRecibos.ItemClick
        Try
            FCN_DetalleRecibos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_DetalleRecibos()
        Try
            If grdviewTemporal_EnsambleLiberado.IsFocusedView() Then
                frmTemporal_Recibos.ppNumeroSAP = grdviewTemporal_EnsambleLiberado.GetRowCellValue(grdviewTemporal_EnsambleLiberado.FocusedRowHandle, "NumOrden")
                frmTemporal_Recibos.ShowDialog()
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

    Private Sub grdviewTemporal_EnsambleLiberado_DoubleClick(sender As Object, e As EventArgs) Handles grdviewTemporal_EnsambleLiberado.DoubleClick
        Try
            FCN_DetalleRecibos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnOrdenLista_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenLista.ItemClick
        Try
            frmOrdenLista.Text = "Listado de Ordenes"
            frmOrdenLista.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class