<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarMoldesMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarMoldesMaquinas))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcGrdviewMoldes = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.sbdcMaquinasAsignadas = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcgrdMaquinasAsignadas = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barbtnPrioridadArriba = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnPrioridadAbajo = New DevExpress.XtraBars.BarButtonItem()
        Me.mmeComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMPreferencial = New DevExpress.XtraEditors.TextEdit()
        Me.txtCavidades = New DevExpress.XtraEditors.TextEdit()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.slueMaterial2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueMaterial1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueMaquinas = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdMoldes = New DevExpress.XtraGrid.GridControl()
        Me.DsAsigMoldes_Maquinas_Agregar1 = New waProduccion_Pedidos.dsAsigMoldes_Maquinas_Agregar()
        Me.grdviewMoldes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCavidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaquinaPreferencial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUbicacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoldeSerie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMantenimientoFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_CreacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBit_ModificacionFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdMaquinasAsignadas = New DevExpress.XtraGrid.GridControl()
        Me.grdviewMaquinasAsignadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterial2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycMaquinasNoAsignadas = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycMaterial1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycMaterial2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnSeleccionar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMPreferencial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCavidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMaterial2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMaterial1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMaquinas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsigMoldes_Maquinas_Agregar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMoldes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMaquinasNoAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMaterial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMaterial2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.sbdcGrdviewMoldes)
        Me.LayoutControl1.Controls.Add(Me.sbdcgrdMaquinasAsignadas)
        Me.LayoutControl1.Controls.Add(Me.mmeComentarios)
        Me.LayoutControl1.Controls.Add(Me.txtMPreferencial)
        Me.LayoutControl1.Controls.Add(Me.txtCavidades)
        Me.LayoutControl1.Controls.Add(Me.txtId)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.slueMaterial2)
        Me.LayoutControl1.Controls.Add(Me.slueMaterial1)
        Me.LayoutControl1.Controls.Add(Me.sbdcMaquinasAsignadas)
        Me.LayoutControl1.Controls.Add(Me.slueMaquinas)
        Me.LayoutControl1.Controls.Add(Me.grdMoldes)
        Me.LayoutControl1.Controls.Add(Me.grdMaquinasAsignadas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(768, 381, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1170, 752)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'sbdcGrdviewMoldes
        '
        Me.sbdcGrdviewMoldes.CausesValidation = False
        Me.sbdcGrdviewMoldes.IsVertical = True
        Me.sbdcGrdviewMoldes.Location = New System.Drawing.Point(664, 12)
        Me.sbdcGrdviewMoldes.Manager = Me.BarManager1
        Me.sbdcGrdviewMoldes.Name = "sbdcGrdviewMoldes"
        Me.sbdcGrdviewMoldes.Size = New System.Drawing.Size(51, 66)
        Me.sbdcGrdviewMoldes.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcMaquinasAsignadas)
        Me.BarManager1.DockControls.Add(Me.sbdcgrdMaquinasAsignadas)
        Me.BarManager1.DockControls.Add(Me.sbdcGrdviewMoldes)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar, Me.barbtnPrioridadArriba, Me.barbtnPrioridadAbajo})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcMaquinasAsignadas
        Me.Bar1.Text = "Tools"
        '
        'barbtnAgregar
        '
        Me.barbtnAgregar.Caption = "Agregar Maquina al Molde Seleccionado"
        Me.barbtnAgregar.Id = 0
        Me.barbtnAgregar.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnAgregar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnAgregar.Name = "barbtnAgregar"
        '
        'sbdcMaquinasAsignadas
        '
        Me.sbdcMaquinasAsignadas.CausesValidation = False
        Me.sbdcMaquinasAsignadas.Location = New System.Drawing.Point(719, 241)
        Me.sbdcMaquinasAsignadas.Manager = Me.BarManager1
        Me.sbdcMaquinasAsignadas.Name = "sbdcMaquinasAsignadas"
        Me.sbdcMaquinasAsignadas.Size = New System.Drawing.Size(72, 47)
        Me.sbdcMaquinasAsignadas.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1170, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 752)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1170, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 752)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1170, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 752)
        '
        'sbdcgrdMaquinasAsignadas
        '
        Me.sbdcgrdMaquinasAsignadas.CausesValidation = False
        Me.sbdcgrdMaquinasAsignadas.IsVertical = True
        Me.sbdcgrdMaquinasAsignadas.Location = New System.Drawing.Point(1123, 292)
        Me.sbdcgrdMaquinasAsignadas.Manager = Me.BarManager1
        Me.sbdcgrdMaquinasAsignadas.Name = "sbdcgrdMaquinasAsignadas"
        Me.sbdcgrdMaquinasAsignadas.Size = New System.Drawing.Size(35, 94)
        Me.sbdcgrdMaquinasAsignadas.Text = "StandaloneBarDockControl1"
        '
        'barbtnPrioridadArriba
        '
        Me.barbtnPrioridadArriba.Caption = "Subir"
        Me.barbtnPrioridadArriba.Enabled = False
        Me.barbtnPrioridadArriba.Id = 1
        Me.barbtnPrioridadArriba.ImageOptions.Image = CType(resources.GetObject("barbtnPrioridadArriba.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPrioridadArriba.ImageOptions.LargeImage = CType(resources.GetObject("barbtnPrioridadArriba.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnPrioridadArriba.Name = "barbtnPrioridadArriba"
        '
        'barbtnPrioridadAbajo
        '
        Me.barbtnPrioridadAbajo.Caption = "Bajar"
        Me.barbtnPrioridadAbajo.Enabled = False
        Me.barbtnPrioridadAbajo.Id = 2
        Me.barbtnPrioridadAbajo.ImageOptions.Image = CType(resources.GetObject("barbtnPrioridadAbajo.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnPrioridadAbajo.ImageOptions.LargeImage = CType(resources.GetObject("barbtnPrioridadAbajo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnPrioridadAbajo.Name = "barbtnPrioridadAbajo"
        '
        'mmeComentarios
        '
        Me.mmeComentarios.Enabled = False
        Me.mmeComentarios.Location = New System.Drawing.Point(835, 84)
        Me.mmeComentarios.MaximumSize = New System.Drawing.Size(0, 63)
        Me.mmeComentarios.MenuManager = Me.BarManager1
        Me.mmeComentarios.Name = "mmeComentarios"
        Me.mmeComentarios.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.mmeComentarios.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mmeComentarios.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.mmeComentarios.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.mmeComentarios.Properties.AppearanceDisabled.Options.UseFont = True
        Me.mmeComentarios.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.mmeComentarios.Size = New System.Drawing.Size(323, 63)
        Me.mmeComentarios.StyleController = Me.LayoutControl1
        Me.mmeComentarios.TabIndex = 14
        '
        'txtMPreferencial
        '
        Me.txtMPreferencial.Enabled = False
        Me.txtMPreferencial.Location = New System.Drawing.Point(1024, 60)
        Me.txtMPreferencial.MaximumSize = New System.Drawing.Size(69, 20)
        Me.txtMPreferencial.MenuManager = Me.BarManager1
        Me.txtMPreferencial.MinimumSize = New System.Drawing.Size(69, 20)
        Me.txtMPreferencial.Name = "txtMPreferencial"
        Me.txtMPreferencial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMPreferencial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMPreferencial.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtMPreferencial.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMPreferencial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtMPreferencial.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtMPreferencial.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtMPreferencial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtMPreferencial.Size = New System.Drawing.Size(69, 20)
        Me.txtMPreferencial.StyleController = Me.LayoutControl1
        Me.txtMPreferencial.TabIndex = 13
        '
        'txtCavidades
        '
        Me.txtCavidades.Enabled = False
        Me.txtCavidades.Location = New System.Drawing.Point(835, 60)
        Me.txtCavidades.MaximumSize = New System.Drawing.Size(69, 20)
        Me.txtCavidades.MenuManager = Me.BarManager1
        Me.txtCavidades.MinimumSize = New System.Drawing.Size(69, 20)
        Me.txtCavidades.Name = "txtCavidades"
        Me.txtCavidades.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCavidades.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCavidades.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCavidades.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCavidades.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCavidades.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCavidades.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCavidades.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCavidades.Size = New System.Drawing.Size(69, 20)
        Me.txtCavidades.StyleController = Me.LayoutControl1
        Me.txtCavidades.TabIndex = 12
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(835, 12)
        Me.txtId.MaximumSize = New System.Drawing.Size(69, 20)
        Me.txtId.MenuManager = Me.BarManager1
        Me.txtId.MinimumSize = New System.Drawing.Size(69, 20)
        Me.txtId.Name = "txtId"
        Me.txtId.Properties.Appearance.Options.UseTextOptions = True
        Me.txtId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtId.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtId.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtId.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtId.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtId.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtId.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtId.Size = New System.Drawing.Size(69, 20)
        Me.txtId.StyleController = Me.LayoutControl1
        Me.txtId.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(835, 36)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNombre.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombre.Size = New System.Drawing.Size(323, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 10
        '
        'slueMaterial2
        '
        Me.slueMaterial2.Location = New System.Drawing.Point(1056, 205)
        Me.slueMaterial2.MenuManager = Me.BarManager1
        Me.slueMaterial2.Name = "slueMaterial2"
        Me.slueMaterial2.Properties.Appearance.Options.UseTextOptions = True
        Me.slueMaterial2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.slueMaterial2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMaterial2.Properties.NullText = ""
        Me.slueMaterial2.Properties.View = Me.SearchLookUpEdit2View
        Me.slueMaterial2.Size = New System.Drawing.Size(90, 20)
        Me.slueMaterial2.StyleController = Me.LayoutControl1
        Me.slueMaterial2.TabIndex = 8
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'slueMaterial1
        '
        Me.slueMaterial1.Location = New System.Drawing.Point(1056, 181)
        Me.slueMaterial1.MenuManager = Me.BarManager1
        Me.slueMaterial1.Name = "slueMaterial1"
        Me.slueMaterial1.Properties.Appearance.Options.UseTextOptions = True
        Me.slueMaterial1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.slueMaterial1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMaterial1.Properties.NullText = ""
        Me.slueMaterial1.Properties.View = Me.GridView1
        Me.slueMaterial1.Size = New System.Drawing.Size(90, 20)
        Me.slueMaterial1.StyleController = Me.LayoutControl1
        Me.slueMaterial1.TabIndex = 7
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'slueMaquinas
        '
        Me.slueMaquinas.Location = New System.Drawing.Point(847, 181)
        Me.slueMaquinas.Name = "slueMaquinas"
        Me.slueMaquinas.Properties.Appearance.Options.UseTextOptions = True
        Me.slueMaquinas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.slueMaquinas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMaquinas.Properties.NullText = ""
        Me.slueMaquinas.Properties.View = Me.SearchLookUpEdit1View
        Me.slueMaquinas.Size = New System.Drawing.Size(89, 20)
        Me.slueMaquinas.StyleController = Me.LayoutControl1
        Me.slueMaquinas.TabIndex = 6
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grdMoldes
        '
        Me.grdMoldes.DataMember = "dsdtMoldes"
        Me.grdMoldes.DataSource = Me.DsAsigMoldes_Maquinas_Agregar1
        Me.grdMoldes.Location = New System.Drawing.Point(12, 12)
        Me.grdMoldes.MainView = Me.grdviewMoldes
        Me.grdMoldes.Name = "grdMoldes"
        Me.grdMoldes.Size = New System.Drawing.Size(648, 728)
        Me.grdMoldes.TabIndex = 5
        Me.grdMoldes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMoldes})
        '
        'DsAsigMoldes_Maquinas_Agregar1
        '
        Me.DsAsigMoldes_Maquinas_Agregar1.DataSetName = "dsAsigMoldes_Maquinas_Agregar"
        Me.DsAsigMoldes_Maquinas_Agregar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewMoldes
        '
        Me.grdviewMoldes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewMoldes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewMoldes.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewMoldes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewMoldes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewMoldes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewMoldes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewMoldes.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewMoldes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMoldes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewMoldes.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.Preview.Options.UseFont = True
        Me.grdviewMoldes.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewMoldes.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewMoldes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewMoldes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMoldes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewMoldes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMoldes.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMoldes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewMoldes.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMoldes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colCavidades, Me.colMaquinaPreferencial, Me.colBodega, Me.colUbicacion, Me.colUbicacionFecha, Me.colMoldeSerie, Me.colMantenimiento, Me.colMantenimientoFecha, Me.colComentarios, Me.colEstatus, Me.colBit_CreacionUsuario, Me.colBit_CreacionFecha, Me.colBit_ModificacionUsuario, Me.colBit_ModificacionFecha})
        Me.grdviewMoldes.GridControl = Me.grdMoldes
        Me.grdviewMoldes.Name = "grdviewMoldes"
        Me.grdviewMoldes.OptionsBehavior.Editable = False
        Me.grdviewMoldes.OptionsBehavior.ReadOnly = True
        Me.grdviewMoldes.OptionsFind.AlwaysVisible = True
        Me.grdviewMoldes.OptionsFind.ShowClearButton = False
        Me.grdviewMoldes.OptionsFind.ShowCloseButton = False
        Me.grdviewMoldes.OptionsView.ColumnAutoWidth = False
        Me.grdviewMoldes.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMoldes.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMoldes.OptionsView.ShowGroupPanel = False
        Me.grdviewMoldes.OptionsView.ShowViewCaption = True
        Me.grdviewMoldes.PaintStyleName = "MixedXP"
        Me.grdviewMoldes.ViewCaption = "Catalogo de Moldes"
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
        Me.colId.Caption = "Molde"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 50
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 250
        '
        'colCavidades
        '
        Me.colCavidades.AppearanceCell.Options.UseTextOptions = True
        Me.colCavidades.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidades.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCavidades.AppearanceHeader.Options.UseFont = True
        Me.colCavidades.AppearanceHeader.Options.UseTextOptions = True
        Me.colCavidades.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCavidades.FieldName = "Cavidades"
        Me.colCavidades.Name = "colCavidades"
        Me.colCavidades.Visible = True
        Me.colCavidades.VisibleIndex = 2
        Me.colCavidades.Width = 71
        '
        'colMaquinaPreferencial
        '
        Me.colMaquinaPreferencial.AppearanceCell.Options.UseTextOptions = True
        Me.colMaquinaPreferencial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquinaPreferencial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquinaPreferencial.AppearanceHeader.Options.UseFont = True
        Me.colMaquinaPreferencial.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquinaPreferencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquinaPreferencial.Caption = "M Preferencial"
        Me.colMaquinaPreferencial.FieldName = "MaquinaPreferencial"
        Me.colMaquinaPreferencial.Name = "colMaquinaPreferencial"
        Me.colMaquinaPreferencial.Visible = True
        Me.colMaquinaPreferencial.VisibleIndex = 3
        Me.colMaquinaPreferencial.Width = 90
        '
        'colBodega
        '
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        '
        'colUbicacion
        '
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        '
        'colUbicacionFecha
        '
        Me.colUbicacionFecha.FieldName = "UbicacionFecha"
        Me.colUbicacionFecha.Name = "colUbicacionFecha"
        '
        'colMoldeSerie
        '
        Me.colMoldeSerie.FieldName = "MoldeSerie"
        Me.colMoldeSerie.Name = "colMoldeSerie"
        '
        'colMantenimiento
        '
        Me.colMantenimiento.FieldName = "Mantenimiento"
        Me.colMantenimiento.Name = "colMantenimiento"
        '
        'colMantenimientoFecha
        '
        Me.colMantenimientoFecha.FieldName = "MantenimientoFecha"
        Me.colMantenimientoFecha.Name = "colMantenimientoFecha"
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 4
        Me.colComentarios.Width = 200
        '
        'colEstatus
        '
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 5
        Me.colEstatus.Width = 50
        '
        'colBit_CreacionUsuario
        '
        Me.colBit_CreacionUsuario.FieldName = "Bit_CreacionUsuario"
        Me.colBit_CreacionUsuario.Name = "colBit_CreacionUsuario"
        '
        'colBit_CreacionFecha
        '
        Me.colBit_CreacionFecha.FieldName = "Bit_CreacionFecha"
        Me.colBit_CreacionFecha.Name = "colBit_CreacionFecha"
        '
        'colBit_ModificacionUsuario
        '
        Me.colBit_ModificacionUsuario.FieldName = "Bit_ModificacionUsuario"
        Me.colBit_ModificacionUsuario.Name = "colBit_ModificacionUsuario"
        '
        'colBit_ModificacionFecha
        '
        Me.colBit_ModificacionFecha.FieldName = "Bit_ModificacionFecha"
        Me.colBit_ModificacionFecha.Name = "colBit_ModificacionFecha"
        '
        'grdMaquinasAsignadas
        '
        Me.grdMaquinasAsignadas.DataMember = "dsdtMaquinasAsignadas"
        Me.grdMaquinasAsignadas.DataSource = Me.DsAsigMoldes_Maquinas_Agregar1
        Me.grdMaquinasAsignadas.Location = New System.Drawing.Point(719, 292)
        Me.grdMaquinasAsignadas.MainView = Me.grdviewMaquinasAsignadas
        Me.grdMaquinasAsignadas.MaximumSize = New System.Drawing.Size(400, 0)
        Me.grdMaquinasAsignadas.MinimumSize = New System.Drawing.Size(400, 400)
        Me.grdMaquinasAsignadas.Name = "grdMaquinasAsignadas"
        Me.grdMaquinasAsignadas.Size = New System.Drawing.Size(400, 400)
        Me.grdMaquinasAsignadas.TabIndex = 4
        Me.grdMaquinasAsignadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinasAsignadas})
        '
        'grdviewMaquinasAsignadas
        '
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewMaquinasAsignadas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.grdviewMaquinasAsignadas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewMaquinasAsignadas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.grdviewMaquinasAsignadas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.GroupRow.Options.UseFont = True
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.grdviewMaquinasAsignadas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewMaquinasAsignadas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.grdviewMaquinasAsignadas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.grdviewMaquinasAsignadas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.Preview.Options.UseFont = True
        Me.grdviewMaquinasAsignadas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinasAsignadas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grdviewMaquinasAsignadas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.grdviewMaquinasAsignadas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinasAsignadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaquina, Me.colMaterial1, Me.colMaterial2, Me.colEstatus1})
        Me.grdviewMaquinasAsignadas.GridControl = Me.grdMaquinasAsignadas
        Me.grdviewMaquinasAsignadas.Name = "grdviewMaquinasAsignadas"
        Me.grdviewMaquinasAsignadas.OptionsBehavior.Editable = False
        Me.grdviewMaquinasAsignadas.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinasAsignadas.OptionsFilter.AllowFilterEditor = False
        Me.grdviewMaquinasAsignadas.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.grdviewMaquinasAsignadas.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.grdviewMaquinasAsignadas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinasAsignadas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinasAsignadas.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinasAsignadas.OptionsView.ShowViewCaption = True
        Me.grdviewMaquinasAsignadas.PaintStyleName = "MixedXP"
        Me.grdviewMaquinasAsignadas.ViewCaption = "Maquinas Asignadas"
        '
        'colMaquina
        '
        Me.colMaquina.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquina.AppearanceCell.Options.UseFont = True
        Me.colMaquina.AppearanceCell.Options.UseTextOptions = True
        Me.colMaquina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaquina.AppearanceHeader.Options.UseFont = True
        Me.colMaquina.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaquina.FieldName = "Maquina"
        Me.colMaquina.Name = "colMaquina"
        Me.colMaquina.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaquina.OptionsFilter.AllowAutoFilter = False
        Me.colMaquina.OptionsFilter.AllowFilter = False
        Me.colMaquina.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaquina.Visible = True
        Me.colMaquina.VisibleIndex = 0
        Me.colMaquina.Width = 70
        '
        'colMaterial1
        '
        Me.colMaterial1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial1.AppearanceHeader.Options.UseFont = True
        Me.colMaterial1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial1.FieldName = "Material1"
        Me.colMaterial1.Name = "colMaterial1"
        Me.colMaterial1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaterial1.OptionsFilter.AllowAutoFilter = False
        Me.colMaterial1.OptionsFilter.AllowFilter = False
        Me.colMaterial1.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaterial1.Width = 100
        '
        'colMaterial2
        '
        Me.colMaterial2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMaterial2.AppearanceHeader.Options.UseFont = True
        Me.colMaterial2.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterial2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterial2.FieldName = "Material2"
        Me.colMaterial2.Name = "colMaterial2"
        Me.colMaterial2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaterial2.OptionsFilter.AllowAutoFilter = False
        Me.colMaterial2.OptionsFilter.AllowFilter = False
        Me.colMaterial2.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMaterial2.Width = 100
        '
        'colEstatus1
        '
        Me.colEstatus1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEstatus1.AppearanceHeader.Options.UseFont = True
        Me.colEstatus1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus1.FieldName = "Estatus"
        Me.colEstatus1.Name = "colEstatus1"
        Me.colEstatus1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEstatus1.OptionsFilter.AllowAutoFilter = False
        Me.colEstatus1.OptionsFilter.AllowFilter = False
        Me.colEstatus1.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEstatus1.Visible = True
        Me.colEstatus1.VisibleIndex = 1
        Me.colEstatus1.Width = 59
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.SimpleSeparator1, Me.SplitterItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlGroup2, Me.LayoutControlItem10})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1170, 752)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.grdMoldes
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(652, 732)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(707, 684)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(2, 48)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(709, 684)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(441, 48)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtNombre
        Me.LayoutControlItem3.CustomizationFormText = "Nombre"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(707, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem3.Text = "Nombre"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtId
        Me.LayoutControlItem5.CustomizationFormText = "Id"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(707, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem5.Text = "Id"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.mmeComentarios
        Me.LayoutControlItem8.CustomizationFormText = "Comentarios"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(707, 72)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(443, 67)
        Me.LayoutControlItem8.Text = "Comentarios"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdMaquinasAsignadas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(707, 280)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(404, 404)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(896, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(254, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtCavidades
        Me.LayoutControlItem6.CustomizationFormText = "Cavidades"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(707, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem6.Text = "Cavidades"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtMPreferencial
        Me.LayoutControlItem7.CustomizationFormText = "Maq. Preferencial"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(896, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem7.Text = "Maq. Preferencial"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(1085, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(65, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.sbdcgrdMaquinasAsignadas
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(1111, 280)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(39, 404)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.sbdcMaquinasAsignadas
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(707, 229)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(443, 51)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup2.CustomizationFormText = "Asignar nuevas maquinas a molde"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycMaquinasNoAsignadas, Me.lycMaterial1, Me.lycMaterial2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(707, 139)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(443, 90)
        Me.LayoutControlGroup2.Text = "Asignar nuevas maquinas a molde"
        '
        'lycMaquinasNoAsignadas
        '
        Me.lycMaquinasNoAsignadas.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycMaquinasNoAsignadas.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycMaquinasNoAsignadas.Control = Me.slueMaquinas
        Me.lycMaquinasNoAsignadas.CustomizationFormText = "Maquinas No Asignadas"
        Me.lycMaquinasNoAsignadas.Location = New System.Drawing.Point(0, 0)
        Me.lycMaquinasNoAsignadas.Name = "lycMaquinasNoAsignadas"
        Me.lycMaquinasNoAsignadas.Size = New System.Drawing.Size(209, 48)
        Me.lycMaquinasNoAsignadas.Text = "Maquinas No Asignadas"
        Me.lycMaquinasNoAsignadas.TextSize = New System.Drawing.Size(113, 13)
        '
        'lycMaterial1
        '
        Me.lycMaterial1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycMaterial1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycMaterial1.Control = Me.slueMaterial1
        Me.lycMaterial1.CustomizationFormText = "Material1"
        Me.lycMaterial1.Location = New System.Drawing.Point(209, 0)
        Me.lycMaterial1.Name = "lycMaterial1"
        Me.lycMaterial1.Size = New System.Drawing.Size(210, 24)
        Me.lycMaterial1.Text = "Material1"
        Me.lycMaterial1.TextSize = New System.Drawing.Size(113, 13)
        Me.lycMaterial1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lycMaterial2
        '
        Me.lycMaterial2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycMaterial2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycMaterial2.Control = Me.slueMaterial2
        Me.lycMaterial2.CustomizationFormText = "Material2"
        Me.lycMaterial2.Location = New System.Drawing.Point(209, 24)
        Me.lycMaterial2.Name = "lycMaterial2"
        Me.lycMaterial2.Size = New System.Drawing.Size(210, 24)
        Me.lycMaterial2.Text = "Material2"
        Me.lycMaterial2.TextSize = New System.Drawing.Size(113, 13)
        Me.lycMaterial2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.sbdcGrdviewMoldes
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(652, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(55, 732)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEliminar})
        Me.BarManager2.MaxItemId = 1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnPrioridadArriba), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnPrioridadAbajo)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcgrdMaquinasAsignadas
        Me.Bar2.Text = "Tools"
        '
        'barbtnEliminar
        '
        Me.barbtnEliminar.Caption = "Eliminar Relacion de Maquina"
        Me.barbtnEliminar.Id = 0
        Me.barbtnEliminar.ImageOptions.Image = CType(resources.GetObject("barbtnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminar.Name = "barbtnEliminar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1170, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 752)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1170, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 752)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1170, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 752)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSeleccionar})
        Me.BarManager3.MaxItemId = 2
        '
        'Bar3
        '
        Me.Bar3.BarName = "Tools"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSeleccionar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DisableCustomization = True
        Me.Bar3.OptionsBar.DrawBorder = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.StandaloneBarDockControl = Me.sbdcGrdviewMoldes
        Me.Bar3.Text = "Tools"
        '
        'barbtnSeleccionar
        '
        Me.barbtnSeleccionar.Caption = "Seleccionar Molde"
        Me.barbtnSeleccionar.Id = 0
        Me.barbtnSeleccionar.ImageOptions.Image = CType(resources.GetObject("barbtnSeleccionar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnSeleccionar.Name = "barbtnSeleccionar"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Size = New System.Drawing.Size(1170, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 752)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Size = New System.Drawing.Size(1170, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 752)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1170, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 752)
        '
        'frmAsignarMoldesMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 752)
        Me.Controls.Add(Me.LayoutControl1)
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
        Me.Name = "frmAsignarMoldesMaquinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAsigMoldes_Maquinas_Agregar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMPreferencial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCavidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMaterial2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMaterial1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMaquinas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsigMoldes_Maquinas_Agregar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMoldes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewMaquinasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMaquinasNoAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMaterial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMaterial2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents sbdcMaquinasAsignadas As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents slueMaquinas As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdMoldes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMoldes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdMaquinasAsignadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinasAsignadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents lycMaquinasNoAsignadas As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsAsigMoldes_Maquinas_Agregar1 As waProduccion_Pedidos.dsAsigMoldes_Maquinas_Agregar
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCavidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquinaPreferencial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUbicacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoldeSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMantenimientoFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_CreacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBit_ModificacionFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents slueMaterial2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueMaterial1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lycMaterial1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycMaterial2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents mmeComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtMPreferencial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCavidades As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents sbdcgrdMaquinasAsignadas As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents sbdcGrdviewMoldes As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnSeleccionar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnPrioridadArriba As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnPrioridadAbajo As DevExpress.XtraBars.BarButtonItem
End Class
