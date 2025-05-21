<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_FichaArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_FichaArticulo))
        Me.lycTemporal_DetalleArticulo = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.picArticulo = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycTemporal_DetalleArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_DetalleArticulo.SuspendLayout()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal_DetalleArticulo
        '
        Me.lycTemporal_DetalleArticulo.Controls.Add(Me.txtCodigoArticulo)
        Me.lycTemporal_DetalleArticulo.Controls.Add(Me.txtNombreArticulo)
        Me.lycTemporal_DetalleArticulo.Controls.Add(Me.picArticulo)
        Me.lycTemporal_DetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_DetalleArticulo.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_DetalleArticulo.Name = "lycTemporal_DetalleArticulo"
        Me.lycTemporal_DetalleArticulo.Root = Me.LayoutControlGroup1
        Me.lycTemporal_DetalleArticulo.Size = New System.Drawing.Size(935, 389)
        Me.lycTemporal_DetalleArticulo.TabIndex = 0
        Me.lycTemporal_DetalleArticulo.Text = "LayoutControl1"
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(447, 12)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(476, 20)
        Me.txtCodigoArticulo.StyleController = Me.lycTemporal_DetalleArticulo
        Me.txtCodigoArticulo.TabIndex = 6
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
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(935, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 389)
        Me.barDockControlBottom.Size = New System.Drawing.Size(935, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 389)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(935, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 389)
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(447, 36)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(476, 20)
        Me.txtNombreArticulo.StyleController = Me.lycTemporal_DetalleArticulo
        Me.txtNombreArticulo.TabIndex = 5
        '
        'picArticulo
        '
        Me.picArticulo.Location = New System.Drawing.Point(12, 12)
        Me.picArticulo.MenuManager = Me.BarManager1
        Me.picArticulo.Name = "picArticulo"
        Me.picArticulo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picArticulo.Size = New System.Drawing.Size(352, 365)
        Me.picArticulo.StyleController = Me.lycTemporal_DetalleArticulo
        Me.picArticulo.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(935, 389)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.picArticulo
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(356, 369)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombreArticulo
        Me.LayoutControlItem2.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(356, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(559, 345)
        Me.LayoutControlItem2.Text = "Nombre Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(356, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem3.Text = "Codigo Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
        '
        'frmTemporal_FichaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 432)
        Me.Controls.Add(Me.lycTemporal_DetalleArticulo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTemporal_FichaArticulo"
        Me.Text = "frmTemporal_DetalleArticulo"
        CType(Me.lycTemporal_DetalleArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_DetalleArticulo.ResumeLayout(False)
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lycTemporal_DetalleArticulo As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picArticulo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
