<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetasSolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetasSolicitud))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colEstadoEtiqueta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycEtiquetas = New DevExpress.XtraLayout.LayoutControl()
        Me.grdCodigosHijos = New DevExpress.XtraGrid.GridControl()
        Me.DsEtiquetasSolicitud1 = New waProduccion_Pedidos.dsEtiquetasSolicitud()
        Me.grdviewCodigosHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnSolicitarEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.lblSolicitado = New DevExpress.XtraBars.BarStaticItem()
        Me.lblImprimiendo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblCompletado = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.grdEtiquetas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEtiquetas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreIngles = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreación = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.lycEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycEtiquetas.SuspendLayout()
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtiquetasSolicitud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstadoEtiqueta
        '
        Me.colEstadoEtiqueta.FieldName = "EstadoEtiqueta"
        Me.colEstadoEtiqueta.Name = "colEstadoEtiqueta"
        Me.colEstadoEtiqueta.Visible = True
        Me.colEstadoEtiqueta.VisibleIndex = 14
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 1
        Me.colNumSAP.Width = 60
        '
        'lycEtiquetas
        '
        Me.lycEtiquetas.Controls.Add(Me.grdCodigosHijos)
        Me.lycEtiquetas.Controls.Add(Me.grdEtiquetas)
        Me.lycEtiquetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycEtiquetas.Location = New System.Drawing.Point(0, 0)
        Me.lycEtiquetas.Name = "lycEtiquetas"
        Me.lycEtiquetas.Root = Me.LayoutControlGroup1
        Me.lycEtiquetas.Size = New System.Drawing.Size(1084, 548)
        Me.lycEtiquetas.TabIndex = 0
        Me.lycEtiquetas.Text = "LayoutControl1"
        '
        'grdCodigosHijos
        '
        Me.grdCodigosHijos.DataMember = "dsdtCodigoHijos"
        Me.grdCodigosHijos.DataSource = Me.DsEtiquetasSolicitud1
        Me.grdCodigosHijos.Location = New System.Drawing.Point(12, 12)
        Me.grdCodigosHijos.MainView = Me.grdviewCodigosHijos
        Me.grdCodigosHijos.MenuManager = Me.BarManager1
        Me.grdCodigosHijos.Name = "grdCodigosHijos"
        Me.grdCodigosHijos.Size = New System.Drawing.Size(140, 524)
        Me.grdCodigosHijos.TabIndex = 5
        Me.grdCodigosHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigosHijos})
        '
        'DsEtiquetasSolicitud1
        '
        Me.DsEtiquetasSolicitud1.DataSetName = "dsEtiquetasSolicitud"
        Me.DsEtiquetasSolicitud1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewCodigosHijos
        '
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewCodigosHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewCodigosHijos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewCodigosHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewCodigosHijos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewCodigosHijos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewCodigosHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewCodigosHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCodigosHijos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewCodigosHijos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewCodigosHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewCodigosHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewCodigosHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewCodigosHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewCodigosHijos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewCodigosHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewCodigosHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewCodigosHijos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewCodigosHijos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewCodigosHijos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewCodigosHijos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewCodigosHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewCodigosHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewCodigosHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCodigosHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo1})
        Me.grdviewCodigosHijos.GridControl = Me.grdCodigosHijos
        Me.grdviewCodigosHijos.Name = "grdviewCodigosHijos"
        Me.grdviewCodigosHijos.OptionsBehavior.Editable = False
        Me.grdviewCodigosHijos.OptionsBehavior.ReadOnly = True
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCodigosHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCodigosHijos.OptionsView.ShowFooter = True
        Me.grdviewCodigosHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigosHijos.PaintStyleName = "Web"
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnSolicitarEtiquetas, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarHeaderItem1, Me.lblSolicitado, Me.lblImprimiendo, Me.lblCompletado})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSolicitarEtiquetas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar), New DevExpress.XtraBars.LinkPersistInfo(Me.lblSolicitado, True), New DevExpress.XtraBars.LinkPersistInfo(Me.lblImprimiendo, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.lblCompletado, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnSolicitarEtiquetas
        '
        Me.barbtnSolicitarEtiquetas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnSolicitarEtiquetas.Caption = "Solicitar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Etiquetas"
        Me.barbtnSolicitarEtiquetas.Id = 1
        Me.barbtnSolicitarEtiquetas.ImageOptions.Image = CType(resources.GetObject("barbtnSolicitarEtiquetas.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSolicitarEtiquetas.Name = "barbtnSolicitarEtiquetas"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'lblSolicitado
        '
        Me.lblSolicitado.Caption = "Solicitado"
        Me.lblSolicitado.Id = 5
        Me.lblSolicitado.ItemAppearance.Normal.BackColor = System.Drawing.Color.Yellow
        Me.lblSolicitado.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSolicitado.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.lblSolicitado.ItemAppearance.Normal.Options.UseBackColor = True
        Me.lblSolicitado.ItemAppearance.Normal.Options.UseFont = True
        Me.lblSolicitado.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblSolicitado.Name = "lblSolicitado"
        '
        'lblImprimiendo
        '
        Me.lblImprimiendo.Caption = "Imprimiendo"
        Me.lblImprimiendo.Id = 6
        Me.lblImprimiendo.ItemAppearance.Normal.BackColor = System.Drawing.Color.Orange
        Me.lblImprimiendo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblImprimiendo.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.lblImprimiendo.ItemAppearance.Normal.Options.UseBackColor = True
        Me.lblImprimiendo.ItemAppearance.Normal.Options.UseFont = True
        Me.lblImprimiendo.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblImprimiendo.Name = "lblImprimiendo"
        '
        'lblCompletado
        '
        Me.lblCompletado.Caption = "Completado"
        Me.lblCompletado.Id = 7
        Me.lblCompletado.ItemAppearance.Normal.BackColor = System.Drawing.Color.GreenYellow
        Me.lblCompletado.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCompletado.ItemAppearance.Normal.Options.UseBackColor = True
        Me.lblCompletado.ItemAppearance.Normal.Options.UseFont = True
        Me.lblCompletado.Name = "lblCompletado"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1084, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 548)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1084, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1084, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Appearance.BackColor = System.Drawing.Color.GreenYellow
        Me.BarHeaderItem1.Appearance.Options.UseBackColor = True
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 4
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'grdEtiquetas
        '
        Me.grdEtiquetas.DataMember = "dsdtEtiquetas"
        Me.grdEtiquetas.DataSource = Me.DsEtiquetasSolicitud1
        Me.grdEtiquetas.Location = New System.Drawing.Point(156, 12)
        Me.grdEtiquetas.MainView = Me.grdviewEtiquetas
        Me.grdEtiquetas.MenuManager = Me.BarManager1
        Me.grdEtiquetas.Name = "grdEtiquetas"
        Me.grdEtiquetas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen})
        Me.grdEtiquetas.Size = New System.Drawing.Size(916, 524)
        Me.grdEtiquetas.TabIndex = 4
        Me.grdEtiquetas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEtiquetas})
        '
        'grdviewEtiquetas
        '
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEtiquetas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEtiquetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.Preview.Options.UseFont = True
        Me.grdviewEtiquetas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEtiquetas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEtiquetas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEtiquetas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEtiquetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEtiquetas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEtiquetas.ColumnPanelRowHeight = 35
        Me.grdviewEtiquetas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colOrigen, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colNombreIngles, Me.colCodigoBarras, Me.colColor, Me.colUnidadVenta, Me.colUnidadMedida, Me.colPlaneado, Me.colCreación, Me.colVencimiento, Me.colEstadoEtiqueta})
        GridFormatRule1.Column = Me.colEstadoEtiqueta
        GridFormatRule1.ColumnApplyTo = Me.colNumSAP
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Yellow
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "S"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colEstadoEtiqueta
        GridFormatRule2.ColumnApplyTo = Me.colNumSAP
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "P"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colEstadoEtiqueta
        GridFormatRule3.ColumnApplyTo = Me.colNumSAP
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.GreenYellow
        FormatConditionRuleValue3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Appearance.Options.UseFont = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = "C"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.grdviewEtiquetas.FormatRules.Add(GridFormatRule1)
        Me.grdviewEtiquetas.FormatRules.Add(GridFormatRule2)
        Me.grdviewEtiquetas.FormatRules.Add(GridFormatRule3)
        Me.grdviewEtiquetas.GridControl = Me.grdEtiquetas
        Me.grdviewEtiquetas.Name = "grdviewEtiquetas"
        Me.grdviewEtiquetas.OptionsSelection.MultiSelect = True
        Me.grdviewEtiquetas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewEtiquetas.OptionsView.ColumnAutoWidth = False
        Me.grdviewEtiquetas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEtiquetas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEtiquetas.OptionsView.ShowFooter = True
        Me.grdviewEtiquetas.OptionsView.ShowGroupPanel = False
        Me.grdviewEtiquetas.PaintStyleName = "Flat"
        Me.grdviewEtiquetas.RowHeight = 25
        Me.grdviewEtiquetas.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNumSAP, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 2
        Me.colEstado.Width = 80
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 3
        Me.colTipo.Width = 80
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.ColumnEdit = Me.rslueOrigen
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 4
        Me.colOrigen.Width = 80
        '
        'rslueOrigen
        '
        Me.rslueOrigen.AutoHeight = False
        Me.rslueOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen.Name = "rslueOrigen"
        Me.rslueOrigen.NullText = ""
        Me.rslueOrigen.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceCell.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 6
        Me.colCodigoArticulo.Width = 125
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 7
        Me.colNombreArticulo.Width = 250
        '
        'colNombreIngles
        '
        Me.colNombreIngles.FieldName = "NombreIngles"
        Me.colNombreIngles.Name = "colNombreIngles"
        Me.colNombreIngles.Visible = True
        Me.colNombreIngles.VisibleIndex = 10
        '
        'colCodigoBarras
        '
        Me.colCodigoBarras.FieldName = "CodigoBarras"
        Me.colCodigoBarras.Name = "colCodigoBarras"
        Me.colCodigoBarras.Visible = True
        Me.colCodigoBarras.VisibleIndex = 9
        Me.colCodigoBarras.Width = 125
        '
        'colColor
        '
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 8
        '
        'colUnidadVenta
        '
        Me.colUnidadVenta.FieldName = "UnidadVenta"
        Me.colUnidadVenta.Name = "colUnidadVenta"
        Me.colUnidadVenta.Visible = True
        Me.colUnidadVenta.VisibleIndex = 11
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.FieldName = "UnidadMedida"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.Visible = True
        Me.colUnidadMedida.VisibleIndex = 12
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceCell.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 5
        '
        'colCreación
        '
        Me.colCreación.FieldName = "Creación"
        Me.colCreación.Name = "colCreación"
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 13
        '
        'colVencimiento
        '
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 15
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1084, 548)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdEtiquetas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(144, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(920, 528)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdCodigosHijos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(144, 528)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'frmEtiquetasSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycEtiquetas)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEtiquetasSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Etiquetas para Ensamble"
        CType(Me.lycEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycEtiquetas.ResumeLayout(False)
        CType(Me.grdCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtiquetasSolicitud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigosHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycEtiquetas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdEtiquetas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEtiquetas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsEtiquetasSolicitud1 As waProduccion_Pedidos.dsEtiquetasSolicitud
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreIngles As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnSolicitarEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdCodigosHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigosHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents rslueOrigen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEstadoEtiqueta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblSolicitado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblImprimiendo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblCompletado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
End Class
