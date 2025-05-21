<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanPrioridadesAlmacen_Hijos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanPrioridadesAlmacen_Hijos))
        Me.lycHijos = New DevExpress.XtraLayout.LayoutControl()
        Me.grdPlanPrioridadesAlmacen = New DevExpress.XtraGrid.GridControl()
        Me.DsEmergenciasProduccion1 = New waProduccion_Pedidos.dsEmergenciasProduccion()
        Me.grdviewPlanPrioridadesAlmacen = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinMonto = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnOrdenProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycHijos.SuspendLayout()
        CType(Me.grdPlanPrioridadesAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmergenciasProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewPlanPrioridadesAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycHijos
        '
        Me.lycHijos.Controls.Add(Me.grdPlanPrioridadesAlmacen)
        Me.lycHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycHijos.Location = New System.Drawing.Point(0, 0)
        Me.lycHijos.Name = "lycHijos"
        Me.lycHijos.Root = Me.LayoutControlGroup1
        Me.lycHijos.Size = New System.Drawing.Size(821, 261)
        Me.lycHijos.TabIndex = 0
        Me.lycHijos.Text = "LayoutControl1"
        '
        'grdPlanPrioridadesAlmacen
        '
        Me.grdPlanPrioridadesAlmacen.DataMember = "dsdtEmergenciasProduccion_Hijos"
        Me.grdPlanPrioridadesAlmacen.DataSource = Me.DsEmergenciasProduccion1
        Me.grdPlanPrioridadesAlmacen.Location = New System.Drawing.Point(12, 12)
        Me.grdPlanPrioridadesAlmacen.MainView = Me.grdviewPlanPrioridadesAlmacen
        Me.grdPlanPrioridadesAlmacen.MenuManager = Me.BarManager1
        Me.grdPlanPrioridadesAlmacen.Name = "grdPlanPrioridadesAlmacen"
        Me.grdPlanPrioridadesAlmacen.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rspinMonto})
        Me.grdPlanPrioridadesAlmacen.Size = New System.Drawing.Size(797, 237)
        Me.grdPlanPrioridadesAlmacen.TabIndex = 4
        Me.grdPlanPrioridadesAlmacen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewPlanPrioridadesAlmacen})
        '
        'DsEmergenciasProduccion1
        '
        Me.DsEmergenciasProduccion1.DataSetName = "dsEmergenciasProduccion"
        Me.DsEmergenciasProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewPlanPrioridadesAlmacen
        '
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Preview.Options.UseFont = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Row.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.Row.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewPlanPrioridadesAlmacen.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewPlanPrioridadesAlmacen.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewPlanPrioridadesAlmacen.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProdFinal})
        Me.grdviewPlanPrioridadesAlmacen.GridControl = Me.grdPlanPrioridadesAlmacen
        Me.grdviewPlanPrioridadesAlmacen.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Planeado", Nothing, "(Planeado: SUM={0:0.##})")})
        Me.grdviewPlanPrioridadesAlmacen.Name = "grdviewPlanPrioridadesAlmacen"
        Me.grdviewPlanPrioridadesAlmacen.OptionsBehavior.Editable = False
        Me.grdviewPlanPrioridadesAlmacen.OptionsBehavior.ReadOnly = True
        Me.grdviewPlanPrioridadesAlmacen.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewPlanPrioridadesAlmacen.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewPlanPrioridadesAlmacen.OptionsView.ShowFooter = True
        Me.grdviewPlanPrioridadesAlmacen.OptionsView.ShowGroupPanel = False
        Me.grdviewPlanPrioridadesAlmacen.PaintStyleName = "Style3D"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 123
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 286
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.ColumnEdit = Me.rspinMonto
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 2
        '
        'rspinMonto
        '
        Me.rspinMonto.AutoHeight = False
        Me.rspinMonto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinMonto.DisplayFormat.FormatString = "n0"
        Me.rspinMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinMonto.EditFormat.FormatString = "n0"
        Me.rspinMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinMonto.Mask.EditMask = "n0"
        Me.rspinMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rspinMonto.Name = "rspinMonto"
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.ColumnEdit = Me.rspinMonto
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 3
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.ColumnEdit = Me.rspinMonto
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 4
        '
        'colProdFinal
        '
        Me.colProdFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colProdFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProdFinal.ColumnEdit = Me.rspinMonto
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        Me.colProdFinal.Visible = True
        Me.colProdFinal.VisibleIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnOrdenProduccion, Me.barbtnCerrar, Me.barbtnImprimirGrid})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenProduccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnOrdenProduccion
        '
        Me.barbtnOrdenProduccion.Caption = "Ordenes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producción"
        Me.barbtnOrdenProduccion.Id = 0
        Me.barbtnOrdenProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenProduccion.Name = "barbtnOrdenProduccion"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 2
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(821, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 261)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(821, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 261)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(821, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 261)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(821, 261)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdPlanPrioridadesAlmacen
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(801, 241)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmPlanPrioridadesAlmacen_Hijos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycHijos)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPlanPrioridadesAlmacen_Hijos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Hijos"
        CType(Me.lycHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycHijos.ResumeLayout(False)
        CType(Me.grdPlanPrioridadesAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmergenciasProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewPlanPrioridadesAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycHijos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdPlanPrioridadesAlmacen As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewPlanPrioridadesAlmacen As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsEmergenciasProduccion1 As waProduccion_Pedidos.dsEmergenciasProduccion
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnOrdenProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rspinMonto As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
