<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros_Procedimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros_Procedimientos))
        Me.lycParametros_Procedimientos = New DevExpress.XtraLayout.LayoutControl()
        Me.spinEnfriadoUnidades = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnExportarXlsx = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAyuda = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnVistaFormato = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnFotografias = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sbdcAdvertenciasTrabajo = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.sbdcListaEmpaque = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.spinEmpaqueSTD = New DevExpress.XtraEditors.SpinEdit()
        Me.grdAdvertencias = New DevExpress.XtraGrid.GridControl()
        Me.DsParametros_Procedimientos1 = New waProduccion_Pedidos.dsParametros_Procedimientos()
        Me.grdviewAdvertencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mmeInstruccionTrabajo = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.slueCodigo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdEmpaque = New DevExpress.XtraGrid.GridControl()
        Me.grdviewEmpaque = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUEmpaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barAdvertencias = New DevExpress.XtraBars.Bar()
        Me.barbtnEliminarAdvertencias = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barbtnAgregar_ListaEmpaque = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEliminarListaEmpaque = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.DsParametros_Instrucciones1 = New waProduccion_Pedidos.dsParametros_Instrucciones()
        CType(Me.lycParametros_Procedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycParametros_Procedimientos.SuspendLayout()
        CType(Me.spinEnfriadoUnidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinEmpaqueSTD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAdvertencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Procedimientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewAdvertencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeInstruccionTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEmpaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Instrucciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycParametros_Procedimientos
        '
        Me.lycParametros_Procedimientos.Controls.Add(Me.spinEnfriadoUnidades)
        Me.lycParametros_Procedimientos.Controls.Add(Me.spinEmpaqueSTD)
        Me.lycParametros_Procedimientos.Controls.Add(Me.sbdcListaEmpaque)
        Me.lycParametros_Procedimientos.Controls.Add(Me.sbdcAdvertenciasTrabajo)
        Me.lycParametros_Procedimientos.Controls.Add(Me.grdAdvertencias)
        Me.lycParametros_Procedimientos.Controls.Add(Me.mmeInstruccionTrabajo)
        Me.lycParametros_Procedimientos.Controls.Add(Me.txtDescripcion)
        Me.lycParametros_Procedimientos.Controls.Add(Me.slueCodigo)
        Me.lycParametros_Procedimientos.Controls.Add(Me.grdEmpaque)
        Me.lycParametros_Procedimientos.Controls.Add(Me.txtDeLinea)
        Me.lycParametros_Procedimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycParametros_Procedimientos.Location = New System.Drawing.Point(0, 31)
        Me.lycParametros_Procedimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.lycParametros_Procedimientos.Name = "lycParametros_Procedimientos"
        Me.lycParametros_Procedimientos.Root = Me.LayoutControlGroup1
        Me.lycParametros_Procedimientos.Size = New System.Drawing.Size(1552, 753)
        Me.lycParametros_Procedimientos.TabIndex = 0
        Me.lycParametros_Procedimientos.Text = "LayoutControl1"
        '
        'spinEnfriadoUnidades
        '
        Me.spinEnfriadoUnidades.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinEnfriadoUnidades.Location = New System.Drawing.Point(1449, 249)
        Me.spinEnfriadoUnidades.Margin = New System.Windows.Forms.Padding(4)
        Me.spinEnfriadoUnidades.MenuManager = Me.BarManager1
        Me.spinEnfriadoUnidades.Name = "spinEnfriadoUnidades"
        Me.spinEnfriadoUnidades.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinEnfriadoUnidades.Size = New System.Drawing.Size(72, 22)
        Me.spinEnfriadoUnidades.StyleController = Me.lycParametros_Procedimientos
        Me.spinEnfriadoUnidades.TabIndex = 11
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcAdvertenciasTrabajo)
        Me.BarManager1.DockControls.Add(Me.sbdcListaEmpaque)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar, Me.barbtnExportarXlsx, Me.barbtnImprimirGrid, Me.barbtnBuscar, Me.barbtnVistaFormato, Me.barbtnFotografias, Me.barbtnAyuda})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.OptionsBar.AllowQuickCustomization = False
        Me.bar1.OptionsBar.DrawBorder = False
        Me.bar1.OptionsBar.DrawDragBorder = False
        Me.bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirGrid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExportarXlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnAyuda, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnVistaFormato, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnFotografias, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnBuscar
        '
        Me.barbtnBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnBuscar.Caption = "Buscar"
        Me.barbtnBuscar.Id = 3
        Me.barbtnBuscar.ImageOptions.Image = CType(resources.GetObject("barbtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnBuscar.Name = "barbtnBuscar"
        '
        'barbtnImprimirGrid
        '
        Me.barbtnImprimirGrid.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnImprimirGrid.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grid"
        Me.barbtnImprimirGrid.Id = 2
        Me.barbtnImprimirGrid.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirGrid.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirGrid.Name = "barbtnImprimirGrid"
        '
        'barbtnExportarXlsx
        '
        Me.barbtnExportarXlsx.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnExportarXlsx.Caption = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        Me.barbtnExportarXlsx.Id = 1
        Me.barbtnExportarXlsx.ImageOptions.Image = CType(resources.GetObject("barbtnExportarXlsx.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnExportarXlsx.Name = "barbtnExportarXlsx"
        '
        'barbtnAyuda
        '
        Me.barbtnAyuda.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnAyuda.Caption = "Ayuda"
        Me.barbtnAyuda.Id = 6
        Me.barbtnAyuda.ImageOptions.Image = CType(resources.GetObject("barbtnAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAyuda.Name = "barbtnAyuda"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnVistaFormato
        '
        Me.barbtnVistaFormato.Caption = "Vista " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Formato"
        Me.barbtnVistaFormato.Id = 4
        Me.barbtnVistaFormato.ImageOptions.Image = CType(resources.GetObject("barbtnVistaFormato.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnVistaFormato.Name = "barbtnVistaFormato"
        '
        'barbtnFotografias
        '
        Me.barbtnFotografias.Caption = "Editar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fotografias"
        Me.barbtnFotografias.Id = 5
        Me.barbtnFotografias.ImageOptions.Image = CType(resources.GetObject("barbtnFotografias.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnFotografias.Name = "barbtnFotografias"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1552, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 784)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1552, 55)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 753)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1552, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 753)
        '
        'sbdcAdvertenciasTrabajo
        '
        Me.sbdcAdvertenciasTrabajo.CausesValidation = False
        Me.sbdcAdvertenciasTrabajo.IsVertical = True
        Me.sbdcAdvertenciasTrabajo.Location = New System.Drawing.Point(31, 82)
        Me.sbdcAdvertenciasTrabajo.Manager = Me.BarManager1
        Me.sbdcAdvertenciasTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.sbdcAdvertenciasTrabajo.Name = "sbdcAdvertenciasTrabajo"
        Me.sbdcAdvertenciasTrabajo.Size = New System.Drawing.Size(43, 70)
        Me.sbdcAdvertenciasTrabajo.Text = "StandaloneBarDockControl1"
        '
        'sbdcListaEmpaque
        '
        Me.sbdcListaEmpaque.CausesValidation = False
        Me.sbdcListaEmpaque.IsVertical = True
        Me.sbdcListaEmpaque.Location = New System.Drawing.Point(31, 330)
        Me.sbdcListaEmpaque.Manager = Me.BarManager1
        Me.sbdcListaEmpaque.Margin = New System.Windows.Forms.Padding(4)
        Me.sbdcListaEmpaque.Name = "sbdcListaEmpaque"
        Me.sbdcListaEmpaque.Size = New System.Drawing.Size(43, 126)
        Me.sbdcListaEmpaque.Text = "StandaloneBarDockControl1"
        '
        'spinEmpaqueSTD
        '
        Me.spinEmpaqueSTD.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinEmpaqueSTD.Location = New System.Drawing.Point(1246, 249)
        Me.spinEmpaqueSTD.Margin = New System.Windows.Forms.Padding(4)
        Me.spinEmpaqueSTD.MenuManager = Me.BarManager1
        Me.spinEmpaqueSTD.Name = "spinEmpaqueSTD"
        Me.spinEmpaqueSTD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinEmpaqueSTD.Size = New System.Drawing.Size(72, 22)
        Me.spinEmpaqueSTD.StyleController = Me.lycParametros_Procedimientos
        Me.spinEmpaqueSTD.TabIndex = 10
        '
        'grdAdvertencias
        '
        Me.grdAdvertencias.DataMember = "dsdtAdvertencias"
        Me.grdAdvertencias.DataSource = Me.DsParametros_Procedimientos1
        Me.grdAdvertencias.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAdvertencias.Location = New System.Drawing.Point(80, 82)
        Me.grdAdvertencias.MainView = Me.grdviewAdvertencias
        Me.grdAdvertencias.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAdvertencias.MenuManager = Me.BarManager1
        Me.grdAdvertencias.Name = "grdAdvertencias"
        Me.grdAdvertencias.Size = New System.Drawing.Size(1005, 189)
        Me.grdAdvertencias.TabIndex = 9
        Me.grdAdvertencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewAdvertencias})
        '
        'DsParametros_Procedimientos1
        '
        Me.DsParametros_Procedimientos1.DataSetName = "dsParametros_Procedimientos"
        Me.DsParametros_Procedimientos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewAdvertencias
        '
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewAdvertencias.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.Preview.Options.UseFont = True
        Me.grdviewAdvertencias.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.Row.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.Row.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewAdvertencias.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewAdvertencias.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewAdvertencias.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewAdvertencias.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewAdvertencias.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewAdvertencias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colNumLinea, Me.colDescripcion})
        Me.grdviewAdvertencias.GridControl = Me.grdAdvertencias
        Me.grdviewAdvertencias.Name = "grdviewAdvertencias"
        Me.grdviewAdvertencias.OptionsCustomization.AllowSort = False
        Me.grdviewAdvertencias.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewAdvertencias.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewAdvertencias.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewAdvertencias.OptionsView.ShowFooter = True
        Me.grdviewAdvertencias.OptionsView.ShowGroupPanel = False
        Me.grdviewAdvertencias.PaintStyleName = "Web"
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Width = 71
        '
        'colNumLinea
        '
        Me.colNumLinea.Caption = "#"
        Me.colNumLinea.FieldName = "NumLinea"
        Me.colNumLinea.Name = "colNumLinea"
        Me.colNumLinea.OptionsColumn.AllowEdit = False
        Me.colNumLinea.OptionsColumn.ReadOnly = True
        Me.colNumLinea.Visible = True
        Me.colNumLinea.VisibleIndex = 0
        Me.colNumLinea.Width = 66
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 765
        '
        'mmeInstruccionTrabajo
        '
        Me.mmeInstruccionTrabajo.Location = New System.Drawing.Point(1121, 82)
        Me.mmeInstruccionTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.mmeInstruccionTrabajo.MaximumSize = New System.Drawing.Size(400, 0)
        Me.mmeInstruccionTrabajo.MenuManager = Me.BarManager1
        Me.mmeInstruccionTrabajo.MinimumSize = New System.Drawing.Size(400, 0)
        Me.mmeInstruccionTrabajo.Name = "mmeInstruccionTrabajo"
        Me.mmeInstruccionTrabajo.Size = New System.Drawing.Size(400, 161)
        Me.mmeInstruccionTrabajo.StyleController = Me.lycParametros_Procedimientos
        Me.mmeInstruccionTrabajo.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(389, 16)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MenuManager = Me.BarManager1
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDescripcion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDescripcion.Size = New System.Drawing.Size(949, 22)
        Me.txtDescripcion.StyleController = Me.lycParametros_Procedimientos
        Me.txtDescripcion.TabIndex = 6
        '
        'slueCodigo
        '
        Me.slueCodigo.Location = New System.Drawing.Point(141, 16)
        Me.slueCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.slueCodigo.MaximumSize = New System.Drawing.Size(117, 20)
        Me.slueCodigo.MenuManager = Me.BarManager1
        Me.slueCodigo.MinimumSize = New System.Drawing.Size(117, 20)
        Me.slueCodigo.Name = "slueCodigo"
        Me.slueCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCodigo.Properties.NullText = ""
        Me.slueCodigo.Properties.View = Me.SearchLookUpEdit1View
        Me.slueCodigo.Size = New System.Drawing.Size(117, 22)
        Me.slueCodigo.StyleController = Me.lycParametros_Procedimientos
        Me.slueCodigo.TabIndex = 5
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grdEmpaque
        '
        Me.grdEmpaque.DataMember = "dsdtEmpaque"
        Me.grdEmpaque.DataSource = Me.DsParametros_Procedimientos1
        Me.grdEmpaque.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmpaque.Location = New System.Drawing.Point(80, 330)
        Me.grdEmpaque.MainView = Me.grdviewEmpaque
        Me.grdEmpaque.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmpaque.Name = "grdEmpaque"
        Me.grdEmpaque.Size = New System.Drawing.Size(1441, 392)
        Me.grdEmpaque.TabIndex = 4
        Me.grdEmpaque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEmpaque})
        '
        'grdviewEmpaque
        '
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEmpaque.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEmpaque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEmpaque.Appearance.Preview.Options.UseFont = True
        Me.grdviewEmpaque.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEmpaque.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewEmpaque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEmpaque.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEmpaque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEmpaque.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEmpaque.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewEmpaque.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEmpaque.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colId_Empaque, Me.colLinea, Me.colCodigo, Me.colNombreCodigo, Me.colCantidad, Me.colUM, Me.colUEmpaque, Me.colComentarios})
        Me.grdviewEmpaque.GridControl = Me.grdEmpaque
        Me.grdviewEmpaque.GroupCount = 1
        Me.grdviewEmpaque.Name = "grdviewEmpaque"
        Me.grdviewEmpaque.OptionsCustomization.AllowSort = False
        Me.grdviewEmpaque.OptionsView.ColumnAutoWidth = False
        Me.grdviewEmpaque.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEmpaque.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEmpaque.OptionsView.ShowFooter = True
        Me.grdviewEmpaque.OptionsView.ShowGroupPanel = False
        Me.grdviewEmpaque.PaintStyleName = "Web"
        Me.grdviewEmpaque.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colId_Empaque, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colId_Empaque
        '
        Me.colId_Empaque.Caption = "Empaque"
        Me.colId_Empaque.FieldName = "Id_Empaque"
        Me.colId_Empaque.Name = "colId_Empaque"
        Me.colId_Empaque.OptionsColumn.AllowFocus = False
        Me.colId_Empaque.OptionsColumn.ReadOnly = True
        Me.colId_Empaque.OptionsColumn.TabStop = False
        Me.colId_Empaque.Visible = True
        Me.colId_Empaque.VisibleIndex = 2
        '
        'colLinea
        '
        Me.colLinea.FieldName = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.OptionsColumn.AllowEdit = False
        Me.colLinea.OptionsColumn.ReadOnly = True
        Me.colLinea.Visible = True
        Me.colLinea.VisibleIndex = 0
        Me.colLinea.Width = 74
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 100
        '
        'colNombreCodigo
        '
        Me.colNombreCodigo.FieldName = "NombreCodigo"
        Me.colNombreCodigo.Name = "colNombreCodigo"
        Me.colNombreCodigo.OptionsColumn.AllowEdit = False
        Me.colNombreCodigo.OptionsColumn.ReadOnly = True
        Me.colNombreCodigo.Visible = True
        Me.colNombreCodigo.VisibleIndex = 2
        Me.colNombreCodigo.Width = 250
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 70
        '
        'colUM
        '
        Me.colUM.Caption = "U/Medida"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.AllowEdit = False
        Me.colUM.OptionsColumn.ReadOnly = True
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 4
        Me.colUM.Width = 60
        '
        'colUEmpaque
        '
        Me.colUEmpaque.Caption = "U/Empaque"
        Me.colUEmpaque.FieldName = "UEmpaque"
        Me.colUEmpaque.Name = "colUEmpaque"
        Me.colUEmpaque.OptionsColumn.AllowEdit = False
        Me.colUEmpaque.OptionsColumn.ReadOnly = True
        Me.colUEmpaque.Visible = True
        Me.colUEmpaque.VisibleIndex = 5
        Me.colUEmpaque.Width = 70
        '
        'colComentarios
        '
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.AllowEdit = False
        Me.colComentarios.OptionsColumn.ReadOnly = True
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 6
        Me.colComentarios.Width = 401
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Enabled = False
        Me.txtDeLinea.Location = New System.Drawing.Point(1469, 16)
        Me.txtDeLinea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(67, 20)
        Me.txtDeLinea.MenuManager = Me.BarManager1
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(67, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtDeLinea.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDeLinea.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDeLinea.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDeLinea.Size = New System.Drawing.Size(67, 22)
        Me.txtDeLinea.StyleController = Me.lycParametros_Procedimientos
        Me.txtDeLinea.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1552, 753)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.slueCodigo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 28)
        Me.LayoutControlItem2.Text = "Codigo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(122, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDescripcion
        Me.LayoutControlItem3.Location = New System.Drawing.Point(248, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1080, 28)
        Me.LayoutControlItem3.Text = "Descripcion"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(122, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtDeLinea
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1328, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem4.Text = "De Linea"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(122, 16)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1090, 248)
        Me.LayoutControlGroup2.Text = "Advertencias de Trabajo"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.grdAdvertencias
        Me.LayoutControlItem6.Location = New System.Drawing.Point(49, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1011, 195)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.sbdcAdvertenciasTrabajo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(49, 76)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 76)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(49, 119)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(1090, 28)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(436, 248)
        Me.LayoutControlGroup3.Text = "Instrucciones de Trabajo"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.mmeInstruccionTrabajo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(406, 167)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.spinEmpaqueSTD
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 167)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(203, 28)
        Me.LayoutControlItem9.Text = "Equipo Personas STD"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(122, 16)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.spinEnfriadoUnidades
        Me.LayoutControlItem10.Location = New System.Drawing.Point(203, 167)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(203, 28)
        Me.LayoutControlItem10.Text = "Unidades Enfriado"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(122, 16)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem8, Me.EmptySpaceItem2})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 276)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1526, 451)
        Me.LayoutControlGroup4.Text = "Lista de Empaque"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdEmpaque
        Me.LayoutControlItem1.Location = New System.Drawing.Point(49, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1447, 398)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.sbdcListaEmpaque
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(49, 132)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 132)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(49, 266)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barAdvertencias})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnEliminarAdvertencias})
        Me.BarManager2.MaxItemId = 1
        '
        'barAdvertencias
        '
        Me.barAdvertencias.BarName = "Tools"
        Me.barAdvertencias.DockCol = 0
        Me.barAdvertencias.DockRow = 0
        Me.barAdvertencias.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barAdvertencias.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEliminarAdvertencias)})
        Me.barAdvertencias.OptionsBar.AllowQuickCustomization = False
        Me.barAdvertencias.OptionsBar.DrawBorder = False
        Me.barAdvertencias.StandaloneBarDockControl = Me.sbdcAdvertenciasTrabajo
        Me.barAdvertencias.Text = "Tools"
        '
        'barbtnEliminarAdvertencias
        '
        Me.barbtnEliminarAdvertencias.Caption = "Eliminar"
        Me.barbtnEliminarAdvertencias.Id = 0
        Me.barbtnEliminarAdvertencias.ImageOptions.Image = CType(resources.GetObject("barbtnEliminarAdvertencias.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminarAdvertencias.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminarAdvertencias.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminarAdvertencias.Name = "barbtnEliminarAdvertencias"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl1.Size = New System.Drawing.Size(1552, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 839)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl2.Size = New System.Drawing.Size(1552, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 839)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1552, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 839)
        '
        'BarManager3
        '
        Me.BarManager3.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager3.DockControls.Add(Me.BarDockControl5)
        Me.BarManager3.DockControls.Add(Me.BarDockControl6)
        Me.BarManager3.DockControls.Add(Me.BarDockControl7)
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.Form = Me
        Me.BarManager3.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAgregar_ListaEmpaque, Me.barbtnEliminarListaEmpaque, Me.barbtnEditar})
        Me.BarManager3.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAgregar_ListaEmpaque), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEliminarListaEmpaque)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.StandaloneBarDockControl = Me.sbdcListaEmpaque
        Me.Bar2.Text = "Tools"
        '
        'barbtnAgregar_ListaEmpaque
        '
        Me.barbtnAgregar_ListaEmpaque.Caption = "Agregar"
        Me.barbtnAgregar_ListaEmpaque.Id = 0
        Me.barbtnAgregar_ListaEmpaque.ImageOptions.Image = CType(resources.GetObject("barbtnAgregar_ListaEmpaque.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAgregar_ListaEmpaque.ImageOptions.LargeImage = CType(resources.GetObject("barbtnAgregar_ListaEmpaque.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnAgregar_ListaEmpaque.Name = "barbtnAgregar_ListaEmpaque"
        '
        'barbtnEditar
        '
        Me.barbtnEditar.Caption = "Editar"
        Me.barbtnEditar.Id = 2
        Me.barbtnEditar.ImageOptions.Image = CType(resources.GetObject("barbtnEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEditar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEditar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEditar.Name = "barbtnEditar"
        '
        'barbtnEliminarListaEmpaque
        '
        Me.barbtnEliminarListaEmpaque.Caption = "Eliminar"
        Me.barbtnEliminarListaEmpaque.Id = 1
        Me.barbtnEliminarListaEmpaque.ImageOptions.Image = CType(resources.GetObject("barbtnEliminarListaEmpaque.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnEliminarListaEmpaque.ImageOptions.LargeImage = CType(resources.GetObject("barbtnEliminarListaEmpaque.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnEliminarListaEmpaque.Name = "barbtnEliminarListaEmpaque"
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Me.BarManager3
        Me.BarDockControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl5.Size = New System.Drawing.Size(1552, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 839)
        Me.BarDockControl6.Manager = Me.BarManager3
        Me.BarDockControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl6.Size = New System.Drawing.Size(1552, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Me.BarManager3
        Me.BarDockControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 839)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1552, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 839)
        '
        'DsParametros_Instrucciones1
        '
        Me.DsParametros_Instrucciones1.DataSetName = "dsParametros_Instrucciones"
        Me.DsParametros_Instrucciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmParametros_Procedimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 839)
        Me.Controls.Add(Me.lycParametros_Procedimientos)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmParametros_Procedimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmParametros_Procedimientos"
        CType(Me.lycParametros_Procedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycParametros_Procedimientos.ResumeLayout(False)
        CType(Me.spinEnfriadoUnidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinEmpaqueSTD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAdvertencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Procedimientos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewAdvertencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeInstruccionTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEmpaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros_Instrucciones1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycParametros_Procedimientos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdEmpaque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewEmpaque As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slueCodigo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsParametros_Procedimientos1 As waProduccion_Pedidos.dsParametros_Procedimientos
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEmpaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents mmeInstruccionTrabajo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdAdvertencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewAdvertencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents sbdcAdvertenciasTrabajo As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents barAdvertencias As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnEliminarAdvertencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents sbdcListaEmpaque As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAgregar_ListaEmpaque As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnEliminarListaEmpaque As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barbtnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnExportarXlsx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents barbtnVistaFormato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Instrucciones1 As waProduccion_Pedidos.dsParametros_Instrucciones
    Friend WithEvents barbtnFotografias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents spinEnfriadoUnidades As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinEmpaqueSTD As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents barbtnAyuda As DevExpress.XtraBars.BarButtonItem
End Class
