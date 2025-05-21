<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarDatosProduccion
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
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarDatosProduccion))
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lycDatos = New DevExpress.XtraLayout.LayoutControl()
        Me.grdDatos = New DevExpress.XtraGrid.GridControl()
        Me.DsCargarDatosProduccion1 = New waProduccion_Pedidos.dsCargarDatosProduccion()
        Me.grdviewDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadesHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCavidadesMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcentaje1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcentaje2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoGramos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInyeccionGrms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInyeccionVariacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInyeccionHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dockmDatos = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barSuperior = New DevExpress.XtraBars.Bar()
        Me.barbtnCargarPlantilla = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEliminarLinea = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDescargarPlantilla = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dockpDerecho = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lycDerecho = New DevExpress.XtraLayout.LayoutControl()
        Me.memoError = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTotalAgregar = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalActualizar = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalCodigos = New DevExpress.XtraEditors.TextEdit()
        Me.rdgTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkInyeccionHora = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInyeccionVariacion = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInyeccionGramos = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        Me.txtErrorCP = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtErrorMolde = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatos.SuspendLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCargarDatosProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockmDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockpDerecho.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.lycDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDerecho.SuspendLayout()
        CType(Me.memoError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAgregar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalActualizar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCodigos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInyeccionHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInyeccionVariacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInyeccionGramos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtErrorCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtErrorMolde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 0
        Me.colEstado.Width = 122
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 108
        '
        'colCodigoMolde
        '
        Me.colCodigoMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoMolde.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigoMolde.FieldName = "CodigoMolde"
        Me.colCodigoMolde.Name = "colCodigoMolde"
        Me.colCodigoMolde.Visible = True
        Me.colCodigoMolde.VisibleIndex = 7
        Me.colCodigoMolde.Width = 85
        '
        'lycDatos
        '
        Me.lycDatos.Controls.Add(Me.grdDatos)
        Me.lycDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycDatos.Location = New System.Drawing.Point(0, 47)
        Me.lycDatos.Name = "lycDatos"
        Me.lycDatos.Root = Me.LayoutControlGroup1
        Me.lycDatos.Size = New System.Drawing.Size(938, 590)
        Me.lycDatos.TabIndex = 0
        Me.lycDatos.Text = "LayoutControl1"
        '
        'grdDatos
        '
        Me.grdDatos.DataMember = "dsdtCargarDatosProduccion"
        Me.grdDatos.DataSource = Me.DsCargarDatosProduccion1
        Me.grdDatos.Location = New System.Drawing.Point(12, 12)
        Me.grdDatos.MainView = Me.grdviewDatos
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.Size = New System.Drawing.Size(914, 566)
        Me.grdDatos.TabIndex = 4
        Me.grdDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewDatos})
        '
        'DsCargarDatosProduccion1
        '
        Me.DsCargarDatosProduccion1.DataSetName = "dsCargarDatosProduccion"
        Me.DsCargarDatosProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewDatos
        '
        Me.grdviewDatos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewDatos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewDatos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewDatos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewDatos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewDatos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewDatos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewDatos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewDatos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewDatos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewDatos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewDatos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewDatos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewDatos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewDatos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewDatos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewDatos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.Preview.Options.UseFont = True
        Me.grdviewDatos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewDatos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewDatos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewDatos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewDatos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewDatos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewDatos.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewDatos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewDatos.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewDatos.ColumnPanelRowHeight = 50
        Me.grdviewDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstado, Me.colCodigo, Me.colDescripcion, Me.colNumeroMaquina, Me.colUnidadesHora, Me.colUnidadMedida, Me.colCavidadesMolde, Me.colMaterial1, Me.colPorcentaje1, Me.colMaterial2, Me.colPorcentaje2, Me.colPesoGramos, Me.colCodigoMolde, Me.colInyeccionGrms, Me.colInyeccionVariacion, Me.colInyeccionHora})
        GridFormatRule1.Column = Me.colEstado
        GridFormatRule1.ColumnApplyTo = Me.colEstado
        GridFormatRule1.Name = "Actualizar"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "Actualizar"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colEstado
        GridFormatRule2.ColumnApplyTo = Me.colEstado
        GridFormatRule2.Name = "Insertar"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "Insertar"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colEstado
        GridFormatRule3.ColumnApplyTo = Me.colCodigo
        GridFormatRule3.Name = "CP No existe en DB"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = "CP No existe en DB"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.colEstado
        GridFormatRule4.ColumnApplyTo = Me.colCodigoMolde
        GridFormatRule4.Name = "Format0"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Maroon
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = "Molde NO existe en DB"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.grdviewDatos.FormatRules.Add(GridFormatRule1)
        Me.grdviewDatos.FormatRules.Add(GridFormatRule2)
        Me.grdviewDatos.FormatRules.Add(GridFormatRule3)
        Me.grdviewDatos.FormatRules.Add(GridFormatRule4)
        Me.grdviewDatos.GridControl = Me.grdDatos
        Me.grdviewDatos.Name = "grdviewDatos"
        Me.grdviewDatos.OptionsView.ColumnAutoWidth = False
        Me.grdviewDatos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewDatos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewDatos.OptionsView.ShowFooter = True
        Me.grdviewDatos.OptionsView.ShowGroupPanel = False
        Me.grdviewDatos.PaintStyleName = "Web"
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 469
        '
        'colNumeroMaquina
        '
        Me.colNumeroMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroMaquina.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNumeroMaquina.FieldName = "NumeroMaquina"
        Me.colNumeroMaquina.Name = "colNumeroMaquina"
        Me.colNumeroMaquina.Visible = True
        Me.colNumeroMaquina.VisibleIndex = 3
        Me.colNumeroMaquina.Width = 85
        '
        'colUnidadesHora
        '
        Me.colUnidadesHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadesHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadesHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnidadesHora.FieldName = "UnidadesHora"
        Me.colUnidadesHora.Name = "colUnidadesHora"
        Me.colUnidadesHora.Visible = True
        Me.colUnidadesHora.VisibleIndex = 4
        Me.colUnidadesHora.Width = 85
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadMedida.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnidadMedida.FieldName = "UnidadMedida"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.Visible = True
        Me.colUnidadMedida.VisibleIndex = 5
        Me.colUnidadMedida.Width = 85
        '
        'colCavidadesMolde
        '
        Me.colCavidadesMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colCavidadesMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidadesMolde.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCavidadesMolde.FieldName = "CavidadesMolde"
        Me.colCavidadesMolde.Name = "colCavidadesMolde"
        Me.colCavidadesMolde.Visible = True
        Me.colCavidadesMolde.VisibleIndex = 6
        Me.colCavidadesMolde.Width = 100
        '
        'colMaterial1
        '
        Me.colMaterial1.FieldName = "Material1"
        Me.colMaterial1.Name = "colMaterial1"
        '
        'colPorcentaje1
        '
        Me.colPorcentaje1.FieldName = "Porcentaje1"
        Me.colPorcentaje1.Name = "colPorcentaje1"
        '
        'colMaterial2
        '
        Me.colMaterial2.FieldName = "Material2"
        Me.colMaterial2.Name = "colMaterial2"
        '
        'colPorcentaje2
        '
        Me.colPorcentaje2.FieldName = "Porcentaje2"
        Me.colPorcentaje2.Name = "colPorcentaje2"
        '
        'colPesoGramos
        '
        Me.colPesoGramos.FieldName = "PesoGramos"
        Me.colPesoGramos.Name = "colPesoGramos"
        '
        'colInyeccionGrms
        '
        Me.colInyeccionGrms.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInyeccionGrms.AppearanceCell.Options.UseBackColor = True
        Me.colInyeccionGrms.AppearanceHeader.ForeColor = System.Drawing.Color.Blue
        Me.colInyeccionGrms.AppearanceHeader.Options.UseForeColor = True
        Me.colInyeccionGrms.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionGrms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionGrms.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionGrms.FieldName = "InyeccionGrms"
        Me.colInyeccionGrms.Name = "colInyeccionGrms"
        Me.colInyeccionGrms.Visible = True
        Me.colInyeccionGrms.VisibleIndex = 8
        Me.colInyeccionGrms.Width = 100
        '
        'colInyeccionVariacion
        '
        Me.colInyeccionVariacion.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInyeccionVariacion.AppearanceCell.Options.UseBackColor = True
        Me.colInyeccionVariacion.AppearanceHeader.ForeColor = System.Drawing.Color.Blue
        Me.colInyeccionVariacion.AppearanceHeader.Options.UseForeColor = True
        Me.colInyeccionVariacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionVariacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionVariacion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionVariacion.FieldName = "InyeccionVariacion"
        Me.colInyeccionVariacion.Name = "colInyeccionVariacion"
        Me.colInyeccionVariacion.Visible = True
        Me.colInyeccionVariacion.VisibleIndex = 9
        Me.colInyeccionVariacion.Width = 100
        '
        'colInyeccionHora
        '
        Me.colInyeccionHora.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInyeccionHora.AppearanceCell.Options.UseBackColor = True
        Me.colInyeccionHora.AppearanceHeader.ForeColor = System.Drawing.Color.Blue
        Me.colInyeccionHora.AppearanceHeader.Options.UseForeColor = True
        Me.colInyeccionHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colInyeccionHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInyeccionHora.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInyeccionHora.FieldName = "InyeccionHora"
        Me.colInyeccionHora.Name = "colInyeccionHora"
        Me.colInyeccionHora.Visible = True
        Me.colInyeccionHora.VisibleIndex = 10
        Me.colInyeccionHora.Width = 100
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(938, 590)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdDatos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(918, 570)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'dockmDatos
        '
        Me.dockmDatos.Form = Me
        Me.dockmDatos.MenuManager = Me.BarManager1
        Me.dockmDatos.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockpDerecho})
        Me.dockmDatos.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barSuperior, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.dockmDatos
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCargarPlantilla, Me.barbtnCerrar, Me.barbtnEliminarLinea, Me.barbtnDescargarPlantilla, Me.barbtnExportarXlsx, Me.barbtnBuscar, Me.barbtnImprimirGrid})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barSuperior
        '
        Me.barSuperior.BarName = "Tools"
        Me.barSuperior.DockCol = 0
        Me.barSuperior.DockRow = 0
        Me.barSuperior.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barSuperior.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCargarPlantilla, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnEliminarLinea, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDescargarPlantilla, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barSuperior.OptionsBar.AllowQuickCustomization = False
        Me.barSuperior.OptionsBar.DrawBorder = False
        Me.barSuperior.OptionsBar.DrawDragBorder = False
        Me.barSuperior.Text = "Tools"
        '
        'barbtnCargarPlantilla
        '
        Me.barbtnCargarPlantilla.Caption = "Cargar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plantilla"
        Me.barbtnCargarPlantilla.Id = 0
        Me.barbtnCargarPlantilla.ImageOptions.Image = CType(resources.GetObject("barbtnCargarPlantilla.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCargarPlantilla.Name = "barbtnCargarPlantilla"
        '
        'barbtnEliminarLinea
        '
        Me.barbtnEliminarLinea.Caption = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea"
        Me.barbtnEliminarLinea.Id = 2
        Me.barbtnEliminarLinea.ImageOptions.Image = CType(resources.GetObject("barbtnEliminarLinea.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminarLinea.Name = "barbtnEliminarLinea"
        '
        'barbtnDescargarPlantilla
        '
        Me.barbtnDescargarPlantilla.Caption = "Descargar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plantilla"
        Me.barbtnDescargarPlantilla.Id = 3
        Me.barbtnDescargarPlantilla.ImageOptions.Image = CType(resources.GetObject("barbtnDescargarPlantilla.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDescargarPlantilla.Name = "barbtnDescargarPlantilla"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
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
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 6
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 4
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 1
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1201, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 637)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1201, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 590)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1201, 47)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 590)
        '
        'dockpDerecho
        '
        Me.dockpDerecho.Controls.Add(Me.DockPanel1_Container)
        Me.dockpDerecho.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockpDerecho.ID = New System.Guid("a56bef1f-bbf8-4f9d-867a-a6f4bdac4326")
        Me.dockpDerecho.Location = New System.Drawing.Point(938, 47)
        Me.dockpDerecho.Name = "dockpDerecho"
        Me.dockpDerecho.Options.AllowFloating = False
        Me.dockpDerecho.Options.FloatOnDblClick = False
        Me.dockpDerecho.Options.ShowCloseButton = False
        Me.dockpDerecho.OriginalSize = New System.Drawing.Size(263, 200)
        Me.dockpDerecho.Size = New System.Drawing.Size(263, 590)
        Me.dockpDerecho.Text = "Filtros de Carga"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.lycDerecho)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(254, 563)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'lycDerecho
        '
        Me.lycDerecho.Controls.Add(Me.txtErrorMolde)
        Me.lycDerecho.Controls.Add(Me.txtErrorCP)
        Me.lycDerecho.Controls.Add(Me.memoError)
        Me.lycDerecho.Controls.Add(Me.txtTotalAgregar)
        Me.lycDerecho.Controls.Add(Me.txtTotalActualizar)
        Me.lycDerecho.Controls.Add(Me.txtTotalCodigos)
        Me.lycDerecho.Controls.Add(Me.rdgTipo)
        Me.lycDerecho.Controls.Add(Me.btnActualizar)
        Me.lycDerecho.Controls.Add(Me.lbl1)
        Me.lycDerecho.Controls.Add(Me.chkInyeccionHora)
        Me.lycDerecho.Controls.Add(Me.chkInyeccionVariacion)
        Me.lycDerecho.Controls.Add(Me.chkInyeccionGramos)
        Me.lycDerecho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycDerecho.Location = New System.Drawing.Point(0, 0)
        Me.lycDerecho.Margin = New System.Windows.Forms.Padding(2)
        Me.lycDerecho.Name = "lycDerecho"
        Me.lycDerecho.Root = Me.LayoutControlGroup2
        Me.lycDerecho.Size = New System.Drawing.Size(254, 563)
        Me.lycDerecho.TabIndex = 0
        Me.lycDerecho.Text = "LayoutControl1"
        '
        'memoError
        '
        Me.memoError.Location = New System.Drawing.Point(12, 478)
        Me.memoError.MenuManager = Me.BarManager1
        Me.memoError.Name = "memoError"
        Me.memoError.Size = New System.Drawing.Size(230, 73)
        Me.memoError.StyleController = Me.lycDerecho
        Me.memoError.TabIndex = 13
        '
        'txtTotalAgregar
        '
        Me.txtTotalAgregar.Location = New System.Drawing.Point(120, 223)
        Me.txtTotalAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalAgregar.MenuManager = Me.BarManager1
        Me.txtTotalAgregar.Name = "txtTotalAgregar"
        Me.txtTotalAgregar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtTotalAgregar.Properties.Appearance.Options.UseFont = True
        Me.txtTotalAgregar.Size = New System.Drawing.Size(122, 30)
        Me.txtTotalAgregar.StyleController = Me.lycDerecho
        Me.txtTotalAgregar.TabIndex = 12
        '
        'txtTotalActualizar
        '
        Me.txtTotalActualizar.Location = New System.Drawing.Point(120, 189)
        Me.txtTotalActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalActualizar.MenuManager = Me.BarManager1
        Me.txtTotalActualizar.Name = "txtTotalActualizar"
        Me.txtTotalActualizar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtTotalActualizar.Properties.Appearance.Options.UseFont = True
        Me.txtTotalActualizar.Size = New System.Drawing.Size(122, 30)
        Me.txtTotalActualizar.StyleController = Me.lycDerecho
        Me.txtTotalActualizar.TabIndex = 11
        '
        'txtTotalCodigos
        '
        Me.txtTotalCodigos.Location = New System.Drawing.Point(120, 155)
        Me.txtTotalCodigos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalCodigos.MenuManager = Me.BarManager1
        Me.txtTotalCodigos.Name = "txtTotalCodigos"
        Me.txtTotalCodigos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtTotalCodigos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCodigos.Size = New System.Drawing.Size(122, 30)
        Me.txtTotalCodigos.StyleController = Me.lycDerecho
        Me.txtTotalCodigos.TabIndex = 10
        '
        'rdgTipo
        '
        Me.rdgTipo.EditValue = 0
        Me.rdgTipo.Location = New System.Drawing.Point(12, 124)
        Me.rdgTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.rdgTipo.MenuManager = Me.BarManager1
        Me.rdgTipo.Name = "rdgTipo"
        Me.rdgTipo.Properties.Columns = 2
        Me.rdgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Actualizar"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Agregar")})
        Me.rdgTipo.Size = New System.Drawing.Size(230, 27)
        Me.rdgTipo.StyleController = Me.lycDerecho
        Me.rdgTipo.TabIndex = 9
        '
        'btnActualizar
        '
        Me.btnActualizar.ImageOptions.Image = CType(resources.GetObject("btnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(12, 325)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(230, 38)
        Me.btnActualizar.StyleController = Me.lycDerecho
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar Datos"
        '
        'lbl1
        '
        Me.lbl1.Appearance.Options.UseTextOptions = True
        Me.lbl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lbl1.Location = New System.Drawing.Point(12, 12)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(121, 13)
        Me.lbl1.StyleController = Me.lycDerecho
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Columnas para Actualizar"
        '
        'chkInyeccionHora
        '
        Me.chkInyeccionHora.Location = New System.Drawing.Point(12, 81)
        Me.chkInyeccionHora.Margin = New System.Windows.Forms.Padding(2)
        Me.chkInyeccionHora.MenuManager = Me.BarManager1
        Me.chkInyeccionHora.Name = "chkInyeccionHora"
        Me.chkInyeccionHora.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkInyeccionHora.Properties.Appearance.Options.UseForeColor = True
        Me.chkInyeccionHora.Properties.Caption = "Inyección Hora"
        Me.chkInyeccionHora.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style11
        Me.chkInyeccionHora.Size = New System.Drawing.Size(230, 22)
        Me.chkInyeccionHora.StyleController = Me.lycDerecho
        Me.chkInyeccionHora.TabIndex = 6
        '
        'chkInyeccionVariacion
        '
        Me.chkInyeccionVariacion.Location = New System.Drawing.Point(12, 55)
        Me.chkInyeccionVariacion.Margin = New System.Windows.Forms.Padding(2)
        Me.chkInyeccionVariacion.MenuManager = Me.BarManager1
        Me.chkInyeccionVariacion.Name = "chkInyeccionVariacion"
        Me.chkInyeccionVariacion.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkInyeccionVariacion.Properties.Appearance.Options.UseForeColor = True
        Me.chkInyeccionVariacion.Properties.Caption = "Inyección Variación"
        Me.chkInyeccionVariacion.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style11
        Me.chkInyeccionVariacion.Size = New System.Drawing.Size(230, 22)
        Me.chkInyeccionVariacion.StyleController = Me.lycDerecho
        Me.chkInyeccionVariacion.TabIndex = 5
        '
        'chkInyeccionGramos
        '
        Me.chkInyeccionGramos.Location = New System.Drawing.Point(12, 29)
        Me.chkInyeccionGramos.Margin = New System.Windows.Forms.Padding(2)
        Me.chkInyeccionGramos.MenuManager = Me.BarManager1
        Me.chkInyeccionGramos.Name = "chkInyeccionGramos"
        Me.chkInyeccionGramos.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkInyeccionGramos.Properties.Appearance.Options.UseForeColor = True
        Me.chkInyeccionGramos.Properties.Caption = "Inyección Gramos"
        Me.chkInyeccionGramos.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style11
        Me.chkInyeccionGramos.Size = New System.Drawing.Size(230, 22)
        Me.chkInyeccionGramos.StyleController = Me.lycDerecho
        Me.chkInyeccionGramos.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 4
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(254, 563)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkInyeccionGramos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(234, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 355)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(234, 94)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkInyeccionVariacion
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 43)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(234, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkInyeccionHora
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 69)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(234, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lbl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(234, 17)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem7.Control = Me.rdgTipo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 95)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(234, 48)
        Me.LayoutControlItem7.Text = "Tipo"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.txtTotalCodigos
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(234, 34)
        Me.LayoutControlItem8.Text = "Total Codigos"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.txtTotalActualizar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 177)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(234, 34)
        Me.LayoutControlItem9.Text = "Total para Actualizar"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnActualizar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 313)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(234, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtTotalAgregar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 211)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(234, 34)
        Me.LayoutControlItem10.Text = "Total para Insertar"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.memoError
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 449)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(234, 94)
        Me.LayoutControlItem11.Text = "Resultado de Proceso"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(104, 13)
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'ssmEsperar
        '
        Me.ssmEsperar.ClosingDelay = 500
        '
        'txtErrorCP
        '
        Me.txtErrorCP.Location = New System.Drawing.Point(120, 257)
        Me.txtErrorCP.MenuManager = Me.BarManager1
        Me.txtErrorCP.Name = "txtErrorCP"
        Me.txtErrorCP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtErrorCP.Properties.Appearance.Options.UseFont = True
        Me.txtErrorCP.Size = New System.Drawing.Size(122, 30)
        Me.txtErrorCP.StyleController = Me.lycDerecho
        Me.txtErrorCP.TabIndex = 14
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.txtErrorCP
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 245)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(234, 34)
        Me.LayoutControlItem12.Text = "Total Error CP"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(104, 13)
        '
        'txtErrorMolde
        '
        Me.txtErrorMolde.Location = New System.Drawing.Point(120, 291)
        Me.txtErrorMolde.MenuManager = Me.BarManager1
        Me.txtErrorMolde.Name = "txtErrorMolde"
        Me.txtErrorMolde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtErrorMolde.Properties.Appearance.Options.UseFont = True
        Me.txtErrorMolde.Size = New System.Drawing.Size(122, 30)
        Me.txtErrorMolde.StyleController = Me.lycDerecho
        Me.txtErrorMolde.TabIndex = 15
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.txtErrorMolde
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 279)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(234, 34)
        Me.LayoutControlItem13.Text = "Total Error Molde"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(104, 13)
        '
        'frmCargarDatosProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycDatos)
        Me.Controls.Add(Me.dockpDerecho)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCargarDatosProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCargarDatosProduccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lycDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatos.ResumeLayout(False)
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCargarDatosProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockmDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockpDerecho.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.lycDerecho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDerecho.ResumeLayout(False)
        CType(Me.memoError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAgregar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalActualizar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCodigos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInyeccionHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInyeccionVariacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInyeccionGramos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtErrorCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtErrorMolde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycDatos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dockmDatos As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents dockpDerecho As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barSuperior As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCargarPlantilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DsCargarDatosProduccion1 As waProduccion_Pedidos.dsCargarDatosProduccion
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCavidadesMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentaje1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentaje2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoGramos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionGrms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionVariacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInyeccionHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lycDerecho As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkInyeccionHora As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents barbtnEliminarLinea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkInyeccionVariacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInyeccionGramos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents barbtnDescargarPlantilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rdgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotalActualizar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCodigos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotalAgregar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents memoError As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtErrorMolde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtErrorCP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
End Class
