Public Class frmAsignarMoldesMaquinas_Old


#Region "Carga Inicial"
    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            mSeguridad.APG_Seguridad(barbtnBitacoraModificacion)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmAsigMoldes_Maquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ValoresDefault()
            Sub_GetAsigMoldes_Maquinas()
            mSeguridad.APG_Seguridad(Me, barbtnBitacoraModificacion)
            Sub_Seguridad_APG()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ValoresDefault()
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(vrlueMateriales, mSQLSelect.GET_Listado_Materiales(), "Id", "Id")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub Sub_GetAsigMoldes_Maquinas()
        Try
            Dim dt As New DataTable("dtAsigMoldes_Maquinas")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsAsigMoldes_Maquinas1.Tables("dsdtAsigMoldes_Maquinas").Clear()
            DsAsigMoldes_Maquinas1.Tables("dsdtAsigMoldes_Maquinas").Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewMoldes_Maquinas_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMoldes_Maquinas.DoubleClick
        Try
            Dim pMolde As String = mFunciones.FCN_GetCellValue(grdviewMoldes_Maquinas, "Molde")
            Dim pMaquina As String = mFunciones.FCN_GetCellValue(grdviewMoldes_Maquinas, "Maquina")
            Dim pMaterial1 As String = mFunciones.FCN_GetCellValue(grdviewMoldes_Maquinas, "Material1")
            Dim pMaterial2 As String = mFunciones.FCN_GetCellValue(grdviewMoldes_Maquinas, "Material2")

            Dim dt As New DataTable("dtAsigMoldes_MaquinasSeleccionada")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(pMolde, pMaquina, pMaterial1, pMaterial2)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsAsigMoldes_Maquinas1.Tables("dsdtAsigMoldes_MaquinasSeleccionado").Clear()
            DsAsigMoldes_Maquinas1.Tables("dsdtAsigMoldes_MaquinasSeleccionado").Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region
#Region "Botones"
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            frmAsignarMoldesMaquinas.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            grdviewMoldes_Maquinas.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewMoldes_Maquinas)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdMoldes_Maquinas.CloseEditor()
            'If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pMolde As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Molde")
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Nombre")
            Dim pMaquina As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Maquina")
            Dim pMaterial1 As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Material1")
            Dim pMaterial2 As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Material2")
            Dim pUnidadesXHora As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "UnidadesXHora")
            Dim pInyeccionesXHora As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "InyeccionesXHora")
            Dim pCostoHoraNormal As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "CostoHoraNormal")
            Dim pCostoHoraIncremento As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "CostoHoraIncremento")
            Dim pEstatus As String = mFunciones.FCN_GetCellValue(vgrdMoldes_Maquinas, "Estatus")

            If Not mMensajes.msg_ActualizarMoldesMaquinas(pMolde, pMaquina, pMaterial1, pMaterial2) Then
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_AsigMoldes_Maquinas(pMolde, pMaquina, pMaterial1, pMaterial2, pUnidadesXHora, pInyeccionesXHora, pCostoHoraNormal, pCostoHoraIncremento, pEstatus) Then
                mMensajes.msg_ActualizarMoldesMaquinas_Ok(pMolde, pMaquina, pMaterial1, pMaterial2)
            Else
                mMensajes.msg_ActualizarMoldesMaquinas_Error(pMolde, pMaquina, pMaterial1, pMaterial2)
            End If

            DsAsigMoldes_Maquinas1.Tables("dsdtAsigMoldes_MaquinasSeleccionado").Clear() 'Vaciar Controles
            Sub_GetAsigMoldes_Maquinas()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region

    Private Sub barbtnBitacoraModificacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBitacoraModificacion.ItemClick
        Try
            If barbtnBitacoraModificacion.Down Then
                rowBit_CreacionUsuario.Visible = True
                rowBit_CreacionFecha.Visible = True
                rowBit_ModificacionUsuario.Visible = True
                rowBit_ModificacionFecha.Visible = True
            Else
                rowBit_CreacionUsuario.Visible = False
                rowBit_CreacionFecha.Visible = False
                rowBit_ModificacionUsuario.Visible = False
                rowBit_ModificacionFecha.Visible = False
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class