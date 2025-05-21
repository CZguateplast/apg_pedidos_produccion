<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoBarras
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim UpcaGenerator1 As DevExpress.XtraPrinting.BarCode.UPCAGenerator = New DevExpress.XtraPrinting.BarCode.UPCAGenerator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoBarras))
        Me.lycCodigoBarras = New DevExpress.XtraLayout.LayoutControl()
        Me.lbl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bccDUN14 = New DevExpress.XtraEditors.BarCodeControl()
        Me.bccCodigoBarras = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtDUN14 = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barCodigoBarras = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnGenerarCodigoBarras = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnBorrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtUPC = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycCodigoBarras.SuspendLayout()
        CType(Me.txtDUN14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUPC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycCodigoBarras
        '
        Me.lycCodigoBarras.Controls.Add(Me.lbl2)
        Me.lycCodigoBarras.Controls.Add(Me.lbl1)
        Me.lycCodigoBarras.Controls.Add(Me.bccDUN14)
        Me.lycCodigoBarras.Controls.Add(Me.bccCodigoBarras)
        Me.lycCodigoBarras.Controls.Add(Me.txtDUN14)
        Me.lycCodigoBarras.Controls.Add(Me.txtUPC)
        Me.lycCodigoBarras.Controls.Add(Me.txtCodigoBarras)
        Me.lycCodigoBarras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycCodigoBarras.Location = New System.Drawing.Point(0, 29)
        Me.lycCodigoBarras.Name = "lycCodigoBarras"
        Me.lycCodigoBarras.Root = Me.LayoutControlGroup1
        Me.lycCodigoBarras.Size = New System.Drawing.Size(355, 340)
        Me.lycCodigoBarras.TabIndex = 0
        Me.lycCodigoBarras.Text = "LayoutControl1"
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(114, 12)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(112, 13)
        Me.lbl2.StyleController = Me.lycCodigoBarras
        Me.lbl2.TabIndex = 10
        Me.lbl2.Text = "Ingrese UPC (6 Digitos)"
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(76, 29)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(187, 13)
        Me.lbl1.StyleController = Me.lycCodigoBarras
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "ó ingrese Codigo de Barras (12 Digitos)"
        '
        'bccDUN14
        '
        Me.bccDUN14.AutoModule = True
        Me.bccDUN14.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccDUN14.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccDUN14.Location = New System.Drawing.Point(24, 240)
        Me.bccDUN14.MaximumSize = New System.Drawing.Size(0, 70)
        Me.bccDUN14.MinimumSize = New System.Drawing.Size(0, 70)
        Me.bccDUN14.Name = "bccDUN14"
        Me.bccDUN14.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.bccDUN14.Size = New System.Drawing.Size(307, 70)
        Me.bccDUN14.StyleController = Me.lycCodigoBarras
        Me.bccDUN14.Symbology = Code128Generator1
        Me.bccDUN14.TabIndex = 8
        '
        'bccCodigoBarras
        '
        Me.bccCodigoBarras.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccCodigoBarras.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bccCodigoBarras.Location = New System.Drawing.Point(12, 106)
        Me.bccCodigoBarras.MaximumSize = New System.Drawing.Size(0, 70)
        Me.bccCodigoBarras.MinimumSize = New System.Drawing.Size(0, 70)
        Me.bccCodigoBarras.Name = "bccCodigoBarras"
        Me.bccCodigoBarras.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.bccCodigoBarras.Size = New System.Drawing.Size(331, 70)
        Me.bccCodigoBarras.StyleController = Me.lycCodigoBarras
        Me.bccCodigoBarras.Symbology = UpcaGenerator1
        Me.bccCodigoBarras.TabIndex = 7
        '
        'txtDUN14
        '
        Me.txtDUN14.Location = New System.Drawing.Point(105, 210)
        Me.txtDUN14.MenuManager = Me.BarManager1
        Me.txtDUN14.Name = "txtDUN14"
        Me.txtDUN14.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtDUN14.Properties.Appearance.Options.UseFont = True
        Me.txtDUN14.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDUN14.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDUN14.Properties.ReadOnly = True
        Me.txtDUN14.Size = New System.Drawing.Size(226, 26)
        Me.txtDUN14.StyleController = Me.lycCodigoBarras
        Me.txtDUN14.TabIndex = 6
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barCodigoBarras, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnGenerarCodigoBarras, Me.barbtnBorrar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barCodigoBarras
        '
        Me.barCodigoBarras.BarName = "Tools"
        Me.barCodigoBarras.DockCol = 0
        Me.barCodigoBarras.DockRow = 0
        Me.barCodigoBarras.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barCodigoBarras.OptionsBar.AllowQuickCustomization = False
        Me.barCodigoBarras.OptionsBar.DrawBorder = False
        Me.barCodigoBarras.OptionsBar.DrawDragBorder = False
        Me.barCodigoBarras.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnGenerarCodigoBarras, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBorrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'barbtnGenerarCodigoBarras
        '
        Me.barbtnGenerarCodigoBarras.Caption = "Generar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo"
        Me.barbtnGenerarCodigoBarras.Id = 1
        Me.barbtnGenerarCodigoBarras.ImageOptions.Image = CType(resources.GetObject("barbtnGenerarCodigoBarras.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnGenerarCodigoBarras.Name = "barbtnGenerarCodigoBarras"
        '
        'barbtnBorrar
        '
        Me.barbtnBorrar.Caption = "Borrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Información"
        Me.barbtnBorrar.Id = 2
        Me.barbtnBorrar.ImageOptions.Image = CType(resources.GetObject("barbtnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBorrar.Name = "barbtnBorrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(355, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 369)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(355, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 340)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(355, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 340)
        '
        'txtUPC
        '
        Me.txtUPC.Location = New System.Drawing.Point(93, 46)
        Me.txtUPC.MenuManager = Me.BarManager1
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtUPC.Properties.Appearance.Options.UseFont = True
        Me.txtUPC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUPC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUPC.Properties.MaxLength = 6
        Me.txtUPC.Size = New System.Drawing.Size(250, 26)
        Me.txtUPC.StyleController = Me.lycCodigoBarras
        Me.txtUPC.TabIndex = 5
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(93, 76)
        Me.txtCodigoBarras.MenuManager = Me.BarManager1
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtCodigoBarras.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoBarras.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoBarras.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoBarras.Properties.MaxLength = 12
        Me.txtCodigoBarras.Size = New System.Drawing.Size(250, 26)
        Me.txtCodigoBarras.StyleController = Me.lycCodigoBarras
        Me.txtCodigoBarras.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlGroup2, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(355, 340)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bccCodigoBarras
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(335, 74)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(335, 152)
        Me.LayoutControlGroup2.Text = "DUN 14"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtDUN14
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(311, 30)
        Me.LayoutControlItem3.Text = "DUN14"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(78, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bccDUN14
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(311, 80)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 17)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(64, 17)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(255, 17)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(80, 17)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(102, 17)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(218, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(117, 17)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.txtCodigoBarras
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(335, 30)
        Me.LayoutControlItem1.Text = "Codigo Barras"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(78, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtUPC
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(335, 30)
        Me.LayoutControlItem2.Text = "UPC"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(78, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lbl2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(102, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(116, 17)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lbl1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(64, 17)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(191, 17)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'frmCodigoBarras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 412)
        Me.Controls.Add(Me.lycCodigoBarras)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCodigoBarras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCodigoBarras"
        CType(Me.lycCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycCodigoBarras.ResumeLayout(False)
        CType(Me.txtDUN14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUPC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycCodigoBarras As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barCodigoBarras As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bccDUN14 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents bccCodigoBarras As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents txtDUN14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUPC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barbtnGenerarCodigoBarras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnBorrar As DevExpress.XtraBars.BarButtonItem
End Class
