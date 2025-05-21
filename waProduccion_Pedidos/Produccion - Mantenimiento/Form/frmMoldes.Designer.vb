<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoldes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoldes))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sbdcMenu = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
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
        Me.grdMoldes = New DevExpress.XtraGrid.GridControl()
        Me.DsMoldes1 = New waProduccion_Pedidos.dsMoldes()
        Me.grdviewMoldes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoldeSerie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCavidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaquinaPreferencial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueBodega = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUbicacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimientoFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcIneficiencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmmeComentarios1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.vgrdMoldes = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.rslueMaquinas = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vrslueBodegas = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rmmeComentarios = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.rmmeComentario = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rowId = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombre = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCavidades = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUnidades = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaquinaPreferencial = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBodega = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUbicacion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUbicacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMoldeSerie = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMantenimiento = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMantenimientoFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComentarios = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstatus = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPorcIneficiencia = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizarPorcEficiencia = New DevExpress.XtraBars.BarButtonItem()
        Me.barspinPorcEficiencia = New DevExpress.XtraBars.BarEditItem()
        Me.rspinPorcEficiencia = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.rbtneditActualizaPorcEficiencia = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMoldes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeComentarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeComentario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinPorcEficiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtneditActualizaPorcEficiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.sbdcMenu)
        Me.LayoutControl1.Controls.Add(Me.grdMoldes)
        Me.LayoutControl1.Controls.Add(Me.vgrdMoldes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1483, 692)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(302, 28)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Mantenimiento de Moldes"
        '
        'sbdcMenu
        '
        Me.sbdcMenu.CausesValidation = False
        Me.sbdcMenu.Location = New System.Drawing.Point(16, 50)
        Me.sbdcMenu.Manager = Me.BarManager1
        Me.sbdcMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sbdcMenu.Name = "sbdcMenu"
        Me.sbdcMenu.Size = New System.Drawing.Size(500, 47)
        Me.sbdcMenu.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcMenu)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnActualizar, Me.barbtnAgregar, Me.barbtnBitacoraModificacion, Me.barbtnGrabar, Me.barbtnCancelar, Me.barbtnImprimirGrid, Me.barbtnBuscar})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.FloatLocation = New System.Drawing.Point(125, 213)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnGrabar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBitacoraModificacion, True)})
        Me.Bar1.OptionsBar.AllowCollapse = True
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcMenu
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Nuevo"
        Me.barbtnAgregar.Id = 2
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnGrabar
        '
        Me.barbtnGrabar.Caption = "Grabar"
        Me.barbtnGrabar.Id = 5
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
        '
        'barbtnCancelar
        '
        Me.barbtnCancelar.Caption = "Cancelar"
        Me.barbtnCancelar.Id = 6
        Me.barbtnCancelar.ImageOptions.Image = CType(resources.GetObject("barbtnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCancelar.Name = "barbtnCancelar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 0
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnActualizar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir Listado"
        Me.barbtnImprimirGrid.Id = 7
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 8
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Bit Usuario"
        Me.barbtnBitacoraModificacion.Id = 3
        Me.barbtnBitacoraModificacion.ImageOptions.Image = CType(resources.GetObject("barbtnBitacoraModificacion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBitacoraModificacion.Name = "barbtnBitacoraModificacion"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1483, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 692)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1483, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 692)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1483, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 692)
        '
        'grdMoldes
        '
        Me.grdMoldes.DataMember = "dsdtMoldes"
        Me.grdMoldes.DataSource = Me.DsMoldes1
        Me.grdMoldes.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdMoldes.Location = New System.Drawing.Point(522, 16)
        Me.grdMoldes.MainView = Me.grdviewMoldes
        Me.grdMoldes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdMoldes.Name = "grdMoldes"
        Me.grdMoldes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rmmeComentarios1, Me.rslueBodega})
        Me.grdMoldes.Size = New System.Drawing.Size(945, 660)
        Me.grdMoldes.TabIndex = 6
        Me.grdMoldes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMoldes})
        '
        'DsMoldes1
        '
        Me.DsMoldes1.DataSetName = "dsMoldes"
        Me.DsMoldes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewMoldes
        '
        Me.grdviewMoldes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewMoldes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewMoldes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewMoldes.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewMoldes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewMoldes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewMoldes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewMoldes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewMoldes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewMoldes.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.grdviewMoldes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewMoldes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMoldes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewMoldes.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.Preview.Options.UseFont = True
        Me.grdviewMoldes.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewMoldes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.grdviewMoldes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grdviewMoldes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.grdviewMoldes.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMoldes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colMoldeSerie, Me.colNombre, Me.colCavidades, Me.colUnidades, Me.colMaquinaPreferencial, Me.colBodega, Me.colUbicacion, Me.colUbicacionFecha, Me.colMantenimiento, Me.colMantenimientoFecha, Me.colPorcIneficiencia, Me.colComentarios, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewMoldes.GridControl = Me.grdMoldes
        Me.grdviewMoldes.Name = "grdviewMoldes"
        Me.grdviewMoldes.OptionsBehavior.Editable = False
        Me.grdviewMoldes.OptionsBehavior.ReadOnly = True
        Me.grdviewMoldes.OptionsFind.AlwaysVisible = True
        Me.grdviewMoldes.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.grdviewMoldes.OptionsFind.ShowCloseButton = False
        Me.grdviewMoldes.OptionsFind.ShowFindButton = False
        Me.grdviewMoldes.OptionsView.ColumnAutoWidth = False
        Me.grdviewMoldes.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMoldes.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMoldes.OptionsView.ShowGroupPanel = False
        Me.grdviewMoldes.PaintStyleName = "Web"
        '
        'colId
        '
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colMoldeSerie
        '
        Me.colMoldeSerie.AppearanceCell.Options.UseTextOptions = True
        Me.colMoldeSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoldeSerie.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoldeSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoldeSerie.FieldName = "MoldeSerie"
        Me.colMoldeSerie.Name = "colMoldeSerie"
        Me.colMoldeSerie.Visible = True
        Me.colMoldeSerie.VisibleIndex = 1
        Me.colMoldeSerie.Width = 86
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 314
        '
        'colCavidades
        '
        Me.colCavidades.AppearanceCell.Options.UseTextOptions = True
        Me.colCavidades.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colCavidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidades.FieldName = "Cavidades"
        Me.colCavidades.Name = "colCavidades"
        Me.colCavidades.Visible = True
        Me.colCavidades.VisibleIndex = 3
        '
        'colUnidades
        '
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 4
        '
        'colMaquinaPreferencial
        '
        Me.colMaquinaPreferencial.AppearanceCell.Options.UseTextOptions = True
        Me.colMaquinaPreferencial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquinaPreferencial.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquinaPreferencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquinaPreferencial.FieldName = "MaquinaPreferencial"
        Me.colMaquinaPreferencial.Name = "colMaquinaPreferencial"
        Me.colMaquinaPreferencial.Visible = True
        Me.colMaquinaPreferencial.VisibleIndex = 5
        '
        'colBodega
        '
        Me.colBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.ColumnEdit = Me.rslueBodega
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 6
        '
        'rslueBodega
        '
        Me.rslueBodega.AutoHeight = False
        Me.rslueBodega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueBodega.Name = "rslueBodega"
        Me.rslueBodega.NullText = ""
        Me.rslueBodega.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colUbicacion
        '
        Me.colUbicacion.AppearanceCell.Options.UseTextOptions = True
        Me.colUbicacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUbicacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colUbicacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        Me.colUbicacion.Visible = True
        Me.colUbicacion.VisibleIndex = 7
        '
        'colUbicacionFecha
        '
        Me.colUbicacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colUbicacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUbicacionFecha.FieldName = "UbicacionFecha"
        Me.colUbicacionFecha.Name = "colUbicacionFecha"
        Me.colUbicacionFecha.Visible = True
        Me.colUbicacionFecha.VisibleIndex = 8
        '
        'colMantenimiento
        '
        Me.colMantenimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colMantenimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMantenimiento.FieldName = "Mantenimiento"
        Me.colMantenimiento.Name = "colMantenimiento"
        Me.colMantenimiento.Visible = True
        Me.colMantenimiento.VisibleIndex = 9
        '
        'colMantenimientoFecha
        '
        Me.colMantenimientoFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colMantenimientoFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMantenimientoFecha.FieldName = "MantenimientoFecha"
        Me.colMantenimientoFecha.Name = "colMantenimientoFecha"
        Me.colMantenimientoFecha.Visible = True
        Me.colMantenimientoFecha.VisibleIndex = 10
        '
        'colPorcIneficiencia
        '
        Me.colPorcIneficiencia.FieldName = "PorcIneficiencia"
        Me.colPorcIneficiencia.Name = "colPorcIneficiencia"
        Me.colPorcIneficiencia.Visible = True
        Me.colPorcIneficiencia.VisibleIndex = 11
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 13
        Me.colComentarios.Width = 188
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 12
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        '
        'rmmeComentarios1
        '
        Me.rmmeComentarios1.AutoHeight = False
        Me.rmmeComentarios1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rmmeComentarios1.Name = "rmmeComentarios1"
        '
        'vgrdMoldes
        '
        Me.vgrdMoldes.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.vgrdMoldes.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.vgrdMoldes.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdMoldes.Appearance.Category.ForeColor = System.Drawing.Color.White
        Me.vgrdMoldes.Appearance.Category.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdMoldes.Appearance.Category.Options.UseFont = True
        Me.vgrdMoldes.Appearance.Category.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.vgrdMoldes.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.vgrdMoldes.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdMoldes.Appearance.DisabledRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.vgrdMoldes.Appearance.DisabledRow.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes.Appearance.DisabledRow.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.DisabledRow.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.vgrdMoldes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgrdMoldes.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.vgrdMoldes.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.vgrdMoldes.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdMoldes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdMoldes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.vgrdMoldes.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.vgrdMoldes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdMoldes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.vgrdMoldes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.vgrdMoldes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.vgrdMoldes.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.vgrdMoldes.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.vgrdMoldes.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.vgrdMoldes.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdMoldes.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdMoldes.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdMoldes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.vgrdMoldes.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdMoldes.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.vgrdMoldes.DataMember = "dsdtMoldes_Seleccion"
        Me.vgrdMoldes.DataSource = Me.DsMoldes1
        Me.vgrdMoldes.Location = New System.Drawing.Point(16, 103)
        Me.vgrdMoldes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vgrdMoldes.MaximumSize = New System.Drawing.Size(500, 0)
        Me.vgrdMoldes.MinimumSize = New System.Drawing.Size(500, 0)
        Me.vgrdMoldes.Name = "vgrdMoldes"
        Me.vgrdMoldes.RecordWidth = 225
        Me.vgrdMoldes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueMaquinas, Me.vrslueBodegas, Me.rmmeComentarios, Me.rmmeComentario})
        Me.vgrdMoldes.RowHeaderWidth = 141
        Me.vgrdMoldes.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowId, Me.rowNombre, Me.rowCavidades, Me.rowUnidades, Me.rowMaquinaPreferencial, Me.rowBodega, Me.rowUbicacion, Me.rowUbicacionFecha, Me.rowMoldeSerie, Me.rowMantenimiento, Me.rowMantenimientoFecha, Me.rowComentarios, Me.rowEstatus, Me.rowBit_CreacionUsuario1, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario1, Me.rowBit_ModificacionFecha1, Me.rowPorcIneficiencia})
        Me.vgrdMoldes.Size = New System.Drawing.Size(500, 573)
        Me.vgrdMoldes.TabIndex = 5
        '
        'rslueMaquinas
        '
        Me.rslueMaquinas.AutoHeight = False
        Me.rslueMaquinas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueMaquinas.Name = "rslueMaquinas"
        Me.rslueMaquinas.NullText = ""
        Me.rslueMaquinas.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'vrslueBodegas
        '
        Me.vrslueBodegas.AutoHeight = False
        Me.vrslueBodegas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueBodegas.Name = "vrslueBodegas"
        Me.vrslueBodegas.NullText = ""
        Me.vrslueBodegas.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'rmmeComentarios
        '
        Me.rmmeComentarios.AutoHeight = False
        Me.rmmeComentarios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rmmeComentarios.Name = "rmmeComentarios"
        Me.rmmeComentarios.ValidateOnEnterKey = True
        '
        'rmmeComentario
        '
        Me.rmmeComentario.Name = "rmmeComentario"
        '
        'rowId
        '
        Me.rowId.Name = "rowId"
        Me.rowId.Properties.Caption = "Id"
        Me.rowId.Properties.FieldName = "Id"
        '
        'rowNombre
        '
        Me.rowNombre.Name = "rowNombre"
        Me.rowNombre.Properties.Caption = "Nombre"
        Me.rowNombre.Properties.FieldName = "Nombre"
        '
        'rowCavidades
        '
        Me.rowCavidades.Name = "rowCavidades"
        Me.rowCavidades.Properties.Caption = "Cavidades"
        Me.rowCavidades.Properties.FieldName = "Cavidades"
        '
        'rowUnidades
        '
        Me.rowUnidades.Name = "rowUnidades"
        Me.rowUnidades.Properties.Caption = "Unidades"
        Me.rowUnidades.Properties.FieldName = "Unidades"
        '
        'rowMaquinaPreferencial
        '
        Me.rowMaquinaPreferencial.Name = "rowMaquinaPreferencial"
        Me.rowMaquinaPreferencial.Properties.Caption = "Maquina Preferencial"
        Me.rowMaquinaPreferencial.Properties.FieldName = "MaquinaPreferencial"
        '
        'rowBodega
        '
        Me.rowBodega.Name = "rowBodega"
        Me.rowBodega.Properties.Caption = "Bodega"
        Me.rowBodega.Properties.FieldName = "Bodega"
        '
        'rowUbicacion
        '
        Me.rowUbicacion.Name = "rowUbicacion"
        Me.rowUbicacion.Properties.Caption = "Ubicacion"
        Me.rowUbicacion.Properties.FieldName = "Ubicacion"
        '
        'rowUbicacionFecha
        '
        Me.rowUbicacionFecha.Name = "rowUbicacionFecha"
        Me.rowUbicacionFecha.Properties.Caption = "Ubicacion Fecha"
        Me.rowUbicacionFecha.Properties.FieldName = "UbicacionFecha"
        '
        'rowMoldeSerie
        '
        Me.rowMoldeSerie.Name = "rowMoldeSerie"
        Me.rowMoldeSerie.Properties.Caption = "Molde Serie"
        Me.rowMoldeSerie.Properties.FieldName = "MoldeSerie"
        '
        'rowMantenimiento
        '
        Me.rowMantenimiento.Name = "rowMantenimiento"
        Me.rowMantenimiento.Properties.Caption = "Mantenimiento"
        Me.rowMantenimiento.Properties.FieldName = "Mantenimiento"
        '
        'rowMantenimientoFecha
        '
        Me.rowMantenimientoFecha.Name = "rowMantenimientoFecha"
        Me.rowMantenimientoFecha.Properties.Caption = "Mantenimiento Fecha"
        Me.rowMantenimientoFecha.Properties.FieldName = "MantenimientoFecha"
        '
        'rowComentarios
        '
        Me.rowComentarios.Name = "rowComentarios"
        Me.rowComentarios.Properties.Caption = "Comentarios"
        Me.rowComentarios.Properties.FieldName = "Comentarios"
        '
        'rowEstatus
        '
        Me.rowEstatus.Name = "rowEstatus"
        Me.rowEstatus.Properties.Caption = "Estatus"
        Me.rowEstatus.Properties.FieldName = "Estatus"
        '
        'rowBit_CreacionUsuario1
        '
        Me.rowBit_CreacionUsuario1.Name = "rowBit_CreacionUsuario1"
        Me.rowBit_CreacionUsuario1.Properties.Caption = "Bit_Creacion Usuario"
        Me.rowBit_CreacionUsuario1.Properties.FieldName = "Bit_CreacionUsuario"
        Me.rowBit_CreacionUsuario1.Visible = False
        '
        'rowBit_CreacionFecha
        '
        Me.rowBit_CreacionFecha.Name = "rowBit_CreacionFecha"
        Me.rowBit_CreacionFecha.Properties.Caption = "Bit_Creacion Fecha"
        Me.rowBit_CreacionFecha.Properties.FieldName = "Bit_CreacionFecha"
        Me.rowBit_CreacionFecha.Visible = False
        '
        'rowBit_ModificacionUsuario1
        '
        Me.rowBit_ModificacionUsuario1.Name = "rowBit_ModificacionUsuario1"
        Me.rowBit_ModificacionUsuario1.Properties.Caption = "Bit_Modificacion Usuario"
        Me.rowBit_ModificacionUsuario1.Properties.FieldName = "Bit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario1.Visible = False
        '
        'rowBit_ModificacionFecha1
        '
        Me.rowBit_ModificacionFecha1.Name = "rowBit_ModificacionFecha1"
        Me.rowBit_ModificacionFecha1.Properties.Caption = "Bit_Modificacion Fecha"
        Me.rowBit_ModificacionFecha1.Properties.FieldName = "Bit_ModificacionFecha"
        Me.rowBit_ModificacionFecha1.Visible = False
        '
        'rowPorcIneficiencia
        '
        Me.rowPorcIneficiencia.Name = "rowPorcIneficiencia"
        Me.rowPorcIneficiencia.Properties.FieldName = "PorcIneficiencia"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1483, 692)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdMoldes
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 87)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(506, 579)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdMoldes
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(506, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(951, 666)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.sbdcMenu
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(506, 53)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LabelControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(506, 34)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'rowBit_CreacionUsuario
        '
        Me.rowBit_CreacionUsuario.Name = "rowBit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Properties.Caption = "Bit_Creacion Usuario"
        Me.rowBit_CreacionUsuario.Properties.FieldName = "Bit_CreacionUsuario"
        '
        'rowBit_ModificacionUsuario
        '
        Me.rowBit_ModificacionUsuario.Name = "rowBit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Properties.Caption = "Bit_Modificacion Usuario"
        Me.rowBit_ModificacionUsuario.Properties.FieldName = "Bit_ModificacionUsuario"
        '
        'rowBit_ModificacionFecha
        '
        Me.rowBit_ModificacionFecha.Name = "rowBit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Properties.Caption = "Bit_Modificacion Fecha"
        Me.rowBit_ModificacionFecha.Properties.FieldName = "Bit_ModificacionFecha"
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnActualizarPorcEficiencia, Me.barspinPorcEficiencia})
        Me.BarManager2.MaxItemId = 4
        Me.BarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rbtneditActualizaPorcEficiencia, Me.rspinPorcEficiencia})
        Me.BarManager2.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizarPorcEficiencia, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barspinPorcEficiencia, "", False, True, True, 66)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnActualizarPorcEficiencia
        '
        Me.barbtnActualizarPorcEficiencia.Caption = "Actualizar Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todos los Moldes"
        Me.barbtnActualizarPorcEficiencia.Id = 2
        Me.barbtnActualizarPorcEficiencia.ImageOptions.Image = CType(resources.GetObject("barbtnActualizarPorcEficiencia.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizarPorcEficiencia.Name = "barbtnActualizarPorcEficiencia"
        '
        'barspinPorcEficiencia
        '
        Me.barspinPorcEficiencia.Caption = "PorcEficiencia"
        Me.barspinPorcEficiencia.Edit = Me.rspinPorcEficiencia
        Me.barspinPorcEficiencia.EditHeight = 30
        Me.barspinPorcEficiencia.Id = 3
        Me.barspinPorcEficiencia.Name = "barspinPorcEficiencia"
        '
        'rspinPorcEficiencia
        '
        Me.rspinPorcEficiencia.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.rspinPorcEficiencia.Appearance.Options.UseFont = True
        Me.rspinPorcEficiencia.AutoHeight = False
        Me.rspinPorcEficiencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinPorcEficiencia.IsFloatValue = False
        Me.rspinPorcEficiencia.Mask.EditMask = "N00"
        Me.rspinPorcEficiencia.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.rspinPorcEficiencia.Name = "rspinPorcEficiencia"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BarDockControl1.Size = New System.Drawing.Size(1483, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 692)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BarDockControl2.Size = New System.Drawing.Size(1483, 55)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 692)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1483, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 692)
        '
        'rbtneditActualizaPorcEficiencia
        '
        Me.rbtneditActualizaPorcEficiencia.AutoHeight = False
        Me.rbtneditActualizaPorcEficiencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.rbtneditActualizaPorcEficiencia.DisplayFormat.FormatString = "n0"
        Me.rbtneditActualizaPorcEficiencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rbtneditActualizaPorcEficiencia.EditFormat.FormatString = "n0"
        Me.rbtneditActualizaPorcEficiencia.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rbtneditActualizaPorcEficiencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rbtneditActualizaPorcEficiencia.Mask.UseMaskAsDisplayFormat = True
        Me.rbtneditActualizaPorcEficiencia.Name = "rbtneditActualizaPorcEficiencia"
        '
        'frmMoldes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1483, 747)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMoldes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento - Moldes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMoldes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeComentarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeComentario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinPorcEficiencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtneditActualizaPorcEficiencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents vgrdMoldes As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdMoldes As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsMoldes1 As waProduccion_Pedidos.dsMoldes
    Friend WithEvents grdviewMoldes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCavidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquinaPreferencial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUbicacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoldeSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimientoFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueMaquinas As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents vrslueBodegas As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rmmeComentarios1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents rmmeComentarios As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents rmmeComentario As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents sbdcMenu As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rslueBodega As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowId As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombre As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCavidades As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUnidades As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaquinaPreferencial As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBodega As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUbicacion As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUbicacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMoldeSerie As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMantenimiento As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMantenimientoFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComentarios As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstatus As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowPorcIneficiencia As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents colPorcIneficiencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtneditActualizaPorcEficiencia As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents barbtnActualizarPorcEficiencia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barspinPorcEficiencia As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rspinPorcEficiencia As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
