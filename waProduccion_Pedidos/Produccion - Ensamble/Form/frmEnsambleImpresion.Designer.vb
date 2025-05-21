<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnsambleImpresion
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnsambleImpresion))
        Me.barEnsambleImpresion = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTokenEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.lycEnsambleImpresion = New DevExpress.XtraLayout.LayoutControl()
        Me.grdEnsambleOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.DsEnsambleImpresion1 = New waProduccion_Pedidos.dsEnsambleImpresion()
        Me.grdviewEnsambleOrdenes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreación = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasAtrasado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCampaña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycHijos = New DevExpress.XtraLayout.LayoutControl()
        Me.grdEnsamblePadres = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEnsamblePadres = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycSplitHijos = New DevExpress.XtraLayout.LayoutControl()
        Me.grdEnsambleHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEnsambleHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizarDatos = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.barEnsambleImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTokenEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycEnsambleImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycEnsambleImpresion.SuspendLayout()
        CType(Me.grdEnsambleOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEnsambleImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambleOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.lycHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycHijos.SuspendLayout()
        CType(Me.grdEnsamblePadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsamblePadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycSplitHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplitHijos.SuspendLayout()
        CType(Me.grdEnsambleHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambleHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barEnsambleImpresion
        '
        Me.barEnsambleImpresion.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.barEnsambleImpresion.DockControls.Add(Me.barDockControlTop)
        Me.barEnsambleImpresion.DockControls.Add(Me.barDockControlBottom)
        Me.barEnsambleImpresion.DockControls.Add(Me.barDockControlLeft)
        Me.barEnsambleImpresion.DockControls.Add(Me.barDockControlRight)
        Me.barEnsambleImpresion.Form = Me
        Me.barEnsambleImpresion.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnImprimirEnsamble, Me.barbtnImprimirGrid, Me.barbtnExportarGrid, Me.barbtnBuscar, Me.BarButtonItem1, Me.barbtnActualizarDatos})
        Me.barEnsambleImpresion.MaxItemId = 9
        Me.barEnsambleImpresion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTokenEdit1})
        Me.barEnsambleImpresion.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirEnsamble, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizarDatos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnImprimirEnsamble
        '
        Me.barbtnImprimirEnsamble.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ensamble"
        Me.barbtnImprimirEnsamble.Id = 3
        Me.barbtnImprimirEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirEnsamble.Name = "barbtnImprimirEnsamble"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barEnsambleImpresion
        Me.barDockControlTop.Size = New System.Drawing.Size(1395, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 574)
        Me.barDockControlBottom.Manager = Me.barEnsambleImpresion
        Me.barDockControlBottom.Size = New System.Drawing.Size(1395, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barEnsambleImpresion
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 574)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1395, 0)
        Me.barDockControlRight.Manager = Me.barEnsambleImpresion
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 574)
        '
        'RepositoryItemTokenEdit1
        '
        Me.RepositoryItemTokenEdit1.Name = "RepositoryItemTokenEdit1"
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'lycEnsambleImpresion
        '
        Me.lycEnsambleImpresion.Controls.Add(Me.grdEnsambleOrdenes)
        Me.lycEnsambleImpresion.Controls.Add(Me.SplitContainerControl1)
        Me.lycEnsambleImpresion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycEnsambleImpresion.Location = New System.Drawing.Point(0, 0)
        Me.lycEnsambleImpresion.Name = "lycEnsambleImpresion"
        Me.lycEnsambleImpresion.Root = Me.LayoutControlGroup1
        Me.lycEnsambleImpresion.Size = New System.Drawing.Size(1395, 574)
        Me.lycEnsambleImpresion.TabIndex = 4
        Me.lycEnsambleImpresion.Text = "LayoutControl1"
        '
        'grdEnsambleOrdenes
        '
        Me.grdEnsambleOrdenes.DataMember = "dsdtEnsambleOrdenes"
        Me.grdEnsambleOrdenes.DataSource = Me.DsEnsambleImpresion1
        Me.grdEnsambleOrdenes.Location = New System.Drawing.Point(12, 378)
        Me.grdEnsambleOrdenes.MainView = Me.grdviewEnsambleOrdenes
        Me.grdEnsambleOrdenes.MenuManager = Me.barEnsambleImpresion
        Me.grdEnsambleOrdenes.Name = "grdEnsambleOrdenes"
        Me.grdEnsambleOrdenes.Size = New System.Drawing.Size(1371, 184)
        Me.grdEnsambleOrdenes.TabIndex = 7
        Me.grdEnsambleOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambleOrdenes})
        '
        'DsEnsambleImpresion1
        '
        Me.DsEnsambleImpresion1.DataSetName = "dsEnsambleImpresion"
        Me.DsEnsambleImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewEnsambleOrdenes
        '
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewEnsambleOrdenes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsambleOrdenes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsambleOrdenes.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewEnsambleOrdenes.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleOrdenes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambleOrdenes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleOrdenes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewEnsambleOrdenes.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambleOrdenes.ColumnPanelRowHeight = 35
        Me.grdviewEnsambleOrdenes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colPlaneado2, Me.colCompletado2, Me.colPendiente2, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado, Me.colOrigen, Me.colDestino, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNumeroOrden, Me.colCampaña, Me.colEntrega, Me.colComentario1, Me.colComentario2, Me.colCreacion})
        Me.grdviewEnsambleOrdenes.GridControl = Me.grdEnsambleOrdenes
        Me.grdviewEnsambleOrdenes.Name = "grdviewEnsambleOrdenes"
        Me.grdviewEnsambleOrdenes.OptionsBehavior.Editable = False
        Me.grdviewEnsambleOrdenes.OptionsBehavior.ReadOnly = True
        Me.grdviewEnsambleOrdenes.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambleOrdenes.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambleOrdenes.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambleOrdenes.OptionsView.ShowFooter = True
        Me.grdviewEnsambleOrdenes.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambleOrdenes.PaintStyleName = "Web"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.Caption = "SAP"
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 0
        Me.colNumSAP.Width = 55
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        Me.colEstado.Width = 70
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 70
        '
        'colPlaneado2
        '
        Me.colPlaneado2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPlaneado2.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado2.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado2.FieldName = "Planeado"
        Me.colPlaneado2.Name = "colPlaneado2"
        Me.colPlaneado2.Visible = True
        Me.colPlaneado2.VisibleIndex = 3
        Me.colPlaneado2.Width = 70
        '
        'colCompletado2
        '
        Me.colCompletado2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCompletado2.AppearanceHeader.Options.UseFont = True
        Me.colCompletado2.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado2.FieldName = "Completado"
        Me.colCompletado2.Name = "colCompletado2"
        Me.colCompletado2.Visible = True
        Me.colCompletado2.VisibleIndex = 4
        Me.colCompletado2.Width = 77
        '
        'colPendiente2
        '
        Me.colPendiente2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPendiente2.AppearanceHeader.Options.UseFont = True
        Me.colPendiente2.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente2.FieldName = "Pendiente"
        Me.colPendiente2.Name = "colPendiente2"
        Me.colPendiente2.Visible = True
        Me.colPendiente2.VisibleIndex = 5
        Me.colPendiente2.Width = 70
        '
        'colCreación
        '
        Me.colCreación.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCreación.AppearanceHeader.Options.UseFont = True
        Me.colCreación.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreación.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.FieldName = "Creación"
        Me.colCreación.Name = "colCreación"
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 6
        Me.colCreación.Width = 65
        '
        'colVencimiento
        '
        Me.colVencimiento.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colVencimiento.AppearanceHeader.Options.UseFont = True
        Me.colVencimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.Caption = "Vence"
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 7
        Me.colVencimiento.Width = 65
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDiasAtrasado.AppearanceHeader.Options.UseFont = True
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.Caption = "Dias"
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 8
        Me.colDiasAtrasado.Width = 50
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 9
        Me.colOrigen.Width = 70
        '
        'colDestino
        '
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 10
        Me.colDestino.Width = 70
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrupoCliente.AppearanceHeader.Options.UseFont = True
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 11
        Me.colGrupoCliente.Width = 70
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoCliente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 12
        Me.colCodigoCliente.Width = 70
        '
        'colNumeroOrden
        '
        Me.colNumeroOrden.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumeroOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumeroOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroOrden.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNumeroOrden.FieldName = "NumeroOrden"
        Me.colNumeroOrden.Name = "colNumeroOrden"
        Me.colNumeroOrden.Visible = True
        Me.colNumeroOrden.VisibleIndex = 13
        Me.colNumeroOrden.Width = 70
        '
        'colCampaña
        '
        Me.colCampaña.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCampaña.AppearanceHeader.Options.UseFont = True
        Me.colCampaña.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampaña.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.FieldName = "Campaña"
        Me.colCampaña.Name = "colCampaña"
        Me.colCampaña.Visible = True
        Me.colCampaña.VisibleIndex = 14
        Me.colCampaña.Width = 70
        '
        'colEntrega
        '
        Me.colEntrega.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEntrega.AppearanceHeader.Options.UseFont = True
        Me.colEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.FieldName = "Entrega"
        Me.colEntrega.Name = "colEntrega"
        Me.colEntrega.Visible = True
        Me.colEntrega.VisibleIndex = 15
        Me.colEntrega.Width = 65
        '
        'colComentario1
        '
        Me.colComentario1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colComentario1.AppearanceHeader.Options.UseFont = True
        Me.colComentario1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentario1.Caption = "Comentarios"
        Me.colComentario1.FieldName = "Comentario1"
        Me.colComentario1.Name = "colComentario1"
        Me.colComentario1.Visible = True
        Me.colComentario1.VisibleIndex = 16
        Me.colComentario1.Width = 200
        '
        'colComentario2
        '
        Me.colComentario2.FieldName = "Comentario2"
        Me.colComentario2.Name = "colComentario2"
        '
        'colCreacion
        '
        Me.colCreacion.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCreacion.AppearanceHeader.Options.UseFont = True
        Me.colCreacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreacion.FieldName = "Creacion"
        Me.colCreacion.Name = "colCreacion"
        Me.colCreacion.Visible = True
        Me.colCreacion.VisibleIndex = 17
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lycHijos)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lycSplitHijos)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1371, 362)
        Me.SplitContainerControl1.SplitterPosition = 646
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'lycHijos
        '
        Me.lycHijos.Controls.Add(Me.grdEnsamblePadres)
        Me.lycHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycHijos.Location = New System.Drawing.Point(0, 0)
        Me.lycHijos.Name = "lycHijos"
        Me.lycHijos.Root = Me.LayoutControlGroup3
        Me.lycHijos.Size = New System.Drawing.Size(646, 362)
        Me.lycHijos.TabIndex = 0
        Me.lycHijos.Text = "LayoutControl1"
        '
        'grdEnsamblePadres
        '
        Me.grdEnsamblePadres.DataMember = "dsdtEnsamblePadres"
        Me.grdEnsamblePadres.DataSource = Me.DsEnsambleImpresion1
        Me.grdEnsamblePadres.Location = New System.Drawing.Point(12, 12)
        Me.grdEnsamblePadres.MainView = Me.grdviewEnsamblePadres
        Me.grdEnsamblePadres.MenuManager = Me.barEnsambleImpresion
        Me.grdEnsamblePadres.Name = "grdEnsamblePadres"
        Me.grdEnsamblePadres.Size = New System.Drawing.Size(622, 338)
        Me.grdEnsamblePadres.TabIndex = 4
        Me.grdEnsamblePadres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsamblePadres})
        '
        'grdviewEnsamblePadres
        '
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEnsamblePadres.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsamblePadres.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsamblePadres.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsamblePadres.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsamblePadres.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsamblePadres.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEnsamblePadres.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsamblePadres.ColumnPanelRowHeight = 35
        Me.grdviewEnsamblePadres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente})
        Me.grdviewEnsamblePadres.GridControl = Me.grdEnsamblePadres
        Me.grdviewEnsamblePadres.Name = "grdviewEnsamblePadres"
        Me.grdviewEnsamblePadres.OptionsBehavior.Editable = False
        Me.grdviewEnsamblePadres.OptionsBehavior.ReadOnly = True
        Me.grdviewEnsamblePadres.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsamblePadres.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsamblePadres.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsamblePadres.OptionsView.ShowFooter = True
        Me.grdviewEnsamblePadres.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsamblePadres.PaintStyleName = "Web"
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.colPrioridad.AppearanceHeader.Options.UseFont = True
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 45
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 250
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 70
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 70
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(646, 362)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdEnsamblePadres
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(626, 342)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'lycSplitHijos
        '
        Me.lycSplitHijos.Controls.Add(Me.grdEnsambleHijos)
        Me.lycSplitHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplitHijos.Location = New System.Drawing.Point(0, 0)
        Me.lycSplitHijos.Name = "lycSplitHijos"
        Me.lycSplitHijos.Root = Me.LayoutControlGroup2
        Me.lycSplitHijos.Size = New System.Drawing.Size(720, 362)
        Me.lycSplitHijos.TabIndex = 0
        Me.lycSplitHijos.Text = "LayoutControl1"
        '
        'grdEnsambleHijos
        '
        Me.grdEnsambleHijos.DataMember = "dsdtEnsambleHijos"
        Me.grdEnsambleHijos.DataSource = Me.DsEnsambleImpresion1
        Me.grdEnsambleHijos.Location = New System.Drawing.Point(12, 12)
        Me.grdEnsambleHijos.MainView = Me.grdviewEnsambleHijos
        Me.grdEnsambleHijos.MenuManager = Me.barEnsambleImpresion
        Me.grdEnsambleHijos.Name = "grdEnsambleHijos"
        Me.grdEnsambleHijos.Size = New System.Drawing.Size(696, 338)
        Me.grdEnsambleHijos.TabIndex = 4
        Me.grdEnsambleHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambleHijos})
        '
        'grdviewEnsambleHijos
        '
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsambleHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsambleHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambleHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewEnsambleHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambleHijos.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewEnsambleHijos.ColumnPanelRowHeight = 35
        Me.grdviewEnsambleHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colCodigoPadre, Me.colColor, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colProdFinal})
        Me.grdviewEnsambleHijos.GridControl = Me.grdEnsambleHijos
        Me.grdviewEnsambleHijos.Name = "grdviewEnsambleHijos"
        Me.grdviewEnsambleHijos.OptionsBehavior.Editable = False
        Me.grdviewEnsambleHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewEnsambleHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambleHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambleHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambleHijos.OptionsView.ShowFooter = True
        Me.grdviewEnsambleHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambleHijos.PaintStyleName = "Web"
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 0
        Me.colCodigoArticulo1.Width = 105
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 1
        Me.colNombreArticulo1.Width = 300
        '
        'colCodigoPadre
        '
        Me.colCodigoPadre.FieldName = "CodigoPadre"
        Me.colCodigoPadre.Name = "colCodigoPadre"
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 2
        Me.colColor.Width = 45
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 3
        Me.colPlaneado1.Width = 70
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 4
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente1.AppearanceHeader.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 5
        Me.colPendiente1.Width = 70
        '
        'colProdFinal
        '
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(720, 362)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdEnsambleHijos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(700, 342)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1395, 574)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SplitContainerControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1375, 366)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdEnsambleOrdenes
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 366)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1375, 188)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 4
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarGrid
        '
        Me.barbtnExportarGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarGrid.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnExportarGrid.Id = 5
        Me.barbtnExportarGrid.ImageOptions.Image = CType(resources.GetObject("barbtnExportarGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarGrid.Name = "barbtnExportarGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 6
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Aplicar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibo"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image1"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barbtnActualizarDatos
        '
        Me.barbtnActualizarDatos.Caption = "Actualizar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datos"
        Me.barbtnActualizarDatos.Id = 8
        Me.barbtnActualizarDatos.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizarDatos.Name = "barbtnActualizarDatos"
        '
        'frmEnsambleImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycEnsambleImpresion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEnsambleImpresion"
        Me.Text = "TRABAJOS DE ENSAMBLE"
        CType(Me.barEnsambleImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTokenEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycEnsambleImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycEnsambleImpresion.ResumeLayout(False)
        CType(Me.grdEnsambleOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEnsambleImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambleOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.lycHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycHijos.ResumeLayout(False)
        CType(Me.grdEnsamblePadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsamblePadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycSplitHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplitHijos.ResumeLayout(False)
        CType(Me.grdEnsambleHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambleHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barEnsambleImpresion As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lycEnsambleImpresion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DsEnsambleImpresion1 As waProduccion_Pedidos.dsEnsambleImpresion
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycHijos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdEnsamblePadres As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsamblePadres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycSplitHijos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdEnsambleHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsambleHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdEnsambleOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsambleOrdenes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasAtrasado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCampaña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemTokenEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents barbtnImprimirEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizarDatos As DevExpress.XtraBars.BarButtonItem
End Class
