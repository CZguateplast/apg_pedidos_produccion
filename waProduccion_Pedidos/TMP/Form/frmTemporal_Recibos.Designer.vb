<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_Recibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_Recibos))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtPlaneado = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumOrden = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.grdTemporal_Recibos = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporalRecibosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTemporal_Recibos = New waProduccion_Pedidos.dsTemporal_Recibos()
        Me.grdviewTemporal_Recibos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycNombreArticulo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycCodigoArticulo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycNumOrden = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDeLinea = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtPlaneado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTemporal_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporalRecibosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycNombreArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycNumOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDeLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.txtPlaneado)
        Me.LayoutControl1.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl1.Controls.Add(Me.txtNumOrden)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.grdTemporal_Recibos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(474, 407)
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
        Me.lblTitulo.Size = New System.Drawing.Size(220, 29)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Detalle de Recibos"
        '
        'txtPlaneado
        '
        Me.txtPlaneado.Location = New System.Drawing.Point(382, 45)
        Me.txtPlaneado.MaximumSize = New System.Drawing.Size(80, 0)
        Me.txtPlaneado.MinimumSize = New System.Drawing.Size(80, 0)
        Me.txtPlaneado.Name = "txtPlaneado"
        Me.txtPlaneado.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPlaneado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPlaneado.Properties.ReadOnly = True
        Me.txtPlaneado.Size = New System.Drawing.Size(80, 20)
        Me.txtPlaneado.StyleController = Me.LayoutControl1
        Me.txtPlaneado.TabIndex = 9
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(412, 69)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(50, 0)
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(50, 0)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.StyleController = Me.LayoutControl1
        Me.txtDeLinea.TabIndex = 8
        '
        'txtNumOrden
        '
        Me.txtNumOrden.Location = New System.Drawing.Point(114, 45)
        Me.txtNumOrden.MaximumSize = New System.Drawing.Size(75, 0)
        Me.txtNumOrden.MinimumSize = New System.Drawing.Size(75, 0)
        Me.txtNumOrden.Name = "txtNumOrden"
        Me.txtNumOrden.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumOrden.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumOrden.Properties.ReadOnly = True
        Me.txtNumOrden.Size = New System.Drawing.Size(75, 20)
        Me.txtNumOrden.StyleController = Me.LayoutControl1
        Me.txtNumOrden.TabIndex = 7
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(114, 93)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(348, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(114, 69)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(125, 0)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'grdTemporal_Recibos
        '
        Me.grdTemporal_Recibos.DataMember = "dsdtTemporal_Recibos"
        Me.grdTemporal_Recibos.DataSource = Me.DsTemporalRecibosBindingSource
        Me.grdTemporal_Recibos.Location = New System.Drawing.Point(12, 117)
        Me.grdTemporal_Recibos.MainView = Me.grdviewTemporal_Recibos
        Me.grdTemporal_Recibos.Name = "grdTemporal_Recibos"
        Me.grdTemporal_Recibos.Size = New System.Drawing.Size(450, 278)
        Me.grdTemporal_Recibos.TabIndex = 4
        Me.grdTemporal_Recibos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_Recibos})
        '
        'DsTemporalRecibosBindingSource
        '
        Me.DsTemporalRecibosBindingSource.DataSource = Me.DsTemporal_Recibos
        Me.DsTemporalRecibosBindingSource.Position = 0
        '
        'DsTemporal_Recibos
        '
        Me.DsTemporal_Recibos.DataSetName = "dsTemporal_Recibos"
        Me.DsTemporal_Recibos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_Recibos
        '
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_Recibos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_Recibos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_Recibos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_Recibos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_Recibos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_Recibos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_Recibos.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewTemporal_Recibos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecibo, Me.colFecha, Me.colCompletado, Me.colComentarios})
        Me.grdviewTemporal_Recibos.GridControl = Me.grdTemporal_Recibos
        Me.grdviewTemporal_Recibos.Name = "grdviewTemporal_Recibos"
        Me.grdviewTemporal_Recibos.OptionsBehavior.Editable = False
        Me.grdviewTemporal_Recibos.OptionsBehavior.ReadOnly = True
        Me.grdviewTemporal_Recibos.OptionsView.ColumnAutoWidth = False
        Me.grdviewTemporal_Recibos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_Recibos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_Recibos.OptionsView.ShowFooter = True
        Me.grdviewTemporal_Recibos.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_Recibos.PaintStyleName = "Flat"
        '
        'colRecibo
        '
        Me.colRecibo.AppearanceCell.Options.UseTextOptions = True
        Me.colRecibo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecibo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRecibo.AppearanceHeader.Options.UseFont = True
        Me.colRecibo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRecibo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecibo.FieldName = "Recibo"
        Me.colRecibo.Name = "colRecibo"
        Me.colRecibo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colRecibo.Visible = True
        Me.colRecibo.VisibleIndex = 0
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
        Me.colCompletado.VisibleIndex = 2
        Me.colCompletado.Width = 80
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 3
        Me.colComentarios.Width = 200
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lycNombreArticulo, Me.lycCodigoArticulo, Me.lycNumOrden, Me.lycDeLinea, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(474, 407)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTemporal_Recibos
        Me.LayoutControlItem1.CustomizationFormText = "RECIBOS"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 105)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(454, 282)
        Me.LayoutControlItem1.Text = "RECIBOS"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'lycNombreArticulo
        '
        Me.lycNombreArticulo.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lycNombreArticulo.AppearanceItemCaption.Options.UseFont = True
        Me.lycNombreArticulo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycNombreArticulo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycNombreArticulo.Control = Me.txtNombreArticulo
        Me.lycNombreArticulo.CustomizationFormText = "Nombre Articulo"
        Me.lycNombreArticulo.Location = New System.Drawing.Point(0, 81)
        Me.lycNombreArticulo.Name = "lycNombreArticulo"
        Me.lycNombreArticulo.Size = New System.Drawing.Size(454, 24)
        Me.lycNombreArticulo.Text = "Nombre Articulo"
        Me.lycNombreArticulo.TextSize = New System.Drawing.Size(99, 13)
        '
        'lycCodigoArticulo
        '
        Me.lycCodigoArticulo.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lycCodigoArticulo.AppearanceItemCaption.Options.UseFont = True
        Me.lycCodigoArticulo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycCodigoArticulo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycCodigoArticulo.Control = Me.txtCodigoArticulo
        Me.lycCodigoArticulo.CustomizationFormText = "Codigo Articulo"
        Me.lycCodigoArticulo.Location = New System.Drawing.Point(0, 57)
        Me.lycCodigoArticulo.Name = "lycCodigoArticulo"
        Me.lycCodigoArticulo.Size = New System.Drawing.Size(231, 24)
        Me.lycCodigoArticulo.Text = "Codigo Articulo"
        Me.lycCodigoArticulo.TextSize = New System.Drawing.Size(99, 13)
        '
        'lycNumOrden
        '
        Me.lycNumOrden.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lycNumOrden.AppearanceItemCaption.Options.UseFont = True
        Me.lycNumOrden.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycNumOrden.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycNumOrden.Control = Me.txtNumOrden
        Me.lycNumOrden.CustomizationFormText = "Numero Orden"
        Me.lycNumOrden.Location = New System.Drawing.Point(0, 33)
        Me.lycNumOrden.Name = "lycNumOrden"
        Me.lycNumOrden.Size = New System.Drawing.Size(181, 24)
        Me.lycNumOrden.Text = "Orden Produccion"
        Me.lycNumOrden.TextSize = New System.Drawing.Size(99, 13)
        '
        'lycDeLinea
        '
        Me.lycDeLinea.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lycDeLinea.AppearanceItemCaption.Options.UseFont = True
        Me.lycDeLinea.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycDeLinea.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycDeLinea.Control = Me.txtDeLinea
        Me.lycDeLinea.CustomizationFormText = "De Linea"
        Me.lycDeLinea.Location = New System.Drawing.Point(298, 57)
        Me.lycDeLinea.Name = "lycDeLinea"
        Me.lycDeLinea.Size = New System.Drawing.Size(156, 24)
        Me.lycDeLinea.Text = "De Linea"
        Me.lycDeLinea.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtPlaneado
        Me.LayoutControlItem2.CustomizationFormText = "Planeado"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(268, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem2.Text = "Planeado"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.lblTitulo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(454, 33)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(181, 33)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(87, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(231, 57)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(67, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnCerrar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(474, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(474, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(474, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'frmTemporal_Recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTemporal_Recibos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtPlaneado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemporal_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporalRecibosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycNombreArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycNumOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDeLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdTemporal_Recibos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_Recibos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsTemporal_Recibos As waProduccion_Pedidos.dsTemporal_Recibos
    Friend WithEvents colRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lycNombreArticulo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycNumOrden As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycCodigoArticulo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDeLinea As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPlaneado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporalRecibosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
