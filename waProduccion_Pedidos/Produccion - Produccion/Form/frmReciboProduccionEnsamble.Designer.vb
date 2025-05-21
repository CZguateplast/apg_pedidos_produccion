<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciboProduccionEnsamble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboProduccionEnsamble))
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.lycReciboProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.slueTipo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barfootReciboProduccion = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAyuda = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenModificar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetalleRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barbtnReciboDetalles = New DevExpress.XtraBars.BarButtonItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtRef2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.slueCodigoArticulo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.grdReciboProduccionEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.DsReciboProduccionEnsamble1 = New waProduccion_Pedidos.dsReciboProduccionEnsamble()
        Me.grdviewReciboProduccionEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCerrar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rchkCerrar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueSAP = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueDestinoBodega = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rcalCargar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rchkboxCerrar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.txtComentarioRecibo = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycReciboProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycReciboProduccion.SuspendLayout()
        CType(Me.slueTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRef2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReciboProduccionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReciboProduccionEnsamble1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewReciboProduccionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueDestinoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcalCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkboxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarioRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycReciboProduccion
        '
        Me.lycReciboProduccion.Controls.Add(Me.slueTipo)
        Me.lycReciboProduccion.Controls.Add(Me.txtRef2)
        Me.lycReciboProduccion.Controls.Add(Me.txtNombreArticulo)
        Me.lycReciboProduccion.Controls.Add(Me.slueCodigoArticulo)
        Me.lycReciboProduccion.Controls.Add(Me.dteFecha)
        Me.lycReciboProduccion.Controls.Add(Me.grdReciboProduccionEnsamble)
        Me.lycReciboProduccion.Controls.Add(Me.txtComentarioRecibo)
        Me.lycReciboProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycReciboProduccion.Location = New System.Drawing.Point(0, 59)
        Me.lycReciboProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.lycReciboProduccion.Name = "lycReciboProduccion"
        Me.lycReciboProduccion.Root = Me.LayoutControlGroup1
        Me.lycReciboProduccion.Size = New System.Drawing.Size(1397, 612)
        Me.lycReciboProduccion.TabIndex = 0
        Me.lycReciboProduccion.Text = "LayoutControl1"
        '
        'slueTipo
        '
        Me.slueTipo.EditValue = "S"
        Me.slueTipo.EnterMoveNextControl = True
        Me.slueTipo.Location = New System.Drawing.Point(192, 16)
        Me.slueTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.slueTipo.MenuManager = Me.BarManager1
        Me.slueTipo.Name = "slueTipo"
        Me.slueTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTipo.Properties.NullText = ""
        Me.slueTipo.Properties.ShowClearButton = False
        Me.slueTipo.Properties.View = Me.GridView1
        Me.slueTipo.Size = New System.Drawing.Size(160, 22)
        Me.slueTipo.StyleController = Me.lycReciboProduccion
        Me.slueTipo.TabIndex = 11
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barfootReciboProduccion, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnSAP, Me.barbtnReciboDetalles, Me.barbtnExportarXlsx, Me.barbtnEliminar, Me.barbtnOrdenModificar, Me.barbtnDetalleRecibos, Me.barbtnImprimirGrid, Me.barbtnAyuda})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.barfootReciboProduccion
        '
        'barfootReciboProduccion
        '
        Me.barfootReciboProduccion.BarName = "Status bar"
        Me.barfootReciboProduccion.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barfootReciboProduccion.DockCol = 0
        Me.barfootReciboProduccion.DockRow = 0
        Me.barfootReciboProduccion.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barfootReciboProduccion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSAP, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAyuda, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDetalleRecibos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barfootReciboProduccion.OptionsBar.AllowQuickCustomization = False
        Me.barfootReciboProduccion.OptionsBar.DrawDragBorder = False
        Me.barfootReciboProduccion.OptionsBar.UseWholeRow = True
        Me.barfootReciboProduccion.Text = "Status bar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 10
        Me.barbtnImprimirGrid.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.printtitles_32x32
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar"
        Me.barbtnExportarXlsx.Id = 6
        Me.barbtnExportarXlsx.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.exporttoxls_32x32
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnSAP.Caption = "Grabar"
        Me.barbtnSAP.Id = 1
        Me.barbtnSAP.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'barbtnAyuda
        '
        Me.barbtnAyuda.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAyuda.Caption = "Ayuda"
        Me.barbtnAyuda.Id = 11
        Me.barbtnAyuda.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.index_32x32
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
        'barbtnOrdenModificar
        '
        Me.barbtnOrdenModificar.Caption = "Editar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnOrdenModificar.Id = 8
        Me.barbtnOrdenModificar.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.editname_32x32
        Me.barbtnOrdenModificar.Name = "barbtnOrdenModificar"
        '
        'barbtnDetalleRecibos
        '
        Me.barbtnDetalleRecibos.Caption = "Detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibos"
        Me.barbtnDetalleRecibos.Id = 9
        Me.barbtnDetalleRecibos.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.pageorientationlandscape_32x32
        Me.barbtnDetalleRecibos.Name = "barbtnDetalleRecibos"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 4"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Custom 4"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fila"
        Me.barbtnEliminar.Id = 7
        Me.barbtnEliminar.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.deletetablerows_32x321
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1397, 59)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 671)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1397, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 59)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 612)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1397, 59)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 612)
        '
        'barbtnReciboDetalles
        '
        Me.barbtnReciboDetalles.Caption = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibos"
        Me.barbtnReciboDetalles.Id = 4
        Me.barbtnReciboDetalles.ImageOptions.Image = CType(resources.GetObject("barbtnReciboDetalles.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnReciboDetalles.Name = "barbtnReciboDetalles"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtRef2
        '
        Me.txtRef2.Location = New System.Drawing.Point(849, 16)
        Me.txtRef2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRef2.MenuManager = Me.BarManager1
        Me.txtRef2.Name = "txtRef2"
        Me.txtRef2.Properties.MaxLength = 11
        Me.txtRef2.Size = New System.Drawing.Size(166, 22)
        Me.txtRef2.StyleController = Me.lycReciboProduccion
        Me.txtRef2.TabIndex = 10
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(534, 44)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(481, 22)
        Me.txtNombreArticulo.StyleController = Me.lycReciboProduccion
        Me.txtNombreArticulo.TabIndex = 9
        '
        'slueCodigoArticulo
        '
        Me.slueCodigoArticulo.Location = New System.Drawing.Point(192, 44)
        Me.slueCodigoArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.slueCodigoArticulo.MaximumSize = New System.Drawing.Size(160, 20)
        Me.slueCodigoArticulo.MenuManager = Me.BarManager1
        Me.slueCodigoArticulo.MinimumSize = New System.Drawing.Size(160, 20)
        Me.slueCodigoArticulo.Name = "slueCodigoArticulo"
        Me.slueCodigoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoArticulo.Properties.NullText = ""
        Me.slueCodigoArticulo.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigoArticulo.Size = New System.Drawing.Size(160, 22)
        Me.slueCodigoArticulo.StyleController = Me.lycReciboProduccion
        Me.slueCodigoArticulo.TabIndex = 8
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(534, 16)
        Me.dteFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFecha.MaximumSize = New System.Drawing.Size(133, 20)
        Me.dteFecha.MenuManager = Me.BarManager1
        Me.dteFecha.MinimumSize = New System.Drawing.Size(133, 20)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Size = New System.Drawing.Size(133, 22)
        Me.dteFecha.StyleController = Me.lycReciboProduccion
        Me.dteFecha.TabIndex = 6
        '
        'grdReciboProduccionEnsamble
        '
        Me.grdReciboProduccionEnsamble.DataMember = "dsdtReciboProduccionEnsamble"
        Me.grdReciboProduccionEnsamble.DataSource = Me.DsReciboProduccionEnsamble1
        Me.grdReciboProduccionEnsamble.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdReciboProduccionEnsamble.Location = New System.Drawing.Point(16, 119)
        Me.grdReciboProduccionEnsamble.MainView = Me.grdviewReciboProduccionEnsamble
        Me.grdReciboProduccionEnsamble.Margin = New System.Windows.Forms.Padding(4)
        Me.grdReciboProduccionEnsamble.MenuManager = Me.BarManager1
        Me.grdReciboProduccionEnsamble.MinimumSize = New System.Drawing.Size(1333, 0)
        Me.grdReciboProduccionEnsamble.Name = "grdReciboProduccionEnsamble"
        Me.grdReciboProduccionEnsamble.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueSAP, Me.rchkboxCerrar, Me.rchkCerrar, Me.rcalCargar, Me.rslueDestinoBodega})
        Me.grdReciboProduccionEnsamble.Size = New System.Drawing.Size(1365, 477)
        Me.grdReciboProduccionEnsamble.TabIndex = 4
        Me.grdReciboProduccionEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewReciboProduccionEnsamble})
        '
        'DsReciboProduccionEnsamble1
        '
        Me.DsReciboProduccionEnsamble1.DataSetName = "dsReciboProduccionEnsamble"
        Me.DsReciboProduccionEnsamble1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewReciboProduccionEnsamble
        '
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewReciboProduccionEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewReciboProduccionEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewReciboProduccionEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewReciboProduccionEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewReciboProduccionEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewReciboProduccionEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCerrar, Me.colSAP, Me.colBodega, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colStock, Me.colComprometido, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCargar, Me.colComentarios, Me.colEstado})
        Me.grdviewReciboProduccionEnsamble.GridControl = Me.grdReciboProduccionEnsamble
        Me.grdviewReciboProduccionEnsamble.Name = "grdviewReciboProduccionEnsamble"
        Me.grdviewReciboProduccionEnsamble.NewItemRowText = "Click aquí para agregar un nuevo documento"
        Me.grdviewReciboProduccionEnsamble.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.grdviewReciboProduccionEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewReciboProduccionEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewReciboProduccionEnsamble.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewReciboProduccionEnsamble.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewReciboProduccionEnsamble.OptionsView.ShowFooter = True
        Me.grdviewReciboProduccionEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewReciboProduccionEnsamble.PaintStyleName = "Web"
        '
        'colCerrar
        '
        Me.colCerrar.AppearanceHeader.Options.UseTextOptions = True
        Me.colCerrar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCerrar.Caption = "Cerrar"
        Me.colCerrar.ColumnEdit = Me.rchkCerrar
        Me.colCerrar.FieldName = "Cerrar"
        Me.colCerrar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCerrar.Name = "colCerrar"
        Me.colCerrar.Visible = True
        Me.colCerrar.VisibleIndex = 0
        Me.colCerrar.Width = 55
        '
        'rchkCerrar
        '
        Me.rchkCerrar.AutoHeight = False
        Me.rchkCerrar.Caption = "Check"
        Me.rchkCerrar.Name = "rchkCerrar"
        Me.rchkCerrar.ValueGrayed = False
        '
        'colSAP
        '
        Me.colSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSAP.AppearanceHeader.Options.UseFont = True
        Me.colSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP.ColumnEdit = Me.rslueSAP
        Me.colSAP.FieldName = "SAP"
        Me.colSAP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colSAP.Name = "colSAP"
        Me.colSAP.OptionsColumn.AllowEdit = False
        Me.colSAP.OptionsColumn.ReadOnly = True
        Me.colSAP.Visible = True
        Me.colSAP.VisibleIndex = 1
        Me.colSAP.Width = 60
        '
        'rslueSAP
        '
        Me.rslueSAP.AutoHeight = False
        Me.rslueSAP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueSAP.Name = "rslueSAP"
        Me.rslueSAP.NullText = ""
        Me.rslueSAP.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBodega
        '
        Me.colBodega.AppearanceCell.Options.UseTextOptions = True
        Me.colBodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBodega.AppearanceHeader.Options.UseFont = True
        Me.colBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.ColumnEdit = Me.rslueDestinoBodega
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colBodega.Name = "colBodega"
        Me.colBodega.OptionsColumn.AllowFocus = False
        Me.colBodega.OptionsColumn.ReadOnly = True
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 3
        '
        'rslueDestinoBodega
        '
        Me.rslueDestinoBodega.AutoHeight = False
        Me.rslueDestinoBodega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestinoBodega.Name = "rslueDestinoBodega"
        Me.rslueDestinoBodega.NullText = ""
        Me.rslueDestinoBodega.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 4
        Me.colCodigoArticulo.Width = 110
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowFocus = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 5
        Me.colNombreArticulo.Width = 300
        '
        'colStock
        '
        Me.colStock.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colStock.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colStock.AppearanceCell.Options.UseBackColor = True
        Me.colStock.AppearanceCell.Options.UseForeColor = True
        Me.colStock.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colStock.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colStock.AppearanceHeader.Options.UseBackColor = True
        Me.colStock.AppearanceHeader.Options.UseForeColor = True
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.AllowEdit = False
        Me.colStock.OptionsColumn.AllowFocus = False
        Me.colStock.OptionsColumn.ReadOnly = True
        Me.colStock.OptionsColumn.TabStop = False
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 11
        '
        'colComprometido
        '
        Me.colComprometido.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colComprometido.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colComprometido.AppearanceCell.Options.UseBackColor = True
        Me.colComprometido.AppearanceCell.Options.UseForeColor = True
        Me.colComprometido.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colComprometido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colComprometido.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colComprometido.AppearanceHeader.Options.UseBackColor = True
        Me.colComprometido.AppearanceHeader.Options.UseFont = True
        Me.colComprometido.AppearanceHeader.Options.UseForeColor = True
        Me.colComprometido.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido.FieldName = "Comprometido"
        Me.colComprometido.Name = "colComprometido"
        Me.colComprometido.OptionsColumn.AllowEdit = False
        Me.colComprometido.OptionsColumn.ReadOnly = True
        Me.colComprometido.OptionsColumn.TabStop = False
        Me.colComprometido.Visible = True
        Me.colComprometido.VisibleIndex = 12
        Me.colComprometido.Width = 90
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colPlaneado.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colPlaneado.AppearanceHeader.Options.UseBackColor = True
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowFocus = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Planeado", "{0:n0}")})
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 8
        Me.colPlaneado.Width = 70
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colCompletado.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colCompletado.AppearanceHeader.Options.UseBackColor = True
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.Caption = "Completo"
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowFocus = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Completado", "{0:n0}")})
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 9
        Me.colCompletado.Width = 70
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colPendiente.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colPendiente.AppearanceHeader.Options.UseBackColor = True
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowFocus = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pendiente", "{0:n0}")})
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 10
        Me.colPendiente.Width = 70
        '
        'colCargar
        '
        Me.colCargar.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCargar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCargar.AppearanceCell.Options.UseBackColor = True
        Me.colCargar.AppearanceCell.Options.UseFont = True
        Me.colCargar.AppearanceCell.Options.UseTextOptions = True
        Me.colCargar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCargar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCargar.AppearanceHeader.Options.UseFont = True
        Me.colCargar.AppearanceHeader.Options.UseTextOptions = True
        Me.colCargar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCargar.ColumnEdit = Me.rcalCargar
        Me.colCargar.FieldName = "Cargar"
        Me.colCargar.Name = "colCargar"
        Me.colCargar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cargar", "{0:n0}")})
        Me.colCargar.Visible = True
        Me.colCargar.VisibleIndex = 6
        Me.colCargar.Width = 80
        '
        'rcalCargar
        '
        Me.rcalCargar.AutoHeight = False
        Me.rcalCargar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcalCargar.Name = "rcalCargar"
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.ReadOnly = True
        Me.colComentarios.OptionsColumn.TabStop = False
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 7
        Me.colComentarios.Width = 254
        '
        'colEstado
        '
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.OptionsColumn.TabStop = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 2
        '
        'rchkboxCerrar
        '
        Me.rchkboxCerrar.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.rchkboxCerrar.AutoHeight = False
        Me.rchkboxCerrar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rchkboxCerrar.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(True, "SI"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(False, "NO", System.Windows.Forms.CheckState.Checked)})
        Me.rchkboxCerrar.Name = "rchkboxCerrar"
        Me.rchkboxCerrar.SelectAllItemVisible = False
        '
        'txtComentarioRecibo
        '
        Me.txtComentarioRecibo.Location = New System.Drawing.Point(192, 72)
        Me.txtComentarioRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentarioRecibo.MaximumSize = New System.Drawing.Size(823, 0)
        Me.txtComentarioRecibo.MenuManager = Me.BarManager1
        Me.txtComentarioRecibo.MinimumSize = New System.Drawing.Size(823, 0)
        Me.txtComentarioRecibo.Name = "txtComentarioRecibo"
        Me.txtComentarioRecibo.Size = New System.Drawing.Size(823, 41)
        Me.txtComentarioRecibo.StyleController = Me.lycReciboProduccion
        Me.txtComentarioRecibo.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1397, 612)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdReciboProduccionEnsamble
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1371, 483)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.dteFecha
        Me.LayoutControlItem3.CustomizationFormText = "Fecha de Contabilización:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(342, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(315, 28)
        Me.LayoutControlItem3.Text = "Fecha de Contabilización:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(173, 17)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.slueCodigoArticulo
        Me.LayoutControlItem5.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(342, 28)
        Me.LayoutControlItem5.Text = "Codigo Articulo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(173, 17)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtNombreArticulo
        Me.LayoutControlItem6.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(342, 28)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(663, 28)
        Me.LayoutControlItem6.Text = "Nombre Articulo"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(173, 17)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem2.Control = Me.txtComentarioRecibo
        Me.LayoutControlItem2.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1005, 47)
        Me.LayoutControlItem2.Text = "Comentarios"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(173, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtRef2
        Me.LayoutControlItem4.CustomizationFormText = "Ref 2:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(657, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(348, 28)
        Me.LayoutControlItem4.Text = "Ref 2:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(173, 17)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1005, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(366, 103)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.slueTipo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(342, 28)
        Me.LayoutControlItem8.Text = "Tipo:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(173, 17)
        '
        'frmReciboProduccionEnsamble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycReciboProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReciboProduccionEnsamble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo y Emision de Produccion y Ensamble"
        CType(Me.lycReciboProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycReciboProduccion.ResumeLayout(False)
        CType(Me.slueTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRef2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReciboProduccionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReciboProduccionEnsamble1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewReciboProduccionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueDestinoBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcalCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkboxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarioRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycReciboProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdReciboProduccionEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewReciboProduccionEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barfootReciboProduccion As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slueCodigoArticulo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsReciboProduccionEnsamble1 As waProduccion_Pedidos.dsReciboProduccionEnsamble
    Friend WithEvents colSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRef2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComentarioRecibo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rslueSAP As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCerrar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rchkboxCerrar As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents rchkCerrar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rcalCargar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnReciboDetalles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents slueTipo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnOrdenModificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetalleRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAyuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueDestinoBodega As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
