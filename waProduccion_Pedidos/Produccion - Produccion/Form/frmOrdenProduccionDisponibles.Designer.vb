<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenProduccionDisponibles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenProduccionDisponibles))
        Me.lycOrdenProduccionImpresion = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdProduccionDetalle = New DevExpress.XtraGrid.GridControl()
        Me.DsOrdenProduccionImpresion1 = New waProduccion_Pedidos.dsOrdenProduccionImpresion()
        Me.grdviewOrdenesDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente2 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colComentario2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.splitOrdenProduccion = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdProduccionPadres = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProduccionPadres = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcProduccionPadres = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnReciboAplicar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnPrioridad = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.grdProduccionHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProduccionHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.lycOrdenProduccionImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenProduccionImpresion.SuspendLayout()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProduccionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewOrdenesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOrdenProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOrdenProduccion.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.grdProduccionPadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProduccionPadres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycOrdenProduccionImpresion
        '
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtNombreArticulo)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCodigoArticulo)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.grdProduccionDetalle)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.splitOrdenProduccion)
        Me.lycOrdenProduccionImpresion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenProduccionImpresion.Location = New System.Drawing.Point(0, 0)
        Me.lycOrdenProduccionImpresion.Name = "lycOrdenProduccionImpresion"
        Me.lycOrdenProduccionImpresion.Root = Me.LayoutControlGroup1
        Me.lycOrdenProduccionImpresion.Size = New System.Drawing.Size(1492, 698)
        Me.lycOrdenProduccionImpresion.TabIndex = 0
        Me.lycOrdenProduccionImpresion.Text = "LayoutControl1"
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(354, 510)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(1126, 20)
        Me.txtNombreArticulo.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtNombreArticulo.TabIndex = 7
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(106, 510)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(150, 0)
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(150, 0)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoArticulo.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCodigoArticulo.TabIndex = 6
        '
        'grdProduccionDetalle
        '
        Me.grdProduccionDetalle.DataMember = "dsdtProduccionOrden"
        Me.grdProduccionDetalle.DataSource = Me.DsOrdenProduccionImpresion1
        Me.grdProduccionDetalle.Location = New System.Drawing.Point(12, 534)
        Me.grdProduccionDetalle.MainView = Me.grdviewOrdenesDetalle
        Me.grdProduccionDetalle.Name = "grdProduccionDetalle"
        Me.grdProduccionDetalle.Size = New System.Drawing.Size(1468, 152)
        Me.grdProduccionDetalle.TabIndex = 5
        Me.grdProduccionDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenesDetalle})
        '
        'DsOrdenProduccionImpresion1
        '
        Me.DsOrdenProduccionImpresion1.DataSetName = "dsOrdenProduccionImpresion"
        Me.DsOrdenProduccionImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenesDetalle
        '
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.Options.UseFont = True
        Me.grdviewOrdenesDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdviewOrdenesDetalle.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.grdviewOrdenesDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewOrdenesDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesDetalle.Appearance.Row.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.Row.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewOrdenesDetalle.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewOrdenesDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.grdviewOrdenesDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewOrdenesDetalle.ColumnPanelRowHeight = 35
        Me.grdviewOrdenesDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colPlaneado2, Me.colCompletado2, Me.colPendiente2, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado, Me.colOrigen, Me.colDestino, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNumeroOrden, Me.colCampaña, Me.colEntrega, Me.colComentario1, Me.colComentario2, Me.colCreacion})
        Me.grdviewOrdenesDetalle.GridControl = Me.grdProduccionDetalle
        Me.grdviewOrdenesDetalle.Name = "grdviewOrdenesDetalle"
        Me.grdviewOrdenesDetalle.OptionsBehavior.Editable = False
        Me.grdviewOrdenesDetalle.OptionsBehavior.ReadOnly = True
        Me.grdviewOrdenesDetalle.OptionsView.ColumnAutoWidth = False
        Me.grdviewOrdenesDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewOrdenesDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewOrdenesDetalle.OptionsView.ShowFooter = True
        Me.grdviewOrdenesDetalle.OptionsView.ShowGroupPanel = False
        Me.grdviewOrdenesDetalle.PaintStyleName = "Web"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.Caption = "SAP"
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.OptionsColumn.AllowEdit = False
        Me.colNumSAP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumSAP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumSAP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 0
        Me.colNumSAP.Width = 55
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEstado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        Me.colEstado.Width = 70
        '
        'colTipo
        '
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.AllowEdit = False
        Me.colTipo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 70
        '
        'colPlaneado2
        '
        Me.colPlaneado2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado2.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado2.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado2.FieldName = "Planeado"
        Me.colPlaneado2.Name = "colPlaneado2"
        Me.colPlaneado2.OptionsColumn.AllowEdit = False
        Me.colPlaneado2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPlaneado2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPlaneado2.OptionsColumn.ReadOnly = True
        Me.colPlaneado2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPlaneado2.Visible = True
        Me.colPlaneado2.VisibleIndex = 3
        '
        'colCompletado2
        '
        Me.colCompletado2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado2.AppearanceHeader.Options.UseFont = True
        Me.colCompletado2.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado2.FieldName = "Completado"
        Me.colCompletado2.Name = "colCompletado2"
        Me.colCompletado2.OptionsColumn.AllowEdit = False
        Me.colCompletado2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCompletado2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCompletado2.OptionsColumn.ReadOnly = True
        Me.colCompletado2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCompletado2.Visible = True
        Me.colCompletado2.VisibleIndex = 4
        '
        'colPendiente2
        '
        Me.colPendiente2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente2.AppearanceHeader.Options.UseFont = True
        Me.colPendiente2.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente2.FieldName = "Pendiente"
        Me.colPendiente2.Name = "colPendiente2"
        Me.colPendiente2.OptionsColumn.AllowEdit = False
        Me.colPendiente2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPendiente2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPendiente2.OptionsColumn.ReadOnly = True
        Me.colPendiente2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPendiente2.Visible = True
        Me.colPendiente2.VisibleIndex = 5
        '
        'colCreación
        '
        Me.colCreación.AppearanceCell.Options.UseTextOptions = True
        Me.colCreación.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreación.AppearanceHeader.Options.UseFont = True
        Me.colCreación.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreación.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreación.FieldName = "Creación"
        Me.colCreación.Name = "colCreación"
        Me.colCreación.OptionsColumn.AllowEdit = False
        Me.colCreación.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCreación.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCreación.OptionsColumn.ReadOnly = True
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 6
        Me.colCreación.Width = 65
        '
        'colVencimiento
        '
        Me.colVencimiento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimiento.AppearanceHeader.Options.UseFont = True
        Me.colVencimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.Caption = "Vence"
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.OptionsColumn.AllowEdit = False
        Me.colVencimiento.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVencimiento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVencimiento.OptionsColumn.ReadOnly = True
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 7
        Me.colVencimiento.Width = 65
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceCell.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiasAtrasado.AppearanceHeader.Options.UseFont = True
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.Caption = "Dias"
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.OptionsColumn.AllowEdit = False
        Me.colDiasAtrasado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDiasAtrasado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDiasAtrasado.OptionsColumn.ReadOnly = True
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 8
        Me.colDiasAtrasado.Width = 50
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.OptionsColumn.AllowEdit = False
        Me.colOrigen.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colOrigen.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 9
        Me.colOrigen.Width = 70
        '
        'colDestino
        '
        Me.colDestino.AppearanceCell.Options.UseTextOptions = True
        Me.colDestino.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.OptionsColumn.AllowEdit = False
        Me.colDestino.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 10
        Me.colDestino.Width = 70
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupoCliente.AppearanceHeader.Options.UseFont = True
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrupoCliente.Caption = "Grupo Cliente"
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.OptionsColumn.AllowEdit = False
        Me.colGrupoCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colGrupoCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 11
        Me.colGrupoCliente.Width = 72
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCliente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.Caption = "Cliente"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.AllowEdit = False
        Me.colCodigoCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 12
        Me.colCodigoCliente.Width = 72
        '
        'colNumeroOrden
        '
        Me.colNumeroOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumeroOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroOrden.Caption = "Orden"
        Me.colNumeroOrden.FieldName = "NumeroOrden"
        Me.colNumeroOrden.Name = "colNumeroOrden"
        Me.colNumeroOrden.OptionsColumn.AllowEdit = False
        Me.colNumeroOrden.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumeroOrden.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumeroOrden.Visible = True
        Me.colNumeroOrden.VisibleIndex = 13
        Me.colNumeroOrden.Width = 72
        '
        'colCampaña
        '
        Me.colCampaña.AppearanceCell.Options.UseTextOptions = True
        Me.colCampaña.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCampaña.AppearanceHeader.Options.UseFont = True
        Me.colCampaña.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampaña.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCampaña.FieldName = "Campaña"
        Me.colCampaña.Name = "colCampaña"
        Me.colCampaña.OptionsColumn.AllowEdit = False
        Me.colCampaña.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCampaña.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCampaña.Visible = True
        Me.colCampaña.VisibleIndex = 14
        '
        'colEntrega
        '
        Me.colEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEntrega.AppearanceHeader.Options.UseFont = True
        Me.colEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrega.FieldName = "Entrega"
        Me.colEntrega.Name = "colEntrega"
        Me.colEntrega.OptionsColumn.AllowEdit = False
        Me.colEntrega.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEntrega.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEntrega.Visible = True
        Me.colEntrega.VisibleIndex = 15
        Me.colEntrega.Width = 65
        '
        'colComentario1
        '
        Me.colComentario1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentario1.AppearanceHeader.Options.UseFont = True
        Me.colComentario1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentario1.FieldName = "Comentario1"
        Me.colComentario1.Name = "colComentario1"
        Me.colComentario1.OptionsColumn.AllowEdit = False
        Me.colComentario1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComentario1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComentario1.Visible = True
        Me.colComentario1.VisibleIndex = 16
        Me.colComentario1.Width = 250
        '
        'colComentario2
        '
        Me.colComentario2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentario2.AppearanceHeader.Options.UseFont = True
        Me.colComentario2.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentario2.FieldName = "Comentario2"
        Me.colComentario2.Name = "colComentario2"
        Me.colComentario2.OptionsColumn.AllowEdit = False
        Me.colComentario2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComentario2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComentario2.Width = 250
        '
        'colCreacion
        '
        Me.colCreacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreacion.AppearanceHeader.Options.UseFont = True
        Me.colCreacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreacion.FieldName = "Creacion"
        Me.colCreacion.Name = "colCreacion"
        Me.colCreacion.OptionsColumn.AllowEdit = False
        Me.colCreacion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCreacion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCreacion.Visible = True
        Me.colCreacion.VisibleIndex = 17
        Me.colCreacion.Width = 99
        '
        'splitOrdenProduccion
        '
        Me.splitOrdenProduccion.Location = New System.Drawing.Point(12, 12)
        Me.splitOrdenProduccion.Name = "splitOrdenProduccion"
        Me.splitOrdenProduccion.Panel1.Controls.Add(Me.LayoutControl3)
        Me.splitOrdenProduccion.Panel1.Text = "Panel1"
        Me.splitOrdenProduccion.Panel2.Controls.Add(Me.LayoutControl2)
        Me.splitOrdenProduccion.Panel2.Text = "Panel2"
        Me.splitOrdenProduccion.Size = New System.Drawing.Size(1468, 494)
        Me.splitOrdenProduccion.SplitterPosition = 667
        Me.splitOrdenProduccion.TabIndex = 4
        Me.splitOrdenProduccion.Text = "SplitContainerControl1"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.grdProduccionPadres)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(667, 494)
        Me.LayoutControl3.TabIndex = 1
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'grdProduccionPadres
        '
        Me.grdProduccionPadres.DataMember = "dsdtProduccionPadres"
        Me.grdProduccionPadres.DataSource = Me.DsOrdenProduccionImpresion1
        Me.grdProduccionPadres.Location = New System.Drawing.Point(12, 12)
        Me.grdProduccionPadres.MainView = Me.grdviewProduccionPadres
        Me.grdProduccionPadres.Name = "grdProduccionPadres"
        Me.grdProduccionPadres.Size = New System.Drawing.Size(643, 470)
        Me.grdProduccionPadres.TabIndex = 0
        Me.grdProduccionPadres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProduccionPadres})
        '
        'grdviewProduccionPadres
        '
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.Empty.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewProduccionPadres.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray
        Me.grdviewProduccionPadres.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black
        Me.grdviewProduccionPadres.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionPadres.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.grdviewProduccionPadres.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionPadres.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver
        Me.grdviewProduccionPadres.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionPadres.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewProduccionPadres.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewProduccionPadres.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewProduccionPadres.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdviewProduccionPadres.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewProduccionPadres.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProduccionPadres.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionPadres.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionPadres.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewProduccionPadres.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProduccionPadres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente})
        Me.grdviewProduccionPadres.GridControl = Me.grdProduccionPadres
        Me.grdviewProduccionPadres.Name = "grdviewProduccionPadres"
        Me.grdviewProduccionPadres.OptionsBehavior.Editable = False
        Me.grdviewProduccionPadres.OptionsBehavior.ReadOnly = True
        Me.grdviewProduccionPadres.OptionsView.ColumnAutoWidth = False
        Me.grdviewProduccionPadres.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProduccionPadres.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProduccionPadres.OptionsView.ShowFooter = True
        Me.grdviewProduccionPadres.OptionsView.ShowGroupPanel = False
        Me.grdviewProduccionPadres.PaintStyleName = "Flat"
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPrioridad.AppearanceHeader.Options.UseFont = True
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 0
        Me.colPrioridad.Width = 63
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
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodigoArticulo", "Total CP {0:n0}")})
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
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
        Me.colNombreArticulo.VisibleIndex = 2
        Me.colNombreArticulo.Width = 200
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 70
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        Me.colCompletado.Width = 70
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 70
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(667, 494)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.grdProduccionPadres
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(647, 474)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.sbdcProduccionPadres)
        Me.LayoutControl2.Controls.Add(Me.grdProduccionHijos)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(796, 494)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'sbdcProduccionPadres
        '
        Me.sbdcProduccionPadres.CausesValidation = False
        Me.sbdcProduccionPadres.IsVertical = True
        Me.sbdcProduccionPadres.Location = New System.Drawing.Point(12, 12)
        Me.sbdcProduccionPadres.Manager = Me.BarManager1
        Me.sbdcProduccionPadres.Name = "sbdcProduccionPadres"
        Me.sbdcProduccionPadres.Size = New System.Drawing.Size(0, 26)
        Me.sbdcProduccionPadres.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcProduccionPadres)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimir, Me.barbtnActualizar, Me.barbtnCerrar, Me.barbtnReciboAplicar, Me.BarButtonItem1, Me.barbtnBuscar, Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnPrioridad, Me.barbtnHelp})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnReciboAplicar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnPrioridad, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnHelp, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnImprimir
        '
        Me.barbtnImprimir.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producciones"
        Me.barbtnImprimir.Id = 0
        Me.barbtnImprimir.ImageOptions.Image = CType(resources.GetObject("barbtnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimir.Name = "barbtnImprimir"
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 1
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barbtnReciboAplicar
        '
        Me.barbtnReciboAplicar.Caption = "Aplicar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibo"
        Me.barbtnReciboAplicar.Id = 3
        Me.barbtnReciboAplicar.ImageOptions.Image = CType(resources.GetObject("barbtnReciboAplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnReciboAplicar.Name = "barbtnReciboAplicar"
        '
        'barbtnPrioridad
        '
        Me.barbtnPrioridad.Caption = "Prioridad"
        Me.barbtnPrioridad.Id = 8
        Me.barbtnPrioridad.ImageOptions.Image = CType(resources.GetObject("barbtnPrioridad.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPrioridad.Name = "barbtnPrioridad"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 5
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir"
        Me.barbtnImprimirGrid.Id = 6
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar"
        Me.barbtnExportarXlsx.Id = 7
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnHelp
        '
        Me.barbtnHelp.Caption = "Help"
        Me.barbtnHelp.Id = 9
        Me.barbtnHelp.ImageOptions.Image = CType(resources.GetObject("barbtnHelp.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnHelp.Name = "barbtnHelp"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1492, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 698)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1492, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 698)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1492, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 698)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Buscar"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'grdProduccionHijos
        '
        Me.grdProduccionHijos.DataMember = "dsdtProduccionHijos"
        Me.grdProduccionHijos.DataSource = Me.DsOrdenProduccionImpresion1
        Me.grdProduccionHijos.Location = New System.Drawing.Point(12, 12)
        Me.grdProduccionHijos.MainView = Me.grdviewProduccionHijos
        Me.grdProduccionHijos.Name = "grdProduccionHijos"
        Me.grdProduccionHijos.Size = New System.Drawing.Size(772, 470)
        Me.grdProduccionHijos.TabIndex = 0
        Me.grdProduccionHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProduccionHijos})
        '
        'grdviewProduccionHijos
        '
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Empty.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewProduccionHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray
        Me.grdviewProduccionHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver
        Me.grdviewProduccionHijos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewProduccionHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewProduccionHijos.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray
        Me.grdviewProduccionHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo1, Me.colNombreArticulo1, Me.colPlaneado1, Me.colCompletado1, Me.colPendiente1, Me.colProdFinal})
        Me.grdviewProduccionHijos.GridControl = Me.grdProduccionHijos
        Me.grdviewProduccionHijos.Name = "grdviewProduccionHijos"
        Me.grdviewProduccionHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProduccionHijos.OptionsView.ShowFooter = True
        Me.grdviewProduccionHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewProduccionHijos.PaintStyleName = "Flat"
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo1.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 0
        Me.colCodigoArticulo1.Width = 125
        '
        'colNombreArticulo1
        '
        Me.colNombreArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo1.FieldName = "NombreArticulo"
        Me.colNombreArticulo1.Name = "colNombreArticulo1"
        Me.colNombreArticulo1.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo1.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo1.Visible = True
        Me.colNombreArticulo1.VisibleIndex = 1
        Me.colNombreArticulo1.Width = 200
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.OptionsColumn.AllowEdit = False
        Me.colPlaneado1.OptionsColumn.ReadOnly = True
        Me.colPlaneado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 2
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.OptionsColumn.AllowEdit = False
        Me.colCompletado1.OptionsColumn.ReadOnly = True
        Me.colCompletado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 3
        '
        'colPendiente1
        '
        Me.colPendiente1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colPendiente1.AppearanceHeader.Options.UseFont = True
        Me.colPendiente1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente1.FieldName = "Pendiente"
        Me.colPendiente1.Name = "colPendiente1"
        Me.colPendiente1.OptionsColumn.AllowEdit = False
        Me.colPendiente1.OptionsColumn.ReadOnly = True
        Me.colPendiente1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPendiente1.Visible = True
        Me.colPendiente1.VisibleIndex = 4
        '
        'colProdFinal
        '
        Me.colProdFinal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.colProdFinal.AppearanceHeader.Options.UseFont = True
        Me.colProdFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colProdFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        Me.colProdFinal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colProdFinal.Visible = True
        Me.colProdFinal.VisibleIndex = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbdcProduccionPadres
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(33, 414)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(796, 494)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.grdProduccionHijos
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(776, 474)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1492, 698)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.splitOrdenProduccion
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1472, 498)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.grdProduccionDetalle
        Me.LayoutControlItem2.CustomizationFormText = "DETALLE DE ORDENES DE PRODUCCION"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 522)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1472, 156)
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 498)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem3.Text = "Codigo Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtNombreArticulo
        Me.LayoutControlItem4.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(248, 498)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1224, 24)
        Me.LayoutControlItem4.Text = "Nombre Articulo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(91, 13)
        '
        'frmOrdenProduccionDisponibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1492, 741)
        Me.Controls.Add(Me.lycOrdenProduccionImpresion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenProduccionDisponibles"
        Me.Text = "Analisis de ordenes de Producción"
        CType(Me.lycOrdenProduccionImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycOrdenProduccionImpresion.ResumeLayout(False)
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProduccionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewOrdenesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitOrdenProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOrdenProduccion.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.grdProduccionPadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProduccionPadres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProduccionHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProduccionHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycOrdenProduccionImpresion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents splitOrdenProduccion As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grdProduccionPadres As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProduccionPadres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdProduccionHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewProduccionHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdProduccionDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewOrdenesDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsOrdenProduccionImpresion1 As waProduccion_Pedidos.dsOrdenProduccionImpresion
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente2 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colComentario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbdcProduccionPadres As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnReciboAplicar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnPrioridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnHelp As DevExpress.XtraBars.BarButtonItem
End Class
