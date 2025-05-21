Public Class frmAnalisisNecesidades


    Private Sub frmAnalisisNecesidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Controles()
            'mSeguridad.APG_Seguridad(Me, barbtnFichaArticulo)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Fill_Controles()
        Try

            mFunciones.FCN_FILL_SearchLookUpEdit(slueTipoArticulo, mSQLSelect.GET_PROD_CatListados("Tipo_Articulo"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueColor, mSQLSelect.GET_Catalogo_Colores(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoPadre, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoPadreInicial, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoPadreFinal, mSQLSelect.GET_Listado_ArticuloCP(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCampana, mSQLSelect.GET_Listado_CampanaVigentes(), "Id", "Id")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub sluePlantillas_Enter(sender As Object, e As EventArgs) Handles sluePlantillas.Enter
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(sluePlantillas, mSQLSelect.GET_Listado_Plantilla(), "Nombre", "Nombre")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub barbtnFiltro_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub barbtnGenerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Try
        '    If ssmEsperar.IsSplashFormVisible() = False Then

        '        ssmEsperar.ShowWaitForm()
        '        ssmEsperar.SetWaitFormCaption("Espere un Momento...")
        '        ssmEsperar.SetWaitFormDescription("Buscando Articulos...")
        '    End If

        '    Dim pDeLinea As String = String.Empty
        '    Dim pColor As String = String.Empty
        '    Dim pCodigoPadre As String = String.Empty
        '    Dim pCodigoPadreInicial As String = String.Empty
        '    Dim pCodigoPadreFinal As String = String.Empty
        '    Dim pPorcStock As String = String.Empty
        '    Dim pStockMenorA As String = String.Empty
        '    Dim pStockMayorA As String = String.Empty
        '    Dim pDeudaRol As String = String.Empty
        '    Dim pDeudaCampana As String = String.Empty
        '    Dim pDeudaProyeccion As String = String.Empty
        '    Dim pDeudaEnsamble As String = String.Empty
        '    Dim pCampana As String = String.Empty
        '    Dim pCliente As String = String.Empty

        '    If slueTipoArticulo.EditValue = Nothing Then : pDeLinea = "" : Else : pDeLinea = slueTipoArticulo.EditValue : End If
        '    If slueColor.EditValue = Nothing then : pColor = Nothing : else : pColor = slueColor.EditValue.ToString : End if
        '    If slueCodigoPadre.EditValue = Nothing Then : pCodigoPadre = Nothing : Else : pCodigoPadre = slueCodigoPadre.EditValue.ToString : End If
        '    If slueCodigoPadreFinal.EditValue = Nothing Then
        '        pCodigoPadreInicial = Nothing
        '        pCodigoPadreFinal = Nothing
        '    Else
        '        pCodigoPadreInicial = slueCodigoPadreInicial.EditValue.ToString
        '        pCodigoPadreFinal = slueCodigoPadreFinal.EditValue.ToString
        '    End If



        '    If Not slueCodigoPadreInicial.EditValue = Nothing Or Not slueCodigoPadreFinal.EditValue = Nothing Then
        '        If slueCodigoPadreInicial.EditValue = Nothing Then
        '            mMensajes.msg_Informacion("Falta valor de Codigo Padre Inicial")
        '            Exit Sub
        '        End If
        '        If slueCodigoPadreFinal.EditValue = Nothing Then
        '            mMensajes.msg_Informacion("Falta valor de Codigo Padre Final")
        '            Exit Sub
        '        End If
        '    End If

        '    If rdgStock.EditValue = "Stock%Minimo" Then
        '        If Not spinrdgStock.EditValue > 0 Then
        '            mMensajes.msg_Informacion("Debe de ingresar un porcentaje para calcular el Minimo.")
        '            Exit Sub
        '        Else
        '            pPorcStock = spinrdgStock.EditValue.ToString
        '        End If
        '    End If

        '    If spinMenorA.EditValue > 0 Then : pStockMenorA = spinMenorA.EditValue.ToString : Else : pStockMenorA = Nothing : End If
        '    If spinStockMayor.EditValue > 0 Then : pStockMayorA = spinStockMayor.EditValue.ToString : Else : pStockMayorA = Nothing : End If
        '    If spinDeudaRol.EditValue > 0 Then : pDeudaRol = spinDeudaRol.EditValue.ToString : Else : pDeudaRol = Nothing : End If
        '    If spinDeudaCampana.EditValue > 0 Then : pDeudaCampana = spinDeudaCampana.EditValue.ToString : Else : pDeudaCampana = Nothing : End If
        '    If spinDeudaProyeccion.EditValue > 0 Then : pDeudaProyeccion = spinDeudaProyeccion.EditValue.ToString : Else : pDeudaProyeccion = Nothing : End If
        '    If spinDeudaEnsamble.EditValue > 0 Then : pDeudaEnsamble = spinDeudaEnsamble.EditValue.ToString : Else : pDeudaEnsamble = Nothing : End If

        '    If slueCampana.EditValue = Nothing Then : pCampana = Nothing : Else : pCampana = slueCampana.EditValue.ToString : End If
        '    If slueCliente.EditValue = Nothing Then : pCliente = Nothing : Else : pCliente = slueCliente.EditValue.ToString : End If

        '    Dim dt As New DataTable()
        '    dt = mSQLSelect.GET_AnalisisNecesidades(pDeLinea, pColor, pCodigoPadre, pCodigoPadreInicial, pCodigoPadreFinal, rdgStock.EditValue.ToString, pPorcStock, pStockMenorA, pStockMayorA, pCampana, pCliente, pDeudaRol, pDeudaCampana, pDeudaProyeccion, pDeudaEnsamble)
        '    If dt.Rows.Count = Nothing Then
        '        Exit Sub
        '    End If

        '    DsAnalisisNecesidades1.Tables(DsAnalisisNecesidades1.dsdtAnalisisNecesidades.TableName.ToString).Clear()
        '    DsAnalisisNecesidades1.Tables(DsAnalisisNecesidades1.dsdtAnalisisNecesidades.TableName.ToString).Merge(dt)

        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'Finally
        '    If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        'End Try
    End Sub

    Private Sub rdgStock_EditValueChanged(sender As Object, e As EventArgs) Handles rdgStock.EditValueChanged
        Try
            If rdgStock.EditValue = "Ninguno" Then
                spinrdgStock.Enabled = False

            ElseIf rdgStock.EditValue = "MenorMinimo" Then
                spinrdgStock.Enabled = False

            ElseIf rdgStock.EditValue = "MenorMaximo" Then
                spinrdgStock.Enabled = False

            ElseIf rdgStock.EditValue = "EntreMinimoMaximo" Then
                spinrdgStock.Enabled = False

            ElseIf rdgStock.EditValue = "Menor%Minimo" Then
                spinrdgStock.Enabled = True


            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            'vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")

            frmTemporal_Stock.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_Stock.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEnsamble.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_Ensamble.ppOrigenesBodegas = "'1','2','3','4'"
            frmTemporal_Ensamble.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_Ensamble.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProduccion.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If

            frmTemporal_Produccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_Produccion.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaRol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaRol.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_DeudaRol.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaCampana.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_DeudaCampana.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaProyeccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaProyeccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_DeudaProyeccion.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            ssmEsperar.ShowWaitForm()
            grdviewAnalisisArticulos.ShowRibbonPrintPreview()
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewAnalisisArticulos.ExportToXlsx(sfdSave.FileName)
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

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewAnalisisArticulos)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_Continuar()
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                mMensajes.msg_Informacion("Debe de elegir un articulo valido!")
                Exit Sub
            End If


            frmTemporal_MoldesDeCodigo.ppCodigo = mFunciones.FCN_GetCellValue(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_MoldesDeCodigo.ShowDialog()

            If frmTemporal_MoldesDeCodigo.ppContinuar = False Then
                mMensajes.msg_Informacion("Se Canceló el proceso por el Usuario!")
                Exit Sub
            End If

            'Traer Moldes Seleccionados
            Dim pResultado_Moldes As String = String.Empty
            pResultado_Moldes = frmTemporal_MoldesDeCodigo.ppResultado()
            If pResultado_Moldes = Nothing Then
                mMensajes.msg_Informacion("No existen Datos para cargar! Codigos de Molde!!")
                Exit Sub
            End If

            'Traer Codigos Hijos Seleccionados
            Dim pResultado_CodigosHijos As String = String.Empty
            pResultado_CodigosHijos = mFunciones.FCN_GET_Columna(mSQLSelect.GET_ArticulosHijosPorMolde(pResultado_Moldes), "CodigoArticulo")

            If pResultado_CodigosHijos = Nothing Then
                mMensajes.msg_Informacion("No existen Datos para cargar! Codigos Hijos!!")
                Exit Sub
            End If

            frmOrdenEnsambleProduccion.ppCodigosArticulos = pResultado_CodigosHijos
            frmOrdenEnsambleProduccion.MdiParent = frmMenu
            frmOrdenEnsambleProduccion.WindowState = FormWindowState.Maximized
            frmOrdenEnsambleProduccion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnContinuar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnContinuar.ItemClick
        Try
            FCN_Continuar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub chkFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltro.CheckedChanged
        Try
            If chkFiltro.Checked = False Then
                splitAnalisisNecesidades.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                chkFiltro.Text = "Mostrar Filtro"
            Else
                splitAnalisisNecesidades.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                chkFiltro.Text = "Ocultar Filtro"
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Try
            'If ssmEsperar.IsSplashFormVisible() = False Then

            '    ssmEsperar.ShowWaitForm()
            '    ssmEsperar.SetWaitFormCaption("Espere un Momento...")
            '    ssmEsperar.SetWaitFormDescription("Buscando Articulos...")
            'End If
            'DevExpress esta dando problema

            Dim pDeLinea As String = String.Empty
            Dim pColor As String = String.Empty
            Dim pCodigoPadre As String = String.Empty
            Dim pCodigoPadreInicial As String = String.Empty
            Dim pCodigoPadreFinal As String = String.Empty
            Dim pPorcStock As String = String.Empty
            Dim pStockMenorA As String = String.Empty
            Dim pStockMayorA As String = String.Empty
            Dim pDeudaRol As String = String.Empty
            Dim pDeudaCampana As String = String.Empty
            Dim pDeudaProyeccion As String = String.Empty
            Dim pDeudaEnsamble As String = String.Empty
            Dim pCampana As String = String.Empty
            Dim pCliente As String = String.Empty

            If slueTipoArticulo.EditValue = Nothing Then : pDeLinea = "" : Else : pDeLinea = slueTipoArticulo.EditValue : End If
            If slueColor.EditValue = Nothing Then : pColor = Nothing : Else : pColor = slueColor.EditValue.ToString : End If
            If slueCodigoPadre.EditValue = Nothing Then : pCodigoPadre = Nothing : Else : pCodigoPadre = slueCodigoPadre.EditValue.ToString : End If
            If slueCodigoPadreFinal.EditValue = Nothing Then
                pCodigoPadreInicial = Nothing
                pCodigoPadreFinal = Nothing
            Else
                pCodigoPadreInicial = slueCodigoPadreInicial.EditValue.ToString
                pCodigoPadreFinal = slueCodigoPadreFinal.EditValue.ToString
            End If



            If Not slueCodigoPadreInicial.EditValue = Nothing Or Not slueCodigoPadreFinal.EditValue = Nothing Then
                If slueCodigoPadreInicial.EditValue = Nothing Then
                    mMensajes.msg_Informacion("Falta valor de Codigo Padre Inicial")
                    Exit Sub
                End If
                If slueCodigoPadreFinal.EditValue = Nothing Then
                    mMensajes.msg_Informacion("Falta valor de Codigo Padre Final")
                    Exit Sub
                End If
            End If

            If rdgStock.EditValue = "Stock%Minimo" Then
                If Not spinrdgStock.EditValue > 0 Then
                    mMensajes.msg_Informacion("Debe de ingresar un porcentaje para calcular el Minimo.")
                    Exit Sub
                Else
                    pPorcStock = spinrdgStock.EditValue.ToString
                End If
            End If

            If spinMenorA.EditValue > 0 Then : pStockMenorA = spinMenorA.EditValue.ToString : Else : pStockMenorA = Nothing : End If
            If spinStockMayor.EditValue > 0 Then : pStockMayorA = spinStockMayor.EditValue.ToString : Else : pStockMayorA = Nothing : End If
            If spinDeudaRol.EditValue > 0 Then : pDeudaRol = spinDeudaRol.EditValue.ToString : Else : pDeudaRol = Nothing : End If
            If spinDeudaCampana.EditValue > 0 Then : pDeudaCampana = spinDeudaCampana.EditValue.ToString : Else : pDeudaCampana = Nothing : End If
            If spinDeudaProyeccion.EditValue > 0 Then : pDeudaProyeccion = spinDeudaProyeccion.EditValue.ToString : Else : pDeudaProyeccion = Nothing : End If
            If spinDeudaEnsamble.EditValue > 0 Then : pDeudaEnsamble = spinDeudaEnsamble.EditValue.ToString : Else : pDeudaEnsamble = Nothing : End If

            If slueCampana.EditValue = Nothing Then : pCampana = Nothing : Else : pCampana = slueCampana.EditValue.ToString : End If
            If slueCliente.EditValue = Nothing Then : pCliente = Nothing : Else : pCliente = slueCliente.EditValue.ToString : End If

            Dim dt As New DataTable()
            dt = mSQLSelect.GET_AnalisisNecesidades(pDeLinea, pColor, pCodigoPadre, pCodigoPadreInicial, pCodigoPadreFinal, rdgStock.EditValue.ToString, pPorcStock, pStockMenorA, pStockMayorA, pCampana, pCliente, pDeudaRol, pDeudaCampana, pDeudaProyeccion, pDeudaEnsamble)
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsAnalisisNecesidades1.Tables(DsAnalisisNecesidades1.dsdtAnalisisNecesidades.TableName.ToString).Clear()
            DsAnalisisNecesidades1.Tables(DsAnalisisNecesidades1.dsdtAnalisisNecesidades.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            'If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub grdviewAnalisisArticulos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewAnalisisArticulos.DoubleClick
        Try
            FCN_Continuar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnFichaArticulo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFichaArticulo.ItemClick
        Try
            frmTemporal_FichaArticulo.ppCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_FichaArticulo.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaEnsamble.ItemClick
        Try
            If grdviewAnalisisArticulos.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaEnsamble.ppOrigenesBodegas = "'0','1','2','3','4'"
            frmTemporal_DeudaEnsamble.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_DeudaEnsamble.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAnalisisVentas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAnalisisVentas.ItemClick
        Try

            frmTemporal_AnalisisVenta.ppCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewAnalisisArticulos, "CodigoArticulo")
            frmTemporal_AnalisisVenta.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class