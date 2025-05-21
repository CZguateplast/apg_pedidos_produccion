<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlProduccion_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlProduccion_Detalle))
        Me.nbarDetalle = New DevExpress.XtraNavBar.NavBarControl()
        Me.nbgProducciones = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dteTrabajoInicio = New DevExpress.XtraEditors.DateEdit()
        Me.slueTurno = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dteFechaTurno = New DevExpress.XtraEditors.DateEdit()
        Me.dteTrabajoFinal = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Maquina = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaquina = New DevExpress.XtraEditors.TextEdit()
        Me.nbgParametrosMaquina = New DevExpress.XtraNavBar.NavBarGroup()
        Me.lycControlProduccionDetalle = New DevExpress.XtraLayout.LayoutControl()
        Me.sbdcControlProduccionDetalle = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnAceptar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.mmeComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.spinPendientes = New DevExpress.XtraEditors.SpinEdit()
        Me.TimeTotal = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.timeInicial = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.timeFinal = New DevExpress.XtraEditors.TimeSpanEdit()
        Me.spinEnsambles = New DevExpress.XtraEditors.SpinEdit()
        Me.spinTotal = New DevExpress.XtraEditors.SpinEdit()
        Me.spinMalas = New DevExpress.XtraEditors.SpinEdit()
        Me.spinBuenas = New DevExpress.XtraEditors.SpinEdit()
        Me.grdEnsambles = New DevExpress.XtraGrid.GridControl()
        Me.DsControlProduccionDetalle = New waProduccion_Pedidos.dsControlProduccionDetalle()
        Me.grdviewEnsambles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdProducciones = New DevExpress.XtraGrid.GridControl()
        Me.lyviewProducciones = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colTipo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colTipo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDestino = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDestino = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colNumeroSAP = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colNumeroSAP = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCodigoArticulo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rmmeNombre = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_colNombreArticulo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPlaneado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCompletado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPendiente = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colProducidos = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colProducidos = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rmmeDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_colComentarios = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.DsControlProduccionDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.nbarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nbarDetalle.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.dteTrabajoInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTrabajoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaTurno.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTrabajoFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTrabajoFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycControlProduccionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycControlProduccionDetalle.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinEnsambles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMalas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinBuenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlProduccionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyviewProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colNumeroSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colNombreArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPlaneado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCompletado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colProducidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmmeDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlProduccionDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nbarDetalle
        '
        Me.nbarDetalle.ActiveGroup = Me.nbgProducciones
        Me.nbarDetalle.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.nbarDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.nbarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbarDetalle.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nbgProducciones, Me.nbgParametrosMaquina})
        Me.nbarDetalle.Location = New System.Drawing.Point(0, 0)
        Me.nbarDetalle.Name = "nbarDetalle"
        Me.nbarDetalle.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.nbarDetalle.OptionsNavPane.ExpandedWidth = 250
        Me.nbarDetalle.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Me.nbarDetalle.ShowIcons = DevExpress.Utils.DefaultBoolean.[True]
        Me.nbarDetalle.Size = New System.Drawing.Size(250, 704)
        Me.nbarDetalle.TabIndex = 0
        Me.nbarDetalle.Text = "NavBarControl1"
        Me.nbarDetalle.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2016 Black")
        '
        'nbgProducciones
        '
        Me.nbgProducciones.Caption = "Producciones"
        Me.nbgProducciones.Expanded = True
        Me.nbgProducciones.LargeImage = CType(resources.GetObject("nbgProducciones.LargeImage"), System.Drawing.Image)
        Me.nbgProducciones.Name = "nbgProducciones"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer1.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl2)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl4)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl1)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.dteTrabajoInicio)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.slueTurno)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.dteFechaTurno)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.dteTrabajoFinal)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl3)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.Maquina)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtMaquina)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(249, 511)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(41, 126)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Fecha Final:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(59, 242)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Turno de:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(30, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 19)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Fecha Inicial:"
        '
        'dteTrabajoInicio
        '
        Me.dteTrabajoInicio.EditValue = Nothing
        Me.dteTrabajoInicio.Location = New System.Drawing.Point(144, 90)
        Me.dteTrabajoInicio.Name = "dteTrabajoInicio"
        Me.dteTrabajoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTrabajoInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTrabajoInicio.Size = New System.Drawing.Size(83, 20)
        Me.dteTrabajoInicio.TabIndex = 3
        '
        'slueTurno
        '
        Me.slueTurno.Location = New System.Drawing.Point(144, 241)
        Me.slueTurno.Name = "slueTurno"
        Me.slueTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueTurno.Properties.NullText = ""
        Me.slueTurno.Properties.View = Me.SearchLookUpEdit1View
        Me.slueTurno.Size = New System.Drawing.Size(83, 20)
        Me.slueTurno.TabIndex = 6
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'dteFechaTurno
        '
        Me.dteFechaTurno.EditValue = Nothing
        Me.dteFechaTurno.Location = New System.Drawing.Point(144, 208)
        Me.dteFechaTurno.Name = "dteFechaTurno"
        Me.dteFechaTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaTurno.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaTurno.Size = New System.Drawing.Size(83, 20)
        Me.dteFechaTurno.TabIndex = 0
        '
        'dteTrabajoFinal
        '
        Me.dteTrabajoFinal.EditValue = Nothing
        Me.dteTrabajoFinal.Location = New System.Drawing.Point(144, 125)
        Me.dteTrabajoFinal.Name = "dteTrabajoFinal"
        Me.dteTrabajoFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTrabajoFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTrabajoFinal.Size = New System.Drawing.Size(83, 20)
        Me.dteTrabajoFinal.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(32, 209)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(106, 19)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Fecha Turno:"
        '
        'Maquina
        '
        Me.Maquina.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Maquina.Appearance.Options.UseFont = True
        Me.Maquina.Location = New System.Drawing.Point(63, 23)
        Me.Maquina.Name = "Maquina"
        Me.Maquina.Size = New System.Drawing.Size(75, 19)
        Me.Maquina.TabIndex = 1
        Me.Maquina.Text = "Maquina:"
        '
        'txtMaquina
        '
        Me.txtMaquina.Enabled = False
        Me.txtMaquina.Location = New System.Drawing.Point(144, 15)
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtMaquina.Properties.Appearance.Options.UseFont = True
        Me.txtMaquina.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaquina.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaquina.Size = New System.Drawing.Size(83, 32)
        Me.txtMaquina.TabIndex = 0
        '
        'nbgParametrosMaquina
        '
        Me.nbgParametrosMaquina.Caption = "Parametros de Maquina"
        Me.nbgParametrosMaquina.ControlContainer = Me.NavBarGroupControlContainer1
        Me.nbgParametrosMaquina.GroupClientHeight = 453
        Me.nbgParametrosMaquina.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.nbgParametrosMaquina.LargeImage = Global.waProduccion_Pedidos.My.Resources.Resources.Maquinas
        Me.nbgParametrosMaquina.Name = "nbgParametrosMaquina"
        '
        'lycControlProduccionDetalle
        '
        Me.lycControlProduccionDetalle.Controls.Add(Me.sbdcControlProduccionDetalle)
        Me.lycControlProduccionDetalle.Controls.Add(Me.mmeComentarios)
        Me.lycControlProduccionDetalle.Controls.Add(Me.spinPendientes)
        Me.lycControlProduccionDetalle.Controls.Add(Me.TimeTotal)
        Me.lycControlProduccionDetalle.Controls.Add(Me.timeInicial)
        Me.lycControlProduccionDetalle.Controls.Add(Me.timeFinal)
        Me.lycControlProduccionDetalle.Controls.Add(Me.spinEnsambles)
        Me.lycControlProduccionDetalle.Controls.Add(Me.spinTotal)
        Me.lycControlProduccionDetalle.Controls.Add(Me.spinMalas)
        Me.lycControlProduccionDetalle.Controls.Add(Me.spinBuenas)
        Me.lycControlProduccionDetalle.Controls.Add(Me.grdEnsambles)
        Me.lycControlProduccionDetalle.Controls.Add(Me.grdProducciones)
        Me.lycControlProduccionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycControlProduccionDetalle.Location = New System.Drawing.Point(250, 0)
        Me.lycControlProduccionDetalle.Name = "lycControlProduccionDetalle"
        Me.lycControlProduccionDetalle.Root = Me.LayoutControlGroup3
        Me.lycControlProduccionDetalle.Size = New System.Drawing.Size(966, 704)
        Me.lycControlProduccionDetalle.TabIndex = 1
        Me.lycControlProduccionDetalle.Text = "LayoutControl2"
        '
        'sbdcControlProduccionDetalle
        '
        Me.sbdcControlProduccionDetalle.CausesValidation = False
        Me.sbdcControlProduccionDetalle.IsVertical = True
        Me.sbdcControlProduccionDetalle.Location = New System.Drawing.Point(903, 626)
        Me.sbdcControlProduccionDetalle.Manager = Me.BarManager1
        Me.sbdcControlProduccionDetalle.Name = "sbdcControlProduccionDetalle"
        Me.sbdcControlProduccionDetalle.Size = New System.Drawing.Size(51, 66)
        Me.sbdcControlProduccionDetalle.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.sbdcControlProduccionDetalle)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnAceptar})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAceptar)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.sbdcControlProduccionDetalle
        Me.Bar1.Text = "Tools"
        '
        'barbtnAceptar
        '
        Me.barbtnAceptar.Caption = "Aceptar"
        Me.barbtnAceptar.Id = 0
        Me.barbtnAceptar.ImageOptions.Image = CType(resources.GetObject("barbtnAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnAceptar.Name = "barbtnAceptar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1216, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 704)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1216, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 704)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1216, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 704)
        '
        'mmeComentarios
        '
        Me.mmeComentarios.Location = New System.Drawing.Point(540, 566)
        Me.mmeComentarios.Name = "mmeComentarios"
        Me.mmeComentarios.Size = New System.Drawing.Size(359, 126)
        Me.mmeComentarios.StyleController = Me.lycControlProduccionDetalle
        Me.mmeComentarios.TabIndex = 18
        '
        'spinPendientes
        '
        Me.spinPendientes.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinPendientes.Enabled = False
        Me.spinPendientes.Location = New System.Drawing.Point(104, 658)
        Me.spinPendientes.Name = "spinPendientes"
        Me.spinPendientes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.spinPendientes.Properties.Appearance.Options.UseFont = True
        Me.spinPendientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinPendientes.Properties.ReadOnly = True
        Me.spinPendientes.Size = New System.Drawing.Size(75, 22)
        Me.spinPendientes.StyleController = Me.lycControlProduccionDetalle
        Me.spinPendientes.TabIndex = 17
        '
        'TimeTotal
        '
        Me.TimeTotal.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.TimeTotal.Enabled = False
        Me.TimeTotal.Location = New System.Drawing.Point(470, 634)
        Me.TimeTotal.Name = "TimeTotal"
        Me.TimeTotal.Properties.AllowEditDays = False
        Me.TimeTotal.Properties.AllowEditSeconds = False
        Me.TimeTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeTotal.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.TimeTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TimeTotal.Properties.EditFormat.FormatString = "HH:mm"
        Me.TimeTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TimeTotal.Properties.Mask.EditMask = "HH:mm"
        Me.TimeTotal.Properties.ReadOnly = True
        Me.TimeTotal.Size = New System.Drawing.Size(54, 20)
        Me.TimeTotal.StyleController = Me.lycControlProduccionDetalle
        Me.TimeTotal.TabIndex = 16
        '
        'timeInicial
        '
        Me.timeInicial.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.timeInicial.Location = New System.Drawing.Point(470, 586)
        Me.timeInicial.Name = "timeInicial"
        Me.timeInicial.Properties.AllowEditDays = False
        Me.timeInicial.Properties.AllowEditSeconds = False
        Me.timeInicial.Properties.Appearance.Options.UseTextOptions = True
        Me.timeInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.timeInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeInicial.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.timeInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.timeInicial.Properties.EditFormat.FormatString = "HH:mm"
        Me.timeInicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.timeInicial.Properties.Mask.EditMask = "HH:mm"
        Me.timeInicial.Properties.MaxDays = 0
        Me.timeInicial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.timeInicial.Size = New System.Drawing.Size(54, 20)
        Me.timeInicial.StyleController = Me.lycControlProduccionDetalle
        Me.timeInicial.TabIndex = 15
        '
        'timeFinal
        '
        Me.timeFinal.EditValue = System.TimeSpan.Parse("00:00:00")
        Me.timeFinal.Location = New System.Drawing.Point(470, 610)
        Me.timeFinal.Name = "timeFinal"
        Me.timeFinal.Properties.AllowEditDays = False
        Me.timeFinal.Properties.AllowEditSeconds = False
        Me.timeFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.timeFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.timeFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timeFinal.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.timeFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.timeFinal.Properties.EditFormat.FormatString = "HH:mm"
        Me.timeFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.timeFinal.Properties.Mask.EditMask = "HH:mm"
        Me.timeFinal.Properties.MaxDays = 0
        Me.timeFinal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.timeFinal.Size = New System.Drawing.Size(54, 20)
        Me.timeFinal.StyleController = Me.lycControlProduccionDetalle
        Me.timeFinal.TabIndex = 14
        '
        'spinEnsambles
        '
        Me.spinEnsambles.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinEnsambles.Enabled = False
        Me.spinEnsambles.Location = New System.Drawing.Point(287, 586)
        Me.spinEnsambles.MaximumSize = New System.Drawing.Size(75, 20)
        Me.spinEnsambles.MinimumSize = New System.Drawing.Size(75, 20)
        Me.spinEnsambles.Name = "spinEnsambles"
        Me.spinEnsambles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinEnsambles.Properties.Mask.EditMask = "n0"
        Me.spinEnsambles.Properties.ReadOnly = True
        Me.spinEnsambles.Size = New System.Drawing.Size(75, 20)
        Me.spinEnsambles.StyleController = Me.lycControlProduccionDetalle
        Me.spinEnsambles.TabIndex = 12
        '
        'spinTotal
        '
        Me.spinTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinTotal.Enabled = False
        Me.spinTotal.Location = New System.Drawing.Point(104, 634)
        Me.spinTotal.MaximumSize = New System.Drawing.Size(75, 20)
        Me.spinTotal.MinimumSize = New System.Drawing.Size(75, 20)
        Me.spinTotal.Name = "spinTotal"
        Me.spinTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.spinTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.spinTotal.Properties.Appearance.Options.UseFont = True
        Me.spinTotal.Properties.Appearance.Options.UseForeColor = True
        Me.spinTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinTotal.Properties.Mask.EditMask = "n0"
        Me.spinTotal.Properties.ReadOnly = True
        Me.spinTotal.Size = New System.Drawing.Size(75, 20)
        Me.spinTotal.StyleController = Me.lycControlProduccionDetalle
        Me.spinTotal.TabIndex = 8
        '
        'spinMalas
        '
        Me.spinMalas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMalas.Location = New System.Drawing.Point(104, 610)
        Me.spinMalas.MaximumSize = New System.Drawing.Size(75, 20)
        Me.spinMalas.MinimumSize = New System.Drawing.Size(75, 20)
        Me.spinMalas.Name = "spinMalas"
        Me.spinMalas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.spinMalas.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.spinMalas.Properties.Appearance.Options.UseFont = True
        Me.spinMalas.Properties.Appearance.Options.UseForeColor = True
        Me.spinMalas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMalas.Properties.Mask.EditMask = "n0"
        Me.spinMalas.Size = New System.Drawing.Size(75, 20)
        Me.spinMalas.StyleController = Me.lycControlProduccionDetalle
        Me.spinMalas.TabIndex = 7
        '
        'spinBuenas
        '
        Me.spinBuenas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinBuenas.Enabled = False
        Me.spinBuenas.Location = New System.Drawing.Point(104, 586)
        Me.spinBuenas.MaximumSize = New System.Drawing.Size(75, 20)
        Me.spinBuenas.MinimumSize = New System.Drawing.Size(75, 20)
        Me.spinBuenas.Name = "spinBuenas"
        Me.spinBuenas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.spinBuenas.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.spinBuenas.Properties.Appearance.Options.UseFont = True
        Me.spinBuenas.Properties.Appearance.Options.UseForeColor = True
        Me.spinBuenas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinBuenas.Properties.Mask.EditMask = "n0"
        Me.spinBuenas.Properties.ReadOnly = True
        Me.spinBuenas.Size = New System.Drawing.Size(75, 20)
        Me.spinBuenas.StyleController = Me.lycControlProduccionDetalle
        Me.spinBuenas.TabIndex = 6
        '
        'grdEnsambles
        '
        Me.grdEnsambles.DataMember = "dsdtEnsambles"
        Me.grdEnsambles.DataSource = Me.DsControlProduccionDetalle
        Me.grdEnsambles.Location = New System.Drawing.Point(12, 369)
        Me.grdEnsambles.MainView = Me.grdviewEnsambles
        Me.grdEnsambles.Name = "grdEnsambles"
        Me.grdEnsambles.Size = New System.Drawing.Size(942, 177)
        Me.grdEnsambles.TabIndex = 5
        Me.grdEnsambles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewEnsambles})
        '
        'DsControlProduccionDetalle
        '
        Me.DsControlProduccionDetalle.DataSetName = "dsControlProduccionDetalle"
        Me.DsControlProduccionDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewEnsambles
        '
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewEnsambles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.grdviewEnsambles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewEnsambles.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewEnsambles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Preview.Options.UseFont = True
        Me.grdviewEnsambles.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.Row.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewEnsambles.Appearance.Row.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grdviewEnsambles.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewEnsambles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewEnsambles.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewEnsambles.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewEnsambles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.grdviewEnsambles.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewEnsambles.ColumnPanelRowHeight = 35
        Me.grdviewEnsambles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.BandedGridColumn7, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn10})
        Me.grdviewEnsambles.GridControl = Me.grdEnsambles
        Me.grdviewEnsambles.Name = "grdviewEnsambles"
        Me.grdviewEnsambles.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grdviewEnsambles.OptionsBehavior.FocusLeaveOnTab = True
        Me.grdviewEnsambles.OptionsView.ColumnAutoWidth = False
        Me.grdviewEnsambles.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewEnsambles.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewEnsambles.OptionsView.ShowGroupPanel = False
        Me.grdviewEnsambles.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdviewEnsambles.OptionsView.ShowViewCaption = True
        Me.grdviewEnsambles.PaintStyleName = "UltraFlat"
        Me.grdviewEnsambles.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BandedGridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.grdviewEnsambles.ViewCaption = "E N S A M B L E S      ( AR)"
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn1.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn1.FieldName = "Tipo"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.VisibleIndex = 8
        Me.BandedGridColumn1.Width = 92
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn2.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.FieldName = "Destino"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn2.OptionsEditForm.VisibleIndex = 1
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.VisibleIndex = 7
        Me.BandedGridColumn2.Width = 69
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn3.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridColumn3.FieldName = "NumeroSAP"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn3.OptionsEditForm.VisibleIndex = 4
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.VisibleIndex = 0
        Me.BandedGridColumn3.Width = 68
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn4.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridColumn4.FieldName = "CodigoArticulo"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn4.OptionsEditForm.VisibleIndex = 3
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.VisibleIndex = 1
        Me.BandedGridColumn4.Width = 88
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn5.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn5.FieldName = "NombreArticulo"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsEditForm.ColumnSpan = 2
        Me.BandedGridColumn5.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn5.OptionsEditForm.VisibleIndex = 6
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.VisibleIndex = 2
        Me.BandedGridColumn5.Width = 290
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.Orange
        Me.BandedGridColumn6.AppearanceCell.Options.UseForeColor = True
        Me.BandedGridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn6.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn6.FieldName = "Planeado"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn6.OptionsEditForm.VisibleIndex = 2
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.VisibleIndex = 3
        Me.BandedGridColumn6.Width = 78
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.BandedGridColumn7.AppearanceCell.Options.UseForeColor = True
        Me.BandedGridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn7.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn7.FieldName = "Completado"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn7.OptionsEditForm.VisibleIndex = 5
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.VisibleIndex = 4
        Me.BandedGridColumn7.Width = 82
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.BandedGridColumn8.AppearanceCell.Options.UseForeColor = True
        Me.BandedGridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn8.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn8.FieldName = "Pendiente"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn8.OptionsEditForm.VisibleIndex = 7
        Me.BandedGridColumn8.Visible = True
        Me.BandedGridColumn8.VisibleIndex = 5
        Me.BandedGridColumn8.Width = 72
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn9.AppearanceCell.Options.UseForeColor = True
        Me.BandedGridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn9.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn9.FieldName = "Producidos"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn9.OptionsEditForm.VisibleIndex = 9
        Me.BandedGridColumn9.Visible = True
        Me.BandedGridColumn9.VisibleIndex = 6
        Me.BandedGridColumn9.Width = 82
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridColumn10.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn10.FieldName = "Comentarios"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.OptionsEditForm.ColumnSpan = 2
        Me.BandedGridColumn10.OptionsEditForm.UseEditorColRowSpan = False
        Me.BandedGridColumn10.OptionsEditForm.VisibleIndex = 8
        Me.BandedGridColumn10.Visible = True
        Me.BandedGridColumn10.VisibleIndex = 9
        Me.BandedGridColumn10.Width = 422
        '
        'grdProducciones
        '
        Me.grdProducciones.DataMember = "dsdtProducciones"
        Me.grdProducciones.DataSource = Me.DsControlProduccionDetalle
        Me.grdProducciones.Location = New System.Drawing.Point(12, 12)
        Me.grdProducciones.MainView = Me.lyviewProducciones
        Me.grdProducciones.Name = "grdProducciones"
        Me.grdProducciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rmmeNombre, Me.rmmeDescripcion})
        Me.grdProducciones.Size = New System.Drawing.Size(909, 353)
        Me.grdProducciones.TabIndex = 4
        Me.grdProducciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lyviewProducciones})
        '
        'lyviewProducciones
        '
        Me.lyviewProducciones.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lyviewProducciones.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lyviewProducciones.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lyviewProducciones.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black
        Me.lyviewProducciones.Appearance.CardCaption.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.CardCaption.Options.UseBorderColor = True
        Me.lyviewProducciones.Appearance.CardCaption.Options.UseFont = True
        Me.lyviewProducciones.Appearance.CardCaption.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lyviewProducciones.Appearance.FieldCaption.BackColor2 = System.Drawing.Color.GhostWhite
        Me.lyviewProducciones.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.lyviewProducciones.Appearance.FieldCaption.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.FieldCaption.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.lyviewProducciones.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black
        Me.lyviewProducciones.Appearance.FieldValue.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.FieldValue.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.lyviewProducciones.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.lyviewProducciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.lyviewProducciones.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lyviewProducciones.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.lyviewProducciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lyviewProducciones.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lyviewProducciones.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lyviewProducciones.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White
        Me.lyviewProducciones.Appearance.FocusedCardCaption.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.FocusedCardCaption.Options.UseBorderColor = True
        Me.lyviewProducciones.Appearance.FocusedCardCaption.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.Gray
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.Gray
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.Options.UseBorderColor = True
        Me.lyviewProducciones.Appearance.HideSelectionCardCaption.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lyviewProducciones.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White
        Me.lyviewProducciones.Appearance.SelectedCardCaption.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.SelectedCardCaption.Options.UseForeColor = True
        Me.lyviewProducciones.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lyviewProducciones.Appearance.SeparatorLine.Options.UseBackColor = True
        Me.lyviewProducciones.Appearance.ViewBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lyviewProducciones.Appearance.ViewBackground.Options.UseBackColor = True
        Me.lyviewProducciones.CardMinSize = New System.Drawing.Size(247, 285)
        Me.lyviewProducciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colTipo, Me.colDestino, Me.colNumeroSAP, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProducidos, Me.colComentarios})
        Me.lyviewProducciones.GridControl = Me.grdProducciones
        Me.lyviewProducciones.Name = "lyviewProducciones"
        Me.lyviewProducciones.OptionsBehavior.FocusLeaveOnTab = True
        Me.lyviewProducciones.OptionsCarouselMode.CardCount = 4
        Me.lyviewProducciones.OptionsCarouselMode.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic
        Me.lyviewProducciones.OptionsCustomization.AllowFilter = False
        Me.lyviewProducciones.OptionsCustomization.AllowSort = False
        Me.lyviewProducciones.OptionsFilter.AllowColumnMRUFilterList = False
        Me.lyviewProducciones.OptionsFilter.AllowFilterEditor = False
        Me.lyviewProducciones.OptionsView.ShowHeaderPanel = False
        Me.lyviewProducciones.OptionsView.ShowViewCaption = True
        Me.lyviewProducciones.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel
        Me.lyviewProducciones.PaintStyleName = "Style3D"
        Me.lyviewProducciones.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNombreArticulo, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.lyviewProducciones.TemplateCard = Me.LayoutViewCard1
        Me.lyviewProducciones.ViewCaption = "P R O D U C C I O N E S      (CP)"
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
        Me.colTipo.LayoutViewField = Me.layoutViewField_colTipo
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.AllowEdit = False
        Me.colTipo.OptionsColumn.AllowFocus = False
        Me.colTipo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipo.OptionsColumn.AllowIncrementalSearch = False
        Me.colTipo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipo.OptionsColumn.AllowMove = False
        Me.colTipo.OptionsColumn.AllowShowHide = False
        Me.colTipo.OptionsColumn.AllowSize = False
        Me.colTipo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipo.OptionsColumn.FixedWidth = True
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.OptionsColumn.TabStop = False
        Me.colTipo.OptionsEditForm.VisibleIndex = 4
        Me.colTipo.Width = 106
        '
        'layoutViewField_colTipo
        '
        Me.layoutViewField_colTipo.EditorPreferredWidth = 108
        Me.layoutViewField_colTipo.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colTipo.Name = "layoutViewField_colTipo"
        Me.layoutViewField_colTipo.Size = New System.Drawing.Size(112, 24)
        Me.layoutViewField_colTipo.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colTipo.TextVisible = False
        '
        'colDestino
        '
        Me.colDestino.AppearanceCell.Options.UseTextOptions = True
        Me.colDestino.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.LayoutViewField = Me.layoutViewField_colDestino
        Me.colDestino.Name = "colDestino"
        Me.colDestino.OptionsColumn.AllowEdit = False
        Me.colDestino.OptionsColumn.AllowFocus = False
        Me.colDestino.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.OptionsColumn.AllowIncrementalSearch = False
        Me.colDestino.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.OptionsColumn.AllowMove = False
        Me.colDestino.OptionsColumn.AllowShowHide = False
        Me.colDestino.OptionsColumn.AllowSize = False
        Me.colDestino.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.OptionsColumn.ReadOnly = True
        Me.colDestino.OptionsColumn.TabStop = False
        Me.colDestino.OptionsEditForm.VisibleIndex = 1
        Me.colDestino.Width = 96
        '
        'layoutViewField_colDestino
        '
        Me.layoutViewField_colDestino.EditorPreferredWidth = 111
        Me.layoutViewField_colDestino.Location = New System.Drawing.Point(112, 0)
        Me.layoutViewField_colDestino.Name = "layoutViewField_colDestino"
        Me.layoutViewField_colDestino.Size = New System.Drawing.Size(115, 24)
        Me.layoutViewField_colDestino.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDestino.TextVisible = False
        '
        'colNumeroSAP
        '
        Me.colNumeroSAP.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroSAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroSAP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroSAP.AppearanceHeader.Options.UseFont = True
        Me.colNumeroSAP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroSAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroSAP.FieldName = "NumeroSAP"
        Me.colNumeroSAP.LayoutViewField = Me.layoutViewField_colNumeroSAP
        Me.colNumeroSAP.Name = "colNumeroSAP"
        Me.colNumeroSAP.OptionsColumn.ReadOnly = True
        Me.colNumeroSAP.Width = 78
        '
        'layoutViewField_colNumeroSAP
        '
        Me.layoutViewField_colNumeroSAP.EditorPreferredWidth = 138
        Me.layoutViewField_colNumeroSAP.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colNumeroSAP.Name = "layoutViewField_colNumeroSAP"
        Me.layoutViewField_colNumeroSAP.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colNumeroSAP.TextSize = New System.Drawing.Size(80, 13)
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.LayoutViewField = Me.layoutViewField_colCodigoArticulo
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.OptionsEditForm.VisibleIndex = 3
        Me.colCodigoArticulo.Width = 142
        '
        'layoutViewField_colCodigoArticulo
        '
        Me.layoutViewField_colCodigoArticulo.EditorPreferredWidth = 138
        Me.layoutViewField_colCodigoArticulo.Location = New System.Drawing.Point(0, 48)
        Me.layoutViewField_colCodigoArticulo.Name = "layoutViewField_colCodigoArticulo"
        Me.layoutViewField_colCodigoArticulo.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colCodigoArticulo.TextSize = New System.Drawing.Size(80, 13)
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreArticulo.AppearanceHeader.Options.UseFont = True
        Me.colNombreArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreArticulo.ColumnEdit = Me.rmmeNombre
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.LayoutViewField = Me.layoutViewField_colNombreArticulo
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.OptionsEditForm.ColumnSpan = 2
        Me.colNombreArticulo.OptionsEditForm.StartNewRow = True
        Me.colNombreArticulo.OptionsEditForm.UseEditorColRowSpan = False
        Me.colNombreArticulo.OptionsEditForm.VisibleIndex = 6
        Me.colNombreArticulo.Width = 422
        '
        'rmmeNombre
        '
        Me.rmmeNombre.Name = "rmmeNombre"
        '
        'layoutViewField_colNombreArticulo
        '
        Me.layoutViewField_colNombreArticulo.EditorPreferredWidth = 138
        Me.layoutViewField_colNombreArticulo.Location = New System.Drawing.Point(0, 72)
        Me.layoutViewField_colNombreArticulo.Name = "layoutViewField_colNombreArticulo"
        Me.layoutViewField_colNombreArticulo.Size = New System.Drawing.Size(227, 21)
        Me.layoutViewField_colNombreArticulo.TextSize = New System.Drawing.Size(80, 13)
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceCell.ForeColor = System.Drawing.Color.Orange
        Me.colPlaneado.AppearanceCell.Options.UseFont = True
        Me.colPlaneado.AppearanceCell.Options.UseForeColor = True
        Me.colPlaneado.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.LayoutViewField = Me.layoutViewField_colPlaneado
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.OptionsEditForm.VisibleIndex = 2
        Me.colPlaneado.Width = 97
        '
        'layoutViewField_colPlaneado
        '
        Me.layoutViewField_colPlaneado.EditorPreferredWidth = 138
        Me.layoutViewField_colPlaneado.Location = New System.Drawing.Point(0, 93)
        Me.layoutViewField_colPlaneado.Name = "layoutViewField_colPlaneado"
        Me.layoutViewField_colPlaneado.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colPlaneado.TextSize = New System.Drawing.Size(80, 13)
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.colCompletado.AppearanceCell.Options.UseFont = True
        Me.colCompletado.AppearanceCell.Options.UseForeColor = True
        Me.colCompletado.AppearanceCell.Options.UseTextOptions = True
        Me.colCompletado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.LayoutViewField = Me.layoutViewField_colCompletado
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.OptionsEditForm.VisibleIndex = 5
        Me.colCompletado.Width = 100
        '
        'layoutViewField_colCompletado
        '
        Me.layoutViewField_colCompletado.EditorPreferredWidth = 138
        Me.layoutViewField_colCompletado.Location = New System.Drawing.Point(0, 117)
        Me.layoutViewField_colCompletado.Name = "layoutViewField_colCompletado"
        Me.layoutViewField_colCompletado.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colCompletado.TextSize = New System.Drawing.Size(80, 13)
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colPendiente.AppearanceCell.Options.UseFont = True
        Me.colPendiente.AppearanceCell.Options.UseForeColor = True
        Me.colPendiente.AppearanceCell.Options.UseTextOptions = True
        Me.colPendiente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.LayoutViewField = Me.layoutViewField_colPendiente
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.OptionsEditForm.VisibleIndex = 7
        Me.colPendiente.Width = 104
        '
        'layoutViewField_colPendiente
        '
        Me.layoutViewField_colPendiente.EditorPreferredWidth = 138
        Me.layoutViewField_colPendiente.Location = New System.Drawing.Point(0, 141)
        Me.layoutViewField_colPendiente.Name = "layoutViewField_colPendiente"
        Me.layoutViewField_colPendiente.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colPendiente.TextSize = New System.Drawing.Size(80, 13)
        '
        'colProducidos
        '
        Me.colProducidos.AppearanceCell.BackColor = System.Drawing.Color.Gray
        Me.colProducidos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.colProducidos.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colProducidos.AppearanceCell.Options.UseBackColor = True
        Me.colProducidos.AppearanceCell.Options.UseFont = True
        Me.colProducidos.AppearanceCell.Options.UseForeColor = True
        Me.colProducidos.AppearanceCell.Options.UseTextOptions = True
        Me.colProducidos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProducidos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProducidos.AppearanceHeader.Options.UseFont = True
        Me.colProducidos.AppearanceHeader.Options.UseTextOptions = True
        Me.colProducidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProducidos.FieldName = "Producidos"
        Me.colProducidos.LayoutViewField = Me.layoutViewField_colProducidos
        Me.colProducidos.Name = "colProducidos"
        Me.colProducidos.OptionsEditForm.StartNewRow = True
        Me.colProducidos.OptionsEditForm.UseEditorColRowSpan = False
        Me.colProducidos.OptionsEditForm.VisibleIndex = 9
        Me.colProducidos.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Producidos", "SUM={0:n0}")})
        Me.colProducidos.Width = 121
        '
        'layoutViewField_colProducidos
        '
        Me.layoutViewField_colProducidos.EditorPreferredWidth = 138
        Me.layoutViewField_colProducidos.Location = New System.Drawing.Point(0, 165)
        Me.layoutViewField_colProducidos.Name = "layoutViewField_colProducidos"
        Me.layoutViewField_colProducidos.Size = New System.Drawing.Size(227, 24)
        Me.layoutViewField_colProducidos.TextSize = New System.Drawing.Size(80, 13)
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.ColumnEdit = Me.rmmeDescripcion
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.LayoutViewField = Me.layoutViewField_colComentarios
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near
        Me.colComentarios.OptionsEditForm.ColumnSpan = 2
        Me.colComentarios.OptionsEditForm.RowSpan = 2
        Me.colComentarios.OptionsEditForm.StartNewRow = True
        Me.colComentarios.OptionsEditForm.UseEditorColRowSpan = False
        Me.colComentarios.OptionsEditForm.VisibleIndex = 8
        Me.colComentarios.Width = 422
        '
        'rmmeDescripcion
        '
        Me.rmmeDescripcion.Name = "rmmeDescripcion"
        '
        'layoutViewField_colComentarios
        '
        Me.layoutViewField_colComentarios.EditorPreferredWidth = 138
        Me.layoutViewField_colComentarios.Location = New System.Drawing.Point(0, 189)
        Me.layoutViewField_colComentarios.Name = "layoutViewField_colComentarios"
        Me.layoutViewField_colComentarios.Size = New System.Drawing.Size(227, 20)
        Me.layoutViewField_colComentarios.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colTipo, Me.layoutViewField_colNumeroSAP, Me.layoutViewField_colNombreArticulo, Me.layoutViewField_colPlaneado, Me.layoutViewField_colCompletado, Me.layoutViewField_colPendiente, Me.layoutViewField_colProducidos, Me.layoutViewField_colComentarios, Me.layoutViewField_colDestino, Me.layoutViewField_colCodigoArticulo})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlGroup2, Me.LayoutControlItem7, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlItem12, Me.LayoutControlItem11, Me.EmptySpaceItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(966, 704)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.grdProducciones
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(913, 357)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(913, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(33, 357)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.CaptionImage = CType(resources.GetObject("LayoutControlGroup2.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 538)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(183, 146)
        Me.LayoutControlGroup2.Text = "Resumen de Produccion"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.spinTotal
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem3.Text = "Total"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.spinMalas
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem2.Text = "Malas"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.spinBuenas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem1.Text = "Buenas"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.spinPendientes
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem10.Text = "Pendientes"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.grdEnsambles
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 357)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(946, 181)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.CaptionImage = CType(resources.GetObject("LayoutControlGroup4.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(366, 538)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(162, 146)
        Me.LayoutControlGroup4.Text = "Tiempo de Trabajo"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.timeInicial
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem5.Text = "Hora Inicial"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.timeFinal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem8.Text = "Hora final"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.TimeTotal
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(138, 50)
        Me.LayoutControlItem9.Text = "Total Trabajado"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.CaptionImage = CType(resources.GetObject("LayoutControlGroup5.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(183, 538)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(183, 146)
        Me.LayoutControlGroup5.Text = "Resumen de Ensambles"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spinEnsambles
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(159, 98)
        Me.LayoutControlItem4.Text = "Total Ensambles"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.sbdcControlProduccionDetalle
        Me.LayoutControlItem12.Location = New System.Drawing.Point(891, 614)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(55, 70)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.mmeComentarios
        Me.LayoutControlItem11.Location = New System.Drawing.Point(528, 538)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(363, 146)
        Me.LayoutControlItem11.Text = "Comentarios"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(77, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(891, 538)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(55, 76)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StyleController1.Appearance.Options.UseFont = True
        '
        'DsControlProduccionDetalleBindingSource
        '
        Me.DsControlProduccionDetalleBindingSource.DataSource = Me.DsControlProduccionDetalle
        Me.DsControlProduccionDetalleBindingSource.Position = 0
        '
        'frmControlProduccion_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 704)
        Me.Controls.Add(Me.lycControlProduccionDetalle)
        Me.Controls.Add(Me.nbarDetalle)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmControlProduccion_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmControlProduccion_Detalle"
        CType(Me.nbarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nbarDetalle.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        CType(Me.dteTrabajoInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTrabajoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaTurno.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTrabajoFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTrabajoFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaquina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycControlProduccionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycControlProduccionDetalle.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinEnsambles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMalas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinBuenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlProduccionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyviewProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colNumeroSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colNombreArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPlaneado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCompletado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colProducidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmmeDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlProduccionDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nbarDetalle As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nbgProducciones As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbgParametrosMaquina As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents lycControlProduccionDetalle As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdEnsambles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdProducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsControlProduccionDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsControlProduccionDetalle As waProduccion_Pedidos.dsControlProduccionDetalle
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteTrabajoInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteTrabajoFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Maquina As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaquina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents slueTurno As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaTurno As DevExpress.XtraEditors.DateEdit
    Friend WithEvents spinTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinMalas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinBuenas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lyviewProducciones As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colNumeroSAP As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colProducidos As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents grdviewEnsambles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rmmeNombre As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rmmeDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents layoutViewField_colTipo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDestino As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colNumeroSAP As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCodigoArticulo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colNombreArticulo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPlaneado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCompletado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPendiente As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colProducidos As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colComentarios As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents spinEnsambles As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents timeFinal As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents timeInicial As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TimeTotal As DevExpress.XtraEditors.TimeSpanEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents spinPendientes As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents sbdcControlProduccionDetalle As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnAceptar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents mmeComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
