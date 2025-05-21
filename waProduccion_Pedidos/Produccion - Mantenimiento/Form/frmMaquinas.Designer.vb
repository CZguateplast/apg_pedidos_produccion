<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaquinas))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sbdcMenu = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barMenu = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBitacoraModificacion = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.vgrdMaquinas = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsMaquinas1 = New waProduccion_Pedidos.dsMaquinas()
        Me.vrslueTipoMaquina = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vrslueUbicacion = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rowId = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombre = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowModelo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSerie = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowGrupo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUbicacion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowToneladas = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLibrasHoras = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTipo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowInyeccionOz = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowInyeccionGr = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrensaCierreMAX = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrensaCierreMIN = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrensaCierreCARRERA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCarreraExpulsionMM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBarrasDistanciaHOR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBarrasDistanciaVER = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPlatinasDimencionesHOR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPlatinasDimencionesVER = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAnilloCentrador = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMantenimiento = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMantenimientoFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstatus = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdMaquinas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewMaquinas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueUbicacion = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colToneladas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLibrasHoras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueTipoMaquina = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInyeccionOz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInyeccionGr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrensaCierreMAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrensaCierreMIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrensaCierreCARRERA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarreraExpulsionMM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarrasDistanciaHOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarrasDistanciaVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlatinasDimencionesHOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlatinasDimencionesVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnilloCentrador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimientoFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCambioMolde_Hora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycMaquinas = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.rowCambioMolde_Hora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaquinas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueTipoMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueTipoMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.sbdcMenu)
        Me.LayoutControl1.Controls.Add(Me.vgrdMaquinas)
        Me.LayoutControl1.Controls.Add(Me.grdMaquinas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.lycMaquinas
        Me.LayoutControl1.Size = New System.Drawing.Size(1916, 747)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(270, 23)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Mantenimiento de Maquinas"
        '
        'sbdcMenu
        '
        Me.sbdcMenu.CausesValidation = False
        Me.sbdcMenu.Location = New System.Drawing.Point(12, 39)
        Me.sbdcMenu.Manager = Me.BarManager1
        Me.sbdcMenu.Name = "sbdcMenu"
        Me.sbdcMenu.Size = New System.Drawing.Size(338, 47)
        Me.sbdcMenu.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barMenu})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcMenu)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnGrabar, Me.barbtnCancelar, Me.barbtnActualizar, Me.barbtnBitacoraModificacion, Me.barbtnImprimirGrid, Me.barbtnBuscar})
        Me.BarManager1.MaxItemId = 7
        '
        'barMenu
        '
        Me.barMenu.BarName = "Tools"
        Me.barMenu.DockCol = 0
        Me.barMenu.DockRow = 0
        Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnGrabar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBitacoraModificacion, True)})
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawBorder = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.StandaloneBarDockControl = Me.sbdcMenu
        Me.barMenu.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnGrabar
        '
        Me.barbtnGrabar.Caption = "Grabar"
        Me.barbtnGrabar.Id = 1
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
        '
        'barbtnCancelar
        '
        Me.barbtnCancelar.Caption = "Cancelar"
        Me.barbtnCancelar.Id = 2
        Me.barbtnCancelar.ImageOptions.Image = CType(resources.GetObject("barbtnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCancelar.Name = "barbtnCancelar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 3
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir Listado"
        Me.barbtnImprimirGrid.Id = 5
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Caption = "buscar"
        Me.barbtnBuscar.Id = 6
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Usuario"
        Me.barbtnBitacoraModificacion.Enabled = False
        Me.barbtnBitacoraModificacion.Id = 4
        Me.barbtnBitacoraModificacion.ImageOptions.Image = CType(resources.GetObject("barbtnBitacoraModificacion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBitacoraModificacion.Name = "barbtnBitacoraModificacion"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1916, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 747)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1916, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 747)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1916, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 747)
        '
        'vgrdMaquinas
        '
        Me.vgrdMaquinas.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vgrdMaquinas.Appearance.Category.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vgrdMaquinas.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vgrdMaquinas.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdMaquinas.Appearance.Category.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.Category.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vgrdMaquinas.Appearance.Category.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdMaquinas.Appearance.Category.Options.UseFont = True
        Me.vgrdMaquinas.Appearance.Category.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdMaquinas.Appearance.CategoryExpandButton.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.DisabledRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vgrdMaquinas.Appearance.DisabledRow.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.DisabledRow.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.DisabledRow.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.vgrdMaquinas.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.vgrdMaquinas.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.vgrdMaquinas.Appearance.ExpandButton.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdMaquinas.Appearance.ExpandButton.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdMaquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vgrdMaquinas.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.vgrdMaquinas.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.vgrdMaquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdMaquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.FocusedRow.Options.UseFont = True
        Me.vgrdMaquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vgrdMaquinas.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.vgrdMaquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdMaquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.HideSelectionRow.Options.UseFont = True
        Me.vgrdMaquinas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vgrdMaquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.RecordValue.BackColor = System.Drawing.Color.White
        Me.vgrdMaquinas.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.Options.UseFont = True
        Me.vgrdMaquinas.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdMaquinas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vgrdMaquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdMaquinas.DataMember = "dsdtMaquinaSeleccionada2"
        Me.vgrdMaquinas.DataSource = Me.DsMaquinas1
        Me.vgrdMaquinas.Location = New System.Drawing.Point(12, 90)
        Me.vgrdMaquinas.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdMaquinas.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdMaquinas.Name = "vgrdMaquinas"
        Me.vgrdMaquinas.RecordWidth = 200
        Me.vgrdMaquinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.vrslueTipoMaquina, Me.vrslueUbicacion})
        Me.vgrdMaquinas.RowHeaderWidth = 156
        Me.vgrdMaquinas.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowId, Me.rowNombre, Me.rowModelo, Me.rowSerie, Me.rowGrupo, Me.rowUbicacion, Me.rowToneladas, Me.rowLibrasHoras, Me.rowTipo, Me.rowInyeccionOz, Me.rowInyeccionGr, Me.rowPrensaCierreMAX, Me.rowPrensaCierreMIN, Me.rowPrensaCierreCARRERA, Me.rowCarreraExpulsionMM, Me.rowBarrasDistanciaHOR, Me.rowBarrasDistanciaVER, Me.rowPlatinasDimencionesHOR, Me.rowPlatinasDimencionesVER, Me.rowAnilloCentrador, Me.rowMantenimiento, Me.rowMantenimientoFecha, Me.rowEstatus, Me.rowBit_CreacionUsuario, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario, Me.rowBit_ModificacionFecha, Me.rowCambioMolde_Hora})
        Me.vgrdMaquinas.Size = New System.Drawing.Size(375, 645)
        Me.vgrdMaquinas.TabIndex = 5
        '
        'DsMaquinas1
        '
        Me.DsMaquinas1.DataSetName = "dsMaquinas"
        Me.DsMaquinas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vrslueTipoMaquina
        '
        Me.vrslueTipoMaquina.AutoHeight = False
        Me.vrslueTipoMaquina.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueTipoMaquina.Name = "vrslueTipoMaquina"
        Me.vrslueTipoMaquina.NullText = ""
        Me.vrslueTipoMaquina.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'vrslueUbicacion
        '
        Me.vrslueUbicacion.AutoHeight = False
        Me.vrslueUbicacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueUbicacion.Name = "vrslueUbicacion"
        Me.vrslueUbicacion.NullText = ""
        Me.vrslueUbicacion.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'rowId
        '
        Me.rowId.Appearance.Options.UseTextOptions = True
        Me.rowId.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowId.Enabled = False
        Me.rowId.Name = "rowId"
        Me.rowId.Properties.Caption = "Id"
        Me.rowId.Properties.FieldName = "Id"
        '
        'rowNombre
        '
        Me.rowNombre.Appearance.Options.UseTextOptions = True
        Me.rowNombre.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombre.Name = "rowNombre"
        Me.rowNombre.Properties.Caption = "Nombre"
        Me.rowNombre.Properties.FieldName = "Nombre"
        '
        'rowModelo
        '
        Me.rowModelo.Appearance.Options.UseTextOptions = True
        Me.rowModelo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowModelo.Name = "rowModelo"
        Me.rowModelo.Properties.Caption = "Modelo"
        Me.rowModelo.Properties.FieldName = "Modelo"
        '
        'rowSerie
        '
        Me.rowSerie.Appearance.Options.UseTextOptions = True
        Me.rowSerie.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowSerie.Name = "rowSerie"
        Me.rowSerie.Properties.Caption = "Serie"
        Me.rowSerie.Properties.FieldName = "Serie"
        '
        'rowGrupo
        '
        Me.rowGrupo.Appearance.Options.UseTextOptions = True
        Me.rowGrupo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowGrupo.Name = "rowGrupo"
        Me.rowGrupo.Properties.Caption = "Grupo"
        Me.rowGrupo.Properties.FieldName = "Grupo"
        '
        'rowUbicacion
        '
        Me.rowUbicacion.Name = "rowUbicacion"
        Me.rowUbicacion.Properties.Caption = "Ubicacion"
        Me.rowUbicacion.Properties.FieldName = "Ubicacion"
        Me.rowUbicacion.Properties.RowEdit = Me.vrslueUbicacion
        '
        'rowToneladas
        '
        Me.rowToneladas.Appearance.Options.UseTextOptions = True
        Me.rowToneladas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowToneladas.Name = "rowToneladas"
        Me.rowToneladas.Properties.Caption = "Toneladas"
        Me.rowToneladas.Properties.FieldName = "Toneladas"
        '
        'rowLibrasHoras
        '
        Me.rowLibrasHoras.Appearance.Options.UseTextOptions = True
        Me.rowLibrasHoras.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowLibrasHoras.Name = "rowLibrasHoras"
        Me.rowLibrasHoras.Properties.Caption = "Libras Horas"
        Me.rowLibrasHoras.Properties.FieldName = "LibrasHoras"
        '
        'rowTipo
        '
        Me.rowTipo.Appearance.Options.UseTextOptions = True
        Me.rowTipo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowTipo.Height = 18
        Me.rowTipo.Name = "rowTipo"
        Me.rowTipo.Properties.Caption = "Tipo"
        Me.rowTipo.Properties.FieldName = "Tipo"
        Me.rowTipo.Properties.RowEdit = Me.vrslueTipoMaquina
        '
        'rowInyeccionOz
        '
        Me.rowInyeccionOz.Appearance.Options.UseTextOptions = True
        Me.rowInyeccionOz.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowInyeccionOz.Name = "rowInyeccionOz"
        Me.rowInyeccionOz.Properties.Caption = "Inyeccion Oz"
        Me.rowInyeccionOz.Properties.FieldName = "InyeccionOz"
        '
        'rowInyeccionGr
        '
        Me.rowInyeccionGr.Appearance.Options.UseTextOptions = True
        Me.rowInyeccionGr.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowInyeccionGr.Name = "rowInyeccionGr"
        Me.rowInyeccionGr.Properties.Caption = "Inyeccion Gr"
        Me.rowInyeccionGr.Properties.FieldName = "InyeccionGr"
        '
        'rowPrensaCierreMAX
        '
        Me.rowPrensaCierreMAX.Appearance.Options.UseTextOptions = True
        Me.rowPrensaCierreMAX.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowPrensaCierreMAX.Name = "rowPrensaCierreMAX"
        Me.rowPrensaCierreMAX.Properties.Caption = "Prensa Cierre MAX"
        Me.rowPrensaCierreMAX.Properties.FieldName = "PrensaCierreMAX"
        '
        'rowPrensaCierreMIN
        '
        Me.rowPrensaCierreMIN.Appearance.Options.UseTextOptions = True
        Me.rowPrensaCierreMIN.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowPrensaCierreMIN.Name = "rowPrensaCierreMIN"
        Me.rowPrensaCierreMIN.Properties.Caption = "Prensa Cierre MIN"
        Me.rowPrensaCierreMIN.Properties.FieldName = "PrensaCierreMIN"
        '
        'rowPrensaCierreCARRERA
        '
        Me.rowPrensaCierreCARRERA.Appearance.Options.UseTextOptions = True
        Me.rowPrensaCierreCARRERA.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowPrensaCierreCARRERA.Name = "rowPrensaCierreCARRERA"
        Me.rowPrensaCierreCARRERA.Properties.Caption = "Prensa Cierre CARRERA"
        Me.rowPrensaCierreCARRERA.Properties.FieldName = "PrensaCierreCARRERA"
        '
        'rowCarreraExpulsionMM
        '
        Me.rowCarreraExpulsionMM.Appearance.Options.UseTextOptions = True
        Me.rowCarreraExpulsionMM.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCarreraExpulsionMM.Name = "rowCarreraExpulsionMM"
        Me.rowCarreraExpulsionMM.Properties.Caption = "Carrera Expulsion MM"
        Me.rowCarreraExpulsionMM.Properties.FieldName = "CarreraExpulsionMM"
        '
        'rowBarrasDistanciaHOR
        '
        Me.rowBarrasDistanciaHOR.Appearance.Options.UseTextOptions = True
        Me.rowBarrasDistanciaHOR.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBarrasDistanciaHOR.Name = "rowBarrasDistanciaHOR"
        Me.rowBarrasDistanciaHOR.Properties.Caption = "Barras Distancia HOR"
        Me.rowBarrasDistanciaHOR.Properties.FieldName = "BarrasDistanciaHOR"
        '
        'rowBarrasDistanciaVER
        '
        Me.rowBarrasDistanciaVER.Appearance.Options.UseTextOptions = True
        Me.rowBarrasDistanciaVER.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBarrasDistanciaVER.Name = "rowBarrasDistanciaVER"
        Me.rowBarrasDistanciaVER.Properties.Caption = "Barras Distancia VER"
        Me.rowBarrasDistanciaVER.Properties.FieldName = "BarrasDistanciaVER"
        '
        'rowPlatinasDimencionesHOR
        '
        Me.rowPlatinasDimencionesHOR.Appearance.Options.UseTextOptions = True
        Me.rowPlatinasDimencionesHOR.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowPlatinasDimencionesHOR.Name = "rowPlatinasDimencionesHOR"
        Me.rowPlatinasDimencionesHOR.Properties.Caption = "Platinas Dimenciones HOR"
        Me.rowPlatinasDimencionesHOR.Properties.FieldName = "PlatinasDimencionesHOR"
        '
        'rowPlatinasDimencionesVER
        '
        Me.rowPlatinasDimencionesVER.Appearance.Options.UseTextOptions = True
        Me.rowPlatinasDimencionesVER.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowPlatinasDimencionesVER.Name = "rowPlatinasDimencionesVER"
        Me.rowPlatinasDimencionesVER.Properties.Caption = "Platinas Dimenciones VER"
        Me.rowPlatinasDimencionesVER.Properties.FieldName = "PlatinasDimencionesVER"
        '
        'rowAnilloCentrador
        '
        Me.rowAnilloCentrador.Appearance.Options.UseTextOptions = True
        Me.rowAnilloCentrador.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowAnilloCentrador.Name = "rowAnilloCentrador"
        Me.rowAnilloCentrador.Properties.Caption = "Anillo Centrador"
        Me.rowAnilloCentrador.Properties.FieldName = "AnilloCentrador"
        '
        'rowMantenimiento
        '
        Me.rowMantenimiento.Appearance.Options.UseTextOptions = True
        Me.rowMantenimiento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowMantenimiento.Enabled = False
        Me.rowMantenimiento.Name = "rowMantenimiento"
        Me.rowMantenimiento.Properties.Caption = "Mantenimiento"
        Me.rowMantenimiento.Properties.FieldName = "Mantenimiento"
        '
        'rowMantenimientoFecha
        '
        Me.rowMantenimientoFecha.Appearance.Options.UseTextOptions = True
        Me.rowMantenimientoFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowMantenimientoFecha.Enabled = False
        Me.rowMantenimientoFecha.Name = "rowMantenimientoFecha"
        Me.rowMantenimientoFecha.Properties.Caption = "Mantenimiento Fecha"
        Me.rowMantenimientoFecha.Properties.FieldName = "MantenimientoFecha"
        '
        'rowEstatus
        '
        Me.rowEstatus.Appearance.Options.UseTextOptions = True
        Me.rowEstatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowEstatus.Name = "rowEstatus"
        Me.rowEstatus.Properties.Caption = "Estatus"
        Me.rowEstatus.Properties.FieldName = "Estatus"
        '
        'rowBit_CreacionUsuario
        '
        Me.rowBit_CreacionUsuario.Appearance.Options.UseTextOptions = True
        Me.rowBit_CreacionUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBit_CreacionUsuario.Enabled = False
        Me.rowBit_CreacionUsuario.Name = "rowBit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Properties.Caption = "Bit_Creacion Usuario"
        Me.rowBit_CreacionUsuario.Properties.FieldName = "Bit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Visible = False
        '
        'rowBit_CreacionFecha
        '
        Me.rowBit_CreacionFecha.Appearance.Options.UseTextOptions = True
        Me.rowBit_CreacionFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBit_CreacionFecha.Enabled = False
        Me.rowBit_CreacionFecha.Name = "rowBit_CreacionFecha"
        Me.rowBit_CreacionFecha.Properties.Caption = "Bit_Creacion Fecha"
        Me.rowBit_CreacionFecha.Properties.FieldName = "Bit_CreacionFecha"
        Me.rowBit_CreacionFecha.Visible = False
        '
        'rowBit_ModificacionUsuario
        '
        Me.rowBit_ModificacionUsuario.Appearance.Options.UseTextOptions = True
        Me.rowBit_ModificacionUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBit_ModificacionUsuario.Enabled = False
        Me.rowBit_ModificacionUsuario.Name = "rowBit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Properties.Caption = "Bit_Modificacion Usuario"
        Me.rowBit_ModificacionUsuario.Properties.FieldName = "Bit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Visible = False
        '
        'rowBit_ModificacionFecha
        '
        Me.rowBit_ModificacionFecha.Appearance.Options.UseTextOptions = True
        Me.rowBit_ModificacionFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowBit_ModificacionFecha.Enabled = False
        Me.rowBit_ModificacionFecha.Name = "rowBit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Properties.Caption = "Bit_Modificacion Fecha"
        Me.rowBit_ModificacionFecha.Properties.FieldName = "Bit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Visible = False
        '
        'grdMaquinas
        '
        Me.grdMaquinas.DataMember = "dsdtMaquinas2"
        Me.grdMaquinas.DataSource = Me.DsMaquinas1
        Me.grdMaquinas.Location = New System.Drawing.Point(391, 12)
        Me.grdMaquinas.MainView = Me.grdviewMaquinas
        Me.grdMaquinas.Name = "grdMaquinas"
        Me.grdMaquinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueTipoMaquina, Me.rslueUbicacion})
        Me.grdMaquinas.Size = New System.Drawing.Size(1513, 723)
        Me.grdMaquinas.TabIndex = 4
        Me.grdMaquinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinas})
        '
        'grdviewMaquinas
        '
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMaquinas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Preview.Options.UseFont = True
        Me.grdviewMaquinas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinas.ColumnPanelRowHeight = 35
        Me.grdviewMaquinas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colModelo, Me.colSerie, Me.colGrupo, Me.colUbicacion, Me.colToneladas, Me.colLibrasHoras, Me.colTipo, Me.colInyeccionOz, Me.colInyeccionGr, Me.colPrensaCierreMAX, Me.colPrensaCierreMIN, Me.colPrensaCierreCARRERA, Me.colCarreraExpulsionMM, Me.colBarrasDistanciaHOR, Me.colBarrasDistanciaVER, Me.colPlatinasDimencionesHOR, Me.colPlatinasDimencionesVER, Me.colAnilloCentrador, Me.colMantenimiento, Me.colMantenimientoFecha, Me.colCambioMolde_Hora, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewMaquinas.GridControl = Me.grdMaquinas
        Me.grdviewMaquinas.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", Nothing, "")})
        Me.grdviewMaquinas.Name = "grdviewMaquinas"
        Me.grdviewMaquinas.OptionsBehavior.Editable = False
        Me.grdviewMaquinas.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinas.OptionsView.ColumnAutoWidth = False
        Me.grdviewMaquinas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinas.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinas.PaintStyleName = "Web"
        '
        'colId
        '
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 55
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 150
        '
        'colModelo
        '
        Me.colModelo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModelo.AppearanceHeader.Options.UseFont = True
        Me.colModelo.AppearanceHeader.Options.UseTextOptions = True
        Me.colModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 2
        Me.colModelo.Width = 100
        '
        'colSerie
        '
        Me.colSerie.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSerie.AppearanceHeader.Options.UseFont = True
        Me.colSerie.AppearanceHeader.Options.UseTextOptions = True
        Me.colSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSerie.FieldName = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.Visible = True
        Me.colSerie.VisibleIndex = 3
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupo.AppearanceHeader.Options.UseFont = True
        Me.colGrupo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 4
        Me.colGrupo.Width = 60
        '
        'colUbicacion
        '
        Me.colUbicacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUbicacion.AppearanceHeader.Options.UseFont = True
        Me.colUbicacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colUbicacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUbicacion.ColumnEdit = Me.rslueUbicacion
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        Me.colUbicacion.Visible = True
        Me.colUbicacion.VisibleIndex = 5
        '
        'rslueUbicacion
        '
        Me.rslueUbicacion.AutoHeight = False
        Me.rslueUbicacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueUbicacion.Name = "rslueUbicacion"
        Me.rslueUbicacion.NullText = ""
        Me.rslueUbicacion.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colToneladas
        '
        Me.colToneladas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colToneladas.AppearanceHeader.Options.UseFont = True
        Me.colToneladas.AppearanceHeader.Options.UseTextOptions = True
        Me.colToneladas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colToneladas.FieldName = "Toneladas"
        Me.colToneladas.Name = "colToneladas"
        Me.colToneladas.Visible = True
        Me.colToneladas.VisibleIndex = 6
        Me.colToneladas.Width = 80
        '
        'colLibrasHoras
        '
        Me.colLibrasHoras.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLibrasHoras.AppearanceHeader.Options.UseFont = True
        Me.colLibrasHoras.AppearanceHeader.Options.UseTextOptions = True
        Me.colLibrasHoras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLibrasHoras.FieldName = "LibrasHoras"
        Me.colLibrasHoras.Name = "colLibrasHoras"
        Me.colLibrasHoras.Visible = True
        Me.colLibrasHoras.VisibleIndex = 7
        Me.colLibrasHoras.Width = 80
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.ColumnEdit = Me.rslueTipoMaquina
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 8
        Me.colTipo.Width = 60
        '
        'rslueTipoMaquina
        '
        Me.rslueTipoMaquina.AutoHeight = False
        Me.rslueTipoMaquina.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueTipoMaquina.Name = "rslueTipoMaquina"
        Me.rslueTipoMaquina.NullText = ""
        Me.rslueTipoMaquina.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInyeccionOz
        '
        Me.colInyeccionOz.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionOz.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionOz.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionOz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionOz.FieldName = "InyeccionOz"
        Me.colInyeccionOz.Name = "colInyeccionOz"
        Me.colInyeccionOz.Visible = True
        Me.colInyeccionOz.VisibleIndex = 9
        Me.colInyeccionOz.Width = 80
        '
        'colInyeccionGr
        '
        Me.colInyeccionGr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionGr.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionGr.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionGr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionGr.FieldName = "InyeccionGr"
        Me.colInyeccionGr.Name = "colInyeccionGr"
        Me.colInyeccionGr.Visible = True
        Me.colInyeccionGr.VisibleIndex = 10
        Me.colInyeccionGr.Width = 80
        '
        'colPrensaCierreMAX
        '
        Me.colPrensaCierreMAX.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrensaCierreMAX.AppearanceHeader.Options.UseFont = True
        Me.colPrensaCierreMAX.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrensaCierreMAX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrensaCierreMAX.FieldName = "PrensaCierreMAX"
        Me.colPrensaCierreMAX.Name = "colPrensaCierreMAX"
        Me.colPrensaCierreMAX.Visible = True
        Me.colPrensaCierreMAX.VisibleIndex = 11
        Me.colPrensaCierreMAX.Width = 80
        '
        'colPrensaCierreMIN
        '
        Me.colPrensaCierreMIN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrensaCierreMIN.AppearanceHeader.Options.UseFont = True
        Me.colPrensaCierreMIN.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrensaCierreMIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrensaCierreMIN.FieldName = "PrensaCierreMIN"
        Me.colPrensaCierreMIN.Name = "colPrensaCierreMIN"
        Me.colPrensaCierreMIN.Visible = True
        Me.colPrensaCierreMIN.VisibleIndex = 12
        Me.colPrensaCierreMIN.Width = 80
        '
        'colPrensaCierreCARRERA
        '
        Me.colPrensaCierreCARRERA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrensaCierreCARRERA.AppearanceHeader.Options.UseFont = True
        Me.colPrensaCierreCARRERA.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrensaCierreCARRERA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrensaCierreCARRERA.FieldName = "PrensaCierreCARRERA"
        Me.colPrensaCierreCARRERA.Name = "colPrensaCierreCARRERA"
        Me.colPrensaCierreCARRERA.Visible = True
        Me.colPrensaCierreCARRERA.VisibleIndex = 13
        Me.colPrensaCierreCARRERA.Width = 80
        '
        'colCarreraExpulsionMM
        '
        Me.colCarreraExpulsionMM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCarreraExpulsionMM.AppearanceHeader.Options.UseFont = True
        Me.colCarreraExpulsionMM.AppearanceHeader.Options.UseTextOptions = True
        Me.colCarreraExpulsionMM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCarreraExpulsionMM.FieldName = "CarreraExpulsionMM"
        Me.colCarreraExpulsionMM.Name = "colCarreraExpulsionMM"
        Me.colCarreraExpulsionMM.Visible = True
        Me.colCarreraExpulsionMM.VisibleIndex = 14
        Me.colCarreraExpulsionMM.Width = 80
        '
        'colBarrasDistanciaHOR
        '
        Me.colBarrasDistanciaHOR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBarrasDistanciaHOR.AppearanceHeader.Options.UseFont = True
        Me.colBarrasDistanciaHOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colBarrasDistanciaHOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBarrasDistanciaHOR.FieldName = "BarrasDistanciaHOR"
        Me.colBarrasDistanciaHOR.Name = "colBarrasDistanciaHOR"
        Me.colBarrasDistanciaHOR.Visible = True
        Me.colBarrasDistanciaHOR.VisibleIndex = 15
        Me.colBarrasDistanciaHOR.Width = 80
        '
        'colBarrasDistanciaVER
        '
        Me.colBarrasDistanciaVER.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBarrasDistanciaVER.AppearanceHeader.Options.UseFont = True
        Me.colBarrasDistanciaVER.AppearanceHeader.Options.UseTextOptions = True
        Me.colBarrasDistanciaVER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBarrasDistanciaVER.FieldName = "BarrasDistanciaVER"
        Me.colBarrasDistanciaVER.Name = "colBarrasDistanciaVER"
        Me.colBarrasDistanciaVER.Visible = True
        Me.colBarrasDistanciaVER.VisibleIndex = 16
        Me.colBarrasDistanciaVER.Width = 80
        '
        'colPlatinasDimencionesHOR
        '
        Me.colPlatinasDimencionesHOR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlatinasDimencionesHOR.AppearanceHeader.Options.UseFont = True
        Me.colPlatinasDimencionesHOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlatinasDimencionesHOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlatinasDimencionesHOR.FieldName = "PlatinasDimencionesHOR"
        Me.colPlatinasDimencionesHOR.Name = "colPlatinasDimencionesHOR"
        Me.colPlatinasDimencionesHOR.Visible = True
        Me.colPlatinasDimencionesHOR.VisibleIndex = 17
        Me.colPlatinasDimencionesHOR.Width = 80
        '
        'colPlatinasDimencionesVER
        '
        Me.colPlatinasDimencionesVER.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlatinasDimencionesVER.AppearanceHeader.Options.UseFont = True
        Me.colPlatinasDimencionesVER.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlatinasDimencionesVER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlatinasDimencionesVER.FieldName = "PlatinasDimencionesVER"
        Me.colPlatinasDimencionesVER.Name = "colPlatinasDimencionesVER"
        Me.colPlatinasDimencionesVER.Visible = True
        Me.colPlatinasDimencionesVER.VisibleIndex = 18
        Me.colPlatinasDimencionesVER.Width = 80
        '
        'colAnilloCentrador
        '
        Me.colAnilloCentrador.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAnilloCentrador.AppearanceHeader.Options.UseFont = True
        Me.colAnilloCentrador.AppearanceHeader.Options.UseTextOptions = True
        Me.colAnilloCentrador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAnilloCentrador.FieldName = "AnilloCentrador"
        Me.colAnilloCentrador.Name = "colAnilloCentrador"
        Me.colAnilloCentrador.Visible = True
        Me.colAnilloCentrador.VisibleIndex = 19
        Me.colAnilloCentrador.Width = 80
        '
        'colMantenimiento
        '
        Me.colMantenimiento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMantenimiento.AppearanceHeader.Options.UseFont = True
        Me.colMantenimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colMantenimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMantenimiento.FieldName = "Mantenimiento"
        Me.colMantenimiento.Name = "colMantenimiento"
        Me.colMantenimiento.Visible = True
        Me.colMantenimiento.VisibleIndex = 20
        Me.colMantenimiento.Width = 80
        '
        'colMantenimientoFecha
        '
        Me.colMantenimientoFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMantenimientoFecha.AppearanceHeader.Options.UseFont = True
        Me.colMantenimientoFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colMantenimientoFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMantenimientoFecha.FieldName = "MantenimientoFecha"
        Me.colMantenimientoFecha.Name = "colMantenimientoFecha"
        Me.colMantenimientoFecha.Visible = True
        Me.colMantenimientoFecha.VisibleIndex = 21
        Me.colMantenimientoFecha.Width = 80
        '
        'colCambioMolde_Hora
        '
        Me.colCambioMolde_Hora.Caption = "Cambio Molde (Hora)"
        Me.colCambioMolde_Hora.FieldName = "CambioMolde_Hora"
        Me.colCambioMolde_Hora.Name = "colCambioMolde_Hora"
        Me.colCambioMolde_Hora.Visible = True
        Me.colCambioMolde_Hora.VisibleIndex = 22
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus.AppearanceHeader.Options.UseFont = True
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 23
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        '
        'lycMaquinas
        '
        Me.lycMaquinas.CustomizationFormText = "LayoutControlGroup1"
        Me.lycMaquinas.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycMaquinas.GroupBordersVisible = False
        Me.lycMaquinas.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.lycMaquinas.Location = New System.Drawing.Point(0, 0)
        Me.lycMaquinas.Name = "lycMaquinas"
        Me.lycMaquinas.Size = New System.Drawing.Size(1916, 747)
        Me.lycMaquinas.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdMaquinas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1517, 727)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdMaquinas
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 649)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcMenu
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 51)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(379, 27)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'rowCambioMolde_Hora
        '
        Me.rowCambioMolde_Hora.Height = 16
        Me.rowCambioMolde_Hora.Name = "rowCambioMolde_Hora"
        Me.rowCambioMolde_Hora.Properties.FieldName = "CambioMolde_Hora"
        '
        'frmMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1916, 747)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMaquinas"
        Me.Text = "Maquinas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaquinas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueTipoMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueTipoMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lycMaquinas As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdMaquinas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents vgrdMaquinas As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcMenu As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barMenu As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsMaquinas1 As waProduccion_Pedidos.dsMaquinas
    Friend WithEvents vrslueTipoMaquina As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueTipoMaquina As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToneladas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLibrasHoras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionOz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionGr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrensaCierreMAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrensaCierreMIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrensaCierreCARRERA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarreraExpulsionMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarrasDistanciaHOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarrasDistanciaVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlatinasDimencionesHOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlatinasDimencionesVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnilloCentrador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimientoFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowId As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombre As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowModelo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSerie As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowGrupo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowToneladas As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLibrasHoras As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTipo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowInyeccionOz As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowInyeccionGr As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrensaCierreMAX As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrensaCierreMIN As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrensaCierreCARRERA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCarreraExpulsionMM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBarrasDistanciaHOR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBarrasDistanciaVER As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPlatinasDimencionesHOR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPlatinasDimencionesVER As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAnilloCentrador As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMantenimiento As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMantenimientoFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstatus As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUbicacion As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueUbicacion As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vrslueUbicacion As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCambioMolde_Hora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowCambioMolde_Hora As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
