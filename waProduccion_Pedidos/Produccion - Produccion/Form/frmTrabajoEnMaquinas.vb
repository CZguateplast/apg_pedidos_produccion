Public Class frmTrabajoEnMaquinas

    Private Sub frmTrabajoEnMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LOADING()
            timeTrabajoEnMaquina.Start()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LOADING()
        Try
            Dim dtTrabajoEnMaquinas As New DataTable()
            dtTrabajoEnMaquinas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProgramacionProduccion_Prioridad1")

            DsTrabajoEnMaquinas1.Tables(DsTrabajoEnMaquinas1.dsdtTrabajoEnMaquina.TableName.ToString).Clear()

            If dtTrabajoEnMaquinas.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsTrabajoEnMaquinas1.Tables(DsTrabajoEnMaquinas1.dsdtTrabajoEnMaquina.TableName.ToString).Merge(dtTrabajoEnMaquinas)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub timeTrabajoEnMaquina_Tick(sender As Object, e As EventArgs) Handles timeTrabajoEnMaquina.Tick
        Try
            LOADING()
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
            mFunciones.FCN_XTRAGRID_Buscar(lyvTrabajoEnMaquina)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            lyvTrabajoEnMaquina.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnFiltroEnProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFiltroEnProceso.ItemClick
        Try
            lyvTrabajoEnMaquina.Columns("Estado").FilterMode() = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            lyvTrabajoEnMaquina.ActiveFilterString = "[Estado] = 'En Proceso'"
            'lyvTrabajoEnMaquina.ApplyFindFilter("""En Proceso""")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnFitroEnPausa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFitroEnPausa.ItemClick
        Try
            lyvTrabajoEnMaquina.Columns("Estado").FilterMode() = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            lyvTrabajoEnMaquina.ActiveFilterString = "[Estado] = 'En Espera'"

            'lyvTrabajoEnMaquina.ApplyFindFilter("""En Espera""")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub barbtnFiltroBodega_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFiltroBodega.ItemClick
        Try
            lyvTrabajoEnMaquina.Columns("Ubicacion").FilterMode() = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            lyvTrabajoEnMaquina.ActiveFilterString = "[Ubicacion] = 'Bodega'"

            'lyvTrabajoEnMaquina.ApplyFindFilter("""Bodega""")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnFiltroFabrica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFiltroFabrica.ItemClick
        Try
            lyvTrabajoEnMaquina.Columns("Ubicacion").FilterMode() = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            lyvTrabajoEnMaquina.ActiveFilterString = "[Ubicacion] = 'Fabrica'"
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRecibos.ItemClick
        Try
            frmReciboProduccionEnsamble.Text = "Recibos de Produccion y Ensamble"
            frmReciboProduccionEnsamble.StartPosition = FormStartPosition.CenterScreen
            frmReciboProduccionEnsamble.vpCodigoArticulo = mFunciones.FCN_GetCellValue(lyvTrabajoEnMaquina, "CodigoArticulo")
            frmReciboProduccionEnsamble.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub
End Class