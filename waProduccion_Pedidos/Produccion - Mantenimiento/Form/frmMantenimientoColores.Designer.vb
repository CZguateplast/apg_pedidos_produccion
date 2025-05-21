<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoColores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoColores))
        Me.lycMantenimientoColores = New DevExpress.XtraLayout.LayoutControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycSplit1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycSplit2 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdColor = New DevExpress.XtraGrid.GridControl()
        Me.DsMantenimientoColores1 = New waProduccion_Pedidos.dsMantenimientoColores()
        Me.bgrdviewColor = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gbGeneral = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colKgColorante = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbdTodos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colARCPCC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colARCPCC_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gdgARTodos = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAR_Todos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAR_DL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAR_DL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAR_NDL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAR_NDL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCP_Todos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCP_DL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCP_DL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCP_NDL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCP_NDL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCC_Todos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCC_DL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCC_DL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCC_NDL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCC_NDL_Stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnGenerar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.barbtnTodosDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnARDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCPDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCCDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnReporteGeneral = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycMantenimientoColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycMantenimientoColores.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit2.SuspendLayout()
        CType(Me.grdColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMantenimientoColores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgrdviewColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycMantenimientoColores
        '
        Me.lycMantenimientoColores.Controls.Add(Me.SplitContainerControl1)
        Me.lycMantenimientoColores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycMantenimientoColores.Location = New System.Drawing.Point(0, 0)
        Me.lycMantenimientoColores.Name = "lycMantenimientoColores"
        Me.lycMantenimientoColores.Root = Me.LayoutControlGroup1
        Me.lycMantenimientoColores.Size = New System.Drawing.Size(1358, 694)
        Me.lycMantenimientoColores.TabIndex = 0
        Me.lycMantenimientoColores.Text = "LayoutControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lycSplit1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lycSplit2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1334, 670)
        Me.SplitContainerControl1.SplitterPosition = 6
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'lycSplit1
        '
        Me.lycSplit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit1.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit1.Name = "lycSplit1"
        Me.lycSplit1.Root = Me.LayoutControlGroup2
        Me.lycSplit1.Size = New System.Drawing.Size(1334, 6)
        Me.lycSplit1.TabIndex = 0
        Me.lycSplit1.Text = "LayoutControl1"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1317, 20)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'lycSplit2
        '
        Me.lycSplit2.Controls.Add(Me.grdColor)
        Me.lycSplit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit2.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit2.Name = "lycSplit2"
        Me.lycSplit2.Root = Me.LayoutControlGroup3
        Me.lycSplit2.Size = New System.Drawing.Size(1334, 659)
        Me.lycSplit2.TabIndex = 0
        Me.lycSplit2.Text = "LayoutControl1"
        '
        'grdColor
        '
        Me.grdColor.DataMember = "dsdtMantenimientoColores"
        Me.grdColor.DataSource = Me.DsMantenimientoColores1
        Me.grdColor.Location = New System.Drawing.Point(12, 12)
        Me.grdColor.MainView = Me.bgrdviewColor
        Me.grdColor.Name = "grdColor"
        Me.grdColor.Size = New System.Drawing.Size(1310, 635)
        Me.grdColor.TabIndex = 4
        Me.grdColor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bgrdviewColor})
        '
        'DsMantenimientoColores1
        '
        Me.DsMantenimientoColores1.DataSetName = "dsMantenimientoColores"
        Me.DsMantenimientoColores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bgrdviewColor
        '
        Me.bgrdviewColor.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.bgrdviewColor.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.bgrdviewColor.Appearance.BandPanel.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bgrdviewColor.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.BandPanel.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.BandPanel.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.BandPanel.Options.UseFont = True
        Me.bgrdviewColor.Appearance.BandPanel.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.bgrdviewColor.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bgrdviewColor.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.bgrdviewColor.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bgrdviewColor.Appearance.Empty.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.bgrdviewColor.Appearance.EvenRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.bgrdviewColor.Appearance.EvenRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.EvenRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.EvenRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgrdviewColor.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.bgrdviewColor.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgrdviewColor.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.bgrdviewColor.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.bgrdviewColor.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgrdviewColor.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.bgrdviewColor.Appearance.FilterPanel.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FilterPanel.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.bgrdviewColor.Appearance.FixedLine.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.FocusedCell.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Navy
        Me.bgrdviewColor.Appearance.FocusedCell.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FocusedCell.Options.UseFont = True
        Me.bgrdviewColor.Appearance.FocusedCell.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.FocusedRow.BackColor = System.Drawing.Color.Maroon
        Me.bgrdviewColor.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bgrdviewColor.Appearance.FocusedRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.FocusedRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FocusedRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.FocusedRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.FooterPanel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.FooterPanel.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.FooterPanel.Options.UseFont = True
        Me.bgrdviewColor.Appearance.FooterPanel.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.GroupButton.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.GroupButton.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.GroupButton.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.bgrdviewColor.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.bgrdviewColor.Appearance.GroupFooter.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.bgrdviewColor.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.GroupFooter.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.GroupFooter.Options.UseFont = True
        Me.bgrdviewColor.Appearance.GroupFooter.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.bgrdviewColor.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.GroupPanel.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bgrdviewColor.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.GroupPanel.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.GroupPanel.Options.UseFont = True
        Me.bgrdviewColor.Appearance.GroupPanel.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.bgrdviewColor.Appearance.GroupRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.GroupRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.GroupRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.GroupRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bgrdviewColor.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.bgrdviewColor.Appearance.HeaderPanel.Options.UseFont = True
        Me.bgrdviewColor.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.bgrdviewColor.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.bgrdviewColor.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bgrdviewColor.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.HideSelectionRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.HorzLine.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.OddRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.bgrdviewColor.Appearance.OddRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.OddRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.OddRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bgrdviewColor.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.Preview.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.Preview.ForeColor = System.Drawing.Color.Maroon
        Me.bgrdviewColor.Appearance.Preview.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.Preview.Options.UseFont = True
        Me.bgrdviewColor.Appearance.Preview.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.bgrdviewColor.Appearance.Row.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.Row.Options.UseFont = True
        Me.bgrdviewColor.Appearance.Row.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bgrdviewColor.Appearance.RowSeparator.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.bgrdviewColor.Appearance.SelectedRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.bgrdviewColor.Appearance.SelectedRow.Options.UseBackColor = True
        Me.bgrdviewColor.Appearance.SelectedRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.SelectedRow.Options.UseForeColor = True
        Me.bgrdviewColor.Appearance.TopNewRow.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.bgrdviewColor.Appearance.TopNewRow.Options.UseFont = True
        Me.bgrdviewColor.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.bgrdviewColor.Appearance.VertLine.Options.UseBackColor = True
        Me.bgrdviewColor.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbGeneral, Me.gbdTodos, Me.gridBand2, Me.gridBand5, Me.gridBand9})
        Me.bgrdviewColor.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colColor, Me.colNombre, Me.colEstado, Me.colKgColorante, Me.colARCPCC, Me.colARCPCC_Stock, Me.colAR_Todos, Me.colAR_DL, Me.colAR_DL_Stock, Me.colAR_NDL, Me.colAR_NDL_Stock, Me.colCP_Todos, Me.colCP_DL, Me.colCP_DL_Stock, Me.colCP_NDL, Me.colCP_NDL_Stock, Me.colCC_Todos, Me.colCC_DL, Me.colCC_DL_Stock, Me.colCC_NDL, Me.colCC_NDL_Stock})
        Me.bgrdviewColor.GridControl = Me.grdColor
        Me.bgrdviewColor.Name = "bgrdviewColor"
        Me.bgrdviewColor.OptionsBehavior.Editable = False
        Me.bgrdviewColor.OptionsBehavior.ReadOnly = True
        Me.bgrdviewColor.OptionsView.EnableAppearanceEvenRow = True
        Me.bgrdviewColor.OptionsView.EnableAppearanceOddRow = True
        Me.bgrdviewColor.OptionsView.ShowFooter = True
        Me.bgrdviewColor.OptionsView.ShowGroupPanel = False
        Me.bgrdviewColor.PaintStyleName = "MixedXP"
        '
        'gbGeneral
        '
        Me.gbGeneral.AppearanceHeader.Options.UseTextOptions = True
        Me.gbGeneral.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbGeneral.Caption = "Datos Generales"
        Me.gbGeneral.Columns.Add(Me.colColor)
        Me.gbGeneral.Columns.Add(Me.colNombre)
        Me.gbGeneral.Columns.Add(Me.colEstado)
        Me.gbGeneral.Columns.Add(Me.colKgColorante)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.VisibleIndex = 0
        Me.gbGeneral.Width = 536
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceCell.Options.UseFont = True
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.Width = 67
        '
        'colNombre
        '
        Me.colNombre.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceCell.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.Width = 247
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstado.AppearanceCell.Options.UseFont = True
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.Width = 100
        '
        'colKgColorante
        '
        Me.colKgColorante.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colKgColorante.AppearanceCell.Options.UseFont = True
        Me.colKgColorante.AppearanceHeader.Options.UseTextOptions = True
        Me.colKgColorante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKgColorante.FieldName = "KgColorante"
        Me.colKgColorante.Name = "colKgColorante"
        Me.colKgColorante.OptionsColumn.ReadOnly = True
        Me.colKgColorante.Visible = True
        Me.colKgColorante.Width = 122
        '
        'gbdTodos
        '
        Me.gbdTodos.AppearanceHeader.Options.UseTextOptions = True
        Me.gbdTodos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbdTodos.Caption = "(AR/CP/CC)"
        Me.gbdTodos.Columns.Add(Me.colARCPCC)
        Me.gbdTodos.Columns.Add(Me.colARCPCC_Stock)
        Me.gbdTodos.Name = "gbdTodos"
        Me.gbdTodos.VisibleIndex = 1
        Me.gbdTodos.Width = 100
        '
        'colARCPCC
        '
        Me.colARCPCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colARCPCC.AppearanceHeader.Options.UseFont = True
        Me.colARCPCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colARCPCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colARCPCC.Caption = "DL/NDL"
        Me.colARCPCC.FieldName = "ARCPCC"
        Me.colARCPCC.Name = "colARCPCC"
        Me.colARCPCC.OptionsColumn.ReadOnly = True
        Me.colARCPCC.Visible = True
        Me.colARCPCC.Width = 50
        '
        'colARCPCC_Stock
        '
        Me.colARCPCC_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colARCPCC_Stock.AppearanceHeader.Options.UseFont = True
        Me.colARCPCC_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colARCPCC_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colARCPCC_Stock.Caption = "C/Stock"
        Me.colARCPCC_Stock.FieldName = "ARCPCC_Stock"
        Me.colARCPCC_Stock.Name = "colARCPCC_Stock"
        Me.colARCPCC_Stock.OptionsColumn.ReadOnly = True
        Me.colARCPCC_Stock.Visible = True
        Me.colARCPCC_Stock.Width = 50
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand2.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "(AR) Articulos"
        Me.gridBand2.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gdgARTodos, Me.gridBand4, Me.gridBand3})
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 250
        '
        'gdgARTodos
        '
        Me.gdgARTodos.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gdgARTodos.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gdgARTodos.AppearanceHeader.Options.UseBackColor = True
        Me.gdgARTodos.AppearanceHeader.Options.UseForeColor = True
        Me.gdgARTodos.AppearanceHeader.Options.UseTextOptions = True
        Me.gdgARTodos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdgARTodos.Caption = "Todos"
        Me.gdgARTodos.Columns.Add(Me.colAR_Todos)
        Me.gdgARTodos.Name = "gdgARTodos"
        Me.gdgARTodos.VisibleIndex = 0
        Me.gdgARTodos.Width = 50
        '
        'colAR_Todos
        '
        Me.colAR_Todos.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colAR_Todos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAR_Todos.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colAR_Todos.AppearanceCell.Options.UseBackColor = True
        Me.colAR_Todos.AppearanceCell.Options.UseFont = True
        Me.colAR_Todos.AppearanceCell.Options.UseForeColor = True
        Me.colAR_Todos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colAR_Todos.AppearanceHeader.Options.UseFont = True
        Me.colAR_Todos.AppearanceHeader.Options.UseTextOptions = True
        Me.colAR_Todos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAR_Todos.Caption = "DL/NDL"
        Me.colAR_Todos.FieldName = "AR_Todos"
        Me.colAR_Todos.Name = "colAR_Todos"
        Me.colAR_Todos.OptionsColumn.ReadOnly = True
        Me.colAR_Todos.Visible = True
        Me.colAR_Todos.Width = 50
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand4.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand4.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand4.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.Caption = "De Linea"
        Me.gridBand4.Columns.Add(Me.colAR_DL)
        Me.gridBand4.Columns.Add(Me.colAR_DL_Stock)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 1
        Me.gridBand4.Width = 100
        '
        'colAR_DL
        '
        Me.colAR_DL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAR_DL.AppearanceCell.Options.UseBackColor = True
        Me.colAR_DL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colAR_DL.AppearanceHeader.Options.UseFont = True
        Me.colAR_DL.AppearanceHeader.Options.UseTextOptions = True
        Me.colAR_DL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAR_DL.Caption = "DL"
        Me.colAR_DL.FieldName = "AR_DL"
        Me.colAR_DL.Name = "colAR_DL"
        Me.colAR_DL.OptionsColumn.ReadOnly = True
        Me.colAR_DL.Visible = True
        Me.colAR_DL.Width = 50
        '
        'colAR_DL_Stock
        '
        Me.colAR_DL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAR_DL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colAR_DL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colAR_DL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colAR_DL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colAR_DL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAR_DL_Stock.Caption = "C/Stock"
        Me.colAR_DL_Stock.FieldName = "AR_DL_Stock"
        Me.colAR_DL_Stock.Name = "colAR_DL_Stock"
        Me.colAR_DL_Stock.OptionsColumn.ReadOnly = True
        Me.colAR_DL_Stock.Visible = True
        Me.colAR_DL_Stock.Width = 50
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand3.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand3.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand3.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "No de Linea"
        Me.gridBand3.Columns.Add(Me.colAR_NDL)
        Me.gridBand3.Columns.Add(Me.colAR_NDL_Stock)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 100
        '
        'colAR_NDL
        '
        Me.colAR_NDL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAR_NDL.AppearanceCell.Options.UseBackColor = True
        Me.colAR_NDL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colAR_NDL.AppearanceHeader.Options.UseFont = True
        Me.colAR_NDL.AppearanceHeader.Options.UseTextOptions = True
        Me.colAR_NDL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAR_NDL.Caption = "NDL"
        Me.colAR_NDL.FieldName = "AR_NDL"
        Me.colAR_NDL.Name = "colAR_NDL"
        Me.colAR_NDL.OptionsColumn.ReadOnly = True
        Me.colAR_NDL.Visible = True
        Me.colAR_NDL.Width = 50
        '
        'colAR_NDL_Stock
        '
        Me.colAR_NDL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAR_NDL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colAR_NDL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colAR_NDL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colAR_NDL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colAR_NDL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAR_NDL_Stock.Caption = "C/Stock"
        Me.colAR_NDL_Stock.FieldName = "AR_NDL_Stock"
        Me.colAR_NDL_Stock.Name = "colAR_NDL_Stock"
        Me.colAR_NDL_Stock.OptionsColumn.ReadOnly = True
        Me.colAR_NDL_Stock.Visible = True
        Me.colAR_NDL_Stock.Width = 50
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand5.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand5.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand5.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "(CP) Componentes Producidos"
        Me.gridBand5.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand6, Me.gridBand7, Me.gridBand8})
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 3
        Me.gridBand5.Width = 250
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand6.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand6.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand6.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "Todos"
        Me.gridBand6.Columns.Add(Me.colCP_Todos)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 0
        Me.gridBand6.Width = 50
        '
        'colCP_Todos
        '
        Me.colCP_Todos.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colCP_Todos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCP_Todos.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colCP_Todos.AppearanceCell.Options.UseBackColor = True
        Me.colCP_Todos.AppearanceCell.Options.UseFont = True
        Me.colCP_Todos.AppearanceCell.Options.UseForeColor = True
        Me.colCP_Todos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCP_Todos.AppearanceHeader.Options.UseFont = True
        Me.colCP_Todos.AppearanceHeader.Options.UseTextOptions = True
        Me.colCP_Todos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCP_Todos.Caption = "DL/NDL"
        Me.colCP_Todos.FieldName = "CP_Todos"
        Me.colCP_Todos.Name = "colCP_Todos"
        Me.colCP_Todos.OptionsColumn.ReadOnly = True
        Me.colCP_Todos.Visible = True
        Me.colCP_Todos.Width = 50
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand7.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand7.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand7.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.Caption = "De Linea"
        Me.gridBand7.Columns.Add(Me.colCP_DL)
        Me.gridBand7.Columns.Add(Me.colCP_DL_Stock)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 1
        Me.gridBand7.Width = 100
        '
        'colCP_DL
        '
        Me.colCP_DL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCP_DL.AppearanceCell.Options.UseBackColor = True
        Me.colCP_DL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCP_DL.AppearanceHeader.Options.UseFont = True
        Me.colCP_DL.AppearanceHeader.Options.UseTextOptions = True
        Me.colCP_DL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCP_DL.Caption = "DL"
        Me.colCP_DL.FieldName = "CP_DL"
        Me.colCP_DL.Name = "colCP_DL"
        Me.colCP_DL.OptionsColumn.ReadOnly = True
        Me.colCP_DL.Visible = True
        Me.colCP_DL.Width = 50
        '
        'colCP_DL_Stock
        '
        Me.colCP_DL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCP_DL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colCP_DL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCP_DL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colCP_DL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colCP_DL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCP_DL_Stock.Caption = "C/Stock"
        Me.colCP_DL_Stock.FieldName = "CP_DL_Stock"
        Me.colCP_DL_Stock.Name = "colCP_DL_Stock"
        Me.colCP_DL_Stock.OptionsColumn.ReadOnly = True
        Me.colCP_DL_Stock.Visible = True
        Me.colCP_DL_Stock.Width = 50
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridBand8.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand8.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand8.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.Caption = "No de Linea"
        Me.gridBand8.Columns.Add(Me.colCP_NDL)
        Me.gridBand8.Columns.Add(Me.colCP_NDL_Stock)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 2
        Me.gridBand8.Width = 100
        '
        'colCP_NDL
        '
        Me.colCP_NDL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCP_NDL.AppearanceCell.Options.UseBackColor = True
        Me.colCP_NDL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCP_NDL.AppearanceHeader.Options.UseFont = True
        Me.colCP_NDL.AppearanceHeader.Options.UseTextOptions = True
        Me.colCP_NDL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCP_NDL.Caption = "NDL"
        Me.colCP_NDL.FieldName = "CP_NDL"
        Me.colCP_NDL.Name = "colCP_NDL"
        Me.colCP_NDL.OptionsColumn.ReadOnly = True
        Me.colCP_NDL.Visible = True
        Me.colCP_NDL.Width = 50
        '
        'colCP_NDL_Stock
        '
        Me.colCP_NDL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCP_NDL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colCP_NDL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCP_NDL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colCP_NDL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colCP_NDL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCP_NDL_Stock.Caption = "C/Stock"
        Me.colCP_NDL_Stock.FieldName = "CP_NDL_Stock"
        Me.colCP_NDL_Stock.Name = "colCP_NDL_Stock"
        Me.colCP_NDL_Stock.OptionsColumn.ReadOnly = True
        Me.colCP_NDL_Stock.Visible = True
        Me.colCP_NDL_Stock.Width = 50
        '
        'gridBand9
        '
        Me.gridBand9.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand9.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand9.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand9.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand9.Caption = "(CC) Componentes Comprados"
        Me.gridBand9.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand10, Me.gridBand11, Me.gridBand12})
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 4
        Me.gridBand9.Width = 250
        '
        'gridBand10
        '
        Me.gridBand10.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand10.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand10.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand10.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand10.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand10.Caption = "Todos"
        Me.gridBand10.Columns.Add(Me.colCC_Todos)
        Me.gridBand10.Name = "gridBand10"
        Me.gridBand10.VisibleIndex = 0
        Me.gridBand10.Width = 50
        '
        'colCC_Todos
        '
        Me.colCC_Todos.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colCC_Todos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCC_Todos.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colCC_Todos.AppearanceCell.Options.UseBackColor = True
        Me.colCC_Todos.AppearanceCell.Options.UseFont = True
        Me.colCC_Todos.AppearanceCell.Options.UseForeColor = True
        Me.colCC_Todos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCC_Todos.AppearanceHeader.Options.UseFont = True
        Me.colCC_Todos.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC_Todos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC_Todos.Caption = "DL/NDL"
        Me.colCC_Todos.FieldName = "CC_Todos"
        Me.colCC_Todos.Name = "colCC_Todos"
        Me.colCC_Todos.OptionsColumn.ReadOnly = True
        Me.colCC_Todos.Visible = True
        Me.colCC_Todos.Width = 50
        '
        'gridBand11
        '
        Me.gridBand11.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand11.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand11.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand11.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand11.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand11.Caption = "De Linea"
        Me.gridBand11.Columns.Add(Me.colCC_DL)
        Me.gridBand11.Columns.Add(Me.colCC_DL_Stock)
        Me.gridBand11.Name = "gridBand11"
        Me.gridBand11.VisibleIndex = 1
        Me.gridBand11.Width = 100
        '
        'colCC_DL
        '
        Me.colCC_DL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCC_DL.AppearanceCell.Options.UseBackColor = True
        Me.colCC_DL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCC_DL.AppearanceHeader.Options.UseFont = True
        Me.colCC_DL.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC_DL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC_DL.Caption = "DL"
        Me.colCC_DL.FieldName = "CC_DL"
        Me.colCC_DL.Name = "colCC_DL"
        Me.colCC_DL.OptionsColumn.ReadOnly = True
        Me.colCC_DL.Visible = True
        Me.colCC_DL.Width = 50
        '
        'colCC_DL_Stock
        '
        Me.colCC_DL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCC_DL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colCC_DL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCC_DL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colCC_DL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC_DL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC_DL_Stock.Caption = "C/Stock"
        Me.colCC_DL_Stock.FieldName = "CC_DL_Stock"
        Me.colCC_DL_Stock.Name = "colCC_DL_Stock"
        Me.colCC_DL_Stock.OptionsColumn.ReadOnly = True
        Me.colCC_DL_Stock.Visible = True
        Me.colCC_DL_Stock.Width = 50
        '
        'gridBand12
        '
        Me.gridBand12.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand12.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.gridBand12.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand12.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand12.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand12.Caption = "No de Linea"
        Me.gridBand12.Columns.Add(Me.colCC_NDL)
        Me.gridBand12.Columns.Add(Me.colCC_NDL_Stock)
        Me.gridBand12.Name = "gridBand12"
        Me.gridBand12.VisibleIndex = 2
        Me.gridBand12.Width = 100
        '
        'colCC_NDL
        '
        Me.colCC_NDL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCC_NDL.AppearanceCell.Options.UseBackColor = True
        Me.colCC_NDL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCC_NDL.AppearanceHeader.Options.UseFont = True
        Me.colCC_NDL.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC_NDL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC_NDL.Caption = "NDL"
        Me.colCC_NDL.FieldName = "CC_NDL"
        Me.colCC_NDL.Name = "colCC_NDL"
        Me.colCC_NDL.OptionsColumn.ReadOnly = True
        Me.colCC_NDL.Visible = True
        Me.colCC_NDL.Width = 50
        '
        'colCC_NDL_Stock
        '
        Me.colCC_NDL_Stock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCC_NDL_Stock.AppearanceCell.Options.UseBackColor = True
        Me.colCC_NDL_Stock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colCC_NDL_Stock.AppearanceHeader.Options.UseFont = True
        Me.colCC_NDL_Stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC_NDL_Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC_NDL_Stock.Caption = "C/Stock"
        Me.colCC_NDL_Stock.FieldName = "CC_NDL_Stock"
        Me.colCC_NDL_Stock.Name = "colCC_NDL_Stock"
        Me.colCC_NDL_Stock.OptionsColumn.ReadOnly = True
        Me.colCC_NDL_Stock.Visible = True
        Me.colCC_NDL_Stock.Width = 50
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1334, 659)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdColor
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1314, 639)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1358, 694)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SplitContainerControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1338, 674)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnBuscar, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnGenerar, Me.barbtnARDetalle, Me.barbtnCPDetalle, Me.barbtnCCDetalle, Me.barbtnTodosDetalle, Me.barbtnReporteGeneral, Me.BarSubItem1})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGenerar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnReporteGeneral, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnGenerar
        '
        Me.barbtnGenerar.Caption = "Aplicar Filtro"
        Me.barbtnGenerar.Id = 5
        Me.barbtnGenerar.ImageOptions.Image = CType(resources.GetObject("barbtnGenerar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGenerar.Name = "barbtnGenerar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Detalle"
        Me.BarSubItem1.Id = 12
        Me.BarSubItem1.ImageOptions.Image = CType(resources.GetObject("BarSubItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnTodosDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnARDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCPDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCCDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'barbtnTodosDetalle
        '
        Me.barbtnTodosDetalle.Caption = "Todos"
        Me.barbtnTodosDetalle.Id = 9
        Me.barbtnTodosDetalle.ImageOptions.Image = CType(resources.GetObject("barbtnTodosDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnTodosDetalle.Name = "barbtnTodosDetalle"
        '
        'barbtnARDetalle
        '
        Me.barbtnARDetalle.Caption = "AR"
        Me.barbtnARDetalle.Id = 6
        Me.barbtnARDetalle.ImageOptions.Image = CType(resources.GetObject("barbtnARDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnARDetalle.Name = "barbtnARDetalle"
        '
        'barbtnCPDetalle
        '
        Me.barbtnCPDetalle.Caption = "CP"
        Me.barbtnCPDetalle.Id = 7
        Me.barbtnCPDetalle.ImageOptions.Image = CType(resources.GetObject("barbtnCPDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCPDetalle.Name = "barbtnCPDetalle"
        '
        'barbtnCCDetalle
        '
        Me.barbtnCCDetalle.Caption = "CC"
        Me.barbtnCCDetalle.Id = 8
        Me.barbtnCCDetalle.ImageOptions.Image = CType(resources.GetObject("barbtnCCDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCCDetalle.Name = "barbtnCCDetalle"
        '
        'barbtnReporteGeneral
        '
        Me.barbtnReporteGeneral.Caption = "Reporte"
        Me.barbtnReporteGeneral.Id = 10
        Me.barbtnReporteGeneral.ImageOptions.Image = CType(resources.GetObject("barbtnReporteGeneral.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnReporteGeneral.Name = "barbtnReporteGeneral"
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
        Me.barbtnImprimirGrid.Caption = "Imprimir"
        Me.barbtnImprimirGrid.Id = 3
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar"
        Me.barbtnExportarXlsx.Id = 4
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1358, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 694)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1358, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 694)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1358, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 694)
        '
        'frmMantenimientoColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.lycMantenimientoColores)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMantenimientoColores"
        Me.Text = "frmMantenimientoColores"
        CType(Me.lycMantenimientoColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycMantenimientoColores.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit2.ResumeLayout(False)
        CType(Me.grdColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMantenimientoColores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgrdviewColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycMantenimientoColores As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycSplit1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycSplit2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdColor As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsMantenimientoColores1 As waProduccion_Pedidos.dsMantenimientoColores
    Friend WithEvents bgrdviewColor As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents gbGeneral As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKgColorante As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbdTodos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colARCPCC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colARCPCC_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gdgARTodos As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAR_Todos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAR_DL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAR_DL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAR_NDL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAR_NDL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCP_Todos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCP_DL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCP_DL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCP_NDL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCP_NDL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCC_Todos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCC_DL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCC_DL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCC_NDL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCC_NDL_Stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnGenerar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnARDetalle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnTodosDetalle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCPDetalle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCCDetalle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnReporteGeneral As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
End Class
