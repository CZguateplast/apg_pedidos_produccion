<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenEnsambleProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenEnsambleProduccion))
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProducir = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rcalCalculadora = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.lycOrdenEnsambleProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.splitResultado = New DevExpress.XtraEditors.SplitContainerControl()
        Me.splitOrdenesEnsamble = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycSplit1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdHijos = New DevExpress.XtraGrid.GridControl()
        Me.DsOrdenEnsambleProduccion1 = New waProduccion_Pedidos.dsOrdenEnsambleProduccion()
        Me.grdviewHijos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gbdDatosArticulo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDeLinea = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colColor3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdValoresPositivos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStock1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProduccion1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEnsamble = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalPositivo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdValoresNegativos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRol = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCampana = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProyeccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDeudaEnsamble = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalNegativo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gdbResultado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDisponible = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSugerido = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycOrdenesEnsamble2 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkCC = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDuplicar = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcOrdenEnsambleProduccion = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.chkResultadoOrdenes = New DevExpress.XtraEditors.CheckButton()
        Me.chkArticulosSugeridos = New DevExpress.XtraEditors.CheckButton()
        Me.grdArticulos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rsluePrioridadAR = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadEnsamble = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigenAR = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueDestinoAR = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueColores = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueGrupoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumOrdenVenta = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumCampana = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdteFechaEntrega = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbbOrigenAR = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.rspinPrioridad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdComponentesProducidos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewComponentesProducidos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colOrigenAR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rslueDestino = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinoCP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoArticulo2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrioridadCP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rsluePrioridadCP = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rslueCodigoCP = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colComentario = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colComprometido = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAlmacen = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMetasa = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPradera = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProduccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMinLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaxLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rslueOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rspinPrioridadCP = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.txtIdNivel1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycResultado = New DevExpress.XtraLayout.LayoutControl()
        Me.grdProducciones = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProducciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridadOCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Nivel11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Nivel21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroSAP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen2 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoCliente2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOrden1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrega1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario_Nivel11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario_Nivel21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSAP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_UsuarioCreacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_FechaCreacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdEnsambles = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEnsambles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId_Nivel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Nivel2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridadOAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinPrioridadOAR = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCodigoArticulo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoCliente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario_Nivel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario_Nivel2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_UsuarioCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_FechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizarControles = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtListaMateriales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaRol = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaCampana = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaProyeccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAnalisisVenta = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnComponente = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.barbtn = New DevExpress.XtraBars.BarButtonItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.rcalCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycOrdenEnsambleProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenEnsambleProduccion.SuspendLayout()
        CType(Me.splitResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitResultado.SuspendLayout()
        CType(Me.splitOrdenesEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOrdenesEnsamble.SuspendLayout()
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit1.SuspendLayout()
        CType(Me.grdHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenEnsambleProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycOrdenesEnsamble2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenesEnsamble2.SuspendLayout()
        CType(Me.chkCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rsluePrioridadAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigenAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueDestinoAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbOrigenAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdComponentesProducidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewComponentesProducidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rsluePrioridadCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPrioridadCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdNivel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycResultado.SuspendLayout()
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPrioridadOAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCantidad.Caption = "Unidad Base"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowMove = False
        Me.colCantidad.OptionsColumn.AllowSize = False
        Me.colCantidad.OptionsColumn.TabStop = False
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 70
        '
        'colProducir
        '
        Me.colProducir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProducir.AppearanceHeader.Options.UseFont = True
        Me.colProducir.AppearanceHeader.Options.UseTextOptions = True
        Me.colProducir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProducir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProducir.Caption = "Cantidad A Producir"
        Me.colProducir.ColumnEdit = Me.rcalCalculadora
        Me.colProducir.FieldName = "Producir"
        Me.colProducir.Name = "colProducir"
        Me.colProducir.Visible = True
        '
        'rcalCalculadora
        '
        Me.rcalCalculadora.AutoHeight = False
        Me.rcalCalculadora.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcalCalculadora.Name = "rcalCalculadora"
        '
        'lycOrdenEnsambleProduccion
        '
        Me.lycOrdenEnsambleProduccion.Controls.Add(Me.splitResultado)
        Me.lycOrdenEnsambleProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenEnsambleProduccion.Location = New System.Drawing.Point(0, 40)
        Me.lycOrdenEnsambleProduccion.Name = "lycOrdenEnsambleProduccion"
        Me.lycOrdenEnsambleProduccion.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(537, 501, 250, 350)
        Me.lycOrdenEnsambleProduccion.Root = Me.LayoutControlGroup1
        Me.lycOrdenEnsambleProduccion.Size = New System.Drawing.Size(1366, 663)
        Me.lycOrdenEnsambleProduccion.TabIndex = 0
        Me.lycOrdenEnsambleProduccion.Text = "LayoutControl1"
        '
        'splitResultado
        '
        Me.splitResultado.Horizontal = False
        Me.splitResultado.Location = New System.Drawing.Point(12, 12)
        Me.splitResultado.Name = "splitResultado"
        Me.splitResultado.Panel1.Controls.Add(Me.splitOrdenesEnsamble)
        Me.splitResultado.Panel1.Text = "Panel1"
        Me.splitResultado.Panel2.Controls.Add(Me.lycResultado)
        Me.splitResultado.Panel2.Text = "Panel2"
        Me.splitResultado.Size = New System.Drawing.Size(1342, 639)
        Me.splitResultado.SplitterPosition = 485
        Me.splitResultado.TabIndex = 12
        Me.splitResultado.Text = "SplitContainerControl1"
        '
        'splitOrdenesEnsamble
        '
        Me.splitOrdenesEnsamble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitOrdenesEnsamble.Horizontal = False
        Me.splitOrdenesEnsamble.Location = New System.Drawing.Point(0, 0)
        Me.splitOrdenesEnsamble.Name = "splitOrdenesEnsamble"
        Me.splitOrdenesEnsamble.Panel1.Controls.Add(Me.lycSplit1)
        Me.splitOrdenesEnsamble.Panel1.Text = "Panel1"
        Me.splitOrdenesEnsamble.Panel2.Controls.Add(Me.lycOrdenesEnsamble2)
        Me.splitOrdenesEnsamble.Panel2.Text = "Panel2"
        Me.splitOrdenesEnsamble.Size = New System.Drawing.Size(1342, 485)
        Me.splitOrdenesEnsamble.SplitterPosition = 163
        Me.splitOrdenesEnsamble.TabIndex = 11
        Me.splitOrdenesEnsamble.Text = "SplitContainerControl1"
        '
        'lycSplit1
        '
        Me.lycSplit1.Controls.Add(Me.grdHijos)
        Me.lycSplit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit1.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit1.Name = "lycSplit1"
        Me.lycSplit1.Root = Me.LayoutControlGroup2
        Me.lycSplit1.Size = New System.Drawing.Size(1342, 163)
        Me.lycSplit1.TabIndex = 0
        Me.lycSplit1.Text = "LayoutControl1"
        '
        'grdHijos
        '
        Me.grdHijos.DataMember = "dsdtCodigosArticulos"
        Me.grdHijos.DataSource = Me.DsOrdenEnsambleProduccion1
        Me.grdHijos.Location = New System.Drawing.Point(12, 12)
        Me.grdHijos.MainView = Me.grdviewHijos
        Me.grdHijos.Name = "grdHijos"
        Me.grdHijos.Size = New System.Drawing.Size(1318, 139)
        Me.grdHijos.TabIndex = 0
        Me.grdHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewHijos})
        Me.grdHijos.Visible = False
        '
        'DsOrdenEnsambleProduccion1
        '
        Me.DsOrdenEnsambleProduccion1.DataSetName = "dsOrdenEnsambleProduccion"
        Me.DsOrdenEnsambleProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewHijos
        '
        Me.grdviewHijos.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewHijos.Appearance.BandPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.BandPanel.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.BandPanel.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.BandPanel.Options.UseFont = True
        Me.grdviewHijos.Appearance.BandPanel.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.BandPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.HeaderPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewHijos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbdDatosArticulo, Me.gbdValoresPositivos, Me.gbdValoresNegativos, Me.gdbResultado})
        Me.grdviewHijos.ColumnPanelRowHeight = 35
        Me.grdviewHijos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDeLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colColor3, Me.colStock1, Me.colProduccion1, Me.colEnsamble, Me.colTotalPositivo, Me.colRol, Me.colCampana, Me.colProyeccion, Me.colDeudaEnsamble, Me.colTotalNegativo, Me.colDisponible, Me.colSugerido, Me.colStockMinimo, Me.colStockMaximo})
        Me.grdviewHijos.GridControl = Me.grdHijos
        Me.grdviewHijos.Name = "grdviewHijos"
        Me.grdviewHijos.OptionsBehavior.Editable = False
        Me.grdviewHijos.OptionsBehavior.FocusLeaveOnTab = True
        Me.grdviewHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewHijos.PaintStyleName = "Flat"
        Me.grdviewHijos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStockMinimo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodigoArticulo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gbdDatosArticulo
        '
        Me.gbdDatosArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdDatosArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdDatosArticulo.Caption = "Datos del Articulo"
        Me.gbdDatosArticulo.Columns.Add(Me.colDeLinea)
        Me.gbdDatosArticulo.Columns.Add(Me.colCodigoArticulo)
        Me.gbdDatosArticulo.Columns.Add(Me.colNombreArticulo)
        Me.gbdDatosArticulo.Columns.Add(Me.colColor3)
        Me.gbdDatosArticulo.Columns.Add(Me.colStockMinimo)
        Me.gbdDatosArticulo.Columns.Add(Me.colStockMaximo)
        Me.gbdDatosArticulo.Name = "gbdDatosArticulo"
        Me.gbdDatosArticulo.VisibleIndex = 0
        Me.gbdDatosArticulo.Width = 614
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceCell.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colDeLinea.AppearanceHeader.Options.UseFont = True
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.ReadOnly = True
        Me.colDeLinea.Visible = True
        Me.colDeLinea.Width = 40
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.Width = 120
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.Width = 300
        '
        'colColor3
        '
        Me.colColor3.AppearanceCell.Options.UseTextOptions = True
        Me.colColor3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colColor3.AppearanceHeader.Options.UseFont = True
        Me.colColor3.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor3.FieldName = "Color"
        Me.colColor3.Name = "colColor3"
        Me.colColor3.OptionsColumn.ReadOnly = True
        Me.colColor3.Visible = True
        Me.colColor3.Width = 40
        '
        'colStockMinimo
        '
        Me.colStockMinimo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStockMinimo.AppearanceHeader.Options.UseFont = True
        Me.colStockMinimo.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockMinimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockMinimo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockMinimo.FieldName = "StockMinimo"
        Me.colStockMinimo.Name = "colStockMinimo"
        Me.colStockMinimo.OptionsColumn.ReadOnly = True
        Me.colStockMinimo.Visible = True
        Me.colStockMinimo.Width = 57
        '
        'colStockMaximo
        '
        Me.colStockMaximo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStockMaximo.AppearanceHeader.Options.UseFont = True
        Me.colStockMaximo.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockMaximo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockMaximo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockMaximo.FieldName = "StockMaximo"
        Me.colStockMaximo.Name = "colStockMaximo"
        Me.colStockMaximo.OptionsColumn.ReadOnly = True
        Me.colStockMaximo.Visible = True
        Me.colStockMaximo.Width = 57
        '
        'gbdValoresPositivos
        '
        Me.gbdValoresPositivos.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdValoresPositivos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdValoresPositivos.Caption = "Valores Positivos"
        Me.gbdValoresPositivos.Columns.Add(Me.colStock1)
        Me.gbdValoresPositivos.Columns.Add(Me.colProduccion1)
        Me.gbdValoresPositivos.Columns.Add(Me.colEnsamble)
        Me.gbdValoresPositivos.Columns.Add(Me.colTotalPositivo)
        Me.gbdValoresPositivos.Name = "gbdValoresPositivos"
        Me.gbdValoresPositivos.VisibleIndex = 1
        Me.gbdValoresPositivos.Width = 228
        '
        'colStock1
        '
        Me.colStock1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStock1.AppearanceHeader.Options.UseFont = True
        Me.colStock1.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStock1.FieldName = "Stock"
        Me.colStock1.Name = "colStock1"
        Me.colStock1.OptionsColumn.ReadOnly = True
        Me.colStock1.Visible = True
        Me.colStock1.Width = 57
        '
        'colProduccion1
        '
        Me.colProduccion1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colProduccion1.AppearanceHeader.Options.UseFont = True
        Me.colProduccion1.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccion1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProduccion1.FieldName = "Produccion"
        Me.colProduccion1.Name = "colProduccion1"
        Me.colProduccion1.OptionsColumn.ReadOnly = True
        Me.colProduccion1.Visible = True
        Me.colProduccion1.Width = 57
        '
        'colEnsamble
        '
        Me.colEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsamble.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnsamble.FieldName = "Ensamble"
        Me.colEnsamble.Name = "colEnsamble"
        Me.colEnsamble.OptionsColumn.ReadOnly = True
        Me.colEnsamble.Visible = True
        Me.colEnsamble.Width = 57
        '
        'colTotalPositivo
        '
        Me.colTotalPositivo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colTotalPositivo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalPositivo.AppearanceCell.Options.UseBackColor = True
        Me.colTotalPositivo.AppearanceCell.Options.UseFont = True
        Me.colTotalPositivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalPositivo.AppearanceHeader.Options.UseFont = True
        Me.colTotalPositivo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalPositivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalPositivo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalPositivo.FieldName = "TotalPositivo"
        Me.colTotalPositivo.Name = "colTotalPositivo"
        Me.colTotalPositivo.OptionsColumn.ReadOnly = True
        Me.colTotalPositivo.Visible = True
        Me.colTotalPositivo.Width = 57
        '
        'gbdValoresNegativos
        '
        Me.gbdValoresNegativos.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdValoresNegativos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdValoresNegativos.Caption = "Valores Negativos"
        Me.gbdValoresNegativos.Columns.Add(Me.colRol)
        Me.gbdValoresNegativos.Columns.Add(Me.colCampana)
        Me.gbdValoresNegativos.Columns.Add(Me.colProyeccion)
        Me.gbdValoresNegativos.Columns.Add(Me.colDeudaEnsamble)
        Me.gbdValoresNegativos.Columns.Add(Me.colTotalNegativo)
        Me.gbdValoresNegativos.Name = "gbdValoresNegativos"
        Me.gbdValoresNegativos.VisibleIndex = 2
        Me.gbdValoresNegativos.Width = 285
        '
        'colRol
        '
        Me.colRol.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colRol.AppearanceHeader.Options.UseFont = True
        Me.colRol.AppearanceHeader.Options.UseTextOptions = True
        Me.colRol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRol.FieldName = "Rol"
        Me.colRol.Name = "colRol"
        Me.colRol.OptionsColumn.ReadOnly = True
        Me.colRol.Visible = True
        Me.colRol.Width = 57
        '
        'colCampana
        '
        Me.colCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCampana.AppearanceHeader.Options.UseFont = True
        Me.colCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampana.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCampana.FieldName = "Campana"
        Me.colCampana.Name = "colCampana"
        Me.colCampana.OptionsColumn.ReadOnly = True
        Me.colCampana.Visible = True
        Me.colCampana.Width = 57
        '
        'colProyeccion
        '
        Me.colProyeccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colProyeccion.AppearanceHeader.Options.UseFont = True
        Me.colProyeccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colProyeccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProyeccion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProyeccion.FieldName = "Proyeccion"
        Me.colProyeccion.Name = "colProyeccion"
        Me.colProyeccion.OptionsColumn.ReadOnly = True
        Me.colProyeccion.Visible = True
        Me.colProyeccion.Width = 57
        '
        'colDeudaEnsamble
        '
        Me.colDeudaEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colDeudaEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colDeudaEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeudaEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeudaEnsamble.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeudaEnsamble.FieldName = "DeudaEnsamble"
        Me.colDeudaEnsamble.Name = "colDeudaEnsamble"
        Me.colDeudaEnsamble.OptionsColumn.ReadOnly = True
        Me.colDeudaEnsamble.Visible = True
        Me.colDeudaEnsamble.Width = 57
        '
        'colTotalNegativo
        '
        Me.colTotalNegativo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colTotalNegativo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalNegativo.AppearanceCell.Options.UseBackColor = True
        Me.colTotalNegativo.AppearanceCell.Options.UseFont = True
        Me.colTotalNegativo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalNegativo.AppearanceHeader.Options.UseFont = True
        Me.colTotalNegativo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalNegativo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalNegativo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalNegativo.FieldName = "TotalNegativo"
        Me.colTotalNegativo.Name = "colTotalNegativo"
        Me.colTotalNegativo.OptionsColumn.ReadOnly = True
        Me.colTotalNegativo.Visible = True
        Me.colTotalNegativo.Width = 57
        '
        'gdbResultado
        '
        Me.gdbResultado.AppearanceHeader.Options.UseTextOptions = True
        Me.gdbResultado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdbResultado.Caption = "Resultado"
        Me.gdbResultado.Columns.Add(Me.colDisponible)
        Me.gdbResultado.Columns.Add(Me.colSugerido)
        Me.gdbResultado.Name = "gdbResultado"
        Me.gdbResultado.VisibleIndex = 3
        Me.gdbResultado.Width = 114
        '
        'colDisponible
        '
        Me.colDisponible.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colDisponible.AppearanceHeader.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Options.UseTextOptions = True
        Me.colDisponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDisponible.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDisponible.FieldName = "Disponible"
        Me.colDisponible.Name = "colDisponible"
        Me.colDisponible.OptionsColumn.ReadOnly = True
        Me.colDisponible.Visible = True
        Me.colDisponible.Width = 57
        '
        'colSugerido
        '
        Me.colSugerido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colSugerido.AppearanceHeader.Options.UseFont = True
        Me.colSugerido.AppearanceHeader.Options.UseTextOptions = True
        Me.colSugerido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSugerido.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSugerido.FieldName = "Sugerido"
        Me.colSugerido.Name = "colSugerido"
        Me.colSugerido.OptionsColumn.ReadOnly = True
        Me.colSugerido.Visible = True
        Me.colSugerido.Width = 57
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1342, 163)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdHijos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1322, 143)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'lycOrdenesEnsamble2
        '
        Me.lycOrdenesEnsamble2.Controls.Add(Me.chkCC)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.chkResultadoOrdenes)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.chkArticulosSugeridos)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.sbdcOrdenEnsambleProduccion)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.grdArticulos)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.grdComponentesProducidos)
        Me.lycOrdenesEnsamble2.Controls.Add(Me.txtIdNivel1)
        Me.lycOrdenesEnsamble2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenesEnsamble2.Location = New System.Drawing.Point(0, 0)
        Me.lycOrdenesEnsamble2.Name = "lycOrdenesEnsamble2"
        Me.lycOrdenesEnsamble2.Root = Me.LayoutControlGroup3
        Me.lycOrdenesEnsamble2.Size = New System.Drawing.Size(1342, 312)
        Me.lycOrdenesEnsamble2.TabIndex = 0
        Me.lycOrdenesEnsamble2.Text = "LayoutControl1"
        '
        'chkCC
        '
        Me.chkCC.Location = New System.Drawing.Point(58, 166)
        Me.chkCC.MenuManager = Me.BarManager1
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Properties.Caption = "CC"
        Me.chkCC.Size = New System.Drawing.Size(50, 20)
        Me.chkCC.StyleController = Me.lycOrdenesEnsamble2
        Me.chkCC.TabIndex = 10
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcOrdenEnsambleProduccion)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnEliminar, Me.barbtnDuplicar})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicar, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcOrdenEnsambleProduccion
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Eliminar Componente"
        Me.barbtnEliminar.Id = 1
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'barbtnDuplicar
        '
        Me.barbtnDuplicar.Caption = "Duplicar Orden Ensamble"
        Me.barbtnDuplicar.Id = 2
        Me.barbtnDuplicar.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicar.Name = "barbtnDuplicar"
        '
        'sbdcOrdenEnsambleProduccion
        '
        Me.sbdcOrdenEnsambleProduccion.CausesValidation = False
        Me.sbdcOrdenEnsambleProduccion.IsVertical = True
        Me.sbdcOrdenEnsambleProduccion.Location = New System.Drawing.Point(12, 38)
        Me.sbdcOrdenEnsambleProduccion.Manager = Me.BarManager1
        Me.sbdcOrdenEnsambleProduccion.Name = "sbdcOrdenEnsambleProduccion"
        Me.sbdcOrdenEnsambleProduccion.Size = New System.Drawing.Size(42, 153)
        Me.sbdcOrdenEnsambleProduccion.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1366, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 703)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1366, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 663)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1366, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 663)
        '
        'chkResultadoOrdenes
        '
        Me.chkResultadoOrdenes.ImageOptions.Image = CType(resources.GetObject("chkResultadoOrdenes.ImageOptions.Image"), System.Drawing.Image)
        Me.chkResultadoOrdenes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.chkResultadoOrdenes.Location = New System.Drawing.Point(12, 278)
        Me.chkResultadoOrdenes.Name = "chkResultadoOrdenes"
        Me.chkResultadoOrdenes.Size = New System.Drawing.Size(1318, 22)
        Me.chkResultadoOrdenes.StyleController = Me.lycOrdenesEnsamble2
        Me.chkResultadoOrdenes.TabIndex = 4
        Me.chkResultadoOrdenes.Text = "Mostrar Resultado de Ordenes"
        '
        'chkArticulosSugeridos
        '
        Me.chkArticulosSugeridos.Checked = True
        Me.chkArticulosSugeridos.ImageOptions.Image = CType(resources.GetObject("chkArticulosSugeridos.ImageOptions.Image"), System.Drawing.Image)
        Me.chkArticulosSugeridos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.chkArticulosSugeridos.Location = New System.Drawing.Point(12, 12)
        Me.chkArticulosSugeridos.Name = "chkArticulosSugeridos"
        Me.chkArticulosSugeridos.Size = New System.Drawing.Size(1318, 22)
        Me.chkArticulosSugeridos.StyleController = Me.lycOrdenesEnsamble2
        Me.chkArticulosSugeridos.TabIndex = 1
        Me.chkArticulosSugeridos.Text = "Ocultar Articulos Sugeridos"
        '
        'grdArticulos
        '
        Me.grdArticulos.DataMember = "dsdtArticulos"
        Me.grdArticulos.DataSource = Me.DsOrdenEnsambleProduccion1
        Me.grdArticulos.Location = New System.Drawing.Point(58, 38)
        Me.grdArticulos.MainView = Me.grdviewArticulos
        Me.grdArticulos.MaximumSize = New System.Drawing.Size(0, 100)
        Me.grdArticulos.MinimumSize = New System.Drawing.Size(0, 100)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbbOrigenAR, Me.rslueColores, Me.rslueGrupoCliente, Me.rslueCodigoCliente, Me.rslueNumOrdenVenta, Me.rslueNumCampana, Me.rslueDestinoAR, Me.rslueOrigenAR, Me.rspinPrioridad, Me.rdteFechaEntrega, Me.rsluePrioridadAR})
        Me.grdArticulos.Size = New System.Drawing.Size(1272, 100)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewArticulos})
        '
        'grdviewArticulos
        '
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.grdviewArticulos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.grdviewArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.grdviewArticulos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.grdviewArticulos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.grdviewArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.grdviewArticulos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.grdviewArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseFont = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.grdviewArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewArticulos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grdviewArticulos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewArticulos.ColumnPanelRowHeight = 35
        Me.grdviewArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colPrioridad, Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colCantidadEnsamble, Me.colOrigen, Me.colDestino, Me.colColor, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNombreCliente, Me.colNumOrden, Me.colNumCampana, Me.colNombreCampana, Me.colFechaEntrega, Me.colComentarios})
        Me.grdviewArticulos.GridControl = Me.grdArticulos
        Me.grdviewArticulos.Name = "grdviewArticulos"
        Me.grdviewArticulos.OptionsBehavior.FocusLeaveOnTab = True
        Me.grdviewArticulos.OptionsView.ColumnAutoWidth = False
        Me.grdviewArticulos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewArticulos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewArticulos.OptionsView.ShowGroupPanel = False
        Me.grdviewArticulos.PaintStyleName = "Web"
        Me.grdviewArticulos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNombreArticulo1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Width = 39
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPrioridad.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPrioridad.AppearanceHeader.Options.UseFont = True
        Me.colPrioridad.AppearanceHeader.Options.UseForeColor = True
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.Caption = "Prioridad"
        Me.colPrioridad.ColumnEdit = Me.rsluePrioridadAR
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 80
        '
        'rsluePrioridadAR
        '
        Me.rsluePrioridadAR.AutoHeight = False
        Me.rsluePrioridadAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rsluePrioridadAR.Name = "rsluePrioridadAR"
        Me.rsluePrioridadAR.NullText = ""
        Me.rsluePrioridadAR.PopupView = Me.GridView13
        '
        'GridView13
        '
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo1.AppearanceCell.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoArticulo1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoArticulo1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoArticulo1.OptionsColumn.AllowMove = False
        Me.colCodigoArticulo1.OptionsColumn.AllowSize = False
        Me.colCodigoArticulo1.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 1
        Me.colCodigoArticulo1.Width = 120
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo1.AppearanceCell.Options.UseFont = True
        Me.colNombreArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombreArticulo1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNombreArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo1.AppearanceHeader.Options.UseForeColor = True
        Me.colNombreArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombreArticulo1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombreArticulo1.OptionsColumn.AllowMove = False
        Me.colNombreArticulo1.OptionsColumn.AllowSize = False
        Me.colNombreArticulo1.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 2
        Me.colNombreArticulo1.Width = 300
        '
        'colCantidadEnsamble
        '
        Me.colCantidadEnsamble.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidadEnsamble.AppearanceCell.Options.UseFont = True
        Me.colCantidadEnsamble.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidadEnsamble.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCantidadEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCantidadEnsamble.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCantidadEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colCantidadEnsamble.AppearanceHeader.Options.UseForeColor = True
        Me.colCantidadEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidadEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidadEnsamble.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCantidadEnsamble.Caption = "Cantidad Ensamble"
        Me.colCantidadEnsamble.FieldName = "CantidadEnsamble"
        Me.colCantidadEnsamble.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCantidadEnsamble.Name = "colCantidadEnsamble"
        Me.colCantidadEnsamble.Visible = True
        Me.colCantidadEnsamble.VisibleIndex = 3
        Me.colCantidadEnsamble.Width = 70
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceCell.Options.UseFont = True
        Me.colOrigen.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colOrigen.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseForeColor = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.ColumnEdit = Me.rslueOrigenAR
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 4
        Me.colOrigen.Width = 80
        '
        'rslueOrigenAR
        '
        Me.rslueOrigenAR.AutoHeight = False
        Me.rslueOrigenAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigenAR.Name = "rslueOrigenAR"
        Me.rslueOrigenAR.NullText = ""
        Me.rslueOrigenAR.PopupView = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colDestino
        '
        Me.colDestino.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceCell.Options.UseFont = True
        Me.colDestino.AppearanceCell.Options.UseTextOptions = True
        Me.colDestino.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDestino.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseForeColor = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.ColumnEdit = Me.rslueDestinoAR
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colDestino.Name = "colDestino"
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 5
        Me.colDestino.Width = 80
        '
        'rslueDestinoAR
        '
        Me.rslueDestinoAR.AutoHeight = False
        Me.rslueDestinoAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestinoAR.Name = "rslueDestinoAR"
        Me.rslueDestinoAR.NullText = ""
        Me.rslueDestinoAR.PopupView = Me.GridView8
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colColor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseForeColor = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.ColumnEdit = Me.rslueColores
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 10
        Me.colColor.Width = 50
        '
        'rslueColores
        '
        Me.rslueColores.AutoHeight = False
        Me.rslueColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueColores.Name = "rslueColores"
        Me.rslueColores.NullText = ""
        Me.rslueColores.PopupView = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupoCliente.AppearanceHeader.Options.UseFont = True
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.Caption = "G Cliente"
        Me.colGrupoCliente.ColumnEdit = Me.rslueGrupoCliente
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 14
        '
        'rslueGrupoCliente
        '
        Me.rslueGrupoCliente.AutoHeight = False
        Me.rslueGrupoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueGrupoCliente.Name = "rslueGrupoCliente"
        Me.rslueGrupoCliente.NullText = ""
        Me.rslueGrupoCliente.PopupView = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoCliente.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoCliente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.Caption = "Cod Cliente"
        Me.colCodigoCliente.ColumnEdit = Me.rslueCodigoCliente
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 12
        Me.colCodigoCliente.Width = 84
        '
        'rslueCodigoCliente
        '
        Me.rslueCodigoCliente.AutoHeight = False
        Me.rslueCodigoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoCliente.Name = "rslueCodigoCliente"
        Me.rslueCodigoCliente.NullText = ""
        Me.rslueCodigoCliente.PopupView = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombreCliente.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNombreCliente.AppearanceHeader.Options.UseFont = True
        Me.colNombreCliente.AppearanceHeader.Options.UseForeColor = True
        Me.colNombreCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 13
        Me.colNombreCliente.Width = 216
        '
        'colNumOrden
        '
        Me.colNumOrden.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumOrden.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNumOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden.AppearanceHeader.Options.UseForeColor = True
        Me.colNumOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.ColumnEdit = Me.rslueNumOrdenVenta
        Me.colNumOrden.FieldName = "NumOrden"
        Me.colNumOrden.Name = "colNumOrden"
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 11
        Me.colNumOrden.Width = 85
        '
        'rslueNumOrdenVenta
        '
        Me.rslueNumOrdenVenta.AutoHeight = False
        Me.rslueNumOrdenVenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumOrdenVenta.Name = "rslueNumOrdenVenta"
        Me.rslueNumOrdenVenta.NullText = ""
        Me.rslueNumOrdenVenta.PopupView = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colNumCampana
        '
        Me.colNumCampana.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumCampana.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNumCampana.AppearanceHeader.Options.UseFont = True
        Me.colNumCampana.AppearanceHeader.Options.UseForeColor = True
        Me.colNumCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCampana.Caption = "# Campaña"
        Me.colNumCampana.ColumnEdit = Me.rslueNumCampana
        Me.colNumCampana.FieldName = "NumCampana"
        Me.colNumCampana.Name = "colNumCampana"
        Me.colNumCampana.Visible = True
        Me.colNumCampana.VisibleIndex = 8
        '
        'rslueNumCampana
        '
        Me.rslueNumCampana.AutoHeight = False
        Me.rslueNumCampana.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumCampana.Name = "rslueNumCampana"
        Me.rslueNumCampana.NullText = ""
        Me.rslueNumCampana.PopupView = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colNombreCampana
        '
        Me.colNombreCampana.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombreCampana.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNombreCampana.AppearanceHeader.Options.UseFont = True
        Me.colNombreCampana.AppearanceHeader.Options.UseForeColor = True
        Me.colNombreCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCampana.FieldName = "NombreCampana"
        Me.colNombreCampana.Name = "colNombreCampana"
        Me.colNombreCampana.Visible = True
        Me.colNombreCampana.VisibleIndex = 9
        Me.colNombreCampana.Width = 226
        '
        'colFechaEntrega
        '
        Me.colFechaEntrega.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaEntrega.AppearanceCell.Options.UseFont = True
        Me.colFechaEntrega.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaEntrega.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFechaEntrega.AppearanceHeader.Options.UseFont = True
        Me.colFechaEntrega.AppearanceHeader.Options.UseForeColor = True
        Me.colFechaEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.Caption = "Entrega"
        Me.colFechaEntrega.ColumnEdit = Me.rdteFechaEntrega
        Me.colFechaEntrega.FieldName = "FechaEntrega"
        Me.colFechaEntrega.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colFechaEntrega.Name = "colFechaEntrega"
        Me.colFechaEntrega.Visible = True
        Me.colFechaEntrega.VisibleIndex = 6
        '
        'rdteFechaEntrega
        '
        Me.rdteFechaEntrega.AutoHeight = False
        Me.rdteFechaEntrega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaEntrega.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaEntrega.Name = "rdteFechaEntrega"
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceCell.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colComentarios.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseForeColor = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 7
        Me.colComentarios.Width = 255
        '
        'cbbOrigenAR
        '
        Me.cbbOrigenAR.AutoHeight = False
        Me.cbbOrigenAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbOrigenAR.Name = "cbbOrigenAR"
        '
        'rspinPrioridad
        '
        Me.rspinPrioridad.AutoHeight = False
        Me.rspinPrioridad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPrioridad.DisplayFormat.FormatString = "{0:n0}"
        Me.rspinPrioridad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridad.EditFormat.FormatString = "{0:n0}"
        Me.rspinPrioridad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridad.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.rspinPrioridad.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.rspinPrioridad.Name = "rspinPrioridad"
        '
        'grdComponentesProducidos
        '
        Me.grdComponentesProducidos.DataMember = "dsdtComponentesProducidos"
        Me.grdComponentesProducidos.DataSource = Me.DsOrdenEnsambleProduccion1
        Me.grdComponentesProducidos.Location = New System.Drawing.Point(112, 142)
        Me.grdComponentesProducidos.MainView = Me.grdviewComponentesProducidos
        Me.grdComponentesProducidos.Name = "grdComponentesProducidos"
        Me.grdComponentesProducidos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen, Me.rslueDestino, Me.rslueCodigoCP, Me.rspinPrioridadCP, Me.rsluePrioridadCP, Me.rcalCalculadora})
        Me.grdComponentesProducidos.Size = New System.Drawing.Size(1218, 132)
        Me.grdComponentesProducidos.TabIndex = 3
        Me.grdComponentesProducidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewComponentesProducidos})
        '
        'grdviewComponentesProducidos
        '
        Me.grdviewComponentesProducidos.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewComponentesProducidos.Appearance.BandPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.BandPanel.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.BandPanel.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.BandPanel.Options.UseFont = True
        Me.grdviewComponentesProducidos.Appearance.BandPanel.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.BandPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HeaderPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewComponentesProducidos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.Preview.Options.UseFont = True
        Me.grdviewComponentesProducidos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentesProducidos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewComponentesProducidos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewComponentesProducidos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewComponentesProducidos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewComponentesProducidos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewComponentesProducidos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2})
        Me.grdviewComponentesProducidos.ColumnPanelRowHeight = 35
        Me.grdviewComponentesProducidos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colOrigenAR, Me.colCodigoArticulo2, Me.colPrioridadCP, Me.colCodigoCP, Me.colNombreCP, Me.colStock, Me.colUM, Me.colCantidad, Me.colAlmacen, Me.colMetasa, Me.colPradera, Me.colProduccion, Me.colComprometido, Me.colProducir, Me.colDestinoCP, Me.colComentario, Me.colMinLevel, Me.colMaxLevel})
        GridFormatRule3.Column = Me.colCantidad
        GridFormatRule3.ColumnApplyTo = Me.colCantidad
        GridFormatRule3.Name = "Format0"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Black
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Appearance.Options.UseFont = True
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue3.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.colProducir
        GridFormatRule4.ColumnApplyTo = Me.colProducir
        GridFormatRule4.Name = "Format1"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Black
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Appearance.Options.UseFont = True
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue4.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.grdviewComponentesProducidos.FormatRules.Add(GridFormatRule3)
        Me.grdviewComponentesProducidos.FormatRules.Add(GridFormatRule4)
        Me.grdviewComponentesProducidos.GridControl = Me.grdComponentesProducidos
        Me.grdviewComponentesProducidos.Name = "grdviewComponentesProducidos"
        Me.grdviewComponentesProducidos.OptionsBehavior.FocusLeaveOnTab = True
        Me.grdviewComponentesProducidos.OptionsView.ColumnAutoWidth = False
        Me.grdviewComponentesProducidos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewComponentesProducidos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewComponentesProducidos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewComponentesProducidos.OptionsView.ShowGroupPanel = False
        Me.grdviewComponentesProducidos.PaintStyleName = "Flat"
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridBand1.AppearanceHeader.Options.UseFont = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Lista de Materiales"
        Me.GridBand1.Columns.Add(Me.colOrigenAR)
        Me.GridBand1.Columns.Add(Me.colDestinoCP)
        Me.GridBand1.Columns.Add(Me.colCodigoArticulo2)
        Me.GridBand1.Columns.Add(Me.colPrioridadCP)
        Me.GridBand1.Columns.Add(Me.colCodigoCP)
        Me.GridBand1.Columns.Add(Me.colNombreCP)
        Me.GridBand1.Columns.Add(Me.colUM)
        Me.GridBand1.Columns.Add(Me.colCantidad)
        Me.GridBand1.Columns.Add(Me.colProducir)
        Me.GridBand1.Columns.Add(Me.colComentario)
        Me.GridBand1.Columns.Add(Me.colComprometido)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 1193
        '
        'colOrigenAR
        '
        Me.colOrigenAR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigenAR.AppearanceHeader.Options.UseFont = True
        Me.colOrigenAR.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigenAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigenAR.Caption = "Origen AR"
        Me.colOrigenAR.ColumnEdit = Me.rslueDestino
        Me.colOrigenAR.FieldName = "OrigenAR"
        Me.colOrigenAR.Name = "colOrigenAR"
        Me.colOrigenAR.Visible = True
        Me.colOrigenAR.Width = 93
        '
        'rslueDestino
        '
        Me.rslueDestino.AutoHeight = False
        Me.rslueDestino.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestino.Name = "rslueDestino"
        Me.rslueDestino.NullText = ""
        Me.rslueDestino.PopupView = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDestinoCP
        '
        Me.colDestinoCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestinoCP.AppearanceHeader.Options.UseFont = True
        Me.colDestinoCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestinoCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestinoCP.Caption = "DestinoCP"
        Me.colDestinoCP.ColumnEdit = Me.rslueDestino
        Me.colDestinoCP.FieldName = "DestinoCP"
        Me.colDestinoCP.Name = "colDestinoCP"
        Me.colDestinoCP.Visible = True
        Me.colDestinoCP.Width = 93
        '
        'colCodigoArticulo2
        '
        Me.colCodigoArticulo2.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo2.Name = "colCodigoArticulo2"
        Me.colCodigoArticulo2.Width = 101
        '
        'colPrioridadCP
        '
        Me.colPrioridadCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrioridadCP.AppearanceHeader.Options.UseFont = True
        Me.colPrioridadCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridadCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridadCP.Caption = "Prioridad"
        Me.colPrioridadCP.ColumnEdit = Me.rsluePrioridadCP
        Me.colPrioridadCP.FieldName = "Prioridad"
        Me.colPrioridadCP.Name = "colPrioridadCP"
        Me.colPrioridadCP.OptionsColumn.TabStop = False
        Me.colPrioridadCP.Visible = True
        Me.colPrioridadCP.Width = 80
        '
        'rsluePrioridadCP
        '
        Me.rsluePrioridadCP.AutoHeight = False
        Me.rsluePrioridadCP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rsluePrioridadCP.Name = "rsluePrioridadCP"
        Me.rsluePrioridadCP.NullText = ""
        Me.rsluePrioridadCP.PopupView = Me.GridView12
        '
        'GridView12
        '
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCP
        '
        Me.colCodigoCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCP.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCP.ColumnEdit = Me.rslueCodigoCP
        Me.colCodigoCP.FieldName = "CodigoCP"
        Me.colCodigoCP.Name = "colCodigoCP"
        Me.colCodigoCP.OptionsColumn.TabStop = False
        Me.colCodigoCP.Visible = True
        Me.colCodigoCP.Width = 110
        '
        'rslueCodigoCP
        '
        Me.rslueCodigoCP.AutoHeight = False
        Me.rslueCodigoCP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoCP.Name = "rslueCodigoCP"
        Me.rslueCodigoCP.NullText = ""
        Me.rslueCodigoCP.PopupView = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colNombreCP
        '
        Me.colNombreCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCP.AppearanceHeader.Options.UseFont = True
        Me.colNombreCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCP.FieldName = "NombreCP"
        Me.colNombreCP.Name = "colNombreCP"
        Me.colNombreCP.OptionsColumn.AllowEdit = False
        Me.colNombreCP.OptionsColumn.AllowFocus = False
        Me.colNombreCP.OptionsColumn.AllowMove = False
        Me.colNombreCP.OptionsColumn.AllowSize = False
        Me.colNombreCP.OptionsColumn.TabStop = False
        Me.colNombreCP.Visible = True
        Me.colNombreCP.Width = 300
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.AppearanceHeader.Options.UseTextOptions = True
        Me.colUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.Caption = "U/Medida"
        Me.colUM.FieldName = "U/M"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.AllowEdit = False
        Me.colUM.OptionsColumn.AllowFocus = False
        Me.colUM.OptionsColumn.AllowMove = False
        Me.colUM.OptionsColumn.AllowSize = False
        Me.colUM.OptionsColumn.TabStop = False
        Me.colUM.Visible = True
        Me.colUM.Width = 70
        '
        'colComentario
        '
        Me.colComentario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentario.AppearanceHeader.Options.UseFont = True
        Me.colComentario.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentario.Caption = "Comentario"
        Me.colComentario.FieldName = "Comentario"
        Me.colComentario.Name = "colComentario"
        Me.colComentario.Visible = True
        Me.colComentario.Width = 227
        '
        'colComprometido
        '
        Me.colComprometido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComprometido.AppearanceHeader.Options.UseFont = True
        Me.colComprometido.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido.FieldName = "Comprometido"
        Me.colComprometido.Name = "colComprometido"
        Me.colComprometido.OptionsColumn.AllowEdit = False
        Me.colComprometido.OptionsColumn.AllowFocus = False
        Me.colComprometido.OptionsColumn.ReadOnly = True
        Me.colComprometido.Visible = True
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand2.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Stock"
        Me.gridBand2.Columns.Add(Me.colStock)
        Me.gridBand2.Columns.Add(Me.colAlmacen)
        Me.gridBand2.Columns.Add(Me.colMetasa)
        Me.gridBand2.Columns.Add(Me.colPradera)
        Me.gridBand2.Columns.Add(Me.colProduccion)
        Me.gridBand2.Columns.Add(Me.colMinLevel)
        Me.gridBand2.Columns.Add(Me.colMaxLevel)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 585
        '
        'colStock
        '
        Me.colStock.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colStock.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colStock.AppearanceCell.Options.UseBackColor = True
        Me.colStock.AppearanceCell.Options.UseForeColor = True
        Me.colStock.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStock.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colStock.AppearanceHeader.Options.UseBackColor = True
        Me.colStock.AppearanceHeader.Options.UseFont = True
        Me.colStock.AppearanceHeader.Options.UseForeColor = True
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.AllowEdit = False
        Me.colStock.OptionsColumn.AllowFocus = False
        Me.colStock.Visible = True
        '
        'colAlmacen
        '
        Me.colAlmacen.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colAlmacen.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colAlmacen.AppearanceCell.Options.UseBackColor = True
        Me.colAlmacen.AppearanceCell.Options.UseForeColor = True
        Me.colAlmacen.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colAlmacen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlmacen.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colAlmacen.AppearanceHeader.Options.UseBackColor = True
        Me.colAlmacen.AppearanceHeader.Options.UseFont = True
        Me.colAlmacen.AppearanceHeader.Options.UseForeColor = True
        Me.colAlmacen.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlmacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen.Caption = "BodegaSJ"
        Me.colAlmacen.FieldName = "Almacen"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.OptionsColumn.AllowEdit = False
        Me.colAlmacen.OptionsColumn.AllowFocus = False
        Me.colAlmacen.OptionsColumn.ReadOnly = True
        Me.colAlmacen.Visible = True
        '
        'colMetasa
        '
        Me.colMetasa.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colMetasa.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colMetasa.AppearanceCell.Options.UseBackColor = True
        Me.colMetasa.AppearanceCell.Options.UseForeColor = True
        Me.colMetasa.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colMetasa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMetasa.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colMetasa.AppearanceHeader.Options.UseBackColor = True
        Me.colMetasa.AppearanceHeader.Options.UseFont = True
        Me.colMetasa.AppearanceHeader.Options.UseForeColor = True
        Me.colMetasa.AppearanceHeader.Options.UseTextOptions = True
        Me.colMetasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa.Caption = "PI"
        Me.colMetasa.FieldName = "Metasa"
        Me.colMetasa.Name = "colMetasa"
        Me.colMetasa.OptionsColumn.AllowEdit = False
        Me.colMetasa.OptionsColumn.AllowFocus = False
        Me.colMetasa.OptionsColumn.ReadOnly = True
        Me.colMetasa.Visible = True
        '
        'colPradera
        '
        Me.colPradera.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colPradera.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colPradera.AppearanceCell.Options.UseBackColor = True
        Me.colPradera.AppearanceCell.Options.UseForeColor = True
        Me.colPradera.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colPradera.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPradera.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colPradera.AppearanceHeader.Options.UseBackColor = True
        Me.colPradera.AppearanceHeader.Options.UseFont = True
        Me.colPradera.AppearanceHeader.Options.UseForeColor = True
        Me.colPradera.AppearanceHeader.Options.UseTextOptions = True
        Me.colPradera.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera.Caption = "PT"
        Me.colPradera.FieldName = "Pradera"
        Me.colPradera.Name = "colPradera"
        Me.colPradera.OptionsColumn.AllowEdit = False
        Me.colPradera.OptionsColumn.AllowFocus = False
        Me.colPradera.OptionsColumn.ReadOnly = True
        Me.colPradera.Visible = True
        '
        'colProduccion
        '
        Me.colProduccion.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colProduccion.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colProduccion.AppearanceCell.Options.UseBackColor = True
        Me.colProduccion.AppearanceCell.Options.UseForeColor = True
        Me.colProduccion.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colProduccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduccion.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colProduccion.AppearanceHeader.Options.UseBackColor = True
        Me.colProduccion.AppearanceHeader.Options.UseFont = True
        Me.colProduccion.AppearanceHeader.Options.UseForeColor = True
        Me.colProduccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion.FieldName = "Produccion"
        Me.colProduccion.Name = "colProduccion"
        Me.colProduccion.OptionsColumn.AllowEdit = False
        Me.colProduccion.OptionsColumn.AllowFocus = False
        Me.colProduccion.OptionsColumn.ReadOnly = True
        Me.colProduccion.Visible = True
        '
        'colMinLevel
        '
        Me.colMinLevel.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colMinLevel.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colMinLevel.AppearanceCell.Options.UseBackColor = True
        Me.colMinLevel.AppearanceCell.Options.UseForeColor = True
        Me.colMinLevel.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colMinLevel.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colMinLevel.AppearanceHeader.Options.UseBackColor = True
        Me.colMinLevel.AppearanceHeader.Options.UseForeColor = True
        Me.colMinLevel.Caption = "Min"
        Me.colMinLevel.FieldName = "MinLevel"
        Me.colMinLevel.Name = "colMinLevel"
        Me.colMinLevel.Visible = True
        Me.colMinLevel.Width = 105
        '
        'colMaxLevel
        '
        Me.colMaxLevel.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colMaxLevel.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colMaxLevel.AppearanceCell.Options.UseBackColor = True
        Me.colMaxLevel.AppearanceCell.Options.UseForeColor = True
        Me.colMaxLevel.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colMaxLevel.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colMaxLevel.AppearanceHeader.Options.UseBackColor = True
        Me.colMaxLevel.AppearanceHeader.Options.UseForeColor = True
        Me.colMaxLevel.Caption = "Max"
        Me.colMaxLevel.FieldName = "MaxLevel"
        Me.colMaxLevel.Name = "colMaxLevel"
        Me.colMaxLevel.Visible = True
        Me.colMaxLevel.Width = 105
        '
        'rslueOrigen
        '
        Me.rslueOrigen.AutoHeight = False
        Me.rslueOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen.Name = "rslueOrigen"
        Me.rslueOrigen.NullText = ""
        Me.rslueOrigen.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'rspinPrioridadCP
        '
        Me.rspinPrioridadCP.AutoHeight = False
        Me.rspinPrioridadCP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPrioridadCP.DisplayFormat.FormatString = "{0:n0}"
        Me.rspinPrioridadCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridadCP.EditFormat.FormatString = "{0:n0}"
        Me.rspinPrioridadCP.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridadCP.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.rspinPrioridadCP.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.rspinPrioridadCP.Name = "rspinPrioridadCP"
        '
        'txtIdNivel1
        '
        Me.txtIdNivel1.EditValue = "1"
        Me.txtIdNivel1.Enabled = False
        Me.txtIdNivel1.Location = New System.Drawing.Point(58, 142)
        Me.txtIdNivel1.MaximumSize = New System.Drawing.Size(47, 0)
        Me.txtIdNivel1.MenuManager = Me.BarManager1
        Me.txtIdNivel1.Name = "txtIdNivel1"
        Me.txtIdNivel1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIdNivel1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtIdNivel1.Size = New System.Drawing.Size(47, 20)
        Me.txtIdNivel1.StyleController = Me.lycOrdenesEnsamble2
        Me.txtIdNivel1.TabIndex = 9
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.LayoutControlItem11})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1342, 312)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdArticulos
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(46, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1276, 104)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.grdComponentesProducidos
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(100, 130)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1222, 136)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.sbdcOrdenEnsambleProduccion
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(46, 157)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(46, 178)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(54, 88)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtIdNivel1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(46, 130)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(54, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkArticulosSugeridos
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1322, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 183)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(46, 83)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkResultadoOrdenes
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 266)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1322, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.chkCC
        Me.LayoutControlItem11.Location = New System.Drawing.Point(46, 154)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(54, 24)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'lycResultado
        '
        Me.lycResultado.Controls.Add(Me.grdProducciones)
        Me.lycResultado.Controls.Add(Me.grdEnsambles)
        Me.lycResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycResultado.Location = New System.Drawing.Point(0, 0)
        Me.lycResultado.Name = "lycResultado"
        Me.lycResultado.Root = Me.LayoutControlGroup4
        Me.lycResultado.Size = New System.Drawing.Size(1342, 144)
        Me.lycResultado.TabIndex = 0
        Me.lycResultado.Text = "LayoutControl1"
        '
        'grdProducciones
        '
        Me.grdProducciones.DataMember = "dsdtProduccionEncabezado"
        Me.grdProducciones.DataSource = Me.DsOrdenEnsambleProduccion1
        Me.grdProducciones.Location = New System.Drawing.Point(674, 12)
        Me.grdProducciones.MainView = Me.grdviewProducciones
        Me.grdProducciones.Name = "grdProducciones"
        Me.grdProducciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen2})
        Me.grdProducciones.Size = New System.Drawing.Size(656, 120)
        Me.grdProducciones.TabIndex = 6
        Me.grdProducciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProducciones})
        '
        'grdviewProducciones
        '
        Me.grdviewProducciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProducciones.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProducciones.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewProducciones.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewProducciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProducciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProducciones.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProducciones.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProducciones.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewProducciones.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewProducciones.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewProducciones.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewProducciones.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewProducciones.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.Preview.Options.UseFont = True
        Me.grdviewProducciones.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProducciones.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProducciones.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewProducciones.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewProducciones.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProducciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridadOCP, Me.colId_Nivel11, Me.colId_Nivel21, Me.colTipo1, Me.colNumeroSAP1, Me.colCodigoArticulo4, Me.colUnidades1, Me.colOrigen2, Me.colDestino2, Me.colColor2, Me.colGrupoCliente2, Me.colCodigoCliente2, Me.colNumeroOrden1, Me.colEntrega1, Me.colComentario_Nivel11, Me.colComentario_Nivel21, Me.colSAP1, Me.colEstatus1, Me.colBit_UsuarioCreacion1, Me.colBit_FechaCreacion1})
        Me.grdviewProducciones.GridControl = Me.grdProducciones
        Me.grdviewProducciones.Name = "grdviewProducciones"
        Me.grdviewProducciones.OptionsBehavior.Editable = False
        Me.grdviewProducciones.OptionsBehavior.ReadOnly = True
        Me.grdviewProducciones.OptionsView.ColumnAutoWidth = False
        Me.grdviewProducciones.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProducciones.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProducciones.OptionsView.ShowGroupPanel = False
        Me.grdviewProducciones.OptionsView.ShowViewCaption = True
        Me.grdviewProducciones.PaintStyleName = "UltraFlat"
        Me.grdviewProducciones.ViewCaption = "PRODUCCIONES"
        '
        'colPrioridadOCP
        '
        Me.colPrioridadOCP.Caption = "Prioridad"
        Me.colPrioridadOCP.FieldName = "Prioridad"
        Me.colPrioridadOCP.Name = "colPrioridadOCP"
        Me.colPrioridadOCP.Visible = True
        Me.colPrioridadOCP.VisibleIndex = 0
        Me.colPrioridadOCP.Width = 51
        '
        'colId_Nivel11
        '
        Me.colId_Nivel11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId_Nivel11.AppearanceHeader.Options.UseFont = True
        Me.colId_Nivel11.AppearanceHeader.Options.UseTextOptions = True
        Me.colId_Nivel11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId_Nivel11.Caption = "Id"
        Me.colId_Nivel11.FieldName = "Id_Nivel1"
        Me.colId_Nivel11.Name = "colId_Nivel11"
        Me.colId_Nivel11.Visible = True
        Me.colId_Nivel11.VisibleIndex = 1
        Me.colId_Nivel11.Width = 61
        '
        'colId_Nivel21
        '
        Me.colId_Nivel21.FieldName = "Id_Nivel2"
        Me.colId_Nivel21.Name = "colId_Nivel21"
        '
        'colTipo1
        '
        Me.colTipo1.FieldName = "Tipo"
        Me.colTipo1.Name = "colTipo1"
        '
        'colNumeroSAP1
        '
        Me.colNumeroSAP1.FieldName = "NumeroSAP"
        Me.colNumeroSAP1.Name = "colNumeroSAP1"
        '
        'colCodigoArticulo4
        '
        Me.colCodigoArticulo4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo4.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo4.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo4.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo4.Name = "colCodigoArticulo4"
        Me.colCodigoArticulo4.Visible = True
        Me.colCodigoArticulo4.VisibleIndex = 2
        Me.colCodigoArticulo4.Width = 125
        '
        'colUnidades1
        '
        Me.colUnidades1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidades1.AppearanceHeader.Options.UseFont = True
        Me.colUnidades1.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidades1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidades1.FieldName = "Unidades"
        Me.colUnidades1.Name = "colUnidades1"
        Me.colUnidades1.Visible = True
        Me.colUnidades1.VisibleIndex = 3
        '
        'colOrigen2
        '
        Me.colOrigen2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen2.AppearanceHeader.Options.UseFont = True
        Me.colOrigen2.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen2.ColumnEdit = Me.rslueOrigen2
        Me.colOrigen2.FieldName = "Origen"
        Me.colOrigen2.Name = "colOrigen2"
        Me.colOrigen2.Visible = True
        Me.colOrigen2.VisibleIndex = 4
        '
        'rslueOrigen2
        '
        Me.rslueOrigen2.AutoHeight = False
        Me.rslueOrigen2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen2.Name = "rslueOrigen2"
        Me.rslueOrigen2.NullText = ""
        Me.rslueOrigen2.PopupView = Me.GridView11
        '
        'GridView11
        '
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colDestino2
        '
        Me.colDestino2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino2.AppearanceHeader.Options.UseFont = True
        Me.colDestino2.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino2.FieldName = "Destino"
        Me.colDestino2.Name = "colDestino2"
        Me.colDestino2.Visible = True
        Me.colDestino2.VisibleIndex = 5
        '
        'colColor2
        '
        Me.colColor2.FieldName = "Color"
        Me.colColor2.Name = "colColor2"
        '
        'colGrupoCliente2
        '
        Me.colGrupoCliente2.FieldName = "GrupoCliente"
        Me.colGrupoCliente2.Name = "colGrupoCliente2"
        '
        'colCodigoCliente2
        '
        Me.colCodigoCliente2.FieldName = "CodigoCliente"
        Me.colCodigoCliente2.Name = "colCodigoCliente2"
        '
        'colNumeroOrden1
        '
        Me.colNumeroOrden1.FieldName = "NumeroOrden"
        Me.colNumeroOrden1.Name = "colNumeroOrden1"
        '
        'colEntrega1
        '
        Me.colEntrega1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEntrega1.AppearanceHeader.Options.UseFont = True
        Me.colEntrega1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrega1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega1.FieldName = "Entrega"
        Me.colEntrega1.Name = "colEntrega1"
        Me.colEntrega1.Visible = True
        Me.colEntrega1.VisibleIndex = 6
        '
        'colComentario_Nivel11
        '
        Me.colComentario_Nivel11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentario_Nivel11.AppearanceHeader.Options.UseFont = True
        Me.colComentario_Nivel11.Caption = "Comentario"
        Me.colComentario_Nivel11.FieldName = "Comentario_Nivel1"
        Me.colComentario_Nivel11.Name = "colComentario_Nivel11"
        Me.colComentario_Nivel11.Visible = True
        Me.colComentario_Nivel11.VisibleIndex = 7
        '
        'colComentario_Nivel21
        '
        Me.colComentario_Nivel21.FieldName = "Comentario_Nivel2"
        Me.colComentario_Nivel21.Name = "colComentario_Nivel21"
        '
        'colSAP1
        '
        Me.colSAP1.FieldName = "SAP"
        Me.colSAP1.Name = "colSAP1"
        '
        'colEstatus1
        '
        Me.colEstatus1.FieldName = "Estatus"
        Me.colEstatus1.Name = "colEstatus1"
        '
        'colBit_UsuarioCreacion1
        '
        Me.colBit_UsuarioCreacion1.FieldName = "Bit_UsuarioCreacion"
        Me.colBit_UsuarioCreacion1.Name = "colBit_UsuarioCreacion1"
        '
        'colBit_FechaCreacion1
        '
        Me.colBit_FechaCreacion1.FieldName = "Bit_FechaCreacion"
        Me.colBit_FechaCreacion1.Name = "colBit_FechaCreacion1"
        '
        'grdEnsambles
        '
        Me.grdEnsambles.DataMember = "dsdtEnsambleEncabezado"
        Me.grdEnsambles.DataSource = Me.DsOrdenEnsambleProduccion1
        GridLevelNode2.RelationName = "Level1"
        Me.grdEnsambles.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.grdEnsambles.Location = New System.Drawing.Point(12, 12)
        Me.grdEnsambles.MainView = Me.grdviewEnsambles
        Me.grdEnsambles.Name = "grdEnsambles"
        Me.grdEnsambles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen1, Me.rspinPrioridadOAR})
        Me.grdEnsambles.Size = New System.Drawing.Size(658, 120)
        Me.grdEnsambles.TabIndex = 5
        Me.grdEnsambles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambles})
        '
        'grdviewEnsambles
        '
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewEnsambles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewEnsambles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsambles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsambles.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewEnsambles.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewEnsambles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewEnsambles.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_Nivel1, Me.colId_Nivel2, Me.colTipo, Me.colNumeroSAP, Me.colPrioridadOAR, Me.colCodigoArticulo3, Me.colUnidades, Me.colOrigen1, Me.colDestino1, Me.colColor1, Me.colGrupoCliente1, Me.colCodigoCliente1, Me.colNumeroOrden, Me.colEntrega, Me.colComentario_Nivel1, Me.colComentario_Nivel2, Me.colSAP, Me.colEstatus, Me.colBit_UsuarioCreacion, Me.colBit_FechaCreacion})
        Me.grdviewEnsambles.GridControl = Me.grdEnsambles
        Me.grdviewEnsambles.Name = "grdviewEnsambles"
        Me.grdviewEnsambles.OptionsBehavior.Editable = False
        Me.grdviewEnsambles.OptionsBehavior.ReadOnly = True
        Me.grdviewEnsambles.OptionsDetail.ShowDetailTabs = False
        Me.grdviewEnsambles.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambles.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambles.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambles.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambles.OptionsView.ShowViewCaption = True
        Me.grdviewEnsambles.PaintStyleName = "UltraFlat"
        Me.grdviewEnsambles.ViewCaption = "ENSAMBLES"
        '
        'colId_Nivel1
        '
        Me.colId_Nivel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId_Nivel1.AppearanceHeader.Options.UseFont = True
        Me.colId_Nivel1.AppearanceHeader.Options.UseTextOptions = True
        Me.colId_Nivel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId_Nivel1.Caption = "Id"
        Me.colId_Nivel1.FieldName = "Id_Nivel1"
        Me.colId_Nivel1.Name = "colId_Nivel1"
        Me.colId_Nivel1.Visible = True
        Me.colId_Nivel1.VisibleIndex = 0
        Me.colId_Nivel1.Width = 46
        '
        'colId_Nivel2
        '
        Me.colId_Nivel2.FieldName = "Id_Nivel2"
        Me.colId_Nivel2.Name = "colId_Nivel2"
        '
        'colTipo
        '
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        '
        'colNumeroSAP
        '
        Me.colNumeroSAP.FieldName = "NumeroSAP"
        Me.colNumeroSAP.Name = "colNumeroSAP"
        '
        'colPrioridadOAR
        '
        Me.colPrioridadOAR.Caption = "Prioridad"
        Me.colPrioridadOAR.ColumnEdit = Me.rspinPrioridadOAR
        Me.colPrioridadOAR.FieldName = "Prioridad"
        Me.colPrioridadOAR.Name = "colPrioridadOAR"
        Me.colPrioridadOAR.Visible = True
        Me.colPrioridadOAR.VisibleIndex = 1
        '
        'rspinPrioridadOAR
        '
        Me.rspinPrioridadOAR.AutoHeight = False
        Me.rspinPrioridadOAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPrioridadOAR.Name = "rspinPrioridadOAR"
        '
        'colCodigoArticulo3
        '
        Me.colCodigoArticulo3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo3.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo3.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo3.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo3.Name = "colCodigoArticulo3"
        Me.colCodigoArticulo3.Visible = True
        Me.colCodigoArticulo3.VisibleIndex = 2
        Me.colCodigoArticulo3.Width = 110
        '
        'colUnidades
        '
        Me.colUnidades.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidades.AppearanceHeader.Options.UseFont = True
        Me.colUnidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 3
        '
        'colOrigen1
        '
        Me.colOrigen1.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigen1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen1.AppearanceHeader.Options.UseFont = True
        Me.colOrigen1.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen1.ColumnEdit = Me.rslueOrigen1
        Me.colOrigen1.FieldName = "Origen"
        Me.colOrigen1.Name = "colOrigen1"
        Me.colOrigen1.Visible = True
        Me.colOrigen1.VisibleIndex = 4
        '
        'rslueOrigen1
        '
        Me.rslueOrigen1.AutoHeight = False
        Me.rslueOrigen1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen1.Name = "rslueOrigen1"
        Me.rslueOrigen1.NullText = ""
        Me.rslueOrigen1.PopupView = Me.GridView10
        '
        'GridView10
        '
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colDestino1
        '
        Me.colDestino1.AppearanceCell.Options.UseTextOptions = True
        Me.colDestino1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino1.AppearanceHeader.Options.UseFont = True
        Me.colDestino1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino1.FieldName = "Destino"
        Me.colDestino1.Name = "colDestino1"
        Me.colDestino1.Visible = True
        Me.colDestino1.VisibleIndex = 5
        '
        'colColor1
        '
        Me.colColor1.FieldName = "Color"
        Me.colColor1.Name = "colColor1"
        '
        'colGrupoCliente1
        '
        Me.colGrupoCliente1.FieldName = "GrupoCliente"
        Me.colGrupoCliente1.Name = "colGrupoCliente1"
        '
        'colCodigoCliente1
        '
        Me.colCodigoCliente1.FieldName = "CodigoCliente"
        Me.colCodigoCliente1.Name = "colCodigoCliente1"
        '
        'colNumeroOrden
        '
        Me.colNumeroOrden.FieldName = "NumeroOrden"
        Me.colNumeroOrden.Name = "colNumeroOrden"
        '
        'colEntrega
        '
        Me.colEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEntrega.AppearanceHeader.Options.UseFont = True
        Me.colEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.FieldName = "Entrega"
        Me.colEntrega.Name = "colEntrega"
        Me.colEntrega.Visible = True
        Me.colEntrega.VisibleIndex = 6
        '
        'colComentario_Nivel1
        '
        Me.colComentario_Nivel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentario_Nivel1.AppearanceHeader.Options.UseFont = True
        Me.colComentario_Nivel1.Caption = "Comentario"
        Me.colComentario_Nivel1.FieldName = "Comentario_Nivel1"
        Me.colComentario_Nivel1.Name = "colComentario_Nivel1"
        Me.colComentario_Nivel1.Visible = True
        Me.colComentario_Nivel1.VisibleIndex = 7
        Me.colComentario_Nivel1.Width = 140
        '
        'colComentario_Nivel2
        '
        Me.colComentario_Nivel2.FieldName = "Comentario_Nivel2"
        Me.colComentario_Nivel2.Name = "colComentario_Nivel2"
        '
        'colSAP
        '
        Me.colSAP.FieldName = "SAP"
        Me.colSAP.Name = "colSAP"
        '
        'colEstatus
        '
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        '
        'colBit_UsuarioCreacion
        '
        Me.colBit_UsuarioCreacion.FieldName = "Bit_UsuarioCreacion"
        Me.colBit_UsuarioCreacion.Name = "colBit_UsuarioCreacion"
        '
        'colBit_FechaCreacion
        '
        Me.colBit_FechaCreacion.FieldName = "Bit_FechaCreacion"
        Me.colBit_FechaCreacion.Name = "colBit_FechaCreacion"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1342, 144)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.grdProducciones
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(662, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(660, 124)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdEnsambles
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(662, 124)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1366, 663)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.splitResultado
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1346, 643)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSAP, Me.barbtnCerrar, Me.barbtnNuevo, Me.barbtnActualizarControles, Me.barbtListaMateriales})
        Me.BarManager2.MaxItemId = 9
        Me.BarManager2.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSAP, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizarControles, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtListaMateriales, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnSAP.Caption = "Subir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SAP"
        Me.barbtnSAP.Id = 1
        Me.barbtnSAP.ImageOptions.Image = CType(resources.GetObject("barbtnSAP.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 2
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnNuevo
        '
        Me.barbtnNuevo.Caption = "Nuevo"
        Me.barbtnNuevo.Id = 6
        Me.barbtnNuevo.ImageOptions.Image = CType(resources.GetObject("barbtnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnNuevo.ImageOptions.LargeImage = CType(resources.GetObject("barbtnNuevo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnNuevo.Name = "barbtnNuevo"
        '
        'barbtnActualizarControles
        '
        Me.barbtnActualizarControles.Caption = "Actualizar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Listados"
        Me.barbtnActualizarControles.Id = 7
        Me.barbtnActualizarControles.ImageOptions.Image = CType(resources.GetObject("barbtnActualizarControles.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizarControles.Name = "barbtnActualizarControles"
        '
        'barbtListaMateriales
        '
        Me.barbtListaMateriales.Caption = "Lista " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Materiales"
        Me.barbtListaMateriales.Id = 8
        Me.barbtListaMateriales.ImageOptions.Image = CType(resources.GetObject("barbtListaMateriales.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtListaMateriales.Name = "barbtListaMateriales"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 40)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1366, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 703)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1366, 42)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 40)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 663)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1366, 40)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 663)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtn, Me.barbtnEnsamble, Me.barbtnProduccion, Me.barbtnDeudaRol, Me.barbtnDeudaCampana, Me.barbtnDeudaProyeccion, Me.barbtnAnalisisVenta, Me.barbtnComponente, Me.barbtnStock})
        Me.BarManager3.MaxItemId = 9
        '
        'Bar3
        '
        Me.Bar3.BarName = "Tools"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(52, 115)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnStock, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProduccion, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEnsamble, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaRol, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaCampana, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaProyeccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAnalisisVenta, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnComponente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawBorder = False
        Me.Bar3.Text = "Tools"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Id = 8
        Me.barbtnStock.ImageOptions.Image = CType(resources.GetObject("barbtnStock.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnStock.Name = "barbtnStock"
        '
        'barbtnProduccion
        '
        Me.barbtnProduccion.Caption = "Producción"
        Me.barbtnProduccion.Id = 2
        Me.barbtnProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProduccion.Name = "barbtnProduccion"
        '
        'barbtnEnsamble
        '
        Me.barbtnEnsamble.Caption = "Ensamble"
        Me.barbtnEnsamble.Id = 1
        Me.barbtnEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEnsamble.Name = "barbtnEnsamble"
        '
        'barbtnDeudaRol
        '
        Me.barbtnDeudaRol.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        Me.barbtnDeudaRol.Id = 3
        Me.barbtnDeudaRol.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaRol.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaRol.Name = "barbtnDeudaRol"
        '
        'barbtnDeudaCampana
        '
        Me.barbtnDeudaCampana.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Campaña"
        Me.barbtnDeudaCampana.Id = 4
        Me.barbtnDeudaCampana.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaCampana.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaCampana.Name = "barbtnDeudaCampana"
        '
        'barbtnDeudaProyeccion
        '
        Me.barbtnDeudaProyeccion.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proyección"
        Me.barbtnDeudaProyeccion.Id = 5
        Me.barbtnDeudaProyeccion.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaProyeccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaProyeccion.Name = "barbtnDeudaProyeccion"
        '
        'barbtnAnalisisVenta
        '
        Me.barbtnAnalisisVenta.Caption = "Analisis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Venta"
        Me.barbtnAnalisisVenta.Id = 6
        Me.barbtnAnalisisVenta.ImageOptions.Image = CType(resources.GetObject("barbtnAnalisisVenta.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAnalisisVenta.Name = "barbtnAnalisisVenta"
        '
        'barbtnComponente
        '
        Me.barbtnComponente.Caption = "Solicitar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Componentes"
        Me.barbtnComponente.Id = 7
        Me.barbtnComponente.ImageOptions.Image = CType(resources.GetObject("barbtnComponente.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnComponente.Name = "barbtnComponente"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(1366, 40)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 745)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(1366, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 40)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 705)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1366, 40)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 705)
        '
        'barbtn
        '
        Me.barbtn.Caption = "Stock"
        Me.barbtn.Id = 0
        Me.barbtn.ImageOptions.Image = CType(resources.GetObject("barbtn.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtn.Name = "barbtn"
        Me.barbtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'frmOrdenEnsambleProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.lycOrdenEnsambleProduccion)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmOrdenEnsambleProduccion"
        Me.Text = "Ordenes de ensamble y producción .-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rcalCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycOrdenEnsambleProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycOrdenEnsambleProduccion.ResumeLayout(False)
        CType(Me.splitResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitResultado.ResumeLayout(False)
        CType(Me.splitOrdenesEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOrdenesEnsamble.ResumeLayout(False)
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit1.ResumeLayout(False)
        CType(Me.grdHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOrdenEnsambleProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycOrdenesEnsamble2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycOrdenesEnsamble2.ResumeLayout(False)
        CType(Me.chkCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rsluePrioridadAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigenAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueDestinoAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbOrigenAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdComponentesProducidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewComponentesProducidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rsluePrioridadCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPrioridadCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdNivel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycResultado.ResumeLayout(False)
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPrioridadOAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycOrdenEnsambleProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdProducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProducciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdEnsambles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsambles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdComponentesProducidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsOrdenEnsambleProduccion1 As waProduccion_Pedidos.dsOrdenEnsambleProduccion
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadEnsamble As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbbOrigenAR As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents rslueOrigen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueDestino As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoCP As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueColores As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueGrupoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumOrdenVenta As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumCampana As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueDestinoAR As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIdNivel1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdviewComponentesProducidos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colOrigenAR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDestinoCP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoCP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombreCP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducir As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComentario As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComprometido As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAlmacen As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMetasa As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPradera As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProduccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colId_Nivel11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Nivel21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroSAP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOrden1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrega1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario_Nivel11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario_Nivel21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_UsuarioCreacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_FechaCreacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Nivel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Nivel2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario_Nivel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario_Nivel2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_UsuarioCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_FechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueOrigenAR As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueOrigen1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueOrigen2 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaRol As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaCampana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaProyeccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAnalisisVenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnComponente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rspinPrioridad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPrioridadCP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rspinPrioridadCP As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPrioridadOAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rspinPrioridadOAR As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPrioridadOCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdviewHijos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colColor3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStock1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProduccion1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEnsamble As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalPositivo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRol As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCampana As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProyeccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeudaEnsamble As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalNegativo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDisponible As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSugerido As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbdDatosArticulo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbdValoresPositivos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbdValoresNegativos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gdbResultado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents splitOrdenesEnsamble As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycSplit1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycOrdenesEnsamble2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents sbdcOrdenEnsambleProduccion As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents splitResultado As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycResultado As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkArticulosSugeridos As DevExpress.XtraEditors.CheckButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkResultadoOrdenes As DevExpress.XtraEditors.CheckButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnDuplicar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents rdteFechaEntrega As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barbtnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMinLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaxLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents rsluePrioridadAR As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rsluePrioridadCP As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnActualizarControles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rcalCalculadora As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents barbtListaMateriales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
