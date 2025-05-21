<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_ProduccionColores_Padre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_ProduccionColores_Padre))
        Me.lycFondo = New DevExpress.XtraLayout.LayoutControl()
        Me.grdColores = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_ProduccionColores_Padre1 = New waProduccion_Pedidos.dsTemporal_ProduccionColores_Padre()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAceptar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycFondo.SuspendLayout()
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_ProduccionColores_Padre1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycFondo
        '
        Me.lycFondo.Controls.Add(Me.grdColores)
        Me.lycFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycFondo.Location = New System.Drawing.Point(0, 0)
        Me.lycFondo.Name = "lycFondo"
        Me.lycFondo.Root = Me.LayoutControlGroup1
        Me.lycFondo.Size = New System.Drawing.Size(502, 314)
        Me.lycFondo.TabIndex = 0
        Me.lycFondo.Text = "LayoutControl1"
        '
        'grdColores
        '
        Me.grdColores.DataMember = "dsdtColores"
        Me.grdColores.DataSource = Me.DsTemporal_ProduccionColores_Padre1
        Me.grdColores.Location = New System.Drawing.Point(12, 12)
        Me.grdColores.MainView = Me.grdviewColores
        Me.grdColores.MenuManager = Me.BarManager1
        Me.grdColores.Name = "grdColores"
        Me.grdColores.Size = New System.Drawing.Size(478, 290)
        Me.grdColores.TabIndex = 4
        Me.grdColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewColores})
        '
        'DsTemporal_ProduccionColores_Padre1
        '
        Me.DsTemporal_ProduccionColores_Padre1.DataSetName = "dsTemporal_ProduccionColores_Padre"
        Me.DsTemporal_ProduccionColores_Padre1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewColores
        '
        Me.grdviewColores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewColores.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewColores.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewColores.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewColores.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewColores.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewColores.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewColores.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewColores.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewColores.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewColores.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewColores.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewColores.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewColores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewColores.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewColores.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewColores.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewColores.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewColores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewColores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewColores.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewColores.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewColores.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewColores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewColores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewColores.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewColores.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewColores.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewColores.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewColores.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewColores.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewColores.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewColores.Appearance.Preview.Options.UseFont = True
        Me.grdviewColores.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewColores.Appearance.Row.Options.UseBackColor = True
        Me.grdviewColores.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewColores.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewColores.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewColores.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewColores.ColumnPanelRowHeight = 35
        Me.grdviewColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colCodigoPadre, Me.colColor, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProdFinal, Me.colTipoMaterial})
        Me.grdviewColores.GridControl = Me.grdColores
        Me.grdviewColores.Name = "grdviewColores"
        Me.grdviewColores.OptionsBehavior.Editable = False
        Me.grdviewColores.OptionsBehavior.ReadOnly = True
        Me.grdviewColores.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewColores.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewColores.OptionsView.ShowFooter = True
        Me.grdviewColores.OptionsView.ShowGroupPanel = False
        Me.grdviewColores.PaintStyleName = "Web"
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
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 102
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        '
        'colCodigoPadre
        '
        Me.colCodigoPadre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoPadre.AppearanceHeader.Options.UseFont = True
        Me.colCodigoPadre.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoPadre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPadre.FieldName = "CodigoPadre"
        Me.colCodigoPadre.Name = "colCodigoPadre"
        Me.colCodigoPadre.Width = 127
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 1
        Me.colColor.Width = 58
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 2
        Me.colPlaneado.Width = 93
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 3
        Me.colCompletado.Width = 93
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 4
        Me.colPendiente.Width = 114
        '
        'colProdFinal
        '
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        '
        'colTipoMaterial
        '
        Me.colTipoMaterial.FieldName = "TipoMaterial"
        Me.colTipoMaterial.Name = "colTipoMaterial"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnAceptar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAceptar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnAceptar
        '
        Me.barbtnAceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAceptar.Caption = "Aceptar"
        Me.barbtnAceptar.Id = 1
        Me.barbtnAceptar.ImageOptions.Image = CType(resources.GetObject("barbtnAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAceptar.Name = "barbtnAceptar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(502, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 314)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(502, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 314)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(502, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 314)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(502, 314)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdColores
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(482, 294)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmTemporal_ProduccionColores_Padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycFondo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTemporal_ProduccionColores_Padre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_ProduccionColores_Padre"
        CType(Me.lycFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycFondo.ResumeLayout(False)
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_ProduccionColores_Padre1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycFondo As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAceptar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsTemporal_ProduccionColores_Padre1 As waProduccion_Pedidos.dsTemporal_ProduccionColores_Padre
    Friend WithEvents grdviewColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
