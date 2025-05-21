<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaquinasPorcentajeEficiencia_LOG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaquinasPorcentajeEficiencia_LOG))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdPorcEficienciaMaquinas = New DevExpress.XtraGrid.GridControl()
        Me.DsPorcEficienciaMaquinas1 = New waProduccion_Pedidos.dsPorcEficienciaMaquinas()
        Me.grdviewPorcEficienciaMaquinas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdteFecha = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colPorcentaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.rdteBit_CreacionFecha = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdPorcEficienciaMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPorcEficienciaMaquinas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewPorcEficienciaMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteBit_CreacionFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteBit_CreacionFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdPorcEficienciaMaquinas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(469, 510)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdPorcEficienciaMaquinas
        '
        Me.grdPorcEficienciaMaquinas.DataMember = "dsdtPorcEficienciaMaquinas_LOG"
        Me.grdPorcEficienciaMaquinas.DataSource = Me.DsPorcEficienciaMaquinas1
        Me.grdPorcEficienciaMaquinas.Location = New System.Drawing.Point(12, 12)
        Me.grdPorcEficienciaMaquinas.MainView = Me.grdviewPorcEficienciaMaquinas
        Me.grdPorcEficienciaMaquinas.Name = "grdPorcEficienciaMaquinas"
        Me.grdPorcEficienciaMaquinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rdteFecha, Me.rspinPorcentaje, Me.rdteBit_CreacionFecha})
        Me.grdPorcEficienciaMaquinas.Size = New System.Drawing.Size(445, 486)
        Me.grdPorcEficienciaMaquinas.TabIndex = 4
        Me.grdPorcEficienciaMaquinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewPorcEficienciaMaquinas})
        '
        'DsPorcEficienciaMaquinas1
        '
        Me.DsPorcEficienciaMaquinas1.DataSetName = "dsPorcEficienciaMaquinas"
        Me.DsPorcEficienciaMaquinas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewPorcEficienciaMaquinas
        '
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewPorcEficienciaMaquinas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewPorcEficienciaMaquinas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPorcEficienciaMaquinas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewPorcEficienciaMaquinas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewPorcEficienciaMaquinas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewPorcEficienciaMaquinas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPorcEficienciaMaquinas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewPorcEficienciaMaquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewPorcEficienciaMaquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewPorcEficienciaMaquinas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.Preview.Options.UseFont = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewPorcEficienciaMaquinas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewPorcEficienciaMaquinas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewPorcEficienciaMaquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewPorcEficienciaMaquinas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colPorcentaje, Me.colBit_CreacionFecha, Me.colBit_CreacionUsuario})
        Me.grdviewPorcEficienciaMaquinas.GridControl = Me.grdPorcEficienciaMaquinas
        Me.grdviewPorcEficienciaMaquinas.Name = "grdviewPorcEficienciaMaquinas"
        Me.grdviewPorcEficienciaMaquinas.OptionsBehavior.Editable = False
        Me.grdviewPorcEficienciaMaquinas.OptionsBehavior.ReadOnly = True
        Me.grdviewPorcEficienciaMaquinas.OptionsView.ColumnAutoWidth = False
        Me.grdviewPorcEficienciaMaquinas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewPorcEficienciaMaquinas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewPorcEficienciaMaquinas.OptionsView.ShowGroupPanel = False
        Me.grdviewPorcEficienciaMaquinas.PaintStyleName = "Web"
        '
        'colFecha
        '
        Me.colFecha.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha.AppearanceCell.Options.UseFont = True
        Me.colFecha.AppearanceCell.Options.UseTextOptions = True
        Me.colFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.ColumnEdit = Me.rdteFecha
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 95
        '
        'rdteFecha
        '
        Me.rdteFecha.AutoHeight = False
        Me.rdteFecha.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFecha.Name = "rdteFecha"
        '
        'colPorcentaje
        '
        Me.colPorcentaje.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPorcentaje.AppearanceCell.Options.UseFont = True
        Me.colPorcentaje.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPorcentaje.AppearanceHeader.Options.UseFont = True
        Me.colPorcentaje.AppearanceHeader.Options.UseTextOptions = True
        Me.colPorcentaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPorcentaje.ColumnEdit = Me.rspinPorcentaje
        Me.colPorcentaje.FieldName = "Porcentaje"
        Me.colPorcentaje.Name = "colPorcentaje"
        Me.colPorcentaje.Visible = True
        Me.colPorcentaje.VisibleIndex = 1
        Me.colPorcentaje.Width = 84
        '
        'rspinPorcentaje
        '
        Me.rspinPorcentaje.AutoHeight = False
        Me.rspinPorcentaje.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPorcentaje.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.rspinPorcentaje.Name = "rspinPorcentaje"
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.AppearanceCell.Options.UseTextOptions = True
        Me.colBit_CreacionFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionFecha.Caption = "Creacion Fecha"
        Me.colBit_CreacionFecha.ColumnEdit = Me.rdteBit_CreacionFecha
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        Me.colBit_CreacionFecha.OptionsColumn.AllowEdit = False
        Me.colBit_CreacionFecha.OptionsColumn.AllowFocus = False
        Me.colBit_CreacionFecha.OptionsColumn.AllowMove = False
        Me.colBit_CreacionFecha.Visible = True
        Me.colBit_CreacionFecha.VisibleIndex = 3
        Me.colBit_CreacionFecha.Width = 125
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.AppearanceCell.Options.UseTextOptions = True
        Me.colBit_CreacionUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionUsuario.Caption = "Creacion Usuario"
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        Me.colBit_CreacionUsuario.OptionsColumn.AllowEdit = False
        Me.colBit_CreacionUsuario.OptionsColumn.AllowFocus = False
        Me.colBit_CreacionUsuario.OptionsColumn.AllowMove = False
        Me.colBit_CreacionUsuario.Visible = True
        Me.colBit_CreacionUsuario.VisibleIndex = 2
        Me.colBit_CreacionUsuario.Width = 125
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(469, 510)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdPorcEficienciaMaquinas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(449, 490)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnBuscar, Me.barbtnImprimir})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimir)})
        Me.Bar1.OptionsBar.AllowCollapse = True
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Glyph = CType(resources.GetObject("barbtnBuscar.Glyph"), System.Drawing.Image)
        Me.barbtnBuscar.Id = 0
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimir
        '
        Me.barbtnImprimir.Caption = "Imprimir"
        Me.barbtnImprimir.Glyph = CType(resources.GetObject("barbtnImprimir.Glyph"), System.Drawing.Image)
        Me.barbtnImprimir.Id = 1
        Me.barbtnImprimir.LargeGlyph = CType(resources.GetObject("barbtnImprimir.LargeGlyph"), System.Drawing.Image)
        Me.barbtnImprimir.Name = "barbtnImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(469, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 557)
        Me.barDockControlBottom.Size = New System.Drawing.Size(469, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 510)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(469, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 510)
        '
        'rdteBit_CreacionFecha
        '
        Me.rdteBit_CreacionFecha.AutoHeight = False
        Me.rdteBit_CreacionFecha.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy hh:mm tt"
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rdteBit_CreacionFecha.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.rdteBit_CreacionFecha.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"
        Me.rdteBit_CreacionFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rdteBit_CreacionFecha.EditFormat.FormatString = "dd/MM/yyyy hh:mm tt"
        Me.rdteBit_CreacionFecha.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rdteBit_CreacionFecha.Mask.EditMask = "dd/MM/yyyy hh:mm tt"
        Me.rdteBit_CreacionFecha.Mask.UseMaskAsDisplayFormat = True
        Me.rdteBit_CreacionFecha.Name = "rdteBit_CreacionFecha"
        '
        'frmPorcEficienciaMaquinas_LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 557)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(485, 595)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(485, 595)
        Me.Name = "frmPorcEficienciaMaquinas_LOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOG Porcentaje de Eficiencia de Maquinas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdPorcEficienciaMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPorcEficienciaMaquinas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewPorcEficienciaMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteBit_CreacionFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteBit_CreacionFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdPorcEficienciaMaquinas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewPorcEficienciaMaquinas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsPorcEficienciaMaquinas1 As waProduccion_Pedidos.dsPorcEficienciaMaquinas
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rdteFecha As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rspinPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents barbtnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rdteBit_CreacionFecha As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
