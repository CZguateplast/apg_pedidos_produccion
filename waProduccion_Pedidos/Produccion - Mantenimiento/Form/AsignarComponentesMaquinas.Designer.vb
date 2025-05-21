<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarComponentesMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarComponentesMaquinas))
        Me.lycAsignarComponentesMaquinas = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtMolde = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcHorizontal1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.sbdcVertical3 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barbtnBajar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSeleccionar = New DevExpress.XtraBars.BarButtonItem()
        Me.txtNombreComponente = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoComponente = New DevExpress.XtraEditors.TextEdit()
        Me.grdMaquinasDisponibles = New DevExpress.XtraGrid.GridControl()
        Me.DsAsignarComponentesMaquinas1 = New waProduccion_Pedidos.dsAsignarComponentesMaquinas()
        Me.grdviewMaquinasDisponibles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdMaquinasAsignadas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewMaquinasAsignadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdComponentes = New DevExpress.XtraGrid.GridControl()
        Me.grdviewComponentes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSubir = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lycAsignarComponentesMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycAsignarComponentesMaquinas.SuspendLayout()
        CType(Me.txtMolde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreComponente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoComponente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsignarComponentesMaquinas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycAsignarComponentesMaquinas
        '
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.lblTitulo)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.txtMolde)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.sbdcVertical3)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.txtNombreComponente)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.txtCodigoComponente)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.grdMaquinasDisponibles)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.sbdcHorizontal1)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.grdMaquinasAsignadas)
        Me.lycAsignarComponentesMaquinas.Controls.Add(Me.grdComponentes)
        Me.lycAsignarComponentesMaquinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycAsignarComponentesMaquinas.Location = New System.Drawing.Point(0, 0)
        Me.lycAsignarComponentesMaquinas.Name = "lycAsignarComponentesMaquinas"
        Me.lycAsignarComponentesMaquinas.Root = Me.LayoutControlGroup1
        Me.lycAsignarComponentesMaquinas.Size = New System.Drawing.Size(964, 483)
        Me.lycAsignarComponentesMaquinas.TabIndex = 0
        Me.lycAsignarComponentesMaquinas.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(354, 25)
        Me.lblTitulo.StyleController = Me.lycAsignarComponentesMaquinas
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Asignar Componentes a Maquinas"
        '
        'txtMolde
        '
        Me.txtMolde.Enabled = False
        Me.txtMolde.Location = New System.Drawing.Point(901, 12)
        Me.txtMolde.MenuManager = Me.BarManager1
        Me.txtMolde.Name = "txtMolde"
        Me.txtMolde.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMolde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMolde.Size = New System.Drawing.Size(51, 20)
        Me.txtMolde.StyleController = Me.lycAsignarComponentesMaquinas
        Me.txtMolde.TabIndex = 11
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcHorizontal1)
        Me.BarManager1.DockControls.Add(Me.sbdcVertical3)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnBajar, Me.barbtnSeleccionar})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(964, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 483)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(964, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 483)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(964, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 483)
        '
        'sbdcHorizontal1
        '
        Me.sbdcHorizontal1.CausesValidation = False
        Me.sbdcHorizontal1.Location = New System.Drawing.Point(533, 12)
        Me.sbdcHorizontal1.Manager = Me.BarManager1
        Me.sbdcHorizontal1.Name = "sbdcHorizontal1"
        Me.sbdcHorizontal1.Size = New System.Drawing.Size(72, 47)
        Me.sbdcHorizontal1.Text = "StandaloneBarDockControl1"
        '
        'sbdcVertical3
        '
        Me.sbdcVertical3.CausesValidation = False
        Me.sbdcVertical3.IsVertical = True
        Me.sbdcVertical3.Location = New System.Drawing.Point(917, 63)
        Me.sbdcVertical3.Manager = Me.BarManager1
        Me.sbdcVertical3.Name = "sbdcVertical3"
        Me.sbdcVertical3.Size = New System.Drawing.Size(35, 94)
        Me.sbdcVertical3.Text = "StandaloneBarDockControl1"
        '
        'barbtnBajar
        '
        Me.barbtnBajar.Caption = "Bajar"
        Me.barbtnBajar.Enabled = False
        Me.barbtnBajar.Id = 0
        Me.barbtnBajar.ImageOptions.Image = CType(resources.GetObject("barbtnBajar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBajar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnBajar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnBajar.Name = "barbtnBajar"
        '
        'barbtnSeleccionar
        '
        Me.barbtnSeleccionar.Caption = "Seleccionar"
        Me.barbtnSeleccionar.Id = 1
        Me.barbtnSeleccionar.ImageOptions.Image = CType(resources.GetObject("barbtnSeleccionar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSeleccionar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnSeleccionar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnSeleccionar.Name = "barbtnSeleccionar"
        '
        'txtNombreComponente
        '
        Me.txtNombreComponente.Enabled = False
        Me.txtNombreComponente.Location = New System.Drawing.Point(713, 36)
        Me.txtNombreComponente.MenuManager = Me.BarManager1
        Me.txtNombreComponente.Name = "txtNombreComponente"
        Me.txtNombreComponente.Size = New System.Drawing.Size(239, 20)
        Me.txtNombreComponente.StyleController = Me.lycAsignarComponentesMaquinas
        Me.txtNombreComponente.TabIndex = 9
        '
        'txtCodigoComponente
        '
        Me.txtCodigoComponente.Enabled = False
        Me.txtCodigoComponente.Location = New System.Drawing.Point(713, 12)
        Me.txtCodigoComponente.MaximumSize = New System.Drawing.Size(80, 0)
        Me.txtCodigoComponente.MenuManager = Me.BarManager1
        Me.txtCodigoComponente.MinimumSize = New System.Drawing.Size(80, 0)
        Me.txtCodigoComponente.Name = "txtCodigoComponente"
        Me.txtCodigoComponente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoComponente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoComponente.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigoComponente.StyleController = Me.lycAsignarComponentesMaquinas
        Me.txtCodigoComponente.TabIndex = 8
        '
        'grdMaquinasDisponibles
        '
        Me.grdMaquinasDisponibles.DataMember = "dsdtMaquinasDisponibles"
        Me.grdMaquinasDisponibles.DataSource = Me.DsAsignarComponentesMaquinas1
        Me.grdMaquinasDisponibles.Location = New System.Drawing.Point(609, 63)
        Me.grdMaquinasDisponibles.MainView = Me.grdviewMaquinasDisponibles
        Me.grdMaquinasDisponibles.MaximumSize = New System.Drawing.Size(100, 0)
        Me.grdMaquinasDisponibles.MenuManager = Me.BarManager1
        Me.grdMaquinasDisponibles.MinimumSize = New System.Drawing.Size(100, 0)
        Me.grdMaquinasDisponibles.Name = "grdMaquinasDisponibles"
        Me.grdMaquinasDisponibles.Size = New System.Drawing.Size(100, 408)
        Me.grdMaquinasDisponibles.TabIndex = 7
        Me.grdMaquinasDisponibles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinasDisponibles})
        '
        'DsAsignarComponentesMaquinas1
        '
        Me.DsAsignarComponentesMaquinas1.DataSetName = "dsAsignarComponentesMaquinas"
        Me.DsAsignarComponentesMaquinas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewMaquinasDisponibles
        '
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.grdviewMaquinasDisponibles.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMaquinasDisponibles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.Preview.Options.UseFont = True
        Me.grdviewMaquinasDisponibles.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasDisponibles.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewMaquinasDisponibles.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMaquinasDisponibles.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasDisponibles.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewMaquinasDisponibles.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinasDisponibles.ColumnPanelRowHeight = 35
        Me.grdviewMaquinasDisponibles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1})
        Me.grdviewMaquinasDisponibles.GridControl = Me.grdMaquinasDisponibles
        Me.grdviewMaquinasDisponibles.Name = "grdviewMaquinasDisponibles"
        Me.grdviewMaquinasDisponibles.OptionsBehavior.Editable = False
        Me.grdviewMaquinasDisponibles.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowColumnMoving = False
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowColumnResizing = False
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowFilter = False
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowGroup = False
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdviewMaquinasDisponibles.OptionsCustomization.AllowSort = False
        Me.grdviewMaquinasDisponibles.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinasDisponibles.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinasDisponibles.OptionsView.ShowFooter = True
        Me.grdviewMaquinasDisponibles.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinasDisponibles.OptionsView.ShowViewCaption = True
        Me.grdviewMaquinasDisponibles.PaintStyleName = "Flat"
        Me.grdviewMaquinasDisponibles.ViewCaption = "DISPONIBLES"
        '
        'colId1
        '
        Me.colId1.AppearanceCell.Options.UseTextOptions = True
        Me.colId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId1.AppearanceHeader.Options.UseFont = True
        Me.colId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId1.Caption = "Maquina"
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0}")})
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        '
        'grdMaquinasAsignadas
        '
        Me.grdMaquinasAsignadas.DataMember = "dsdtMaquinasAsignadas"
        Me.grdMaquinasAsignadas.DataSource = Me.DsAsignarComponentesMaquinas1
        Me.grdMaquinasAsignadas.Location = New System.Drawing.Point(713, 63)
        Me.grdMaquinasAsignadas.MainView = Me.grdviewMaquinasAsignadas
        Me.grdMaquinasAsignadas.MaximumSize = New System.Drawing.Size(200, 0)
        Me.grdMaquinasAsignadas.MinimumSize = New System.Drawing.Size(200, 0)
        Me.grdMaquinasAsignadas.Name = "grdMaquinasAsignadas"
        Me.grdMaquinasAsignadas.Size = New System.Drawing.Size(200, 408)
        Me.grdMaquinasAsignadas.TabIndex = 5
        Me.grdMaquinasAsignadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinasAsignadas})
        '
        'grdviewMaquinasAsignadas
        '
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMaquinasAsignadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Options.UseFont = True
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.ColumnPanelRowHeight = 35
        Me.grdviewMaquinasAsignadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioridad, Me.colMaquina, Me.colEstatus1})
        Me.grdviewMaquinasAsignadas.GridControl = Me.grdMaquinasAsignadas
        Me.grdviewMaquinasAsignadas.Name = "grdviewMaquinasAsignadas"
        Me.grdviewMaquinasAsignadas.OptionsBehavior.Editable = False
        Me.grdviewMaquinasAsignadas.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinasAsignadas.OptionsCustomization.AllowColumnMoving = False
        Me.grdviewMaquinasAsignadas.OptionsCustomization.AllowColumnResizing = False
        Me.grdviewMaquinasAsignadas.OptionsCustomization.AllowFilter = False
        Me.grdviewMaquinasAsignadas.OptionsCustomization.AllowGroup = False
        Me.grdviewMaquinasAsignadas.OptionsCustomization.AllowSort = False
        Me.grdviewMaquinasAsignadas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinasAsignadas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinasAsignadas.OptionsView.ShowFooter = True
        Me.grdviewMaquinasAsignadas.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinasAsignadas.OptionsView.ShowViewCaption = True
        Me.grdviewMaquinasAsignadas.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        Me.grdviewMaquinasAsignadas.PaintStyleName = "Flat"
        Me.grdviewMaquinasAsignadas.ViewCaption = "ASIGNADAS"
        '
        'colPrioridad
        '
        Me.colPrioridad.AppearanceCell.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrioridad.AppearanceHeader.Options.UseFont = True
        Me.colPrioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 1
        Me.colPrioridad.Width = 59
        '
        'colMaquina
        '
        Me.colMaquina.AppearanceCell.Options.UseTextOptions = True
        Me.colMaquina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquina.AppearanceHeader.Options.UseFont = True
        Me.colMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.FieldName = "Maquina"
        Me.colMaquina.Name = "colMaquina"
        Me.colMaquina.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Maquina", "{0} Asignadas")})
        Me.colMaquina.Visible = True
        Me.colMaquina.VisibleIndex = 0
        Me.colMaquina.Width = 67
        '
        'colEstatus1
        '
        Me.colEstatus1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus1.AppearanceHeader.Options.UseFont = True
        Me.colEstatus1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus1.Caption = "Activo"
        Me.colEstatus1.FieldName = "Estatus"
        Me.colEstatus1.Name = "colEstatus1"
        Me.colEstatus1.Visible = True
        Me.colEstatus1.VisibleIndex = 2
        Me.colEstatus1.Width = 56
        '
        'grdComponentes
        '
        Me.grdComponentes.DataMember = "dsdtComponentes"
        Me.grdComponentes.DataSource = Me.DsAsignarComponentesMaquinas1
        Me.grdComponentes.Location = New System.Drawing.Point(12, 63)
        Me.grdComponentes.MainView = Me.grdviewComponentes
        Me.grdComponentes.Name = "grdComponentes"
        Me.grdComponentes.Size = New System.Drawing.Size(593, 408)
        Me.grdComponentes.TabIndex = 4
        Me.grdComponentes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewComponentes})
        '
        'grdviewComponentes
        '
        Me.grdviewComponentes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewComponentes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewComponentes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewComponentes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grdviewComponentes.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewComponentes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.grdviewComponentes.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdviewComponentes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewComponentes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewComponentes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewComponentes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewComponentes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdviewComponentes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewComponentes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.grdviewComponentes.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.Preview.Options.UseFont = True
        Me.grdviewComponentes.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewComponentes.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewComponentes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewComponentes.Appearance.Row.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewComponentes.Appearance.Row.Options.UseForeColor = True
        Me.grdviewComponentes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewComponentes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grdviewComponentes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewComponentes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewComponentes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewComponentes.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewComponentes.ColumnPanelRowHeight = 35
        Me.grdviewComponentes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDescripcion, Me.colMolde, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewComponentes.GridControl = Me.grdComponentes
        Me.grdviewComponentes.Name = "grdviewComponentes"
        Me.grdviewComponentes.OptionsBehavior.Editable = False
        Me.grdviewComponentes.OptionsBehavior.ReadOnly = True
        Me.grdviewComponentes.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewComponentes.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewComponentes.OptionsView.ShowFooter = True
        Me.grdviewComponentes.OptionsView.ShowGroupPanel = False
        Me.grdviewComponentes.OptionsView.ShowViewCaption = True
        Me.grdviewComponentes.PaintStyleName = "UltraFlat"
        Me.grdviewComponentes.ViewCaption = "Componentes"
        '
        'colId
        '
        Me.colId.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceCell.Options.UseFont = True
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.Caption = "Componente"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 90
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Nombre"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Descripcion", "{0} Componentes Disponibles")})
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 295
        '
        'colMolde
        '
        Me.colMolde.AppearanceCell.Options.UseTextOptions = True
        Me.colMolde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMolde.AppearanceHeader.Options.UseFont = True
        Me.colMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.Caption = "# Molde"
        Me.colMolde.FieldName = "Molde"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Visible = True
        Me.colMolde.VisibleIndex = 2
        Me.colMolde.Width = 70
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus.AppearanceHeader.Options.UseFont = True
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.Caption = "Activo"
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 3
        Me.colEstatus.Width = 73
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Width = 100
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        Me.colBit_CreacionFecha.Width = 100
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Width = 100
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Width = 100
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(964, 483)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdComponentes
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(597, 412)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdMaquinasAsignadas
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(701, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(204, 412)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(358, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(163, 51)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sbdcHorizontal1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(521, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(76, 51)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdMaquinasDisponibles
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(597, 51)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(104, 412)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtCodigoComponente
        Me.LayoutControlItem5.CustomizationFormText = "Codigo Componente"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(597, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(188, 24)
        Me.LayoutControlItem5.Text = "Codigo Componente"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtNombreComponente
        Me.LayoutControlItem6.CustomizationFormText = "Nombre Componente"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(597, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(347, 27)
        Me.LayoutControlItem6.Text = "Nombre Componente"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.sbdcVertical3
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(905, 51)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(39, 412)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.txtMolde
        Me.LayoutControlItem8.Location = New System.Drawing.Point(785, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem8.Text = "Molde"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.lblTitulo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(358, 51)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 0
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSeleccionar)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcHorizontal1
        Me.Bar1.Text = "Tools"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(964, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 483)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(964, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 483)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(964, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 483)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar5})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEliminar, Me.barbtnSubir, Me.barbtnCerrar, Me.barbtnImprimirGrid, Me.barbtnBuscar})
        Me.BarManager3.MaxItemId = 5
        Me.BarManager3.StatusBar = Me.Bar5
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSubir), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnBajar)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcVertical3
        Me.Bar2.Text = "Tools"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Eliminar"
        Me.barbtnEliminar.Enabled = False
        Me.barbtnEliminar.Id = 0
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'barbtnSubir
        '
        Me.barbtnSubir.Caption = "Subir"
        Me.barbtnSubir.Enabled = False
        Me.barbtnSubir.Id = 1
        Me.barbtnSubir.ImageOptions.Image = CType(resources.GetObject("barbtnSubir.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSubir.ImageOptions.LargeImage = CType(resources.GetObject("barbtnSubir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnSubir.Name = "barbtnSubir"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 4
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 3
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 2
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(964, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 483)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(964, 43)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 483)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(964, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 483)
        '
        'frmAsignarComponentesMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 526)
        Me.Controls.Add(Me.lycAsignarComponentesMaquinas)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarComponentesMaquinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AsignarComponentesMaquinas"
        CType(Me.lycAsignarComponentesMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycAsignarComponentesMaquinas.ResumeLayout(False)
        CType(Me.txtMolde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreComponente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoComponente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsignarComponentesMaquinas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMaquinasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMaquinasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycAsignarComponentesMaquinas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdMaquinasAsignadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinasAsignadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdComponentes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewComponentes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sbdcHorizontal1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents grdMaquinasDisponibles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinasDisponibles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreComponente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoComponente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbdcVertical3 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnSubir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnBajar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnSeleccionar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsAsignarComponentesMaquinas1 As waProduccion_Pedidos.dsAsignarComponentesMaquinas
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMolde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
End Class
