<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_ListaMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_ListaMateriales))
        Me.lycListaMateriales = New DevExpress.XtraLayout.LayoutControl()
        Me.txtAlmacen = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barListaMateriales = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.slueListaPrecios = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.spinCantidad = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.grdListaMateriales = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_ListaMateriales1 = New waProduccion_Pedidos.dsTemporal_ListaMateriales()
        Me.grdviewListaMateriales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colListaPrecios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueListaPrecios = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaMateriales.SuspendLayout()
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueListaPrecios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_ListaMateriales1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycListaMateriales
        '
        Me.lycListaMateriales.Controls.Add(Me.txtAlmacen)
        Me.lycListaMateriales.Controls.Add(Me.slueListaPrecios)
        Me.lycListaMateriales.Controls.Add(Me.spinCantidad)
        Me.lycListaMateriales.Controls.Add(Me.txtNombre)
        Me.lycListaMateriales.Controls.Add(Me.txtCodigo)
        Me.lycListaMateriales.Controls.Add(Me.grdListaMateriales)
        Me.lycListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListaMateriales.Location = New System.Drawing.Point(0, 29)
        Me.lycListaMateriales.Name = "lycListaMateriales"
        Me.lycListaMateriales.Root = Me.LayoutControlGroup1
        Me.lycListaMateriales.Size = New System.Drawing.Size(917, 553)
        Me.lycListaMateriales.TabIndex = 0
        Me.lycListaMateriales.Text = "LayoutControl1"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.Enabled = False
        Me.txtAlmacen.Location = New System.Drawing.Point(535, 12)
        Me.txtAlmacen.MenuManager = Me.BarManager1
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAlmacen.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlmacen.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAlmacen.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAlmacen.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtAlmacen.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtAlmacen.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtAlmacen.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtAlmacen.Size = New System.Drawing.Size(370, 20)
        Me.txtAlmacen.StyleController = Me.lycListaMateriales
        Me.txtAlmacen.TabIndex = 10
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barListaMateriales, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barListaMateriales
        '
        Me.barListaMateriales.BarName = "Tools"
        Me.barListaMateriales.DockCol = 0
        Me.barListaMateriales.DockRow = 0
        Me.barListaMateriales.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barListaMateriales.OptionsBar.AllowQuickCustomization = False
        Me.barListaMateriales.OptionsBar.DisableClose = True
        Me.barListaMateriales.OptionsBar.DrawBorder = False
        Me.barListaMateriales.OptionsBar.DrawDragBorder = False
        Me.barListaMateriales.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(917, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 582)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(917, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 553)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(917, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 553)
        '
        'slueListaPrecios
        '
        Me.slueListaPrecios.Enabled = False
        Me.slueListaPrecios.Location = New System.Drawing.Point(535, 36)
        Me.slueListaPrecios.MenuManager = Me.BarManager1
        Me.slueListaPrecios.Name = "slueListaPrecios"
        Me.slueListaPrecios.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.slueListaPrecios.Properties.Appearance.Options.UseBackColor = True
        Me.slueListaPrecios.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.slueListaPrecios.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.slueListaPrecios.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueListaPrecios.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.slueListaPrecios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueListaPrecios.Properties.NullText = ""
        Me.slueListaPrecios.Properties.View = Me.SearchLookUpEdit2View
        Me.slueListaPrecios.Size = New System.Drawing.Size(370, 20)
        Me.slueListaPrecios.StyleController = Me.lycListaMateriales
        Me.slueListaPrecios.TabIndex = 9
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'spinCantidad
        '
        Me.spinCantidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinCantidad.Enabled = False
        Me.spinCantidad.Location = New System.Drawing.Point(295, 12)
        Me.spinCantidad.MaximumSize = New System.Drawing.Size(100, 0)
        Me.spinCantidad.MenuManager = Me.BarManager1
        Me.spinCantidad.MinimumSize = New System.Drawing.Size(100, 0)
        Me.spinCantidad.Name = "spinCantidad"
        Me.spinCantidad.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.spinCantidad.Properties.Appearance.Options.UseBackColor = True
        Me.spinCantidad.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinCantidad.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinCantidad.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinCantidad.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinCantidad.Size = New System.Drawing.Size(100, 20)
        Me.spinCantidad.StyleController = Me.lycListaMateriales
        Me.spinCantidad.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(89, 36)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombre.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombre.Size = New System.Drawing.Size(306, 20)
        Me.txtNombre.StyleController = Me.lycListaMateriales
        Me.txtNombre.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(89, 12)
        Me.txtCodigo.MaximumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.MinimumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCodigo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodigo.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigo.StyleController = Me.lycListaMateriales
        Me.txtCodigo.TabIndex = 5
        '
        'grdListaMateriales
        '
        Me.grdListaMateriales.DataMember = "dsdtListaMateriales_Detalle"
        Me.grdListaMateriales.DataSource = Me.DsTemporal_ListaMateriales1
        Me.grdListaMateriales.Location = New System.Drawing.Point(12, 60)
        Me.grdListaMateriales.MainView = Me.grdviewListaMateriales
        Me.grdListaMateriales.MenuManager = Me.BarManager1
        Me.grdListaMateriales.Name = "grdListaMateriales"
        Me.grdListaMateriales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueListaPrecios})
        Me.grdListaMateriales.Size = New System.Drawing.Size(893, 481)
        Me.grdListaMateriales.TabIndex = 4
        Me.grdListaMateriales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaMateriales})
        '
        'DsTemporal_ListaMateriales1
        '
        Me.DsTemporal_ListaMateriales1.DataSetName = "dsTemporal_ListaMateriales"
        Me.DsTemporal_ListaMateriales1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaMateriales
        '
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Empty.BackColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewListaMateriales.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray
        Me.grdviewListaMateriales.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.grdviewListaMateriales.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver
        Me.grdviewListaMateriales.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver
        Me.grdviewListaMateriales.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewListaMateriales.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewListaMateriales.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray
        Me.grdviewListaMateriales.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewListaMateriales.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.ColumnPanelRowHeight = 35
        Me.grdviewListaMateriales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLinea, Me.colCodigo, Me.colNombre, Me.colCantidad, Me.GridColumn1, Me.colAlmacen, Me.colListaPrecios})
        Me.grdviewListaMateriales.GridControl = Me.grdListaMateriales
        Me.grdviewListaMateriales.Name = "grdviewListaMateriales"
        Me.grdviewListaMateriales.OptionsBehavior.Editable = False
        Me.grdviewListaMateriales.OptionsBehavior.ReadOnly = True
        Me.grdviewListaMateriales.OptionsFind.AlwaysVisible = True
        Me.grdviewListaMateriales.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaMateriales.OptionsView.ShowFooter = True
        Me.grdviewListaMateriales.OptionsView.ShowGroupPanel = False
        Me.grdviewListaMateriales.PaintStyleName = "Web"
        '
        'colLinea
        '
        Me.colLinea.FieldName = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.Visible = True
        Me.colLinea.VisibleIndex = 0
        Me.colLinea.Width = 47
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 100
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 300
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "U/M"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 60
        '
        'colAlmacen
        '
        Me.colAlmacen.FieldName = "Almacen"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.Visible = True
        Me.colAlmacen.VisibleIndex = 5
        Me.colAlmacen.Width = 80
        '
        'colListaPrecios
        '
        Me.colListaPrecios.ColumnEdit = Me.rslueListaPrecios
        Me.colListaPrecios.FieldName = "ListaPrecios"
        Me.colListaPrecios.Name = "colListaPrecios"
        Me.colListaPrecios.Visible = True
        Me.colListaPrecios.VisibleIndex = 6
        Me.colListaPrecios.Width = 200
        '
        'rslueListaPrecios
        '
        Me.rslueListaPrecios.AutoHeight = False
        Me.rslueListaPrecios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueListaPrecios.Name = "rslueListaPrecios"
        Me.rslueListaPrecios.NullText = ""
        Me.rslueListaPrecios.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(917, 553)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdListaMateriales
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(897, 485)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCodigo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem2.Text = "Producto"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.slueListaPrecios
        Me.LayoutControlItem6.Location = New System.Drawing.Point(446, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(451, 24)
        Me.LayoutControlItem6.Text = "Lista de precios"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNombre
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(387, 24)
        Me.LayoutControlItem3.Text = "Nombre"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spinCantidad
        Me.LayoutControlItem4.Location = New System.Drawing.Point(206, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(181, 24)
        Me.LayoutControlItem4.Text = "Cantidad"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(387, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(59, 48)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtAlmacen
        Me.LayoutControlItem5.Location = New System.Drawing.Point(446, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(451, 24)
        Me.LayoutControlItem5.Text = "Almacen"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(74, 13)
        '
        'frmTemporal_ListaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycListaMateriales)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTemporal_ListaMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA DE MATERIALES"
        CType(Me.lycListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaMateriales.ResumeLayout(False)
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueListaPrecios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_ListaMateriales1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycListaMateriales As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barListaMateriales As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents slueListaPrecios As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents spinCantidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdListaMateriales As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaMateriales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtAlmacen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_ListaMateriales1 As waProduccion_Pedidos.dsTemporal_ListaMateriales
    Friend WithEvents colLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colListaPrecios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueListaPrecios As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
