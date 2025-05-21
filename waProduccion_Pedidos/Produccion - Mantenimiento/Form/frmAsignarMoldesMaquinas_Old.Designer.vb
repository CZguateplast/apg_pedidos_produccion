<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarMoldesMaquinas_Old
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarMoldesMaquinas_Old))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.vgrdMoldes_Maquinas = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsAsigMoldes_Maquinas1 = New waProduccion_Pedidos.dsAsigMoldes_Maquinas()
        Me.vrlueMateriales = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rowMolde = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombre = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaquina = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUnidadesXHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowInyeccionesXHora = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCostoHoraNormal = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCostoHoraIncremento = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstatus = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdMoldes_Maquinas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewMoldes_Maquinas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesXHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInyeccionesXHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoHoraNormal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoHoraIncremento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBitacoraModificacion = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.vgrdMoldes_Maquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsigMoldes_Maquinas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrlueMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMoldes_Maquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMoldes_Maquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.StandaloneBarDockControl1)
        Me.LayoutControl1.Controls.Add(Me.vgrdMoldes_Maquinas)
        Me.LayoutControl1.Controls.Add(Me.grdMoldes_Maquinas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1505, 782)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(12, 12)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(375, 47)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'vgrdMoldes_Maquinas
        '
        Me.vgrdMoldes_Maquinas.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdMoldes_Maquinas.Appearance.Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.Category.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdMoldes_Maquinas.Appearance.Category.Options.UseFont = True
        Me.vgrdMoldes_Maquinas.Appearance.Category.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdMoldes_Maquinas.Appearance.CategoryExpandButton.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.DisabledRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.DisabledRow.ForeColor = System.Drawing.Color.White
        Me.vgrdMoldes_Maquinas.Appearance.DisabledRow.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.DisabledRow.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgrdMoldes_Maquinas.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdMoldes_Maquinas.Appearance.ExpandButton.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdMoldes_Maquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes_Maquinas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdMoldes_Maquinas.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdMoldes_Maquinas.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdMoldes_Maquinas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vgrdMoldes_Maquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdMoldes_Maquinas.DataMember = "dsdtAsigMoldes_MaquinasSeleccionado"
        Me.vgrdMoldes_Maquinas.DataSource = Me.DsAsigMoldes_Maquinas1
        Me.vgrdMoldes_Maquinas.Location = New System.Drawing.Point(12, 63)
        Me.vgrdMoldes_Maquinas.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdMoldes_Maquinas.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdMoldes_Maquinas.Name = "vgrdMoldes_Maquinas"
        Me.vgrdMoldes_Maquinas.RecordWidth = 225
        Me.vgrdMoldes_Maquinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.vrlueMateriales})
        Me.vgrdMoldes_Maquinas.RowHeaderWidth = 141
        Me.vgrdMoldes_Maquinas.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowMolde, Me.rowNombre, Me.rowMaquina, Me.rowMaterial1, Me.rowMaterial2, Me.rowUnidadesXHora, Me.rowInyeccionesXHora, Me.rowCostoHoraNormal, Me.rowCostoHoraIncremento, Me.rowEstatus, Me.rowBit_CreacionUsuario, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario, Me.rowBit_ModificacionFecha})
        Me.vgrdMoldes_Maquinas.Size = New System.Drawing.Size(375, 707)
        Me.vgrdMoldes_Maquinas.TabIndex = 5
        '
        'DsAsigMoldes_Maquinas1
        '
        Me.DsAsigMoldes_Maquinas1.DataSetName = "dsAsigMoldes_Maquinas"
        Me.DsAsigMoldes_Maquinas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vrlueMateriales
        '
        Me.vrlueMateriales.AutoHeight = False
        Me.vrlueMateriales.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrlueMateriales.Name = "vrlueMateriales"
        Me.vrlueMateriales.NullText = ""
        Me.vrlueMateriales.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'rowMolde
        '
        Me.rowMolde.Enabled = False
        Me.rowMolde.Name = "rowMolde"
        Me.rowMolde.Properties.Caption = "Molde"
        Me.rowMolde.Properties.FieldName = "Molde"
        '
        'rowNombre
        '
        Me.rowNombre.Enabled = False
        Me.rowNombre.Height = 17
        Me.rowNombre.Name = "rowNombre"
        Me.rowNombre.Properties.Caption = "Nombre"
        Me.rowNombre.Properties.FieldName = "Nombre"
        '
        'rowMaquina
        '
        Me.rowMaquina.Enabled = False
        Me.rowMaquina.Name = "rowMaquina"
        Me.rowMaquina.Properties.Caption = "Maquina"
        Me.rowMaquina.Properties.FieldName = "Maquina"
        '
        'rowMaterial1
        '
        Me.rowMaterial1.Name = "rowMaterial1"
        Me.rowMaterial1.Properties.Caption = "Material1"
        Me.rowMaterial1.Properties.FieldName = "Material1"
        Me.rowMaterial1.Properties.RowEdit = Me.vrlueMateriales
        '
        'rowMaterial2
        '
        Me.rowMaterial2.Name = "rowMaterial2"
        Me.rowMaterial2.Properties.Caption = "Material2"
        Me.rowMaterial2.Properties.FieldName = "Material2"
        Me.rowMaterial2.Properties.RowEdit = Me.vrlueMateriales
        '
        'rowUnidadesXHora
        '
        Me.rowUnidadesXHora.Enabled = False
        Me.rowUnidadesXHora.Name = "rowUnidadesXHora"
        Me.rowUnidadesXHora.Properties.Caption = "Unidades XHora"
        Me.rowUnidadesXHora.Properties.FieldName = "UnidadesXHora"
        '
        'rowInyeccionesXHora
        '
        Me.rowInyeccionesXHora.Enabled = False
        Me.rowInyeccionesXHora.Name = "rowInyeccionesXHora"
        Me.rowInyeccionesXHora.Properties.Caption = "Inyecciones XHora"
        Me.rowInyeccionesXHora.Properties.FieldName = "InyeccionesXHora"
        '
        'rowCostoHoraNormal
        '
        Me.rowCostoHoraNormal.Enabled = False
        Me.rowCostoHoraNormal.Name = "rowCostoHoraNormal"
        Me.rowCostoHoraNormal.Properties.Caption = "Costo Hora Normal"
        Me.rowCostoHoraNormal.Properties.FieldName = "CostoHoraNormal"
        '
        'rowCostoHoraIncremento
        '
        Me.rowCostoHoraIncremento.Enabled = False
        Me.rowCostoHoraIncremento.Name = "rowCostoHoraIncremento"
        Me.rowCostoHoraIncremento.Properties.Caption = "Costo Hora Incremento"
        Me.rowCostoHoraIncremento.Properties.FieldName = "CostoHoraIncremento"
        '
        'rowEstatus
        '
        Me.rowEstatus.Name = "rowEstatus"
        Me.rowEstatus.Properties.Caption = "Estatus"
        Me.rowEstatus.Properties.FieldName = "Estatus"
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
        'grdMoldes_Maquinas
        '
        Me.grdMoldes_Maquinas.DataMember = "dsdtAsigMoldes_Maquinas"
        Me.grdMoldes_Maquinas.DataSource = Me.DsAsigMoldes_Maquinas1
        Me.grdMoldes_Maquinas.Location = New System.Drawing.Point(391, 12)
        Me.grdMoldes_Maquinas.MainView = Me.grdviewMoldes_Maquinas
        Me.grdMoldes_Maquinas.Name = "grdMoldes_Maquinas"
        Me.grdMoldes_Maquinas.Size = New System.Drawing.Size(1102, 758)
        Me.grdMoldes_Maquinas.TabIndex = 4
        Me.grdMoldes_Maquinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMoldes_Maquinas})
        '
        'grdviewMoldes_Maquinas
        '
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes_Maquinas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes_Maquinas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes_Maquinas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes_Maquinas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMoldes_Maquinas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.Preview.Options.UseFont = True
        Me.grdviewMoldes_Maquinas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes_Maquinas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMoldes_Maquinas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes_Maquinas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewMoldes_Maquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMoldes_Maquinas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMolde, Me.colNombre, Me.colMaquina, Me.colMaterial1, Me.colMaterial2, Me.colUnidadesXHora, Me.colInyeccionesXHora, Me.colCostoHoraNormal, Me.colCostoHoraIncremento, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewMoldes_Maquinas.GridControl = Me.grdMoldes_Maquinas
        Me.grdviewMoldes_Maquinas.Name = "grdviewMoldes_Maquinas"
        Me.grdviewMoldes_Maquinas.OptionsBehavior.Editable = False
        Me.grdviewMoldes_Maquinas.OptionsBehavior.ReadOnly = True
        Me.grdviewMoldes_Maquinas.OptionsView.ColumnAutoWidth = False
        Me.grdviewMoldes_Maquinas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMoldes_Maquinas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMoldes_Maquinas.OptionsView.ShowGroupPanel = False
        Me.grdviewMoldes_Maquinas.PaintStyleName = "Web"
        '
        'colMolde
        '
        Me.colMolde.AppearanceCell.Options.UseTextOptions = True
        Me.colMolde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMolde.AppearanceHeader.Options.UseFont = True
        Me.colMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.FieldName = "Molde"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Visible = True
        Me.colMolde.VisibleIndex = 0
        Me.colMolde.Width = 80
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 300
        '
        'colMaquina
        '
        Me.colMaquina.AppearanceCell.Options.UseTextOptions = True
        Me.colMaquina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquina.AppearanceHeader.Options.UseFont = True
        Me.colMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.FieldName = "Maquina"
        Me.colMaquina.Name = "colMaquina"
        Me.colMaquina.Visible = True
        Me.colMaquina.VisibleIndex = 2
        Me.colMaquina.Width = 80
        '
        'colMaterial1
        '
        Me.colMaterial1.AppearanceCell.Options.UseTextOptions = True
        Me.colMaterial1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1.FieldName = "Material1"
        Me.colMaterial1.Name = "colMaterial1"
        Me.colMaterial1.Visible = True
        Me.colMaterial1.VisibleIndex = 3
        Me.colMaterial1.Width = 100
        '
        'colMaterial2
        '
        Me.colMaterial2.AppearanceCell.Options.UseTextOptions = True
        Me.colMaterial2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial2.AppearanceHeader.Options.UseFont = True
        Me.colMaterial2.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial2.FieldName = "Material2"
        Me.colMaterial2.Name = "colMaterial2"
        Me.colMaterial2.Visible = True
        Me.colMaterial2.VisibleIndex = 4
        Me.colMaterial2.Width = 100
        '
        'colUnidadesXHora
        '
        Me.colUnidadesXHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidadesXHora.AppearanceHeader.Options.UseFont = True
        Me.colUnidadesXHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesXHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesXHora.FieldName = "UnidadesXHora"
        Me.colUnidadesXHora.Name = "colUnidadesXHora"
        Me.colUnidadesXHora.Visible = True
        Me.colUnidadesXHora.VisibleIndex = 5
        Me.colUnidadesXHora.Width = 120
        '
        'colInyeccionesXHora
        '
        Me.colInyeccionesXHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInyeccionesXHora.AppearanceHeader.Options.UseFont = True
        Me.colInyeccionesXHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionesXHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionesXHora.FieldName = "InyeccionesXHora"
        Me.colInyeccionesXHora.Name = "colInyeccionesXHora"
        Me.colInyeccionesXHora.Visible = True
        Me.colInyeccionesXHora.VisibleIndex = 6
        Me.colInyeccionesXHora.Width = 130
        '
        'colCostoHoraNormal
        '
        Me.colCostoHoraNormal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoHoraNormal.AppearanceHeader.Options.UseFont = True
        Me.colCostoHoraNormal.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoHoraNormal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoHoraNormal.FieldName = "CostoHoraNormal"
        Me.colCostoHoraNormal.Name = "colCostoHoraNormal"
        Me.colCostoHoraNormal.Visible = True
        Me.colCostoHoraNormal.VisibleIndex = 7
        Me.colCostoHoraNormal.Width = 125
        '
        'colCostoHoraIncremento
        '
        Me.colCostoHoraIncremento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostoHoraIncremento.AppearanceHeader.Options.UseFont = True
        Me.colCostoHoraIncremento.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoHoraIncremento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoHoraIncremento.FieldName = "CostoHoraIncremento"
        Me.colCostoHoraIncremento.Name = "colCostoHoraIncremento"
        Me.colCostoHoraIncremento.Visible = True
        Me.colCostoHoraIncremento.VisibleIndex = 8
        Me.colCostoHoraIncremento.Width = 125
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus.AppearanceHeader.Options.UseFont = True
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 9
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1505, 782)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdMoldes_Maquinas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1106, 762)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdMoldes_Maquinas
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 711)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.StandaloneBarDockControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 51)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnActualizar, Me.barbtnImprimir, Me.barbtnBuscar, Me.barbtnBitacoraModificacion})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBitacoraModificacion)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Glyph = CType(resources.GetObject("barbtnAgregar.Glyph"), System.Drawing.Image)
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Glyph = CType(resources.GetObject("barbtnActualizar.Glyph"), System.Drawing.Image)
        Me.barbtnActualizar.Id = 3
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Glyph = CType(resources.GetObject("barbtnBuscar.Glyph"), System.Drawing.Image)
        Me.barbtnBuscar.Id = 5
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimir
        '
        Me.barbtnImprimir.Caption = "Imprimir"
        Me.barbtnImprimir.Glyph = CType(resources.GetObject("barbtnImprimir.Glyph"), System.Drawing.Image)
        Me.barbtnImprimir.Id = 4
        Me.barbtnImprimir.Name = "barbtnImprimir"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Usuario"
        Me.barbtnBitacoraModificacion.Glyph = CType(resources.GetObject("barbtnBitacoraModificacion.Glyph"), System.Drawing.Image)
        Me.barbtnBitacoraModificacion.Id = 6
        Me.barbtnBitacoraModificacion.Name = "barbtnBitacoraModificacion"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1505, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 782)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1505, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 782)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1505, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 782)
        '
        'frmAsignarMoldesMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 782)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmAsignarMoldesMaquinas"
        Me.Text = "Asignacion de Moldes / Maquinas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.vgrdMoldes_Maquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsigMoldes_Maquinas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrlueMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMoldes_Maquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMoldes_Maquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents vgrdMoldes_Maquinas As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents grdMoldes_Maquinas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMoldes_Maquinas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsAsigMoldes_Maquinas1 As waProduccion_Pedidos.dsAsigMoldes_Maquinas
    Friend WithEvents colMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesXHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionesXHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoHoraNormal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoHoraIncremento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowMolde As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaquina As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUnidadesXHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowInyeccionesXHora As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCostoHoraNormal As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCostoHoraIncremento As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstatus As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents vrlueMateriales As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowNombre As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
