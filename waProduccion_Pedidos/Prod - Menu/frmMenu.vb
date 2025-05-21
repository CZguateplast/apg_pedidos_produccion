Imports System.Net.Mail
Imports System.IO.Ports
Imports System.Threading
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSplashScreen

Public Class frmMenu

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos")
        DesconectarDIAPI_Goblal()
    End Sub


    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            rbcMenuPrincipal.Minimized = True 'Minimizar el menu desde un principio
            AccesoSeguridad()
            Sub_Seguridad_APG()
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos")

            'Conectar a SAP al iniciar
            'ConectarDIAPICR()
            'ConectarDIAPI_MX()
            'ConectarDIAPISV()
            'ConectarDIAPIGT()

            tmrTiempoyHora.Start()
            barstaticProyecto.Caption = "Solución: " + My.Application.Info.ProductName.ToString
            barstaticVersion.Caption = "Versión: " + My.Application.Info.Version.ToString
            barStaticUsuario.Caption = My.Settings.log_Usuario.ToString
            barStaticNombre.Caption = My.Settings.log_Nombre.ToString
            If My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GT" Then
                barstaticDB2.Caption = "Tipo DB: Producción"
                My.Settings.log_DB = "SBOGuateplast"
            Else
                barstaticDB2.Caption = "Tipo DB: Desarrollo"
                My.Settings.log_DB = "SBOGuateTEST"
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Seguridad_APG()
        'Pestaña Almacen -----------------
        mSeguridad.APG_Seguridad(rbpAlmacen) '0
        mSeguridad.APG_Seguridad(vtnAnalisisArticulos) '1
        mSeguridad.APG_Seguridad(vtnOrdenProduccion) '2
        mSeguridad.APG_Seguridad(vtnOrdenEnsamble) '3
        mSeguridad.APG_Seguridad(vtnImpresionOrdenes) '4
        mSeguridad.APG_Seguridad(vtnOrdenEnsamble1x1) '5
        mSeguridad.APG_Seguridad(vtnOrdenProduccionCerrar) '-----
        mSeguridad.APG_Seguridad(vtnOrdenEnsambleCerrar) '----
        mSeguridad.APG_Seguridad(vtnOrdenMateriaPrimaCerrar) '----


        'Pestaña Mantenimiento
        mSeguridad.APG_Seguridad(rbpMantenimiento) '0
        mSeguridad.APG_Seguridad(vtnParametrosProduccion) '1
        mSeguridad.APG_Seguridad(vtnMoldes) '2
        mSeguridad.APG_Seguridad(vtnMaquinas) '3
        mSeguridad.APG_Seguridad(vtnBodegas) '4
        mSeguridad.APG_Seguridad(vtnMateriales) '5
        mSeguridad.APG_Seguridad(vtnEnsamblesParametros) '6
        mSeguridad.APG_Seguridad(vtnEmpaqueParametros) '7
        mSeguridad.APG_Seguridad(vtnColores) '8  '2017 11 28 
        mSeguridad.APG_Seguridad(vtnAsignarComponentesProducidosMoldes) '9
        mSeguridad.APG_Seguridad(vtnComponentesMaquinas) '10 '2017 11 28
        mSeguridad.APG_Seguridad(vtnAsignarMoldesMaquinas) '11
        mSeguridad.APG_Seguridad(vtnParametrosPendientes) '12
        mSeguridad.APG_Seguridad(vtnMantenimientoArticulos) '13
        mSeguridad.APG_Seguridad(vtnCargarDatosProduccion) '14


        'Pestaña Ensamble
        mSeguridad.APG_Seguridad(rbpEnsamble) '0
        mSeguridad.APG_Seguridad(vtnEnsambleImpresion) '1
        mSeguridad.APG_Seguridad(vtnEnsambleCalculadora) '2

        'Pestaña Produccion
        mSeguridad.APG_Seguridad(rbpProduccion) '0
        mSeguridad.APG_Seguridad(vtnOrdenProduccionImpresion) '1 
        mSeguridad.APG_Seguridad(vtnImpresionInstrucciones)
        mSeguridad.APG_Seguridad(vtnListasOrdenes) '2
        mSeguridad.APG_Seguridad(vtnOrdenes) '3
        mSeguridad.APG_Seguridad(vtnDesmontes) '4
        mSeguridad.APG_Seguridad(vtnRecibos) '5
        mSeguridad.APG_Seguridad(vtnEmergenciasProduccion) '6
        mSeguridad.APG_Seguridad(vtnProgramacionProduccion) '7
        mSeguridad.APG_Seguridad(vtnTrabajoEnMaquinas) '8
        mSeguridad.APG_Seguridad(vtnControlProduccion) '9
        mSeguridad.APG_Seguridad(vtnMaquinasPorcEficiencia) '10
        mSeguridad.APG_Seguridad(vtnProduccionCalendario) '11

        'Pestaña Inventarios
        mSeguridad.APG_Seguridad(rbpInventarios) '0
        mSeguridad.APG_Seguridad(vtnInventarioSalidas) '1
        mSeguridad.APG_Seguridad(vtnInventarioSalidaImpresion) '2
        mSeguridad.APG_Seguridad(vtnArticulosActualizarAR) '3
        mSeguridad.APG_Seguridad(vtnListaPreciosCostosActualizar) '4
        mSeguridad.APG_Seguridad(vtnListaPreciosActualizar) '5
        mSeguridad.APG_Seguridad(barbtnRevalorizacion_EE) '6
        mSeguridad.APG_Seguridad(vtnLPClientes) '7
        mSeguridad.APG_Seguridad(vtnListaMaterialesEliminarCompleta) '8
        mSeguridad.APG_Seguridad(vtnCodigoBarras) '9
        'Nuevos Permisos
        'mSeguridad.APG_Seguridad(btnTrasladoInvetario) '10
        'mSeguridad.APG_Seguridad(BtnAjusteInventario) '10

        'Aqui van mis permisos

        'Pestaña Reportes
        mSeguridad.APG_Seguridad(rbpReportes) '0
        mSeguridad.APG_Seguridad(vtnRep_Desviacion_CP) '1
        mSeguridad.APG_Seguridad(vtnRep_Desviacion_AR) '2
        mSeguridad.APG_Seguridad(vtnRep_OrdenesDirectoSAP) '3


    End Sub


    Private Sub bvbExit_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bvbExit.ItemClick
        Me.Close()
    End Sub
    Private Sub Clientes_ItemDoubleClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        splEsperar.Show()
    End Sub
    Private Sub barbtnPruebas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        frmTemporal_AnalisisVenta.ShowDialog()
    End Sub
    Private Sub tmrTiempoyHora_Tick(sender As Object, e As EventArgs) Handles tmrTiempoyHora.Tick
        Try
            Application.DoEvents()
            bartxtHora.EditValue = TimeOfDay
            bartxtFecha1.EditValue = DateString

            Application.DoEvents()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    frmMercanciasSalidas.Sub_TrasladosMercaderia_Impresion("46933")
    'End Sub


    Private Sub vtnAnalisisArticulos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnAnalisisArticulos.ItemClick
        Try
            frmAnalisisNecesidades.MdiParent = Me
            frmAnalisisNecesidades.WindowState = FormWindowState.Maximized
            frmAnalisisNecesidades.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnOrdenProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenProduccion.ItemClick
        Try
            frmOrdenProduccion.MdiParent = Me
            frmOrdenProduccion.WindowState = FormWindowState.Maximized
            frmOrdenProduccion.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnOrdenProduccionCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenProduccionCerrar.ItemClick
        Try
            vpTipoOrden = "CP" 'Set Tipo de Ordenes a Mostrar
            frmOrdenCerrar.Text = "Cerrar ordenes de PRODUCCION"
            frmOrdenCerrar.MdiParent = Me
            frmOrdenCerrar.WindowState = FormWindowState.Maximized
            frmOrdenCerrar.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

#Region "Almacen"
    Private Sub vtnOrdenEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenEnsamble.ItemClick
        Try
            fcn_vtnAnalisisEnsamble()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub fcn_vtnAnalisisEnsamble()
        Try

            frmTemporal_Lista.ppTabla = mSQLSelect.GET_Catalogo_AR_CP_Hijos()
            frmTemporal_Lista.ShowDialog()
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = frmTemporal_Lista.ppResultado
            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmTemporal_MoldesDeCodigo.ppCodigo = pCodigoArticulo
            frmTemporal_MoldesDeCodigo.ShowDialog()

            If frmTemporal_MoldesDeCodigo.ppContinuar = False Then
                mMensajes.msg_Informacion("Se Canceló el proceso por el Usuario!")
                Exit Sub
            End If

            'Traer Moldes Seleccionados
            Dim pResultado_Moldes As String = String.Empty
            pResultado_Moldes = frmTemporal_MoldesDeCodigo.ppResultado()
            If pResultado_Moldes = Nothing Then
                mMensajes.msg_Informacion("No existen Datos para cargar! Codigos de Molde!!")
                Exit Sub
            End If

            'Traer Codigos Hijos Seleccionados
            Dim pResultado_CodigosHijos As String = String.Empty
            pResultado_CodigosHijos = mFunciones.FCN_GET_Columna(mSQLSelect.GET_ArticulosHijosPorMolde(pResultado_Moldes), "CodigoArticulo")

            If pResultado_CodigosHijos = Nothing Then
                mMensajes.msg_Informacion("No existen Datos para cargar! Codigos Hijos!!")
                Exit Sub
            End If

            frmOrdenEnsambleProduccion.ppTipo = "AnalisisEnsamble"
            frmOrdenEnsambleProduccion.ppCodigosArticulos = pResultado_CodigosHijos
            frmOrdenEnsambleProduccion.ppCodigosArticuloOrigen = pCodigoArticulo
            frmOrdenEnsambleProduccion.MdiParent = Me
            frmOrdenEnsambleProduccion.WindowState = FormWindowState.Maximized
            frmOrdenEnsambleProduccion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnOrdenEnsamble1x1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenEnsamble1x1.ItemClick
        Try
            fcn_vtnEnsamble()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub fcn_vtnEnsamble()
        Try

            frmTemporal_Lista.ppTabla = mSQLSelect.GET_Catalogo_AR_CP_Hijos()
            frmTemporal_Lista.ShowDialog()
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = frmTemporal_Lista.ppResultado
            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmOrdenEnsambleProduccion.ppTipo = "Ensamble"
            frmOrdenEnsambleProduccion.ppCodigosArticulos = "'" + pCodigoArticulo + "'"
            frmOrdenEnsambleProduccion.MdiParent = Me
            frmOrdenEnsambleProduccion.WindowState = FormWindowState.Maximized
            frmOrdenEnsambleProduccion.Show()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region


    Private Sub vtnOrdenEnsambleCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenEnsambleCerrar.ItemClick
        vpTipoOrden = "AR" 'Set Tipo de Ordenes a Mostrar
        frmOrdenCerrar.Text = "Cerrar ordenes de ENSAMBLE"
        frmOrdenCerrar.MdiParent = Me
        frmOrdenCerrar.WindowState = FormWindowState.Maximized
        frmOrdenCerrar.Show()
    End Sub

    Private Sub vtnImpresionOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnImpresionOrdenes.ItemClick
        Try
            frmOrdenImpresion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub vtnMoldes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnMoldes.ItemClick
        Try
            frmMoldes.Text = "Mantenimiento de Moldes"
            'frmMoldes.MdiParent = Me
            'frmMoldes.WindowState = FormWindowState.Maximized
            frmMoldes.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub vtnMaquinas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnMaquinas.ItemClick
        Try
            frmMaquinas.Text = "Mantenimiento de Maquinas"
            frmMaquinas.MdiParent = Me
            frmMaquinas.WindowState = FormWindowState.Maximized
            frmMaquinas.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub vtnAsignarComponentesProducidosMoldes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnAsignarComponentesProducidosMoldes.ItemClick
        Try
            frmAsignarCodigosProducidosMoldes.Text = "Mantenimiento de Codigos Producidos / Moldes"
            frmAsignarCodigosProducidosMoldes.MdiParent = Me
            frmAsignarCodigosProducidosMoldes.WindowState = FormWindowState.Maximized
            frmAsignarCodigosProducidosMoldes.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub vtnAsignarMoldesMaquinas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnAsignarMoldesMaquinas.ItemClick
        Try
            frmAsignarMoldesMaquinas.Text = "Mantenimiento de Moldes / Maquinas"
            frmAsignarMoldesMaquinas.MdiParent = Me
            frmAsignarMoldesMaquinas.WindowState = FormWindowState.Maximized
            frmAsignarMoldesMaquinas.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnMaquinasPorcEficiencia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnMaquinasPorcEficiencia.ItemClick
        Try
            frmMaquinasPorcentajeEficiencia.Text = "Porcentaje Diarios de Eficiencia de Maquinas"
            frmMaquinasPorcentajeEficiencia.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnInventarioSalidas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnInventarioSalidas.ItemClick
        Try
            frmMercanciasSalidas.Text = "Salidas de Mercaderia"
            frmMercanciasSalidas.MdiParent = Me
            frmMercanciasSalidas.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnInventarioSalidaImpresion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnInventarioSalidaImpresion.ItemClick
        Try
            frmMercanciasSalidasImpresion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vtnArticulosActualizarAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnArticulosActualizarAR.ItemClick
        Try

            frmArticulosActualizacion.Text = "Actualizar Articulos"
            frmArticulosActualizacion.MdiParent = Me
            frmArticulosActualizacion.WindowState = FormWindowState.Maximized
            frmArticulosActualizacion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnEnsamblesParametros_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEnsamblesParametros.ItemClick
        Try

            frmParametros_Ensambles.Text = "Parametrizacion de Tiempos de Ensamble"
            frmParametros_Ensambles.MdiParent = Me
            frmParametros_Ensambles.WindowState = FormWindowState.Maximized
            frmParametros_Ensambles.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnOrdenProduccionImpresion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenProduccionImpresion.ItemClick
        Try

            frmOrdenProduccionDisponibles.Text = "Impresion Ordenes de Produccion"
            frmOrdenProduccionDisponibles.MdiParent = Me
            frmOrdenProduccionDisponibles.WindowState = FormWindowState.Maximized
            frmOrdenProduccionDisponibles.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub vtnListaPreciosCostosActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub vtnRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnRecibos.ItemClick
        Try
            frmReciboProduccionEnsamble.Text = "Recibo/Emision Produccion"
            frmReciboProduccionEnsamble.MdiParent = Me
            'frmReciboProduccionEnsamble.WindowState = FormWindowState.Maximized
            frmReciboProduccionEnsamble.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnEmpaqueParametros_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEmpaqueParametros.ItemClick
        Try

            frmParametros_Procedimientos.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnParametrosProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnParametrosProduccion.ItemClick
        Try
            frmParametros_Produccion.Text = "Parametros de Produccion"
            frmParametros_Produccion.MdiParent = Me
            frmParametros_Produccion.WindowState = FormWindowState.Maximized
            frmParametros_Produccion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnOrdenMateriaPrimaCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenMateriaPrimaCerrar.ItemClick
        Try
            vpTipoOrden = "MP" 'Set Tipo de Ordenes a Mostrar
            frmOrdenCerrar.Text = "Cerrar ordenes de Materia Prima"
            frmOrdenCerrar.MdiParent = Me
            frmOrdenCerrar.WindowState = FormWindowState.Maximized
            frmOrdenCerrar.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub vtnListasOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnListasOrdenes.ItemClick
        Try
            frmOrdenLista.Text = "Listado de Ordenes"
            frmOrdenLista.MdiParent = Me
            frmOrdenLista.WindowState = FormWindowState.Maximized
            frmOrdenLista.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PruebaEmail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'FCN_Email_EnviarSinAdjunto("OrdenesCerradas", "Prueba", "Esto es Una Prueba")
    End Sub


    Private Sub vtnOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnOrdenes.ItemClick
        Try

            frmOrdenProduccionEnsamble.Text = "Ordenes Produccion Ensamble"
            'frmOrdenProduccionEnsamble.ppNumSAP = pSAP
            frmOrdenProduccionEnsamble.ppTipo = "Vacio"
            'frmOrdenProduccionEnsamble.ShowDialog(Me)
            frmOrdenProduccionEnsamble.MdiParent = Me
            frmOrdenProduccionEnsamble.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnMantenimientoArticulos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnMantenimientoArticulos.ItemClick
        Try
            frmMantenimientoArticulos.Text = "Mantenimiento de Articulos"
            frmMantenimientoArticulos.MdiParent = Me
            frmMantenimientoArticulos.WindowState = FormWindowState.Maximized
            frmMantenimientoArticulos.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'FCN_Email_Pruebas()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnnHelp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnnHelp.ItemClick


        frmTemporal_OrdenesCerradasResultado.ppCodigoArticulo = "'181516','180520'"
        frmTemporal_OrdenesCerradasResultado.vpEnviarCorreo = True
        frmTemporal_OrdenesCerradasResultado.ppTipoEvento = "Cerradas"
        frmTemporal_OrdenesCerradasResultado.ShowDialog()

    End Sub

    Private Sub vtnEmergenciasProduccion_ItemPress(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEmergenciasProduccion.ItemPress
    End Sub

    Private Sub barbtnEmergenciasProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEmergenciasProduccion.ItemClick
        Try
            'barStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Application.DoEvents()
            'BackgroundWorker1.RunWorkerAsync()

            frmPlanPrioridadesAlmacen.Text = "Plan Prioridades Almacen"
            frmPlanPrioridadesAlmacen.ModoLlamada = "PRINCIPAL"
            frmPlanPrioridadesAlmacen.MdiParent = Me
            frmPlanPrioridadesAlmacen.WindowState = FormWindowState.Maximized
            frmPlanPrioridadesAlmacen.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Application.DoEvents()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub rbcMenuPrincipal_Click(sender As Object, e As EventArgs) Handles rbcMenuPrincipal.Click

    End Sub

    Private Sub vtnColores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnColores.ItemClick
        Try
            frmMantenimientoColores.MdiParent = Me
            frmMantenimientoColores.WindowState = FormWindowState.Maximized
            frmMantenimientoColores.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnListaPreciosCostosActualizar_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnListaPreciosCostosActualizar.ItemClick
        Try

            frmListaPreciosCostosActualizar.Text = "Actualizción de lista de Precios [Costos]"
            frmListaPreciosCostosActualizar.MdiParent = Me
            frmListaPreciosCostosActualizar.WindowState = FormWindowState.Maximized
            frmListaPreciosCostosActualizar.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnListaPreciosActualizar_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnListaPreciosActualizar.ItemClick
        Try
            frmListaPreciosActualizar.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub vtnLPClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnLPClientes.ItemClick

        Try
            frmListaPreciosClientes.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub vtnProgramacionProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnProgramacionProduccion.ItemClick
        Try

            mSQLInsert.fg_Historial(vtnProgramacionProduccion.Caption.ToString, "Ingreso a Programación de Producción.")

            frmProgramacionProduccion.Text = "Programación Producción"
            frmProgramacionProduccion.MdiParent = Me
            frmProgramacionProduccion.WindowState = FormWindowState.Maximized
            frmProgramacionProduccion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnComponentesMaquinas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnComponentesMaquinas.ItemClick
        Try

            frmAsignarComponentesMaquinas.Text = "Asignacion de Componentes a Maquinas"
            frmAsignarComponentesMaquinas.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnTrabajoEnMaquinas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnTrabajoEnMaquinas.ItemClick
        Try

            frmTrabajoEnMaquinas.Text = "Trabajos Asignados a Maquinas"
            frmTrabajoEnMaquinas.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnControlProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnControlProduccion.ItemClick
        Try

            frmControlProduccion.Text = "Control de Produccion"
            frmControlProduccion.MdiParent = Me
            frmControlProduccion.WindowState = FormWindowState.Maximized
            frmControlProduccion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnRep_Desviacion_CP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnRep_Desviacion_CP.ItemClick
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Reportes_spDiferencias_PROD_SAP] PE ")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsReportes1.Tables(DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString).Clear()
            DsReportes1.Tables(DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString).Merge(dt)


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrpt_Desviacion_ProduccionEnsamble
            RPTdocumento.DataSource = Me.DsReportes1
            RPTdocumento.DataMember = Me.DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            PrintTool.ShowRibbonPreviewDialog()

            If MsgBox("Desea enviarlo por correo? ", MsgBoxStyle.YesNo, "Enviar reporte por Correo...") = MsgBoxResult.Yes Then
                mFunciones.ExportToPNG(RPTdocumento, "Reporte_DesviacionPROD_SAP")
                mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("DesviacionPROD_SAP",
                                                            "Desviacion en Ordenes de Producción " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]",
                                                            "Reporte Adjunto.",
                                                            "Reporte_DesviacionPROD_SAP")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnRep_Desviacion_AR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnRep_Desviacion_AR.ItemClick
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Reportes_spDiferencias_PROD_SAP] EE ")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsReportes1.Tables(DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString).Clear()
            DsReportes1.Tables(DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString).Merge(dt)


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrpt_Desviacion_ProduccionEnsamble
            RPTdocumento.DataSource = Me.DsReportes1
            RPTdocumento.DataMember = Me.DsReportes1.dsdtDesviacion_ProduccionEnsamble.TableName.ToString
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            PrintTool.ShowRibbonPreviewDialog()

            If MsgBox("Desea enviarlo por correo? ", MsgBoxStyle.YesNo, "Enviar reporte por Correo...") = MsgBoxResult.Yes Then
                mFunciones.ExportToPNG(RPTdocumento, "Reporte_DesviacionPROD_SAP")
                mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("DesviacionPROD_SAP",
                                                            "Desviacion en Ordenes de Ensambles " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]",
                                                            "Reporte Adjunto.",
                                                            "Reporte_DesviacionPROD_SAP")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnRep_OrdenesDirectoSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnRep_OrdenesDirectoSAP.ItemClick
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Reportes_spOrdenesSubidasDirectoSAP] ")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsReportes1.Tables(DsReportes1.dsdtOrdenesSubidasDirectoSAP.TableName.ToString).Clear()
            DsReportes1.Tables(DsReportes1.dsdtOrdenesSubidasDirectoSAP.TableName.ToString).Merge(dt)


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrpt_OrdenesDirectoSAP
            RPTdocumento.DataSource = Me.DsReportes1
            RPTdocumento.DataMember = Me.DsReportes1.dsdtOrdenesSubidasDirectoSAP.TableName.ToString
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            PrintTool.ShowRibbonPreviewDialog()

            If MsgBox("Desea enviarlo por correo? ", MsgBoxStyle.YesNo, "Enviar reporte por Correo...") = MsgBoxResult.Yes Then
                mFunciones.ExportToPNG(RPTdocumento, "Reporte_OrdenesDirectoSAP")
                mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("DesviacionPROD_SAP",
                                                            "Ordenes Ingresadas Directo en SAP " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]",
                                                            "Reporte Adjunto.",
                                                            "Reporte_OrdenesDirectoSAP")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnEnsambleImpresion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEnsambleImpresion.ItemClick
        Try

            frmEnsambleImpresion.Text = "Ensambles - Impresion"
            frmEnsambleImpresion.MdiParent = Me
            frmEnsambleImpresion.WindowState = FormWindowState.Maximized
            frmEnsambleImpresion.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub vtnEnsambleCalculadora_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnEnsambleCalculadora.ItemClick
        Try

            frmEnsambleCalculadora.Text = "Ensambles - Calculadora"
            frmEnsambleCalculadora.MdiParent = Me
            frmEnsambleCalculadora.WindowState = FormWindowState.Maximized
            frmEnsambleCalculadora.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnDesmontes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnDesmontes.ItemClick
        Try

            frmTemporal_Lista.ppTabla = mSQLSelect.GET_Catalogo_AR_CP_Hijos()
            frmTemporal_Lista.ShowDialog()
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = frmTemporal_Lista.ppResultado
            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmOrdenProduccionEnsamble.ppTipo = "Desmontar"
            frmOrdenProduccionEnsamble.ppCodigoArticulo = pCodigoArticulo
            frmOrdenProduccionEnsamble.Show()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub vtnParametrosPendientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnParametrosPendientes.ItemClick
        Try
            frmParametrosPendientes.Text = "Parametros pendientes de Información"
            frmParametrosPendientes.MdiParent = Me
            frmParametrosPendientes.WindowState = FormWindowState.Maximized
            frmParametrosPendientes.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnRevalorizacion_EE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRevalorizacion_EE.ItemClick
        If Environment.UserName = "EJPEREZ" Then

            Dim dt As New DataTable()

            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Revalorizacion_EnergiaElectrica]")

            If dt.Rows.Count = Nothing Then
                mMensajes.msg_NoData()
                Exit Sub
            End If

            If Not ssmSperar.IsSplashFormVisible Then : ssmSperar.ShowWaitForm() : End If
            For i = 0 To dt.Rows.Count - 1
                ssmSperar.SetWaitFormDescription(dt.Rows(i)("ARItemCode").ToString)
                UPDATE_Revalorizacion_EnergiaElectrica(dt.Rows(i)("ARItemCode").ToString, dt.Rows(i)("Porcentaje").ToString)
            Next
            If ssmSperar.IsSplashFormVisible Then : ssmSperar.CloseWaitForm() : End If


        Else
            MsgBox("No cuenta con suficientes permisos para ejecutar este proceso")
        End If
    End Sub

    Private Sub vtnListaMaterialesEliminarCompleta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnListaMaterialesEliminarCompleta.ItemClick
        Try
            frmListaMaterialEliminarCompleto.Text = "Borrar Lista Materiales"
            frmListaMaterialEliminarCompleto.MdiParent = Me
            frmListaMaterialEliminarCompleto.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnCodigoBarras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnCodigoBarras.ItemClick
        Try
            frmCodigoBarras.Text = "Generar Codigo de Barras (DUN 14)"
            frmCodigoBarras.MdiParent = Me
            frmCodigoBarras.Show()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnProduccionCalendario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnProduccionCalendario.ItemClick
        frmProduccionCalendario.Text = "Calendario de Producción"
        frmProduccionCalendario.MdiParent = Me
        frmParametrosPendientes.WindowState = FormWindowState.Maximized
        frmProduccionCalendario.Show()
    End Sub

    Private Sub vtnImpresionInstrucciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnImpresionInstrucciones.ItemClick
        frmCodigosImpresion_XCodigo.Text = "Impresion de Instrucciones de Trabajo"
        frmCodigosImpresion_XCodigo.MdiParent = Me
        frmCodigosImpresion_XCodigo.Show()
    End Sub

    Private Sub vtnCargarParametrosProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnCargarDatosProduccion.ItemClick
        frmCargarDatosProduccion.Text = "CargarDatosProduccion"
        frmCargarDatosProduccion.MdiParent = Me
        frmCargarDatosProduccion.Show()
    End Sub

    Private Sub vtnListaMateriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnListaMateriales.ItemClick

        Try

            frmTemporal_Lista.ppTabla = mSQLSelect.GET_Catalogo_AR_CP_Hijos()
            frmTemporal_Lista.ShowDialog()
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = frmTemporal_Lista.ppResultado
            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmTemporal_ListaMateriales.mmCodigo = pCodigoArticulo
            frmTemporal_ListaMateriales.ShowDialog(Me)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub vtnExportarListaEmpaque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles vtnExportarListaEmpaque.ItemClick
        Try
            If MsgBox("Desea exportar a Excel el catalogo completo de LISTAS DE EMPAQUE?", MsgBoxStyle.YesNo, "Exportar") = MsgBoxResult.No Then
                Exit Sub
            End If

            'Dim ssmEsperar2 As New DevExpress.XtraSplashScreen.SplashScreenManager
            'ssmEsperar2.ShowForm(GetType(splEsperar))

            'Valida que este instanciado antes de usarlo!
            If ssmSperar Is Nothing Then
                ssmSperar = New SplashScreenManager(Me, GetType(splEsperar), True, True)
            End If

            If Not ssmSperar.IsSplashFormVisible() Then : ssmSperar.ShowWaitForm() : End If

            ssmSperar.SetWaitFormCaption("Buscando Catalogo...")
            ssmSperar.SetWaitFormDescription("Lista Empaque...")

            Dim dtEmpaque As New DataTable()
            dtEmpaque = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Empaque_Parametros_Todos")

            If dtEmpaque.Rows.Count = Nothing Then
                Throw New Exception("No existen datos de Lista de Empaque")
            End If

            '-------------------------------------------------

            If ssmSperar.IsSplashFormVisible() Then : ssmSperar.CloseWaitForm() : End If

            Dim pRutaGuardar As String = String.Empty

            sfdSave.Title = "Guardar Archivo"
            sfdSave.Filter = "(*.XLS)|*.xls"

            If sfdSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pRutaGuardar = sfdSave.FileName.ToString
            Else
                MsgBox("Operación cancelada por el Usuario")
            End If

            Dim gcGrid As New DevExpress.XtraGrid.GridControl
            Dim gvView As New DevExpress.XtraGrid.Views.Grid.GridView
            Dim bV As DevExpress.XtraGrid.Views.Base.BaseView = gvView
            gcGrid.BindingContext = New System.Windows.Forms.BindingContext
            gcGrid.MainView = gvView
            gvView.GridControl = gcGrid
            gcGrid.ViewCollection.AddRange({bV})
            gcGrid.DataSource = dtEmpaque
            gcGrid.ForceInitialize()
            gvView.PopulateColumns()
            gvView.OptionsView.ColumnAutoWidth = True
            gvView.BestFitMaxRowCount = -1
            gvView.BestFitColumns()
            gcGrid.ExportToXls(pRutaGuardar)

            MsgBox("Su documento se ha grabado con exito." + Environment.NewLine + "Ruta: " + pRutaGuardar.ToString)

            'gvView.ActiveFilterString = "CustExists='Y'"
            'gcGrid.ExportToXls("C:\Users\Admin\Desktop\CatalogoListaEmpaque.xls")

            '-----------------------------------------------------

        Catch ex As Exception
            If ssmSperar.IsSplashFormVisible() Then : ssmSperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Traslado de Invetario MOD 03/07/2024
    Private Sub btnTrasladoInvetario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrasladoInvetario.ItemClick
        fmrTrasladoDeInventario.Text = "Traslado De Invetario"
        fmrTrasladoDeInventario.MdiParent = Me
        fmrTrasladoDeInventario.WindowState = FormWindowState.Maximized ' Establecer el estado de ventana a maximizado
        fmrTrasladoDeInventario.Show()
    End Sub

    'Ajuste de Invetario MOD 03/07/2024
    Private Sub BtnAjusteInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAjusteInventario.ItemClick
        frmAjustedeInvetario.Text = "Ajuste De Invetario"
        frmAjustedeInvetario.MdiParent = Me
        frmAjustedeInvetario.WindowState = FormWindowState.Maximized ' Establecer el estado de ventana a maximizado
        frmAjustedeInvetario.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            'barStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Application.DoEvents()
            'BackgroundWorker1.RunWorkerAsync()

            frmPlanPrioridadesAlmacen.Text = "Plan Prioridades Almacen"
            frmPlanPrioridadesAlmacen.ModoLlamada = "SECUNDARIO"
            frmPlanPrioridadesAlmacen.MdiParent = Me
            frmPlanPrioridadesAlmacen.WindowState = FormWindowState.Maximized
            frmPlanPrioridadesAlmacen.Show()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class
