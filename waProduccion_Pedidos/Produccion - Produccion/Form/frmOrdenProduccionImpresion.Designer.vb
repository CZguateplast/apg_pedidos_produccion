<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenProduccionImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenProduccionImpresion))
        Me.lycOrdenProduccionImpresion = New DevExpress.XtraLayout.LayoutControl()
        Me.txtUnidades = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterial2Porc = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterial1Porc = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterial1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterial2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterial3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTurnosReq = New DevExpress.XtraEditors.TextEdit()
        Me.txtHorasReq = New DevExpress.XtraEditors.TextEdit()
        Me.txtSacosDia = New DevExpress.XtraEditors.TextEdit()
        Me.txtLbHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccionMax = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccionMin = New DevExpress.XtraEditors.TextEdit()
        Me.txtInyeccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloMax = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloMin = New DevExpress.XtraEditors.TextEdit()
        Me.txtCicloTurno = New DevExpress.XtraEditors.TextEdit()
        Me.txtCiclo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaquinaPreferencial = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoldeUbicacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoldeCavidades = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoldeNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoldeId = New DevExpress.XtraEditors.TextEdit()
        Me.grdMaquinas = New DevExpress.XtraGrid.GridControl()
        Me.DsOrdenProduccionImpresion = New waProduccion_Pedidos.dsOrdenProduccionImpresion()
        Me.grdviewMaquinas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdProduccionHijos = New DevExpress.XtraGrid.GridControl()
        Me.grdviewProduccionHijos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMoldeBodega = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnVistaPrevia = New DevExpress.XtraBars.BarButtonItem()
        Me.chkDetalle = New DevExpress.XtraBars.BarCheckItem()
        Me.btsTipoEnsamble = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnImprimirInstrucciones = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.DsParametros_Instrucciones1 = New waProduccion_Pedidos.dsParametros_Instrucciones()
        CType(Me.lycOrdenProduccionImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycOrdenProduccionImpresion.SuspendLayout()
        CType(Me.txtUnidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial2Porc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial1Porc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTurnosReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorasReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSacosDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLbHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccionMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccionMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInyeccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCicloTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiclo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaquinaPreferencial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldeUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldeCavidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldeNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldeId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenProduccionImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProduccionHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldeBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros_Instrucciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycOrdenProduccionImpresion
        '
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtUnidades)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaterial2Porc)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaterial1Porc)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCicloHora)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaterial1)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaterial2)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaterial3)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtTurnosReq)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtHorasReq)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtSacosDia)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtLbHora)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtInyeccionMax)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtInyeccionMin)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtInyeccion)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCicloMax)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCicloMin)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCicloTurno)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtCiclo)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMaquinaPreferencial)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMoldeUbicacion)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMoldeCavidades)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMoldeNombre)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMoldeId)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.grdMaquinas)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.grdProduccionHijos)
        Me.lycOrdenProduccionImpresion.Controls.Add(Me.txtMoldeBodega)
        Me.lycOrdenProduccionImpresion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycOrdenProduccionImpresion.Location = New System.Drawing.Point(0, 0)
        Me.lycOrdenProduccionImpresion.Name = "lycOrdenProduccionImpresion"
        Me.lycOrdenProduccionImpresion.Root = Me.LayoutControlGroup1
        Me.lycOrdenProduccionImpresion.Size = New System.Drawing.Size(911, 640)
        Me.lycOrdenProduccionImpresion.TabIndex = 0
        Me.lycOrdenProduccionImpresion.Text = "LayoutControl1"
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(230, 66)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnidades.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnidades.Properties.ReadOnly = True
        Me.txtUnidades.Size = New System.Drawing.Size(50, 20)
        Me.txtUnidades.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtUnidades.TabIndex = 32
        '
        'txtMaterial2Porc
        '
        Me.txtMaterial2Porc.Location = New System.Drawing.Point(755, 168)
        Me.txtMaterial2Porc.MaximumSize = New System.Drawing.Size(40, 0)
        Me.txtMaterial2Porc.MinimumSize = New System.Drawing.Size(40, 0)
        Me.txtMaterial2Porc.Name = "txtMaterial2Porc"
        Me.txtMaterial2Porc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterial2Porc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterial2Porc.Properties.ReadOnly = True
        Me.txtMaterial2Porc.Size = New System.Drawing.Size(40, 20)
        Me.txtMaterial2Porc.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaterial2Porc.TabIndex = 31
        '
        'txtMaterial1Porc
        '
        Me.txtMaterial1Porc.Location = New System.Drawing.Point(755, 144)
        Me.txtMaterial1Porc.MaximumSize = New System.Drawing.Size(40, 0)
        Me.txtMaterial1Porc.MinimumSize = New System.Drawing.Size(40, 0)
        Me.txtMaterial1Porc.Name = "txtMaterial1Porc"
        Me.txtMaterial1Porc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterial1Porc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterial1Porc.Properties.ReadOnly = True
        Me.txtMaterial1Porc.Size = New System.Drawing.Size(40, 20)
        Me.txtMaterial1Porc.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaterial1Porc.TabIndex = 30
        '
        'txtCicloHora
        '
        Me.txtCicloHora.Location = New System.Drawing.Point(100, 156)
        Me.txtCicloHora.Name = "txtCicloHora"
        Me.txtCicloHora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCicloHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCicloHora.Properties.ReadOnly = True
        Me.txtCicloHora.Size = New System.Drawing.Size(55, 20)
        Me.txtCicloHora.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCicloHora.TabIndex = 29
        '
        'txtMaterial1
        '
        Me.txtMaterial1.Location = New System.Drawing.Point(676, 144)
        Me.txtMaterial1.MaximumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial1.MinimumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial1.Name = "txtMaterial1"
        Me.txtMaterial1.Properties.ReadOnly = True
        Me.txtMaterial1.Size = New System.Drawing.Size(75, 20)
        Me.txtMaterial1.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaterial1.TabIndex = 28
        '
        'txtMaterial2
        '
        Me.txtMaterial2.Location = New System.Drawing.Point(676, 168)
        Me.txtMaterial2.MaximumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial2.MinimumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial2.Name = "txtMaterial2"
        Me.txtMaterial2.Properties.ReadOnly = True
        Me.txtMaterial2.Size = New System.Drawing.Size(75, 20)
        Me.txtMaterial2.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaterial2.TabIndex = 27
        '
        'txtMaterial3
        '
        Me.txtMaterial3.Location = New System.Drawing.Point(676, 192)
        Me.txtMaterial3.MaximumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial3.MinimumSize = New System.Drawing.Size(75, 0)
        Me.txtMaterial3.Name = "txtMaterial3"
        Me.txtMaterial3.Properties.ReadOnly = True
        Me.txtMaterial3.Size = New System.Drawing.Size(75, 20)
        Me.txtMaterial3.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaterial3.TabIndex = 26
        '
        'txtTurnosReq
        '
        Me.txtTurnosReq.Location = New System.Drawing.Point(223, 608)
        Me.txtTurnosReq.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtTurnosReq.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtTurnosReq.Name = "txtTurnosReq"
        Me.txtTurnosReq.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTurnosReq.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTurnosReq.Properties.ReadOnly = True
        Me.txtTurnosReq.Size = New System.Drawing.Size(55, 20)
        Me.txtTurnosReq.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtTurnosReq.TabIndex = 25
        '
        'txtHorasReq
        '
        Me.txtHorasReq.Location = New System.Drawing.Point(88, 608)
        Me.txtHorasReq.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtHorasReq.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtHorasReq.Name = "txtHorasReq"
        Me.txtHorasReq.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHorasReq.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtHorasReq.Properties.ReadOnly = True
        Me.txtHorasReq.Size = New System.Drawing.Size(55, 20)
        Me.txtHorasReq.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtHorasReq.TabIndex = 24
        '
        'txtSacosDia
        '
        Me.txtSacosDia.Location = New System.Drawing.Point(529, 156)
        Me.txtSacosDia.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtSacosDia.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtSacosDia.Name = "txtSacosDia"
        Me.txtSacosDia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSacosDia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSacosDia.Properties.ReadOnly = True
        Me.txtSacosDia.Size = New System.Drawing.Size(55, 20)
        Me.txtSacosDia.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtSacosDia.TabIndex = 23
        '
        'txtLbHora
        '
        Me.txtLbHora.Location = New System.Drawing.Point(529, 132)
        Me.txtLbHora.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtLbHora.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtLbHora.Name = "txtLbHora"
        Me.txtLbHora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLbHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLbHora.Properties.ReadOnly = True
        Me.txtLbHora.Size = New System.Drawing.Size(55, 20)
        Me.txtLbHora.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtLbHora.TabIndex = 22
        '
        'txtInyeccionMax
        '
        Me.txtInyeccionMax.Location = New System.Drawing.Point(394, 180)
        Me.txtInyeccionMax.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMax.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMax.Name = "txtInyeccionMax"
        Me.txtInyeccionMax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInyeccionMax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInyeccionMax.Properties.ReadOnly = True
        Me.txtInyeccionMax.Size = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMax.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtInyeccionMax.TabIndex = 21
        '
        'txtInyeccionMin
        '
        Me.txtInyeccionMin.Location = New System.Drawing.Point(394, 156)
        Me.txtInyeccionMin.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMin.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMin.Name = "txtInyeccionMin"
        Me.txtInyeccionMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInyeccionMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInyeccionMin.Properties.ReadOnly = True
        Me.txtInyeccionMin.Size = New System.Drawing.Size(55, 20)
        Me.txtInyeccionMin.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtInyeccionMin.TabIndex = 20
        '
        'txtInyeccion
        '
        Me.txtInyeccion.Location = New System.Drawing.Point(394, 132)
        Me.txtInyeccion.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccion.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtInyeccion.Name = "txtInyeccion"
        Me.txtInyeccion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInyeccion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInyeccion.Properties.ReadOnly = True
        Me.txtInyeccion.Size = New System.Drawing.Size(55, 20)
        Me.txtInyeccion.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtInyeccion.TabIndex = 19
        '
        'txtCicloMax
        '
        Me.txtCicloMax.Location = New System.Drawing.Point(235, 156)
        Me.txtCicloMax.Name = "txtCicloMax"
        Me.txtCicloMax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCicloMax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCicloMax.Properties.ReadOnly = True
        Me.txtCicloMax.Size = New System.Drawing.Size(55, 20)
        Me.txtCicloMax.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCicloMax.TabIndex = 18
        '
        'txtCicloMin
        '
        Me.txtCicloMin.Location = New System.Drawing.Point(235, 132)
        Me.txtCicloMin.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtCicloMin.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtCicloMin.Name = "txtCicloMin"
        Me.txtCicloMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCicloMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCicloMin.Properties.ReadOnly = True
        Me.txtCicloMin.Size = New System.Drawing.Size(55, 20)
        Me.txtCicloMin.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCicloMin.TabIndex = 17
        '
        'txtCicloTurno
        '
        Me.txtCicloTurno.Location = New System.Drawing.Point(100, 180)
        Me.txtCicloTurno.Name = "txtCicloTurno"
        Me.txtCicloTurno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCicloTurno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCicloTurno.Properties.ReadOnly = True
        Me.txtCicloTurno.Size = New System.Drawing.Size(55, 20)
        Me.txtCicloTurno.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCicloTurno.TabIndex = 16
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(100, 132)
        Me.txtCiclo.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtCiclo.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCiclo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCiclo.Properties.ReadOnly = True
        Me.txtCiclo.Size = New System.Drawing.Size(55, 20)
        Me.txtCiclo.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtCiclo.TabIndex = 15
        '
        'txtMaquinaPreferencial
        '
        Me.txtMaquinaPreferencial.Location = New System.Drawing.Point(529, 42)
        Me.txtMaquinaPreferencial.MaximumSize = New System.Drawing.Size(55, 20)
        Me.txtMaquinaPreferencial.MinimumSize = New System.Drawing.Size(55, 20)
        Me.txtMaquinaPreferencial.Name = "txtMaquinaPreferencial"
        Me.txtMaquinaPreferencial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaquinaPreferencial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaquinaPreferencial.Properties.ReadOnly = True
        Me.txtMaquinaPreferencial.Size = New System.Drawing.Size(55, 20)
        Me.txtMaquinaPreferencial.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMaquinaPreferencial.TabIndex = 12
        '
        'txtMoldeUbicacion
        '
        Me.txtMoldeUbicacion.Location = New System.Drawing.Point(529, 66)
        Me.txtMoldeUbicacion.Name = "txtMoldeUbicacion"
        Me.txtMoldeUbicacion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMoldeUbicacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMoldeUbicacion.Properties.ReadOnly = True
        Me.txtMoldeUbicacion.Size = New System.Drawing.Size(55, 20)
        Me.txtMoldeUbicacion.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMoldeUbicacion.TabIndex = 11
        '
        'txtMoldeCavidades
        '
        Me.txtMoldeCavidades.Location = New System.Drawing.Point(100, 66)
        Me.txtMoldeCavidades.Name = "txtMoldeCavidades"
        Me.txtMoldeCavidades.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMoldeCavidades.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMoldeCavidades.Properties.ReadOnly = True
        Me.txtMoldeCavidades.Size = New System.Drawing.Size(50, 20)
        Me.txtMoldeCavidades.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMoldeCavidades.TabIndex = 10
        '
        'txtMoldeNombre
        '
        Me.txtMoldeNombre.Location = New System.Drawing.Point(230, 42)
        Me.txtMoldeNombre.Name = "txtMoldeNombre"
        Me.txtMoldeNombre.Properties.ReadOnly = True
        Me.txtMoldeNombre.Size = New System.Drawing.Size(219, 20)
        Me.txtMoldeNombre.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMoldeNombre.TabIndex = 9
        '
        'txtMoldeId
        '
        Me.txtMoldeId.Location = New System.Drawing.Point(100, 42)
        Me.txtMoldeId.Name = "txtMoldeId"
        Me.txtMoldeId.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMoldeId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMoldeId.Properties.ReadOnly = True
        Me.txtMoldeId.Size = New System.Drawing.Size(50, 20)
        Me.txtMoldeId.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMoldeId.TabIndex = 8
        '
        'grdMaquinas
        '
        Me.grdMaquinas.DataMember = "dsdtMoldesMaquinasTrabajar"
        Me.grdMaquinas.DataSource = Me.DsOrdenProduccionImpresion
        Me.grdMaquinas.Location = New System.Drawing.Point(600, 28)
        Me.grdMaquinas.MainView = Me.grdviewMaquinas
        Me.grdMaquinas.Name = "grdMaquinas"
        Me.grdMaquinas.Size = New System.Drawing.Size(299, 112)
        Me.grdMaquinas.TabIndex = 5
        Me.grdMaquinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewMaquinas})
        '
        'DsOrdenProduccionImpresion
        '
        Me.DsOrdenProduccionImpresion.DataSetName = "dsOrdenProduccionImpresion"
        Me.DsOrdenProduccionImpresion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewMaquinas
        '
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewMaquinas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewMaquinas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewMaquinas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.Preview.Options.UseFont = True
        Me.grdviewMaquinas.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewMaquinas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewMaquinas.Appearance.Row.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.Row.Options.UseBorderColor = True
        Me.grdviewMaquinas.Appearance.Row.Options.UseForeColor = True
        Me.grdviewMaquinas.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdviewMaquinas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grdviewMaquinas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewMaquinas.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewMaquinas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdviewMaquinas.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewMaquinas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaquina})
        Me.grdviewMaquinas.GridControl = Me.grdMaquinas
        Me.grdviewMaquinas.Name = "grdviewMaquinas"
        Me.grdviewMaquinas.OptionsBehavior.Editable = False
        Me.grdviewMaquinas.OptionsBehavior.ReadOnly = True
        Me.grdviewMaquinas.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewMaquinas.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewMaquinas.OptionsView.ShowGroupPanel = False
        Me.grdviewMaquinas.PaintStyleName = "Flat"
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
        Me.colMaquina.Visible = True
        Me.colMaquina.VisibleIndex = 0
        Me.colMaquina.Width = 50
        '
        'grdProduccionHijos
        '
        Me.grdProduccionHijos.DataMember = "dsdtProduccionHijos"
        Me.grdProduccionHijos.DataSource = Me.DsOrdenProduccionImpresion
        Me.grdProduccionHijos.Location = New System.Drawing.Point(12, 216)
        Me.grdProduccionHijos.MainView = Me.grdviewProduccionHijos
        Me.grdProduccionHijos.Name = "grdProduccionHijos"
        Me.grdProduccionHijos.Size = New System.Drawing.Size(887, 388)
        Me.grdProduccionHijos.TabIndex = 4
        Me.grdProduccionHijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewProduccionHijos})
        '
        'grdviewProduccionHijos
        '
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewProduccionHijos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseFont = True
        Me.grdviewProduccionHijos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewProduccionHijos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewProduccionHijos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewProduccionHijos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewProduccionHijos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grdviewProduccionHijos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewProduccionHijos.ColumnPanelRowHeight = 35
        Me.grdviewProduccionHijos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colProdFinal, Me.colTipoMaterial})
        Me.grdviewProduccionHijos.GridControl = Me.grdProduccionHijos
        Me.grdviewProduccionHijos.Name = "grdviewProduccionHijos"
        Me.grdviewProduccionHijos.OptionsView.ColumnAutoWidth = False
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewProduccionHijos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewProduccionHijos.OptionsView.ShowFooter = True
        Me.grdviewProduccionHijos.OptionsView.ShowGroupPanel = False
        Me.grdviewProduccionHijos.PaintStyleName = "Flat"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
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
        Me.colNombreArticulo.OptionsColumn.AllowEdit = False
        Me.colNombreArticulo.OptionsColumn.ReadOnly = True
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 1
        Me.colNombreArticulo.Width = 313
        '
        'colPlaneado
        '
        Me.colPlaneado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaneado.AppearanceHeader.Options.UseFont = True
        Me.colPlaneado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlaneado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.OptionsColumn.AllowEdit = False
        Me.colPlaneado.OptionsColumn.ReadOnly = True
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 2
        Me.colPlaneado.Width = 85
        '
        'colCompletado
        '
        Me.colCompletado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCompletado.AppearanceHeader.Options.UseFont = True
        Me.colCompletado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.OptionsColumn.AllowEdit = False
        Me.colCompletado.OptionsColumn.ReadOnly = True
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 3
        Me.colCompletado.Width = 85
        '
        'colPendiente
        '
        Me.colPendiente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPendiente.AppearanceHeader.Options.UseFont = True
        Me.colPendiente.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendiente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.OptionsColumn.AllowEdit = False
        Me.colPendiente.OptionsColumn.ReadOnly = True
        Me.colPendiente.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 4
        Me.colPendiente.Width = 85
        '
        'colProdFinal
        '
        Me.colProdFinal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProdFinal.AppearanceHeader.Options.UseFont = True
        Me.colProdFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colProdFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProdFinal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProdFinal.Caption = "Producción Final"
        Me.colProdFinal.FieldName = "ProdFinal"
        Me.colProdFinal.Name = "colProdFinal"
        Me.colProdFinal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colProdFinal.Visible = True
        Me.colProdFinal.VisibleIndex = 5
        Me.colProdFinal.Width = 85
        '
        'colTipoMaterial
        '
        Me.colTipoMaterial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoMaterial.AppearanceHeader.Options.UseFont = True
        Me.colTipoMaterial.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMaterial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTipoMaterial.Caption = "Tipo Material"
        Me.colTipoMaterial.FieldName = "TipoMaterial"
        Me.colTipoMaterial.Name = "colTipoMaterial"
        Me.colTipoMaterial.Visible = True
        Me.colTipoMaterial.VisibleIndex = 6
        Me.colTipoMaterial.Width = 69
        '
        'txtMoldeBodega
        '
        Me.txtMoldeBodega.Location = New System.Drawing.Point(360, 66)
        Me.txtMoldeBodega.Name = "txtMoldeBodega"
        Me.txtMoldeBodega.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMoldeBodega.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMoldeBodega.Properties.ReadOnly = True
        Me.txtMoldeBodega.Size = New System.Drawing.Size(89, 20)
        Me.txtMoldeBodega.StyleController = Me.lycOrdenProduccionImpresion
        Me.txtMoldeBodega.TabIndex = 13
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem4, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem20, Me.LayoutControlItem21})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(911, 640)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdProduccionHijos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 204)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(891, 392)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.grdMaquinas
        Me.LayoutControlItem2.CustomizationFormText = "Referencia Maquinas"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(588, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(303, 132)
        Me.LayoutControlItem2.Text = "Maquinas"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup2.CustomizationFormText = "Parametros del Molde"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem26})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(588, 90)
        Me.LayoutControlGroup2.Text = "Parametros del Molde"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtMoldeId
        Me.LayoutControlItem3.CustomizationFormText = "Molde"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem3.Text = "Molde"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtMoldeNombre
        Me.LayoutControlItem5.CustomizationFormText = "Nombre"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(130, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem5.Text = "Nombre"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.txtMoldeCavidades
        Me.LayoutControlItem6.CustomizationFormText = "Cavidades"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem6.Text = "Cavidades"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.txtMoldeUbicacion
        Me.LayoutControlItem7.CustomizationFormText = "Ubicacion"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(429, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem7.Text = "Ubicacion"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.txtMoldeBodega
        Me.LayoutControlItem9.CustomizationFormText = "Lugar"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(260, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(169, 24)
        Me.LayoutControlItem9.Text = "Lugar"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.txtMaquinaPreferencial
        Me.LayoutControlItem8.CustomizationFormText = "Preferencial"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(429, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem8.Text = "Preferencial"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue
        Me.LayoutControlItem26.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem26.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem26.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem26.Control = Me.txtUnidades
        Me.LayoutControlItem26.CustomizationFormText = "Unidades"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(130, 24)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem26.Text = "Unidades"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup3.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup3.CustomizationFormText = "Ciclos"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.LayoutControlItem10, Me.LayoutControlItem12})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(294, 114)
        Me.LayoutControlGroup3.Text = "Ciclos"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem11.Control = Me.txtCiclo
        Me.LayoutControlItem11.CustomizationFormText = "Ciclo"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem11.Text = "Ciclo"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.txtCicloMax
        Me.LayoutControlItem14.CustomizationFormText = "Ciclo Max"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(135, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(135, 48)
        Me.LayoutControlItem14.Text = "Ciclo Max"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem13.Control = Me.txtCicloMin
        Me.LayoutControlItem13.CustomizationFormText = "Ciclo Min"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(135, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem13.Text = "Ciclo Min"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtCicloHora
        Me.LayoutControlItem10.CustomizationFormText = "Ciclo Hora"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem10.Text = "Ciclo Hora"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem12.Control = Me.txtCicloTurno
        Me.LayoutControlItem12.CustomizationFormText = "Ciclo Turno"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem12.Text = "Ciclo Turno"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup4.AppearanceGroup.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup4.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup4.CustomizationFormText = "Inyección Grms"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(294, 90)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(294, 114)
        Me.LayoutControlGroup4.Text = "Inyección Grms"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem15.Control = Me.txtInyeccion
        Me.LayoutControlItem15.CustomizationFormText = "Inyección"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem15.Text = "Inyección"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem16.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem16.Control = Me.txtInyeccionMin
        Me.LayoutControlItem16.CustomizationFormText = "Inyección Min"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem16.Text = "Inyección Min"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem17.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem17.Control = Me.txtInyeccionMax
        Me.LayoutControlItem17.CustomizationFormText = "Inyección Max"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem17.Text = "Inyección Max"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem18.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem18.Control = Me.txtLbHora
        Me.LayoutControlItem18.CustomizationFormText = "Lb Hora"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(135, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem18.Text = "Lb Hora"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem19.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem19.Control = Me.txtSacosDia
        Me.LayoutControlItem19.CustomizationFormText = "Sacos 25 Kg (Dia)"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(135, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem19.Text = "Sacos Dia 25Kg"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem22.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem22.Control = Me.txtMaterial2
        Me.LayoutControlItem22.CustomizationFormText = "Material 2"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(588, 156)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem22.Text = "Material 2"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem23.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem23.Control = Me.txtMaterial1
        Me.LayoutControlItem23.CustomizationFormText = "Material 1"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(588, 132)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem23.Text = "Material 1"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtMaterial3
        Me.LayoutControlItem4.CustomizationFormText = "Material 3"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(588, 180)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(303, 24)
        Me.LayoutControlItem4.Text = "Material 3"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtMaterial1Porc
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(743, 132)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(148, 24)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtMaterial2Porc
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(743, 156)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(148, 24)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem20.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem20.Control = Me.txtHorasReq
        Me.LayoutControlItem20.CustomizationFormText = "Horas Req."
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 596)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem20.Text = "Horas Req."
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem21.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem21.Control = Me.txtTurnosReq
        Me.LayoutControlItem21.CustomizationFormText = "Turnos Req."
        Me.LayoutControlItem21.Location = New System.Drawing.Point(135, 596)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(756, 24)
        Me.LayoutControlItem21.Text = "Turnos Req."
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(73, 13)
        '
        'StyleController1
        '
        Me.StyleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnVistaPrevia, Me.barbtnCerrar, Me.chkDetalle, Me.btsTipoEnsamble, Me.barbtnImprimirInstrucciones, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnVistaPrevia, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.chkDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btsTipoEnsamble, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnImprimirInstrucciones, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnVistaPrevia
        '
        Me.barbtnVistaPrevia.Caption = "Imprimir"
        Me.barbtnVistaPrevia.Id = 0
        Me.barbtnVistaPrevia.ImageOptions.Image = CType(resources.GetObject("barbtnVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnVistaPrevia.Name = "barbtnVistaPrevia"
        Me.barbtnVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'chkDetalle
        '
        Me.chkDetalle.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.chkDetalle.Caption = "Imprimir Detalle"
        Me.chkDetalle.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.chkDetalle.Id = 2
        Me.chkDetalle.Name = "chkDetalle"
        '
        'btsTipoEnsamble
        '
        Me.btsTipoEnsamble.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btsTipoEnsamble.Caption = "Ensambles Solo en Producción"
        Me.btsTipoEnsamble.Id = 3
        Me.btsTipoEnsamble.Name = "btsTipoEnsamble"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Id = 1
        Me.barbtnCerrar.ImageOptions.Image = CType(resources.GetObject("barbtnCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'barbtnImprimirInstrucciones
        '
        Me.barbtnImprimirInstrucciones.Caption = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instrucciones"
        Me.barbtnImprimirInstrucciones.Id = 4
        Me.barbtnImprimirInstrucciones.ImageOptions.Image = CType(resources.GetObject("barbtnImprimirInstrucciones.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnImprimirInstrucciones.Name = "barbtnImprimirInstrucciones"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(911, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 640)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(911, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 640)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(911, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 640)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'DsParametros_Instrucciones1
        '
        Me.DsParametros_Instrucciones1.DataSetName = "dsParametros_Instrucciones"
        Me.DsParametros_Instrucciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmOrdenProduccionImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 683)
        Me.ControlBox = false
        Me.Controls.Add(Me.lycOrdenProduccionImpresion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmOrdenProduccionImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa de Impresion de Ordenes de Produccion"
        CType(Me.lycOrdenProduccionImpresion,System.ComponentModel.ISupportInitialize).EndInit
        Me.lycOrdenProduccionImpresion.ResumeLayout(false)
        CType(Me.txtUnidades.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaterial2Porc.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaterial1Porc.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCicloHora.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaterial1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaterial2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaterial3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTurnosReq.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHorasReq.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSacosDia.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtLbHora.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtInyeccionMax.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtInyeccionMin.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtInyeccion.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCicloMax.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCicloMin.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCicloTurno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCiclo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaquinaPreferencial.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMoldeUbicacion.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMoldeCavidades.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMoldeNombre.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMoldeId.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdMaquinas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsOrdenProduccionImpresion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdviewMaquinas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdProduccionHijos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdviewProduccionHijos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMoldeBodega.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem26,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem14,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem13,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem15,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem16,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem17,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem18,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem19,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem22,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem23,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem25,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem20,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem21,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsParametros_Instrucciones1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lycOrdenProduccionImpresion As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdProduccionHijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsOrdenProduccionImpresion As waProduccion_Pedidos.dsOrdenProduccionImpresion
    Friend WithEvents grdviewProduccionHijos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdMaquinas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewMaquinas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMaquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMaquinaPreferencial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoldeUbicacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoldeCavidades As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoldeNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoldeId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMaterial1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaterial2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaterial3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTurnosReq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHorasReq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSacosDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLbHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccionMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccionMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInyeccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCicloTurno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCiclo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCicloHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMaterial2Porc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaterial1Porc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUnidades As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMoldeBodega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkDetalle As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btsTipoEnsamble As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents colTipoMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnImprimirInstrucciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsParametros_Instrucciones1 As waProduccion_Pedidos.dsParametros_Instrucciones
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
