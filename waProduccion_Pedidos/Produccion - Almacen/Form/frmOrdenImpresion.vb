Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
Public Class frmOrdenImpresion


    Private Sub ImpresionOrdenSeleccionada()
        Try
            If Not grdviewImpresionOrdenesDisponibles.SelectedRowsCount = 0 Then
                Dim dt As New DataTable("dtImpresionorden")
                dt = mSQLSelect.GET_Impresion_OrdenSeleccionada(FCN_XTRAGRID_GetFilasSeleccionadas(grdviewImpresionOrdenesDisponibles, "Id"))
                If Not dt.Rows.Count = 0 Then
                    DsImpresionOrden1.Tables("dsdtImpresionOrden").Clear() 'Borrar DataSet
                    DsImpresionOrden1.Tables("dsdtImpresionOrden").Merge(dt) 'Llenar DSDT con OrdenesDisponibles

                    Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptImpresionOrden
                    RPTdocumento.DataSource = Me.DsImpresionOrden1
                    RPTdocumento.DataMember = "dsdtImpresionOrden"
                    ''dvwReportes.DocumentSource = RPTdocumento
                    Dim PrintTool As New ReportPrintTool(RPTdocumento)

                    mFunciones.ExportToPNG(RPTdocumento, "Reporte_OrdenProduccion1")
                    mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
                                                                 "OrdenesProduccion", _
                                                                 "Hola", _
                                                                 "Reporte_OrdenProduccion1")

                    PrintTool.ShowRibbonPreviewDialog()
                End If
                'wzcReportes.SetNextPage()

            Else
                mMensajes.msg_Informacion("Selecciones como minimo 1 linea.")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally

        End Try
    End Sub

    Private Sub grdviewImpresionOrdenesDisponibles_DoubleClick(sender As Object, e As EventArgs) Handles grdviewImpresionOrdenesDisponibles.DoubleClick
        ImpresionOrdenSeleccionada()
    End Sub

    Private Sub frmImpresionOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable("dtImpresionorden")
            dt = mSQLSelect.GET_Impresion_OrdenesDisponibles()
            If Not dt.Rows.Count = 0 Then
                DsImpresionOrden1.Tables("dsdtImpresionOrdenesDisponibles").Clear() 'Borrar DataSet
                DsImpresionOrden1.Tables("dsdtImpresionOrdenesDisponibles").Merge(dt) 'Llenar DSDT con OrdenesDisponibles
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub barbtnImprimirListado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirListado.ItemClick
        grdviewImpresionOrdenesDisponibles.ShowRibbonPrintPreview()
    End Sub

    Private Sub barbtnImprimirSeleccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirSeleccion.ItemClick
        ImpresionOrdenSeleccionada()
    End Sub
End Class