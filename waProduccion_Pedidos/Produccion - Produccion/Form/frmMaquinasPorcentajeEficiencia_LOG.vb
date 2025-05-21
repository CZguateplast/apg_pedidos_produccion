Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data



Public Class frmMaquinasPorcentajeEficiencia_LOG

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewPorcEficienciaMaquinas)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            grdviewPorcEficienciaMaquinas.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmPorcEficienciaMaquinas_LOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sub_PorcEficienciaMaquinas()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub sub_PorcEficienciaMaquinas()
        Try
            Dim dt As New DataTable("dtPorcEficienciaMaquinas")
            dt = mSQLSelect.GET_PorcEficienciaMaquinas_LOG()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsPorcEficienciaMaquinas1.Tables("dsdtPorcEficienciaMaquinas_LOG").Clear()
            DsPorcEficienciaMaquinas1.Tables("dsdtPorcEficienciaMaquinas_LOG").Merge(dt)

            grdviewPorcEficienciaMaquinas.Columns("Fecha").GroupIndex = 0
            grdviewPorcEficienciaMaquinas.CollapseAllGroups()
            grdviewPorcEficienciaMaquinas.Columns("Fecha").SortOrder = ColumnSortOrder.Descending

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



End Class