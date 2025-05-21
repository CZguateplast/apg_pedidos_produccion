<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPreciosActualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaPreciosActualizar))
        Me.lycListaPrecios = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.sbdcListapreciosActualizar = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.rslueListaPrecios = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.rsluevListaPrecios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnMonedaAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.slueMonedaAplicar = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.spinPrecioLista = New DevExpress.XtraEditors.SpinEdit()
        Me.btnPrecioAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArticulosTodos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArticulosConPrecio = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArticulosPrecioCero = New DevExpress.XtraEditors.SimpleButton()
        Me.memoListaPreciosDeNombre = New DevExpress.XtraEditors.MemoEdit()
        Me.memoListaPreciosParaNombre = New DevExpress.XtraEditors.MemoEdit()
        Me.slueListaPreciosPara = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueListaPreciosDe = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueGrupoArticulo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueCodigoArticulo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdListaPrecios = New DevExpress.XtraGrid.GridControl()
        Me.DsListaPreciosActualizar1 = New waProduccion_Pedidos.dsListaPreciosActualizar()
        Me.grdviewListaPrecios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueMoneda = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barListaPreciosActualizar = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.lycListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaPrecios.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rsluevListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMonedaAplicar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPrecioLista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoListaPreciosDeNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoListaPreciosParaNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueListaPreciosPara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueListaPreciosDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueGrupoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaPreciosActualizar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycListaPrecios
        '
        Me.lycListaPrecios.Controls.Add(Me.lblTitulo)
        Me.lycListaPrecios.Controls.Add(Me.sbdcListapreciosActualizar)
        Me.lycListaPrecios.Controls.Add(Me.btnMonedaAplicar)
        Me.lycListaPrecios.Controls.Add(Me.slueMonedaAplicar)
        Me.lycListaPrecios.Controls.Add(Me.spinPrecioLista)
        Me.lycListaPrecios.Controls.Add(Me.btnPrecioAplicar)
        Me.lycListaPrecios.Controls.Add(Me.btnArticulosTodos)
        Me.lycListaPrecios.Controls.Add(Me.btnArticulosConPrecio)
        Me.lycListaPrecios.Controls.Add(Me.btnArticulosPrecioCero)
        Me.lycListaPrecios.Controls.Add(Me.memoListaPreciosDeNombre)
        Me.lycListaPrecios.Controls.Add(Me.memoListaPreciosParaNombre)
        Me.lycListaPrecios.Controls.Add(Me.slueListaPreciosPara)
        Me.lycListaPrecios.Controls.Add(Me.slueListaPreciosDe)
        Me.lycListaPrecios.Controls.Add(Me.slueGrupoArticulo)
        Me.lycListaPrecios.Controls.Add(Me.slueCodigoArticulo)
        Me.lycListaPrecios.Controls.Add(Me.grdListaPrecios)
        Me.lycListaPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListaPrecios.Location = New System.Drawing.Point(0, 0)
        Me.lycListaPrecios.Name = "lycListaPrecios"
        Me.lycListaPrecios.Root = Me.LayoutControlGroup1
        Me.lycListaPrecios.Size = New System.Drawing.Size(870, 496)
        Me.lycListaPrecios.TabIndex = 0
        Me.lycListaPrecios.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(312, 23)
        Me.lblTitulo.StyleController = Me.lycListaPrecios
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Actualización de Lista de Precios"
        '
        'sbdcListapreciosActualizar
        '
        Me.sbdcListapreciosActualizar.CausesValidation = False
        Me.sbdcListapreciosActualizar.IsVertical = True
        Me.sbdcListapreciosActualizar.Location = New System.Drawing.Point(12, 210)
        Me.sbdcListapreciosActualizar.Manager = Me.BarManager1
        Me.sbdcListapreciosActualizar.Name = "sbdcListapreciosActualizar"
        Me.sbdcListapreciosActualizar.Size = New System.Drawing.Size(35, 51)
        Me.sbdcListapreciosActualizar.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcListapreciosActualizar)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnActualizar, Me.barbtnNuevo})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueListaPrecios})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnNuevo
        '
        Me.barbtnNuevo.Caption = "Nuevo"
        Me.barbtnNuevo.Id = 4
        Me.barbtnNuevo.ImageOptions.Image = CType(resources.GetObject("barbtnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnNuevo.Name = "barbtnNuevo"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 1
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(870, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 496)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(870, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 496)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(870, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 496)
        '
        'rslueListaPrecios
        '
        Me.rslueListaPrecios.AutoHeight = False
        Me.rslueListaPrecios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueListaPrecios.Name = "rslueListaPrecios"
        Me.rslueListaPrecios.View = Me.rsluevListaPrecios
        '
        'rsluevListaPrecios
        '
        Me.rsluevListaPrecios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.rsluevListaPrecios.Name = "rsluevListaPrecios"
        Me.rsluevListaPrecios.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.rsluevListaPrecios.OptionsView.ShowGroupPanel = False
        '
        'btnMonedaAplicar
        '
        Me.btnMonedaAplicar.ImageOptions.Image = CType(resources.GetObject("btnMonedaAplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMonedaAplicar.Location = New System.Drawing.Point(784, 172)
        Me.btnMonedaAplicar.Name = "btnMonedaAplicar"
        Me.btnMonedaAplicar.Size = New System.Drawing.Size(62, 22)
        Me.btnMonedaAplicar.StyleController = Me.lycListaPrecios
        Me.btnMonedaAplicar.TabIndex = 17
        Me.btnMonedaAplicar.Text = "Aplicar"
        '
        'slueMonedaAplicar
        '
        Me.slueMonedaAplicar.Location = New System.Drawing.Point(665, 172)
        Me.slueMonedaAplicar.MenuManager = Me.BarManager1
        Me.slueMonedaAplicar.Name = "slueMonedaAplicar"
        Me.slueMonedaAplicar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMonedaAplicar.Properties.NullText = ""
        Me.slueMonedaAplicar.Properties.View = Me.GridView3
        Me.slueMonedaAplicar.Size = New System.Drawing.Size(115, 20)
        Me.slueMonedaAplicar.StyleController = Me.lycListaPrecios
        Me.slueMonedaAplicar.TabIndex = 16
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'spinPrecioLista
        '
        Me.spinPrecioLista.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPrecioLista.Location = New System.Drawing.Point(665, 146)
        Me.spinPrecioLista.MenuManager = Me.BarManager1
        Me.spinPrecioLista.Name = "spinPrecioLista"
        Me.spinPrecioLista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPrecioLista.Properties.DisplayFormat.FormatString = "n6"
        Me.spinPrecioLista.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPrecioLista.Properties.EditFormat.FormatString = "n6"
        Me.spinPrecioLista.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPrecioLista.Properties.Mask.EditMask = "n6"
        Me.spinPrecioLista.Size = New System.Drawing.Size(115, 20)
        Me.spinPrecioLista.StyleController = Me.lycListaPrecios
        Me.spinPrecioLista.TabIndex = 15
        '
        'btnPrecioAplicar
        '
        Me.btnPrecioAplicar.ImageOptions.Image = CType(resources.GetObject("btnPrecioAplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrecioAplicar.Location = New System.Drawing.Point(784, 146)
        Me.btnPrecioAplicar.Name = "btnPrecioAplicar"
        Me.btnPrecioAplicar.Size = New System.Drawing.Size(62, 22)
        Me.btnPrecioAplicar.StyleController = Me.lycListaPrecios
        Me.btnPrecioAplicar.TabIndex = 14
        Me.btnPrecioAplicar.Text = "Aplicar"
        '
        'btnArticulosTodos
        '
        Me.btnArticulosTodos.Appearance.Options.UseTextOptions = True
        Me.btnArticulosTodos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnArticulosTodos.ImageOptions.Image = CType(resources.GetObject("btnArticulosTodos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnArticulosTodos.Location = New System.Drawing.Point(292, 39)
        Me.btnArticulosTodos.Name = "btnArticulosTodos"
        Me.btnArticulosTodos.Size = New System.Drawing.Size(205, 38)
        Me.btnArticulosTodos.StyleController = Me.lycListaPrecios
        Me.btnArticulosTodos.TabIndex = 13
        Me.btnArticulosTodos.Text = "Todos los Articulos"
        '
        'btnArticulosConPrecio
        '
        Me.btnArticulosConPrecio.Appearance.Options.UseTextOptions = True
        Me.btnArticulosConPrecio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnArticulosConPrecio.ImageOptions.Image = CType(resources.GetObject("btnArticulosConPrecio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnArticulosConPrecio.Location = New System.Drawing.Point(292, 123)
        Me.btnArticulosConPrecio.Name = "btnArticulosConPrecio"
        Me.btnArticulosConPrecio.Size = New System.Drawing.Size(205, 38)
        Me.btnArticulosConPrecio.StyleController = Me.lycListaPrecios
        Me.btnArticulosConPrecio.TabIndex = 12
        Me.btnArticulosConPrecio.Text = "Articulos con Precio > [0.01]"
        '
        'btnArticulosPrecioCero
        '
        Me.btnArticulosPrecioCero.Appearance.Options.UseTextOptions = True
        Me.btnArticulosPrecioCero.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnArticulosPrecioCero.ImageOptions.Image = CType(resources.GetObject("btnArticulosPrecioCero.ImageOptions.Image"), System.Drawing.Image)
        Me.btnArticulosPrecioCero.Location = New System.Drawing.Point(292, 81)
        Me.btnArticulosPrecioCero.Name = "btnArticulosPrecioCero"
        Me.btnArticulosPrecioCero.Size = New System.Drawing.Size(205, 38)
        Me.btnArticulosPrecioCero.StyleController = Me.lycListaPrecios
        Me.btnArticulosPrecioCero.TabIndex = 11
        Me.btnArticulosPrecioCero.Text = "Articulos Sin Precio = [0.00]"
        '
        'memoListaPreciosDeNombre
        '
        Me.memoListaPreciosDeNombre.Enabled = False
        Me.memoListaPreciosDeNombre.Location = New System.Drawing.Point(24, 93)
        Me.memoListaPreciosDeNombre.MaximumSize = New System.Drawing.Size(0, 53)
        Me.memoListaPreciosDeNombre.MenuManager = Me.BarManager1
        Me.memoListaPreciosDeNombre.MinimumSize = New System.Drawing.Size(0, 53)
        Me.memoListaPreciosDeNombre.Name = "memoListaPreciosDeNombre"
        Me.memoListaPreciosDeNombre.Size = New System.Drawing.Size(252, 53)
        Me.memoListaPreciosDeNombre.StyleController = Me.lycListaPrecios
        Me.memoListaPreciosDeNombre.TabIndex = 10
        '
        'memoListaPreciosParaNombre
        '
        Me.memoListaPreciosParaNombre.Enabled = False
        Me.memoListaPreciosParaNombre.Location = New System.Drawing.Point(513, 93)
        Me.memoListaPreciosParaNombre.MenuManager = Me.BarManager1
        Me.memoListaPreciosParaNombre.Name = "memoListaPreciosParaNombre"
        Me.memoListaPreciosParaNombre.Size = New System.Drawing.Size(333, 49)
        Me.memoListaPreciosParaNombre.StyleController = Me.lycListaPrecios
        Me.memoListaPreciosParaNombre.TabIndex = 9
        '
        'slueListaPreciosPara
        '
        Me.slueListaPreciosPara.Location = New System.Drawing.Point(665, 69)
        Me.slueListaPreciosPara.MaximumSize = New System.Drawing.Size(0, 20)
        Me.slueListaPreciosPara.MenuManager = Me.BarManager1
        Me.slueListaPreciosPara.MinimumSize = New System.Drawing.Size(0, 20)
        Me.slueListaPreciosPara.Name = "slueListaPreciosPara"
        Me.slueListaPreciosPara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueListaPreciosPara.Properties.NullText = ""
        Me.slueListaPreciosPara.Properties.View = Me.GridView2
        Me.slueListaPreciosPara.Size = New System.Drawing.Size(181, 20)
        Me.slueListaPreciosPara.StyleController = Me.lycListaPrecios
        Me.slueListaPreciosPara.TabIndex = 8
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'slueListaPreciosDe
        '
        Me.slueListaPreciosDe.EditValue = ""
        Me.slueListaPreciosDe.Location = New System.Drawing.Point(176, 69)
        Me.slueListaPreciosDe.MaximumSize = New System.Drawing.Size(100, 0)
        Me.slueListaPreciosDe.MenuManager = Me.BarManager1
        Me.slueListaPreciosDe.MinimumSize = New System.Drawing.Size(100, 0)
        Me.slueListaPreciosDe.Name = "slueListaPreciosDe"
        Me.slueListaPreciosDe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueListaPreciosDe.Properties.NullText = ""
        Me.slueListaPreciosDe.Properties.View = Me.GridView1
        Me.slueListaPreciosDe.Size = New System.Drawing.Size(100, 20)
        Me.slueListaPreciosDe.StyleController = Me.lycListaPrecios
        Me.slueListaPreciosDe.TabIndex = 7
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'slueGrupoArticulo
        '
        Me.slueGrupoArticulo.Location = New System.Drawing.Point(176, 174)
        Me.slueGrupoArticulo.MenuManager = Me.BarManager1
        Me.slueGrupoArticulo.Name = "slueGrupoArticulo"
        Me.slueGrupoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueGrupoArticulo.Properties.NullText = ""
        Me.slueGrupoArticulo.Properties.View = Me.SearchLookUpEdit2View
        Me.slueGrupoArticulo.Size = New System.Drawing.Size(100, 20)
        Me.slueGrupoArticulo.StyleController = Me.lycListaPrecios
        Me.slueGrupoArticulo.TabIndex = 6
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'slueCodigoArticulo
        '
        Me.slueCodigoArticulo.Location = New System.Drawing.Point(176, 150)
        Me.slueCodigoArticulo.MenuManager = Me.BarManager1
        Me.slueCodigoArticulo.Name = "slueCodigoArticulo"
        Me.slueCodigoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoArticulo.Properties.NullText = ""
        Me.slueCodigoArticulo.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigoArticulo.Size = New System.Drawing.Size(100, 20)
        Me.slueCodigoArticulo.StyleController = Me.lycListaPrecios
        Me.slueCodigoArticulo.TabIndex = 5
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grdListaPrecios
        '
        Me.grdListaPrecios.DataMember = "dsdtListaPreciosActualizar"
        Me.grdListaPrecios.DataSource = Me.DsListaPreciosActualizar1
        Me.grdListaPrecios.Location = New System.Drawing.Point(51, 210)
        Me.grdListaPrecios.MainView = Me.grdviewListaPrecios
        Me.grdListaPrecios.MenuManager = Me.BarManager1
        Me.grdListaPrecios.Name = "grdListaPrecios"
        Me.grdListaPrecios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueMoneda, Me.rspinPrecio})
        Me.grdListaPrecios.Size = New System.Drawing.Size(807, 274)
        Me.grdListaPrecios.TabIndex = 4
        Me.grdListaPrecios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaPrecios})
        '
        'DsListaPreciosActualizar1
        '
        Me.DsListaPreciosActualizar1.DataSetName = "dsListaPreciosActualizar"
        Me.DsListaPreciosActualizar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaPrecios
        '
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.grdviewListaPrecios.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdviewListaPrecios.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewListaPrecios.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaPrecios.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaPrecios.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaPrecios.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewListaPrecios.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaPrecios.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewListaPrecios.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaPrecios.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewListaPrecios.ColumnPanelRowHeight = 35
        Me.grdviewListaPrecios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPrecio, Me.colMoneda})
        Me.grdviewListaPrecios.GridControl = Me.grdListaPrecios
        Me.grdviewListaPrecios.Name = "grdviewListaPrecios"
        Me.grdviewListaPrecios.OptionsSelection.MultiSelect = True
        Me.grdviewListaPrecios.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewListaPrecios.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaPrecios.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaPrecios.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaPrecios.OptionsView.ShowFooter = True
        Me.grdviewListaPrecios.OptionsView.ShowGroupPanel = False
        Me.grdviewListaPrecios.PaintStyleName = "Web"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        Me.colCodigoArticulo.Width = 125
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.AllowFocus = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 400
        '
        'colPrecio
        '
        Me.colPrecio.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecio.ColumnEdit = Me.rspinPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 3
        Me.colPrecio.Width = 100
        '
        'rspinPrecio
        '
        Me.rspinPrecio.AutoHeight = False
        Me.rspinPrecio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPrecio.DisplayFormat.FormatString = "n6"
        Me.rspinPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrecio.EditFormat.FormatString = "n6"
        Me.rspinPrecio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinPrecio.Mask.EditMask = "n6"
        Me.rspinPrecio.Name = "rspinPrecio"
        '
        'colMoneda
        '
        Me.colMoneda.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoneda.ColumnEdit = Me.rslueMoneda
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 4
        Me.colMoneda.Width = 70
        '
        'rslueMoneda
        '
        Me.rslueMoneda.AutoHeight = False
        Me.rslueMoneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueMoneda.Name = "rslueMoneda"
        Me.rslueMoneda.NullText = ""
        Me.rslueMoneda.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem15, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(870, 496)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdListaPrecios
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(39, 198)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(811, 278)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Informacion para Agregar"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(280, 171)
        Me.LayoutControlGroup2.Text = "Informacion para Agregar"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.slueListaPreciosDe
        Me.LayoutControlItem4.CustomizationFormText = "Lista de Precios"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem4.Text = "Lista de Precios"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.memoListaPreciosDeNombre
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(256, 57)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.slueCodigoArticulo
        Me.LayoutControlItem2.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 81)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem2.Text = "Codigo Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.slueGrupoArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Grupo de Articulos"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 105)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem3.Text = "Grupo de Articulos"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Lista de Precios que desea Actualizar"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(489, 27)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(361, 171)
        Me.LayoutControlGroup3.Text = "Lista de Precios que desea Actualizar"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.slueListaPreciosPara
        Me.LayoutControlItem5.CustomizationFormText = "Lista de Precios para Actualizar"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(337, 24)
        Me.LayoutControlItem5.Text = "Lista de Precios para Actualizar"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.memoListaPreciosParaNombre
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(337, 53)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnPrecioAplicar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(271, 77)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(66, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.spinPrecioLista
        Me.LayoutControlItem12.CustomizationFormText = "Precio para Todos"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 77)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(271, 26)
        Me.LayoutControlItem12.Text = "Precio de la Lista"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.slueMonedaAplicar
        Me.LayoutControlItem13.CustomizationFormText = "Moneda de la Lista"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(271, 26)
        Me.LayoutControlItem13.Text = "Moneda de la Lista"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnMonedaAplicar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(271, 103)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(66, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnArticulosPrecioCero
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(280, 69)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(209, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(280, 153)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(209, 45)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnArticulosConPrecio
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(280, 111)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(209, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnArticulosTodos
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(280, 27)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(209, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.sbdcListapreciosActualizar
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(39, 278)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.lblTitulo
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(850, 27)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barListaPreciosActualizar})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEliminar})
        Me.BarManager2.MaxItemId = 1
        '
        'barListaPreciosActualizar
        '
        Me.barListaPreciosActualizar.BarName = "Tools"
        Me.barListaPreciosActualizar.DockCol = 0
        Me.barListaPreciosActualizar.DockRow = 0
        Me.barListaPreciosActualizar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barListaPreciosActualizar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEliminar)})
        Me.barListaPreciosActualizar.Offset = 1
        Me.barListaPreciosActualizar.OptionsBar.AllowQuickCustomization = False
        Me.barListaPreciosActualizar.OptionsBar.DrawBorder = False
        Me.barListaPreciosActualizar.StandaloneBarDockControl = Me.sbdcListapreciosActualizar
        Me.barListaPreciosActualizar.Text = "Tools"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "barbtnEliminar"
        Me.barbtnEliminar.Id = 0
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(870, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 539)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(870, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 539)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(870, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 539)
        '
        'frmListaPreciosActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 539)
        Me.Controls.Add(Me.lycListaPrecios)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListaPreciosActualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListaPreciosActualizar"
        CType(Me.lycListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaPrecios.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rsluevListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMonedaAplicar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPrecioLista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoListaPreciosDeNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoListaPreciosParaNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueListaPreciosPara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueListaPreciosDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueGrupoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaPreciosActualizar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycListaPrecios As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents rslueListaPrecios As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents rsluevListaPrecios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueCodigoArticulo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdListaPrecios As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaPrecios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents slueGrupoArticulo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsListaPreciosActualizar1 As waProduccion_Pedidos.dsListaPreciosActualizar
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents slueListaPreciosPara As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueListaPreciosDe As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnArticulosTodos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArticulosConPrecio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArticulosPrecioCero As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents memoListaPreciosDeNombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents memoListaPreciosParaNombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rslueMoneda As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnMonedaAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents slueMonedaAplicar As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents spinPrecioLista As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnPrecioAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcListapreciosActualizar As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barListaPreciosActualizar As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rspinPrecio As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
