<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_ColorDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_ColorDetalle))
        Me.lycTemporal_Color = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.grdColores = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_ColorDetalle1 = New waProduccion_Pedidos.dsTemporal_ColorDetalle()
        Me.grdviewColores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtColorNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.picColor = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycTemporal_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_Color.SuspendLayout()
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_ColorDetalle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColorNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal_Color
        '
        Me.lycTemporal_Color.Controls.Add(Me.picColor)
        Me.lycTemporal_Color.Controls.Add(Me.txtColorNombre)
        Me.lycTemporal_Color.Controls.Add(Me.lblTitulo)
        Me.lycTemporal_Color.Controls.Add(Me.grdColores)
        Me.lycTemporal_Color.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_Color.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_Color.Name = "lycTemporal_Color"
        Me.lycTemporal_Color.Root = Me.LayoutControlGroup1
        Me.lycTemporal_Color.Size = New System.Drawing.Size(675, 552)
        Me.lycTemporal_Color.TabIndex = 0
        Me.lycTemporal_Color.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(252, 29)
        Me.lblTitulo.StyleController = Me.lycTemporal_Color
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "DETALLE DEL COLOR"
        '
        'grdColores
        '
        Me.grdColores.DataMember = "dsdtColorDetalle"
        Me.grdColores.DataSource = Me.DsTemporal_ColorDetalle1
        Me.grdColores.Location = New System.Drawing.Point(12, 90)
        Me.grdColores.MainView = Me.grdviewColores
        Me.grdColores.MenuManager = Me.BarManager1
        Me.grdColores.Name = "grdColores"
        Me.grdColores.Size = New System.Drawing.Size(651, 450)
        Me.grdColores.TabIndex = 4
        Me.grdColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewColores})
        '
        'DsTemporal_ColorDetalle1
        '
        Me.DsTemporal_ColorDetalle1.DataSetName = "dsTemporal_ColorDetalle"
        Me.DsTemporal_ColorDetalle1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewColores
        '
        Me.grdviewColores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewColores.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewColores.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewColores.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewColores.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewColores.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewColores.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewColores.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Preview.Options.UseFont = True
        Me.grdviewColores.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewColores.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.Row.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Row.Options.UseForeColor = True
        Me.grdviewColores.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewColores.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewColores.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewColores.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewColores.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewColores.ColumnPanelRowHeight = 35
        Me.grdviewColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColor, Me.colCodigo, Me.colNombre, Me.colDeLinea, Me.colStock})
        Me.grdviewColores.GridControl = Me.grdColores
        Me.grdviewColores.Name = "grdviewColores"
        Me.grdviewColores.OptionsView.ColumnAutoWidth = False
        Me.grdviewColores.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewColores.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewColores.OptionsView.ShowFooter = True
        Me.grdviewColores.OptionsView.ShowGroupPanel = False
        Me.grdviewColores.PaintStyleName = "Web"
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 0
        Me.colColor.Width = 50
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 105
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 325
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceCell.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.ReadOnly = True
        Me.colDeLinea.Visible = True
        Me.colDeLinea.VisibleIndex = 3
        Me.colDeLinea.Width = 65
        '
        'colStock
        '
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.ReadOnly = True
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 4
        Me.colStock.Width = 70
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnBuscar, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnExportarXlsx), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(675, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 552)
        Me.barDockControlBottom.Size = New System.Drawing.Size(675, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 552)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(675, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 552)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(675, 552)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdColores
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(655, 454)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lblTitulo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(655, 33)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'txtColorNombre
        '
        Me.txtColorNombre.Location = New System.Drawing.Point(108, 45)
        Me.txtColorNombre.MenuManager = Me.BarManager1
        Me.txtColorNombre.Name = "txtColorNombre"
        Me.txtColorNombre.Properties.ReadOnly = True
        Me.txtColorNombre.Size = New System.Drawing.Size(413, 20)
        Me.txtColorNombre.StyleController = Me.lycTemporal_Color
        Me.txtColorNombre.TabIndex = 6
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.txtColorNombre
        Me.LayoutControlItem3.CustomizationFormText = "Nombre de Color"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(513, 24)
        Me.LayoutControlItem3.Text = "Nombre de Color"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
        '
        'picColor
        '
        Me.picColor.Location = New System.Drawing.Point(525, 45)
        Me.picColor.MenuManager = Me.BarManager1
        Me.picColor.Name = "picColor"
        Me.picColor.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picColor.Size = New System.Drawing.Size(138, 41)
        Me.picColor.StyleController = Me.lycTemporal_Color
        Me.picColor.TabIndex = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.picColor
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(513, 33)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(142, 45)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 57)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(513, 21)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Glyph = CType(resources.GetObject("barbtnBuscar.Glyph"), System.Drawing.Image)
        Me.barbtnBuscar.Id = 1
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir"
        Me.barbtnImprimirGrid.Glyph = CType(resources.GetObject("barbtnImprimirGrid.Glyph"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Id = 2
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Caption = "Exportar Excel"
        Me.barbtnExportarXlsx.Glyph = CType(resources.GetObject("barbtnExportarXlsx.Glyph"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Id = 3
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'frmTemporal_ColorDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 595)
        Me.Controls.Add(Me.lycTemporal_Color)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_ColorDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_ColorDetalle"
        CType(Me.lycTemporal_Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_Color.ResumeLayout(False)
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_ColorDetalle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColorNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lycTemporal_Color As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTemporal_ColorDetalle1 As waProduccion_Pedidos.dsTemporal_ColorDetalle
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents picColor As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtColorNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
End Class
