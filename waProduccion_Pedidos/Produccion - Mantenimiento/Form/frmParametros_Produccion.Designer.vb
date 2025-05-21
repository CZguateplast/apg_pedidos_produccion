<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros_Produccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros_Produccion))
        Me.lycParametrosProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcParametrosProduccion = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barParametrosProduccion = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBitacoraModificacion = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.vgrdParametrosProduccion = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsParametros_Produccion1 = New waProduccion_Pedidos.dsParametros_Produccion()
        Me.rowCodigoArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreArticulo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCicloHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPesoInyeccionGrms = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPesoInyeccionVariacionGrms = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCiclo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCicloTurno = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCicloMin = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCicloMax = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowArticulosHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowArticulosTurno = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPesoInyeccionKgs = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRangoPesoGrmsMin = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRangoPesoGrmsMax = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLbHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSacos25KG = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdParametrosProduccion = New DevExpress.XtraGrid.GridControl()
        Me.grdviewParametrosProduccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCiclo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloTurno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloMax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticulosHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticulosTurno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoInyeccionKgs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoInyeccionGrms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRangoPesoGrmsMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRangoPesoGrmsMax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLbHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSacos25KG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycParametrosProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametrosProduccion.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdParametrosProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Produccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdParametrosProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewParametrosProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametrosProduccion
        '
        Me.lycParametrosProduccion.Controls.Add(Me.sbdcParametrosProduccion)
        Me.lycParametrosProduccion.Controls.Add(Me.vgrdParametrosProduccion)
        Me.lycParametrosProduccion.Controls.Add(Me.grdParametrosProduccion)
        Me.lycParametrosProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametrosProduccion.Location = New System.Drawing.Point(0, 0)
        Me.lycParametrosProduccion.Name = "lycParametrosProduccion"
        Me.lycParametrosProduccion.Root = Me.LayoutControlGroup1
        Me.lycParametrosProduccion.Size = New System.Drawing.Size(1270, 566)
        Me.lycParametrosProduccion.TabIndex = 0
        Me.lycParametrosProduccion.Text = "LayoutControl1"
        '
        'sbdcParametrosProduccion
        '
        Me.sbdcParametrosProduccion.CausesValidation = False
        Me.sbdcParametrosProduccion.Location = New System.Drawing.Point(8, 10)
        Me.sbdcParametrosProduccion.Manager = Me.BarManager1
        Me.sbdcParametrosProduccion.Name = "sbdcParametrosProduccion"
        Me.sbdcParametrosProduccion.Size = New System.Drawing.Size(318, 40)
        Me.sbdcParametrosProduccion.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barParametrosProduccion, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcParametrosProduccion)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnCerrar, Me.barbtnGrabar, Me.barbtnCancelar, Me.barbtnActualizar, Me.barbtnImprimirGrid, Me.barbtnBuscar, Me.barbtnBitacoraModificacion})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barParametrosProduccion
        '
        Me.barParametrosProduccion.BarName = "Tools"
        Me.barParametrosProduccion.DockCol = 0
        Me.barParametrosProduccion.DockRow = 0
        Me.barParametrosProduccion.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barParametrosProduccion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnGrabar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBitacoraModificacion)})
        Me.barParametrosProduccion.OptionsBar.AllowQuickCustomization = False
        Me.barParametrosProduccion.OptionsBar.DrawBorder = False
        Me.barParametrosProduccion.OptionsBar.DrawDragBorder = False
        Me.barParametrosProduccion.StandaloneBarDockControl = Me.sbdcParametrosProduccion
        Me.barParametrosProduccion.Text = "Tools"
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
        Me.barbtnGrabar.Id = 3
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
        '
        'barbtnCancelar
        '
        Me.barbtnCancelar.Caption = "Cancelar"
        Me.barbtnCancelar.Id = 4
        Me.barbtnCancelar.ImageOptions.Image = CType(resources.GetObject("barbtnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCancelar.Name = "barbtnCancelar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 5
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir Grid"
        Me.barbtnImprimirGrid.Id = 6
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 7
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Bitacora Usuario"
        Me.barbtnBitacoraModificacion.Id = 8
        Me.barbtnBitacoraModificacion.ImageOptions.Image = CType(resources.GetObject("barbtnBitacoraModificacion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBitacoraModificacion.Name = "barbtnBitacoraModificacion"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 2
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1270, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1270, 42)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1270, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'vgrdParametrosProduccion
        '
        Me.vgrdParametrosProduccion.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black
        Me.vgrdParametrosProduccion.Appearance.ReadOnlyRow.Options.UseForeColor = True
        Me.vgrdParametrosProduccion.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.vgrdParametrosProduccion.DataMember = "dsdtParametrosProduccionSeleccion"
        Me.vgrdParametrosProduccion.DataSource = Me.DsParametros_Produccion1
        Me.vgrdParametrosProduccion.Location = New System.Drawing.Point(8, 54)
        Me.vgrdParametrosProduccion.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdParametrosProduccion.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdParametrosProduccion.Name = "vgrdParametrosProduccion"
        Me.vgrdParametrosProduccion.RecordWidth = 206
        Me.vgrdParametrosProduccion.RowHeaderWidth = 158
        Me.vgrdParametrosProduccion.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCodigoArticulo, Me.rowNombreArticulo, Me.rowCicloHora, Me.rowPesoInyeccionGrms, Me.rowPesoInyeccionVariacionGrms, Me.rowCiclo, Me.rowCicloTurno, Me.rowCicloMin, Me.rowCicloMax, Me.rowArticulosHora, Me.rowArticulosTurno, Me.rowPesoInyeccionKgs, Me.rowRangoPesoGrmsMin, Me.rowRangoPesoGrmsMax, Me.rowLbHora, Me.rowSacos25KG, Me.rowBit_CreacionUsuario, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario, Me.rowBit_ModificacionFecha})
        Me.vgrdParametrosProduccion.Size = New System.Drawing.Size(375, 502)
        Me.vgrdParametrosProduccion.TabIndex = 5
        '
        'DsParametros_Produccion1
        '
        Me.DsParametros_Produccion1.DataSetName = "dsParametros_Produccion"
        Me.DsParametros_Produccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.rowNombreArticulo.Properties.ReadOnly = True
        '
        'rowCicloHora
        '
        Me.rowCicloHora.Height = 16
        Me.rowCicloHora.Name = "rowCicloHora"
        Me.rowCicloHora.Properties.Caption = "Ciclo Hora"
        Me.rowCicloHora.Properties.FieldName = "CicloHora"
        Me.rowCicloHora.Properties.ReadOnly = False
        '
        'rowPesoInyeccionGrms
        '
        Me.rowPesoInyeccionGrms.Name = "rowPesoInyeccionGrms"
        Me.rowPesoInyeccionGrms.Properties.Caption = "Peso Unitario Gramos"
        Me.rowPesoInyeccionGrms.Properties.FieldName = "PesoInyeccionGrms"
        Me.rowPesoInyeccionGrms.Properties.ReadOnly = False
        '
        'rowPesoInyeccionVariacionGrms
        '
        Me.rowPesoInyeccionVariacionGrms.Height = 16
        Me.rowPesoInyeccionVariacionGrms.Name = "rowPesoInyeccionVariacionGrms"
        Me.rowPesoInyeccionVariacionGrms.Properties.Caption = "PesoInyeccionVariacionGrms"
        Me.rowPesoInyeccionVariacionGrms.Properties.FieldName = "PesoInyeccionVariacionGrms"
        Me.rowPesoInyeccionVariacionGrms.Properties.ReadOnly = False
        '
        'rowCiclo
        '
        Me.rowCiclo.Enabled = False
        Me.rowCiclo.Height = 16
        Me.rowCiclo.Name = "rowCiclo"
        Me.rowCiclo.Properties.Caption = "Ciclo"
        Me.rowCiclo.Properties.FieldName = "Ciclo"
        Me.rowCiclo.Properties.ReadOnly = True
        '
        'rowCicloTurno
        '
        Me.rowCicloTurno.Enabled = False
        Me.rowCicloTurno.Name = "rowCicloTurno"
        Me.rowCicloTurno.Properties.Caption = "Ciclo Turno"
        Me.rowCicloTurno.Properties.FieldName = "CicloTurno"
        Me.rowCicloTurno.Properties.ReadOnly = True
        '
        'rowCicloMin
        '
        Me.rowCicloMin.Enabled = False
        Me.rowCicloMin.Name = "rowCicloMin"
        Me.rowCicloMin.Properties.Caption = "Ciclo Min"
        Me.rowCicloMin.Properties.FieldName = "CicloMin"
        Me.rowCicloMin.Properties.ReadOnly = True
        '
        'rowCicloMax
        '
        Me.rowCicloMax.Enabled = False
        Me.rowCicloMax.Height = 16
        Me.rowCicloMax.Name = "rowCicloMax"
        Me.rowCicloMax.Properties.Caption = "Ciclo Max"
        Me.rowCicloMax.Properties.FieldName = "CicloMax"
        Me.rowCicloMax.Properties.ReadOnly = True
        '
        'rowArticulosHora
        '
        Me.rowArticulosHora.Enabled = False
        Me.rowArticulosHora.Name = "rowArticulosHora"
        Me.rowArticulosHora.Properties.Caption = "Articulos Hora"
        Me.rowArticulosHora.Properties.FieldName = "ArticulosHora"
        Me.rowArticulosHora.Properties.ReadOnly = True
        '
        'rowArticulosTurno
        '
        Me.rowArticulosTurno.Enabled = False
        Me.rowArticulosTurno.Name = "rowArticulosTurno"
        Me.rowArticulosTurno.Properties.Caption = "Articulos Turno"
        Me.rowArticulosTurno.Properties.FieldName = "ArticulosTurno"
        Me.rowArticulosTurno.Properties.ReadOnly = True
        '
        'rowPesoInyeccionKgs
        '
        Me.rowPesoInyeccionKgs.Enabled = False
        Me.rowPesoInyeccionKgs.Name = "rowPesoInyeccionKgs"
        Me.rowPesoInyeccionKgs.Properties.Caption = "Peso Inyeccion Kgs"
        Me.rowPesoInyeccionKgs.Properties.FieldName = "PesoInyeccionKgs"
        Me.rowPesoInyeccionKgs.Properties.ReadOnly = True
        '
        'rowRangoPesoGrmsMin
        '
        Me.rowRangoPesoGrmsMin.Enabled = False
        Me.rowRangoPesoGrmsMin.Name = "rowRangoPesoGrmsMin"
        Me.rowRangoPesoGrmsMin.Properties.Caption = "Rango Peso Grms Min"
        Me.rowRangoPesoGrmsMin.Properties.FieldName = "RangoPesoGrmsMin"
        Me.rowRangoPesoGrmsMin.Properties.ReadOnly = True
        '
        'rowRangoPesoGrmsMax
        '
        Me.rowRangoPesoGrmsMax.Enabled = False
        Me.rowRangoPesoGrmsMax.Name = "rowRangoPesoGrmsMax"
        Me.rowRangoPesoGrmsMax.Properties.Caption = "Rango Peso Grms Max"
        Me.rowRangoPesoGrmsMax.Properties.FieldName = "RangoPesoGrmsMax"
        Me.rowRangoPesoGrmsMax.Properties.ReadOnly = True
        '
        'rowLbHora
        '
        Me.rowLbHora.Enabled = False
        Me.rowLbHora.Name = "rowLbHora"
        Me.rowLbHora.Properties.Caption = "Lb Hora"
        Me.rowLbHora.Properties.FieldName = "LbHora"
        Me.rowLbHora.Properties.ReadOnly = True
        '
        'rowSacos25KG
        '
        Me.rowSacos25KG.Enabled = False
        Me.rowSacos25KG.Name = "rowSacos25KG"
        Me.rowSacos25KG.Properties.Caption = "Sacos25KG"
        Me.rowSacos25KG.Properties.FieldName = "Sacos25KG"
        Me.rowSacos25KG.Properties.ReadOnly = True
        '
        'rowBit_CreacionUsuario
        '
        Me.rowBit_CreacionUsuario.Enabled = False
        Me.rowBit_CreacionUsuario.Name = "rowBit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Properties.Caption = "Bit_Creacion Usuario"
        Me.rowBit_CreacionUsuario.Properties.FieldName = "Bit_CreacionUsuario"
        Me.rowBit_CreacionUsuario.Visible = False
        '
        'rowBit_CreacionFecha
        '
        Me.rowBit_CreacionFecha.Enabled = False
        Me.rowBit_CreacionFecha.Name = "rowBit_CreacionFecha"
        Me.rowBit_CreacionFecha.Properties.Caption = "Bit_Creacion Fecha"
        Me.rowBit_CreacionFecha.Properties.FieldName = "Bit_CreacionFecha"
        Me.rowBit_CreacionFecha.Visible = False
        '
        'rowBit_ModificacionUsuario
        '
        Me.rowBit_ModificacionUsuario.Enabled = False
        Me.rowBit_ModificacionUsuario.Name = "rowBit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Properties.Caption = "Bit_Modificacion Usuario"
        Me.rowBit_ModificacionUsuario.Properties.FieldName = "Bit_ModificacionUsuario"
        Me.rowBit_ModificacionUsuario.Visible = False
        '
        'rowBit_ModificacionFecha
        '
        Me.rowBit_ModificacionFecha.Enabled = False
        Me.rowBit_ModificacionFecha.Name = "rowBit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Properties.Caption = "Bit_Modificacion Fecha"
        Me.rowBit_ModificacionFecha.Properties.FieldName = "Bit_ModificacionFecha"
        Me.rowBit_ModificacionFecha.Visible = False
        '
        'grdParametrosProduccion
        '
        Me.grdParametrosProduccion.DataMember = "dsdtParametrosProduccion"
        Me.grdParametrosProduccion.DataSource = Me.DsParametros_Produccion1
        Me.grdParametrosProduccion.Location = New System.Drawing.Point(385, 10)
        Me.grdParametrosProduccion.MainView = Me.grdviewParametrosProduccion
        Me.grdParametrosProduccion.Name = "grdParametrosProduccion"
        Me.grdParametrosProduccion.Size = New System.Drawing.Size(877, 546)
        Me.grdParametrosProduccion.TabIndex = 4
        Me.grdParametrosProduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewParametrosProduccion})
        '
        'grdviewParametrosProduccion
        '
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.grdviewParametrosProduccion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewParametrosProduccion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.grdviewParametrosProduccion.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewParametrosProduccion.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewParametrosProduccion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.Preview.ForeColor = System.Drawing.Color.Navy
        Me.grdviewParametrosProduccion.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewParametrosProduccion.Appearance.Row.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.Row.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewParametrosProduccion.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewParametrosProduccion.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewParametrosProduccion.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewParametrosProduccion.ColumnPanelRowHeight = 35
        Me.grdviewParametrosProduccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCiclo, Me.colCicloHora, Me.colCicloTurno, Me.colCicloMin, Me.colCicloMax, Me.colArticulosHora, Me.colArticulosTurno, Me.colPesoInyeccionKgs, Me.colPesoInyeccionGrms, Me.colRangoPesoGrmsMin, Me.colRangoPesoGrmsMax, Me.colLbHora, Me.colSacos25KG, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewParametrosProduccion.GridControl = Me.grdParametrosProduccion
        Me.grdviewParametrosProduccion.Name = "grdviewParametrosProduccion"
        Me.grdviewParametrosProduccion.OptionsBehavior.Editable = False
        Me.grdviewParametrosProduccion.OptionsBehavior.ReadOnly = True
        Me.grdviewParametrosProduccion.OptionsView.ColumnAutoWidth = False
        Me.grdviewParametrosProduccion.OptionsView.ShowGroupPanel = False
        Me.grdviewParametrosProduccion.PaintStyleName = "Web"
        Me.grdviewParametrosProduccion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBit_CreacionFecha, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigoArticulo
        '
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
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 300
        '
        'colCiclo
        '
        Me.colCiclo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCiclo.AppearanceHeader.Options.UseFont = True
        Me.colCiclo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCiclo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCiclo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCiclo.FieldName = "Ciclo"
        Me.colCiclo.Name = "colCiclo"
        Me.colCiclo.OptionsColumn.ReadOnly = True
        Me.colCiclo.Visible = True
        Me.colCiclo.VisibleIndex = 2
        Me.colCiclo.Width = 70
        '
        'colCicloHora
        '
        Me.colCicloHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCicloHora.AppearanceHeader.Options.UseFont = True
        Me.colCicloHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colCicloHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCicloHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCicloHora.FieldName = "CicloHora"
        Me.colCicloHora.Name = "colCicloHora"
        Me.colCicloHora.OptionsColumn.ReadOnly = True
        Me.colCicloHora.Visible = True
        Me.colCicloHora.VisibleIndex = 3
        Me.colCicloHora.Width = 70
        '
        'colCicloTurno
        '
        Me.colCicloTurno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCicloTurno.AppearanceHeader.Options.UseFont = True
        Me.colCicloTurno.AppearanceHeader.Options.UseTextOptions = True
        Me.colCicloTurno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCicloTurno.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCicloTurno.Caption = "Ciclo Turno"
        Me.colCicloTurno.FieldName = "CicloTurno"
        Me.colCicloTurno.Name = "colCicloTurno"
        Me.colCicloTurno.OptionsColumn.ReadOnly = True
        Me.colCicloTurno.Visible = True
        Me.colCicloTurno.VisibleIndex = 4
        Me.colCicloTurno.Width = 70
        '
        'colCicloMin
        '
        Me.colCicloMin.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCicloMin.AppearanceHeader.Options.UseFont = True
        Me.colCicloMin.AppearanceHeader.Options.UseTextOptions = True
        Me.colCicloMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCicloMin.FieldName = "CicloMin"
        Me.colCicloMin.Name = "colCicloMin"
        Me.colCicloMin.OptionsColumn.ReadOnly = True
        Me.colCicloMin.Visible = True
        Me.colCicloMin.VisibleIndex = 5
        Me.colCicloMin.Width = 70
        '
        'colCicloMax
        '
        Me.colCicloMax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCicloMax.AppearanceHeader.Options.UseFont = True
        Me.colCicloMax.AppearanceHeader.Options.UseTextOptions = True
        Me.colCicloMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCicloMax.FieldName = "CicloMax"
        Me.colCicloMax.Name = "colCicloMax"
        Me.colCicloMax.OptionsColumn.ReadOnly = True
        Me.colCicloMax.Visible = True
        Me.colCicloMax.VisibleIndex = 6
        Me.colCicloMax.Width = 70
        '
        'colArticulosHora
        '
        Me.colArticulosHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colArticulosHora.AppearanceHeader.Options.UseFont = True
        Me.colArticulosHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colArticulosHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colArticulosHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colArticulosHora.FieldName = "ArticulosHora"
        Me.colArticulosHora.Name = "colArticulosHora"
        Me.colArticulosHora.OptionsColumn.ReadOnly = True
        Me.colArticulosHora.Visible = True
        Me.colArticulosHora.VisibleIndex = 7
        Me.colArticulosHora.Width = 70
        '
        'colArticulosTurno
        '
        Me.colArticulosTurno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colArticulosTurno.AppearanceHeader.Options.UseFont = True
        Me.colArticulosTurno.AppearanceHeader.Options.UseTextOptions = True
        Me.colArticulosTurno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colArticulosTurno.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colArticulosTurno.FieldName = "ArticulosTurno"
        Me.colArticulosTurno.Name = "colArticulosTurno"
        Me.colArticulosTurno.OptionsColumn.ReadOnly = True
        Me.colArticulosTurno.Visible = True
        Me.colArticulosTurno.VisibleIndex = 8
        Me.colArticulosTurno.Width = 70
        '
        'colPesoInyeccionKgs
        '
        Me.colPesoInyeccionKgs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPesoInyeccionKgs.AppearanceHeader.Options.UseFont = True
        Me.colPesoInyeccionKgs.AppearanceHeader.Options.UseTextOptions = True
        Me.colPesoInyeccionKgs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPesoInyeccionKgs.FieldName = "PesoInyeccionKgs"
        Me.colPesoInyeccionKgs.Name = "colPesoInyeccionKgs"
        Me.colPesoInyeccionKgs.OptionsColumn.ReadOnly = True
        Me.colPesoInyeccionKgs.Visible = True
        Me.colPesoInyeccionKgs.VisibleIndex = 9
        Me.colPesoInyeccionKgs.Width = 70
        '
        'colPesoInyeccionGrms
        '
        Me.colPesoInyeccionGrms.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPesoInyeccionGrms.AppearanceHeader.Options.UseFont = True
        Me.colPesoInyeccionGrms.AppearanceHeader.Options.UseTextOptions = True
        Me.colPesoInyeccionGrms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPesoInyeccionGrms.FieldName = "PesoInyeccionGrms"
        Me.colPesoInyeccionGrms.Name = "colPesoInyeccionGrms"
        Me.colPesoInyeccionGrms.OptionsColumn.ReadOnly = True
        Me.colPesoInyeccionGrms.Visible = True
        Me.colPesoInyeccionGrms.VisibleIndex = 10
        Me.colPesoInyeccionGrms.Width = 70
        '
        'colRangoPesoGrmsMin
        '
        Me.colRangoPesoGrmsMin.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRangoPesoGrmsMin.AppearanceHeader.Options.UseFont = True
        Me.colRangoPesoGrmsMin.AppearanceHeader.Options.UseTextOptions = True
        Me.colRangoPesoGrmsMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRangoPesoGrmsMin.FieldName = "RangoPesoGrmsMin"
        Me.colRangoPesoGrmsMin.Name = "colRangoPesoGrmsMin"
        Me.colRangoPesoGrmsMin.OptionsColumn.ReadOnly = True
        Me.colRangoPesoGrmsMin.Visible = True
        Me.colRangoPesoGrmsMin.VisibleIndex = 11
        Me.colRangoPesoGrmsMin.Width = 70
        '
        'colRangoPesoGrmsMax
        '
        Me.colRangoPesoGrmsMax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRangoPesoGrmsMax.AppearanceHeader.Options.UseFont = True
        Me.colRangoPesoGrmsMax.AppearanceHeader.Options.UseTextOptions = True
        Me.colRangoPesoGrmsMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRangoPesoGrmsMax.FieldName = "RangoPesoGrmsMax"
        Me.colRangoPesoGrmsMax.Name = "colRangoPesoGrmsMax"
        Me.colRangoPesoGrmsMax.OptionsColumn.ReadOnly = True
        Me.colRangoPesoGrmsMax.Visible = True
        Me.colRangoPesoGrmsMax.VisibleIndex = 12
        Me.colRangoPesoGrmsMax.Width = 70
        '
        'colLbHora
        '
        Me.colLbHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLbHora.AppearanceHeader.Options.UseFont = True
        Me.colLbHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colLbHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLbHora.FieldName = "LbHora"
        Me.colLbHora.Name = "colLbHora"
        Me.colLbHora.OptionsColumn.ReadOnly = True
        Me.colLbHora.Visible = True
        Me.colLbHora.VisibleIndex = 13
        Me.colLbHora.Width = 70
        '
        'colSacos25KG
        '
        Me.colSacos25KG.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSacos25KG.AppearanceHeader.Options.UseFont = True
        Me.colSacos25KG.AppearanceHeader.Options.UseTextOptions = True
        Me.colSacos25KG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSacos25KG.FieldName = "Sacos25KG"
        Me.colSacos25KG.Name = "colSacos25KG"
        Me.colSacos25KG.OptionsColumn.ReadOnly = True
        Me.colSacos25KG.Visible = True
        Me.colSacos25KG.VisibleIndex = 14
        Me.colSacos25KG.Width = 70
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Visible = True
        Me.colBit_CreacionUsuario.VisibleIndex = 15
        Me.colBit_CreacionUsuario.Width = 80
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_CreacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_CreacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        Me.colBit_CreacionFecha.Visible = True
        Me.colBit_CreacionFecha.VisibleIndex = 16
        Me.colBit_CreacionFecha.Width = 80
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Visible = True
        Me.colBit_ModificacionUsuario.VisibleIndex = 17
        Me.colBit_ModificacionUsuario.Width = 80
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseFont = True
        Me.colBit_ModificacionFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colBit_ModificacionFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Visible = True
        Me.colBit_ModificacionFecha.VisibleIndex = 18
        Me.colBit_ModificacionFecha.Width = 80
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1270, 566)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdParametrosProduccion
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(377, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(879, 550)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdParametrosProduccion
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(377, 506)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcParametrosProduccion
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(377, 44)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'frmParametros_Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 608)
        Me.Controls.Add(Me.lycParametrosProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmParametros_Produccion"
        Me.Text = "frmParametrosProduccion"
        CType(Me.lycParametrosProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametrosProduccion.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdParametrosProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Produccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdParametrosProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewParametrosProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametrosProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents vgrdParametrosProduccion As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents grdParametrosProduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewParametrosProduccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcParametrosProduccion As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barParametrosProduccion As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Produccion1 As waProduccion_Pedidos.dsParametros_Produccion
    Friend WithEvents rowCodigoArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreArticulo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCiclo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCicloHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCicloTurno As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCicloMin As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCicloMax As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowArticulosHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowArticulosTurno As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPesoInyeccionKgs As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPesoInyeccionGrms As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRangoPesoGrmsMin As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRangoPesoGrmsMax As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLbHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSacos25KG As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiclo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloTurno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticulosHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticulosTurno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoInyeccionKgs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoInyeccionGrms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRangoPesoGrmsMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRangoPesoGrmsMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLbHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSacos25KG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowPesoInyeccionVariacionGrms As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
