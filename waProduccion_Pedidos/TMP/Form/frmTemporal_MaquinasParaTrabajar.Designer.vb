<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_MaquinasParaTrabajar
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_MaquinasParaTrabajar))
        Me.lycMaquinasParaTrabajar = New DevExpress.XtraLayout.LayoutControl()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.DsTemporal_MaquinasParaTrabajar1 = New waProduccion_Pedidos.dsTemporal_MaquinasParaTrabajar()
        Me.lbTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoPadre = New DevExpress.XtraEditors.TextEdit()
        Me.grdMaquinasParaTrabajar = New DevExpress.XtraGrid.GridControl()
        Me.grdviewMaquinasParaTrabajar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasPendientes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblTitulo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnAceptar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycMaquinasParaTrabajar.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_MaquinasParaTrabajar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycMaquinasParaTrabajar
        '
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.ChartControl2)
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.ChartControl1)
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.lbTitulo)
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.txtNombre)
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.txtCodigoPadre)
        Me.lycMaquinasParaTrabajar.Controls.Add(Me.grdMaquinasParaTrabajar)
        Me.lycMaquinasParaTrabajar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycMaquinasParaTrabajar.Location = New System.Drawing.Point(0, 0)
        Me.lycMaquinasParaTrabajar.Name = "lycMaquinasParaTrabajar"
        Me.lycMaquinasParaTrabajar.Root = Me.LayoutControlGroup1
        Me.lycMaquinasParaTrabajar.Size = New System.Drawing.Size(922, 471)
        Me.lycMaquinasParaTrabajar.TabIndex = 0
        Me.lycMaquinasParaTrabajar.Text = "LayoutControl1"
        '
        'ChartControl2
        '
        Me.ChartControl2.DataBindings = Nothing
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Location = New System.Drawing.Point(12, 439)
        Me.ChartControl2.Name = "ChartControl2"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl2.Size = New System.Drawing.Size(898, 20)
        Me.ChartControl2.TabIndex = 9
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.DsTemporal_MaquinasParaTrabajar1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(339, 41)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "dsdtTemporal_MaquinasParaTrabajar.Maquina"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "dsdtTemporal_MaquinasParaTrabajar.HorasPendientes"
        Me.ChartControl1.Size = New System.Drawing.Size(571, 394)
        Me.ChartControl1.TabIndex = 8
        '
        'DsTemporal_MaquinasParaTrabajar1
        '
        Me.DsTemporal_MaquinasParaTrabajar1.DataSetName = "dsTemporal_MaquinasParaTrabajar"
        Me.DsTemporal_MaquinasParaTrabajar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbTitulo
        '
        Me.lbTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbTitulo.Appearance.Options.UseFont = True
        Me.lbTitulo.Appearance.Options.UseForeColor = True
        Me.lbTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(451, 25)
        Me.lbTitulo.StyleController = Me.lycMaquinasParaTrabajar
        Me.lbTitulo.TabIndex = 7
        Me.lbTitulo.Text = "MAQUINAS DISPONIBLES PARA TRABAJAR"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(89, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(246, 20)
        Me.txtNombre.StyleController = Me.lycMaquinasParaTrabajar
        Me.txtNombre.TabIndex = 6
        '
        'txtCodigoPadre
        '
        Me.txtCodigoPadre.Location = New System.Drawing.Point(89, 41)
        Me.txtCodigoPadre.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txtCodigoPadre.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txtCodigoPadre.Name = "txtCodigoPadre"
        Me.txtCodigoPadre.Properties.ReadOnly = True
        Me.txtCodigoPadre.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoPadre.StyleController = Me.lycMaquinasParaTrabajar
        Me.txtCodigoPadre.TabIndex = 5
        '
        'grdMaquinasParaTrabajar
        '
        Me.grdMaquinasParaTrabajar.DataMember = "dsdtTemporal_MaquinasParaTrabajar"
        Me.grdMaquinasParaTrabajar.DataSource = Me.DsTemporal_MaquinasParaTrabajar1
        Me.grdMaquinasParaTrabajar.Location = New System.Drawing.Point(12, 89)
        Me.grdMaquinasParaTrabajar.MainView = Me.grdviewMaquinasParaTrabajar
        Me.grdMaquinasParaTrabajar.Name = "grdMaquinasParaTrabajar"
        Me.grdMaquinasParaTrabajar.Size = New System.Drawing.Size(323, 346)
        Me.grdMaquinasParaTrabajar.TabIndex = 4
        Me.grdMaquinasParaTrabajar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinasParaTrabajar})
        '
        'grdviewMaquinasParaTrabajar
        '
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewMaquinasParaTrabajar.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasParaTrabajar.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasParaTrabajar.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMaquinasParaTrabajar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewMaquinasParaTrabajar.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinasParaTrabajar.ColumnPanelRowHeight = 35
        Me.grdviewMaquinasParaTrabajar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMolde, Me.colEstatus, Me.colPrioridad, Me.colMaquina, Me.colHorasPendientes})
        Me.grdviewMaquinasParaTrabajar.GridControl = Me.grdMaquinasParaTrabajar
        Me.grdviewMaquinasParaTrabajar.Name = "grdviewMaquinasParaTrabajar"
        Me.grdviewMaquinasParaTrabajar.OptionsBehavior.Editable = False
        Me.grdviewMaquinasParaTrabajar.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinasParaTrabajar.OptionsView.ColumnAutoWidth = False
        Me.grdviewMaquinasParaTrabajar.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinasParaTrabajar.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinasParaTrabajar.OptionsView.ShowFooter = True
        Me.grdviewMaquinasParaTrabajar.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinasParaTrabajar.PaintStyleName = "Web"
        '
        'colMolde
        '
        Me.colMolde.FieldName = "Componente"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Width = 50
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.Caption = "Activa"
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 1
        Me.colEstatus.Width = 70
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 70
        '
        'colMaquina
        '
        Me.colMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.FieldName = "Maquina"
        Me.colMaquina.Name = "colMaquina"
        Me.colMaquina.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colMaquina.Visible = True
        Me.colMaquina.VisibleIndex = 2
        Me.colMaquina.Width = 70
        '
        'colHorasPendientes
        '
        Me.colHorasPendientes.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasPendientes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasPendientes.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasPendientes.FieldName = "HorasPendientes"
        Me.colHorasPendientes.Name = "colHorasPendientes"
        Me.colHorasPendientes.OptionsColumn.ReadOnly = True
        Me.colHorasPendientes.Visible = True
        Me.colHorasPendientes.VisibleIndex = 3
        Me.colHorasPendientes.Width = 87
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.lblTitulo, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(922, 471)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdMaquinasParaTrabajar
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 77)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(327, 350)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtCodigoPadre
        Me.LayoutControlItem2.CustomizationFormText = "Codigo Padre"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem2.Text = "Codigo Padre"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtNombre
        Me.LayoutControlItem3.CustomizationFormText = "Nombre"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(327, 24)
        Me.LayoutControlItem3.Text = "Nombre"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(201, 29)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(126, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblTitulo
        '
        Me.lblTitulo.Control = Me.lbTitulo
        Me.lblTitulo.CustomizationFormText = "Maquinas para Trabajar"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(902, 29)
        Me.lblTitulo.Text = "Maquinas para Trabajar"
        Me.lblTitulo.TextSize = New System.Drawing.Size(0, 0)
        Me.lblTitulo.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ChartControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(327, 29)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(575, 398)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ChartControl2
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 427)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(902, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnAceptar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAceptar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnAceptar
        '
        Me.barbtnAceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAceptar.Caption = "Aceptar"
        Me.barbtnAceptar.Id = 1
        Me.barbtnAceptar.ImageOptions.Image = CType(resources.GetObject("barbtnAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAceptar.Name = "barbtnAceptar"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(922, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 471)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(922, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 471)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(922, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 471)
        '
        'frmTemporal_MaquinasParaTrabajar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 514)
        Me.Controls.Add(Me.lycMaquinasParaTrabajar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_MaquinasParaTrabajar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_MaquinasParaTrabajar"
        CType(Me.lycMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycMaquinasParaTrabajar.ResumeLayout(False)
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_MaquinasParaTrabajar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMaquinasParaTrabajar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycMaquinasParaTrabajar As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoPadre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdMaquinasParaTrabajar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinasParaTrabajar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAceptar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lbTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTitulo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_MaquinasParaTrabajar1 As waProduccion_Pedidos.dsTemporal_MaquinasParaTrabajar
    Friend WithEvents colMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasPendientes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
