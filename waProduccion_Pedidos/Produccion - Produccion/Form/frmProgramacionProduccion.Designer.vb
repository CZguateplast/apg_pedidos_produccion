<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramacionProduccion))
        Dim ShapeTransition1 As DevExpress.Utils.Animation.ShapeTransition = New DevExpress.Utils.Animation.ShapeTransition()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycProgramacionProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.splitProgramacionProduccion = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycSplit1 = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcSplit1Vertical = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnProgramacionGrafica = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProgramacionFinal = New DevExpress.XtraBars.BarButtonItem()
        Me.bwsVista = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.wsmVistasOrdenes = New DevExpress.Utils.WorkspaceManager()
        Me.barbtnEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenesProduccion_Todas = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcSplit1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.sbdcSplit2 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barbtnQuitar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnColapsarTodo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExpandir = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnColapsar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBajar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.grdOrdenesProduccion = New DevExpress.XtraGrid.GridControl()
        Me.DsProgramacionProduccion = New waProduccion_Pedidos.dsProgramacionProduccion()
        Me.grdviewOrdenesProduccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmergencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreferencial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridadEmergencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rsluePrioridadEmergencias = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProduccionHora1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromedioMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lycSplit2 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdProgramacionAsignados = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProgramacionAsignados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPreferencial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrioridadMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridad1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduccionHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DsProgramacionProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barSplit1 = New DevExpress.XtraBars.Bar()
        Me.barbtnColumnas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.barbtnVistaDefault = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnVistaGrupoMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.barwVistas = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barSplit1Vertical = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrupoMaquina = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProgramacionAutomatica = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetalleColores = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager4 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl12 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarManager5 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnIniciarProceso = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetener = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSubir = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnMaquinaCambiar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnMantenimiento1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl13 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl14 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl15 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl16 = New DevExpress.XtraBars.BarDockControl()
        Me.barbtnExpandirTodo = New DevExpress.XtraBars.BarButtonItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True, True)
        CType(Me.lycProgramacionProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycProgramacionProduccion.SuspendLayout()
        CType(Me.splitProgramacionProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitProgramacionProduccion.SuspendLayout()
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdenesProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProgramacionProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewOrdenesProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rsluePrioridadEmergencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit2.SuspendLayout()
        CType(Me.grdProgramacionAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProgramacionAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProgramacionProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 0
        Me.colEstado.Width = 100
        '
        'lycProgramacionProduccion
        '
        Me.lycProgramacionProduccion.Controls.Add(Me.splitProgramacionProduccion)
        Me.lycProgramacionProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycProgramacionProduccion.Location = New System.Drawing.Point(0, 29)
        Me.lycProgramacionProduccion.Name = "lycProgramacionProduccion"
        Me.lycProgramacionProduccion.Root = Me.LayoutControlGroup1
        Me.lycProgramacionProduccion.Size = New System.Drawing.Size(1562, 663)
        Me.lycProgramacionProduccion.TabIndex = 0
        Me.lycProgramacionProduccion.Text = "LayoutControl1"
        '
        'splitProgramacionProduccion
        '
        Me.splitProgramacionProduccion.Location = New System.Drawing.Point(12, 12)
        Me.splitProgramacionProduccion.Name = "splitProgramacionProduccion"
        Me.splitProgramacionProduccion.Panel1.Controls.Add(Me.lycSplit1)
        Me.splitProgramacionProduccion.Panel1.Text = "Panel1"
        Me.splitProgramacionProduccion.Panel2.Controls.Add(Me.lycSplit2)
        Me.splitProgramacionProduccion.Panel2.Text = "Panel2"
        Me.splitProgramacionProduccion.Size = New System.Drawing.Size(1538, 639)
        Me.splitProgramacionProduccion.SplitterPosition = 716
        Me.splitProgramacionProduccion.TabIndex = 5
        Me.splitProgramacionProduccion.Text = "SplitContainerControl1"
        '
        'lycSplit1
        '
        Me.lycSplit1.Controls.Add(Me.sbdcSplit1Vertical)
        Me.lycSplit1.Controls.Add(Me.sbdcSplit1)
        Me.lycSplit1.Controls.Add(Me.grdOrdenesProduccion)
        Me.lycSplit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit1.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit1.Name = "lycSplit1"
        Me.lycSplit1.Root = Me.LayoutControlGroup2
        Me.lycSplit1.Size = New System.Drawing.Size(716, 639)
        Me.lycSplit1.TabIndex = 0
        Me.lycSplit1.Text = "LayoutControl1"
        '
        'sbdcSplit1Vertical
        '
        Me.sbdcSplit1Vertical.CausesValidation = False
        Me.sbdcSplit1Vertical.IsVertical = True
        Me.sbdcSplit1Vertical.Location = New System.Drawing.Point(653, 12)
        Me.sbdcSplit1Vertical.Manager = Me.BarManager1
        Me.sbdcSplit1Vertical.Name = "sbdcSplit1Vertical"
        Me.sbdcSplit1Vertical.Size = New System.Drawing.Size(51, 232)
        Me.sbdcSplit1Vertical.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcSplit1)
        Me.BarManager1.DockControls.Add(Me.sbdcSplit1Vertical)
        Me.BarManager1.DockControls.Add(Me.sbdcSplit2)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnQuitar, Me.barbtnColapsarTodo, Me.barbtnExpandir, Me.barbtnColapsar, Me.barbtnBajar, Me.barbtnProgramacionGrafica, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.BarButtonItem1, Me.barbtnProgramacionFinal, Me.barbtnEmail, Me.bwsVista, Me.barbtnOrdenesProduccion_Todas})
        Me.BarManager1.MaxItemId = 18
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        Me.Bar1.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProgramacionGrafica, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProgramacionFinal, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bwsVista, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEmail, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenesProduccion_Todas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnProgramacionGrafica
        '
        Me.barbtnProgramacionGrafica.Caption = "Programación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grafica"
        Me.barbtnProgramacionGrafica.Id = 9
        Me.barbtnProgramacionGrafica.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionGrafica.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionGrafica.Name = "barbtnProgramacionGrafica"
        '
        'barbtnProgramacionFinal
        '
        Me.barbtnProgramacionFinal.Caption = "Programacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final"
        Me.barbtnProgramacionFinal.Id = 14
        Me.barbtnProgramacionFinal.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionFinal.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionFinal.Name = "barbtnProgramacionFinal"
        '
        'bwsVista
        '
        Me.bwsVista.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bwsVista.Caption = "Vista"
        Me.bwsVista.Id = 16
        Me.bwsVista.ImageOptions.Image = CType(resources.GetObject("bwsVista.ImageOptions.Image"), System.Drawing.Image)
        Me.bwsVista.Name = "bwsVista"
        Me.bwsVista.WorkspaceManager = Me.wsmVistasOrdenes
        '
        'wsmVistasOrdenes
        '
        Me.wsmVistasOrdenes.TargetControl = Me
        ShapeTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.ShapeEffectOptions.CircleOut
        Me.wsmVistasOrdenes.TransitionType = ShapeTransition1
        '
        'barbtnEmail
        '
        Me.barbtnEmail.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnEmail.Caption = "Email"
        Me.barbtnEmail.Id = 15
        Me.barbtnEmail.ImageOptions.Image = CType(resources.GetObject("barbtnEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEmail.Name = "barbtnEmail"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 10
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 11
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
        'barbtnOrdenesProduccion_Todas
        '
        Me.barbtnOrdenesProduccion_Todas.Caption = "Ordenes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Produccion"
        Me.barbtnOrdenesProduccion_Todas.Id = 17
        Me.barbtnOrdenesProduccion_Todas.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenesProduccion_Todas.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenesProduccion_Todas.Name = "barbtnOrdenesProduccion_Todas"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1562, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 692)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1562, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 663)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1562, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 663)
        '
        'sbdcSplit1
        '
        Me.sbdcSplit1.CausesValidation = False
        Me.sbdcSplit1.Location = New System.Drawing.Point(12, 596)
        Me.sbdcSplit1.Manager = Me.BarManager1
        Me.sbdcSplit1.Name = "sbdcSplit1"
        Me.sbdcSplit1.Size = New System.Drawing.Size(106, 31)
        Me.sbdcSplit1.Text = "StandaloneBarDockControl1"
        '
        'sbdcSplit2
        '
        Me.sbdcSplit2.CausesValidation = False
        Me.sbdcSplit2.Location = New System.Drawing.Point(12, 596)
        Me.sbdcSplit2.Manager = Me.BarManager1
        Me.sbdcSplit2.Name = "sbdcSplit2"
        Me.sbdcSplit2.Size = New System.Drawing.Size(710, 31)
        Me.sbdcSplit2.Text = "StandaloneBarDockControl1"
        '
        'barbtnQuitar
        '
        Me.barbtnQuitar.Caption = "Quitar"
        Me.barbtnQuitar.Id = 1
        Me.barbtnQuitar.ImageOptions.Image = CType(resources.GetObject("barbtnQuitar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnQuitar.Name = "barbtnQuitar"
        '
        'barbtnColapsarTodo
        '
        Me.barbtnColapsarTodo.Caption = "Colapsar Todo"
        Me.barbtnColapsarTodo.Id = 3
        Me.barbtnColapsarTodo.ImageOptions.Image = CType(resources.GetObject("barbtnColapsarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnColapsarTodo.ImageOptions.LargeImage = CType(resources.GetObject("barbtnColapsarTodo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnColapsarTodo.Name = "barbtnColapsarTodo"
        '
        'barbtnExpandir
        '
        Me.barbtnExpandir.Caption = "Expandir"
        Me.barbtnExpandir.Id = 4
        Me.barbtnExpandir.ImageOptions.Image = CType(resources.GetObject("barbtnExpandir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExpandir.ImageOptions.LargeImage = CType(resources.GetObject("barbtnExpandir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnExpandir.Name = "barbtnExpandir"
        '
        'barbtnColapsar
        '
        Me.barbtnColapsar.Caption = "Colapsar"
        Me.barbtnColapsar.Id = 5
        Me.barbtnColapsar.ImageOptions.Image = CType(resources.GetObject("barbtnColapsar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnColapsar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnColapsar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnColapsar.Name = "barbtnColapsar"
        '
        'barbtnBajar
        '
        Me.barbtnBajar.Caption = "Bajar"
        Me.barbtnBajar.Id = 8
        Me.barbtnBajar.ImageOptions.Image = CType(resources.GetObject("barbtnBajar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBajar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnBajar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnBajar.Name = "barbtnBajar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Programación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final"
        Me.BarButtonItem1.Id = 13
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'grdOrdenesProduccion
        '
        Me.grdOrdenesProduccion.DataMember = "dsdtOrdenesProduccion"
        Me.grdOrdenesProduccion.DataSource = Me.DsProgramacionProduccion
        Me.grdOrdenesProduccion.Location = New System.Drawing.Point(12, 12)
        Me.grdOrdenesProduccion.MainView = Me.grdviewOrdenesProduccion
        Me.grdOrdenesProduccion.Name = "grdOrdenesProduccion"
        Me.grdOrdenesProduccion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rsluePrioridadEmergencias})
        Me.grdOrdenesProduccion.Size = New System.Drawing.Size(637, 580)
        Me.grdOrdenesProduccion.TabIndex = 4
        Me.grdOrdenesProduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenesProduccion})
        '
        'DsProgramacionProduccion
        '
        Me.DsProgramacionProduccion.DataSetName = "dsProgramacionProduccion"
        Me.DsProgramacionProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenesProduccion
        '
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewOrdenesProduccion.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.Preview.Options.UseFont = True
        Me.grdviewOrdenesProduccion.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.Row.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.Row.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccion.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccion.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccion.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewOrdenesProduccion.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccion.ColumnPanelRowHeight = 35
        Me.grdviewOrdenesProduccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmergencia, Me.colPrioridad, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colPreferencial, Me.colGrupoMaquina, Me.colPrioridadEmergencia, Me.colProduccionHora1, Me.colHorasPendiente1, Me.colPromedioMaquina})
        Me.grdviewOrdenesProduccion.GridControl = Me.grdOrdenesProduccion
        Me.grdviewOrdenesProduccion.GroupCount = 1
        Me.grdviewOrdenesProduccion.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HorasPendiente", Nothing, "(Horas Pendientes : {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "PromedioMaquina", Nothing, "(Horas Promedio Maquina: {0})")})
        Me.grdviewOrdenesProduccion.Name = "grdviewOrdenesProduccion"
        Me.grdviewOrdenesProduccion.OptionsBehavior.Editable = False
        Me.grdviewOrdenesProduccion.OptionsBehavior.ReadOnly = True
        Me.grdviewOrdenesProduccion.OptionsSelection.MultiSelect = True
        Me.grdviewOrdenesProduccion.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewOrdenesProduccion.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdviewOrdenesProduccion.OptionsView.ColumnAutoWidth = False
        Me.grdviewOrdenesProduccion.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewOrdenesProduccion.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewOrdenesProduccion.OptionsView.ShowFooter = True
        Me.grdviewOrdenesProduccion.OptionsView.ShowGroupPanel = False
        Me.grdviewOrdenesProduccion.PaintStyleName = "Flat"
        Me.grdviewOrdenesProduccion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmergencia, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colEmergencia
        '
        Me.colEmergencia.FieldName = "Emergencia"
        Me.colEmergencia.Name = "colEmergencia"
        Me.colEmergencia.OptionsColumn.ReadOnly = True
        Me.colEmergencia.Visible = True
        Me.colEmergencia.VisibleIndex = 1
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.OptionsColumn.ReadOnly = True
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 2
        Me.colPrioridad.Width = 54
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 3
        Me.colCodigoArticulo.Width = 70
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 4
        Me.colNombreArticulo.Width = 190
        '
        'colPlaneado
        '
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        '
        'colCompletado
        '
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        '
        'colPreferencial
        '
        Me.colPreferencial.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreferencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreferencial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreferencial.Caption = "Maquina Preferencial"
        Me.colPreferencial.FieldName = "Preferencial"
        Me.colPreferencial.Name = "colPreferencial"
        Me.colPreferencial.OptionsColumn.ReadOnly = True
        Me.colPreferencial.Visible = True
        Me.colPreferencial.VisibleIndex = 6
        Me.colPreferencial.Width = 70
        '
        'colGrupoMaquina
        '
        Me.colGrupoMaquina.FieldName = "GrupoMaquina"
        Me.colGrupoMaquina.Name = "colGrupoMaquina"
        '
        'colPrioridadEmergencia
        '
        Me.colPrioridadEmergencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridadEmergencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridadEmergencia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPrioridadEmergencia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrioridadEmergencia.ColumnEdit = Me.rsluePrioridadEmergencias
        Me.colPrioridadEmergencia.FieldName = "PrioridadEmergencia"
        Me.colPrioridadEmergencia.Name = "colPrioridadEmergencia"
        Me.colPrioridadEmergencia.Visible = True
        Me.colPrioridadEmergencia.VisibleIndex = 1
        Me.colPrioridadEmergencia.Width = 66
        '
        'rsluePrioridadEmergencias
        '
        Me.rsluePrioridadEmergencias.AutoHeight = False
        Me.rsluePrioridadEmergencias.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rsluePrioridadEmergencias.Name = "rsluePrioridadEmergencias"
        Me.rsluePrioridadEmergencias.NullText = ""
        Me.rsluePrioridadEmergencias.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProduccionHora1
        '
        Me.colProduccionHora1.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccionHora1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccionHora1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProduccionHora1.FieldName = "ProduccionHora"
        Me.colProduccionHora1.Name = "colProduccionHora1"
        '
        'colHorasPendiente1
        '
        Me.colHorasPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasPendiente1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasPendiente1.FieldName = "HorasPendiente"
        Me.colHorasPendiente1.Name = "colHorasPendiente1"
        '
        'colPromedioMaquina
        '
        Me.colPromedioMaquina.FieldName = "PromedioMaquina"
        Me.colPromedioMaquina.Name = "colPromedioMaquina"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(716, 639)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOrdenesProduccion
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(641, 584)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcSplit1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 584)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(110, 35)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbdcSplit1Vertical
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(641, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(55, 619)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(110, 584)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(531, 35)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lycSplit2
        '
        Me.lycSplit2.Controls.Add(Me.sbdcSplit2)
        Me.lycSplit2.Controls.Add(Me.grdProgramacionAsignados)
        Me.lycSplit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit2.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit2.Name = "lycSplit2"
        Me.lycSplit2.Root = Me.LayoutControlGroup3
        Me.lycSplit2.Size = New System.Drawing.Size(817, 639)
        Me.lycSplit2.TabIndex = 1
        Me.lycSplit2.Text = "LayoutControl1"
        '
        'grdProgramacionAsignados
        '
        Me.grdProgramacionAsignados.DataMember = "dsdtOrdenesProgramadas"
        Me.grdProgramacionAsignados.DataSource = Me.DsProgramacionProduccion
        Me.grdProgramacionAsignados.Location = New System.Drawing.Point(12, 12)
        Me.grdProgramacionAsignados.MainView = Me.grdviewProgramacionAsignados
        Me.grdProgramacionAsignados.Name = "grdProgramacionAsignados"
        Me.grdProgramacionAsignados.Size = New System.Drawing.Size(793, 580)
        Me.grdProgramacionAsignados.TabIndex = 0
        Me.grdProgramacionAsignados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProgramacionAsignados})
        '
        'grdviewProgramacionAsignados
        '
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProgramacionAsignados.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewProgramacionAsignados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.Preview.Options.UseFont = True
        Me.grdviewProgramacionAsignados.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProgramacionAsignados.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProgramacionAsignados.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProgramacionAsignados.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewProgramacionAsignados.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProgramacionAsignados.ColumnPanelRowHeight = 35
        Me.grdviewProgramacionAsignados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreferencial1, Me.colEstado, Me.ColPrioridadMaquina, Me.colPrioridad1, Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colProduccionHora, Me.colHorasPendiente, Me.colComentarios})
        GridFormatRule1.Column = Me.colEstado
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "En Proceso"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colEstado
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "En Espera"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colEstado
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Silver
        FormatConditionRuleValue3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Appearance.Options.UseFont = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = "Mantenimiento"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.grdviewProgramacionAsignados.FormatRules.Add(GridFormatRule1)
        Me.grdviewProgramacionAsignados.FormatRules.Add(GridFormatRule2)
        Me.grdviewProgramacionAsignados.FormatRules.Add(GridFormatRule3)
        Me.grdviewProgramacionAsignados.GridControl = Me.grdProgramacionAsignados
        Me.grdviewProgramacionAsignados.GroupCount = 1
        Me.grdviewProgramacionAsignados.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HorasPendiente", Nothing, ",     Horas Pendiente [{0:n0}]"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodigoArticulo", Nothing, "      Moldes en cola [{0:n0}]")})
        Me.grdviewProgramacionAsignados.Name = "grdviewProgramacionAsignados"
        Me.grdviewProgramacionAsignados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewProgramacionAsignados.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdviewProgramacionAsignados.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdviewProgramacionAsignados.OptionsView.ColumnAutoWidth = False
        Me.grdviewProgramacionAsignados.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProgramacionAsignados.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProgramacionAsignados.OptionsView.ShowFooter = True
        Me.grdviewProgramacionAsignados.OptionsView.ShowGroupPanel = False
        Me.grdviewProgramacionAsignados.PaintStyleName = "Web"
        Me.grdviewProgramacionAsignados.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPreferencial1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPreferencial1
        '
        Me.colPreferencial1.Caption = "Maquina"
        Me.colPreferencial1.FieldName = "Preferencial"
        Me.colPreferencial1.Name = "colPreferencial1"
        Me.colPreferencial1.OptionsColumn.ReadOnly = True
        Me.colPreferencial1.Visible = True
        Me.colPreferencial1.VisibleIndex = 0
        '
        'ColPrioridadMaquina
        '
        Me.ColPrioridadMaquina.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrioridadMaquina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrioridadMaquina.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPrioridadMaquina.AppearanceHeader.Options.UseFont = True
        Me.ColPrioridadMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrioridadMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrioridadMaquina.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPrioridadMaquina.FieldName = "PrioridadMaquina"
        Me.ColPrioridadMaquina.Name = "ColPrioridadMaquina"
        Me.ColPrioridadMaquina.OptionsColumn.AllowEdit = False
        Me.ColPrioridadMaquina.OptionsColumn.ReadOnly = True
        Me.ColPrioridadMaquina.Visible = True
        Me.ColPrioridadMaquina.VisibleIndex = 2
        Me.ColPrioridadMaquina.Width = 60
        '
        'colPrioridad1
        '
        Me.colPrioridad1.AppearanceCell.Options.UseTextOptions = True
        Me.colPrioridad1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPrioridad1.AppearanceHeader.Options.UseFont = True
        Me.colPrioridad1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad1.FieldName = "Prioridad"
        Me.colPrioridad1.Name = "colPrioridad1"
        Me.colPrioridad1.OptionsColumn.AllowEdit = False
        Me.colPrioridad1.OptionsColumn.ReadOnly = True
        Me.colPrioridad1.Visible = True
        Me.colPrioridad1.VisibleIndex = 1
        Me.colPrioridad1.Width = 60
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo1.AppearanceCell.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo1.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 3
        Me.colCodigoArticulo1.Width = 80
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombreArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo1.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 4
        Me.colNombreArticulo1.Width = 190
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colPlaneado1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado1.AppearanceCell.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.OptionsColumn.AllowEdit = False
        Me.colPlaneado1.OptionsColumn.ReadOnly = True
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 5
        Me.colPlaneado1.Width = 70
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colCompletado1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado1.AppearanceCell.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.OptionsColumn.AllowEdit = False
        Me.colCompletado1.OptionsColumn.ReadOnly = True
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 6
        Me.colCompletado1.Width = 70
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colPendiente1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente1.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente1.AppearanceCell.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPendiente1.AppearanceHeader.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.OptionsColumn.AllowEdit = False
        Me.colPendiente1.OptionsColumn.ReadOnly = True
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 7
        Me.colPendiente1.Width = 70
        '
        'colProduccionHora
        '
        Me.colProduccionHora.AppearanceCell.Options.UseTextOptions = True
        Me.colProduccionHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProduccionHora.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colProduccionHora.AppearanceHeader.Options.UseFont = True
        Me.colProduccionHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccionHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccionHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProduccionHora.DisplayFormat.FormatString = "{0:n0}"
        Me.colProduccionHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProduccionHora.FieldName = "ProduccionHora"
        Me.colProduccionHora.Name = "colProduccionHora"
        Me.colProduccionHora.OptionsColumn.AllowEdit = False
        Me.colProduccionHora.OptionsColumn.ReadOnly = True
        Me.colProduccionHora.Visible = True
        Me.colProduccionHora.VisibleIndex = 8
        Me.colProduccionHora.Width = 65
        '
        'colHorasPendiente
        '
        Me.colHorasPendiente.AppearanceCell.Options.UseTextOptions = True
        Me.colHorasPendiente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHorasPendiente.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colHorasPendiente.AppearanceHeader.Options.UseFont = True
        Me.colHorasPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasPendiente.FieldName = "HorasPendiente"
        Me.colHorasPendiente.Name = "colHorasPendiente"
        Me.colHorasPendiente.OptionsColumn.AllowEdit = False
        Me.colHorasPendiente.OptionsColumn.ReadOnly = True
        Me.colHorasPendiente.Visible = True
        Me.colHorasPendiente.VisibleIndex = 9
        Me.colHorasPendiente.Width = 65
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 10
        Me.colComentarios.Width = 200
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(817, 639)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdProgramacionAsignados
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(797, 584)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.sbdcSplit2
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 584)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(797, 35)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1562, 663)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.splitProgramacionProduccion
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1542, 643)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'DsProgramacionProduccionBindingSource
        '
        Me.DsProgramacionProduccionBindingSource.DataSource = Me.DsProgramacionProduccion
        Me.DsProgramacionProduccionBindingSource.Position = 0
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barSplit1})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnColumnas, Me.barbtnVistaDefault, Me.barbtnVistaGrupoMaquina, Me.barwVistas})
        Me.BarManager2.MaxItemId = 6
        '
        'barSplit1
        '
        Me.barSplit1.BarName = "Tools"
        Me.barSplit1.DockCol = 0
        Me.barSplit1.DockRow = 0
        Me.barSplit1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barSplit1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnColumnas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barSplit1.OptionsBar.AllowQuickCustomization = False
        Me.barSplit1.OptionsBar.DrawBorder = False
        Me.barSplit1.StandaloneBarDockControl = Me.sbdcSplit1
        Me.barSplit1.Text = "Tools"
        '
        'barbtnColumnas
        '
        Me.barbtnColumnas.Caption = "Columnas"
        Me.barbtnColumnas.Id = 0
        Me.barbtnColumnas.ImageOptions.Image = CType(resources.GetObject("barbtnColumnas.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnColumnas.ImageOptions.LargeImage = CType(resources.GetObject("barbtnColumnas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnColumnas.Name = "barbtnColumnas"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 735)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 735)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1562, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 735)
        '
        'barbtnVistaDefault
        '
        Me.barbtnVistaDefault.Caption = "Vista Default"
        Me.barbtnVistaDefault.Id = 3
        Me.barbtnVistaDefault.Name = "barbtnVistaDefault"
        '
        'barbtnVistaGrupoMaquina
        '
        Me.barbtnVistaGrupoMaquina.Caption = "Vista Por Grupo Maquina"
        Me.barbtnVistaGrupoMaquina.Id = 4
        Me.barbtnVistaGrupoMaquina.Name = "barbtnVistaGrupoMaquina"
        '
        'barwVistas
        '
        Me.barwVistas.Caption = "Grabar Vistas"
        Me.barwVistas.Id = 5
        Me.barwVistas.ImageOptions.Image = CType(resources.GetObject("barwVistas.ImageOptions.Image"), System.Drawing.Image)
        Me.barwVistas.ImageOptions.LargeImage = CType(resources.GetObject("barwVistas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barwVistas.Name = "barwVistas"
        Me.barwVistas.WorkspaceManager = Me.wsmVistasOrdenes
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barSplit1Vertical})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnProgramacionAutomatica, Me.barbtnDetalleColores, Me.barbtnGrupoMaquina})
        Me.BarManager3.MaxItemId = 6
        '
        'barSplit1Vertical
        '
        Me.barSplit1Vertical.BarName = "Tools"
        Me.barSplit1Vertical.DockCol = 0
        Me.barSplit1Vertical.DockRow = 0
        Me.barSplit1Vertical.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barSplit1Vertical.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnGrupoMaquina), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnQuitar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProgramacionAutomatica, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDetalleColores, True)})
        Me.barSplit1Vertical.OptionsBar.AllowQuickCustomization = False
        Me.barSplit1Vertical.OptionsBar.DrawBorder = False
        Me.barSplit1Vertical.StandaloneBarDockControl = Me.sbdcSplit1Vertical
        Me.barSplit1Vertical.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnGrupoMaquina
        '
        Me.barbtnGrupoMaquina.Caption = "Grupo Maquina"
        Me.barbtnGrupoMaquina.Id = 5
        Me.barbtnGrupoMaquina.ImageOptions.Image = CType(resources.GetObject("barbtnGrupoMaquina.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrupoMaquina.Name = "barbtnGrupoMaquina"
        '
        'barbtnProgramacionAutomatica
        '
        Me.barbtnProgramacionAutomatica.Caption = "Asignación Automatica"
        Me.barbtnProgramacionAutomatica.Id = 3
        Me.barbtnProgramacionAutomatica.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionAutomatica.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionAutomatica.Name = "barbtnProgramacionAutomatica"
        '
        'barbtnDetalleColores
        '
        Me.barbtnDetalleColores.Caption = "Detalle Colores"
        Me.barbtnDetalleColores.Id = 4
        Me.barbtnDetalleColores.ImageOptions.Image = CType(resources.GetObject("barbtnDetalleColores.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDetalleColores.Name = "barbtnDetalleColores"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 735)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 735)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1562, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 735)
        '
        'BarManager4
        '
        Me.BarManager4.DockControls.Add(Me.BarDockControl9)
        Me.BarManager4.DockControls.Add(Me.BarDockControl10)
        Me.BarManager4.DockControls.Add(Me.BarDockControl11)
        Me.BarManager4.DockControls.Add(Me.BarDockControl12)
        Me.BarManager4.Form = Me
        Me.BarManager4.MaxItemId = 4
        Me.BarManager4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl9.Manager = Me.BarManager4
        Me.BarDockControl9.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 735)
        Me.BarDockControl10.Manager = Me.BarManager4
        Me.BarDockControl10.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl11.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl11.Manager = Me.BarManager4
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 735)
        '
        'BarDockControl12
        '
        Me.BarDockControl12.CausesValidation = False
        Me.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl12.Location = New System.Drawing.Point(1562, 0)
        Me.BarDockControl12.Manager = Me.BarManager4
        Me.BarDockControl12.Size = New System.Drawing.Size(0, 735)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'BarManager5
        '
        Me.BarManager5.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager5.DockControls.Add(Me.BarDockControl13)
        Me.BarManager5.DockControls.Add(Me.BarDockControl14)
        Me.BarManager5.DockControls.Add(Me.BarDockControl15)
        Me.BarManager5.DockControls.Add(Me.BarDockControl16)
        Me.BarManager5.Form = Me
        Me.BarManager5.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnIniciarProceso, Me.barbtnDetener, Me.barbtnMaquinaCambiar, Me.barbtnMantenimiento1, Me.barbtnSubir, Me.barbtnEliminar})
        Me.BarManager5.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExpandir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnColapsar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnIniciarProceso, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDetener, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSubir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBajar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnMaquinaCambiar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnMantenimiento1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcSplit2
        Me.Bar2.Text = "Tools"
        '
        'barbtnIniciarProceso
        '
        Me.barbtnIniciarProceso.Caption = "Iniciar"
        Me.barbtnIniciarProceso.Id = 2
        Me.barbtnIniciarProceso.ImageOptions.Image = CType(resources.GetObject("barbtnIniciarProceso.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnIniciarProceso.ImageOptions.LargeImage = CType(resources.GetObject("barbtnIniciarProceso.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnIniciarProceso.Name = "barbtnIniciarProceso"
        '
        'barbtnDetener
        '
        Me.barbtnDetener.Caption = "Detener"
        Me.barbtnDetener.Id = 3
        Me.barbtnDetener.ImageOptions.Image = CType(resources.GetObject("barbtnDetener.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDetener.ImageOptions.LargeImage = CType(resources.GetObject("barbtnDetener.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnDetener.Name = "barbtnDetener"
        '
        'barbtnSubir
        '
        Me.barbtnSubir.Caption = "Subir"
        Me.barbtnSubir.Id = 6
        Me.barbtnSubir.ImageOptions.Image = CType(resources.GetObject("barbtnSubir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSubir.ImageOptions.LargeImage = CType(resources.GetObject("barbtnSubir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnSubir.Name = "barbtnSubir"
        '
        'barbtnMaquinaCambiar
        '
        Me.barbtnMaquinaCambiar.Caption = "Cambiar Maquina"
        Me.barbtnMaquinaCambiar.Id = 4
        Me.barbtnMaquinaCambiar.ImageOptions.Image = CType(resources.GetObject("barbtnMaquinaCambiar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnMaquinaCambiar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnMaquinaCambiar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnMaquinaCambiar.Name = "barbtnMaquinaCambiar"
        '
        'barbtnMantenimiento1
        '
        Me.barbtnMantenimiento1.Caption = "Mantenimiento"
        Me.barbtnMantenimiento1.Id = 5
        Me.barbtnMantenimiento1.ImageOptions.Image = CType(resources.GetObject("barbtnMantenimiento1.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnMantenimiento1.ImageOptions.LargeImage = CType(resources.GetObject("barbtnMantenimiento1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnMantenimiento1.Name = "barbtnMantenimiento1"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Eliminar"
        Me.barbtnEliminar.Id = 7
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'BarDockControl13
        '
        Me.BarDockControl13.CausesValidation = False
        Me.BarDockControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl13.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl13.Manager = Me.BarManager5
        Me.BarDockControl13.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl14
        '
        Me.BarDockControl14.CausesValidation = False
        Me.BarDockControl14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl14.Location = New System.Drawing.Point(0, 735)
        Me.BarDockControl14.Manager = Me.BarManager5
        Me.BarDockControl14.Size = New System.Drawing.Size(1562, 0)
        '
        'BarDockControl15
        '
        Me.BarDockControl15.CausesValidation = False
        Me.BarDockControl15.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl15.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl15.Manager = Me.BarManager5
        Me.BarDockControl15.Size = New System.Drawing.Size(0, 735)
        '
        'BarDockControl16
        '
        Me.BarDockControl16.CausesValidation = False
        Me.BarDockControl16.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl16.Location = New System.Drawing.Point(1562, 0)
        Me.BarDockControl16.Manager = Me.BarManager5
        Me.BarDockControl16.Size = New System.Drawing.Size(0, 735)
        '
        'barbtnExpandirTodo
        '
        Me.barbtnExpandirTodo.Caption = "Expandir Todo"
        Me.barbtnExpandirTodo.Id = 0
        Me.barbtnExpandirTodo.ImageOptions.Image = CType(resources.GetObject("barbtnExpandirTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExpandirTodo.ImageOptions.LargeImage = CType(resources.GetObject("barbtnExpandirTodo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnExpandirTodo.Name = "barbtnExpandirTodo"
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'frmProgramacionProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1562, 735)
        Me.Controls.Add(Me.lycProgramacionProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl12)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Controls.Add(Me.BarDockControl15)
        Me.Controls.Add(Me.BarDockControl16)
        Me.Controls.Add(Me.BarDockControl14)
        Me.Controls.Add(Me.BarDockControl13)
        Me.Name = "frmProgramacionProduccion"
        Me.Text = "frmProgramacionProduccion"
        CType(Me.lycProgramacionProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycProgramacionProduccion.ResumeLayout(False)
        CType(Me.splitProgramacionProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProgramacionProduccion.ResumeLayout(False)
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdenesProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProgramacionProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewOrdenesProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rsluePrioridadEmergencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit2.ResumeLayout(False)
        CType(Me.grdProgramacionAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProgramacionAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProgramacionProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycProgramacionProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdOrdenesProduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewOrdenesProduccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents splitProgramacionProduccion As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grdProgramacionAsignados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProgramacionAsignados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsProgramacionProduccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProgramacionProduccion As waProduccion_Pedidos.dsProgramacionProduccion
    Friend WithEvents colEmergencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreferencial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lycSplit1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents sbdcSplit1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barSplit1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnColumnas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sbdcSplit1Vertical As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycSplit2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents barSplit1Vertical As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnQuitar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPreferencial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridad1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl12 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager4 As DevExpress.XtraBars.BarManager
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrioridadMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduccionHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbdcSplit2 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl15 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl16 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl14 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl13 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager5 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnExpandirTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnColapsarTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExpandir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnColapsar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnIniciarProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetener As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnMaquinaCambiar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnMantenimiento1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnSubir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBajar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnProgramacionGrafica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnProgramacionAutomatica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnProgramacionFinal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnDetalleColores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colGrupoMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridadEmergencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rsluePrioridadEmergencias As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnGrupoMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colProduccionHora1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnVistaDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnVistaGrupoMaquina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barwVistas As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents wsmVistasOrdenes As DevExpress.Utils.WorkspaceManager
    Friend WithEvents bwsVista As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents colPromedioMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents splEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnOrdenesProduccion_Todas As DevExpress.XtraBars.BarButtonItem

    'Friend WithEvents barbtnCambiarMaquina As DevExpress.XtraBars.BarButtonItem
End Class
