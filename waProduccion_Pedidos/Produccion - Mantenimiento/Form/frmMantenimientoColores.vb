Imports DevExpress.XtraReports.UI
Public Class frmMantenimientoColores


    Private Sub btnGenerarFiltro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(bgrdviewColor)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            bgrdviewColor.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                bgrdviewColor.ExportToXlsx(sfdSave.FileName)
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

    Private Sub barbtnGenerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGenerar.ItemClick
        Try
            Dim dt As New DataTable()

            dt = mSQLSelect.GET_ReporteColores()

            If dt.Rows.Count = Nothing Then
                DsMantenimientoColores1.Tables(DsMantenimientoColores1.dsdtMantenimientoColores.TableName.ToString).Clear()
            End If

            DsMantenimientoColores1.Tables(DsMantenimientoColores1.dsdtMantenimientoColores.TableName.ToString).Clear()
            DsMantenimientoColores1.Tables(DsMantenimientoColores1.dsdtMantenimientoColores.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnARDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnARDetalle.ItemClick
        Try
            Dim pTipo As String = "AR"
            Dim pColor As String = String.Empty

            pColor = mFunciones.FCN_GetCellValue(bgrdviewColor, "Color")

            frmTemporal_ColorDetalle.ppTipo = pTipo
            frmTemporal_ColorDetalle.ppColor = pColor
            frmTemporal_ColorDetalle.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnTodosDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnTodosDetalle.ItemClick
        Try
            Dim pTipo As String = String.Empty
            Dim pColor As String = String.Empty

            pColor = mFunciones.FCN_GetCellValue(bgrdviewColor, "Color")

            frmTemporal_ColorDetalle.ppTipo = pTipo
            frmTemporal_ColorDetalle.ppColor = pColor
            frmTemporal_ColorDetalle.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCPDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCPDetalle.ItemClick
        Try
            Dim pTipo As String = "CP"
            Dim pColor As String = String.Empty

            pColor = mFunciones.FCN_GetCellValue(bgrdviewColor, "Color")

            frmTemporal_ColorDetalle.ppTipo = pTipo
            frmTemporal_ColorDetalle.ppColor = pColor
            frmTemporal_ColorDetalle.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCCDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCCDetalle.ItemClick
        Try
            Dim pTipo As String = "CC"
            Dim pColor As String = String.Empty

            pColor = mFunciones.FCN_GetCellValue(bgrdviewColor, "Color")

            frmTemporal_ColorDetalle.ppTipo = pTipo
            frmTemporal_ColorDetalle.ppColor = pColor
            frmTemporal_ColorDetalle.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnReporteGeneral_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReporteGeneral.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptMantenimientoColores
            RPTdocumento.DataSource = Me.DsMantenimientoColores1
            RPTdocumento.DataMember = DsMantenimientoColores1.dsdtMantenimientoColores.TableName.ToString
            RPTdocumento.RequestParameters = False

            Dim PrintTool As New ReportPrintTool(RPTdocumento)
            PrintTool.ShowRibbonPreviewDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmMantenimientoColores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class