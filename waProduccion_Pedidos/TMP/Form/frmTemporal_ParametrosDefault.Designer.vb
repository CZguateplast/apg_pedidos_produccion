<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_ParametrosDefault
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_ParametrosDefault))
        Me.lycParametrosDefault = New DevExpress.XtraLayout.LayoutControl()
        Me.slueTipo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnQuitar = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcControlesMovimiento = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdListaGrabada = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_ParametrosDefault1 = New waProduccion_Pedidos.dsTemporal_ParametrosDefault()
        Me.grdviewListaGrabada = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdListaDisponible = New DevExpress.XtraGrid.GridControl()
        Me.grdviewListaDisponible = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.barbtnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycParametrosDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametrosDefault.SuspendLayout()
        CType(Me.slueTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaGrabada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_ParametrosDefault1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaGrabada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametrosDefault
        '
        Me.lycParametrosDefault.Controls.Add(Me.slueTipo)
        Me.lycParametrosDefault.Controls.Add(Me.sbdcControlesMovimiento)
        Me.lycParametrosDefault.Controls.Add(Me.grdListaGrabada)
        Me.lycParametrosDefault.Controls.Add(Me.grdListaDisponible)
        Me.lycParametrosDefault.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametrosDefault.Location = New System.Drawing.Point(0, 29)
        Me.lycParametrosDefault.Name = "lycParametrosDefault"
        Me.lycParametrosDefault.Root = Me.LayoutControlGroup1
        Me.lycParametrosDefault.Size = New System.Drawing.Size(989, 443)
        Me.lycParametrosDefault.TabIndex = 0
        Me.lycParametrosDefault.Text = "LayoutControl1"
        '
        'slueTipo
        '
        Me.slueTipo.Location = New System.Drawing.Point(35, 12)
        Me.slueTipo.MenuManager = Me.BarManager1
        Me.slueTipo.Name = "slueTipo"
        Me.slueTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTipo.Properties.NullText = ""
        Me.slueTipo.Properties.View = Me.SearchLookUpEdit1View
        Me.slueTipo.Size = New System.Drawing.Size(942, 20)
        Me.slueTipo.StyleController = Me.lycParametrosDefault
        Me.slueTipo.TabIndex = 7
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcControlesMovimiento)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnQuitar})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnQuitar)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcControlesMovimiento
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Enabled = False
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnQuitar
        '
        Me.barbtnQuitar.Caption = "Quitar"
        Me.barbtnQuitar.Enabled = False
        Me.barbtnQuitar.Id = 1
        Me.barbtnQuitar.ImageOptions.Image = CType(resources.GetObject("barbtnQuitar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnQuitar.Name = "barbtnQuitar"
        '
        'sbdcControlesMovimiento
        '
        Me.sbdcControlesMovimiento.CausesValidation = False
        Me.sbdcControlesMovimiento.IsVertical = True
        Me.sbdcControlesMovimiento.Location = New System.Drawing.Point(465, 36)
        Me.sbdcControlesMovimiento.Manager = Me.BarManager1
        Me.sbdcControlesMovimiento.Name = "sbdcControlesMovimiento"
        Me.sbdcControlesMovimiento.Size = New System.Drawing.Size(51, 104)
        Me.sbdcControlesMovimiento.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(989, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 472)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(989, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 443)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(989, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 443)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grdListaGrabada
        '
        Me.grdListaGrabada.DataMember = "dsdtListaGrabada"
        Me.grdListaGrabada.DataSource = Me.DsTemporal_ParametrosDefault1
        Me.grdListaGrabada.Location = New System.Drawing.Point(520, 36)
        Me.grdListaGrabada.MainView = Me.grdviewListaGrabada
        Me.grdListaGrabada.Name = "grdListaGrabada"
        Me.grdListaGrabada.Size = New System.Drawing.Size(457, 395)
        Me.grdListaGrabada.TabIndex = 5
        Me.grdListaGrabada.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaGrabada})
        '
        'DsTemporal_ParametrosDefault1
        '
        Me.DsTemporal_ParametrosDefault1.DataSetName = "dsTemporal_ParametrosDefault"
        Me.DsTemporal_ParametrosDefault1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaGrabada
        '
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaGrabada.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaGrabada.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaGrabada.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaGrabada.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewListaGrabada.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaGrabada.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaGrabada.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewListaGrabada.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaGrabada.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colDescripcion1})
        Me.grdviewListaGrabada.GridControl = Me.grdListaGrabada
        Me.grdviewListaGrabada.Name = "grdviewListaGrabada"
        Me.grdviewListaGrabada.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaGrabada.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaGrabada.OptionsView.ShowFooter = True
        Me.grdviewListaGrabada.OptionsView.ShowGroupPanel = False
        Me.grdviewListaGrabada.PaintStyleName = "Web"
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.OptionsColumn.AllowEdit = False
        Me.colId1.OptionsColumn.ReadOnly = True
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 125
        '
        'colDescripcion1
        '
        Me.colDescripcion1.FieldName = "Descripcion"
        Me.colDescripcion1.Name = "colDescripcion1"
        Me.colDescripcion1.OptionsColumn.AllowEdit = False
        Me.colDescripcion1.OptionsColumn.ReadOnly = True
        Me.colDescripcion1.Visible = True
        Me.colDescripcion1.VisibleIndex = 1
        Me.colDescripcion1.Width = 252
        '
        'grdListaDisponible
        '
        Me.grdListaDisponible.DataMember = "dsdtListaDisponible"
        Me.grdListaDisponible.DataSource = Me.DsTemporal_ParametrosDefault1
        Me.grdListaDisponible.Location = New System.Drawing.Point(12, 36)
        Me.grdListaDisponible.MainView = Me.grdviewListaDisponible
        Me.grdListaDisponible.Name = "grdListaDisponible"
        Me.grdListaDisponible.Size = New System.Drawing.Size(449, 395)
        Me.grdListaDisponible.TabIndex = 4
        Me.grdListaDisponible.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaDisponible})
        '
        'grdviewListaDisponible
        '
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaDisponible.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaDisponible.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaDisponible.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewListaDisponible.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaDisponible.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaDisponible.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaDisponible.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaDisponible.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaDisponible.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDescripcion})
        Me.grdviewListaDisponible.GridControl = Me.grdListaDisponible
        Me.grdviewListaDisponible.Name = "grdviewListaDisponible"
        Me.grdviewListaDisponible.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaDisponible.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaDisponible.OptionsView.ShowFooter = True
        Me.grdviewListaDisponible.OptionsView.ShowGroupPanel = False
        Me.grdviewListaDisponible.PaintStyleName = "Web"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 125
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 251
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(989, 443)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdListaDisponible
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(453, 399)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdListaGrabada
        Me.LayoutControlItem2.Location = New System.Drawing.Point(508, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(461, 399)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcControlesMovimiento
        Me.LayoutControlItem3.Location = New System.Drawing.Point(453, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(55, 399)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.slueTipo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(969, 24)
        Me.LayoutControlItem4.Text = "Tipo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(20, 13)
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar5})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSalir})
        Me.BarManager2.MaxItemId = 2
        Me.BarManager2.StatusBar = Me.Bar5
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.Text = "Tools"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'barbtnSalir
        '
        Me.barbtnSalir.Caption = "Salir"
        Me.barbtnSalir.Id = 0
        Me.barbtnSalir.ImageOptions.Image = CType(resources.GetObject("barbtnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSalir.Name = "barbtnSalir"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(989, 29)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 472)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(989, 43)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 29)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 443)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(989, 29)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 443)
        '
        'frmTemporal_ParametrosDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 515)
        Me.Controls.Add(Me.lycParametrosDefault)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "frmTemporal_ParametrosDefault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_ParametrosDefault"
        CType(Me.lycParametrosDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametrosDefault.ResumeLayout(False)
        CType(Me.slueTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaGrabada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_ParametrosDefault1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaGrabada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametrosDefault As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents sbdcControlesMovimiento As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnQuitar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdListaGrabada As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaGrabada As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdListaDisponible As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaDisponible As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents slueTipo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents barbtnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTemporal_ParametrosDefault1 As waProduccion_Pedidos.dsTemporal_ParametrosDefault
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
