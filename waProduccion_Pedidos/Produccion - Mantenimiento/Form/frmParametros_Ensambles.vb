Public Class frmParametros_Ensambles

    Private Sub frmParametros_Ensambles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Fill_grdviewParametros_Ensamble()
            Sub_Botones(True, False, False, False, True, True, False)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_grdviewParametros_Ensamble()
        Try
            Dim dt As New DataTable("dtParametrosEnsamble")

            dt = mSQLSelect.GET_Catalogo_EnsambleParametros()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsamble.TableName.ToString).Clear()
            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsamble.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Botones(ByVal pAgregar As Boolean, ByVal pGrabar As Boolean, ByVal pCancelar As Boolean, _
                       ByVal pActualizar As Boolean, ByVal pBuscar As Boolean, ByVal pImprimir As Boolean, _
                       ByVal pDatosBit As Boolean)
        Try
            If pAgregar = True Then
                'barbtnAgregar.Enabled = True
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
                barbtnBitacoraModificacion.Down = False
                rowBit_CreacionUsuario.Visible = False
                rowBit_CreacionFecha.Visible = False
                rowBit_ModificacionUsuario.Visible = False
                rowBit_ModificacionFecha.Visible = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewParametrosEnsamble_DoubleClick(sender As Object, e As EventArgs) Handles grdviewParametrosEnsamble.DoubleClick
        Try
            Dim dt As New DataTable("dtParametrosEnsamble")

            dt = mSQLSelect.GET_Catalogo_EnsambleParametros("'" + mFunciones.FCN_GetCellValue(grdviewParametrosEnsamble, "CodigoArticulo") + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Clear()
            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Merge(dt)

            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsamble.TableName.ToString).Clear()

            Sub_Botones(False, False, True, True, False, False, True)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

 
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

    Private Sub barbtnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelar.ItemClick
        Try
            If Not mMensajes.msg_ContinuarSinGuardar() Then
                Exit Sub
            End If



            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametros_Ensamble()

            Sub_Botones(True, False, False, False, True, True, False)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdParametrosEnsambles.CloseEditor()

            If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "CodigoArticulo")
            Dim pSegundosXArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "SegundosXArticulo")
            Dim pMinutosXArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "MinutosXArticulo")
            Dim pEnsamblesXHora As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "EnsamblesXHora")
            Dim pEquipoPersonas As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "EquipoPersonas")

            If Not mMensajes.msg_Actualizar() Then
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_ParametrosEnsamble(pCodigoArticulo, pSegundosXArticulo, pMinutosXArticulo, pEnsamblesXHora, pEquipoPersonas) Then
                msg_Proceso_ok()
            Else
                msg_Proceso_Error()
            End If

            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametros_Ensamble() 'Llenar Grid

            'ValidarBotones
            Sub_Botones(True, False, False, False, True, True, False)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Function sub_Validacion_VerticalGrid() As Boolean
        Try
            If FCN_GetCellValue(vgrdParametrosEnsambles, "SegundosXArticulo") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (SegundosXArticulo) del Articulo. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosEnsambles, "MinutosXArticulo") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (MinutosXArticulo) del Articulo. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosEnsambles, "EnsamblesXHora") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (EnsamblesXHora) del Articulo ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosEnsambles, "EquipoPersonas") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (EquipoPersonas) del Articulo ")
                Return False
            End If
            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function


    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            Try
                vpCodigoArticulo = String.Empty
                Dim dtArticulos As New DataTable()
                dtArticulos = GET_Listado_ParametrosEnsamble_Nuevos()
                vpTabla1 = dtArticulos
                frmTemporal_CodigosArticulos_Nuevos.ShowDialog()
                If Not vpBoolean Then
                    Exit Sub
                End If

                Dim dt As New DataTable
                Dim columnsMaster As DataColumn
                columnsMaster = New DataColumn("NombreArticulo", Type.GetType("System.String"))
                dt.Columns.Add(columnsMaster)
                Dim row As DataRow = dt.NewRow()
                row("NombreArticulo") = " "
                dt.Rows.Add(row)

                'Vaciar Vertical Grid de Maquinas
                DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Clear() 'Vaciar Controles
                DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Merge(dt)

                'Vaciar GridView de Maquinas
                DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsamble.TableName.ToString).Clear() 'Vaciar Controles

                vgrdParametrosEnsambles.SetCellValue(rowCodigoArticulo, 0, vpCodigoArticulo.ToString)
                vgrdParametrosEnsambles.SetCellValue(rowNombreArticulo, 0, vpNombreArticulo.ToString)

                Sub_Botones(False, False, True, True, False, False, True)

            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try



            Sub_Botones(False, True, True, False, False, False, True)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewParametrosEnsamble.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewParametrosEnsamble)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            vgrdParametrosEnsambles.CloseEditor()
            If Not sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "CodigoArticulo")
            Dim pSegundosXArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "SegundosXArticulo")
            Dim pMinutosXArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "MinutosXArticulo")
            Dim pEnsamblesXHora As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "EnsamblesXHora")
            Dim pEquipoPersonas As String = mFunciones.FCN_GetCellValue(vgrdParametrosEnsambles, "EquipoPersonas")

            'Dim dt As New DataTable("dtMoldes")
            'dt = mSQLSelect.GET_Listado_CodigosProducidos(pId) 'Obtener Datos si existen

            ''Validar que no exista la maquina que se desea guardar
            'If Not dt.Rows.Count = Nothing Then
            '    mMensajes.msg_Proceso_Error("El Id del Codigo Producido ( " + pId.ToString + " )  ya existe en la Base de Datos")
            '    Exit Sub
            'End If

            If Not mMensajes.msg_Grabar() Then
                Exit Sub
            End If

            If mSQLInsert.SET_EnsamblesArticulos(pCodigoArticulo, pSegundosXArticulo, pMinutosXArticulo, pEnsamblesXHora, pEquipoPersonas) Then
                mMensajes.msg_Proceso_ok()
            Else
                mMensajes.msg_Proceso_Error()
            End If


            DsParametros_Ensambles1.Tables(DsParametros_Ensambles1.dsdtParametrosEnsambleSeleccionada.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametros_Ensamble()

            Sub_Botones(True, False, False, False, True, True, False)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

 

    Private Sub vgrdParametrosEnsambles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdParametrosEnsambles.CellValueChanged
        'Try
        '    Dim pStatus As Boolean = True
        '    Dim pSegundos As Integer = 0
        '    Dim pMinutos As Decimal = 0.0
        '    Dim pArticulosHora As Integer = 0
        '    Dim EquipoPersona As Integer = 0



        '    If e.Row.Properties.FieldName = "SegundosXArticulo" Then
        '        pSegundos = vgrdParametrosEnsambles.GetCellValue(rowSegundosXArticulo, 0)
        '        pMinutos = Convert.ToDecimal(Val(pSegundos) / 60)
        '        vgrdParametrosEnsambles.SetCellValue(rowMinutosXArticulo, 0, pMinutos)

        '        pStatus = False

        '    ElseIf e.Row.Properties.FieldName = "MinutosXArticulo" Then
        '        If pStatus = False Then
        '            Exit Sub
        '        End If
        '        mMensajes.msg_Error("Minutos")
        '    ElseIf e.Row.Properties.FieldName = "EnsamblesXHora" Then
        '        mMensajes.msg_Error("Hora")
        '    End If
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try

    End Sub

    
    Private Sub vgrdParametrosEnsambles_FocusedRowChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles vgrdParametrosEnsambles.FocusedRowChanged
        Try
            Dim pStatus As Boolean = True
            Dim pSegundos As String = String.Empty
            Dim pMinutos As String = String.Empty
            Dim pEnsamblesHora As String = String.Empty
            Dim pEquipoPersona As String = String.Empty

            If Not IsDBNull(vgrdParametrosEnsambles.GetCellValue(rowSegundosXArticulo, 0)) Then
                pSegundos = vgrdParametrosEnsambles.GetCellValue(rowSegundosXArticulo, 0)
            End If
            If Not IsDBNull(vgrdParametrosEnsambles.GetCellValue(rowMinutosXArticulo, 0)) Then
                pMinutos = vgrdParametrosEnsambles.GetCellValue(rowMinutosXArticulo, 0)
            End If
            If Not IsDBNull(vgrdParametrosEnsambles.GetCellValue(rowEnsamblesXHora, 0)) Then
                pEnsamblesHora = vgrdParametrosEnsambles.GetCellValue(rowEnsamblesXHora, 0)
            End If

            If Not IsDBNull(vgrdParametrosEnsambles.GetCellValue(rowEquipoPersonas, 0)) Then
                pEquipoPersona = vgrdParametrosEnsambles.GetCellValue(rowEquipoPersonas, 0)
            End If

            If vgrdParametrosEnsambles.RecordCount > 0 Then

                If e.OldRow.Properties.FieldName = "SegundosXArticulo" And Not pSegundos = Nothing Then
                    If pSegundos = 0 Or pSegundos = Nothing Then
                        Exit Sub
                    End If
                    'Segundos X Articulo
                    pMinutos = Format(Convert.ToDouble(Convert.ToDecimal(Val(pSegundos) / 60)), "0.00")
                    vgrdParametrosEnsambles.SetCellValue(rowMinutosXArticulo, 0, pMinutos)

                    'Ensambles X Hora
                    pEnsamblesHora = Math.Ceiling((3600 / Val(pSegundos)) * Val(pEquipoPersona))
                    vgrdParametrosEnsambles.SetCellValue(rowEnsamblesXHora, 0, pEnsamblesHora)

                ElseIf e.OldRow.Properties.FieldName = "MinutosXArticulo" And Not pMinutos = Nothing Then
                    If pMinutos = 0 Or pMinutos = Nothing Then
                        Exit Sub
                    End If

                    pSegundos = Math.Ceiling(Convert.ToDecimal(Val(pMinutos) * 60))
                    vgrdParametrosEnsambles.SetCellValue(rowSegundosXArticulo, 0, pSegundos)

                    'Ensambles X Hora
                    pEnsamblesHora = Math.Ceiling((3600 / Val(pSegundos)) * Val(pEquipoPersona))
                    vgrdParametrosEnsambles.SetCellValue(rowEnsamblesXHora, 0, pEnsamblesHora)

                ElseIf e.OldRow.Properties.FieldName = "EnsamblesXHora" And Not pEnsamblesHora = Nothing Then
                    If pEnsamblesHora = 0 Or pEnsamblesHora = Nothing Or pEquipoPersona = Nothing Then
                        Exit Sub
                    End If
                    pMinutos = Format(60 / ((Val(pEnsamblesHora) / Val(pEquipoPersona))), "0.00")
                    vgrdParametrosEnsambles.SetCellValue(rowMinutosXArticulo, 0, pMinutos)

                    pSegundos = Math.Ceiling(Convert.ToDecimal(Val(pMinutos) * 60))
                    vgrdParametrosEnsambles.SetCellValue(rowSegundosXArticulo, 0, pSegundos)

                ElseIf e.OldRow.Properties.FieldName = "EquipoPersonas" And Not pEquipoPersona = Nothing Then
                    If pEquipoPersona = 0 Or pEquipoPersona = Nothing Or pSegundos = Nothing Then
                        Exit Sub
                    End If

                    If Not pSegundos = 0 Or Not pSegundos = Nothing Then
                        'Segundos X Articulo
                        pMinutos = Format(Convert.ToDouble(Convert.ToDecimal(Val(pSegundos) / 60)), "0.00")
                        vgrdParametrosEnsambles.SetCellValue(rowMinutosXArticulo, 0, pMinutos)

                        'Ensambles X Hora
                        pEnsamblesHora = Math.Ceiling((3600 / Val(pSegundos)) * Val(pEquipoPersona))
                        vgrdParametrosEnsambles.SetCellValue(rowEnsamblesXHora, 0, pEnsamblesHora)
                    End If
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class