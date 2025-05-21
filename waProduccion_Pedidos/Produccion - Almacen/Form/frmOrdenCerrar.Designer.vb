<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenCerrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCerrar))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.sbtnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDiasAtraso = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grdCerrarEnsamble = New DevExpress.XtraGrid.GridControl()
        Me.DsCerrarAR1 = New waProduccion_Pedidos.dsCerrarAR()
        Me.grdviewCerrarEnsamble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCerrarEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCerrarAR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCerrarEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.sbtnMostrar)
        Me.LayoutControl1.Controls.Add(Me.txtDiasAtraso)
        Me.LayoutControl1.Controls.Add(Me.grdCerrarEnsamble)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1420, 685)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'sbtnMostrar
        '
        Me.sbtnMostrar.Image = CType(resources.GetObject("sbtnMostrar.Image"), System.Drawing.Image)
        Me.sbtnMostrar.Location = New System.Drawing.Point(191, 12)
        Me.sbtnMostrar.Name = "sbtnMostrar"
        Me.sbtnMostrar.Size = New System.Drawing.Size(127, 22)
        Me.sbtnMostrar.StyleController = Me.LayoutControl1
        Me.sbtnMostrar.TabIndex = 6
        Me.sbtnMostrar.Text = "Mostrar Pedidos"
        '
        'txtDiasAtraso
        '
        Me.txtDiasAtraso.Location = New System.Drawing.Point(137, 12)
        Me.txtDiasAtraso.MaximumSize = New System.Drawing.Size(50, 20)
        Me.txtDiasAtraso.MenuManager = Me.BarManager1
        Me.txtDiasAtraso.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtDiasAtraso.Name = "txtDiasAtraso"
        Me.txtDiasAtraso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiasAtraso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiasAtraso.Size = New System.Drawing.Size(50, 20)
        Me.txtDiasAtraso.StyleController = Me.LayoutControl1
        Me.txtDiasAtraso.TabIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Caption = "Cerrar Ordenes Seleccionadas"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1420, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 732)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1420, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 685)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1420, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 685)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'grdCerrarEnsamble
        '
        Me.grdCerrarEnsamble.DataMember = "dsdtCerrarAR"
        Me.grdCerrarEnsamble.DataSource = Me.DsCerrarAR1
        Me.grdCerrarEnsamble.Location = New System.Drawing.Point(12, 38)
        Me.grdCerrarEnsamble.MainView = Me.grdviewCerrarEnsamble
        Me.grdCerrarEnsamble.Name = "grdCerrarEnsamble"
        Me.grdCerrarEnsamble.Size = New System.Drawing.Size(1396, 635)
        Me.grdCerrarEnsamble.TabIndex = 4
        Me.grdCerrarEnsamble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCerrarEnsamble})
        '
        'DsCerrarAR1
        '
        Me.DsCerrarAR1.DataSetName = "dsCerrarAR"
        Me.DsCerrarAR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewCerrarEnsamble
        '
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.Options.UseFont = True
        Me.grdviewCerrarEnsamble.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewCerrarEnsamble.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCerrarEnsamble.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCerrarEnsamble.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCerrarEnsamble.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCerrarEnsamble.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewCerrarEnsamble.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCerrarEnsamble.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumSAP, Me.colEstado, Me.colTipo, Me.colOrigen, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colCreación, Me.colVencimiento, Me.colDiasAtrasado})
        Me.grdviewCerrarEnsamble.GridControl = Me.grdCerrarEnsamble
        Me.grdviewCerrarEnsamble.Name = "grdviewCerrarEnsamble"
        Me.grdviewCerrarEnsamble.OptionsBehavior.Editable = False
        Me.grdviewCerrarEnsamble.OptionsBehavior.ReadOnly = True
        Me.grdviewCerrarEnsamble.OptionsFind.AlwaysVisible = True
        Me.grdviewCerrarEnsamble.OptionsFind.ShowClearButton = False
        Me.grdviewCerrarEnsamble.OptionsFind.ShowCloseButton = False
        Me.grdviewCerrarEnsamble.OptionsSelection.MultiSelect = True
        Me.grdviewCerrarEnsamble.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewCerrarEnsamble.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdviewCerrarEnsamble.OptionsSelection.UseIndicatorForSelection = False
        Me.grdviewCerrarEnsamble.OptionsView.ColumnAutoWidth = False
        Me.grdviewCerrarEnsamble.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCerrarEnsamble.OptionsView.ShowFooter = True
        Me.grdviewCerrarEnsamble.OptionsView.ShowGroupPanel = False
        Me.grdviewCerrarEnsamble.PaintStyleName = "Web"
        '
        'colNumSAP
        '
        Me.colNumSAP.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colNumSAP.AppearanceCell.Options.UseFont = True
        Me.colNumSAP.AppearanceCell.Options.UseForeColor = True
        Me.colNumSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSAP.FieldName = "NumSAP"
        Me.colNumSAP.Name = "colNumSAP"
        Me.colNumSAP.OptionsColumn.AllowFocus = False
        Me.colNumSAP.OptionsColumn.ReadOnly = True
        Me.colNumSAP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumSAP", "{0:n0} Ordenes")})
        Me.colNumSAP.Visible = True
        Me.colNumSAP.VisibleIndex = 1
        Me.colNumSAP.Width = 100
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
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 2
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
        Me.colTipo.OptionsColumn.AllowFocus = False
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 3
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
        Me.colOrigen.OptionsColumn.AllowFocus = False
        Me.colOrigen.OptionsColumn.ReadOnly = True
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 4
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
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 5
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
        Me.colNombreArticulo.OptionsColumn.AllowFocus = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 6
        Me.colNombreArticulo.Width = 400
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaneado.AppearanceCell.Options.UseFont = True
        Me.colPlaneado.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowFocus = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 7
        Me.colPlaneado.Width = 85
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCompletado.AppearanceCell.Options.UseFont = True
        Me.colCompletado.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowFocus = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 8
        Me.colCompletado.Width = 85
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowFocus = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 9
        Me.colPendiente.Width = 85
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
        Me.colCreación.OptionsColumn.AllowFocus = False
        Me.colCreación.OptionsColumn.ReadOnly = True
        Me.colCreación.Visible = True
        Me.colCreación.VisibleIndex = 10
        Me.colCreación.Width = 85
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
        Me.colVencimiento.OptionsColumn.AllowFocus = False
        Me.colVencimiento.OptionsColumn.ReadOnly = True
        Me.colVencimiento.Visible = True
        Me.colVencimiento.VisibleIndex = 11
        Me.colVencimiento.Width = 85
        '
        'colDiasAtrasado
        '
        Me.colDiasAtrasado.AppearanceCell.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiasAtrasado.AppearanceHeader.Options.UseFont = True
        Me.colDiasAtrasado.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiasAtrasado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiasAtrasado.FieldName = "Dias Atrasado"
        Me.colDiasAtrasado.Name = "colDiasAtrasado"
        Me.colDiasAtrasado.OptionsColumn.AllowFocus = False
        Me.colDiasAtrasado.OptionsColumn.ReadOnly = True
        Me.colDiasAtrasado.Visible = True
        Me.colDiasAtrasado.VisibleIndex = 12
        Me.colDiasAtrasado.Width = 85
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1420, 685)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdCerrarEnsamble
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1400, 639)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDiasAtraso
        Me.LayoutControlItem2.CustomizationFormText = "Dias de Atraso"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(179, 26)
        Me.LayoutControlItem2.Text = "Dias de atraso mayor a >"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(122, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbtnMostrar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(179, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(131, 26)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(310, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1090, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmOrdenCerrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 732)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOrdenCerrar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerrar ordenes de Ensamble"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCerrarEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCerrarAR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCerrarEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdCerrarEnsamble As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCerrarEnsamble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsCerrarAR1 As waProduccion_Pedidos.dsCerrarAR
    Friend WithEvents colNumSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreación As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasAtrasado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbtnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDiasAtraso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
