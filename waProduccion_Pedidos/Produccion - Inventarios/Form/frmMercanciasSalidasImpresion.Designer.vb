<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercanciasSalidasImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMercanciasSalidasImpresion))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdTrasladoMercaderiaImpresion = New DevExpress.XtraGrid.GridControl()
        Me.DsTrasladosMercaderia1 = New waProduccion_Pedidos.dsTrasladosMercaderia()
        Me.grdviewTrasladoMercaderiaImpresion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colListaNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuarioAPG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdTrasladoMercaderiaImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrasladosMercaderia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTrasladoMercaderiaImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdTrasladoMercaderiaImpresion)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(729, 475)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdTrasladoMercaderiaImpresion
        '
        Me.grdTrasladoMercaderiaImpresion.DataMember = "dsdtTrasladosMercaderiaImpresion"
        Me.grdTrasladoMercaderiaImpresion.DataSource = Me.DsTrasladosMercaderia1
        Me.grdTrasladoMercaderiaImpresion.Location = New System.Drawing.Point(12, 12)
        Me.grdTrasladoMercaderiaImpresion.MainView = Me.grdviewTrasladoMercaderiaImpresion
        Me.grdTrasladoMercaderiaImpresion.MenuManager = Me.BarManager1
        Me.grdTrasladoMercaderiaImpresion.Name = "grdTrasladoMercaderiaImpresion"
        Me.grdTrasladoMercaderiaImpresion.Size = New System.Drawing.Size(705, 451)
        Me.grdTrasladoMercaderiaImpresion.TabIndex = 4
        Me.grdTrasladoMercaderiaImpresion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTrasladoMercaderiaImpresion})
        '
        'DsTrasladosMercaderia1
        '
        Me.DsTrasladosMercaderia1.DataSetName = "dsTrasladosMercaderia"
        Me.DsTrasladosMercaderia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTrasladoMercaderiaImpresion
        '
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Preview.Options.UseFont = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewTrasladoMercaderiaImpresion.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTrasladoMercaderiaImpresion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colFecha, Me.colHora, Me.colListaNombre, Me.colComentarios, Me.colDocTotal, Me.colUsuarioAPG})
        Me.grdviewTrasladoMercaderiaImpresion.GridControl = Me.grdTrasladoMercaderiaImpresion
        Me.grdviewTrasladoMercaderiaImpresion.Name = "grdviewTrasladoMercaderiaImpresion"
        Me.grdviewTrasladoMercaderiaImpresion.OptionsBehavior.Editable = False
        Me.grdviewTrasladoMercaderiaImpresion.OptionsBehavior.ReadOnly = True
        Me.grdviewTrasladoMercaderiaImpresion.OptionsView.ColumnAutoWidth = False
        Me.grdviewTrasladoMercaderiaImpresion.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTrasladoMercaderiaImpresion.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTrasladoMercaderiaImpresion.OptionsView.ShowGroupPanel = False
        Me.grdviewTrasladoMercaderiaImpresion.PaintStyleName = "Web"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceCell.Options.UseFont = True
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 0
        Me.colNumSAP.Width = 69
        '
        'colFecha
        '
        Me.colFecha.AppearanceCell.Options.UseTextOptions = True
        Me.colFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 80
        '
        'colHora
        '
        Me.colHora.AppearanceCell.Options.UseTextOptions = True
        Me.colHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHora.AppearanceHeader.Options.UseTextOptions = True
        Me.colHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHora.FieldName = "Hora"
        Me.colHora.Name = "colHora"
        Me.colHora.OptionsColumn.ReadOnly = True
        Me.colHora.Visible = True
        Me.colHora.VisibleIndex = 2
        Me.colHora.Width = 49
        '
        'colListaNombre
        '
        Me.colListaNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colListaNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colListaNombre.FieldName = "ListaNombre"
        Me.colListaNombre.Name = "colListaNombre"
        Me.colListaNombre.Visible = True
        Me.colListaNombre.VisibleIndex = 3
        Me.colListaNombre.Width = 111
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 4
        Me.colComentarios.Width = 222
        '
        'colDocTotal
        '
        Me.colDocTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colDocTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDocTotal.FieldName = "DocTotal"
        Me.colDocTotal.Name = "colDocTotal"
        Me.colDocTotal.Visible = True
        Me.colDocTotal.VisibleIndex = 5
        Me.colDocTotal.Width = 81
        '
        'colUsuarioAPG
        '
        Me.colUsuarioAPG.AppearanceHeader.Options.UseTextOptions = True
        Me.colUsuarioAPG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUsuarioAPG.Caption = "APG"
        Me.colUsuarioAPG.FieldName = "UsuarioAPG"
        Me.colUsuarioAPG.Name = "colUsuarioAPG"
        Me.colUsuarioAPG.Visible = True
        Me.colUsuarioAPG.VisibleIndex = 6
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimir})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimir)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnImprimir
        '
        Me.barbtnImprimir.Caption = "Imprimir"
        Me.barbtnImprimir.Glyph = CType(resources.GetObject("barbtnImprimir.Glyph"), System.Drawing.Image)
        Me.barbtnImprimir.Id = 0
        Me.barbtnImprimir.Name = "barbtnImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(729, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 522)
        Me.barDockControlBottom.Size = New System.Drawing.Size(729, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 475)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(729, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 475)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(729, 475)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTrasladoMercaderiaImpresion
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(709, 455)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmTrasladosmercaderiaImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 522)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(745, 560)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(745, 560)
        Me.Name = "frmTrasladosmercaderiaImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Salidas de Mercancias"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdTrasladoMercaderiaImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrasladosMercaderia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTrasladoMercaderiaImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdTrasladoMercaderiaImpresion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTrasladoMercaderiaImpresion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTrasladosMercaderia1 As waProduccion_Pedidos.dsTrasladosMercaderia
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colListaNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuarioAPG As DevExpress.XtraGrid.Columns.GridColumn
End Class
