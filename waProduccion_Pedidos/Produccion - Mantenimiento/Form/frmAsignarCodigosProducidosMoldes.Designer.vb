<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCodigosProducidosMoldes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarCodigosProducidosMoldes))
        Me.lycAsignacionCodigosProducidosMoldes = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcMenu = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.vgrdCP_Moldes = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsAsigCP_Moldes1 = New waProduccion_Pedidos.dsAsigCP_Moldes()
        Me.vrslueMolde = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vrslueMateriales = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rowId = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDescripcion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial1Porc = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial2Porc = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMaterial3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMolde = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombre = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstatus = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_CreacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBit_ModificacionFecha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdCP_Moldes = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCP_Moldes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial1Porc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial2Porc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycgCP_Moldes = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycMenu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBitacoraModificacion = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycAsignacionCodigosProducidosMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAsignacionCodigosProducidosMoldes.SuspendLayout()
        CType(Me.vgrdCP_Moldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsigCP_Moldes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueMolde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCP_Moldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCP_Moldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycgCP_Moldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycAsignacionCodigosProducidosMoldes
        '
        Me.lycAsignacionCodigosProducidosMoldes.Controls.Add(Me.sbdcMenu)
        Me.lycAsignacionCodigosProducidosMoldes.Controls.Add(Me.vgrdCP_Moldes)
        Me.lycAsignacionCodigosProducidosMoldes.Controls.Add(Me.grdCP_Moldes)
        Me.lycAsignacionCodigosProducidosMoldes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAsignacionCodigosProducidosMoldes.Location = New System.Drawing.Point(0, 0)
        Me.lycAsignacionCodigosProducidosMoldes.Name = "lycAsignacionCodigosProducidosMoldes"
        Me.lycAsignacionCodigosProducidosMoldes.Root = Me.lycgCP_Moldes
        Me.lycAsignacionCodigosProducidosMoldes.Size = New System.Drawing.Size(1439, 742)
        Me.lycAsignacionCodigosProducidosMoldes.TabIndex = 0
        Me.lycAsignacionCodigosProducidosMoldes.Text = "LayoutControl1"
        '
        'sbdcMenu
        '
        Me.sbdcMenu.CausesValidation = False
        Me.sbdcMenu.Location = New System.Drawing.Point(12, 12)
        Me.sbdcMenu.Manager = Me.BarManager1
        Me.sbdcMenu.Name = "sbdcMenu"
        Me.sbdcMenu.Size = New System.Drawing.Size(338, 47)
        Me.sbdcMenu.Text = "StandaloneBarDockControl1"
        '
        'vgrdCP_Moldes
        '
        Me.vgrdCP_Moldes.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdCP_Moldes.Appearance.Category.ForeColor = System.Drawing.Color.Black
        Me.vgrdCP_Moldes.Appearance.Category.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.Category.Options.UseFont = True
        Me.vgrdCP_Moldes.Appearance.Category.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgrdCP_Moldes.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdCP_Moldes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdCP_Moldes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdCP_Moldes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdCP_Moldes.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdCP_Moldes.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdCP_Moldes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vgrdCP_Moldes.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdCP_Moldes.DataMember = "dsdtCodigosProducidosSeleccionado"
        Me.vgrdCP_Moldes.DataSource = Me.DsAsigCP_Moldes1
        Me.vgrdCP_Moldes.Location = New System.Drawing.Point(12, 63)
        Me.vgrdCP_Moldes.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdCP_Moldes.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdCP_Moldes.Name = "vgrdCP_Moldes"
        Me.vgrdCP_Moldes.RecordWidth = 225
        Me.vgrdCP_Moldes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.vrslueMolde, Me.vrslueMateriales})
        Me.vgrdCP_Moldes.RowHeaderWidth = 95
        Me.vgrdCP_Moldes.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowId, Me.rowDescripcion, Me.rowMaterial1, Me.rowMaterial1Porc, Me.rowMaterial2, Me.rowMaterial2Porc, Me.rowMaterial3, Me.rowMolde, Me.rowNombre, Me.rowEstatus, Me.rowBit_CreacionUsuario, Me.rowBit_CreacionFecha, Me.rowBit_ModificacionUsuario, Me.rowBit_ModificacionFecha})
        Me.vgrdCP_Moldes.Size = New System.Drawing.Size(375, 667)
        Me.vgrdCP_Moldes.TabIndex = 5
        '
        'DsAsigCP_Moldes1
        '
        Me.DsAsigCP_Moldes1.DataSetName = "dsAsigCP_Moldes"
        Me.DsAsigCP_Moldes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vrslueMolde
        '
        Me.vrslueMolde.AutoHeight = False
        Me.vrslueMolde.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueMolde.Name = "vrslueMolde"
        Me.vrslueMolde.ShowClearButton = False
        Me.vrslueMolde.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'vrslueMateriales
        '
        Me.vrslueMateriales.AutoHeight = False
        Me.vrslueMateriales.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueMateriales.Name = "vrslueMateriales"
        Me.vrslueMateriales.NullText = ""
        Me.vrslueMateriales.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'rowId
        '
        Me.rowId.Enabled = False
        Me.rowId.Name = "rowId"
        Me.rowId.Properties.Caption = "Id"
        Me.rowId.Properties.FieldName = "Id"
        '
        'rowDescripcion
        '
        Me.rowDescripcion.Enabled = False
        Me.rowDescripcion.Name = "rowDescripcion"
        Me.rowDescripcion.Properties.Caption = "Descripcion"
        Me.rowDescripcion.Properties.FieldName = "Descripcion"
        '
        'rowMaterial1
        '
        Me.rowMaterial1.Name = "rowMaterial1"
        Me.rowMaterial1.Properties.Caption = "Material1"
        Me.rowMaterial1.Properties.FieldName = "Material1"
        Me.rowMaterial1.Properties.RowEdit = Me.vrslueMateriales
        '
        'rowMaterial1Porc
        '
        Me.rowMaterial1Porc.Name = "rowMaterial1Porc"
        Me.rowMaterial1Porc.Properties.Caption = "Material1Porc"
        Me.rowMaterial1Porc.Properties.FieldName = "Material1Porc"
        '
        'rowMaterial2
        '
        Me.rowMaterial2.Height = 17
        Me.rowMaterial2.Name = "rowMaterial2"
        Me.rowMaterial2.Properties.Caption = "Material2"
        Me.rowMaterial2.Properties.FieldName = "Material2"
        Me.rowMaterial2.Properties.RowEdit = Me.vrslueMateriales
        '
        'rowMaterial2Porc
        '
        Me.rowMaterial2Porc.Name = "rowMaterial2Porc"
        Me.rowMaterial2Porc.Properties.Caption = "Material2Porc"
        Me.rowMaterial2Porc.Properties.FieldName = "Material2Porc"
        '
        'rowMaterial3
        '
        Me.rowMaterial3.Name = "rowMaterial3"
        Me.rowMaterial3.Properties.Caption = "Material3"
        Me.rowMaterial3.Properties.FieldName = "Material3"
        Me.rowMaterial3.Properties.RowEdit = Me.vrslueMateriales
        '
        'rowMolde
        '
        Me.rowMolde.Name = "rowMolde"
        Me.rowMolde.Properties.Caption = "Molde"
        Me.rowMolde.Properties.FieldName = "Molde"
        Me.rowMolde.Properties.RowEdit = Me.vrslueMolde
        '
        'rowNombre
        '
        Me.rowNombre.Name = "rowNombre"
        Me.rowNombre.Properties.Caption = "Nombre"
        Me.rowNombre.Properties.FieldName = "Nombre"
        '
        'rowEstatus
        '
        Me.rowEstatus.Name = "rowEstatus"
        Me.rowEstatus.Properties.Caption = "Estatus"
        Me.rowEstatus.Properties.FieldName = "Estatus"
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
        'grdCP_Moldes
        '
        Me.grdCP_Moldes.DataMember = "dsdtCodigosProducidos"
        Me.grdCP_Moldes.DataSource = Me.DsAsigCP_Moldes1
        Me.grdCP_Moldes.Location = New System.Drawing.Point(391, 12)
        Me.grdCP_Moldes.MainView = Me.grdviewCP_Moldes
        Me.grdCP_Moldes.Name = "grdCP_Moldes"
        Me.grdCP_Moldes.Size = New System.Drawing.Size(1036, 718)
        Me.grdCP_Moldes.TabIndex = 4
        Me.grdCP_Moldes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCP_Moldes})
        '
        'grdviewCP_Moldes
        '
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewCP_Moldes.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCP_Moldes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.Preview.Options.UseFont = True
        Me.grdviewCP_Moldes.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP_Moldes.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCP_Moldes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCP_Moldes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP_Moldes.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCP_Moldes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDescripcion, Me.colMaterial1, Me.colMaterial1Porc, Me.colMaterial2, Me.colMaterial2Porc, Me.colMaterial3, Me.colMolde, Me.colNombre, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewCP_Moldes.GridControl = Me.grdCP_Moldes
        Me.grdviewCP_Moldes.Name = "grdviewCP_Moldes"
        Me.grdviewCP_Moldes.OptionsBehavior.Editable = False
        Me.grdviewCP_Moldes.OptionsBehavior.ReadOnly = True
        Me.grdviewCP_Moldes.OptionsView.ColumnAutoWidth = False
        Me.grdviewCP_Moldes.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCP_Moldes.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCP_Moldes.OptionsView.ShowGroupPanel = False
        Me.grdviewCP_Moldes.PaintStyleName = "UltraFlat"
        '
        'colId
        '
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 250
        '
        'colMaterial1
        '
        Me.colMaterial1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1.FieldName = "Material1"
        Me.colMaterial1.Name = "colMaterial1"
        Me.colMaterial1.Visible = True
        Me.colMaterial1.VisibleIndex = 2
        Me.colMaterial1.Width = 100
        '
        'colMaterial1Porc
        '
        Me.colMaterial1Porc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1Porc.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1Porc.FieldName = "Material1Porc"
        Me.colMaterial1Porc.Name = "colMaterial1Porc"
        Me.colMaterial1Porc.Visible = True
        Me.colMaterial1Porc.VisibleIndex = 3
        '
        'colMaterial2
        '
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
        'colMaterial2Porc
        '
        Me.colMaterial2Porc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial2Porc.AppearanceHeader.Options.UseFont = True
        Me.colMaterial2Porc.FieldName = "Material2Porc"
        Me.colMaterial2Porc.Name = "colMaterial2Porc"
        Me.colMaterial2Porc.Visible = True
        Me.colMaterial2Porc.VisibleIndex = 5
        Me.colMaterial2Porc.Width = 87
        '
        'colMaterial3
        '
        Me.colMaterial3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial3.AppearanceHeader.Options.UseFont = True
        Me.colMaterial3.FieldName = "Material3"
        Me.colMaterial3.Name = "colMaterial3"
        Me.colMaterial3.Visible = True
        Me.colMaterial3.VisibleIndex = 6
        '
        'colMolde
        '
        Me.colMolde.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colMolde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMolde.AppearanceHeader.Options.UseBackColor = True
        Me.colMolde.AppearanceHeader.Options.UseFont = True
        Me.colMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.FieldName = "Molde"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Visible = True
        Me.colMolde.VisibleIndex = 7
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceHeader.Options.UseBackColor = True
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 8
        Me.colNombre.Width = 250
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
        'lycgCP_Moldes
        '
        Me.lycgCP_Moldes.CustomizationFormText = "LayoutControlGroup1"
        Me.lycgCP_Moldes.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycgCP_Moldes.GroupBordersVisible = False
        Me.lycgCP_Moldes.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lycMenu})
        Me.lycgCP_Moldes.Location = New System.Drawing.Point(0, 0)
        Me.lycgCP_Moldes.Name = "lycgCP_Moldes"
        Me.lycgCP_Moldes.Size = New System.Drawing.Size(1439, 742)
        Me.lycgCP_Moldes.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdCP_Moldes
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1040, 722)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdCP_Moldes
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 671)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lycMenu
        '
        Me.lycMenu.Control = Me.sbdcMenu
        Me.lycMenu.CustomizationFormText = "LayoutControlItem3"
        Me.lycMenu.Location = New System.Drawing.Point(0, 0)
        Me.lycMenu.Name = "lycMenu"
        Me.lycMenu.Size = New System.Drawing.Size(379, 51)
        Me.lycMenu.TextSize = New System.Drawing.Size(0, 0)
        Me.lycMenu.TextVisible = False
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcMenu)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimirGrid, Me.barbtnAgregar, Me.barbtnGrabar, Me.barbtnCancelar, Me.barbtnActualizar, Me.barbtnBuscar, Me.barbtnBitacoraModificacion})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
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
        Me.Bar1.OptionsBar.DrawSizeGrip = True
        Me.Bar1.StandaloneBarDockControl = Me.sbdcMenu
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Id = 1
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnAgregar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnGrabar
        '
        Me.barbtnGrabar.Caption = "Grabar"
        Me.barbtnGrabar.Id = 2
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
        '
        'barbtnCancelar
        '
        Me.barbtnCancelar.Caption = "Cancelar"
        Me.barbtnCancelar.Id = 3
        Me.barbtnCancelar.ImageOptions.Image = CType(resources.GetObject("barbtnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCancelar.Name = "barbtnCancelar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 4
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir"
        Me.barbtnImprimirGrid.Id = 0
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 5
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnBitacoraModificacion
        '
        Me.barbtnBitacoraModificacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.barbtnBitacoraModificacion.Caption = "Usuarios"
        Me.barbtnBitacoraModificacion.Enabled = False
        Me.barbtnBitacoraModificacion.Id = 6
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
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1439, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 742)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1439, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 742)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1439, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 742)
        '
        'frmAsignarCodigosProducidosMoldes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 765)
        Me.Controls.Add(Me.lycAsignacionCodigosProducidosMoldes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmAsignarCodigosProducidosMoldes"
        Me.Text = "Mantenimiento de Codigos Producidos / Moldes"
        CType(Me.lycAsignacionCodigosProducidosMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAsignacionCodigosProducidosMoldes.ResumeLayout(False)
        CType(Me.vgrdCP_Moldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsigCP_Moldes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueMolde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCP_Moldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCP_Moldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycgCP_Moldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycAsignacionCodigosProducidosMoldes As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents sbdcMenu As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents vgrdCP_Moldes As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents grdCP_Moldes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCP_Moldes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lycgCP_Moldes As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycMenu As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsAsigCP_Moldes1 As waProduccion_Pedidos.dsAsigCP_Moldes
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowId As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDescripcion As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMolde As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombre As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstatus As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_CreacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBit_ModificacionFecha As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents vrslueMolde As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBitacoraModificacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents vrslueMateriales As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rowMaterial1Porc As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial2Porc As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMaterial3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents colMaterial1Porc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial2Porc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
