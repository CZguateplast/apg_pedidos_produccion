<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlProduccion
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlProduccion))
        Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colEstado = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.DsControlProduccion1 = New waProduccion_Pedidos.dsControlProduccion()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiReportes = New DevExpress.XtraBars.BarSubItem()
        Me.barbtnProgramacionFinal = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProgramacionGrafica = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.docmControlProduccion = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.pancControlProduccion = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockpMaquina = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lycMaquina = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dockpMolde = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer2 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lycMolde = New DevExpress.XtraLayout.LayoutControl()
        Me.txtSacosDia = New DevExpress.XtraEditors.TextEdit()
        Me.txtLibrasHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccionMaxima = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccionMinima = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloMaximo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloMinimo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloTurno = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtCiclo = New DevExpress.XtraEditors.TextEdit()
        Me.txtUbicacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtLugar = New DevExpress.XtraEditors.TextEdit()
        Me.txtunidades = New DevExpress.XtraEditors.TextEdit()
        Me.txtCavidades = New DevExpress.XtraEditors.TextEdit()
        Me.txtPreferencial = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtMolde = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.docpColores = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lycColores = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCodigoPadre = New DevExpress.XtraEditors.TextEdit()
        Me.grdColores = New DevExpress.XtraGrid.GridControl()
        Me.grdviewColores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.rbtnIniciarProceso = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDetener = New DevExpress.XtraBars.BarSubItem()
        Me.rbtnRevisionMolde = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRevisionMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInstruccionDirecta = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFinalizacionTrabajo = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCambiarMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.bar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barSuperiorControlProduccion = New DevExpress.XtraBars.Bar()
        Me.barbtnEditarTrabajos = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnTrabajoIniciar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnTrabajoDetener = New DevExpress.XtraBars.BarSubItem()
        Me.barbtnDetenerTrabajoFinalizado = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetenerRevisionMolde = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetenerRevisionMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDentenerInstruccionDirecta = New DevExpress.XtraBars.BarButtonItem()
        Me.barbnCambiarMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSolicitarEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnRecibo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnInstruccionesTrabajo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.DsdtControlProduccionTableAdapter1 = New waProduccion_Pedidos.dsControlProduccionTableAdapters.dsdtControlProduccionTableAdapter()
        Me.dsdtControlProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsControlProduccion2 = New waProduccion_Pedidos.dsControlProduccion()
        Me.lycControlProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.grdControlProduccion = New DevExpress.XtraGrid.GridControl()
        Me.tlviewControlProduccion = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colPreferencial = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPrioridadMaquina = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colProduccionHora = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colHorasPendiente = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.rdlMenu = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.DsParametros_Instrucciones1 = New waProduccion_Pedidos.dsParametros_Instrucciones()
        CType(Me.DsControlProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.docmControlProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pancControlProduccion.SuspendLayout()
        Me.dockpMaquina.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        CType(Me.lycMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycMaquina.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockpMolde.SuspendLayout()
        Me.ControlContainer2.SuspendLayout()
        CType(Me.lycMolde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycMolde.SuspendLayout()
        CType(Me.txtSacosDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibrasHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccionMaxima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccionMinima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiclo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLugar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCavidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreferencial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMolde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docpColores.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.lycColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycColores.SuspendLayout()
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsdtControlProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlProduccion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycControlProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycControlProduccion.SuspendLayout()
        CType(Me.grdControlProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlviewControlProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Instrucciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.BackColor = System.Drawing.Color.SkyBlue
        Me.colCodigoArticulo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoArticulo.AppearanceCell.Options.UseFont = True
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 4
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 5
        '
        'colPlaneado
        '
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 6
        '
        'colCompletado
        '
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 7
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 11
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 8
        '
        'DsControlProduccion1
        '
        Me.DsControlProduccion1.DataSetName = "dsControlProduccion"
        Me.DsControlProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.DockManager = Me.docmControlProduccion
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbtnIniciarProceso, Me.BarButtonItem3, Me.rbtnDetener, Me.rbtnRevisionMolde, Me.rbtnRevisionMaquina, Me.rbtnInstruccionDirecta, Me.rbtnEtiquetas, Me.rbtnFinalizacionTrabajo, Me.barbtnCerrar, Me.rbtnCambiarMaquina, Me.barbtnProgramacionGrafica, Me.bar, Me.bsiReportes, Me.barbtnProgramacionFinal, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx})
        Me.barManager1.MaxItemId = 22
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar3
        '
        Me.bar3.BarName = "Status bar"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiReportes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProgramacionGrafica, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Status bar"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 21
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 20
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 14
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'bsiReportes
        '
        Me.bsiReportes.Caption = "Reportes"
        Me.bsiReportes.Id = 18
        Me.bsiReportes.ImageOptions.Image = CType(resources.GetObject("bsiReportes.ImageOptions.Image"), System.Drawing.Image)
        Me.bsiReportes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnProgramacionFinal)})
        Me.bsiReportes.Name = "bsiReportes"
        '
        'barbtnProgramacionFinal
        '
        Me.barbtnProgramacionFinal.Caption = "Programación Final"
        Me.barbtnProgramacionFinal.Id = 19
        Me.barbtnProgramacionFinal.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionFinal.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionFinal.ImageOptions.LargeImage = CType(resources.GetObject("barbtnProgramacionFinal.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnProgramacionFinal.Name = "barbtnProgramacionFinal"
        '
        'barbtnProgramacionGrafica
        '
        Me.barbtnProgramacionGrafica.Caption = "Programación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grafica"
        Me.barbtnProgramacionGrafica.Id = 16
        Me.barbtnProgramacionGrafica.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionGrafica.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionGrafica.Name = "barbtnProgramacionGrafica"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1307, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 664)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1307, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 617)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1307, 47)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 617)
        '
        'docmControlProduccion
        '
        Me.docmControlProduccion.Form = Me
        Me.docmControlProduccion.MenuManager = Me.BarManager2
        Me.docmControlProduccion.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.pancControlProduccion})
        Me.docmControlProduccion.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'pancControlProduccion
        '
        Me.pancControlProduccion.ActiveChild = Me.dockpMaquina
        Me.pancControlProduccion.Controls.Add(Me.dockpMolde)
        Me.pancControlProduccion.Controls.Add(Me.docpColores)
        Me.pancControlProduccion.Controls.Add(Me.dockpMaquina)
        Me.pancControlProduccion.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pancControlProduccion.ID = New System.Guid("0ed52353-22cc-48d4-a3b6-22410696992e")
        Me.pancControlProduccion.Location = New System.Drawing.Point(953, 47)
        Me.pancControlProduccion.Name = "pancControlProduccion"
        Me.pancControlProduccion.Options.FloatOnDblClick = False
        Me.pancControlProduccion.Options.ShowCloseButton = False
        Me.pancControlProduccion.Options.ShowMaximizeButton = False
        Me.pancControlProduccion.OriginalSize = New System.Drawing.Size(354, 200)
        Me.pancControlProduccion.Size = New System.Drawing.Size(354, 617)
        Me.pancControlProduccion.Tabbed = True
        Me.pancControlProduccion.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Top
        Me.pancControlProduccion.TabsScroll = True
        Me.pancControlProduccion.Text = "panelContainer1"
        '
        'dockpMaquina
        '
        Me.dockpMaquina.Controls.Add(Me.ControlContainer1)
        Me.dockpMaquina.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dockpMaquina.ID = New System.Guid("89b22a05-c389-400d-b1c5-0d2bbfd62961")
        Me.dockpMaquina.Location = New System.Drawing.Point(5, 50)
        Me.dockpMaquina.Name = "dockpMaquina"
        Me.dockpMaquina.Options.FloatOnDblClick = False
        Me.dockpMaquina.Options.ShowCloseButton = False
        Me.dockpMaquina.Options.ShowMaximizeButton = False
        Me.dockpMaquina.OriginalSize = New System.Drawing.Size(345, 563)
        Me.dockpMaquina.Size = New System.Drawing.Size(345, 563)
        Me.dockpMaquina.Text = "Maquina"
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.lycMaquina)
        Me.ControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(345, 563)
        Me.ControlContainer1.TabIndex = 0
        '
        'lycMaquina
        '
        Me.lycMaquina.Controls.Add(Me.LabelControl2)
        Me.lycMaquina.Controls.Add(Me.LabelControl1)
        Me.lycMaquina.Controls.Add(Me.ChartControl2)
        Me.lycMaquina.Controls.Add(Me.ChartControl1)
        Me.lycMaquina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycMaquina.Location = New System.Drawing.Point(0, 0)
        Me.lycMaquina.Name = "lycMaquina"
        Me.lycMaquina.Root = Me.LayoutControlGroup3
        Me.lycMaquina.Size = New System.Drawing.Size(345, 563)
        Me.lycMaquina.TabIndex = 0
        Me.lycMaquina.Text = "LayoutControl1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(146, 13)
        Me.LabelControl2.StyleController = Me.lycMaquina
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Carga de Trabajo por Maquina"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 373)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(179, 16)
        Me.LabelControl1.StyleController = Me.lycMaquina
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Carga de Trabajo por Grupo"
        '
        'ChartControl2
        '
        Me.ChartControl2.DataBindings = Nothing
        SimpleDiagram3D1.PerspectiveAngle = 14
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        SimpleDiagram3D1.RotationType = DevExpress.XtraCharts.RotationType.UseMouseStandard
        SimpleDiagram3D1.RuntimeRotation = True
        Me.ChartControl2.Diagram = SimpleDiagram3D1
        Me.ChartControl2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl2.Location = New System.Drawing.Point(12, 393)
        Me.ChartControl2.Name = "ChartControl2"
        Series1.Name = "Series 1"
        Series1.View = Pie3DSeriesView1
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl2.Size = New System.Drawing.Size(321, 158)
        Me.ChartControl2.TabIndex = 6
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.DsControlProduccion1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(12, 29)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "dsdtControlProduccion.Preferencial"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "dsdtControlProduccion.HorasPendiente"
        Me.ChartControl1.Size = New System.Drawing.Size(321, 340)
        Me.ChartControl1.TabIndex = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.EmptySpaceItem2, Me.LayoutControlItem25})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(345, 563)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.ChartControl1
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(325, 344)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.ChartControl2
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 381)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(325, 162)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.LabelControl1
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 361)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(183, 20)
        Me.LayoutControlItem24.Text = "Trabajos por Maquina"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(183, 361)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(142, 20)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.LabelControl2
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(325, 17)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'dockpMolde
        '
        Me.dockpMolde.Controls.Add(Me.ControlContainer2)
        Me.dockpMolde.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dockpMolde.ID = New System.Guid("a45a0291-06ce-4bfa-b789-c5dceb1f8a5b")
        Me.dockpMolde.Location = New System.Drawing.Point(5, 50)
        Me.dockpMolde.Name = "dockpMolde"
        Me.dockpMolde.Options.FloatOnDblClick = False
        Me.dockpMolde.Options.ShowCloseButton = False
        Me.dockpMolde.Options.ShowMaximizeButton = False
        Me.dockpMolde.OriginalSize = New System.Drawing.Size(345, 563)
        Me.dockpMolde.Size = New System.Drawing.Size(345, 563)
        Me.dockpMolde.Text = "Molde"
        '
        'ControlContainer2
        '
        Me.ControlContainer2.Controls.Add(Me.lycMolde)
        Me.ControlContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ControlContainer2.Name = "ControlContainer2"
        Me.ControlContainer2.Size = New System.Drawing.Size(345, 563)
        Me.ControlContainer2.TabIndex = 0
        '
        'lycMolde
        '
        Me.lycMolde.Controls.Add(Me.txtSacosDia)
        Me.lycMolde.Controls.Add(Me.txtLibrasHora)
        Me.lycMolde.Controls.Add(Me.txtInyeccionMaxima)
        Me.lycMolde.Controls.Add(Me.txtInyeccionMinima)
        Me.lycMolde.Controls.Add(Me.txtInyeccion)
        Me.lycMolde.Controls.Add(Me.txtCicloMaximo)
        Me.lycMolde.Controls.Add(Me.txtCicloMinimo)
        Me.lycMolde.Controls.Add(Me.txtCicloTurno)
        Me.lycMolde.Controls.Add(Me.txtCicloHora)
        Me.lycMolde.Controls.Add(Me.txtCiclo)
        Me.lycMolde.Controls.Add(Me.txtUbicacion)
        Me.lycMolde.Controls.Add(Me.txtLugar)
        Me.lycMolde.Controls.Add(Me.txtunidades)
        Me.lycMolde.Controls.Add(Me.txtCavidades)
        Me.lycMolde.Controls.Add(Me.txtPreferencial)
        Me.lycMolde.Controls.Add(Me.txtNombre)
        Me.lycMolde.Controls.Add(Me.txtMolde)
        Me.lycMolde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycMolde.Location = New System.Drawing.Point(0, 0)
        Me.lycMolde.Name = "lycMolde"
        Me.lycMolde.Root = Me.LayoutControlGroup4
        Me.lycMolde.Size = New System.Drawing.Size(345, 563)
        Me.lycMolde.TabIndex = 0
        Me.lycMolde.Text = "LayoutControl1"
        '
        'txtSacosDia
        '
        Me.txtSacosDia.Location = New System.Drawing.Point(262, 342)
        Me.txtSacosDia.MenuManager = Me.barManager1
        Me.txtSacosDia.Name = "txtSacosDia"
        Me.txtSacosDia.Size = New System.Drawing.Size(59, 20)
        Me.txtSacosDia.StyleController = Me.lycMolde
        Me.txtSacosDia.TabIndex = 20
        '
        'txtLibrasHora
        '
        Me.txtLibrasHora.Location = New System.Drawing.Point(262, 318)
        Me.txtLibrasHora.MenuManager = Me.barManager1
        Me.txtLibrasHora.Name = "txtLibrasHora"
        Me.txtLibrasHora.Size = New System.Drawing.Size(59, 20)
        Me.txtLibrasHora.StyleController = Me.lycMolde
        Me.txtLibrasHora.TabIndex = 19
        '
        'txtInyeccionMaxima
        '
        Me.txtInyeccionMaxima.Location = New System.Drawing.Point(112, 366)
        Me.txtInyeccionMaxima.MenuManager = Me.barManager1
        Me.txtInyeccionMaxima.Name = "txtInyeccionMaxima"
        Me.txtInyeccionMaxima.Size = New System.Drawing.Size(58, 20)
        Me.txtInyeccionMaxima.StyleController = Me.lycMolde
        Me.txtInyeccionMaxima.TabIndex = 18
        '
        'txtInyeccionMinima
        '
        Me.txtInyeccionMinima.Location = New System.Drawing.Point(112, 342)
        Me.txtInyeccionMinima.MenuManager = Me.barManager1
        Me.txtInyeccionMinima.Name = "txtInyeccionMinima"
        Me.txtInyeccionMinima.Size = New System.Drawing.Size(58, 20)
        Me.txtInyeccionMinima.StyleController = Me.lycMolde
        Me.txtInyeccionMinima.TabIndex = 17
        '
        'txtInyeccion
        '
        Me.txtInyeccion.Location = New System.Drawing.Point(112, 318)
        Me.txtInyeccion.MenuManager = Me.barManager1
        Me.txtInyeccion.Name = "txtInyeccion"
        Me.txtInyeccion.Size = New System.Drawing.Size(58, 20)
        Me.txtInyeccion.StyleController = Me.lycMolde
        Me.txtInyeccion.TabIndex = 16
        '
        'txtCicloMaximo
        '
        Me.txtCicloMaximo.Location = New System.Drawing.Point(262, 228)
        Me.txtCicloMaximo.MenuManager = Me.barManager1
        Me.txtCicloMaximo.Name = "txtCicloMaximo"
        Me.txtCicloMaximo.Size = New System.Drawing.Size(59, 20)
        Me.txtCicloMaximo.StyleController = Me.lycMolde
        Me.txtCicloMaximo.TabIndex = 15
        '
        'txtCicloMinimo
        '
        Me.txtCicloMinimo.Location = New System.Drawing.Point(262, 204)
        Me.txtCicloMinimo.MenuManager = Me.barManager1
        Me.txtCicloMinimo.Name = "txtCicloMinimo"
        Me.txtCicloMinimo.Size = New System.Drawing.Size(59, 20)
        Me.txtCicloMinimo.StyleController = Me.lycMolde
        Me.txtCicloMinimo.TabIndex = 14
        '
        'txtCicloTurno
        '
        Me.txtCicloTurno.Location = New System.Drawing.Point(112, 252)
        Me.txtCicloTurno.MenuManager = Me.barManager1
        Me.txtCicloTurno.Name = "txtCicloTurno"
        Me.txtCicloTurno.Size = New System.Drawing.Size(58, 20)
        Me.txtCicloTurno.StyleController = Me.lycMolde
        Me.txtCicloTurno.TabIndex = 13
        '
        'txtCicloHora
        '
        Me.txtCicloHora.Location = New System.Drawing.Point(112, 228)
        Me.txtCicloHora.MenuManager = Me.barManager1
        Me.txtCicloHora.Name = "txtCicloHora"
        Me.txtCicloHora.Size = New System.Drawing.Size(58, 20)
        Me.txtCicloHora.StyleController = Me.lycMolde
        Me.txtCicloHora.TabIndex = 12
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(112, 204)
        Me.txtCiclo.MenuManager = Me.barManager1
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Size = New System.Drawing.Size(58, 20)
        Me.txtCiclo.StyleController = Me.lycMolde
        Me.txtCiclo.TabIndex = 11
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(112, 138)
        Me.txtUbicacion.MenuManager = Me.barManager1
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUbicacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUbicacion.Size = New System.Drawing.Size(209, 20)
        Me.txtUbicacion.StyleController = Me.lycMolde
        Me.txtUbicacion.TabIndex = 10
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(112, 114)
        Me.txtLugar.MenuManager = Me.barManager1
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLugar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLugar.Size = New System.Drawing.Size(209, 20)
        Me.txtLugar.StyleController = Me.lycMolde
        Me.txtLugar.TabIndex = 9
        '
        'txtunidades
        '
        Me.txtunidades.Location = New System.Drawing.Point(262, 90)
        Me.txtunidades.MenuManager = Me.barManager1
        Me.txtunidades.Name = "txtunidades"
        Me.txtunidades.Properties.Appearance.Options.UseTextOptions = True
        Me.txtunidades.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtunidades.Size = New System.Drawing.Size(59, 20)
        Me.txtunidades.StyleController = Me.lycMolde
        Me.txtunidades.TabIndex = 8
        '
        'txtCavidades
        '
        Me.txtCavidades.Location = New System.Drawing.Point(112, 90)
        Me.txtCavidades.MenuManager = Me.barManager1
        Me.txtCavidades.Name = "txtCavidades"
        Me.txtCavidades.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCavidades.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCavidades.Size = New System.Drawing.Size(58, 20)
        Me.txtCavidades.StyleController = Me.lycMolde
        Me.txtCavidades.TabIndex = 7
        '
        'txtPreferencial
        '
        Me.txtPreferencial.Location = New System.Drawing.Point(262, 42)
        Me.txtPreferencial.MenuManager = Me.barManager1
        Me.txtPreferencial.Name = "txtPreferencial"
        Me.txtPreferencial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPreferencial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPreferencial.Size = New System.Drawing.Size(59, 20)
        Me.txtPreferencial.StyleController = Me.lycMolde
        Me.txtPreferencial.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 66)
        Me.txtNombre.MenuManager = Me.barManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(209, 20)
        Me.txtNombre.StyleController = Me.lycMolde
        Me.txtNombre.TabIndex = 5
        '
        'txtMolde
        '
        Me.txtMolde.Location = New System.Drawing.Point(112, 42)
        Me.txtMolde.MenuManager = Me.barManager1
        Me.txtMolde.Name = "txtMolde"
        Me.txtMolde.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMolde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMolde.Size = New System.Drawing.Size(58, 20)
        Me.txtMolde.StyleController = Me.lycMolde
        Me.txtMolde.TabIndex = 4
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.LayoutControlGroup7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(345, 563)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 390)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(325, 153)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup5.AppearanceGroup.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem9})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(325, 162)
        Me.LayoutControlGroup5.Text = "Parametros Molde"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtUbicacion
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem10.Text = "Ubicación"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.txtunidades
        Me.LayoutControlItem8.Location = New System.Drawing.Point(150, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem8.Text = "Unidades"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtCavidades
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem7.Text = "Cavidades"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtNombre
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem5.Text = "Nombre"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtMolde
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem4.Text = "Molde"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtPreferencial
        Me.LayoutControlItem6.Location = New System.Drawing.Point(150, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem6.Text = "Preferencial"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.txtLugar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem9.Text = "Lugar"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup6.AppearanceGroup.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlGroup6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem14})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(325, 114)
        Me.LayoutControlGroup6.Text = "Ciclos"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem11.Control = Me.txtCiclo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem11.Text = "Ciclo"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.txtCicloHora
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem12.Text = "Ciclo Hora"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.txtCicloTurno
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem13.Text = "Ciclo Turno"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.txtCicloMaximo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(150, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(151, 48)
        Me.LayoutControlItem15.Text = "Ciclo Maximo"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.txtCicloMinimo
        Me.LayoutControlItem14.Location = New System.Drawing.Point(150, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem14.Text = "Ciclo Minimo"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup7.AppearanceGroup.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlGroup7.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup7.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem18})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 276)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(325, 114)
        Me.LayoutControlGroup7.Text = "Inyección (gramos)"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem16.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem16.Control = Me.txtInyeccion
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem16.Text = "Inyección"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem17.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem17.Control = Me.txtInyeccionMinima
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem17.Text = "Inyección Minima"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem19.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem19.Control = Me.txtLibrasHora
        Me.LayoutControlItem19.Location = New System.Drawing.Point(150, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem19.Text = "Lb Hora"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem20.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem20.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem20.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem20.Control = Me.txtSacosDia
        Me.LayoutControlItem20.Location = New System.Drawing.Point(150, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(151, 48)
        Me.LayoutControlItem20.Text = "Sacos dia (25 kg)"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem18.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem18.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem18.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem18.Control = Me.txtInyeccionMaxima
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem18.Text = "Inyección Maxima"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(85, 13)
        '
        'docpColores
        '
        Me.docpColores.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.docpColores.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.docpColores.Appearance.Options.UseBackColor = True
        Me.docpColores.Controls.Add(Me.DockPanel1_Container)
        Me.docpColores.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.docpColores.ID = New System.Guid("b9720a68-37b9-4cdd-ae79-daed6f8553e4")
        Me.docpColores.Location = New System.Drawing.Point(5, 50)
        Me.docpColores.Name = "docpColores"
        Me.docpColores.Options.AllowFloating = False
        Me.docpColores.Options.FloatOnDblClick = False
        Me.docpColores.Options.ShowCloseButton = False
        Me.docpColores.OriginalSize = New System.Drawing.Size(345, 563)
        Me.docpColores.Size = New System.Drawing.Size(345, 563)
        Me.docpColores.Text = "Colores"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.lycColores)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(345, 563)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'lycColores
        '
        Me.lycColores.Controls.Add(Me.txtCodigoPadre)
        Me.lycColores.Controls.Add(Me.grdColores)
        Me.lycColores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycColores.Location = New System.Drawing.Point(0, 0)
        Me.lycColores.Name = "lycColores"
        Me.lycColores.Root = Me.LayoutControlGroup2
        Me.lycColores.Size = New System.Drawing.Size(345, 563)
        Me.lycColores.TabIndex = 0
        Me.lycColores.Text = "LayoutControl1"
        '
        'txtCodigoPadre
        '
        Me.txtCodigoPadre.Enabled = False
        Me.txtCodigoPadre.Location = New System.Drawing.Point(89, 12)
        Me.txtCodigoPadre.MenuManager = Me.barManager1
        Me.txtCodigoPadre.Name = "txtCodigoPadre"
        Me.txtCodigoPadre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodigoPadre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigoPadre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodigoPadre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodigoPadre.Size = New System.Drawing.Size(244, 20)
        Me.txtCodigoPadre.StyleController = Me.lycColores
        Me.txtCodigoPadre.TabIndex = 5
        '
        'grdColores
        '
        Me.grdColores.DataMember = "dsdtColores"
        Me.grdColores.DataSource = Me.DsControlProduccion1
        Me.grdColores.Location = New System.Drawing.Point(12, 36)
        Me.grdColores.MainView = Me.grdviewColores
        Me.grdColores.MenuManager = Me.barManager1
        Me.grdColores.Name = "grdColores"
        Me.grdColores.Size = New System.Drawing.Size(321, 515)
        Me.grdColores.TabIndex = 4
        Me.grdColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewColores})
        '
        'grdviewColores
        '
        Me.grdviewColores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewColores.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewColores.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewColores.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewColores.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewColores.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewColores.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewColores.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Preview.Options.UseFont = True
        Me.grdviewColores.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.Row.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.Row.Options.UseForeColor = True
        Me.grdviewColores.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewColores.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewColores.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewColores.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewColores.ColumnPanelRowHeight = 35
        Me.grdviewColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColor, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colTipoMaterial})
        Me.grdviewColores.GridControl = Me.grdColores
        Me.grdviewColores.Name = "grdviewColores"
        Me.grdviewColores.OptionsBehavior.Editable = False
        Me.grdviewColores.OptionsBehavior.ReadOnly = True
        Me.grdviewColores.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewColores.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewColores.OptionsView.ShowFooter = True
        Me.grdviewColores.OptionsView.ShowGroupPanel = False
        Me.grdviewColores.PaintStyleName = "Web"
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Color", "{0}")})
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 0
        Me.colColor.Width = 46
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Planeado", "{0:0.##}")})
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 1
        Me.colPlaneado1.Width = 80
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Completado", "{0:0.##}")})
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 2
        Me.colCompletado1.Width = 76
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente1.AppearanceHeader.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pendiente", "{0:0.##}")})
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 3
        Me.colPendiente1.Width = 76
        '
        'colTipoMaterial
        '
        Me.colTipoMaterial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colTipoMaterial.AppearanceHeader.Options.UseFont = True
        Me.colTipoMaterial.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.FieldName = "TipoMaterial"
        Me.colTipoMaterial.Name = "colTipoMaterial"
        Me.colTipoMaterial.Visible = True
        Me.colTipoMaterial.VisibleIndex = 4
        Me.colTipoMaterial.Width = 99
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(345, 563)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdColores
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(325, 519)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.txtCodigoPadre
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(325, 24)
        Me.LayoutControlItem3.Text = "Codigo Padre"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
        '
        'rbtnIniciarProceso
        '
        Me.rbtnIniciarProceso.Caption = "Iniciar"
        Me.rbtnIniciarProceso.Id = 2
        Me.rbtnIniciarProceso.ImageOptions.Image = CType(resources.GetObject("rbtnIniciarProceso.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnIniciarProceso.Name = "rbtnIniciarProceso"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Detener"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'rbtnDetener
        '
        Me.rbtnDetener.Caption = "Detener"
        Me.rbtnDetener.Id = 8
        Me.rbtnDetener.ImageOptions.Image = CType(resources.GetObject("rbtnDetener.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnDetener.ImageOptions.LargeImage = CType(resources.GetObject("rbtnDetener.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.rbtnDetener.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnRevisionMolde), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnRevisionMaquina), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnInstruccionDirecta), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnFinalizacionTrabajo)})
        Me.rbtnDetener.Name = "rbtnDetener"
        '
        'rbtnRevisionMolde
        '
        Me.rbtnRevisionMolde.Caption = "Revision Molde"
        Me.rbtnRevisionMolde.Id = 9
        Me.rbtnRevisionMolde.ImageOptions.Image = CType(resources.GetObject("rbtnRevisionMolde.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnRevisionMolde.Name = "rbtnRevisionMolde"
        '
        'rbtnRevisionMaquina
        '
        Me.rbtnRevisionMaquina.Caption = "Revision Maquina"
        Me.rbtnRevisionMaquina.Id = 10
        Me.rbtnRevisionMaquina.ImageOptions.Image = CType(resources.GetObject("rbtnRevisionMaquina.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnRevisionMaquina.Name = "rbtnRevisionMaquina"
        '
        'rbtnInstruccionDirecta
        '
        Me.rbtnInstruccionDirecta.Caption = "Instruccion Directa"
        Me.rbtnInstruccionDirecta.Id = 11
        Me.rbtnInstruccionDirecta.ImageOptions.Image = CType(resources.GetObject("rbtnInstruccionDirecta.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnInstruccionDirecta.Name = "rbtnInstruccionDirecta"
        '
        'rbtnFinalizacionTrabajo
        '
        Me.rbtnFinalizacionTrabajo.Caption = "Finalización de Trabajo"
        Me.rbtnFinalizacionTrabajo.Id = 13
        Me.rbtnFinalizacionTrabajo.ImageOptions.Image = CType(resources.GetObject("rbtnFinalizacionTrabajo.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnFinalizacionTrabajo.Name = "rbtnFinalizacionTrabajo"
        '
        'rbtnEtiquetas
        '
        Me.rbtnEtiquetas.Caption = "Solicitud de Etiquetas"
        Me.rbtnEtiquetas.Id = 12
        Me.rbtnEtiquetas.ImageOptions.Image = CType(resources.GetObject("rbtnEtiquetas.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnEtiquetas.Name = "rbtnEtiquetas"
        '
        'rbtnCambiarMaquina
        '
        Me.rbtnCambiarMaquina.Caption = "Cambiar de Maquina"
        Me.rbtnCambiarMaquina.Id = 15
        Me.rbtnCambiarMaquina.ImageOptions.Image = CType(resources.GetObject("rbtnCambiarMaquina.ImageOptions.Image"), System.Drawing.Image)
        Me.rbtnCambiarMaquina.Name = "rbtnCambiarMaquina"
        '
        'bar
        '
        Me.bar.Caption = "Programación Final"
        Me.bar.Id = 17
        Me.bar.Name = "bar"
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barSuperiorControlProduccion})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.DockManager = Me.docmControlProduccion
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnRecibo, Me.barbtnTrabajoIniciar, Me.barbtnSolicitarEtiquetas, Me.barbnCambiarMaquina, Me.barbtnEditarTrabajos, Me.barbtnTrabajoDetener, Me.barbtnDetenerTrabajoFinalizado, Me.barbtnDetenerRevisionMolde, Me.barbtnDetenerRevisionMaquina, Me.barbtnDentenerInstruccionDirecta, Me.barbtnInstruccionesTrabajo})
        Me.BarManager2.MaxItemId = 12
        '
        'barSuperiorControlProduccion
        '
        Me.barSuperiorControlProduccion.BarName = "Tools"
        Me.barSuperiorControlProduccion.DockCol = 0
        Me.barSuperiorControlProduccion.DockRow = 0
        Me.barSuperiorControlProduccion.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barSuperiorControlProduccion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEditarTrabajos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnTrabajoIniciar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnTrabajoDetener, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbnCambiarMaquina, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSolicitarEtiquetas, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnRecibo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnInstruccionesTrabajo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barSuperiorControlProduccion.OptionsBar.AllowQuickCustomization = False
        Me.barSuperiorControlProduccion.OptionsBar.DisableClose = True
        Me.barSuperiorControlProduccion.OptionsBar.DrawBorder = False
        Me.barSuperiorControlProduccion.OptionsBar.DrawDragBorder = False
        Me.barSuperiorControlProduccion.Text = "Tools"
        '
        'barbtnEditarTrabajos
        '
        Me.barbtnEditarTrabajos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnEditarTrabajos.Caption = "Editar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajos"
        Me.barbtnEditarTrabajos.Id = 5
        Me.barbtnEditarTrabajos.ImageOptions.Image = CType(resources.GetObject("barbtnEditarTrabajos.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEditarTrabajos.Name = "barbtnEditarTrabajos"
        '
        'barbtnTrabajoIniciar
        '
        Me.barbtnTrabajoIniciar.Caption = "Iniciar"
        Me.barbtnTrabajoIniciar.Id = 1
        Me.barbtnTrabajoIniciar.ImageOptions.Image = CType(resources.GetObject("barbtnTrabajoIniciar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnTrabajoIniciar.Name = "barbtnTrabajoIniciar"
        '
        'barbtnTrabajoDetener
        '
        Me.barbtnTrabajoDetener.Caption = "Detener"
        Me.barbtnTrabajoDetener.Id = 6
        Me.barbtnTrabajoDetener.ImageOptions.Image = CType(resources.GetObject("barbtnTrabajoDetener.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnTrabajoDetener.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDetenerTrabajoFinalizado), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDetenerRevisionMolde), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDetenerRevisionMaquina), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDentenerInstruccionDirecta)})
        Me.barbtnTrabajoDetener.Name = "barbtnTrabajoDetener"
        '
        'barbtnDetenerTrabajoFinalizado
        '
        Me.barbtnDetenerTrabajoFinalizado.Caption = "Finalización de Trabajo"
        Me.barbtnDetenerTrabajoFinalizado.Id = 7
        Me.barbtnDetenerTrabajoFinalizado.Name = "barbtnDetenerTrabajoFinalizado"
        '
        'barbtnDetenerRevisionMolde
        '
        Me.barbtnDetenerRevisionMolde.Caption = "Revision de Molde"
        Me.barbtnDetenerRevisionMolde.Id = 8
        Me.barbtnDetenerRevisionMolde.Name = "barbtnDetenerRevisionMolde"
        '
        'barbtnDetenerRevisionMaquina
        '
        Me.barbtnDetenerRevisionMaquina.Caption = "Revisión de Maquina"
        Me.barbtnDetenerRevisionMaquina.Id = 9
        Me.barbtnDetenerRevisionMaquina.Name = "barbtnDetenerRevisionMaquina"
        '
        'barbtnDentenerInstruccionDirecta
        '
        Me.barbtnDentenerInstruccionDirecta.Caption = "Instrucción Directa"
        Me.barbtnDentenerInstruccionDirecta.Id = 10
        Me.barbtnDentenerInstruccionDirecta.Name = "barbtnDentenerInstruccionDirecta"
        '
        'barbnCambiarMaquina
        '
        Me.barbnCambiarMaquina.Caption = "Cambiar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maquina"
        Me.barbnCambiarMaquina.Id = 4
        Me.barbnCambiarMaquina.ImageOptions.Image = CType(resources.GetObject("barbnCambiarMaquina.ImageOptions.Image"), System.Drawing.Image)
        Me.barbnCambiarMaquina.Name = "barbnCambiarMaquina"
        '
        'barbtnSolicitarEtiquetas
        '
        Me.barbtnSolicitarEtiquetas.Caption = "Solicitar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Etiquetas"
        Me.barbtnSolicitarEtiquetas.Id = 3
        Me.barbtnSolicitarEtiquetas.ImageOptions.Image = CType(resources.GetObject("barbtnSolicitarEtiquetas.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSolicitarEtiquetas.Name = "barbtnSolicitarEtiquetas"
        '
        'barbtnRecibo
        '
        Me.barbtnRecibo.Caption = "Aplicar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibo"
        Me.barbtnRecibo.Id = 0
        Me.barbtnRecibo.ImageOptions.Image = CType(resources.GetObject("barbtnRecibo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnRecibo.ImageOptions.LargeImage = CType(resources.GetObject("barbtnRecibo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnRecibo.Name = "barbtnRecibo"
        '
        'barbtnInstruccionesTrabajo
        '
        Me.barbtnInstruccionesTrabajo.Caption = "Instrucciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajo"
        Me.barbtnInstruccionesTrabajo.Id = 11
        Me.barbtnInstruccionesTrabajo.ImageOptions.Image = CType(resources.GetObject("barbtnInstruccionesTrabajo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnInstruccionesTrabajo.Name = "barbtnInstruccionesTrabajo"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1307, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 707)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1307, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 660)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1307, 47)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 660)
        '
        'DsdtControlProduccionTableAdapter1
        '
        Me.DsdtControlProduccionTableAdapter1.ClearBeforeFill = True
        '
        'dsdtControlProduccionBindingSource
        '
        Me.dsdtControlProduccionBindingSource.DataMember = "dsdtControlProduccion"
        Me.dsdtControlProduccionBindingSource.DataSource = Me.DsControlProduccion2
        Me.dsdtControlProduccionBindingSource.Sort = ""
        '
        'DsControlProduccion2
        '
        Me.DsControlProduccion2.DataSetName = "dsControlProduccion"
        Me.DsControlProduccion2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lycControlProduccion
        '
        Me.lycControlProduccion.Controls.Add(Me.grdControlProduccion)
        Me.lycControlProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycControlProduccion.Location = New System.Drawing.Point(0, 47)
        Me.lycControlProduccion.Name = "lycControlProduccion"
        Me.lycControlProduccion.Root = Me.LayoutControlGroup1
        Me.lycControlProduccion.Size = New System.Drawing.Size(953, 617)
        Me.lycControlProduccion.TabIndex = 4
        Me.lycControlProduccion.Text = "LayoutControl1"
        '
        'grdControlProduccion
        '
        Me.grdControlProduccion.DataMember = "dsdtControlProduccion"
        Me.grdControlProduccion.DataSource = Me.DsControlProduccion1
        Me.grdControlProduccion.Location = New System.Drawing.Point(12, 12)
        Me.grdControlProduccion.MainView = Me.tlviewControlProduccion
        Me.grdControlProduccion.MenuManager = Me.barManager1
        Me.grdControlProduccion.Name = "grdControlProduccion"
        Me.grdControlProduccion.Size = New System.Drawing.Size(929, 593)
        Me.grdControlProduccion.TabIndex = 4
        Me.grdControlProduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tlviewControlProduccion})
        '
        'tlviewControlProduccion
        '
        Me.tlviewControlProduccion.Appearance.GroupText.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.tlviewControlProduccion.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlviewControlProduccion.Appearance.GroupText.Options.UseFont = True
        Me.tlviewControlProduccion.Appearance.GroupText.Options.UseForeColor = True
        Me.tlviewControlProduccion.Appearance.GroupText.Options.UseTextOptions = True
        Me.tlviewControlProduccion.Appearance.GroupText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlviewControlProduccion.Appearance.ItemFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlviewControlProduccion.Appearance.ItemFocused.Options.UseBackColor = True
        Me.tlviewControlProduccion.Appearance.ItemNormal.BackColor = System.Drawing.Color.Silver
        Me.tlviewControlProduccion.Appearance.ItemNormal.Options.UseBackColor = True
        Me.tlviewControlProduccion.Appearance.ItemPressed.BackColor = System.Drawing.Color.Red
        Me.tlviewControlProduccion.Appearance.ItemPressed.Options.UseBackColor = True
        Me.tlviewControlProduccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreferencial, Me.colEstado, Me.colPrioridad, Me.colPrioridadMaquina, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProduccionHora, Me.colHorasPendiente, Me.colComentarios})
        Me.tlviewControlProduccion.ColumnSet.GroupColumn = Me.colPreferencial
        Me.tlviewControlProduccion.GridControl = Me.grdControlProduccion
        Me.tlviewControlProduccion.Name = "tlviewControlProduccion"
        Me.tlviewControlProduccion.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlviewControlProduccion.OptionsTiles.IndentBetweenGroups = 0
        Me.tlviewControlProduccion.OptionsTiles.IndentBetweenItems = 4
        Me.tlviewControlProduccion.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(10)
        Me.tlviewControlProduccion.OptionsTiles.ItemSize = New System.Drawing.Size(250, 80)
        Me.tlviewControlProduccion.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tlviewControlProduccion.OptionsTiles.Padding = New System.Windows.Forms.Padding(9)
        Me.tlviewControlProduccion.OptionsTiles.RowCount = 0
        Me.tlviewControlProduccion.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar
        Me.tlviewControlProduccion.OptionsView.BackgroundColorMode = DevExpress.XtraGrid.Views.Tile.BackgroundColorMode.ItemBackground
        Me.tlviewControlProduccion.OptionsView.ShowViewCaption = True
        Me.tlviewControlProduccion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPreferencial, DevExpress.Data.ColumnSortOrder.Ascending)})
        TableColumnDefinition1.Length.Value = 138.0R
        TableColumnDefinition2.Length.Value = 58.0R
        Me.tlviewControlProduccion.TileColumns.Add(TableColumnDefinition1)
        Me.tlviewControlProduccion.TileColumns.Add(TableColumnDefinition2)
        TableRowDefinition1.Length.Value = 20.0R
        TableRowDefinition2.Length.Value = 24.0R
        TableRowDefinition3.Length.Value = 21.0R
        TableRowDefinition4.Length.Value = 18.0R
        Me.tlviewControlProduccion.TileRows.Add(TableRowDefinition1)
        Me.tlviewControlProduccion.TileRows.Add(TableRowDefinition2)
        Me.tlviewControlProduccion.TileRows.Add(TableRowDefinition3)
        Me.tlviewControlProduccion.TileRows.Add(TableRowDefinition4)
        TileViewItemElement1.AnimateTransition = DevExpress.Utils.DefaultBoolean.[True]
        TileViewItemElement1.Column = Me.colEstado
        TileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.Text = "colEstado"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Column = Me.colCodigoArticulo
        TileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.RowIndex = 1
        TileViewItemElement2.Text = "colCodigoArticulo"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement3.Column = Me.colNombreArticulo
        TileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 2
        TileViewItemElement3.Text = "colNombreArticulo"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Blue
        TileViewItemElement4.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement4.Column = Me.colPlaneado
        TileViewItemElement4.ColumnIndex = 1
        TileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.Text = "colPlaneado"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.Green
        TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement5.Column = Me.colCompletado
        TileViewItemElement5.ColumnIndex = 1
        TileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement5.RowIndex = 1
        TileViewItemElement5.Text = "colCompletado"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement6.Column = Me.colComentarios
        TileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement6.RowIndex = 3
        TileViewItemElement6.Text = "colComentarios"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.Red
        TileViewItemElement7.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement7.Column = Me.colPendiente
        TileViewItemElement7.ColumnIndex = 1
        TileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement7.RowIndex = 2
        TileViewItemElement7.Text = "colPendiente"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement1)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement2)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement3)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement4)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement5)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement6)
        Me.tlviewControlProduccion.TileTemplate.Add(TileViewItemElement7)
        Me.tlviewControlProduccion.ViewCaption = "Control de Producción"
        '
        'colPreferencial
        '
        Me.colPreferencial.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colPreferencial.AppearanceCell.Options.UseFont = True
        Me.colPreferencial.FieldName = "Preferencial"
        Me.colPreferencial.Name = "colPreferencial"
        Me.colPreferencial.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPreferencial.Visible = True
        Me.colPreferencial.VisibleIndex = 0
        '
        'colPrioridad
        '
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 2
        '
        'colPrioridadMaquina
        '
        Me.colPrioridadMaquina.FieldName = "PrioridadMaquina"
        Me.colPrioridadMaquina.Name = "colPrioridadMaquina"
        Me.colPrioridadMaquina.Visible = True
        Me.colPrioridadMaquina.VisibleIndex = 3
        '
        'colProduccionHora
        '
        Me.colProduccionHora.FieldName = "ProduccionHora"
        Me.colProduccionHora.Name = "colProduccionHora"
        Me.colProduccionHora.Visible = True
        Me.colProduccionHora.VisibleIndex = 9
        '
        'colHorasPendiente
        '
        Me.colHorasPendiente.FieldName = "HorasPendiente"
        Me.colHorasPendiente.Name = "colHorasPendiente"
        Me.colHorasPendiente.Visible = True
        Me.colHorasPendiente.VisibleIndex = 10
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(953, 617)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdControlProduccion
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(933, 597)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'rdlMenu
        '
        Me.rdlMenu.BackColor = System.Drawing.Color.Silver
        Me.rdlMenu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdlMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnIniciarProceso), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnDetener), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnEtiquetas), New DevExpress.XtraBars.LinkPersistInfo(Me.rbtnCambiarMaquina)})
        Me.rdlMenu.Manager = Me.barManager1
        Me.rdlMenu.MenuColor = System.Drawing.Color.Black
        Me.rdlMenu.Name = "rdlMenu"
        Me.rdlMenu.SubMenuHoverColor = System.Drawing.Color.Black
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'DsParametros_Instrucciones1
        '
        Me.DsParametros_Instrucciones1.DataSetName = "dsParametros_Instrucciones"
        Me.DsParametros_Instrucciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmControlProduccion
        '
        Me.ClientSize = New System.Drawing.Size(1307, 707)
        Me.Controls.Add(Me.lycControlProduccion)
        Me.Controls.Add(Me.pancControlProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.HelpButton = True
        Me.Name = "frmControlProduccion"
        Me.Text = "Control de Producción"
        CType(Me.DsControlProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.docmControlProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pancControlProduccion.ResumeLayout(False)
        Me.dockpMaquina.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        CType(Me.lycMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycMaquina.ResumeLayout(False)
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockpMolde.ResumeLayout(False)
        Me.ControlContainer2.ResumeLayout(False)
        CType(Me.lycMolde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycMolde.ResumeLayout(False)
        CType(Me.txtSacosDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibrasHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInyeccionMaxima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInyeccionMinima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInyeccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCicloMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCicloMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCicloTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCicloHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiclo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLugar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCavidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreferencial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMolde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docpColores.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.lycColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycColores.ResumeLayout(False)
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsdtControlProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlProduccion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycControlProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycControlProduccion.ResumeLayout(False)
        CType(Me.grdControlProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlviewControlProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Instrucciones1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend barManager1 As DevExpress.XtraBars.BarManager
    Friend bar3 As DevExpress.XtraBars.Bar
    Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lycControlProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdControlProduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsControlProduccion1 As waProduccion_Pedidos.dsControlProduccion
    Friend WithEvents tlviewControlProduccion As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colPreferencial As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPrioridadMaquina As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colProduccionHora As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colHorasPendiente As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents rdlMenu As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnIniciarProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDetener As DevExpress.XtraBars.BarSubItem
    Friend WithEvents rbtnRevisionMolde As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRevisionMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnInstruccionDirecta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFinalizacionTrabajo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCambiarMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnProgramacionGrafica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiReportes As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barbtnProgramacionFinal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents docmControlProduccion As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents docpColores As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lycColores As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodigoPadre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barSuperiorControlProduccion As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnRecibo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnTrabajoIniciar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnTrabajoDetener As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barbtnSolicitarEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbnCambiarMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEditarTrabajos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetenerTrabajoFinalizado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetenerRevisionMolde As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetenerRevisionMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDentenerInstruccionDirecta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dockpMaquina As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lycMaquina As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents pancControlProduccion As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents dockpMolde As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer2 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lycMolde As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtSacosDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLibrasHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccionMaxima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccionMinima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloMinimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloTurno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCiclo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUbicacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLugar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtunidades As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCavidades As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPreferencial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMolde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnInstruccionesTrabajo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Instrucciones1 As waProduccion_Pedidos.dsParametros_Instrucciones
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsdtControlProduccionTableAdapter1 As waProduccion_Pedidos.dsControlProduccionTableAdapters.dsdtControlProduccionTableAdapter
    Friend WithEvents dsdtControlProduccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsControlProduccion2 As waProduccion_Pedidos.dsControlProduccion
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem

End Class
