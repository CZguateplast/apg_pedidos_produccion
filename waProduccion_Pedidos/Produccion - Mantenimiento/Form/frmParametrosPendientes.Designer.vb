<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametrosPendientes))
        Me.lycParametrosPendientes = New DevExpress.XtraLayout.LayoutControl()
        Me.grdParametrosPendientes = New DevExpress.XtraGrid.GridControl()
        Me.DsParametrosPendientes1 = New waProduccion_Pedidos.dsParametrosPendientes()
        Me.bgvParametrosPendientes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gb1Codigo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gb2Materiales = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colMaterial1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaterial1Porc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaterial2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaterial2Porc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaterial3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gb3Molde = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colMolde = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCavidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaquinaPreferencial = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gb4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colInyeccionGrms = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInyeccionHora = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInyeccionVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycParametrosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametrosPendientes.SuspendLayout()
        CType(Me.grdParametrosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametrosPendientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgvParametrosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametrosPendientes
        '
        Me.lycParametrosPendientes.Controls.Add(Me.grdParametrosPendientes)
        Me.lycParametrosPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametrosPendientes.Location = New System.Drawing.Point(0, 29)
        Me.lycParametrosPendientes.Name = "lycParametrosPendientes"
        Me.lycParametrosPendientes.Root = Me.LayoutControlGroup1
        Me.lycParametrosPendientes.Size = New System.Drawing.Size(1213, 597)
        Me.lycParametrosPendientes.TabIndex = 0
        Me.lycParametrosPendientes.Text = "LayoutControl1"
        '
        'grdParametrosPendientes
        '
        Me.grdParametrosPendientes.DataMember = "dsdtParametrosPendientes"
        Me.grdParametrosPendientes.DataSource = Me.DsParametrosPendientes1
        Me.grdParametrosPendientes.Location = New System.Drawing.Point(12, 12)
        Me.grdParametrosPendientes.MainView = Me.bgvParametrosPendientes
        Me.grdParametrosPendientes.MenuManager = Me.BarManager1
        Me.grdParametrosPendientes.Name = "grdParametrosPendientes"
        Me.grdParametrosPendientes.Size = New System.Drawing.Size(1189, 573)
        Me.grdParametrosPendientes.TabIndex = 4
        Me.grdParametrosPendientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bgvParametrosPendientes})
        '
        'DsParametrosPendientes1
        '
        Me.DsParametrosPendientes1.DataSetName = "dsParametrosPendientes"
        Me.DsParametrosPendientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bgvParametrosPendientes
        '
        Me.bgvParametrosPendientes.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bgvParametrosPendientes.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.BandPanel.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.BandPanel.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.BandPanel.Options.UseFont = True
        Me.bgvParametrosPendientes.Appearance.BandPanel.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.Empty.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.bgvParametrosPendientes.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.bgvParametrosPendientes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FixedLine.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.Teal
        Me.bgvParametrosPendientes.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.GroupButton.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.GroupButton.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.bgvParametrosPendientes.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bgvParametrosPendientes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.bgvParametrosPendientes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.GroupPanel.Options.UseFont = True
        Me.bgvParametrosPendientes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.GroupRow.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.GroupRow.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.Options.UseFont = True
        Me.bgvParametrosPendientes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.bgvParametrosPendientes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.HorzLine.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.bgvParametrosPendientes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.Preview.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.Preview.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.bgvParametrosPendientes.Appearance.Row.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.Row.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.bgvParametrosPendientes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.bgvParametrosPendientes.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.bgvParametrosPendientes.Appearance.VertLine.Options.UseBackColor = True
        Me.bgvParametrosPendientes.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gb1Codigo, Me.gb2Materiales, Me.gb3Molde, Me.gb4})
        Me.bgvParametrosPendientes.ColumnPanelRowHeight = 35
        Me.bgvParametrosPendientes.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colNombre, Me.colEstatus, Me.colMaterial1, Me.colMaterial1Porc, Me.colMaterial2, Me.colMaterial2Porc, Me.colMaterial3, Me.colMolde, Me.colCavidades, Me.colUnidades, Me.colMaquinaPreferencial, Me.colInyeccionGrms, Me.colInyeccionHora, Me.colInyeccionVariacion})
        Me.bgvParametrosPendientes.GridControl = Me.grdParametrosPendientes
        Me.bgvParametrosPendientes.Name = "bgvParametrosPendientes"
        Me.bgvParametrosPendientes.OptionsBehavior.Editable = False
        Me.bgvParametrosPendientes.OptionsBehavior.ReadOnly = True
        Me.bgvParametrosPendientes.OptionsView.ColumnAutoWidth = False
        Me.bgvParametrosPendientes.OptionsView.ShowFooter = True
        Me.bgvParametrosPendientes.OptionsView.ShowGroupPanel = False
        Me.bgvParametrosPendientes.PaintStyleName = "MixedXP"
        '
        'gb1Codigo
        '
        Me.gb1Codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.gb1Codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gb1Codigo.Caption = "Codigo"
        Me.gb1Codigo.Columns.Add(Me.colCodigo)
        Me.gb1Codigo.Columns.Add(Me.colNombre)
        Me.gb1Codigo.Columns.Add(Me.colEstatus)
        Me.gb1Codigo.Name = "gb1Codigo"
        Me.gb1Codigo.VisibleIndex = 0
        Me.gb1Codigo.Width = 390
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 90
        '
        'colNombre
        '
        Me.colNombre.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colNombre.AppearanceCell.Options.UseBackColor = True
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.Width = 250
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colEstatus.AppearanceCell.Options.UseBackColor = True
        Me.colEstatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus.AppearanceHeader.Options.UseFont = True
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEstatus.Caption = "Activo"
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.Width = 50
        '
        'gb2Materiales
        '
        Me.gb2Materiales.AppearanceHeader.Options.UseTextOptions = True
        Me.gb2Materiales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gb2Materiales.Caption = "Materiales"
        Me.gb2Materiales.Columns.Add(Me.colMaterial1)
        Me.gb2Materiales.Columns.Add(Me.colMaterial1Porc)
        Me.gb2Materiales.Columns.Add(Me.colMaterial2)
        Me.gb2Materiales.Columns.Add(Me.colMaterial2Porc)
        Me.gb2Materiales.Columns.Add(Me.colMaterial3)
        Me.gb2Materiales.Name = "gb2Materiales"
        Me.gb2Materiales.VisibleIndex = 1
        Me.gb2Materiales.Width = 300
        '
        'colMaterial1
        '
        Me.colMaterial1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaterial1.Caption = "Material 1"
        Me.colMaterial1.FieldName = "Material1"
        Me.colMaterial1.Name = "colMaterial1"
        Me.colMaterial1.Visible = True
        Me.colMaterial1.Width = 60
        '
        'colMaterial1Porc
        '
        Me.colMaterial1Porc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1Porc.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1Porc.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial1Porc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1Porc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaterial1Porc.Caption = "% Material 1"
        Me.colMaterial1Porc.FieldName = "Material1Porc"
        Me.colMaterial1Porc.Name = "colMaterial1Porc"
        Me.colMaterial1Porc.Visible = True
        Me.colMaterial1Porc.Width = 60
        '
        'colMaterial2
        '
        Me.colMaterial2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial2.AppearanceHeader.Options.UseFont = True
        Me.colMaterial2.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaterial2.Caption = "Material 2"
        Me.colMaterial2.FieldName = "Material2"
        Me.colMaterial2.Name = "colMaterial2"
        Me.colMaterial2.Visible = True
        Me.colMaterial2.Width = 60
        '
        'colMaterial2Porc
        '
        Me.colMaterial2Porc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial2Porc.AppearanceHeader.Options.UseFont = True
        Me.colMaterial2Porc.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial2Porc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial2Porc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaterial2Porc.Caption = "% Material 2"
        Me.colMaterial2Porc.FieldName = "Material2Porc"
        Me.colMaterial2Porc.Name = "colMaterial2Porc"
        Me.colMaterial2Porc.Visible = True
        Me.colMaterial2Porc.Width = 60
        '
        'colMaterial3
        '
        Me.colMaterial3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial3.AppearanceHeader.Options.UseFont = True
        Me.colMaterial3.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaterial3.Caption = "Material 3"
        Me.colMaterial3.FieldName = "Material3"
        Me.colMaterial3.Name = "colMaterial3"
        Me.colMaterial3.Visible = True
        Me.colMaterial3.Width = 60
        '
        'gb3Molde
        '
        Me.gb3Molde.AppearanceHeader.Options.UseTextOptions = True
        Me.gb3Molde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gb3Molde.Caption = "Molde"
        Me.gb3Molde.Columns.Add(Me.colMolde)
        Me.gb3Molde.Columns.Add(Me.colCavidades)
        Me.gb3Molde.Columns.Add(Me.colUnidades)
        Me.gb3Molde.Columns.Add(Me.colMaquinaPreferencial)
        Me.gb3Molde.Name = "gb3Molde"
        Me.gb3Molde.VisibleIndex = 2
        Me.gb3Molde.Width = 250
        '
        'colMolde
        '
        Me.colMolde.AppearanceCell.BackColor = System.Drawing.Color.Tan
        Me.colMolde.AppearanceCell.Options.UseBackColor = True
        Me.colMolde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMolde.AppearanceHeader.Options.UseFont = True
        Me.colMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMolde.FieldName = "Molde"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Visible = True
        Me.colMolde.Width = 60
        '
        'colCavidades
        '
        Me.colCavidades.AppearanceCell.BackColor = System.Drawing.Color.Tan
        Me.colCavidades.AppearanceCell.Options.UseBackColor = True
        Me.colCavidades.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCavidades.AppearanceHeader.Options.UseFont = True
        Me.colCavidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colCavidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidades.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCavidades.FieldName = "Cavidades"
        Me.colCavidades.Name = "colCavidades"
        Me.colCavidades.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cavidades", "{0}")})
        Me.colCavidades.Visible = True
        Me.colCavidades.Width = 70
        '
        'colUnidades
        '
        Me.colUnidades.AppearanceCell.BackColor = System.Drawing.Color.Tan
        Me.colUnidades.AppearanceCell.Options.UseBackColor = True
        Me.colUnidades.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidades.AppearanceHeader.Options.UseFont = True
        Me.colUnidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidades.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.Width = 60
        '
        'colMaquinaPreferencial
        '
        Me.colMaquinaPreferencial.AppearanceCell.BackColor = System.Drawing.Color.Tan
        Me.colMaquinaPreferencial.AppearanceCell.Options.UseBackColor = True
        Me.colMaquinaPreferencial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquinaPreferencial.AppearanceHeader.Options.UseFont = True
        Me.colMaquinaPreferencial.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquinaPreferencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquinaPreferencial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaquinaPreferencial.Caption = "Maquina Pref"
        Me.colMaquinaPreferencial.FieldName = "MaquinaPreferencial"
        Me.colMaquinaPreferencial.Name = "colMaquinaPreferencial"
        Me.colMaquinaPreferencial.Visible = True
        Me.colMaquinaPreferencial.Width = 60
        '
        'gb4
        '
        Me.gb4.AppearanceHeader.Options.UseTextOptions = True
        Me.gb4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gb4.Caption = "Producción"
        Me.gb4.Columns.Add(Me.colInyeccionGrms)
        Me.gb4.Columns.Add(Me.colInyeccionHora)
        Me.gb4.Columns.Add(Me.colInyeccionVariacion)
        Me.gb4.Name = "gb4"
        Me.gb4.VisibleIndex = 3
        Me.gb4.Width = 225
        '
        'colInyeccionGrms
        '
        Me.colInyeccionGrms.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionGrms.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionGrms.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionGrms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionGrms.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionGrms.FieldName = "InyeccionGrms"
        Me.colInyeccionGrms.Name = "colInyeccionGrms"
        Me.colInyeccionGrms.Visible = True
        '
        'colInyeccionHora
        '
        Me.colInyeccionHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionHora.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionHora.FieldName = "InyeccionHora"
        Me.colInyeccionHora.Name = "colInyeccionHora"
        Me.colInyeccionHora.Visible = True
        '
        'colInyeccionVariacion
        '
        Me.colInyeccionVariacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionVariacion.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionVariacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionVariacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionVariacion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionVariacion.FieldName = "InyeccionVariacion"
        Me.colInyeccionVariacion.Name = "colInyeccionVariacion"
        Me.colInyeccionVariacion.Visible = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnExportarXlsx, Me.barbtnBuscar, Me.barbtnImprimirGrid})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 2
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 3
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1213, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 626)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1213, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 597)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1213, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 597)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1213, 597)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdParametrosPendientes
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1193, 577)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmParametrosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 669)
        Me.Controls.Add(Me.lycParametrosPendientes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmParametrosPendientes"
        Me.Text = "frmParametrosPendientes"
        CType(Me.lycParametrosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametrosPendientes.ResumeLayout(False)
        CType(Me.grdParametrosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametrosPendientes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgvParametrosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametrosPendientes As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdParametrosPendientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsParametrosPendientes1 As waProduccion_Pedidos.dsParametrosPendientes
    Friend WithEvents bgvParametrosPendientes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gb1Codigo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gb2Materiales As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaterial1Porc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaterial2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaterial2Porc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaterial3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gb3Molde As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colMolde As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCavidades As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaquinaPreferencial As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gb4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colInyeccionGrms As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInyeccionHora As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInyeccionVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
End Class
