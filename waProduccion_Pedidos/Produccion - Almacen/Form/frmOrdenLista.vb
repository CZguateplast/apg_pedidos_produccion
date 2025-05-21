Imports DevExpress.XtraReports.UI
Public Class frmOrdenLista

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbbTipoListado_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        Try
            If Not e.NewValue = String.Empty Then
                Dim dt As New DataTable()
                Select Case e.NewValue
                    Case "Ordenes de Producción"
                        dt = mSQLSelect.GET_Listado_OrdenesEnsamble("-1", "CP")
                    Case "Ordenes de Ensamble"
                        dt = mSQLSelect.GET_Listado_OrdenesEnsamble("-1", "AR")
                    Case "Ordenes de Materia Prima"
                        dt = mSQLSelect.GET_Listado_OrdenesEnsamble("-1", "MP")
                End Select

                DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Clear()
                DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Merge(dt)

                grdviewOrdenLista.UnselectRow(0)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmOrdenLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            APG_Seguridad(Me, barbtnOrdenLiberar)
            APG_Seguridad(Me, barbtnOrdenCerrar)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewOrdenLista.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Valida, 
    Private Sub barbtnOrdenCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenCerrar.ItemClick
        Try

            frmTemporal_OrdenesCerradasResultado.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewOrdenLista, "NumSAP")

            If mMensajes.msg_Ordenes_StatusCerrar() Then
                ssmEsperar.ShowWaitForm()
                Dim pArray As ArrayList
                pArray = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewOrdenLista)
                For i = 0 To pArray.Count - 1
                    Dim pNumOrden As String = pArray(i)("NumSAP").ToString

                    If pArray(i)("Estado").ToString = "Liberado" Then
                        ssmEsperar.SetWaitFormCaption("")
                        mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(pNumOrden)
                    Else
                        ssmEsperar.SetWaitFormCaption("")
                        mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(pNumOrden)
                        mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(pNumOrden)
                    End If
                Next

                'MostrarOrdenesFabricacion()
                sub_Generar()
                If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                frmTemporal_OrdenesCerradasResultado.vpEnviarCorreo = True
                frmTemporal_OrdenesCerradasResultado.ppTipoEvento = "Cerradas"
                frmTemporal_OrdenesCerradasResultado.ShowDialog()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.InnerException.ToString)
        Finally

        End Try
    End Sub

    Private Sub MostrarOrdenesFabricacion()
        Try
            Dim dt As New DataTable("dtEnsambles")
            dt = mSQLSelect.GET_Listado_OrdenesEnsamble("-1", vpTipoOrden)

            DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Clear()
            DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Merge(dt)
            grdviewOrdenLista.UnselectRow(0)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnOrdenLiberar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenLiberar.ItemClick
        Try

            frmTemporal_OrdenesCerradasResultado.ppCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewOrdenLista, "NumSAP")

            If mMensajes.msg_Ordenes_StatusLiberar() Then
                ssmEsperar.ShowWaitForm()
                Dim pArray As ArrayList
                pArray = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewOrdenLista)

                For i = 0 To pArray.Count - 1
                    Dim pNumOrden As String = pArray(i)("NumSAP").ToString

                    If pArray(i)("Estado").ToString = "Planeado" Then
                        mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(pNumOrden)
                    End If
                Next

                'MostrarOrdenesFabricacion()
                sub_Generar()
                If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                frmTemporal_OrdenesCerradasResultado.vpEnviarCorreo = True
                frmTemporal_OrdenesCerradasResultado.ppTipoEvento = "Liberadas"
                frmTemporal_OrdenesCerradasResultado.ShowDialog()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally

        End Try
    End Sub

    Private Sub grdviewOrdenLista_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grdviewOrdenLista.SelectionChanged
        Try
            Dim Rows As New ArrayList()
            Dim pGridView As DevExpress.XtraGrid.Views.Grid.GridView = grdviewOrdenLista
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next

            If Rows.Count = Nothing Then
                mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)
                Exit Sub
            End If

            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)

            Dim pColumna As String = "CodigoArticulo"
            For j = 0 To Rows.Count - 1
                If Not mFunciones.FCN_ValidarDisponiblidad_CerrarOrdenes("'" + Rows(j)(pColumna) + "'", Me.Name.ToString) Then
                    grdviewOrdenLista.UnselectRow(e.ControllerRow)
                End If
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewOrdenLista.ExportToXlsx(sfdSave.FileName)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewOrdenLista)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            sub_Generar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub sub_Generar()
        Try
            Dim pTipoBusqueda As String = String.Empty
            Dim pTipoOrden As String = String.Empty
            Dim pNumeroSAP As String = String.Empty
            Dim pFechaInicial As String = String.Empty
            Dim pFechaFinal As String = String.Empty

            pTipoBusqueda = rdgTipoBusqueda.EditValue.ToString
            pTipoOrden = rdgTipoOrden.EditValue.ToString
            pNumeroSAP = spinNumSAP.EditValue.ToString

            If Not dteFechaInicial.EditValue = Nothing Then : pFechaInicial = mFunciones.ConvertirFechaSQL(dteFechaInicial) : Else : pFechaInicial = String.Empty : End If
            If Not dteFechaFinal.EditValue = Nothing Then : pFechaFinal = mFunciones.ConvertirFechaSQL(dteFechaFinal) : Else : pFechaFinal = String.Empty : End If

            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC [APGProduccion].[dbo].[Impresion_Listas] '" + pTipoBusqueda + "','" + pTipoOrden + "','" + pNumeroSAP + "','" + pFechaInicial + "','" + pFechaFinal + "'")

            DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Clear()
            If Not dt.Rows.Count = Nothing Then
                DsOrdenLista1.Tables(DsOrdenLista1.dsdtCerrarAR.TableName.ToString).Merge(dt)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub rdgTipoBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdgTipoBusqueda.SelectedIndexChanged
        Try
            If rdgTipoBusqueda.EditValue = "Todos" Then
                spinNumSAP.Enabled = False
                dteFechaInicial.Enabled = False
                dteFechaFinal.Enabled = False
            ElseIf rdgTipoBusqueda.EditValue = "SAP" Then
                spinNumSAP.Enabled = True
                dteFechaInicial.Enabled = False
                dteFechaFinal.Enabled = False
            ElseIf rdgTipoBusqueda.EditValue = "Fecha" Then
                spinNumSAP.Enabled = False
                dteFechaInicial.Enabled = True
                dteFechaFinal.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnResumenPedidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnResumenPedidos.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptResumenPedido
            RPTdocumento.DataSource = Me.DsOrdenLista1
            RPTdocumento.DataMember = Me.DsOrdenLista1.dsdtCerrarAR.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            PrintTool.ShowRibbonPreviewDialog()

            'If MsgBox("Desea enviarlo por correo? ", MsgBoxStyle.YesNo, "Enviar reporte por Correo...") = MsgBoxResult.Yes Then
            '    mFunciones.ExportToPNG(RPTdocumento, "Reporte_DesviacionPROD_SAP")
            '    mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("DesviacionPROD_SAP", _
            '                                                "Desviacion en Ordenes de Ensambles " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
            '                                                "Reporte Adjunto.", _
            '                                                "Reporte_DesviacionPROD_SAP")
            'End If





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick
        Try
            'Shell("D:\Programacion\Add on\waProduccion_Pedidos\waProduccion_Pedidos\bin\Debug\Help\helpListadoOrdenes.png")
            'Process.Start("D:\Programacion\Add on\waProduccion_Pedidos\waProduccion_Pedidos\bin\Debug\Help\helpListadoOrdenes.png")
            Process.Start(Application.StartupPath.ToString + "\Help\helpListadoOrdenes.png")


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class