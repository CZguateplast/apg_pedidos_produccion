Imports System.Drawing
Public Class frmMaquinas
#Region "Carga Inicial"
    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            mSeguridad.APG_Seguridad(Me, barbtnBitacoraModificacion)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub frmMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ValoresDefault()
            Sub_Catalogo_Maquinas()
            Sub_Seguridad_APG()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_Botones(ByVal pAgregar As Boolean, ByVal pGrabar As Boolean, ByVal pCancelar As Boolean,
                         ByVal pActualizar As Boolean, ByVal pBuscar As Boolean, ByVal pImprimir As Boolean,
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
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ValoresDefault()
        Try
            FCN_BarButtonItem_Enabled(barbtnGrabar)
            FCN_BarButtonItem_Enabled(barbtnCancelar)
            FCN_BarButtonItem_Enabled(barbtnActualizar)

            'verticalGrid
            FCN_FILL_SearchLookUpEdit(vrslueTipoMaquina, mSQLSelect.GET_Listado("Maquina_Tipo"), "Id", "Nombre")
            FCN_FILL_SearchLookUpEdit(rslueTipoMaquina, mSQLSelect.GET_Listado("Maquina_Tipo"), "Id", "Nombre")
            FCN_FILL_SearchLookUpEdit(rslueUbicacion, GET_Listado_MaquinasBodegas(), "Id", "Nombre")
            FCN_FILL_SearchLookUpEdit(vrslueUbicacion, GET_Listado_MaquinasBodegas(), "Id", "Nombre")


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub Sub_Catalogo_Maquinas()
        Try
            Dim dt As New DataTable("dtMaquinas")
            dt = mSQLSelect.GET_Catalogo_Maquinas()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinas2.TableName.ToString).Clear()
            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinas2.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewMaquinas_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMaquinas.DoubleClick
        Try
            Dim dt As New DataTable("dtMaquinaSeleccion")
            dt = mSQLSelect.GET_Catalogo_Maquinas(mFunciones.FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewMaquinas, "Id"))

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Clear()
            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Merge(dt)

            Sub_Botones(False, False, True, True, False, False, True)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Botones"

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("Nombre", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            Dim row As DataRow = dt.NewRow()
            row("Nombre") = " "
            dt.Rows.Add(row)


            'Vaciar Vertical Grid de Maquinas
            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Clear() 'Vaciar Controles
            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Merge(dt)

            'Vaciar GridView de Maquinas
            DsMaquinas1.Tables("dsdtMaquinas").Clear() 'Vaciar Controles


            Sub_Botones(False, True, True, False, False, False, True)
            'FCN_BarButtonItem_Enabled(barbtnAgregar)
            'FCN_BarButtonItem_Enabled(barbtnGrabar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            'FCN_BarButtonItem_Enabled(barbtnBitacoraModificacion)
            FCN_VerticalGridRow_Enabled(rowId)

            barbtnActualizar.Enabled = False
            rowId.Enabled = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            'Cerrar el editor del VerticalGrid
            vgrdMaquinas.CloseEditor()

            'INICIO -- Validar Campos -------------------------------
            If Not sub_Validacion_VerticalGrid() Then
                Exit Sub
            End If
            'FIN ----- Validar Campos -------------------------------

            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Id")
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Nombre")
            Dim pModelo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Modelo")
            Dim pGrupo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Grupo")
            Dim pTipo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Tipo")
            Dim pStatus As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Estatus")

            Dim dt As New DataTable("dtMoldes")
            dt = mSQLSelect.GET_Catalogo_Maquinas(pId) 'Obtener Datos si existen

            'Validar que no exista la maquina que se desea guardar
            If Not dt.Rows.Count = Nothing Then
                mMensajes.msg_Proceso_Error("El Id de la Maquina ( " + pId.ToString + " )  ya existe en la Base de Datos")
                Exit Sub
            End If

            'INICIO Area para guardar --------------------------------------------------------------------------------------------------------------------

            If Not mMensajes.msg_GrabarMaquina(pId) Then 'Preguntar si desea grabar la nueva
                Exit Sub
            End If

            If mSQLInsert.SET_Maquinas(DsMaquinas1.dsdtMaquinaSeleccionada2) Then
                mMensajes.msg_GrabarMaquina_Ok(pId)
            Else
                mMensajes.msg_GrabarMaquina_Error(pId)
                Exit Sub
            End If

            'FINAL Area para guardar ---------------------------------------------------------------------------------------------------------------------



            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Clear() 'borrar DataSet de Seleccion

            Sub_Catalogo_Maquinas() 'Llenar Grid Principal de Maquinas

            Sub_Botones(True, False, False, False, True, True, False)

            rowId.Enabled = False


            ''Si se a completado entonces se Restablecen los controles
            'FCN_BarButtonItem_Enabled(barbtnGrabar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            'FCN_BarButtonItem_Enabled(barbtnBitacoraModificacion)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub barbtnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelar.ItemClick
        Try
            If Not mMensajes.msg_ContinuarSinGuardar() Then
                Exit Sub
            End If



            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Clear() 'Vaciar Controles

            Sub_Catalogo_Maquinas() 'Llenar Grid Principal de Moldes

            'Restablecer controles
            Sub_Botones(True, False, False, False, True, True, False)

            rowId.Enabled = False

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdMaquinas.CloseEditor()

            'INICIO -- Validar Campos -------------------------------
            If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If
            'FIN ----- Validar Campos -------------------------------

            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Id")
            'Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Nombre")
            'Dim pModelo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Modelo")
            'Dim pGrupo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Grupo")
            'Dim pTipo As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Tipo")
            'Dim pStatus As String = mFunciones.FCN_GetCellValue(vgrdMaquinas, "Estatus")

            If msg_ActualizarMaquina(pId) Then
                If mSQLUpdate.UPDATE_Maquinas(DsMaquinas1.dsdtMaquinaSeleccionada2) Then
                    mMensajes.msg_ActualizarMaquina_Ok(pId)
                Else
                    mMensajes.msg_ActualizarMaquina_Error(pId)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If


            DsMaquinas1.Tables(DsMaquinas1.dsdtMaquinaSeleccionada2.TableName.ToString).Clear() ' Borrar Vertical Grid
            Sub_Catalogo_Maquinas() 'Llenar Grid Principal de Moldes

            Sub_Botones(True, False, False, False, True, True, False)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region
#Region "Grid Vertical"
    Private Function sub_Validacion_VerticalGrid() As Boolean
        Try
            If FCN_GetCellValue(vgrdMaquinas, "Id") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Id) de Maquina. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMaquinas, "Grupo") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Grupo) de Maquina. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMaquinas, "Tipo") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Tipo) de Maquina. ")
                Return False
            End If

            barbtnActualizar.Enabled = False
            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Private Sub vgrdMaquinas_EditorKeyPress(sender As Object, e As KeyPressEventArgs) Handles vgrdMaquinas.EditorKeyPress
        Try

            If vgrdMaquinas.FocusedRow.Properties.FieldName = "Id" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMaquinas.FocusedRow.Properties.FieldName = "Nombre" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMaquinas.FocusedRow.Properties.FieldName = "Modelo" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                End If

            ElseIf vgrdMaquinas.FocusedRow.Properties.FieldName = "Grupo" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If

            ElseIf vgrdMaquinas.FocusedRow.Properties.FieldName = "Tipo" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                End If
            End If

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

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewMaquinas.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewMaquinas)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class