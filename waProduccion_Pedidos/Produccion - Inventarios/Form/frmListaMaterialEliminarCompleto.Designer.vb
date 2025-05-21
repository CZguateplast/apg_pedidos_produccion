<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaMaterialEliminarCompleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaMaterialEliminarCompleto))
        Me.splashEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.waitDetalle), true, true, true)
        Me.lycListaMaterial = New DevExpress.XtraLayout.LayoutControl()
        Me.grdListaMateriales = New DevExpress.XtraGrid.GridControl()
        Me.DsListaMaterialEliminarCompleto1 = New waProduccion_Pedidos.dsListaMaterialEliminarCompleto()
        Me.grdviewListaMateriales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAbrirExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAplicar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.barbtnDescargarPlantilla = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.lycListaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaMaterial.SuspendLayout()
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaMaterialEliminarCompleto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splashEsperar
        '
        Me.splashEsperar.ClosingDelay = 500
        '
        'lycListaMaterial
        '
        Me.lycListaMaterial.Controls.Add(Me.grdListaMateriales)
        Me.lycListaMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListaMaterial.Location = New System.Drawing.Point(0, 44)
        Me.lycListaMaterial.Name = "lycListaMaterial"
        Me.lycListaMaterial.Root = Me.LayoutControlGroup1
        Me.lycListaMaterial.Size = New System.Drawing.Size(256, 437)
        Me.lycListaMaterial.TabIndex = 0
        Me.lycListaMaterial.Text = "LayoutControl1"
        '
        'grdListaMateriales
        '
        Me.grdListaMateriales.DataMember = "dsdtListaMaterialEliminarCompleto"
        Me.grdListaMateriales.DataSource = Me.DsListaMaterialEliminarCompleto1
        Me.grdListaMateriales.Location = New System.Drawing.Point(12, 12)
        Me.grdListaMateriales.MainView = Me.grdviewListaMateriales
        Me.grdListaMateriales.MenuManager = Me.BarManager1
        Me.grdListaMateriales.Name = "grdListaMateriales"
        Me.grdListaMateriales.Size = New System.Drawing.Size(232, 413)
        Me.grdListaMateriales.TabIndex = 4
        Me.grdListaMateriales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaMateriales})
        '
        'DsListaMaterialEliminarCompleto1
        '
        Me.DsListaMaterialEliminarCompleto1.DataSetName = "dsListaMaterialEliminarCompleto"
        Me.DsListaMaterialEliminarCompleto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaMateriales
        '
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaMateriales.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo})
        Me.grdviewListaMateriales.GridControl = Me.grdListaMateriales
        Me.grdviewListaMateriales.Name = "grdviewListaMateriales"
        Me.grdviewListaMateriales.NewItemRowText = "Ingresar Codigo Articulo"
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaMateriales.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewListaMateriales.OptionsView.ShowFooter = True
        Me.grdviewListaMateriales.OptionsView.ShowGroupPanel = False
        Me.grdviewListaMateriales.PaintStyleName = "Web"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodigoArticulo", "{0} Codigos")})
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnAplicar, Me.barbtnAbrirExcel, Me.barbtnDescargarPlantilla})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAbrirExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDescargarPlantilla, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnAbrirExcel
        '
        Me.barbtnAbrirExcel.Caption = "Abrir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnAbrirExcel.Id = 2
        Me.barbtnAbrirExcel.ImageOptions.Image = CType(resources.GetObject("barbtnAbrirExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAbrirExcel.Name = "barbtnAbrirExcel"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAplicar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnAplicar
        '
        Me.barbtnAplicar.Caption = "Aplicar"
        Me.barbtnAplicar.Id = 1
        Me.barbtnAplicar.ImageOptions.Image = CType(resources.GetObject("barbtnAplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAplicar.Name = "barbtnAplicar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(256, 44)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 481)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(256, 44)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 44)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 437)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(256, 44)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 437)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(256, 437)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdListaMateriales
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(236, 417)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'ofdAbrir
        '
        Me.ofdAbrir.FileName = "OpenFileDialog1"
        '
        'barbtnDescargarPlantilla
        '
        Me.barbtnDescargarPlantilla.Caption = "Descargar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plantilla"
        Me.barbtnDescargarPlantilla.Id = 3
        Me.barbtnDescargarPlantilla.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDescargarPlantilla.Name = "barbtnDescargarPlantilla"
        '
        'frmListaMaterialEliminarCompleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 525)
        Me.Controls.Add(Me.lycListaMaterial)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaMaterialEliminarCompleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrar Lista Materiales"
        CType(Me.lycListaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaMaterial.ResumeLayout(False)
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaMaterialEliminarCompleto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycListaMaterial As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdListaMateriales As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaMateriales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsListaMaterialEliminarCompleto1 As waProduccion_Pedidos.dsListaMaterialEliminarCompleto
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnAbrirExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAplicar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents splashEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents barbtnDescargarPlantilla As DevExpress.XtraBars.BarButtonItem
End Class
