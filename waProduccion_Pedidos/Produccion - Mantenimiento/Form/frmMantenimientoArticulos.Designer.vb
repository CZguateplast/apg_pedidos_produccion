<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoArticulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoArticulos))
        Dim UpcaGenerator1 As DevExpress.XtraPrinting.BarCode.UPCAGenerator = New DevExpress.XtraPrinting.BarCode.UPCAGenerator()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.lycMantenimientoArticulos = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCodigoPadre = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcDiseno = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.sbdcAlmacen = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.sbdcListaMateriales = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barbtnCargarImagen1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabarImagen = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnVentasEstadisticas = New DevExpress.XtraBars.BarButtonItem()
        Me.dteP_FechaLanzamiento = New DevExpress.XtraEditors.DateEdit()
        Me.dteP_FechaAnuncio = New DevExpress.XtraEditors.DateEdit()
        Me.dteP_FechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtSenalizacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtTiketCaja = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreIngles = New DevExpress.XtraEditors.TextEdit()
        Me.xtcMantenimientoPadre = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpColores = New DevExpress.XtraTab.XtraTabPage()
        Me.lycColores = New DevExpress.XtraLayout.LayoutControl()
        Me.gpcCodigosHijos = New DevExpress.XtraEditors.GroupControl()
        Me.lycCodigosHijos = New DevExpress.XtraLayout.LayoutControl()
        Me.xtc_Hijos = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpH_Ingenieria = New DevExpress.XtraTab.XtraTabPage()
        Me.lycH_Ingenieria = New DevExpress.XtraLayout.LayoutControl()
        Me.btnH_Ingenieria_Grabar = New DevExpress.XtraEditors.SimpleButton()
        Me.spinH_ArticulosXHora = New DevExpress.XtraEditors.SpinEdit()
        Me.spinH_EnsambleEquipo = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit26 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit25 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit24 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit23 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit22 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit21 = New DevExpress.XtraEditors.SpinEdit()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SpinEdit20 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit19 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit18 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit17 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit16 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit15 = New DevExpress.XtraEditors.SpinEdit()
        Me.slueH_DeptoEnsamble = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueH_MaterialEmpaqueVenta = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtH_Capacidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtH_Material = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup21 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycH_Ingenieria1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem90 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem89 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycgH_EmpaqueVenta = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem91 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem94 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem95 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem96 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem93 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem97 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem31 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem98 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem32 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup22 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem100 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem33 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem104 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem101 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem102 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem105 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem34 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem103 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem99 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem30 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup23 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem107 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem106 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem92 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem108 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem35 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.xtpH_Ventas = New DevExpress.XtraTab.XtraTabPage()
        Me.lycH_Ventas = New DevExpress.XtraLayout.LayoutControl()
        Me.spinH_EmpaqueVenta = New DevExpress.XtraEditors.SpinEdit()
        Me.spinH_EmpaqueEstandar = New DevExpress.XtraEditors.SpinEdit()
        Me.spinH_PrecioMayorista = New DevExpress.XtraEditors.SpinEdit()
        Me.spinH_Unidades = New DevExpress.XtraEditors.SpinEdit()
        Me.spinH_Contenido = New DevExpress.XtraEditors.SpinEdit()
        Me.rdgH_EnCatalogo = New DevExpress.XtraEditors.RadioGroup()
        Me.slueH_GrupoArticulos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup20 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem84 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem85 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem86 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem87 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem88 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem29 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem26 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xtpH_Auditoria = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpH_Contabilidad = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpH_ListaMateriales = New DevExpress.XtraTab.XtraTabPage()
        Me.lycListaMateriales = New DevExpress.XtraLayout.LayoutControl()
        Me.grdListaMaterialesHijos = New DevExpress.XtraGrid.GridControl()
        Me.DsMantenimientoArticulos1 = New waProduccion_Pedidos.dsMantenimientoArticulos()
        Me.grdviewListaMaterialesHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueBodega = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xtpHijosAlmacen = New DevExpress.XtraTab.XtraTabPage()
        Me.lycAlmacenHijos = New DevExpress.XtraLayout.LayoutControl()
        Me.txtStockMaximo = New DevExpress.XtraEditors.TextEdit()
        Me.txtLocalizacionDel = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockMinimo = New DevExpress.XtraEditors.TextEdit()
        Me.txtUPC = New DevExpress.XtraEditors.TextEdit()
        Me.bccCodigoBarras = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.txtDUN14 = New DevExpress.XtraEditors.TextEdit()
        Me.bccDUN14 = New DevExpress.XtraEditors.BarCodeControl()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem25 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.grdCodigosHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCodigosHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.slueColorAgregar = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup19 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xtpVentas = New DevExpress.XtraTab.XtraTabPage()
        Me.lycVentas = New DevExpress.XtraLayout.LayoutControl()
        Me.spinP_PrecioMayorista = New DevExpress.XtraEditors.SpinEdit()
        Me.spinP_EmpaqueVenta = New DevExpress.XtraEditors.SpinEdit()
        Me.spinP_EmpaqueEstandar = New DevExpress.XtraEditors.SpinEdit()
        Me.spinP_Unidades = New DevExpress.XtraEditors.SpinEdit()
        Me.spinP_Contenido = New DevExpress.XtraEditors.SpinEdit()
        Me.slueP_GrupoArticulos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rdgP_EnCatalgo = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem28 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Auditoria = New DevExpress.XtraTab.XtraTabPage()
        Me.lycAuditoria = New DevExpress.XtraLayout.LayoutControl()
        Me.btn_Auditoria_Guardar = New DevExpress.XtraEditors.SimpleButton()
        Me.spinPrecio_TiendaContinental = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_HNOperadoraSur = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_GTCemaco = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_GTDespensa = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_GTPaiz = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_SVMayorista = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Barbados = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Belice = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Mexico = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_PuertoRico = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_RepDominicana = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Panama = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_CostaRica = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Nicaragua = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_Honduras = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_ElSalvador = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_CPUnidadDocena = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_CPUnidadindividual = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_CentroAmericaSur = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_CentroAmericaNorte = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPrecio_MayoristaTarjeta = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup15 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem20 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem22 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup16 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup17 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem24 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup18 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem23 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem77 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.xtpIngenieria = New DevExpress.XtraTab.XtraTabPage()
        Me.lycAlmacen = New DevExpress.XtraLayout.LayoutControl()
        Me.txtArticuloCapacidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtArticuloMedidas = New DevExpress.XtraEditors.TextEdit()
        Me.SpinEdit14 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit13 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit12 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit11 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit10 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit9 = New DevExpress.XtraEditors.SpinEdit()
        Me.slueMaterialEmpaqueMaster = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SpinEdit8 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit7 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit6 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit5 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit4 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.slueMaterialEmpaqueEstandar = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem17 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem16 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup14 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem21 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem27 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup13 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem18 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem19 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem15 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.xtpContabilidad = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpDiseno = New DevExpress.XtraTab.XtraTabPage()
        Me.lycDiseno = New DevExpress.XtraLayout.LayoutControl()
        Me.picArticulo = New DevExpress.XtraEditors.PictureEdit()
        Me.txtExtension = New DevExpress.XtraEditors.TextEdit()
        Me.txtImagenRutaDestino = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtImagenRutaOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.txtImagenNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.xtpListaMateriales = New DevExpress.XtraTab.XtraTabPage()
        Me.lycP_ListaMateriales = New DevExpress.XtraLayout.LayoutControl()
        Me.grdH_ListaMateriales = New DevExpress.XtraGrid.GridControl()
        Me.grdviewP_ListaMateriales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup24 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem109 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xtpExportacion = New DevExpress.XtraTab.XtraTabPage()
        Me.lycExportacion = New DevExpress.XtraLayout.LayoutControl()
        Me.txtPartidaArancelaria = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnCargarImagen = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barAlmacen = New DevExpress.XtraBars.Bar()
        Me.barbtnAsignarUPC = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.Alerta1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.BarManager4 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barListaMateriales = New DevExpress.XtraBars.Bar()
        Me.barbtnActualizarListaMateriales = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnListaMateriales_CopiarDe = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl12 = New DevExpress.XtraBars.BarDockControl()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        CType(Me.lycMantenimientoArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycMantenimientoArticulos.SuspendLayout()
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaLanzamiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaLanzamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaAnuncio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaAnuncio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteP_FechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenalizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTiketCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreIngles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcMantenimientoPadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMantenimientoPadre.SuspendLayout()
        Me.xtpColores.SuspendLayout()
        CType(Me.lycColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycColores.SuspendLayout()
        CType(Me.gpcCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCodigosHijos.SuspendLayout()
        CType(Me.lycCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycCodigosHijos.SuspendLayout()
        CType(Me.xtc_Hijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtc_Hijos.SuspendLayout()
        Me.xtpH_Ingenieria.SuspendLayout()
        CType(Me.lycH_Ingenieria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycH_Ingenieria.SuspendLayout()
        CType(Me.spinH_ArticulosXHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinH_EnsambleEquipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit26.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit25.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit24.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueH_DeptoEnsamble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueH_MaterialEmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtH_Capacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtH_Material.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycH_Ingenieria1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycgH_EmpaqueVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpH_Ventas.SuspendLayout()
        CType(Me.lycH_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycH_Ventas.SuspendLayout()
        CType(Me.spinH_EmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinH_EmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinH_PrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinH_Unidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinH_Contenido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgH_EnCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueH_GrupoArticulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpH_ListaMateriales.SuspendLayout()
        CType(Me.lycListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaMateriales.SuspendLayout()
        CType(Me.grdListaMaterialesHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMantenimientoArticulos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaMaterialesHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpHijosAlmacen.SuspendLayout()
        CType(Me.lycAlmacenHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAlmacenHijos.SuspendLayout()
        CType(Me.txtStockMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalizacionDel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUPC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDUN14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueColorAgregar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpVentas.SuspendLayout()
        CType(Me.lycVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycVentas.SuspendLayout()
        CType(Me.spinP_PrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinP_EmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinP_EmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinP_Unidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinP_Contenido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueP_GrupoArticulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgP_EnCatalgo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Auditoria.SuspendLayout()
        CType(Me.lycAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAuditoria.SuspendLayout()
        CType(Me.spinPrecio_TiendaContinental.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_HNOperadoraSur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_GTCemaco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_GTDespensa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_GTPaiz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_SVMayorista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Barbados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Belice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Mexico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_PuertoRico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_RepDominicana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Panama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_CostaRica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Nicaragua.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_Honduras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_ElSalvador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_CPUnidadDocena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_CPUnidadindividual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_CentroAmericaSur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_CentroAmericaNorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecio_MayoristaTarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpIngenieria.SuspendLayout()
        CType(Me.lycAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAlmacen.SuspendLayout()
        CType(Me.txtArticuloCapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArticuloMedidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMaterialEmpaqueMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMaterialEmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDiseno.SuspendLayout()
        CType(Me.lycDiseno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDiseno.SuspendLayout()
        CType(Me.picArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtension.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagenRutaDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagenRutaOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagenNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpListaMateriales.SuspendLayout()
        CType(Me.lycP_ListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycP_ListaMateriales.SuspendLayout()
        CType(Me.grdH_ListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewP_ListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpExportacion.SuspendLayout()
        CType(Me.lycExportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycExportacion.SuspendLayout()
        CType(Me.txtPartidaArancelaria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycMantenimientoArticulos
        '
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtCodigoPadre)
        Me.lycMantenimientoArticulos.Controls.Add(Me.dteP_FechaLanzamiento)
        Me.lycMantenimientoArticulos.Controls.Add(Me.dteP_FechaAnuncio)
        Me.lycMantenimientoArticulos.Controls.Add(Me.dteP_FechaInicio)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtSenalizacion)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtTiketCaja)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtDescripcion2)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtDescripcion1)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtNombreIngles)
        Me.lycMantenimientoArticulos.Controls.Add(Me.xtcMantenimientoPadre)
        Me.lycMantenimientoArticulos.Controls.Add(Me.txtNombreArticulo)
        Me.lycMantenimientoArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycMantenimientoArticulos.Location = New System.Drawing.Point(0, 0)
        Me.lycMantenimientoArticulos.Name = "lycMantenimientoArticulos"
        Me.lycMantenimientoArticulos.Root = Me.LayoutControlGroup1
        Me.lycMantenimientoArticulos.Size = New System.Drawing.Size(1249, 663)
        Me.lycMantenimientoArticulos.TabIndex = 0
        Me.lycMantenimientoArticulos.Text = "LayoutControl1"
        '
        'txtCodigoPadre
        '
        Me.txtCodigoPadre.Location = New System.Drawing.Point(107, 12)
        Me.txtCodigoPadre.MenuManager = Me.BarManager1
        Me.txtCodigoPadre.Name = "txtCodigoPadre"
        Me.txtCodigoPadre.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoPadre.Properties.MaxLength = 8
        Me.txtCodigoPadre.Size = New System.Drawing.Size(119, 20)
        Me.txtCodigoPadre.StyleController = Me.lycMantenimientoArticulos
        Me.txtCodigoPadre.TabIndex = 19
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcDiseno)
        Me.BarManager1.DockControls.Add(Me.sbdcAlmacen)
        Me.BarManager1.DockControls.Add(Me.sbdcListaMateriales)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnSAP, Me.barbtnCargarImagen1, Me.barbtnGrabarImagen, Me.barbtnVentasEstadisticas, Me.barbtnNuevo})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSAP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnNuevo
        '
        Me.barbtnNuevo.Caption = "Nuevo"
        Me.barbtnNuevo.Id = 8
        Me.barbtnNuevo.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.new_32x32
        Me.barbtnNuevo.Name = "barbtnNuevo"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnSAP.Caption = "Grabar"
        Me.barbtnSAP.Id = 3
        Me.barbtnSAP.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 1
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1249, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 663)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1249, 44)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 663)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1249, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 663)
        '
        'sbdcDiseno
        '
        Me.sbdcDiseno.CausesValidation = False
        Me.sbdcDiseno.Location = New System.Drawing.Point(12, 12)
        Me.sbdcDiseno.Manager = Me.BarManager1
        Me.sbdcDiseno.Name = "sbdcDiseno"
        Me.sbdcDiseno.Size = New System.Drawing.Size(266, 47)
        Me.sbdcDiseno.Text = "StandaloneBarDockControl1"
        '
        'sbdcAlmacen
        '
        Me.sbdcAlmacen.CausesValidation = False
        Me.sbdcAlmacen.Location = New System.Drawing.Point(12, 435)
        Me.sbdcAlmacen.Manager = Me.BarManager1
        Me.sbdcAlmacen.Name = "sbdcAlmacen"
        Me.sbdcAlmacen.Size = New System.Drawing.Size(236, 31)
        Me.sbdcAlmacen.Text = "StandaloneBarDockControl1"
        '
        'sbdcListaMateriales
        '
        Me.sbdcListaMateriales.CausesValidation = False
        Me.sbdcListaMateriales.Location = New System.Drawing.Point(12, 435)
        Me.sbdcListaMateriales.Manager = Me.BarManager1
        Me.sbdcListaMateriales.Name = "sbdcListaMateriales"
        Me.sbdcListaMateriales.Size = New System.Drawing.Size(183, 31)
        Me.sbdcListaMateriales.Text = "StandaloneBarDockControl1"
        '
        'barbtnCargarImagen1
        '
        Me.barbtnCargarImagen1.Caption = "Cargar Imagen"
        Me.barbtnCargarImagen1.Id = 5
        Me.barbtnCargarImagen1.ImageOptions.Image = CType(resources.GetObject("barbtnCargarImagen1.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCargarImagen1.Name = "barbtnCargarImagen1"
        '
        'barbtnGrabarImagen
        '
        Me.barbtnGrabarImagen.Caption = "Grabar Imagen"
        Me.barbtnGrabarImagen.Id = 6
        Me.barbtnGrabarImagen.ImageOptions.Image = CType(resources.GetObject("barbtnGrabarImagen.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabarImagen.Name = "barbtnGrabarImagen"
        '
        'barbtnVentasEstadisticas
        '
        Me.barbtnVentasEstadisticas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnVentasEstadisticas.Caption = "Estadistica Ventas"
        Me.barbtnVentasEstadisticas.Id = 7
        Me.barbtnVentasEstadisticas.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.stackedlinewithmarkers_16x16
        Me.barbtnVentasEstadisticas.ImageOptions.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.stackedlinewithmarkers_32x32
        Me.barbtnVentasEstadisticas.Name = "barbtnVentasEstadisticas"
        '
        'dteP_FechaLanzamiento
        '
        Me.dteP_FechaLanzamiento.EditValue = Nothing
        Me.dteP_FechaLanzamiento.Location = New System.Drawing.Point(895, 60)
        Me.dteP_FechaLanzamiento.MenuManager = Me.BarManager1
        Me.dteP_FechaLanzamiento.Name = "dteP_FechaLanzamiento"
        Me.dteP_FechaLanzamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaLanzamiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaLanzamiento.Size = New System.Drawing.Size(103, 20)
        Me.dteP_FechaLanzamiento.StyleController = Me.lycMantenimientoArticulos
        Me.dteP_FechaLanzamiento.TabIndex = 17
        '
        'dteP_FechaAnuncio
        '
        Me.dteP_FechaAnuncio.EditValue = Nothing
        Me.dteP_FechaAnuncio.Location = New System.Drawing.Point(895, 36)
        Me.dteP_FechaAnuncio.MenuManager = Me.BarManager1
        Me.dteP_FechaAnuncio.Name = "dteP_FechaAnuncio"
        Me.dteP_FechaAnuncio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaAnuncio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaAnuncio.Size = New System.Drawing.Size(103, 20)
        Me.dteP_FechaAnuncio.StyleController = Me.lycMantenimientoArticulos
        Me.dteP_FechaAnuncio.TabIndex = 16
        '
        'dteP_FechaInicio
        '
        Me.dteP_FechaInicio.EditValue = Nothing
        Me.dteP_FechaInicio.Location = New System.Drawing.Point(895, 12)
        Me.dteP_FechaInicio.MenuManager = Me.BarManager1
        Me.dteP_FechaInicio.Name = "dteP_FechaInicio"
        Me.dteP_FechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteP_FechaInicio.Size = New System.Drawing.Size(103, 20)
        Me.dteP_FechaInicio.StyleController = Me.lycMantenimientoArticulos
        Me.dteP_FechaInicio.TabIndex = 15
        '
        'txtSenalizacion
        '
        Me.txtSenalizacion.Location = New System.Drawing.Point(631, 60)
        Me.txtSenalizacion.MenuManager = Me.BarManager1
        Me.txtSenalizacion.Name = "txtSenalizacion"
        Me.txtSenalizacion.Properties.Mask.BeepOnError = True
        Me.txtSenalizacion.Properties.Mask.EditMask = "@ ""Guateplast"""
        Me.txtSenalizacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSenalizacion.Size = New System.Drawing.Size(165, 20)
        Me.txtSenalizacion.StyleController = Me.lycMantenimientoArticulos
        Me.txtSenalizacion.TabIndex = 14
        Me.txtSenalizacion.ToolTip = "Tamaño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iniciales al final del texto < GUATEPLAST >"
        '
        'txtTiketCaja
        '
        Me.txtTiketCaja.Location = New System.Drawing.Point(631, 36)
        Me.txtTiketCaja.MenuManager = Me.BarManager1
        Me.txtTiketCaja.Name = "txtTiketCaja"
        Me.txtTiketCaja.Size = New System.Drawing.Size(165, 20)
        Me.txtTiketCaja.StyleController = Me.lycMantenimientoArticulos
        Me.txtTiketCaja.TabIndex = 13
        '
        'txtDescripcion2
        '
        Me.txtDescripcion2.Location = New System.Drawing.Point(386, 60)
        Me.txtDescripcion2.MenuManager = Me.BarManager1
        Me.txtDescripcion2.Name = "txtDescripcion2"
        Me.txtDescripcion2.Size = New System.Drawing.Size(146, 20)
        Me.txtDescripcion2.StyleController = Me.lycMantenimientoArticulos
        Me.txtDescripcion2.TabIndex = 12
        '
        'txtDescripcion1
        '
        Me.txtDescripcion1.Location = New System.Drawing.Point(386, 36)
        Me.txtDescripcion1.MenuManager = Me.BarManager1
        Me.txtDescripcion1.Name = "txtDescripcion1"
        Me.txtDescripcion1.Size = New System.Drawing.Size(146, 20)
        Me.txtDescripcion1.StyleController = Me.lycMantenimientoArticulos
        Me.txtDescripcion1.TabIndex = 11
        '
        'txtNombreIngles
        '
        Me.txtNombreIngles.Location = New System.Drawing.Point(107, 60)
        Me.txtNombreIngles.MenuManager = Me.BarManager1
        Me.txtNombreIngles.Name = "txtNombreIngles"
        Me.txtNombreIngles.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreIngles.StyleController = Me.lycMantenimientoArticulos
        Me.txtNombreIngles.TabIndex = 10
        '
        'xtcMantenimientoPadre
        '
        Me.xtcMantenimientoPadre.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.xtcMantenimientoPadre.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcMantenimientoPadre.Location = New System.Drawing.Point(12, 84)
        Me.xtcMantenimientoPadre.Name = "xtcMantenimientoPadre"
        Me.xtcMantenimientoPadre.SelectedTabPage = Me.xtpColores
        Me.xtcMantenimientoPadre.Size = New System.Drawing.Size(1225, 567)
        Me.xtcMantenimientoPadre.TabIndex = 9
        Me.xtcMantenimientoPadre.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpVentas, Me.Auditoria, Me.xtpIngenieria, Me.xtpContabilidad, Me.xtpDiseno, Me.xtpListaMateriales, Me.xtpExportacion, Me.xtpColores})
        '
        'xtpColores
        '
        Me.xtpColores.Controls.Add(Me.lycColores)
        Me.xtpColores.Image = CType(resources.GetObject("xtpColores.Image"), System.Drawing.Image)
        Me.xtpColores.Name = "xtpColores"
        Me.xtpColores.Size = New System.Drawing.Size(1096, 561)
        Me.xtpColores.Text = "Colores"
        '
        'lycColores
        '
        Me.lycColores.Controls.Add(Me.gpcCodigosHijos)
        Me.lycColores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycColores.Location = New System.Drawing.Point(0, 0)
        Me.lycColores.Name = "lycColores"
        Me.lycColores.Root = Me.LayoutControlGroup19
        Me.lycColores.Size = New System.Drawing.Size(1096, 561)
        Me.lycColores.TabIndex = 0
        Me.lycColores.Text = "LayoutControl1"
        '
        'gpcCodigosHijos
        '
        Me.gpcCodigosHijos.Controls.Add(Me.lycCodigosHijos)
        Me.gpcCodigosHijos.Location = New System.Drawing.Point(12, 12)
        Me.gpcCodigosHijos.Name = "gpcCodigosHijos"
        Me.gpcCodigosHijos.ShowCaption = False
        Me.gpcCodigosHijos.Size = New System.Drawing.Size(1072, 537)
        Me.gpcCodigosHijos.TabIndex = 4
        Me.gpcCodigosHijos.Text = "Codigos Hijos"
        '
        'lycCodigosHijos
        '
        Me.lycCodigosHijos.Controls.Add(Me.xtc_Hijos)
        Me.lycCodigosHijos.Controls.Add(Me.grdCodigosHijos)
        Me.lycCodigosHijos.Controls.Add(Me.slueColorAgregar)
        Me.lycCodigosHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycCodigosHijos.Location = New System.Drawing.Point(2, 2)
        Me.lycCodigosHijos.Name = "lycCodigosHijos"
        Me.lycCodigosHijos.Root = Me.LayoutControlGroup2
        Me.lycCodigosHijos.Size = New System.Drawing.Size(1068, 533)
        Me.lycCodigosHijos.TabIndex = 0
        Me.lycCodigosHijos.Text = "LayoutControl1"
        '
        'xtc_Hijos
        '
        Me.xtc_Hijos.Location = New System.Drawing.Point(316, 12)
        Me.xtc_Hijos.Name = "xtc_Hijos"
        Me.xtc_Hijos.SelectedTabPage = Me.xtpH_Ingenieria
        Me.xtc_Hijos.Size = New System.Drawing.Size(740, 509)
        Me.xtc_Hijos.TabIndex = 8
        Me.xtc_Hijos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpH_Ventas, Me.xtpH_Auditoria, Me.xtpH_Ingenieria, Me.xtpH_Contabilidad, Me.xtpH_ListaMateriales, Me.xtpHijosAlmacen})
        '
        'xtpH_Ingenieria
        '
        Me.xtpH_Ingenieria.Controls.Add(Me.lycH_Ingenieria)
        Me.xtpH_Ingenieria.Image = Global.waProduccion_Pedidos.My.Resources.Resources.gaugestylefullcircular_16x16
        Me.xtpH_Ingenieria.Name = "xtpH_Ingenieria"
        Me.xtpH_Ingenieria.Size = New System.Drawing.Size(734, 478)
        Me.xtpH_Ingenieria.Text = "Ingenieria"
        '
        'lycH_Ingenieria
        '
        Me.lycH_Ingenieria.Controls.Add(Me.btnH_Ingenieria_Grabar)
        Me.lycH_Ingenieria.Controls.Add(Me.spinH_ArticulosXHora)
        Me.lycH_Ingenieria.Controls.Add(Me.spinH_EnsambleEquipo)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit26)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit25)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit24)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit23)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit22)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit21)
        Me.lycH_Ingenieria.Controls.Add(Me.SearchLookUpEdit2)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit20)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit19)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit18)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit17)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit16)
        Me.lycH_Ingenieria.Controls.Add(Me.SpinEdit15)
        Me.lycH_Ingenieria.Controls.Add(Me.slueH_DeptoEnsamble)
        Me.lycH_Ingenieria.Controls.Add(Me.slueH_MaterialEmpaqueVenta)
        Me.lycH_Ingenieria.Controls.Add(Me.txtH_Capacidad)
        Me.lycH_Ingenieria.Controls.Add(Me.txtH_Material)
        Me.lycH_Ingenieria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycH_Ingenieria.Location = New System.Drawing.Point(0, 0)
        Me.lycH_Ingenieria.Name = "lycH_Ingenieria"
        Me.lycH_Ingenieria.Root = Me.LayoutControlGroup21
        Me.lycH_Ingenieria.Size = New System.Drawing.Size(734, 478)
        Me.lycH_Ingenieria.TabIndex = 0
        Me.lycH_Ingenieria.Text = "LayoutControl1"
        '
        'btnH_Ingenieria_Grabar
        '
        Me.btnH_Ingenieria_Grabar.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.save_16x16
        Me.btnH_Ingenieria_Grabar.Location = New System.Drawing.Point(12, 426)
        Me.btnH_Ingenieria_Grabar.Name = "btnH_Ingenieria_Grabar"
        Me.btnH_Ingenieria_Grabar.Size = New System.Drawing.Size(136, 22)
        Me.btnH_Ingenieria_Grabar.StyleController = Me.lycH_Ingenieria
        Me.btnH_Ingenieria_Grabar.TabIndex = 23
        Me.btnH_Ingenieria_Grabar.Text = "Grabar"
        '
        'spinH_ArticulosXHora
        '
        Me.spinH_ArticulosXHora.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_ArticulosXHora.Location = New System.Drawing.Point(592, 90)
        Me.spinH_ArticulosXHora.MaximumSize = New System.Drawing.Size(80, 0)
        Me.spinH_ArticulosXHora.MenuManager = Me.BarManager1
        Me.spinH_ArticulosXHora.MinimumSize = New System.Drawing.Size(80, 0)
        Me.spinH_ArticulosXHora.Name = "spinH_ArticulosXHora"
        Me.spinH_ArticulosXHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_ArticulosXHora.Size = New System.Drawing.Size(80, 20)
        Me.spinH_ArticulosXHora.StyleController = Me.lycH_Ingenieria
        Me.spinH_ArticulosXHora.TabIndex = 22
        '
        'spinH_EnsambleEquipo
        '
        Me.spinH_EnsambleEquipo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_EnsambleEquipo.Location = New System.Drawing.Point(592, 66)
        Me.spinH_EnsambleEquipo.MaximumSize = New System.Drawing.Size(80, 0)
        Me.spinH_EnsambleEquipo.MenuManager = Me.BarManager1
        Me.spinH_EnsambleEquipo.MinimumSize = New System.Drawing.Size(80, 0)
        Me.spinH_EnsambleEquipo.Name = "spinH_EnsambleEquipo"
        Me.spinH_EnsambleEquipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_EnsambleEquipo.Size = New System.Drawing.Size(80, 20)
        Me.spinH_EnsambleEquipo.StyleController = Me.lycH_Ingenieria
        Me.spinH_EnsambleEquipo.TabIndex = 21
        '
        'SpinEdit26
        '
        Me.SpinEdit26.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit26.Location = New System.Drawing.Point(358, 366)
        Me.SpinEdit26.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit26.MenuManager = Me.BarManager1
        Me.SpinEdit26.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit26.Name = "SpinEdit26"
        Me.SpinEdit26.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit26.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit26.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit26.TabIndex = 20
        '
        'SpinEdit25
        '
        Me.SpinEdit25.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit25.Location = New System.Drawing.Point(358, 342)
        Me.SpinEdit25.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit25.MenuManager = Me.BarManager1
        Me.SpinEdit25.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit25.Name = "SpinEdit25"
        Me.SpinEdit25.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit25.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit25.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit25.TabIndex = 19
        '
        'SpinEdit24
        '
        Me.SpinEdit24.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit24.Location = New System.Drawing.Point(149, 390)
        Me.SpinEdit24.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit24.MenuManager = Me.BarManager1
        Me.SpinEdit24.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit24.Name = "SpinEdit24"
        Me.SpinEdit24.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit24.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit24.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit24.TabIndex = 18
        '
        'SpinEdit23
        '
        Me.SpinEdit23.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit23.Location = New System.Drawing.Point(149, 366)
        Me.SpinEdit23.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit23.MenuManager = Me.BarManager1
        Me.SpinEdit23.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit23.Name = "SpinEdit23"
        Me.SpinEdit23.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit23.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit23.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit23.TabIndex = 17
        '
        'SpinEdit22
        '
        Me.SpinEdit22.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit22.Location = New System.Drawing.Point(149, 342)
        Me.SpinEdit22.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit22.MenuManager = Me.BarManager1
        Me.SpinEdit22.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit22.Name = "SpinEdit22"
        Me.SpinEdit22.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit22.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit22.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit22.TabIndex = 16
        '
        'SpinEdit21
        '
        Me.SpinEdit21.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit21.Location = New System.Drawing.Point(149, 318)
        Me.SpinEdit21.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit21.MenuManager = Me.BarManager1
        Me.SpinEdit21.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit21.Name = "SpinEdit21"
        Me.SpinEdit21.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit21.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit21.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit21.TabIndex = 15
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(149, 294)
        Me.SearchLookUpEdit2.MaximumSize = New System.Drawing.Size(290, 20)
        Me.SearchLookUpEdit2.MenuManager = Me.BarManager1
        Me.SearchLookUpEdit2.MinimumSize = New System.Drawing.Size(290, 20)
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.NullText = ""
        Me.SearchLookUpEdit2.Properties.View = Me.GridView7
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(290, 20)
        Me.SearchLookUpEdit2.StyleController = Me.lycH_Ingenieria
        Me.SearchLookUpEdit2.TabIndex = 14
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'SpinEdit20
        '
        Me.SpinEdit20.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit20.Location = New System.Drawing.Point(358, 204)
        Me.SpinEdit20.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit20.MenuManager = Me.BarManager1
        Me.SpinEdit20.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit20.Name = "SpinEdit20"
        Me.SpinEdit20.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit20.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit20.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit20.TabIndex = 13
        '
        'SpinEdit19
        '
        Me.SpinEdit19.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit19.Location = New System.Drawing.Point(358, 180)
        Me.SpinEdit19.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit19.MenuManager = Me.BarManager1
        Me.SpinEdit19.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit19.Name = "SpinEdit19"
        Me.SpinEdit19.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit19.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit19.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit19.TabIndex = 12
        '
        'SpinEdit18
        '
        Me.SpinEdit18.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit18.Location = New System.Drawing.Point(149, 228)
        Me.SpinEdit18.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit18.MenuManager = Me.BarManager1
        Me.SpinEdit18.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit18.Name = "SpinEdit18"
        Me.SpinEdit18.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit18.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit18.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit18.TabIndex = 11
        '
        'SpinEdit17
        '
        Me.SpinEdit17.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit17.Location = New System.Drawing.Point(149, 204)
        Me.SpinEdit17.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit17.MenuManager = Me.BarManager1
        Me.SpinEdit17.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit17.Name = "SpinEdit17"
        Me.SpinEdit17.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit17.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit17.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit17.TabIndex = 10
        '
        'SpinEdit16
        '
        Me.SpinEdit16.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit16.Location = New System.Drawing.Point(149, 180)
        Me.SpinEdit16.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit16.MenuManager = Me.BarManager1
        Me.SpinEdit16.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit16.Name = "SpinEdit16"
        Me.SpinEdit16.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit16.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit16.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit16.TabIndex = 9
        '
        'SpinEdit15
        '
        Me.SpinEdit15.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit15.Location = New System.Drawing.Point(149, 156)
        Me.SpinEdit15.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit15.MenuManager = Me.BarManager1
        Me.SpinEdit15.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit15.Name = "SpinEdit15"
        Me.SpinEdit15.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit15.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit15.StyleController = Me.lycH_Ingenieria
        Me.SpinEdit15.TabIndex = 8
        '
        'slueH_DeptoEnsamble
        '
        Me.slueH_DeptoEnsamble.Location = New System.Drawing.Point(592, 42)
        Me.slueH_DeptoEnsamble.MaximumSize = New System.Drawing.Size(80, 0)
        Me.slueH_DeptoEnsamble.MenuManager = Me.BarManager1
        Me.slueH_DeptoEnsamble.MinimumSize = New System.Drawing.Size(80, 0)
        Me.slueH_DeptoEnsamble.Name = "slueH_DeptoEnsamble"
        Me.slueH_DeptoEnsamble.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueH_DeptoEnsamble.Properties.NullText = ""
        Me.slueH_DeptoEnsamble.Properties.View = Me.GridView6
        Me.slueH_DeptoEnsamble.Size = New System.Drawing.Size(80, 20)
        Me.slueH_DeptoEnsamble.StyleController = Me.lycH_Ingenieria
        Me.slueH_DeptoEnsamble.TabIndex = 7
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'slueH_MaterialEmpaqueVenta
        '
        Me.slueH_MaterialEmpaqueVenta.Location = New System.Drawing.Point(149, 132)
        Me.slueH_MaterialEmpaqueVenta.MenuManager = Me.BarManager1
        Me.slueH_MaterialEmpaqueVenta.Name = "slueH_MaterialEmpaqueVenta"
        Me.slueH_MaterialEmpaqueVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueH_MaterialEmpaqueVenta.Properties.NullText = ""
        Me.slueH_MaterialEmpaqueVenta.Properties.View = Me.GridView5
        Me.slueH_MaterialEmpaqueVenta.Size = New System.Drawing.Size(290, 20)
        Me.slueH_MaterialEmpaqueVenta.StyleController = Me.lycH_Ingenieria
        Me.slueH_MaterialEmpaqueVenta.TabIndex = 6
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'txtH_Capacidad
        '
        Me.txtH_Capacidad.Location = New System.Drawing.Point(149, 66)
        Me.txtH_Capacidad.MaximumSize = New System.Drawing.Size(80, 0)
        Me.txtH_Capacidad.MenuManager = Me.BarManager1
        Me.txtH_Capacidad.MinimumSize = New System.Drawing.Size(80, 0)
        Me.txtH_Capacidad.Name = "txtH_Capacidad"
        Me.txtH_Capacidad.Size = New System.Drawing.Size(80, 20)
        Me.txtH_Capacidad.StyleController = Me.lycH_Ingenieria
        Me.txtH_Capacidad.TabIndex = 5
        '
        'txtH_Material
        '
        Me.txtH_Material.Location = New System.Drawing.Point(149, 42)
        Me.txtH_Material.MaximumSize = New System.Drawing.Size(290, 20)
        Me.txtH_Material.MenuManager = Me.BarManager1
        Me.txtH_Material.MinimumSize = New System.Drawing.Size(290, 20)
        Me.txtH_Material.Name = "txtH_Material"
        Me.txtH_Material.Size = New System.Drawing.Size(290, 20)
        Me.txtH_Material.StyleController = Me.lycH_Ingenieria
        Me.txtH_Material.TabIndex = 4
        '
        'LayoutControlGroup21
        '
        Me.LayoutControlGroup21.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup21.GroupBordersVisible = False
        Me.LayoutControlGroup21.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycH_Ingenieria1, Me.lycgH_EmpaqueVenta, Me.LayoutControlGroup22, Me.EmptySpaceItem30, Me.LayoutControlGroup23, Me.LayoutControlItem108, Me.EmptySpaceItem35})
        Me.LayoutControlGroup21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup21.Name = "LayoutControlGroup21"
        Me.LayoutControlGroup21.Size = New System.Drawing.Size(734, 478)
        Me.LayoutControlGroup21.TextVisible = False
        '
        'lycH_Ingenieria1
        '
        Me.lycH_Ingenieria1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem90, Me.LayoutControlItem89})
        Me.lycH_Ingenieria1.Location = New System.Drawing.Point(0, 0)
        Me.lycH_Ingenieria1.Name = "lycH_Ingenieria1"
        Me.lycH_Ingenieria1.Size = New System.Drawing.Size(443, 90)
        Me.lycH_Ingenieria1.Text = "Medidas del Articulo"
        '
        'LayoutControlItem90
        '
        Me.LayoutControlItem90.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem90.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem90.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem90.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem90.Control = Me.txtH_Capacidad
        Me.LayoutControlItem90.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem90.Name = "LayoutControlItem90"
        Me.LayoutControlItem90.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem90.Text = "Capacidad (lt,oz,etc)"
        Me.LayoutControlItem90.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem89
        '
        Me.LayoutControlItem89.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem89.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem89.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem89.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem89.Control = Me.txtH_Material
        Me.LayoutControlItem89.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem89.Name = "LayoutControlItem89"
        Me.LayoutControlItem89.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem89.Text = "Medidas (cm)"
        Me.LayoutControlItem89.TextSize = New System.Drawing.Size(122, 13)
        '
        'lycgH_EmpaqueVenta
        '
        Me.lycgH_EmpaqueVenta.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem91, Me.LayoutControlItem94, Me.LayoutControlItem95, Me.LayoutControlItem96, Me.LayoutControlItem93, Me.LayoutControlItem97, Me.EmptySpaceItem31, Me.LayoutControlItem98, Me.EmptySpaceItem32})
        Me.lycgH_EmpaqueVenta.Location = New System.Drawing.Point(0, 90)
        Me.lycgH_EmpaqueVenta.Name = "lycgH_EmpaqueVenta"
        Me.lycgH_EmpaqueVenta.Size = New System.Drawing.Size(443, 162)
        Me.lycgH_EmpaqueVenta.Text = "Empaque estandar de venta"
        '
        'LayoutControlItem91
        '
        Me.LayoutControlItem91.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem91.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem91.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem91.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem91.Control = Me.slueH_MaterialEmpaqueVenta
        Me.LayoutControlItem91.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem91.Name = "LayoutControlItem91"
        Me.LayoutControlItem91.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem91.Text = "Material"
        Me.LayoutControlItem91.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem94
        '
        Me.LayoutControlItem94.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem94.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem94.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem94.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem94.Control = Me.SpinEdit16
        Me.LayoutControlItem94.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem94.Name = "LayoutControlItem94"
        Me.LayoutControlItem94.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem94.Text = "A - Peso (kg)"
        Me.LayoutControlItem94.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem95
        '
        Me.LayoutControlItem95.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem95.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem95.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem95.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem95.Control = Me.SpinEdit17
        Me.LayoutControlItem95.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem95.Name = "LayoutControlItem95"
        Me.LayoutControlItem95.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem95.Text = "C - Largo (cm)"
        Me.LayoutControlItem95.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem96
        '
        Me.LayoutControlItem96.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem96.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem96.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem96.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem96.Control = Me.SpinEdit18
        Me.LayoutControlItem96.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem96.Name = "LayoutControlItem96"
        Me.LayoutControlItem96.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem96.Text = "E - Alto (cm)"
        Me.LayoutControlItem96.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem93
        '
        Me.LayoutControlItem93.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem93.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem93.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem93.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem93.Control = Me.SpinEdit15
        Me.LayoutControlItem93.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem93.Name = "LayoutControlItem93"
        Me.LayoutControlItem93.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem93.Text = "Unidades por Bulto"
        Me.LayoutControlItem93.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem97
        '
        Me.LayoutControlItem97.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem97.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem97.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem97.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem97.Control = Me.SpinEdit19
        Me.LayoutControlItem97.Location = New System.Drawing.Point(209, 48)
        Me.LayoutControlItem97.Name = "LayoutControlItem97"
        Me.LayoutControlItem97.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem97.Text = "B - Volumen (Lt)"
        Me.LayoutControlItem97.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem31
        '
        Me.EmptySpaceItem31.AllowHotTrack = False
        Me.EmptySpaceItem31.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem31.Name = "EmptySpaceItem31"
        Me.EmptySpaceItem31.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem31.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem98
        '
        Me.LayoutControlItem98.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem98.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem98.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem98.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem98.Control = Me.SpinEdit20
        Me.LayoutControlItem98.Location = New System.Drawing.Point(209, 72)
        Me.LayoutControlItem98.Name = "LayoutControlItem98"
        Me.LayoutControlItem98.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem98.Text = "D - Ancho (cm)"
        Me.LayoutControlItem98.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem32
        '
        Me.EmptySpaceItem32.AllowHotTrack = False
        Me.EmptySpaceItem32.Location = New System.Drawing.Point(209, 96)
        Me.EmptySpaceItem32.Name = "EmptySpaceItem32"
        Me.EmptySpaceItem32.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem32.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup22
        '
        Me.LayoutControlGroup22.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem100, Me.EmptySpaceItem33, Me.LayoutControlItem104, Me.LayoutControlItem101, Me.LayoutControlItem102, Me.LayoutControlItem105, Me.EmptySpaceItem34, Me.LayoutControlItem103, Me.LayoutControlItem99})
        Me.LayoutControlGroup22.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlGroup22.Name = "LayoutControlGroup22"
        Me.LayoutControlGroup22.Size = New System.Drawing.Size(443, 162)
        Me.LayoutControlGroup22.Text = "Empaque Master de Venta"
        '
        'LayoutControlItem100
        '
        Me.LayoutControlItem100.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem100.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem100.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem100.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem100.Control = Me.SpinEdit21
        Me.LayoutControlItem100.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem100.Name = "LayoutControlItem100"
        Me.LayoutControlItem100.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem100.Text = "Unidades por bulto"
        Me.LayoutControlItem100.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem33
        '
        Me.EmptySpaceItem33.AllowHotTrack = False
        Me.EmptySpaceItem33.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem33.Name = "EmptySpaceItem33"
        Me.EmptySpaceItem33.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem33.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem104
        '
        Me.LayoutControlItem104.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem104.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem104.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem104.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem104.Control = Me.SpinEdit25
        Me.LayoutControlItem104.Location = New System.Drawing.Point(209, 48)
        Me.LayoutControlItem104.Name = "LayoutControlItem104"
        Me.LayoutControlItem104.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem104.Text = "B - Volumen (Lt)"
        Me.LayoutControlItem104.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem101
        '
        Me.LayoutControlItem101.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem101.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem101.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem101.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem101.Control = Me.SpinEdit22
        Me.LayoutControlItem101.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem101.Name = "LayoutControlItem101"
        Me.LayoutControlItem101.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem101.Text = "A - Peso (kg)"
        Me.LayoutControlItem101.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem102
        '
        Me.LayoutControlItem102.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem102.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem102.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem102.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem102.Control = Me.SpinEdit23
        Me.LayoutControlItem102.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem102.Name = "LayoutControlItem102"
        Me.LayoutControlItem102.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem102.Text = "C - Largo (cm)"
        Me.LayoutControlItem102.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem105
        '
        Me.LayoutControlItem105.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem105.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem105.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem105.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem105.Control = Me.SpinEdit26
        Me.LayoutControlItem105.Location = New System.Drawing.Point(209, 72)
        Me.LayoutControlItem105.Name = "LayoutControlItem105"
        Me.LayoutControlItem105.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem105.Text = "D - Ancho (cm)"
        Me.LayoutControlItem105.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem34
        '
        Me.EmptySpaceItem34.AllowHotTrack = False
        Me.EmptySpaceItem34.Location = New System.Drawing.Point(209, 96)
        Me.EmptySpaceItem34.Name = "EmptySpaceItem34"
        Me.EmptySpaceItem34.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem34.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem103
        '
        Me.LayoutControlItem103.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem103.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem103.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem103.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem103.Control = Me.SpinEdit24
        Me.LayoutControlItem103.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem103.Name = "LayoutControlItem103"
        Me.LayoutControlItem103.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem103.Text = "E - Alto (cm)"
        Me.LayoutControlItem103.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem99
        '
        Me.LayoutControlItem99.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem99.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem99.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem99.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem99.Control = Me.SearchLookUpEdit2
        Me.LayoutControlItem99.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem99.Name = "LayoutControlItem99"
        Me.LayoutControlItem99.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem99.Text = "Material"
        Me.LayoutControlItem99.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem30
        '
        Me.EmptySpaceItem30.AllowHotTrack = False
        Me.EmptySpaceItem30.Location = New System.Drawing.Point(676, 0)
        Me.EmptySpaceItem30.Name = "EmptySpaceItem30"
        Me.EmptySpaceItem30.Size = New System.Drawing.Size(38, 414)
        Me.EmptySpaceItem30.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup23
        '
        Me.LayoutControlGroup23.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem107, Me.LayoutControlItem106, Me.LayoutControlItem92})
        Me.LayoutControlGroup23.Location = New System.Drawing.Point(443, 0)
        Me.LayoutControlGroup23.Name = "LayoutControlGroup23"
        Me.LayoutControlGroup23.Size = New System.Drawing.Size(233, 414)
        Me.LayoutControlGroup23.Text = "Datos de ensamble"
        '
        'LayoutControlItem107
        '
        Me.LayoutControlItem107.Control = Me.spinH_ArticulosXHora
        Me.LayoutControlItem107.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem107.Name = "LayoutControlItem107"
        Me.LayoutControlItem107.Size = New System.Drawing.Size(209, 324)
        Me.LayoutControlItem107.Text = "Articulos X Hora [Min]"
        Me.LayoutControlItem107.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem106
        '
        Me.LayoutControlItem106.Control = Me.spinH_EnsambleEquipo
        Me.LayoutControlItem106.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem106.Name = "LayoutControlItem106"
        Me.LayoutControlItem106.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem106.Text = "Equipo Minimo [Personas]"
        Me.LayoutControlItem106.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem92
        '
        Me.LayoutControlItem92.Control = Me.slueH_DeptoEnsamble
        Me.LayoutControlItem92.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem92.Name = "LayoutControlItem92"
        Me.LayoutControlItem92.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem92.Text = "Departamento Ensamble"
        Me.LayoutControlItem92.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem108
        '
        Me.LayoutControlItem108.Control = Me.btnH_Ingenieria_Grabar
        Me.LayoutControlItem108.Location = New System.Drawing.Point(0, 414)
        Me.LayoutControlItem108.Name = "LayoutControlItem108"
        Me.LayoutControlItem108.Size = New System.Drawing.Size(140, 44)
        Me.LayoutControlItem108.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem108.TextVisible = False
        '
        'EmptySpaceItem35
        '
        Me.EmptySpaceItem35.AllowHotTrack = False
        Me.EmptySpaceItem35.Location = New System.Drawing.Point(140, 414)
        Me.EmptySpaceItem35.Name = "EmptySpaceItem35"
        Me.EmptySpaceItem35.Size = New System.Drawing.Size(574, 44)
        Me.EmptySpaceItem35.TextSize = New System.Drawing.Size(0, 0)
        '
        'xtpH_Ventas
        '
        Me.xtpH_Ventas.Controls.Add(Me.lycH_Ventas)
        Me.xtpH_Ventas.Image = Global.waProduccion_Pedidos.My.Resources.Resources.bosale_16x16
        Me.xtpH_Ventas.Name = "xtpH_Ventas"
        Me.xtpH_Ventas.Size = New System.Drawing.Size(734, 478)
        Me.xtpH_Ventas.Text = "Ventas"
        '
        'lycH_Ventas
        '
        Me.lycH_Ventas.Controls.Add(Me.spinH_EmpaqueVenta)
        Me.lycH_Ventas.Controls.Add(Me.spinH_EmpaqueEstandar)
        Me.lycH_Ventas.Controls.Add(Me.spinH_PrecioMayorista)
        Me.lycH_Ventas.Controls.Add(Me.spinH_Unidades)
        Me.lycH_Ventas.Controls.Add(Me.spinH_Contenido)
        Me.lycH_Ventas.Controls.Add(Me.rdgH_EnCatalogo)
        Me.lycH_Ventas.Controls.Add(Me.slueH_GrupoArticulos)
        Me.lycH_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycH_Ventas.Location = New System.Drawing.Point(0, 0)
        Me.lycH_Ventas.Name = "lycH_Ventas"
        Me.lycH_Ventas.Root = Me.LayoutControlGroup20
        Me.lycH_Ventas.Size = New System.Drawing.Size(734, 478)
        Me.lycH_Ventas.TabIndex = 0
        Me.lycH_Ventas.Text = "LayoutControl1"
        '
        'spinH_EmpaqueVenta
        '
        Me.spinH_EmpaqueVenta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_EmpaqueVenta.Location = New System.Drawing.Point(121, 167)
        Me.spinH_EmpaqueVenta.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueVenta.MenuManager = Me.BarManager1
        Me.spinH_EmpaqueVenta.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueVenta.Name = "spinH_EmpaqueVenta"
        Me.spinH_EmpaqueVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_EmpaqueVenta.Properties.Mask.EditMask = "n0"
        Me.spinH_EmpaqueVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinH_EmpaqueVenta.Size = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueVenta.StyleController = Me.lycH_Ventas
        Me.spinH_EmpaqueVenta.TabIndex = 10
        '
        'spinH_EmpaqueEstandar
        '
        Me.spinH_EmpaqueEstandar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_EmpaqueEstandar.Location = New System.Drawing.Point(121, 143)
        Me.spinH_EmpaqueEstandar.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueEstandar.MenuManager = Me.BarManager1
        Me.spinH_EmpaqueEstandar.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueEstandar.Name = "spinH_EmpaqueEstandar"
        Me.spinH_EmpaqueEstandar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_EmpaqueEstandar.Properties.Mask.EditMask = "n0"
        Me.spinH_EmpaqueEstandar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinH_EmpaqueEstandar.Size = New System.Drawing.Size(100, 20)
        Me.spinH_EmpaqueEstandar.StyleController = Me.lycH_Ventas
        Me.spinH_EmpaqueEstandar.TabIndex = 9
        '
        'spinH_PrecioMayorista
        '
        Me.spinH_PrecioMayorista.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_PrecioMayorista.Location = New System.Drawing.Point(121, 119)
        Me.spinH_PrecioMayorista.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinH_PrecioMayorista.MenuManager = Me.BarManager1
        Me.spinH_PrecioMayorista.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinH_PrecioMayorista.Name = "spinH_PrecioMayorista"
        Me.spinH_PrecioMayorista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_PrecioMayorista.Properties.Mask.EditMask = "n2"
        Me.spinH_PrecioMayorista.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinH_PrecioMayorista.Size = New System.Drawing.Size(100, 20)
        Me.spinH_PrecioMayorista.StyleController = Me.lycH_Ventas
        Me.spinH_PrecioMayorista.TabIndex = 8
        '
        'spinH_Unidades
        '
        Me.spinH_Unidades.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_Unidades.Location = New System.Drawing.Point(121, 95)
        Me.spinH_Unidades.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinH_Unidades.MenuManager = Me.BarManager1
        Me.spinH_Unidades.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinH_Unidades.Name = "spinH_Unidades"
        Me.spinH_Unidades.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_Unidades.Properties.Mask.EditMask = "n0"
        Me.spinH_Unidades.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinH_Unidades.Size = New System.Drawing.Size(100, 20)
        Me.spinH_Unidades.StyleController = Me.lycH_Ventas
        Me.spinH_Unidades.TabIndex = 7
        '
        'spinH_Contenido
        '
        Me.spinH_Contenido.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinH_Contenido.Location = New System.Drawing.Point(121, 71)
        Me.spinH_Contenido.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinH_Contenido.MenuManager = Me.BarManager1
        Me.spinH_Contenido.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinH_Contenido.Name = "spinH_Contenido"
        Me.spinH_Contenido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinH_Contenido.Properties.Mask.EditMask = "n0"
        Me.spinH_Contenido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinH_Contenido.Size = New System.Drawing.Size(100, 20)
        Me.spinH_Contenido.StyleController = Me.lycH_Ventas
        Me.spinH_Contenido.TabIndex = 6
        '
        'rdgH_EnCatalogo
        '
        Me.rdgH_EnCatalogo.Location = New System.Drawing.Point(121, 36)
        Me.rdgH_EnCatalogo.MenuManager = Me.BarManager1
        Me.rdgH_EnCatalogo.Name = "rdgH_EnCatalogo"
        Me.rdgH_EnCatalogo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No")})
        Me.rdgH_EnCatalogo.Size = New System.Drawing.Size(100, 31)
        Me.rdgH_EnCatalogo.StyleController = Me.lycH_Ventas
        Me.rdgH_EnCatalogo.TabIndex = 5
        '
        'slueH_GrupoArticulos
        '
        Me.slueH_GrupoArticulos.Location = New System.Drawing.Point(121, 12)
        Me.slueH_GrupoArticulos.MaximumSize = New System.Drawing.Size(250, 0)
        Me.slueH_GrupoArticulos.MenuManager = Me.BarManager1
        Me.slueH_GrupoArticulos.MinimumSize = New System.Drawing.Size(250, 0)
        Me.slueH_GrupoArticulos.Name = "slueH_GrupoArticulos"
        Me.slueH_GrupoArticulos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueH_GrupoArticulos.Properties.NullText = ""
        Me.slueH_GrupoArticulos.Properties.View = Me.GridView4
        Me.slueH_GrupoArticulos.Size = New System.Drawing.Size(250, 20)
        Me.slueH_GrupoArticulos.StyleController = Me.lycH_Ventas
        Me.slueH_GrupoArticulos.TabIndex = 4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup20
        '
        Me.LayoutControlGroup20.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup20.GroupBordersVisible = False
        Me.LayoutControlGroup20.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem9, Me.LayoutControlItem83, Me.LayoutControlItem84, Me.LayoutControlItem85, Me.LayoutControlItem86, Me.LayoutControlItem87, Me.LayoutControlItem88, Me.EmptySpaceItem29, Me.EmptySpaceItem26, Me.LayoutControlItem8})
        Me.LayoutControlGroup20.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup20.Name = "LayoutControlGroup20"
        Me.LayoutControlGroup20.Size = New System.Drawing.Size(734, 478)
        Me.LayoutControlGroup20.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 179)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(363, 279)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem83
        '
        Me.LayoutControlItem83.Control = Me.rdgH_EnCatalogo
        Me.LayoutControlItem83.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem83.Name = "LayoutControlItem83"
        Me.LayoutControlItem83.Size = New System.Drawing.Size(213, 35)
        Me.LayoutControlItem83.Text = "Aparece en Catalogo?"
        Me.LayoutControlItem83.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem84
        '
        Me.LayoutControlItem84.Control = Me.spinH_Contenido
        Me.LayoutControlItem84.Location = New System.Drawing.Point(0, 59)
        Me.LayoutControlItem84.Name = "LayoutControlItem84"
        Me.LayoutControlItem84.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem84.Text = "Contenido"
        Me.LayoutControlItem84.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem85
        '
        Me.LayoutControlItem85.Control = Me.spinH_Unidades
        Me.LayoutControlItem85.Location = New System.Drawing.Point(0, 83)
        Me.LayoutControlItem85.Name = "LayoutControlItem85"
        Me.LayoutControlItem85.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem85.Text = "Unidades / Piezas"
        Me.LayoutControlItem85.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem86
        '
        Me.LayoutControlItem86.Control = Me.spinH_PrecioMayorista
        Me.LayoutControlItem86.Location = New System.Drawing.Point(0, 107)
        Me.LayoutControlItem86.Name = "LayoutControlItem86"
        Me.LayoutControlItem86.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem86.Text = "Precio Mayorista"
        Me.LayoutControlItem86.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem87
        '
        Me.LayoutControlItem87.Control = Me.spinH_EmpaqueEstandar
        Me.LayoutControlItem87.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlItem87.Name = "LayoutControlItem87"
        Me.LayoutControlItem87.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem87.Text = "Empaque Estandar"
        Me.LayoutControlItem87.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem88
        '
        Me.LayoutControlItem88.Control = Me.spinH_EmpaqueVenta
        Me.LayoutControlItem88.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem88.Name = "LayoutControlItem88"
        Me.LayoutControlItem88.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem88.Text = "Empaque de venta"
        Me.LayoutControlItem88.TextSize = New System.Drawing.Size(106, 13)
        '
        'EmptySpaceItem29
        '
        Me.EmptySpaceItem29.AllowHotTrack = False
        Me.EmptySpaceItem29.Location = New System.Drawing.Point(363, 0)
        Me.EmptySpaceItem29.Name = "EmptySpaceItem29"
        Me.EmptySpaceItem29.Size = New System.Drawing.Size(351, 458)
        Me.EmptySpaceItem29.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem26
        '
        Me.EmptySpaceItem26.AllowHotTrack = False
        Me.EmptySpaceItem26.Location = New System.Drawing.Point(213, 24)
        Me.EmptySpaceItem26.Name = "EmptySpaceItem26"
        Me.EmptySpaceItem26.Size = New System.Drawing.Size(150, 155)
        Me.EmptySpaceItem26.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.slueH_GrupoArticulos
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem8.Text = "Grupo Articulos"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(106, 13)
        '
        'xtpH_Auditoria
        '
        Me.xtpH_Auditoria.Image = Global.waProduccion_Pedidos.My.Resources.Resources.edittask_16x16
        Me.xtpH_Auditoria.Name = "xtpH_Auditoria"
        Me.xtpH_Auditoria.Size = New System.Drawing.Size(734, 478)
        Me.xtpH_Auditoria.Text = "Auditoria"
        '
        'xtpH_Contabilidad
        '
        Me.xtpH_Contabilidad.Image = Global.waProduccion_Pedidos.My.Resources.Resources.formatnumbercurrency_16x16
        Me.xtpH_Contabilidad.Name = "xtpH_Contabilidad"
        Me.xtpH_Contabilidad.Size = New System.Drawing.Size(734, 478)
        Me.xtpH_Contabilidad.Text = "Contabilidad"
        '
        'xtpH_ListaMateriales
        '
        Me.xtpH_ListaMateriales.Controls.Add(Me.lycListaMateriales)
        Me.xtpH_ListaMateriales.Image = CType(resources.GetObject("xtpH_ListaMateriales.Image"), System.Drawing.Image)
        Me.xtpH_ListaMateriales.Name = "xtpH_ListaMateriales"
        Me.xtpH_ListaMateriales.Size = New System.Drawing.Size(734, 478)
        Me.xtpH_ListaMateriales.Text = "Lista Materiales"
        '
        'lycListaMateriales
        '
        Me.lycListaMateriales.Controls.Add(Me.sbdcListaMateriales)
        Me.lycListaMateriales.Controls.Add(Me.grdListaMaterialesHijos)
        Me.lycListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListaMateriales.Location = New System.Drawing.Point(0, 0)
        Me.lycListaMateriales.Name = "lycListaMateriales"
        Me.lycListaMateriales.Root = Me.LayoutControlGroup4
        Me.lycListaMateriales.Size = New System.Drawing.Size(734, 478)
        Me.lycListaMateriales.TabIndex = 0
        Me.lycListaMateriales.Text = "LayoutControl1"
        '
        'grdListaMaterialesHijos
        '
        Me.grdListaMaterialesHijos.DataMember = "dsdtListaMateriales"
        Me.grdListaMaterialesHijos.DataSource = Me.DsMantenimientoArticulos1
        Me.grdListaMaterialesHijos.Location = New System.Drawing.Point(12, 12)
        Me.grdListaMaterialesHijos.MainView = Me.grdviewListaMaterialesHijos
        Me.grdListaMaterialesHijos.MenuManager = Me.BarManager1
        Me.grdListaMaterialesHijos.Name = "grdListaMaterialesHijos"
        Me.grdListaMaterialesHijos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueCodigoArticulo, Me.rspinCantidad, Me.rslueBodega})
        Me.grdListaMaterialesHijos.Size = New System.Drawing.Size(710, 419)
        Me.grdListaMaterialesHijos.TabIndex = 7
        Me.grdListaMaterialesHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaMaterialesHijos})
        '
        'DsMantenimientoArticulos1
        '
        Me.DsMantenimientoArticulos1.DataSetName = "dsMantenimientoArticulos"
        Me.DsMantenimientoArticulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaMaterialesHijos
        '
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaMaterialesHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaMaterialesHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewListaMaterialesHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewListaMaterialesHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaMaterialesHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPadre, Me.colNumLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCantidad, Me.colBodega})
        Me.grdviewListaMaterialesHijos.GridControl = Me.grdListaMaterialesHijos
        Me.grdviewListaMaterialesHijos.Name = "grdviewListaMaterialesHijos"
        Me.grdviewListaMaterialesHijos.OptionsSelection.MultiSelect = True
        Me.grdviewListaMaterialesHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaMaterialesHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaMaterialesHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaMaterialesHijos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewListaMaterialesHijos.OptionsView.ShowFooter = True
        Me.grdviewListaMaterialesHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewListaMaterialesHijos.OptionsView.ShowViewCaption = True
        Me.grdviewListaMaterialesHijos.PaintStyleName = "Office2003"
        Me.grdviewListaMaterialesHijos.ViewCaption = "Lista Materiales (Hijos)"
        '
        'colPadre
        '
        Me.colPadre.ColumnEdit = Me.rslueBodega
        Me.colPadre.FieldName = "Padre"
        Me.colPadre.Name = "colPadre"
        '
        'rslueBodega
        '
        Me.rslueBodega.AutoHeight = False
        Me.rslueBodega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueBodega.Name = "rslueBodega"
        Me.rslueBodega.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colNumLinea
        '
        Me.colNumLinea.FieldName = "NumLinea"
        Me.colNumLinea.Name = "colNumLinea"
        Me.colNumLinea.Width = 30
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.ColumnEdit = Me.rslueCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 125
        '
        'rslueCodigoArticulo
        '
        Me.rslueCodigoArticulo.AutoHeight = False
        Me.rslueCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoArticulo.Name = "rslueCodigoArticulo"
        Me.rslueCodigoArticulo.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 300
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.ColumnEdit = Me.rspinCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 80
        '
        'rspinCantidad
        '
        Me.rspinCantidad.AutoHeight = False
        Me.rspinCantidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinCantidad.DisplayFormat.FormatString = "{0:n6}"
        Me.rspinCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinCantidad.EditFormat.FormatString = "{0:n6}"
        Me.rspinCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinCantidad.Name = "rspinCantidad"
        '
        'colBodega
        '
        Me.colBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.ColumnEdit = Me.rslueBodega
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 3
        Me.colBodega.Width = 110
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem81})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(734, 478)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.grdListaMaterialesHijos
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(714, 423)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem81
        '
        Me.LayoutControlItem81.Control = Me.sbdcListaMateriales
        Me.LayoutControlItem81.CustomizationFormText = "LayoutControlItem81"
        Me.LayoutControlItem81.Location = New System.Drawing.Point(0, 423)
        Me.LayoutControlItem81.Name = "LayoutControlItem81"
        Me.LayoutControlItem81.Size = New System.Drawing.Size(714, 35)
        Me.LayoutControlItem81.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem81.TextVisible = False
        '
        'xtpHijosAlmacen
        '
        Me.xtpHijosAlmacen.Controls.Add(Me.lycAlmacenHijos)
        Me.xtpHijosAlmacen.Image = CType(resources.GetObject("xtpHijosAlmacen.Image"), System.Drawing.Image)
        Me.xtpHijosAlmacen.Name = "xtpHijosAlmacen"
        Me.xtpHijosAlmacen.Size = New System.Drawing.Size(734, 478)
        Me.xtpHijosAlmacen.Text = "Almacen"
        '
        'lycAlmacenHijos
        '
        Me.lycAlmacenHijos.Controls.Add(Me.sbdcAlmacen)
        Me.lycAlmacenHijos.Controls.Add(Me.txtStockMaximo)
        Me.lycAlmacenHijos.Controls.Add(Me.txtLocalizacionDel)
        Me.lycAlmacenHijos.Controls.Add(Me.txtStockMinimo)
        Me.lycAlmacenHijos.Controls.Add(Me.txtUPC)
        Me.lycAlmacenHijos.Controls.Add(Me.bccCodigoBarras)
        Me.lycAlmacenHijos.Controls.Add(Me.txtCodigoBarras)
        Me.lycAlmacenHijos.Controls.Add(Me.txtDUN14)
        Me.lycAlmacenHijos.Controls.Add(Me.bccDUN14)
        Me.lycAlmacenHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAlmacenHijos.Location = New System.Drawing.Point(0, 0)
        Me.lycAlmacenHijos.Name = "lycAlmacenHijos"
        Me.lycAlmacenHijos.Root = Me.LayoutControlGroup5
        Me.lycAlmacenHijos.Size = New System.Drawing.Size(734, 478)
        Me.lycAlmacenHijos.TabIndex = 0
        Me.lycAlmacenHijos.Text = "LayoutControl1"
        '
        'txtStockMaximo
        '
        Me.txtStockMaximo.Location = New System.Drawing.Point(635, 66)
        Me.txtStockMaximo.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtStockMaximo.MenuManager = Me.BarManager1
        Me.txtStockMaximo.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtStockMaximo.Name = "txtStockMaximo"
        Me.txtStockMaximo.Size = New System.Drawing.Size(75, 20)
        Me.txtStockMaximo.StyleController = Me.lycAlmacenHijos
        Me.txtStockMaximo.TabIndex = 17
        '
        'txtLocalizacionDel
        '
        Me.txtLocalizacionDel.Location = New System.Drawing.Point(635, 90)
        Me.txtLocalizacionDel.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtLocalizacionDel.MenuManager = Me.BarManager1
        Me.txtLocalizacionDel.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtLocalizacionDel.Name = "txtLocalizacionDel"
        Me.txtLocalizacionDel.Size = New System.Drawing.Size(75, 20)
        Me.txtLocalizacionDel.StyleController = Me.lycAlmacenHijos
        Me.txtLocalizacionDel.TabIndex = 16
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.Location = New System.Drawing.Point(635, 42)
        Me.txtStockMinimo.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtStockMinimo.MenuManager = Me.BarManager1
        Me.txtStockMinimo.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(75, 20)
        Me.txtStockMinimo.StyleController = Me.lycAlmacenHijos
        Me.txtStockMinimo.TabIndex = 15
        '
        'txtUPC
        '
        Me.txtUPC.Location = New System.Drawing.Point(122, 42)
        Me.txtUPC.MaximumSize = New System.Drawing.Size(200, 20)
        Me.txtUPC.MenuManager = Me.BarManager1
        Me.txtUPC.MinimumSize = New System.Drawing.Size(200, 20)
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Size = New System.Drawing.Size(200, 20)
        Me.txtUPC.StyleController = Me.lycAlmacenHijos
        Me.txtUPC.TabIndex = 4
        '
        'bccCodigoBarras
        '
        Me.bccCodigoBarras.AutoModule = True
        Me.bccCodigoBarras.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccCodigoBarras.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccCodigoBarras.Location = New System.Drawing.Point(24, 90)
        Me.bccCodigoBarras.MaximumSize = New System.Drawing.Size(0, 70)
        Me.bccCodigoBarras.MinimumSize = New System.Drawing.Size(0, 70)
        Me.bccCodigoBarras.Name = "bccCodigoBarras"
        Me.bccCodigoBarras.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.bccCodigoBarras.Size = New System.Drawing.Size(298, 70)
        Me.bccCodigoBarras.StyleController = Me.lycAlmacenHijos
        Me.bccCodigoBarras.Symbology = UpcaGenerator1
        Me.bccCodigoBarras.TabIndex = 12
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(122, 66)
        Me.txtCodigoBarras.MaximumSize = New System.Drawing.Size(200, 20)
        Me.txtCodigoBarras.MenuManager = Me.BarManager1
        Me.txtCodigoBarras.MinimumSize = New System.Drawing.Size(200, 20)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(200, 20)
        Me.txtCodigoBarras.StyleController = Me.lycAlmacenHijos
        Me.txtCodigoBarras.TabIndex = 5
        '
        'txtDUN14
        '
        Me.txtDUN14.Location = New System.Drawing.Point(122, 164)
        Me.txtDUN14.MaximumSize = New System.Drawing.Size(200, 20)
        Me.txtDUN14.MenuManager = Me.BarManager1
        Me.txtDUN14.MinimumSize = New System.Drawing.Size(200, 20)
        Me.txtDUN14.Name = "txtDUN14"
        Me.txtDUN14.Size = New System.Drawing.Size(200, 20)
        Me.txtDUN14.StyleController = Me.lycAlmacenHijos
        Me.txtDUN14.TabIndex = 6
        '
        'bccDUN14
        '
        Me.bccDUN14.AutoModule = True
        Me.bccDUN14.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccDUN14.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccDUN14.Location = New System.Drawing.Point(24, 188)
        Me.bccDUN14.MaximumSize = New System.Drawing.Size(0, 70)
        Me.bccDUN14.MinimumSize = New System.Drawing.Size(0, 70)
        Me.bccDUN14.Name = "bccDUN14"
        Me.bccDUN14.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.bccDUN14.Size = New System.Drawing.Size(298, 70)
        Me.bccDUN14.StyleController = Me.lycAlmacenHijos
        Me.bccDUN14.Symbology = Code128Generator1
        Me.bccDUN14.TabIndex = 14
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup5"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup7, Me.EmptySpaceItem25, Me.EmptySpaceItem5, Me.LayoutControlItem35, Me.LayoutControlGroup6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(734, 478)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "Codigos"
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem10, Me.LayoutControlItem5, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(326, 262)
        Me.LayoutControlGroup7.Text = "Codigos"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem11.Control = Me.txtDUN14
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem11.Text = "DUN14"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtCodigoBarras
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem10.Text = "Codigo Barras"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtUPC
        Me.LayoutControlItem5.CustomizationFormText = "UPC"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem5.Text = "UPC"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bccCodigoBarras
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(302, 74)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.bccDUN14
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 146)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(302, 74)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem25
        '
        Me.EmptySpaceItem25.AllowHotTrack = False
        Me.EmptySpaceItem25.CustomizationFormText = "EmptySpaceItem25"
        Me.EmptySpaceItem25.Location = New System.Drawing.Point(0, 262)
        Me.EmptySpaceItem25.Name = "EmptySpaceItem25"
        Me.EmptySpaceItem25.Size = New System.Drawing.Size(714, 161)
        Me.EmptySpaceItem25.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(326, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(187, 262)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.sbdcAlmacen
        Me.LayoutControlItem35.CustomizationFormText = "LayoutControlItem35"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 423)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(714, 35)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem21, Me.LayoutControlItem20})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(513, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(201, 262)
        Me.LayoutControlGroup6.Text = "Stock y Localización"
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtStockMinimo
        Me.LayoutControlItem19.CustomizationFormText = "Minimo"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem19.Text = "Minimo"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtStockMaximo
        Me.LayoutControlItem21.CustomizationFormText = "Maximo"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem21.Text = "Maximo"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtLocalizacionDel
        Me.LayoutControlItem20.CustomizationFormText = "Localizacion Bodega"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(177, 172)
        Me.LayoutControlItem20.Text = "Localizacion Bodega"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(95, 13)
        '
        'grdCodigosHijos
        '
        Me.grdCodigosHijos.DataMember = "dsdtColores"
        Me.grdCodigosHijos.DataSource = Me.DsMantenimientoArticulos1
        Me.grdCodigosHijos.Location = New System.Drawing.Point(12, 36)
        Me.grdCodigosHijos.MainView = Me.grdviewCodigosHijos
        Me.grdCodigosHijos.MaximumSize = New System.Drawing.Size(300, 0)
        Me.grdCodigosHijos.MenuManager = Me.BarManager1
        Me.grdCodigosHijos.MinimumSize = New System.Drawing.Size(300, 0)
        Me.grdCodigosHijos.Name = "grdCodigosHijos"
        Me.grdCodigosHijos.Size = New System.Drawing.Size(300, 485)
        Me.grdCodigosHijos.TabIndex = 5
        Me.grdCodigosHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigosHijos})
        '
        'grdviewCodigosHijos
        '
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCodigosHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colDeLinea})
        Me.grdviewCodigosHijos.GridControl = Me.grdCodigosHijos
        Me.grdviewCodigosHijos.Name = "grdviewCodigosHijos"
        Me.grdviewCodigosHijos.OptionsBehavior.Editable = False
        Me.grdviewCodigosHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewCodigosHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCodigosHijos.OptionsView.ShowFooter = True
        Me.grdviewCodigosHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigosHijos.OptionsView.ShowViewCaption = True
        Me.grdviewCodigosHijos.PaintStyleName = "MixedXP"
        Me.grdviewCodigosHijos.ViewCaption = "Colores (Hijos)"
        '
        'colId
        '
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 38
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 173
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.Visible = True
        Me.colDeLinea.VisibleIndex = 2
        Me.colDeLinea.Width = 67
        '
        'slueColorAgregar
        '
        Me.slueColorAgregar.Location = New System.Drawing.Point(82, 12)
        Me.slueColorAgregar.MenuManager = Me.BarManager1
        Me.slueColorAgregar.Name = "slueColorAgregar"
        Me.slueColorAgregar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueColorAgregar.Properties.NullText = ""
        Me.slueColorAgregar.Properties.View = Me.SearchLookUpEdit1View
        Me.slueColorAgregar.Size = New System.Drawing.Size(230, 20)
        Me.slueColorAgregar.StyleController = Me.lycCodigosHijos
        Me.slueColorAgregar.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem18})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1068, 533)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.slueColorAgregar
        Me.LayoutControlItem3.CustomizationFormText = "Color"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(304, 24)
        Me.LayoutControlItem3.Text = "Agregar Color"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdCodigosHijos
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(304, 489)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.xtc_Hijos
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(304, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(744, 513)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlGroup19
        '
        Me.LayoutControlGroup19.CustomizationFormText = "LayoutControlGroup19"
        Me.LayoutControlGroup19.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup19.GroupBordersVisible = False
        Me.LayoutControlGroup19.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup19.Name = "LayoutControlGroup19"
        Me.LayoutControlGroup19.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup19.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gpcCodigosHijos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1076, 541)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'xtpVentas
        '
        Me.xtpVentas.Controls.Add(Me.lycVentas)
        Me.xtpVentas.Image = CType(resources.GetObject("xtpVentas.Image"), System.Drawing.Image)
        Me.xtpVentas.Name = "xtpVentas"
        Me.xtpVentas.Size = New System.Drawing.Size(1096, 561)
        Me.xtpVentas.Text = "Ventas"
        '
        'lycVentas
        '
        Me.lycVentas.Controls.Add(Me.spinP_PrecioMayorista)
        Me.lycVentas.Controls.Add(Me.spinP_EmpaqueVenta)
        Me.lycVentas.Controls.Add(Me.spinP_EmpaqueEstandar)
        Me.lycVentas.Controls.Add(Me.spinP_Unidades)
        Me.lycVentas.Controls.Add(Me.spinP_Contenido)
        Me.lycVentas.Controls.Add(Me.slueP_GrupoArticulos)
        Me.lycVentas.Controls.Add(Me.rdgP_EnCatalgo)
        Me.lycVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycVentas.Location = New System.Drawing.Point(0, 0)
        Me.lycVentas.Name = "lycVentas"
        Me.lycVentas.Root = Me.LayoutControlGroup9
        Me.lycVentas.Size = New System.Drawing.Size(1096, 561)
        Me.lycVentas.TabIndex = 0
        Me.lycVentas.Text = "LayoutControl1"
        '
        'spinP_PrecioMayorista
        '
        Me.spinP_PrecioMayorista.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinP_PrecioMayorista.Location = New System.Drawing.Point(121, 113)
        Me.spinP_PrecioMayorista.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinP_PrecioMayorista.MenuManager = Me.BarManager1
        Me.spinP_PrecioMayorista.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinP_PrecioMayorista.Name = "spinP_PrecioMayorista"
        Me.spinP_PrecioMayorista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinP_PrecioMayorista.Properties.Mask.BeepOnError = True
        Me.spinP_PrecioMayorista.Properties.Mask.EditMask = "n2"
        Me.spinP_PrecioMayorista.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinP_PrecioMayorista.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinP_PrecioMayorista.Size = New System.Drawing.Size(100, 20)
        Me.spinP_PrecioMayorista.StyleController = Me.lycVentas
        Me.spinP_PrecioMayorista.TabIndex = 14
        '
        'spinP_EmpaqueVenta
        '
        Me.spinP_EmpaqueVenta.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_EmpaqueVenta.Location = New System.Drawing.Point(121, 161)
        Me.spinP_EmpaqueVenta.MenuManager = Me.BarManager1
        Me.spinP_EmpaqueVenta.Name = "spinP_EmpaqueVenta"
        Me.spinP_EmpaqueVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinP_EmpaqueVenta.Properties.Mask.EditMask = "n0"
        Me.spinP_EmpaqueVenta.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinP_EmpaqueVenta.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_EmpaqueVenta.Size = New System.Drawing.Size(100, 20)
        Me.spinP_EmpaqueVenta.StyleController = Me.lycVentas
        Me.spinP_EmpaqueVenta.TabIndex = 13
        '
        'spinP_EmpaqueEstandar
        '
        Me.spinP_EmpaqueEstandar.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_EmpaqueEstandar.Location = New System.Drawing.Point(121, 137)
        Me.spinP_EmpaqueEstandar.MenuManager = Me.BarManager1
        Me.spinP_EmpaqueEstandar.Name = "spinP_EmpaqueEstandar"
        Me.spinP_EmpaqueEstandar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinP_EmpaqueEstandar.Properties.Mask.EditMask = "n0"
        Me.spinP_EmpaqueEstandar.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinP_EmpaqueEstandar.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_EmpaqueEstandar.Size = New System.Drawing.Size(100, 20)
        Me.spinP_EmpaqueEstandar.StyleController = Me.lycVentas
        Me.spinP_EmpaqueEstandar.TabIndex = 12
        '
        'spinP_Unidades
        '
        Me.spinP_Unidades.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_Unidades.Location = New System.Drawing.Point(121, 89)
        Me.spinP_Unidades.MenuManager = Me.BarManager1
        Me.spinP_Unidades.Name = "spinP_Unidades"
        Me.spinP_Unidades.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinP_Unidades.Properties.Mask.EditMask = "n0"
        Me.spinP_Unidades.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinP_Unidades.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_Unidades.Size = New System.Drawing.Size(100, 20)
        Me.spinP_Unidades.StyleController = Me.lycVentas
        Me.spinP_Unidades.TabIndex = 8
        '
        'spinP_Contenido
        '
        Me.spinP_Contenido.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_Contenido.Location = New System.Drawing.Point(121, 65)
        Me.spinP_Contenido.MaximumSize = New System.Drawing.Size(100, 20)
        Me.spinP_Contenido.MenuManager = Me.BarManager1
        Me.spinP_Contenido.MinimumSize = New System.Drawing.Size(100, 20)
        Me.spinP_Contenido.Name = "spinP_Contenido"
        Me.spinP_Contenido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinP_Contenido.Properties.Mask.EditMask = "n0"
        Me.spinP_Contenido.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinP_Contenido.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinP_Contenido.Size = New System.Drawing.Size(100, 20)
        Me.spinP_Contenido.StyleController = Me.lycVentas
        Me.spinP_Contenido.TabIndex = 7
        '
        'slueP_GrupoArticulos
        '
        Me.slueP_GrupoArticulos.Location = New System.Drawing.Point(121, 12)
        Me.slueP_GrupoArticulos.MaximumSize = New System.Drawing.Size(250, 0)
        Me.slueP_GrupoArticulos.MenuManager = Me.BarManager1
        Me.slueP_GrupoArticulos.MinimumSize = New System.Drawing.Size(250, 0)
        Me.slueP_GrupoArticulos.Name = "slueP_GrupoArticulos"
        Me.slueP_GrupoArticulos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueP_GrupoArticulos.Properties.NullText = ""
        Me.slueP_GrupoArticulos.Properties.View = Me.GridView1
        Me.slueP_GrupoArticulos.Size = New System.Drawing.Size(250, 20)
        Me.slueP_GrupoArticulos.StyleController = Me.lycVentas
        Me.slueP_GrupoArticulos.TabIndex = 5
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'rdgP_EnCatalgo
        '
        Me.rdgP_EnCatalgo.EditValue = True
        Me.rdgP_EnCatalgo.Location = New System.Drawing.Point(121, 36)
        Me.rdgP_EnCatalgo.MaximumSize = New System.Drawing.Size(100, 25)
        Me.rdgP_EnCatalgo.MenuManager = Me.BarManager1
        Me.rdgP_EnCatalgo.MinimumSize = New System.Drawing.Size(100, 25)
        Me.rdgP_EnCatalgo.Name = "rdgP_EnCatalgo"
        Me.rdgP_EnCatalgo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No")})
        Me.rdgP_EnCatalgo.Size = New System.Drawing.Size(100, 25)
        Me.rdgP_EnCatalgo.StyleController = Me.lycVentas
        Me.rdgP_EnCatalgo.TabIndex = 4
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.CustomizationFormText = "LayoutControlGroup9"
        Me.LayoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup9.GroupBordersVisible = False
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem7, Me.LayoutControlItem29, Me.EmptySpaceItem12, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem30, Me.LayoutControlItem38, Me.LayoutControlItem31, Me.LayoutControlItem37, Me.EmptySpaceItem28})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup9.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(213, 24)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(150, 149)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.rdgP_EnCatalgo
        Me.LayoutControlItem29.CustomizationFormText = "Aparece en Catalogo?"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(213, 29)
        Me.LayoutControlItem29.Text = "Aparece en Catalogo?"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(106, 13)
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AllowHotTrack = False
        Me.EmptySpaceItem12.CustomizationFormText = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(363, 0)
        Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(713, 541)
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.spinP_Contenido
        Me.LayoutControlItem32.CustomizationFormText = "Contenido"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem32.Text = "Contenido"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.spinP_Unidades
        Me.LayoutControlItem33.CustomizationFormText = "Unidades"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 77)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem33.Text = "Unidades / Piezas"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.slueP_GrupoArticulos
        Me.LayoutControlItem30.CustomizationFormText = "Grupo de Articulos"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem30.Text = "Grupo de Articulos"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.spinP_PrecioMayorista
        Me.LayoutControlItem38.CustomizationFormText = "Precio Mayorista"
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 101)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem38.Text = "Precio Mayorista"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.spinP_EmpaqueEstandar
        Me.LayoutControlItem31.CustomizationFormText = "Empaque Estandar"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem31.Text = "Empaque Estandar"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.spinP_EmpaqueVenta
        Me.LayoutControlItem37.CustomizationFormText = "Empaque de Venta"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 149)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem37.Text = "Empaque de Venta"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(106, 13)
        '
        'EmptySpaceItem28
        '
        Me.EmptySpaceItem28.AllowHotTrack = False
        Me.EmptySpaceItem28.CustomizationFormText = "EmptySpaceItem28"
        Me.EmptySpaceItem28.Location = New System.Drawing.Point(0, 173)
        Me.EmptySpaceItem28.Name = "EmptySpaceItem28"
        Me.EmptySpaceItem28.Size = New System.Drawing.Size(363, 368)
        Me.EmptySpaceItem28.TextSize = New System.Drawing.Size(0, 0)
        '
        'Auditoria
        '
        Me.Auditoria.Controls.Add(Me.lycAuditoria)
        Me.Auditoria.Image = CType(resources.GetObject("Auditoria.Image"), System.Drawing.Image)
        Me.Auditoria.Name = "Auditoria"
        Me.Auditoria.Size = New System.Drawing.Size(1096, 561)
        Me.Auditoria.Text = "Auditoria"
        '
        'lycAuditoria
        '
        Me.lycAuditoria.Controls.Add(Me.btn_Auditoria_Guardar)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_TiendaContinental)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_HNOperadoraSur)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_GTCemaco)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_GTDespensa)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_GTPaiz)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_SVMayorista)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Barbados)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Belice)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Mexico)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_PuertoRico)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_RepDominicana)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Panama)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_CostaRica)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Nicaragua)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_Honduras)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_ElSalvador)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_CPUnidadDocena)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_CPUnidadindividual)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_CentroAmericaSur)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_CentroAmericaNorte)
        Me.lycAuditoria.Controls.Add(Me.spinPrecio_MayoristaTarjeta)
        Me.lycAuditoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAuditoria.Location = New System.Drawing.Point(0, 0)
        Me.lycAuditoria.Name = "lycAuditoria"
        Me.lycAuditoria.Root = Me.LayoutControlGroup15
        Me.lycAuditoria.Size = New System.Drawing.Size(1096, 561)
        Me.lycAuditoria.TabIndex = 0
        Me.lycAuditoria.Text = "LayoutControl1"
        '
        'btn_Auditoria_Guardar
        '
        Me.btn_Auditoria_Guardar.ImageOptions.Image = CType(resources.GetObject("btn_Auditoria_Guardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Auditoria_Guardar.Location = New System.Drawing.Point(12, 509)
        Me.btn_Auditoria_Guardar.MaximumSize = New System.Drawing.Size(150, 40)
        Me.btn_Auditoria_Guardar.MinimumSize = New System.Drawing.Size(150, 40)
        Me.btn_Auditoria_Guardar.Name = "btn_Auditoria_Guardar"
        Me.btn_Auditoria_Guardar.Size = New System.Drawing.Size(150, 40)
        Me.btn_Auditoria_Guardar.StyleController = Me.lycAuditoria
        Me.btn_Auditoria_Guardar.TabIndex = 25
        Me.btn_Auditoria_Guardar.Text = "Grabar"
        '
        'spinPrecio_TiendaContinental
        '
        Me.spinPrecio_TiendaContinental.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_TiendaContinental.Location = New System.Drawing.Point(552, 162)
        Me.spinPrecio_TiendaContinental.MenuManager = Me.BarManager1
        Me.spinPrecio_TiendaContinental.Name = "spinPrecio_TiendaContinental"
        Me.spinPrecio_TiendaContinental.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_TiendaContinental.Properties.Mask.BeepOnError = True
        Me.spinPrecio_TiendaContinental.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_TiendaContinental.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_TiendaContinental.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_TiendaContinental.StyleController = Me.lycAuditoria
        Me.spinPrecio_TiendaContinental.TabIndex = 24
        '
        'spinPrecio_HNOperadoraSur
        '
        Me.spinPrecio_HNOperadoraSur.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_HNOperadoraSur.Location = New System.Drawing.Point(552, 138)
        Me.spinPrecio_HNOperadoraSur.MenuManager = Me.BarManager1
        Me.spinPrecio_HNOperadoraSur.Name = "spinPrecio_HNOperadoraSur"
        Me.spinPrecio_HNOperadoraSur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_HNOperadoraSur.Properties.Mask.BeepOnError = True
        Me.spinPrecio_HNOperadoraSur.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_HNOperadoraSur.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_HNOperadoraSur.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_HNOperadoraSur.StyleController = Me.lycAuditoria
        Me.spinPrecio_HNOperadoraSur.TabIndex = 23
        '
        'spinPrecio_GTCemaco
        '
        Me.spinPrecio_GTCemaco.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_GTCemaco.Location = New System.Drawing.Point(552, 90)
        Me.spinPrecio_GTCemaco.MenuManager = Me.BarManager1
        Me.spinPrecio_GTCemaco.Name = "spinPrecio_GTCemaco"
        Me.spinPrecio_GTCemaco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_GTCemaco.Properties.Mask.BeepOnError = True
        Me.spinPrecio_GTCemaco.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_GTCemaco.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_GTCemaco.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_GTCemaco.StyleController = Me.lycAuditoria
        Me.spinPrecio_GTCemaco.TabIndex = 22
        '
        'spinPrecio_GTDespensa
        '
        Me.spinPrecio_GTDespensa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_GTDespensa.Location = New System.Drawing.Point(552, 66)
        Me.spinPrecio_GTDespensa.MenuManager = Me.BarManager1
        Me.spinPrecio_GTDespensa.Name = "spinPrecio_GTDespensa"
        Me.spinPrecio_GTDespensa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_GTDespensa.Properties.Mask.BeepOnError = True
        Me.spinPrecio_GTDespensa.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_GTDespensa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_GTDespensa.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_GTDespensa.StyleController = Me.lycAuditoria
        Me.spinPrecio_GTDespensa.TabIndex = 21
        '
        'spinPrecio_GTPaiz
        '
        Me.spinPrecio_GTPaiz.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_GTPaiz.Location = New System.Drawing.Point(552, 42)
        Me.spinPrecio_GTPaiz.MaximumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_GTPaiz.MenuManager = Me.BarManager1
        Me.spinPrecio_GTPaiz.MinimumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_GTPaiz.Name = "spinPrecio_GTPaiz"
        Me.spinPrecio_GTPaiz.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_GTPaiz.Properties.Mask.BeepOnError = True
        Me.spinPrecio_GTPaiz.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_GTPaiz.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_GTPaiz.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_GTPaiz.StyleController = Me.lycAuditoria
        Me.spinPrecio_GTPaiz.TabIndex = 20
        '
        'spinPrecio_SVMayorista
        '
        Me.spinPrecio_SVMayorista.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_SVMayorista.Location = New System.Drawing.Point(552, 114)
        Me.spinPrecio_SVMayorista.MenuManager = Me.BarManager1
        Me.spinPrecio_SVMayorista.Name = "spinPrecio_SVMayorista"
        Me.spinPrecio_SVMayorista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_SVMayorista.Properties.Mask.BeepOnError = True
        Me.spinPrecio_SVMayorista.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_SVMayorista.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_SVMayorista.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_SVMayorista.StyleController = Me.lycAuditoria
        Me.spinPrecio_SVMayorista.TabIndex = 19
        '
        'spinPrecio_Barbados
        '
        Me.spinPrecio_Barbados.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Barbados.Location = New System.Drawing.Point(356, 258)
        Me.spinPrecio_Barbados.MenuManager = Me.BarManager1
        Me.spinPrecio_Barbados.Name = "spinPrecio_Barbados"
        Me.spinPrecio_Barbados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Barbados.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Barbados.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Barbados.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Barbados.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Barbados.StyleController = Me.lycAuditoria
        Me.spinPrecio_Barbados.TabIndex = 18
        '
        'spinPrecio_Belice
        '
        Me.spinPrecio_Belice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Belice.Location = New System.Drawing.Point(356, 66)
        Me.spinPrecio_Belice.MenuManager = Me.BarManager1
        Me.spinPrecio_Belice.Name = "spinPrecio_Belice"
        Me.spinPrecio_Belice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Belice.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Belice.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Belice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Belice.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Belice.StyleController = Me.lycAuditoria
        Me.spinPrecio_Belice.TabIndex = 17
        '
        'spinPrecio_Mexico
        '
        Me.spinPrecio_Mexico.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Mexico.Location = New System.Drawing.Point(356, 42)
        Me.spinPrecio_Mexico.MaximumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_Mexico.MenuManager = Me.BarManager1
        Me.spinPrecio_Mexico.MinimumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_Mexico.Name = "spinPrecio_Mexico"
        Me.spinPrecio_Mexico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Mexico.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Mexico.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Mexico.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Mexico.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Mexico.StyleController = Me.lycAuditoria
        Me.spinPrecio_Mexico.TabIndex = 16
        '
        'spinPrecio_PuertoRico
        '
        Me.spinPrecio_PuertoRico.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_PuertoRico.Location = New System.Drawing.Point(356, 234)
        Me.spinPrecio_PuertoRico.MenuManager = Me.BarManager1
        Me.spinPrecio_PuertoRico.Name = "spinPrecio_PuertoRico"
        Me.spinPrecio_PuertoRico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_PuertoRico.Properties.Mask.BeepOnError = True
        Me.spinPrecio_PuertoRico.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_PuertoRico.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_PuertoRico.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_PuertoRico.StyleController = Me.lycAuditoria
        Me.spinPrecio_PuertoRico.TabIndex = 15
        '
        'spinPrecio_RepDominicana
        '
        Me.spinPrecio_RepDominicana.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_RepDominicana.Location = New System.Drawing.Point(356, 210)
        Me.spinPrecio_RepDominicana.MenuManager = Me.BarManager1
        Me.spinPrecio_RepDominicana.Name = "spinPrecio_RepDominicana"
        Me.spinPrecio_RepDominicana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_RepDominicana.Properties.Mask.BeepOnError = True
        Me.spinPrecio_RepDominicana.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_RepDominicana.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_RepDominicana.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_RepDominicana.StyleController = Me.lycAuditoria
        Me.spinPrecio_RepDominicana.TabIndex = 14
        '
        'spinPrecio_Panama
        '
        Me.spinPrecio_Panama.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Panama.Location = New System.Drawing.Point(356, 186)
        Me.spinPrecio_Panama.MenuManager = Me.BarManager1
        Me.spinPrecio_Panama.Name = "spinPrecio_Panama"
        Me.spinPrecio_Panama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Panama.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Panama.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Panama.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Panama.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Panama.StyleController = Me.lycAuditoria
        Me.spinPrecio_Panama.TabIndex = 13
        '
        'spinPrecio_CostaRica
        '
        Me.spinPrecio_CostaRica.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_CostaRica.Location = New System.Drawing.Point(356, 162)
        Me.spinPrecio_CostaRica.MenuManager = Me.BarManager1
        Me.spinPrecio_CostaRica.Name = "spinPrecio_CostaRica"
        Me.spinPrecio_CostaRica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_CostaRica.Properties.Mask.BeepOnError = True
        Me.spinPrecio_CostaRica.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_CostaRica.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_CostaRica.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_CostaRica.StyleController = Me.lycAuditoria
        Me.spinPrecio_CostaRica.TabIndex = 12
        '
        'spinPrecio_Nicaragua
        '
        Me.spinPrecio_Nicaragua.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Nicaragua.Location = New System.Drawing.Point(356, 138)
        Me.spinPrecio_Nicaragua.MenuManager = Me.BarManager1
        Me.spinPrecio_Nicaragua.Name = "spinPrecio_Nicaragua"
        Me.spinPrecio_Nicaragua.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Nicaragua.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Nicaragua.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Nicaragua.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Nicaragua.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Nicaragua.StyleController = Me.lycAuditoria
        Me.spinPrecio_Nicaragua.TabIndex = 11
        '
        'spinPrecio_Honduras
        '
        Me.spinPrecio_Honduras.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_Honduras.Location = New System.Drawing.Point(356, 114)
        Me.spinPrecio_Honduras.MenuManager = Me.BarManager1
        Me.spinPrecio_Honduras.Name = "spinPrecio_Honduras"
        Me.spinPrecio_Honduras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_Honduras.Properties.Mask.BeepOnError = True
        Me.spinPrecio_Honduras.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_Honduras.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_Honduras.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_Honduras.StyleController = Me.lycAuditoria
        Me.spinPrecio_Honduras.TabIndex = 10
        '
        'spinPrecio_ElSalvador
        '
        Me.spinPrecio_ElSalvador.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_ElSalvador.Location = New System.Drawing.Point(356, 90)
        Me.spinPrecio_ElSalvador.MenuManager = Me.BarManager1
        Me.spinPrecio_ElSalvador.Name = "spinPrecio_ElSalvador"
        Me.spinPrecio_ElSalvador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_ElSalvador.Properties.Mask.BeepOnError = True
        Me.spinPrecio_ElSalvador.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_ElSalvador.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_ElSalvador.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_ElSalvador.StyleController = Me.lycAuditoria
        Me.spinPrecio_ElSalvador.TabIndex = 9
        '
        'spinPrecio_CPUnidadDocena
        '
        Me.spinPrecio_CPUnidadDocena.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_CPUnidadDocena.Location = New System.Drawing.Point(136, 180)
        Me.spinPrecio_CPUnidadDocena.MenuManager = Me.BarManager1
        Me.spinPrecio_CPUnidadDocena.Name = "spinPrecio_CPUnidadDocena"
        Me.spinPrecio_CPUnidadDocena.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_CPUnidadDocena.Properties.Mask.BeepOnError = True
        Me.spinPrecio_CPUnidadDocena.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_CPUnidadDocena.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_CPUnidadDocena.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_CPUnidadDocena.StyleController = Me.lycAuditoria
        Me.spinPrecio_CPUnidadDocena.TabIndex = 8
        '
        'spinPrecio_CPUnidadindividual
        '
        Me.spinPrecio_CPUnidadindividual.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_CPUnidadindividual.Location = New System.Drawing.Point(136, 156)
        Me.spinPrecio_CPUnidadindividual.MenuManager = Me.BarManager1
        Me.spinPrecio_CPUnidadindividual.Name = "spinPrecio_CPUnidadindividual"
        Me.spinPrecio_CPUnidadindividual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_CPUnidadindividual.Properties.Mask.BeepOnError = True
        Me.spinPrecio_CPUnidadindividual.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_CPUnidadindividual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_CPUnidadindividual.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_CPUnidadindividual.StyleController = Me.lycAuditoria
        Me.spinPrecio_CPUnidadindividual.TabIndex = 7
        '
        'spinPrecio_CentroAmericaSur
        '
        Me.spinPrecio_CentroAmericaSur.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_CentroAmericaSur.Location = New System.Drawing.Point(136, 90)
        Me.spinPrecio_CentroAmericaSur.MenuManager = Me.BarManager1
        Me.spinPrecio_CentroAmericaSur.Name = "spinPrecio_CentroAmericaSur"
        Me.spinPrecio_CentroAmericaSur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_CentroAmericaSur.Properties.Mask.BeepOnError = True
        Me.spinPrecio_CentroAmericaSur.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_CentroAmericaSur.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_CentroAmericaSur.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_CentroAmericaSur.StyleController = Me.lycAuditoria
        Me.spinPrecio_CentroAmericaSur.TabIndex = 6
        '
        'spinPrecio_CentroAmericaNorte
        '
        Me.spinPrecio_CentroAmericaNorte.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_CentroAmericaNorte.Location = New System.Drawing.Point(136, 66)
        Me.spinPrecio_CentroAmericaNorte.MenuManager = Me.BarManager1
        Me.spinPrecio_CentroAmericaNorte.Name = "spinPrecio_CentroAmericaNorte"
        Me.spinPrecio_CentroAmericaNorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_CentroAmericaNorte.Properties.Mask.BeepOnError = True
        Me.spinPrecio_CentroAmericaNorte.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_CentroAmericaNorte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_CentroAmericaNorte.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_CentroAmericaNorte.StyleController = Me.lycAuditoria
        Me.spinPrecio_CentroAmericaNorte.TabIndex = 5
        '
        'spinPrecio_MayoristaTarjeta
        '
        Me.spinPrecio_MayoristaTarjeta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecio_MayoristaTarjeta.Location = New System.Drawing.Point(136, 42)
        Me.spinPrecio_MayoristaTarjeta.MaximumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_MayoristaTarjeta.MenuManager = Me.BarManager1
        Me.spinPrecio_MayoristaTarjeta.MinimumSize = New System.Drawing.Size(80, 0)
        Me.spinPrecio_MayoristaTarjeta.Name = "spinPrecio_MayoristaTarjeta"
        Me.spinPrecio_MayoristaTarjeta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecio_MayoristaTarjeta.Properties.Mask.BeepOnError = True
        Me.spinPrecio_MayoristaTarjeta.Properties.Mask.EditMask = "n2"
        Me.spinPrecio_MayoristaTarjeta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinPrecio_MayoristaTarjeta.Size = New System.Drawing.Size(80, 20)
        Me.spinPrecio_MayoristaTarjeta.StyleController = Me.lycAuditoria
        Me.spinPrecio_MayoristaTarjeta.TabIndex = 4
        '
        'LayoutControlGroup15
        '
        Me.LayoutControlGroup15.CustomizationFormText = "LayoutControlGroup15"
        Me.LayoutControlGroup15.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup15.GroupBordersVisible = False
        Me.LayoutControlGroup15.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem20, Me.EmptySpaceItem22, Me.LayoutControlGroup16, Me.LayoutControlGroup17, Me.EmptySpaceItem24, Me.LayoutControlGroup18, Me.LayoutControlItem82, Me.EmptySpaceItem8})
        Me.LayoutControlGroup15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup15.Name = "LayoutControlGroup15"
        Me.LayoutControlGroup15.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup15.TextVisible = False
        '
        'EmptySpaceItem20
        '
        Me.EmptySpaceItem20.AllowHotTrack = False
        Me.EmptySpaceItem20.CustomizationFormText = "EmptySpaceItem20"
        Me.EmptySpaceItem20.Location = New System.Drawing.Point(0, 204)
        Me.EmptySpaceItem20.Name = "EmptySpaceItem20"
        Me.EmptySpaceItem20.Size = New System.Drawing.Size(220, 78)
        Me.EmptySpaceItem20.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem22
        '
        Me.EmptySpaceItem22.AllowHotTrack = False
        Me.EmptySpaceItem22.CustomizationFormText = "EmptySpaceItem22"
        Me.EmptySpaceItem22.Location = New System.Drawing.Point(636, 0)
        Me.EmptySpaceItem22.Name = "EmptySpaceItem22"
        Me.EmptySpaceItem22.Size = New System.Drawing.Size(440, 282)
        Me.EmptySpaceItem22.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup16
        '
        Me.LayoutControlGroup16.CustomizationFormText = "Precios por Sistema"
        Me.LayoutControlGroup16.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem60, Me.LayoutControlItem61, Me.LayoutControlItem62})
        Me.LayoutControlGroup16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup16.Name = "LayoutControlGroup16"
        Me.LayoutControlGroup16.Size = New System.Drawing.Size(220, 114)
        Me.LayoutControlGroup16.Text = "Precios por Sistema"
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.spinPrecio_MayoristaTarjeta
        Me.LayoutControlItem60.CustomizationFormText = "Mayorista con Tarjeta"
        Me.LayoutControlItem60.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem60.Text = "Mayorista con Tarjeta"
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.spinPrecio_CentroAmericaNorte
        Me.LayoutControlItem61.CustomizationFormText = "Centro America Norte"
        Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem61.Text = "Centro America Norte"
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.spinPrecio_CentroAmericaSur
        Me.LayoutControlItem62.CustomizationFormText = "Centro America Sur"
        Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem62.Text = "Centro America Sur"
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlGroup17
        '
        Me.LayoutControlGroup17.CustomizationFormText = "Precio para Centros Plasticos"
        Me.LayoutControlGroup17.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem63, Me.LayoutControlItem64})
        Me.LayoutControlGroup17.Location = New System.Drawing.Point(0, 114)
        Me.LayoutControlGroup17.Name = "LayoutControlGroup17"
        Me.LayoutControlGroup17.Size = New System.Drawing.Size(220, 90)
        Me.LayoutControlGroup17.Text = "Precio para Centros Plasticos"
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.spinPrecio_CPUnidadindividual
        Me.LayoutControlItem63.CustomizationFormText = "Por Unidad (Individual)"
        Me.LayoutControlItem63.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem63.Text = "Por Unidad (Individual)"
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.spinPrecio_CPUnidadDocena
        Me.LayoutControlItem64.CustomizationFormText = "por Unidad (Docena)"
        Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem64.Text = "por Unidad (Docena)"
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(109, 13)
        '
        'EmptySpaceItem24
        '
        Me.EmptySpaceItem24.AllowHotTrack = False
        Me.EmptySpaceItem24.CustomizationFormText = "EmptySpaceItem24"
        Me.EmptySpaceItem24.Location = New System.Drawing.Point(154, 282)
        Me.EmptySpaceItem24.Name = "EmptySpaceItem24"
        Me.EmptySpaceItem24.Size = New System.Drawing.Size(922, 259)
        Me.EmptySpaceItem24.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup18
        '
        Me.LayoutControlGroup18.CustomizationFormText = "Precios Resto del Mundo"
        Me.LayoutControlGroup18.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem23, Me.LayoutControlItem74, Me.LayoutControlItem71, Me.LayoutControlItem70, Me.LayoutControlItem69, Me.LayoutControlItem68, Me.LayoutControlItem67, Me.LayoutControlItem66, Me.LayoutControlItem65, Me.LayoutControlItem73, Me.LayoutControlItem72, Me.LayoutControlItem76, Me.LayoutControlItem77, Me.LayoutControlItem78, Me.LayoutControlItem75, Me.LayoutControlItem79, Me.LayoutControlItem80})
        Me.LayoutControlGroup18.Location = New System.Drawing.Point(220, 0)
        Me.LayoutControlGroup18.Name = "LayoutControlGroup18"
        Me.LayoutControlGroup18.Size = New System.Drawing.Size(416, 282)
        Me.LayoutControlGroup18.Text = "Precios Resto del Mundo"
        '
        'EmptySpaceItem23
        '
        Me.EmptySpaceItem23.AllowHotTrack = False
        Me.EmptySpaceItem23.CustomizationFormText = "EmptySpaceItem23"
        Me.EmptySpaceItem23.Location = New System.Drawing.Point(196, 144)
        Me.EmptySpaceItem23.Name = "EmptySpaceItem23"
        Me.EmptySpaceItem23.Size = New System.Drawing.Size(196, 96)
        Me.EmptySpaceItem23.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.spinPrecio_Barbados
        Me.LayoutControlItem74.CustomizationFormText = "Barbados"
        Me.LayoutControlItem74.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem74.Text = "Barbados"
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.spinPrecio_PuertoRico
        Me.LayoutControlItem71.CustomizationFormText = "Puerto Rico"
        Me.LayoutControlItem71.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem71.Text = "Puerto Rico"
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.spinPrecio_RepDominicana
        Me.LayoutControlItem70.CustomizationFormText = "Republica Dominicana"
        Me.LayoutControlItem70.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem70.Text = "Republica Dominicana"
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.spinPrecio_Panama
        Me.LayoutControlItem69.CustomizationFormText = "Panamá"
        Me.LayoutControlItem69.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem69.Text = "Panamá"
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.spinPrecio_CostaRica
        Me.LayoutControlItem68.CustomizationFormText = "Costa Rica"
        Me.LayoutControlItem68.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem68.Text = "Costa Rica"
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.spinPrecio_Nicaragua
        Me.LayoutControlItem67.CustomizationFormText = "Nicaragua"
        Me.LayoutControlItem67.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem67.Text = "Nicaragua"
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.spinPrecio_Honduras
        Me.LayoutControlItem66.CustomizationFormText = "Honduras"
        Me.LayoutControlItem66.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem66.Text = "Honduras"
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.spinPrecio_ElSalvador
        Me.LayoutControlItem65.CustomizationFormText = "El Salvador"
        Me.LayoutControlItem65.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem65.Text = "El Salvador"
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.spinPrecio_Belice
        Me.LayoutControlItem73.CustomizationFormText = "Belice"
        Me.LayoutControlItem73.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem73.Text = "Belice"
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem72
        '
        Me.LayoutControlItem72.Control = Me.spinPrecio_Mexico
        Me.LayoutControlItem72.CustomizationFormText = "Mexico"
        Me.LayoutControlItem72.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem72.Name = "LayoutControlItem72"
        Me.LayoutControlItem72.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem72.Text = "Mexico"
        Me.LayoutControlItem72.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.spinPrecio_GTPaiz
        Me.LayoutControlItem76.CustomizationFormText = "(GT) Paiz"
        Me.LayoutControlItem76.Location = New System.Drawing.Point(196, 0)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem76.Text = "(GT) Paiz"
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem77
        '
        Me.LayoutControlItem77.Control = Me.spinPrecio_GTDespensa
        Me.LayoutControlItem77.CustomizationFormText = "(GT) Despensa"
        Me.LayoutControlItem77.Location = New System.Drawing.Point(196, 24)
        Me.LayoutControlItem77.Name = "LayoutControlItem77"
        Me.LayoutControlItem77.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem77.Text = "(GT) Despensa"
        Me.LayoutControlItem77.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem78
        '
        Me.LayoutControlItem78.Control = Me.spinPrecio_GTCemaco
        Me.LayoutControlItem78.CustomizationFormText = "(GT) Cemaco"
        Me.LayoutControlItem78.Location = New System.Drawing.Point(196, 48)
        Me.LayoutControlItem78.Name = "LayoutControlItem78"
        Me.LayoutControlItem78.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem78.Text = "(GT) Cemaco"
        Me.LayoutControlItem78.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem75
        '
        Me.LayoutControlItem75.Control = Me.spinPrecio_SVMayorista
        Me.LayoutControlItem75.CustomizationFormText = "(SV) Mayorista"
        Me.LayoutControlItem75.Location = New System.Drawing.Point(196, 72)
        Me.LayoutControlItem75.Name = "LayoutControlItem75"
        Me.LayoutControlItem75.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem75.Text = "(SV) Mayorista"
        Me.LayoutControlItem75.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem79
        '
        Me.LayoutControlItem79.Control = Me.spinPrecio_HNOperadoraSur
        Me.LayoutControlItem79.CustomizationFormText = "(HN) Operadora Sur"
        Me.LayoutControlItem79.Location = New System.Drawing.Point(196, 96)
        Me.LayoutControlItem79.Name = "LayoutControlItem79"
        Me.LayoutControlItem79.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem79.Text = "(HN) Operadora Sur"
        Me.LayoutControlItem79.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem80
        '
        Me.LayoutControlItem80.Control = Me.spinPrecio_TiendaContinental
        Me.LayoutControlItem80.CustomizationFormText = "Tienda Continental"
        Me.LayoutControlItem80.Location = New System.Drawing.Point(196, 120)
        Me.LayoutControlItem80.Name = "LayoutControlItem80"
        Me.LayoutControlItem80.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem80.Text = "Tienda Continental"
        Me.LayoutControlItem80.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem82
        '
        Me.LayoutControlItem82.Control = Me.btn_Auditoria_Guardar
        Me.LayoutControlItem82.Location = New System.Drawing.Point(0, 497)
        Me.LayoutControlItem82.Name = "LayoutControlItem82"
        Me.LayoutControlItem82.Size = New System.Drawing.Size(154, 44)
        Me.LayoutControlItem82.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem82.TextVisible = False
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 282)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(154, 215)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'xtpIngenieria
        '
        Me.xtpIngenieria.Controls.Add(Me.lycAlmacen)
        Me.xtpIngenieria.Image = Global.waProduccion_Pedidos.My.Resources.Resources.gaugestylehalfcircular_32x32
        Me.xtpIngenieria.Name = "xtpIngenieria"
        Me.xtpIngenieria.Size = New System.Drawing.Size(1096, 561)
        Me.xtpIngenieria.Text = "Ingeniería"
        '
        'lycAlmacen
        '
        Me.lycAlmacen.Controls.Add(Me.txtArticuloCapacidad)
        Me.lycAlmacen.Controls.Add(Me.txtArticuloMedidas)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit14)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit13)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit12)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit11)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit10)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit9)
        Me.lycAlmacen.Controls.Add(Me.slueMaterialEmpaqueMaster)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit8)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit7)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit6)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit5)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit4)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit3)
        Me.lycAlmacen.Controls.Add(Me.slueMaterialEmpaqueEstandar)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit2)
        Me.lycAlmacen.Controls.Add(Me.SpinEdit1)
        Me.lycAlmacen.Controls.Add(Me.SearchLookUpEdit1)
        Me.lycAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAlmacen.Location = New System.Drawing.Point(0, 0)
        Me.lycAlmacen.Name = "lycAlmacen"
        Me.lycAlmacen.Root = Me.LayoutControlGroup3
        Me.lycAlmacen.Size = New System.Drawing.Size(1096, 561)
        Me.lycAlmacen.TabIndex = 0
        Me.lycAlmacen.Text = "LayoutControl1"
        '
        'txtArticuloCapacidad
        '
        Me.txtArticuloCapacidad.Location = New System.Drawing.Point(149, 66)
        Me.txtArticuloCapacidad.MaximumSize = New System.Drawing.Size(80, 0)
        Me.txtArticuloCapacidad.MenuManager = Me.BarManager1
        Me.txtArticuloCapacidad.MinimumSize = New System.Drawing.Size(80, 0)
        Me.txtArticuloCapacidad.Name = "txtArticuloCapacidad"
        Me.txtArticuloCapacidad.Size = New System.Drawing.Size(80, 20)
        Me.txtArticuloCapacidad.StyleController = Me.lycAlmacen
        Me.txtArticuloCapacidad.TabIndex = 21
        '
        'txtArticuloMedidas
        '
        Me.txtArticuloMedidas.Location = New System.Drawing.Point(149, 42)
        Me.txtArticuloMedidas.MaximumSize = New System.Drawing.Size(290, 20)
        Me.txtArticuloMedidas.MenuManager = Me.BarManager1
        Me.txtArticuloMedidas.MinimumSize = New System.Drawing.Size(290, 20)
        Me.txtArticuloMedidas.Name = "txtArticuloMedidas"
        Me.txtArticuloMedidas.Size = New System.Drawing.Size(290, 20)
        Me.txtArticuloMedidas.StyleController = Me.lycAlmacen
        Me.txtArticuloMedidas.TabIndex = 9
        '
        'SpinEdit14
        '
        Me.SpinEdit14.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit14.Location = New System.Drawing.Point(149, 390)
        Me.SpinEdit14.MenuManager = Me.BarManager1
        Me.SpinEdit14.Name = "SpinEdit14"
        Me.SpinEdit14.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit14.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit14.StyleController = Me.lycAlmacen
        Me.SpinEdit14.TabIndex = 20
        '
        'SpinEdit13
        '
        Me.SpinEdit13.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit13.Location = New System.Drawing.Point(358, 366)
        Me.SpinEdit13.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit13.MenuManager = Me.BarManager1
        Me.SpinEdit13.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit13.Name = "SpinEdit13"
        Me.SpinEdit13.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit13.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit13.StyleController = Me.lycAlmacen
        Me.SpinEdit13.TabIndex = 19
        '
        'SpinEdit12
        '
        Me.SpinEdit12.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit12.Location = New System.Drawing.Point(149, 366)
        Me.SpinEdit12.MenuManager = Me.BarManager1
        Me.SpinEdit12.Name = "SpinEdit12"
        Me.SpinEdit12.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit12.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit12.StyleController = Me.lycAlmacen
        Me.SpinEdit12.TabIndex = 18
        '
        'SpinEdit11
        '
        Me.SpinEdit11.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit11.Location = New System.Drawing.Point(358, 342)
        Me.SpinEdit11.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit11.MenuManager = Me.BarManager1
        Me.SpinEdit11.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit11.Name = "SpinEdit11"
        Me.SpinEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit11.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit11.StyleController = Me.lycAlmacen
        Me.SpinEdit11.TabIndex = 17
        '
        'SpinEdit10
        '
        Me.SpinEdit10.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit10.Location = New System.Drawing.Point(149, 342)
        Me.SpinEdit10.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit10.MenuManager = Me.BarManager1
        Me.SpinEdit10.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit10.Name = "SpinEdit10"
        Me.SpinEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit10.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit10.StyleController = Me.lycAlmacen
        Me.SpinEdit10.TabIndex = 16
        '
        'SpinEdit9
        '
        Me.SpinEdit9.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit9.Location = New System.Drawing.Point(149, 318)
        Me.SpinEdit9.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit9.MenuManager = Me.BarManager1
        Me.SpinEdit9.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit9.Name = "SpinEdit9"
        Me.SpinEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit9.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit9.StyleController = Me.lycAlmacen
        Me.SpinEdit9.TabIndex = 15
        '
        'slueMaterialEmpaqueMaster
        '
        Me.slueMaterialEmpaqueMaster.Location = New System.Drawing.Point(149, 294)
        Me.slueMaterialEmpaqueMaster.MaximumSize = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueMaster.MenuManager = Me.BarManager1
        Me.slueMaterialEmpaqueMaster.MinimumSize = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueMaster.Name = "slueMaterialEmpaqueMaster"
        Me.slueMaterialEmpaqueMaster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMaterialEmpaqueMaster.Properties.NullText = ""
        Me.slueMaterialEmpaqueMaster.Properties.View = Me.SearchLookUpEdit3View
        Me.slueMaterialEmpaqueMaster.Size = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueMaster.StyleController = Me.lycAlmacen
        Me.slueMaterialEmpaqueMaster.TabIndex = 14
        '
        'SearchLookUpEdit3View
        '
        Me.SearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit3View.Name = "SearchLookUpEdit3View"
        Me.SearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'SpinEdit8
        '
        Me.SpinEdit8.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit8.Location = New System.Drawing.Point(149, 228)
        Me.SpinEdit8.MenuManager = Me.BarManager1
        Me.SpinEdit8.Name = "SpinEdit8"
        Me.SpinEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit8.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit8.StyleController = Me.lycAlmacen
        Me.SpinEdit8.TabIndex = 13
        '
        'SpinEdit7
        '
        Me.SpinEdit7.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit7.Location = New System.Drawing.Point(358, 204)
        Me.SpinEdit7.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit7.MenuManager = Me.BarManager1
        Me.SpinEdit7.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit7.Name = "SpinEdit7"
        Me.SpinEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit7.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit7.StyleController = Me.lycAlmacen
        Me.SpinEdit7.TabIndex = 12
        '
        'SpinEdit6
        '
        Me.SpinEdit6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit6.Location = New System.Drawing.Point(149, 204)
        Me.SpinEdit6.MenuManager = Me.BarManager1
        Me.SpinEdit6.Name = "SpinEdit6"
        Me.SpinEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit6.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit6.StyleController = Me.lycAlmacen
        Me.SpinEdit6.TabIndex = 11
        '
        'SpinEdit5
        '
        Me.SpinEdit5.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit5.Location = New System.Drawing.Point(358, 180)
        Me.SpinEdit5.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit5.MenuManager = Me.BarManager1
        Me.SpinEdit5.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit5.Name = "SpinEdit5"
        Me.SpinEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit5.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit5.StyleController = Me.lycAlmacen
        Me.SpinEdit5.TabIndex = 10
        '
        'SpinEdit4
        '
        Me.SpinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit4.Location = New System.Drawing.Point(149, 180)
        Me.SpinEdit4.MenuManager = Me.BarManager1
        Me.SpinEdit4.Name = "SpinEdit4"
        Me.SpinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit4.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit4.StyleController = Me.lycAlmacen
        Me.SpinEdit4.TabIndex = 9
        '
        'SpinEdit3
        '
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(149, 156)
        Me.SpinEdit3.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit3.MenuManager = Me.BarManager1
        Me.SpinEdit3.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit3.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit3.StyleController = Me.lycAlmacen
        Me.SpinEdit3.TabIndex = 8
        '
        'slueMaterialEmpaqueEstandar
        '
        Me.slueMaterialEmpaqueEstandar.Location = New System.Drawing.Point(149, 132)
        Me.slueMaterialEmpaqueEstandar.MaximumSize = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueEstandar.MenuManager = Me.BarManager1
        Me.slueMaterialEmpaqueEstandar.MinimumSize = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueEstandar.Name = "slueMaterialEmpaqueEstandar"
        Me.slueMaterialEmpaqueEstandar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMaterialEmpaqueEstandar.Properties.NullText = ""
        Me.slueMaterialEmpaqueEstandar.Properties.View = Me.SearchLookUpEdit2View
        Me.slueMaterialEmpaqueEstandar.Size = New System.Drawing.Size(290, 20)
        Me.slueMaterialEmpaqueEstandar.StyleController = Me.lycAlmacen
        Me.slueMaterialEmpaqueEstandar.TabIndex = 7
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(592, 90)
        Me.SpinEdit2.MenuManager = Me.BarManager1
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit2.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit2.StyleController = Me.lycAlmacen
        Me.SpinEdit2.TabIndex = 6
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(592, 66)
        Me.SpinEdit1.MaximumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit1.MenuManager = Me.BarManager1
        Me.SpinEdit1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Size = New System.Drawing.Size(80, 20)
        Me.SpinEdit1.StyleController = Me.lycAlmacen
        Me.SpinEdit1.TabIndex = 5
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(592, 42)
        Me.SearchLookUpEdit1.MaximumSize = New System.Drawing.Size(150, 0)
        Me.SearchLookUpEdit1.MenuManager = Me.BarManager1
        Me.SearchLookUpEdit1.MinimumSize = New System.Drawing.Size(150, 0)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.View = Me.GridView2
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(150, 20)
        Me.SearchLookUpEdit1.StyleController = Me.lycAlmacen
        Me.SearchLookUpEdit1.TabIndex = 4
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup12, Me.LayoutControlGroup14, Me.EmptySpaceItem27, Me.LayoutControlGroup13, Me.LayoutControlGroup11, Me.EmptySpaceItem13})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.CustomizationFormText = "Empaque Estandar de Venta"
        Me.LayoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem41, Me.LayoutControlItem42, Me.LayoutControlItem43, Me.LayoutControlItem45, Me.LayoutControlItem47, Me.LayoutControlItem44, Me.LayoutControlItem46, Me.EmptySpaceItem17, Me.EmptySpaceItem16})
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlGroup12.Name = "LayoutControlGroup12"
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(443, 162)
        Me.LayoutControlGroup12.Text = "Empaque Estandar de Venta"
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.slueMaterialEmpaqueEstandar
        Me.LayoutControlItem41.CustomizationFormText = "Material"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem41.Text = "Material"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.SpinEdit3
        Me.LayoutControlItem42.CustomizationFormText = "Unidades por Bulto"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem42.Text = "Unidades por Bulto"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.SpinEdit4
        Me.LayoutControlItem43.CustomizationFormText = "A - Peso (Kg)"
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem43.Text = "A - Peso (Kg)"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.SpinEdit6
        Me.LayoutControlItem45.CustomizationFormText = "C - Largo (cm)"
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem45.Text = "C - Largo (cm)"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.SpinEdit8
        Me.LayoutControlItem47.CustomizationFormText = "E - Alto (cm)"
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem47.Text = "E - Alto (cm)"
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.SpinEdit5
        Me.LayoutControlItem44.CustomizationFormText = "B - Volumen (Lt)"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(209, 48)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem44.Text = "B - Volumen (Lt)"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.SpinEdit7
        Me.LayoutControlItem46.CustomizationFormText = "D - Ancho (cm)"
        Me.LayoutControlItem46.Location = New System.Drawing.Point(209, 72)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem46.Text = "D - Ancho (cm)"
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem17
        '
        Me.EmptySpaceItem17.AllowHotTrack = False
        Me.EmptySpaceItem17.CustomizationFormText = "EmptySpaceItem17"
        Me.EmptySpaceItem17.Location = New System.Drawing.Point(209, 96)
        Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
        Me.EmptySpaceItem17.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem16
        '
        Me.EmptySpaceItem16.AllowHotTrack = False
        Me.EmptySpaceItem16.CustomizationFormText = "EmptySpaceItem16"
        Me.EmptySpaceItem16.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem16.Name = "EmptySpaceItem16"
        Me.EmptySpaceItem16.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem16.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup14
        '
        Me.LayoutControlGroup14.CustomizationFormText = "Medidas del Articulo"
        Me.LayoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem55, Me.LayoutControlItem56, Me.EmptySpaceItem21})
        Me.LayoutControlGroup14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup14.Name = "LayoutControlGroup14"
        Me.LayoutControlGroup14.Size = New System.Drawing.Size(443, 90)
        Me.LayoutControlGroup14.Text = "Medidas del Articulo"
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.txtArticuloMedidas
        Me.LayoutControlItem55.CustomizationFormText = "Medidas (cm)"
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem55.Text = "Medidas (cm)"
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.txtArticuloCapacidad
        Me.LayoutControlItem56.CustomizationFormText = "Capacidad (Lt, oz, etc)"
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem56.Text = "Capacidad (Lt, oz, etc)"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem21
        '
        Me.EmptySpaceItem21.AllowHotTrack = False
        Me.EmptySpaceItem21.CustomizationFormText = "EmptySpaceItem21"
        Me.EmptySpaceItem21.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem21.Name = "EmptySpaceItem21"
        Me.EmptySpaceItem21.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem21.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem27
        '
        Me.EmptySpaceItem27.AllowHotTrack = False
        Me.EmptySpaceItem27.CustomizationFormText = "EmptySpaceItem27"
        Me.EmptySpaceItem27.Location = New System.Drawing.Point(0, 414)
        Me.EmptySpaceItem27.Name = "EmptySpaceItem27"
        Me.EmptySpaceItem27.Size = New System.Drawing.Size(1076, 127)
        Me.EmptySpaceItem27.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup13
        '
        Me.LayoutControlGroup13.CustomizationFormText = "Empaque Master de Venta"
        Me.LayoutControlGroup13.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem48, Me.LayoutControlItem49, Me.EmptySpaceItem18, Me.LayoutControlItem51, Me.LayoutControlItem53, Me.EmptySpaceItem19, Me.LayoutControlItem54, Me.LayoutControlItem52, Me.LayoutControlItem50})
        Me.LayoutControlGroup13.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlGroup13.Name = "LayoutControlGroup13"
        Me.LayoutControlGroup13.Size = New System.Drawing.Size(443, 162)
        Me.LayoutControlGroup13.Text = "Empaque Master de Venta"
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.slueMaterialEmpaqueMaster
        Me.LayoutControlItem48.CustomizationFormText = "Material"
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(419, 24)
        Me.LayoutControlItem48.Text = "Material"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.SpinEdit9
        Me.LayoutControlItem49.CustomizationFormText = "Unidades por Bulto"
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem49.Text = "Unidades por Bulto"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem18
        '
        Me.EmptySpaceItem18.AllowHotTrack = False
        Me.EmptySpaceItem18.CustomizationFormText = "EmptySpaceItem18"
        Me.EmptySpaceItem18.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem18.Name = "EmptySpaceItem18"
        Me.EmptySpaceItem18.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem18.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.SpinEdit11
        Me.LayoutControlItem51.CustomizationFormText = "B - Volumen (Lt)"
        Me.LayoutControlItem51.Location = New System.Drawing.Point(209, 48)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem51.Text = "B - Volumen (Lt)"
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.SpinEdit13
        Me.LayoutControlItem53.CustomizationFormText = "D - Ancho (cm)"
        Me.LayoutControlItem53.Location = New System.Drawing.Point(209, 72)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem53.Text = "D - Ancho (cm)"
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem19
        '
        Me.EmptySpaceItem19.AllowHotTrack = False
        Me.EmptySpaceItem19.CustomizationFormText = "EmptySpaceItem19"
        Me.EmptySpaceItem19.Location = New System.Drawing.Point(209, 96)
        Me.EmptySpaceItem19.Name = "EmptySpaceItem19"
        Me.EmptySpaceItem19.Size = New System.Drawing.Size(210, 24)
        Me.EmptySpaceItem19.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.SpinEdit14
        Me.LayoutControlItem54.CustomizationFormText = "E - Alto (cm)"
        Me.LayoutControlItem54.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem54.Text = "E - Alto (cm)"
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.SpinEdit12
        Me.LayoutControlItem52.CustomizationFormText = "C - Largo (cm)"
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem52.Text = "C - Largo (cm)"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.SpinEdit10
        Me.LayoutControlItem50.CustomizationFormText = "A - Peso (Kg)"
        Me.LayoutControlItem50.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem50.Text = "A - Peso (Kg)"
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.CustomizationFormText = "Ensamble"
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40, Me.LayoutControlItem39, Me.LayoutControlItem36, Me.EmptySpaceItem15})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(443, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(303, 414)
        Me.LayoutControlGroup11.Text = "Ensamble"
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.SpinEdit2
        Me.LayoutControlItem40.CustomizationFormText = "LayoutControlItem40"
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(209, 324)
        Me.LayoutControlItem40.Text = "Tiempo X Articulo [Min]"
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.SpinEdit1
        Me.LayoutControlItem39.CustomizationFormText = "LayoutControlItem39"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem39.Text = "Equipo Minimo [Personas]"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem36.CustomizationFormText = "LayoutControlItem36"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem36.Text = "Depto Ensamble"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(122, 13)
        '
        'EmptySpaceItem15
        '
        Me.EmptySpaceItem15.AllowHotTrack = False
        Me.EmptySpaceItem15.CustomizationFormText = "EmptySpaceItem15"
        Me.EmptySpaceItem15.Location = New System.Drawing.Point(209, 24)
        Me.EmptySpaceItem15.Name = "EmptySpaceItem15"
        Me.EmptySpaceItem15.Size = New System.Drawing.Size(70, 348)
        Me.EmptySpaceItem15.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem13
        '
        Me.EmptySpaceItem13.AllowHotTrack = False
        Me.EmptySpaceItem13.CustomizationFormText = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Location = New System.Drawing.Point(746, 0)
        Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Size = New System.Drawing.Size(330, 414)
        Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
        '
        'xtpContabilidad
        '
        Me.xtpContabilidad.Image = CType(resources.GetObject("xtpContabilidad.Image"), System.Drawing.Image)
        Me.xtpContabilidad.Name = "xtpContabilidad"
        Me.xtpContabilidad.Size = New System.Drawing.Size(1096, 561)
        Me.xtpContabilidad.Text = "Contabilidad"
        '
        'xtpDiseno
        '
        Me.xtpDiseno.Controls.Add(Me.lycDiseno)
        Me.xtpDiseno.Image = CType(resources.GetObject("xtpDiseno.Image"), System.Drawing.Image)
        Me.xtpDiseno.Name = "xtpDiseno"
        Me.xtpDiseno.Size = New System.Drawing.Size(1096, 561)
        Me.xtpDiseno.Text = "Diseño"
        '
        'lycDiseno
        '
        Me.lycDiseno.Controls.Add(Me.picArticulo)
        Me.lycDiseno.Controls.Add(Me.sbdcDiseno)
        Me.lycDiseno.Controls.Add(Me.txtExtension)
        Me.lycDiseno.Controls.Add(Me.txtImagenRutaDestino)
        Me.lycDiseno.Controls.Add(Me.txtImagenRutaOrigen)
        Me.lycDiseno.Controls.Add(Me.txtImagenNombre)
        Me.lycDiseno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycDiseno.Location = New System.Drawing.Point(0, 0)
        Me.lycDiseno.Name = "lycDiseno"
        Me.lycDiseno.Root = Me.LayoutControlGroup8
        Me.lycDiseno.Size = New System.Drawing.Size(1096, 561)
        Me.lycDiseno.TabIndex = 0
        Me.lycDiseno.Text = "LayoutControl1"
        '
        'picArticulo
        '
        Me.picArticulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.picArticulo.Location = New System.Drawing.Point(561, 12)
        Me.picArticulo.MenuManager = Me.BarManager1
        Me.picArticulo.Name = "picArticulo"
        Me.picArticulo.Properties.InitialImage = CType(resources.GetObject("picArticulo.Properties.InitialImage"), System.Drawing.Image)
        Me.picArticulo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.picArticulo.Properties.ZoomAccelerationFactor = 1.0R
        Me.picArticulo.Size = New System.Drawing.Size(523, 537)
        Me.picArticulo.StyleController = Me.lycDiseno
        Me.picArticulo.TabIndex = 12
        '
        'txtExtension
        '
        Me.txtExtension.Enabled = False
        Me.txtExtension.Location = New System.Drawing.Point(77, 87)
        Me.txtExtension.MaximumSize = New System.Drawing.Size(60, 0)
        Me.txtExtension.MenuManager = Me.BarManager1
        Me.txtExtension.MinimumSize = New System.Drawing.Size(60, 0)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtExtension.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtExtension.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtExtension.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtExtension.Size = New System.Drawing.Size(60, 20)
        Me.txtExtension.StyleController = Me.lycDiseno
        Me.txtExtension.TabIndex = 11
        '
        'txtImagenRutaDestino
        '
        Me.txtImagenRutaDestino.EditValue = "C:\Users\BOD-EJPEREZ\Desktop\Imagenes Destino\"
        Me.txtImagenRutaDestino.Enabled = False
        Me.txtImagenRutaDestino.Location = New System.Drawing.Point(77, 135)
        Me.txtImagenRutaDestino.MenuManager = Me.BarManager1
        Me.txtImagenRutaDestino.Name = "txtImagenRutaDestino"
        Me.txtImagenRutaDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtImagenRutaDestino.Size = New System.Drawing.Size(480, 20)
        Me.txtImagenRutaDestino.StyleController = Me.lycDiseno
        Me.txtImagenRutaDestino.TabIndex = 8
        '
        'txtImagenRutaOrigen
        '
        Me.txtImagenRutaOrigen.Enabled = False
        Me.txtImagenRutaOrigen.Location = New System.Drawing.Point(77, 111)
        Me.txtImagenRutaOrigen.MenuManager = Me.BarManager1
        Me.txtImagenRutaOrigen.Name = "txtImagenRutaOrigen"
        Me.txtImagenRutaOrigen.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtImagenRutaOrigen.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtImagenRutaOrigen.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtImagenRutaOrigen.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtImagenRutaOrigen.Size = New System.Drawing.Size(480, 20)
        Me.txtImagenRutaOrigen.StyleController = Me.lycDiseno
        Me.txtImagenRutaOrigen.TabIndex = 7
        '
        'txtImagenNombre
        '
        Me.txtImagenNombre.Enabled = False
        Me.txtImagenNombre.Location = New System.Drawing.Point(77, 63)
        Me.txtImagenNombre.MenuManager = Me.BarManager1
        Me.txtImagenNombre.MinimumSize = New System.Drawing.Size(400, 0)
        Me.txtImagenNombre.Name = "txtImagenNombre"
        Me.txtImagenNombre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtImagenNombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtImagenNombre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtImagenNombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtImagenNombre.Size = New System.Drawing.Size(480, 20)
        Me.txtImagenNombre.StyleController = Me.lycDiseno
        Me.txtImagenNombre.TabIndex = 6
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.CustomizationFormText = "LayoutControlGroup8"
        Me.LayoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup8.GroupBordersVisible = False
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem13, Me.EmptySpaceItem3, Me.LayoutControlItem22, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem24, Me.EmptySpaceItem2, Me.EmptySpaceItem4})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup8.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.sbdcDiseno
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(270, 51)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.picArticulo
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(549, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(527, 541)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(270, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(279, 51)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtImagenRutaDestino
        Me.LayoutControlItem22.CustomizationFormText = "Ruta Destino"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 123)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(549, 24)
        Me.LayoutControlItem22.Text = "Ruta Destino"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtImagenRutaOrigen
        Me.LayoutControlItem15.CustomizationFormText = "Ruta Origen"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(549, 24)
        Me.LayoutControlItem15.Text = "Ruta Origen"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtImagenNombre
        Me.LayoutControlItem14.CustomizationFormText = "Nombre"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(549, 24)
        Me.LayoutControlItem14.Text = "Nombre"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtExtension
        Me.LayoutControlItem24.CustomizationFormText = "Extension"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem24.Text = "Extension"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(62, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 147)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(549, 394)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(129, 75)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(420, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'xtpListaMateriales
        '
        Me.xtpListaMateriales.Controls.Add(Me.lycP_ListaMateriales)
        Me.xtpListaMateriales.Image = CType(resources.GetObject("xtpListaMateriales.Image"), System.Drawing.Image)
        Me.xtpListaMateriales.Name = "xtpListaMateriales"
        Me.xtpListaMateriales.Size = New System.Drawing.Size(1096, 561)
        Me.xtpListaMateriales.Text = "Lista Materiales"
        '
        'lycP_ListaMateriales
        '
        Me.lycP_ListaMateriales.Controls.Add(Me.grdH_ListaMateriales)
        Me.lycP_ListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycP_ListaMateriales.Location = New System.Drawing.Point(0, 0)
        Me.lycP_ListaMateriales.Name = "lycP_ListaMateriales"
        Me.lycP_ListaMateriales.Root = Me.LayoutControlGroup24
        Me.lycP_ListaMateriales.Size = New System.Drawing.Size(1096, 561)
        Me.lycP_ListaMateriales.TabIndex = 0
        Me.lycP_ListaMateriales.Text = "LayoutControl1"
        '
        'grdH_ListaMateriales
        '
        Me.grdH_ListaMateriales.Location = New System.Drawing.Point(12, 12)
        Me.grdH_ListaMateriales.MainView = Me.grdviewP_ListaMateriales
        Me.grdH_ListaMateriales.MenuManager = Me.BarManager1
        Me.grdH_ListaMateriales.Name = "grdH_ListaMateriales"
        Me.grdH_ListaMateriales.Size = New System.Drawing.Size(1072, 537)
        Me.grdH_ListaMateriales.TabIndex = 4
        Me.grdH_ListaMateriales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewP_ListaMateriales})
        '
        'grdviewP_ListaMateriales
        '
        Me.grdviewP_ListaMateriales.GridControl = Me.grdH_ListaMateriales
        Me.grdviewP_ListaMateriales.Name = "grdviewP_ListaMateriales"
        Me.grdviewP_ListaMateriales.OptionsView.ShowFooter = True
        Me.grdviewP_ListaMateriales.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup24
        '
        Me.LayoutControlGroup24.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup24.GroupBordersVisible = False
        Me.LayoutControlGroup24.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem109})
        Me.LayoutControlGroup24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup24.Name = "LayoutControlGroup24"
        Me.LayoutControlGroup24.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup24.TextVisible = False
        '
        'LayoutControlItem109
        '
        Me.LayoutControlItem109.Control = Me.grdH_ListaMateriales
        Me.LayoutControlItem109.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem109.Name = "LayoutControlItem109"
        Me.LayoutControlItem109.Size = New System.Drawing.Size(1076, 541)
        Me.LayoutControlItem109.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem109.TextVisible = False
        '
        'xtpExportacion
        '
        Me.xtpExportacion.Controls.Add(Me.lycExportacion)
        Me.xtpExportacion.Image = Global.waProduccion_Pedidos.My.Resources.Resources.World
        Me.xtpExportacion.Name = "xtpExportacion"
        Me.xtpExportacion.Size = New System.Drawing.Size(1096, 561)
        Me.xtpExportacion.Text = "Exportación"
        '
        'lycExportacion
        '
        Me.lycExportacion.Controls.Add(Me.txtPartidaArancelaria)
        Me.lycExportacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycExportacion.Location = New System.Drawing.Point(0, 0)
        Me.lycExportacion.Name = "lycExportacion"
        Me.lycExportacion.Root = Me.LayoutControlGroup10
        Me.lycExportacion.Size = New System.Drawing.Size(1096, 561)
        Me.lycExportacion.TabIndex = 0
        Me.lycExportacion.Text = "LayoutControl1"
        '
        'txtPartidaArancelaria
        '
        Me.txtPartidaArancelaria.Location = New System.Drawing.Point(106, 12)
        Me.txtPartidaArancelaria.MenuManager = Me.BarManager1
        Me.txtPartidaArancelaria.Name = "txtPartidaArancelaria"
        Me.txtPartidaArancelaria.Size = New System.Drawing.Size(192, 20)
        Me.txtPartidaArancelaria.StyleController = Me.lycExportacion
        Me.txtPartidaArancelaria.TabIndex = 4
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.CustomizationFormText = "LayoutControlGroup10"
        Me.LayoutControlGroup10.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup10.GroupBordersVisible = False
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem34, Me.EmptySpaceItem10, Me.EmptySpaceItem11})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(1096, 561)
        Me.LayoutControlGroup10.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtPartidaArancelaria
        Me.LayoutControlItem34.CustomizationFormText = "Partida Arancelaria"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem34.Text = "Partida Arancelaria"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(91, 13)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(290, 517)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(290, 0)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(786, 541)
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(107, 36)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreArticulo.StyleController = Me.lycMantenimientoArticulos
        Me.txtNombreArticulo.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem12, Me.LayoutControlItem6, Me.LayoutControlItem23, Me.LayoutControlItem26, Me.EmptySpaceItem6, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem57, Me.LayoutControlItem58, Me.LayoutControlItem59, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1249, 663)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.xtcMantenimientoPadre
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1229, 571)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.txtNombreIngles
        Me.LayoutControlItem12.CustomizationFormText = "Nombre Ingles"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem12.Text = "Nombre Ingles"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtNombreArticulo
        Me.LayoutControlItem6.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem6.Text = "Nombre Articulo"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem23.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem23.Control = Me.txtDescripcion1
        Me.LayoutControlItem23.CustomizationFormText = "Descripcion 1"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(279, 24)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(245, 24)
        Me.LayoutControlItem23.Text = "Descripcion 1"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem26.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem26.Control = Me.txtDescripcion2
        Me.LayoutControlItem26.CustomizationFormText = "Descripcion 2"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(279, 48)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(245, 24)
        Me.LayoutControlItem26.Text = "Descripcion 2"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(218, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(570, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtTiketCaja
        Me.LayoutControlItem27.CustomizationFormText = "Tiket de Caja"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(524, 24)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem27.Text = "Tiket de Caja"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtSenalizacion
        Me.LayoutControlItem28.CustomizationFormText = "Señalización"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(524, 48)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem28.Text = "Señalización"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.dteP_FechaInicio
        Me.LayoutControlItem57.CustomizationFormText = "Fecha Inicio"
        Me.LayoutControlItem57.Location = New System.Drawing.Point(788, 0)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem57.Text = "Fecha Inicio"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.dteP_FechaAnuncio
        Me.LayoutControlItem58.CustomizationFormText = "Fecha Anuncio"
        Me.LayoutControlItem58.Location = New System.Drawing.Point(788, 24)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem58.Text = "Fecha Anuncio"
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.dteP_FechaLanzamiento
        Me.LayoutControlItem59.CustomizationFormText = "Fecha Lanzamiento"
        Me.LayoutControlItem59.Location = New System.Drawing.Point(788, 48)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem59.Text = "Fecha Lanzamiento"
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(990, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(239, 72)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCodigoPadre
        Me.LayoutControlItem2.CustomizationFormText = "Codigo Padre"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem2.Text = "Codigo Padre"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'ofdImagen
        '
        Me.ofdImagen.FileName = "OpenFileDialog1"
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCargarImagen})
        Me.BarManager2.MaxItemId = 1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCargarImagen, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGrabarImagen, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DisableCustomization = True
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcDiseno
        Me.Bar2.Text = "Tools"
        '
        'barbtnCargarImagen
        '
        Me.barbtnCargarImagen.Caption = "Cargar Imagen"
        Me.barbtnCargarImagen.Id = 0
        Me.barbtnCargarImagen.ImageOptions.Image = CType(resources.GetObject("barbtnCargarImagen.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCargarImagen.Name = "barbtnCargarImagen"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 707)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 707)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1249, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 707)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barAlmacen})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAsignarUPC})
        Me.BarManager3.MaxItemId = 3
        '
        'barAlmacen
        '
        Me.barAlmacen.BarName = "Tools"
        Me.barAlmacen.DockCol = 0
        Me.barAlmacen.DockRow = 0
        Me.barAlmacen.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barAlmacen.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAsignarUPC, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnVentasEstadisticas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barAlmacen.OptionsBar.AllowQuickCustomization = False
        Me.barAlmacen.OptionsBar.DrawBorder = False
        Me.barAlmacen.OptionsBar.DrawDragBorder = False
        Me.barAlmacen.StandaloneBarDockControl = Me.sbdcAlmacen
        Me.barAlmacen.Text = "Tools"
        '
        'barbtnAsignarUPC
        '
        Me.barbtnAsignarUPC.Caption = "Asignar UPC"
        Me.barbtnAsignarUPC.Id = 0
        Me.barbtnAsignarUPC.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.barcode_16x16
        Me.barbtnAsignarUPC.ImageOptions.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.barcode_32x32
        Me.barbtnAsignarUPC.Name = "barbtnAsignarUPC"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 707)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 707)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1249, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 707)
        '
        'Alerta1
        '
        Me.Alerta1.LookAndFeel.SkinName = "Office 2010 Black"
        Me.Alerta1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Alerta1.ShowCloseButton = False
        Me.Alerta1.ShowPinButton = False
        '
        'BarManager4
        '
        Me.BarManager4.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barListaMateriales})
        Me.BarManager4.DockControls.Add(Me.BarDockControl9)
        Me.BarManager4.DockControls.Add(Me.BarDockControl10)
        Me.BarManager4.DockControls.Add(Me.BarDockControl11)
        Me.BarManager4.DockControls.Add(Me.BarDockControl12)
        Me.BarManager4.Form = Me
        Me.BarManager4.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnListaMateriales_CopiarDe, Me.barbtnActualizarListaMateriales})
        Me.BarManager4.MaxItemId = 2
        '
        'barListaMateriales
        '
        Me.barListaMateriales.BarName = "Tools"
        Me.barListaMateriales.DockCol = 0
        Me.barListaMateriales.DockRow = 0
        Me.barListaMateriales.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barListaMateriales.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizarListaMateriales, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnListaMateriales_CopiarDe, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barListaMateriales.OptionsBar.AllowQuickCustomization = False
        Me.barListaMateriales.OptionsBar.DrawBorder = False
        Me.barListaMateriales.OptionsBar.DrawDragBorder = False
        Me.barListaMateriales.StandaloneBarDockControl = Me.sbdcListaMateriales
        Me.barListaMateriales.Text = "Tools"
        '
        'barbtnActualizarListaMateriales
        '
        Me.barbtnActualizarListaMateriales.Caption = "Actualizar"
        Me.barbtnActualizarListaMateriales.Id = 1
        Me.barbtnActualizarListaMateriales.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.refreshallpivottable_16x16
        Me.barbtnActualizarListaMateriales.ImageOptions.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.refreshallpivottable_32x32
        Me.barbtnActualizarListaMateriales.Name = "barbtnActualizarListaMateriales"
        '
        'barbtnListaMateriales_CopiarDe
        '
        Me.barbtnListaMateriales_CopiarDe.Caption = "Copiar de"
        Me.barbtnListaMateriales_CopiarDe.Id = 0
        Me.barbtnListaMateriales_CopiarDe.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.copy_16x16
        Me.barbtnListaMateriales_CopiarDe.ImageOptions.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.copy_32x321
        Me.barbtnListaMateriales_CopiarDe.Name = "barbtnListaMateriales_CopiarDe"
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl9.Manager = Me.BarManager4
        Me.BarDockControl9.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 707)
        Me.BarDockControl10.Manager = Me.BarManager4
        Me.BarDockControl10.Size = New System.Drawing.Size(1249, 0)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl11.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl11.Manager = Me.BarManager4
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 707)
        '
        'BarDockControl12
        '
        Me.BarDockControl12.CausesValidation = False
        Me.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl12.Location = New System.Drawing.Point(1249, 0)
        Me.BarDockControl12.Manager = Me.BarManager4
        Me.BarDockControl12.Size = New System.Drawing.Size(0, 707)
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'frmMantenimientoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 707)
        Me.Controls.Add(Me.lycMantenimientoArticulos)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl12)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Name = "frmMantenimientoArticulos"
        Me.Text = " "
        CType(Me.lycMantenimientoArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycMantenimientoArticulos.ResumeLayout(False)
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaLanzamiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaLanzamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaAnuncio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaAnuncio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteP_FechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenalizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTiketCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreIngles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcMantenimientoPadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMantenimientoPadre.ResumeLayout(False)
        Me.xtpColores.ResumeLayout(False)
        CType(Me.lycColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycColores.ResumeLayout(False)
        CType(Me.gpcCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCodigosHijos.ResumeLayout(False)
        CType(Me.lycCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycCodigosHijos.ResumeLayout(False)
        CType(Me.xtc_Hijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtc_Hijos.ResumeLayout(False)
        Me.xtpH_Ingenieria.ResumeLayout(False)
        CType(Me.lycH_Ingenieria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycH_Ingenieria.ResumeLayout(False)
        CType(Me.spinH_ArticulosXHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinH_EnsambleEquipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit26.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit25.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit24.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueH_DeptoEnsamble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueH_MaterialEmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtH_Capacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtH_Material.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycH_Ingenieria1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycgH_EmpaqueVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem35, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpH_Ventas.ResumeLayout(False)
        CType(Me.lycH_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycH_Ventas.ResumeLayout(False)
        CType(Me.spinH_EmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinH_EmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinH_PrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinH_Unidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinH_Contenido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgH_EnCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueH_GrupoArticulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpH_ListaMateriales.ResumeLayout(False)
        CType(Me.lycListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaMateriales.ResumeLayout(False)
        CType(Me.grdListaMaterialesHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMantenimientoArticulos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaMaterialesHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpHijosAlmacen.ResumeLayout(False)
        CType(Me.lycAlmacenHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAlmacenHijos.ResumeLayout(False)
        CType(Me.txtStockMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalizacionDel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUPC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDUN14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueColorAgregar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpVentas.ResumeLayout(False)
        CType(Me.lycVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycVentas.ResumeLayout(False)
        CType(Me.spinP_PrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinP_EmpaqueVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinP_EmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinP_Unidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinP_Contenido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueP_GrupoArticulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgP_EnCatalgo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem28, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Auditoria.ResumeLayout(False)
        CType(Me.lycAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAuditoria.ResumeLayout(False)
        CType(Me.spinPrecio_TiendaContinental.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_HNOperadoraSur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_GTCemaco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_GTDespensa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_GTPaiz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_SVMayorista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Barbados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Belice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Mexico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_PuertoRico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_RepDominicana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Panama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_CostaRica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Nicaragua.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_Honduras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_ElSalvador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_CPUnidadDocena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_CPUnidadindividual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_CentroAmericaSur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_CentroAmericaNorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecio_MayoristaTarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpIngenieria.ResumeLayout(False)
        CType(Me.lycAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAlmacen.ResumeLayout(False)
        CType(Me.txtArticuloCapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArticuloMedidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMaterialEmpaqueMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMaterialEmpaqueEstandar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDiseno.ResumeLayout(False)
        CType(Me.lycDiseno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDiseno.ResumeLayout(False)
        CType(Me.picArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtension.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagenRutaDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagenRutaOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagenNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpListaMateriales.ResumeLayout(False)
        CType(Me.lycP_ListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycP_ListaMateriales.ResumeLayout(False)
        CType(Me.grdH_ListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewP_ListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpExportacion.ResumeLayout(False)
        CType(Me.lycExportacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycExportacion.ResumeLayout(False)
        CType(Me.txtPartidaArancelaria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycMantenimientoArticulos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gpcCodigosHijos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lycCodigosHijos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdCodigosHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigosHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueColorAgregar As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcMantenimientoPadre As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpContabilidad As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpVentas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpIngenieria As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDiseno As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdListaMaterialesHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaMaterialesHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xtpListaMateriales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lycAlmacen As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtDUN14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUPC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents bccCodigoBarras As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents bccDUN14 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xtc_Hijos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpH_ListaMateriales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lycListaMateriales As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xtpHijosAlmacen As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lycAlmacenHijos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtStockMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLocalizacionDel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockMinimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lycDiseno As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtImagenRutaDestino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtImagenRutaOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImagenNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtExtension As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcDiseno As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnCargarImagen1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCargarImagen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnGrabarImagen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents picArticulo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtSenalizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTiketCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreIngles As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycVentas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents spinP_Unidades As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinP_Contenido As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents slueP_GrupoArticulos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rdgP_EnCatalgo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xtpExportacion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lycExportacion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtPartidaArancelaria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents spinP_PrecioMayorista As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinP_EmpaqueVenta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinP_EmpaqueEstandar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Auditoria As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtArticuloCapacidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArticuloMedidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpinEdit14 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit13 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit12 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit11 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit10 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit9 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents slueMaterialEmpaqueMaster As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpinEdit8 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit7 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit6 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit5 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents slueMaterialEmpaqueEstandar As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem17 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem16 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup13 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem18 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem19 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem15 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup14 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem21 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dteP_FechaLanzamiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteP_FechaAnuncio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteP_FechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycAuditoria As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents spinPrecio_TiendaContinental As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_HNOperadoraSur As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_GTCemaco As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_GTDespensa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_GTPaiz As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_SVMayorista As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Barbados As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Belice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Mexico As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_PuertoRico As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_RepDominicana As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Panama As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_CostaRica As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Nicaragua As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_Honduras As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_ElSalvador As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_CPUnidadDocena As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_CPUnidadindividual As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_CentroAmericaSur As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_CentroAmericaNorte As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPrecio_MayoristaTarjeta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup15 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem20 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem22 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup16 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup17 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem24 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup18 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem23 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem77 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodigoPadre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsMantenimientoArticulos1 As waProduccion_Pedidos.dsMantenimientoArticulos
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpColores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lycColores As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup19 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcAlmacen As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmptySpaceItem25 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents barAlmacen As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAsignarUPC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueBodega As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rspinCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents EmptySpaceItem28 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem27 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Alerta1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents sbdcListaMateriales As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl12 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager4 As DevExpress.XtraBars.BarManager
    Friend WithEvents barListaMateriales As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnListaMateriales_CopiarDe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizarListaMateriales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnVentasEstadisticas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Auditoria_Guardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtpH_Ventas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpH_Auditoria As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpH_Ingenieria As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpH_Contabilidad As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents lycH_Ventas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents rdgH_EnCatalogo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents slueH_GrupoArticulos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup20 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinH_EmpaqueVenta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinH_EmpaqueEstandar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinH_PrecioMayorista As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinH_Unidades As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinH_Contenido As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem84 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem85 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem86 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem87 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem88 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem29 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem26 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lycH_Ingenieria As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnH_Ingenieria_Grabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spinH_ArticulosXHora As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinH_EnsambleEquipo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit26 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit25 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit24 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit23 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit22 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit21 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpinEdit20 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit19 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit18 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit17 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit16 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit15 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents slueH_DeptoEnsamble As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueH_MaterialEmpaqueVenta As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtH_Capacidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtH_Material As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup21 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycH_Ingenieria1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem90 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem89 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycgH_EmpaqueVenta As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem91 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem94 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem95 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem96 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem93 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem97 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem31 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem98 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem32 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup22 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem100 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem33 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem104 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem101 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem102 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem105 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem34 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem103 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem99 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem30 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup23 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem107 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem106 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem92 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem108 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem35 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lycP_ListaMateriales As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdH_ListaMateriales As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewP_ListaMateriales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup24 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem109 As DevExpress.XtraLayout.LayoutControlItem
End Class
