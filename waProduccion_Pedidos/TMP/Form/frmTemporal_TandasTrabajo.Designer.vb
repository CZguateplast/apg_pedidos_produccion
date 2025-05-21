<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_TandasTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_TandasTrabajo))
        Me.lycTemporal = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcTandas = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregarTanda = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grdTandas = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_TandasTrabajo1 = New waProduccion_Pedidos.dsTemporal_TandasTrabajo()
        Me.grdviewTandas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesBuenas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesMalas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasProducidas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReporteMalas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReporteTiempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoReporteTiempoPerdido = New DevExpress.XtraEditors.MemoEdit()
        Me.memoReporteUnidadesMalas = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMaquina = New DevExpress.XtraEditors.TextEdit()
        Me.timeTiempoTotal = New DevExpress.XtraEditors.TimeEdit()
        Me.timeHoraFinal = New DevExpress.XtraEditors.TimeEdit()
        Me.timeHoraInicio = New DevExpress.XtraEditors.TimeEdit()
        Me.spinUTotal = New DevExpress.XtraEditors.SpinEdit()
        Me.spinUMalas = New DevExpress.XtraEditors.SpinEdit()
        Me.spinUBuenas = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycTemporal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTandas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_TandasTrabajo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTandas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoReporteTiempoPerdido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoReporteUnidadesMalas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeTiempoTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeHoraFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeHoraInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinUTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinUMalas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinUBuenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal
        '
        Me.lycTemporal.Controls.Add(Me.sbdcTandas)
        Me.lycTemporal.Controls.Add(Me.grdTandas)
        Me.lycTemporal.Controls.Add(Me.memoReporteTiempoPerdido)
        Me.lycTemporal.Controls.Add(Me.memoReporteUnidadesMalas)
        Me.lycTemporal.Controls.Add(Me.txtMaquina)
        Me.lycTemporal.Controls.Add(Me.timeTiempoTotal)
        Me.lycTemporal.Controls.Add(Me.timeHoraFinal)
        Me.lycTemporal.Controls.Add(Me.timeHoraInicio)
        Me.lycTemporal.Controls.Add(Me.spinUTotal)
        Me.lycTemporal.Controls.Add(Me.spinUMalas)
        Me.lycTemporal.Controls.Add(Me.spinUBuenas)
        Me.lycTemporal.Controls.Add(Me.txtNombre)
        Me.lycTemporal.Controls.Add(Me.txtCodigo)
        Me.lycTemporal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal.Name = "lycTemporal"
        Me.lycTemporal.Root = Me.LayoutControlGroup1
        Me.lycTemporal.Size = New System.Drawing.Size(862, 455)
        Me.lycTemporal.TabIndex = 0
        Me.lycTemporal.Text = "LayoutControl1"
        '
        'sbdcTandas
        '
        Me.sbdcTandas.CausesValidation = False
        Me.sbdcTandas.Location = New System.Drawing.Point(528, 166)
        Me.sbdcTandas.Manager = Me.BarManager1
        Me.sbdcTandas.Name = "sbdcTandas"
        Me.sbdcTandas.Size = New System.Drawing.Size(115, 47)
        Me.sbdcTandas.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcTandas)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnGrabar, Me.barbtnAgregarTanda})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAgregarTanda, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcTandas
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregarTanda
        '
        Me.barbtnAgregarTanda.Caption = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajo"
        Me.barbtnAgregarTanda.Id = 2
        Me.barbtnAgregarTanda.ImageOptions.Image = CType(resources.GetObject("barbtnAgregarTanda.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregarTanda.Name = "barbtnAgregarTanda"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGrabar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnGrabar
        '
        Me.barbtnGrabar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnGrabar.Caption = "Grabar"
        Me.barbtnGrabar.Id = 1
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(862, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 455)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(862, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 455)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(862, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 455)
        '
        'grdTandas
        '
        Me.grdTandas.DataMember = "dsdtTrabajos"
        Me.grdTandas.DataSource = Me.DsTemporal_TandasTrabajo1
        Me.grdTandas.Location = New System.Drawing.Point(12, 229)
        Me.grdTandas.MainView = Me.grdviewTandas
        Me.grdTandas.MenuManager = Me.BarManager1
        Me.grdTandas.Name = "grdTandas"
        Me.grdTandas.Size = New System.Drawing.Size(838, 214)
        Me.grdTandas.TabIndex = 15
        Me.grdTandas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTandas})
        '
        'DsTemporal_TandasTrabajo1
        '
        Me.DsTemporal_TandasTrabajo1.DataSetName = "dsTemporal_TandasTrabajo"
        Me.DsTemporal_TandasTrabajo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTandas
        '
        Me.grdviewTandas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewTandas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewTandas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewTandas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewTandas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewTandas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewTandas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTandas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTandas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewTandas.Appearance.Preview.Options.UseFont = True
        Me.grdviewTandas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTandas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewTandas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewTandas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTandas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTandas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTandas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewTandas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTandas.ColumnPanelRowHeight = 35
        Me.grdviewTandas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colTotalUnidades, Me.colUnidadesBuenas, Me.colUnidadesMalas, Me.colHorasProducidas, Me.colHoraInicio, Me.colHoraFinal, Me.colReporteMalas, Me.colReporteTiempo})
        Me.grdviewTandas.GridControl = Me.grdTandas
        Me.grdviewTandas.Name = "grdviewTandas"
        Me.grdviewTandas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTandas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTandas.PaintStyleName = "Web"
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
        '
        'colTotalUnidades
        '
        Me.colTotalUnidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalUnidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalUnidades.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalUnidades.FieldName = "TotalUnidades"
        Me.colTotalUnidades.Name = "colTotalUnidades"
        Me.colTotalUnidades.Visible = True
        Me.colTotalUnidades.VisibleIndex = 1
        '
        'colUnidadesBuenas
        '
        Me.colUnidadesBuenas.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesBuenas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesBuenas.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnidadesBuenas.FieldName = "UnidadesBuenas"
        Me.colUnidadesBuenas.Name = "colUnidadesBuenas"
        Me.colUnidadesBuenas.Visible = True
        Me.colUnidadesBuenas.VisibleIndex = 2
        '
        'colUnidadesMalas
        '
        Me.colUnidadesMalas.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesMalas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesMalas.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnidadesMalas.FieldName = "UnidadesMalas"
        Me.colUnidadesMalas.Name = "colUnidadesMalas"
        Me.colUnidadesMalas.Visible = True
        Me.colUnidadesMalas.VisibleIndex = 3
        '
        'colHorasProducidas
        '
        Me.colHorasProducidas.AppearanceCell.Options.UseTextOptions = True
        Me.colHorasProducidas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasProducidas.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasProducidas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasProducidas.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasProducidas.FieldName = "HorasProducidas"
        Me.colHorasProducidas.Name = "colHorasProducidas"
        Me.colHorasProducidas.Visible = True
        Me.colHorasProducidas.VisibleIndex = 4
        '
        'colHoraInicio
        '
        Me.colHoraInicio.AppearanceCell.Options.UseTextOptions = True
        Me.colHoraInicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraInicio.AppearanceHeader.Options.UseTextOptions = True
        Me.colHoraInicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraInicio.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHoraInicio.FieldName = "HoraInicio"
        Me.colHoraInicio.Name = "colHoraInicio"
        Me.colHoraInicio.Visible = True
        Me.colHoraInicio.VisibleIndex = 5
        '
        'colHoraFinal
        '
        Me.colHoraFinal.AppearanceCell.Options.UseTextOptions = True
        Me.colHoraFinal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colHoraFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraFinal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHoraFinal.FieldName = "HoraFinal"
        Me.colHoraFinal.Name = "colHoraFinal"
        Me.colHoraFinal.Visible = True
        Me.colHoraFinal.VisibleIndex = 6
        '
        'colReporteMalas
        '
        Me.colReporteMalas.AppearanceHeader.Options.UseTextOptions = True
        Me.colReporteMalas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReporteMalas.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReporteMalas.FieldName = "ReporteMalas"
        Me.colReporteMalas.Name = "colReporteMalas"
        Me.colReporteMalas.Visible = True
        Me.colReporteMalas.VisibleIndex = 7
        '
        'colReporteTiempo
        '
        Me.colReporteTiempo.AppearanceHeader.Options.UseTextOptions = True
        Me.colReporteTiempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReporteTiempo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReporteTiempo.FieldName = "ReporteTiempo"
        Me.colReporteTiempo.Name = "colReporteTiempo"
        Me.colReporteTiempo.Visible = True
        Me.colReporteTiempo.VisibleIndex = 8
        '
        'memoReporteTiempoPerdido
        '
        Me.memoReporteTiempoPerdido.Location = New System.Drawing.Point(286, 130)
        Me.memoReporteTiempoPerdido.MenuManager = Me.BarManager1
        Me.memoReporteTiempoPerdido.Name = "memoReporteTiempoPerdido"
        Me.memoReporteTiempoPerdido.Size = New System.Drawing.Size(214, 83)
        Me.memoReporteTiempoPerdido.StyleController = Me.lycTemporal
        Me.memoReporteTiempoPerdido.TabIndex = 14
        '
        'memoReporteUnidadesMalas
        '
        Me.memoReporteUnidadesMalas.Location = New System.Drawing.Point(24, 130)
        Me.memoReporteUnidadesMalas.MenuManager = Me.BarManager1
        Me.memoReporteUnidadesMalas.Name = "memoReporteUnidadesMalas"
        Me.memoReporteUnidadesMalas.Size = New System.Drawing.Size(234, 83)
        Me.memoReporteUnidadesMalas.StyleController = Me.lycTemporal
        Me.memoReporteUnidadesMalas.TabIndex = 13
        '
        'txtMaquina
        '
        Me.txtMaquina.Location = New System.Drawing.Point(664, 58)
        Me.txtMaquina.MenuManager = Me.BarManager1
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaquina.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaquina.Size = New System.Drawing.Size(174, 20)
        Me.txtMaquina.StyleController = Me.lycTemporal
        Me.txtMaquina.TabIndex = 12
        '
        'timeTiempoTotal
        '
        Me.timeTiempoTotal.EditValue = New Date(2019, 9, 10, 0, 0, 0, 0)
        Me.timeTiempoTotal.Location = New System.Drawing.Point(420, 90)
        Me.timeTiempoTotal.MenuManager = Me.BarManager1
        Me.timeTiempoTotal.Name = "timeTiempoTotal"
        Me.timeTiempoTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.timeTiempoTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.timeTiempoTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeTiempoTotal.Size = New System.Drawing.Size(80, 20)
        Me.timeTiempoTotal.StyleController = Me.lycTemporal
        Me.timeTiempoTotal.TabIndex = 11
        '
        'timeHoraFinal
        '
        Me.timeHoraFinal.EditValue = New Date(2019, 9, 10, 0, 0, 0, 0)
        Me.timeHoraFinal.Location = New System.Drawing.Point(420, 66)
        Me.timeHoraFinal.MenuManager = Me.BarManager1
        Me.timeHoraFinal.Name = "timeHoraFinal"
        Me.timeHoraFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.timeHoraFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.timeHoraFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeHoraFinal.Size = New System.Drawing.Size(80, 20)
        Me.timeHoraFinal.StyleController = Me.lycTemporal
        Me.timeHoraFinal.TabIndex = 10
        '
        'timeHoraInicio
        '
        Me.timeHoraInicio.EditValue = New Date(2019, 9, 10, 0, 0, 0, 0)
        Me.timeHoraInicio.Location = New System.Drawing.Point(420, 42)
        Me.timeHoraInicio.MaximumSize = New System.Drawing.Size(80, 0)
        Me.timeHoraInicio.MenuManager = Me.BarManager1
        Me.timeHoraInicio.MinimumSize = New System.Drawing.Size(80, 0)
        Me.timeHoraInicio.Name = "timeHoraInicio"
        Me.timeHoraInicio.Properties.Appearance.Options.UseTextOptions = True
        Me.timeHoraInicio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.timeHoraInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeHoraInicio.Size = New System.Drawing.Size(80, 20)
        Me.timeHoraInicio.StyleController = Me.lycTemporal
        Me.timeHoraInicio.TabIndex = 9
        '
        'spinUTotal
        '
        Me.spinUTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinUTotal.Location = New System.Drawing.Point(158, 90)
        Me.spinUTotal.MenuManager = Me.BarManager1
        Me.spinUTotal.Name = "spinUTotal"
        Me.spinUTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinUTotal.Properties.DisplayFormat.FormatString = "n0"
        Me.spinUTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinUTotal.Size = New System.Drawing.Size(100, 20)
        Me.spinUTotal.StyleController = Me.lycTemporal
        Me.spinUTotal.TabIndex = 8
        '
        'spinUMalas
        '
        Me.spinUMalas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinUMalas.Location = New System.Drawing.Point(158, 66)
        Me.spinUMalas.MenuManager = Me.BarManager1
        Me.spinUMalas.Name = "spinUMalas"
        Me.spinUMalas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinUMalas.Properties.DisplayFormat.FormatString = "n0"
        Me.spinUMalas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinUMalas.Size = New System.Drawing.Size(100, 20)
        Me.spinUMalas.StyleController = Me.lycTemporal
        Me.spinUMalas.TabIndex = 7
        '
        'spinUBuenas
        '
        Me.spinUBuenas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinUBuenas.Location = New System.Drawing.Point(158, 42)
        Me.spinUBuenas.MaximumSize = New System.Drawing.Size(100, 0)
        Me.spinUBuenas.MenuManager = Me.BarManager1
        Me.spinUBuenas.MinimumSize = New System.Drawing.Size(100, 0)
        Me.spinUBuenas.Name = "spinUBuenas"
        Me.spinUBuenas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinUBuenas.Properties.DisplayFormat.FormatString = "n0"
        Me.spinUBuenas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinUBuenas.Size = New System.Drawing.Size(100, 20)
        Me.spinUBuenas.StyleController = Me.lycTemporal
        Me.spinUBuenas.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(528, 98)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(310, 20)
        Me.txtNombre.StyleController = Me.lycTemporal
        Me.txtNombre.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(528, 58)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigo.Size = New System.Drawing.Size(132, 20)
        Me.txtCodigo.StyleController = Me.lycTemporal
        Me.txtCodigo.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem12, Me.LayoutControlGroup4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(862, 455)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(262, 217)
        Me.LayoutControlGroup2.Text = "UNIDADES"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.spinUTotal
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem5.Text = "Total Unidades"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.spinUMalas
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem4.Text = "Unidades Malas"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.spinUBuenas
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem3.Text = "Unidades Buenas"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem10.Control = Me.memoReporteUnidadesMalas
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(238, 103)
        Me.LayoutControlItem10.Text = "Reporte de Unidades Malas"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(262, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(242, 217)
        Me.LayoutControlGroup3.Text = "TIEMPO"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.timeHoraInicio
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem6.Text = "Hora Inicio"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.timeHoraFinal
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem7.Text = "Hora Final"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.timeTiempoTotal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem8.Text = "Total Tiempo"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem11.Control = Me.memoReporteTiempoPerdido
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(218, 103)
        Me.LayoutControlItem11.Text = "Reporte Tiempo Perdido"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.grdTandas
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(842, 218)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem13})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(504, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(338, 217)
        Me.LayoutControlGroup4.Text = "DATOS GENERALES"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtMaquina
        Me.LayoutControlItem9.Location = New System.Drawing.Point(136, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(178, 40)
        Me.LayoutControlItem9.Text = "Maquina"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(314, 40)
        Me.LayoutControlItem2.Text = "Nombre"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(131, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(136, 40)
        Me.LayoutControlItem1.Text = "Codigo"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(131, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 80)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(314, 44)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.sbdcTandas
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(314, 51)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'frmTemporal_TandasTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycTemporal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTemporal_TandasTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trabajos de Producción"
        CType(Me.lycTemporal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTandas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_TandasTrabajo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTandas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoReporteTiempoPerdido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoReporteUnidadesMalas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeTiempoTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeHoraFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeHoraInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinUTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinUMalas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinUBuenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTemporal As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsTemporal_TandasTrabajo1 As waProduccion_Pedidos.dsTemporal_TandasTrabajo
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinUTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinUMalas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinUBuenas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdTandas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTandas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents memoReporteTiempoPerdido As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents memoReporteUnidadesMalas As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtMaquina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents timeTiempoTotal As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents timeHoraFinal As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents timeHoraInicio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcTandas As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents barbtnAgregarTanda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesBuenas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesMalas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasProducidas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReporteMalas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReporteTiempo As DevExpress.XtraGrid.Columns.GridColumn
End Class
