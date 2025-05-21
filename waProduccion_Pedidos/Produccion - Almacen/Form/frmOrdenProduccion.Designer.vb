<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenProduccion
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenProduccion))
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.mmeComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcOrdenesProduccion = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdIngresoOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.DsIngresoAnalisisCP1 = New waProduccion_Pedidos.dsIngresoAnalisisCP()
        Me.grdviewArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueDestino = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueColores = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueGrupoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumOrdenVenta = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumCampana = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dedtEntrega = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.grdCodigoProducidosHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCodigosProducidosHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMetasa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPradera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisponible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.slueCodigosProducidosPadres = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdIngresoOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresoAnalisisCP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedtEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedtEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCodigoProducidosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigosProducidosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigosProducidosPadres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceCell.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeLinea.AppearanceHeader.Options.UseFont = True
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.ReadOnly = True
        Me.colDeLinea.Visible = True
        Me.colDeLinea.VisibleIndex = 0
        Me.colDeLinea.Width = 56
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Controls.Add(Me.grdCodigoProducidosHijos)
        Me.LayoutControl1.Controls.Add(Me.slueCodigosProducidosPadres)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1360, 631)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LayoutControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 220)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1336, 399)
        Me.PanelControl1.TabIndex = 6
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.mmeComentarios)
        Me.LayoutControl2.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl2.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl2.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl2.Controls.Add(Me.sbdcOrdenesProduccion)
        Me.LayoutControl2.Controls.Add(Me.grdIngresoOrdenes)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(1332, 395)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'mmeComentarios
        '
        Me.mmeComentarios.Enabled = False
        Me.mmeComentarios.Location = New System.Drawing.Point(164, 88)
        Me.mmeComentarios.MenuManager = Me.BarManager1
        Me.mmeComentarios.Name = "mmeComentarios"
        Me.mmeComentarios.Size = New System.Drawing.Size(1156, 29)
        Me.mmeComentarios.StyleController = Me.LayoutControl2
        Me.mmeComentarios.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcOrdenesProduccion)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSAP})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSAP)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcOrdenesProduccion
        Me.Bar1.Text = "Tools"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Caption = "Generar Orden"
        Me.barbtnSAP.Enabled = False
        Me.barbtnSAP.Id = 0
        Me.barbtnSAP.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.ImageOptions.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'sbdcOrdenesProduccion
        '
        Me.sbdcOrdenesProduccion.CausesValidation = False
        Me.sbdcOrdenesProduccion.Location = New System.Drawing.Point(12, 12)
        Me.sbdcOrdenesProduccion.Manager = Me.BarManager1
        Me.sbdcOrdenesProduccion.Name = "sbdcOrdenesProduccion"
        Me.sbdcOrdenesProduccion.Size = New System.Drawing.Size(1308, 48)
        Me.sbdcOrdenesProduccion.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1360, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 678)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1360, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 631)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1360, 47)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 631)
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(1260, 64)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.MenuManager = Me.BarManager1
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDeLinea.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDeLinea.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDeLinea.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.StyleController = Me.LayoutControl2
        Me.txtDeLinea.TabIndex = 7
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(456, 64)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreArticulo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombreArticulo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNombreArticulo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(648, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl2
        Me.txtNombreArticulo.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(164, 64)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(136, 20)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(136, 20)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoArticulo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoArticulo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodigoArticulo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl2
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'grdIngresoOrdenes
        '
        Me.grdIngresoOrdenes.DataMember = "dsdtIngresoOrdenes"
        Me.grdIngresoOrdenes.DataSource = Me.DsIngresoAnalisisCP1
        Me.grdIngresoOrdenes.Enabled = False
        Me.grdIngresoOrdenes.Location = New System.Drawing.Point(12, 140)
        Me.grdIngresoOrdenes.MainView = Me.grdviewArticulos
        Me.grdIngresoOrdenes.Name = "grdIngresoOrdenes"
        Me.grdIngresoOrdenes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen, Me.rslueDestino, Me.rslueColores, Me.rslueGrupoCliente, Me.rslueCodigoCliente, Me.rslueNumOrdenVenta, Me.rslueNumCampana, Me.dedtEntrega})
        Me.grdIngresoOrdenes.Size = New System.Drawing.Size(1308, 243)
        Me.grdIngresoOrdenes.TabIndex = 4
        Me.grdIngresoOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewArticulos})
        '
        'DsIngresoAnalisisCP1
        '
        Me.DsIngresoAnalisisCP1.DataSetName = "dsIngresoAnalisisCP"
        Me.DsIngresoAnalisisCP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewArticulos
        '
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseFont = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCantidad, Me.colOrigen, Me.colDestino, Me.colColor, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNombreCliente, Me.colNumOrden, Me.colNumCampana, Me.colNombreCampana, Me.colFechaEntrega, Me.colComentarios})
        Me.grdviewArticulos.GridControl = Me.grdIngresoOrdenes
        Me.grdviewArticulos.Name = "grdviewArticulos"
        Me.grdviewArticulos.NewItemRowText = "Click aquí para ingresar un nuevo Pedido a Producción"
        Me.grdviewArticulos.OptionsView.ColumnAutoWidth = False
        Me.grdviewArticulos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewArticulos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewArticulos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewArticulos.OptionsView.ShowFooter = True
        Me.grdviewArticulos.OptionsView.ShowGroupPanel = False
        Me.grdviewArticulos.PaintStyleName = "Flat"
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "{0:n0}")})
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 0
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.ColumnEdit = Me.rslueOrigen
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 1
        Me.colOrigen.Width = 92
        '
        'rslueOrigen
        '
        Me.rslueOrigen.AutoHeight = False
        Me.rslueOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen.Name = "rslueOrigen"
        Me.rslueOrigen.NullText = ""
        Me.rslueOrigen.ShowClearButton = False
        Me.rslueOrigen.ShowFooter = False
        Me.rslueOrigen.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDestino
        '
        Me.colDestino.AppearanceCell.Options.UseTextOptions = True
        Me.colDestino.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.ColumnEdit = Me.rslueDestino
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 2
        Me.colDestino.Width = 92
        '
        'rslueDestino
        '
        Me.rslueDestino.AutoHeight = False
        Me.rslueDestino.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestino.Name = "rslueDestino"
        Me.rslueDestino.NullText = ""
        Me.rslueDestino.ShowClearButton = False
        Me.rslueDestino.ShowFooter = False
        Me.rslueDestino.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.ColumnEdit = Me.rslueColores
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 3
        Me.colColor.Width = 67
        '
        'rslueColores
        '
        Me.rslueColores.AutoHeight = False
        Me.rslueColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueColores.Name = "rslueColores"
        Me.rslueColores.NullText = ""
        Me.rslueColores.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupoCliente.AppearanceHeader.Options.UseFont = True
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.ColumnEdit = Me.rslueGrupoCliente
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 4
        Me.colGrupoCliente.Width = 113
        '
        'rslueGrupoCliente
        '
        Me.rslueGrupoCliente.AutoHeight = False
        Me.rslueGrupoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueGrupoCliente.Name = "rslueGrupoCliente"
        Me.rslueGrupoCliente.NullText = ""
        Me.rslueGrupoCliente.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCliente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.Caption = "Cod Cliente"
        Me.colCodigoCliente.ColumnEdit = Me.rslueCodigoCliente
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 5
        Me.colCodigoCliente.Width = 71
        '
        'rslueCodigoCliente
        '
        Me.rslueCodigoCliente.AutoHeight = False
        Me.rslueCodigoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoCliente.Name = "rslueCodigoCliente"
        Me.rslueCodigoCliente.NullText = ""
        Me.rslueCodigoCliente.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCliente.AppearanceHeader.Options.UseFont = True
        Me.colNombreCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.OptionsColumn.AllowEdit = False
        Me.colNombreCliente.OptionsColumn.ReadOnly = True
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 6
        Me.colNombreCliente.Width = 224
        '
        'colNumOrden
        '
        Me.colNumOrden.AppearanceCell.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.ColumnEdit = Me.rslueNumOrdenVenta
        Me.colNumOrden.FieldName = "NumOrden"
        Me.colNumOrden.Name = "colNumOrden"
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 7
        Me.colNumOrden.Width = 71
        '
        'rslueNumOrdenVenta
        '
        Me.rslueNumOrdenVenta.AutoHeight = False
        Me.rslueNumOrdenVenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumOrdenVenta.Name = "rslueNumOrdenVenta"
        Me.rslueNumOrdenVenta.NullText = ""
        Me.rslueNumOrdenVenta.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colNumCampana
        '
        Me.colNumCampana.AppearanceCell.Options.UseTextOptions = True
        Me.colNumCampana.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumCampana.AppearanceHeader.Options.UseFont = True
        Me.colNumCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCampana.ColumnEdit = Me.rslueNumCampana
        Me.colNumCampana.FieldName = "NumCampana"
        Me.colNumCampana.Name = "colNumCampana"
        Me.colNumCampana.Visible = True
        Me.colNumCampana.VisibleIndex = 8
        Me.colNumCampana.Width = 71
        '
        'rslueNumCampana
        '
        Me.rslueNumCampana.AutoHeight = False
        Me.rslueNumCampana.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumCampana.Name = "rslueNumCampana"
        Me.rslueNumCampana.NullText = ""
        Me.rslueNumCampana.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colNombreCampana
        '
        Me.colNombreCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCampana.AppearanceHeader.Options.UseFont = True
        Me.colNombreCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCampana.FieldName = "NombreCampana"
        Me.colNombreCampana.Name = "colNombreCampana"
        Me.colNombreCampana.OptionsColumn.AllowEdit = False
        Me.colNombreCampana.OptionsColumn.ReadOnly = True
        Me.colNombreCampana.Visible = True
        Me.colNombreCampana.VisibleIndex = 9
        Me.colNombreCampana.Width = 182
        '
        'colFechaEntrega
        '
        Me.colFechaEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaEntrega.AppearanceHeader.Options.UseFont = True
        Me.colFechaEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.Caption = "Entrega"
        Me.colFechaEntrega.ColumnEdit = Me.dedtEntrega
        Me.colFechaEntrega.FieldName = "FechaEntrega"
        Me.colFechaEntrega.Name = "colFechaEntrega"
        Me.colFechaEntrega.Visible = True
        Me.colFechaEntrega.VisibleIndex = 10
        Me.colFechaEntrega.Width = 80
        '
        'dedtEntrega
        '
        Me.dedtEntrega.AutoHeight = False
        Me.dedtEntrega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedtEntrega.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedtEntrega.Name = "dedtEntrega"
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
        Me.colComentarios.VisibleIndex = 11
        Me.colComentarios.Width = 193
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1332, 395)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem4.Control = Me.grdIngresoOrdenes
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 109)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1312, 266)
        Me.LayoutControlItem4.Text = "Ordenes de Produccion"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(149, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbdcOrdenesProduccion
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1312, 52)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem6.CustomizationFormText = "Codigo Componente"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(292, 24)
        Me.LayoutControlItem6.Text = "Codigo Componente"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtNombreArticulo
        Me.LayoutControlItem7.CustomizationFormText = "Nombre Componente"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(292, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(804, 24)
        Me.LayoutControlItem7.Text = "Nombre Componente"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.txtDeLinea
        Me.LayoutControlItem8.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(1096, 52)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(216, 24)
        Me.LayoutControlItem8.Text = "De Linea?"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(149, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem9.Control = Me.mmeComentarios
        Me.LayoutControlItem9.CustomizationFormText = "Comentarios"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1312, 33)
        Me.LayoutControlItem9.Text = "Comentarios"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(149, 13)
        '
        'grdCodigoProducidosHijos
        '
        Me.grdCodigoProducidosHijos.DataMember = "dsdtIngresoAnalisisCP"
        Me.grdCodigoProducidosHijos.DataSource = Me.DsIngresoAnalisisCP1
        Me.grdCodigoProducidosHijos.Location = New System.Drawing.Point(12, 55)
        Me.grdCodigoProducidosHijos.MainView = Me.grdviewCodigosProducidosHijos
        Me.grdCodigoProducidosHijos.Name = "grdCodigoProducidosHijos"
        Me.grdCodigoProducidosHijos.Size = New System.Drawing.Size(1336, 161)
        Me.grdCodigoProducidosHijos.TabIndex = 5
        Me.grdCodigoProducidosHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigosProducidosHijos})
        '
        'grdviewCodigosProducidosHijos
        '
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosProducidosHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosProducidosHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosProducidosHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewCodigosProducidosHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosProducidosHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosProducidosHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewCodigosProducidosHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCodigosProducidosHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colStockTotal, Me.colAlmacen, Me.colMetasa, Me.colPradera, Me.colProduccion, Me.colComprometido, Me.colDisponible})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Green
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colDeLinea
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "SI"
        Me.grdviewCodigosProducidosHijos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grdviewCodigosProducidosHijos.GridControl = Me.grdCodigoProducidosHijos
        Me.grdviewCodigosProducidosHijos.Name = "grdviewCodigosProducidosHijos"
        Me.grdviewCodigosProducidosHijos.OptionsBehavior.Editable = False
        Me.grdviewCodigosProducidosHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewCodigosProducidosHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewCodigosProducidosHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCodigosProducidosHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCodigosProducidosHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigosProducidosHijos.PaintStyleName = "Web"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        Me.colCodigoArticulo.Width = 149
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
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 404
        '
        'colStockTotal
        '
        Me.colStockTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStockTotal.AppearanceHeader.Options.UseFont = True
        Me.colStockTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockTotal.FieldName = "StockTotal"
        Me.colStockTotal.Name = "colStockTotal"
        Me.colStockTotal.OptionsColumn.ReadOnly = True
        Me.colStockTotal.Visible = True
        Me.colStockTotal.VisibleIndex = 3
        Me.colStockTotal.Width = 100
        '
        'colAlmacen
        '
        Me.colAlmacen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlmacen.AppearanceHeader.Options.UseFont = True
        Me.colAlmacen.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlmacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen.FieldName = "Almacen"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.OptionsColumn.ReadOnly = True
        Me.colAlmacen.Visible = True
        Me.colAlmacen.VisibleIndex = 4
        Me.colAlmacen.Width = 100
        '
        'colMetasa
        '
        Me.colMetasa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMetasa.AppearanceHeader.Options.UseFont = True
        Me.colMetasa.AppearanceHeader.Options.UseTextOptions = True
        Me.colMetasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa.FieldName = "Metasa"
        Me.colMetasa.Name = "colMetasa"
        Me.colMetasa.OptionsColumn.ReadOnly = True
        Me.colMetasa.Visible = True
        Me.colMetasa.VisibleIndex = 5
        Me.colMetasa.Width = 100
        '
        'colPradera
        '
        Me.colPradera.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPradera.AppearanceHeader.Options.UseFont = True
        Me.colPradera.AppearanceHeader.Options.UseTextOptions = True
        Me.colPradera.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera.FieldName = "Pradera"
        Me.colPradera.Name = "colPradera"
        Me.colPradera.OptionsColumn.ReadOnly = True
        Me.colPradera.Visible = True
        Me.colPradera.VisibleIndex = 6
        Me.colPradera.Width = 100
        '
        'colProduccion
        '
        Me.colProduccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduccion.AppearanceHeader.Options.UseFont = True
        Me.colProduccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion.FieldName = "Produccion"
        Me.colProduccion.Name = "colProduccion"
        Me.colProduccion.OptionsColumn.ReadOnly = True
        Me.colProduccion.Visible = True
        Me.colProduccion.VisibleIndex = 7
        Me.colProduccion.Width = 100
        '
        'colComprometido
        '
        Me.colComprometido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComprometido.AppearanceHeader.Options.UseFont = True
        Me.colComprometido.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido.Caption = "Comprometido"
        Me.colComprometido.FieldName = "Comprometido"
        Me.colComprometido.Name = "colComprometido"
        Me.colComprometido.OptionsColumn.ReadOnly = True
        Me.colComprometido.Visible = True
        Me.colComprometido.VisibleIndex = 8
        Me.colComprometido.Width = 100
        '
        'colDisponible
        '
        Me.colDisponible.AppearanceCell.BackColor = System.Drawing.Color.SkyBlue
        Me.colDisponible.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDisponible.AppearanceCell.Options.UseBackColor = True
        Me.colDisponible.AppearanceCell.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDisponible.AppearanceHeader.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Options.UseTextOptions = True
        Me.colDisponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDisponible.FieldName = "Disponible"
        Me.colDisponible.Name = "colDisponible"
        Me.colDisponible.OptionsColumn.ReadOnly = True
        Me.colDisponible.Visible = True
        Me.colDisponible.VisibleIndex = 9
        Me.colDisponible.Width = 100
        '
        'slueCodigosProducidosPadres
        '
        Me.slueCodigosProducidosPadres.Location = New System.Drawing.Point(244, 12)
        Me.slueCodigosProducidosPadres.MaximumSize = New System.Drawing.Size(126, 20)
        Me.slueCodigosProducidosPadres.MinimumSize = New System.Drawing.Size(126, 20)
        Me.slueCodigosProducidosPadres.Name = "slueCodigosProducidosPadres"
        Me.slueCodigosProducidosPadres.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigosProducidosPadres.Properties.NullText = ""
        Me.slueCodigosProducidosPadres.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigosProducidosPadres.Size = New System.Drawing.Size(126, 20)
        Me.slueCodigosProducidosPadres.StyleController = Me.LayoutControl1
        Me.slueCodigosProducidosPadres.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1360, 631)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.slueCodigosProducidosPadres
        Me.LayoutControlItem1.CustomizationFormText = "Codigo Producido CP"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem1.Text = "Codigo Producido CP"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(229, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.grdCodigoProducidosHijos
        Me.LayoutControlItem2.CustomizationFormText = "Resultado Codigos Producidos Hijos"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1340, 184)
        Me.LayoutControlItem2.Text = "Resultado Codigos Producidos Hijos"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(229, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(362, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(978, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 208)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1340, 403)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnStock, Me.barbtnDeudaEnsamble, Me.barbtnProduccion})
        Me.BarManager2.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnStock), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnProduccion), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDeudaEnsamble)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.Text = "Tools"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Id = 0
        Me.barbtnStock.ImageOptions.Image = CType(resources.GetObject("barbtnStock.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnStock.Name = "barbtnStock"
        '
        'barbtnProduccion
        '
        Me.barbtnProduccion.Caption = "Produccion"
        Me.barbtnProduccion.Id = 2
        Me.barbtnProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProduccion.Name = "barbtnProduccion"
        '
        'barbtnDeudaEnsamble
        '
        Me.barbtnDeudaEnsamble.Caption = "Comprometido"
        Me.barbtnDeudaEnsamble.Id = 1
        Me.barbtnDeudaEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaEnsamble.Name = "barbtnDeudaEnsamble"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1360, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 678)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1360, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 631)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1360, 47)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 631)
        '
        'frmOrdenProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 678)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "frmOrdenProduccion"
        Me.Text = "frmIngresoAnalisisCP"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdIngresoOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresoAnalisisCP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedtEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedtEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCodigoProducidosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigosProducidosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigosProducidosPadres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdCodigoProducidosHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigosProducidosHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueCodigosProducidosPadres As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMetasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPradera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisponible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdIngresoOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsIngresoAnalisisCP1 As waProduccion_Pedidos.dsIngresoAnalisisCP
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbdcOrdenesProduccion As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rslueOrigen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueDestino As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueColores As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueGrupoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumOrdenVenta As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumCampana As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dedtEntrega As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents mmeComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaEnsamble As DevExpress.XtraBars.BarButtonItem
End Class
