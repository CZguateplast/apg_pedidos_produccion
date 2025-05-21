<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmergenciasProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmergenciasProduccion))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.splitEmergenciasProduccion = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lycListadoProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.lblHijos = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grdProduccionHijos = New DevExpress.XtraGrid.GridControl()
        Me.DsEmergenciasProduccion1 = New waProduccion_Pedidos.dsEmergenciasProduccion()
        Me.grdviewProduccionHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDetalleOrdenes = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcEmergenciasProduccion = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnReporte = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProgramacionProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCorreo = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcEmergenciasProduccionCursores = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barbtnBajarPrioridad = New DevExpress.XtraBars.BarButtonItem()
        Me.grdProduccionPadres = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProduccionPadres = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rsluePrioridadCP = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lycEmergenciasProduccion = New DevExpress.XtraLayout.LayoutControl()
        Me.lblPlan = New DevExpress.XtraEditors.LabelControl()
        Me.grdEmergenciasProduccion_Plan = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEmergenciasProduccion_Plan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdteFechaRecibo = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColoresPendientes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueColor = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCampaña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCampana = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFechaDespacho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdteFechaEntrega = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colObservacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnQuitar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSubirPrioridad = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.splitEmergenciasProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitEmergenciasProduccion.SuspendLayout()
        CType(Me.lycListadoProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListadoProduccion.SuspendLayout()
        CType(Me.grdProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmergenciasProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProduccionPadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProduccionPadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rsluePrioridadCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycEmergenciasProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycEmergenciasProduccion.SuspendLayout()
        CType(Me.grdEmergenciasProduccion_Plan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEmergenciasProduccion_Plan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaRecibo.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFechaEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colPlan
        '
        Me.colPlan.Caption = "Plan"
        Me.colPlan.FieldName = "Plan"
        Me.colPlan.Name = "colPlan"
        '
        'splitEmergenciasProduccion
        '
        Me.splitEmergenciasProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitEmergenciasProduccion.Horizontal = False
        Me.splitEmergenciasProduccion.Location = New System.Drawing.Point(0, 0)
        Me.splitEmergenciasProduccion.Name = "splitEmergenciasProduccion"
        Me.splitEmergenciasProduccion.Panel1.Controls.Add(Me.lycListadoProduccion)
        Me.splitEmergenciasProduccion.Panel1.Text = "Panel1"
        Me.splitEmergenciasProduccion.Panel2.Controls.Add(Me.lycEmergenciasProduccion)
        Me.splitEmergenciasProduccion.Panel2.Text = "Panel2"
        Me.splitEmergenciasProduccion.Size = New System.Drawing.Size(1314, 624)
        Me.splitEmergenciasProduccion.SplitterPosition = 214
        Me.splitEmergenciasProduccion.TabIndex = 0
        Me.splitEmergenciasProduccion.Text = "SplitContainerControl1"
        '
        'lycListadoProduccion
        '
        Me.lycListadoProduccion.Controls.Add(Me.lblHijos)
        Me.lycListadoProduccion.Controls.Add(Me.LabelControl1)
        Me.lycListadoProduccion.Controls.Add(Me.grdProduccionHijos)
        Me.lycListadoProduccion.Controls.Add(Me.sbdcEmergenciasProduccion)
        Me.lycListadoProduccion.Controls.Add(Me.grdProduccionPadres)
        Me.lycListadoProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycListadoProduccion.Location = New System.Drawing.Point(0, 0)
        Me.lycListadoProduccion.Name = "lycListadoProduccion"
        Me.lycListadoProduccion.Root = Me.LayoutControlGroup1
        Me.lycListadoProduccion.Size = New System.Drawing.Size(1314, 214)
        Me.lycListadoProduccion.TabIndex = 0
        Me.lycListadoProduccion.Text = "LayoutControl1"
        '
        'lblHijos
        '
        Me.lblHijos.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHijos.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblHijos.Appearance.Options.UseFont = True
        Me.lblHijos.Appearance.Options.UseForeColor = True
        Me.lblHijos.Location = New System.Drawing.Point(656, 12)
        Me.lblHijos.Name = "lblHijos"
        Me.lblHijos.Size = New System.Drawing.Size(150, 19)
        Me.lblHijos.StyleController = Me.lycListadoProduccion
        Me.lblHijos.TabIndex = 8
        Me.lblHijos.Text = "Detalle de Colores"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(67, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(224, 19)
        Me.LabelControl1.StyleController = Me.lycListadoProduccion
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Ordenes Producción en SAP"
        '
        'grdProduccionHijos
        '
        Me.grdProduccionHijos.DataMember = "dsdtEmergenciasProduccion_Hijos"
        Me.grdProduccionHijos.DataSource = Me.DsEmergenciasProduccion1
        Me.grdProduccionHijos.Location = New System.Drawing.Point(656, 35)
        Me.grdProduccionHijos.MainView = Me.grdviewProduccionHijos
        Me.grdProduccionHijos.MaximumSize = New System.Drawing.Size(600, 0)
        Me.grdProduccionHijos.MenuManager = Me.BarManager1
        Me.grdProduccionHijos.Name = "grdProduccionHijos"
        Me.grdProduccionHijos.Size = New System.Drawing.Size(597, 167)
        Me.grdProduccionHijos.TabIndex = 5
        Me.grdProduccionHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProduccionHijos})
        '
        'DsEmergenciasProduccion1
        '
        Me.DsEmergenciasProduccion1.DataSetName = "dsEmergenciasProduccion"
        Me.DsEmergenciasProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewProduccionHijos
        '
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewProduccionHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo2, Me.colNombreArticulo2, Me.colPlaneado2, Me.colCompletado2, Me.colPendiente2})
        Me.grdviewProduccionHijos.GridControl = Me.grdProduccionHijos
        Me.grdviewProduccionHijos.Name = "grdviewProduccionHijos"
        Me.grdviewProduccionHijos.OptionsBehavior.Editable = False
        Me.grdviewProduccionHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProduccionHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewProduccionHijos.PaintStyleName = "Web"
        '
        'colCodigoArticulo2
        '
        Me.colCodigoArticulo2.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo2.Name = "colCodigoArticulo2"
        Me.colCodigoArticulo2.Visible = True
        Me.colCodigoArticulo2.VisibleIndex = 0
        Me.colCodigoArticulo2.Width = 115
        '
        'colNombreArticulo2
        '
        Me.colNombreArticulo2.FieldName = "NombreArticulo"
        Me.colNombreArticulo2.Name = "colNombreArticulo2"
        Me.colNombreArticulo2.Visible = True
        Me.colNombreArticulo2.VisibleIndex = 1
        Me.colNombreArticulo2.Width = 285
        '
        'colPlaneado2
        '
        Me.colPlaneado2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado2.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado2.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado2.FieldName = "Planeado"
        Me.colPlaneado2.Name = "colPlaneado2"
        Me.colPlaneado2.OptionsColumn.ReadOnly = True
        Me.colPlaneado2.Visible = True
        Me.colPlaneado2.VisibleIndex = 2
        Me.colPlaneado2.Width = 60
        '
        'colCompletado2
        '
        Me.colCompletado2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado2.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado2.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado2.FieldName = "Completado"
        Me.colCompletado2.Name = "colCompletado2"
        Me.colCompletado2.OptionsColumn.ReadOnly = True
        Me.colCompletado2.Visible = True
        Me.colCompletado2.VisibleIndex = 3
        Me.colCompletado2.Width = 60
        '
        'colPendiente2
        '
        Me.colPendiente2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPendiente2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPendiente2.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente2.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente2.FieldName = "Pendiente"
        Me.colPendiente2.Name = "colPendiente2"
        Me.colPendiente2.OptionsColumn.ReadOnly = True
        Me.colPendiente2.Visible = True
        Me.colPendiente2.VisibleIndex = 4
        Me.colPendiente2.Width = 60
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcEmergenciasProduccion)
        Me.BarManager1.DockControls.Add(Me.sbdcEmergenciasProduccionCursores)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnCerrar, Me.barbtnGrabar, Me.barbtnBajarPrioridad, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnReporte, Me.barbtnCorreo, Me.barbtnBuscar, Me.barbtnDetalleOrdenes, Me.barbtnActualizar, Me.barbtnProgramacionProduccion})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDetalleOrdenes)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcEmergenciasProduccion
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Quitar"
        Me.barbtnAgregar.Id = 1
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 11
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnDetalleOrdenes
        '
        Me.barbtnDetalleOrdenes.Caption = "Detalle de Ordenes"
        Me.barbtnDetalleOrdenes.Id = 10
        Me.barbtnDetalleOrdenes.ImageOptions.Image = CType(resources.GetObject("barbtnDetalleOrdenes.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDetalleOrdenes.Name = "barbtnDetalleOrdenes"
        '
        'sbdcEmergenciasProduccion
        '
        Me.sbdcEmergenciasProduccion.Appearance.Options.UseTextOptions = True
        Me.sbdcEmergenciasProduccion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sbdcEmergenciasProduccion.CausesValidation = False
        Me.sbdcEmergenciasProduccion.IsVertical = True
        Me.sbdcEmergenciasProduccion.Location = New System.Drawing.Point(12, 12)
        Me.sbdcEmergenciasProduccion.Manager = Me.BarManager1
        Me.sbdcEmergenciasProduccion.Name = "sbdcEmergenciasProduccion"
        Me.sbdcEmergenciasProduccion.Size = New System.Drawing.Size(51, 142)
        Me.sbdcEmergenciasProduccion.Text = "StandaloneBarDockControl1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnReporte, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnProgramacionProduccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCorreo, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGrabar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnReporte
        '
        Me.barbtnReporte.Caption = "Reporte"
        Me.barbtnReporte.Id = 7
        Me.barbtnReporte.ImageOptions.Image = CType(resources.GetObject("barbtnReporte.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnReporte.Name = "barbtnReporte"
        '
        'barbtnProgramacionProduccion
        '
        Me.barbtnProgramacionProduccion.Caption = "Programacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Produccion"
        Me.barbtnProgramacionProduccion.Id = 12
        Me.barbtnProgramacionProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnProgramacionProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnProgramacionProduccion.Name = "barbtnProgramacionProduccion"
        '
        'barbtnCorreo
        '
        Me.barbtnCorreo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCorreo.Caption = "Enviar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Correo"
        Me.barbtnCorreo.Id = 8
        Me.barbtnCorreo.ImageOptions.Image = CType(resources.GetObject("barbtnCorreo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCorreo.Name = "barbtnCorreo"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 9
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 5
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 6
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnGrabar
        '
        Me.barbtnGrabar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnGrabar.Caption = "Grabar"
        Me.barbtnGrabar.Id = 3
        Me.barbtnGrabar.ImageOptions.Image = CType(resources.GetObject("barbtnGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGrabar.Name = "barbtnGrabar"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1314, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 624)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1314, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 624)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1314, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 624)
        '
        'sbdcEmergenciasProduccionCursores
        '
        Me.sbdcEmergenciasProduccionCursores.CausesValidation = False
        Me.sbdcEmergenciasProduccionCursores.IsVertical = True
        Me.sbdcEmergenciasProduccionCursores.Location = New System.Drawing.Point(12, 12)
        Me.sbdcEmergenciasProduccionCursores.Manager = Me.BarManager1
        Me.sbdcEmergenciasProduccionCursores.Name = "sbdcEmergenciasProduccionCursores"
        Me.sbdcEmergenciasProduccionCursores.Size = New System.Drawing.Size(51, 142)
        Me.sbdcEmergenciasProduccionCursores.Text = "StandaloneBarDockControl1"
        '
        'barbtnBajarPrioridad
        '
        Me.barbtnBajarPrioridad.Caption = "Bajar"
        Me.barbtnBajarPrioridad.Id = 4
        Me.barbtnBajarPrioridad.ImageOptions.Image = CType(resources.GetObject("barbtnBajarPrioridad.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBajarPrioridad.Name = "barbtnBajarPrioridad"
        '
        'grdProduccionPadres
        '
        Me.grdProduccionPadres.DataMember = "dsdtEmergenciasProduccion_Padres"
        Me.grdProduccionPadres.DataSource = Me.DsEmergenciasProduccion1
        Me.grdProduccionPadres.Location = New System.Drawing.Point(67, 35)
        Me.grdProduccionPadres.MainView = Me.grdviewProduccionPadres
        Me.grdProduccionPadres.MaximumSize = New System.Drawing.Size(587, 0)
        Me.grdProduccionPadres.Name = "grdProduccionPadres"
        Me.grdProduccionPadres.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rsluePrioridadCP})
        Me.grdProduccionPadres.Size = New System.Drawing.Size(585, 167)
        Me.grdProduccionPadres.TabIndex = 4
        Me.grdProduccionPadres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProduccionPadres})
        '
        'grdviewProduccionPadres
        '
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewProduccionPadres.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.Preview.Options.UseFont = True
        Me.grdviewProduccionPadres.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewProduccionPadres.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad1, Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colPlan})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colPlan
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Gray
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.grdviewProduccionPadres.FormatRules.Add(GridFormatRule1)
        Me.grdviewProduccionPadres.GridControl = Me.grdProduccionPadres
        Me.grdviewProduccionPadres.Name = "grdviewProduccionPadres"
        Me.grdviewProduccionPadres.OptionsBehavior.Editable = False
        Me.grdviewProduccionPadres.OptionsBehavior.ReadOnly = True
        Me.grdviewProduccionPadres.OptionsView.ColumnAutoWidth = False
        Me.grdviewProduccionPadres.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProduccionPadres.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProduccionPadres.OptionsView.ShowGroupPanel = False
        Me.grdviewProduccionPadres.PaintStyleName = "Web"
        Me.grdviewProduccionPadres.ViewCaption = "Ordenes Produccion en SAP"
        '
        'colPrioridad1
        '
        Me.colPrioridad1.ColumnEdit = Me.rsluePrioridadCP
        Me.colPrioridad1.FieldName = "Prioridad"
        Me.colPrioridad1.Name = "colPrioridad1"
        Me.colPrioridad1.OptionsColumn.ReadOnly = True
        Me.colPrioridad1.Visible = True
        Me.colPrioridad1.VisibleIndex = 0
        Me.colPrioridad1.Width = 80
        '
        'rsluePrioridadCP
        '
        Me.rsluePrioridadCP.AutoHeight = False
        Me.rsluePrioridadCP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rsluePrioridadCP.Name = "rsluePrioridadCP"
        Me.rsluePrioridadCP.NullText = ""
        Me.rsluePrioridadCP.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 1
        Me.colCodigoArticulo1.Width = 80
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 2
        Me.colNombreArticulo1.Width = 225
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado1.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado1.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.OptionsColumn.ReadOnly = True
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 3
        Me.colPlaneado1.Width = 60
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado1.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado1.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.OptionsColumn.ReadOnly = True
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 4
        Me.colCompletado1.Width = 60
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPendiente1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPendiente1.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente1.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.OptionsColumn.ReadOnly = True
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 5
        Me.colPendiente1.Width = 60
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1314, 214)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdProduccionPadres
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(55, 23)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(589, 171)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.grdProduccionHijos
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(644, 23)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(601, 171)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1245, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(49, 194)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sbdcEmergenciasProduccion
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(55, 194)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LabelControl1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(55, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(228, 23)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(283, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(361, 23)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.lblHijos
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(644, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(154, 23)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(798, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(447, 23)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lycEmergenciasProduccion
        '
        Me.lycEmergenciasProduccion.Controls.Add(Me.lblPlan)
        Me.lycEmergenciasProduccion.Controls.Add(Me.sbdcEmergenciasProduccionCursores)
        Me.lycEmergenciasProduccion.Controls.Add(Me.grdEmergenciasProduccion_Plan)
        Me.lycEmergenciasProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycEmergenciasProduccion.Location = New System.Drawing.Point(0, 0)
        Me.lycEmergenciasProduccion.Name = "lycEmergenciasProduccion"
        Me.lycEmergenciasProduccion.Root = Me.LayoutControlGroup2
        Me.lycEmergenciasProduccion.Size = New System.Drawing.Size(1314, 405)
        Me.lycEmergenciasProduccion.TabIndex = 0
        Me.lycEmergenciasProduccion.Text = "LayoutControl1"
        '
        'lblPlan
        '
        Me.lblPlan.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlan.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblPlan.Appearance.Options.UseFont = True
        Me.lblPlan.Appearance.Options.UseForeColor = True
        Me.lblPlan.Location = New System.Drawing.Point(67, 12)
        Me.lblPlan.Name = "lblPlan"
        Me.lblPlan.Size = New System.Drawing.Size(232, 19)
        Me.lblPlan.StyleController = Me.lycEmergenciasProduccion
        Me.lblPlan.TabIndex = 5
        Me.lblPlan.Text = "Plan Sugerido de Producción"
        '
        'grdEmergenciasProduccion_Plan
        '
        Me.grdEmergenciasProduccion_Plan.AllowDrop = True
        Me.grdEmergenciasProduccion_Plan.DataMember = "dsdtEmergenciasProduccion_Plan"
        Me.grdEmergenciasProduccion_Plan.DataSource = Me.DsEmergenciasProduccion1
        Me.grdEmergenciasProduccion_Plan.Location = New System.Drawing.Point(67, 35)
        Me.grdEmergenciasProduccion_Plan.MainView = Me.grdviewEmergenciasProduccion_Plan
        Me.grdEmergenciasProduccion_Plan.MenuManager = Me.BarManager1
        Me.grdEmergenciasProduccion_Plan.Name = "grdEmergenciasProduccion_Plan"
        Me.grdEmergenciasProduccion_Plan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rdteFechaEntrega, Me.rslueColor, Me.rslueCliente, Me.rslueCampana, Me.rdteFechaRecibo})
        Me.grdEmergenciasProduccion_Plan.Size = New System.Drawing.Size(1235, 358)
        Me.grdEmergenciasProduccion_Plan.TabIndex = 4
        Me.grdEmergenciasProduccion_Plan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEmergenciasProduccion_Plan})
        '
        'grdviewEmergenciasProduccion_Plan
        '
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewEmergenciasProduccion_Plan.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Preview.ForeColor = System.Drawing.Color.SaddleBrown
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Row.BackColor = System.Drawing.Color.OldLace
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Row.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEmergenciasProduccion_Plan.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewEmergenciasProduccion_Plan.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.TopNewRow.Options.UseForeColor = True
        Me.grdviewEmergenciasProduccion_Plan.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewEmergenciasProduccion_Plan.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEmergenciasProduccion_Plan.ColumnPanelRowHeight = 35
        Me.grdviewEmergenciasProduccion_Plan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad, Me.colFechaRecibo, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colHorasPendiente, Me.colColoresPendientes, Me.colColorInicio, Me.colCliente, Me.colCampaña, Me.colFechaDespacho, Me.colObservacion})
        Me.grdviewEmergenciasProduccion_Plan.GridControl = Me.grdEmergenciasProduccion_Plan
        Me.grdviewEmergenciasProduccion_Plan.Name = "grdviewEmergenciasProduccion_Plan"
        Me.grdviewEmergenciasProduccion_Plan.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.grdviewEmergenciasProduccion_Plan.OptionsView.ColumnAutoWidth = False
        Me.grdviewEmergenciasProduccion_Plan.OptionsView.ShowGroupPanel = False
        Me.grdviewEmergenciasProduccion_Plan.PaintStyleName = "UltraFlat"
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceCell.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrioridad.Caption = "#Num"
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.OptionsColumn.AllowEdit = False
        Me.colPrioridad.OptionsColumn.ReadOnly = True
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 40
        '
        'colFechaRecibo
        '
        Me.colFechaRecibo.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaRecibo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaRecibo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaRecibo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaRecibo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFechaRecibo.Caption = "Fecha Ultimo Recibo"
        Me.colFechaRecibo.ColumnEdit = Me.rdteFechaRecibo
        Me.colFechaRecibo.FieldName = "FechaRecibo"
        Me.colFechaRecibo.Name = "colFechaRecibo"
        Me.colFechaRecibo.OptionsColumn.AllowEdit = False
        Me.colFechaRecibo.OptionsColumn.ReadOnly = True
        Me.colFechaRecibo.Visible = True
        Me.colFechaRecibo.VisibleIndex = 7
        '
        'rdteFechaRecibo
        '
        Me.rdteFechaRecibo.AutoHeight = False
        Me.rdteFechaRecibo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaRecibo.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaRecibo.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rdteFechaRecibo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rdteFechaRecibo.EditFormat.FormatString = "dd/MM/yyyy"
        Me.rdteFechaRecibo.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rdteFechaRecibo.Mask.EditMask = "dd/MM/yyyy"
        Me.rdteFechaRecibo.Mask.UseMaskAsDisplayFormat = True
        Me.rdteFechaRecibo.Name = "rdteFechaRecibo"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceCell.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        Me.colCodigoArticulo.Width = 100
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceCell.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 225
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowEdit = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 57
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowEdit = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        Me.colCompletado.Width = 57
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPendiente.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowEdit = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 57
        '
        'colHorasPendiente
        '
        Me.colHorasPendiente.AppearanceCell.Options.UseTextOptions = True
        Me.colHorasPendiente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHorasPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHorasPendiente.Caption = "Horas Pendiente"
        Me.colHorasPendiente.FieldName = "HorasPendiente"
        Me.colHorasPendiente.Name = "colHorasPendiente"
        Me.colHorasPendiente.OptionsColumn.AllowEdit = False
        Me.colHorasPendiente.OptionsColumn.ReadOnly = True
        Me.colHorasPendiente.Visible = True
        Me.colHorasPendiente.VisibleIndex = 6
        '
        'colColoresPendientes
        '
        Me.colColoresPendientes.AppearanceHeader.Options.UseTextOptions = True
        Me.colColoresPendientes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColoresPendientes.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColoresPendientes.FieldName = "ColoresPendientes"
        Me.colColoresPendientes.Name = "colColoresPendientes"
        Me.colColoresPendientes.OptionsColumn.AllowEdit = False
        Me.colColoresPendientes.OptionsColumn.ReadOnly = True
        Me.colColoresPendientes.Visible = True
        Me.colColoresPendientes.VisibleIndex = 8
        Me.colColoresPendientes.Width = 200
        '
        'colColorInicio
        '
        Me.colColorInicio.AppearanceCell.Options.UseTextOptions = True
        Me.colColorInicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColorInicio.AppearanceHeader.Options.UseTextOptions = True
        Me.colColorInicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColorInicio.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColorInicio.ColumnEdit = Me.rslueColor
        Me.colColorInicio.FieldName = "ColorInicio"
        Me.colColorInicio.Name = "colColorInicio"
        Me.colColorInicio.Visible = True
        Me.colColorInicio.VisibleIndex = 9
        Me.colColorInicio.Width = 50
        '
        'rslueColor
        '
        Me.rslueColor.AutoHeight = False
        Me.rslueColor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueColor.Name = "rslueColor"
        Me.rslueColor.NullText = ""
        Me.rslueColor.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCliente.ColumnEdit = Me.rslueCliente
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 10
        Me.colCliente.Width = 60
        '
        'rslueCliente
        '
        Me.rslueCliente.AutoHeight = False
        Me.rslueCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCliente.Name = "rslueCliente"
        Me.rslueCliente.NullText = ""
        Me.rslueCliente.View = Me.RepositoryItemSearchLookUpEdit2View
        '
        'RepositoryItemSearchLookUpEdit2View
        '
        Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
        Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colCampaña
        '
        Me.colCampaña.AppearanceCell.Options.UseTextOptions = True
        Me.colCampaña.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampaña.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCampaña.ColumnEdit = Me.rslueCampana
        Me.colCampaña.FieldName = "Campaña"
        Me.colCampaña.Name = "colCampaña"
        Me.colCampaña.Visible = True
        Me.colCampaña.VisibleIndex = 11
        Me.colCampaña.Width = 60
        '
        'rslueCampana
        '
        Me.rslueCampana.AutoHeight = False
        Me.rslueCampana.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCampana.Name = "rslueCampana"
        Me.rslueCampana.NullText = ""
        Me.rslueCampana.View = Me.RepositoryItemSearchLookUpEdit3View
        '
        'RepositoryItemSearchLookUpEdit3View
        '
        Me.RepositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit3View.Name = "RepositoryItemSearchLookUpEdit3View"
        Me.RepositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colFechaDespacho
        '
        Me.colFechaDespacho.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaDespacho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaDespacho.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaDespacho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaDespacho.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFechaDespacho.ColumnEdit = Me.rdteFechaEntrega
        Me.colFechaDespacho.FieldName = "FechaDespacho"
        Me.colFechaDespacho.Name = "colFechaDespacho"
        Me.colFechaDespacho.Visible = True
        Me.colFechaDespacho.VisibleIndex = 12
        Me.colFechaDespacho.Width = 65
        '
        'rdteFechaEntrega
        '
        Me.rdteFechaEntrega.AutoHeight = False
        Me.rdteFechaEntrega.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaEntrega.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFechaEntrega.CalendarTimeProperties.Mask.EditMask = "dd"
        Me.rdteFechaEntrega.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rdteFechaEntrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rdteFechaEntrega.EditFormat.FormatString = "dd/MM/yyyy"
        Me.rdteFechaEntrega.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rdteFechaEntrega.Mask.EditMask = "dd/MM/yyyy"
        Me.rdteFechaEntrega.Mask.UseMaskAsDisplayFormat = True
        Me.rdteFechaEntrega.Name = "rdteFechaEntrega"
        '
        'colObservacion
        '
        Me.colObservacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colObservacion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colObservacion.FieldName = "Observacion"
        Me.colObservacion.Name = "colObservacion"
        Me.colObservacion.Visible = True
        Me.colObservacion.VisibleIndex = 13
        Me.colObservacion.Width = 208
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1314, 405)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.grdEmergenciasProduccion_Plan
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(55, 23)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1239, 362)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.sbdcEmergenciasProduccionCursores
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(55, 385)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lblPlan
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(55, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1239, 23)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSubirPrioridad, Me.barbtnQuitar})
        Me.BarManager2.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnQuitar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSubirPrioridad), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBajarPrioridad)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcEmergenciasProduccionCursores
        Me.Bar2.Text = "Tools"
        '
        'barbtnQuitar
        '
        Me.barbtnQuitar.Caption = "Quitar"
        Me.barbtnQuitar.Enabled = False
        Me.barbtnQuitar.Id = 1
        Me.barbtnQuitar.ImageOptions.Image = CType(resources.GetObject("barbtnQuitar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnQuitar.Name = "barbtnQuitar"
        '
        'barbtnSubirPrioridad
        '
        Me.barbtnSubirPrioridad.Caption = "Subir"
        Me.barbtnSubirPrioridad.Id = 0
        Me.barbtnSubirPrioridad.ImageOptions.Image = CType(resources.GetObject("barbtnSubirPrioridad.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSubirPrioridad.Name = "barbtnSubirPrioridad"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1314, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 667)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1314, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 667)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1314, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 667)
        '
        'frmEmergenciasProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 667)
        Me.Controls.Add(Me.splitEmergenciasProduccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "frmEmergenciasProduccion"
        Me.Text = "frmEmergenciasProduccion"
        CType(Me.splitEmergenciasProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitEmergenciasProduccion.ResumeLayout(False)
        CType(Me.lycListadoProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListadoProduccion.ResumeLayout(False)
        CType(Me.grdProduccionHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmergenciasProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProduccionHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProduccionPadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProduccionPadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rsluePrioridadCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycEmergenciasProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycEmergenciasProduccion.ResumeLayout(False)
        CType(Me.grdEmergenciasProduccion_Plan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEmergenciasProduccion_Plan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaRecibo.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaEntrega.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFechaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents splitEmergenciasProduccion As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lycListadoProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents sbdcEmergenciasProduccion As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents grdProduccionPadres As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProduccionPadres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycEmergenciasProduccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdEmergenciasProduccion_Plan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEmergenciasProduccion_Plan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sbdcEmergenciasProduccionCursores As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSubirPrioridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBajarPrioridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsEmergenciasProduccion1 As waProduccion_Pedidos.dsEmergenciasProduccion
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColoresPendientes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCampaña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaDespacho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridad1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnQuitar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueColor As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCampana As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rdteFechaEntrega As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnReporte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCorreo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdProduccionHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProduccionHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCodigoArticulo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblHijos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblPlan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnDetalleOrdenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colFechaRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rdteFechaRecibo As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colHorasPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnProgramacionProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rsluePrioridadCP As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
