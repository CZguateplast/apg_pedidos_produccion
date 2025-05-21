<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_DeudaEnsamble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_DeudaEnsamble))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdTemporal_DeudaEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_DeudaEnsamble1 = New waProduccion_Pedidos.dsTemporal_DeudaEnsamble()
        Me.grdviewtemporal_DeudaEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_DeudaEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_DeudaEnsamble1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewtemporal_DeudaEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.grdTemporal_DeudaEnsamble)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(901, 399)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(315, 29)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "DEUDA SEGUN ENSAMBLE"
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Enabled = False
        Me.txtDeLinea.Location = New System.Drawing.Point(830, 45)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Size = New System.Drawing.Size(59, 20)
        Me.txtDeLinea.StyleController = Me.LayoutControl1
        Me.txtDeLinea.TabIndex = 7
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Enabled = False
        Me.txtNombreArticulo.Location = New System.Drawing.Point(306, 45)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(433, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Enabled = False
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(99, 45)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(116, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'grdTemporal_DeudaEnsamble
        '
        Me.grdTemporal_DeudaEnsamble.DataMember = "dsdtTemporal_DeudaEnsamble"
        Me.grdTemporal_DeudaEnsamble.DataSource = Me.DsTemporal_DeudaEnsamble1
        Me.grdTemporal_DeudaEnsamble.Location = New System.Drawing.Point(12, 85)
        Me.grdTemporal_DeudaEnsamble.MainView = Me.grdviewtemporal_DeudaEnsamble
        Me.grdTemporal_DeudaEnsamble.Name = "grdTemporal_DeudaEnsamble"
        Me.grdTemporal_DeudaEnsamble.Size = New System.Drawing.Size(877, 302)
        Me.grdTemporal_DeudaEnsamble.TabIndex = 4
        Me.grdTemporal_DeudaEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewtemporal_DeudaEnsamble})
        '
        'DsTemporal_DeudaEnsamble1
        '
        Me.DsTemporal_DeudaEnsamble1.DataSetName = "dsTemporal_DeudaEnsamble"
        Me.DsTemporal_DeudaEnsamble1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewtemporal_DeudaEnsamble
        '
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.Options.UseFont = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewtemporal_DeudaEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewtemporal_DeudaEnsamble.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewtemporal_DeudaEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewtemporal_DeudaEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumOrden, Me.colFecha, Me.colPlaneado, Me.colCompletado, Me.colDiferencia, Me.colDestino, Me.colComentarios})
        Me.grdviewtemporal_DeudaEnsamble.GridControl = Me.grdTemporal_DeudaEnsamble
        Me.grdviewtemporal_DeudaEnsamble.Name = "grdviewtemporal_DeudaEnsamble"
        Me.grdviewtemporal_DeudaEnsamble.OptionsBehavior.Editable = False
        Me.grdviewtemporal_DeudaEnsamble.OptionsBehavior.ReadOnly = True
        Me.grdviewtemporal_DeudaEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewtemporal_DeudaEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewtemporal_DeudaEnsamble.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewtemporal_DeudaEnsamble.OptionsView.ShowFooter = True
        Me.grdviewtemporal_DeudaEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewtemporal_DeudaEnsamble.PaintStyleName = "Flat"
        '
        'colNumOrden
        '
        Me.colNumOrden.AppearanceCell.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.Caption = "#SAP"
        Me.colNumOrden.FieldName = "NumOrden"
        Me.colNumOrden.Name = "colNumOrden"
        Me.colNumOrden.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 0
        Me.colNumOrden.Width = 74
        '
        'colFecha
        '
        Me.colFecha.AppearanceCell.Options.UseTextOptions = True
        Me.colFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 80
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado.AppearanceCell.Options.UseBackColor = True
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
        Me.colPlaneado.VisibleIndex = 2
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado.AppearanceCell.Options.UseBackColor = True
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
        Me.colCompletado.VisibleIndex = 3
        '
        'colDiferencia
        '
        Me.colDiferencia.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colDiferencia.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colDiferencia.AppearanceCell.Options.UseBackColor = True
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
        Me.colDiferencia.VisibleIndex = 4
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
        Me.colDestino.OptionsColumn.ReadOnly = True
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 5
        Me.colDestino.Width = 100
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 6
        Me.colComentarios.Width = 380
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(901, 399)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.Control = Me.grdTemporal_DeudaEnsamble
        Me.LayoutControlItem1.CustomizationFormText = "Comprometido"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 57)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(881, 322)
        Me.LayoutControlItem1.Text = "Comprometido"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem2.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem2.Text = "Codigo Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNombreArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(207, 33)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(524, 24)
        Me.LayoutControlItem3.Text = "Nombre Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtDeLinea
        Me.LayoutControlItem4.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(731, 33)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem4.Text = "De Linea?"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblTitulo
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(881, 33)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(901, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 399)
        Me.barDockControlBottom.Size = New System.Drawing.Size(901, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 399)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(901, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 399)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        Me.barbtnImprimirGrid.Glyph = CType(resources.GetObject("barbtnImprimirGrid.Glyph"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Id = 0
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Glyph = CType(resources.GetObject("barbtnExportarXlsx.Glyph"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 2
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(901, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 399)
        Me.BarDockControl2.Size = New System.Drawing.Size(901, 43)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 399)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(901, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 399)
        '
        'frmTemporal_DeudaEnsamble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 442)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTemporal_DeudaEnsamble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deuda Ensamble"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_DeudaEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_DeudaEnsamble1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewtemporal_DeudaEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdTemporal_DeudaEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewtemporal_DeudaEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DsTemporal_DeudaEnsamble1 As waProduccion_Pedidos.dsTemporal_DeudaEnsamble
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
End Class
