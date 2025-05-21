<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenLista))
        Me.lycOrdenLista = New DevExpress.XtraLayout.LayoutControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.dteFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barReportes = New DevExpress.XtraBars.BarSubItem()
        Me.barbtnResumenPedidos = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenLiberar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAyuda = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dteFechaInicial = New DevExpress.XtraEditors.DateEdit()
        Me.spinNumSAP = New DevExpress.XtraEditors.SpinEdit()
        Me.rdgTipoBusqueda = New DevExpress.XtraEditors.RadioGroup()
        Me.rdgTipoOrden = New DevExpress.XtraEditors.RadioGroup()
        Me.grdOrdenLista = New DevExpress.XtraGrid.GridControl()
        Me.DsOrdenLista1 = New waProduccion_Pedidos.dsOrdenLista()
        Me.grdviewOrdenLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreación = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasAtrasado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycgOrdenLista = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.colUltimoRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuarioAPG = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.lycOrdenLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenLista.SuspendLayout()
        CType(Me.dteFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinNumSAP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdenLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenLista1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewOrdenLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycgOrdenLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycOrdenLista
        '
        Me.lycOrdenLista.Controls.Add(Me.btnGenerar)
        Me.lycOrdenLista.Controls.Add(Me.dteFechaFinal)
        Me.lycOrdenLista.Controls.Add(Me.dteFechaInicial)
        Me.lycOrdenLista.Controls.Add(Me.spinNumSAP)
        Me.lycOrdenLista.Controls.Add(Me.rdgTipoBusqueda)
        Me.lycOrdenLista.Controls.Add(Me.rdgTipoOrden)
        Me.lycOrdenLista.Controls.Add(Me.grdOrdenLista)
        Me.lycOrdenLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenLista.Location = New System.Drawing.Point(0, 0)
        Me.lycOrdenLista.Name = "lycOrdenLista"
        Me.lycOrdenLista.Root = Me.lycgOrdenLista
        Me.lycOrdenLista.Size = New System.Drawing.Size(1428, 698)
        Me.lycOrdenLista.TabIndex = 0
        Me.lycOrdenLista.Text = "LayoutControl1"
        '
        'btnGenerar
        '
        Me.btnGenerar.ImageOptions.Image = CType(resources.GetObject("btnGenerar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGenerar.Location = New System.Drawing.Point(1064, 12)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(99, 22)
        Me.btnGenerar.StyleController = Me.lycOrdenLista
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.EditValue = Nothing
        Me.dteFechaFinal.Enabled = False
        Me.dteFechaFinal.Location = New System.Drawing.Point(960, 12)
        Me.dteFechaFinal.MaximumSize = New System.Drawing.Size(100, 0)
        Me.dteFechaFinal.MenuManager = Me.BarManager1
        Me.dteFechaFinal.MinimumSize = New System.Drawing.Size(100, 0)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinal.Size = New System.Drawing.Size(100, 20)
        Me.dteFechaFinal.StyleController = Me.lycOrdenLista
        Me.dteFechaFinal.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnOrdenCerrar, Me.barbtnImprimirGrid, Me.barbtnOrdenLiberar, Me.barbtnExportarXlsx, Me.barbtnBuscar, Me.barReportes, Me.barbtnResumenPedidos, Me.barbtnAyuda})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barReportes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenLiberar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAyuda), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barReportes
        '
        Me.barReportes.Caption = "Reportes"
        Me.barReportes.Id = 6
        Me.barReportes.ImageOptions.Image = CType(resources.GetObject("barReportes.ImageOptions.Image"), System.Drawing.Image)
        Me.barReportes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnResumenPedidos)})
        Me.barReportes.Name = "barReportes"
        '
        'barbtnResumenPedidos
        '
        Me.barbtnResumenPedidos.Caption = "Resumen de Pedidos"
        Me.barbtnResumenPedidos.Id = 7
        Me.barbtnResumenPedidos.ImageOptions.Image = CType(resources.GetObject("barbtnResumenPedidos.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnResumenPedidos.ImageOptions.LargeImage = CType(resources.GetObject("barbtnResumenPedidos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnResumenPedidos.Name = "barbtnResumenPedidos"
        '
        'barbtnOrdenLiberar
        '
        Me.barbtnOrdenLiberar.Caption = "Liberar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnOrdenLiberar.Id = 3
        Me.barbtnOrdenLiberar.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenLiberar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenLiberar.Name = "barbtnOrdenLiberar"
        '
        'barbtnOrdenCerrar
        '
        Me.barbtnOrdenCerrar.Caption = "Cerrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnOrdenCerrar.Id = 1
        Me.barbtnOrdenCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenCerrar.Name = "barbtnOrdenCerrar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 5
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir Grid"
        Me.barbtnImprimirGrid.Id = 2
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Caption = "Exportar"
        Me.barbtnExportarXlsx.Id = 4
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnAyuda
        '
        Me.barbtnAyuda.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAyuda.Caption = "Ayuda"
        Me.barbtnAyuda.Id = 8
        Me.barbtnAyuda.ImageOptions.Image = CType(resources.GetObject("barbtnAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAyuda.Name = "barbtnAyuda"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1428, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 698)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1428, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 698)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1428, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 698)
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.EditValue = Nothing
        Me.dteFechaInicial.Enabled = False
        Me.dteFechaInicial.Location = New System.Drawing.Point(800, 12)
        Me.dteFechaInicial.MaximumSize = New System.Drawing.Size(100, 0)
        Me.dteFechaInicial.MenuManager = Me.BarManager1
        Me.dteFechaInicial.MinimumSize = New System.Drawing.Size(100, 0)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaInicial.Size = New System.Drawing.Size(100, 20)
        Me.dteFechaInicial.StyleController = Me.lycOrdenLista
        Me.dteFechaInicial.TabIndex = 8
        '
        'spinNumSAP
        '
        Me.spinNumSAP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinNumSAP.Enabled = False
        Me.spinNumSAP.Location = New System.Drawing.Point(650, 12)
        Me.spinNumSAP.MaximumSize = New System.Drawing.Size(90, 0)
        Me.spinNumSAP.MenuManager = Me.BarManager1
        Me.spinNumSAP.MinimumSize = New System.Drawing.Size(90, 0)
        Me.spinNumSAP.Name = "spinNumSAP"
        Me.spinNumSAP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinNumSAP.Size = New System.Drawing.Size(90, 20)
        Me.spinNumSAP.StyleController = Me.lycOrdenLista
        Me.spinNumSAP.TabIndex = 7
        '
        'rdgTipoBusqueda
        '
        Me.rdgTipoBusqueda.EditValue = "Todos"
        Me.rdgTipoBusqueda.Location = New System.Drawing.Point(325, 12)
        Me.rdgTipoBusqueda.MenuManager = Me.BarManager1
        Me.rdgTipoBusqueda.Name = "rdgTipoBusqueda"
        Me.rdgTipoBusqueda.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Todos", "Todos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("SAP", "Num Orden"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Fecha", "Fecha")})
        Me.rdgTipoBusqueda.Size = New System.Drawing.Size(265, 25)
        Me.rdgTipoBusqueda.StyleController = Me.lycOrdenLista
        Me.rdgTipoBusqueda.TabIndex = 6
        '
        'rdgTipoOrden
        '
        Me.rdgTipoOrden.EditValue = "AR"
        Me.rdgTipoOrden.Location = New System.Drawing.Point(68, 12)
        Me.rdgTipoOrden.MenuManager = Me.BarManager1
        Me.rdgTipoOrden.Name = "rdgTipoOrden"
        Me.rdgTipoOrden.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("AR", "AR"), New DevExpress.XtraEditors.Controls.RadioGroupItem("CP", "CP"), New DevExpress.XtraEditors.Controls.RadioGroupItem("MP", "MP")})
        Me.rdgTipoOrden.Size = New System.Drawing.Size(197, 25)
        Me.rdgTipoOrden.StyleController = Me.lycOrdenLista
        Me.rdgTipoOrden.TabIndex = 5
        '
        'grdOrdenLista
        '
        Me.grdOrdenLista.DataMember = "dsdtCerrarAR"
        Me.grdOrdenLista.DataSource = Me.DsOrdenLista1
        Me.grdOrdenLista.Location = New System.Drawing.Point(12, 41)
        Me.grdOrdenLista.MainView = Me.grdviewOrdenLista
        Me.grdOrdenLista.MenuManager = Me.BarManager1
        Me.grdOrdenLista.Name = "grdOrdenLista"
        Me.grdOrdenLista.Size = New System.Drawing.Size(1404, 645)
        Me.grdOrdenLista.TabIndex = 4
        Me.grdOrdenLista.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenLista})
        '
        'DsOrdenLista1
        '
        Me.DsOrdenLista1.DataSetName = "dsOrdenLista"
        Me.DsOrdenLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenLista
        '
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenLista.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenLista.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.grdviewOrdenLista.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdviewOrdenLista.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenLista.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewOrdenLista.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenLista.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewOrdenLista.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.Preview.Options.UseFont = True
        Me.grdviewOrdenLista.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenLista.Appearance.Row.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.Row.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewOrdenLista.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenLista.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewOrdenLista.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewOrdenLista.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewOrdenLista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colOrigen, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado, Me.colUltimoRecibo, Me.colComentarios, Me.colUsuarioAPG})
        Me.grdviewOrdenLista.GridControl = Me.grdOrdenLista
        Me.grdviewOrdenLista.Name = "grdviewOrdenLista"
        Me.grdviewOrdenLista.OptionsBehavior.Editable = False
        Me.grdviewOrdenLista.OptionsBehavior.ReadOnly = True
        Me.grdviewOrdenLista.OptionsSelection.MultiSelect = True
        Me.grdviewOrdenLista.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewOrdenLista.OptionsView.ColumnAutoWidth = False
        Me.grdviewOrdenLista.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewOrdenLista.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewOrdenLista.OptionsView.ShowFooter = True
        Me.grdviewOrdenLista.OptionsView.ShowGroupPanel = False
        Me.grdviewOrdenLista.PaintStyleName = "Flat"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 1
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 2
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 3
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.OptionsColumn.ReadOnly = True
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 4
        Me.colOrigen.Width = 90
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 5
        Me.colCodigoArticulo.Width = 125
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 6
        Me.colNombreArticulo.Width = 408
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 7
        Me.colPlaneado.Width = 80
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 8
        Me.colCompletado.Width = 80
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 9
        Me.colPendiente.Width = 80
        '
        'colCreación
        '
        Me.colCreación.AppearanceCell.Options.UseTextOptions = True
        Me.colCreación.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreación.AppearanceHeader.Options.UseFont = True
        Me.colCreación.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreación.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.FieldName = "Creación"
        Me.colCreación.Name = "colCreación"
        Me.colCreación.OptionsColumn.ReadOnly = True
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 10
        '
        'colVencimiento
        '
        Me.colVencimiento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimiento.AppearanceHeader.Options.UseFont = True
        Me.colVencimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.Caption = "Vence"
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.OptionsColumn.ReadOnly = True
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 11
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiasAtrasado.AppearanceHeader.Options.UseFont = True
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.Caption = "Dias Atraso"
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.OptionsColumn.ReadOnly = True
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 13
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 15
        Me.colComentarios.Width = 281
        '
        'lycgOrdenLista
        '
        Me.lycgOrdenLista.CustomizationFormText = "lycgOrdenLista"
        Me.lycgOrdenLista.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycgOrdenLista.GroupBordersVisible = False
        Me.lycgOrdenLista.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem7})
        Me.lycgOrdenLista.Location = New System.Drawing.Point(0, 0)
        Me.lycgOrdenLista.Name = "lycgOrdenLista"
        Me.lycgOrdenLista.Size = New System.Drawing.Size(1428, 698)
        Me.lycgOrdenLista.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOrdenLista
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1408, 649)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(1155, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(253, 29)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.rdgTipoOrden
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(257, 29)
        Me.LayoutControlItem2.Text = "Tipo Orden"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.rdgTipoBusqueda
        Me.LayoutControlItem4.Location = New System.Drawing.Point(257, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(325, 29)
        Me.LayoutControlItem4.Text = "Filtrar por:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem5.Control = Me.spinNumSAP
        Me.LayoutControlItem5.Location = New System.Drawing.Point(582, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(150, 29)
        Me.LayoutControlItem5.Text = "Mayor A"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.dteFechaInicial
        Me.LayoutControlItem6.Location = New System.Drawing.Point(732, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(160, 29)
        Me.LayoutControlItem6.Text = "Fecha Del"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnGenerar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(1052, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(103, 29)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.dteFechaFinal
        Me.LayoutControlItem7.Location = New System.Drawing.Point(892, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(160, 29)
        Me.LayoutControlItem7.Text = "Al"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(53, 13)
        '
        'colUltimoRecibo
        '
        Me.colUltimoRecibo.Caption = "UltimoRecibo"
        Me.colUltimoRecibo.FieldName = "UltimoRecibo"
        Me.colUltimoRecibo.Name = "colUltimoRecibo"
        Me.colUltimoRecibo.Visible = True
        Me.colUltimoRecibo.VisibleIndex = 12
        '
        'colUsuarioAPG
        '
        Me.colUsuarioAPG.Caption = "UsuarioAPG"
        Me.colUsuarioAPG.FieldName = "UsuarioAPG"
        Me.colUsuarioAPG.Name = "colUsuarioAPG"
        Me.colUsuarioAPG.Visible = True
        Me.colUsuarioAPG.VisibleIndex = 14
        '
        'frmOrdenLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycOrdenLista)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOrdenLista"
        Me.Text = "frmOrdenLista"
        CType(Me.lycOrdenLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycOrdenLista.ResumeLayout(False)
        CType(Me.dteFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinNumSAP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdenLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOrdenLista1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewOrdenLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycgOrdenLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycOrdenLista As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lycgOrdenLista As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnOrdenCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdOrdenLista As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewOrdenLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsOrdenLista1 As waProduccion_Pedidos.dsOrdenLista
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasAtrasado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnOrdenLiberar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents dteFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents spinNumSAP As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents rdgTipoBusqueda As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdgTipoOrden As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barReportes As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barbtnResumenPedidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAyuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colUltimoRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuarioAPG As DevExpress.XtraGrid.Columns.GridColumn
End Class
