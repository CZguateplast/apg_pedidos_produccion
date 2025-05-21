<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_DeudaCampana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_DeudaCampana))
        Me.lycTemporal_DeudaCampana = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdTemporal_DeudaCampana = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_DeudaCampana = New waProduccion_Pedidos.dsTemporal_DeudaCampana()
        Me.grdviewTemporal_DeudaCampana = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.lycTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_DeudaCampana.SuspendLayout()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lycTemporal_DeudaCampana
        '
        Me.lycTemporal_DeudaCampana.Controls.Add(Me.lblTitulo)
        Me.lycTemporal_DeudaCampana.Controls.Add(Me.txtDeLinea)
        Me.lycTemporal_DeudaCampana.Controls.Add(Me.txtNombreArticulo)
        Me.lycTemporal_DeudaCampana.Controls.Add(Me.txtCodigoArticulo)
        Me.lycTemporal_DeudaCampana.Controls.Add(Me.grdTemporal_DeudaCampana)
        Me.lycTemporal_DeudaCampana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_DeudaCampana.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_DeudaCampana.Name = "lycTemporal_DeudaCampana"
        Me.lycTemporal_DeudaCampana.Root = Me.LayoutControlGroup1
        Me.lycTemporal_DeudaCampana.Size = New System.Drawing.Size(891, 438)
        Me.lycTemporal_DeudaCampana.TabIndex = 0
        Me.lycTemporal_DeudaCampana.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(267, 29)
        Me.lblTitulo.StyleController = Me.lycTemporal_DeudaCampana
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "DEUDA DE CAMPAÑAS"
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(819, 45)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Size = New System.Drawing.Size(60, 20)
        Me.txtDeLinea.StyleController = Me.lycTemporal_DeudaCampana
        Me.txtDeLinea.TabIndex = 7
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(299, 45)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(437, 20)
        Me.txtNombreArticulo.StyleController = Me.lycTemporal_DeudaCampana
        Me.txtNombreArticulo.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(91, 45)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.StyleController = Me.lycTemporal_DeudaCampana
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'grdTemporal_DeudaCampana
        '
        Me.grdTemporal_DeudaCampana.DataMember = "dsdtTemporal_DeudaCampana"
        Me.grdTemporal_DeudaCampana.DataSource = Me.DsTemporal_DeudaCampana
        Me.grdTemporal_DeudaCampana.Location = New System.Drawing.Point(12, 69)
        Me.grdTemporal_DeudaCampana.MainView = Me.grdviewTemporal_DeudaCampana
        Me.grdTemporal_DeudaCampana.Name = "grdTemporal_DeudaCampana"
        Me.grdTemporal_DeudaCampana.Size = New System.Drawing.Size(867, 357)
        Me.grdTemporal_DeudaCampana.TabIndex = 4
        Me.grdTemporal_DeudaCampana.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_DeudaCampana})
        '
        'DsTemporal_DeudaCampana
        '
        Me.DsTemporal_DeudaCampana.DataSetName = "dsTemporal_DeudaCampana"
        Me.DsTemporal_DeudaCampana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_DeudaCampana
        '
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_DeudaCampana.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_DeudaCampana.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.grdviewTemporal_DeudaCampana.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_DeudaCampana.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombreCampana, Me.colNumOrden, Me.colCodigoCliente, Me.colNombreCliente, Me.colPendiente, Me.colFecha, Me.colEntrega})
        Me.grdviewTemporal_DeudaCampana.GridControl = Me.grdTemporal_DeudaCampana
        Me.grdviewTemporal_DeudaCampana.Name = "grdviewTemporal_DeudaCampana"
        Me.grdviewTemporal_DeudaCampana.OptionsBehavior.Editable = False
        Me.grdviewTemporal_DeudaCampana.OptionsBehavior.ReadOnly = True
        Me.grdviewTemporal_DeudaCampana.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_DeudaCampana.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_DeudaCampana.OptionsView.ShowFooter = True
        Me.grdviewTemporal_DeudaCampana.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_DeudaCampana.PaintStyleName = "Flat"
        '
        'colId
        '
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.Caption = "Campaña"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 65
        '
        'colNombreCampana
        '
        Me.colNombreCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCampana.AppearanceHeader.Options.UseFont = True
        Me.colNombreCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCampana.FieldName = "NombreCampana"
        Me.colNombreCampana.Name = "colNombreCampana"
        Me.colNombreCampana.OptionsColumn.ReadOnly = True
        Me.colNombreCampana.Visible = True
        Me.colNombreCampana.VisibleIndex = 1
        Me.colNombreCampana.Width = 196
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
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 2
        Me.colNumOrden.Width = 58
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
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 3
        Me.colCodigoCliente.Width = 56
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCliente.AppearanceHeader.Options.UseFont = True
        Me.colNombreCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.OptionsColumn.ReadOnly = True
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 4
        Me.colNombreCliente.Width = 205
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPendiente.AppearanceCell.Options.UseBackColor = True
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 5
        Me.colPendiente.Width = 70
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
        Me.colFecha.VisibleIndex = 6
        Me.colFecha.Width = 57
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
        Me.colEntrega.OptionsColumn.ReadOnly = True
        Me.colEntrega.Visible = True
        Me.colEntrega.VisibleIndex = 7
        Me.colEntrega.Width = 57
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(891, 438)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
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
        Me.LayoutControlItem1.Control = Me.grdTemporal_DeudaCampana
        Me.LayoutControlItem1.CustomizationFormText = "CAMPAÑAS"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 57)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(871, 361)
        Me.LayoutControlItem1.Text = "CAMPAÑAS"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
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
        Me.LayoutControlItem3.Size = New System.Drawing.Size(520, 24)
        Me.LayoutControlItem3.Text = "Nombre Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtDeLinea
        Me.LayoutControlItem4.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(728, 33)
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
        Me.LayoutControlItem5.Size = New System.Drawing.Size(871, 33)
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
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(891, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Size = New System.Drawing.Size(891, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(891, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
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
        Me.barbtnImprimirGrid.Caption = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
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
        Me.BarDockControl1.Size = New System.Drawing.Size(891, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 438)
        Me.BarDockControl2.Size = New System.Drawing.Size(891, 43)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(891, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 438)
        '
        'frmTemporal_DeudaCampana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 481)
        Me.Controls.Add(Me.lycTemporal_DeudaCampana)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_DeudaCampana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deuda solo Ordenes de Campana"
        CType(Me.lycTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_DeudaCampana.ResumeLayout(False)
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_DeudaCampana, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lycTemporal_DeudaCampana As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdTemporal_DeudaCampana As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_DeudaCampana As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
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
    Friend WithEvents DsTemporal_DeudaCampana As waProduccion_Pedidos.dsTemporal_DeudaCampana
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrega As DevExpress.XtraGrid.Columns.GridColumn
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
