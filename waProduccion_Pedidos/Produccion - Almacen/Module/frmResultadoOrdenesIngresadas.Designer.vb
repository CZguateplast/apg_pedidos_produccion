<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultadoOrdenesIngresadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultadoOrdenesIngresadas))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdOrdenIngresoSAPResultado = New DevExpress.XtraGrid.GridControl()
        Me.DsIngresoOrden1 = New waProduccion_Pedidos.dsIngresoOrden()
        Me.grdviewOrdenIngresoSAPResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueDestino = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DsIngresoOrden1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnVistaPrevia = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.LayoutControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.LayoutControl1.SuspendLayout
        CType(Me.grdOrdenIngresoSAPResultado,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsIngresoOrden1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grdviewOrdenIngresoSAPResultado,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.rslueOrigen,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSearchLookUpEdit1View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.rslueDestino,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutControlItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsIngresoOrden1BindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdOrdenIngresoSAPResultado)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(639, 471)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdOrdenIngresoSAPResultado
        '
        Me.grdOrdenIngresoSAPResultado.DataMember = "dsdtSAPResultados"
        Me.grdOrdenIngresoSAPResultado.DataSource = Me.DsIngresoOrden1
        Me.grdOrdenIngresoSAPResultado.Location = New System.Drawing.Point(12, 34)
        Me.grdOrdenIngresoSAPResultado.MainView = Me.grdviewOrdenIngresoSAPResultado
        Me.grdOrdenIngresoSAPResultado.Name = "grdOrdenIngresoSAPResultado"
        Me.grdOrdenIngresoSAPResultado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen, Me.rslueDestino})
        Me.grdOrdenIngresoSAPResultado.Size = New System.Drawing.Size(615, 425)
        Me.grdOrdenIngresoSAPResultado.TabIndex = 4
        Me.grdOrdenIngresoSAPResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenIngresoSAPResultado})
        '
        'DsIngresoOrden1
        '
        Me.DsIngresoOrden1.DataSetName = "dsIngresoOrden"
        Me.DsIngresoOrden1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenIngresoSAPResultado
        '
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButton.Options.UseForeColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Empty.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewOrdenIngresoSAPResultado.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewOrdenIngresoSAPResultado.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewOrdenIngresoSAPResultado.Appearance.EvenRow.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterCloseButton.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterCloseButton.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FilterPanel.Options.UseForeColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FocusedRow.Options.UseForeColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FooterPanel.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.FooterPanel.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupButton.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupButton.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupFooter.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupFooter.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupPanel.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupPanel.Options.UseForeColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupRow.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.GroupRow.Options.UseFont = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HeaderPanel.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HeaderPanel.Options.UseBorderColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HideSelectionRow.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewOrdenIngresoSAPResultado.Appearance.HorzLine.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenIngresoSAPResultado.Appearance.OddRow.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Preview.Options.UseFont = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenIngresoSAPResultado.Appearance.Row.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewOrdenIngresoSAPResultado.Appearance.RowSeparator.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewOrdenIngresoSAPResultado.Appearance.VertLine.Options.UseBackColor = true
        Me.grdviewOrdenIngresoSAPResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipo, Me.colNumeroSAP, Me.colCodigoArticulo, Me.colUnidades, Me.colOrigen, Me.colDestino})
        Me.grdviewOrdenIngresoSAPResultado.GridControl = Me.grdOrdenIngresoSAPResultado
        Me.grdviewOrdenIngresoSAPResultado.Name = "grdviewOrdenIngresoSAPResultado"
        Me.grdviewOrdenIngresoSAPResultado.OptionsView.EnableAppearanceEvenRow = true
        Me.grdviewOrdenIngresoSAPResultado.OptionsView.EnableAppearanceOddRow = true
        Me.grdviewOrdenIngresoSAPResultado.OptionsView.ShowGroupPanel = false
        Me.grdviewOrdenIngresoSAPResultado.PaintStyleName = "Web"
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = true
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = true
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.AllowEdit = false
        Me.colTipo.OptionsColumn.ReadOnly = true
        Me.colTipo.Visible = true
        Me.colTipo.VisibleIndex = 0
        '
        'colNumeroSAP
        '
        Me.colNumeroSAP.AppearanceCell.BackColor = System.Drawing.Color.RoyalBlue
        Me.colNumeroSAP.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroSAP.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colNumeroSAP.AppearanceCell.Options.UseBackColor = true
        Me.colNumeroSAP.AppearanceCell.Options.UseFont = true
        Me.colNumeroSAP.AppearanceCell.Options.UseForeColor = true
        Me.colNumeroSAP.AppearanceCell.Options.UseTextOptions = true
        Me.colNumeroSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroSAP.AppearanceHeader.Options.UseFont = true
        Me.colNumeroSAP.AppearanceHeader.Options.UseTextOptions = true
        Me.colNumeroSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroSAP.Caption = "# SAP"
        Me.colNumeroSAP.FieldName = "NumeroSAP"
        Me.colNumeroSAP.Name = "colNumeroSAP"
        Me.colNumeroSAP.OptionsColumn.AllowEdit = False
        Me.colNumeroSAP.Visible = True
        Me.colNumeroSAP.VisibleIndex = 1
        Me.colNumeroSAP.Width = 89
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 2
        Me.colCodigoArticulo.Width = 131
        '
        'colUnidades
        '
        Me.colUnidades.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidades.AppearanceHeader.Options.UseFont = True
        Me.colUnidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.OptionsColumn.AllowEdit = False
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 3
        Me.colUnidades.Width = 81
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.ColumnEdit = Me.rslueOrigen
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.OptionsColumn.AllowEdit = False
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 4
        Me.colOrigen.Width = 108
        '
        'rslueOrigen
        '
        Me.rslueOrigen.AutoHeight = False
        Me.rslueOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen.Name = "rslueOrigen"
        Me.rslueOrigen.NullText = ""
        Me.rslueOrigen.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDestino
        '
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.ColumnEdit = Me.rslueDestino
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.OptionsColumn.AllowEdit = False
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 5
        Me.colDestino.Width = 108
        '
        'rslueDestino
        '
        Me.rslueDestino.AutoHeight = false
        Me.rslueDestino.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestino.Name = "rslueDestino"
        Me.rslueDestino.NullText = ""
        Me.rslueDestino.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView1.OptionsView.ShowGroupPanel = false
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = false
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(639, 471)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = false
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = true
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.Control = Me.grdOrdenIngresoSAPResultado
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(619, 451)
        Me.LayoutControlItem1.Text = "ORDENES SUBIDAS A SAP"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(212, 19)
        '
        'DsIngresoOrden1BindingSource
        '
        Me.DsIngresoOrden1BindingSource.DataSource = Me.DsIngresoOrden1
        Me.DsIngresoOrden1BindingSource.Position = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnVistaPrevia, Me.barbtnExportarXlsx})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(639, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 518)
        Me.barDockControlBottom.Size = New System.Drawing.Size(639, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 471)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(639, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 471)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnVistaPrevia), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnExportarXlsx)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = false
        Me.Bar1.OptionsBar.DrawBorder = false
        Me.Bar1.OptionsBar.DrawDragBorder = false
        Me.Bar1.Text = "Tools"
        '
        'barbtnVistaPrevia
        '
        Me.barbtnVistaPrevia.Caption = "Vista Previa"
        Me.barbtnVistaPrevia.Glyph = CType(resources.GetObject("barbtnVistaPrevia.Glyph"),System.Drawing.Image)
        Me.barbtnVistaPrevia.Id = 0
        Me.barbtnVistaPrevia.Name = "barbtnVistaPrevia"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Caption = "Exportar Xlsx"
        Me.barbtnExportarXlsx.Glyph = CType(resources.GetObject("barbtnExportarXlsx.Glyph"),System.Drawing.Image)
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'frmResultadoOrdenesIngresadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 518)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximumSize = New System.Drawing.Size(655, 557)
        Me.MinimumSize = New System.Drawing.Size(655, 557)
        Me.Name = "frmResultadoOrdenesIngresadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.LayoutControl1.ResumeLayout(false)
        CType(Me.grdOrdenIngresoSAPResultado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsIngresoOrden1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdviewOrdenIngresoSAPResultado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.rslueOrigen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSearchLookUpEdit1View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.rslueDestino,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsIngresoOrden1BindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdOrdenIngresoSAPResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsIngresoOrden1 As waProduccion_Pedidos.dsIngresoOrden
    Friend WithEvents grdviewOrdenIngresoSAPResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsIngresoOrden1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rslueOrigen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueDestino As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
End Class
