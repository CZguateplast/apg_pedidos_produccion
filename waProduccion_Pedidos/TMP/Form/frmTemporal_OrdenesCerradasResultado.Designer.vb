<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_OrdenesCerradasResultado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_OrdenesCerradasResultado))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.lbcOrdenesCerradas = New DevExpress.XtraEditors.LabelControl()
        Me.sbtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.grdOrdenesCerradas = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_OrdenesCerradas1 = New waProduccion_Pedidos.dsTemporal_OrdenesCerradas()
        Me.grdviewOrdenesCerradas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreación = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasAtrasado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdOrdenesCerradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_OrdenesCerradas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewOrdenesCerradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
        Me.colEstado.Width = 74
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnImprimir)
        Me.LayoutControl1.Controls.Add(Me.lbcOrdenesCerradas)
        Me.LayoutControl1.Controls.Add(Me.sbtnOk)
        Me.LayoutControl1.Controls.Add(Me.grdOrdenesCerradas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1247, 584)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnImprimir
        '
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(969, 534)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(131, 38)
        Me.btnImprimir.StyleController = Me.LayoutControl1
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        '
        'lbcOrdenesCerradas
        '
        Me.lbcOrdenesCerradas.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbcOrdenesCerradas.Appearance.Options.UseFont = True
        Me.lbcOrdenesCerradas.Location = New System.Drawing.Point(12, 12)
        Me.lbcOrdenesCerradas.Name = "lbcOrdenesCerradas"
        Me.lbcOrdenesCerradas.Size = New System.Drawing.Size(352, 19)
        Me.lbcOrdenesCerradas.StyleController = Me.LayoutControl1
        Me.lbcOrdenesCerradas.TabIndex = 6
        Me.lbcOrdenesCerradas.Text = "Las siguientes Ordenes en SAP se han actualizado"
        '
        'sbtnOk
        '
        Me.sbtnOk.ImageOptions.Image = CType(resources.GetObject("sbtnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.sbtnOk.Location = New System.Drawing.Point(1104, 534)
        Me.sbtnOk.Name = "sbtnOk"
        Me.sbtnOk.Size = New System.Drawing.Size(131, 38)
        Me.sbtnOk.StyleController = Me.LayoutControl1
        Me.sbtnOk.TabIndex = 5
        Me.sbtnOk.Text = "Aceptar"
        '
        'grdOrdenesCerradas
        '
        Me.grdOrdenesCerradas.DataMember = "dsdtTemporal_OrdenesCerradas"
        Me.grdOrdenesCerradas.DataSource = Me.DsTemporal_OrdenesCerradas1
        Me.grdOrdenesCerradas.Location = New System.Drawing.Point(12, 35)
        Me.grdOrdenesCerradas.MainView = Me.grdviewOrdenesCerradas
        Me.grdOrdenesCerradas.Name = "grdOrdenesCerradas"
        Me.grdOrdenesCerradas.Size = New System.Drawing.Size(1223, 495)
        Me.grdOrdenesCerradas.TabIndex = 4
        Me.grdOrdenesCerradas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewOrdenesCerradas})
        '
        'DsTemporal_OrdenesCerradas1
        '
        Me.DsTemporal_OrdenesCerradas1.DataSetName = "dsTemporal_OrdenesCerradas"
        Me.DsTemporal_OrdenesCerradas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewOrdenesCerradas
        '
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewOrdenesCerradas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewOrdenesCerradas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.Preview.Options.UseFont = True
        Me.grdviewOrdenesCerradas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewOrdenesCerradas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewOrdenesCerradas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewOrdenesCerradas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewOrdenesCerradas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewOrdenesCerradas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewOrdenesCerradas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colOrigen, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colEstado
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Cerrado"
        Me.grdviewOrdenesCerradas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grdviewOrdenesCerradas.GridControl = Me.grdOrdenesCerradas
        Me.grdviewOrdenesCerradas.Name = "grdviewOrdenesCerradas"
        Me.grdviewOrdenesCerradas.OptionsBehavior.ReadOnly = True
        Me.grdviewOrdenesCerradas.OptionsView.ColumnAutoWidth = False
        Me.grdviewOrdenesCerradas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewOrdenesCerradas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewOrdenesCerradas.OptionsView.ShowGroupPanel = False
        Me.grdviewOrdenesCerradas.PaintStyleName = "Flat"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 0
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 73
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
        Me.colOrigen.OptionsColumn.ReadOnly = True
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 3
        Me.colOrigen.Width = 73
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
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 4
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
        Me.colNombreArticulo.VisibleIndex = 5
        Me.colNombreArticulo.Width = 300
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceCell.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 6
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceCell.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 7
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 8
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
        Me.colCreación.OptionsColumn.ReadOnly = True
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 9
        Me.colCreación.Width = 80
        '
        'colVencimiento
        '
        Me.colVencimiento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimiento.AppearanceHeader.Options.UseFont = True
        Me.colVencimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.OptionsColumn.ReadOnly = True
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 10
        Me.colVencimiento.Width = 80
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiasAtrasado.AppearanceHeader.Options.UseFont = True
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.OptionsColumn.ReadOnly = True
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 11
        Me.colDiasAtrasado.Width = 91
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1247, 584)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOrdenesCerradas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1227, 499)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sbtnOk
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(1092, 522)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 522)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(957, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.lbcOrdenesCerradas
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1227, 23)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnImprimir
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(957, 522)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'frmTemporal_OrdenesCerradasResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmTemporal_OrdenesCerradasResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ordenes"
        Me.TopMost = True
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdOrdenesCerradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_OrdenesCerradas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewOrdenesCerradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdOrdenesCerradas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewOrdenesCerradas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_OrdenesCerradas1 As waProduccion_Pedidos.dsTemporal_OrdenesCerradas
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasAtrasado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbcOrdenesCerradas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbtnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
