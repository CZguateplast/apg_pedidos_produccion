Public Class frmOrdenProduccionDisponibles

    Private Sub frmOrdenProduccionImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Seguridad_APG()
            Sub_CentrarSplit()
            Sub_Fill_grdviewProduccionPadres()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnImprimir)
            mSeguridad.APG_Seguridad(Me, barbtnActualizar)
            mSeguridad.APG_Seguridad(Me, barbtnReciboAplicar)
            mSeguridad.APG_Seguridad(Me, barbtnPrioridad)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_grdviewProduccionPadres()
        Try
            Dim dt As New DataTable("dtProduccionPadres")
            dt = mSQLSelect.GET_OrdenesProduccion_Padres()
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionPadres.TableName.ToString).Clear()
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionPadres.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_CentrarSplit()
        Try
            Dim pPosicion As Integer = Val(Me.Size.Width - 50) / 2
            splitOrdenProduccion.SplitterPosition = pPosicion
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub frmOrdenProduccionImpresion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Sub_CentrarSplit()
    End Sub

    Private Sub grdviewProduccionPadres_DoubleClick(sender As Object, e As EventArgs) Handles grdviewProduccionPadres.DoubleClick
        Try
            'Sub_Fill_grdviewProduccionHijos()
            Sub_Imprimir()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewProduccionPadres_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewProduccionPadres.FocusedRowChanged
        Try
            If grdviewProduccionPadres.RowCount = Nothing Then
                Exit Sub
            End If

            Sub_Fill_grdviewProduccionHijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_Fill_grdviewProduccionHijos()
        Try
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionOrden.TableName.ToString).Clear()
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()


            If grdviewProduccionPadres.RowCount = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoPadre As String = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")

            If pCodigoPadre = String.Empty Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If
            'dt = mSQLSelect.GET_OrdenesProduccion_Hijos(pCodigoPadre)
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Hijos] CP," + pCodigoPadre.ToString)
            If dt.Rows.Count = Nothing Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If

            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_GrdviewProduccionOrden()
        Try
            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewProduccionHijos, "CodigoArticulo")
            Dim pNombreArticulo As String = mFunciones.FCN_GetCellValue(grdviewProduccionHijos, "NombreArticulo")

            txtCodigoArticulo.EditValue = String.Empty
            txtNombreArticulo.EditValue = String.Empty

            If pCodigoArticulo = String.Empty Then
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionOrden.TableName.ToString).Clear()
                Exit Sub
            End If


            dt = mSQLSelect.GET_OrdenesProduccion_Orden("CP", pCodigoArticulo)
            If dt.Rows.Count = Nothing Then
                txtCodigoArticulo.EditValue = String.Empty
                txtNombreArticulo.EditValue = String.Empty
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionOrden.TableName.ToString).Clear()
                Exit Sub
            End If

            txtCodigoArticulo.EditValue = pCodigoArticulo
            txtNombreArticulo.EditValue = pNombreArticulo

            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionOrden.TableName.ToString).Clear()
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionOrden.TableName.ToString).Merge(dt)

            ''Datos para Impresion
            'Dim dtOrdenesProduccionImpresion As New DataTable("dtOrdenesProduccionImpresion")
            'dtOrdenesProduccionImpresion = GET_OrdenesProduccion_Impresion(pCodigoArticulo)

            'If dt.Rows.Count = Nothing Then
            '    DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionDatosProduccionOrden.TableName.ToString).Clear()
            '    Exit Sub
            'End If

            'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionDatosProduccionOrden.TableName.ToString).Clear()
            'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionDatosProduccionOrden.TableName.ToString).Merge(dtOrdenesProduccionImpresion)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdProduccionHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdProduccionHijos.DoubleClick
        Try
            Sub_Fill_GrdviewProduccionOrden()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewProduccionHijos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewProduccionHijos.FocusedRowChanged
        Try
            If grdviewProduccionHijos.RowCount = Nothing Then
                Exit Sub
            End If
            Sub_Fill_GrdviewProduccionOrden()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnImprimir_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            Sub_Imprimir()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Imprimir()
        Try

            frmOrdenProduccionImpresion.DsOrdenProduccionImpresion.Tables(frmOrdenProduccionImpresion.DsOrdenProduccionImpresion.dsdtProduccionHijos.TableName.ToString).Clear()
            frmOrdenProduccionImpresion.DsOrdenProduccionImpresion.Tables(frmOrdenProduccionImpresion.DsOrdenProduccionImpresion.dsdtProduccionHijos.TableName.ToString).Merge(DsOrdenProduccionImpresion1.dsdtProduccionHijos)
            vpCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")
            frmOrdenProduccionImpresion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            Sub_Fill_grdviewProduccionPadres()
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

    Private Sub barbtnReciboAplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReciboAplicar.ItemClick
        Try
            frmReciboProduccionEnsamble.Text = "Recibos de Produccion y Ensamble"
            frmReciboProduccionEnsamble.StartPosition = FormStartPosition.CenterScreen
            frmReciboProduccionEnsamble.vpCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")
            frmReciboProduccionEnsamble.ShowDialog()

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

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            If grdProduccionPadres.IsFocused Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewProduccionPadres)
            ElseIf grdProduccionHijos.IsFocused Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewProduccionHijos)
            ElseIf grdProduccionDetalle.IsFocused Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewOrdenesDetalle)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdProduccionPadres.IsFocused Then
                grdviewProduccionPadres.ShowRibbonPrintPreview()
            ElseIf grdProduccionHijos.IsFocused Then
                grdviewProduccionHijos.ShowRibbonPrintPreview()
            ElseIf grdProduccionDetalle.IsFocused Then
                grdviewOrdenesDetalle.ShowRibbonPrintPreview()
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
                ElseIf grdProduccionHijos.IsFocused Then
                    grdviewProduccionHijos.ExportToXlsx(sfdSave.FileName)
                ElseIf grdProduccionDetalle.IsFocused Then
                    grdviewOrdenesDetalle.ExportToXlsx(sfdSave.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnPrioridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnPrioridad.ItemClick
        Try
            Dim pCodigoArticulo As String = String.Empty

            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProduccionPadres, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                Exit Sub
            End If

            frmTemporal_Prioridades.ppCodigo = pCodigoArticulo
            frmTemporal_Prioridades.ShowDialog()

            If frmTemporal_Prioridades.ppProceso = True Then
                Sub_Fill_grdviewProduccionPadres()
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmOrdenProduccionDisponibles_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked

    End Sub

    Private Sub barbtnHelp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnHelp.ItemClick

        Try
            Dim path = System.IO.Path.Combine(Application.StartupPath, "help/frmOrdenProduccionDisponible.htm")
            System.Diagnostics.Process.Start(path)
            'Dim path = System.IO.Path.Combine(Application.StartupPath, "frmOrdenProduccionDisponible.chm")
            'Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
            'Help.ShowHelp(ParentForm, "frmOrdenProduccionDisponible.htm", HelpNavigator.TableOfContents)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub grdviewProduccionPadres_Click(sender As Object, e As EventArgs) Handles grdviewProduccionPadres.Click
        Try
            Sub_Fill_grdviewProduccionHijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
End Class