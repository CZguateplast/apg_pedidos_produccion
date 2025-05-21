Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Public Class frmPlanPrioridadesAlmacen

    'Para carga la vista:
    Public Property ModoLlamada As String = ""

    Private Sub btsOcultar_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsOcultar.CheckedChanged
        Try
            If btsOcultar.Checked = False Then
                sccPlanPrioridades.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            Else
                sccPlanPrioridades.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmPlanPrioridadesAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FCN_FormLoad()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_FormLoad()
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(rsluePrioridadAlmacen, mSQLSelect.GET_PROD_CatListados("Tipo_Prioridad"), "Id", "Nombre")

            'FCN_EmergenciasProduccion_Padres()

            If ModoLlamada = "PRINCIPAL" Then
                FCN_EmergenciasProduccion_Padres()
            ElseIf ModoLlamada = "SECUNDARIO" Then
                FCN_EmergenciasProduccion_Padres_SoloBolsa()
            End If

            FCN_EmergenciasProduccion_Plan()
            FCN_MarcarRojo_Emergencias()

            Application.DoEvents()
            frmMenu.tmrBarStatus.Stop()
            Application.DoEvents()
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

    'Funcion con Solo Productos
    Private Sub FCN_EmergenciasProduccion_Padres()
        Try
            Application.DoEvents()
            Dim dt As New DataTable("dtProduccionPadres")
            dt = mSQLSelect.GET_OrdenesProduccion_Padres()
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Padres.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Padres.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Fucnion con solo bolsas
    Private Sub FCN_EmergenciasProduccion_Padres_SoloBolsa()
        Try
            Application.DoEvents()
            Dim dt As New DataTable("dtProduccionPadres")
            dt = mSQLSelect.GET_OrdenesProduccion_Padres_SoloBolsa()
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Padres.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Padres.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_EmergenciasProduccion_Plan()
        Try
            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()
            Dim dt As New DataTable()
            Dim pFecha As String

            dt = GET_EmergenciasProduccion_Transaciones(mSQLSelect.GET_EmergenciasProduccion_UltimoPlan())
            'dt = GET_EmergenciasProduccion_Transaciones("473")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            'AGREGAR COLORES PENDIENTES PRODUCCION
            'For i = 0 To dt.Rows.Count - 1
            '    Application.DoEvents()
            '    dt.Rows(i)("ColoresPendientes") = GET_ColoresProduccion_Pendientes(dt.Rows(i)("CodigoArticulo").ToString)
            '    Application.DoEvents()
            'Next

            'AGREGAR FECHA DE ULTIMO RECIBO DE PRODUCCION
            For i = 0 To dt.Rows.Count - 1
                Application.DoEvents()
                pFecha = mSQLSelect.GET_Recibos_UltimoIngreso(dt.Rows(i)("CodigoArticulo").ToString)
                If Not pFecha = Nothing Then
                    dt.Rows(i)("FechaRecibo") = pFecha
                End If
                Application.DoEvents()
            Next

            'HORAS REQUERIDAS
            Dim dtParametros As New DataTable()
            Dim pHorasRequeridas As Decimal
            For i = 0 To dt.Rows.Count - 1
                Application.DoEvents()
                dtParametros = GET_MoldesProduccionParametros(dt.Rows(i)("CodigoArticulo").ToString)

                If Not dtParametros.Rows.Count = Nothing Then
                    If Not dtParametros(0)("CicloHora").ToString = String.Empty And dtParametros.Rows(0)("ArticulosHora") > 0 Then
                        pHorasRequeridas = Val(dt.Rows(i)("Pendiente")) / Val(Math.Ceiling(dtParametros.Rows(0)("ArticulosHora")))
                        dt.Rows(i)("HorasPendiente") = Math.Ceiling(pHorasRequeridas)
                    End If

                End If
                Application.DoEvents()
            Next
            'dt.Rows(10).Delete()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub tileviewPrioridadesProduccion_BeforeLeaveRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles tileviewPrioridadesProduccion.BeforeLeaveRow
        Try
            FCN_Enumerar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Enumerar()
        Try
            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()

            Dim dt As New DataTable()
            dt = DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan

            'dt.AcceptChanges()

            For i = 0 To DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.Count - 1
                DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows(i)("Prioridad") = Val(i + 1)
            Next

            dt.AcceptChanges()
            'DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Clear()
            'DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub tileviewPrioridadesProduccion_ItemRightClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles tileviewPrioridadesProduccion.ItemRightClick
        Try
            Application.DoEvents()
            Dim pPrioridad As String = String.Empty
            Dim pComentario As String = String.Empty

            pPrioridad = tileviewPrioridadesProduccion.GetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Prioridad")
            pComentario = tileviewPrioridadesProduccion.GetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Observacion")

            spinPrioridad.EditValue = pPrioridad
            memoComentarios.EditValue = pComentario

            FlyoutPanel1.ShowBeakForm(MousePosition, False)

            spinPrioridad.EditValue = pPrioridad
            memoComentarios.EditValue = pComentario


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FlyoutPanel1_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel1.ButtonClick
        Try
            Dim tag As String = e.Button.Caption.ToString()
            Select Case tag
                Case "Aceptar"
                    DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()

                    tileviewPrioridadesProduccion.SetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Prioridad", spinPrioridad.EditValue.ToString)
                    tileviewPrioridadesProduccion.SetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Observacion", memoComentarios.EditValue.ToString)

                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.DefaultView.Sort = "Prioridad ASC"
                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()


                    Dim dt As New DataTable()
                    dt = DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan

                    Dim pFocus As Integer = tileviewPrioridadesProduccion.FocusedRowHandle
                    Dim pIndex As Integer = 1

                    For i = 0 To dt.Rows.Count - 1

                        If Not pFocus = i Then

                            If spinPrioridad.EditValue.ToString = Val(pIndex) Then
                                pIndex = pIndex + 1
                            End If

                            dt.Rows(i)("Prioridad") = pIndex
                            pIndex = pIndex + 1
                        End If
                    Next

                    dt.AcceptChanges()
                    Dim view As DataView = New DataView(dt)
                    ' Lo ordenamos por el campo Nombre.
                    view.Sort = "Prioridad ASC"
                    Dim dt2 As New DataTable()
                    dt2 = view.ToTable
                    dt2.AcceptChanges()

                    DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Clear()
                    DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Merge(dt2)


                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan = dt



                    'Dim row As DataRow = DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows(grdviewOrdenesProduccion.FocusedRowHandle)
                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.NewRow()
                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.InsertAt(row, DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.Count)

                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows(grdviewOrdenesProduccion.FocusedRowHandle).Delete()

                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.InsertAt(row, Val(spinPrioridad.EditValue - 1))

                    'DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.DefaultView.Sort = "Prioridad ASC"

                    TryCast(sender, FlyoutPanel).HidePopup()

                Case "Cancelar"
                    TryCast(sender, FlyoutPanel).HidePopup()
            End Select

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub tileviewPrioridadesProduccion_ItemPress(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles tileviewPrioridadesProduccion.ItemPress
        Try
            If e.Item.RowHandle = DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.Count - 1 Then
                tileviewPrioridadesProduccion.OptionsDragDrop.AllowDrag = False
            Else
                tileviewPrioridadesProduccion.OptionsDragDrop.AllowDrag = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            FCN_AgregarArticulo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub FCN_AgregarArticulo()
        Try
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "CodigoArticulo")

            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            For i = 0 To tileviewPrioridadesProduccion.RowCount - 1
                If pCodigoArticulo = tileviewPrioridadesProduccion.GetRowCellValue(i, "CodigoArticulo") Then
                    mMensajes.msg_Informacion("El articulo [" + pCodigoArticulo + "] ya existe dentro del plan de Emergencias")
                    Exit Sub
                End If
            Next

            Dim dt As New DataTable()
            dt = GET_EmergenciasProduccion_Plan("'" + pCodigoArticulo + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            'For i = 0 To dt.Rows.Count - 1
            '    dt.Rows(i)("ColoresPendientes") = GET_ColoresProduccion_Pendientes(dt.Rows(i)("CodigoArticulo").ToString)
            'Next
            'If MsgBox("Desea agregar el Codigo [" + pCodigoArticulo + "] al Plan de Emergencias de Produccion ", MsgBoxStyle.YesNo, "Agregar...") = MsgBoxResult.No Then
            ' Exit Sub
            ' End If

            If tileviewPrioridadesProduccion.RowCount = Nothing Then
                dt.Rows(0)(0) = "1"
            Else
                dt.Rows(0)(0) = Val(tileviewPrioridadesProduccion.RowCount + 1).ToString
            End If
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Merge(dt)

            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub FCN_MarcarRojo_Emergencias()
        Try
            For h = 0 To grdviewOrdenesProduccion.RowCount - 1
                grdviewOrdenesProduccion.SetRowCellValue(h, "Plan", False)
            Next

            For i = 0 To tileviewPrioridadesProduccion.RowCount - 1
                For j = 0 To grdviewOrdenesProduccion.RowCount - 1
                    If grdviewOrdenesProduccion.GetRowCellValue(j, "CodigoArticulo") = tileviewPrioridadesProduccion.GetRowCellValue(i, "CodigoArticulo") Then
                        grdviewOrdenesProduccion.SetRowCellValue(j, "Plan", True)
                    End If
                Next
            Next


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmPlanPrioridadesAlmacen_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            FCN_formShown()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_formShown()
        Try
            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewOrdenesProduccion_DoubleClick(sender As Object, e As EventArgs) Handles grdviewOrdenesProduccion.DoubleClick
        Try
            FCN_AgregarArticulo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnQuitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnQuitar.ItemClick
        Try
            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.Rows.RemoveAt(tileviewPrioridadesProduccion.FocusedRowHandle)
            FCN_Enumerar()

            'mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(tileviewPrioridadesProduccion)

            'For i = 0 To tileviewPrioridadesProduccion.RowCount - 1
            '    tileviewPrioridadesProduccion.SetRowCellValue(i, "Prioridad", i + 1)
            'Next
            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()
            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub tileviewPrioridadesProduccion_ColumnFilterChanged(sender As Object, e As EventArgs) Handles tileviewPrioridadesProduccion.ColumnFilterChanged
        Try
            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub tileviewPrioridadesProduccion_DoubleClick(sender As Object, e As EventArgs) Handles tileviewPrioridadesProduccion.DoubleClick
        Try
            Try
                Application.DoEvents()
                Dim pPrioridad As String = String.Empty
                Dim pComentario As String = String.Empty

                pPrioridad = tileviewPrioridadesProduccion.GetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Prioridad")
                pComentario = tileviewPrioridadesProduccion.GetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "Observacion")

                spinPrioridad.EditValue = pPrioridad
                memoComentarios.EditValue = pComentario

                FlyoutPanel1.ShowBeakForm(MousePosition, False)

                spinPrioridad.EditValue = pPrioridad
                memoComentarios.EditValue = pComentario


            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try

            If grdviewOrdenesProduccion.IsFocusedView Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewOrdenesProduccion)
            ElseIf tileviewPrioridadesProduccion.IsFocusedView Then
                mFunciones.FCN_XTRAGRID_Buscar(tileviewPrioridadesProduccion)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewOrdenesProduccion, tileviewPrioridadesProduccion)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewOrdenesProduccion, tileviewPrioridadesProduccion, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnReporteAlmacen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReporteAlmacen.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEmergenciasProduccion
            RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
            RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString
            RPTdocumento.Parameters("vSeleccionados").Value = tileviewPrioridadesProduccion.RowCount
            RPTdocumento.Parameters("vTotales").Value = grdviewOrdenesProduccion.RowCount
            RPTdocumento.Parameters("vPorcentaje").Value = Val(Val(tileviewPrioridadesProduccion.RowCount) * 100) / Val(grdviewOrdenesProduccion.RowCount)

            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_OrdenProduccion1")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                            "OrdenesProduccion", _
            '                                            "Hola", _
            '                                            "Reporte_OrdenProduccion1")

            PrintTool.ShowRibbonPreviewDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnReporteProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReporteProduccion.ItemClick
        Try

            'LLENAR GRID DE ORDENES DE PRODUCCION
            Dim dtOrdenesProduccion As New DataTable()
            dtOrdenesProduccion = mSQLSelect.GET_EmergenciasProduccion_Ordenes()
            If dtOrdenesProduccion.Rows.Count = Nothing Then
                DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtOrdenesProduccion.TableName.ToString).Clear()
                Exit Sub
            End If
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtOrdenesProduccion.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtOrdenesProduccion.TableName.ToString).Merge(dtOrdenesProduccion)


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptProgramacionProduccion
            RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
            RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtOrdenesProduccion.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_OrdenProduccion1")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                            "OrdenesProduccion", _
            '                                            "Hola", _
            '                                            "Reporte_OrdenProduccion1")

            PrintTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabarPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabarPlan.ItemClick
        Try
            FCN_Grabar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_Grabar()
        Try
            If tileviewPrioridadesProduccion.RowCount = Nothing Then
                mMensajes.msg_Error("No existe Planificacion para Grabar")
                Exit Sub
            End If

            Dim pCorrelativo As String = String.Empty

            pCorrelativo = mSQLInsert.SET_EmergenciasProduccion_Correlativo()
            If pCorrelativo = String.Empty Then
                mMensajes.msg_Informacion("A ocurrido un error en el proceso. Intentar de nuevo.")
                Exit Sub
            End If

            If mSQLInsert.SET_EmergenciasProduccion_Encabezado(pCorrelativo, DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Padres) Then
                If mSQLInsert.SET_EmergenciasProduccion_Plan(pCorrelativo, DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan) Then

                    ' INICIO ENVIAR CORREO ****************************************************************
                    Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEmergenciasProduccion
                    RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
                    RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString
                    ''dvwReportes.DocumentSource = RPTdocumento
                    Dim PrintTool As New ReportPrintTool(RPTdocumento)

                    mFunciones.ExportToPNG(RPTdocumento, "Reporte_EmergenciasProduccion_Grabar")

                    'EJEMPLO DE NOMBRE mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EmergenciasProduccion_Grabar", _
                    mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EmergenciasProduccion_Grabar", _
                                                                 "Plan de Prioridades Almacen por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                                 "Hola", _
                                                                 "Reporte_EmergenciasProduccion_Grabar")
                    ' FIN ENVIAR CORREO ****************************************************************

                    mMensajes.msg_Informacion("Proceso ejecutado exitosamente. " + Environment.NewLine + "Transacción # " + pCorrelativo)

                Else
                    mMensajes.msg_Informacion("A ocurrido un error en el proceso. Intentar de nuevo.")
                    Exit Sub
                End If
            Else
                mMensajes.msg_Informacion("A ocurrido un error en el proceso. Intentar de nuevo.")
                Exit Sub
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCorreo.ItemClick
        Try

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEmergenciasProduccion
            RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
            RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString
            RPTdocumento.Parameters("vSeleccionados").Value = tileviewPrioridadesProduccion.RowCount
            RPTdocumento.Parameters("vTotales").Value = grdviewOrdenesProduccion.RowCount
            RPTdocumento.Parameters("vPorcentaje").Value = Val(Val(tileviewPrioridadesProduccion.RowCount) * 100) / Val(grdviewOrdenesProduccion.RowCount)

            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)


            mFunciones.ExportToPNG(RPTdocumento, "Reporte_EmergenciasProduccion")
            'EmergenciasProduccion
            mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EmergenciasProduccion", _
                                                        "Plan de Prioridades Almacen por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                        "Hola", _
                                                        "Reporte_EmergenciasProduccion")

            If MsgBox("Su correo ha sido enviado exitosamente!." + Environment.NewLine + "¿Desea ver el reporte?", MsgBoxStyle.YesNo, "Correo...") = MsgBoxResult.Yes Then
                PrintTool.ShowRibbonPreviewDialog()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizarOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarOrdenes.ItemClick
        Try
            If barbtnGrabarPlan.Enabled = True Then
                If MsgBox("Para actualizar es necesario GUARDAR." + Environment.NewLine + "Desea continuar?", MsgBoxStyle.YesNo, "Actualizar...") = MsgBoxResult.No Then
                    Exit Sub
                End If
                FCN_Grabar()
            End If


            frmMenu.barStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Application.DoEvents()
            frmMenu.tmrBarStatus.Start()
            Application.DoEvents()
            FCN_FormLoad()
            FCN_FormShown()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            frmMenu.barStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            frmMenu.tmrBarStatus.Stop()
        End Try


    End Sub


    Private Sub grdviewOrdenesProduccion_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewOrdenesProduccion.FocusedRowChanged
        Try
            Sub_Fill_grdviewProduccionHijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_grdviewProduccionHijos()
        Try
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()


            If grdviewOrdenesProduccion.RowCount = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoPadre As String = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "CodigoArticulo")

            If pCodigoPadre = String.Empty Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If
            dt = mSQLSelect.GET_OrdenesProduccion_Hijos(pCodigoPadre)
            If dt.Rows.Count = Nothing Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If

            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewOrdenesProduccion_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdviewOrdenesProduccion.ColumnFilterChanged
        Try
            Sub_Fill_grdviewProduccionHijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnColumnas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnColumnas.ItemClick
        Try
            grdviewOrdenesProduccion.ShowCustomization()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDetalleHijos_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleHijos.ItemClick
        Try
            Dim pCodigoPadre As String = String.Empty


            If grdviewOrdenesProduccion.IsFocusedView() Then
                pCodigoPadre = grdviewOrdenesProduccion.GetRowCellValue(grdviewOrdenesProduccion.FocusedRowHandle, "CodigoArticulo")
            ElseIf tileviewPrioridadesProduccion.IsFocusedView Then
                pCodigoPadre = tileviewPrioridadesProduccion.GetRowCellValue(tileviewPrioridadesProduccion.FocusedRowHandle, "CodigoArticulo")
            End If


            If pCodigoPadre = String.Empty Then
                Exit Sub
            End If

            frmPlanPrioridadesAlmacen_Hijos.ppCodigoPadre = pCodigoPadre
            frmPlanPrioridadesAlmacen_Hijos.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewOrdenesProduccion_Click(sender As Object, e As EventArgs) Handles grdviewOrdenesProduccion.Click
        Try
            FCN_habilitar_Botones()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub tileviewPrioridadesProduccion_Click(sender As Object, e As EventArgs) Handles tileviewPrioridadesProduccion.Click
        Try
            FCN_habilitar_Botones()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_habilitar_Botones()
        Try
            If grdviewOrdenesProduccion.IsFocusedView() Then
                barbtnAgregar.Enabled = True
                barbtnQuitar.Enabled = False

            ElseIf tileviewPrioridadesProduccion.IsFocusedView() Then
                barbtnAgregar.Enabled = False
                barbtnQuitar.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick

        Try
            Dim path = System.IO.Path.Combine(Application.StartupPath, "help/helpPlanPrioridadesAlmacen.png")
            System.Diagnostics.Process.Start(path)
            'Dim path = System.IO.Path.Combine(Application.StartupPath, "frmOrdenProduccionDisponible.chm")
            'Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
            'Help.ShowHelp(ParentForm, "frmOrdenProduccionDisponible.htm", HelpNavigator.TableOfContents)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
End Class