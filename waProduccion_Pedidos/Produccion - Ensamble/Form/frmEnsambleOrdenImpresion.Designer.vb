<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnsambleOrdenImpresion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnsambleOrdenImpresion))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.spinUnidadesEnfriado = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barchkDetalle = New DevExpress.XtraBars.BarEditItem()
        Me.rchkImprimirDetalle = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.barbtnImprimirInstrucciones = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dcmEnsamble = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerTop = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.dcpAdvertenciasDeTrabajo = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.grdAdvertencias = New DevExpress.XtraGrid.GridControl()
        Me.DsEnsambleOrdenImpresion1 = New waProduccion_Pedidos.dsEnsambleOrdenImpresion()
        Me.grdviewAdvertencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dcpListaDeEmpaque = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.grdListaEmpaque = New DevExpress.XtraGrid.GridControl()
        Me.grdviewListaEmpaque = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUEmpaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonasEquipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spinEquipoPersonasSTD = New DevExpress.XtraEditors.SpinEdit()
        Me.mmeInstruccionesDeTrabajo = New DevExpress.XtraEditors.MemoEdit()
        Me.txtEquipoPersonas = New DevExpress.XtraEditors.TextEdit()
        Me.txtEnsambleXHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinXArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSegXArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdImpresionEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.grdviewImpresionEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.spinUnidadesEnfriado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkImprimirDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dcmEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerTop.SuspendLayout()
        Me.dcpAdvertenciasDeTrabajo.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        CType(Me.grdAdvertencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewAdvertencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dcpListaDeEmpaque.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.grdListaEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinEquipoPersonasSTD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeInstruccionesDeTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipoPersonas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnsambleXHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinXArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSegXArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdImpresionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewImpresionEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.spinUnidadesEnfriado)
        Me.LayoutControl1.Controls.Add(Me.spinEquipoPersonasSTD)
        Me.LayoutControl1.Controls.Add(Me.mmeInstruccionesDeTrabajo)
        Me.LayoutControl1.Controls.Add(Me.txtEquipoPersonas)
        Me.LayoutControl1.Controls.Add(Me.txtEnsambleXHora)
        Me.LayoutControl1.Controls.Add(Me.txtMinXArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtSegXArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.grdImpresionEnsamble)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(990, 567)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'spinUnidadesEnfriado
        '
        Me.spinUnidadesEnfriado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinUnidadesEnfriado.Enabled = False
        Me.spinUnidadesEnfriado.Location = New System.Drawing.Point(906, 114)
        Me.spinUnidadesEnfriado.MaximumSize = New System.Drawing.Size(60, 20)
        Me.spinUnidadesEnfriado.MenuManager = Me.BarManager1
        Me.spinUnidadesEnfriado.MinimumSize = New System.Drawing.Size(60, 20)
        Me.spinUnidadesEnfriado.Name = "spinUnidadesEnfriado"
        Me.spinUnidadesEnfriado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinUnidadesEnfriado.Size = New System.Drawing.Size(60, 20)
        Me.spinUnidadesEnfriado.StyleController = Me.LayoutControl1
        Me.spinUnidadesEnfriado.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.dcmEnsamble
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnImprimirInstrucciones, Me.barbtnImprimir, Me.barchkDetalle, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rchkImprimirDetalle})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barchkDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirInstrucciones, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 5
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnExportarXlsx.Id = 6
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnImprimir
        '
        Me.barbtnImprimir.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajos"
        Me.barbtnImprimir.Id = 2
        Me.barbtnImprimir.ImageOptions.Image = CType(resources.GetObject("barbtnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimir.Name = "barbtnImprimir"
        '
        'barchkDetalle
        '
        Me.barchkDetalle.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detalle"
        Me.barchkDetalle.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.barchkDetalle.Edit = Me.rchkImprimirDetalle
        Me.barchkDetalle.EditValue = False
        Me.barchkDetalle.Id = 4
        Me.barchkDetalle.Name = "barchkDetalle"
        '
        'rchkImprimirDetalle
        '
        Me.rchkImprimirDetalle.AutoHeight = False
        Me.rchkImprimirDetalle.Name = "rchkImprimirDetalle"
        '
        'barbtnImprimirInstrucciones
        '
        Me.barbtnImprimirInstrucciones.Caption = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instrucciones"
        Me.barbtnImprimirInstrucciones.Id = 1
        Me.barbtnImprimirInstrucciones.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirInstrucciones.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirInstrucciones.Name = "barbtnImprimirInstrucciones"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(990, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 609)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(990, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 589)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(990, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 589)
        '
        'dcmEnsamble
        '
        Me.dcmEnsamble.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerTop})
        Me.dcmEnsamble.Form = Me
        Me.dcmEnsamble.MenuManager = Me.BarManager1
        Me.dcmEnsamble.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerTop
        '
        Me.hideContainerTop.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerTop.Controls.Add(Me.dcpAdvertenciasDeTrabajo)
        Me.hideContainerTop.Controls.Add(Me.dcpListaDeEmpaque)
        Me.hideContainerTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.hideContainerTop.Location = New System.Drawing.Point(0, 20)
        Me.hideContainerTop.Name = "hideContainerTop"
        Me.hideContainerTop.Size = New System.Drawing.Size(990, 22)
        '
        'dcpAdvertenciasDeTrabajo
        '
        Me.dcpAdvertenciasDeTrabajo.Controls.Add(Me.ControlContainer1)
        Me.dcpAdvertenciasDeTrabajo.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.dcpAdvertenciasDeTrabajo.ID = New System.Guid("6c8833f1-d11a-4ca5-877d-4a9bf256136d")
        Me.dcpAdvertenciasDeTrabajo.Image = CType(resources.GetObject("dcpAdvertenciasDeTrabajo.Image"), System.Drawing.Image)
        Me.dcpAdvertenciasDeTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.dcpAdvertenciasDeTrabajo.Name = "dcpAdvertenciasDeTrabajo"
        Me.dcpAdvertenciasDeTrabajo.Options.AllowFloating = False
        Me.dcpAdvertenciasDeTrabajo.Options.ShowCloseButton = False
        Me.dcpAdvertenciasDeTrabajo.OriginalSize = New System.Drawing.Size(200, 309)
        Me.dcpAdvertenciasDeTrabajo.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.dcpAdvertenciasDeTrabajo.SavedIndex = 0
        Me.dcpAdvertenciasDeTrabajo.Size = New System.Drawing.Size(990, 309)
        Me.dcpAdvertenciasDeTrabajo.Text = "Advertencias de Trabajo"
        Me.dcpAdvertenciasDeTrabajo.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.grdAdvertencias)
        Me.ControlContainer1.Location = New System.Drawing.Point(4, 23)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(982, 281)
        Me.ControlContainer1.TabIndex = 0
        '
        'grdAdvertencias
        '
        Me.grdAdvertencias.DataMember = "dadtAdvertenciasDeTrabajo"
        Me.grdAdvertencias.DataSource = Me.DsEnsambleOrdenImpresion1
        Me.grdAdvertencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAdvertencias.Location = New System.Drawing.Point(0, 0)
        Me.grdAdvertencias.MainView = Me.grdviewAdvertencias
        Me.grdAdvertencias.MenuManager = Me.BarManager1
        Me.grdAdvertencias.Name = "grdAdvertencias"
        Me.grdAdvertencias.Size = New System.Drawing.Size(982, 281)
        Me.grdAdvertencias.TabIndex = 0
        Me.grdAdvertencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewAdvertencias})
        '
        'DsEnsambleOrdenImpresion1
        '
        Me.DsEnsambleOrdenImpresion1.DataSetName = " "
        Me.DsEnsambleOrdenImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewAdvertencias
        '
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewAdvertencias.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.Row.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.Row.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.ColumnPanelRowHeight = 35
        Me.grdviewAdvertencias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colNumLinea, Me.colDescripcion})
        Me.grdviewAdvertencias.GridControl = Me.grdAdvertencias
        Me.grdviewAdvertencias.Name = "grdviewAdvertencias"
        Me.grdviewAdvertencias.OptionsBehavior.Editable = False
        Me.grdviewAdvertencias.OptionsBehavior.ReadOnly = True
        Me.grdviewAdvertencias.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewAdvertencias.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewAdvertencias.OptionsView.ShowGroupPanel = False
        Me.grdviewAdvertencias.PaintStyleName = "Web"
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 95
        '
        'colNumLinea
        '
        Me.colNumLinea.FieldName = "NumLinea"
        Me.colNumLinea.Name = "colNumLinea"
        Me.colNumLinea.Visible = True
        Me.colNumLinea.VisibleIndex = 1
        Me.colNumLinea.Width = 69
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 582
        '
        'dcpListaDeEmpaque
        '
        Me.dcpListaDeEmpaque.Controls.Add(Me.DockPanel1_Container)
        Me.dcpListaDeEmpaque.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.dcpListaDeEmpaque.ID = New System.Guid("8e31567a-6076-4fba-a730-a30b3c6a26e8")
        Me.dcpListaDeEmpaque.Image = CType(resources.GetObject("dcpListaDeEmpaque.Image"), System.Drawing.Image)
        Me.dcpListaDeEmpaque.Location = New System.Drawing.Point(0, 0)
        Me.dcpListaDeEmpaque.Name = "dcpListaDeEmpaque"
        Me.dcpListaDeEmpaque.Options.AllowFloating = False
        Me.dcpListaDeEmpaque.Options.ShowCloseButton = False
        Me.dcpListaDeEmpaque.OriginalSize = New System.Drawing.Size(200, 349)
        Me.dcpListaDeEmpaque.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.dcpListaDeEmpaque.SavedIndex = 0
        Me.dcpListaDeEmpaque.Size = New System.Drawing.Size(990, 349)
        Me.dcpListaDeEmpaque.Text = "Lista de Empaque"
        Me.dcpListaDeEmpaque.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.grdListaEmpaque)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(982, 321)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'grdListaEmpaque
        '
        Me.grdListaEmpaque.DataMember = "dsdtListaEmpaque"
        Me.grdListaEmpaque.DataSource = Me.DsEnsambleOrdenImpresion1
        Me.grdListaEmpaque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdListaEmpaque.Location = New System.Drawing.Point(0, 0)
        Me.grdListaEmpaque.MainView = Me.grdviewListaEmpaque
        Me.grdListaEmpaque.MenuManager = Me.BarManager1
        Me.grdListaEmpaque.Name = "grdListaEmpaque"
        Me.grdListaEmpaque.Size = New System.Drawing.Size(982, 321)
        Me.grdListaEmpaque.TabIndex = 0
        Me.grdListaEmpaque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaEmpaque})
        '
        'grdviewListaEmpaque
        '
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaEmpaque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaEmpaque.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaEmpaque.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewListaEmpaque.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaEmpaque.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaEmpaque.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaEmpaque.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaEmpaque.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaEmpaque.ColumnPanelRowHeight = 35
        Me.grdviewListaEmpaque.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colDeLinea, Me.colId_Empaque, Me.colLinea, Me.colCodigo, Me.colNombreCodigo, Me.colCantidad, Me.colUM, Me.colUEmpaque, Me.colComentarios, Me.colPersonasEquipo})
        Me.grdviewListaEmpaque.GridControl = Me.grdListaEmpaque
        Me.grdviewListaEmpaque.GroupCount = 1
        Me.grdviewListaEmpaque.Name = "grdviewListaEmpaque"
        Me.grdviewListaEmpaque.OptionsBehavior.AutoExpandAllGroups = True
        Me.grdviewListaEmpaque.OptionsBehavior.Editable = False
        Me.grdviewListaEmpaque.OptionsBehavior.ReadOnly = True
        Me.grdviewListaEmpaque.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaEmpaque.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaEmpaque.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaEmpaque.OptionsView.ShowGroupPanel = False
        Me.grdviewListaEmpaque.PaintStyleName = "Web"
        Me.grdviewListaEmpaque.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colId_Empaque, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        'colDeLinea
        '
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        '
        'colId_Empaque
        '
        Me.colId_Empaque.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId_Empaque.AppearanceHeader.Options.UseFont = True
        Me.colId_Empaque.AppearanceHeader.Options.UseTextOptions = True
        Me.colId_Empaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId_Empaque.Caption = "Empaque"
        Me.colId_Empaque.FieldName = "Id_Empaque"
        Me.colId_Empaque.Name = "colId_Empaque"
        Me.colId_Empaque.Visible = True
        Me.colId_Empaque.VisibleIndex = 2
        '
        'colLinea
        '
        Me.colLinea.AppearanceCell.Options.UseTextOptions = True
        Me.colLinea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLinea.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLinea.AppearanceHeader.Options.UseFont = True
        Me.colLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLinea.Caption = "#"
        Me.colLinea.FieldName = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.Visible = True
        Me.colLinea.VisibleIndex = 0
        Me.colLinea.Width = 60
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 125
        '
        'colNombreCodigo
        '
        Me.colNombreCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCodigo.AppearanceHeader.Options.UseFont = True
        Me.colNombreCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCodigo.Caption = "Nombre"
        Me.colNombreCodigo.FieldName = "NombreCodigo"
        Me.colNombreCodigo.Name = "colNombreCodigo"
        Me.colNombreCodigo.Visible = True
        Me.colNombreCodigo.VisibleIndex = 2
        Me.colNombreCodigo.Width = 132
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 73
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.AppearanceHeader.Options.UseTextOptions = True
        Me.colUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.Caption = "U/Medida"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 4
        Me.colUM.Width = 80
        '
        'colUEmpaque
        '
        Me.colUEmpaque.AppearanceCell.Options.UseTextOptions = True
        Me.colUEmpaque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUEmpaque.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUEmpaque.AppearanceHeader.Options.UseFont = True
        Me.colUEmpaque.AppearanceHeader.Options.UseTextOptions = True
        Me.colUEmpaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUEmpaque.Caption = "U/Empaque"
        Me.colUEmpaque.FieldName = "UEmpaque"
        Me.colUEmpaque.Name = "colUEmpaque"
        Me.colUEmpaque.Visible = True
        Me.colUEmpaque.VisibleIndex = 5
        Me.colUEmpaque.Width = 80
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 6
        Me.colComentarios.Width = 350
        '
        'colPersonasEquipo
        '
        Me.colPersonasEquipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPersonasEquipo.AppearanceHeader.Options.UseFont = True
        Me.colPersonasEquipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPersonasEquipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPersonasEquipo.FieldName = "PersonasEquipo"
        Me.colPersonasEquipo.Name = "colPersonasEquipo"
        Me.colPersonasEquipo.Width = 146
        '
        'spinEquipoPersonasSTD
        '
        Me.spinEquipoPersonasSTD.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinEquipoPersonasSTD.Enabled = False
        Me.spinEquipoPersonasSTD.Location = New System.Drawing.Point(631, 114)
        Me.spinEquipoPersonasSTD.MaximumSize = New System.Drawing.Size(60, 20)
        Me.spinEquipoPersonasSTD.MenuManager = Me.BarManager1
        Me.spinEquipoPersonasSTD.MinimumSize = New System.Drawing.Size(60, 20)
        Me.spinEquipoPersonasSTD.Name = "spinEquipoPersonasSTD"
        Me.spinEquipoPersonasSTD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinEquipoPersonasSTD.Size = New System.Drawing.Size(60, 20)
        Me.spinEquipoPersonasSTD.StyleController = Me.LayoutControl1
        Me.spinEquipoPersonasSTD.TabIndex = 8
        '
        'mmeInstruccionesDeTrabajo
        '
        Me.mmeInstruccionesDeTrabajo.Enabled = False
        Me.mmeInstruccionesDeTrabajo.Location = New System.Drawing.Point(511, 42)
        Me.mmeInstruccionesDeTrabajo.MenuManager = Me.BarManager1
        Me.mmeInstruccionesDeTrabajo.Name = "mmeInstruccionesDeTrabajo"
        Me.mmeInstruccionesDeTrabajo.Size = New System.Drawing.Size(455, 68)
        Me.mmeInstruccionesDeTrabajo.StyleController = Me.LayoutControl1
        Me.mmeInstruccionesDeTrabajo.TabIndex = 7
        '
        'txtEquipoPersonas
        '
        Me.txtEquipoPersonas.Enabled = False
        Me.txtEquipoPersonas.Location = New System.Drawing.Point(366, 114)
        Me.txtEquipoPersonas.MenuManager = Me.BarManager1
        Me.txtEquipoPersonas.Name = "txtEquipoPersonas"
        Me.txtEquipoPersonas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEquipoPersonas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEquipoPersonas.Size = New System.Drawing.Size(100, 20)
        Me.txtEquipoPersonas.StyleController = Me.LayoutControl1
        Me.txtEquipoPersonas.TabIndex = 6
        '
        'txtEnsambleXHora
        '
        Me.txtEnsambleXHora.Enabled = False
        Me.txtEnsambleXHora.Location = New System.Drawing.Point(144, 114)
        Me.txtEnsambleXHora.MenuManager = Me.BarManager1
        Me.txtEnsambleXHora.Name = "txtEnsambleXHora"
        Me.txtEnsambleXHora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEnsambleXHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEnsambleXHora.Size = New System.Drawing.Size(98, 20)
        Me.txtEnsambleXHora.StyleController = Me.LayoutControl1
        Me.txtEnsambleXHora.TabIndex = 5
        '
        'txtMinXArticulo
        '
        Me.txtMinXArticulo.Enabled = False
        Me.txtMinXArticulo.Location = New System.Drawing.Point(366, 90)
        Me.txtMinXArticulo.MenuManager = Me.BarManager1
        Me.txtMinXArticulo.Name = "txtMinXArticulo"
        Me.txtMinXArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinXArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinXArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinXArticulo.StyleController = Me.LayoutControl1
        Me.txtMinXArticulo.TabIndex = 4
        '
        'txtSegXArticulo
        '
        Me.txtSegXArticulo.Enabled = False
        Me.txtSegXArticulo.Location = New System.Drawing.Point(144, 90)
        Me.txtSegXArticulo.MenuManager = Me.BarManager1
        Me.txtSegXArticulo.Name = "txtSegXArticulo"
        Me.txtSegXArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSegXArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSegXArticulo.Size = New System.Drawing.Size(98, 20)
        Me.txtSegXArticulo.StyleController = Me.LayoutControl1
        Me.txtSegXArticulo.TabIndex = 3
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Enabled = False
        Me.txtNombreArticulo.Location = New System.Drawing.Point(144, 66)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(322, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 2
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Enabled = False
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(144, 42)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(322, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 0
        '
        'grdImpresionEnsamble
        '
        Me.grdImpresionEnsamble.DataMember = "dsdtEnsambleOrdenImpresion"
        Me.grdImpresionEnsamble.DataSource = Me.DsEnsambleOrdenImpresion1
        Me.grdImpresionEnsamble.Location = New System.Drawing.Point(12, 175)
        Me.grdImpresionEnsamble.MainView = Me.grdviewImpresionEnsamble
        Me.grdImpresionEnsamble.Name = "grdImpresionEnsamble"
        Me.grdImpresionEnsamble.Size = New System.Drawing.Size(966, 380)
        Me.grdImpresionEnsamble.TabIndex = 10
        Me.grdImpresionEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewImpresionEnsamble})
        '
        'grdviewImpresionEnsamble
        '
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewImpresionEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.Preview.Options.UseFont = True
        Me.grdviewImpresionEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewImpresionEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewImpresionEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewImpresionEnsamble.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewImpresionEnsamble.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewImpresionEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewImpresionEnsamble.ColumnPanelRowHeight = 35
        Me.grdviewImpresionEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCodigoPadre, Me.colColor, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProdFinal, Me.colTipoMaterial})
        Me.grdviewImpresionEnsamble.GridControl = Me.grdImpresionEnsamble
        Me.grdviewImpresionEnsamble.Name = "grdviewImpresionEnsamble"
        Me.grdviewImpresionEnsamble.OptionsBehavior.Editable = False
        Me.grdviewImpresionEnsamble.OptionsBehavior.ReadOnly = True
        Me.grdviewImpresionEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewImpresionEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewImpresionEnsamble.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewImpresionEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewImpresionEnsamble.PaintStyleName = "Web"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 125
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 385
        '
        'colCodigoPadre
        '
        Me.colCodigoPadre.FieldName = "CodigoPadre"
        Me.colCodigoPadre.Name = "colCodigoPadre"
        '
        'colColor
        '
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 2
        Me.colPlaneado.Width = 85
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 3
        Me.colCompletado.Width = 85
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 4
        Me.colPendiente.Width = 85
        '
        'colProdFinal
        '
        Me.colProdFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colProdFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProdFinal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        Me.colProdFinal.Visible = True
        Me.colProdFinal.VisibleIndex = 5
        Me.colProdFinal.Width = 85
        '
        'colTipoMaterial
        '
        Me.colTipoMaterial.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTipoMaterial.FieldName = "TipoMaterial"
        Me.colTipoMaterial.Name = "colTipoMaterial"
        Me.colTipoMaterial.Visible = True
        Me.colTipoMaterial.VisibleIndex = 6
        Me.colTipoMaterial.Width = 80
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.EmptySpaceItem2, Me.LayoutControlGroup3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(990, 567)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdImpresionEnsamble
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 163)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(970, 384)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.Black
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(470, 138)
        Me.LayoutControlGroup2.Text = "Parametros de Ensamble"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(446, 24)
        Me.LayoutControlItem2.Text = "Codigo Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtNombreArticulo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(446, 24)
        Me.LayoutControlItem3.Text = "Nombre Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtSegXArticulo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem4.Text = "Seg. X Articulo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtEnsambleXHora
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem6.Text = "Ensamble X Hora"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtEquipoPersonas
        Me.LayoutControlItem7.Location = New System.Drawing.Point(222, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(224, 24)
        Me.LayoutControlItem7.Text = "Equipo Personas"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtMinXArticulo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(222, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(224, 24)
        Me.LayoutControlItem5.Text = "Min. X Articulo"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(470, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(17, 138)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(487, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(483, 138)
        Me.LayoutControlGroup3.Text = "Instrucciones de Trabajo"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.mmeInstruccionesDeTrabajo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(459, 72)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.spinEquipoPersonasSTD
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem9.Text = "Equipo Personas STD"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.spinUnidadesEnfriado
        Me.LayoutControlItem10.Location = New System.Drawing.Point(275, 72)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem10.Text = "Unidades Enfriado"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(184, 72)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(91, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 138)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(970, 25)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmEnsambleOrdenImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.hideContainerTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEnsambleOrdenImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa Impresion Ensamble"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.spinUnidadesEnfriado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkImprimirDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dcmEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerTop.ResumeLayout(False)
        Me.dcpAdvertenciasDeTrabajo.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        CType(Me.grdAdvertencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewAdvertencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dcpListaDeEmpaque.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.grdListaEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinEquipoPersonasSTD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeInstruccionesDeTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipoPersonas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnsambleXHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinXArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSegXArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdImpresionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewImpresionEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdImpresionEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewImpresionEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsEnsambleOrdenImpresion1 As dsEnsambleOrdenImpresion
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEquipoPersonas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEnsambleXHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinXArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSegXArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dcmEnsamble As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents hideContainerTop As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents dcpListaDeEmpaque As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents grdListaEmpaque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaEmpaque As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEmpaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonasEquipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spinUnidadesEnfriado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinEquipoPersonasSTD As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents mmeInstruccionesDeTrabajo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dcpAdvertenciasDeTrabajo As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents grdAdvertencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewAdvertencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirInstrucciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barchkDetalle As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rchkImprimirDetalle As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
End Class
