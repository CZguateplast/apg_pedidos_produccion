<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_Prioridades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_Prioridades))
        Me.lycPrioridad = New DevExpress.XtraLayout.LayoutControl()
        Me.grdPrioridades = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_Prioridades1 = New waProduccion_Pedidos.dsTemporal_Prioridades()
        Me.grdviewPrioridades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinPrioridad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barmPrioridad = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barPrioridad = New DevExpress.XtraBars.Bar()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.spinPrioridad = New DevExpress.XtraEditors.SpinEdit()
        Me.lycgPrioridades = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.lycPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycPrioridad.SuspendLayout()
        CType(Me.grdPrioridades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_Prioridades1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewPrioridades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barmPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrioridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycgPrioridades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycPrioridad
        '
        Me.lycPrioridad.Controls.Add(Me.grdPrioridades)
        Me.lycPrioridad.Controls.Add(Me.spinPrioridad)
        Me.lycPrioridad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycPrioridad.Location = New System.Drawing.Point(0, 0)
        Me.lycPrioridad.Name = "lycPrioridad"
        Me.lycPrioridad.Root = Me.lycgPrioridades
        Me.lycPrioridad.Size = New System.Drawing.Size(750, 421)
        Me.lycPrioridad.TabIndex = 0
        Me.lycPrioridad.Text = "LayoutControl1"
        '
        'grdPrioridades
        '
        Me.grdPrioridades.DataMember = "dsdtPrioridad"
        Me.grdPrioridades.DataSource = Me.DsTemporal_Prioridades1
        Me.grdPrioridades.Location = New System.Drawing.Point(12, 36)
        Me.grdPrioridades.MainView = Me.grdviewPrioridades
        Me.grdPrioridades.MenuManager = Me.barmPrioridad
        Me.grdPrioridades.Name = "grdPrioridades"
        Me.grdPrioridades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rspinPrioridad})
        Me.grdPrioridades.Size = New System.Drawing.Size(726, 373)
        Me.grdPrioridades.TabIndex = 5
        Me.grdPrioridades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewPrioridades})
        '
        'DsTemporal_Prioridades1
        '
        Me.DsTemporal_Prioridades1.DataSetName = "dsTemporal_Prioridades"
        Me.DsTemporal_Prioridades1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewPrioridades
        '
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewPrioridades.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewPrioridades.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewPrioridades.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPrioridades.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewPrioridades.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewPrioridades.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewPrioridades.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewPrioridades.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewPrioridades.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPrioridades.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewPrioridades.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewPrioridades.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewPrioridades.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewPrioridades.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewPrioridades.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewPrioridades.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPrioridades.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewPrioridades.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPrioridades.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewPrioridades.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewPrioridades.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewPrioridades.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewPrioridades.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewPrioridades.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewPrioridades.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewPrioridades.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewPrioridades.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewPrioridades.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewPrioridades.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewPrioridades.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewPrioridades.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewPrioridades.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewPrioridades.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewPrioridades.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewPrioridades.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.Preview.Options.UseFont = True
        Me.grdviewPrioridades.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewPrioridades.Appearance.Row.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewPrioridades.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewPrioridades.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewPrioridades.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewPrioridades.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad, Me.colNumSAP, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente})
        Me.grdviewPrioridades.GridControl = Me.grdPrioridades
        Me.grdviewPrioridades.Name = "grdviewPrioridades"
        Me.grdviewPrioridades.OptionsView.ColumnAutoWidth = False
        Me.grdviewPrioridades.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewPrioridades.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewPrioridades.OptionsView.ShowGroupPanel = False
        Me.grdviewPrioridades.PaintStyleName = "Web"
        '
        'colPrioridad
        '
        Me.colPrioridad.ColumnEdit = Me.rspinPrioridad
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 65
        '
        'rspinPrioridad
        '
        Me.rspinPrioridad.AutoHeight = False
        Me.rspinPrioridad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPrioridad.DisplayFormat.FormatString = "{0:n0}"
        Me.rspinPrioridad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridad.EditFormat.FormatString = "{0:n0}"
        Me.rspinPrioridad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrioridad.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.rspinPrioridad.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.rspinPrioridad.Name = "rspinPrioridad"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 1
        Me.colNumSAP.Width = 70
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 2
        Me.colCodigoArticulo.Width = 101
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.AllowFocus = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 3
        Me.colNombreArticulo.Width = 250
        '
        'colPlaneado
        '
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowEdit = False
        Me.colPlaneado.OptionsColumn.AllowFocus = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 4
        Me.colPlaneado.Width = 70
        '
        'colCompletado
        '
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowEdit = False
        Me.colCompletado.OptionsColumn.AllowFocus = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 5
        Me.colCompletado.Width = 70
        '
        'colPendiente
        '
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowEdit = False
        Me.colPendiente.OptionsColumn.AllowFocus = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 6
        Me.colPendiente.Width = 70
        '
        'barmPrioridad
        '
        Me.barmPrioridad.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barPrioridad})
        Me.barmPrioridad.DockControls.Add(Me.barDockControlTop)
        Me.barmPrioridad.DockControls.Add(Me.barDockControlBottom)
        Me.barmPrioridad.DockControls.Add(Me.barDockControlLeft)
        Me.barmPrioridad.DockControls.Add(Me.barDockControlRight)
        Me.barmPrioridad.Form = Me
        Me.barmPrioridad.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnSAP})
        Me.barmPrioridad.MaxItemId = 2
        Me.barmPrioridad.StatusBar = Me.barPrioridad
        '
        'barPrioridad
        '
        Me.barPrioridad.BarName = "Status bar"
        Me.barPrioridad.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barPrioridad.DockCol = 0
        Me.barPrioridad.DockRow = 0
        Me.barPrioridad.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barPrioridad.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSAP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barPrioridad.OptionsBar.AllowQuickCustomization = False
        Me.barPrioridad.OptionsBar.DrawDragBorder = False
        Me.barPrioridad.OptionsBar.UseWholeRow = True
        Me.barPrioridad.Text = "Status bar"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Caption = "SAP"
        Me.barbtnSAP.Glyph = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Id = 1
        Me.barbtnSAP.Name = "barbtnSAP"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(750, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 421)
        Me.barDockControlBottom.Size = New System.Drawing.Size(750, 44)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(750, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
        '
        'spinPrioridad
        '
        Me.spinPrioridad.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinPrioridad.Location = New System.Drawing.Point(117, 12)
        Me.spinPrioridad.MenuManager = Me.barmPrioridad
        Me.spinPrioridad.Name = "spinPrioridad"
        Me.spinPrioridad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrioridad.Properties.DisplayFormat.FormatString = "{0:n0}"
        Me.spinPrioridad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPrioridad.Properties.EditFormat.FormatString = "{0:n0}"
        Me.spinPrioridad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPrioridad.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.spinPrioridad.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinPrioridad.Size = New System.Drawing.Size(54, 20)
        Me.spinPrioridad.StyleController = Me.lycPrioridad
        Me.spinPrioridad.TabIndex = 4
        '
        'lycgPrioridades
        '
        Me.lycgPrioridades.CustomizationFormText = "LayoutControlGroup1"
        Me.lycgPrioridades.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycgPrioridades.GroupBordersVisible = False
        Me.lycgPrioridades.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.lycgPrioridades.Location = New System.Drawing.Point(0, 0)
        Me.lycgPrioridades.Name = "lycgPrioridades"
        Me.lycgPrioridades.Size = New System.Drawing.Size(750, 421)
        Me.lycgPrioridades.Text = "lycgPrioridades"
        Me.lycgPrioridades.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.spinPrioridad
        Me.LayoutControlItem1.CustomizationFormText = "Prioridad para Aplicar"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem1.Text = "Prioridad para Aplicar"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(102, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(163, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(567, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdPrioridades
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(730, 377)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmTemporal_Prioridades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycPrioridad)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(750, 465)
        Me.MinimumSize = New System.Drawing.Size(750, 465)
        Me.Name = "frmTemporal_Prioridades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrioridades"
        CType(Me.lycPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycPrioridad.ResumeLayout(False)
        CType(Me.grdPrioridades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_Prioridades1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewPrioridades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barmPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrioridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycgPrioridades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lycPrioridad As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lycgPrioridades As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdPrioridades As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewPrioridades As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barmPrioridad As DevExpress.XtraBars.BarManager
    Friend WithEvents barPrioridad As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents spinPrioridad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_Prioridades1 As waProduccion_Pedidos.dsTemporal_Prioridades
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rspinPrioridad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
