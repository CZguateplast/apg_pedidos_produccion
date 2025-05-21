<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_DeudaProyeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_DeudaProyeccion))
        Me.lycTemporal_DeudaProyeccion = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdTemporal_DeudaProyeccion = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_DeudaProyeccion = New waProduccion_Pedidos.dsTemporal_DeudaProyeccion()
        Me.grdviewTemporal_DeudaProyeccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProyectado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacturado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_DeudaProyeccion.SuspendLayout()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal_DeudaProyeccion
        '
        Me.lycTemporal_DeudaProyeccion.Controls.Add(Me.lblTitulo)
        Me.lycTemporal_DeudaProyeccion.Controls.Add(Me.txtDeLinea)
        Me.lycTemporal_DeudaProyeccion.Controls.Add(Me.txtNombreArticulo)
        Me.lycTemporal_DeudaProyeccion.Controls.Add(Me.txtCodigoArticulo)
        Me.lycTemporal_DeudaProyeccion.Controls.Add(Me.grdTemporal_DeudaProyeccion)
        Me.lycTemporal_DeudaProyeccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_DeudaProyeccion.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_DeudaProyeccion.Name = "lycTemporal_DeudaProyeccion"
        Me.lycTemporal_DeudaProyeccion.Root = Me.LayoutControlGroup1
        Me.lycTemporal_DeudaProyeccion.Size = New System.Drawing.Size(926, 399)
        Me.lycTemporal_DeudaProyeccion.TabIndex = 0
        Me.lycTemporal_DeudaProyeccion.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(795, 29)
        Me.lblTitulo.StyleController = Me.lycTemporal_DeudaProyeccion
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "DEUDA SEGUN LAS PROYECCIONES DE LAS CAMPAÑAS VIGENTES"
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(854, 45)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.MenuManager = Me.BarManager1
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.StyleController = Me.lycTemporal_DeudaProyeccion
        Me.txtDeLinea.TabIndex = 7
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(926, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 399)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(926, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 399)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(926, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 399)
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(299, 45)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(472, 20)
        Me.txtNombreArticulo.StyleController = Me.lycTemporal_DeudaProyeccion
        Me.txtNombreArticulo.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(91, 45)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.StyleController = Me.lycTemporal_DeudaProyeccion
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'grdTemporal_DeudaProyeccion
        '
        Me.grdTemporal_DeudaProyeccion.DataMember = "dsdtTemporal_DeudaProyeccion"
        Me.grdTemporal_DeudaProyeccion.DataSource = Me.DsTemporal_DeudaProyeccion
        Me.grdTemporal_DeudaProyeccion.Location = New System.Drawing.Point(12, 69)
        Me.grdTemporal_DeudaProyeccion.MainView = Me.grdviewTemporal_DeudaProyeccion
        Me.grdTemporal_DeudaProyeccion.Name = "grdTemporal_DeudaProyeccion"
        Me.grdTemporal_DeudaProyeccion.Size = New System.Drawing.Size(902, 318)
        Me.grdTemporal_DeudaProyeccion.TabIndex = 4
        Me.grdTemporal_DeudaProyeccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_DeudaProyeccion})
        '
        'DsTemporal_DeudaProyeccion
        '
        Me.DsTemporal_DeudaProyeccion.DataSetName = "dsTemporal_DeudaProyeccion"
        Me.DsTemporal_DeudaProyeccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_DeudaProyeccion
        '
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaProyeccion.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaProyeccion.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaProyeccion.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaProyeccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombreCampana, Me.colProyectado, Me.colFacturado, Me.colDiferencia, Me.colFechaEntrega, Me.colFechaInicio, Me.colFechaFinal})
        Me.grdviewTemporal_DeudaProyeccion.GridControl = Me.grdTemporal_DeudaProyeccion
        Me.grdviewTemporal_DeudaProyeccion.Name = "grdviewTemporal_DeudaProyeccion"
        Me.grdviewTemporal_DeudaProyeccion.OptionsBehavior.Editable = False
        Me.grdviewTemporal_DeudaProyeccion.OptionsBehavior.ReadOnly = True
        Me.grdviewTemporal_DeudaProyeccion.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_DeudaProyeccion.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_DeudaProyeccion.OptionsView.ShowFooter = True
        Me.grdviewTemporal_DeudaProyeccion.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_DeudaProyeccion.PaintStyleName = "Flat"
        '
        'colId
        '
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 90
        '
        'colNombreCampana
        '
        Me.colNombreCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCampana.AppearanceHeader.Options.UseFont = True
        Me.colNombreCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCampana.FieldName = "NombreCampana"
        Me.colNombreCampana.Name = "colNombreCampana"
        Me.colNombreCampana.Visible = True
        Me.colNombreCampana.VisibleIndex = 1
        Me.colNombreCampana.Width = 335
        '
        'colProyectado
        '
        Me.colProyectado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colProyectado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProyectado.AppearanceCell.Options.UseBackColor = True
        Me.colProyectado.AppearanceCell.Options.UseFont = True
        Me.colProyectado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProyectado.AppearanceHeader.Options.UseFont = True
        Me.colProyectado.AppearanceHeader.Options.UseTextOptions = True
        Me.colProyectado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProyectado.FieldName = "Proyectado"
        Me.colProyectado.Name = "colProyectado"
        Me.colProyectado.OptionsColumn.ReadOnly = True
        Me.colProyectado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colProyectado.Visible = True
        Me.colProyectado.VisibleIndex = 2
        '
        'colFacturado
        '
        Me.colFacturado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colFacturado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFacturado.AppearanceCell.Options.UseBackColor = True
        Me.colFacturado.AppearanceCell.Options.UseFont = True
        Me.colFacturado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFacturado.AppearanceHeader.Options.UseFont = True
        Me.colFacturado.AppearanceHeader.Options.UseTextOptions = True
        Me.colFacturado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFacturado.FieldName = "Facturado"
        Me.colFacturado.Name = "colFacturado"
        Me.colFacturado.OptionsColumn.ReadOnly = True
        Me.colFacturado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFacturado.Visible = True
        Me.colFacturado.VisibleIndex = 3
        '
        'colDiferencia
        '
        Me.colDiferencia.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colDiferencia.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia.AppearanceCell.Options.UseBackColor = True
        Me.colDiferencia.AppearanceCell.Options.UseFont = True
        Me.colDiferencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia.AppearanceHeader.Options.UseFont = True
        Me.colDiferencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiferencia.FieldName = "Diferencia"
        Me.colDiferencia.Name = "colDiferencia"
        Me.colDiferencia.OptionsColumn.ReadOnly = True
        Me.colDiferencia.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDiferencia.Visible = True
        Me.colDiferencia.VisibleIndex = 4
        '
        'colFechaEntrega
        '
        Me.colFechaEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaEntrega.AppearanceHeader.Options.UseFont = True
        Me.colFechaEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.Caption = "Entrega"
        Me.colFechaEntrega.FieldName = "FechaEntrega"
        Me.colFechaEntrega.Name = "colFechaEntrega"
        Me.colFechaEntrega.Visible = True
        Me.colFechaEntrega.VisibleIndex = 5
        Me.colFechaEntrega.Width = 73
        '
        'colFechaInicio
        '
        Me.colFechaInicio.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaInicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaInicio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaInicio.AppearanceHeader.Options.UseFont = True
        Me.colFechaInicio.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaInicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaInicio.Caption = "Inicio"
        Me.colFechaInicio.FieldName = "FechaInicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 6
        Me.colFechaInicio.Width = 73
        '
        'colFechaFinal
        '
        Me.colFechaFinal.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaFinal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaFinal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaFinal.AppearanceHeader.Options.UseFont = True
        Me.colFechaFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaFinal.Caption = "Final"
        Me.colFechaFinal.FieldName = "FechaFinal"
        Me.colFechaFinal.Name = "colFechaFinal"
        Me.colFechaFinal.Visible = True
        Me.colFechaFinal.VisibleIndex = 7
        Me.colFechaFinal.Width = 89
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(926, 399)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.Control = Me.grdTemporal_DeudaProyeccion
        Me.LayoutControlItem1.CustomizationFormText = "CAMPANAS"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 57)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(906, 322)
        Me.LayoutControlItem1.Text = "PROYECCIONES"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem2.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(208, 24)
        Me.LayoutControlItem2.Text = "Codigo Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtNombreArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(208, 33)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(555, 24)
        Me.LayoutControlItem3.Text = "Nombre Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtDeLinea
        Me.LayoutControlItem4.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(763, 33)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(143, 24)
        Me.LayoutControlItem4.Text = "De Linea?"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblTitulo
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(906, 33)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnCerrar})
        Me.BarManager2.MaxItemId = 3
        Me.BarManager2.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 0
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 2
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(926, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 399)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(926, 43)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 399)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(926, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 399)
        '
        'frmTemporal_DeudaProyeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 442)
        Me.Controls.Add(Me.lycTemporal_DeudaProyeccion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_DeudaProyeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_DeudaProyeccion"
        CType(Me.lycTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_DeudaProyeccion.ResumeLayout(False)
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_DeudaProyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTemporal_DeudaProyeccion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdTemporal_DeudaProyeccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsTemporal_DeudaProyeccion As waProduccion_Pedidos.dsTemporal_DeudaProyeccion
    Friend WithEvents grdviewTemporal_DeudaProyeccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProyectado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacturado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
End Class
