<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlProduccion_Resumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlProduccion_Resumen))
        Me.lycControlProduccion_Resumen = New DevExpress.XtraLayout.LayoutControl()
        Me.spinProduccionPendiente = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnEditarOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.slueTurno = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dteTurno = New DevExpress.XtraEditors.DateEdit()
        Me.dteInicioTrabajo = New DevExpress.XtraEditors.DateEdit()
        Me.mmeComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMaquina = New DevExpress.XtraEditors.TextEdit()
        Me.timeTotalHoras = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.timeFinal = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.timeInicial = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.spinTotalProduccion = New DevExpress.XtraEditors.SpinEdit()
        Me.spinMalas = New DevExpress.XtraEditors.SpinEdit()
        Me.spinTotalEnsambles = New DevExpress.XtraEditors.SpinEdit()
        Me.spinBuenas = New DevExpress.XtraEditors.SpinEdit()
        Me.grdEnsambles = New DevExpress.XtraGrid.GridControl()
        Me.DsControlProduccion_Resumen1 = New waProduccion_Pedidos.dsControlProduccion_Resumen()
        Me.grdviewEnsambles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSAP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdProducciones = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProducciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycControlProduccion_Resumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycControlProduccion_Resumen.SuspendLayout()
        CType(Me.spinProduccionPendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTurno.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteInicioTrabajo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteInicioTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeTotalHoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinTotalProduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMalas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinTotalEnsambles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinBuenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlProduccion_Resumen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycControlProduccion_Resumen
        '
        Me.lycControlProduccion_Resumen.Controls.Add(Me.spinProduccionPendiente)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.slueTurno)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.dteTurno)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.dteInicioTrabajo)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.mmeComentarios)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.txtMaquina)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.timeTotalHoras)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.timeFinal)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.timeInicial)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.spinTotalProduccion)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.spinMalas)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.spinTotalEnsambles)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.spinBuenas)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.grdEnsambles)
        Me.lycControlProduccion_Resumen.Controls.Add(Me.grdProducciones)
        Me.lycControlProduccion_Resumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycControlProduccion_Resumen.Location = New System.Drawing.Point(0, 0)
        Me.lycControlProduccion_Resumen.Name = "lycControlProduccion_Resumen"
        Me.lycControlProduccion_Resumen.Root = Me.LayoutControlGroup1
        Me.lycControlProduccion_Resumen.Size = New System.Drawing.Size(929, 558)
        Me.lycControlProduccion_Resumen.TabIndex = 0
        Me.lycControlProduccion_Resumen.Text = "LayoutControl1"
        '
        'spinProduccionPendiente
        '
        Me.spinProduccionPendiente.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinProduccionPendiente.Enabled = False
        Me.spinProduccionPendiente.Location = New System.Drawing.Point(317, 120)
        Me.spinProduccionPendiente.MenuManager = Me.BarManager1
        Me.spinProduccionPendiente.Name = "spinProduccionPendiente"
        Me.spinProduccionPendiente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinProduccionPendiente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinProduccionPendiente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinProduccionPendiente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinProduccionPendiente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinProduccionPendiente.Size = New System.Drawing.Size(75, 20)
        Me.spinProduccionPendiente.StyleController = Me.lycControlProduccion_Resumen
        Me.spinProduccionPendiente.TabIndex = 15
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEditarOrden, Me.barbtnGrabar, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEditarOrden, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGrabar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnEditarOrden
        '
        Me.barbtnEditarOrden.Caption = "Editar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.barbtnEditarOrden.Id = 0
        Me.barbtnEditarOrden.ImageOptions.Image = CType(resources.GetObject("barbtnEditarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEditarOrden.Name = "barbtnEditarOrden"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(929, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 558)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(929, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 558)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(929, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 558)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'slueTurno
        '
        Me.slueTurno.Enabled = False
        Me.slueTurno.Location = New System.Drawing.Point(104, 120)
        Me.slueTurno.MenuManager = Me.BarManager1
        Me.slueTurno.Name = "slueTurno"
        Me.slueTurno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.slueTurno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.slueTurno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueTurno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.slueTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTurno.Properties.NullText = ""
        Me.slueTurno.Properties.View = Me.SearchLookUpEdit1View
        Me.slueTurno.Size = New System.Drawing.Size(105, 20)
        Me.slueTurno.StyleController = Me.lycControlProduccion_Resumen
        Me.slueTurno.TabIndex = 14
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'dteTurno
        '
        Me.dteTurno.EditValue = Nothing
        Me.dteTurno.Enabled = False
        Me.dteTurno.Location = New System.Drawing.Point(104, 96)
        Me.dteTurno.Name = "dteTurno"
        Me.dteTurno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dteTurno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dteTurno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteTurno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTurno.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTurno.Size = New System.Drawing.Size(105, 20)
        Me.dteTurno.StyleController = Me.lycControlProduccion_Resumen
        Me.dteTurno.TabIndex = 12
        '
        'dteInicioTrabajo
        '
        Me.dteInicioTrabajo.EditValue = Nothing
        Me.dteInicioTrabajo.Enabled = False
        Me.dteInicioTrabajo.Location = New System.Drawing.Point(104, 72)
        Me.dteInicioTrabajo.MenuManager = Me.BarManager1
        Me.dteInicioTrabajo.Name = "dteInicioTrabajo"
        Me.dteInicioTrabajo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dteInicioTrabajo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dteInicioTrabajo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteInicioTrabajo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteInicioTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteInicioTrabajo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteInicioTrabajo.Size = New System.Drawing.Size(105, 20)
        Me.dteInicioTrabajo.StyleController = Me.lycControlProduccion_Resumen
        Me.dteInicioTrabajo.TabIndex = 12
        '
        'mmeComentarios
        '
        Me.mmeComentarios.Enabled = False
        Me.mmeComentarios.Location = New System.Drawing.Point(762, 28)
        Me.mmeComentarios.MenuManager = Me.BarManager1
        Me.mmeComentarios.Name = "mmeComentarios"
        Me.mmeComentarios.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mmeComentarios.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.mmeComentarios.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.mmeComentarios.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.mmeComentarios.Size = New System.Drawing.Size(155, 124)
        Me.mmeComentarios.StyleController = Me.lycControlProduccion_Resumen
        Me.mmeComentarios.TabIndex = 11
        '
        'txtMaquina
        '
        Me.txtMaquina.Enabled = False
        Me.txtMaquina.Location = New System.Drawing.Point(104, 48)
        Me.txtMaquina.MaximumSize = New System.Drawing.Size(105, 20)
        Me.txtMaquina.MenuManager = Me.BarManager1
        Me.txtMaquina.MinimumSize = New System.Drawing.Size(105, 20)
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaquina.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtMaquina.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtMaquina.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtMaquina.Size = New System.Drawing.Size(105, 20)
        Me.txtMaquina.StyleController = Me.lycControlProduccion_Resumen
        Me.txtMaquina.TabIndex = 10
        '
        'timeTotalHoras
        '
        Me.timeTotalHoras.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.timeTotalHoras.Enabled = False
        Me.timeTotalHoras.Location = New System.Drawing.Point(683, 96)
        Me.timeTotalHoras.MenuManager = Me.BarManager1
        Me.timeTotalHoras.Name = "timeTotalHoras"
        Me.timeTotalHoras.Properties.AllowEditDays = False
        Me.timeTotalHoras.Properties.AllowEditSeconds = False
        Me.timeTotalHoras.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.timeTotalHoras.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.timeTotalHoras.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.timeTotalHoras.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.timeTotalHoras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeTotalHoras.Properties.Mask.EditMask = "HH:mm"
        Me.timeTotalHoras.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.timeTotalHoras.Size = New System.Drawing.Size(63, 20)
        Me.timeTotalHoras.StyleController = Me.lycControlProduccion_Resumen
        Me.timeTotalHoras.TabIndex = 9
        '
        'timeFinal
        '
        Me.timeFinal.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.timeFinal.Enabled = False
        Me.timeFinal.Location = New System.Drawing.Point(683, 72)
        Me.timeFinal.MenuManager = Me.BarManager1
        Me.timeFinal.Name = "timeFinal"
        Me.timeFinal.Properties.AllowEditDays = False
        Me.timeFinal.Properties.AllowEditSeconds = False
        Me.timeFinal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.timeFinal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.timeFinal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.timeFinal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.timeFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeFinal.Properties.Mask.EditMask = "HH:mm"
        Me.timeFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.timeFinal.Size = New System.Drawing.Size(63, 20)
        Me.timeFinal.StyleController = Me.lycControlProduccion_Resumen
        Me.timeFinal.TabIndex = 8
        '
        'timeInicial
        '
        Me.timeInicial.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.timeInicial.Enabled = False
        Me.timeInicial.Location = New System.Drawing.Point(683, 48)
        Me.timeInicial.MaximumSize = New System.Drawing.Size(63, 0)
        Me.timeInicial.MenuManager = Me.BarManager1
        Me.timeInicial.MinimumSize = New System.Drawing.Size(63, 0)
        Me.timeInicial.Name = "timeInicial"
        Me.timeInicial.Properties.AllowEditDays = False
        Me.timeInicial.Properties.AllowEditSeconds = False
        Me.timeInicial.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.timeInicial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.timeInicial.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.timeInicial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.timeInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeInicial.Properties.Mask.EditMask = "HH:mm"
        Me.timeInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.timeInicial.Size = New System.Drawing.Size(63, 20)
        Me.timeInicial.StyleController = Me.lycControlProduccion_Resumen
        Me.timeInicial.TabIndex = 7
        '
        'spinTotalProduccion
        '
        Me.spinTotalProduccion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinTotalProduccion.Enabled = False
        Me.spinTotalProduccion.Location = New System.Drawing.Point(317, 96)
        Me.spinTotalProduccion.Name = "spinTotalProduccion"
        Me.spinTotalProduccion.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinTotalProduccion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinTotalProduccion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinTotalProduccion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinTotalProduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinTotalProduccion.Properties.Mask.EditMask = "n0"
        Me.spinTotalProduccion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinTotalProduccion.Size = New System.Drawing.Size(75, 20)
        Me.spinTotalProduccion.StyleController = Me.lycControlProduccion_Resumen
        Me.spinTotalProduccion.TabIndex = 6
        '
        'spinMalas
        '
        Me.spinMalas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMalas.Enabled = False
        Me.spinMalas.Location = New System.Drawing.Point(317, 72)
        Me.spinMalas.Name = "spinMalas"
        Me.spinMalas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinMalas.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinMalas.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinMalas.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinMalas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMalas.Properties.Mask.EditMask = "n0"
        Me.spinMalas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinMalas.Size = New System.Drawing.Size(75, 20)
        Me.spinMalas.StyleController = Me.lycControlProduccion_Resumen
        Me.spinMalas.TabIndex = 6
        '
        'spinTotalEnsambles
        '
        Me.spinTotalEnsambles.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinTotalEnsambles.Enabled = False
        Me.spinTotalEnsambles.Location = New System.Drawing.Point(500, 48)
        Me.spinTotalEnsambles.MaximumSize = New System.Drawing.Size(75, 0)
        Me.spinTotalEnsambles.MinimumSize = New System.Drawing.Size(75, 0)
        Me.spinTotalEnsambles.Name = "spinTotalEnsambles"
        Me.spinTotalEnsambles.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinTotalEnsambles.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinTotalEnsambles.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinTotalEnsambles.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinTotalEnsambles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinTotalEnsambles.Properties.Mask.EditMask = "n0"
        Me.spinTotalEnsambles.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinTotalEnsambles.Size = New System.Drawing.Size(75, 20)
        Me.spinTotalEnsambles.StyleController = Me.lycControlProduccion_Resumen
        Me.spinTotalEnsambles.TabIndex = 6
        '
        'spinBuenas
        '
        Me.spinBuenas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinBuenas.Enabled = False
        Me.spinBuenas.Location = New System.Drawing.Point(317, 48)
        Me.spinBuenas.MaximumSize = New System.Drawing.Size(75, 20)
        Me.spinBuenas.MenuManager = Me.BarManager1
        Me.spinBuenas.MinimumSize = New System.Drawing.Size(75, 20)
        Me.spinBuenas.Name = "spinBuenas"
        Me.spinBuenas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.spinBuenas.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spinBuenas.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spinBuenas.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spinBuenas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinBuenas.Properties.Mask.EditMask = "n0"
        Me.spinBuenas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spinBuenas.Size = New System.Drawing.Size(75, 20)
        Me.spinBuenas.StyleController = Me.lycControlProduccion_Resumen
        Me.spinBuenas.TabIndex = 6
        '
        'grdEnsambles
        '
        Me.grdEnsambles.DataMember = "dsdtEnsambles"
        Me.grdEnsambles.DataSource = Me.DsControlProduccion_Resumen1
        Me.grdEnsambles.Location = New System.Drawing.Point(12, 342)
        Me.grdEnsambles.MainView = Me.grdviewEnsambles
        Me.grdEnsambles.MenuManager = Me.BarManager1
        Me.grdEnsambles.Name = "grdEnsambles"
        Me.grdEnsambles.Size = New System.Drawing.Size(905, 204)
        Me.grdEnsambles.TabIndex = 5
        Me.grdEnsambles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambles})
        '
        'DsControlProduccion_Resumen1
        '
        Me.DsControlProduccion_Resumen1.DataSetName = "dsControlProduccion_Resumen"
        Me.DsControlProduccion_Resumen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewEnsambles
        '
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEnsambles.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewEnsambles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewEnsambles.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAP1, Me.colEstado1, Me.colBodega1, Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colStock1, Me.colComprometido1, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colCargar1, Me.colComentarios1})
        Me.grdviewEnsambles.GridControl = Me.grdEnsambles
        Me.grdviewEnsambles.Name = "grdviewEnsambles"
        Me.grdviewEnsambles.OptionsBehavior.Editable = False
        Me.grdviewEnsambles.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grdviewEnsambles.OptionsBehavior.ReadOnly = True
        Me.grdviewEnsambles.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambles.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambles.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambles.OptionsView.ShowFooter = True
        Me.grdviewEnsambles.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambles.OptionsView.ShowViewCaption = True
        Me.grdviewEnsambles.PaintStyleName = "Web"
        Me.grdviewEnsambles.ViewCaption = "ENSAMBLES"
        '
        'colSAP1
        '
        Me.colSAP1.AppearanceCell.Options.UseTextOptions = True
        Me.colSAP1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP1.AppearanceHeader.Options.UseTextOptions = True
        Me.colSAP1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP1.FieldName = "SAP"
        Me.colSAP1.Name = "colSAP1"
        Me.colSAP1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SAP", "{0}")})
        Me.colSAP1.Visible = True
        Me.colSAP1.VisibleIndex = 0
        Me.colSAP1.Width = 60
        '
        'colEstado1
        '
        Me.colEstado1.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado1.FieldName = "Estado"
        Me.colEstado1.Name = "colEstado1"
        Me.colEstado1.Visible = True
        Me.colEstado1.VisibleIndex = 1
        Me.colEstado1.Width = 80
        '
        'colBodega1
        '
        Me.colBodega1.AppearanceCell.Options.UseTextOptions = True
        Me.colBodega1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega1.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega1.FieldName = "Bodega"
        Me.colBodega1.Name = "colBodega1"
        Me.colBodega1.Visible = True
        Me.colBodega1.VisibleIndex = 2
        Me.colBodega1.Width = 100
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 3
        Me.colCodigoArticulo1.Width = 115
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 4
        Me.colNombreArticulo1.Width = 250
        '
        'colStock1
        '
        Me.colStock1.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock1.FieldName = "Stock"
        Me.colStock1.Name = "colStock1"
        Me.colStock1.Visible = True
        Me.colStock1.VisibleIndex = 7
        Me.colStock1.Width = 65
        '
        'colComprometido1
        '
        Me.colComprometido1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colComprometido1.AppearanceHeader.Options.UseFont = True
        Me.colComprometido1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido1.FieldName = "Comprometido"
        Me.colComprometido1.Name = "colComprometido1"
        Me.colComprometido1.Visible = True
        Me.colComprometido1.VisibleIndex = 8
        Me.colComprometido1.Width = 90
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 9
        Me.colPlaneado1.Width = 90
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 10
        Me.colCompletado1.Width = 90
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente1.AppearanceHeader.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 11
        Me.colPendiente1.Width = 90
        '
        'colCargar1
        '
        Me.colCargar1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCargar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCargar1.FieldName = "Cargar"
        Me.colCargar1.Name = "colCargar1"
        Me.colCargar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cargar", "SUM={0:0.##}")})
        Me.colCargar1.Visible = True
        Me.colCargar1.VisibleIndex = 5
        Me.colCargar1.Width = 80
        '
        'colComentarios1
        '
        Me.colComentarios1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios1.FieldName = "Comentarios"
        Me.colComentarios1.Name = "colComentarios1"
        Me.colComentarios1.Visible = True
        Me.colComentarios1.VisibleIndex = 6
        Me.colComentarios1.Width = 200
        '
        'grdProducciones
        '
        Me.grdProducciones.DataMember = "dsdtProduccion"
        Me.grdProducciones.DataSource = Me.DsControlProduccion_Resumen1
        Me.grdProducciones.Location = New System.Drawing.Point(12, 156)
        Me.grdProducciones.MainView = Me.grdviewProducciones
        Me.grdProducciones.MenuManager = Me.BarManager1
        Me.grdProducciones.Name = "grdProducciones"
        Me.grdProducciones.Size = New System.Drawing.Size(905, 182)
        Me.grdProducciones.TabIndex = 4
        Me.grdProducciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProducciones})
        '
        'grdviewProducciones
        '
        Me.grdviewProducciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.grdviewProducciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewProducciones.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewProducciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewProducciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewProducciones.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseFont = True
        Me.grdviewProducciones.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewProducciones.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewProducciones.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewProducciones.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewProducciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewProducciones.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProducciones.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProducciones.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewProducciones.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewProducciones.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewProducciones.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewProducciones.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProducciones.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.grdviewProducciones.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProducciones.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProducciones.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProducciones.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProducciones.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProducciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAP, Me.colEstado, Me.colBodega, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colStock, Me.colComprometido, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCargar, Me.colComentarios})
        Me.grdviewProducciones.GridControl = Me.grdProducciones
        Me.grdviewProducciones.Name = "grdviewProducciones"
        Me.grdviewProducciones.OptionsBehavior.Editable = False
        Me.grdviewProducciones.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grdviewProducciones.OptionsBehavior.ReadOnly = True
        Me.grdviewProducciones.OptionsView.ColumnAutoWidth = False
        Me.grdviewProducciones.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProducciones.OptionsView.ShowFooter = True
        Me.grdviewProducciones.OptionsView.ShowGroupPanel = False
        Me.grdviewProducciones.OptionsView.ShowViewCaption = True
        Me.grdviewProducciones.PaintStyleName = "Web"
        Me.grdviewProducciones.ViewCaption = "PRODUCCIONES"
        '
        'colSAP
        '
        Me.colSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSAP.FieldName = "SAP"
        Me.colSAP.Name = "colSAP"
        Me.colSAP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SAP", "{0}")})
        Me.colSAP.Visible = True
        Me.colSAP.VisibleIndex = 0
        Me.colSAP.Width = 60
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        Me.colEstado.Width = 80
        '
        'colBodega
        '
        Me.colBodega.AppearanceCell.Options.UseTextOptions = True
        Me.colBodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 2
        Me.colBodega.Width = 100
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 3
        Me.colCodigoArticulo.Width = 115
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 4
        Me.colNombreArticulo.Width = 250
        '
        'colStock
        '
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 7
        Me.colStock.Width = 65
        '
        'colComprometido
        '
        Me.colComprometido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colComprometido.AppearanceHeader.Options.UseFont = True
        Me.colComprometido.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido.FieldName = "Comprometido"
        Me.colComprometido.Name = "colComprometido"
        Me.colComprometido.Visible = True
        Me.colComprometido.VisibleIndex = 8
        Me.colComprometido.Width = 90
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 9
        Me.colPlaneado.Width = 90
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 10
        Me.colCompletado.Width = 90
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 11
        Me.colPendiente.Width = 90
        '
        'colCargar
        '
        Me.colCargar.AppearanceHeader.Options.UseTextOptions = True
        Me.colCargar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCargar.FieldName = "Cargar"
        Me.colCargar.Name = "colCargar"
        Me.colCargar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cargar", "SUM={0:0.##}")})
        Me.colCargar.Visible = True
        Me.colCargar.VisibleIndex = 5
        Me.colCargar.Width = 80
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 6
        Me.colComentarios.Width = 200
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlGroup2, Me.LayoutControlItem1, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlItem11, Me.LayoutControlGroup5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(929, 558)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdEnsambles
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 330)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(909, 208)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CaptionImage = CType(resources.GetObject("LayoutControlGroup2.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem14})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(213, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(183, 144)
        Me.LayoutControlGroup2.Text = "Producción"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.spinTotalProduccion
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem5.Text = "Total"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.spinMalas
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem4.Text = "Malas"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.spinBuenas
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem3.Text = "Buenas"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.spinProduccionPendiente
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem14.Text = "Pendiente"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdProducciones
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(909, 186)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CaptionImage = CType(resources.GetObject("LayoutControlGroup3.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(396, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(183, 144)
        Me.LayoutControlGroup3.Text = "Ensambles"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.spinTotalEnsambles
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(159, 96)
        Me.LayoutControlItem6.Text = "Total Ensambles"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CaptionImage = CType(resources.GetObject("LayoutControlGroup4.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(579, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(171, 144)
        Me.LayoutControlGroup4.Text = "Tiempos"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.timeInicial
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(147, 24)
        Me.LayoutControlItem7.Text = "Hora Inicial"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.timeFinal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(147, 24)
        Me.LayoutControlItem8.Text = "Hora Final"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.timeTotalHoras
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(147, 48)
        Me.LayoutControlItem9.Text = "Total Horas"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.mmeComentarios
        Me.LayoutControlItem11.Location = New System.Drawing.Point(750, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(159, 144)
        Me.LayoutControlItem11.Text = "Comentarios"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CaptionImage = CType(resources.GetObject("LayoutControlGroup5.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(213, 144)
        Me.LayoutControlGroup5.Text = "Parametros de Maquina"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtMaquina
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem10.Text = "Maquina"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.dteInicioTrabajo
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem12.Text = "Inicio Trabajo"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.dteTurno
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem13.Text = "Fecha Turno"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.slueTurno
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem15.Text = "Tipo de Turno"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(77, 13)
        '
        'frmControlProduccion_Resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 601)
        Me.Controls.Add(Me.lycControlProduccion_Resumen)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmControlProduccion_Resumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Produccion Resumen"
        CType(Me.lycControlProduccion_Resumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycControlProduccion_Resumen.ResumeLayout(False)
        CType(Me.spinProduccionPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTurno.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteInicioTrabajo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteInicioTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeTotalHoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinTotalProduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMalas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinTotalEnsambles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinBuenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlProduccion_Resumen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycControlProduccion_Resumen As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdEnsambles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEnsambles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdProducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProducciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsControlProduccion_Resumen1 As waProduccion_Pedidos.dsControlProduccion_Resumen
    Friend WithEvents colSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnEditarOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents spinMalas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinBuenas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinTotalProduccion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinTotalEnsambles As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents timeInicial As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents timeTotalHoras As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents timeFinal As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents mmeComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtMaquina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dteInicioTrabajo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dteTurno As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents slueTurno As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinProduccionPendiente As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
