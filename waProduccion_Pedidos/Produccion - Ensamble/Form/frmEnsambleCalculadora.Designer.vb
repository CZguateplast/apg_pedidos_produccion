<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnsambleCalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnsambleCalculadora))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colDisponible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnsambleXHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.lycEnsambleCalculadora = New DevExpress.XtraLayout.LayoutControl()
        Me.sccEnsambleCalculadora = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycSplit1 = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcEnsambleCalculadora = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barEnsambleCalculadora = New DevExpress.XtraBars.Bar()
        Me.barbtnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnsDuplicar = New DevExpress.XtraBars.BarSubItem()
        Me.barbtnDuplicarEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDuplicarBotadero = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSellado = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDuplicarEmpaque = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDuplicarImprenta = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDuplicarOtros = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetalleOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaRol = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaCampana = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaProyeccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnMostrar = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.rccbeubicaciones = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.barbtnEnsambleDeuda = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscarCodigo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscarPadre = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscarCampana = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnParametrosDefault = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImpresionFormato = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAyuda = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarToggleSwitchItem1 = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.barbtnAgrupar = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.barbtnDuplicarLinea = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemBreadCrumbEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit()
        Me.Token1 = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
        Me.grdEnsambleCalculadora = New DevExpress.XtraGrid.GridControl()
        Me.DsEnsambleCalculadora1 = New waProduccion_Pedidos.dsEnsambleCalculadora()
        Me.grdviewEnsambleCalculadora = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnsambleDeuda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEquipoPersonas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnsambleXPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rcalCalculadora = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colHorasXPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProyectado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycSplit2 = New DevExpress.XtraLayout.LayoutControl()
        Me.spinResultadoSueldoExtra_Dia = New DevExpress.XtraEditors.SpinEdit()
        Me.spinResultadoSueldoBase_Dia = New DevExpress.XtraEditors.SpinEdit()
        Me.spinTotalXCompleto = New DevExpress.XtraEditors.SpinEdit()
        Me.spinResultadoXPersona_Extras = New DevExpress.XtraEditors.SpinEdit()
        Me.spinResultadoXPersona_Base = New DevExpress.XtraEditors.SpinEdit()
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton()
        Me.spinResultadoCantidadPersonas = New DevExpress.XtraEditors.SpinEdit()
        Me.spinXdiasTrabajo = New DevExpress.XtraEditors.SpinEdit()
        Me.spinResultado_DiasTrabajo = New DevExpress.XtraEditors.SpinEdit()
        Me.spinXPersonas = New DevExpress.XtraEditors.SpinEdit()
        Me.spinHorasDiarias = New DevExpress.XtraEditors.SpinEdit()
        Me.spinHorasPendientes = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.btsAgrupar = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btsMultiSeleccion = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btsExpandir = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.colMinimo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.lycEnsambleCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycEnsambleCalculadora.SuspendLayout()
        CType(Me.sccEnsambleCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sccEnsambleCalculadora.SuspendLayout()
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rccbeubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemBreadCrumbEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Token1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnsambleCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEnsambleCalculadora1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambleCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcalCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycSplit2.SuspendLayout()
        CType(Me.spinResultadoSueldoExtra_Dia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinResultadoSueldoBase_Dia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinTotalXCompleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinResultadoXPersona_Extras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinResultadoXPersona_Base.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinResultadoCantidadPersonas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinXdiasTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinResultado_DiasTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinXPersonas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinHorasDiarias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinHorasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDisponible
        '
        Me.colDisponible.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDisponible.AppearanceCell.Options.UseBackColor = True
        Me.colDisponible.AppearanceCell.Options.UseTextOptions = True
        Me.colDisponible.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDisponible.AppearanceHeader.Options.UseTextOptions = True
        Me.colDisponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDisponible.Caption = "Disponible"
        Me.colDisponible.FieldName = "Disponible"
        Me.colDisponible.Name = "colDisponible"
        Me.colDisponible.Visible = True
        Me.colDisponible.VisibleIndex = 15
        Me.colDisponible.Width = 80
        '
        'colEnsambleXHora
        '
        Me.colEnsambleXHora.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colEnsambleXHora.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEnsambleXHora.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colEnsambleXHora.AppearanceCell.Options.UseBackColor = True
        Me.colEnsambleXHora.AppearanceCell.Options.UseFont = True
        Me.colEnsambleXHora.AppearanceCell.Options.UseForeColor = True
        Me.colEnsambleXHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsambleXHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsambleXHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnsambleXHora.Caption = "Ensambles por Hora [Equipo]"
        Me.colEnsambleXHora.DisplayFormat.FormatString = "{0:n0}"
        Me.colEnsambleXHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEnsambleXHora.FieldName = "EnsamblesXHora"
        Me.colEnsambleXHora.Name = "colEnsambleXHora"
        Me.colEnsambleXHora.OptionsColumn.AllowEdit = False
        Me.colEnsambleXHora.OptionsColumn.TabStop = False
        Me.colEnsambleXHora.UnboundExpression = "[EnsambleXPersona] * [EquipoPersonas]"
        Me.colEnsambleXHora.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colEnsambleXHora.Visible = True
        Me.colEnsambleXHora.VisibleIndex = 9
        Me.colEnsambleXHora.Width = 90
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.TabStop = False
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 3
        Me.colCodigoArticulo.Width = 119
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'lycEnsambleCalculadora
        '
        Me.lycEnsambleCalculadora.Controls.Add(Me.sccEnsambleCalculadora)
        Me.lycEnsambleCalculadora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycEnsambleCalculadora.Location = New System.Drawing.Point(0, 59)
        Me.lycEnsambleCalculadora.Margin = New System.Windows.Forms.Padding(4)
        Me.lycEnsambleCalculadora.Name = "lycEnsambleCalculadora"
        Me.lycEnsambleCalculadora.Root = Me.LayoutControlGroup1
        Me.lycEnsambleCalculadora.Size = New System.Drawing.Size(2071, 718)
        Me.lycEnsambleCalculadora.TabIndex = 0
        Me.lycEnsambleCalculadora.Text = "LayoutControl1"
        '
        'sccEnsambleCalculadora
        '
        Me.sccEnsambleCalculadora.Location = New System.Drawing.Point(16, 16)
        Me.sccEnsambleCalculadora.Margin = New System.Windows.Forms.Padding(4)
        Me.sccEnsambleCalculadora.Name = "sccEnsambleCalculadora"
        Me.sccEnsambleCalculadora.Panel1.Controls.Add(Me.lycSplit1)
        Me.sccEnsambleCalculadora.Panel1.Text = "Panel1"
        Me.sccEnsambleCalculadora.Panel2.Controls.Add(Me.lycSplit2)
        Me.sccEnsambleCalculadora.Panel2.Text = "Panel2"
        Me.sccEnsambleCalculadora.Size = New System.Drawing.Size(2039, 686)
        Me.sccEnsambleCalculadora.SplitterPosition = 1655
        Me.sccEnsambleCalculadora.TabIndex = 5
        Me.sccEnsambleCalculadora.Text = "SplitContainerControl1"
        '
        'lycSplit1
        '
        Me.lycSplit1.Controls.Add(Me.sbdcEnsambleCalculadora)
        Me.lycSplit1.Controls.Add(Me.grdEnsambleCalculadora)
        Me.lycSplit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit1.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit1.Margin = New System.Windows.Forms.Padding(4)
        Me.lycSplit1.Name = "lycSplit1"
        Me.lycSplit1.Root = Me.LayoutControlGroup2
        Me.lycSplit1.Size = New System.Drawing.Size(1655, 686)
        Me.lycSplit1.TabIndex = 0
        Me.lycSplit1.Text = "LayoutControl1"
        '
        'sbdcEnsambleCalculadora
        '
        Me.sbdcEnsambleCalculadora.CausesValidation = False
        Me.sbdcEnsambleCalculadora.Location = New System.Drawing.Point(16, 633)
        Me.sbdcEnsambleCalculadora.Manager = Me.BarManager1
        Me.sbdcEnsambleCalculadora.Margin = New System.Windows.Forms.Padding(4)
        Me.sbdcEnsambleCalculadora.Name = "sbdcEnsambleCalculadora"
        Me.sbdcEnsambleCalculadora.Size = New System.Drawing.Size(482, 37)
        Me.sbdcEnsambleCalculadora.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barEnsambleCalculadora, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcEnsambleCalculadora)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnBuscarCodigo, Me.barbtnBuscarCampana, Me.BarToggleSwitchItem1, Me.barbtnAgrupar, Me.barbtnDuplicarLinea, Me.barbtnsDuplicar, Me.barbtnDuplicarEnsamble, Me.barbtnDuplicarBotadero, Me.barbtnDuplicarEmpaque, Me.barbtnDuplicarImprenta, Me.barbtnDuplicarOtros, Me.barbtnEliminar, Me.barbtnBuscarPadre, Me.barbtnNuevo, Me.barbtnEnsambleDeuda, Me.barbtnBuscar, Me.barbtnExportarXlsx, Me.barbtnImprimirGrid, Me.barbtnAyuda, Me.BarButtonItem1, Me.barbtnDetalleOrden, Me.barbtnImpresionFormato, Me.barbtnMostrar, Me.BarEditItem1, Me.barbtnDeudaRol, Me.barbtnStock, Me.barbtnDeudaCampana, Me.barbtnSellado, Me.barbtnParametrosDefault, Me.barbtnDeudaProyeccion})
        Me.BarManager1.MaxItemId = 42
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRadioGroup1, Me.RepositoryItemTextEdit1, Me.rccbeubicaciones, Me.RepositoryItemImageComboBox1, Me.RepositoryItemTextEdit2, Me.RepositoryItemBreadCrumbEdit1, Me.Token1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barEnsambleCalculadora
        '
        Me.barEnsambleCalculadora.BarName = "Tools"
        Me.barEnsambleCalculadora.DockCol = 0
        Me.barEnsambleCalculadora.DockRow = 0
        Me.barEnsambleCalculadora.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barEnsambleCalculadora.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnsDuplicar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnStock, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDetalleOrden, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaRol, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaCampana, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDeudaProyeccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnMostrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barEnsambleCalculadora.OptionsBar.AllowQuickCustomization = False
        Me.barEnsambleCalculadora.OptionsBar.DrawBorder = False
        Me.barEnsambleCalculadora.OptionsBar.DrawDragBorder = False
        Me.barEnsambleCalculadora.Text = "Tools"
        '
        'barbtnNuevo
        '
        Me.barbtnNuevo.Caption = "Nuevo"
        Me.barbtnNuevo.Id = 14
        Me.barbtnNuevo.ImageOptions.Image = CType(resources.GetObject("barbtnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnNuevo.Name = "barbtnNuevo"
        '
        'barbtnsDuplicar
        '
        Me.barbtnsDuplicar.Caption = "Duplicar"
        Me.barbtnsDuplicar.Id = 6
        Me.barbtnsDuplicar.ImageOptions.Image = CType(resources.GetObject("barbtnsDuplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnsDuplicar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicarEnsamble), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicarBotadero), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSellado), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicarEmpaque), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicarImprenta), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDuplicarOtros)})
        Me.barbtnsDuplicar.Name = "barbtnsDuplicar"
        '
        'barbtnDuplicarEnsamble
        '
        Me.barbtnDuplicarEnsamble.Caption = "Ensamble"
        Me.barbtnDuplicarEnsamble.Id = 7
        Me.barbtnDuplicarEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarEnsamble.Name = "barbtnDuplicarEnsamble"
        '
        'barbtnDuplicarBotadero
        '
        Me.barbtnDuplicarBotadero.Caption = "Botadero"
        Me.barbtnDuplicarBotadero.Id = 8
        Me.barbtnDuplicarBotadero.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarBotadero.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarBotadero.Name = "barbtnDuplicarBotadero"
        '
        'barbtnSellado
        '
        Me.barbtnSellado.Caption = "Sellado"
        Me.barbtnSellado.Id = 39
        Me.barbtnSellado.ImageOptions.Image = CType(resources.GetObject("barbtnSellado.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSellado.Name = "barbtnSellado"
        '
        'barbtnDuplicarEmpaque
        '
        Me.barbtnDuplicarEmpaque.Caption = "Empaque"
        Me.barbtnDuplicarEmpaque.Id = 9
        Me.barbtnDuplicarEmpaque.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarEmpaque.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarEmpaque.Name = "barbtnDuplicarEmpaque"
        '
        'barbtnDuplicarImprenta
        '
        Me.barbtnDuplicarImprenta.Caption = "Imprenta"
        Me.barbtnDuplicarImprenta.Id = 10
        Me.barbtnDuplicarImprenta.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarImprenta.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarImprenta.Name = "barbtnDuplicarImprenta"
        '
        'barbtnDuplicarOtros
        '
        Me.barbtnDuplicarOtros.Caption = "Otros"
        Me.barbtnDuplicarOtros.Id = 11
        Me.barbtnDuplicarOtros.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarOtros.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarOtros.Name = "barbtnDuplicarOtros"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Borrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea"
        Me.barbtnEliminar.Id = 12
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Id = 37
        Me.barbtnStock.ImageOptions.Image = CType(resources.GetObject("barbtnStock.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnStock.Name = "barbtnStock"
        '
        'barbtnDetalleOrden
        '
        Me.barbtnDetalleOrden.Caption = "Ordenes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Ensambles"
        Me.barbtnDetalleOrden.Id = 23
        Me.barbtnDetalleOrden.ImageOptions.Image = CType(resources.GetObject("barbtnDetalleOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDetalleOrden.Name = "barbtnDetalleOrden"
        '
        'barbtnDeudaRol
        '
        Me.barbtnDeudaRol.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        Me.barbtnDeudaRol.Id = 36
        Me.barbtnDeudaRol.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaRol.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaRol.Name = "barbtnDeudaRol"
        '
        'barbtnDeudaCampana
        '
        Me.barbtnDeudaCampana.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Campaña"
        Me.barbtnDeudaCampana.Id = 38
        Me.barbtnDeudaCampana.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaCampana.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaCampana.Name = "barbtnDeudaCampana"
        '
        'barbtnDeudaProyeccion
        '
        Me.barbtnDeudaProyeccion.Caption = "Deuda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proyección"
        Me.barbtnDeudaProyeccion.Id = 41
        Me.barbtnDeudaProyeccion.ImageOptions.Image = CType(resources.GetObject("barbtnDeudaProyeccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDeudaProyeccion.Name = "barbtnDeudaProyeccion"
        '
        'barbtnMostrar
        '
        Me.barbtnMostrar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnMostrar.Caption = "Mostrar"
        Me.barbtnMostrar.Id = 25
        Me.barbtnMostrar.ImageOptions.Image = CType(resources.GetObject("barbtnMostrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnMostrar.Name = "barbtnMostrar"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.BarEditItem1, "", False, True, True, 301, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEnsambleDeuda, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscarCodigo, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscarPadre, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscarCampana, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnParametrosDefault, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImpresionFormato, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAyuda, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Filtros"
        Me.BarEditItem1.Edit = Me.rccbeubicaciones
        Me.BarEditItem1.Id = 29
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'rccbeubicaciones
        '
        Me.rccbeubicaciones.AutoHeight = False
        Me.rccbeubicaciones.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rccbeubicaciones.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("0", "Produccion"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Ensamble"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "Imprenta"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "Peines"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("4", "Pradera")})
        Me.rccbeubicaciones.Name = "rccbeubicaciones"
        '
        'barbtnEnsambleDeuda
        '
        Me.barbtnEnsambleDeuda.Caption = "Deuda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ensamble"
        Me.barbtnEnsambleDeuda.Id = 15
        Me.barbtnEnsambleDeuda.ImageOptions.Image = CType(resources.GetObject("barbtnEnsambleDeuda.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEnsambleDeuda.Name = "barbtnEnsambleDeuda"
        '
        'barbtnBuscarCodigo
        '
        Me.barbtnBuscarCodigo.Caption = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo"
        Me.barbtnBuscarCodigo.Enabled = False
        Me.barbtnBuscarCodigo.Id = 1
        Me.barbtnBuscarCodigo.ImageOptions.Image = CType(resources.GetObject("barbtnBuscarCodigo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscarCodigo.Name = "barbtnBuscarCodigo"
        '
        'barbtnBuscarPadre
        '
        Me.barbtnBuscarPadre.Caption = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Padre"
        Me.barbtnBuscarPadre.Enabled = False
        Me.barbtnBuscarPadre.Id = 13
        Me.barbtnBuscarPadre.ImageOptions.Image = CType(resources.GetObject("barbtnBuscarPadre.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscarPadre.Name = "barbtnBuscarPadre"
        '
        'barbtnBuscarCampana
        '
        Me.barbtnBuscarCampana.Caption = "Analizar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Campañas"
        Me.barbtnBuscarCampana.Id = 2
        Me.barbtnBuscarCampana.ImageOptions.Image = CType(resources.GetObject("barbtnBuscarCampana.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscarCampana.Name = "barbtnBuscarCampana"
        '
        'barbtnParametrosDefault
        '
        Me.barbtnParametrosDefault.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnParametrosDefault.Caption = "Parametros " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Default"
        Me.barbtnParametrosDefault.Id = 40
        Me.barbtnParametrosDefault.ImageOptions.Image = CType(resources.GetObject("barbtnParametrosDefault.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnParametrosDefault.Name = "barbtnParametrosDefault"
        '
        'barbtnImpresionFormato
        '
        Me.barbtnImpresionFormato.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImpresionFormato.Caption = "Impresion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Formato"
        Me.barbtnImpresionFormato.Id = 24
        Me.barbtnImpresionFormato.ImageOptions.Image = CType(resources.GetObject("barbtnImpresionFormato.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImpresionFormato.Name = "barbtnImpresionFormato"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 16
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 18
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 17
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnAyuda
        '
        Me.barbtnAyuda.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAyuda.Caption = "Ayuda"
        Me.barbtnAyuda.Id = 20
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(2071, 59)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 777)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2071, 55)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 59)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 718)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2071, 59)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 718)
        '
        'BarToggleSwitchItem1
        '
        Me.BarToggleSwitchItem1.Caption = "Agrupar"
        Me.BarToggleSwitchItem1.Id = 3
        Me.BarToggleSwitchItem1.Name = "BarToggleSwitchItem1"
        '
        'barbtnAgrupar
        '
        Me.barbtnAgrupar.Caption = "Agrupar"
        Me.barbtnAgrupar.Id = 4
        Me.barbtnAgrupar.Name = "barbtnAgrupar"
        '
        'barbtnDuplicarLinea
        '
        Me.barbtnDuplicarLinea.Caption = "Duplicar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea"
        Me.barbtnDuplicarLinea.Id = 5
        Me.barbtnDuplicarLinea.ImageOptions.Image = CType(resources.GetObject("barbtnDuplicarLinea.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDuplicarLinea.Name = "barbtnDuplicarLinea"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 21
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem()})
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ensamble", Nothing, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("pradera", Nothing, -1)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemBreadCrumbEdit1
        '
        Me.RepositoryItemBreadCrumbEdit1.AutoHeight = False
        Me.RepositoryItemBreadCrumbEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemBreadCrumbEdit1.Name = "RepositoryItemBreadCrumbEdit1"
        '
        'Token1
        '
        Me.Token1.Name = "Token1"
        Me.Token1.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("Ensamble", "1"))
        Me.Token1.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("Pradera", "2"))
        Me.Token1.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("Produccion", "3"))
        Me.Token1.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("Value4", "Value4"))
        '
        'grdEnsambleCalculadora
        '
        Me.grdEnsambleCalculadora.DataMember = "dsdtEnsambleCalculadora"
        Me.grdEnsambleCalculadora.DataSource = Me.DsEnsambleCalculadora1
        Me.grdEnsambleCalculadora.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEnsambleCalculadora.Location = New System.Drawing.Point(16, 16)
        Me.grdEnsambleCalculadora.MainView = Me.grdviewEnsambleCalculadora
        Me.grdEnsambleCalculadora.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEnsambleCalculadora.MenuManager = Me.BarManager1
        Me.grdEnsambleCalculadora.Name = "grdEnsambleCalculadora"
        Me.grdEnsambleCalculadora.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rcalCalculadora})
        Me.grdEnsambleCalculadora.Size = New System.Drawing.Size(1623, 611)
        Me.grdEnsambleCalculadora.TabIndex = 4
        Me.grdEnsambleCalculadora.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambleCalculadora})
        '
        'DsEnsambleCalculadora1
        '
        Me.DsEnsambleCalculadora1.DataSetName = "dsEnsambleCalculadora"
        Me.DsEnsambleCalculadora1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewEnsambleCalculadora
        '
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.Options.UseFont = True
        Me.grdviewEnsambleCalculadora.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.Options.UseFont = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewEnsambleCalculadora.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsambleCalculadora.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsambleCalculadora.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewEnsambleCalculadora.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambleCalculadora.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambleCalculadora.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewEnsambleCalculadora.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambleCalculadora.ColumnPanelRowHeight = 70
        Me.grdviewEnsambleCalculadora.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUbicacion, Me.colGrupo, Me.colTipo, Me.colDeLinea, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colEnsambleDeuda, Me.colEquipoPersonas, Me.colEnsambleXPersona, Me.colHorasXPersona, Me.colEnsambleXHora, Me.colHoras, Me.colComentarios, Me.colStock, Me.colMinimo, Me.colComprometido, Me.colDisponible, Me.colProyectado})
        GridFormatRule1.Column = Me.colDisponible
        GridFormatRule1.ColumnApplyTo = Me.colDisponible
        GridFormatRule1.Name = "rolSinStock"
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less
        FormatConditionRuleValue1.Value1 = 0
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colEnsambleXHora
        GridFormatRule2.ColumnApplyTo = Me.colCodigoArticulo
        GridFormatRule2.Name = "rolCodigoSinParametros"
        FormatConditionRuleValue2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = 0
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.grdviewEnsambleCalculadora.FormatRules.Add(GridFormatRule1)
        Me.grdviewEnsambleCalculadora.FormatRules.Add(GridFormatRule2)
        Me.grdviewEnsambleCalculadora.GridControl = Me.grdEnsambleCalculadora
        Me.grdviewEnsambleCalculadora.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Horas", Me.colHoras, "")})
        Me.grdviewEnsambleCalculadora.Name = "grdviewEnsambleCalculadora"
        Me.grdviewEnsambleCalculadora.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambleCalculadora.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambleCalculadora.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambleCalculadora.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.grdviewEnsambleCalculadora.OptionsView.ShowFooter = True
        Me.grdviewEnsambleCalculadora.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambleCalculadora.PaintStyleName = "Web"
        '
        'colUbicacion
        '
        Me.colUbicacion.Caption = "Ubicación"
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        Me.colUbicacion.Visible = True
        Me.colUbicacion.VisibleIndex = 0
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.MaxWidth = 75
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 1
        Me.colGrupo.Width = 64
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.AllowEdit = False
        Me.colTipo.OptionsColumn.AllowFocus = False
        Me.colTipo.OptionsColumn.TabStop = False
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 68
        '
        'colDeLinea
        '
        Me.colDeLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeLinea.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeLinea.FieldName = "DeLinea"
        Me.colDeLinea.Name = "colDeLinea"
        Me.colDeLinea.OptionsColumn.AllowEdit = False
        Me.colDeLinea.OptionsColumn.TabStop = False
        Me.colDeLinea.Width = 50
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.TabStop = False
        Me.colNombreArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreArticulo", "{0} ""Trabajos en Cola""")})
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 4
        Me.colNombreArticulo.Width = 300
        '
        'colEnsambleDeuda
        '
        Me.colEnsambleDeuda.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colEnsambleDeuda.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEnsambleDeuda.AppearanceCell.Options.UseBackColor = True
        Me.colEnsambleDeuda.AppearanceCell.Options.UseFont = True
        Me.colEnsambleDeuda.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsambleDeuda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsambleDeuda.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnsambleDeuda.Caption = "Cantidad para Ensamble"
        Me.colEnsambleDeuda.FieldName = "EnsambleDeuda"
        Me.colEnsambleDeuda.Name = "colEnsambleDeuda"
        Me.colEnsambleDeuda.Visible = True
        Me.colEnsambleDeuda.VisibleIndex = 5
        Me.colEnsambleDeuda.Width = 90
        '
        'colEquipoPersonas
        '
        Me.colEquipoPersonas.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colEquipoPersonas.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEquipoPersonas.AppearanceCell.Options.UseBackColor = True
        Me.colEquipoPersonas.AppearanceCell.Options.UseFont = True
        Me.colEquipoPersonas.AppearanceHeader.Options.UseTextOptions = True
        Me.colEquipoPersonas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEquipoPersonas.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEquipoPersonas.Caption = "Cantidad de Personas [Equipo]"
        Me.colEquipoPersonas.FieldName = "EquipoPersonas"
        Me.colEquipoPersonas.Name = "colEquipoPersonas"
        Me.colEquipoPersonas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EquipoPersonas", "{0:n0}")})
        Me.colEquipoPersonas.Visible = True
        Me.colEquipoPersonas.VisibleIndex = 8
        Me.colEquipoPersonas.Width = 90
        '
        'colEnsambleXPersona
        '
        Me.colEnsambleXPersona.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colEnsambleXPersona.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEnsambleXPersona.AppearanceCell.Options.UseBackColor = True
        Me.colEnsambleXPersona.AppearanceCell.Options.UseFont = True
        Me.colEnsambleXPersona.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsambleXPersona.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsambleXPersona.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnsambleXPersona.Caption = "Ensambles por Hora [1Persona]"
        Me.colEnsambleXPersona.ColumnEdit = Me.rcalCalculadora
        Me.colEnsambleXPersona.FieldName = "EnsambleXPersona"
        Me.colEnsambleXPersona.Name = "colEnsambleXPersona"
        Me.colEnsambleXPersona.Visible = True
        Me.colEnsambleXPersona.VisibleIndex = 6
        Me.colEnsambleXPersona.Width = 90
        '
        'rcalCalculadora
        '
        Me.rcalCalculadora.AutoHeight = False
        Me.rcalCalculadora.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcalCalculadora.Name = "rcalCalculadora"
        '
        'colHorasXPersona
        '
        Me.colHorasXPersona.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colHorasXPersona.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colHorasXPersona.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colHorasXPersona.AppearanceCell.Options.UseBackColor = True
        Me.colHorasXPersona.AppearanceCell.Options.UseFont = True
        Me.colHorasXPersona.AppearanceCell.Options.UseForeColor = True
        Me.colHorasXPersona.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasXPersona.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasXPersona.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasXPersona.Caption = "Total de Horas [1Persona]"
        Me.colHorasXPersona.DisplayFormat.FormatString = "{0:n2}"
        Me.colHorasXPersona.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHorasXPersona.FieldName = "HorasXPersona"
        Me.colHorasXPersona.Name = "colHorasXPersona"
        Me.colHorasXPersona.OptionsColumn.AllowEdit = False
        Me.colHorasXPersona.OptionsColumn.TabStop = False
        Me.colHorasXPersona.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HorasXPersona", "{0:n2}")})
        Me.colHorasXPersona.UnboundExpression = "[EnsambleDeuda] / [EnsambleXPersona]"
        Me.colHorasXPersona.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colHorasXPersona.Visible = True
        Me.colHorasXPersona.VisibleIndex = 7
        Me.colHorasXPersona.Width = 90
        '
        'colHoras
        '
        Me.colHoras.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colHoras.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colHoras.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colHoras.AppearanceCell.Options.UseBackColor = True
        Me.colHoras.AppearanceCell.Options.UseFont = True
        Me.colHoras.AppearanceCell.Options.UseForeColor = True
        Me.colHoras.AppearanceHeader.Options.UseTextOptions = True
        Me.colHoras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoras.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHoras.Caption = "Total de Horas [Equipo]"
        Me.colHoras.DisplayFormat.FormatString = "{0:n2}"
        Me.colHoras.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHoras.FieldName = "HorasXEquipo"
        Me.colHoras.Name = "colHoras"
        Me.colHoras.OptionsColumn.AllowEdit = False
        Me.colHoras.OptionsColumn.TabStop = False
        Me.colHoras.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HorasXEquipo", "{0:n2}")})
        Me.colHoras.UnboundExpression = "Iif(ToDecimal([EnsambleDeuda] / [EnsambleXPersona] / [EquipoPersonas]) > '0', ToD" &
    "ecimal([EnsambleDeuda] / [EnsambleXPersona] / [EquipoPersonas]), '0')"
        Me.colHoras.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colHoras.Visible = True
        Me.colHoras.VisibleIndex = 10
        Me.colHoras.Width = 90
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 16
        Me.colComentarios.Width = 212
        '
        'colStock
        '
        Me.colStock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colStock.AppearanceCell.Options.UseBackColor = True
        Me.colStock.AppearanceCell.Options.UseTextOptions = True
        Me.colStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.Caption = "Stock"
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 12
        Me.colStock.Width = 67
        '
        'colComprometido
        '
        Me.colComprometido.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colComprometido.AppearanceCell.Options.UseBackColor = True
        Me.colComprometido.AppearanceCell.Options.UseTextOptions = True
        Me.colComprometido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComprometido.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido.Caption = "Comprometido"
        Me.colComprometido.FieldName = "Comprometido"
        Me.colComprometido.Name = "colComprometido"
        Me.colComprometido.Visible = True
        Me.colComprometido.VisibleIndex = 13
        Me.colComprometido.Width = 89
        '
        'colProyectado
        '
        Me.colProyectado.Caption = "Proyectado"
        Me.colProyectado.FieldName = "Proyectado"
        Me.colProyectado.Name = "colProyectado"
        Me.colProyectado.Visible = True
        Me.colProyectado.VisibleIndex = 14
        Me.colProyectado.Width = 89
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1655, 686)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdEnsambleCalculadora
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1629, 617)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.sbdcEnsambleCalculadora
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 617)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(1629, 43)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'lycSplit2
        '
        Me.lycSplit2.Controls.Add(Me.spinResultadoSueldoExtra_Dia)
        Me.lycSplit2.Controls.Add(Me.spinResultadoSueldoBase_Dia)
        Me.lycSplit2.Controls.Add(Me.spinTotalXCompleto)
        Me.lycSplit2.Controls.Add(Me.spinResultadoXPersona_Extras)
        Me.lycSplit2.Controls.Add(Me.spinResultadoXPersona_Base)
        Me.lycSplit2.Controls.Add(Me.btnCalcular)
        Me.lycSplit2.Controls.Add(Me.spinResultadoCantidadPersonas)
        Me.lycSplit2.Controls.Add(Me.spinXdiasTrabajo)
        Me.lycSplit2.Controls.Add(Me.spinResultado_DiasTrabajo)
        Me.lycSplit2.Controls.Add(Me.spinXPersonas)
        Me.lycSplit2.Controls.Add(Me.spinHorasDiarias)
        Me.lycSplit2.Controls.Add(Me.spinHorasPendientes)
        Me.lycSplit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycSplit2.Location = New System.Drawing.Point(0, 0)
        Me.lycSplit2.Margin = New System.Windows.Forms.Padding(4)
        Me.lycSplit2.Name = "lycSplit2"
        Me.lycSplit2.Root = Me.LayoutControlGroup3
        Me.lycSplit2.Size = New System.Drawing.Size(378, 686)
        Me.lycSplit2.TabIndex = 0
        Me.lycSplit2.Text = "LayoutControl1"
        '
        'spinResultadoSueldoExtra_Dia
        '
        Me.spinResultadoSueldoExtra_Dia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultadoSueldoExtra_Dia.Enabled = False
        Me.spinResultadoSueldoExtra_Dia.Location = New System.Drawing.Point(163, 219)
        Me.spinResultadoSueldoExtra_Dia.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultadoSueldoExtra_Dia.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoExtra_Dia.MenuManager = Me.BarManager1
        Me.spinResultadoSueldoExtra_Dia.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoExtra_Dia.Name = "spinResultadoSueldoExtra_Dia"
        Me.spinResultadoSueldoExtra_Dia.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinResultadoSueldoExtra_Dia.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinResultadoSueldoExtra_Dia.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultadoSueldoExtra_Dia.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinResultadoSueldoExtra_Dia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultadoSueldoExtra_Dia.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultadoSueldoExtra_Dia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoSueldoExtra_Dia.Properties.EditFormat.FormatString = "n2"
        Me.spinResultadoSueldoExtra_Dia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoSueldoExtra_Dia.Properties.Mask.EditMask = "n2"
        Me.spinResultadoSueldoExtra_Dia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinResultadoSueldoExtra_Dia.Size = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoExtra_Dia.StyleController = Me.lycSplit2
        Me.spinResultadoSueldoExtra_Dia.TabIndex = 15
        '
        'spinResultadoSueldoBase_Dia
        '
        Me.spinResultadoSueldoBase_Dia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultadoSueldoBase_Dia.Enabled = False
        Me.spinResultadoSueldoBase_Dia.Location = New System.Drawing.Point(163, 191)
        Me.spinResultadoSueldoBase_Dia.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultadoSueldoBase_Dia.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoBase_Dia.MenuManager = Me.BarManager1
        Me.spinResultadoSueldoBase_Dia.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoBase_Dia.Name = "spinResultadoSueldoBase_Dia"
        Me.spinResultadoSueldoBase_Dia.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinResultadoSueldoBase_Dia.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinResultadoSueldoBase_Dia.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultadoSueldoBase_Dia.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinResultadoSueldoBase_Dia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultadoSueldoBase_Dia.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultadoSueldoBase_Dia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoSueldoBase_Dia.Properties.EditFormat.FormatString = "n2"
        Me.spinResultadoSueldoBase_Dia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoSueldoBase_Dia.Properties.Mask.EditMask = "n2"
        Me.spinResultadoSueldoBase_Dia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinResultadoSueldoBase_Dia.Size = New System.Drawing.Size(153, 20)
        Me.spinResultadoSueldoBase_Dia.StyleController = Me.lycSplit2
        Me.spinResultadoSueldoBase_Dia.TabIndex = 14
        '
        'spinTotalXCompleto
        '
        Me.spinTotalXCompleto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinTotalXCompleto.Enabled = False
        Me.spinTotalXCompleto.Location = New System.Drawing.Point(163, 331)
        Me.spinTotalXCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.spinTotalXCompleto.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinTotalXCompleto.MenuManager = Me.BarManager1
        Me.spinTotalXCompleto.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinTotalXCompleto.Name = "spinTotalXCompleto"
        Me.spinTotalXCompleto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinTotalXCompleto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinTotalXCompleto.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinTotalXCompleto.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinTotalXCompleto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinTotalXCompleto.Properties.DisplayFormat.FormatString = "n2"
        Me.spinTotalXCompleto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinTotalXCompleto.Properties.EditFormat.FormatString = "n2"
        Me.spinTotalXCompleto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinTotalXCompleto.Properties.Mask.EditMask = "n2"
        Me.spinTotalXCompleto.Size = New System.Drawing.Size(153, 20)
        Me.spinTotalXCompleto.StyleController = Me.lycSplit2
        Me.spinTotalXCompleto.TabIndex = 13
        '
        'spinResultadoXPersona_Extras
        '
        Me.spinResultadoXPersona_Extras.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultadoXPersona_Extras.Enabled = False
        Me.spinResultadoXPersona_Extras.Location = New System.Drawing.Point(163, 303)
        Me.spinResultadoXPersona_Extras.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultadoXPersona_Extras.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Extras.MenuManager = Me.BarManager1
        Me.spinResultadoXPersona_Extras.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Extras.Name = "spinResultadoXPersona_Extras"
        Me.spinResultadoXPersona_Extras.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinResultadoXPersona_Extras.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinResultadoXPersona_Extras.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultadoXPersona_Extras.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinResultadoXPersona_Extras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultadoXPersona_Extras.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultadoXPersona_Extras.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoXPersona_Extras.Properties.EditFormat.FormatString = "n2"
        Me.spinResultadoXPersona_Extras.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoXPersona_Extras.Properties.Mask.EditMask = "n2"
        Me.spinResultadoXPersona_Extras.Size = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Extras.StyleController = Me.lycSplit2
        Me.spinResultadoXPersona_Extras.TabIndex = 12
        '
        'spinResultadoXPersona_Base
        '
        Me.spinResultadoXPersona_Base.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultadoXPersona_Base.Enabled = False
        Me.spinResultadoXPersona_Base.Location = New System.Drawing.Point(163, 275)
        Me.spinResultadoXPersona_Base.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultadoXPersona_Base.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Base.MenuManager = Me.BarManager1
        Me.spinResultadoXPersona_Base.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Base.Name = "spinResultadoXPersona_Base"
        Me.spinResultadoXPersona_Base.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinResultadoXPersona_Base.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinResultadoXPersona_Base.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultadoXPersona_Base.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinResultadoXPersona_Base.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultadoXPersona_Base.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultadoXPersona_Base.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoXPersona_Base.Properties.EditFormat.FormatString = "n2"
        Me.spinResultadoXPersona_Base.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoXPersona_Base.Properties.Mask.EditMask = "n2"
        Me.spinResultadoXPersona_Base.Size = New System.Drawing.Size(153, 20)
        Me.spinResultadoXPersona_Base.StyleController = Me.lycSplit2
        Me.spinResultadoXPersona_Base.TabIndex = 11
        '
        'btnCalcular
        '
        Me.btnCalcular.ImageOptions.Image = CType(resources.GetObject("btnCalcular.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCalcular.Location = New System.Drawing.Point(16, 374)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(346, 40)
        Me.btnCalcular.StyleController = Me.lycSplit2
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        '
        'spinResultadoCantidadPersonas
        '
        Me.spinResultadoCantidadPersonas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultadoCantidadPersonas.Enabled = False
        Me.spinResultadoCantidadPersonas.Location = New System.Drawing.Point(163, 633)
        Me.spinResultadoCantidadPersonas.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultadoCantidadPersonas.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoCantidadPersonas.MenuManager = Me.BarManager1
        Me.spinResultadoCantidadPersonas.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultadoCantidadPersonas.Name = "spinResultadoCantidadPersonas"
        Me.spinResultadoCantidadPersonas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinResultadoCantidadPersonas.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultadoCantidadPersonas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultadoCantidadPersonas.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultadoCantidadPersonas.Properties.EditFormat.FormatString = "n2"
        Me.spinResultadoCantidadPersonas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultadoCantidadPersonas.Properties.Mask.EditMask = "n2"
        Me.spinResultadoCantidadPersonas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinResultadoCantidadPersonas.Size = New System.Drawing.Size(153, 20)
        Me.spinResultadoCantidadPersonas.StyleController = Me.lycSplit2
        Me.spinResultadoCantidadPersonas.TabIndex = 9
        '
        'spinXdiasTrabajo
        '
        Me.spinXdiasTrabajo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinXdiasTrabajo.Location = New System.Drawing.Point(163, 605)
        Me.spinXdiasTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.spinXdiasTrabajo.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinXdiasTrabajo.MenuManager = Me.BarManager1
        Me.spinXdiasTrabajo.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinXdiasTrabajo.Name = "spinXdiasTrabajo"
        Me.spinXdiasTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinXdiasTrabajo.Properties.DisplayFormat.FormatString = "n0"
        Me.spinXdiasTrabajo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinXdiasTrabajo.Properties.EditFormat.FormatString = "n0"
        Me.spinXdiasTrabajo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinXdiasTrabajo.Properties.Mask.EditMask = "n0"
        Me.spinXdiasTrabajo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinXdiasTrabajo.Size = New System.Drawing.Size(153, 20)
        Me.spinXdiasTrabajo.StyleController = Me.lycSplit2
        Me.spinXdiasTrabajo.TabIndex = 8
        '
        'spinResultado_DiasTrabajo
        '
        Me.spinResultado_DiasTrabajo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinResultado_DiasTrabajo.Enabled = False
        Me.spinResultado_DiasTrabajo.Location = New System.Drawing.Point(163, 247)
        Me.spinResultado_DiasTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.spinResultado_DiasTrabajo.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinResultado_DiasTrabajo.MenuManager = Me.BarManager1
        Me.spinResultado_DiasTrabajo.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinResultado_DiasTrabajo.Name = "spinResultado_DiasTrabajo"
        Me.spinResultado_DiasTrabajo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spinResultado_DiasTrabajo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinResultado_DiasTrabajo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinResultado_DiasTrabajo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinResultado_DiasTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinResultado_DiasTrabajo.Properties.DisplayFormat.FormatString = "n2"
        Me.spinResultado_DiasTrabajo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultado_DiasTrabajo.Properties.EditFormat.FormatString = "n2"
        Me.spinResultado_DiasTrabajo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinResultado_DiasTrabajo.Properties.Mask.EditMask = "n2"
        Me.spinResultado_DiasTrabajo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinResultado_DiasTrabajo.Size = New System.Drawing.Size(153, 20)
        Me.spinResultado_DiasTrabajo.StyleController = Me.lycSplit2
        Me.spinResultado_DiasTrabajo.TabIndex = 7
        '
        'spinXPersonas
        '
        Me.spinXPersonas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinXPersonas.Location = New System.Drawing.Point(163, 110)
        Me.spinXPersonas.Margin = New System.Windows.Forms.Padding(4)
        Me.spinXPersonas.MaximumSize = New System.Drawing.Size(153, 20)
        Me.spinXPersonas.MenuManager = Me.BarManager1
        Me.spinXPersonas.MinimumSize = New System.Drawing.Size(153, 20)
        Me.spinXPersonas.Name = "spinXPersonas"
        Me.spinXPersonas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinXPersonas.Properties.DisplayFormat.FormatString = "n0"
        Me.spinXPersonas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinXPersonas.Properties.EditFormat.FormatString = "n0"
        Me.spinXPersonas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinXPersonas.Properties.Mask.EditMask = "n0"
        Me.spinXPersonas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinXPersonas.Size = New System.Drawing.Size(153, 20)
        Me.spinXPersonas.StyleController = Me.lycSplit2
        Me.spinXPersonas.TabIndex = 6
        '
        'spinHorasDiarias
        '
        Me.spinHorasDiarias.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinHorasDiarias.Location = New System.Drawing.Point(148, 44)
        Me.spinHorasDiarias.Margin = New System.Windows.Forms.Padding(4)
        Me.spinHorasDiarias.MaximumSize = New System.Drawing.Size(185, 20)
        Me.spinHorasDiarias.MenuManager = Me.BarManager1
        Me.spinHorasDiarias.MinimumSize = New System.Drawing.Size(185, 20)
        Me.spinHorasDiarias.Name = "spinHorasDiarias"
        Me.spinHorasDiarias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinHorasDiarias.Properties.DisplayFormat.FormatString = "n0"
        Me.spinHorasDiarias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasDiarias.Properties.EditFormat.FormatString = "n0"
        Me.spinHorasDiarias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasDiarias.Properties.Mask.EditMask = "n0"
        Me.spinHorasDiarias.Size = New System.Drawing.Size(185, 20)
        Me.spinHorasDiarias.StyleController = Me.lycSplit2
        Me.spinHorasDiarias.TabIndex = 5
        '
        'spinHorasPendientes
        '
        Me.spinHorasPendientes.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinHorasPendientes.Location = New System.Drawing.Point(148, 16)
        Me.spinHorasPendientes.Margin = New System.Windows.Forms.Padding(4)
        Me.spinHorasPendientes.MaximumSize = New System.Drawing.Size(185, 20)
        Me.spinHorasPendientes.MenuManager = Me.BarManager1
        Me.spinHorasPendientes.MinimumSize = New System.Drawing.Size(185, 20)
        Me.spinHorasPendientes.Name = "spinHorasPendientes"
        Me.spinHorasPendientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinHorasPendientes.Properties.DisplayFormat.FormatString = "n2"
        Me.spinHorasPendientes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasPendientes.Properties.EditFormat.FormatString = "n2"
        Me.spinHorasPendientes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasPendientes.Properties.Mask.EditMask = "n2"
        Me.spinHorasPendientes.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinHorasPendientes.Size = New System.Drawing.Size(185, 20)
        Me.spinHorasPendientes.StyleController = Me.lycSplit2
        Me.spinHorasPendientes.TabIndex = 4
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlGroup4, Me.LayoutControlGroup6, Me.LayoutControlGroup5, Me.LayoutControlItem9, Me.EmptySpaceItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(378, 686)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.spinHorasPendientes
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(352, 28)
        Me.LayoutControlItem3.Text = "Total de Horas"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spinHorasDiarias
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(352, 28)
        Me.LayoutControlItem4.Text = "Horas X Dia"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(352, 81)
        Me.LayoutControlGroup4.Text = "Calculo por Personas"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.spinXPersonas
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem5.Text = "Cantidad Personas"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(129, 17)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem6})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 137)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(352, 221)
        Me.LayoutControlGroup6.Text = "Referencia por Dia"
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.spinResultadoSueldoBase_Dia
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem14.Text = "Sueldo Base Dia"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.spinResultadoSueldoExtra_Dia
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem15.Text = "Horas Extras Dia"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.spinResultadoXPersona_Base
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem10.Text = "Sueldo Base"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem11.Control = Me.spinResultadoXPersona_Extras
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem11.Text = "Horas Extras"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.spinTotalXCompleto
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 140)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem12.Text = "Total Sueldos"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.spinResultado_DiasTrabajo
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem6.Text = "Dias Trabajo"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(129, 17)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 551)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(352, 109)
        Me.LayoutControlGroup5.Text = "Cálculo por Dias"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.spinXdiasTrabajo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem7.Text = "Dias a trabajar"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.spinResultadoCantidadPersonas
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(322, 28)
        Me.LayoutControlItem8.Text = "Cantidad personas"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(129, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnCalcular
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 358)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(352, 46)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 404)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(352, 147)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(2071, 718)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sccEnsambleCalculadora
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(2045, 692)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btsAgrupar, Me.btsMultiSeleccion, Me.btsExpandir})
        Me.BarManager2.MaxItemId = 3
        '
        'bar2
        '
        Me.bar2.BarName = "Tools"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btsAgrupar), New DevExpress.XtraBars.LinkPersistInfo(Me.btsMultiSeleccion), New DevExpress.XtraBars.LinkPersistInfo(Me.btsExpandir)})
        Me.bar2.OptionsBar.AllowQuickCustomization = False
        Me.bar2.OptionsBar.DisableClose = True
        Me.bar2.OptionsBar.DisableCustomization = True
        Me.bar2.OptionsBar.DrawBorder = False
        Me.bar2.StandaloneBarDockControl = Me.sbdcEnsambleCalculadora
        Me.bar2.Text = "Tools"
        '
        'btsAgrupar
        '
        Me.btsAgrupar.Caption = "Agrupar"
        Me.btsAgrupar.Id = 0
        Me.btsAgrupar.Name = "btsAgrupar"
        '
        'btsMultiSeleccion
        '
        Me.btsMultiSeleccion.Caption = "Multi-Selección"
        Me.btsMultiSeleccion.Id = 1
        Me.btsMultiSeleccion.Name = "btsMultiSeleccion"
        '
        'btsExpandir
        '
        Me.btsExpandir.Caption = "Expandir"
        Me.btsExpandir.Id = 2
        Me.btsExpandir.Name = "btsExpandir"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl1.Size = New System.Drawing.Size(2071, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 832)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl2.Size = New System.Drawing.Size(2071, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 832)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(2071, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 832)
        '
        'colMinimo
        '
        Me.colMinimo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colMinimo.AppearanceCell.Options.UseBackColor = True
        Me.colMinimo.AppearanceCell.Options.UseTextOptions = True
        Me.colMinimo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMinimo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMinimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinimo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMinimo.Caption = "Minimo"
        Me.colMinimo.FieldName = "Minimo"
        Me.colMinimo.Name = "colMinimo"
        Me.colMinimo.Visible = True
        Me.colMinimo.VisibleIndex = 11
        Me.colMinimo.Width = 70
        '
        'frmEnsambleCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2071, 832)
        Me.Controls.Add(Me.lycEnsambleCalculadora)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEnsambleCalculadora"
        Me.Text = "frmEnsambleCalculadora"
        CType(Me.lycEnsambleCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycEnsambleCalculadora.ResumeLayout(False)
        CType(Me.sccEnsambleCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sccEnsambleCalculadora.ResumeLayout(False)
        CType(Me.lycSplit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rccbeubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemBreadCrumbEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Token1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnsambleCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEnsambleCalculadora1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambleCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcalCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycSplit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycSplit2.ResumeLayout(False)
        CType(Me.spinResultadoSueldoExtra_Dia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinResultadoSueldoBase_Dia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinTotalXCompleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinResultadoXPersona_Extras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinResultadoXPersona_Base.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinResultadoCantidadPersonas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinXdiasTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinResultado_DiasTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinXPersonas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinHorasDiarias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinHorasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycEnsambleCalculadora As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barEnsambleCalculadora As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdEnsambleCalculadora As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsambleCalculadora As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsEnsambleCalculadora1 As waProduccion_Pedidos.dsEnsambleCalculadora
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnsambleDeuda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnsambleXHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEquipoPersonas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnBuscarCodigo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscarCampana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEnsambleXPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasXPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnAgrupar As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents BarToggleSwitchItem1 As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents barbtnDuplicarLinea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnsDuplicar As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barbtnDuplicarEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDuplicarBotadero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDuplicarEmpaque As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDuplicarImprenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDuplicarOtros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rcalCalculadora As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscarPadre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEnsambleDeuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnAyuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnDetalleOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisponible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnImpresionFormato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sccEnsambleCalculadora As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycSplit1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycSplit2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents spinResultadoCantidadPersonas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinXdiasTrabajo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinResultado_DiasTrabajo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinXPersonas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinHorasDiarias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinHorasPendientes As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnMostrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rccbeubicaciones As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemBreadCrumbEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Token1 As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
    Friend WithEvents spinResultadoXPersona_Extras As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinResultadoXPersona_Base As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinTotalXCompleto As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnDeudaRol As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sbdcEnsambleCalculadora As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btsAgrupar As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btsMultiSeleccion As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btsExpandir As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents spinResultadoSueldoExtra_Dia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinResultadoSueldoBase_Dia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnDeudaCampana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnSellado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnParametrosDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colProyectado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnDeudaProyeccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colMinimo As DevExpress.XtraGrid.Columns.GridColumn
End Class
