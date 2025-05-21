Public Class frmTemporal_Produccion

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


    Private Sub frmTemporal_Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Dim dt2 As New DataTable

            dt = mSQLSelect.GET_ProduccionPlaneada_XArticulo(pCodigoArticulo)
            dt2 = mSQLSelect.GET_ProduccionLiberada_XArticulo(pCodigoArticulo)

            If dt.Rows.Count = Nothing And dt2.Rows.Count = Nothing Then
                mMensajes.msg_Informacion("Este articulo no tiene ningun tipo de Produccion")
                Me.Close()
            Else
                Dim dtArticulo As New DataTable
                dtArticulo = mSQLSelect.GET_Articulo(pCodigoArticulo)
                If Not dtArticulo.Rows.Count = 0 Then
                    txtCodigoArticulo.EditValue = dtArticulo.Rows(0)("CodigoArticulo").ToString
                    txtNombreArticulo.EditValue = dtArticulo.Rows(0)("NombreArticulo").ToString
                    txtDeLinea.EditValue = dtArticulo.Rows(0)("DeLinea").ToString
                End If


                DsTemporal_Produccion.Tables("dsdtTemporal_ProduccionPlaneada").Clear() 'Borrar DataSet
                DsTemporal_Produccion.Tables("dsdtTemporal_ProduccionPlaneada").Merge(dt) 'Llenar DSDT con Qry

                DsTemporal_Produccion.Tables("dsdtTemporal_ProduccionLiberada").Clear() 'Borrar DataSet
                DsTemporal_Produccion.Tables("dsdtTemporal_ProduccionLiberada").Merge(dt2) 'Llenar DSDT con Qry
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
    Private Sub barbtnVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub
    Private Sub barbtnVistaPrevia2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia2.ItemClick
        grdviewTemporal_ProduccionLiberadas.ShowRibbonPrintPreview()
    End Sub
    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        grdviewTemporal_ProduccionPlaneadas.PrintDialog()
    End Sub
    Private Sub barbtnImprimir2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        grdviewTemporal_ProduccionLiberadas.PrintDialog()
    End Sub
    Private Sub barbtnExportarXLSX_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub
    Private Sub barbtnExportarXLSX2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        sfdSave.Filter = "Archivos Excel | *.xlsx"
        If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            grdviewTemporal_ProduccionLiberadas.ExportToXlsx(sfdSave.FileName)
        End If
    End Sub
#End Region



    Private Sub barbtnRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        frmTemporal_Recibos.ppNumeroSAP = grdviewTemporal_ProduccionLiberadas.GetRowCellValue(grdviewTemporal_ProduccionLiberadas.FocusedRowHandle, "NumOrden")
        frmTemporal_Recibos.ShowDialog()
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdviewTemporal_ProduccionPlaneadas.IsFocusedView() Then
                grdviewTemporal_ProduccionPlaneadas.ShowRibbonPrintPreview()
            ElseIf grdviewTemporal_ProduccionLiberadas.IsFocusedView() Then
                grdviewTemporal_ProduccionLiberadas.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick

        Try
            If grdviewTemporal_ProduccionPlaneadas.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewTemporal_ProduccionPlaneadas.ExportToXlsx(sfdSave.FileName)
                End If
            ElseIf grdviewTemporal_ProduccionLiberadas.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewTemporal_ProduccionLiberadas.ExportToXlsx(sfdSave.FileName)
                End If
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
            If grdviewTemporal_ProduccionLiberadas.IsFocusedView() Then
                frmTemporal_Recibos.ppNumeroSAP = grdviewTemporal_ProduccionLiberadas.GetRowCellValue(grdviewTemporal_ProduccionLiberadas.FocusedRowHandle, "NumOrden")
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

    Private Sub grdviewTemporal_ProduccionLiberadas_DoubleClick(sender As Object, e As EventArgs) Handles grdviewTemporal_ProduccionLiberadas.DoubleClick
        Try
            FCN_DetalleRecibos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnOrdenLiberar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenLiberar.ItemClick
        Try
            frmTemporal_OrdenesCerradasResultado.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewTemporal_ProduccionPlaneadas, "NumOrden")

            If mMensajes.msg_Ordenes_StatusLiberar() Then
                ssmEsperar.ShowWaitForm()
                Dim pArray As ArrayList
                pArray = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewTemporal_ProduccionPlaneadas)

                For i = 0 To pArray.Count - 1
                    Dim pNumOrden As String = pArray(i)("NumOrden").ToString

                    'If pArray(i)("Estado").ToString = "Planeado" Then
                    mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(pNumOrden)
                    'End If
                Next
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            frmTemporal_OrdenesCerradasResultado.vpEnviarCorreo = True
            frmTemporal_OrdenesCerradasResultado.ppTipoEvento = "Liberadas"
            frmTemporal_OrdenesCerradasResultado.ShowDialog()
        End Try
    End Sub


 
  
    Private Sub grdviewTemporal_ProduccionPlaneadas_Click(sender As Object, e As EventArgs) Handles grdviewTemporal_ProduccionPlaneadas.Click
        Try
            If grdviewTemporal_ProduccionPlaneadas.RowCount = Nothing Then
                barbtnOrdenLiberar.Enabled = False
                barbtnOrdenCerrar.Enabled = False
                Exit Sub
            End If

            If grdviewTemporal_ProduccionPlaneadas.IsFocusedView() Then
                barbtnOrdenLiberar.Enabled = True
                barbtnOrdenCerrar.Enabled = False
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTemporal_ProduccionLiberadas_Click(sender As Object, e As EventArgs) Handles grdviewTemporal_ProduccionLiberadas.Click
        Try
            If grdviewTemporal_ProduccionLiberadas.RowCount = Nothing Then
                barbtnOrdenLiberar.Enabled = False
                barbtnOrdenCerrar.Enabled = False
                Exit Sub
            End If
            If grdviewTemporal_ProduccionLiberadas.IsFocusedView() Then
                barbtnOrdenCerrar.Enabled = True
                barbtnOrdenLiberar.Enabled = False
            End If

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