<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_Produccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_Produccion))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdTemporal_ProduccionPlaneadas = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_Produccion = New waProduccion_Pedidos.dsTemporal_Produccion()
        Me.grdviewTemporal_ProduccionPlaneadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdTemporal_ProduccionLiberadas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewTemporal_ProduccionLiberadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumOrden1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiferencia1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.barbtnVistaPrevia2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.barbtnDetalleRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenLista = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenLiberar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnOrdenCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_ProduccionPlaneadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_Produccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_ProduccionPlaneadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_ProduccionLiberadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_ProduccionLiberadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.grdTemporal_ProduccionPlaneadas)
        Me.LayoutControl1.Controls.Add(Me.grdTemporal_ProduccionLiberadas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(938, 438)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(332, 29)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "ORDENES DE PRODUCCIÓN"
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(866, 45)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(60, 0)
        Me.txtDeLinea.MenuManager = Me.BarManager1
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(60, 0)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.StyleController = Me.LayoutControl1
        Me.txtDeLinea.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 6
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(938, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(938, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(938, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(399, 45)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(334, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 8
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(141, 45)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 7
        '
        'grdTemporal_ProduccionPlaneadas
        '
        Me.grdTemporal_ProduccionPlaneadas.DataMember = "dsdtTemporal_ProduccionPlaneada"
        Me.grdTemporal_ProduccionPlaneadas.DataSource = Me.DsTemporal_Produccion
        Me.grdTemporal_ProduccionPlaneadas.Location = New System.Drawing.Point(12, 97)
        Me.grdTemporal_ProduccionPlaneadas.MainView = Me.grdviewTemporal_ProduccionPlaneadas
        Me.grdTemporal_ProduccionPlaneadas.Name = "grdTemporal_ProduccionPlaneadas"
        Me.grdTemporal_ProduccionPlaneadas.Size = New System.Drawing.Size(914, 139)
        Me.grdTemporal_ProduccionPlaneadas.TabIndex = 6
        Me.grdTemporal_ProduccionPlaneadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_ProduccionPlaneadas})
        '
        'DsTemporal_Produccion
        '
        Me.DsTemporal_Produccion.DataSetName = "dsTemporal_Produccion"
        Me.DsTemporal_Produccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_ProduccionPlaneadas
        '
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionPlaneadas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionPlaneadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumOrden, Me.colFecha, Me.colCodigoArticulo, Me.colPlaneado, Me.colCompletado, Me.colDiferencia, Me.colComentarios})
        Me.grdviewTemporal_ProduccionPlaneadas.GridControl = Me.grdTemporal_ProduccionPlaneadas
        Me.grdviewTemporal_ProduccionPlaneadas.Name = "grdviewTemporal_ProduccionPlaneadas"
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsBehavior.Editable = False
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsBehavior.ReadOnly = True
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsView.ColumnAutoWidth = False
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsView.ShowFooter = True
        Me.grdviewTemporal_ProduccionPlaneadas.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_ProduccionPlaneadas.PaintStyleName = "Flat"
        '
        'colNumOrden
        '
        Me.colNumOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.FieldName = "NumOrden"
        Me.colNumOrden.Name = "colNumOrden"
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 0
        '
        'colFecha
        '
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 2
        Me.colCodigoArticulo.Width = 125
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado.AppearanceCell.Options.UseFont = True
        Me.colPlaneado.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 3
        Me.colPlaneado.Width = 70
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado.AppearanceCell.Options.UseFont = True
        Me.colCompletado.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 4
        Me.colCompletado.Width = 70
        '
        'colDiferencia
        '
        Me.colDiferencia.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colDiferencia.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colDiferencia.AppearanceCell.Options.UseBackColor = True
        Me.colDiferencia.AppearanceCell.Options.UseFont = True
        Me.colDiferencia.AppearanceCell.Options.UseForeColor = True
        Me.colDiferencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia.AppearanceHeader.Options.UseFont = True
        Me.colDiferencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiferencia.FieldName = "Diferencia"
        Me.colDiferencia.Name = "colDiferencia"
        Me.colDiferencia.OptionsColumn.ReadOnly = True
        Me.colDiferencia.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDiferencia.Visible = True
        Me.colDiferencia.VisibleIndex = 5
        Me.colDiferencia.Width = 70
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.ReadOnly = True
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 6
        Me.colComentarios.Width = 375
        '
        'grdTemporal_ProduccionLiberadas
        '
        Me.grdTemporal_ProduccionLiberadas.DataMember = "dsdtTemporal_ProduccionLiberada"
        Me.grdTemporal_ProduccionLiberadas.DataSource = Me.DsTemporal_Produccion
        Me.grdTemporal_ProduccionLiberadas.Location = New System.Drawing.Point(12, 268)
        Me.grdTemporal_ProduccionLiberadas.MainView = Me.grdviewTemporal_ProduccionLiberadas
        Me.grdTemporal_ProduccionLiberadas.Name = "grdTemporal_ProduccionLiberadas"
        Me.grdTemporal_ProduccionLiberadas.Size = New System.Drawing.Size(914, 158)
        Me.grdTemporal_ProduccionLiberadas.TabIndex = 5
        Me.grdTemporal_ProduccionLiberadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_ProduccionLiberadas})
        '
        'grdviewTemporal_ProduccionLiberadas
        '
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewTemporal_ProduccionLiberadas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_ProduccionLiberadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumOrden1, Me.colFecha1, Me.colCodigoArticulo1, Me.colPlaneado1, Me.colCompletado1, Me.colDiferencia1, Me.colComentarios1})
        Me.grdviewTemporal_ProduccionLiberadas.GridControl = Me.grdTemporal_ProduccionLiberadas
        Me.grdviewTemporal_ProduccionLiberadas.Name = "grdviewTemporal_ProduccionLiberadas"
        Me.grdviewTemporal_ProduccionLiberadas.OptionsBehavior.Editable = False
        Me.grdviewTemporal_ProduccionLiberadas.OptionsBehavior.ReadOnly = True
        Me.grdviewTemporal_ProduccionLiberadas.OptionsView.ColumnAutoWidth = False
        Me.grdviewTemporal_ProduccionLiberadas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_ProduccionLiberadas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_ProduccionLiberadas.OptionsView.ShowFooter = True
        Me.grdviewTemporal_ProduccionLiberadas.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_ProduccionLiberadas.PaintStyleName = "Flat"
        '
        'colNumOrden1
        '
        Me.colNumOrden1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumOrden1.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden1.FieldName = "NumOrden"
        Me.colNumOrden1.Name = "colNumOrden1"
        Me.colNumOrden1.Visible = True
        Me.colNumOrden1.VisibleIndex = 0
        '
        'colFecha1
        '
        Me.colFecha1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha1.AppearanceHeader.Options.UseFont = True
        Me.colFecha1.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha1.FieldName = "Fecha"
        Me.colFecha1.Name = "colFecha1"
        Me.colFecha1.OptionsColumn.ReadOnly = True
        Me.colFecha1.Visible = True
        Me.colFecha1.VisibleIndex = 1
        '
        'colCodigoArticulo1
        '
        Me.colCodigoArticulo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo1.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo1.Name = "colCodigoArticulo1"
        Me.colCodigoArticulo1.Visible = True
        Me.colCodigoArticulo1.VisibleIndex = 2
        Me.colCodigoArticulo1.Width = 125
        '
        'colPlaneado1
        '
        Me.colPlaneado1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado1.AppearanceCell.Options.UseBackColor = True
        Me.colPlaneado1.AppearanceCell.Options.UseFont = True
        Me.colPlaneado1.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado1.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado1.FieldName = "Planeado"
        Me.colPlaneado1.Name = "colPlaneado1"
        Me.colPlaneado1.OptionsColumn.ReadOnly = True
        Me.colPlaneado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPlaneado1.Visible = True
        Me.colPlaneado1.VisibleIndex = 3
        Me.colPlaneado1.Width = 70
        '
        'colCompletado1
        '
        Me.colCompletado1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado1.AppearanceCell.Options.UseBackColor = True
        Me.colCompletado1.AppearanceCell.Options.UseFont = True
        Me.colCompletado1.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado1.AppearanceHeader.Options.UseFont = True
        Me.colCompletado1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado1.FieldName = "Completado"
        Me.colCompletado1.Name = "colCompletado1"
        Me.colCompletado1.OptionsColumn.ReadOnly = True
        Me.colCompletado1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCompletado1.Visible = True
        Me.colCompletado1.VisibleIndex = 4
        Me.colCompletado1.Width = 70
        '
        'colDiferencia1
        '
        Me.colDiferencia1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colDiferencia1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colDiferencia1.AppearanceCell.Options.UseBackColor = True
        Me.colDiferencia1.AppearanceCell.Options.UseFont = True
        Me.colDiferencia1.AppearanceCell.Options.UseForeColor = True
        Me.colDiferencia1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferencia1.AppearanceHeader.Options.UseFont = True
        Me.colDiferencia1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiferencia1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiferencia1.FieldName = "Diferencia"
        Me.colDiferencia1.Name = "colDiferencia1"
        Me.colDiferencia1.OptionsColumn.ReadOnly = True
        Me.colDiferencia1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDiferencia1.Visible = True
        Me.colDiferencia1.VisibleIndex = 5
        Me.colDiferencia1.Width = 70
        '
        'colComentarios1
        '
        Me.colComentarios1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios1.AppearanceHeader.Options.UseFont = True
        Me.colComentarios1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios1.FieldName = "Comentarios"
        Me.colComentarios1.Name = "colComentarios1"
        Me.colComentarios1.OptionsColumn.ReadOnly = True
        Me.colComentarios1.Visible = True
        Me.colComentarios1.VisibleIndex = 6
        Me.colComentarios1.Width = 375
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(938, 438)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Teal
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.grdTemporal_ProduccionLiberadas
        Me.LayoutControlItem2.CustomizationFormText = "LIBERADAS"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 228)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(918, 190)
        Me.LayoutControlItem2.Text = "LIBERADAS"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(126, 25)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Sienna
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.Control = Me.grdTemporal_ProduccionPlaneadas
        Me.LayoutControlItem1.CustomizationFormText = "PLANEADAS"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 57)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(918, 171)
        Me.LayoutControlItem1.Text = "PLANEADAS"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(126, 25)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem4.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem4.Text = "Codigo Articulo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(126, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtNombreArticulo
        Me.LayoutControlItem5.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(258, 33)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(467, 24)
        Me.LayoutControlItem5.Text = "Nombre Articulo"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(126, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtDeLinea
        Me.LayoutControlItem6.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(725, 33)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem6.Text = "De Linea?"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(126, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lblTitulo
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(918, 33)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnVistaPrevia2})
        Me.BarManager2.MaxItemId = 1
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(938, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 438)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(938, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(938, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 438)
        '
        'barbtnVistaPrevia2
        '
        Me.barbtnVistaPrevia2.Caption = "Vista Previa"
        Me.barbtnVistaPrevia2.Id = 0
        Me.barbtnVistaPrevia2.ImageOptions.Image = CType(resources.GetObject("barbtnVistaPrevia2.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnVistaPrevia2.Name = "barbtnVistaPrevia2"
        ToolTipTitleItem1.Text = "Vista Previa"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.barbtnVistaPrevia2.SuperTip = SuperToolTip1
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimirGrid, Me.barbtnExportarXlsx, Me.barbtnDetalleRecibos, Me.barbtnCerrar, Me.barbtnOrdenLiberar, Me.barbtnOrdenCerrar, Me.barbtnOrdenLista})
        Me.BarManager3.MaxItemId = 7
        Me.BarManager3.StatusBar = Me.Bar5
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnDetalleRecibos, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenLista, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenLiberar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnOrdenCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'barbtnDetalleRecibos
        '
        Me.barbtnDetalleRecibos.Caption = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibos"
        Me.barbtnDetalleRecibos.Id = 2
        Me.barbtnDetalleRecibos.ImageOptions.Image = CType(resources.GetObject("barbtnDetalleRecibos.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnDetalleRecibos.Name = "barbtnDetalleRecibos"
        '
        'barbtnOrdenLista
        '
        Me.barbtnOrdenLista.Caption = "Listado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ordenes"
        Me.barbtnOrdenLista.Id = 6
        Me.barbtnOrdenLista.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenLista.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenLista.Name = "barbtnOrdenLista"
        '
        'barbtnOrdenLiberar
        '
        Me.barbtnOrdenLiberar.Caption = "Liberar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ordenes"
        Me.barbtnOrdenLiberar.Enabled = False
        Me.barbtnOrdenLiberar.Id = 4
        Me.barbtnOrdenLiberar.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenLiberar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenLiberar.Name = "barbtnOrdenLiberar"
        '
        'barbtnOrdenCerrar
        '
        Me.barbtnOrdenCerrar.Caption = "Cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ordenes"
        Me.barbtnOrdenCerrar.Enabled = False
        Me.barbtnOrdenCerrar.Id = 5
        Me.barbtnOrdenCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnOrdenCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnOrdenCerrar.Name = "barbtnOrdenCerrar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 0
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 3
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(938, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 438)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(938, 43)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(938, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 438)
        '
        'frmTemporal_Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 481)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Producción"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_ProduccionPlaneadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_Produccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_ProduccionPlaneadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_ProduccionLiberadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_ProduccionLiberadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdTemporal_ProduccionPlaneadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_ProduccionPlaneadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdTemporal_ProduccionLiberadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_ProduccionLiberadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barbtnVistaPrevia2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsTemporal_Produccion As waProduccion_Pedidos.dsTemporal_Produccion
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumOrden1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferencia1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDetalleRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnOrdenLiberar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnOrdenCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnOrdenLista As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
