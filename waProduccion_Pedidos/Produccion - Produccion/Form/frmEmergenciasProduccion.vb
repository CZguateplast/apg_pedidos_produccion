Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI

Public Class frmEmergenciasProduccion

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            If MsgBox("Esta seguro que quiere salir del Plan de Emergencias?", MsgBoxStyle.YesNo, "Cerrar...") = MsgBoxResult.Yes Then
                Me.Close()
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_Fill_grdviewProduccionHijos()
        Try
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()


            If grdviewProduccionPadres.RowCount = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoPadre As String = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")

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
    Private Sub frmEmergenciasProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            FCN_FormLoad()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally

        End Try
    End Sub

    Private Sub FCN_FormLoad()
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(rsluePrioridadCP, mSQLSelect.GET_PROD_CatListados("Tipo_Prioridad"), "Id", "Nombre")
            Application.DoEvents()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Clear()
            Application.DoEvents()
            FCN_EmergenciasProduccion_Padres()
            Application.DoEvents()
            FCN_EmergenciasProduccion_Plan()
            Application.DoEvents()
            'grdviewEmergenciasProduccion_Plan.PopulateColumns()
            grdviewEmergenciasProduccion_Plan.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            grdviewEmergenciasProduccion_Plan.OptionsCustomization.AllowSort = False
            grdviewEmergenciasProduccion_Plan.OptionsView.ShowGroupPanel = False

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueColor, mSQLSelect.GET_Catalogo_Colores(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCampana, mSQLSelect.GET_Listado_CampanaVigentes(), "Id", "Id")
            mSeguridad.APG_Seguridad(Me, barbtnSubirPrioridad)
            mSeguridad.APG_Seguridad(Me, barbtnBajarPrioridad)
            mSeguridad.APG_Seguridad(Me, barbtnGrabar)
            mSeguridad.APG_Seguridad(Me, barbtnCorreo)
            mSeguridad.APG_Seguridad(Me, barbtnProgramacionProduccion)

            Application.DoEvents()
            frmMenu.tmrBarStatus.Stop()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

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
    Private Sub FCN_EmergenciasProduccion_Plan()
        Try
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

    Private Sub grdviewProduccionPadres_Click(sender As Object, e As EventArgs) Handles grdviewProduccionPadres.Click
        Try
            barbtnAgregar.Enabled = True
            barbtnQuitar.Enabled = False
            'FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEmergenciasProduccion_Plan_Click(sender As Object, e As EventArgs) Handles grdviewEmergenciasProduccion_Plan.Click
        Try
            barbtnAgregar.Enabled = False
            mSeguridad.APG_Seguridad(Me, barbtnQuitar)
            'FCN_MarcarRojo_Emergencias()
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
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")

            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            For i = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
                If pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewEmergenciasProduccion_Plan, "CodigoArticulo", i) Then
                    mMensajes.msg_Informacion("El articulo [" + pCodigoArticulo + "] ya existe dentro del plan de Emergencias")
                    Exit Sub
                End If
            Next

            Dim dt As New DataTable()
            dt = GET_EmergenciasProduccion_Plan("'" + pCodigoArticulo + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i)("ColoresPendientes") = GET_ColoresProduccion_Pendientes(dt.Rows(i)("CodigoArticulo").ToString)
            Next
            'If MsgBox("Desea agregar el Codigo [" + pCodigoArticulo + "] al Plan de Emergencias de Produccion ", MsgBoxStyle.YesNo, "Agregar...") = MsgBoxResult.No Then
            ' Exit Sub
            ' End If

            If grdviewEmergenciasProduccion_Plan.RowCount = Nothing Then
                dt.Rows(0)(0) = "1"
            Else
                dt.Rows(0)(0) = Val(grdviewEmergenciasProduccion_Plan.RowCount + 1).ToString
            End If



            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString).Merge(dt)

            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSubirPrioridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSubirPrioridad.ItemClick
        Try

            'grdviewEmergenciasProduccion_Plan.FocusedRowHandle = grdviewEmergenciasProduccion_Plan.FocusedRowHandle - 1
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = grdviewEmergenciasProduccion_Plan
            view.GridControl.Focus()
            Dim index As Integer = view.FocusedRowHandle
            If index <= 0 Then
                Return
            End If
            Dim row1 As DataRow = view.GetDataRow(index)
            Dim row2 As DataRow = view.GetDataRow(index - 1)
            Dim val1 As Object = row1(0)
            Dim val2 As Object = row2(0)
            row1(0) = val2
            row2(0) = val1
            view.FocusedRowHandle = index - 1

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnBajarPrioridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBajarPrioridad.ItemClick
        Dim view As GridView = grdviewEmergenciasProduccion_Plan
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then
            Return
        End If

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow(index + 1)
        Dim val1 As Object = row1(0)
        Dim val2 As Object = row2(0)
        row1(0) = val2
        row2(0) = val1

        view.FocusedRowHandle = index + 1
    End Sub
    Private Sub grdviewProduccionPadres_DoubleClick(sender As Object, e As EventArgs) Handles grdviewProduccionPadres.DoubleClick
        Try
            FCN_AgregarArticulo()
            Sub_Fill_grdviewProduccionHijos()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


#Region "DragDrop"

    'Private downHitInfo As GridHitInfo = Nothing


    'Private Sub grdviewEmergenciasProduccion_Plan_MouseDown(sender As Object, e As MouseEventArgs) Handles grdviewEmergenciasProduccion_Plan.MouseDown
    '    Dim view As GridView = TryCast(sender, GridView)
    '    downHitInfo = Nothing

    '    Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
    '    If Control.ModifierKeys <> Keys.None Then
    '        Return
    '    End If
    '    If e.Button = MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.RowHandle <> GridControl.NewItemRowHandle Then
    '        downHitInfo = hitInfo
    '    End If
    'End Sub

    'Private Sub grdviewEmergenciasProduccion_Plan_MouseMove(sender As Object, e As MouseEventArgs) Handles grdviewEmergenciasProduccion_Plan.MouseMove
    '    Try
    '        Dim view As GridView = TryCast(sender, GridView)
    '        If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
    '            Dim dragSize As Size = SystemInformation.DragSize
    '            Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width \ 2, downHitInfo.HitPoint.Y - dragSize.Height \ 2), dragSize)

    '            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
    '                view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All)
    '                downHitInfo = Nothing
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub

    'Private Sub grdEmergenciasProduccion_Plan_DragOver(sender As Object, e As DragEventArgs) Handles grdEmergenciasProduccion_Plan.DragOver
    '    Try
    '        If e.Data.GetDataPresent(GetType(GridHitInfo)) Then
    '            Dim downHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
    '            If downHitInfo Is Nothing Then
    '                Return
    '            End If

    '            Dim grid As GridControl = TryCast(sender, GridControl)
    '            Dim view As GridView = TryCast(grid.MainView, GridView)
    '            Dim hitInfo As GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
    '            If hitInfo.InRow AndAlso hitInfo.RowHandle <> downHitInfo.RowHandle AndAlso hitInfo.RowHandle <> GridControl.NewItemRowHandle Then
    '                e.Effect = DragDropEffects.Move
    '            Else
    '                e.Effect = DragDropEffects.None
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub
    'Private Sub grdEmergenciasProduccion_Plan_DragDrop(sender As Object, e As DragEventArgs) Handles grdEmergenciasProduccion_Plan.DragDrop
    '    Try
    '        Dim grid As GridControl = TryCast(sender, GridControl)
    '        Dim view As GridView = TryCast(grid.MainView, GridView)
    '        Dim srcHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
    '        Dim hitInfo As GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
    '        Dim sourceRow As Integer = srcHitInfo.RowHandle
    '        Dim targetRow As Integer = hitInfo.RowHandle
    '        MoveRow(sourceRow, targetRow)
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub

    'Private Sub MoveRow(ByVal sourceRow As Integer, ByVal targetRow As Integer)
    '    If sourceRow = targetRow OrElse sourceRow = targetRow + 1 Then
    '        Return
    '    End If

    '    Dim view As GridView = grdviewEmergenciasProduccion_Plan
    '    Dim row1 As DataRow = view.GetDataRow(targetRow)
    '    Dim row2 As DataRow = view.GetDataRow(targetRow + 1)
    '    Dim dragRow As DataRow = view.GetDataRow(sourceRow)
    '    Dim val1 As Decimal = CDec(row1(0))
    '    If row2 Is Nothing Then
    '        dragRow(0) = val1 + 1
    '    Else
    '        Dim val2 As Decimal = CDec(row2(0))
    '        dragRow(0) = (val1 + val2) / 2
    '    End If
    'End Sub

#End Region

    Private Sub barbtnQuitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnQuitar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewEmergenciasProduccion_Plan)

            For i = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
                grdviewEmergenciasProduccion_Plan.SetRowCellValue(i, "Prioridad", i + 1)
            Next
            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()
            FCN_MarcarRojo_Emergencias()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub




    Private Sub FCN_MarcarRojo_Emergencias()
        Try
            For h = 0 To grdviewProduccionPadres.RowCount - 1
                grdviewProduccionPadres.SetRowCellValue(h, "Plan", False)
            Next

            For i = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
                For j = 0 To grdviewProduccionPadres.RowCount - 1
                    If grdviewProduccionPadres.GetRowCellValue(j, "CodigoArticulo") = grdviewEmergenciasProduccion_Plan.GetRowCellValue(i, "CodigoArticulo") Then
                        grdviewProduccionPadres.SetRowCellValue(j, "Plan", True)
                    End If
                Next
            Next

            'For k = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
            '    grdviewProduccionPadres.SetRowCellValue(k, "Plan", False)
            'Next

            'For l = 0 To grdviewProduccionPadres.RowCount - 1
            '    For m = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
            '        If grdviewEmergenciasProduccion_Plan.GetRowCellValue(m, "CodigoArticulo") = grdviewProduccionPadres.GetRowCellValue(l, "CodigoArticulo") Then
            '            grdviewEmergenciasProduccion_Plan.SetRowCellValue(m, "Plan", True)
            '        End If
            '    Next
            'Next




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            FCN_Grabar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Grabar()
        Try
            If grdviewEmergenciasProduccion_Plan.RowCount = Nothing Then
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
                    mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EmergenciasProduccion_Grabar", _
                                                                "Plan Producción Sugerido por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
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

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdProduccionPadres.IsFocused() Then
                grdviewProduccionPadres.ShowRibbonPrintPreview()
            ElseIf grdEmergenciasProduccion_Plan.IsFocused() Then
                grdviewEmergenciasProduccion_Plan.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If grdProduccionPadres.IsFocused Then
                    grdviewProduccionPadres.ExportToXlsx(sfdSave.FileName)
                ElseIf grdEmergenciasProduccion_Plan.IsFocused Then
                    grdviewEmergenciasProduccion_Plan.ExportToXlsx(sfdSave.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnReporte_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReporte.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEmergenciasProduccion
            RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
            RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString
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

    Private Sub barbtnCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCorreo.ItemClick
        Try

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEmergenciasProduccion
            RPTdocumento.DataSource = Me.DsEmergenciasProduccion1
            RPTdocumento.DataMember = Me.DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            mFunciones.ExportToPNG(RPTdocumento, "Reporte_EmergenciasProduccion")
            mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EmergenciasProduccion", _
                                                        "Plan Producción Sugerido por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                        "Hola", _
                                                        "Reporte_EmergenciasProduccion")

            If MsgBox("Su correo ha sido enviado exitosamente!." + Environment.NewLine + "¿Desea ver el reporte?", MsgBoxStyle.YesNo, "Correo...") = MsgBoxResult.Yes Then
                PrintTool.ShowRibbonPreviewDialog()
            End If





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewProduccionPadres_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdviewProduccionPadres.ColumnFilterChanged
        Try
            Sub_Fill_grdviewProduccionHijos()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewProduccionPadres_FocusedRowChanged(sender As Object, e As Views.Base.FocusedRowChangedEventArgs) Handles grdviewProduccionPadres.FocusedRowChanged
        Try
            If grdviewProduccionPadres.RowCount = Nothing Then
                Exit Sub
            End If

            Sub_Fill_grdviewProduccionHijos()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEnumerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEmergenciasProduccion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            FCN_FormShown()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FCN_FormShown()
        Try
            For i = 0 To grdviewEmergenciasProduccion_Plan.RowCount - 1
                grdviewEmergenciasProduccion_Plan.SetRowCellValue(i, "Prioridad", i + 1)
            Next

            DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Plan.AcceptChanges()
            FCN_MarcarRojo_Emergencias()

            frmMenu.barStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            If grdviewProduccionPadres.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewProduccionPadres)
            ElseIf grdviewProduccionHijos.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewProduccionHijos)
            ElseIf grdviewEmergenciasProduccion_Plan.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewEmergenciasProduccion_Plan)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewProduccionHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewProduccionHijos.DoubleClick
        Try
            FCN_OrdenesProduccionDetalle()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_OrdenesProduccionDetalle()
        Try
            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewProduccionHijos, "CodigoArticulo")

            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmTemporal_OrdenesProduccionEnsambleDetalle.ppCodigoArticulo = pCodigoArticulo
            frmTemporal_OrdenesProduccionEnsambleDetalle.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDetalleOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleOrdenes.ItemClick
        Try
            If grdviewProduccionHijos.RowCount = Nothing Then
                MsgBox("No existe detalle para mostrar")
                Exit Sub
            End If
            FCN_OrdenesProduccionDetalle()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            If barbtnGrabar.Enabled = True Then
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
        End Try
    End Sub


    Private Sub barbtnProgramacionProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProgramacionProduccion.ItemClick
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
End Class