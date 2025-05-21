<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenImpresion))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdImpresionOrdenesDisponibles = New DevExpress.XtraGrid.GridControl()
        Me.DsImpresionOrden1 = New waProduccion_Pedidos.dsImpresionOrden()
        Me.grdviewImpresionOrdenesDisponibles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdteFecha = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnImprimirSeleccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirListado = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdImpresionOrdenesDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsImpresionOrden1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewImpresionOrdenesDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdteFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdImpresionOrdenesDisponibles)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(994, 537)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdImpresionOrdenesDisponibles
        '
        Me.grdImpresionOrdenesDisponibles.DataMember = "dsdtImpresionOrdenesDisponibles"
        Me.grdImpresionOrdenesDisponibles.DataSource = Me.DsImpresionOrden1
        Me.grdImpresionOrdenesDisponibles.Location = New System.Drawing.Point(12, 12)
        Me.grdImpresionOrdenesDisponibles.MainView = Me.grdviewImpresionOrdenesDisponibles
        Me.grdImpresionOrdenesDisponibles.Name = "grdImpresionOrdenesDisponibles"
        Me.grdImpresionOrdenesDisponibles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rdteFecha})
        Me.grdImpresionOrdenesDisponibles.Size = New System.Drawing.Size(970, 513)
        Me.grdImpresionOrdenesDisponibles.TabIndex = 4
        Me.grdImpresionOrdenesDisponibles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewImpresionOrdenesDisponibles})
        '
        'DsImpresionOrden1
        '
        Me.DsImpresionOrden1.DataSetName = "dsImpresionOrden"
        Me.DsImpresionOrden1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewImpresionOrdenesDisponibles
        '
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.Options.UseFont = True
        Me.grdviewImpresionOrdenesDisponibles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewImpresionOrdenesDisponibles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colId, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colUsuario})
        Me.grdviewImpresionOrdenesDisponibles.GridControl = Me.grdImpresionOrdenesDisponibles
        Me.grdviewImpresionOrdenesDisponibles.Name = "grdviewImpresionOrdenesDisponibles"
        Me.grdviewImpresionOrdenesDisponibles.OptionsBehavior.ReadOnly = True
        Me.grdviewImpresionOrdenesDisponibles.OptionsSelection.MultiSelect = True
        Me.grdviewImpresionOrdenesDisponibles.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewImpresionOrdenesDisponibles.OptionsView.ShowGroupPanel = False
        '
        'colFecha
        '
        Me.colFecha.AppearanceCell.Options.UseTextOptions = True
        Me.colFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.ColumnEdit = Me.rdteFecha
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 113
        '
        'rdteFecha
        '
        Me.rdteFecha.AllowFocused = False
        Me.rdteFecha.AutoHeight = False
        Me.rdteFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.rdteFecha.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFecha.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[False]
        Me.rdteFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdteFecha.Name = "rdteFecha"
        '
        'colId
        '
        Me.colId.AppearanceCell.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.colId.AppearanceCell.Options.UseBackColor = True
        Me.colId.AppearanceCell.Options.UseTextOptions = True
        Me.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 2
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
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 3
        Me.colCodigoArticulo.Width = 117
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 4
        Me.colNombreArticulo.Width = 416
        '
        'colUsuario
        '
        Me.colUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUsuario.AppearanceHeader.Options.UseFont = True
        Me.colUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.OptionsColumn.AllowEdit = False
        Me.colUsuario.OptionsColumn.ReadOnly = True
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 5
        Me.colUsuario.Width = 78
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(994, 537)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdImpresionOrdenesDisponibles
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(974, 517)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnImprimirSeleccion, Me.barbtnImprimirListado})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirSeleccion), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnImprimirListado)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.Text = "Tools"
        '
        'barbtnImprimirSeleccion
        '
        Me.barbtnImprimirSeleccion.Caption = "Imprimir Seleccion"
        Me.barbtnImprimirSeleccion.Glyph = CType(resources.GetObject("barbtnImprimirSeleccion.Glyph"), System.Drawing.Image)
        Me.barbtnImprimirSeleccion.Id = 0
        Me.barbtnImprimirSeleccion.LargeGlyph = CType(resources.GetObject("barbtnImprimirSeleccion.LargeGlyph"), System.Drawing.Image)
        Me.barbtnImprimirSeleccion.Name = "barbtnImprimirSeleccion"
        ToolTipTitleItem1.Text = "Imprimir Seleccion"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Imprime la Orden Seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Puede imprimir tambien haciendo doble click sobre la orden."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.barbtnImprimirSeleccion.SuperTip = SuperToolTip1
        '
        'barbtnImprimirListado
        '
        Me.barbtnImprimirListado.Caption = "Imprimir Listado"
        Me.barbtnImprimirListado.Glyph = CType(resources.GetObject("barbtnImprimirListado.Glyph"), System.Drawing.Image)
        Me.barbtnImprimirListado.Id = 1
        Me.barbtnImprimirListado.Name = "barbtnImprimirListado"
        ToolTipTitleItem3.Text = "Imprimir Listado"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Imprime todas las ordenes Visibles."
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.barbtnImprimirListado.SuperTip = SuperToolTip2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(994, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 584)
        Me.barDockControlBottom.Size = New System.Drawing.Size(994, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 537)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(994, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 537)
        '
        'frmOrdenImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 584)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes Disponibles para Impresion"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdImpresionOrdenesDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsImpresionOrden1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewImpresionOrdenesDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdteFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdImpresionOrdenesDisponibles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewImpresionOrdenesDisponibles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsImpresionOrden1 As waProduccion_Pedidos.dsImpresionOrden
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents rdteFecha As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barbtnImprimirSeleccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnImprimirListado As DevExpress.XtraBars.BarButtonItem
End Class
