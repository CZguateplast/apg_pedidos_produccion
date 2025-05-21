Public Class frmAsignarCodigosProducidosMoldes

#Region "Carga Inicial"
    
    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            'mSeguridad.APG_Seguridad(Me, barbtnBitacoraModificacion)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub Sub_Botones(ByVal pAgregar As Boolean, ByVal pGrabar As Boolean, ByVal pCancelar As Boolean, _
                                 ByVal pActualizar As Boolean, ByVal pBuscar As Boolean, ByVal pImprimir As Boolean, _
                                 ByVal pDatosBit As Boolean)
        Try
            If pAgregar = True Then
                mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            Else
                barbtnAgregar.Enabled = False
            End If

            If pGrabar = True Then
                barbtnGrabar.Enabled = True
            Else
                barbtnGrabar.Enabled = False
            End If

            If pCancelar = True Then
                barbtnCancelar.Enabled = True
            Else
                barbtnCancelar.Enabled = False
            End If

            If pActualizar = True Then
                mSeguridad.APG_Seguridad(Me, barbtnActualizar)
            Else
                barbtnActualizar.Enabled = False
            End If

            If pBuscar = True Then
                barbtnBuscar.Enabled = True
            Else
                barbtnBuscar.Enabled = False
            End If

            If pImprimir = True Then
                barbtnImprimirGrid.Enabled = True
            Else
                barbtnImprimirGrid.Enabled = False
            End If

            If pDatosBit = True Then
                mSeguridad.APG_Seguridad(Me, barbtnBitacoraModificacion)
            Else
                barbtnBitacoraModificacion.Enabled = False
                rowBit_CreacionUsuario.Visible = False
                rowBit_CreacionFecha.Visible = False
                rowBit_ModificacionUsuario.Visible = False
                rowBit_ModificacionFecha.Visible = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub
    Private Sub frmAsigCP_Moldes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_CargarCodigosProducidos()
            ValoresDefault()
            Sub_Seguridad_APG()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ValoresDefault()
        Try

            Sub_Botones(True, False, False, False, True, True, False)

            mFunciones.FCN_FILL_SearchLookUpEdit(vrslueMolde, mSQLSelect.GET_Listado_Moldes(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(vrslueMateriales, mSQLSelect.GET_Listado_Materiales(), "Id", "Id")


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub Sub_CargarCodigosProducidos()
        Dim dt As New DataTable("dtCodigosProducidos")
        dt = mSQLSelect.GET_Listado_CodigosProducidos()

        If Not dt.Rows.Count = Nothing Then
            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidos").Clear()
            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidos").Merge(dt)
        End If

    End Sub

    Private Sub grdviewCP_Moldes_DoubleClick(sender As Object, e As EventArgs) Handles grdviewCP_Moldes.DoubleClick
        Try
            Dim pCodigo As String = String.Empty
            pCodigo = mFunciones.FCN_GetCellValue(grdviewCP_Moldes, "Id")

            Dim dt As New DataTable("dtCodigosProducidosSeleccion")
            dt = mSQLSelect.GET_Listado_CodigosProducidos(pCodigo)

            If Not dt.Rows.Count = Nothing Then
                DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Clear()
                DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Merge(dt)
            End If

            Sub_Botones(False, False, True, True, False, False, True)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Vertical"

    Private Sub vgrdCP_Moldes_EditorKeyPress(sender As Object, e As KeyPressEventArgs) Handles vgrdCP_Moldes.EditorKeyPress
        Try
            If vgrdCP_Moldes.FocusedRow.Properties.FieldName = "Id" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                    Exit Sub
                End If
            ElseIf vgrdCP_Moldes.FocusedRow.Properties.FieldName = "Descripcion" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Function sub_Validacion_VerticalGrid() As Boolean
        Try
            If FCN_GetCellValue(vgrdCP_Moldes, "Id") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Id) del CodigoProducido. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdCP_Moldes, "Material1") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Material1) del Codigo Producido. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdCP_Moldes, "Molde") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Molde) del Codigo Producido. ")
                Return False
            End If
            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function


    Private Sub vrslueMolde_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles vrslueMolde.EditValueChanging
        Try
            vgrdCP_Moldes.SetCellValue(rowMolde, 0, e.NewValue)
            vpCodigoArticulo = e.NewValue.ToString
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            vgrdCP_Moldes.CloseEditor()
        End Try
    End Sub

    Private Sub vrslueMolde_EditValueChanged(sender As Object, e As EventArgs) Handles vrslueMolde.EditValueChanged
        Try

            Dim dt As New DataTable("dtMolde")
            dt = mSQLSelect.GET_Listado_Moldes("'" + vpCodigoArticulo + "'")
            If Not dt.Rows.Count = Nothing Then
                vgrdCP_Moldes.SetCellValue(rowNombre, 0, dt.Rows(0)("Nombre"))
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            vgrdCP_Moldes.CloseEditor()
        End Try
    End Sub

#End Region
#Region "Botones"

    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewCP_Moldes.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            vpCodigoArticulo = String.Empty
            frmTemporal_CodigosProducidos_Nuevos.ShowDialog()
            If Not vpBoolean Then
                Exit Sub
            End If

        
            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("Nombre", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            Dim row As DataRow = dt.NewRow()
            row("Nombre") = " "
            dt.Rows.Add(row)

            'Vaciar Vertical Grid de Maquinas
            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Clear() 'Vaciar Controles
            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Merge(dt)

            'Vaciar GridView de Maquinas
            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidos").Clear() 'Vaciar Controles

            Sub_Botones(False, False, True, True, False, False, True)

            'FCN_BarButtonItem_Enabled(barbtnAgregar)
            'FCN_BarButtonItem_Enabled(barbtnGrabar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            'FCN_BarButtonItem_Enabled(barbtnBuscar)
            'FCN_BarButtonItem_Enabled(barbtnImprimirGrid)
            'barbtnActualizar.Enabled = False

            vgrdCP_Moldes.SetCellValue(rowId, 0, vpCodigoArticulo.ToString)
            vgrdCP_Moldes.SetCellValue(rowDescripcion, 0, vpNombreArticulo.ToString)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            vgrdCP_Moldes.CloseEditor()
            If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Id")
            Dim pDescripcion As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Descripcion")
            Dim pMaterial1 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material1")
            Dim pMaterial1Porc As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material1Porc")
            Dim pMaterial2 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material2")
            Dim pMaterial2Porc As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material2Porc")
            Dim pMaterial3 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material3")
            Dim pMolde As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Molde")
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Nombre")
            Dim pEstatus As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Estatus")

            Dim dt As New DataTable("dtMoldes")
            dt = mSQLSelect.GET_Listado_CodigosProducidos(pId) 'Obtener Datos si existen

            'Validar que no exista la maquina que se desea guardar
            If Not dt.Rows.Count = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Codigo Producido ( " + pId.ToString + " )  ya existe en la Base de Datos")
                Exit Sub
            End If

            If Not mMensajes.msg_GrabarCodigosProducidos(pId, pMolde) Then
                Exit Sub
            End If

            If mSQLInsert.SET_CodigosProducidos(pId, pDescripcion, pMaterial1, pMaterial1Porc, pMaterial2, pMaterial2Porc, pMaterial3, pMolde, pEstatus) Then
                mMensajes.msg_GrabarCodigosProducidos_Ok(pId, pMolde)
            Else
                mMensajes.msg_GrabarCodigosProducidos_Error(pId, pMolde)
            End If

            'mFunciones.FCN_BarButtonItem_Enabled(barbtnAgregar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnGrabar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnCancelar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnBuscar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnImprimirGrid)

            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Clear() 'Vaciar Controles
            Sub_CargarCodigosProducidos()

            Sub_Botones(True, False, False, False, True, True, False)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelar.ItemClick
        Try
            If Not mMensajes.msg_ContinuarSinGuardar() Then
                Exit Sub
            End If


            'mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            'barbtnGrabar.Enabled = False
            'barbtnCancelar.Enabled = False
            'barbtnActualizar.Enabled = False
            'barbtnBuscar.Enabled = True
            ''barbtn()



            Sub_Botones(True, False, False, False, True, True, False)

            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Clear() 'Vaciar Controles
            Sub_CargarCodigosProducidos()



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdCP_Moldes.CloseEditor()
            If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Id")
            Dim pDescripcion As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Descripcion")
            Dim pMaterial1 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material1")
            Dim pMaterial1Porc As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material1Porc")
            Dim pMaterial2 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material2")
            Dim pMaterial2Porc As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material2Porc")
            Dim pMaterial3 As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Material3")
            Dim pMolde As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Molde")
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Nombre")
            Dim pEstatus As String = mFunciones.FCN_GetCellValue(vgrdCP_Moldes, "Estatus")

            If Not mMensajes.msg_ActualizarCodigosProducidos(pId, pMolde) Then
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_CodigosProducidos(pId, pDescripcion, pMaterial1, pMaterial1Porc, pMaterial2, pMaterial2Porc, pMaterial3, pMolde, pEstatus) Then
                mMensajes.msg_ActualizarCodigosProducidos_Ok(pId, pMolde)
            Else
                mMensajes.msg_ActualizarCodigosProducidos_Error(pId, pMolde)
            End If

            'mFunciones.FCN_BarButtonItem_Enabled(barbtnActualizar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnBuscar)
            'mFunciones.FCN_BarButtonItem_Enabled(barbtnImprimirGrid)

            DsAsigCP_Moldes1.Tables("dsdtCodigosProducidosSeleccionado").Clear() 'Vaciar Controles
            Sub_CargarCodigosProducidos()


            Sub_Botones(True, False, False, False, True, True, False)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewCP_Moldes)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtn_DatosBit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBitacoraModificacion.ItemClick
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




#End Region

End Class