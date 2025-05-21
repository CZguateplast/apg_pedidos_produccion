Public Class frmAnalisisArticulos

    Private Sub frmPedidoIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sub_Seguridad_APG()
        ValoresDefault()
    End Sub
    Private Sub ValoresDefault()
        mFunciones.FCN_FILL_SearchLookUpEdit(slueDeLinea, mSQLSelect.GET_PROD_CatListados("Tipo_Articulo"), "Id", "Nombre")

        mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
        mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticuloInicial, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
        mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticuloFinal, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
        mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
        mFunciones.FCN_FILL_SearchLookUpEdit(slueCampana, mSQLSelect.GET_Listado_CampanaVigentes(), "Id", "Id")

    End Sub

    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, btnPlantillaGrabar)
            mSeguridad.APG_Seguridad(Me, btnPlantillaEliminar)
            mSeguridad.APG_Seguridad(Me, btnPlantillaActualizar)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub wzcProduccionPedidos_CancelClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles wzcProduccionPedidos.CancelClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub


    Private Sub wzcProduccionPedidos_SelectedPageChanging(sender As Object, e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles wzcProduccionPedidos.SelectedPageChanging
        Try

            'Producción Analisis
            If e.Direction = DevExpress.XtraWizard.Direction.Forward And e.Page.Name = "wzpAnalisis" Then
                ssmEsperar.ShowWaitForm()
                Dim dt As New DataTable
                Dim pDeLinea As String = String.Empty
                Dim pColor As String = String.Empty
                Dim pCodigoArticulo As String = String.Empty

                Dim pCodigoArticuloInicial As String = String.Empty
                Dim pCodigoArticuloFinal As String = String.Empty

                Dim pStockMenorMinimo As Boolean = False
                Dim pMayorstock As Integer = 0
                Dim pMenortock As Integer = 0
                Dim pCampana As String = String.Empty
                Dim pCodigoCliente As String = String.Empty
                Dim pMayorDeudaRol As Integer = 0
                Dim pMayorDeudaCampana As Integer = 0
                Dim pMayorDeudaProyeccion As Integer = 0
                '-----------------------------------------------------------------------------
                If slueDeLinea.Text = String.Empty Then : pDeLinea = String.Empty : Else : pDeLinea = slueDeLinea.EditValue : End If
                If slueColor.Text = String.Empty Then : pColor = String.Empty : Else : pColor = slueColor.EditValue : End If

                If slueCodigoArticulo.Text = String.Empty Then : pCodigoArticulo = String.Empty : Else : pCodigoArticulo = slueCodigoArticulo.EditValue : End If
                If slueCodigoArticuloInicial.Text = String.Empty And slueCodigoArticuloFinal.Text = String.Empty Then : pCodigoArticuloInicial = String.Empty : pCodigoArticuloFinal = String.Empty : Else : pCodigoArticuloInicial = slueCodigoArticuloInicial.Text : pCodigoArticuloFinal = slueCodigoArticuloFinal.Text : End If

                If chkStockMenorMinimo.Checked = True Then : pStockMenorMinimo = True : Else : pStockMenorMinimo = False : End If
                If txtMayorStock.Text = "" Then : pMayorstock = 0 : Else : pMayorstock = txtMayorStock.EditValue : End If
                If txtMenorStock.Text = "" Then : pMenortock = 0 : Else : pMenortock = txtMenorStock.EditValue : End If
                If slueCampana.Text = String.Empty Then : pCampana = String.Empty : Else : pCampana = slueCampana.EditValue : End If
                If slueCodigoCliente.Text = String.Empty Then : pCodigoCliente = String.Empty : Else : pCodigoCliente = slueCodigoCliente.Text : End If
                If txtMayorDeudaRol.Text = "" Then : pMayorDeudaRol = 0 : Else : pMayorDeudaRol = txtMayorDeudaRol.EditValue : End If
                If txtMayorDeudaCampana.Text = "" Then : pMayorDeudaCampana = 0 : Else : pMayorDeudaCampana = txtMayorDeudaCampana.EditValue : End If
                If txtMayorDeudaProyeccion.Text = "" Then : pMayorDeudaProyeccion = 0 : Else : pMayorDeudaProyeccion = txtMayorDeudaProyeccion.EditValue : End If

                'dt = mSQLSelect.GET_AnalisisArticulos_XFiltro(pDeLinea, pColor, pCodigoArticulo, pCodigoArticuloInicial, pCodigoArticuloFinal, pStockMenorMinimo, pMayorstock, pMenortock, _
                '                                             pCampana, pCodigoCliente, pMayorDeudaRol, pMayorDeudaCampana, pMayorDeudaProyeccion)

                DsPedidoIngreso.Tables("dsdtAnalisisArticulos").Clear() 'Borrar DataSet
                DsPedidoIngreso.Tables("dsdtAnalisisArticulos").Merge(dt) 'Llenar DSDT con Qry

            ElseIf e.Direction = DevExpress.XtraWizard.Direction.Forward And e.Page.Name = "wzpRelacionCP" Then
                If grdviewAnalsis.SelectedRowsCount > 0 Then
                    ssmEsperar.ShowWaitForm()
                    Dim dt As New DataTable
                    dt = mSQLSelect.GET_RelacionCP(mFunciones.FCN_XTRAGRID_GetCodigoPadre(grdviewAnalsis, "CodigoArticulo"))
                    If dt.Rows.Count = 0 Then
                    Else
                        DsPedidoIngreso.Tables("dsdtRelacionCP").Clear() 'Borrar DataSet
                        DsPedidoIngreso.Tables("dsdtRelacionCP").Merge(dt) 'Llenar DSDT con Qry
                    End If

                    grdviewRelacionCP.SelectAll() 'Seleccionar Todas las Filas
                Else
                    mMensajes.msg_Informacion("Seleccione 1 Articulo como minimo para poder continuar")
                    e.Page = wzpAnalisis

                End If

            ElseIf e.Direction = DevExpress.XtraWizard.Direction.Forward And e.Page.Name = "wzpRelacionARPadres" Then
                If grdviewRelacionCP.SelectedRowsCount > 0 Then
                    ssmEsperar.ShowWaitForm()
                    Dim dt As New DataTable
                    Dim dt1 As New DataTable
                    Dim Lista As String
                    dt1 = GET_RelacionARLista(mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewRelacionCP, "Molde"))
                    Lista = FCN_XTRAGRID_GetFilasSeleccionadas(dt1, "CodigoPadre")
                    dt = GET_RelacionARPadres(Lista)
                    DsPedidoIngreso.Tables("dsdtRelacionARPadres").Clear() 'Borrar DataSet
                    DsPedidoIngreso.Tables("dsdtRelacionARPadres").Merge(dt) 'Llenar DSDT con Qry

                    grdviewRelacionARPadres.SelectAll() 'Seleccionar Todas las Filas
                Else
                    mMensajes.msg_Informacion("Seleccione 1 Articulo como minimo para poder continuar")
                    e.Page = wzpRelacionCP
                End If

            ElseIf e.Direction = DevExpress.XtraWizard.Direction.Forward And e.Page.Name = "wzpArticulosAnalisis" Then
                If grdviewRelacionARPadres.SelectedRowsCount > 0 Then
                    ssmEsperar.ShowWaitForm()
                    Dim dt As New DataTable
                    Dim pLista As String = String.Empty
                    pLista = FCN_SEARCH_Articulos_XPadres(mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewRelacionARPadres))
                    dt = mSQLSelect.GET_AnalisisArticulos_XFiltro(pLista)
                    DsPedidoIngreso.Tables("dsdtArticulosResultado").Clear() 'Borrar DataSet
                    DsPedidoIngreso.Tables("dsdtArticulosResultado").Merge(dt) 'Llenar DSDT con Qry
                Else
                    mMensajes.msg_Informacion("Seleccione 1 Articulo como minimo para poder continuar")
                    e.Page = wzpRelacionARPadres
                End If

            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try

    End Sub


    Private Sub FCN_CreateConsultaTemporal(ByVal dt As DataTable)
        Try

            Dim frmTemporal As New System.Windows.Forms.Form
            Dim grdTemporal As New DevExpress.XtraGrid.GridControl
            Dim grdviewTemporal As New DevExpress.XtraGrid.Views.Grid.GridView

            grdTemporal.ViewCollection.Add(grdviewTemporal)
            grdTemporal.Dock = DockStyle.Fill
            grdviewTemporal.OptionsView.ShowGroupPanel = False
            grdviewTemporal.OptionsBehavior.ReadOnly = True

            grdTemporal.MainView = grdviewTemporal
            grdTemporal.BindingContext = New BindingContext()
            grdTemporal.DataSource = dt
            frmTemporal.Controls.Add(grdTemporal)
            frmTemporal.StartPosition = FormStartPosition.CenterScreen
            frmTemporal.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#Region "BarbtnXtras"
    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            frmTemporal_Stock.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_Stock.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnStock2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock2.ItemClick
        Try
            vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_Stock.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEnsamble.ItemClick
        Try
            frmTemporal_Ensamble.ppOrigenesBodegas = "'1','2','3','4'"
            frmTemporal_Ensamble.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_Ensamble.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnEnsamble2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEnsamble2.ItemClick
        Try
            vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_Ensamble.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProduccion.ItemClick
        Try
            frmTemporal_Produccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_Produccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnProduccion2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProduccion2.ItemClick
        Try
            frmTemporal_Produccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_Produccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnDeudaRol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol.ItemClick
        Try
            frmTemporal_DeudaRol.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_DeudaRol.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnDeudaRol2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol2.ItemClick
        Try
            frmTemporal_DeudaRol.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_DeudaRol.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnDeudaCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana.ItemClick
        Try
            frmTemporal_DeudaCampana.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_DeudaCampana.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnDeudaCampana2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana2.ItemClick
        Try
            frmTemporal_DeudaCampana.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_DeudaCampana.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnDeudaProyeccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion.ItemClick
        Try
            frmTemporal_DeudaProyeccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalsis, "CodigoArticulo")
            frmTemporal_DeudaProyeccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnDeudaProyeccion2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion2.ItemClick
        Try
            frmTemporal_DeudaProyeccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmTemporal_DeudaProyeccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region

#Region "BarbtnFunciones"
    Private Sub barbtnVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia.ItemClick
        Try
            ssmEsperar.ShowWaitForm()
            grdviewAnalsis.ShowRibbonPrintPreview()
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnVistaPrevia2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia2.ItemClick
        Try
            ssmEsperar.ShowWaitForm()
            grdviewArticulosAnalisis.ShowRibbonPrintPreview()
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            grdviewAnalsis.PrintDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub barbtnImprimir2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir2.ItemClick
        Try
            grdviewArticulosAnalisis.PrintDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXLSX_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXLSX.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewAnalsis.ExportToXlsx(sfdSave.FileName)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnExportarXLSX2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXLSX2.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewArticulosAnalisis.ExportToXlsx(sfdSave.FileName)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        FCN_XTRAGRID_Buscar(grdviewAnalsis)
    End Sub
    Private Sub barbtnBuscar2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar2.ItemClick
        FCN_XTRAGRID_Buscar(grdviewArticulosAnalisis)
    End Sub
#End Region

    Private Sub barbtnOk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        wzcProduccionPedidos.SetNextPage()
    End Sub

    Private Sub barbtnGenerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGenerar.ItemClick
        Try
            vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmOrdenEnsambleProduccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    
    Private Sub sluePlantillas_Enter(sender As Object, e As EventArgs) Handles sluePlantillas.Enter
        mFunciones.FCN_FILL_SearchLookUpEdit(sluePlantillas, mSQLSelect.GET_Listado_Plantilla(), "Nombre", "Nombre")

    End Sub

    Private Sub sluePlantillas_EditValueChanged(sender As Object, e As EventArgs) Handles sluePlantillas.EditValueChanged
        Try
            Dim dt As New DataTable("dtPlantilla")
            dt = mSQLSelect.GET_Plantilla_XNombre(sluePlantillas.EditValue)
            If Not dt.Rows.Count = Nothing Then
                slueDeLinea.EditValue = dt.Rows(0)("DeLinea").ToString
                slueCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticuloPadre").ToString
                slueCampana.EditValue = dt.Rows(0)("NumeroCampana").ToString
                txtMayorStock.EditValue = dt.Rows(0)("StockMayorA")
                txtMenorStock.EditValue = dt.Rows(0)("StockMenorA")
                txtMayorDeudaRol.EditValue = dt.Rows(0)("DeudaRolMayorA")
                txtMayorDeudaCampana.EditValue = dt.Rows(0)("DeudaCampanaMayorA")
                txtMayorDeudaProyeccion.EditValue = dt.Rows(0)("DeudaProyeccionMayorA")
                slueColor.EditValue = dt.Rows(0)("Color").ToString
                slueCodigoArticuloInicial.EditValue = dt.Rows(0)("CodigoArticuloInicial").ToString
                slueCodigoArticuloFinal.EditValue = dt.Rows(0)("CodigoArticuloFinal").ToString
                slueCodigoCliente.EditValue = dt.Rows(0)("CodigoCliente").ToString
                chkStockMenorMinimo.Checked = dt.Rows(0)("StockMenorMinimo").ToString



            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPlantillaActualizar_Click(sender As Object, e As EventArgs) Handles btnPlantillaActualizar.Click
        Try
            If Not sluePlantillas.EditValue = Nothing Then
                If mMensajes.msg_Actualizar() Then
                    Dim pArrayList As New ArrayList
                    pArrayList.Add(sluePlantillas.EditValue) '0
                    pArrayList.Add(slueDeLinea.EditValue) '1
                    pArrayList.Add(slueCodigoArticulo.EditValue) '2
                    pArrayList.Add(slueCampana.EditValue) '3
                    pArrayList.Add(txtMayorStock.EditValue) '4
                    pArrayList.Add(txtMenorStock.EditValue) '5
                    pArrayList.Add(txtMayorDeudaRol.EditValue) '6
                    pArrayList.Add(txtMayorDeudaCampana.EditValue) '7
                    pArrayList.Add(txtMayorDeudaProyeccion.EditValue) '8
                    pArrayList.Add(slueColor.EditValue) '9
                    pArrayList.Add(slueCodigoArticuloInicial.EditValue) ' 10
                    pArrayList.Add(slueCodigoArticuloFinal.EditValue) ' 11
                    pArrayList.Add(slueCodigoCliente.EditValue) '12
                    pArrayList.Add(chkStockMenorMinimo.Checked) '13

                    If mSQLUpdate.UPDATE_Plantilla(pArrayList) Then
                        mMensajes.msg_Proceso_ok()
                    Else
                        mMensajes.msg_Proceso_Error()
                    End If
                End If
            Else
                mMensajes.msg_Error("Debe de seleccionar una Plantilla para poder Actualizar")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPlantillaEliminar_Click(sender As Object, e As EventArgs) Handles btnPlantillaEliminar.Click
        Try
            If Not sluePlantillas.EditValue = Nothing Then
                If mMensajes.msg_Eliminar() Then
                    If mSQLDelete.DELETE_Plantilla(sluePlantillas.EditValue) Then
                        mMensajes.msg_Proceso_ok()
                    Else
                        mMensajes.msg_Proceso_Error()
                    End If
                End If
            Else
                mMensajes.msg_Error("Debe de seleccionar una Plantilla para poder Eliminar")
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub chkStockMenorMinimo_CheckedChanged(sender As Object, e As EventArgs) Handles chkStockMenorMinimo.CheckedChanged
        Try
            If chkStockMenorMinimo.Checked = True Then
                txtMayorStock.Enabled = False
                txtMenorStock.Enabled = False
                txtMayorStock.Text = String.Empty
                txtMenorStock.Text = String.Empty
            Else
                txtMayorStock.Enabled = True
                txtMenorStock.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub

    Private Sub slueCodigoCliente_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigoCliente.EditValueChanged
        Try
            Dim dt As New DataTable("NombreCliente")
            dt = mSQLSelect.GET_Listado_ClientesDisponibles(slueCodigoCliente.EditValue)
            If Not dt.Rows.Count = Nothing Then
                mmeNombreCliente.EditValue = dt.Rows(0)("NombreCliente").ToString
            Else
                mmeNombreCliente.EditValue = String.Empty
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCampana_EditValueChanged(sender As Object, e As EventArgs) Handles slueCampana.EditValueChanged

        Try
            Dim dt As New DataTable("NombreCliente")
            dt = mSQLSelect.GET_Listado_CampanaVigentes(slueCampana.EditValue)
            If Not dt.Rows.Count = Nothing Then
                mmeNombreCampana.EditValue = dt.Rows(0)("NombreCampana").ToString
            Else
                mmeNombreCampana.EditValue = String.Empty
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewAnalsis_DoubleClick(sender As Object, e As EventArgs) Handles grdviewAnalsis.DoubleClick
        Try
            wzcProduccionPedidos.SelectedPage = wzpRelacionCP
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewArticulosAnalisis_DoubleClick(sender As Object, e As EventArgs) Handles grdviewArticulosAnalisis.DoubleClick
        Try
            vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewArticulosAnalisis, "CodigoArticulo")
            frmOrdenEnsambleProduccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPlantillaGrabar_Click(sender As Object, e As EventArgs) Handles btnPlantillaGrabar.Click
        Try
            If Not txtPlantillaGrabarNombre.EditValue = String.Empty Then
                Dim dt As New DataTable("dtValidarNombrePlantilla")
                dt = mSQLSelect.GET_Validar_NombrePlantilla(txtPlantillaGrabarNombre.EditValue)
                If dt.Rows(0)(0).ToString = 0 Then
                    Dim pArrayList As New ArrayList
                    pArrayList.Add(txtPlantillaGrabarNombre.EditValue) '0
                    pArrayList.Add(slueDeLinea.EditValue) '1
                    pArrayList.Add(slueCodigoArticulo.EditValue) '2
                    pArrayList.Add(slueCampana.EditValue) '3
                    pArrayList.Add(txtMayorStock.EditValue) '4
                    pArrayList.Add(txtMenorStock.EditValue) '5
                    pArrayList.Add(txtMayorDeudaRol.EditValue) '6
                    pArrayList.Add(txtMayorDeudaCampana.EditValue) '7
                    pArrayList.Add(txtMayorDeudaProyeccion.EditValue) '8
                    pArrayList.Add(slueColor.EditValue) '9
                    pArrayList.Add(slueCodigoArticuloInicial.EditValue) ' 10
                    pArrayList.Add(slueCodigoArticuloFinal.EditValue) ' 11
                    pArrayList.Add(slueCodigoCliente.EditValue) '12
                    pArrayList.Add(chkStockMenorMinimo.Checked) '13

                    If mSQLInsert.INSERT_Plantilla(pArrayList) Then
                        mMensajes.msg_Proceso_ok()
                    Else
                        mMensajes.msg_Error("No se a podido Grabar la Plantilla")
                    End If
                Else
                    mMensajes.msg_Error("No se a podido Grabar la Plantilla. Ya existe con este nombre")
                    txtPlantillaGrabarNombre.Focus()
                End If
            Else
                mMensajes.msg_Error("Ingrese Nombre para poder grabar la Plantilla")
                txtPlantillaGrabarNombre.Focus()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class