<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros_Ensambles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros_Ensambles))
        Me.lycParametros_Ensamble = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcParametrosEnsamble = New DevExpress.XtraBars.StandaloneBarDockControl()
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
        Me.vgrdParametrosEnsambles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsParametros_Ensambles1 = New waProduccion_Pedidos.dsParametros_Ensambles()
        Me.rowCodigoArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSegundosXArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMinutosXArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEnsamblesXHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEquipoPersonas = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdParametrosEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.grdviewParametrosEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSegundosXArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinutosXArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnsamblesXHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEquipoPersonas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycgParametrosEnsamble = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycParametros_Ensamble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametros_Ensamble.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdParametrosEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Ensambles1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdParametrosEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewParametrosEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycgParametrosEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametros_Ensamble
        '
        Me.lycParametros_Ensamble.Controls.Add(Me.sbdcParametrosEnsamble)
        Me.lycParametros_Ensamble.Controls.Add(Me.vgrdParametrosEnsambles)
        Me.lycParametros_Ensamble.Controls.Add(Me.grdParametrosEnsamble)
        Me.lycParametros_Ensamble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametros_Ensamble.Location = New System.Drawing.Point(0, 0)
        Me.lycParametros_Ensamble.Name = "lycParametros_Ensamble"
        Me.lycParametros_Ensamble.Root = Me.lycgParametrosEnsamble
        Me.lycParametros_Ensamble.Size = New System.Drawing.Size(1445, 561)
        Me.lycParametros_Ensamble.TabIndex = 0
        Me.lycParametros_Ensamble.Text = "LayoutControl1"
        '
        'sbdcParametrosEnsamble
        '
        Me.sbdcParametrosEnsamble.CausesValidation = False
        Me.sbdcParametrosEnsamble.Location = New System.Drawing.Point(12, 12)
        Me.sbdcParametrosEnsamble.Manager = Me.BarManager1
        Me.sbdcParametrosEnsamble.Name = "sbdcParametrosEnsamble"
        Me.sbdcParametrosEnsamble.Size = New System.Drawing.Size(338, 47)
        Me.sbdcParametrosEnsamble.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcParametrosEnsamble)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnGrabar, Me.barbtnCancelar, Me.barbtnActualizar, Me.barbtnBitacoraModificacion, Me.barbtnImprimirGrid, Me.barbtnBuscar})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnGrabar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBitacoraModificacion, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcParametrosEnsamble
        Me.Bar1.Text = "Tools"
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
        Me.barbtnImprimirGrid.Caption = "Imprimir Grid"
        Me.barbtnImprimirGrid.Id = 5
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 6
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Datos Usuario"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1445, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1445, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 561)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1445, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 561)
        '
        'vgrdParametrosEnsambles
        '
        Me.vgrdParametrosEnsambles.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdParametrosEnsambles.Appearance.Category.ForeColor = System.Drawing.Color.Black
        Me.vgrdParametrosEnsambles.Appearance.Category.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdParametrosEnsambles.Appearance.Category.Options.UseFont = True
        Me.vgrdParametrosEnsambles.Appearance.Category.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdParametrosEnsambles.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgrdParametrosEnsambles.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdParametrosEnsambles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdParametrosEnsambles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdParametrosEnsambles.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdParametrosEnsambles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdParametrosEnsambles.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdParametrosEnsambles.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdParametrosEnsambles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.vgrdParametrosEnsambles.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdParametrosEnsambles.Appearance.VertLine.Options.UseBorderColor = True
        Me.vgrdParametrosEnsambles.DataMember = "dsdtParametrosEnsambleSeleccionada"
        Me.vgrdParametrosEnsambles.DataSource = Me.DsParametros_Ensambles1
        Me.vgrdParametrosEnsambles.Location = New System.Drawing.Point(12, 63)
        Me.vgrdParametrosEnsambles.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdParametrosEnsambles.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdParametrosEnsambles.Name = "vgrdParametrosEnsambles"
        Me.vgrdParametrosEnsambles.RecordWidth = 250
        Me.vgrdParametrosEnsambles.RowHeaderWidth = 125
        Me.vgrdParametrosEnsambles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCodigoArticulo, Me.rowNombreArticulo, Me.rowSegundosXArticulo, Me.rowMinutosXArticulo, Me.rowEnsamblesXHora, Me.rowEquipoPersonas, Me.rowBit_CreacionUsuario, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario, Me.rowBit_ModificacionFecha})
        Me.vgrdParametrosEnsambles.Size = New System.Drawing.Size(375, 486)
        Me.vgrdParametrosEnsambles.TabIndex = 5
        '
        'DsParametros_Ensambles1
        '
        Me.DsParametros_Ensambles1.DataSetName = "dsParametros_Ensambles"
        Me.DsParametros_Ensambles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rowCodigoArticulo
        '
        Me.rowCodigoArticulo.Enabled = False
        Me.rowCodigoArticulo.Name = "rowCodigoArticulo"
        Me.rowCodigoArticulo.Properties.Caption = "Codigo Articulo"
        Me.rowCodigoArticulo.Properties.FieldName = "CodigoArticulo"
        '
        'rowNombreArticulo
        '
        Me.rowNombreArticulo.Enabled = False
        Me.rowNombreArticulo.Name = "rowNombreArticulo"
        Me.rowNombreArticulo.Properties.Caption = "Nombre Articulo"
        Me.rowNombreArticulo.Properties.FieldName = "NombreArticulo"
        '
        'rowSegundosXArticulo
        '
        Me.rowSegundosXArticulo.Appearance.Options.UseTextOptions = True
        Me.rowSegundosXArticulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowSegundosXArticulo.Name = "rowSegundosXArticulo"
        Me.rowSegundosXArticulo.Properties.Caption = "Segundos XArticulo"
        Me.rowSegundosXArticulo.Properties.FieldName = "SegundosXArticulo"
        '
        'rowMinutosXArticulo
        '
        Me.rowMinutosXArticulo.Appearance.Options.UseTextOptions = True
        Me.rowMinutosXArticulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowMinutosXArticulo.Name = "rowMinutosXArticulo"
        Me.rowMinutosXArticulo.Properties.Caption = "Minutos XArticulo"
        Me.rowMinutosXArticulo.Properties.FieldName = "MinutosXArticulo"
        '
        'rowEnsamblesXHora
        '
        Me.rowEnsamblesXHora.Appearance.Options.UseTextOptions = True
        Me.rowEnsamblesXHora.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowEnsamblesXHora.Name = "rowEnsamblesXHora"
        Me.rowEnsamblesXHora.Properties.Caption = "Ensambles XHora"
        Me.rowEnsamblesXHora.Properties.FieldName = "EnsamblesXHora"
        '
        'rowEquipoPersonas
        '
        Me.rowEquipoPersonas.Appearance.Options.UseTextOptions = True
        Me.rowEquipoPersonas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowEquipoPersonas.Name = "rowEquipoPersonas"
        Me.rowEquipoPersonas.Properties.Caption = "Equipo Personas"
        Me.rowEquipoPersonas.Properties.FieldName = "EquipoPersonas"
        '
        'rowBit_CreacionUsuario
        '
        Me.rowBit_CreacionUsuario.Name = "rowBit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Properties.Caption = "Bit_Creacion Usuario"
        Me.rowBit_CreacionUsuario.Properties.FieldName = "Bit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Visible = False
        '
        'rowBit_CreacionFecha
        '
        Me.rowBit_CreacionFecha.Name = "rowBit_CreacionFecha"
        Me.rowBit_CreacionFecha.Properties.Caption = "Bit_Creacion Fecha"
        Me.rowBit_CreacionFecha.Properties.FieldName = "Bit_CreacionFecha"
        Me.rowBit_CreacionFecha.Visible = False
        '
        'rowBit_ModificacionUsuario
        '
        Me.rowBit_ModificacionUsuario.Name = "rowBit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Properties.Caption = "Bit_Modificacion Usuario"
        Me.rowBit_ModificacionUsuario.Properties.FieldName = "Bit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Visible = False
        '
        'rowBit_ModificacionFecha
        '
        Me.rowBit_ModificacionFecha.Name = "rowBit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Properties.Caption = "Bit_Modificacion Fecha"
        Me.rowBit_ModificacionFecha.Properties.FieldName = "Bit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Visible = False
        '
        'grdParametrosEnsamble
        '
        Me.grdParametrosEnsamble.DataMember = "dsdtParametrosEnsamble"
        Me.grdParametrosEnsamble.DataSource = Me.DsParametros_Ensambles1
        Me.grdParametrosEnsamble.Location = New System.Drawing.Point(391, 12)
        Me.grdParametrosEnsamble.MainView = Me.grdviewParametrosEnsamble
        Me.grdParametrosEnsamble.Name = "grdParametrosEnsamble"
        Me.grdParametrosEnsamble.Size = New System.Drawing.Size(1042, 537)
        Me.grdParametrosEnsamble.TabIndex = 4
        Me.grdParametrosEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewParametrosEnsamble})
        '
        'grdviewParametrosEnsamble
        '
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewParametrosEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.Preview.Options.UseFont = True
        Me.grdviewParametrosEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewParametrosEnsamble.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewParametrosEnsamble.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewParametrosEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewParametrosEnsamble.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewParametrosEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colSegundosXArticulo, Me.colMinutosXArticulo, Me.colEnsamblesXHora, Me.colEquipoPersonas, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewParametrosEnsamble.GridControl = Me.grdParametrosEnsamble
        Me.grdviewParametrosEnsamble.Name = "grdviewParametrosEnsamble"
        Me.grdviewParametrosEnsamble.OptionsBehavior.Editable = False
        Me.grdviewParametrosEnsamble.OptionsBehavior.ReadOnly = True
        Me.grdviewParametrosEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewParametrosEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewParametrosEnsamble.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewParametrosEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewParametrosEnsamble.OptionsView.ShowViewCaption = True
        Me.grdviewParametrosEnsamble.PaintStyleName = "UltraFlat"
        Me.grdviewParametrosEnsamble.ViewCaption = "Parametros Estandar de Tiempos de Ensamble"
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
        Me.colCodigoArticulo.VisibleIndex = 0
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
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 350
        '
        'colSegundosXArticulo
        '
        Me.colSegundosXArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colSegundosXArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSegundosXArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSegundosXArticulo.AppearanceHeader.Options.UseFont = True
        Me.colSegundosXArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSegundosXArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSegundosXArticulo.Caption = "Seg. X Articulo"
        Me.colSegundosXArticulo.FieldName = "SegundosXArticulo"
        Me.colSegundosXArticulo.Name = "colSegundosXArticulo"
        Me.colSegundosXArticulo.Visible = True
        Me.colSegundosXArticulo.VisibleIndex = 2
        Me.colSegundosXArticulo.Width = 100
        '
        'colMinutosXArticulo
        '
        Me.colMinutosXArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colMinutosXArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinutosXArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMinutosXArticulo.AppearanceHeader.Options.UseFont = True
        Me.colMinutosXArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMinutosXArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinutosXArticulo.Caption = "Min. X Articulo"
        Me.colMinutosXArticulo.FieldName = "MinutosXArticulo"
        Me.colMinutosXArticulo.Name = "colMinutosXArticulo"
        Me.colMinutosXArticulo.Visible = True
        Me.colMinutosXArticulo.VisibleIndex = 3
        Me.colMinutosXArticulo.Width = 100
        '
        'colEnsamblesXHora
        '
        Me.colEnsamblesXHora.AppearanceCell.Options.UseTextOptions = True
        Me.colEnsamblesXHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsamblesXHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEnsamblesXHora.AppearanceHeader.Options.UseFont = True
        Me.colEnsamblesXHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnsamblesXHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnsamblesXHora.Caption = "Ensamb. X Hora"
        Me.colEnsamblesXHora.FieldName = "EnsamblesXHora"
        Me.colEnsamblesXHora.Name = "colEnsamblesXHora"
        Me.colEnsamblesXHora.Visible = True
        Me.colEnsamblesXHora.VisibleIndex = 4
        Me.colEnsamblesXHora.Width = 100
        '
        'colEquipoPersonas
        '
        Me.colEquipoPersonas.AppearanceCell.Options.UseTextOptions = True
        Me.colEquipoPersonas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEquipoPersonas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEquipoPersonas.AppearanceHeader.Options.UseFont = True
        Me.colEquipoPersonas.AppearanceHeader.Options.UseTextOptions = True
        Me.colEquipoPersonas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEquipoPersonas.FieldName = "EquipoPersonas"
        Me.colEquipoPersonas.Name = "colEquipoPersonas"
        Me.colEquipoPersonas.Visible = True
        Me.colEquipoPersonas.VisibleIndex = 5
        Me.colEquipoPersonas.Width = 100
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Width = 100
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        Me.colBit_CreacionFecha.Width = 100
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Width = 100
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Width = 100
        '
        'lycgParametrosEnsamble
        '
        Me.lycgParametrosEnsamble.CustomizationFormText = "lycgParametrosEnsamble"
        Me.lycgParametrosEnsamble.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycgParametrosEnsamble.GroupBordersVisible = False
        Me.lycgParametrosEnsamble.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.lycgParametrosEnsamble.Location = New System.Drawing.Point(0, 0)
        Me.lycgParametrosEnsamble.Name = "lycgParametrosEnsamble"
        Me.lycgParametrosEnsamble.Size = New System.Drawing.Size(1445, 561)
        Me.lycgParametrosEnsamble.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdParametrosEnsamble
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1046, 541)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdParametrosEnsambles
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 490)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcParametrosEnsamble
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 51)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'frmParametros_Ensambles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 561)
        Me.Controls.Add(Me.lycParametros_Ensamble)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmParametros_Ensambles"
        Me.Text = "Parametros estandar de Tiempos de Ensamble"
        CType(Me.lycParametros_Ensamble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametros_Ensamble.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdParametrosEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Ensambles1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdParametrosEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewParametrosEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycgParametrosEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametros_Ensamble As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents vgrdParametrosEnsambles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents grdParametrosEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewParametrosEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lycgParametrosEnsamble As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcParametrosEnsamble As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Ensambles1 As waProduccion_Pedidos.dsParametros_Ensambles
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSegundosXArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinutosXArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnsamblesXHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEquipoPersonas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowCodigoArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSegundosXArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMinutosXArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEnsamblesXHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEquipoPersonas As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
End Class
