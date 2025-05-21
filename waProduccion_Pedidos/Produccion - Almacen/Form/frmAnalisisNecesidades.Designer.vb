<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisNecesidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisNecesidades))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colDisponible = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.lycAnalisisNecesidades = New DevExpress.XtraLayout.LayoutControl()
        Me.splitAnalisisNecesidades = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycAnalisisNecesidades_Filtro = New DevExpress.XtraLayout.LayoutControl()
        Me.spinDeudaEnsamble = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barAnalisisNecesidad = New DevExpress.XtraBars.Bar()
        Me.barbtnPlantillaEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnPlantillaActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnPlantillaGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcAnalisisNecesidades = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnFichaArticulo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaRol = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaCampana = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaProyeccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAnalisisVentas = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnContinuar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.spinrdgStock = New DevExpress.XtraEditors.SpinEdit()
        Me.rdgStock = New DevExpress.XtraEditors.RadioGroup()
        Me.sluePlantillas = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueCampana = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.spinDeudaProyeccion = New DevExpress.XtraEditors.SpinEdit()
        Me.spinDeudaCampana = New DevExpress.XtraEditors.SpinEdit()
        Me.spinDeudaRol = New DevExpress.XtraEditors.SpinEdit()
        Me.spinMenorA = New DevExpress.XtraEditors.SpinEdit()
        Me.spinStockMayor = New DevExpress.XtraEditors.SpinEdit()
        Me.slueCodigoPadreFinal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueCodigoPadreInicial = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueCodigoPadre = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueColor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueTipoArticulo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycrdgStock = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycAnalisisNecesidades_Resultado = New DevExpress.XtraLayout.LayoutControl()
        Me.btnAplicarFiltro = New DevExpress.XtraEditors.SimpleButton()
        Me.chkFiltro = New DevExpress.XtraEditors.CheckButton()
        Me.grdAnalisisNecesidades = New DevExpress.XtraGrid.GridControl()
        Me.DsAnalisisNecesidades1 = New waProduccion_Pedidos.dsAnalisisNecesidades()
        Me.grdviewAnalisisArticulos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gbdDatosArticulo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDeLinea = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdPositivos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProduccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEnsamble = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalPositivo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdNegativos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRol = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCampana = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProyeccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDeudaEnsamble = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalNegativo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdResultado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colSugerido = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycAnalisisNecesidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAnalisisNecesidades.SuspendLayout()
        CType(Me.splitAnalisisNecesidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAnalisisNecesidades.SuspendLayout()
        CType(Me.lycAnalisisNecesidades_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAnalisisNecesidades_Filtro.SuspendLayout()
        CType(Me.spinDeudaEnsamble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinrdgStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluePlantillas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCampana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinDeudaProyeccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinDeudaCampana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinDeudaRol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMenorA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinStockMayor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoPadreFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoPadreInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueTipoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycrdgStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycAnalisisNecesidades_Resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAnalisisNecesidades_Resultado.SuspendLayout()
        CType(Me.grdAnalisisNecesidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnalisisNecesidades1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewAnalisisArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDisponible
        '
        Me.colDisponible.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDisponible.AppearanceCell.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colDisponible.AppearanceHeader.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Options.UseTextOptions = True
        Me.colDisponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDisponible.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDisponible.FieldName = "Disponible"
        Me.colDisponible.MinWidth = 15
        Me.colDisponible.Name = "colDisponible"
        Me.colDisponible.OptionsColumn.ReadOnly = True
        Me.colDisponible.Visible = True
        Me.colDisponible.Width = 43
        '
        'lycAnalisisNecesidades
        '
        Me.lycAnalisisNecesidades.Controls.Add(Me.splitAnalisisNecesidades)
        Me.lycAnalisisNecesidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAnalisisNecesidades.Location = New System.Drawing.Point(0, 0)
        Me.lycAnalisisNecesidades.Name = "lycAnalisisNecesidades"
        Me.lycAnalisisNecesidades.Root = Me.LayoutControlGroup1
        Me.lycAnalisisNecesidades.Size = New System.Drawing.Size(1351, 699)
        Me.lycAnalisisNecesidades.TabIndex = 0
        Me.lycAnalisisNecesidades.Text = "LayoutControl1"
        '
        'splitAnalisisNecesidades
        '
        Me.splitAnalisisNecesidades.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.splitAnalisisNecesidades.ContentImage = CType(resources.GetObject("splitAnalisisNecesidades.ContentImage"), System.Drawing.Image)
        Me.splitAnalisisNecesidades.Horizontal = False
        Me.splitAnalisisNecesidades.Location = New System.Drawing.Point(8, 10)
        Me.splitAnalisisNecesidades.Name = "splitAnalisisNecesidades"
        Me.splitAnalisisNecesidades.Panel1.Controls.Add(Me.lycAnalisisNecesidades_Filtro)
        Me.splitAnalisisNecesidades.Panel1.Text = "Panel1"
        Me.splitAnalisisNecesidades.Panel2.Controls.Add(Me.lycAnalisisNecesidades_Resultado)
        Me.splitAnalisisNecesidades.Panel2.Text = "Panel2"
        Me.splitAnalisisNecesidades.Size = New System.Drawing.Size(1335, 679)
        Me.splitAnalisisNecesidades.SplitterPosition = 227
        Me.splitAnalisisNecesidades.TabIndex = 4
        Me.splitAnalisisNecesidades.Text = "SplitContainerControl1"
        '
        'lycAnalisisNecesidades_Filtro
        '
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinDeudaEnsamble)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinrdgStock)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.rdgStock)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.sbdcAnalisisNecesidades)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.sluePlantillas)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueCliente)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueCampana)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinDeudaProyeccion)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinDeudaCampana)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinDeudaRol)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinMenorA)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.spinStockMayor)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueCodigoPadreFinal)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueCodigoPadreInicial)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueCodigoPadre)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueColor)
        Me.lycAnalisisNecesidades_Filtro.Controls.Add(Me.slueTipoArticulo)
        Me.lycAnalisisNecesidades_Filtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAnalisisNecesidades_Filtro.Location = New System.Drawing.Point(0, 0)
        Me.lycAnalisisNecesidades_Filtro.Name = "lycAnalisisNecesidades_Filtro"
        Me.lycAnalisisNecesidades_Filtro.Root = Me.LayoutControlGroup2
        Me.lycAnalisisNecesidades_Filtro.Size = New System.Drawing.Size(1335, 227)
        Me.lycAnalisisNecesidades_Filtro.TabIndex = 0
        Me.lycAnalisisNecesidades_Filtro.Text = "LayoutControl1"
        '
        'spinDeudaEnsamble
        '
        Me.spinDeudaEnsamble.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinDeudaEnsamble.Location = New System.Drawing.Point(600, 77)
        Me.spinDeudaEnsamble.MenuManager = Me.BarManager1
        Me.spinDeudaEnsamble.Name = "spinDeudaEnsamble"
        Me.spinDeudaEnsamble.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinDeudaEnsamble.Size = New System.Drawing.Size(70, 20)
        Me.spinDeudaEnsamble.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinDeudaEnsamble.TabIndex = 22
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barAnalisisNecesidad, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcAnalisisNecesidades)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnPlantillaEliminar, Me.barbtnPlantillaActualizar, Me.barbtnPlantillaGrabar, Me.barbtnStock, Me.barbtnEnsamble, Me.barbtnProduccion, Me.barbtnDeudaRol, Me.barbtnDeudaCampana, Me.barbtnDeudaProyeccion, Me.barbtnDeudaEnsamble, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnBuscar, Me.barbtnCerrar, Me.barbtnContinuar, Me.barbtnFichaArticulo, Me.BarButtonItem1, Me.barbtnAnalisisVentas})
        Me.BarManager1.MaxItemId = 18
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barAnalisisNecesidad
        '
        Me.barAnalisisNecesidad.BarName = "Tools"
        Me.barAnalisisNecesidad.DockCol = 0
        Me.barAnalisisNecesidad.DockRow = 0
        Me.barAnalisisNecesidad.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barAnalisisNecesidad.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnPlantillaEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnPlantillaActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnPlantillaGrabar)})
        Me.barAnalisisNecesidad.OptionsBar.AllowQuickCustomization = False
        Me.barAnalisisNecesidad.OptionsBar.DrawBorder = False
        Me.barAnalisisNecesidad.OptionsBar.DrawDragBorder = False
        Me.barAnalisisNecesidad.StandaloneBarDockControl = Me.sbdcAnalisisNecesidades
        Me.barAnalisisNecesidad.Text = "Tools"
        '
        'barbtnPlantillaEliminar
        '
        Me.barbtnPlantillaEliminar.Caption = "Eliminar"
        Me.barbtnPlantillaEliminar.Id = 0
        Me.barbtnPlantillaEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnPlantillaEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPlantillaEliminar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnPlantillaEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnPlantillaEliminar.Name = "barbtnPlantillaEliminar"
        '
        'barbtnPlantillaActualizar
        '
        Me.barbtnPlantillaActualizar.Caption = "Actualizar"
        Me.barbtnPlantillaActualizar.Id = 1
        Me.barbtnPlantillaActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnPlantillaActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPlantillaActualizar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnPlantillaActualizar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnPlantillaActualizar.Name = "barbtnPlantillaActualizar"
        '
        'barbtnPlantillaGrabar
        '
        Me.barbtnPlantillaGrabar.Caption = "Grabar"
        Me.barbtnPlantillaGrabar.Id = 2
        Me.barbtnPlantillaGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnPlantillaGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPlantillaGrabar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnPlantillaGrabar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnPlantillaGrabar.Name = "barbtnPlantillaGrabar"
        '
        'sbdcAnalisisNecesidades
        '
        Me.sbdcAnalisisNecesidades.Appearance.Options.UseTextOptions = True
        Me.sbdcAnalisisNecesidades.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sbdcAnalisisNecesidades.CausesValidation = False
        Me.sbdcAnalisisNecesidades.Location = New System.Drawing.Point(851, 193)
        Me.sbdcAnalisisNecesidades.Manager = Me.BarManager1
        Me.sbdcAnalisisNecesidades.Name = "sbdcAnalisisNecesidades"
        Me.sbdcAnalisisNecesidades.Size = New System.Drawing.Size(102, 24)
        Me.sbdcAnalisisNecesidades.Text = "StandaloneBarDockControl1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnFichaArticulo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnStock, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEnsamble, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProduccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaRol, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaCampana, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaProyeccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaEnsamble, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAnalisisVentas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnExportarXlsx), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnContinuar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnFichaArticulo
        '
        Me.barbtnFichaArticulo.Caption = "Ficha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Articulo"
        Me.barbtnFichaArticulo.Id = 15
        Me.barbtnFichaArticulo.ImageOptions.Image = CType(resources.GetObject("barbtnFichaArticulo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFichaArticulo.Name = "barbtnFichaArticulo"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Id = 3
        Me.barbtnStock.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.barofpie_32x321
        Me.barbtnStock.Name = "barbtnStock"
        '
        'barbtnEnsamble
        '
        Me.barbtnEnsamble.Caption = "Ensamble"
        Me.barbtnEnsamble.Id = 4
        Me.barbtnEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEnsamble.Name = "barbtnEnsamble"
        '
        'barbtnProduccion
        '
        Me.barbtnProduccion.Caption = "Producción"
        Me.barbtnProduccion.Id = 5
        Me.barbtnProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProduccion.Name = "barbtnProduccion"
        '
        'barbtnDeudaRol
        '
        Me.barbtnDeudaRol.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        Me.barbtnDeudaRol.Description = "Deuda de todos los Articulos que no son de Campaña"
        Me.barbtnDeudaRol.Id = 6
        Me.barbtnDeudaRol.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaRol.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaRol.Name = "barbtnDeudaRol"
        Me.barbtnDeudaRol.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem1.Text = "Deuda Rol"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Detalle de los articulos pendientes de facturar que no son de campaña."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.barbtnDeudaRol.SuperTip = SuperToolTip1
        '
        'barbtnDeudaCampana
        '
        Me.barbtnDeudaCampana.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Campaña"
        Me.barbtnDeudaCampana.Id = 7
        Me.barbtnDeudaCampana.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaCampana.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaCampana.Name = "barbtnDeudaCampana"
        '
        'barbtnDeudaProyeccion
        '
        Me.barbtnDeudaProyeccion.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proyección"
        Me.barbtnDeudaProyeccion.Id = 8
        Me.barbtnDeudaProyeccion.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaProyeccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaProyeccion.Name = "barbtnDeudaProyeccion"
        '
        'barbtnDeudaEnsamble
        '
        Me.barbtnDeudaEnsamble.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ensamble"
        Me.barbtnDeudaEnsamble.Id = 9
        Me.barbtnDeudaEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaEnsamble.Name = "barbtnDeudaEnsamble"
        '
        'barbtnAnalisisVentas
        '
        Me.barbtnAnalisisVentas.Caption = "Analisis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Ventas"
        Me.barbtnAnalisisVentas.Id = 17
        Me.barbtnAnalisisVentas.ImageOptions.Image = CType(resources.GetObject("barbtnAnalisisVentas.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAnalisisVentas.Name = "barbtnAnalisisVentas"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 12
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir Grid"
        Me.barbtnImprimirGrid.Id = 10
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar Xlsx"
        Me.barbtnExportarXlsx.Id = 11
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 13
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnContinuar
        '
        Me.barbtnContinuar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnContinuar.Caption = "Continuar"
        Me.barbtnContinuar.Id = 14
        Me.barbtnContinuar.ImageOptions.Image = CType(resources.GetObject("barbtnContinuar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnContinuar.Name = "barbtnContinuar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1351, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 699)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1351, 42)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 699)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1351, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 699)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Analisis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Venta"
        Me.BarButtonItem1.Id = 16
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'spinrdgStock
        '
        Me.spinrdgStock.EditValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.spinrdgStock.Location = New System.Drawing.Point(397, 53)
        Me.spinrdgStock.MenuManager = Me.BarManager1
        Me.spinrdgStock.Name = "spinrdgStock"
        Me.spinrdgStock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinrdgStock.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.spinrdgStock.Size = New System.Drawing.Size(70, 20)
        Me.spinrdgStock.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinrdgStock.TabIndex = 20
        '
        'rdgStock
        '
        Me.rdgStock.EditValue = "Ninguno"
        Me.rdgStock.Location = New System.Drawing.Point(266, 101)
        Me.rdgStock.MenuManager = Me.BarManager1
        Me.rdgStock.Name = "rdgStock"
        Me.rdgStock.Properties.Columns = 2
        Me.rdgStock.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Ninguno", "Ninguno"), New DevExpress.XtraEditors.Controls.RadioGroupItem("MenorMinimo", "Stock Menor al Minimo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Menor%Minimo", "Stock Menor al % Minimo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("MenorMaximo", "Stock Menor al Maximo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("EntreMinimoMaximo", "Stock Entre Minimo y Maximo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("DisponibleMenorMinimo", "Disponible Menor al Minimo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("DisponibleMenor2M", "Disponible Menor A 2 Meses"), New DevExpress.XtraEditors.Controls.RadioGroupItem("TOP50", "Mostrar Top 50")})
        Me.rdgStock.Size = New System.Drawing.Size(404, 106)
        Me.rdgStock.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.rdgStock.TabIndex = 19
        '
        'sluePlantillas
        '
        Me.sluePlantillas.Location = New System.Drawing.Point(803, 169)
        Me.sluePlantillas.MaximumSize = New System.Drawing.Size(150, 0)
        Me.sluePlantillas.MinimumSize = New System.Drawing.Size(150, 0)
        Me.sluePlantillas.Name = "sluePlantillas"
        Me.sluePlantillas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluePlantillas.Properties.NullText = ""
        Me.sluePlantillas.Properties.PopupView = Me.GridView2
        Me.sluePlantillas.Size = New System.Drawing.Size(150, 20)
        Me.sluePlantillas.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.sluePlantillas.TabIndex = 18
        '
        'GridView2
        '
        Me.GridView2.DetailHeight = 284
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'slueCliente
        '
        Me.slueCliente.Location = New System.Drawing.Point(803, 29)
        Me.slueCliente.MaximumSize = New System.Drawing.Size(150, 0)
        Me.slueCliente.MinimumSize = New System.Drawing.Size(150, 0)
        Me.slueCliente.Name = "slueCliente"
        Me.slueCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCliente.Properties.NullText = ""
        Me.slueCliente.Properties.PopupView = Me.SearchLookUpEdit7View
        Me.slueCliente.Size = New System.Drawing.Size(150, 20)
        Me.slueCliente.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueCliente.TabIndex = 17
        '
        'SearchLookUpEdit7View
        '
        Me.SearchLookUpEdit7View.DetailHeight = 284
        Me.SearchLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit7View.Name = "SearchLookUpEdit7View"
        Me.SearchLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'slueCampana
        '
        Me.slueCampana.Location = New System.Drawing.Point(803, 5)
        Me.slueCampana.MaximumSize = New System.Drawing.Size(150, 0)
        Me.slueCampana.MinimumSize = New System.Drawing.Size(150, 0)
        Me.slueCampana.Name = "slueCampana"
        Me.slueCampana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCampana.Properties.NullText = ""
        Me.slueCampana.Properties.PopupView = Me.SearchLookUpEdit6View
        Me.slueCampana.Size = New System.Drawing.Size(150, 20)
        Me.slueCampana.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueCampana.TabIndex = 16
        '
        'SearchLookUpEdit6View
        '
        Me.SearchLookUpEdit6View.DetailHeight = 284
        Me.SearchLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit6View.Name = "SearchLookUpEdit6View"
        Me.SearchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit6View.OptionsView.ShowGroupPanel = False
        '
        'spinDeudaProyeccion
        '
        Me.spinDeudaProyeccion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinDeudaProyeccion.Location = New System.Drawing.Point(600, 53)
        Me.spinDeudaProyeccion.MaximumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaProyeccion.MinimumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaProyeccion.Name = "spinDeudaProyeccion"
        Me.spinDeudaProyeccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinDeudaProyeccion.Size = New System.Drawing.Size(70, 20)
        Me.spinDeudaProyeccion.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinDeudaProyeccion.TabIndex = 15
        '
        'spinDeudaCampana
        '
        Me.spinDeudaCampana.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinDeudaCampana.Location = New System.Drawing.Point(600, 29)
        Me.spinDeudaCampana.MaximumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaCampana.MinimumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaCampana.Name = "spinDeudaCampana"
        Me.spinDeudaCampana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinDeudaCampana.Size = New System.Drawing.Size(70, 20)
        Me.spinDeudaCampana.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinDeudaCampana.TabIndex = 14
        '
        'spinDeudaRol
        '
        Me.spinDeudaRol.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinDeudaRol.Location = New System.Drawing.Point(600, 5)
        Me.spinDeudaRol.MaximumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaRol.MinimumSize = New System.Drawing.Size(70, 0)
        Me.spinDeudaRol.Name = "spinDeudaRol"
        Me.spinDeudaRol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinDeudaRol.Size = New System.Drawing.Size(70, 20)
        Me.spinDeudaRol.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinDeudaRol.TabIndex = 13
        '
        'spinMenorA
        '
        Me.spinMenorA.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMenorA.Location = New System.Drawing.Point(397, 29)
        Me.spinMenorA.MaximumSize = New System.Drawing.Size(70, 0)
        Me.spinMenorA.MinimumSize = New System.Drawing.Size(70, 0)
        Me.spinMenorA.Name = "spinMenorA"
        Me.spinMenorA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMenorA.Size = New System.Drawing.Size(70, 20)
        Me.spinMenorA.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinMenorA.TabIndex = 10
        '
        'spinStockMayor
        '
        Me.spinStockMayor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinStockMayor.Location = New System.Drawing.Point(397, 5)
        Me.spinStockMayor.MaximumSize = New System.Drawing.Size(70, 0)
        Me.spinStockMayor.MinimumSize = New System.Drawing.Size(70, 0)
        Me.spinStockMayor.Name = "spinStockMayor"
        Me.spinStockMayor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinStockMayor.Size = New System.Drawing.Size(70, 20)
        Me.spinStockMayor.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.spinStockMayor.TabIndex = 9
        '
        'slueCodigoPadreFinal
        '
        Me.slueCodigoPadreFinal.Location = New System.Drawing.Point(148, 132)
        Me.slueCodigoPadreFinal.MaximumSize = New System.Drawing.Size(101, 0)
        Me.slueCodigoPadreFinal.MinimumSize = New System.Drawing.Size(101, 0)
        Me.slueCodigoPadreFinal.Name = "slueCodigoPadreFinal"
        Me.slueCodigoPadreFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoPadreFinal.Properties.NullText = ""
        Me.slueCodigoPadreFinal.Properties.PopupView = Me.SearchLookUpEdit5View
        Me.slueCodigoPadreFinal.Size = New System.Drawing.Size(101, 20)
        Me.slueCodigoPadreFinal.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueCodigoPadreFinal.TabIndex = 8
        '
        'SearchLookUpEdit5View
        '
        Me.SearchLookUpEdit5View.DetailHeight = 284
        Me.SearchLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit5View.Name = "SearchLookUpEdit5View"
        Me.SearchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'slueCodigoPadreInicial
        '
        Me.slueCodigoPadreInicial.Location = New System.Drawing.Point(148, 108)
        Me.slueCodigoPadreInicial.MaximumSize = New System.Drawing.Size(101, 0)
        Me.slueCodigoPadreInicial.MinimumSize = New System.Drawing.Size(101, 0)
        Me.slueCodigoPadreInicial.Name = "slueCodigoPadreInicial"
        Me.slueCodigoPadreInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoPadreInicial.Properties.NullText = ""
        Me.slueCodigoPadreInicial.Properties.PopupView = Me.SearchLookUpEdit4View
        Me.slueCodigoPadreInicial.Size = New System.Drawing.Size(101, 20)
        Me.slueCodigoPadreInicial.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueCodigoPadreInicial.TabIndex = 7
        '
        'SearchLookUpEdit4View
        '
        Me.SearchLookUpEdit4View.DetailHeight = 284
        Me.SearchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit4View.Name = "SearchLookUpEdit4View"
        Me.SearchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'slueCodigoPadre
        '
        Me.slueCodigoPadre.Location = New System.Drawing.Point(139, 53)
        Me.slueCodigoPadre.MaximumSize = New System.Drawing.Size(125, 0)
        Me.slueCodigoPadre.MinimumSize = New System.Drawing.Size(125, 0)
        Me.slueCodigoPadre.Name = "slueCodigoPadre"
        Me.slueCodigoPadre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoPadre.Properties.NullText = ""
        Me.slueCodigoPadre.Properties.PopupView = Me.SearchLookUpEdit3View
        Me.slueCodigoPadre.Size = New System.Drawing.Size(125, 20)
        Me.slueCodigoPadre.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueCodigoPadre.TabIndex = 6
        '
        'SearchLookUpEdit3View
        '
        Me.SearchLookUpEdit3View.DetailHeight = 284
        Me.SearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit3View.Name = "SearchLookUpEdit3View"
        Me.SearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'slueColor
        '
        Me.slueColor.Location = New System.Drawing.Point(139, 29)
        Me.slueColor.MaximumSize = New System.Drawing.Size(125, 0)
        Me.slueColor.MinimumSize = New System.Drawing.Size(125, 0)
        Me.slueColor.Name = "slueColor"
        Me.slueColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueColor.Properties.NullText = ""
        Me.slueColor.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.slueColor.Size = New System.Drawing.Size(125, 20)
        Me.slueColor.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueColor.TabIndex = 5
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.DetailHeight = 284
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'slueTipoArticulo
        '
        Me.slueTipoArticulo.Location = New System.Drawing.Point(139, 5)
        Me.slueTipoArticulo.MaximumSize = New System.Drawing.Size(125, 0)
        Me.slueTipoArticulo.MinimumSize = New System.Drawing.Size(125, 0)
        Me.slueTipoArticulo.Name = "slueTipoArticulo"
        Me.slueTipoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTipoArticulo.Properties.NullText = ""
        Me.slueTipoArticulo.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.slueTipoArticulo.Size = New System.Drawing.Size(125, 20)
        Me.slueTipoArticulo.StyleController = Me.lycAnalisisNecesidades_Filtro
        Me.slueTipoArticulo.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.DetailHeight = 284
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
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LayoutControlItem16, Me.EmptySpaceItem4, Me.LayoutControlItem19, Me.LayoutControlItem21, Me.LayoutControlGroup4, Me.LayoutControlItem5, Me.EmptySpaceItem6, Me.EmptySpaceItem2, Me.LayoutControlItem18, Me.lycrdgStock, Me.EmptySpaceItem1, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1318, 232)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 161)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(258, 55)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.spinMenorA
        Me.LayoutControlItem10.CustomizationFormText = "Stock Menor A"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(258, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem10.Text = "Stock Menor A"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.spinDeudaCampana
        Me.LayoutControlItem14.CustomizationFormText = "Deuda Campaña Mayor A"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(461, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem14.Text = "Deuda Campaña Mayor A"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.spinDeudaProyeccion
        Me.LayoutControlItem15.CustomizationFormText = "Deuda Proyeccion Mayor A"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(461, 48)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem15.Text = "Deuda Proyeccion Mayor A"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.slueCampana
        Me.LayoutControlItem17.CustomizationFormText = "Numero Campaña"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(664, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(283, 24)
        Me.LayoutControlItem17.Text = "Numero Campaña"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.slueTipoArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Tipo Articulos"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem3.Text = "Tipo Articulos"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.slueColor
        Me.LayoutControlItem4.CustomizationFormText = "Color"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem4.Text = "Color"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.spinStockMayor
        Me.LayoutControlItem8.CustomizationFormText = "Stock Mayor A"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(258, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem8.Text = "Stock Mayor A"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.spinDeudaRol
        Me.LayoutControlItem13.CustomizationFormText = "Deuda Rol Mayor A"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(461, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem13.Text = "Deuda Rol Mayor A"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.slueCliente
        Me.LayoutControlItem16.CustomizationFormText = "Codigo Cliente"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(664, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(283, 24)
        Me.LayoutControlItem16.Text = "Codigo Cliente"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(129, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(947, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(357, 216)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.sbdcAnalisisNecesidades
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(843, 188)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(104, 28)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.rdgStock
        Me.LayoutControlItem21.CustomizationFormText = "Stock"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(258, 96)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(406, 110)
        Me.LayoutControlItem21.Text = "Stock"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Por Rango de Codigo Padre"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(258, 89)
        Me.LayoutControlGroup4.Text = "Por Rango de Codigo Padre"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.slueCodigoPadreInicial
        Me.LayoutControlItem6.CustomizationFormText = "Inicial"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(240, 24)
        Me.LayoutControlItem6.Text = "Inicial"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.slueCodigoPadreFinal
        Me.LayoutControlItem7.CustomizationFormText = "Final"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(240, 24)
        Me.LayoutControlItem7.Text = "Final"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(129, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.slueCodigoPadre
        Me.LayoutControlItem5.CustomizationFormText = "Codigo Padre"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem5.Text = "Codigo Padre"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(129, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(664, 188)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(179, 28)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(664, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(283, 116)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem18.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem18.Control = Me.sluePlantillas
        Me.LayoutControlItem18.CustomizationFormText = "Plantillas"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(664, 164)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(283, 24)
        Me.LayoutControlItem18.Text = "Plantillas"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(129, 13)
        '
        'lycrdgStock
        '
        Me.lycrdgStock.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycrdgStock.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycrdgStock.Control = Me.spinrdgStock
        Me.lycrdgStock.CustomizationFormText = "Vacio"
        Me.lycrdgStock.Location = New System.Drawing.Point(258, 48)
        Me.lycrdgStock.Name = "lycrdgStock"
        Me.lycrdgStock.Size = New System.Drawing.Size(203, 48)
        Me.lycrdgStock.Text = "Stock Menor al % Minimo"
        Me.lycrdgStock.TextSize = New System.Drawing.Size(129, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(258, 206)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(406, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.spinDeudaEnsamble
        Me.LayoutControlItem9.CustomizationFormText = "Deuda Ensamble Mayor A"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(461, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem9.Text = "Deuda Ensamble Mayor A"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(129, 13)
        '
        'lycAnalisisNecesidades_Resultado
        '
        Me.lycAnalisisNecesidades_Resultado.Controls.Add(Me.btnAplicarFiltro)
        Me.lycAnalisisNecesidades_Resultado.Controls.Add(Me.chkFiltro)
        Me.lycAnalisisNecesidades_Resultado.Controls.Add(Me.grdAnalisisNecesidades)
        Me.lycAnalisisNecesidades_Resultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAnalisisNecesidades_Resultado.Location = New System.Drawing.Point(0, 0)
        Me.lycAnalisisNecesidades_Resultado.Name = "lycAnalisisNecesidades_Resultado"
        Me.lycAnalisisNecesidades_Resultado.Root = Me.LayoutControlGroup3
        Me.lycAnalisisNecesidades_Resultado.Size = New System.Drawing.Size(1335, 442)
        Me.lycAnalisisNecesidades_Resultado.TabIndex = 0
        Me.lycAnalisisNecesidades_Resultado.Text = "LayoutControl1"
        '
        'btnAplicarFiltro
        '
        Me.btnAplicarFiltro.ImageOptions.Image = CType(resources.GetObject("btnAplicarFiltro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAplicarFiltro.Location = New System.Drawing.Point(8, 10)
        Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
        Me.btnAplicarFiltro.Size = New System.Drawing.Size(122, 36)
        Me.btnAplicarFiltro.StyleController = Me.lycAnalisisNecesidades_Resultado
        Me.btnAplicarFiltro.TabIndex = 6
        Me.btnAplicarFiltro.Text = "Aplicar Filtro"
        '
        'chkFiltro
        '
        Me.chkFiltro.Checked = True
        Me.chkFiltro.ImageOptions.Image = CType(resources.GetObject("chkFiltro.ImageOptions.Image"), System.Drawing.Image)
        Me.chkFiltro.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.chkFiltro.Location = New System.Drawing.Point(132, 10)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(1195, 36)
        Me.chkFiltro.StyleController = Me.lycAnalisisNecesidades_Resultado
        Me.chkFiltro.TabIndex = 5
        Me.chkFiltro.Text = "Ocultar Filtro"
        '
        'grdAnalisisNecesidades
        '
        Me.grdAnalisisNecesidades.DataMember = "dsdtAnalisisNecesidades"
        Me.grdAnalisisNecesidades.DataSource = Me.DsAnalisisNecesidades1
        Me.grdAnalisisNecesidades.Location = New System.Drawing.Point(8, 50)
        Me.grdAnalisisNecesidades.MainView = Me.grdviewAnalisisArticulos
        Me.grdAnalisisNecesidades.Name = "grdAnalisisNecesidades"
        Me.grdAnalisisNecesidades.Size = New System.Drawing.Size(1319, 382)
        Me.grdAnalisisNecesidades.TabIndex = 4
        Me.grdAnalisisNecesidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewAnalisisArticulos})
        '
        'DsAnalisisNecesidades1
        '
        Me.DsAnalisisNecesidades1.DataSetName = "dsAnalisisNecesidades"
        Me.DsAnalisisNecesidades1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewAnalisisArticulos
        '
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.Options.UseFont = True
        Me.grdviewAnalisisArticulos.Appearance.BandPanel.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.grdviewAnalisisArticulos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewAnalisisArticulos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff
        Me.grdviewAnalisisArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewAnalisisArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewAnalisisArticulos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.SaddleBrown
        Me.grdviewAnalisisArticulos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.Row.BackColor = System.Drawing.Color.OldLace
        Me.grdviewAnalisisArticulos.Appearance.Row.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grdviewAnalisisArticulos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewAnalisisArticulos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewAnalisisArticulos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Appearance.TopNewRow.Options.UseForeColor = True
        Me.grdviewAnalisisArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewAnalisisArticulos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewAnalisisArticulos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbdDatosArticulo, Me.gbdPositivos, Me.gbdNegativos, Me.gbdResultado})
        Me.grdviewAnalisisArticulos.ColumnPanelRowHeight = 28
        Me.grdviewAnalisisArticulos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDeLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colColor, Me.colStock, Me.colProduccion, Me.colEnsamble, Me.colTotalPositivo, Me.colRol, Me.colCampana, Me.colProyeccion, Me.colDeudaEnsamble, Me.colTotalNegativo, Me.colDisponible, Me.colSugerido, Me.colStockMinimo, Me.colStockMaximo})
        Me.grdviewAnalisisArticulos.DetailHeight = 284
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colDisponible
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        Me.grdviewAnalisisArticulos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grdviewAnalisisArticulos.GridControl = Me.grdAnalisisNecesidades
        Me.grdviewAnalisisArticulos.Name = "grdviewAnalisisArticulos"
        Me.grdviewAnalisisArticulos.OptionsBehavior.Editable = False
        Me.grdviewAnalisisArticulos.OptionsBehavior.ReadOnly = True
        Me.grdviewAnalisisArticulos.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.grdviewAnalisisArticulos.OptionsFind.SearchInPreview = True
        Me.grdviewAnalisisArticulos.OptionsFind.ShowCloseButton = False
        Me.grdviewAnalisisArticulos.OptionsFind.ShowFindButton = False
        Me.grdviewAnalisisArticulos.OptionsView.ColumnAutoWidth = False
        Me.grdviewAnalisisArticulos.OptionsView.ShowGroupPanel = False
        Me.grdviewAnalisisArticulos.PaintStyleName = "Style3D"
        '
        'gbdDatosArticulo
        '
        Me.gbdDatosArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdDatosArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdDatosArticulo.Caption = "Datos del Articulo"
        Me.gbdDatosArticulo.Columns.Add(Me.colDeLinea)
        Me.gbdDatosArticulo.Columns.Add(Me.colCodigoArticulo)
        Me.gbdDatosArticulo.Columns.Add(Me.colNombreArticulo)
        Me.gbdDatosArticulo.Columns.Add(Me.colColor)
        Me.gbdDatosArticulo.Columns.Add(Me.colStockMinimo)
        Me.gbdDatosArticulo.Columns.Add(Me.colStockMaximo)
        Me.gbdDatosArticulo.MinWidth = 7
        Me.gbdDatosArticulo.Name = "gbdDatosArticulo"
        Me.gbdDatosArticulo.VisibleIndex = 0
        Me.gbdDatosArticulo.Width = 461
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
        Me.colDeLinea.MinWidth = 15
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.ReadOnly = True
        Me.colDeLinea.Visible = True
        Me.colDeLinea.Width = 30
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
        Me.colCodigoArticulo.MinWidth = 15
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.Width = 90
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.MinWidth = 15
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.Width = 225
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor.FieldName = "Color"
        Me.colColor.MinWidth = 15
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.ReadOnly = True
        Me.colColor.Visible = True
        Me.colColor.Width = 30
        '
        'colStockMinimo
        '
        Me.colStockMinimo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStockMinimo.AppearanceHeader.Options.UseFont = True
        Me.colStockMinimo.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockMinimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockMinimo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockMinimo.FieldName = "StockMinimo"
        Me.colStockMinimo.MinWidth = 15
        Me.colStockMinimo.Name = "colStockMinimo"
        Me.colStockMinimo.OptionsColumn.ReadOnly = True
        Me.colStockMinimo.Visible = True
        Me.colStockMinimo.Width = 43
        '
        'colStockMaximo
        '
        Me.colStockMaximo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStockMaximo.AppearanceHeader.Options.UseFont = True
        Me.colStockMaximo.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockMaximo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockMaximo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockMaximo.FieldName = "StockMaximo"
        Me.colStockMaximo.MinWidth = 15
        Me.colStockMaximo.Name = "colStockMaximo"
        Me.colStockMaximo.OptionsColumn.ReadOnly = True
        Me.colStockMaximo.Visible = True
        Me.colStockMaximo.Width = 43
        '
        'gbdPositivos
        '
        Me.gbdPositivos.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdPositivos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdPositivos.Caption = "Valores Positivos"
        Me.gbdPositivos.Columns.Add(Me.colStock)
        Me.gbdPositivos.Columns.Add(Me.colProduccion)
        Me.gbdPositivos.Columns.Add(Me.colEnsamble)
        Me.gbdPositivos.Columns.Add(Me.colTotalPositivo)
        Me.gbdPositivos.MinWidth = 7
        Me.gbdPositivos.Name = "gbdPositivos"
        Me.gbdPositivos.VisibleIndex = 1
        Me.gbdPositivos.Width = 172
        '
        'colStock
        '
        Me.colStock.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colStock.AppearanceCell.Options.UseBackColor = True
        Me.colStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colStock.AppearanceHeader.Options.UseFont = True
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStock.FieldName = "Stock"
        Me.colStock.MinWidth = 15
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.ReadOnly = True
        Me.colStock.Visible = True
        Me.colStock.Width = 43
        '
        'colProduccion
        '
        Me.colProduccion.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colProduccion.AppearanceCell.Options.UseBackColor = True
        Me.colProduccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colProduccion.AppearanceHeader.Options.UseFont = True
        Me.colProduccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProduccion.FieldName = "Produccion"
        Me.colProduccion.MinWidth = 15
        Me.colProduccion.Name = "colProduccion"
        Me.colProduccion.OptionsColumn.ReadOnly = True
        Me.colProduccion.Visible = True
        Me.colProduccion.Width = 43
        '
        'colEnsamble
        '
        Me.colEnsamble.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colEnsamble.AppearanceCell.Options.UseBackColor = True
        Me.colEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsamble.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnsamble.FieldName = "Ensamble"
        Me.colEnsamble.MinWidth = 15
        Me.colEnsamble.Name = "colEnsamble"
        Me.colEnsamble.OptionsColumn.ReadOnly = True
        Me.colEnsamble.Visible = True
        Me.colEnsamble.Width = 43
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
        Me.colTotalPositivo.MinWidth = 15
        Me.colTotalPositivo.Name = "colTotalPositivo"
        Me.colTotalPositivo.OptionsColumn.ReadOnly = True
        Me.colTotalPositivo.Visible = True
        Me.colTotalPositivo.Width = 43
        '
        'gbdNegativos
        '
        Me.gbdNegativos.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdNegativos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdNegativos.Caption = "Valores Negativos"
        Me.gbdNegativos.Columns.Add(Me.colRol)
        Me.gbdNegativos.Columns.Add(Me.colCampana)
        Me.gbdNegativos.Columns.Add(Me.colProyeccion)
        Me.gbdNegativos.Columns.Add(Me.colDeudaEnsamble)
        Me.gbdNegativos.Columns.Add(Me.colTotalNegativo)
        Me.gbdNegativos.MinWidth = 7
        Me.gbdNegativos.Name = "gbdNegativos"
        Me.gbdNegativos.VisibleIndex = 2
        Me.gbdNegativos.Width = 215
        '
        'colRol
        '
        Me.colRol.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRol.AppearanceCell.Options.UseBackColor = True
        Me.colRol.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colRol.AppearanceHeader.Options.UseFont = True
        Me.colRol.AppearanceHeader.Options.UseTextOptions = True
        Me.colRol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRol.FieldName = "Rol"
        Me.colRol.MinWidth = 15
        Me.colRol.Name = "colRol"
        Me.colRol.OptionsColumn.ReadOnly = True
        Me.colRol.Visible = True
        Me.colRol.Width = 43
        '
        'colCampana
        '
        Me.colCampana.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCampana.AppearanceCell.Options.UseBackColor = True
        Me.colCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCampana.AppearanceHeader.Options.UseFont = True
        Me.colCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampana.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCampana.Caption = "Deuda Campañas"
        Me.colCampana.FieldName = "Campana"
        Me.colCampana.MinWidth = 15
        Me.colCampana.Name = "colCampana"
        Me.colCampana.OptionsColumn.ReadOnly = True
        Me.colCampana.Visible = True
        Me.colCampana.Width = 43
        '
        'colProyeccion
        '
        Me.colProyeccion.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colProyeccion.AppearanceCell.Options.UseBackColor = True
        Me.colProyeccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colProyeccion.AppearanceHeader.Options.UseFont = True
        Me.colProyeccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colProyeccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProyeccion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProyeccion.Caption = "Deuda Proyección"
        Me.colProyeccion.FieldName = "Proyeccion"
        Me.colProyeccion.MinWidth = 15
        Me.colProyeccion.Name = "colProyeccion"
        Me.colProyeccion.OptionsColumn.ReadOnly = True
        Me.colProyeccion.Visible = True
        Me.colProyeccion.Width = 43
        '
        'colDeudaEnsamble
        '
        Me.colDeudaEnsamble.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colDeudaEnsamble.AppearanceCell.Options.UseBackColor = True
        Me.colDeudaEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colDeudaEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colDeudaEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeudaEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeudaEnsamble.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeudaEnsamble.FieldName = "DeudaEnsamble"
        Me.colDeudaEnsamble.MinWidth = 15
        Me.colDeudaEnsamble.Name = "colDeudaEnsamble"
        Me.colDeudaEnsamble.OptionsColumn.ReadOnly = True
        Me.colDeudaEnsamble.Visible = True
        Me.colDeudaEnsamble.Width = 43
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
        Me.colTotalNegativo.MinWidth = 15
        Me.colTotalNegativo.Name = "colTotalNegativo"
        Me.colTotalNegativo.OptionsColumn.ReadOnly = True
        Me.colTotalNegativo.Visible = True
        Me.colTotalNegativo.Width = 43
        '
        'gbdResultado
        '
        Me.gbdResultado.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdResultado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdResultado.Caption = "Resultado"
        Me.gbdResultado.Columns.Add(Me.colDisponible)
        Me.gbdResultado.Columns.Add(Me.colSugerido)
        Me.gbdResultado.MinWidth = 7
        Me.gbdResultado.Name = "gbdResultado"
        Me.gbdResultado.VisibleIndex = 3
        Me.gbdResultado.Width = 86
        '
        'colSugerido
        '
        Me.colSugerido.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSugerido.AppearanceCell.Options.UseFont = True
        Me.colSugerido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colSugerido.AppearanceHeader.Options.UseFont = True
        Me.colSugerido.AppearanceHeader.Options.UseTextOptions = True
        Me.colSugerido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSugerido.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSugerido.FieldName = "Sugerido"
        Me.colSugerido.MinWidth = 15
        Me.colSugerido.Name = "colSugerido"
        Me.colSugerido.OptionsColumn.ReadOnly = True
        Me.colSugerido.Visible = True
        Me.colSugerido.Width = 43
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1335, 442)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdAnalisisNecesidades
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1321, 386)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.chkFiltro
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(124, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1197, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnAplicarFiltro
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(124, 40)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1351, 699)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.splitAnalisisNecesidades
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1337, 683)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 5
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1351, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 741)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1351, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 741)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1351, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 741)
        '
        'frmAnalisisNecesidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 741)
        Me.Controls.Add(Me.lycAnalisisNecesidades)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "frmAnalisisNecesidades"
        Me.Text = "frmAnalisisNecesidades"
        CType(Me.lycAnalisisNecesidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAnalisisNecesidades.ResumeLayout(False)
        CType(Me.splitAnalisisNecesidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAnalisisNecesidades.ResumeLayout(False)
        CType(Me.lycAnalisisNecesidades_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAnalisisNecesidades_Filtro.ResumeLayout(False)
        CType(Me.spinDeudaEnsamble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinrdgStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluePlantillas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCampana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinDeudaProyeccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinDeudaCampana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinDeudaRol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMenorA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinStockMayor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoPadreFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoPadreInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueTipoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycrdgStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycAnalisisNecesidades_Resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAnalisisNecesidades_Resultado.ResumeLayout(False)
        CType(Me.grdAnalisisNecesidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnalisisNecesidades1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewAnalisisArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycAnalisisNecesidades As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents splitAnalisisNecesidades As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycAnalisisNecesidades_Filtro As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents slueCodigoPadreFinal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueCodigoPadreInicial As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueCodigoPadre As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueColor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueTipoArticulo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycAnalisisNecesidades_Resultado As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdAnalisisNecesidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinMenorA As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinStockMayor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents slueCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueCampana As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents spinDeudaProyeccion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinDeudaCampana As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinDeudaRol As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcAnalisisNecesidades As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents sluePlantillas As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barAnalisisNecesidad As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnPlantillaEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnPlantillaActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnPlantillaGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DsAnalisisNecesidades1 As waProduccion_Pedidos.dsAnalisisNecesidades
    Friend WithEvents grdviewAnalisisArticulos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gbdDatosArticulo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbdPositivos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProduccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEnsamble As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalPositivo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbdNegativos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colRol As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCampana As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProyeccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeudaEnsamble As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalNegativo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbdResultado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDisponible As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSugerido As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents spinrdgStock As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents rdgStock As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycrdgStock As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents spinDeudaEnsamble As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaRol As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaCampana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaProyeccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnContinuar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkFiltro As DevExpress.XtraEditors.CheckButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAplicarFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnFichaArticulo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAnalisisVentas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
