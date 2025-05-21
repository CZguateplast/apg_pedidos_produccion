<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercanciasSalidas
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
        Me.lycTraslados = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcTrasladosMercaderia = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.vgrdTrasladosMercaderia = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.DsTrasladosMercaderia1 = New waProduccion_Pedidos.dsTrasladosMercaderia()
        Me.vrslueListaPrecios = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rmmeComentarios = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.vrslueCuentaContable = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vrslueFechaConta = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.vrslueFechaDocumento = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rowListaPrecios = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFechaConta = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFechaDocumento = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNumReferencia = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComentarios = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCuentaContable = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAsientoContable = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grdTrasladosMercaderia = New DevExpress.XtraGrid.GridControl()
        Me.grdviewTrasladosMercaderia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueBodegas = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCuentasContables = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.lycTraslados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTraslados.SuspendLayout()
        CType(Me.vgrdTrasladosMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrasladosMercaderia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueFechaConta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueFechaConta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueFechaDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vrslueFechaDocumento.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTrasladosMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTrasladosMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTraslados
        '
        Me.lycTraslados.Controls.Add(Me.sbdcTrasladosMercaderia)
        Me.lycTraslados.Controls.Add(Me.vgrdTrasladosMercaderia)
        Me.lycTraslados.Controls.Add(Me.grdTrasladosMercaderia)
        Me.lycTraslados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTraslados.Location = New System.Drawing.Point(0, 0)
        Me.lycTraslados.Name = "lycTraslados"
        Me.lycTraslados.Root = Me.LayoutControlGroup1
        Me.lycTraslados.Size = New System.Drawing.Size(1356, 742)
        Me.lycTraslados.TabIndex = 0
        Me.lycTraslados.Text = "LayoutControl1"
        '
        'sbdcTrasladosMercaderia
        '
        Me.sbdcTrasladosMercaderia.CausesValidation = False
        Me.sbdcTrasladosMercaderia.Location = New System.Drawing.Point(12, 12)
        Me.sbdcTrasladosMercaderia.Manager = Me.BarManager1
        Me.sbdcTrasladosMercaderia.Name = "sbdcTrasladosMercaderia"
        Me.sbdcTrasladosMercaderia.Size = New System.Drawing.Size(72, 48)
        Me.sbdcTrasladosMercaderia.Text = "StandaloneBarDockControl1"
        '
        'vgrdTrasladosMercaderia
        '
        Me.vgrdTrasladosMercaderia.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgrdTrasladosMercaderia.Appearance.Category.ForeColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.Category.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.Category.Options.UseBorderColor = True
        Me.vgrdTrasladosMercaderia.Appearance.Category.Options.UseFont = True
        Me.vgrdTrasladosMercaderia.Appearance.Category.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.ForeColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgrdTrasladosMercaderia.Appearance.CategoryExpandButton.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.Empty.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.ForeColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgrdTrasladosMercaderia.Appearance.ExpandButton.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgrdTrasladosMercaderia.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.vgrdTrasladosMercaderia.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgrdTrasladosMercaderia.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.White
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgrdTrasladosMercaderia.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgrdTrasladosMercaderia.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.vgrdTrasladosMercaderia.Appearance.VertLine.Options.UseBackColor = True
        Me.vgrdTrasladosMercaderia.DataMember = "dsdtTrasladosMercaderiaEncabezado"
        Me.vgrdTrasladosMercaderia.DataSource = Me.DsTrasladosMercaderia1
        Me.vgrdTrasladosMercaderia.Location = New System.Drawing.Point(12, 64)
        Me.vgrdTrasladosMercaderia.MaximumSize = New System.Drawing.Size(375, 0)
        Me.vgrdTrasladosMercaderia.MinimumSize = New System.Drawing.Size(375, 0)
        Me.vgrdTrasladosMercaderia.Name = "vgrdTrasladosMercaderia"
        Me.vgrdTrasladosMercaderia.RecordWidth = 250
        Me.vgrdTrasladosMercaderia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.vrslueListaPrecios, Me.rmmeComentarios, Me.vrslueCuentaContable, Me.vrslueFechaConta, Me.vrslueFechaDocumento})
        Me.vgrdTrasladosMercaderia.RowHeaderWidth = 125
        Me.vgrdTrasladosMercaderia.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowListaPrecios, Me.rowFechaConta, Me.rowFechaDocumento, Me.rowNumReferencia, Me.rowComentarios, Me.rowCuentaContable, Me.rowAsientoContable})
        Me.vgrdTrasladosMercaderia.Size = New System.Drawing.Size(375, 666)
        Me.vgrdTrasladosMercaderia.TabIndex = 5
        '
        'DsTrasladosMercaderia1
        '
        Me.DsTrasladosMercaderia1.DataSetName = "dsTrasladosMercaderia"
        Me.DsTrasladosMercaderia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vrslueListaPrecios
        '
        Me.vrslueListaPrecios.AutoHeight = False
        Me.vrslueListaPrecios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueListaPrecios.Name = "vrslueListaPrecios"
        Me.vrslueListaPrecios.NullText = ""
        Me.vrslueListaPrecios.ValueMember = "1"
        Me.vrslueListaPrecios.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'rmmeComentarios
        '
        Me.rmmeComentarios.Name = "rmmeComentarios"
        '
        'vrslueCuentaContable
        '
        Me.vrslueCuentaContable.AutoHeight = False
        Me.vrslueCuentaContable.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueCuentaContable.Name = "vrslueCuentaContable"
        Me.vrslueCuentaContable.NullText = ""
        Me.vrslueCuentaContable.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'vrslueFechaConta
        '
        Me.vrslueFechaConta.AutoHeight = False
        Me.vrslueFechaConta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueFechaConta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueFechaConta.Mask.EditMask = "dd/MM/yyyy"
        Me.vrslueFechaConta.Mask.UseMaskAsDisplayFormat = True
        Me.vrslueFechaConta.Name = "vrslueFechaConta"
        '
        'vrslueFechaDocumento
        '
        Me.vrslueFechaDocumento.AutoHeight = False
        Me.vrslueFechaDocumento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueFechaDocumento.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vrslueFechaDocumento.Mask.EditMask = "dd/MM/yyyy"
        Me.vrslueFechaDocumento.Mask.UseMaskAsDisplayFormat = True
        Me.vrslueFechaDocumento.Name = "vrslueFechaDocumento"
        '
        'rowListaPrecios
        '
        Me.rowListaPrecios.Name = "rowListaPrecios"
        Me.rowListaPrecios.Properties.Caption = "Lista Precios"
        Me.rowListaPrecios.Properties.FieldName = "ListaPrecios"
        Me.rowListaPrecios.Properties.RowEdit = Me.vrslueListaPrecios
        '
        'rowFechaConta
        '
        Me.rowFechaConta.Name = "rowFechaConta"
        Me.rowFechaConta.Properties.Caption = "Fecha Conta"
        Me.rowFechaConta.Properties.FieldName = "FechaConta"
        Me.rowFechaConta.Properties.RowEdit = Me.vrslueFechaConta
        '
        'rowFechaDocumento
        '
        Me.rowFechaDocumento.Name = "rowFechaDocumento"
        Me.rowFechaDocumento.Properties.Caption = "Fecha Documento"
        Me.rowFechaDocumento.Properties.FieldName = "FechaDocumento"
        Me.rowFechaDocumento.Properties.RowEdit = Me.vrslueFechaDocumento
        '
        'rowNumReferencia
        '
        Me.rowNumReferencia.Name = "rowNumReferencia"
        Me.rowNumReferencia.Properties.Caption = "Num Referencia"
        Me.rowNumReferencia.Properties.FieldName = "NumReferencia"
        '
        'rowComentarios
        '
        Me.rowComentarios.Name = "rowComentarios"
        Me.rowComentarios.Properties.Caption = "Comentarios"
        Me.rowComentarios.Properties.FieldName = "Comentarios"
        Me.rowComentarios.Properties.RowEdit = Me.rmmeComentarios
        '
        'rowCuentaContable
        '
        Me.rowCuentaContable.Height = 17
        Me.rowCuentaContable.Name = "rowCuentaContable"
        Me.rowCuentaContable.Properties.Caption = "CuentaContable"
        Me.rowCuentaContable.Properties.FieldName = "CuentaContable"
        Me.rowCuentaContable.Properties.RowEdit = Me.vrslueCuentaContable
        '
        'rowAsientoContable
        '
        Me.rowAsientoContable.Name = "rowAsientoContable"
        Me.rowAsientoContable.Properties.Caption = "Asiento Contable"
        Me.rowAsientoContable.Properties.FieldName = "AsientoContable"
        Me.rowAsientoContable.Properties.ReadOnly = True
        '
        'grdTrasladosMercaderia
        '
        Me.grdTrasladosMercaderia.DataMember = "dsdtTrasladosMercaderiaDetalle"
        Me.grdTrasladosMercaderia.DataSource = Me.DsTrasladosMercaderia1
        Me.grdTrasladosMercaderia.Location = New System.Drawing.Point(391, 12)
        Me.grdTrasladosMercaderia.MainView = Me.grdviewTrasladosMercaderia
        Me.grdTrasladosMercaderia.Name = "grdTrasladosMercaderia"
        Me.grdTrasladosMercaderia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueCodigoArticulo, Me.rslueBodegas, Me.rslueCuentasContables})
        Me.grdTrasladosMercaderia.Size = New System.Drawing.Size(953, 718)
        Me.grdTrasladosMercaderia.TabIndex = 4
        Me.grdTrasladosMercaderia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTrasladosMercaderia})
        '
        'grdviewTrasladosMercaderia
        '
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTrasladosMercaderia.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.Preview.Options.UseFont = True
        Me.grdviewTrasladosMercaderia.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladosMercaderia.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewTrasladosMercaderia.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTrasladosMercaderia.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTrasladosMercaderia.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewTrasladosMercaderia.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTrasladosMercaderia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colUnidadMedida, Me.colBodega, Me.colStock, Me.colCantidad, Me.colPrecio})
        Me.grdviewTrasladosMercaderia.GridControl = Me.grdTrasladosMercaderia
        Me.grdviewTrasladosMercaderia.Name = "grdviewTrasladosMercaderia"
        Me.grdviewTrasladosMercaderia.OptionsView.ColumnAutoWidth = False
        Me.grdviewTrasladosMercaderia.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTrasladosMercaderia.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTrasladosMercaderia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewTrasladosMercaderia.OptionsView.ShowGroupPanel = False
        Me.grdviewTrasladosMercaderia.PaintStyleName = "Web"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCodigoArticulo.AppearanceCell.Options.UseForeColor = True
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.ColumnEdit = Me.rslueCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 125
        '
        'rslueCodigoArticulo
        '
        Me.rslueCodigoArticulo.AutoHeight = False
        Me.rslueCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoArticulo.Name = "rslueCodigoArticulo"
        Me.rslueCodigoArticulo.NullText = ""
        Me.rslueCodigoArticulo.ShowClearButton = False
        Me.rslueCodigoArticulo.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.AllowFocus = False
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 250
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidadMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadMedida.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidadMedida.AppearanceHeader.Options.UseFont = True
        Me.colUnidadMedida.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadMedida.Caption = "U/M"
        Me.colUnidadMedida.FieldName = "UnidadMedida"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.OptionsColumn.AllowEdit = False
        Me.colUnidadMedida.OptionsColumn.AllowFocus = False
        Me.colUnidadMedida.Visible = True
        Me.colUnidadMedida.VisibleIndex = 2
        Me.colUnidadMedida.Width = 50
        '
        'colBodega
        '
        Me.colBodega.AppearanceCell.Options.UseTextOptions = True
        Me.colBodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBodega.AppearanceHeader.Options.UseFont = True
        Me.colBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBodega.ColumnEdit = Me.rslueBodegas
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 3
        Me.colBodega.Width = 100
        '
        'rslueBodegas
        '
        Me.rslueBodegas.AutoHeight = False
        Me.rslueBodegas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueBodegas.Name = "rslueBodegas"
        Me.rslueBodegas.NullText = ""
        Me.rslueBodegas.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colStock
        '
        Me.colStock.AppearanceCell.Options.UseTextOptions = True
        Me.colStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStock.AppearanceHeader.Options.UseFont = True
        Me.colStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.AllowEdit = False
        Me.colStock.OptionsColumn.AllowFocus = False
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 4
        Me.colStock.Width = 100
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 6
        '
        'colPrecio
        '
        Me.colPrecio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrecio.AppearanceHeader.Options.UseFont = True
        Me.colPrecio.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowEdit = False
        Me.colPrecio.OptionsColumn.AllowFocus = False
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 5
        '
        'rslueCuentasContables
        '
        Me.rslueCuentasContables.AutoHeight = False
        Me.rslueCuentasContables.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCuentasContables.Name = "rslueCuentasContables"
        Me.rslueCuentasContables.NullText = ""
        Me.rslueCuentasContables.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1356, 742)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTrasladosMercaderia
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(957, 722)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.vgrdTrasladosMercaderia
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 670)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcTrasladosMercaderia
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 52)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcTrasladosMercaderia)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSAP})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSAP)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcTrasladosMercaderia
        Me.Bar1.Text = "Tools"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Caption = "Enviar a SAP"
        Me.barbtnSAP.Id = 0
        Me.barbtnSAP.ImageOptions.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.barbtnSAP.Name = "barbtnSAP"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1356, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 742)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1356, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1356, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 742)
        '
        'frmMercanciasSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 742)
        Me.Controls.Add(Me.lycTraslados)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMercanciasSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas de Mercancias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lycTraslados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTraslados.ResumeLayout(False)
        CType(Me.vgrdTrasladosMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrasladosMercaderia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueFechaConta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueFechaConta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueFechaDocumento.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vrslueFechaDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTrasladosMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTrasladosMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTraslados As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents vgrdTrasladosMercaderia As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents grdTrasladosMercaderia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTrasladosMercaderia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcTrasladosMercaderia As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsTrasladosMercaderia1 As waProduccion_Pedidos.dsTrasladosMercaderia
    Friend WithEvents rowListaPrecios As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFechaConta As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFechaDocumento As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNumReferencia As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComentarios As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAsientoContable As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents vrslueListaPrecios As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueBodegas As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rmmeComentarios As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rslueCuentasContables As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rowCuentaContable As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents vrslueCuentaContable As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vrslueFechaConta As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents vrslueFechaDocumento As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
