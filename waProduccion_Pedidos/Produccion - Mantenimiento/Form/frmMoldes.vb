Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraEditors.Controls

Public Class frmMoldes
#Region "Carga Inicial"
    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub frmMoldes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Listado_Moldes()
            Sub_ValoresDefault()
            Sub_Seguridad_APG()
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
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_ValoresDefault()
        Try
            Sub_Botones(True, False, False, False, True, True, False)
            'FCN_BarButtonItem_Enabled(barbtnGrabar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)

            FCN_FILL_SearchLookUpEdit(rslueMaquinas, GET_Listado_Maquinas(), "Id", "Id")
            FCN_FILL_SearchLookUpEdit(vrslueBodegas, mSQLSelect.GET_PROD_CatListados("Moldes_Bodegas"), "Id", "Nombre")
            FCN_FILL_SearchLookUpEdit(rslueBodega, mSQLSelect.GET_PROD_CatListados("Moldes_Bodegas"), "Id", "Nombre")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub Sub_Listado_Moldes()
        Dim dt As New DataTable("dtMoldes")
        dt = mSQLSelect.GET_Search_Molde()

        If Not dt.Rows.Count = Nothing Then
            DsMoldes1.Tables("dsdtMoldes").Clear()
            DsMoldes1.Tables("dsdtMoldes").Merge(dt)
        End If
    End Sub
    Private Sub grdviewMoldes_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMoldes.DoubleClick
        Try
            Dim dt As New DataTable("dtMoldes_Seleccion")
            dt = mSQLSelect.GET_Search_Moldes(mFunciones.FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewMoldes, "Id"))

            If Not dt.Rows.Count = Nothing Then
                DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear()
                DsMoldes1.Tables("dsdtMoldes_Seleccion").Merge(dt)
            End If

            Sub_Botones(False, False, True, True, False, False, True)

            rowId.Enabled = False
            rowMoldeSerie.Enabled = False

            'barbtnAgregar.Enabled = False
            'barbtnCancelar.Enabled = True
            'barbtnActualizar.Enabled = True


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Vertical"
    Private Function sub_Validacion_VerticalGrid() As Boolean
        Try
            If FCN_GetCellValue(vgrdMoldes, "Id") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Id) del Molde. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMoldes, "Nombre") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Nombre) del Molde. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMoldes, "Cavidades") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Cavidades) del Molde. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMoldes, "Unidades") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Unidades) del Molde. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMoldes, "MoldeSerie") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (MoldeSerie) del Molde. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdMoldes, "PorcIneficiencia") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Porcentaje Ineficiencia) del Molde. ")
                Return False
            End If
            barbtnActualizar.Enabled = False
            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Private Sub vgrdMoldes_EditorKeyPress(sender As Object, e As KeyPressEventArgs) Handles vgrdMoldes.EditorKeyPress
        Try
            If vgrdMoldes.FocusedRow.Properties.FieldName = "Id" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMoldes.FocusedRow.Properties.FieldName = "MoldeSerie" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If

            ElseIf vgrdMoldes.FocusedRow.Properties.FieldName = "Nombre" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMoldes.FocusedRow.Properties.FieldName = "Cavidades" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMoldes.FocusedRow.Properties.FieldName = "Unidades" Then
                If Not mFunciones.ValidarNumeros_SI(e) Then
                    e.KeyChar = String.Empty
                End If
            ElseIf vgrdMoldes.FocusedRow.Properties.FieldName = "Comentarios" Then
                If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                    e.KeyChar = String.Empty
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub rmmeComentarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rmmeComentarios.KeyPress
        Try
            If Not mFunciones.ValidarCaracteresEspeciales(e) Then
                e.KeyChar = String.Empty
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
        
    End Sub
    Private Sub vgrdMoldes_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles vgrdMoldes.InvalidValueException
        Try
            If vgrdMoldes.FocusedRow.Properties.FieldName = "Id" Then
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
                e.WindowCaption = "Error en la Información ingresada"
                e.ErrorText = "Esta casilla no permite ingresar letras"
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Botones"
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            Sub_Botones(False, True, True, False, False, False, True)


            'FCN_BarButtonItem_Enabled(barbtnAgregar)
            'FCN_BarButtonItem_Enabled(barbtnGrabar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            ''FCN_BarButtonItem_Enabled(barbtnBitacoraModificacion)
            barbtnActualizar.Enabled = False

            rowId.Enabled = True
            rowMoldeSerie.Enabled = True

            'FCN_VerticalGridRow_Enabled(rowId)
            'FCN_VerticalGridRow_Enabled(rowMoldeSerie)


            DsMoldes1.Tables("dsdtMoldes").Clear() 'BORRAR DataSet del Listado de Moldes


            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("Nombre", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            Dim row As DataRow = dt.NewRow()
            row("Nombre") = " "
            dt.Rows.Add(row)

            DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear()
            DsMoldes1.Tables("dsdtMoldes_Seleccion").Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            'Cerrar el editor del VerticalGrid
            vgrdMoldes.CloseEditor()

            'INICIO -- Validar Campos -------------------------------
            If Not sub_Validacion_VerticalGrid() Then
                Exit Sub
            End If
            'FIN ----- Validar Campos -------------------------------

            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Id") 'Obtener Id Seleccionado
            Dim pMoldeSerie As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "MoldeSerie") 'Obtener Molde Serie Seleccionado
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Nombre") 'Obtener Molde Serie Seleccionado
            Dim pCavidades As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Cavidades") 'Obtener Cavidades Seleccionado
            Dim pUnidades As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Unidades") ' Obtener Unidades Serie Seleccionado
            Dim pMaquinaPreferencial As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "MaquinaPreferencial") 'Obtener Maquina Preferencial Seleccionado
            Dim pComentarios As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Comentarios") 'Obtener Comentario Seleccionado
            Dim pPorcIneficiencia As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "PorcIneficiencia") 'Obtener Porcentaje Efficiencia
            Dim pStatus As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Estatus") 'Obtener Estatus Serie Seleccionado

            If pUnidades = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Molde ( " + pId.ToString + " ) Serie ( " + pMoldeSerie.ToString + " ) No tiene Unidades por Inyección.")
                Exit Sub
            End If

            If pCavidades = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Molde ( " + pId.ToString + " ) Serie ( " + pMoldeSerie.ToString + " ) No tiene Cavidades.")
                Exit Sub
            End If

            Dim dt As New DataTable("dtMoldes")
            dt = mSQLSelect.GET_Search_Molde(pId, pMoldeSerie) 'Obtener Datos si existen

            'Validar que no exista el Molde que se desea guardar
            If Not dt.Rows.Count = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Molde ( " + pId.ToString + " ) Serie ( " + pMoldeSerie.ToString + " ) ya existe en la Base de Datos")
                Exit Sub
            End If

            'INICIO Area para guardar --------------------------------------------------------------------------------------------------------------------

            If Not mMensajes.msg_GrabarMoldes(pId, pMoldeSerie) Then 'Preguntar si desea grabar el nuevo molde
                Exit Sub
            End If

            If mSQLInsert.SET_Moldes(pId, pMoldeSerie, pNombre, pCavidades, pUnidades, pPorcIneficiencia, pComentarios, pStatus) Then
                mMensajes.msg_GrabarMoldes_Ok(pId, pMoldeSerie)
            Else
                mMensajes.msg_GrabarMoldes_Error(pId, pMoldeSerie)
                Exit Sub
            End If

            'FINAL Area para guardar ---------------------------------------------------------------------------------------------------------------------

            FCN_VerticalGridRow_Enabled(rowId)
            FCN_VerticalGridRow_Enabled(rowMoldeSerie)
            barbtnActualizar.Enabled = False

            DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear() 'borrar DataSet de Seleccion

            Sub_Listado_Moldes() 'Llenar Grid Principal de Moldes

            'Si se a completado entonces se Restablecen los controles
            Sub_Botones(True, False, False, False, True, True, False)

            'FCN_BarButtonItem_Enabled(barbtnAgregar)
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
        

            DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear() 'Vaciar Controles

            Sub_Listado_Moldes() 'Llenar Grid Principal de Moldes

            'Restablecer controles
            Sub_Botones(True, False, False, False, True, True, False)
            FCN_VerticalGridRow_Enabled(rowId)
            FCN_VerticalGridRow_Enabled(rowMoldeSerie)

            'FCN_BarButtonItem_Enabled(barbtnAgregar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)
            'FCN_BarButtonItem_Enabled(barbtnBitacoraModificacion)
            'barbtnActualizar.Enabled = False
            'barbtnGrabar.Enabled = False

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdMoldes.CloseEditor()
            Dim pId As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Id") 'Obtener Id Seleccionado
            Dim pMoldeSerie As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "MoldeSerie") 'Obtener Molde Serie Seleccionado
            Dim pNombre As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Nombre") 'Obtener Molde Serie Seleccionado
            Dim pCavidades As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Cavidades") 'Obtener Cavidades Seleccionado
            Dim pUnidades As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Unidades") ' Obtener Unidades Serie Seleccionado
            Dim pMaquinaPreferencial As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "MaquinaPreferencial") 'Obtener Maquina Preferencial Seleccionado
            Dim pUbicacion As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Ubicacion") 'Obtener Maquina Preferencial Seleccionado
            Dim pPorcIneficiencia As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "PorcIneficiencia") 'Obtener PorcentajeEficiencia
            Dim pComentario As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Comentarios") 'Obtener Comentario Seleccionado
            Dim pStatus As String = mFunciones.FCN_GetCellValue(vgrdMoldes, "Estatus") 'Obtener Estatus Serie Seleccionado


            If pUnidades = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Molde ( " + pId.ToString + " ) Serie ( " + pMoldeSerie.ToString + " ) No tiene Unidades por Inyección.")
                Exit Sub
            End If

            If pCavidades = Nothing Then
                mMensajes.msg_Proceso_Error("El Id del Molde ( " + pId.ToString + " ) Serie ( " + pMoldeSerie.ToString + " ) No tiene Cavidades.")
                Exit Sub
            End If


            If msg_ActualizarMoldes(pId, pMoldeSerie) Then
                If mSQLUpdate.UPDATE_Moldes(pId, pMoldeSerie, pNombre, pCavidades, pUnidades, pMaquinaPreferencial, pUbicacion, pPorcIneficiencia, pComentario, pStatus) Then
                    mMensajes.msg_ActualizarMoldes_Ok(pId, pMoldeSerie)
                Else
                    mMensajes.msg_ActualizarMoldes_Error(pId, pMoldeSerie)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If


            DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear() ' Borrar Vertical Grid
            Sub_Listado_Moldes() 'Llenar Grid Principal de Moldes

            Sub_Botones(True, False, False, False, True, True, False)

            'FCN_BarButtonItem_Enabled(barbtnAgregar)
            'FCN_BarButtonItem_Enabled(barbtnActualizar)
            'FCN_BarButtonItem_Enabled(barbtnCancelar)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region

    Private Sub barbtnBitacoraModificacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBitacoraModificacion.ItemClick
        Try
            If barbtnBitacoraModificacion.Down = True Then
                rowBit_CreacionUsuario1.Visible = True
                rowBit_CreacionFecha.Visible = True
                rowBit_ModificacionUsuario1.Visible = True
                rowBit_ModificacionFecha1.Visible = True
            Else
                rowBit_CreacionUsuario1.Visible = False
                rowBit_CreacionFecha.Visible = False
                rowBit_ModificacionUsuario1.Visible = False
                rowBit_ModificacionFecha1.Visible = False
            End If
            
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewMoldes.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewMoldes)
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


    



    
    Private Sub barbtnActualizarPorcEficiencia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarPorcEficiencia.ItemClick
        Try

            If barspinPorcEficiencia.EditValue = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea Actualizar el Porcentaje de ineficiencia de  TODOS LOS MOLDES? " + Environment.NewLine + " Cambiar a < " + barspinPorcEficiencia.EditValue.ToString + " > ?", MsgBoxStyle.YesNo, "Actualizar") = MsgBoxResult.Yes Then
                If UPDATE_Moldes(barspinPorcEficiencia.EditValue.ToString) Then
                    mMensajes.msg_Proceso_ok()
                Else
                    mMensajes.msg_Proceso_Error()
                End If
            End If

            DsMoldes1.Tables("dsdtMoldes_Seleccion").Clear() ' Borrar Vertical Grid
            Sub_Listado_Moldes() 'Llenar Grid Principal de Moldes

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class