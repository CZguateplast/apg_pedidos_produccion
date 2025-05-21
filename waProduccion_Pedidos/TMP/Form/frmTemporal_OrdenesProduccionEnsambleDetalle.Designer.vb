<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_OrdenesProduccionEnsambleDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_OrdenesProduccionEnsambleDetalle))
        Me.lycTemporal_OrdenesProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.grdOrdenesProduccionEnsambleDetalle = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_OrdenesProduccionEnsambleDetalle1 = New waProduccion_Pedidos.dsTemporal_OrdenesProduccionEnsambleDetalle()
        Me.grdviewOrdenesProduccionEnsambleDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rspinMonto = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreación = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasAtrasado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCampaña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnDocumentoDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycTemporal_OrdenesProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_OrdenesProduccion.SuspendLayout()
        CType(Me.grdOrdenesProduccionEnsambleDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_OrdenesProduccionEnsambleDetalle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewOrdenesProduccionEnsambleDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rspinMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal_OrdenesProduccion
        '
        Me.lycTemporal_OrdenesProduccion.Controls.Add(Me.lblTitulo)
        Me.lycTemporal_OrdenesProduccion.Controls.Add(Me.grdOrdenesProduccionEnsambleDetalle)
        Me.lycTemporal_OrdenesProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_OrdenesProduccion.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_OrdenesProduccion.Name = "lycTemporal_OrdenesProduccion"
        Me.lycTemporal_OrdenesProduccion.Root = Me.LayoutControlGroup1
        Me.lycTemporal_OrdenesProduccion.Size = New System.Drawing.Size(812, 348)
        Me.lycTemporal_OrdenesProduccion.TabIndex = 0
        Me.lycTemporal_OrdenesProduccion.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(335, 19)
        Me.lblTitulo.StyleController = Me.lycTemporal_OrdenesProduccion
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Ordenes de Produccion y Ensamble (SAP)"
        '
        'grdOrdenesProduccionEnsambleDetalle
        '
        Me.grdOrdenesProduccionEnsambleDetalle.DataMember = "dsdtTemporal_OrdenesProduccionEnsambleDetalle"
        Me.grdOrdenesProduccionEnsambleDetalle.DataSource = Me.DsTemporal_OrdenesProduccionEnsambleDetalle1
        Me.grdOrdenesProduccionEnsambleDetalle.Location = New System.Drawing.Point(12, 35)
        Me.grdOrdenesProduccionEnsambleDetalle.MainView = Me.grdviewOrdenesProduccionEnsambleDetalle
        Me.grdOrdenesProduccionEnsambleDetalle.MenuManager = Me.BarManager1
        Me.grdOrdenesProduccionEnsambleDetalle.Name = "grdOrdenesProduccionEnsambleDetalle"
        Me.grdOrdenesProduccionEnsambleDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rspinMonto})
        Me.grdOrdenesProduccionEnsambleDetalle.Size = New System.Drawing.Size(788, 301)
        Me.grdOrdenesProduccionEnsambleDetalle.TabIndex = 4
        Me.grdOrdenesProduccionEnsambleDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenesProduccionEnsambleDetalle})
        '
        'DsTemporal_OrdenesProduccionEnsambleDetalle1
        '
        Me.DsTemporal_OrdenesProduccionEnsambleDetalle1.DataSetName = "dsTemporal_OrdenesProduccionEnsambleDetalle"
        Me.DsTemporal_OrdenesProduccionEnsambleDetalle1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenesProduccionEnsambleDetalle
        '
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Preview.Options.UseFont = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Row.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.Row.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewOrdenesProduccionEnsambleDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.ColumnPanelRowHeight = 35
        Me.grdviewOrdenesProduccionEnsambleDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado, Me.colOrigen, Me.colDestino, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNumeroOrden, Me.colCampaña, Me.colEntrega, Me.colComentario1, Me.colCreacion})
        Me.grdviewOrdenesProduccionEnsambleDetalle.GridControl = Me.grdOrdenesProduccionEnsambleDetalle
        Me.grdviewOrdenesProduccionEnsambleDetalle.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pendiente", Me.colPendiente, "(Pendiente: SUM={0:0.##})")})
        Me.grdviewOrdenesProduccionEnsambleDetalle.Name = "grdviewOrdenesProduccionEnsambleDetalle"
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsBehavior.Editable = False
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsBehavior.ReadOnly = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsView.ColumnAutoWidth = False
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsView.ShowFooter = True
        Me.grdviewOrdenesProduccionEnsambleDetalle.OptionsView.ShowGroupPanel = False
        Me.grdviewOrdenesProduccionEnsambleDetalle.PaintStyleName = "Style3D"
        Me.grdviewOrdenesProduccionEnsambleDetalle.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEstado, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNumSAP.Caption = "SAP"
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 0
        Me.colNumSAP.Width = 55
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        Me.colEstado.Width = 65
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 65
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPlaneado.ColumnEdit = Me.rspinMonto
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 90
        '
        'rspinMonto
        '
        Me.rspinMonto.AutoHeight = False
        Me.rspinMonto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinMonto.DisplayFormat.FormatString = "n0"
        Me.rspinMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinMonto.EditFormat.FormatString = "n0"
        Me.rspinMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rspinMonto.Mask.EditMask = "n0"
        Me.rspinMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rspinMonto.Name = "rspinMonto"
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompletado.ColumnEdit = Me.rspinMonto
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        Me.colCompletado.Width = 90
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPendiente.ColumnEdit = Me.rspinMonto
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 90
        '
        'colCreación
        '
        Me.colCreación.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreación.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCreación.FieldName = "Creación"
        Me.colCreación.Name = "colCreación"
        Me.colCreación.OptionsColumn.ReadOnly = True
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 6
        Me.colCreación.Width = 65
        '
        'colVencimiento
        '
        Me.colVencimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVencimiento.Caption = "Vence"
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.OptionsColumn.ReadOnly = True
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 7
        Me.colVencimiento.Width = 65
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiasAtrasado.Caption = "Dias Atras"
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.OptionsColumn.ReadOnly = True
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 8
        Me.colDiasAtrasado.Width = 55
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 9
        Me.colOrigen.Width = 65
        '
        'colDestino
        '
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 10
        Me.colDestino.Width = 65
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 11
        Me.colGrupoCliente.Width = 65
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 12
        Me.colCodigoCliente.Width = 60
        '
        'colNumeroOrden
        '
        Me.colNumeroOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroOrden.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNumeroOrden.FieldName = "NumeroOrden"
        Me.colNumeroOrden.Name = "colNumeroOrden"
        Me.colNumeroOrden.Visible = True
        Me.colNumeroOrden.VisibleIndex = 13
        Me.colNumeroOrden.Width = 60
        '
        'colCampaña
        '
        Me.colCampaña.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampaña.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCampaña.FieldName = "Campaña"
        Me.colCampaña.Name = "colCampaña"
        Me.colCampaña.Visible = True
        Me.colCampaña.VisibleIndex = 14
        Me.colCampaña.Width = 70
        '
        'colEntrega
        '
        Me.colEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEntrega.FieldName = "Entrega"
        Me.colEntrega.Name = "colEntrega"
        Me.colEntrega.Visible = True
        Me.colEntrega.VisibleIndex = 15
        Me.colEntrega.Width = 65
        '
        'colComentario1
        '
        Me.colComentario1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComentario1.Caption = "Comentarios"
        Me.colComentario1.FieldName = "Comentario1"
        Me.colComentario1.Name = "colComentario1"
        Me.colComentario1.Visible = True
        Me.colComentario1.VisibleIndex = 17
        Me.colComentario1.Width = 250
        '
        'colCreacion
        '
        Me.colCreacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreacion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCreacion.FieldName = "Creacion"
        Me.colCreacion.Name = "colCreacion"
        Me.colCreacion.Visible = True
        Me.colCreacion.VisibleIndex = 16
        Me.colCreacion.Width = 67
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnDocumentoDetalle, Me.barbtnRecibos})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDocumentoDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnRecibos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnDocumentoDetalle
        '
        Me.barbtnDocumentoDetalle.Caption = "Documento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.barbtnDocumentoDetalle.Id = 1
        Me.barbtnDocumentoDetalle.ImageOptions.Image = CType(resources.GetObject("barbtnDocumentoDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDocumentoDetalle.Name = "barbtnDocumentoDetalle"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnRecibos
        '
        Me.barbtnRecibos.Caption = "Recibos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Produccion"
        Me.barbtnRecibos.Id = 2
        Me.barbtnRecibos.ImageOptions.Image = CType(resources.GetObject("barbtnRecibos.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnRecibos.Name = "barbtnRecibos"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(812, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 348)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(812, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 348)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(812, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 348)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(812, 348)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOrdenesProduccionEnsambleDetalle
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(792, 305)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lblTitulo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(792, 23)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmTemporal_OrdenesProduccionEnsambleDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycTemporal_OrdenesProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_OrdenesProduccionEnsambleDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_OrdenesProduccionEnsambleDetalle"
        CType(Me.lycTemporal_OrdenesProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_OrdenesProduccion.ResumeLayout(False)
        CType(Me.grdOrdenesProduccionEnsambleDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_OrdenesProduccionEnsambleDetalle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewOrdenesProduccionEnsambleDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rspinMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTemporal_OrdenesProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdOrdenesProduccionEnsambleDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewOrdenesProduccionEnsambleDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_OrdenesProduccionEnsambleDetalle1 As waProduccion_Pedidos.dsTemporal_OrdenesProduccionEnsambleDetalle
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasAtrasado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCampaña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnDocumentoDetalle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rspinMonto As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
