<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenProduccionEnsamble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenProduccionEnsamble))
        Me.lycOrdenProduccionEnsamble = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcOrdenes = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnNuevaOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscarDocumento = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnLiberarOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrarOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnCopiarNueva = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEspecial = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCopiarDesmonte = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCambiarComponente = New DevExpress.XtraBars.BarButtonItem()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.slueTipoOrden = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPrioridad = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.dteFechaFinalizacion = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaFabricacion = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumSAP = New DevExpress.XtraEditors.TextEdit()
        Me.txtSerie = New DevExpress.XtraEditors.TextEdit()
        Me.slueAlmacen = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUnidadMedida = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.slueCodigoArticulo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTipo = New DevExpress.XtraEditors.TextEdit()
        Me.grdOrdenProduccionEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.DsOrdenesProduccion1 = New waProduccion_Pedidos.dsOrdenesProduccion()
        Me.grdviewordenProduccionEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadBase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequerido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSolicitado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueAlmacen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.spinCantidadPlanificada = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barOrdenes = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminarLinea = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycOrdenProduccionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenProduccionEnsamble.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueTipoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrioridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinalizacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinalizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFabricacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFabricacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSAP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdenProduccionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenesProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewordenProduccionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinCantidadPlanificada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycOrdenProduccionEnsamble
        '
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.sbdcOrdenes)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtComentarios)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.slueTipoOrden)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtPrioridad)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtUsuario)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.dteFechaFinalizacion)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.dteFechaFabricacion)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtNumSAP)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtSerie)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.slueAlmacen)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtUnidadMedida)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtNombreArticulo)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.slueCodigoArticulo)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtTipo)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.grdOrdenProduccionEnsamble)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.txtEstado)
        Me.lycOrdenProduccionEnsamble.Controls.Add(Me.spinCantidadPlanificada)
        Me.lycOrdenProduccionEnsamble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenProduccionEnsamble.Location = New System.Drawing.Point(0, 30)
        Me.lycOrdenProduccionEnsamble.Margin = New System.Windows.Forms.Padding(4)
        Me.lycOrdenProduccionEnsamble.Name = "lycOrdenProduccionEnsamble"
        Me.lycOrdenProduccionEnsamble.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(510, 306, 450, 400)
        Me.lycOrdenProduccionEnsamble.Root = Me.LayoutControlGroup1
        Me.lycOrdenProduccionEnsamble.Size = New System.Drawing.Size(1240, 646)
        Me.lycOrdenProduccionEnsamble.TabIndex = 0
        Me.lycOrdenProduccionEnsamble.Text = "LayoutControl1"
        '
        'sbdcOrdenes
        '
        Me.sbdcOrdenes.CausesValidation = False
        Me.sbdcOrdenes.Location = New System.Drawing.Point(16, 565)
        Me.sbdcOrdenes.Manager = Me.BarManager1
        Me.sbdcOrdenes.Margin = New System.Windows.Forms.Padding(4)
        Me.sbdcOrdenes.Name = "sbdcOrdenes"
        Me.sbdcOrdenes.Size = New System.Drawing.Size(393, 39)
        Me.sbdcOrdenes.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcOrdenes)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnActualizar, Me.BarButtonItem2, Me.barbtnLiberarOrden, Me.barbtnCerrarOrden, Me.barbtnSAP, Me.barbtnCambiarComponente, Me.barbtnNuevaOrden, Me.barbtnBuscarDocumento, Me.barbtnCopiarDesmonte, Me.barbtnCopiarNueva, Me.barbtnEspecial})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSAP, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnNuevaOrden, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscarDocumento, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnLiberarOrden, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrarOrden, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Enabled = False
        Me.barbtnActualizar.Id = 1
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnSAP.Caption = "Crear"
        Me.barbtnSAP.Id = 7
        Me.barbtnSAP.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnNuevaOrden
        '
        Me.barbtnNuevaOrden.Caption = "Nueva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnNuevaOrden.Id = 11
        Me.barbtnNuevaOrden.ImageOptions.Image = CType(resources.GetObject("barbtnNuevaOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnNuevaOrden.Name = "barbtnNuevaOrden"
        '
        'barbtnBuscarDocumento
        '
        Me.barbtnBuscarDocumento.Caption = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Documento"
        Me.barbtnBuscarDocumento.Id = 13
        Me.barbtnBuscarDocumento.ImageOptions.Image = CType(resources.GetObject("barbtnBuscarDocumento.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscarDocumento.Name = "barbtnBuscarDocumento"
        '
        'barbtnLiberarOrden
        '
        Me.barbtnLiberarOrden.Caption = "Liberar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnLiberarOrden.Id = 3
        Me.barbtnLiberarOrden.ImageOptions.Image = CType(resources.GetObject("barbtnLiberarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnLiberarOrden.Name = "barbtnLiberarOrden"
        '
        'barbtnCerrarOrden
        '
        Me.barbtnCerrarOrden.Caption = "Cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnCerrarOrden.Id = 4
        Me.barbtnCerrarOrden.ImageOptions.Image = CType(resources.GetObject("barbtnCerrarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrarOrden.Name = "barbtnCerrarOrden"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCopiarNueva, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEspecial, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCopiarDesmonte, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'barbtnCopiarNueva
        '
        Me.barbtnCopiarNueva.Caption = "Copiar para Nueva Orden"
        Me.barbtnCopiarNueva.Id = 15
        Me.barbtnCopiarNueva.ImageOptions.Image = CType(resources.GetObject("barbtnCopiarNueva.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCopiarNueva.ImageOptions.LargeImage = CType(resources.GetObject("barbtnCopiarNueva.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnCopiarNueva.Name = "barbtnCopiarNueva"
        '
        'barbtnEspecial
        '
        Me.barbtnEspecial.Caption = "Copiar para Especial"
        Me.barbtnEspecial.Id = 16
        Me.barbtnEspecial.ImageOptions.Image = CType(resources.GetObject("barbtnEspecial.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEspecial.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEspecial.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEspecial.Name = "barbtnEspecial"
        '
        'barbtnCopiarDesmonte
        '
        Me.barbtnCopiarDesmonte.Caption = "Copiar para Desmonte"
        Me.barbtnCopiarDesmonte.Id = 14
        Me.barbtnCopiarDesmonte.ImageOptions.Image = CType(resources.GetObject("barbtnCopiarDesmonte.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCopiarDesmonte.ImageOptions.LargeImage = CType(resources.GetObject("barbtnCopiarDesmonte.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnCopiarDesmonte.Name = "barbtnCopiarDesmonte"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1240, 30)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 676)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1240, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 646)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1240, 30)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 646)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barbtnCambiarComponente
        '
        Me.barbtnCambiarComponente.Caption = "Cambiar Componente"
        Me.barbtnCambiarComponente.Id = 10
        Me.barbtnCambiarComponente.ImageOptions.Image = CType(resources.GetObject("barbtnCambiarComponente.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCambiarComponente.ImageOptions.LargeImage = CType(resources.GetObject("barbtnCambiarComponente.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnCambiarComponente.Name = "barbtnCambiarComponente"
        '
        'txtComentarios
        '
        Me.txtComentarios.Enabled = False
        Me.txtComentarios.Location = New System.Drawing.Point(710, 565)
        Me.txtComentarios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentarios.MenuManager = Me.BarManager1
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(514, 65)
        Me.txtComentarios.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtComentarios.TabIndex = 19
        '
        'slueTipoOrden
        '
        Me.slueTipoOrden.Enabled = False
        Me.slueTipoOrden.Location = New System.Drawing.Point(967, 194)
        Me.slueTipoOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.slueTipoOrden.MenuManager = Me.BarManager1
        Me.slueTipoOrden.Name = "slueTipoOrden"
        Me.slueTipoOrden.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.slueTipoOrden.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.slueTipoOrden.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueTipoOrden.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.slueTipoOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTipoOrden.Properties.NullText = ""
        Me.slueTipoOrden.Properties.View = Me.GridView1
        Me.slueTipoOrden.Size = New System.Drawing.Size(242, 22)
        Me.slueTipoOrden.StyleController = Me.lycOrdenProduccionEnsamble
        Me.slueTipoOrden.TabIndex = 18
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Enabled = False
        Me.txtPrioridad.Location = New System.Drawing.Point(967, 166)
        Me.txtPrioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrioridad.MenuManager = Me.BarManager1
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtPrioridad.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtPrioridad.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPrioridad.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPrioridad.Size = New System.Drawing.Size(242, 22)
        Me.txtPrioridad.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtPrioridad.TabIndex = 17
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(967, 138)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MenuManager = Me.BarManager1
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtUsuario.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtUsuario.Size = New System.Drawing.Size(242, 22)
        Me.txtUsuario.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtUsuario.TabIndex = 16
        '
        'dteFechaFinalizacion
        '
        Me.dteFechaFinalizacion.EditValue = Nothing
        Me.dteFechaFinalizacion.Enabled = False
        Me.dteFechaFinalizacion.Location = New System.Drawing.Point(967, 110)
        Me.dteFechaFinalizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinalizacion.MenuManager = Me.BarManager1
        Me.dteFechaFinalizacion.Name = "dteFechaFinalizacion"
        Me.dteFechaFinalizacion.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dteFechaFinalizacion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dteFechaFinalizacion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteFechaFinalizacion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteFechaFinalizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinalizacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinalizacion.Size = New System.Drawing.Size(242, 22)
        Me.dteFechaFinalizacion.StyleController = Me.lycOrdenProduccionEnsamble
        Me.dteFechaFinalizacion.TabIndex = 15
        '
        'dteFechaFabricacion
        '
        Me.dteFechaFabricacion.EditValue = Nothing
        Me.dteFechaFabricacion.Enabled = False
        Me.dteFechaFabricacion.Location = New System.Drawing.Point(967, 82)
        Me.dteFechaFabricacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFabricacion.MenuManager = Me.BarManager1
        Me.dteFechaFabricacion.Name = "dteFechaFabricacion"
        Me.dteFechaFabricacion.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dteFechaFabricacion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dteFechaFabricacion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteFechaFabricacion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteFechaFabricacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFabricacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFabricacion.Size = New System.Drawing.Size(242, 22)
        Me.dteFechaFabricacion.StyleController = Me.lycOrdenProduccionEnsamble
        Me.dteFechaFabricacion.TabIndex = 14
        '
        'txtNumSAP
        '
        Me.txtNumSAP.Enabled = False
        Me.txtNumSAP.Location = New System.Drawing.Point(967, 54)
        Me.txtNumSAP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumSAP.MaximumSize = New System.Drawing.Size(167, 20)
        Me.txtNumSAP.MenuManager = Me.BarManager1
        Me.txtNumSAP.MinimumSize = New System.Drawing.Size(167, 20)
        Me.txtNumSAP.Name = "txtNumSAP"
        Me.txtNumSAP.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNumSAP.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumSAP.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumSAP.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumSAP.Size = New System.Drawing.Size(167, 20)
        Me.txtNumSAP.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtNumSAP.TabIndex = 13
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(686, 54)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerie.MaximumSize = New System.Drawing.Size(133, 0)
        Me.txtSerie.MenuManager = Me.BarManager1
        Me.txtSerie.MinimumSize = New System.Drawing.Size(133, 0)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(133, 22)
        Me.txtSerie.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtSerie.TabIndex = 12
        '
        'slueAlmacen
        '
        Me.slueAlmacen.Location = New System.Drawing.Point(173, 194)
        Me.slueAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.slueAlmacen.MaximumSize = New System.Drawing.Size(167, 0)
        Me.slueAlmacen.MenuManager = Me.BarManager1
        Me.slueAlmacen.MinimumSize = New System.Drawing.Size(167, 0)
        Me.slueAlmacen.Name = "slueAlmacen"
        Me.slueAlmacen.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.slueAlmacen.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.slueAlmacen.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueAlmacen.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.slueAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueAlmacen.Properties.NullText = ""
        Me.slueAlmacen.Properties.View = Me.SearchLookUpEdit3View
        Me.slueAlmacen.Size = New System.Drawing.Size(167, 22)
        Me.slueAlmacen.StyleController = Me.lycOrdenProduccionEnsamble
        Me.slueAlmacen.TabIndex = 11
        '
        'SearchLookUpEdit3View
        '
        Me.SearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit3View.Name = "SearchLookUpEdit3View"
        Me.SearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Enabled = False
        Me.txtUnidadMedida.Location = New System.Drawing.Point(488, 166)
        Me.txtUnidadMedida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadMedida.MenuManager = Me.BarManager1
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtUnidadMedida.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtUnidadMedida.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtUnidadMedida.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtUnidadMedida.Size = New System.Drawing.Size(50, 22)
        Me.txtUnidadMedida.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtUnidadMedida.TabIndex = 10
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Enabled = False
        Me.txtNombreArticulo.Location = New System.Drawing.Point(173, 138)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNombreArticulo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombreArticulo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNombreArticulo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(365, 22)
        Me.txtNombreArticulo.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtNombreArticulo.TabIndex = 8
        '
        'slueCodigoArticulo
        '
        Me.slueCodigoArticulo.Enabled = False
        Me.slueCodigoArticulo.Location = New System.Drawing.Point(173, 110)
        Me.slueCodigoArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.slueCodigoArticulo.MaximumSize = New System.Drawing.Size(167, 0)
        Me.slueCodigoArticulo.MenuManager = Me.BarManager1
        Me.slueCodigoArticulo.MinimumSize = New System.Drawing.Size(167, 0)
        Me.slueCodigoArticulo.Name = "slueCodigoArticulo"
        Me.slueCodigoArticulo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.slueCodigoArticulo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.slueCodigoArticulo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueCodigoArticulo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.slueCodigoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoArticulo.Properties.NullText = ""
        Me.slueCodigoArticulo.Properties.View = Me.SearchLookUpEdit2View
        Me.slueCodigoArticulo.Size = New System.Drawing.Size(167, 22)
        Me.slueCodigoArticulo.StyleController = Me.lycOrdenProduccionEnsamble
        Me.slueCodigoArticulo.TabIndex = 7
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(173, 54)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.MaximumSize = New System.Drawing.Size(167, 0)
        Me.txtTipo.MenuManager = Me.BarManager1
        Me.txtTipo.MinimumSize = New System.Drawing.Size(167, 0)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtTipo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTipo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTipo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTipo.Size = New System.Drawing.Size(167, 22)
        Me.txtTipo.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtTipo.TabIndex = 5
        '
        'grdOrdenProduccionEnsamble
        '
        Me.grdOrdenProduccionEnsamble.DataMember = "dsdtOrdenProduccion"
        Me.grdOrdenProduccionEnsamble.DataSource = Me.DsOrdenesProduccion1
        Me.grdOrdenProduccionEnsamble.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdOrdenProduccionEnsamble.Location = New System.Drawing.Point(16, 237)
        Me.grdOrdenProduccionEnsamble.MainView = Me.grdviewordenProduccionEnsamble
        Me.grdOrdenProduccionEnsamble.Margin = New System.Windows.Forms.Padding(4)
        Me.grdOrdenProduccionEnsamble.Name = "grdOrdenProduccionEnsamble"
        Me.grdOrdenProduccionEnsamble.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueAlmacen, Me.rslueCodigo})
        Me.grdOrdenProduccionEnsamble.Size = New System.Drawing.Size(1208, 322)
        Me.grdOrdenProduccionEnsamble.TabIndex = 4
        Me.grdOrdenProduccionEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewordenProduccionEnsamble})
        '
        'DsOrdenesProduccion1
        '
        Me.DsOrdenesProduccion1.DataSetName = "dsOrdenesProduccion"
        Me.DsOrdenesProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewordenProduccionEnsamble
        '
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewordenProduccionEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewordenProduccionEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewordenProduccionEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewordenProduccionEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewordenProduccionEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewordenProduccionEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewordenProduccionEnsamble.ColumnPanelRowHeight = 38
        Me.grdviewordenProduccionEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCantidadBase, Me.colRequerido, Me.colStock, Me.colSolicitado, Me.colAlmacen})
        Me.grdviewordenProduccionEnsamble.GridControl = Me.grdOrdenProduccionEnsamble
        Me.grdviewordenProduccionEnsamble.Name = "grdviewordenProduccionEnsamble"
        Me.grdviewordenProduccionEnsamble.OptionsCustomization.AllowSort = False
        Me.grdviewordenProduccionEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewordenProduccionEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewordenProduccionEnsamble.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewordenProduccionEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewordenProduccionEnsamble.PaintStyleName = "Web"
        '
        'colNumLinea
        '
        Me.colNumLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumLinea.Caption = "#"
        Me.colNumLinea.FieldName = "NumLinea"
        Me.colNumLinea.Name = "colNumLinea"
        Me.colNumLinea.OptionsColumn.ReadOnly = True
        Me.colNumLinea.OptionsColumn.TabStop = False
        Me.colNumLinea.Visible = True
        Me.colNumLinea.VisibleIndex = 0
        Me.colNumLinea.Width = 43
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.ColumnEdit = Me.rslueCodigo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        Me.colCodigoArticulo.Width = 115
        '
        'rslueCodigo
        '
        Me.rslueCodigo.AutoHeight = False
        Me.rslueCodigo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigo.Name = "rslueCodigo"
        Me.rslueCodigo.NullText = ""
        Me.rslueCodigo.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.OptionsColumn.TabStop = False
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 365
        '
        'colCantidadBase
        '
        Me.colCantidadBase.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidadBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidadBase.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCantidadBase.Caption = "Cantidad Base"
        Me.colCantidadBase.FieldName = "CantidadBase"
        Me.colCantidadBase.Name = "colCantidadBase"
        Me.colCantidadBase.OptionsColumn.ReadOnly = True
        Me.colCantidadBase.Visible = True
        Me.colCantidadBase.VisibleIndex = 3
        Me.colCantidadBase.Width = 90
        '
        'colRequerido
        '
        Me.colRequerido.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequerido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequerido.FieldName = "Requerido"
        Me.colRequerido.Name = "colRequerido"
        Me.colRequerido.Width = 90
        '
        'colStock
        '
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.ReadOnly = True
        Me.colStock.OptionsColumn.TabStop = False
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 4
        Me.colStock.Width = 90
        '
        'colSolicitado
        '
        Me.colSolicitado.AppearanceHeader.Options.UseTextOptions = True
        Me.colSolicitado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSolicitado.FieldName = "Solicitado"
        Me.colSolicitado.Name = "colSolicitado"
        Me.colSolicitado.Visible = True
        Me.colSolicitado.VisibleIndex = 5
        Me.colSolicitado.Width = 90
        '
        'colAlmacen
        '
        Me.colAlmacen.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlmacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen.ColumnEdit = Me.rslueAlmacen
        Me.colAlmacen.FieldName = "Almacen"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.Visible = True
        Me.colAlmacen.VisibleIndex = 6
        Me.colAlmacen.Width = 90
        '
        'rslueAlmacen
        '
        Me.rslueAlmacen.AutoHeight = False
        Me.rslueAlmacen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueAlmacen.Name = "rslueAlmacen"
        Me.rslueAlmacen.NullText = ""
        Me.rslueAlmacen.ShowClearButton = False
        Me.rslueAlmacen.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(173, 82)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.MaximumSize = New System.Drawing.Size(167, 0)
        Me.txtEstado.MenuManager = Me.BarManager1
        Me.txtEstado.MinimumSize = New System.Drawing.Size(167, 0)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtEstado.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtEstado.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtEstado.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtEstado.Size = New System.Drawing.Size(167, 22)
        Me.txtEstado.StyleController = Me.lycOrdenProduccionEnsamble
        Me.txtEstado.TabIndex = 6
        '
        'spinCantidadPlanificada
        '
        Me.spinCantidadPlanificada.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinCantidadPlanificada.Location = New System.Drawing.Point(173, 166)
        Me.spinCantidadPlanificada.Margin = New System.Windows.Forms.Padding(4)
        Me.spinCantidadPlanificada.MaximumSize = New System.Drawing.Size(167, 0)
        Me.spinCantidadPlanificada.MenuManager = Me.BarManager1
        Me.spinCantidadPlanificada.MinimumSize = New System.Drawing.Size(167, 0)
        Me.spinCantidadPlanificada.Name = "spinCantidadPlanificada"
        Me.spinCantidadPlanificada.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinCantidadPlanificada.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinCantidadPlanificada.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinCantidadPlanificada.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinCantidadPlanificada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinCantidadPlanificada.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.spinCantidadPlanificada.Properties.Mask.EditMask = "{0:n0}"
        Me.spinCantidadPlanificada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.spinCantidadPlanificada.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinCantidadPlanificada.Properties.MaxValue = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.spinCantidadPlanificada.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinCantidadPlanificada.Size = New System.Drawing.Size(167, 22)
        Me.spinCantidadPlanificada.StyleController = Me.lycOrdenProduccionEnsamble
        Me.spinCantidadPlanificada.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem16, Me.LayoutControlGroup2, Me.LayoutControlItem17, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1240, 646)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOrdenProduccionEnsamble
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 221)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1214, 328)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem16.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem16.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem16.Control = Me.txtComentarios
        Me.LayoutControlItem16.CustomizationFormText = "Comentarios"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(552, 549)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(662, 71)
        Me.LayoutControlItem16.Text = "Comentarios"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Orden de Fabricación"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1214, 221)
        Me.LayoutControlGroup2.Text = "Orden de Fabricación"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtTipo
        Me.LayoutControlItem2.CustomizationFormText = "Tipo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(315, 28)
        Me.LayoutControlItem2.Text = "Tipo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtEstado
        Me.LayoutControlItem3.CustomizationFormText = "Estado"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(315, 28)
        Me.LayoutControlItem3.Text = "Estado"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.slueCodigoArticulo
        Me.LayoutControlItem4.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(315, 28)
        Me.LayoutControlItem4.Text = "Codigo Articulo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtNombreArticulo
        Me.LayoutControlItem5.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(513, 28)
        Me.LayoutControlItem5.Text = "Nombre Articulo"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.spinCantidadPlanificada
        Me.LayoutControlItem6.CustomizationFormText = "Cantidad Planificado"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(315, 28)
        Me.LayoutControlItem6.Text = "Cantidad Planificado"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.slueAlmacen
        Me.LayoutControlItem8.CustomizationFormText = "Almacen"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 140)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(513, 28)
        Me.LayoutControlItem8.Text = "Almacen"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtUnidadMedida
        Me.LayoutControlItem7.CustomizationFormText = "Unidad Medida"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(315, 112)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem7.Text = "Unidad Medida"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(139, 17)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(315, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(198, 84)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.txtSerie
        Me.LayoutControlItem9.CustomizationFormText = "Serie"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(513, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(281, 168)
        Me.LayoutControlItem9.Text = "Serie"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtNumSAP
        Me.LayoutControlItem10.CustomizationFormText = "Num SAP"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(794, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem10.Text = "Num SAP"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem11.Control = Me.dteFechaFabricacion
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(794, 28)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem11.Text = "Fecha Fabricación"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.dteFechaFinalizacion
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(794, 56)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem12.Text = "Fecha Finalización"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.txtUsuario
        Me.LayoutControlItem13.CustomizationFormText = "Usuario"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(794, 84)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem13.Text = "Usuario"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.txtPrioridad
        Me.LayoutControlItem14.CustomizationFormText = "Prioridad"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(794, 112)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem14.Text = "Prioridad"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.slueTipoOrden
        Me.LayoutControlItem15.CustomizationFormText = "Tipo Orden"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(794, 140)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(390, 28)
        Me.LayoutControlItem15.Text = "Tipo Orden"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(139, 17)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.sbdcOrdenes
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 549)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(399, 45)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 594)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(399, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(399, 549)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(153, 71)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barOrdenes})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEliminarLinea, Me.barbtnStock})
        Me.BarManager2.MaxItemId = 2
        '
        'barOrdenes
        '
        Me.barOrdenes.BarName = "Tools"
        Me.barOrdenes.DockCol = 0
        Me.barOrdenes.DockRow = 0
        Me.barOrdenes.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barOrdenes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminarLinea, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCambiarComponente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnStock, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barOrdenes.OptionsBar.AllowQuickCustomization = False
        Me.barOrdenes.OptionsBar.DrawBorder = False
        Me.barOrdenes.OptionsBar.DrawDragBorder = False
        Me.barOrdenes.StandaloneBarDockControl = Me.sbdcOrdenes
        Me.barOrdenes.Text = "Tools"
        '
        'barbtnEliminarLinea
        '
        Me.barbtnEliminarLinea.Caption = "Eliminar Linea"
        Me.barbtnEliminarLinea.Enabled = False
        Me.barbtnEliminarLinea.Id = 0
        Me.barbtnEliminarLinea.ImageOptions.Image = CType(resources.GetObject("barbtnEliminarLinea.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminarLinea.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminarLinea.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminarLinea.Name = "barbtnEliminarLinea"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Id = 1
        Me.barbtnStock.ImageOptions.Image = CType(resources.GetObject("barbtnStock.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnStock.ImageOptions.LargeImage = CType(resources.GetObject("barbtnStock.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnStock.Name = "barbtnStock"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl1.Size = New System.Drawing.Size(1240, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 732)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl2.Size = New System.Drawing.Size(1240, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 732)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1240, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 732)
        '
        'frmOrdenProduccionEnsamble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 732)
        Me.Controls.Add(Me.lycOrdenProduccionEnsamble)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOrdenProduccionEnsamble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Produccion / Ensamble"
        CType(Me.lycOrdenProduccionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycOrdenProduccionEnsamble.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueTipoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrioridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinalizacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinalizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFabricacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFabricacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSAP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdenProduccionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOrdenesProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewordenProduccionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinCantidadPlanificada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycOrdenProduccionEnsamble As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdOrdenProduccionEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewordenProduccionEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dteFechaFinalizacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaFabricacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumSAP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slueAlmacen As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtUnidadMedida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slueCodigoArticulo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents slueTipoOrden As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPrioridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsOrdenesProduccion1 As waProduccion_Pedidos.dsOrdenesProduccion
    Friend WithEvents colNumLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadBase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequerido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueAlmacen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnLiberarOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnCerrarOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents spinCantidadPlanificada As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sbdcOrdenes As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barOrdenes As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminarLinea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnCambiarComponente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnNuevaOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnBuscarDocumento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueCodigo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnCopiarDesmonte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCopiarNueva As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEspecial As DevExpress.XtraBars.BarButtonItem
End Class
