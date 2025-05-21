<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPreciosCostosActualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaPreciosCostosActualizar))
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colCostoActual1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoSTD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoSTD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycListaPreciosCostosActualizar = New DevExpress.XtraLayout.LayoutControl()
        Me.slueCodigoPadre = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barListaPreciosCostosActualizar = New DevExpress.XtraBars.Bar()
        Me.barbtnActualizarArticulo = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcListaPreciosCostoActualizar = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcActualizarComponentes = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdListaMaterialesCP = New DevExpress.XtraGrid.GridControl()
        Me.DsListaPreciosCostosActualizar1 = New waProduccion_Pedidos.dsListaPreciosCostosActualizar()
        Me.grdviewListaMaterialesCP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioUnitario1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoTotal3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoActual2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoSTD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdListaMateriales = New DevExpress.XtraGrid.GridControl()
        Me.grdviewListaMateriales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coCostoTotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdCodigosHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCodigosHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoTotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdCodigosPadres = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCodigosPadre = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGrupoRastreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombrePadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barActualizarComponentes = New DevExpress.XtraBars.Bar()
        Me.barbtnActualizarComponente = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAgregarGrupoRastreo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAbrirExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDescargarPlantilla = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycListaPreciosCostosActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaPreciosCostosActualizar.SuspendLayout()
        CType(Me.slueCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaMaterialesCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaPreciosCostosActualizar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaMaterialesCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCodigosPadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigosPadre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colCostoActual1
        '
        Me.colCostoActual1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoActual1.AppearanceHeader.Options.UseFont = True
        Me.colCostoActual1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoActual1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoActual1.Caption = "LP Costo"
        Me.colCostoActual1.FieldName = "CostoActual"
        Me.colCostoActual1.Name = "colCostoActual1"
        Me.colCostoActual1.Visible = True
        Me.colCostoActual1.VisibleIndex = 4
        Me.colCostoActual1.Width = 90
        '
        'colCostoSTD1
        '
        Me.colCostoSTD1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoSTD1.AppearanceHeader.Options.UseFont = True
        Me.colCostoSTD1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoSTD1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoSTD1.Caption = "CostoSTD"
        Me.colCostoSTD1.FieldName = "CostoSTD"
        Me.colCostoSTD1.Name = "colCostoSTD1"
        Me.colCostoSTD1.Visible = True
        Me.colCostoSTD1.VisibleIndex = 5
        Me.colCostoSTD1.Width = 90
        '
        'colCostoActual
        '
        Me.colCostoActual.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoActual.AppearanceHeader.Options.UseFont = True
        Me.colCostoActual.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoActual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoActual.Caption = "LP Costo"
        Me.colCostoActual.FieldName = "CostoActual"
        Me.colCostoActual.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colCostoActual.Name = "colCostoActual"
        Me.colCostoActual.ToolTip = "Costo segun Lista de Precios [1 Costos]"
        Me.colCostoActual.Visible = True
        Me.colCostoActual.VisibleIndex = 7
        Me.colCostoActual.Width = 100
        '
        'colCostoSTD
        '
        Me.colCostoSTD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoSTD.AppearanceHeader.Options.UseFont = True
        Me.colCostoSTD.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoSTD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoSTD.Caption = "CostoSTD"
        Me.colCostoSTD.FieldName = "CostoSTD"
        Me.colCostoSTD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colCostoSTD.Name = "colCostoSTD"
        Me.colCostoSTD.Visible = True
        Me.colCostoSTD.VisibleIndex = 8
        Me.colCostoSTD.Width = 100
        '
        'lycListaPreciosCostosActualizar
        '
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.slueCodigoPadre)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.sbdcActualizarComponentes)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.sbdcListaPreciosCostoActualizar)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.grdListaMaterialesCP)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.grdListaMateriales)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.grdCodigosHijos)
        Me.lycListaPreciosCostosActualizar.Controls.Add(Me.grdCodigosPadres)
        Me.lycListaPreciosCostosActualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListaPreciosCostosActualizar.Location = New System.Drawing.Point(0, 47)
        Me.lycListaPreciosCostosActualizar.Name = "lycListaPreciosCostosActualizar"
        Me.lycListaPreciosCostosActualizar.Root = Me.LayoutControlGroup1
        Me.lycListaPreciosCostosActualizar.Size = New System.Drawing.Size(1364, 642)
        Me.lycListaPreciosCostosActualizar.TabIndex = 0
        Me.lycListaPreciosCostosActualizar.Text = "LayoutControl1"
        '
        'slueCodigoPadre
        '
        Me.slueCodigoPadre.Location = New System.Drawing.Point(121, 12)
        Me.slueCodigoPadre.MenuManager = Me.BarManager1
        Me.slueCodigoPadre.Name = "slueCodigoPadre"
        Me.slueCodigoPadre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoPadre.Properties.NullText = ""
        Me.slueCodigoPadre.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigoPadre.Size = New System.Drawing.Size(241, 20)
        Me.slueCodigoPadre.StyleController = Me.lycListaPreciosCostosActualizar
        Me.slueCodigoPadre.TabIndex = 10
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barListaPreciosCostosActualizar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcListaPreciosCostoActualizar)
        Me.BarManager1.DockControls.Add(Me.sbdcActualizarComponentes)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnActualizarArticulo})
        Me.BarManager1.MaxItemId = 2
        '
        'barListaPreciosCostosActualizar
        '
        Me.barListaPreciosCostosActualizar.BarName = "Tools"
        Me.barListaPreciosCostosActualizar.DockCol = 0
        Me.barListaPreciosCostosActualizar.DockRow = 0
        Me.barListaPreciosCostosActualizar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barListaPreciosCostosActualizar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizarArticulo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barListaPreciosCostosActualizar.Offset = 1
        Me.barListaPreciosCostosActualizar.OptionsBar.AllowQuickCustomization = False
        Me.barListaPreciosCostosActualizar.OptionsBar.DrawBorder = False
        Me.barListaPreciosCostosActualizar.OptionsBar.DrawDragBorder = False
        Me.barListaPreciosCostosActualizar.StandaloneBarDockControl = Me.sbdcListaPreciosCostoActualizar
        Me.barListaPreciosCostosActualizar.Text = "Tools"
        '
        'barbtnActualizarArticulo
        '
        Me.barbtnActualizarArticulo.Caption = "Actualizar Costo del Articulo"
        Me.barbtnActualizarArticulo.Id = 0
        Me.barbtnActualizarArticulo.ImageOptions.Image = CType(resources.GetObject("barbtnActualizarArticulo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizarArticulo.Name = "barbtnActualizarArticulo"
        '
        'sbdcListaPreciosCostoActualizar
        '
        Me.sbdcListaPreciosCostoActualizar.CausesValidation = False
        Me.sbdcListaPreciosCostoActualizar.Location = New System.Drawing.Point(366, 320)
        Me.sbdcListaPreciosCostoActualizar.Manager = Me.BarManager1
        Me.sbdcListaPreciosCostoActualizar.Name = "sbdcListaPreciosCostoActualizar"
        Me.sbdcListaPreciosCostoActualizar.Size = New System.Drawing.Size(207, 47)
        Me.sbdcListaPreciosCostoActualizar.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 689)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 642)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1364, 47)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 642)
        '
        'sbdcActualizarComponentes
        '
        Me.sbdcActualizarComponentes.CausesValidation = False
        Me.sbdcActualizarComponentes.IsVertical = True
        Me.sbdcActualizarComponentes.Location = New System.Drawing.Point(766, 526)
        Me.sbdcActualizarComponentes.Manager = Me.BarManager1
        Me.sbdcActualizarComponentes.Name = "sbdcActualizarComponentes"
        Me.sbdcActualizarComponentes.Size = New System.Drawing.Size(51, 104)
        Me.sbdcActualizarComponentes.Text = "StandaloneBarDockControl1"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grdListaMaterialesCP
        '
        Me.grdListaMaterialesCP.DataMember = "dsdtListaMaterialesCP"
        Me.grdListaMaterialesCP.DataSource = Me.DsListaPreciosCostosActualizar1
        Me.grdListaMaterialesCP.Location = New System.Drawing.Point(821, 371)
        Me.grdListaMaterialesCP.MainView = Me.grdviewListaMaterialesCP
        Me.grdListaMaterialesCP.Name = "grdListaMaterialesCP"
        Me.grdListaMaterialesCP.Size = New System.Drawing.Size(531, 259)
        Me.grdListaMaterialesCP.TabIndex = 9
        Me.grdListaMaterialesCP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaMaterialesCP})
        '
        'DsListaPreciosCostosActualizar1
        '
        Me.DsListaPreciosCostosActualizar1.DataSetName = "dsListaPreciosCostosActualizar"
        Me.DsListaPreciosCostosActualizar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewListaMaterialesCP
        '
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.FocusedRow.BackColor = System.Drawing.Color.Teal
        Me.grdviewListaMaterialesCP.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewListaMaterialesCP.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewListaMaterialesCP.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewListaMaterialesCP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewListaMaterialesCP.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewListaMaterialesCP.Appearance.Preview.ForeColor = System.Drawing.Color.Teal
        Me.grdviewListaMaterialesCP.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaMaterialesCP.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMaterialesCP.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMaterialesCP.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewListaMaterialesCP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.grdviewListaMaterialesCP.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo2, Me.colNum1, Me.colComponente1, Me.colNombre1, Me.colCantidad1, Me.colPrecioUnitario1, Me.colCostoTotal3, Me.colCostoActual2, Me.colCostoSTD2})
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        Me.grdviewListaMaterialesCP.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition6})
        Me.grdviewListaMaterialesCP.GridControl = Me.grdListaMaterialesCP
        Me.grdviewListaMaterialesCP.Name = "grdviewListaMaterialesCP"
        Me.grdviewListaMaterialesCP.OptionsBehavior.Editable = False
        Me.grdviewListaMaterialesCP.OptionsBehavior.ReadOnly = True
        Me.grdviewListaMaterialesCP.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaMaterialesCP.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaMaterialesCP.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaMaterialesCP.OptionsView.ShowFooter = True
        Me.grdviewListaMaterialesCP.OptionsView.ShowGroupPanel = False
        Me.grdviewListaMaterialesCP.PaintStyleName = "UltraFlat"
        '
        'colCodigoArticulo2
        '
        Me.colCodigoArticulo2.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo2.Name = "colCodigoArticulo2"
        '
        'colNum1
        '
        Me.colNum1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNum1.AppearanceHeader.Options.UseFont = True
        Me.colNum1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNum1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum1.FieldName = "Num"
        Me.colNum1.Name = "colNum1"
        Me.colNum1.Width = 40
        '
        'colComponente1
        '
        Me.colComponente1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComponente1.AppearanceHeader.Options.UseFont = True
        Me.colComponente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComponente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComponente1.FieldName = "Componente"
        Me.colComponente1.Name = "colComponente1"
        Me.colComponente1.Visible = True
        Me.colComponente1.VisibleIndex = 0
        Me.colComponente1.Width = 125
        '
        'colNombre1
        '
        Me.colNombre1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre1.Caption = "Nombre"
        Me.colNombre1.FieldName = "Nombre"
        Me.colNombre1.Name = "colNombre1"
        Me.colNombre1.Visible = True
        Me.colNombre1.VisibleIndex = 1
        Me.colNombre1.Width = 275
        '
        'colCantidad1
        '
        Me.colCantidad1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad1.AppearanceHeader.Options.UseFont = True
        Me.colCantidad1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad1.FieldName = "Cantidad"
        Me.colCantidad1.Name = "colCantidad1"
        Me.colCantidad1.Visible = True
        Me.colCantidad1.VisibleIndex = 2
        Me.colCantidad1.Width = 60
        '
        'colPrecioUnitario1
        '
        Me.colPrecioUnitario1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrecioUnitario1.AppearanceHeader.Options.UseFont = True
        Me.colPrecioUnitario1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioUnitario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecioUnitario1.FieldName = "PrecioUnitario"
        Me.colPrecioUnitario1.Name = "colPrecioUnitario1"
        Me.colPrecioUnitario1.Width = 90
        '
        'colCostoTotal3
        '
        Me.colCostoTotal3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoTotal3.AppearanceHeader.Options.UseFont = True
        Me.colCostoTotal3.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoTotal3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoTotal3.Caption = "Costo Material"
        Me.colCostoTotal3.FieldName = "CostoTotal"
        Me.colCostoTotal3.Name = "colCostoTotal3"
        Me.colCostoTotal3.OptionsColumn.ReadOnly = True
        Me.colCostoTotal3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostoTotal", "{0:n6}")})
        Me.colCostoTotal3.Visible = True
        Me.colCostoTotal3.VisibleIndex = 3
        Me.colCostoTotal3.Width = 90
        '
        'colCostoActual2
        '
        Me.colCostoActual2.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoActual2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoActual2.Caption = "LP Costo"
        Me.colCostoActual2.FieldName = "CostoActual"
        Me.colCostoActual2.Name = "colCostoActual2"
        Me.colCostoActual2.OptionsColumn.ReadOnly = True
        Me.colCostoActual2.Visible = True
        Me.colCostoActual2.VisibleIndex = 4
        Me.colCostoActual2.Width = 90
        '
        'colCostoSTD2
        '
        Me.colCostoSTD2.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoSTD2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoSTD2.Caption = "CostoSTD"
        Me.colCostoSTD2.FieldName = "CostoSTD"
        Me.colCostoSTD2.Name = "colCostoSTD2"
        Me.colCostoSTD2.Visible = True
        Me.colCostoSTD2.VisibleIndex = 5
        Me.colCostoSTD2.Width = 90
        '
        'grdListaMateriales
        '
        Me.grdListaMateriales.DataMember = "dsdtListaMateriales"
        Me.grdListaMateriales.DataSource = Me.DsListaPreciosCostosActualizar1
        Me.grdListaMateriales.Location = New System.Drawing.Point(12, 371)
        Me.grdListaMateriales.MainView = Me.grdviewListaMateriales
        Me.grdListaMateriales.MaximumSize = New System.Drawing.Size(750, 259)
        Me.grdListaMateriales.MinimumSize = New System.Drawing.Size(750, 259)
        Me.grdListaMateriales.Name = "grdListaMateriales"
        Me.grdListaMateriales.Size = New System.Drawing.Size(750, 259)
        Me.grdListaMateriales.TabIndex = 8
        Me.grdListaMateriales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewListaMateriales})
        '
        'grdviewListaMateriales
        '
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewListaMateriales.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseFont = True
        Me.grdviewListaMateriales.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewListaMateriales.Appearance.Row.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewListaMateriales.Appearance.Row.Options.UseForeColor = True
        Me.grdviewListaMateriales.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewListaMateriales.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewListaMateriales.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewListaMateriales.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewListaMateriales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo1, Me.colNum, Me.colComponente, Me.colNombre, Me.colCantidad, Me.colPrecioUnitario, Me.coCostoTotal1, Me.colCostoTotal, Me.colCostoActual1, Me.colCostoSTD1})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colCostoActual1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "Iif([CostoTotal] <> [CostoActual], True , False )"
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.Column = Me.colCostoSTD1
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition7.Expression = "Iif([CostoSTD] <> [CostoActual], True , False )"
        Me.grdviewListaMateriales.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition7})
        Me.grdviewListaMateriales.GridControl = Me.grdListaMateriales
        Me.grdviewListaMateriales.Name = "grdviewListaMateriales"
        Me.grdviewListaMateriales.OptionsBehavior.Editable = False
        Me.grdviewListaMateriales.OptionsBehavior.ReadOnly = True
        Me.grdviewListaMateriales.OptionsView.ColumnAutoWidth = False
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewListaMateriales.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewListaMateriales.OptionsView.ShowFooter = True
        Me.grdviewListaMateriales.OptionsView.ShowGroupPanel = False
        Me.grdviewListaMateriales.PaintStyleName = "UltraFlat"
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        '
        'colNum
        '
        Me.colNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNum.AppearanceHeader.Options.UseFont = True
        Me.colNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.FieldName = "Num"
        Me.colNum.Name = "colNum"
        Me.colNum.Width = 40
        '
        'colComponente
        '
        Me.colComponente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComponente.AppearanceHeader.Options.UseFont = True
        Me.colComponente.AppearanceHeader.Options.UseTextOptions = True
        Me.colComponente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComponente.FieldName = "Componente"
        Me.colComponente.Name = "colComponente"
        Me.colComponente.Visible = True
        Me.colComponente.VisibleIndex = 0
        Me.colComponente.Width = 125
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 275
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 60
        '
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrecioUnitario.AppearanceHeader.Options.UseFont = True
        Me.colPrecioUnitario.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecioUnitario.FieldName = "PrecioUnitario"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        Me.colPrecioUnitario.Width = 90
        '
        'coCostoTotal1
        '
        Me.coCostoTotal1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.coCostoTotal1.AppearanceHeader.Options.UseFont = True
        Me.coCostoTotal1.AppearanceHeader.Options.UseTextOptions = True
        Me.coCostoTotal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coCostoTotal1.Caption = "Costo Material"
        Me.coCostoTotal1.FieldName = "CostoTotal"
        Me.coCostoTotal1.Name = "coCostoTotal1"
        Me.coCostoTotal1.OptionsColumn.ReadOnly = True
        Me.coCostoTotal1.ToolTip = "Sumatoria de la Lista de Materiales del Componente"
        Me.coCostoTotal1.Visible = True
        Me.coCostoTotal1.VisibleIndex = 3
        Me.coCostoTotal1.Width = 90
        '
        'colCostoTotal
        '
        Me.colCostoTotal.FieldName = "CostoTotal"
        Me.colCostoTotal.Name = "colCostoTotal"
        Me.colCostoTotal.OptionsColumn.ReadOnly = True
        Me.colCostoTotal.Width = 100
        '
        'grdCodigosHijos
        '
        Me.grdCodigosHijos.DataMember = "dsdtCodigosHijos"
        Me.grdCodigosHijos.DataSource = Me.DsListaPreciosCostosActualizar1
        Me.grdCodigosHijos.Location = New System.Drawing.Point(366, 12)
        Me.grdCodigosHijos.MainView = Me.grdviewCodigosHijos
        Me.grdCodigosHijos.Name = "grdCodigosHijos"
        Me.grdCodigosHijos.Size = New System.Drawing.Size(986, 304)
        Me.grdCodigosHijos.TabIndex = 7
        Me.grdCodigosHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigosHijos})
        '
        'grdviewCodigosHijos
        '
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCodigosHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCodigoBarras, Me.colCostoTotal1, Me.colCostoActual, Me.colCostoSTD, Me.colStock})
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colCostoActual
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "Iif([CostoTotal] <> [CostoActual], True , False )"
        StyleFormatCondition2.Value1 = ""
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colCostoSTD
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "Iif([CostoSTD] <> [CostoActual], True , False )"
        Me.grdviewCodigosHijos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2, StyleFormatCondition3})
        Me.grdviewCodigosHijos.GridControl = Me.grdCodigosHijos
        Me.grdviewCodigosHijos.Name = "grdviewCodigosHijos"
        Me.grdviewCodigosHijos.OptionsBehavior.Editable = False
        Me.grdviewCodigosHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewCodigosHijos.OptionsSelection.MultiSelect = True
        Me.grdviewCodigosHijos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewCodigosHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCodigosHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigosHijos.PaintStyleName = "Web"
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeLinea.AppearanceHeader.Options.UseFont = True
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.ReadOnly = True
        Me.colDeLinea.Visible = True
        Me.colDeLinea.VisibleIndex = 1
        Me.colDeLinea.Width = 60
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
        Me.colCodigoArticulo.VisibleIndex = 3
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
        Me.colNombreArticulo.VisibleIndex = 4
        Me.colNombreArticulo.Width = 350
        '
        'colCodigoBarras
        '
        Me.colCodigoBarras.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoBarras.AppearanceHeader.Options.UseFont = True
        Me.colCodigoBarras.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoBarras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarras.FieldName = "CodigoBarras"
        Me.colCodigoBarras.Name = "colCodigoBarras"
        Me.colCodigoBarras.Visible = True
        Me.colCodigoBarras.VisibleIndex = 2
        Me.colCodigoBarras.Width = 125
        '
        'colCostoTotal1
        '
        Me.colCostoTotal1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoTotal1.AppearanceHeader.Options.UseFont = True
        Me.colCostoTotal1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoTotal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoTotal1.Caption = "Costo Material"
        Me.colCostoTotal1.FieldName = "CostoTotal"
        Me.colCostoTotal1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colCostoTotal1.Name = "colCostoTotal1"
        Me.colCostoTotal1.ToolTip = "Sumatoria de la Lista de Materiales del Articulo"
        Me.colCostoTotal1.Visible = True
        Me.colCostoTotal1.VisibleIndex = 6
        Me.colCostoTotal1.Width = 100
        '
        'colStock
        '
        Me.colStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStock.AppearanceHeader.Options.UseFont = True
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 5
        '
        'grdCodigosPadres
        '
        Me.grdCodigosPadres.DataMember = "dsdtCodigosPadres"
        Me.grdCodigosPadres.DataSource = Me.DsListaPreciosCostosActualizar1
        Me.grdCodigosPadres.Location = New System.Drawing.Point(12, 36)
        Me.grdCodigosPadres.MainView = Me.grdviewCodigosPadre
        Me.grdCodigosPadres.MaximumSize = New System.Drawing.Size(350, 0)
        Me.grdCodigosPadres.MinimumSize = New System.Drawing.Size(350, 0)
        Me.grdCodigosPadres.Name = "grdCodigosPadres"
        Me.grdCodigosPadres.Size = New System.Drawing.Size(350, 331)
        Me.grdCodigosPadres.TabIndex = 6
        Me.grdCodigosPadres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigosPadre})
        '
        'grdviewCodigosPadre
        '
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCodigosPadre.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCodigosPadre.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.Preview.Options.UseFont = True
        Me.grdviewCodigosPadre.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosPadre.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCodigosPadre.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosPadre.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewCodigosPadre.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCodigosPadre.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGrupoRastreo, Me.colCodigoPadre, Me.colNombrePadre})
        Me.grdviewCodigosPadre.GridControl = Me.grdCodigosPadres
        Me.grdviewCodigosPadre.GroupCount = 1
        Me.grdviewCodigosPadre.Name = "grdviewCodigosPadre"
        Me.grdviewCodigosPadre.OptionsBehavior.Editable = False
        Me.grdviewCodigosPadre.OptionsBehavior.ReadOnly = True
        Me.grdviewCodigosPadre.OptionsFind.AlwaysVisible = True
        Me.grdviewCodigosPadre.OptionsFind.ShowCloseButton = False
        Me.grdviewCodigosPadre.OptionsFind.ShowFindButton = False
        Me.grdviewCodigosPadre.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCodigosPadre.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCodigosPadre.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigosPadre.PaintStyleName = "UltraFlat"
        Me.grdviewCodigosPadre.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGrupoRastreo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colGrupoRastreo
        '
        Me.colGrupoRastreo.FieldName = "GrupoRastreo"
        Me.colGrupoRastreo.Name = "colGrupoRastreo"
        Me.colGrupoRastreo.Visible = True
        Me.colGrupoRastreo.VisibleIndex = 0
        Me.colGrupoRastreo.Width = 102
        '
        'colCodigoPadre
        '
        Me.colCodigoPadre.FieldName = "CodigoPadre"
        Me.colCodigoPadre.Name = "colCodigoPadre"
        Me.colCodigoPadre.Visible = True
        Me.colCodigoPadre.VisibleIndex = 0
        Me.colCodigoPadre.Width = 82
        '
        'colNombrePadre
        '
        Me.colNombrePadre.FieldName = "NombrePadre"
        Me.colNombrePadre.Name = "colNombrePadre"
        Me.colNombrePadre.Visible = True
        Me.colNombrePadre.VisibleIndex = 1
        Me.colNombrePadre.Width = 258
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1364, 642)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdCodigosPadres
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(354, 335)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdCodigosHijos
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(990, 308)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.grdListaMateriales
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 359)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(754, 263)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdListaMaterialesCP
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(809, 359)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(535, 263)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.sbdcActualizarComponentes
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(754, 514)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(55, 108)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.slueCodigoPadre
        Me.LayoutControlItem7.CustomizationFormText = "Agregar Codigo Padre"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(354, 24)
        Me.LayoutControlItem7.Text = "Agregar Codigo Padre"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbdcListaPreciosCostoActualizar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(354, 308)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(211, 51)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(565, 308)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(779, 51)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(754, 359)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(55, 155)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barActualizarComponentes})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnActualizarComponente, Me.barbtnAgregarGrupoRastreo})
        Me.BarManager2.MaxItemId = 2
        '
        'barActualizarComponentes
        '
        Me.barActualizarComponentes.BarName = "Tools"
        Me.barActualizarComponentes.DockCol = 0
        Me.barActualizarComponentes.DockRow = 0
        Me.barActualizarComponentes.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barActualizarComponentes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizarComponente), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregarGrupoRastreo)})
        Me.barActualizarComponentes.OptionsBar.AllowQuickCustomization = False
        Me.barActualizarComponentes.OptionsBar.DrawBorder = False
        Me.barActualizarComponentes.StandaloneBarDockControl = Me.sbdcActualizarComponentes
        Me.barActualizarComponentes.Text = "Tools"
        '
        'barbtnActualizarComponente
        '
        Me.barbtnActualizarComponente.Caption = "Actualizar Costo del Componente"
        Me.barbtnActualizarComponente.Id = 0
        Me.barbtnActualizarComponente.ImageOptions.Image = CType(resources.GetObject("barbtnActualizarComponente.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizarComponente.Name = "barbtnActualizarComponente"
        '
        'barbtnAgregarGrupoRastreo
        '
        Me.barbtnAgregarGrupoRastreo.Caption = "Agregar A Grupos de Rastreo"
        Me.barbtnAgregarGrupoRastreo.Id = 1
        Me.barbtnAgregarGrupoRastreo.ImageOptions.Image = CType(resources.GetObject("barbtnAgregarGrupoRastreo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregarGrupoRastreo.Name = "barbtnAgregarGrupoRastreo"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1364, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 689)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1364, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 642)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1364, 47)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 642)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAbrirExcel, Me.barbtnDescargarPlantilla})
        Me.BarManager3.MaxItemId = 2
        Me.BarManager3.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAbrirExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDescargarPlantilla, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnAbrirExcel
        '
        Me.barbtnAbrirExcel.Caption = "Cargar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnAbrirExcel.Id = 0
        Me.barbtnAbrirExcel.ImageOptions.Image = CType(resources.GetObject("barbtnAbrirExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAbrirExcel.Name = "barbtnAbrirExcel"
        '
        'barbtnDescargarPlantilla
        '
        Me.barbtnDescargarPlantilla.Caption = "Descargar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plantilla"
        Me.barbtnDescargarPlantilla.Id = 1
        Me.barbtnDescargarPlantilla.ImageOptions.Image = CType(resources.GetObject("barbtnDescargarPlantilla.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDescargarPlantilla.Name = "barbtnDescargarPlantilla"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        Me.Bar3.Visible = False
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(1364, 47)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 689)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(1364, 23)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 642)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1364, 47)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 642)
        '
        'ofdAbrir
        '
        Me.ofdAbrir.FileName = "OpenFileDialog1"
        '
        'frmListaPreciosCostosActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 712)
        Me.Controls.Add(Me.lycListaPreciosCostosActualizar)
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
        Me.Name = "frmListaPreciosCostosActualizar"
        Me.Text = "frmListaPreciosCostosActualizar"
        CType(Me.lycListaPreciosCostosActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaPreciosCostosActualizar.ResumeLayout(False)
        CType(Me.slueCodigoPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaMaterialesCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaPreciosCostosActualizar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaMaterialesCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCodigosPadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigosPadre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycListaPreciosCostosActualizar As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdCodigosPadres As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigosPadre As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsListaPreciosCostosActualizar1 As waProduccion_Pedidos.dsListaPreciosCostosActualizar
    Friend WithEvents colGrupoRastreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombrePadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdCodigosHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigosHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdListaMateriales As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaMateriales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coCostoTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCostoTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdListaMaterialesCP As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewListaMaterialesCP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCodigoArticulo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioUnitario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoTotal3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoActual2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbdcListaPreciosCostoActualizar As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barListaPreciosCostosActualizar As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnActualizarArticulo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sbdcActualizarComponentes As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barActualizarComponentes As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnActualizarComponente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCostoActual1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperarS As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents colCostoSTD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoSTD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoSTD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents slueCodigoPadre As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAbrirExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents barbtnDescargarPlantilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnAgregarGrupoRastreo As DevExpress.XtraBars.BarButtonItem
    'Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
