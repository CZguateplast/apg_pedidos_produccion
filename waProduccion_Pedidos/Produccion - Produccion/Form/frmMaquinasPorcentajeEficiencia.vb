Public Class frmMaquinasPorcentajeEficiencia
    'Public Sub New()
    'End Sub
#Region "Carga Inicial"
    Private Sub Sub_Seguridad()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            mSeguridad.APG_Seguridad(Me, barbtnBitacoraModificacionHistorial)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmPorcEficienciaMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sub_PorcEficienciaMaquinas()
            dteFecha.EditValue = String.Empty
            spinPorcentaje.EditValue = String.Empty
            Sub_Seguridad()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub sub_PorcEficienciaMaquinas()
        Try
            Dim dt As New DataTable("dtPorcEficienciaMaquinas")
            dt = mSQLSelect.GET_PorcEficienciaMaquinas()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsPorcEficienciaMaquinas1.Tables("dsdtPorcEficienciaMaquinas").Clear()
            DsPorcEficienciaMaquinas1.Tables("dsdtPorcEficienciaMaquinas").Merge(dt)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Botones"
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            Dim pFecha As String = mFunciones.ConvertirFechaSQL(dteFecha)
            Dim pPorcentaje As String = spinPorcentaje.EditValue.ToString

            If pFecha = "1-1-1" Then
                mMensajes.msg_InformacionIncompleta("Fecha")
                Exit Sub
            ElseIf pPorcentaje = "0" Then
                mMensajes.msg_InformacionIncompleta("Porcentaje")
                Exit Sub
            End If

            If dteFecha.EditValue > DateTime.Now Then
                mMensajes.msg_Error("No puede ingresar una fecha mayor a ( " + DateTime.Now.ToString("dd/MM/yyyy") + " ).")
                Exit Sub
            End If

            Dim dt As New DataTable("dtPorcEficienciaMaquinas")

            If Not mSQLSelect.GET_PorcEficienciaMaquinas(pFecha).Rows.Count = Nothing Then
                vpBoolean = False
                If mMensajes.msg_ActualizarPorcEficienciaMaquinas(pPorcentaje, pFecha) Then
                    If mSQLUpdate.UPDATE_PorcEficienciaMaquinas(pPorcentaje, pFecha) Then 'Actualizacion
                        mMensajes.msg_ActualizarPorcEficienciaMaquinas_Ok(pPorcentaje, pFecha)
                        sub_PorcEficienciaMaquinas()
                    Else
                        mMensajes.msg_ActualizarPorcEficienciaMaquinas_Error(pPorcentaje, pFecha)
                    End If
                End If

                Exit Sub
            End If

            vpBoolean = True
            SET_PorcEficienciaMaquinas(pFecha, pPorcentaje)

            sub_PorcEficienciaMaquinas()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
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
    
#End Region

    Private Sub barbtnBitacoraModificacionHistorial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBitacoraModificacionHistorial.ItemClick
        Try
            frmMaquinasPorcentajeEficiencia_LOG.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class