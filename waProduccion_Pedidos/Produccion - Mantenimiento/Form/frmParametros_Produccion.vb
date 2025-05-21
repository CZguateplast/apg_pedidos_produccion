Public Class frmParametros_Produccion

    Private Sub frmParametros_Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Botones(True, False, False, False, True, True, False)
            Sub_Fill_grdviewParametrosProduccion()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Function Sub_Validacion_VerticalGrid() As Boolean
        Try
            If FCN_GetCellValue(vgrdParametrosProduccion, "CodigoArticulo") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Codigo de Articulo) del Articulo. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosProduccion, "CicloHora") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Ciclos por Hora) del Articulo. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionGrms") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Peso Inyeccion Gramos) del Articulo. ")
                Return False
            ElseIf FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionVariacionGrms") = String.Empty Then
                mMensajes.msg_InformacionIncompleta(" (Variacion de Inyeccion en Gramos) del Articulo. ")
                Return False
            End If


            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    'FUNCIONES
    Private Sub Sub_Fill_grdviewParametrosProduccion()
        Try
            Dim dt As New DataTable()

            dt = GET_MoldesProduccionParametros()
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccion.TableName.ToString).Clear()
            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccion.TableName.ToString).Merge(dt)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub
    Private Sub Sub_Botones(ByVal pAgregar As Boolean, ByVal pGrabar As Boolean, ByVal pCancelar As Boolean,
                       ByVal pActualizar As Boolean, ByVal pBuscar As Boolean, ByVal pImprimir As Boolean,
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

    'GRID
    Private Sub grdviewParametrosProduccion_DoubleClick(sender As Object, e As EventArgs) Handles grdviewParametrosProduccion.DoubleClick
        Try
            Dim dt As New DataTable()
            Dim pCodigo As String = String.Empty
            pCodigo = mFunciones.FCN_GetCellValue(grdviewParametrosProduccion, "CodigoArticulo")

            If Not pCodigo = String.Empty Then
                'dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProduccionParametros " + pCodigo)
                dt = GET_MoldesProduccionParametros(pCodigo)
                If dt.Rows.Count = Nothing Then
                    DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear()
                    Exit Sub
                End If

                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear()
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Merge(dt)
            Else
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear()
            End If

            Sub_Botones(False, False, True, True, False, False, True)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub vgrdParametrosProduccion_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdParametrosProduccion.CellValueChanged
        Try
            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CodigoArticulo")
            Dim pCicloHora As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CicloHora") 'Habilitar Este
            Dim pPesoInyeccionGrms As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionGrms") 'Habilitar Este
            Dim pPesoInyeccionVariacionGrms As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionVariacionGrms") 'Habilitar Este

            If e.Row.Properties.FieldName = "CicloHora" Then
                Dim dtParametros As New DataTable()
                dtParametros = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo, pCicloHora, pPesoInyeccionGrms)
                If dtParametros.Rows.Count = Nothing Then
                    Exit Sub
                End If
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear()
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Merge(dtParametros)
            End If

            If e.Row.Properties.FieldName = "PesoInyeccionGrms" Then
                Dim dtParametros As New DataTable()
                dtParametros = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo, pCicloHora, pPesoInyeccionGrms)
                If dtParametros.Rows.Count = Nothing Then
                    Exit Sub
                End If
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear()
                DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Merge(dtParametros)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    'BOTONES
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            vpCodigoArticulo = String.Empty
            Dim dtArticulos As New DataTable()
            dtArticulos = GET_Listado_ParametrosProduccion_Nuevos()
            vpTabla1 = dtArticulos
            frmTemporal_CodigosArticulos_Nuevos.ShowDialog()
            If Not vpBoolean Then
                Exit Sub
            End If

            Dim dt As New DataTable
            Dim columnsMaster As DataColumn
            columnsMaster = New DataColumn("CodigoArticulo", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            columnsMaster = New DataColumn("NombreArticulo", Type.GetType("System.String"))
            dt.Columns.Add(columnsMaster)
            Dim row As DataRow = dt.NewRow()
            row("CodigoArticulo") = vpCodigoArticulo.ToString
            row("NombreArticulo") = vpNombreArticulo.ToString
            dt.Rows.Add(row)

            'Vaciar Vertical Grid de Maquinas
            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear() 'Vaciar Controles
            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Merge(dt)

            'Vaciar GridView de Maquinas
            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccion.TableName.ToString).Clear() 'Vaciar Controles


            'Sub_Botones(False, True, True, False, False, False, False)
            Sub_Botones(False, True, True, True, False, False, False)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            vgrdParametrosProduccion.CloseEditor()
            If Not Sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CodigoArticulo")
            Dim pInyeccionHora As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CicloHora")
            Dim pInyeccionGrms As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionGrms")
            Dim pInyeccionVariacion As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionVariacionGrms")

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

            If mSQLInsert.SET_ProduccionParametros(pCodigoArticulo, pInyeccionGrms, pInyeccionVariacion, pInyeccionHora) Then
                mMensajes.msg_Proceso_ok()
            Else
                mMensajes.msg_Proceso_Error()
            End If


            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametrosProduccion()

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
            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametrosProduccion()

            Sub_Botones(True, False, False, False, True, True, False)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            vgrdParametrosProduccion.CloseEditor()
            If Not Sub_Validacion_VerticalGrid() Then : Exit Sub : End If

            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CodigoArticulo")
            Dim pInyeccionHora As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "CicloHora")
            Dim pInyeccionGrms As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionGrms")
            Dim pInyeccionVariacion As String = mFunciones.FCN_GetCellValue(vgrdParametrosProduccion, "PesoInyeccionVariacionGrms")

            'Dim dt As New DataTable("dtMoldes")
            'dt = mSQLSelect.GET_Listado_CodigosProducidos(pId) 'Obtener Datos si existen

            ''Validar que no exista la maquina que se desea guardar
            'If Not dt.Rows.Count = Nothing Then
            '    mMensajes.msg_Proceso_Error("El Id del Codigo Producido ( " + pId.ToString + " )  ya existe en la Base de Datos")
            '    Exit Sub
            'End If

            If Not mMensajes.msg_Actualizar() Then
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_ProduccionParametros(pCodigoArticulo, pInyeccionGrms, pInyeccionVariacion, pInyeccionHora) Then
                mMensajes.msg_Proceso_ok()
            Else
                mMensajes.msg_Proceso_Error()
            End If


            DsParametros_Produccion1.Tables(DsParametros_Produccion1.dsdtParametrosProduccionSeleccion.TableName.ToString).Clear() 'Vaciar Controles
            Sub_Fill_grdviewParametrosProduccion()

            'ValidarBotones
            Sub_Botones(True, False, False, False, True, True, False)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewParametrosProduccion.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewParametrosProduccion)
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

    Private Sub vgrdParametrosProduccion_Click(sender As Object, e As EventArgs) Handles vgrdParametrosProduccion.Click

    End Sub
End Class