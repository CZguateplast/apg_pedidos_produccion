<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlProduccion_Ingreso
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlProduccion_Ingreso))
        Me.rspinUnidades = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.rtimeTiempo = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.grdColoresEncabezado = New DevExpress.XtraGrid.GridControl()
        Me.DsControlProduccion_Ingreso1 = New waProduccion_Pedidos.dsControlProduccion_Ingreso()
        Me.grdviewColores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmemoTexto = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.lycIngreso = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dkmIngreso = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAgregarProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAgregarEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lycDatosProducto = New DevExpress.XtraLayout.LayoutControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaquina = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colCodigoArticulo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalUnidades5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesBuenas5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesMalas5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasProducidas5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraInicio5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasFinal5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReporteMalas5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReporteTiempo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rspinUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtimeTiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdColoresEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlProduccion_Ingreso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmemoTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycIngreso.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dkmIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.lycDatosProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosProducto.SuspendLayout()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rspinUnidades
        '
        Me.rspinUnidades.AutoHeight = False
        Me.rspinUnidades.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rspinUnidades.Name = "rspinUnidades"
        '
        'rtimeTiempo
        '
        Me.rtimeTiempo.AutoHeight = False
        Me.rtimeTiempo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rtimeTiempo.DisplayFormat.FormatString = "HH:mm"
        Me.rtimeTiempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rtimeTiempo.EditFormat.FormatString = "HH:mm"
        Me.rtimeTiempo.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rtimeTiempo.Mask.EditMask = "HH:mm"
        Me.rtimeTiempo.Name = "rtimeTiempo"
        Me.rtimeTiempo.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.rtimeTiempo.ValidateOnEnterKey = True
        '
        'grdColoresEncabezado
        '
        Me.grdColoresEncabezado.DataMember = "dsdtColores"
        Me.grdColoresEncabezado.DataSource = Me.DsControlProduccion_Ingreso1
        Me.grdColoresEncabezado.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdColoresEncabezado.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grdColoresEncabezado.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        GridLevelNode1.LevelTemplate = Me.CardView1
        GridLevelNode1.RelationName = "dsdtColores_dsdtTrabajos"
        Me.grdColoresEncabezado.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdColoresEncabezado.Location = New System.Drawing.Point(12, 12)
        Me.grdColoresEncabezado.MainView = Me.grdviewColores
        Me.grdColoresEncabezado.Name = "grdColoresEncabezado"
        Me.grdColoresEncabezado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rtimeTiempo, Me.rspinUnidades, Me.rmemoTexto})
        Me.grdColoresEncabezado.Size = New System.Drawing.Size(931, 511)
        Me.grdColoresEncabezado.TabIndex = 4
        Me.grdColoresEncabezado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewColores, Me.CardView1})
        '
        'DsControlProduccion_Ingreso1
        '
        Me.DsControlProduccion_Ingreso1.DataSetName = "dsControlProduccion_Ingreso"
        Me.DsControlProduccion_Ingreso1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewColores
        '
        Me.grdviewColores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewColores.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewColores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewColores.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewColores.Appearance.Preview.Options.UseFont = True
        Me.grdviewColores.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.Row.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Row.Options.UseForeColor = True
        Me.grdviewColores.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewColores.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewColores.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewColores.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewColores.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewColores.ColumnPanelRowHeight = 35
        Me.grdviewColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCodigoPadre, Me.colColor, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProdFinal, Me.colTipoMaterial})
        Me.grdviewColores.GridControl = Me.grdColoresEncabezado
        Me.grdviewColores.Name = "grdviewColores"
        Me.grdviewColores.OptionsDetail.AllowExpandEmptyDetails = True
        Me.grdviewColores.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.grdviewColores.OptionsDetail.AutoZoomDetail = True
        Me.grdviewColores.OptionsDetail.ShowDetailTabs = False
        Me.grdviewColores.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdviewColores.OptionsView.ColumnAutoWidth = False
        Me.grdviewColores.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewColores.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewColores.OptionsView.ShowFooter = True
        Me.grdviewColores.OptionsView.ShowGroupPanel = False
        Me.grdviewColores.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdviewColores.PaintStyleName = "Web"
        Me.grdviewColores.RowHeight = 25
        Me.grdviewColores.RowSeparatorHeight = 10
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoArticulo.Caption = "Codigo"
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodigoArticulo", "{0}")})
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 167
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNombreArticulo.Caption = "Nombre Articulo"
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 250
        '
        'colCodigoPadre
        '
        Me.colCodigoPadre.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPadre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPadre.Caption = "Codigo Padre"
        Me.colCodigoPadre.FieldName = "CodigoPadre"
        Me.colCodigoPadre.Name = "colCodigoPadre"
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor.Caption = "Color"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.AllowEdit = False
        Me.colColor.OptionsColumn.ReadOnly = True
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 2
        Me.colColor.Width = 60
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPlaneado.Caption = "Planeado"
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowEdit = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 100
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompletado.Caption = "Completado"
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowEdit = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        Me.colCompletado.Width = 100
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPendiente.Caption = "Pendiente"
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowEdit = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 100
        '
        'colProdFinal
        '
        Me.colProdFinal.Caption = "Prod Final"
        Me.colProdFinal.FieldName = "Prod Final"
        Me.colProdFinal.Name = "colProdFinal"
        Me.colProdFinal.Width = 90
        '
        'colTipoMaterial
        '
        Me.colTipoMaterial.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTipoMaterial.Caption = "Tipo Material"
        Me.colTipoMaterial.FieldName = "TipoMaterial"
        Me.colTipoMaterial.Name = "colTipoMaterial"
        Me.colTipoMaterial.OptionsColumn.AllowEdit = False
        Me.colTipoMaterial.OptionsColumn.ReadOnly = True
        Me.colTipoMaterial.Visible = True
        Me.colTipoMaterial.VisibleIndex = 6
        Me.colTipoMaterial.Width = 135
        '
        'rmemoTexto
        '
        Me.rmemoTexto.Name = "rmemoTexto"
        '
        'lycIngreso
        '
        Me.lycIngreso.Controls.Add(Me.grdColoresEncabezado)
        Me.lycIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycIngreso.Location = New System.Drawing.Point(0, 29)
        Me.lycIngreso.Name = "lycIngreso"
        Me.lycIngreso.Root = Me.LayoutControlGroup1
        Me.lycIngreso.Size = New System.Drawing.Size(955, 578)
        Me.lycIngreso.TabIndex = 0
        Me.lycIngreso.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(955, 578)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.grdColoresEncabezado
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(935, 515)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 515)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(935, 43)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'dkmIngreso
        '
        Me.dkmIngreso.Form = Me
        Me.dkmIngreso.MenuManager = Me.BarManager1
        Me.dkmIngreso.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.dkmIngreso.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.dkmIngreso
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnBuscar, Me.barbtnAgregarProduccion, Me.barbtnAgregarEnsamble})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAgregarProduccion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAgregarEnsamble, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 1
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnAgregarProduccion
        '
        Me.barbtnAgregarProduccion.Caption = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producción"
        Me.barbtnAgregarProduccion.Id = 2
        Me.barbtnAgregarProduccion.ImageOptions.Image = CType(resources.GetObject("barbtnAgregarProduccion.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregarProduccion.Name = "barbtnAgregarProduccion"
        '
        'barbtnAgregarEnsamble
        '
        Me.barbtnAgregarEnsamble.Caption = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ensamble"
        Me.barbtnAgregarEnsamble.Id = 3
        Me.barbtnAgregarEnsamble.ImageOptions.Image = CType(resources.GetObject("barbtnAgregarEnsamble.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregarEnsamble.Name = "barbtnAgregarEnsamble"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1207, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 607)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1207, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 578)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1207, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 578)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("7b226f24-658f-40d1-9fe0-0cfb9a6aa311")
        Me.DockPanel1.Location = New System.Drawing.Point(955, 29)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowDockFill = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(252, 224)
        Me.DockPanel1.Size = New System.Drawing.Size(252, 578)
        Me.DockPanel1.Text = "Datos de Producción"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.lycDatosProducto)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(243, 551)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'lycDatosProducto
        '
        Me.lycDatosProducto.Controls.Add(Me.dteFecha)
        Me.lycDatosProducto.Controls.Add(Me.SearchLookUpEdit2)
        Me.lycDatosProducto.Controls.Add(Me.SearchLookUpEdit1)
        Me.lycDatosProducto.Controls.Add(Me.txtCodigo)
        Me.lycDatosProducto.Controls.Add(Me.TextEdit2)
        Me.lycDatosProducto.Controls.Add(Me.txtMaquina)
        Me.lycDatosProducto.Controls.Add(Me.TextEdit4)
        Me.lycDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycDatosProducto.Location = New System.Drawing.Point(0, 0)
        Me.lycDatosProducto.Name = "lycDatosProducto"
        Me.lycDatosProducto.Root = Me.LayoutControlGroup2
        Me.lycDatosProducto.Size = New System.Drawing.Size(243, 551)
        Me.lycDatosProducto.TabIndex = 0
        Me.lycDatosProducto.Text = "LayoutControl1"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(68, 256)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Size = New System.Drawing.Size(151, 20)
        Me.dteFecha.StyleController = Me.lycDatosProducto
        Me.dteFecha.TabIndex = 10
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(68, 304)
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.NullText = ""
        Me.SearchLookUpEdit2.Properties.View = Me.SearchLookUpEdit2View
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(151, 20)
        Me.SearchLookUpEdit2.StyleController = Me.lycDatosProducto
        Me.SearchLookUpEdit2.TabIndex = 9
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(68, 280)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(151, 20)
        Me.SearchLookUpEdit1.StyleController = Me.lycDatosProducto
        Me.SearchLookUpEdit1.TabIndex = 8
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(68, 132)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(151, 20)
        Me.txtCodigo.StyleController = Me.lycDatosProducto
        Me.txtCodigo.TabIndex = 6
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(68, 66)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(151, 20)
        Me.TextEdit2.StyleController = Me.lycDatosProducto
        Me.TextEdit2.TabIndex = 5
        '
        'txtMaquina
        '
        Me.txtMaquina.Location = New System.Drawing.Point(68, 42)
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Size = New System.Drawing.Size(151, 20)
        Me.txtMaquina.StyleController = Me.lycDatosProducto
        Me.txtMaquina.TabIndex = 4
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(68, 156)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(151, 54)
        Me.TextEdit4.StyleController = Me.lycDatosProducto
        Me.TextEdit4.TabIndex = 7
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 551)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(223, 90)
        Me.LayoutControlGroup3.Text = "Maquina"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextEdit2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem2.Text = "Peso"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtMaquina
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem1.Text = "Maquina"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(223, 124)
        Me.LayoutControlGroup4.Text = "Componente / Articulo"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit4
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(199, 58)
        Me.LayoutControlItem4.Text = "Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCodigo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem3.Text = "Codigo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem7})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 214)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(223, 114)
        Me.LayoutControlGroup5.Text = "Turno"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SearchLookUpEdit2
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem6.Text = "Turno:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem5.Text = "Horario:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dteFecha
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem7.Text = "Fecha:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(41, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 328)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(223, 203)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'CardView1
        '
        Me.CardView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.DodgerBlue
        Me.CardView1.Appearance.FieldCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CardView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.White
        Me.CardView1.Appearance.FieldCaption.Options.UseBackColor = True
        Me.CardView1.Appearance.FieldCaption.Options.UseFont = True
        Me.CardView1.Appearance.FieldCaption.Options.UseForeColor = True
        Me.CardView1.Appearance.FieldCaption.Options.UseTextOptions = True
        Me.CardView1.Appearance.FieldCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo5, Me.colTotalUnidades5, Me.colUnidadesBuenas5, Me.colUnidadesMalas5, Me.colHorasProducidas5, Me.colHoraInicio5, Me.colHorasFinal5, Me.colReporteMalas5, Me.colReporteTiempo5})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.grdColoresEncabezado
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsView.ShowFieldHints = False
        Me.CardView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.CardView1.OptionsView.ShowViewCaption = True
        Me.CardView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colHorasProducidas5, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CardView1.ViewCaption = "Ingreso de Produccion"
        Me.CardView1.ViewCaptionHeight = 35
        '
        'colCodigoArticulo5
        '
        Me.colCodigoArticulo5.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo5.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo5.Caption = "Codigo"
        Me.colCodigoArticulo5.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo5.Name = "colCodigoArticulo5"
        Me.colCodigoArticulo5.Visible = True
        Me.colCodigoArticulo5.VisibleIndex = 0
        '
        'colTotalUnidades5
        '
        Me.colTotalUnidades5.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalUnidades5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalUnidades5.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalUnidades5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalUnidades5.Caption = "Total U"
        Me.colTotalUnidades5.FieldName = "TotalUnidades"
        Me.colTotalUnidades5.Name = "colTotalUnidades5"
        Me.colTotalUnidades5.Visible = True
        Me.colTotalUnidades5.VisibleIndex = 1
        '
        'colUnidadesBuenas5
        '
        Me.colUnidadesBuenas5.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidadesBuenas5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesBuenas5.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesBuenas5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesBuenas5.Caption = "U. Buenas"
        Me.colUnidadesBuenas5.ColumnEdit = Me.rspinUnidades
        Me.colUnidadesBuenas5.CustomizationCaption = "Unidades Buenas"
        Me.colUnidadesBuenas5.FieldName = "UnidadesBuenas"
        Me.colUnidadesBuenas5.Name = "colUnidadesBuenas5"
        Me.colUnidadesBuenas5.Visible = True
        Me.colUnidadesBuenas5.VisibleIndex = 2
        '
        'colUnidadesMalas5
        '
        Me.colUnidadesMalas5.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidadesMalas5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesMalas5.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesMalas5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesMalas5.Caption = "U. Malas"
        Me.colUnidadesMalas5.ColumnEdit = Me.rspinUnidades
        Me.colUnidadesMalas5.FieldName = "UnidadesMalas"
        Me.colUnidadesMalas5.Name = "colUnidadesMalas5"
        Me.colUnidadesMalas5.Visible = True
        Me.colUnidadesMalas5.VisibleIndex = 3
        '
        'colHorasProducidas5
        '
        Me.colHorasProducidas5.AppearanceCell.Options.UseTextOptions = True
        Me.colHorasProducidas5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasProducidas5.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasProducidas5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasProducidas5.Caption = "H. Producidas"
        Me.colHorasProducidas5.ColumnEdit = Me.rtimeTiempo
        Me.colHorasProducidas5.FieldName = "HorasProducidas"
        Me.colHorasProducidas5.Name = "colHorasProducidas5"
        Me.colHorasProducidas5.Visible = True
        Me.colHorasProducidas5.VisibleIndex = 4
        '
        'colHoraInicio5
        '
        Me.colHoraInicio5.AppearanceCell.Options.UseTextOptions = True
        Me.colHoraInicio5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraInicio5.AppearanceHeader.Options.UseTextOptions = True
        Me.colHoraInicio5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraInicio5.Caption = "H. Inicio"
        Me.colHoraInicio5.ColumnEdit = Me.rtimeTiempo
        Me.colHoraInicio5.FieldName = "HoraInicio"
        Me.colHoraInicio5.Name = "colHoraInicio5"
        Me.colHoraInicio5.Visible = True
        Me.colHoraInicio5.VisibleIndex = 5
        '
        'colHorasFinal5
        '
        Me.colHorasFinal5.AppearanceCell.Options.UseTextOptions = True
        Me.colHorasFinal5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasFinal5.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasFinal5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHorasFinal5.Caption = "H. Final"
        Me.colHorasFinal5.ColumnEdit = Me.rtimeTiempo
        Me.colHorasFinal5.FieldName = "HoraFinal"
        Me.colHorasFinal5.Name = "colHorasFinal5"
        Me.colHorasFinal5.Visible = True
        Me.colHorasFinal5.VisibleIndex = 6
        '
        'colReporteMalas5
        '
        Me.colReporteMalas5.AppearanceCell.Options.UseTextOptions = True
        Me.colReporteMalas5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReporteMalas5.AppearanceHeader.Options.UseTextOptions = True
        Me.colReporteMalas5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colReporteMalas5.Caption = "Reporte Malas"
        Me.colReporteMalas5.FieldName = "ReporteMalas"
        Me.colReporteMalas5.Name = "colReporteMalas5"
        Me.colReporteMalas5.Visible = True
        Me.colReporteMalas5.VisibleIndex = 7
        '
        'colReporteTiempo5
        '
        Me.colReporteTiempo5.AppearanceCell.Options.UseTextOptions = True
        Me.colReporteTiempo5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colReporteTiempo5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReporteTiempo5.AppearanceHeader.Options.UseTextOptions = True
        Me.colReporteTiempo5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colReporteTiempo5.Caption = "Tiempo Perdido"
        Me.colReporteTiempo5.FieldName = "ReporteTiempo"
        Me.colReporteTiempo5.Name = "colReporteTiempo5"
        Me.colReporteTiempo5.Visible = True
        Me.colReporteTiempo5.VisibleIndex = 8
        '
        'frmControlProduccion_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycIngreso)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.Name = "frmControlProduccion_Ingreso"
        Me.Text = "Ingreso de Producción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rspinUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtimeTiempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdColoresEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlProduccion_Ingreso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmemoTexto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycIngreso.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dkmIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.lycDatosProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosProducto.ResumeLayout(False)
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycIngreso As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dkmIngreso As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lycDatosProducto As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaquina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdColoresEncabezado As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsControlProduccion_Ingreso1 As waProduccion_Pedidos.dsControlProduccion_Ingreso
    Friend WithEvents rspinUnidades As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rtimeTiempo As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grdviewColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rmemoTexto As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnAgregarProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAgregarEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents colCodigoArticulo5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalUnidades5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesBuenas5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesMalas5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasProducidas5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraInicio5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasFinal5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReporteMalas5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReporteTiempo5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
