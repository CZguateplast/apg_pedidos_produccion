Public Class frmOrdenProduccionEnsamble

    Private mCodigoArticulo As String
    Private pNumSAP As String
    Private pBodega As String
    Private mTipo As String
    Private pfcnBodegaCambiar As Boolean
    Private pfcnTipoOrden As Boolean

    Public Property ppTipo As String
        Get
            Return mTipo
        End Get
        Set(ByVal Value As String)
            mTipo = Value
        End Set
    End Property
    Public Property ppBodega As String
        Get
            Return pBodega
        End Get
        Set(ByVal Value As String)
            pBodega = Value
        End Set
    End Property
    Public Property ppNumSAP() As String
        Get
            Return pNumSAP
        End Get
        Set(ByVal Value As String)
            pNumSAP = Value
        End Set
    End Property
    Public Property ppCodigoArticulo() As String
        Get
            Return mCodigoArticulo
        End Get
        Set(ByVal Value As String)
            mCodigoArticulo = Value
        End Set
    End Property

    Private Sub Seguridad_APG()
        Try
            
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Permisos()
        Try
            Select Case mTipo
                Case "Vacio"


                    'CONTROLES
                    txtTipo.Enabled = False
                    txtEstado.Enabled = False
                    slueCodigoArticulo.Enabled = False
                    txtNombreArticulo.Enabled = False
                    spinCantidadPlanificada.Enabled = False
                    txtUnidadMedida.Enabled = False
                    slueAlmacen.Enabled = False
                    txtSerie.Enabled = False
                    txtNumSAP.Enabled = False
                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    txtUsuario.Enabled = False
                    txtPrioridad.Enabled = False
                    slueTipoOrden.Enabled = False
                    txtComentarios.Enabled = False

                    'GRID
                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = True
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = True
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = True
                    colAlmacen.OptionsColumn.ReadOnly = True

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = False
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = False
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = False
                    colAlmacen.OptionsColumn.AllowEdit = False


                    'BOTONES

                    barbtnCopiarNueva.Enabled = False
                    barbtnEspecial.Enabled = False
                    barbtnCopiarDesmonte.Enabled = False


                    barbtnEliminarLinea.Enabled = False
                    barbtnCambiarComponente.Enabled = False
                    barbtnStock.Enabled = False

                    barbtnNuevaOrden.Enabled = True
                    barbtnBuscarDocumento.Enabled = True

                    barbtnLiberarOrden.Enabled = False
                    barbtnCerrarOrden.Enabled = False

                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = False

                Case "Nuevo"
                    'CONTROLES
                    txtTipo.Enabled = False
                    txtEstado.Enabled = False
                    slueCodigoArticulo.Enabled = False
                    txtNombreArticulo.Enabled = False
                    spinCantidadPlanificada.Enabled = True
                    txtUnidadMedida.Enabled = False
                    mSeguridad.APG_Seguridad(Me, slueAlmacen)
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)
                    txtSerie.Enabled = False
                    txtNumSAP.Enabled = False
                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    txtUsuario.Enabled = False
                    txtPrioridad.Enabled = True
                    slueTipoOrden.Enabled = True
                    txtComentarios.Enabled = True

                    'GRID

                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = False
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = False
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = False
                    colAlmacen.OptionsColumn.ReadOnly = False

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = True
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = True
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = True
                    colAlmacen.OptionsColumn.AllowEdit = True


                    'BOTONES
                    barbtnCopiarNueva.Enabled = False
                    barbtnEspecial.Enabled = True
                    barbtnCopiarDesmonte.Enabled = True


                    barbtnEliminarLinea.Enabled = True
                    barbtnCambiarComponente.Enabled = True
                    barbtnStock.Enabled = True

                    barbtnNuevaOrden.Enabled = True
                    barbtnBuscarDocumento.Enabled = True
                    barbtnLiberarOrden.Enabled = False
                    barbtnCerrarOrden.Enabled = False

                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = True

                Case "Buscar"
                    'CONTROLES
                    txtTipo.Enabled = False
                    txtEstado.Enabled = False
                    slueCodigoArticulo.Enabled = False
                    txtNombreArticulo.Enabled = False
                    spinCantidadPlanificada.Enabled = False
                    txtUnidadMedida.Enabled = False
                    mSeguridad.APG_Seguridad(Me, slueAlmacen)
                    txtSerie.Enabled = False
                    txtNumSAP.Enabled = False
                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    txtUsuario.Enabled = False
                    txtPrioridad.Enabled = True
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)
                    txtComentarios.Enabled = True

                    'GRID
                    ''''' EDICION DE GRID VIEW INICIO
                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = True
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = True
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = True
                    colAlmacen.OptionsColumn.ReadOnly = False

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = False
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = False
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = False
                    colAlmacen.OptionsColumn.AllowEdit = True
                    ''''' EDICION DE GRID VIEW FINAL

                    'BOTONES
                    barbtnCopiarNueva.Enabled = True
                    barbtnEspecial.Enabled = True
                    barbtnCopiarDesmonte.Enabled = True


                    barbtnEliminarLinea.Enabled = False
                    barbtnCambiarComponente.Enabled = False
                    barbtnStock.Enabled = True

                    barbtnNuevaOrden.Enabled = True
                    barbtnBuscarDocumento.Enabled = True
                    'barbtnDesmontar.Enabled = True

                    If txtEstado.EditValue = "Planificado" Then : barbtnLiberarOrden.Enabled = True : Else : barbtnLiberarOrden.Enabled = False : End If
                    If txtEstado.EditValue = "Cerrado" Then : barbtnCerrarOrden.Enabled = False : Else : barbtnCerrarOrden.Enabled = True : End If

                    'barbtnLiberarOrden.Enabled = True
                    'barbtnCerrarOrden.Enabled = True


                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = False

                    mSeguridad.APG_Seguridad(Me, slueAlmacen)
                    mSeguridad.APG_Seguridad(Me, rslueAlmacen)



                Case "Copiar" 'COPIAR ESTANDAR

                    txtNumSAP.EditValue = String.Empty
                    txtTipo.EditValue = "Estándar"
                    txtEstado.EditValue = "Planificado"
                    txtPrioridad.EditValue = "6"

                    spinCantidadPlanificada.Enabled = True
                    mSeguridad.APG_Seguridad(Me, slueAlmacen)

                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)
                    txtPrioridad.Enabled = True
                    txtComentarios.Enabled = True
                    rslueAlmacen.ReadOnly = False
                    barbtnCambiarComponente.Enabled = True

                    dteFechaFabricacion.EditValue = DateTime.Now()
                    dteFechaFinalizacion.EditValue = DateTime.Now()


                    ''''' EDICION DE GRID VIEW INICIO
                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = False
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = False
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = False
                    colAlmacen.OptionsColumn.ReadOnly = False

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = True
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = True
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = True
                    colAlmacen.OptionsColumn.AllowEdit = True
                    ''''' EDICION DE GRID VIEW FINAL

                    '''''BOTONES'''''''''
                    barbtnCopiarNueva.Enabled = False
                    barbtnEspecial.Enabled = True
                    barbtnCopiarDesmonte.Enabled = True


                    barbtnEliminarLinea.Enabled = True
                    barbtnCambiarComponente.Enabled = False
                    barbtnStock.Enabled = True

                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = True

                Case "Especial"

                    barbtnEliminarLinea.Enabled = True
                    txtNumSAP.EditValue = String.Empty
                    txtTipo.EditValue = "Especial"
                    txtEstado.EditValue = "Planificado"
                    txtPrioridad.EditValue = "6"

                    spinCantidadPlanificada.Enabled = True
                    mSeguridad.APG_Seguridad(Me, slueAlmacen)

                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)
                    txtPrioridad.Enabled = True
                    txtComentarios.Enabled = True
                    rslueAlmacen.ReadOnly = False
                    barbtnCambiarComponente.Enabled = True

                    dteFechaFabricacion.EditValue = DateTime.Now()
                    dteFechaFinalizacion.EditValue = DateTime.Now()


                    ''''' EDICION DE GRID VIEW INICIO
                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = False
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = False
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = False
                    colAlmacen.OptionsColumn.ReadOnly = False

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = True
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = True
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = True
                    colAlmacen.OptionsColumn.AllowEdit = True
                    ''''' EDICION DE GRID VIEW FINAL

                    '''''BOTONES'''''''''
                    barbtnCopiarNueva.Enabled = True
                    barbtnEspecial.Enabled = False
                    barbtnCopiarDesmonte.Enabled = True


                    barbtnEliminarLinea.Enabled = True
                    barbtnCambiarComponente.Enabled = False
                    barbtnStock.Enabled = True

                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = True


                Case "Desmontar"

                    barbtnEliminarLinea.Enabled = True
                    txtNumSAP.EditValue = String.Empty
                    txtTipo.EditValue = "Desmontar"
                    txtEstado.EditValue = "Planificado"
                    txtPrioridad.EditValue = "6"

                    spinCantidadPlanificada.Enabled = True
                    mSeguridad.APG_Seguridad(Me, slueAlmacen)

                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)
                    txtPrioridad.Enabled = True
                    txtComentarios.Enabled = True
                    rslueAlmacen.ReadOnly = False
                    barbtnCambiarComponente.Enabled = True

                    dteFechaFabricacion.EditValue = DateTime.Now()
                    dteFechaFinalizacion.EditValue = DateTime.Now()


                    ''''' EDICION DE GRID VIEW INICIO
                    grdviewordenProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top

                    colNumLinea.OptionsColumn.ReadOnly = True
                    colCodigoArticulo.OptionsColumn.ReadOnly = False
                    colNombreArticulo.OptionsColumn.ReadOnly = True
                    colCantidadBase.OptionsColumn.ReadOnly = False
                    colStock.OptionsColumn.ReadOnly = True
                    colSolicitado.OptionsColumn.ReadOnly = False
                    colAlmacen.OptionsColumn.ReadOnly = False

                    colNumLinea.OptionsColumn.AllowEdit = False
                    colCodigoArticulo.OptionsColumn.AllowEdit = True
                    colNombreArticulo.OptionsColumn.AllowEdit = False
                    colCantidadBase.OptionsColumn.AllowEdit = True
                    colStock.OptionsColumn.AllowEdit = False
                    colSolicitado.OptionsColumn.AllowEdit = True
                    colAlmacen.OptionsColumn.AllowEdit = True
                    ''''' EDICION DE GRID VIEW FINAL

                    '''''BOTONES'''''''''
                    barbtnCopiarNueva.Enabled = True
                    barbtnEspecial.Enabled = True
                    barbtnCopiarDesmonte.Enabled = False


                    barbtnEliminarLinea.Enabled = True
                    barbtnCambiarComponente.Enabled = False
                    barbtnStock.Enabled = True

                    barbtnActualizar.Enabled = False
                    barbtnSAP.Enabled = True

                Case "Prueba" 'consulta
                    barbtnEliminarLinea.Enabled = False
                    spinCantidadPlanificada.Enabled = False
                    dteFechaFabricacion.Enabled = False
                    dteFechaFinalizacion.Enabled = False
                    txtPrioridad.Enabled = False
                    barbtnCambiarComponente.Enabled = False

                    mSeguridad.APG_Seguridad(Me, slueAlmacen)
                    mSeguridad.APG_Seguridad(Me, rslueAlmacen)
                    mSeguridad.APG_Seguridad(Me, slueTipoOrden)

            End Select

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Controles()
        'VERIFICA QUE TIPO DE LLAMADO ES EL QUE TIENE

        pfcnBodegaCambiar = False
        pfcnTipoOrden = False

        Dim dtEncabezado As New DataTable()
        Dim dtDetalle As New DataTable

        Select Case mTipo
            Case "Vacio"

                txtTipo.EditValue = Nothing
                txtEstado.EditValue = Nothing
                slueCodigoArticulo.EditValue = Nothing
                txtNombreArticulo.EditValue = Nothing
                spinCantidadPlanificada.EditValue = Nothing
                txtUnidadMedida.EditValue = Nothing
                slueAlmacen.EditValue = Nothing


                txtSerie.EditValue = Nothing
                txtNumSAP.EditValue = Nothing
                dteFechaFabricacion.EditValue = Nothing
                dteFechaFinalizacion.EditValue = Nothing
                txtUsuario.EditValue = Nothing
                txtPrioridad.EditValue = Nothing
                slueTipoOrden.EditValue = Nothing
                txtComentarios.EditValue = Nothing

                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()

            Case "Nuevo"

                dtEncabezado = mSQLSelect.GET_ProduccionOrden_Encabezado_XCodigo(mCodigoArticulo)
                dtDetalle = mSQLSelect.GET_ProduccionOrden_Detalle_XCodigo(mCodigoArticulo)

                txtNumSAP.EditValue = String.Empty
                txtTipo.EditValue = "Estándar"
                txtEstado.EditValue = dtEncabezado.Rows(0)("Estado").ToString
                slueCodigoArticulo.EditValue = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dtEncabezado.Rows(0)("NombreArticulo").ToString
                spinCantidadPlanificada.EditValue = dtEncabezado.Rows(0)("Planeado").ToString
                txtUnidadMedida.EditValue = dtEncabezado.Rows(0)("UnidadMedida").ToString
                slueAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen").ToString
                txtSerie.EditValue = dtEncabezado.Rows(0)("Serie").ToString
                dteFechaFabricacion.EditValue = dtEncabezado.Rows(0)("FechaFabricacion")
                dteFechaFinalizacion.EditValue = dtEncabezado.Rows(0)("FechaFinalizacion")
                txtUsuario.EditValue = My.Settings.log_Usuario.ToString
                txtPrioridad.EditValue = dtEncabezado.Rows(0)("Prioridad").ToString
                slueTipoOrden.EditValue = dtEncabezado.Rows(0)("TipoOrden").ToString
                txtComentarios.EditValue = dtEncabezado.Rows(0)("Comentarios").ToString
                barbtnCambiarComponente.Enabled = True

                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()
                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Merge(dtDetalle)

            Case "Copiar"

                txtNumSAP.EditValue = String.Empty
                txtTipo.EditValue = "Estándar"
                'txtEstado.EditValue = dtEncabezado.Rows(0)("Estado").ToString
                'slueCodigoArticulo.EditValue = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                'txtNombreArticulo.EditValue = dtEncabezado.Rows(0)("NombreArticulo").ToString
                'spinCantidadPlanificada.EditValue = dtEncabezado.Rows(0)("Planeado").ToString
                'txtUnidadMedida.EditValue = dtEncabezado.Rows(0)("UnidadMedida").ToString
                'slueAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen").ToString
                'txtSerie.EditValue = dtEncabezado.Rows(0)("Serie").ToString
                'dteFechaFabricacion.EditValue = dtEncabezado.Rows(0)("FechaFabricacion")
                'dteFechaFinalizacion.EditValue = dtEncabezado.Rows(0)("FechaFinalizacion")
                'txtUsuario.EditValue = My.Settings.log_Usuario.ToString
                'txtPrioridad.EditValue = dtEncabezado.Rows(0)("Prioridad").ToString
                'slueTipoOrden.EditValue = dtEncabezado.Rows(0)("TipoOrden").ToString
                'txtComentarios.EditValue = dtEncabezado.Rows(0)("Comentarios").ToString
                barbtnCambiarComponente.Enabled = True

                'DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()
                'DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Merge(dtDetalle)


            Case "Buscar"
                dtEncabezado = mConexion.ConectarSQLGT_DT("EXEC APGPRODUCCION.dbo.[OWOR_XNumSAP] '" + pNumSAP.ToString + "'")
                dtDetalle = mConexion.ConectarSQLGT_DT("EXEC APGPRODUCCION.dbo.[WOR1_XNumSAP] '" + pNumSAP.ToString + "'")

                txtNumSAP.EditValue = dtEncabezado.Rows(0)("NumSAP").ToString
                txtTipo.EditValue = dtEncabezado.Rows(0)("Tipo").ToString
                txtEstado.EditValue = dtEncabezado.Rows(0)("Estado").ToString
                slueCodigoArticulo.EditValue = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dtEncabezado.Rows(0)("NombreArticulo").ToString
                spinCantidadPlanificada.EditValue = dtEncabezado.Rows(0)("Planeado").ToString
                txtUnidadMedida.EditValue = dtEncabezado.Rows(0)("UnidadMedida").ToString
                slueAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen").ToString
                txtSerie.EditValue = dtEncabezado.Rows(0)("Serie").ToString
                dteFechaFabricacion.EditValue = dtEncabezado.Rows(0)("FechaFabricacion")
                dteFechaFinalizacion.EditValue = dtEncabezado.Rows(0)("FechaFinalizacion")
                txtUsuario.EditValue = My.Settings.log_Usuario.ToString
                txtPrioridad.EditValue = dtEncabezado.Rows(0)("Prioridad").ToString
                slueTipoOrden.EditValue = dtEncabezado.Rows(0)("TipoOrden").ToString
                txtComentarios.EditValue = dtEncabezado.Rows(0)("Comentarios").ToString
                barbtnCambiarComponente.Enabled = True

                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()
                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Merge(dtDetalle)


            Case "Desmontar"
                dtEncabezado = mSQLSelect.GET_ProduccionOrden_Encabezado_XCodigo(mCodigoArticulo)
                dtDetalle = mSQLSelect.GET_ProduccionOrden_Detalle_XCodigo(mCodigoArticulo)

                txtNumSAP.EditValue = String.Empty
                txtTipo.EditValue = "Desmontar"
                txtEstado.EditValue = dtEncabezado.Rows(0)("Estado").ToString
                slueCodigoArticulo.EditValue = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dtEncabezado.Rows(0)("NombreArticulo").ToString
                spinCantidadPlanificada.EditValue = dtEncabezado.Rows(0)("Planeado").ToString
                txtUnidadMedida.EditValue = dtEncabezado.Rows(0)("UnidadMedida").ToString
                slueAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen").ToString
                txtSerie.EditValue = dtEncabezado.Rows(0)("Serie").ToString
                dteFechaFabricacion.EditValue = dtEncabezado.Rows(0)("FechaFabricacion")
                dteFechaFinalizacion.EditValue = dtEncabezado.Rows(0)("FechaFinalizacion")
                txtUsuario.EditValue = My.Settings.log_Usuario.ToString
                txtPrioridad.EditValue = dtEncabezado.Rows(0)("Prioridad").ToString
                slueTipoOrden.EditValue = dtEncabezado.Rows(0)("TipoOrden").ToString
                txtComentarios.EditValue = dtEncabezado.Rows(0)("Comentarios").ToString
                barbtnCambiarComponente.Enabled = True

                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()
                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Merge(dtDetalle)

                spinCantidadPlanificada.Enabled = True
                slueTipoOrden.Enabled = True
                dteFechaFabricacion.Enabled = True
                dteFechaFinalizacion.Enabled = True
                txtPrioridad.Enabled = True

                
            Case "Consulta"
                dtEncabezado = mSQLSelect.GET_ProduccionOrden_Encabezado(pNumSAP)
                dtDetalle = mSQLSelect.GET_ProduccionOrden_Detalle(pNumSAP)

                If dtEncabezado.Rows.Count = Nothing Or dtDetalle.Rows.Count = Nothing Then
                    Exit Sub
                End If

                txtNumSAP.EditValue = pNumSAP
                txtTipo.EditValue = dtEncabezado.Rows(0)("Tipo").ToString
                txtEstado.EditValue = dtEncabezado.Rows(0)("Estado").ToString
                slueCodigoArticulo.EditValue = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dtEncabezado.Rows(0)("NombreArticulo").ToString
                spinCantidadPlanificada.EditValue = dtEncabezado.Rows(0)("Planeado").ToString
                txtUnidadMedida.EditValue = dtEncabezado.Rows(0)("UnidadMedida").ToString
                slueAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen").ToString
                txtSerie.EditValue = dtEncabezado.Rows(0)("Serie").ToString
                dteFechaFabricacion.EditValue = dtEncabezado.Rows(0)("FechaFabricacion")
                dteFechaFinalizacion.EditValue = dtEncabezado.Rows(0)("FechaFinalizacion")
                txtUsuario.EditValue = dtEncabezado.Rows(0)("Usuario").ToString
                txtPrioridad.EditValue = dtEncabezado.Rows(0)("Prioridad").ToString
                slueTipoOrden.EditValue = dtEncabezado.Rows(0)("TipoOrden").ToString
                txtComentarios.EditValue = dtEncabezado.Rows(0)("Comentarios").ToString
                barbtnCambiarComponente.Enabled = False

                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Clear()
                DsOrdenesProduccion1.Tables(DsOrdenesProduccion1.dsdtOrdenProduccion.TableName.ToString).Merge(dtDetalle)

        End Select

        pfcnBodegaCambiar = True
        pfcnTipoOrden = True

    End Sub

    Private Sub frmOrdenProduccionEnsamble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pfcnBodegaCambiar = False
            pfcnTipoOrden = False
            pBodega = Nothing

            'Seguridad_APG()
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_Catalogo_OITM(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueTipoOrden, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueAlmacen, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueAlmacen, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigo, mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[sp_OITM] "), "CodigoArticulo", "CodigoArticulo")

            Sub_Permisos()
            Sub_Controles()
        
            pfcnBodegaCambiar = True
            pfcnTipoOrden = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



#Region "Botones"
    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnLiberarOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnLiberarOrden.ItemClick
        Try
            If mMensajes.msg_Ordenes_StatusLiberar() Then


                If txtEstado.EditValue.ToString = "Planeado" Then
                    If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                    ssmEsperar.SetWaitFormCaption("Espere...")
                    ssmEsperar.SetWaitFormDescription("Liberando " + txtNumSAP.EditValue.ToString)
                    If mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(txtNumSAP.EditValue.ToString) Then
                        txtEstado.EditValue = "Liberado"
                        If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                        MsgBox("La Orden " + txtNumSAP.EditValue.ToString + " Se ha liberado!")
                    End If
                ElseIf txtEstado.EditValue.ToString = "Liberado" Then
                    MsgBox("La Orden ya esta liberada!")
                Else
                    MsgBox("La Orden no se puede Liberar. Intente de Nuevo!")
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub
    Private Sub barbtnCerrarOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrarOrden.ItemClick
        Try
            If mMensajes.msg_Ordenes_StatusCerrar() Then


                If txtEstado.EditValue.ToString = "Planeado" Then
                    If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                    ssmEsperar.SetWaitFormCaption("Espere...")
                    ssmEsperar.SetWaitFormDescription("Liberando " + txtNumSAP.EditValue.ToString)
                    If mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(txtNumSAP.EditValue.ToString) Then
                        ssmEsperar.SetWaitFormDescription("Cerrando " + txtNumSAP.EditValue.ToString)
                        If mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(txtNumSAP.EditValue.ToString) Then
                            txtEstado.EditValue = "Cerrado"
                            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                            MsgBox("La Orden " + txtNumSAP.EditValue.ToString + " Se ha Cerrado!")
                        Else
                            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                            MsgBox("La Orden no se puede Cerrar. Intente de Nuevo!")
                        End If
                    Else
                        If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                        MsgBox("La Orden no se puede Cerrar. Intente de Nuevo!")
                    End If
                ElseIf txtEstado.EditValue.ToString = "Liberado" Then
                    If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                    ssmEsperar.SetWaitFormCaption("Espere")
                    ssmEsperar.SetWaitFormDescription("Cerrando " + txtNumSAP.EditValue.ToString)
                    If mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(txtNumSAP.EditValue.ToString) Then
                        txtEstado.EditValue = "Cerrado"
                        If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                        MsgBox("La Orden " + txtNumSAP.EditValue.ToString + " Se ha Cerrado!")
                    Else
                        If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                        MsgBox("La Orden no se puede Cerrar. Intente de Nuevo!")
                    End If
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try

    End Sub
    Private Sub barbtnBuscarDocumento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscarDocumento.ItemClick
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Lista_OWOR] ")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            frmTemporal_Lista.ppTabla = dt
            frmTemporal_Lista.ppResultado = String.Empty
            frmTemporal_Lista.ShowDialog(Me)

            Dim pCodigo As String = String.Empty
            pCodigo = frmTemporal_Lista.ppResultado
            If pCodigo = Nothing Then
                ppTipo = "Vacio"
                Exit Sub
            End If
            pNumSAP = pCodigo
            ppTipo = "Buscar"


            Sub_Controles()
            Sub_Permisos()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try

            Select Case txtTipo.EditValue
                Case "Desmontar"
                    If spinCantidadPlanificada.EditValue < 1 Then
                        mMensajes.msg_Informacion("Debe ingresar una cantidad mayor a 0 para Desmontar! " + Environment.NewLine + "Intente de Nuevo")
                        Exit Sub
                    End If

                    DsOrdenesProduccion1.dsdtOrdenProduccion.AcceptChanges()
                    mDIAPI.SAP_DIAPI_OrdenesProduccion("2", slueCodigoArticulo.EditValue.ToString, mFunciones.ConvertirFechaSQL(dteFechaFabricacion), mFunciones.ConvertirFechaSQL(dteFechaFinalizacion), _
                                                       spinCantidadPlanificada.EditValue.ToString, slueAlmacen.EditValue.ToString, slueTipoOrden.EditValue.ToString, txtComentarios.EditValue.ToString, _
                                                       DsOrdenesProduccion1.dsdtOrdenProduccion, ssmEsperar)

                Case "Estándar"
                    If spinCantidadPlanificada.EditValue < 1 Then
                        mMensajes.msg_Informacion("Debe ingresar una cantidad mayor a 0 para Desmontar! " + Environment.NewLine + "Intente de Nuevo")
                        Exit Sub
                    End If

                    DsOrdenesProduccion1.dsdtOrdenProduccion.AcceptChanges()
                    mDIAPI.SAP_DIAPI_OrdenesProduccion("0", slueCodigoArticulo.EditValue.ToString, mFunciones.ConvertirFechaSQL(dteFechaFabricacion), mFunciones.ConvertirFechaSQL(dteFechaFinalizacion), _
                                                       spinCantidadPlanificada.EditValue.ToString, slueAlmacen.EditValue.ToString, slueTipoOrden.EditValue.ToString, txtComentarios.EditValue.ToString, _
                                                       DsOrdenesProduccion1.dsdtOrdenProduccion, ssmEsperar)

                Case "Especial"
                    If spinCantidadPlanificada.EditValue < 1 Then
                        mMensajes.msg_Informacion("Debe ingresar una cantidad mayor a 0 para Desmontar! " + Environment.NewLine + "Intente de Nuevo")
                        Exit Sub
                    End If

                    DsOrdenesProduccion1.dsdtOrdenProduccion.AcceptChanges()
                    mDIAPI.SAP_DIAPI_OrdenesProduccion("1", slueCodigoArticulo.EditValue.ToString, mFunciones.ConvertirFechaSQL(dteFechaFabricacion), mFunciones.ConvertirFechaSQL(dteFechaFinalizacion), _
                                                       spinCantidadPlanificada.EditValue.ToString, slueAlmacen.EditValue.ToString, slueTipoOrden.EditValue.ToString, txtComentarios.EditValue.ToString, _
                                                       DsOrdenesProduccion1.dsdtOrdenProduccion, ssmEsperar)



            End Select


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnEliminarLinea_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminarLinea.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewordenProduccionEnsamble)


            For i = 0 To grdviewordenProduccionEnsamble.RowCount - 1
                grdviewordenProduccionEnsamble.SetRowCellValue(i, "NumLinea", i)
            Next

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnCambiarComponente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCambiarComponente.ItemClick
        Try
            If grdviewordenProduccionEnsamble.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pCodigo As String = String.Empty
            pCodigo = grdviewordenProduccionEnsamble.GetRowCellValue(grdviewordenProduccionEnsamble.FocusedRowHandle, "CodigoArticulo")

            If pCodigo = String.Empty Then
                Exit Sub
            End If

            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Codigos_SubEnsambles] '" + pCodigo.ToString + "'")



            If dt.Rows.Count = Nothing Then
                mMensajes.msg_NoData()
                Exit Sub
            End If

            frmTemporal_Lista.ppResultado = String.Empty
            frmTemporal_Lista.ppTabla = dt
            frmTemporal_Lista.ShowDialog(Me)

            If frmTemporal_Lista.ppResultado = String.Empty Then
                Exit Sub
            End If

            pCodigo = frmTemporal_Lista.ppResultado

            grdviewordenProduccionEnsamble.SetRowCellValue(grdviewordenProduccionEnsamble.FocusedRowHandle, "CodigoArticulo", pCodigo)






        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    
    Private Sub barbtnNuevaOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnNuevaOrden.ItemClick
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[sp_OITM] ")
            'dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Lista_OWOR] ")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            frmTemporal_Lista.ppTabla = dt
            frmTemporal_Lista.ppResultado = String.Empty
            frmTemporal_Lista.ShowDialog(Me)

            Dim pCodigo As String = String.Empty
            pCodigo = frmTemporal_Lista.ppResultado
            If pCodigo = Nothing Then
                ppTipo = "Vacio"
                Exit Sub
            End If
            mCodigoArticulo = pCodigo
            ppTipo = "Nuevo"

            Sub_Controles()
            Sub_Permisos()




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region


#Region "Controles"
    Private Sub slueAlmacen_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueAlmacen.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                Exit Sub
            End If

            If pfcnBodegaCambiar = False Then
                Exit Sub
            End If

            If txtNumSAP.EditValue = Nothing Then
                Exit Sub
            End If

            Dim pSAP As String = String.Empty
            Dim pAlmacen As String = String.Empty

            pSAP = txtNumSAP.EditValue.ToString
            pAlmacen = e.NewValue.ToString



            If SAP_DIAPI_OrdenesProduccion_Actualizar_Almacen(pSAP, pAlmacen, ssmEsperar) Then
                pBodega = pAlmacen
            Else
                pBodega = Nothing
                mMensajes.msg_Error("No se ha podido actualizar el Destino. Intente de Nuevo...")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub rslueAlmacen_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles rslueAlmacen.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                Exit Sub
            End If

            If txtNumSAP.EditValue = Nothing Then
                Exit Sub
            End If


            Dim pSAP As String = txtNumSAP.EditValue.ToString
            Dim pAlmacen As String = e.NewValue.ToString
            Dim pLinea As Integer = mFunciones.FCN_GetCellValue(grdviewordenProduccionEnsamble, "NumLinea")

            If SAP_DIAPI_OrdenesProduccion_Actualizar_Almacen_Detalle(pSAP, pLinea, pAlmacen, ssmEsperar) Then
            Else
                mMensajes.msg_Error("No se ha podido actualizar el Destino. Intente de Nuevo...")
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub spinCantidadPlanificada_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles spinCantidadPlanificada.Validating
        Try
            If Not spinCantidadPlanificada.EditValue = Nothing Then
                For i = 0 To grdviewordenProduccionEnsamble.RowCount - 1
                    Dim pBase As Decimal = 0
                    pBase = grdviewordenProduccionEnsamble.GetRowCellValue(i, colCantidadBase)
                    If pBase < 0 Then
                        pBase = 1
                    End If
                    grdviewordenProduccionEnsamble.SetRowCellValue(i, colSolicitado, pBase * spinCantidadPlanificada.EditValue)
                Next
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region


    Private Sub grdviewordenProduccionEnsamble_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewordenProduccionEnsamble.CellValueChanged
        Try

        
            If e.Column.FieldName = "CodigoArticulo" Then
                Dim dt As New DataTable
                Dim Codigo As String = e.Value

                dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[sp_OITM_xItemCode] '" + Codigo + "'")
                If Not dt.Rows.Count = Nothing Then

                    grdviewordenProduccionEnsamble.SetRowCellValue(e.RowHandle, "NombreArticulo", dt.Rows(0)("NombreArticulo").ToString)
                    'If grdviewComponentesProducidos.GetRowCellValue(grdviewComponentesProducidos.FocusedRowHandle, "U/M").ToString = String.Empty Then
                    grdviewordenProduccionEnsamble.SetRowCellValue(e.RowHandle, "CantidadBase", 1)
                    grdviewordenProduccionEnsamble.SetRowCellValue(e.RowHandle, "Stock", dt.Rows(0)("Stock").ToString)


                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewordenProduccionEnsamble_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewordenProduccionEnsamble.InitNewRow
        Try
            grdviewordenProduccionEnsamble.SetRowCellValue(e.RowHandle, "NumLinea", Val(grdviewordenProduccionEnsamble.RowCount))
            grdviewordenProduccionEnsamble.SetRowCellValue(e.RowHandle, "Almacen", "PT")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCopiarDesmonte_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCopiarDesmonte.ItemClick
        Try
            ppTipo = "Desmontar"
            mTipo = "Desmontar"
            Sub_Permisos()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnCopiarNueva_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCopiarNueva.ItemClick
        ppTipo = "Copiar"
        mTipo = "Copiar"
        Sub_Controles()
        Sub_Permisos()
    End Sub

    
    Private Sub barbtnEspecial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEspecial.ItemClick
        Try
            ppTipo = "Especial"
            mTipo = "Especial"
            Sub_Permisos()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick

        Try
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewordenProduccionEnsamble, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_Stock.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
            frmTemporal_Stock.ShowDialog()
        
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try




    End Sub

    Private Sub slueTipoOrden_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueTipoOrden.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                Exit Sub
            End If

            If pfcnTipoOrden = False Then
                Exit Sub
            End If

            If txtNumSAP.EditValue = Nothing Then
                Exit Sub
            End If

            Dim pSAP As String = String.Empty
            Dim pTipoOrden As String = String.Empty

            pSAP = txtNumSAP.EditValue.ToString
            pTipoOrden = e.NewValue.ToString



            If SAP_DIAPI_OrdenesProduccion_Actualizar_TipoOrden(pSAP, pTipoOrden, ssmEsperar) Then
                pBodega = pTipoOrden
            Else
                pBodega = Nothing
                mMensajes.msg_Error("No se ha podido actualizar el Destino. Intente de Nuevo...")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class