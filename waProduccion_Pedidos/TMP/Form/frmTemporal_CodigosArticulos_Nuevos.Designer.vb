<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_CodigosArticulos_Nuevos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_CodigosArticulos_Nuevos))
        Me.lycCodigosArticulosNuevos = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.slueCodigoArticulos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.CodigoArticulo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NombreArticulo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycCodigosArticulosNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycCodigosArticulosNuevos.SuspendLayout()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigoArticulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycCodigosArticulosNuevos
        '
        Me.lycCodigosArticulosNuevos.Controls.Add(Me.txtNombreArticulo)
        Me.lycCodigosArticulosNuevos.Controls.Add(Me.slueCodigoArticulos)
        Me.lycCodigosArticulosNuevos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycCodigosArticulosNuevos.Location = New System.Drawing.Point(0, 0)
        Me.lycCodigosArticulosNuevos.Name = "lycCodigosArticulosNuevos"
        Me.lycCodigosArticulosNuevos.Root = Me.LayoutControlGroup1
        Me.lycCodigosArticulosNuevos.Size = New System.Drawing.Size(563, 68)
        Me.lycCodigosArticulosNuevos.TabIndex = 0
        Me.lycCodigosArticulosNuevos.Text = "LayoutControl1"
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Enabled = False
        Me.txtNombreArticulo.Location = New System.Drawing.Point(88, 36)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(463, 20)
        Me.txtNombreArticulo.StyleController = Me.lycCodigosArticulosNuevos
        Me.txtNombreArticulo.TabIndex = 5
        '
        'slueCodigoArticulos
        '
        Me.slueCodigoArticulos.Location = New System.Drawing.Point(88, 12)
        Me.slueCodigoArticulos.Name = "slueCodigoArticulos"
        Me.slueCodigoArticulos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigoArticulos.Properties.NullText = ""
        Me.slueCodigoArticulos.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigoArticulos.Size = New System.Drawing.Size(463, 20)
        Me.slueCodigoArticulos.StyleController = Me.lycCodigosArticulosNuevos
        Me.slueCodigoArticulos.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.CodigoArticulo, Me.NombreArticulo})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(563, 68)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'CodigoArticulo
        '
        Me.CodigoArticulo.Control = Me.slueCodigoArticulos
        Me.CodigoArticulo.CustomizationFormText = "CodigoArticulo"
        Me.CodigoArticulo.Location = New System.Drawing.Point(0, 0)
        Me.CodigoArticulo.Name = "CodigoArticulo"
        Me.CodigoArticulo.Size = New System.Drawing.Size(543, 24)
        Me.CodigoArticulo.Text = "CodigoArticulo"
        Me.CodigoArticulo.TextSize = New System.Drawing.Size(73, 13)
        '
        'NombreArticulo
        '
        Me.NombreArticulo.Control = Me.txtNombreArticulo
        Me.NombreArticulo.CustomizationFormText = "NombreArticulo"
        Me.NombreArticulo.Location = New System.Drawing.Point(0, 24)
        Me.NombreArticulo.Name = "NombreArticulo"
        Me.NombreArticulo.Size = New System.Drawing.Size(543, 24)
        Me.NombreArticulo.Text = "NombreArticulo"
        Me.NombreArticulo.TextSize = New System.Drawing.Size(73, 13)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnCerrar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAgregar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar"
        Me.barbtnAgregar.Glyph = CType(resources.GetObject("barbtnAgregar.Glyph"), System.Drawing.Image)
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 1
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(563, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 68)
        Me.barDockControlBottom.Size = New System.Drawing.Size(563, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 68)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(563, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 68)
        '
        'frmTemporal_CodigosArticulos_Nuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.lycCodigosArticulosNuevos)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Location = New System.Drawing.Point(579, 155)
        Me.MaximumSize = New System.Drawing.Size(579, 155)
        Me.Name = "frmTemporal_CodigosArticulos_Nuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codigos de Articulos sin Asignar"
        CType(Me.lycCodigosArticulosNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycCodigosArticulosNuevos.ResumeLayout(False)
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigoArticulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lycCodigosArticulosNuevos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slueCodigoArticulos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CodigoArticulo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NombreArticulo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
