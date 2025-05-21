Public Class frmResultadoOrdenesIngresadas

    Private Sub frmIngresoOrdenSAPResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
        mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestino, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")

        DsIngresoOrden1.Tables("dsdtSAPResultados").Clear() 'Borrar DataSet
        DsIngresoOrden1.Tables("dsdtSAPResultados").Merge(vpTabla1) 'Llenar DSDT con Qry

    End Sub

    Private Sub barbtnVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia.ItemClick
        Try
            grdviewOrdenIngresoSAPResultado.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        sfdSave.Filter = "Archivos Excel | *.xlsx"
        If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            grdviewOrdenIngresoSAPResultado.ExportToXlsx(sfdSave.FileName)
        End If
    End Sub
End Class