<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_AnalisisVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_AnalisisVenta))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView4 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView5 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView6 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView7 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView8 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series9 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView9 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series10 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView10 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series11 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView11 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series12 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView12 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series13 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView13 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series14 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView14 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series15 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView15 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.DsAnalisisVenta = New waProduccion_Pedidos.dsAnalisisVenta()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txt3MesesPromedio = New DevExpress.XtraEditors.TextEdit()
        Me.txt3MesesSuma = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesesSimple = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesesCompuesto = New DevExpress.XtraEditors.TextEdit()
        Me.txtPromedioSimple = New DevExpress.XtraEditors.TextEdit()
        Me.txtPromedioCompuesto = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesesConMovimiento = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaximoUnidadesVendidas = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaximo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinimo = New DevExpress.XtraEditors.TextEdit()
        Me.txtStock = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalUnidadesVendidas = New DevExpress.XtraEditors.TextEdit()
        Me.txtU15 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU14 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU13 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU12 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU11 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU09 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU08 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU07 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU06 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU05 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU04 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU03 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU02 = New DevExpress.XtraEditors.TextEdit()
        Me.txtU01 = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.lycPrincipal = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lyc01 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc02 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc03 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc04 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc05 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc06 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc07 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc08 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc09 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyc15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DsdtAnalisisVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.DsAnalisisVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txt3MesesPromedio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3MesesSuma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesesSimple.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesesCompuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPromedioSimple.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPromedioCompuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesesConMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaximoUnidadesVendidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalUnidadesVendidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU09.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU08.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU07.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU06.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU05.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU04.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU03.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU02.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtU01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyc15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsdtAnalisisVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsAnalisisVenta
        '
        Me.DsAnalisisVenta.DataSetName = "dsAnalisisVenta"
        Me.DsAnalisisVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'BarManager1
        '
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1108, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 622)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1108, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 622)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1108, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 622)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1112, 577)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1092, 557)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.txt3MesesPromedio)
        Me.LayoutControl1.Controls.Add(Me.txt3MesesSuma)
        Me.LayoutControl1.Controls.Add(Me.txtMesesSimple)
        Me.LayoutControl1.Controls.Add(Me.txtMesesCompuesto)
        Me.LayoutControl1.Controls.Add(Me.txtPromedioSimple)
        Me.LayoutControl1.Controls.Add(Me.txtPromedioCompuesto)
        Me.LayoutControl1.Controls.Add(Me.txtMesesConMovimiento)
        Me.LayoutControl1.Controls.Add(Me.txtMaximoUnidadesVendidas)
        Me.LayoutControl1.Controls.Add(Me.txtMaximo)
        Me.LayoutControl1.Controls.Add(Me.txtMinimo)
        Me.LayoutControl1.Controls.Add(Me.txtStock)
        Me.LayoutControl1.Controls.Add(Me.txtTotalUnidadesVendidas)
        Me.LayoutControl1.Controls.Add(Me.txtU15)
        Me.LayoutControl1.Controls.Add(Me.txtU14)
        Me.LayoutControl1.Controls.Add(Me.txtU13)
        Me.LayoutControl1.Controls.Add(Me.txtU12)
        Me.LayoutControl1.Controls.Add(Me.txtU11)
        Me.LayoutControl1.Controls.Add(Me.txtU10)
        Me.LayoutControl1.Controls.Add(Me.txtU09)
        Me.LayoutControl1.Controls.Add(Me.txtU08)
        Me.LayoutControl1.Controls.Add(Me.txtU07)
        Me.LayoutControl1.Controls.Add(Me.txtU06)
        Me.LayoutControl1.Controls.Add(Me.txtU05)
        Me.LayoutControl1.Controls.Add(Me.txtU04)
        Me.LayoutControl1.Controls.Add(Me.txtU03)
        Me.LayoutControl1.Controls.Add(Me.txtU02)
        Me.LayoutControl1.Controls.Add(Me.txtU01)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.ChartControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.lycPrincipal
        Me.LayoutControl1.Size = New System.Drawing.Size(1108, 622)
        Me.LayoutControl1.TabIndex = 5
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(586, 29)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 35
        Me.lblTitulo.Text = "ANALISIS DE VENTA DE LOS ULTIMOS 15 MESES"
        '
        'txt3MesesPromedio
        '
        Me.txt3MesesPromedio.Location = New System.Drawing.Point(148, 195)
        Me.txt3MesesPromedio.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txt3MesesPromedio.MenuManager = Me.BarManager1
        Me.txt3MesesPromedio.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txt3MesesPromedio.Name = "txt3MesesPromedio"
        Me.txt3MesesPromedio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt3MesesPromedio.Properties.Appearance.Options.UseBackColor = True
        Me.txt3MesesPromedio.Properties.Appearance.Options.UseTextOptions = True
        Me.txt3MesesPromedio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt3MesesPromedio.Properties.ReadOnly = True
        Me.txt3MesesPromedio.Size = New System.Drawing.Size(70, 20)
        Me.txt3MesesPromedio.StyleController = Me.LayoutControl1
        Me.txt3MesesPromedio.TabIndex = 34
        '
        'txt3MesesSuma
        '
        Me.txt3MesesSuma.Location = New System.Drawing.Point(148, 219)
        Me.txt3MesesSuma.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txt3MesesSuma.MenuManager = Me.BarManager1
        Me.txt3MesesSuma.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txt3MesesSuma.Name = "txt3MesesSuma"
        Me.txt3MesesSuma.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt3MesesSuma.Properties.Appearance.Options.UseBackColor = True
        Me.txt3MesesSuma.Properties.Appearance.Options.UseTextOptions = True
        Me.txt3MesesSuma.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt3MesesSuma.Properties.ReadOnly = True
        Me.txt3MesesSuma.Size = New System.Drawing.Size(70, 20)
        Me.txt3MesesSuma.StyleController = Me.LayoutControl1
        Me.txt3MesesSuma.TabIndex = 33
        '
        'txtMesesSimple
        '
        Me.txtMesesSimple.Location = New System.Drawing.Point(148, 425)
        Me.txtMesesSimple.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesSimple.MenuManager = Me.BarManager1
        Me.txtMesesSimple.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesSimple.Name = "txtMesesSimple"
        Me.txtMesesSimple.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMesesSimple.Properties.Appearance.Options.UseBackColor = True
        Me.txtMesesSimple.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMesesSimple.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMesesSimple.Properties.ReadOnly = True
        Me.txtMesesSimple.Size = New System.Drawing.Size(70, 20)
        Me.txtMesesSimple.StyleController = Me.LayoutControl1
        Me.txtMesesSimple.TabIndex = 32
        '
        'txtMesesCompuesto
        '
        Me.txtMesesCompuesto.Location = New System.Drawing.Point(148, 401)
        Me.txtMesesCompuesto.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesCompuesto.MenuManager = Me.BarManager1
        Me.txtMesesCompuesto.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesCompuesto.Name = "txtMesesCompuesto"
        Me.txtMesesCompuesto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMesesCompuesto.Properties.Appearance.Options.UseBackColor = True
        Me.txtMesesCompuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMesesCompuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMesesCompuesto.Properties.ReadOnly = True
        Me.txtMesesCompuesto.Size = New System.Drawing.Size(70, 20)
        Me.txtMesesCompuesto.StyleController = Me.LayoutControl1
        Me.txtMesesCompuesto.TabIndex = 31
        '
        'txtPromedioSimple
        '
        Me.txtPromedioSimple.Location = New System.Drawing.Point(148, 128)
        Me.txtPromedioSimple.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtPromedioSimple.MenuManager = Me.BarManager1
        Me.txtPromedioSimple.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtPromedioSimple.Name = "txtPromedioSimple"
        Me.txtPromedioSimple.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPromedioSimple.Properties.Appearance.Options.UseBackColor = True
        Me.txtPromedioSimple.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPromedioSimple.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPromedioSimple.Properties.ReadOnly = True
        Me.txtPromedioSimple.Size = New System.Drawing.Size(70, 20)
        Me.txtPromedioSimple.StyleController = Me.LayoutControl1
        Me.txtPromedioSimple.TabIndex = 30
        '
        'txtPromedioCompuesto
        '
        Me.txtPromedioCompuesto.Location = New System.Drawing.Point(148, 104)
        Me.txtPromedioCompuesto.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtPromedioCompuesto.MenuManager = Me.BarManager1
        Me.txtPromedioCompuesto.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtPromedioCompuesto.Name = "txtPromedioCompuesto"
        Me.txtPromedioCompuesto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPromedioCompuesto.Properties.Appearance.Options.UseBackColor = True
        Me.txtPromedioCompuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPromedioCompuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPromedioCompuesto.Properties.ReadOnly = True
        Me.txtPromedioCompuesto.Size = New System.Drawing.Size(70, 20)
        Me.txtPromedioCompuesto.StyleController = Me.LayoutControl1
        Me.txtPromedioCompuesto.TabIndex = 29
        '
        'txtMesesConMovimiento
        '
        Me.txtMesesConMovimiento.Location = New System.Drawing.Point(1014, 572)
        Me.txtMesesConMovimiento.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesConMovimiento.MenuManager = Me.BarManager1
        Me.txtMesesConMovimiento.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMesesConMovimiento.Name = "txtMesesConMovimiento"
        Me.txtMesesConMovimiento.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMesesConMovimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMesesConMovimiento.Properties.Appearance.Options.UseBackColor = True
        Me.txtMesesConMovimiento.Properties.Appearance.Options.UseFont = True
        Me.txtMesesConMovimiento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMesesConMovimiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMesesConMovimiento.Properties.ReadOnly = True
        Me.txtMesesConMovimiento.Size = New System.Drawing.Size(70, 20)
        Me.txtMesesConMovimiento.StyleController = Me.LayoutControl1
        Me.txtMesesConMovimiento.TabIndex = 28
        '
        'txtMaximoUnidadesVendidas
        '
        Me.txtMaximoUnidadesVendidas.Location = New System.Drawing.Point(1014, 548)
        Me.txtMaximoUnidadesVendidas.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMaximoUnidadesVendidas.MenuManager = Me.BarManager1
        Me.txtMaximoUnidadesVendidas.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMaximoUnidadesVendidas.Name = "txtMaximoUnidadesVendidas"
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.Options.UseFont = True
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaximoUnidadesVendidas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaximoUnidadesVendidas.Properties.ReadOnly = True
        Me.txtMaximoUnidadesVendidas.Size = New System.Drawing.Size(70, 20)
        Me.txtMaximoUnidadesVendidas.StyleController = Me.LayoutControl1
        Me.txtMaximoUnidadesVendidas.TabIndex = 27
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(148, 334)
        Me.txtMaximo.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMaximo.MenuManager = Me.BarManager1
        Me.txtMaximo.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaximo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaximo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaximo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaximo.Properties.ReadOnly = True
        Me.txtMaximo.Size = New System.Drawing.Size(70, 20)
        Me.txtMaximo.StyleController = Me.LayoutControl1
        Me.txtMaximo.TabIndex = 26
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(148, 310)
        Me.txtMinimo.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtMinimo.MenuManager = Me.BarManager1
        Me.txtMinimo.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMinimo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMinimo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimo.Properties.ReadOnly = True
        Me.txtMinimo.Size = New System.Drawing.Size(70, 20)
        Me.txtMinimo.StyleController = Me.LayoutControl1
        Me.txtMinimo.TabIndex = 25
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(148, 286)
        Me.txtStock.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtStock.MenuManager = Me.BarManager1
        Me.txtStock.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStock.Properties.Appearance.Options.UseBackColor = True
        Me.txtStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStock.Properties.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(70, 20)
        Me.txtStock.StyleController = Me.LayoutControl1
        Me.txtStock.TabIndex = 24
        '
        'txtTotalUnidadesVendidas
        '
        Me.txtTotalUnidadesVendidas.Location = New System.Drawing.Point(1014, 524)
        Me.txtTotalUnidadesVendidas.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtTotalUnidadesVendidas.MenuManager = Me.BarManager1
        Me.txtTotalUnidadesVendidas.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtTotalUnidadesVendidas.Name = "txtTotalUnidadesVendidas"
        Me.txtTotalUnidadesVendidas.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTotalUnidadesVendidas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalUnidadesVendidas.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalUnidadesVendidas.Properties.Appearance.Options.UseFont = True
        Me.txtTotalUnidadesVendidas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalUnidadesVendidas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalUnidadesVendidas.Properties.ReadOnly = True
        Me.txtTotalUnidadesVendidas.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalUnidadesVendidas.StyleController = Me.LayoutControl1
        Me.txtTotalUnidadesVendidas.TabIndex = 23
        '
        'txtU15
        '
        Me.txtU15.Location = New System.Drawing.Point(1014, 496)
        Me.txtU15.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU15.MenuManager = Me.BarManager1
        Me.txtU15.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU15.Name = "txtU15"
        Me.txtU15.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU15.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU15.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtU15.Properties.Appearance.Options.UseBackColor = True
        Me.txtU15.Properties.Appearance.Options.UseFont = True
        Me.txtU15.Properties.Appearance.Options.UseForeColor = True
        Me.txtU15.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU15.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU15.Properties.ReadOnly = True
        Me.txtU15.Size = New System.Drawing.Size(70, 24)
        Me.txtU15.StyleController = Me.LayoutControl1
        Me.txtU15.TabIndex = 22
        '
        'txtU14
        '
        Me.txtU14.Location = New System.Drawing.Point(1014, 468)
        Me.txtU14.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU14.MenuManager = Me.BarManager1
        Me.txtU14.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU14.Name = "txtU14"
        Me.txtU14.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU14.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU14.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU14.Properties.Appearance.Options.UseBackColor = True
        Me.txtU14.Properties.Appearance.Options.UseFont = True
        Me.txtU14.Properties.Appearance.Options.UseForeColor = True
        Me.txtU14.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU14.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU14.Properties.ReadOnly = True
        Me.txtU14.Size = New System.Drawing.Size(70, 24)
        Me.txtU14.StyleController = Me.LayoutControl1
        Me.txtU14.TabIndex = 21
        '
        'txtU13
        '
        Me.txtU13.Location = New System.Drawing.Point(1014, 440)
        Me.txtU13.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU13.MenuManager = Me.BarManager1
        Me.txtU13.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU13.Name = "txtU13"
        Me.txtU13.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU13.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU13.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtU13.Properties.Appearance.Options.UseBackColor = True
        Me.txtU13.Properties.Appearance.Options.UseFont = True
        Me.txtU13.Properties.Appearance.Options.UseForeColor = True
        Me.txtU13.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU13.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU13.Properties.ReadOnly = True
        Me.txtU13.Size = New System.Drawing.Size(70, 24)
        Me.txtU13.StyleController = Me.LayoutControl1
        Me.txtU13.TabIndex = 20
        '
        'txtU12
        '
        Me.txtU12.Location = New System.Drawing.Point(1014, 412)
        Me.txtU12.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU12.MenuManager = Me.BarManager1
        Me.txtU12.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU12.Name = "txtU12"
        Me.txtU12.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU12.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU12.Properties.Appearance.Options.UseBackColor = True
        Me.txtU12.Properties.Appearance.Options.UseFont = True
        Me.txtU12.Properties.Appearance.Options.UseForeColor = True
        Me.txtU12.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU12.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU12.Properties.ReadOnly = True
        Me.txtU12.Size = New System.Drawing.Size(70, 24)
        Me.txtU12.StyleController = Me.LayoutControl1
        Me.txtU12.TabIndex = 19
        '
        'txtU11
        '
        Me.txtU11.Location = New System.Drawing.Point(1014, 384)
        Me.txtU11.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU11.MenuManager = Me.BarManager1
        Me.txtU11.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU11.Name = "txtU11"
        Me.txtU11.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU11.Properties.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.txtU11.Properties.Appearance.Options.UseBackColor = True
        Me.txtU11.Properties.Appearance.Options.UseFont = True
        Me.txtU11.Properties.Appearance.Options.UseForeColor = True
        Me.txtU11.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU11.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU11.Properties.ReadOnly = True
        Me.txtU11.Size = New System.Drawing.Size(70, 24)
        Me.txtU11.StyleController = Me.LayoutControl1
        Me.txtU11.TabIndex = 18
        '
        'txtU10
        '
        Me.txtU10.Location = New System.Drawing.Point(1014, 356)
        Me.txtU10.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU10.MenuManager = Me.BarManager1
        Me.txtU10.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU10.Name = "txtU10"
        Me.txtU10.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtU10.Properties.Appearance.Options.UseBackColor = True
        Me.txtU10.Properties.Appearance.Options.UseFont = True
        Me.txtU10.Properties.Appearance.Options.UseForeColor = True
        Me.txtU10.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU10.Properties.ReadOnly = True
        Me.txtU10.Size = New System.Drawing.Size(70, 24)
        Me.txtU10.StyleController = Me.LayoutControl1
        Me.txtU10.TabIndex = 17
        '
        'txtU09
        '
        Me.txtU09.Location = New System.Drawing.Point(1014, 328)
        Me.txtU09.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU09.MenuManager = Me.BarManager1
        Me.txtU09.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU09.Name = "txtU09"
        Me.txtU09.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU09.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU09.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU09.Properties.Appearance.Options.UseBackColor = True
        Me.txtU09.Properties.Appearance.Options.UseFont = True
        Me.txtU09.Properties.Appearance.Options.UseForeColor = True
        Me.txtU09.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU09.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU09.Properties.ReadOnly = True
        Me.txtU09.Size = New System.Drawing.Size(70, 24)
        Me.txtU09.StyleController = Me.LayoutControl1
        Me.txtU09.TabIndex = 16
        '
        'txtU08
        '
        Me.txtU08.Location = New System.Drawing.Point(1014, 300)
        Me.txtU08.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU08.MenuManager = Me.BarManager1
        Me.txtU08.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU08.Name = "txtU08"
        Me.txtU08.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU08.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU08.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtU08.Properties.Appearance.Options.UseBackColor = True
        Me.txtU08.Properties.Appearance.Options.UseFont = True
        Me.txtU08.Properties.Appearance.Options.UseForeColor = True
        Me.txtU08.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU08.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU08.Properties.ReadOnly = True
        Me.txtU08.Size = New System.Drawing.Size(70, 24)
        Me.txtU08.StyleController = Me.LayoutControl1
        Me.txtU08.TabIndex = 15
        '
        'txtU07
        '
        Me.txtU07.Location = New System.Drawing.Point(1014, 272)
        Me.txtU07.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU07.MenuManager = Me.BarManager1
        Me.txtU07.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU07.Name = "txtU07"
        Me.txtU07.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU07.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU07.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU07.Properties.Appearance.Options.UseBackColor = True
        Me.txtU07.Properties.Appearance.Options.UseFont = True
        Me.txtU07.Properties.Appearance.Options.UseForeColor = True
        Me.txtU07.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU07.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU07.Properties.ReadOnly = True
        Me.txtU07.Size = New System.Drawing.Size(70, 24)
        Me.txtU07.StyleController = Me.LayoutControl1
        Me.txtU07.TabIndex = 14
        '
        'txtU06
        '
        Me.txtU06.Location = New System.Drawing.Point(1014, 244)
        Me.txtU06.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU06.MenuManager = Me.BarManager1
        Me.txtU06.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU06.Name = "txtU06"
        Me.txtU06.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU06.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU06.Properties.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.txtU06.Properties.Appearance.Options.UseBackColor = True
        Me.txtU06.Properties.Appearance.Options.UseFont = True
        Me.txtU06.Properties.Appearance.Options.UseForeColor = True
        Me.txtU06.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU06.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU06.Properties.ReadOnly = True
        Me.txtU06.Size = New System.Drawing.Size(70, 24)
        Me.txtU06.StyleController = Me.LayoutControl1
        Me.txtU06.TabIndex = 13
        '
        'txtU05
        '
        Me.txtU05.Location = New System.Drawing.Point(1014, 216)
        Me.txtU05.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU05.MenuManager = Me.BarManager1
        Me.txtU05.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU05.Name = "txtU05"
        Me.txtU05.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU05.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU05.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtU05.Properties.Appearance.Options.UseBackColor = True
        Me.txtU05.Properties.Appearance.Options.UseFont = True
        Me.txtU05.Properties.Appearance.Options.UseForeColor = True
        Me.txtU05.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU05.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU05.Properties.ReadOnly = True
        Me.txtU05.Size = New System.Drawing.Size(70, 24)
        Me.txtU05.StyleController = Me.LayoutControl1
        Me.txtU05.TabIndex = 12
        '
        'txtU04
        '
        Me.txtU04.Location = New System.Drawing.Point(1014, 188)
        Me.txtU04.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU04.MenuManager = Me.BarManager1
        Me.txtU04.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU04.Name = "txtU04"
        Me.txtU04.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU04.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU04.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU04.Properties.Appearance.Options.UseBackColor = True
        Me.txtU04.Properties.Appearance.Options.UseFont = True
        Me.txtU04.Properties.Appearance.Options.UseForeColor = True
        Me.txtU04.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU04.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU04.Properties.ReadOnly = True
        Me.txtU04.Size = New System.Drawing.Size(70, 24)
        Me.txtU04.StyleController = Me.LayoutControl1
        Me.txtU04.TabIndex = 11
        '
        'txtU03
        '
        Me.txtU03.Location = New System.Drawing.Point(1014, 160)
        Me.txtU03.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU03.MenuManager = Me.BarManager1
        Me.txtU03.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU03.Name = "txtU03"
        Me.txtU03.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU03.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU03.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtU03.Properties.Appearance.Options.UseBackColor = True
        Me.txtU03.Properties.Appearance.Options.UseFont = True
        Me.txtU03.Properties.Appearance.Options.UseForeColor = True
        Me.txtU03.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU03.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU03.Properties.ReadOnly = True
        Me.txtU03.Size = New System.Drawing.Size(70, 24)
        Me.txtU03.StyleController = Me.LayoutControl1
        Me.txtU03.TabIndex = 10
        '
        'txtU02
        '
        Me.txtU02.Location = New System.Drawing.Point(1014, 132)
        Me.txtU02.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU02.MenuManager = Me.BarManager1
        Me.txtU02.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU02.Name = "txtU02"
        Me.txtU02.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU02.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU02.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtU02.Properties.Appearance.Options.UseBackColor = True
        Me.txtU02.Properties.Appearance.Options.UseFont = True
        Me.txtU02.Properties.Appearance.Options.UseForeColor = True
        Me.txtU02.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU02.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU02.Properties.ReadOnly = True
        Me.txtU02.Size = New System.Drawing.Size(70, 24)
        Me.txtU02.StyleController = Me.LayoutControl1
        Me.txtU02.TabIndex = 9
        '
        'txtU01
        '
        Me.txtU01.Location = New System.Drawing.Point(1014, 104)
        Me.txtU01.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtU01.MenuManager = Me.BarManager1
        Me.txtU01.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtU01.Name = "txtU01"
        Me.txtU01.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtU01.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtU01.Properties.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.txtU01.Properties.Appearance.Options.UseBackColor = True
        Me.txtU01.Properties.Appearance.Options.UseFont = True
        Me.txtU01.Properties.Appearance.Options.UseForeColor = True
        Me.txtU01.Properties.Appearance.Options.UseTextOptions = True
        Me.txtU01.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtU01.Properties.ReadOnly = True
        Me.txtU01.Size = New System.Drawing.Size(70, 24)
        Me.txtU01.StyleController = Me.LayoutControl1
        Me.txtU01.TabIndex = 8
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(389, 45)
        Me.txtNombreArticulo.MenuManager = Me.BarManager1
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtNombreArticulo.Properties.Appearance.Options.UseFont = True
        Me.txtNombreArticulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNombreArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(529, 24)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 7
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(1046, 45)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.MenuManager = Me.BarManager1
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtDeLinea.Properties.Appearance.Options.UseFont = True
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(50, 24)
        Me.txtDeLinea.StyleController = Me.LayoutControl1
        Me.txtDeLinea.TabIndex = 6
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(136, 45)
        Me.txtCodigoArticulo.MaximumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.MinimumSize = New System.Drawing.Size(125, 20)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(125, 24)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 5
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Light"
        Me.ChartControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChartControl1.BackImage.Image = CType(resources.GetObject("ChartControl1.BackImage.Image"), System.Drawing.Image)
        Me.ChartControl1.DataSource = Me.DsAnalisisVenta
        XyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.White
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.White
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Shadow.Size = 3
        Me.ChartControl1.Legend.Shadow.Visible = True
        Me.ChartControl1.Legend.UseCheckBoxes = True
        Me.ChartControl1.Location = New System.Drawing.Point(234, 73)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteBaseColorNumber = 5
        Me.ChartControl1.PaletteName = "Apex"
        Me.ChartControl1.RuntimeSelection = True
        Series1.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "U_01"
        Series1.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_01"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.View = SideBySideBarSeriesView1
        Series2.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Name = "U_02"
        Series2.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_02"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Series2.View = SideBySideBarSeriesView2
        Series3.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.Name = "U_03"
        Series3.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_03"
        SideBySideBarSeriesView3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.View = SideBySideBarSeriesView3
        Series4.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.Name = "U_04"
        Series4.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_04"
        SideBySideBarSeriesView4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series4.View = SideBySideBarSeriesView4
        Series5.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series5.Name = "U_05"
        Series5.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_05"
        SideBySideBarSeriesView5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series5.View = SideBySideBarSeriesView5
        Series6.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series6.Name = "U_06"
        Series6.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_06"
        SideBySideBarSeriesView6.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series6.View = SideBySideBarSeriesView6
        Series7.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series7.Name = "U_07"
        Series7.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_07"
        SideBySideBarSeriesView7.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Series7.View = SideBySideBarSeriesView7
        Series8.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series8.Name = "U_08"
        Series8.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_08"
        SideBySideBarSeriesView8.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series8.View = SideBySideBarSeriesView8
        Series9.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series9.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series9.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series9.Name = "U_09"
        Series9.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_09"
        SideBySideBarSeriesView9.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series9.View = SideBySideBarSeriesView9
        Series10.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series10.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series10.Name = "U_10"
        Series10.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_10"
        SideBySideBarSeriesView10.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series10.View = SideBySideBarSeriesView10
        Series11.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series11.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series11.Name = "U_11"
        Series11.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_11"
        SideBySideBarSeriesView11.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series11.View = SideBySideBarSeriesView11
        Series12.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series12.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series12.Name = "U_12"
        Series12.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_12"
        SideBySideBarSeriesView12.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Series12.View = SideBySideBarSeriesView12
        Series13.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series13.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series13.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series13.Name = "U_13"
        Series13.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_13"
        SideBySideBarSeriesView13.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series13.View = SideBySideBarSeriesView13
        Series14.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series14.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series14.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series14.Name = "U_14"
        Series14.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_14"
        SideBySideBarSeriesView14.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series14.View = SideBySideBarSeriesView14
        Series15.ArgumentDataMember = "dsdtAnalisisVenta.ItemCode"
        Series15.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series15.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series15.Name = "U_15"
        Series15.ValueDataMembersSerializable = "dsdtAnalisisVenta.U_15"
        SideBySideBarSeriesView15.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series15.View = SideBySideBarSeriesView15
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4, Series5, Series6, Series7, Series8, Series9, Series10, Series11, Series12, Series13, Series14, Series15}
        Me.ChartControl1.SideBySideBarDistanceFixed = 10
        Me.ChartControl1.Size = New System.Drawing.Size(640, 537)
        Me.ChartControl1.TabIndex = 4
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        ChartTitle1.Text = "Analisis de Venta de los ultimos 15 Meses"
        ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartTitle1.Visible = False
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'lycPrincipal
        '
        Me.lycPrincipal.CustomizationFormText = "lycPrincipal"
        Me.lycPrincipal.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lycPrincipal.GroupBordersVisible = False
        Me.lycPrincipal.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlGroup6, Me.LayoutControlGroup3, Me.EmptySpaceItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlItem6})
        Me.lycPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.lycPrincipal.Name = "lycPrincipal"
        Me.lycPrincipal.Size = New System.Drawing.Size(1108, 622)
        Me.lycPrincipal.Text = "lycPrincipal"
        Me.lycPrincipal.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(222, 61)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(644, 541)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem3.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(253, 28)
        Me.LayoutControlItem3.Text = "Codigo Articulo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.txtDeLinea
        Me.LayoutControlItem4.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(910, 33)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(178, 28)
        Me.LayoutControlItem4.Text = "De Linea?"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.txtNombreArticulo
        Me.LayoutControlItem5.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(253, 33)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(657, 28)
        Me.LayoutControlItem5.Text = "Nombre Articulo"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "Proximos 3 meses segun año anterior"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem31, Me.LayoutControlItem32})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(222, 91)
        Me.LayoutControlGroup6.Text = "Minimo y maximo segun año Anterior"
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem31.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem31.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem31.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem31.Control = Me.txt3MesesSuma
        Me.LayoutControlItem31.CustomizationFormText = "Proy. 3 Meses (sum)"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem31.Text = "Proyeccion Maximo"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem32.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem32.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem32.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem32.Control = Me.txt3MesesPromedio
        Me.LayoutControlItem32.CustomizationFormText = "Proy. 3 Meses (Pro)"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem32.Text = "Proyeccion Minimo"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Datos de Stock"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem22})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 243)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(222, 115)
        Me.LayoutControlGroup3.Text = "Datos de Stock Actual"
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem23.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem23.Control = Me.txtMinimo
        Me.LayoutControlItem23.CustomizationFormText = "Minimo"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem23.Text = "Minimo"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem24.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem24.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem24.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem24.Control = Me.txtMaximo
        Me.LayoutControlItem24.CustomizationFormText = "Maximo"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem24.Text = "Maximo"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem22.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem22.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem22.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem22.Control = Me.txtStock
        Me.LayoutControlItem22.CustomizationFormText = "Stock"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem22.Text = "Stock"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(121, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 449)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(222, 153)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lyc01, Me.lyc02, Me.lyc03, Me.lyc04, Me.lyc05, Me.lyc06, Me.lyc07, Me.lyc08, Me.lyc09, Me.lyc10, Me.lyc11, Me.lyc12, Me.lyc13, Me.lyc14, Me.LayoutControlItem21, Me.lyc15, Me.LayoutControlItem25, Me.LayoutControlItem26})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(866, 61)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(222, 541)
        Me.LayoutControlGroup2.Text = "Venta Mensual en Unidades"
        '
        'lyc01
        '
        Me.lyc01.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc01.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc01.Control = Me.txtU01
        Me.lyc01.CustomizationFormText = "U_01"
        Me.lyc01.Location = New System.Drawing.Point(0, 0)
        Me.lyc01.Name = "lyc01"
        Me.lyc01.Size = New System.Drawing.Size(198, 28)
        Me.lyc01.Text = "U_01"
        Me.lyc01.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc02
        '
        Me.lyc02.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc02.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc02.Control = Me.txtU02
        Me.lyc02.CustomizationFormText = "U_02"
        Me.lyc02.Location = New System.Drawing.Point(0, 28)
        Me.lyc02.Name = "lyc02"
        Me.lyc02.Size = New System.Drawing.Size(198, 28)
        Me.lyc02.Text = "U_02"
        Me.lyc02.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc03
        '
        Me.lyc03.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc03.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc03.Control = Me.txtU03
        Me.lyc03.CustomizationFormText = "U_03"
        Me.lyc03.Location = New System.Drawing.Point(0, 56)
        Me.lyc03.Name = "lyc03"
        Me.lyc03.Size = New System.Drawing.Size(198, 28)
        Me.lyc03.Text = "U_03"
        Me.lyc03.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc04
        '
        Me.lyc04.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc04.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc04.Control = Me.txtU04
        Me.lyc04.CustomizationFormText = "U_04"
        Me.lyc04.Location = New System.Drawing.Point(0, 84)
        Me.lyc04.Name = "lyc04"
        Me.lyc04.Size = New System.Drawing.Size(198, 28)
        Me.lyc04.Text = "U_04"
        Me.lyc04.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc05
        '
        Me.lyc05.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc05.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc05.Control = Me.txtU05
        Me.lyc05.CustomizationFormText = "U_05"
        Me.lyc05.Location = New System.Drawing.Point(0, 112)
        Me.lyc05.Name = "lyc05"
        Me.lyc05.Size = New System.Drawing.Size(198, 28)
        Me.lyc05.Text = "U_05"
        Me.lyc05.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc06
        '
        Me.lyc06.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc06.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc06.Control = Me.txtU06
        Me.lyc06.CustomizationFormText = "U_06"
        Me.lyc06.Location = New System.Drawing.Point(0, 140)
        Me.lyc06.Name = "lyc06"
        Me.lyc06.Size = New System.Drawing.Size(198, 28)
        Me.lyc06.Text = "U_06"
        Me.lyc06.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc07
        '
        Me.lyc07.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc07.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc07.Control = Me.txtU07
        Me.lyc07.CustomizationFormText = "U_07"
        Me.lyc07.Location = New System.Drawing.Point(0, 168)
        Me.lyc07.Name = "lyc07"
        Me.lyc07.Size = New System.Drawing.Size(198, 28)
        Me.lyc07.Text = "U_07"
        Me.lyc07.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc08
        '
        Me.lyc08.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc08.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc08.Control = Me.txtU08
        Me.lyc08.CustomizationFormText = "U_08"
        Me.lyc08.Location = New System.Drawing.Point(0, 196)
        Me.lyc08.Name = "lyc08"
        Me.lyc08.Size = New System.Drawing.Size(198, 28)
        Me.lyc08.Text = "U_08"
        Me.lyc08.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc09
        '
        Me.lyc09.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc09.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc09.Control = Me.txtU09
        Me.lyc09.CustomizationFormText = "U_09"
        Me.lyc09.Location = New System.Drawing.Point(0, 224)
        Me.lyc09.Name = "lyc09"
        Me.lyc09.Size = New System.Drawing.Size(198, 28)
        Me.lyc09.Text = "U_09"
        Me.lyc09.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc10
        '
        Me.lyc10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc10.Control = Me.txtU10
        Me.lyc10.CustomizationFormText = "U_10"
        Me.lyc10.Location = New System.Drawing.Point(0, 252)
        Me.lyc10.Name = "lyc10"
        Me.lyc10.Size = New System.Drawing.Size(198, 28)
        Me.lyc10.Text = "U_10"
        Me.lyc10.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc11
        '
        Me.lyc11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc11.Control = Me.txtU11
        Me.lyc11.CustomizationFormText = "U_11"
        Me.lyc11.Location = New System.Drawing.Point(0, 280)
        Me.lyc11.Name = "lyc11"
        Me.lyc11.Size = New System.Drawing.Size(198, 28)
        Me.lyc11.Text = "U_11"
        Me.lyc11.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc12
        '
        Me.lyc12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc12.Control = Me.txtU12
        Me.lyc12.CustomizationFormText = "U_12"
        Me.lyc12.Location = New System.Drawing.Point(0, 308)
        Me.lyc12.Name = "lyc12"
        Me.lyc12.Size = New System.Drawing.Size(198, 28)
        Me.lyc12.Text = "U_12"
        Me.lyc12.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc13
        '
        Me.lyc13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc13.Control = Me.txtU13
        Me.lyc13.CustomizationFormText = "U_13"
        Me.lyc13.Location = New System.Drawing.Point(0, 336)
        Me.lyc13.Name = "lyc13"
        Me.lyc13.Size = New System.Drawing.Size(198, 28)
        Me.lyc13.Text = "U_13"
        Me.lyc13.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc14
        '
        Me.lyc14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc14.Control = Me.txtU14
        Me.lyc14.CustomizationFormText = "U_14"
        Me.lyc14.Location = New System.Drawing.Point(0, 364)
        Me.lyc14.Name = "lyc14"
        Me.lyc14.Size = New System.Drawing.Size(198, 28)
        Me.lyc14.Text = "U_14"
        Me.lyc14.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem21.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem21.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem21.Control = Me.txtTotalUnidadesVendidas
        Me.LayoutControlItem21.CustomizationFormText = "Total Vendido"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 420)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem21.Text = "Total Vendido"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(121, 13)
        '
        'lyc15
        '
        Me.lyc15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lyc15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lyc15.Control = Me.txtU15
        Me.lyc15.CustomizationFormText = "U_15"
        Me.lyc15.Location = New System.Drawing.Point(0, 392)
        Me.lyc15.Name = "lyc15"
        Me.lyc15.Size = New System.Drawing.Size(198, 28)
        Me.lyc15.Text = "U_15"
        Me.lyc15.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem25.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem25.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem25.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem25.Control = Me.txtMaximoUnidadesVendidas
        Me.LayoutControlItem25.CustomizationFormText = "Maximo UVM"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 444)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem25.Text = "Maximo UVM"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem26.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem26.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem26.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem26.Control = Me.txtMesesConMovimiento
        Me.LayoutControlItem26.CustomizationFormText = "Meses con MOV"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 468)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(198, 30)
        Me.LayoutControlItem26.Text = "Meses con MOV"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Promedio de Venta"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem27, Me.LayoutControlItem28})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 61)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(222, 91)
        Me.LayoutControlGroup4.Text = "Promedio de Venta"
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem27.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem27.Control = Me.txtPromedioCompuesto
        Me.LayoutControlItem27.CustomizationFormText = "Promedio Compuesto"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem27.Text = "Promedio Compuesto"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem28.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem28.Control = Me.txtPromedioSimple
        Me.LayoutControlItem28.CustomizationFormText = "Promedio Simple"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem28.Text = "Promedio Simple"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Meses de Inventario Disponible"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem29, Me.LayoutControlItem30})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 358)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(222, 91)
        Me.LayoutControlGroup5.Text = "Meses de Inventario Disponible"
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem29.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem29.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem29.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem29.Control = Me.txtMesesCompuesto
        Me.LayoutControlItem29.CustomizationFormText = "Inv. Prom. Comp"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem29.Text = "Meses Compuesto"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem30.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem30.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem30.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem30.Control = Me.txtMesesSimple
        Me.LayoutControlItem30.CustomizationFormText = "Inv. Prom. Simple"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem30.Text = "Meses Simple"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(121, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lblTitulo
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1088, 33)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'DsdtAnalisisVentaBindingSource
        '
        Me.DsdtAnalisisVentaBindingSource.DataMember = "dsdtAnalisisVenta"
        Me.DsdtAnalisisVentaBindingSource.DataSource = Me.DsAnalisisVenta
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager2.Controller = Me.BarAndDockingController1
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnCerrar})
        Me.BarManager2.MaxItemId = 1
        Me.BarManager2.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCerrar
        '
        Me.barbtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnCerrar.Caption = "Cerrar"
        Me.barbtnCerrar.Glyph = CType(resources.GetObject("barbtnCerrar.Glyph"), System.Drawing.Image)
        Me.barbtnCerrar.Id = 0
        Me.barbtnCerrar.Name = "barbtnCerrar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1108, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 622)
        Me.BarDockControl2.Size = New System.Drawing.Size(1108, 43)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 622)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1108, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 622)
        '
        'frmTemporal_AnalisisVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 665)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_AnalisisVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis de Venta"
        CType(Me.DsAnalisisVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txt3MesesPromedio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3MesesSuma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesesSimple.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesesCompuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPromedioSimple.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPromedioCompuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesesConMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaximoUnidadesVendidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalUnidadesVendidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU09.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU08.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU07.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU06.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU05.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU04.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU03.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU02.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtU01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyc15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsdtAnalisisVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents DsAnalisisVenta As waProduccion_Pedidos.dsAnalisisVenta
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lycPrincipal As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txt3MesesPromedio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt3MesesSuma As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesesSimple As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesesCompuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPromedioSimple As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPromedioCompuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesesConMovimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaximoUnidadesVendidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalUnidadesVendidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU09 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU08 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU07 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU06 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU05 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU04 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU03 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU02 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtU01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lyc01 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc02 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc03 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc04 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc05 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc06 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc07 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc08 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc09 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyc15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsdtAnalisisVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
