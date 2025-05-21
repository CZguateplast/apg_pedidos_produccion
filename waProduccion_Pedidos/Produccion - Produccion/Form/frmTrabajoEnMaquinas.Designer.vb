<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrabajoEnMaquinas
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrabajoEnMaquinas))
        Me.colEstado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.lycTrabajoEnMaquinas = New DevExpress.XtraLayout.LayoutControl()
        Me.grdTrabajoEnMaquinas = New DevExpress.XtraGrid.GridControl()
        Me.DsTrabajoEnMaquinas1 = New waProduccion_Pedidos.dsTrabajoEnMaquinas()
        Me.lyvTrabajoEnMaquina = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPreferencial = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPrioridadMaquina = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rmmeNombreArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colProduccionHora = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colHorasPendiente = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rmmeComentarios = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnFiltroEnProceso = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnFitroEnPausa = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnFiltroBodega = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnFiltroFabrica = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.timeTrabajoEnMaquina = New System.Windows.Forms.Timer(Me.components)
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPlaneado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPendiente = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPreferencial = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEstado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colCodigoArticulo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colNombreArticulo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colCompletado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colComentarios = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPrioridad = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPrioridadMaquina = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colProduccionHora = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colHorasPendiente = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        CType(Me.lycTrabajoEnMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTrabajoEnMaquinas.SuspendLayout()
        CType(Me.grdTrabajoEnMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrabajoEnMaquinas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyvTrabajoEnMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeNombreArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPlaneado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPreferencial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colNombreArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCompletado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPrioridadMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colProduccionHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colHorasPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.LayoutViewField = Me.layoutViewField_colEstado
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        '
        'lycTrabajoEnMaquinas
        '
        Me.lycTrabajoEnMaquinas.Controls.Add(Me.grdTrabajoEnMaquinas)
        Me.lycTrabajoEnMaquinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTrabajoEnMaquinas.Location = New System.Drawing.Point(0, 31)
        Me.lycTrabajoEnMaquinas.Name = "lycTrabajoEnMaquinas"
        Me.lycTrabajoEnMaquinas.Root = Me.LayoutControlGroup1
        Me.lycTrabajoEnMaquinas.Size = New System.Drawing.Size(1311, 699)
        Me.lycTrabajoEnMaquinas.TabIndex = 0
        Me.lycTrabajoEnMaquinas.Text = "LayoutControl1"
        '
        'grdTrabajoEnMaquinas
        '
        Me.grdTrabajoEnMaquinas.DataMember = "dsdtTrabajoEnMaquina"
        Me.grdTrabajoEnMaquinas.DataSource = Me.DsTrabajoEnMaquinas1
        Me.grdTrabajoEnMaquinas.Location = New System.Drawing.Point(12, 12)
        Me.grdTrabajoEnMaquinas.MainView = Me.lyvTrabajoEnMaquina
        Me.grdTrabajoEnMaquinas.MenuManager = Me.BarManager1
        Me.grdTrabajoEnMaquinas.Name = "grdTrabajoEnMaquinas"
        Me.grdTrabajoEnMaquinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rmmeNombreArticulo, Me.rmmeComentarios})
        Me.grdTrabajoEnMaquinas.Size = New System.Drawing.Size(1287, 675)
        Me.grdTrabajoEnMaquinas.TabIndex = 4
        Me.grdTrabajoEnMaquinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lyvTrabajoEnMaquina})
        '
        'DsTrabajoEnMaquinas1
        '
        Me.DsTrabajoEnMaquinas1.DataSetName = "dsTrabajoEnMaquinas"
        Me.DsTrabajoEnMaquinas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lyvTrabajoEnMaquina
        '
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.lyvTrabajoEnMaquina.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.Options.UseBackColor = True
        Me.lyvTrabajoEnMaquina.Appearance.FilterPanel.Options.UseForeColor = True
        Me.lyvTrabajoEnMaquina.CardHorzInterval = 15
        Me.lyvTrabajoEnMaquina.CardMinSize = New System.Drawing.Size(240, 102)
        Me.lyvTrabajoEnMaquina.CardVertInterval = 0
        Me.lyvTrabajoEnMaquina.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colUbicacion, Me.colPreferencial, Me.colEstado, Me.colPrioridad, Me.colPrioridadMaquina, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProduccionHora, Me.colHorasPendiente, Me.colComentarios})
        Me.lyvTrabajoEnMaquina.DetailHeight = 500
        GridFormatRule1.Column = Me.colEstado
        GridFormatRule1.ColumnApplyTo = Me.colEstado
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Green
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "En Proceso"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colEstado
        GridFormatRule2.ColumnApplyTo = Me.colEstado
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "En Espera"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.lyvTrabajoEnMaquina.FormatRules.Add(GridFormatRule1)
        Me.lyvTrabajoEnMaquina.FormatRules.Add(GridFormatRule2)
        Me.lyvTrabajoEnMaquina.GridControl = Me.grdTrabajoEnMaquinas
        Me.lyvTrabajoEnMaquina.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colPrioridad, Me.layoutViewField_colPrioridadMaquina, Me.layoutViewField_colProduccionHora, Me.layoutViewField_colHorasPendiente})
        Me.lyvTrabajoEnMaquina.Name = "lyvTrabajoEnMaquina"
        Me.lyvTrabajoEnMaquina.OptionsItemText.TextToControlDistance = 0
        Me.lyvTrabajoEnMaquina.OptionsView.ShowCardCaption = False
        Me.lyvTrabajoEnMaquina.OptionsView.ShowCardExpandButton = False
        Me.lyvTrabajoEnMaquina.OptionsView.ShowHeaderPanel = False
        Me.lyvTrabajoEnMaquina.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.lyvTrabajoEnMaquina.TemplateCard = Me.LayoutViewCard1
        '
        'colUbicacion
        '
        Me.colUbicacion.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colUbicacion.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.colUbicacion.AppearanceCell.Options.UseFont = True
        Me.colUbicacion.AppearanceCell.Options.UseForeColor = True
        Me.colUbicacion.AppearanceCell.Options.UseTextOptions = True
        Me.colUbicacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colUbicacion.Name = "colUbicacion"
        '
        'colPreferencial
        '
        Me.colPreferencial.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.colPreferencial.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.colPreferencial.AppearanceCell.Options.UseFont = True
        Me.colPreferencial.AppearanceCell.Options.UseForeColor = True
        Me.colPreferencial.AppearanceCell.Options.UseTextOptions = True
        Me.colPreferencial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreferencial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPreferencial.AppearanceHeader.Options.UseFont = True
        Me.colPreferencial.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreferencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPreferencial.FieldName = "Preferencial"
        Me.colPreferencial.LayoutViewField = Me.layoutViewField_colPreferencial
        Me.colPreferencial.Name = "colPreferencial"
        Me.colPreferencial.OptionsColumn.AllowEdit = False
        Me.colPreferencial.OptionsColumn.ReadOnly = True
        '
        'colPrioridad
        '
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.LayoutViewField = Me.layoutViewField_colPrioridad
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.OptionsColumn.AllowEdit = False
        Me.colPrioridad.OptionsColumn.ReadOnly = True
        '
        'colPrioridadMaquina
        '
        Me.colPrioridadMaquina.FieldName = "PrioridadMaquina"
        Me.colPrioridadMaquina.LayoutViewField = Me.layoutViewField_colPrioridadMaquina
        Me.colPrioridadMaquina.Name = "colPrioridadMaquina"
        Me.colPrioridadMaquina.OptionsColumn.AllowEdit = False
        Me.colPrioridadMaquina.OptionsColumn.ReadOnly = True
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.LayoutViewField = Me.layoutViewField_colCodigoArticulo
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.ColumnEdit = Me.rmmeNombreArticulo
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.LayoutViewField = Me.layoutViewField_colNombreArticulo
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        '
        'rmmeNombreArticulo
        '
        Me.rmmeNombreArticulo.Name = "rmmeNombreArticulo"
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.colPlaneado.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPlaneado.DisplayFormat.FormatString = "{0:n0}"
        Me.colPlaneado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.LayoutViewField = Me.layoutViewField_colPlaneado
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowEdit = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.colCompletado.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCompletado.DisplayFormat.FormatString = "{0:n0}"
        Me.colCompletado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.LayoutViewField = Me.layoutViewField_colCompletado
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowEdit = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPendiente.DisplayFormat.FormatString = "{0:n0}"
        Me.colPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.LayoutViewField = Me.layoutViewField_colPendiente
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowEdit = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        '
        'colProduccionHora
        '
        Me.colProduccionHora.AppearanceCell.Options.UseTextOptions = True
        Me.colProduccionHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProduccionHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduccionHora.AppearanceHeader.Options.UseFont = True
        Me.colProduccionHora.FieldName = "ProduccionHora"
        Me.colProduccionHora.LayoutViewField = Me.layoutViewField_colProduccionHora
        Me.colProduccionHora.Name = "colProduccionHora"
        Me.colProduccionHora.OptionsColumn.AllowEdit = False
        Me.colProduccionHora.OptionsColumn.ReadOnly = True
        '
        'colHorasPendiente
        '
        Me.colHorasPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colHorasPendiente.AppearanceHeader.Options.UseFont = True
        Me.colHorasPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colHorasPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHorasPendiente.FieldName = "HorasPendiente"
        Me.colHorasPendiente.LayoutViewField = Me.layoutViewField_colHorasPendiente
        Me.colHorasPendiente.Name = "colHorasPendiente"
        Me.colHorasPendiente.OptionsColumn.AllowEdit = False
        Me.colHorasPendiente.OptionsColumn.ReadOnly = True
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceCell.Options.UseTextOptions = True
        Me.colComentarios.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComentarios.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colComentarios.ColumnEdit = Me.rmmeComentarios
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.LayoutViewField = Me.layoutViewField_colComentarios
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.AllowEdit = False
        Me.colComentarios.OptionsColumn.ReadOnly = True
        '
        'rmmeComentarios
        '
        Me.rmmeComentarios.Name = "rmmeComentarios"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnBuscar, Me.barbtnImprimirGrid, Me.BarButtonItem1, Me.barbtnFiltroEnProceso, Me.barbtnFitroEnPausa, Me.barbtnRecibos, Me.barbtnFiltroBodega, Me.barbtnFiltroFabrica})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFiltroEnProceso), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFitroEnPausa), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFiltroBodega), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFiltroFabrica)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnFiltroEnProceso
        '
        Me.barbtnFiltroEnProceso.Caption = "Maquinas en Proceso"
        Me.barbtnFiltroEnProceso.Id = 7
        Me.barbtnFiltroEnProceso.ImageOptions.Image = CType(resources.GetObject("barbtnFiltroEnProceso.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFiltroEnProceso.ImageOptions.LargeImage = CType(resources.GetObject("barbtnFiltroEnProceso.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnFiltroEnProceso.Name = "barbtnFiltroEnProceso"
        '
        'barbtnFitroEnPausa
        '
        Me.barbtnFitroEnPausa.Caption = "Maquinas en Pausa"
        Me.barbtnFitroEnPausa.Id = 8
        Me.barbtnFitroEnPausa.ImageOptions.Image = CType(resources.GetObject("barbtnFitroEnPausa.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFitroEnPausa.ImageOptions.LargeImage = CType(resources.GetObject("barbtnFitroEnPausa.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnFitroEnPausa.Name = "barbtnFitroEnPausa"
        '
        'barbtnFiltroBodega
        '
        Me.barbtnFiltroBodega.Caption = "Maquinas Bodega"
        Me.barbtnFiltroBodega.Id = 10
        Me.barbtnFiltroBodega.ImageOptions.Image = CType(resources.GetObject("barbtnFiltroBodega.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFiltroBodega.ImageOptions.LargeImage = CType(resources.GetObject("barbtnFiltroBodega.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnFiltroBodega.Name = "barbtnFiltroBodega"
        '
        'barbtnFiltroFabrica
        '
        Me.barbtnFiltroFabrica.Caption = "Maquinas Fabrica"
        Me.barbtnFiltroFabrica.Id = 11
        Me.barbtnFiltroFabrica.ImageOptions.Image = CType(resources.GetObject("barbtnFiltroFabrica.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFiltroFabrica.ImageOptions.LargeImage = CType(resources.GetObject("barbtnFiltroFabrica.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnFiltroFabrica.Name = "barbtnFiltroFabrica"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnRecibos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir Grid"
        Me.barbtnImprimirGrid.Id = 2
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
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
        'barbtnRecibos
        '
        Me.barbtnRecibos.Caption = "Recibos"
        Me.barbtnRecibos.Id = 9
        Me.barbtnRecibos.ImageOptions.Image = CType(resources.GetObject("barbtnRecibos.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnRecibos.Name = "barbtnRecibos"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1311, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 730)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1311, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 699)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1311, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 699)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1311, 699)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTrabajoEnMaquinas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1291, 679)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'timeTrabajoEnMaquina
        '
        Me.timeTrabajoEnMaquina.Interval = 10000
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_colPlaneado, Me.layoutViewField_colPendiente, Me.layoutViewField_colPreferencial, Me.layoutViewField_colEstado, Me.layoutViewField_colCodigoArticulo, Me.layoutViewField_colNombreArticulo, Me.layoutViewField_colCompletado, Me.layoutViewField_colComentarios})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 0
        Me.LayoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 68
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(52, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(68, 20)
        Me.layoutViewField_LayoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1.TextVisible = False
        '
        'layoutViewField_colPlaneado
        '
        Me.layoutViewField_colPlaneado.EditorPreferredWidth = 60
        Me.layoutViewField_colPlaneado.Location = New System.Drawing.Point(0, 40)
        Me.layoutViewField_colPlaneado.Name = "layoutViewField_colPlaneado"
        Me.layoutViewField_colPlaneado.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colPlaneado.Size = New System.Drawing.Size(121, 20)
        Me.layoutViewField_colPlaneado.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colPlaneado.TextSize = New System.Drawing.Size(61, 13)
        '
        'layoutViewField_colPendiente
        '
        Me.layoutViewField_colPendiente.EditorPreferredWidth = 60
        Me.layoutViewField_colPendiente.Location = New System.Drawing.Point(0, 80)
        Me.layoutViewField_colPendiente.Name = "layoutViewField_colPendiente"
        Me.layoutViewField_colPendiente.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colPendiente.Size = New System.Drawing.Size(121, 22)
        Me.layoutViewField_colPendiente.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colPendiente.TextSize = New System.Drawing.Size(61, 13)
        '
        'layoutViewField_colPreferencial
        '
        Me.layoutViewField_colPreferencial.EditorPreferredWidth = 52
        Me.layoutViewField_colPreferencial.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPreferencial.Name = "layoutViewField_colPreferencial"
        Me.layoutViewField_colPreferencial.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colPreferencial.Size = New System.Drawing.Size(52, 20)
        Me.layoutViewField_colPreferencial.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colPreferencial.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPreferencial.TextVisible = False
        '
        'layoutViewField_colEstado
        '
        Me.layoutViewField_colEstado.EditorPreferredWidth = 120
        Me.layoutViewField_colEstado.Location = New System.Drawing.Point(120, 0)
        Me.layoutViewField_colEstado.Name = "layoutViewField_colEstado"
        Me.layoutViewField_colEstado.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colEstado.Size = New System.Drawing.Size(120, 20)
        Me.layoutViewField_colEstado.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colEstado.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEstado.TextVisible = False
        '
        'layoutViewField_colCodigoArticulo
        '
        Me.layoutViewField_colCodigoArticulo.EditorPreferredWidth = 79
        Me.layoutViewField_colCodigoArticulo.Location = New System.Drawing.Point(0, 20)
        Me.layoutViewField_colCodigoArticulo.Name = "layoutViewField_colCodigoArticulo"
        Me.layoutViewField_colCodigoArticulo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colCodigoArticulo.Size = New System.Drawing.Size(79, 20)
        Me.layoutViewField_colCodigoArticulo.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colCodigoArticulo.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCodigoArticulo.TextVisible = False
        '
        'layoutViewField_colNombreArticulo
        '
        Me.layoutViewField_colNombreArticulo.EditorPreferredWidth = 161
        Me.layoutViewField_colNombreArticulo.Location = New System.Drawing.Point(79, 20)
        Me.layoutViewField_colNombreArticulo.Name = "layoutViewField_colNombreArticulo"
        Me.layoutViewField_colNombreArticulo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colNombreArticulo.Size = New System.Drawing.Size(161, 20)
        Me.layoutViewField_colNombreArticulo.StartNewLine = True
        Me.layoutViewField_colNombreArticulo.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colNombreArticulo.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colNombreArticulo.TextVisible = False
        '
        'layoutViewField_colCompletado
        '
        Me.layoutViewField_colCompletado.EditorPreferredWidth = 60
        Me.layoutViewField_colCompletado.Location = New System.Drawing.Point(0, 60)
        Me.layoutViewField_colCompletado.Name = "layoutViewField_colCompletado"
        Me.layoutViewField_colCompletado.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colCompletado.Size = New System.Drawing.Size(121, 20)
        Me.layoutViewField_colCompletado.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colCompletado.TextSize = New System.Drawing.Size(61, 13)
        '
        'layoutViewField_colComentarios
        '
        Me.layoutViewField_colComentarios.EditorPreferredWidth = 119
        Me.layoutViewField_colComentarios.Location = New System.Drawing.Point(121, 40)
        Me.layoutViewField_colComentarios.Name = "layoutViewField_colComentarios"
        Me.layoutViewField_colComentarios.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colComentarios.Size = New System.Drawing.Size(119, 62)
        Me.layoutViewField_colComentarios.StartNewLine = True
        Me.layoutViewField_colComentarios.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colComentarios.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colComentarios.TextVisible = False
        '
        'layoutViewField_colPrioridad
        '
        Me.layoutViewField_colPrioridad.EditorPreferredWidth = 20
        Me.layoutViewField_colPrioridad.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPrioridad.Name = "layoutViewField_colPrioridad"
        Me.layoutViewField_colPrioridad.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colPrioridad.Size = New System.Drawing.Size(235, 137)
        Me.layoutViewField_colPrioridad.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colPrioridad.TextSize = New System.Drawing.Size(89, 20)
        '
        'layoutViewField_colPrioridadMaquina
        '
        Me.layoutViewField_colPrioridadMaquina.EditorPreferredWidth = 20
        Me.layoutViewField_colPrioridadMaquina.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPrioridadMaquina.Name = "layoutViewField_colPrioridadMaquina"
        Me.layoutViewField_colPrioridadMaquina.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colPrioridadMaquina.Size = New System.Drawing.Size(235, 137)
        Me.layoutViewField_colPrioridadMaquina.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colPrioridadMaquina.TextSize = New System.Drawing.Size(89, 20)
        '
        'layoutViewField_colProduccionHora
        '
        Me.layoutViewField_colProduccionHora.EditorPreferredWidth = 20
        Me.layoutViewField_colProduccionHora.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colProduccionHora.Name = "layoutViewField_colProduccionHora"
        Me.layoutViewField_colProduccionHora.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colProduccionHora.Size = New System.Drawing.Size(235, 137)
        Me.layoutViewField_colProduccionHora.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colProduccionHora.TextSize = New System.Drawing.Size(83, 13)
        '
        'layoutViewField_colHorasPendiente
        '
        Me.layoutViewField_colHorasPendiente.EditorPreferredWidth = 20
        Me.layoutViewField_colHorasPendiente.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colHorasPendiente.Name = "layoutViewField_colHorasPendiente"
        Me.layoutViewField_colHorasPendiente.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colHorasPendiente.Size = New System.Drawing.Size(235, 137)
        Me.layoutViewField_colHorasPendiente.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colHorasPendiente.TextSize = New System.Drawing.Size(83, 13)
        '
        'frmTrabajoEnMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 773)
        Me.Controls.Add(Me.lycTrabajoEnMaquinas)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTrabajoEnMaquinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trabajo en Maquina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lycTrabajoEnMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTrabajoEnMaquinas.ResumeLayout(False)
        CType(Me.grdTrabajoEnMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrabajoEnMaquinas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyvTrabajoEnMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeNombreArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPlaneado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPreferencial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colNombreArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCompletado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPrioridadMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colProduccionHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colHorasPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTrabajoEnMaquinas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdTrabajoEnMaquinas As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTrabajoEnMaquinas1 As waProduccion_Pedidos.dsTrabajoEnMaquinas
    Friend WithEvents rmmeNombreArticulo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rmmeComentarios As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents lyvTrabajoEnMaquina As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colPreferencial As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPrioridadMaquina As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colProduccionHora As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colHorasPendiente As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents timeTrabajoEnMaquina As System.Windows.Forms.Timer
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnFiltroEnProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnFitroEnPausa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents barbtnFiltroBodega As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnFiltroFabrica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents layoutViewField_colEstado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPreferencial As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPrioridad As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPrioridadMaquina As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCodigoArticulo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colNombreArticulo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPlaneado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCompletado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPendiente As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colProduccionHora As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colHorasPendiente As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colComentarios As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
End Class
