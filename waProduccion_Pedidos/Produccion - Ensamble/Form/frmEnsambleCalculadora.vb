Imports DevExpress.XtraReports.UI

Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Public Class frmEnsambleCalculadora

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            If Not grdviewEnsambleCalculadora.RowCount = Nothing Then
                If MsgBox("Seguro que desea salir del la Ventana  " + Me.Text.ToString + " ?", MsgBoxStyle.YesNo, "Guardar Antes de Salir...") = MsgBoxResult.Yes Then
                    Me.Close()
                End If
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscarCodigo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscarCodigo.ItemClick
        Try
            Dim dt As New DataTable()
            Dim pCodigos As String = String.Empty

            frmTemporal_Lista.ppTabla = mSQLSelect.GET_Catalogo_AR_CP_Hijos()
            frmTemporal_Lista.ShowDialog()

            pCodigos = frmTemporal_Lista.ppResultado

            If pCodigos = Nothing Then
                Exit Sub
            End If

            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[EnsambleCalculadora_Lista] '" + pCodigos + "'")

            If Not DsEnsambleCalculadora1.dsdtEnsambleCalculadora.Rows.Count = Nothing Then
                If MsgBox("Desea BORRAR los datos en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
                End If
            End If

            If Not dt.Rows.Count = Nothing Then
                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Merge(dt)
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub




    'Private Sub barbtnBuscarCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscarCampana.ItemClick
    '    Try

    '        Dim dt As New DataTable()
    '        Dim dtCampana As New DataTable()
    '        Dim pCampana As String = String.Empty
    '        Dim pCodigos As String = String.Empty


    '        frmTemporal_Lista.ppTabla = GET_Listado_Campanas()
    '        frmTemporal_Lista.ShowDialog()
    '        pCampana = frmTemporal_Lista.ppResultado

    '        If pCampana = Nothing Then
    '            Exit Sub
    '        End If

    '        If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
    '        ssmEsperar.SetWaitFormCaption("Espere...Buscando")
    '        ssmEsperar.SetWaitFormDescription("Articulos en la Campaña...")
    '        'dtCampana = GET_Listado_Campanas_Detalle("'" + pCampana + "'")

    '        'If dtCampana.Rows.Count = Nothing Then
    '        'MsgBox("No existen Articulos en esta Campaña <" + pCampana + " >. ")
    '        'Exit Sub
    '        'End If

    '        'pCodigos = mFunciones.FCN_GET_Columna(dtCampana, "CodigoArticulo")

    '        'pCodigos = "SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id IN (CONVERT(VARCHAR(10)," + pCampana + "))"



    '        dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[EnsambleCalculadora_Lista_Campana] '" + pCampana + "'")

    '        If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
    '        If Not DsEnsambleCalculadora1.dsdtEnsambleCalculadora.Rows.Count = Nothing Then
    '            If MsgBox("Desea BORRAR los datos en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
    '                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
    '            End If
    '        End If

    '        If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
    '        ssmEsperar.SetWaitFormCaption("Espere...Buscando")
    '        ssmEsperar.SetWaitFormDescription("Articulos en la Campaña...")

    '        If Not dt.Rows.Count = Nothing Then
    '            DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Merge(dt)
    '        End If

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    Finally
    '        If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
    '    End Try
    'End Sub



    Private Sub barbtnDuplicarEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicarEnsamble.ItemClick
        Try
            Sub_Duplicar("Ensamble")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_Duplicar(ByVal pTipo As String)
        Try
            'Duplicar la Row
            If MsgBox("¿Desea > Duplicar < el articulo:" + Chr(13) + "[" + mFunciones.FCN_GetCellValue(grdviewEnsambleCalculadora, "CodigoArticulo") + " ]" + Chr(13) + "[ " + mFunciones.FCN_GetCellValue(grdviewEnsambleCalculadora, "NombreArticulo") + "] ?", MsgBoxStyle.YesNo, "Duplicar") = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            ssmEsperar.SetWaitFormCaption("Espere un Momento")
            ssmEsperar.SetWaitFormDescription("Duplicando..." + pTipo)

            Dim pRow As DataRow = grdviewEnsambleCalculadora.GetDataRow(grdviewEnsambleCalculadora.FocusedRowHandle)
            Dim dt As DataTable = DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString)
            Dim dt2 As DataTable = dt.Clone()

            dt.ImportRow(pRow)
            dt.Rows(dt.Rows.Count - 1)("Grupo") = mFunciones.FCN_GetCellValue(grdviewEnsambleCalculadora, "Grupo")
            dt.Rows(dt.Rows.Count - 1)("Tipo") = pTipo
            grdEnsambleCalculadora.DataSource = dt

            'Ordenar la Row
            DsEnsambleCalculadora1.dsdtEnsambleCalculadora.DefaultView.Sort = "CodigoArticulo,Grupo ASC"
            'Actualizar la Row
            grdviewEnsambleCalculadora.UpdateCurrentRow()
            DsEnsambleCalculadora1.dsdtEnsambleCalculadora.AcceptChanges()

        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub barbtnDuplicarBotadero_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicarBotadero.ItemClick
        Try
            Sub_Duplicar("Botadero")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDuplicarEmpaque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicarEmpaque.ItemClick
        Try
            Sub_Duplicar("Empaque")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDuplicarImprenta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicarImprenta.ItemClick
        Try
            Sub_Duplicar("Imprenta")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDuplicarOtros_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicarOtros.ItemClick
        Try
            Sub_Duplicar("Otros")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEnsambleCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sccEnsambleCalculadora.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        barbtnMostrar.Caption = "Mostrar"
        'Sub_Grupos_Sumar()


    End Sub

    Private Sub Sub_Grupos_Sumar()
        Try

            Dim groupSummary As New DevExpress.XtraGrid.GridGroupSummaryItem
            groupSummary.ShowInGroupColumnFooter = grdviewEnsambleCalculadora.Columns(colHorasXPersona.FieldName.ToString)
            groupSummary.DisplayFormat = "{0:n2}"
            groupSummary.FieldName = colHorasXPersona.FieldName.ToString
            groupSummary.SummaryType = DevExpress.Data.SummaryItemType.Sum

            Dim groupSummary2 As New DevExpress.XtraGrid.GridGroupSummaryItem
            groupSummary2.ShowInGroupColumnFooter = grdviewEnsambleCalculadora.Columns(colHoras.FieldName.ToString)
            groupSummary2.DisplayFormat = "{0:n2}"
            groupSummary2.FieldName = colHoras.FieldName.ToString
            groupSummary2.SummaryType = DevExpress.Data.SummaryItemType.Sum

            grdviewEnsambleCalculadora.GroupSummary.Add(groupSummary)
            grdviewEnsambleCalculadora.GroupSummary.Add(groupSummary2)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewEnsambleCalculadora)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscarPadre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscarPadre.ItemClick
        Try
            Dim dt As New DataTable()
            Dim dtCodigos As New DataTable()
            Dim pCodigoPadre As String = String.Empty
            Dim pCodigos As String = String.Empty


            frmTemporal_Lista.ppTabla = GET_Catalogo_AR_CP_Padres()
            frmTemporal_Lista.ShowDialog()

            pCodigoPadre = frmTemporal_Lista.ppResultado

            If pCodigoPadre = Nothing Then
                Exit Sub
            End If

            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[EnsambleCalculadora_Lista_CodigoPadre] '" + pCodigoPadre + "%'")

            If Not DsEnsambleCalculadora1.dsdtEnsambleCalculadora.Rows.Count = Nothing Then
                If MsgBox("Desea BORRAR los datos en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
                End If
            End If

            If Not dt.Rows.Count = Nothing Then
                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Merge(dt)
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEnsambleCalculadora_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewEnsambleCalculadora.CellValueChanged
        Try
            If e.Column.Name = colHoras.Name Then
                Sub_Grupos_Sumar()
            End If

            fcn_CalculoTiempo()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub fcn_CalculoTiempo()
        Try
            Dim pHorasPendientes As String = grdviewEnsambleCalculadora.Columns("HorasXPersona").SummaryItem.SummaryValue
            Dim pHorasDiarias As String = spinHorasDiarias.EditValue
            Dim pXPersonas As String = spinXPersonas.EditValue
            Dim pXDiastrabajo As String = spinXdiasTrabajo.EditValue
            Dim pSueldoBase As String = "2800"
            Dim pSueldoDiaBase As String = String.Empty
            Dim pSueldoHoraExtra As String = String.Empty
            Dim pHorasExtras As String = String.Empty


            If Val(pHorasPendientes) = Nothing Then
                mMensajes.msg_Error("No existen Horas de Trabajo")
                Exit Sub
            End If

            spinHorasPendientes.EditValue = pHorasPendientes

            If Val(pHorasDiarias) < "1" Then
                Exit Sub
            ElseIf Val(pXPersonas) < "1" And Val(pXDiastrabajo) < "1" Then
                Exit Sub
            End If


            If Val(pXPersonas) > 0 Then
                'Calculo por Dia
                spinResultado_DiasTrabajo.EditValue = (Val(pHorasPendientes) / Val(pHorasDiarias)) / Val(pXPersonas)
            End If

            If Val(pXDiastrabajo) > 0 Then
                'Calculo por Personas
                spinResultadoCantidadPersonas.EditValue = (Val(pHorasPendientes) / Val(pHorasDiarias)) / Val(pXDiastrabajo)
            End If


            pSueldoDiaBase = Val(pSueldoBase) / 30
            spinResultadoXPersona_Base.EditValue = Val(pSueldoDiaBase) * spinResultado_DiasTrabajo.EditValue * spinXPersonas.EditValue

            pHorasExtras = spinHorasDiarias.EditValue - 8

            If pHorasDiarias > 0 Then
                pSueldoHoraExtra = (pSueldoDiaBase / 8) * 1.5
                spinResultadoXPersona_Extras.EditValue = Val(pHorasExtras) * spinResultado_DiasTrabajo.EditValue * Val(pSueldoHoraExtra) * pXPersonas
            End If

            spinTotalXCompleto.EditValue = spinResultadoXPersona_Base.EditValue + spinResultadoXPersona_Extras.EditValue

            If spinResultadoXPersona_Base.EditValue > 1 Then
                spinResultadoSueldoBase_Dia.EditValue = spinResultadoXPersona_Base.EditValue / spinResultado_DiasTrabajo.EditValue
            End If

            If spinResultadoXPersona_Extras.EditValue > 1 Then
                spinResultadoSueldoExtra_Dia.EditValue = spinResultadoXPersona_Extras.EditValue / spinResultado_DiasTrabajo.EditValue
            End If




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnNuevo.ItemClick
        Try
            If grdviewEnsambleCalculadora.RowCount = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea comenzar un Nuevo Listado?", MsgBoxStyle.YesNo, "Nuevo") = MsgBoxResult.Yes Then
                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEnsambleDeuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEnsambleDeuda.ItemClick
        Try

            If Not DsEnsambleCalculadora1.dsdtEnsambleCalculadora.Rows.Count = Nothing Then
                If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
                If MsgBox("Desea BORRAR los datos en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
                End If
                If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            End If

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            ssmEsperar.SetWaitFormCaption("Espere un Momento")
            ssmEsperar.SetWaitFormDescription("Buscando Deuda de Ensambles...")

            Dim pUbicaciones As String = String.Empty
            pUbicaciones = fcn_UbicacionesSeleccionadas()


            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[EnsambleCalculadora_Lista_EnsamblesPendientes]" + My.Settings.log_Usuario.ToString + "," + My.Application.Info.Title.ToString)

            If Not dt.Rows.Count = Nothing Then
                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub grdviewEnsambleCalculadora_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles grdviewEnsambleCalculadora.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "HorasXEquipo" Or e.Column.FieldName = "HorasXPersona" Then
                If Not e.Value Is Nothing Then
                    If e.Value.ToString = "#Err" Then
                        e.DisplayText = 0.0
                    End If
                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            FCN_XTRAGRID_ImprimirGrid(grdviewEnsambleCalculadora)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewEnsambleCalculadora, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewEnsambleCalculadora)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnMultiSeleccion_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick

        Try
            Process.Start(Application.StartupPath.ToString + "\Help\helpEnsambleCalculadora.png")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

 

    Private Sub barbtnDetalleOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleOrden.ItemClick
        If grdviewEnsambleCalculadora.RowCount = Nothing Then
            Exit Sub
        End If

        Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewEnsambleCalculadora, "CodigoArticulo")

        If pCodigoArticulo = Nothing Then
            Exit Sub
        End If

        frmTemporal_OrdenesProduccionEnsambleDetalle.ppCodigoTipo = "AR"
        frmTemporal_OrdenesProduccionEnsambleDetalle.ppCodigoArticulo = pCodigoArticulo
        frmTemporal_OrdenesProduccionEnsambleDetalle.ShowDialog(Me)


    End Sub

    Private Sub barbtnImpresionFormato_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImpresionFormato.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEnsambleCalculadora
            RPTdocumento.DataSource = Me.DsEnsambleCalculadora1
            RPTdocumento.DataMember = Me.DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)


            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_ProgramacionProduccionFinal")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                            "Programacion Produccion Final", _
            '                                            "Detalle de Programacion", _
            '                                            "Reporte_ProgramacionProduccionFinal")

            PrintTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            fcn_CalculoTiempo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnMostrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnMostrar.ItemClick
        Try
            FCN_Ajustar_Split()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Ajustar_Split()
        Try

            Dim pTamanoSplit1 As Integer = 0
            Dim pFormSize As Integer = 0

            pFormSize = Me.Size.Width

            pTamanoSplit1 = Me.Size.Width - 320
            sccEnsambleCalculadora.SplitterPosition = pTamanoSplit1


            If barbtnMostrar.Down = False Then
                sccEnsambleCalculadora.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                barbtnMostrar.Caption = "Mostrar"
            Else
                sccEnsambleCalculadora.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                barbtnMostrar.Caption = "Ocultar"
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEnsambleCalculadora_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Try
            FCN_Ajustar_Split()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Function fcn_UbicacionesSeleccionadas() As String
        Try
            Dim pUbicaciones As String = String.Empty

            mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[sp_PROD_Filtros_Delete]" + My.Settings.log_Usuario.ToString + "," + My.Application.Info.Title.ToString)

            For i = 0 To 4
                If rccbeubicaciones.Items.Item(i).CheckState = CheckState.Checked Then

                    mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[sp_PROD_Filtros_Insert]" + My.Settings.log_Usuario.ToString + "," + My.Application.Info.Title.ToString + "," _
                                              + rccbeubicaciones.Items.Item(i).Value.ToString() + "," + rccbeubicaciones.Items.Item(i).Description.ToString())
                End If
            Next

            If pUbicaciones = String.Empty Then
                Return Nothing
            End If

            Return pUbicaciones

        Catch ex As Exception
            Return Nothing
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub barbtnComprometido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol.ItemClick
        Try
            If grdviewEnsambleCalculadora.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaRol.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewEnsambleCalculadora, "CodigoArticulo")
            frmTemporal_DeudaRol.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btsAgrupar_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsAgrupar.CheckedChanged
        Try
            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If

            If btsAgrupar.Checked = False Then
                ssmEsperar.SetWaitFormCaption("Espere un Momento")
                ssmEsperar.SetWaitFormDescription("Desagrupando...")
                grdviewEnsambleCalculadora.ClearGrouping()
                btsExpandir.Enabled = False
            Else
                ssmEsperar.SetWaitFormCaption("Espere un Momento")
                ssmEsperar.SetWaitFormDescription("Agrupando...")
                Sub_Grupos_Sumar()
                grdviewEnsambleCalculadora.Columns("Ubicacion").GroupIndex = 0
                grdviewEnsambleCalculadora.Columns("Grupo").GroupIndex = 1
                grdviewEnsambleCalculadora.ExpandAllGroups()
                btsExpandir.Checked = True
                btsExpandir.Enabled = True
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub btsMultiSeleccion_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsMultiSeleccion.CheckedChanged
        Try
            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If

            If btsMultiSeleccion.Checked = True Then
                ssmEsperar.SetWaitFormCaption("Espere un Momento")
                ssmEsperar.SetWaitFormDescription("Modo: Multiple Seleccion")
                grdviewEnsambleCalculadora.OptionsSelection.MultiSelect = True
                grdviewEnsambleCalculadora.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            Else
                ssmEsperar.SetWaitFormCaption("Espere un Momento")
                ssmEsperar.SetWaitFormDescription("Modo: Seleccion Unica")
                grdviewEnsambleCalculadora.OptionsSelection.MultiSelect = False
                grdviewEnsambleCalculadora.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub btsExpandir_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsExpandir.CheckedChanged
        Try
            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            If btsExpandir.Checked = False Then
                'CONTRAER
                ssmEsperar.SetWaitFormCaption("Espere")
                ssmEsperar.SetWaitFormDescription("Colapsando...")
                btsExpandir.Caption = "Expandir"
                grdviewEnsambleCalculadora.CollapseAllGroups()
            Else
                'EXPANDIR
                ssmEsperar.SetWaitFormCaption("Espere")
                btsExpandir.Caption = "Contraer"
                ssmEsperar.SetWaitFormDescription("Expandiendo...")
                grdviewEnsambleCalculadora.ExpandAllGroups()

            End If



        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            If grdviewEnsambleCalculadora.RowCount = Nothing Then
                Exit Sub
            End If
            'vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewAnalisisArticulos, "CodigoArticulo")

            frmTemporal_Stock.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewEnsambleCalculadora, "CodigoArticulo")
            frmTemporal_Stock.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana.ItemClick
        Try
            If grdviewEnsambleCalculadora.RowCount = Nothing Then
                Exit Sub
            End If
            frmTemporal_DeudaCampana.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewEnsambleCalculadora, "CodigoArticulo")
            frmTemporal_DeudaCampana.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSellado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSellado.ItemClick
        Try
            Sub_Duplicar("Sellado")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnAgrupar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgrupar.ItemClick

    End Sub

    Private Sub barbtnBuscarCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscarCampana.ItemClick
        Try

            If Not DsEnsambleCalculadora1.dsdtEnsambleCalculadora.Rows.Count = Nothing Then
                If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
                If MsgBox("Desea BORRAR los datos en pantalla?", MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Clear()
                End If
                If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            End If

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If
            ssmEsperar.SetWaitFormCaption("Espere un Momento")
            ssmEsperar.SetWaitFormDescription("Buscando Deuda de Ensambles...")

            Dim pUbicaciones As String = String.Empty
            pUbicaciones = fcn_UbicacionesSeleccionadas()


            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[EnsambleCalculadora_Lista_Campana]" + My.Settings.log_Usuario.ToString + "," + My.Application.Info.Title.ToString)

            If Not dt.Rows.Count = Nothing Then
                DsEnsambleCalculadora1.Tables(DsEnsambleCalculadora1.dsdtEnsambleCalculadora.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub barbtnParametrosDefault_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnParametrosDefault.ItemClick
        Try
            frmTemporal_ParametrosDefault.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaProyeccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion.ItemClick
        Try
            If grdviewEnsambleCalculadora.RowCount = Nothing Then
                Exit Sub
            End If

            frmTemporal_DeudaProyeccion.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewEnsambleCalculadora, "CodigoArticulo")
            frmTemporal_DeudaProyeccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class