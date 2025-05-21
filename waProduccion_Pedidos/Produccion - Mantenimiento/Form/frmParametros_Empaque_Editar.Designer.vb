<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros_Empaque_Editar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros_Empaque_Editar))
        Me.lycParametros_Empaque_Editar = New DevExpress.XtraLayout.LayoutControl()
        Me.spinPersonasXEquipo = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barParametrosEmpaque = New DevExpress.XtraBars.Bar()
        Me.bar3_Empaque = New DevExpress.XtraBars.Bar()
        Me.barbtnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtNumEmpaque = New DevExpress.XtraEditors.TextEdit()
        Me.memoComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.grdEmpaque = New DevExpress.XtraGrid.GridControl()
        Me.DsParametros_Empaque_Editar1 = New waProduccion_Pedidos.dsParametros_Empaque_Editar()
        Me.grdviewEmpaque = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinUnidades = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueUM = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUEmpaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        CType(Me.lycParametros_Empaque_Editar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametros_Empaque_Editar.SuspendLayout()
        CType(Me.spinPersonasXEquipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumEmpaque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Empaque_Editar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametros_Empaque_Editar
        '
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.spinPersonasXEquipo)
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.txtNumEmpaque)
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.memoComentarios)
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.grdEmpaque)
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.txtNombre)
        Me.lycParametros_Empaque_Editar.Controls.Add(Me.txtCodigo)
        Me.lycParametros_Empaque_Editar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametros_Empaque_Editar.Location = New System.Drawing.Point(0, 31)
        Me.lycParametros_Empaque_Editar.Margin = New System.Windows.Forms.Padding(4)
        Me.lycParametros_Empaque_Editar.Name = "lycParametros_Empaque_Editar"
        Me.lycParametros_Empaque_Editar.Root = Me.LayoutControlGroup1
        Me.lycParametros_Empaque_Editar.Size = New System.Drawing.Size(1280, 413)
        Me.lycParametros_Empaque_Editar.TabIndex = 0
        Me.lycParametros_Empaque_Editar.Text = "LayoutControl1"
        '
        'spinPersonasXEquipo
        '
        Me.spinPersonasXEquipo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPersonasXEquipo.Location = New System.Drawing.Point(1172, 291)
        Me.spinPersonasXEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.spinPersonasXEquipo.MenuManager = Me.BarManager1
        Me.spinPersonasXEquipo.Name = "spinPersonasXEquipo"
        Me.spinPersonasXEquipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPersonasXEquipo.Size = New System.Drawing.Size(92, 22)
        Me.spinPersonasXEquipo.StyleController = Me.lycParametros_Empaque_Editar
        Me.spinPersonasXEquipo.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barParametrosEmpaque, Me.bar3_Empaque})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnGuardar, Me.barbtnCerrar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.bar3_Empaque
        '
        'barParametrosEmpaque
        '
        Me.barParametrosEmpaque.BarName = "Tools"
        Me.barParametrosEmpaque.DockCol = 0
        Me.barParametrosEmpaque.DockRow = 0
        Me.barParametrosEmpaque.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barParametrosEmpaque.OptionsBar.AllowQuickCustomization = False
        Me.barParametrosEmpaque.OptionsBar.DisableCustomization = True
        Me.barParametrosEmpaque.OptionsBar.DrawBorder = False
        Me.barParametrosEmpaque.Text = "Tools"
        '
        'bar3_Empaque
        '
        Me.bar3_Empaque.BarName = "Status bar"
        Me.bar3_Empaque.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3_Empaque.DockCol = 0
        Me.bar3_Empaque.DockRow = 0
        Me.bar3_Empaque.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3_Empaque.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGuardar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.bar3_Empaque.OptionsBar.AllowQuickCustomization = False
        Me.bar3_Empaque.OptionsBar.DrawDragBorder = False
        Me.bar3_Empaque.OptionsBar.UseWholeRow = True
        Me.bar3_Empaque.Text = "Status bar"
        '
        'barbtnGuardar
        '
        Me.barbtnGuardar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnGuardar.Caption = "Guardar"
        Me.barbtnGuardar.Id = 0
        Me.barbtnGuardar.ImageOptions.Image = CType(resources.GetObject("barbtnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGuardar.Name = "barbtnGuardar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 1
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnCerrar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1280, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 444)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1280, 55)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 413)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1280, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 413)
        '
        'txtNumEmpaque
        '
        Me.txtNumEmpaque.Enabled = False
        Me.txtNumEmpaque.Location = New System.Drawing.Point(1172, 16)
        Me.txtNumEmpaque.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumEmpaque.MenuManager = Me.BarManager1
        Me.txtNumEmpaque.Name = "txtNumEmpaque"
        Me.txtNumEmpaque.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNumEmpaque.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumEmpaque.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumEmpaque.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumEmpaque.Size = New System.Drawing.Size(92, 22)
        Me.txtNumEmpaque.StyleController = Me.lycParametros_Empaque_Editar
        Me.txtNumEmpaque.TabIndex = 8
        Me.txtNumEmpaque.TabStop = False
        '
        'memoComentarios
        '
        Me.memoComentarios.Location = New System.Drawing.Point(136, 291)
        Me.memoComentarios.Margin = New System.Windows.Forms.Padding(4)
        Me.memoComentarios.MenuManager = Me.BarManager1
        Me.memoComentarios.Name = "memoComentarios"
        Me.memoComentarios.Size = New System.Drawing.Size(910, 106)
        Me.memoComentarios.StyleController = Me.lycParametros_Empaque_Editar
        Me.memoComentarios.TabIndex = 7
        '
        'grdEmpaque
        '
        Me.grdEmpaque.DataMember = "dsdtEmpaque"
        Me.grdEmpaque.DataSource = Me.DsParametros_Empaque_Editar1
        Me.grdEmpaque.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmpaque.Location = New System.Drawing.Point(16, 44)
        Me.grdEmpaque.MainView = Me.grdviewEmpaque
        Me.grdEmpaque.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmpaque.MenuManager = Me.BarManager1
        Me.grdEmpaque.Name = "grdEmpaque"
        Me.grdEmpaque.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueCodigo, Me.rspinUnidades, Me.rslueUM})
        Me.grdEmpaque.Size = New System.Drawing.Size(1248, 241)
        Me.grdEmpaque.TabIndex = 6
        Me.grdEmpaque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEmpaque})
        '
        'DsParametros_Empaque_Editar1
        '
        Me.DsParametros_Empaque_Editar1.DataSetName = "dsParametros_Empaque_Editar"
        Me.DsParametros_Empaque_Editar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewEmpaque
        '
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewEmpaque.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewEmpaque.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewEmpaque.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewEmpaque.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewEmpaque.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewEmpaque.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewEmpaque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewEmpaque.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewEmpaque.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEmpaque.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewEmpaque.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewEmpaque.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewEmpaque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewEmpaque.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewEmpaque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewEmpaque.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEmpaque.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewEmpaque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewEmpaque.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewEmpaque.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewEmpaque.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewEmpaque.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewEmpaque.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewEmpaque.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewEmpaque.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.Preview.Options.UseFont = True
        Me.grdviewEmpaque.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewEmpaque.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewEmpaque.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEmpaque.ColumnPanelRowHeight = 35
        Me.grdviewEmpaque.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colId_Empaque, Me.colLinea, Me.colCodigo, Me.colNombreCodigo, Me.colCantidad, Me.colUM, Me.colUEmpaque, Me.colComentarios})
        Me.grdviewEmpaque.GridControl = Me.grdEmpaque
        Me.grdviewEmpaque.Name = "grdviewEmpaque"
        Me.grdviewEmpaque.OptionsBehavior.FocusLeaveOnTab = True
        Me.grdviewEmpaque.OptionsCustomization.AllowSort = False
        Me.grdviewEmpaque.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEmpaque.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEmpaque.OptionsView.ShowGroupPanel = False
        Me.grdviewEmpaque.PaintStyleName = "Web"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colId_Empaque
        '
        Me.colId_Empaque.FieldName = "Id_Empaque"
        Me.colId_Empaque.Name = "colId_Empaque"
        Me.colId_Empaque.Width = 86
        '
        'colLinea
        '
        Me.colLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLinea.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLinea.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLinea.FieldName = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.OptionsColumn.AllowEdit = False
        Me.colLinea.OptionsColumn.AllowFocus = False
        Me.colLinea.OptionsColumn.AllowSize = False
        Me.colLinea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLinea.OptionsColumn.ReadOnly = True
        Me.colLinea.Visible = True
        Me.colLinea.VisibleIndex = 0
        Me.colLinea.Width = 49
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.ColumnEdit = Me.rslueCodigo
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 122
        '
        'rslueCodigo
        '
        Me.rslueCodigo.AutoHeight = False
        Me.rslueCodigo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigo.Name = "rslueCodigo"
        Me.rslueCodigo.NullText = ""
        Me.rslueCodigo.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colNombreCodigo
        '
        Me.colNombreCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNombreCodigo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreCodigo.FieldName = "NombreCodigo"
        Me.colNombreCodigo.Name = "colNombreCodigo"
        Me.colNombreCodigo.OptionsColumn.AllowEdit = False
        Me.colNombreCodigo.OptionsColumn.AllowFocus = False
        Me.colNombreCodigo.OptionsColumn.TabStop = False
        Me.colNombreCodigo.Visible = True
        Me.colNombreCodigo.VisibleIndex = 2
        Me.colNombreCodigo.Width = 473
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCantidad.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.rspinUnidades
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 94
        '
        'rspinUnidades
        '
        Me.rspinUnidades.AutoHeight = False
        Me.rspinUnidades.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinUnidades.Name = "rspinUnidades"
        '
        'colUM
        '
        Me.colUM.AppearanceHeader.Options.UseTextOptions = True
        Me.colUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUM.Caption = "U/M"
        Me.colUM.ColumnEdit = Me.rslueUM
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 4
        Me.colUM.Width = 45
        '
        'rslueUM
        '
        Me.rslueUM.AutoHeight = False
        Me.rslueUM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueUM.Name = "rslueUM"
        Me.rslueUM.NullText = ""
        Me.rslueUM.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colUEmpaque
        '
        Me.colUEmpaque.AppearanceHeader.Options.UseTextOptions = True
        Me.colUEmpaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUEmpaque.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUEmpaque.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUEmpaque.Caption = "Unidades X Empaque"
        Me.colUEmpaque.ColumnEdit = Me.rspinUnidades
        Me.colUEmpaque.FieldName = "UEmpaque"
        Me.colUEmpaque.Name = "colUEmpaque"
        Me.colUEmpaque.Visible = True
        Me.colUEmpaque.VisibleIndex = 5
        Me.colUEmpaque.Width = 107
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Width = 86
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(432, 16)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombre.Size = New System.Drawing.Size(614, 22)
        Me.txtNombre.StyleController = Me.lycParametros_Empaque_Editar
        Me.txtNombre.TabIndex = 5
        Me.txtNombre.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(136, 16)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodigo.Size = New System.Drawing.Size(170, 22)
        Me.txtCodigo.StyleController = Me.lycParametros_Empaque_Editar
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.TabStop = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1280, 413)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(296, 28)
        Me.LayoutControlItem1.Text = "Codigo"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(117, 17)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.Location = New System.Drawing.Point(296, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(740, 28)
        Me.LayoutControlItem2.Text = "Nombre"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(117, 17)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.grdEmpaque
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1254, 247)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.memoComentarios
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 275)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1036, 112)
        Me.LayoutControlItem4.Text = "Comentarios"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(117, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtNumEmpaque
        Me.LayoutControlItem5.Location = New System.Drawing.Point(1036, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(218, 28)
        Me.LayoutControlItem5.Text = "# Empaque"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(117, 17)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.spinPersonasXEquipo
        Me.LayoutControlItem6.Location = New System.Drawing.Point(1036, 275)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(218, 28)
        Me.LayoutControlItem6.Text = "Personas por Equipo"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(117, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1036, 303)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(218, 84)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'frmParametros_Empaque_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 499)
        Me.Controls.Add(Me.lycParametros_Empaque_Editar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmParametros_Empaque_Editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmParametros_Empaque_Editar"
        CType(Me.lycParametros_Empaque_Editar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametros_Empaque_Editar.ResumeLayout(False)
        CType(Me.spinPersonasXEquipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumEmpaque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Empaque_Editar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametros_Empaque_Editar As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdEmpaque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEmpaque As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barParametrosEmpaque As DevExpress.XtraBars.Bar
    Friend WithEvents bar3_Empaque As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents memoComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents barbtnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Empaque_Editar1 As waProduccion_Pedidos.dsParametros_Empaque_Editar
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEmpaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNumEmpaque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rslueCodigo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rspinUnidades As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents spinPersonasXEquipo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rslueUM As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
