<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenEnsamble
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenEnsamble))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.grdviewCP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrigenAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueDestino = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoCP = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMetasa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPradera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduccion3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinoCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdIngresoOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.DsIngresoOrden1 = New waProduccion_Pedidos.dsIngresoOrden()
        Me.grdviewArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadEnsamble = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueColores = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueGrupoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueCodigoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumOrdenVenta = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueNumCampana = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCampana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rslueOrigenAR = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbbOrigenAR = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.grdviewCC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUM2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.grdviewCP2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrigenAR4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCP4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCP4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUM4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacen4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMetasa4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPradera4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduccion4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprometido4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducir4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinoCP4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComentario14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.mmeComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnEnsamble = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnProduccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaRol = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaCampana = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnDeudaProyeccion = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAnalsisVenta = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnSAP = New DevExpress.XtraBars.BarButtonItem()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtDeLinea = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSugerido = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaximo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinimo = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisponible = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalEgresos = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalIngresos = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeudaProyeccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeudaCampana = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeudaRol = New DevExpress.XtraEditors.TextEdit()
        Me.txtProduccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtEnsamble = New DevExpress.XtraEditors.TextEdit()
        Me.txtStock = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lygIngresos = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycStock = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycEnsamble = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycProduccion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycTotalPositivo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lygEgresos = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycDeudaRol = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDeudaCampana = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDeudaProyeccion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycTotalNegativo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lygSugerido = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycDisponible = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycMinimo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycMaximo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycSugerido = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lycComentarios = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ssmEsperar = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.waProduccion_Pedidos.splEsperar), True, True)
        CType(Me.grdviewCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdIngresoOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresoOrden1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rslueOrigenAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbOrigenAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSugerido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalEgresos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalIngresos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeudaProyeccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeudaCampana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeudaRol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnsamble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lygIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycEnsamble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTotalPositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lygEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDeudaRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDeudaCampana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDeudaProyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTotalNegativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lygSugerido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycSugerido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdviewCP
        '
        Me.grdviewCP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCP.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCP.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCP.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCP.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewCP.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCP.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grdviewCP.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.grdviewCP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCP.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCP.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCP.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCP.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewCP.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCP.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grdviewCP.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCP.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.grdviewCP.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCP.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewCP.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCP.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP.Appearance.Preview.Options.UseFont = True
        Me.grdviewCP.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCP.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCP.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCP.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdviewCP.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCP.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewCP.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCP.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.grdviewCP.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrigenAR, Me.colCodigoCP, Me.colNombreCP, Me.colUM, Me.colCantidad, Me.colAlmacen, Me.colMetasa, Me.colPradera, Me.colProduccion3, Me.colComprometido3, Me.colProducir, Me.colDestinoCP, Me.colComentarios1})
        Me.grdviewCP.GridControl = Me.grdIngresoOrdenes
        Me.grdviewCP.Name = "grdviewCP"
        Me.grdviewCP.NewItemRowText = "Ingrese Nuevo Componente"
        Me.grdviewCP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdviewCP.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.grdviewCP.OptionsDetail.EnableDetailToolTip = True
        Me.grdviewCP.OptionsDetail.ShowDetailTabs = False
        Me.grdviewCP.OptionsView.ColumnAutoWidth = False
        Me.grdviewCP.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCP.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grdviewCP.OptionsView.ShowFooter = True
        Me.grdviewCP.OptionsView.ShowGroupPanel = False
        Me.grdviewCP.PaintStyleName = "Web"
        '
        'colOrigenAR
        '
        Me.colOrigenAR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.colOrigenAR.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colOrigenAR.AppearanceCell.Options.UseBackColor = True
        Me.colOrigenAR.AppearanceCell.Options.UseForeColor = True
        Me.colOrigenAR.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigenAR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigenAR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigenAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colOrigenAR.AppearanceHeader.Options.UseFont = True
        Me.colOrigenAR.AppearanceHeader.Options.UseForeColor = True
        Me.colOrigenAR.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigenAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigenAR.ColumnEdit = Me.rslueDestino
        Me.colOrigenAR.FieldName = "OrigenAR"
        Me.colOrigenAR.Name = "colOrigenAR"
        Me.colOrigenAR.Visible = True
        Me.colOrigenAR.VisibleIndex = 0
        '
        'rslueDestino
        '
        Me.rslueDestino.AutoHeight = False
        Me.rslueDestino.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueDestino.Name = "rslueDestino"
        Me.rslueDestino.NullText = ""
        Me.rslueDestino.ShowClearButton = False
        Me.rslueDestino.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCP
        '
        Me.colCodigoCP.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colCodigoCP.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoCP.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoCP.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCP.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCP.ColumnEdit = Me.rslueCodigoCP
        Me.colCodigoCP.FieldName = "CodigoCP"
        Me.colCodigoCP.Name = "colCodigoCP"
        Me.colCodigoCP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colCodigoCP.Visible = True
        Me.colCodigoCP.VisibleIndex = 1
        Me.colCodigoCP.Width = 150
        '
        'rslueCodigoCP
        '
        Me.rslueCodigoCP.AutoHeight = False
        Me.rslueCodigoCP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoCP.Name = "rslueCodigoCP"
        Me.rslueCodigoCP.NullText = ""
        Me.rslueCodigoCP.ShowClearButton = False
        Me.rslueCodigoCP.View = Me.GridView8
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colNombreCP
        '
        Me.colNombreCP.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colNombreCP.AppearanceCell.Options.UseBackColor = True
        Me.colNombreCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colNombreCP.AppearanceHeader.Options.UseFont = True
        Me.colNombreCP.AppearanceHeader.Options.UseForeColor = True
        Me.colNombreCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCP.FieldName = "NombreCP"
        Me.colNombreCP.Name = "colNombreCP"
        Me.colNombreCP.OptionsColumn.AllowEdit = False
        Me.colNombreCP.OptionsColumn.AllowFocus = False
        Me.colNombreCP.Visible = True
        Me.colNombreCP.VisibleIndex = 2
        Me.colNombreCP.Width = 400
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceCell.Options.UseFont = True
        Me.colUM.AppearanceCell.Options.UseForeColor = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.AppearanceHeader.Options.UseForeColor = True
        Me.colUM.AppearanceHeader.Options.UseTextOptions = True
        Me.colUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.FieldName = "U/M"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.AllowEdit = False
        Me.colUM.OptionsColumn.AllowFocus = False
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 3
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCantidad.AppearanceCell.Options.UseFont = True
        Me.colCantidad.AppearanceCell.Options.UseForeColor = True
        Me.colCantidad.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseForeColor = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 7
        '
        'colAlmacen
        '
        Me.colAlmacen.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlmacen.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colAlmacen.AppearanceCell.Options.UseFont = True
        Me.colAlmacen.AppearanceCell.Options.UseForeColor = True
        Me.colAlmacen.AppearanceCell.Options.UseTextOptions = True
        Me.colAlmacen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlmacen.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colAlmacen.AppearanceHeader.Options.UseFont = True
        Me.colAlmacen.AppearanceHeader.Options.UseForeColor = True
        Me.colAlmacen.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlmacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen.FieldName = "Almacen"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.OptionsColumn.AllowEdit = False
        Me.colAlmacen.OptionsColumn.AllowFocus = False
        Me.colAlmacen.Visible = True
        Me.colAlmacen.VisibleIndex = 4
        '
        'colMetasa
        '
        Me.colMetasa.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMetasa.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colMetasa.AppearanceCell.Options.UseFont = True
        Me.colMetasa.AppearanceCell.Options.UseForeColor = True
        Me.colMetasa.AppearanceCell.Options.UseTextOptions = True
        Me.colMetasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMetasa.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colMetasa.AppearanceHeader.Options.UseFont = True
        Me.colMetasa.AppearanceHeader.Options.UseForeColor = True
        Me.colMetasa.AppearanceHeader.Options.UseTextOptions = True
        Me.colMetasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa.FieldName = "Metasa"
        Me.colMetasa.Name = "colMetasa"
        Me.colMetasa.OptionsColumn.AllowEdit = False
        Me.colMetasa.OptionsColumn.AllowFocus = False
        Me.colMetasa.Visible = True
        Me.colMetasa.VisibleIndex = 5
        '
        'colPradera
        '
        Me.colPradera.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPradera.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPradera.AppearanceCell.Options.UseFont = True
        Me.colPradera.AppearanceCell.Options.UseForeColor = True
        Me.colPradera.AppearanceCell.Options.UseTextOptions = True
        Me.colPradera.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPradera.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPradera.AppearanceHeader.Options.UseFont = True
        Me.colPradera.AppearanceHeader.Options.UseForeColor = True
        Me.colPradera.AppearanceHeader.Options.UseTextOptions = True
        Me.colPradera.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera.FieldName = "Pradera"
        Me.colPradera.Name = "colPradera"
        Me.colPradera.OptionsColumn.AllowEdit = False
        Me.colPradera.OptionsColumn.AllowFocus = False
        Me.colPradera.Visible = True
        Me.colPradera.VisibleIndex = 6
        '
        'colProduccion3
        '
        Me.colProduccion3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduccion3.AppearanceCell.Options.UseFont = True
        Me.colProduccion3.AppearanceCell.Options.UseTextOptions = True
        Me.colProduccion3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion3.FieldName = "Produccion"
        Me.colProduccion3.Name = "colProduccion3"
        Me.colProduccion3.OptionsColumn.AllowEdit = False
        Me.colProduccion3.OptionsColumn.AllowFocus = False
        Me.colProduccion3.Visible = True
        Me.colProduccion3.VisibleIndex = 8
        Me.colProduccion3.Width = 80
        '
        'colComprometido3
        '
        Me.colComprometido3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComprometido3.AppearanceCell.Options.UseFont = True
        Me.colComprometido3.AppearanceCell.Options.UseTextOptions = True
        Me.colComprometido3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido3.FieldName = "Comprometido"
        Me.colComprometido3.Name = "colComprometido3"
        Me.colComprometido3.OptionsColumn.AllowEdit = False
        Me.colComprometido3.OptionsColumn.AllowFocus = False
        Me.colComprometido3.Visible = True
        Me.colComprometido3.VisibleIndex = 9
        Me.colComprometido3.Width = 80
        '
        'colProducir
        '
        Me.colProducir.AppearanceCell.Options.UseTextOptions = True
        Me.colProducir.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProducir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProducir.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colProducir.AppearanceHeader.Options.UseFont = True
        Me.colProducir.AppearanceHeader.Options.UseForeColor = True
        Me.colProducir.AppearanceHeader.Options.UseTextOptions = True
        Me.colProducir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProducir.DisplayFormat.FormatString = "n2"
        Me.colProducir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProducir.FieldName = "Producir"
        Me.colProducir.GroupFormat.FormatString = "n2"
        Me.colProducir.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProducir.Name = "colProducir"
        Me.colProducir.Visible = True
        Me.colProducir.VisibleIndex = 10
        '
        'colDestinoCP
        '
        Me.colDestinoCP.AppearanceCell.Options.UseTextOptions = True
        Me.colDestinoCP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestinoCP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestinoCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colDestinoCP.AppearanceHeader.Options.UseFont = True
        Me.colDestinoCP.AppearanceHeader.Options.UseForeColor = True
        Me.colDestinoCP.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestinoCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestinoCP.ColumnEdit = Me.rslueDestino
        Me.colDestinoCP.FieldName = "DestinoCP"
        Me.colDestinoCP.Name = "colDestinoCP"
        Me.colDestinoCP.Visible = True
        Me.colDestinoCP.VisibleIndex = 11
        Me.colDestinoCP.Width = 80
        '
        'colComentarios1
        '
        Me.colComentarios1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colComentarios1.AppearanceHeader.Options.UseFont = True
        Me.colComentarios1.AppearanceHeader.Options.UseForeColor = True
        Me.colComentarios1.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios1.FieldName = "Comentarios"
        Me.colComentarios1.Name = "colComentarios1"
        Me.colComentarios1.Visible = True
        Me.colComentarios1.VisibleIndex = 12
        Me.colComentarios1.Width = 296
        '
        'grdIngresoOrdenes
        '
        Me.grdIngresoOrdenes.DataMember = "dsdtIngresoOrdenes"
        Me.grdIngresoOrdenes.DataSource = Me.DsIngresoOrden1
        GridLevelNode1.LevelTemplate = Me.grdviewCP
        GridLevelNode2.LevelTemplate = Me.grdviewCP2
        GridLevelNode2.RelationName = "ArticulosCP2"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "ArticulosCP"
        Me.grdIngresoOrdenes.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdIngresoOrdenes.Location = New System.Drawing.Point(12, 167)
        Me.grdIngresoOrdenes.MainView = Me.grdviewArticulos
        Me.grdIngresoOrdenes.Name = "grdIngresoOrdenes"
        Me.grdIngresoOrdenes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rslueOrigen, Me.rslueDestino, Me.rslueColores, Me.rslueGrupoCliente, Me.rslueCodigoCliente, Me.rslueNumOrdenVenta, Me.rslueNumCampana, Me.rslueCodigoCP, Me.rslueOrigenAR, Me.cbbOrigenAR})
        Me.grdIngresoOrdenes.Size = New System.Drawing.Size(1623, 541)
        Me.grdIngresoOrdenes.TabIndex = 19
        Me.grdIngresoOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewArticulos, Me.grdviewCC, Me.GridView1, Me.CardView1, Me.grdviewCP2, Me.grdviewCP})
        '
        'DsIngresoOrden1
        '
        Me.DsIngresoOrden1.DataSetName = "dsIngresoOrden"
        Me.DsIngresoOrden1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewArticulos
        '
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.grdviewArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewArticulos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grdviewArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.grdviewArticulos.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseFont = True
        Me.grdviewArticulos.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.grdviewArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewArticulos.Appearance.Row.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.Row.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grdviewArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.grdviewArticulos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewArticulos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewArticulos.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.grdviewArticulos.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCantidadEnsamble, Me.colOrigen, Me.colDestino, Me.colColor, Me.colGrupoCliente, Me.colCodigoCliente, Me.colNombreCliente, Me.colNumOrden, Me.colNumCampana, Me.colNombreCampana, Me.colFechaEntrega, Me.colComentarios})
        Me.grdviewArticulos.GridControl = Me.grdIngresoOrdenes
        Me.grdviewArticulos.Name = "grdviewArticulos"
        Me.grdviewArticulos.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.grdviewArticulos.OptionsDetail.ShowDetailTabs = False
        Me.grdviewArticulos.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.grdviewArticulos.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewArticulos.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewArticulos.OptionsView.ShowGroupPanel = False
        Me.grdviewArticulos.PaintStyleName = "Web"
        '
        'colId
        '
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.OptionsColumn.AllowFocus = False
        Me.colId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colId.OptionsColumn.AllowIncrementalSearch = False
        Me.colId.OptionsColumn.AllowMove = False
        Me.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.OptionsFilter.AllowFilter = False
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 40
        '
        'colCantidadEnsamble
        '
        Me.colCantidadEnsamble.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidadEnsamble.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidadEnsamble.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidadEnsamble.AppearanceHeader.Options.UseFont = True
        Me.colCantidadEnsamble.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidadEnsamble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidadEnsamble.Caption = "Cantidad P."
        Me.colCantidadEnsamble.DisplayFormat.FormatString = "n1"
        Me.colCantidadEnsamble.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidadEnsamble.FieldName = "CantidadEnsamble"
        Me.colCantidadEnsamble.Name = "colCantidadEnsamble"
        Me.colCantidadEnsamble.OptionsColumn.AllowIncrementalSearch = False
        Me.colCantidadEnsamble.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadEnsamble.OptionsFilter.AllowFilter = False
        Me.colCantidadEnsamble.Visible = True
        Me.colCantidadEnsamble.VisibleIndex = 1
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.ColumnEdit = Me.rslueOrigen
        Me.colOrigen.FieldName = "Origen"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.OptionsColumn.AllowIncrementalSearch = False
        Me.colOrigen.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colOrigen.OptionsFilter.AllowFilter = False
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 2
        Me.colOrigen.Width = 92
        '
        'rslueOrigen
        '
        Me.rslueOrigen.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.rslueOrigen.AutoHeight = False
        Me.rslueOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigen.Name = "rslueOrigen"
        Me.rslueOrigen.NullText = ""
        Me.rslueOrigen.NullValuePromptShowForEmptyValue = True
        Me.rslueOrigen.ShowClearButton = False
        Me.rslueOrigen.View = Me.GridView10
        '
        'GridView10
        '
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colDestino
        '
        Me.colDestino.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestino.AppearanceHeader.Options.UseFont = True
        Me.colDestino.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestino.ColumnEdit = Me.rslueDestino
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.OptionsColumn.AllowIncrementalSearch = False
        Me.colDestino.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDestino.OptionsFilter.AllowFilter = False
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 3
        Me.colDestino.Width = 91
        '
        'colColor
        '
        Me.colColor.AppearanceCell.Options.UseTextOptions = True
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colColor.AppearanceHeader.Options.UseFont = True
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.ColumnEdit = Me.rslueColores
        Me.colColor.CustomizationCaption = " "
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.AllowIncrementalSearch = False
        Me.colColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colColor.OptionsFilter.AllowFilter = False
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 4
        Me.colColor.Width = 67
        '
        'rslueColores
        '
        Me.rslueColores.AutoHeight = False
        Me.rslueColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueColores.Name = "rslueColores"
        Me.rslueColores.NullText = ""
        Me.rslueColores.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupoCliente.AppearanceHeader.Options.UseFont = True
        Me.colGrupoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupoCliente.ColumnEdit = Me.rslueGrupoCliente
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        Me.colGrupoCliente.OptionsColumn.AllowIncrementalSearch = False
        Me.colGrupoCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colGrupoCliente.OptionsFilter.AllowFilter = False
        Me.colGrupoCliente.Visible = True
        Me.colGrupoCliente.VisibleIndex = 5
        Me.colGrupoCliente.Width = 113
        '
        'rslueGrupoCliente
        '
        Me.rslueGrupoCliente.AutoHeight = False
        Me.rslueGrupoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueGrupoCliente.Name = "rslueGrupoCliente"
        Me.rslueGrupoCliente.NullText = ""
        Me.rslueGrupoCliente.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCliente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCliente.Caption = "Cod Cliente"
        Me.colCodigoCliente.ColumnEdit = Me.rslueCodigoCliente
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.AllowIncrementalSearch = False
        Me.colCodigoCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoCliente.OptionsFilter.AllowFilter = False
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 6
        Me.colCodigoCliente.Width = 71
        '
        'rslueCodigoCliente
        '
        Me.rslueCodigoCliente.AutoHeight = False
        Me.rslueCodigoCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueCodigoCliente.Name = "rslueCodigoCliente"
        Me.rslueCodigoCliente.NullText = ""
        Me.rslueCodigoCliente.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.colNombreCliente.AppearanceCell.Options.UseForeColor = True
        Me.colNombreCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCliente.AppearanceHeader.Options.UseFont = True
        Me.colNombreCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.OptionsColumn.AllowEdit = False
        Me.colNombreCliente.OptionsColumn.AllowIncrementalSearch = False
        Me.colNombreCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombreCliente.OptionsColumn.ReadOnly = True
        Me.colNombreCliente.OptionsFilter.AllowFilter = False
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 7
        Me.colNombreCliente.Width = 182
        '
        'colNumOrden
        '
        Me.colNumOrden.AppearanceCell.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumOrden.AppearanceHeader.Options.UseFont = True
        Me.colNumOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumOrden.ColumnEdit = Me.rslueNumOrdenVenta
        Me.colNumOrden.FieldName = "NumOrden"
        Me.colNumOrden.Name = "colNumOrden"
        Me.colNumOrden.OptionsColumn.AllowIncrementalSearch = False
        Me.colNumOrden.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumOrden.OptionsFilter.AllowFilter = False
        Me.colNumOrden.Visible = True
        Me.colNumOrden.VisibleIndex = 8
        Me.colNumOrden.Width = 71
        '
        'rslueNumOrdenVenta
        '
        Me.rslueNumOrdenVenta.AutoHeight = False
        Me.rslueNumOrdenVenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumOrdenVenta.Name = "rslueNumOrdenVenta"
        Me.rslueNumOrdenVenta.NullText = ""
        Me.rslueNumOrdenVenta.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colNumCampana
        '
        Me.colNumCampana.AppearanceCell.Options.UseTextOptions = True
        Me.colNumCampana.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumCampana.AppearanceHeader.Options.UseFont = True
        Me.colNumCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCampana.ColumnEdit = Me.rslueNumCampana
        Me.colNumCampana.FieldName = "NumCampana"
        Me.colNumCampana.Name = "colNumCampana"
        Me.colNumCampana.OptionsColumn.AllowIncrementalSearch = False
        Me.colNumCampana.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNumCampana.OptionsFilter.AllowFilter = False
        Me.colNumCampana.Visible = True
        Me.colNumCampana.VisibleIndex = 9
        Me.colNumCampana.Width = 71
        '
        'rslueNumCampana
        '
        Me.rslueNumCampana.AutoHeight = False
        Me.rslueNumCampana.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueNumCampana.Name = "rslueNumCampana"
        Me.rslueNumCampana.NullText = ""
        Me.rslueNumCampana.View = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colNombreCampana
        '
        Me.colNombreCampana.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.colNombreCampana.AppearanceCell.Options.UseForeColor = True
        Me.colNombreCampana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCampana.AppearanceHeader.Options.UseFont = True
        Me.colNombreCampana.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCampana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCampana.FieldName = "NombreCampana"
        Me.colNombreCampana.Name = "colNombreCampana"
        Me.colNombreCampana.OptionsColumn.AllowEdit = False
        Me.colNombreCampana.OptionsColumn.AllowIncrementalSearch = False
        Me.colNombreCampana.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombreCampana.OptionsColumn.ReadOnly = True
        Me.colNombreCampana.OptionsFilter.AllowFilter = False
        Me.colNombreCampana.Visible = True
        Me.colNombreCampana.VisibleIndex = 10
        Me.colNombreCampana.Width = 182
        '
        'colFechaEntrega
        '
        Me.colFechaEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFechaEntrega.AppearanceHeader.Options.UseFont = True
        Me.colFechaEntrega.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaEntrega.Caption = "Entrega"
        Me.colFechaEntrega.FieldName = "FechaEntrega"
        Me.colFechaEntrega.Name = "colFechaEntrega"
        Me.colFechaEntrega.OptionsColumn.AllowIncrementalSearch = False
        Me.colFechaEntrega.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFechaEntrega.OptionsFilter.AllowFilter = False
        Me.colFechaEntrega.Visible = True
        Me.colFechaEntrega.VisibleIndex = 11
        Me.colFechaEntrega.Width = 67
        '
        'colComentarios
        '
        Me.colComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComentarios.AppearanceHeader.Options.UseFont = True
        Me.colComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.AllowIncrementalSearch = False
        Me.colComentarios.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComentarios.OptionsFilter.AllowFilter = False
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 12
        Me.colComentarios.Width = 193
        '
        'rslueOrigenAR
        '
        Me.rslueOrigenAR.AutoHeight = False
        Me.rslueOrigenAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rslueOrigenAR.Name = "rslueOrigenAR"
        Me.rslueOrigenAR.NullText = ""
        Me.rslueOrigenAR.ShowClearButton = False
        Me.rslueOrigenAR.View = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'cbbOrigenAR
        '
        Me.cbbOrigenAR.AutoHeight = False
        Me.cbbOrigenAR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbOrigenAR.Name = "cbbOrigenAR"
        '
        'grdviewCC
        '
        Me.grdviewCC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoCC, Me.colNombreCC, Me.colStock, Me.colUM2, Me.colCantidad2})
        Me.grdviewCC.GridControl = Me.grdIngresoOrdenes
        Me.grdviewCC.Name = "grdviewCC"
        Me.grdviewCC.OptionsView.ColumnAutoWidth = False
        '
        'colCodigoCC
        '
        Me.colCodigoCC.FieldName = "CodigoCC"
        Me.colCodigoCC.Name = "colCodigoCC"
        Me.colCodigoCC.Visible = True
        Me.colCodigoCC.VisibleIndex = 0
        Me.colCodigoCC.Width = 104
        '
        'colNombreCC
        '
        Me.colNombreCC.FieldName = "NombreCC"
        Me.colNombreCC.Name = "colNombreCC"
        Me.colNombreCC.Visible = True
        Me.colNombreCC.VisibleIndex = 1
        Me.colNombreCC.Width = 276
        '
        'colStock
        '
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.Visible = True
        Me.colStock.VisibleIndex = 2
        '
        'colUM2
        '
        Me.colUM2.FieldName = "U/M2"
        Me.colUM2.Name = "colUM2"
        Me.colUM2.Visible = True
        Me.colUM2.VisibleIndex = 3
        '
        'colCantidad2
        '
        Me.colCantidad2.FieldName = "Cantidad2"
        Me.colCantidad2.Name = "colCantidad2"
        Me.colCantidad2.Visible = True
        Me.colCantidad2.VisibleIndex = 4
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdIngresoOrdenes
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.grdIngresoOrdenes
        Me.CardView1.Name = "CardView1"
        '
        'grdviewCP2
        '
        Me.grdviewCP2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewCP2.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewCP2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewCP2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.GroupButton.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grdviewCP2.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewCP2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.grdviewCP2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdviewCP2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewCP2.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewCP2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdviewCP2.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewCP2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.grdviewCP2.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.Preview.Options.UseFont = True
        Me.grdviewCP2.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdviewCP2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewCP2.Appearance.Row.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.Row.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewCP2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewCP2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.grdviewCP2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grdviewCP2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewCP2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewCP2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewCP2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.grdviewCP2.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewCP2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrigenAR4, Me.colCodigoCP4, Me.colNombreCP4, Me.colUM4, Me.colAlmacen4, Me.colMetasa4, Me.colPradera4, Me.colCantidad4, Me.colProduccion4, Me.colComprometido4, Me.colProducir4, Me.colDestinoCP4, Me.colComentario14})
        Me.grdviewCP2.GridControl = Me.grdIngresoOrdenes
        Me.grdviewCP2.Name = "grdviewCP2"
        Me.grdviewCP2.OptionsDetail.ShowDetailTabs = False
        Me.grdviewCP2.OptionsView.ColumnAutoWidth = False
        Me.grdviewCP2.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewCP2.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewCP2.OptionsView.ShowGroupPanel = False
        Me.grdviewCP2.PaintStyleName = "Web"
        '
        'colOrigenAR4
        '
        Me.colOrigenAR4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.colOrigenAR4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigenAR4.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colOrigenAR4.AppearanceCell.Options.UseBackColor = True
        Me.colOrigenAR4.AppearanceCell.Options.UseFont = True
        Me.colOrigenAR4.AppearanceCell.Options.UseForeColor = True
        Me.colOrigenAR4.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigenAR4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigenAR4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrigenAR4.AppearanceHeader.Options.UseFont = True
        Me.colOrigenAR4.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigenAR4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigenAR4.ColumnEdit = Me.rslueDestino
        Me.colOrigenAR4.FieldName = "OrigenAR"
        Me.colOrigenAR4.Name = "colOrigenAR4"
        Me.colOrigenAR4.Visible = True
        Me.colOrigenAR4.VisibleIndex = 0
        '
        'colCodigoCP4
        '
        Me.colCodigoCP4.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colCodigoCP4.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoCP4.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCP4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCP4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCP4.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCP4.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoCP4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCP4.ColumnEdit = Me.rslueCodigoCP
        Me.colCodigoCP4.FieldName = "CodigoCP"
        Me.colCodigoCP4.Name = "colCodigoCP4"
        Me.colCodigoCP4.Visible = True
        Me.colCodigoCP4.VisibleIndex = 1
        Me.colCodigoCP4.Width = 150
        '
        'colNombreCP4
        '
        Me.colNombreCP4.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colNombreCP4.AppearanceCell.Options.UseBackColor = True
        Me.colNombreCP4.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCP4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCP4.FieldName = "NombreCP"
        Me.colNombreCP4.Name = "colNombreCP4"
        Me.colNombreCP4.OptionsColumn.AllowEdit = False
        Me.colNombreCP4.OptionsColumn.AllowFocus = False
        Me.colNombreCP4.Visible = True
        Me.colNombreCP4.VisibleIndex = 2
        Me.colNombreCP4.Width = 400
        '
        'colUM4
        '
        Me.colUM4.AppearanceCell.Options.UseTextOptions = True
        Me.colUM4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM4.AppearanceHeader.Options.UseFont = True
        Me.colUM4.AppearanceHeader.Options.UseTextOptions = True
        Me.colUM4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM4.FieldName = "UM"
        Me.colUM4.Name = "colUM4"
        Me.colUM4.OptionsColumn.AllowEdit = False
        Me.colUM4.OptionsColumn.AllowFocus = False
        Me.colUM4.Visible = True
        Me.colUM4.VisibleIndex = 3
        '
        'colAlmacen4
        '
        Me.colAlmacen4.AppearanceCell.Options.UseTextOptions = True
        Me.colAlmacen4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlmacen4.AppearanceHeader.Options.UseFont = True
        Me.colAlmacen4.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlmacen4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlmacen4.FieldName = "Almacen"
        Me.colAlmacen4.Name = "colAlmacen4"
        Me.colAlmacen4.OptionsColumn.AllowEdit = False
        Me.colAlmacen4.OptionsColumn.AllowFocus = False
        Me.colAlmacen4.Visible = True
        Me.colAlmacen4.VisibleIndex = 4
        '
        'colMetasa4
        '
        Me.colMetasa4.AppearanceCell.Options.UseTextOptions = True
        Me.colMetasa4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMetasa4.AppearanceHeader.Options.UseFont = True
        Me.colMetasa4.AppearanceHeader.Options.UseTextOptions = True
        Me.colMetasa4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMetasa4.FieldName = "Metasa"
        Me.colMetasa4.Name = "colMetasa4"
        Me.colMetasa4.OptionsColumn.AllowEdit = False
        Me.colMetasa4.OptionsColumn.AllowFocus = False
        Me.colMetasa4.Visible = True
        Me.colMetasa4.VisibleIndex = 5
        '
        'colPradera4
        '
        Me.colPradera4.AppearanceCell.Options.UseTextOptions = True
        Me.colPradera4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPradera4.AppearanceHeader.Options.UseFont = True
        Me.colPradera4.AppearanceHeader.Options.UseTextOptions = True
        Me.colPradera4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPradera4.FieldName = "Pradera"
        Me.colPradera4.Name = "colPradera4"
        Me.colPradera4.OptionsColumn.AllowEdit = False
        Me.colPradera4.OptionsColumn.AllowFocus = False
        Me.colPradera4.Visible = True
        Me.colPradera4.VisibleIndex = 6
        '
        'colCantidad4
        '
        Me.colCantidad4.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidad4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCantidad4.AppearanceHeader.Options.UseFont = True
        Me.colCantidad4.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad4.FieldName = "Cantidad"
        Me.colCantidad4.Name = "colCantidad4"
        Me.colCantidad4.OptionsColumn.AllowEdit = False
        Me.colCantidad4.OptionsColumn.AllowFocus = False
        Me.colCantidad4.Visible = True
        Me.colCantidad4.VisibleIndex = 7
        '
        'colProduccion4
        '
        Me.colProduccion4.AppearanceCell.Options.UseTextOptions = True
        Me.colProduccion4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduccion4.AppearanceHeader.Options.UseFont = True
        Me.colProduccion4.AppearanceHeader.Options.UseTextOptions = True
        Me.colProduccion4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduccion4.FieldName = "Produccion"
        Me.colProduccion4.Name = "colProduccion4"
        Me.colProduccion4.OptionsColumn.AllowEdit = False
        Me.colProduccion4.OptionsColumn.AllowFocus = False
        Me.colProduccion4.Visible = True
        Me.colProduccion4.VisibleIndex = 8
        '
        'colComprometido4
        '
        Me.colComprometido4.AppearanceCell.Options.UseTextOptions = True
        Me.colComprometido4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComprometido4.AppearanceHeader.Options.UseFont = True
        Me.colComprometido4.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprometido4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprometido4.FieldName = "Comprometido"
        Me.colComprometido4.Name = "colComprometido4"
        Me.colComprometido4.OptionsColumn.AllowEdit = False
        Me.colComprometido4.OptionsColumn.AllowFocus = False
        Me.colComprometido4.Visible = True
        Me.colComprometido4.VisibleIndex = 9
        Me.colComprometido4.Width = 101
        '
        'colProducir4
        '
        Me.colProducir4.AppearanceCell.Options.UseTextOptions = True
        Me.colProducir4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProducir4.AppearanceHeader.Options.UseTextOptions = True
        Me.colProducir4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProducir4.DisplayFormat.FormatString = "n2"
        Me.colProducir4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProducir4.FieldName = "Producir"
        Me.colProducir4.Name = "colProducir4"
        Me.colProducir4.Visible = True
        Me.colProducir4.VisibleIndex = 10
        '
        'colDestinoCP4
        '
        Me.colDestinoCP4.AppearanceCell.Options.UseTextOptions = True
        Me.colDestinoCP4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestinoCP4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDestinoCP4.AppearanceHeader.Options.UseFont = True
        Me.colDestinoCP4.AppearanceHeader.Options.UseTextOptions = True
        Me.colDestinoCP4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDestinoCP4.ColumnEdit = Me.rslueDestino
        Me.colDestinoCP4.FieldName = "DestinoCP"
        Me.colDestinoCP4.Name = "colDestinoCP4"
        Me.colDestinoCP4.Visible = True
        Me.colDestinoCP4.VisibleIndex = 11
        Me.colDestinoCP4.Width = 86
        '
        'colComentario14
        '
        Me.colComentario14.AppearanceHeader.Options.UseTextOptions = True
        Me.colComentario14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComentario14.FieldName = "Comentarios"
        Me.colComentario14.Name = "colComentario14"
        Me.colComentario14.Visible = True
        Me.colComentario14.VisibleIndex = 12
        Me.colComentario14.Width = 300
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.mmeComentarios)
        Me.LayoutControl1.Controls.Add(Me.StandaloneBarDockControl1)
        Me.LayoutControl1.Controls.Add(Me.grdIngresoOrdenes)
        Me.LayoutControl1.Controls.Add(Me.txtDeLinea)
        Me.LayoutControl1.Controls.Add(Me.txtNombreArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.LayoutControl1.Controls.Add(Me.txtSugerido)
        Me.LayoutControl1.Controls.Add(Me.txtMaximo)
        Me.LayoutControl1.Controls.Add(Me.txtMinimo)
        Me.LayoutControl1.Controls.Add(Me.txtDisponible)
        Me.LayoutControl1.Controls.Add(Me.txtTotalEgresos)
        Me.LayoutControl1.Controls.Add(Me.txtTotalIngresos)
        Me.LayoutControl1.Controls.Add(Me.txtDeudaProyeccion)
        Me.LayoutControl1.Controls.Add(Me.txtDeudaCampana)
        Me.LayoutControl1.Controls.Add(Me.txtDeudaRol)
        Me.LayoutControl1.Controls.Add(Me.txtProduccion)
        Me.LayoutControl1.Controls.Add(Me.txtEnsamble)
        Me.LayoutControl1.Controls.Add(Me.txtStock)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1647, 720)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'mmeComentarios
        '
        Me.mmeComentarios.Location = New System.Drawing.Point(115, 112)
        Me.mmeComentarios.MenuManager = Me.BarManager1
        Me.mmeComentarios.Name = "mmeComentarios"
        Me.mmeComentarios.Size = New System.Drawing.Size(902, 35)
        Me.mmeComentarios.StyleController = Me.LayoutControl1
        Me.mmeComentarios.TabIndex = 20
        Me.mmeComentarios.UseOptimizedRendering = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnStock, Me.barbtnEnsamble, Me.barbtnProduccion, Me.barbtnDeudaRol, Me.barbtnDeudaCampana, Me.barbtnDeudaProyeccion, Me.barbtnSAP, Me.barbtnAnalsisVenta})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnStock), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnEnsamble), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnProduccion), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDeudaRol), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDeudaCampana), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnDeudaProyeccion), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAnalsisVenta, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSAP, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar1.Text = "Tools"
        '
        'barbtnStock
        '
        Me.barbtnStock.Caption = "Stock"
        Me.barbtnStock.Glyph = CType(resources.GetObject("barbtnStock.Glyph"), System.Drawing.Image)
        Me.barbtnStock.Id = 0
        Me.barbtnStock.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.barbtnStock.Name = "barbtnStock"
        '
        'barbtnEnsamble
        '
        Me.barbtnEnsamble.Caption = "Ensamble"
        Me.barbtnEnsamble.Glyph = CType(resources.GetObject("barbtnEnsamble.Glyph"), System.Drawing.Image)
        Me.barbtnEnsamble.Id = 1
        Me.barbtnEnsamble.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.barbtnEnsamble.Name = "barbtnEnsamble"
        '
        'barbtnProduccion
        '
        Me.barbtnProduccion.Caption = "Produccion"
        Me.barbtnProduccion.Glyph = CType(resources.GetObject("barbtnProduccion.Glyph"), System.Drawing.Image)
        Me.barbtnProduccion.Id = 2
        Me.barbtnProduccion.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.barbtnProduccion.Name = "barbtnProduccion"
        '
        'barbtnDeudaRol
        '
        Me.barbtnDeudaRol.Caption = "Deuda Rol"
        Me.barbtnDeudaRol.Glyph = CType(resources.GetObject("barbtnDeudaRol.Glyph"), System.Drawing.Image)
        Me.barbtnDeudaRol.Id = 3
        Me.barbtnDeudaRol.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.barbtnDeudaRol.Name = "barbtnDeudaRol"
        '
        'barbtnDeudaCampana
        '
        Me.barbtnDeudaCampana.Caption = "Deuda Campana"
        Me.barbtnDeudaCampana.Glyph = CType(resources.GetObject("barbtnDeudaCampana.Glyph"), System.Drawing.Image)
        Me.barbtnDeudaCampana.Id = 4
        Me.barbtnDeudaCampana.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.barbtnDeudaCampana.Name = "barbtnDeudaCampana"
        '
        'barbtnDeudaProyeccion
        '
        Me.barbtnDeudaProyeccion.Caption = "Deuda Proyeccion"
        Me.barbtnDeudaProyeccion.Glyph = CType(resources.GetObject("barbtnDeudaProyeccion.Glyph"), System.Drawing.Image)
        Me.barbtnDeudaProyeccion.Id = 5
        Me.barbtnDeudaProyeccion.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.barbtnDeudaProyeccion.Name = "barbtnDeudaProyeccion"
        '
        'barbtnAnalsisVenta
        '
        Me.barbtnAnalsisVenta.Caption = "Analisis Venta"
        Me.barbtnAnalsisVenta.Glyph = CType(resources.GetObject("barbtnAnalsisVenta.Glyph"), System.Drawing.Image)
        Me.barbtnAnalsisVenta.Id = 8
        Me.barbtnAnalsisVenta.Name = "barbtnAnalsisVenta"
        '
        'barbtnSAP
        '
        Me.barbtnSAP.Caption = "Generar Orden"
        Me.barbtnSAP.Glyph = CType(resources.GetObject("barbtnSAP.Glyph"), System.Drawing.Image)
        Me.barbtnSAP.Id = 6
        Me.barbtnSAP.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.barbtnSAP.LargeGlyph = CType(resources.GetObject("barbtnSAP.LargeGlyph"), System.Drawing.Image)
        Me.barbtnSAP.Name = "barbtnSAP"
        ToolTipTitleItem1.Text = "Subir a SAP"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.barbtnSAP.SuperTip = SuperToolTip1
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(12, 12)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(362, 48)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1647, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 720)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1647, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 720)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1647, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 720)
        '
        'txtDeLinea
        '
        Me.txtDeLinea.Location = New System.Drawing.Point(967, 64)
        Me.txtDeLinea.MaximumSize = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.Name = "txtDeLinea"
        Me.txtDeLinea.Properties.Appearance.BackColor = System.Drawing.Color.Gray
        Me.txtDeLinea.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDeLinea.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtDeLinea.Properties.Appearance.Options.UseBackColor = True
        Me.txtDeLinea.Properties.Appearance.Options.UseFont = True
        Me.txtDeLinea.Properties.Appearance.Options.UseForeColor = True
        Me.txtDeLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeLinea.Properties.ReadOnly = True
        Me.txtDeLinea.Size = New System.Drawing.Size(50, 20)
        Me.txtDeLinea.StyleController = Me.LayoutControl1
        Me.txtDeLinea.TabIndex = 18
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(115, 88)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Properties.Appearance.BackColor = System.Drawing.Color.Gray
        Me.txtNombreArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreArticulo.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNombreArticulo.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombreArticulo.Properties.Appearance.Options.UseFont = True
        Me.txtNombreArticulo.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombreArticulo.Properties.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(902, 20)
        Me.txtNombreArticulo.StyleController = Me.LayoutControl1
        Me.txtNombreArticulo.TabIndex = 17
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(115, 64)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Appearance.BackColor = System.Drawing.Color.Gray
        Me.txtCodigoArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoArticulo.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoArticulo.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodigoArticulo.Properties.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(745, 20)
        Me.txtCodigoArticulo.StyleController = Me.LayoutControl1
        Me.txtCodigoArticulo.TabIndex = 16
        '
        'txtSugerido
        '
        Me.txtSugerido.Location = New System.Drawing.Point(1548, 115)
        Me.txtSugerido.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtSugerido.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtSugerido.Name = "txtSugerido"
        Me.txtSugerido.Properties.Appearance.BackColor = System.Drawing.Color.Green
        Me.txtSugerido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtSugerido.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSugerido.Properties.Appearance.Options.UseBackColor = True
        Me.txtSugerido.Properties.Appearance.Options.UseFont = True
        Me.txtSugerido.Properties.Appearance.Options.UseForeColor = True
        Me.txtSugerido.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSugerido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSugerido.Properties.ReadOnly = True
        Me.txtSugerido.Size = New System.Drawing.Size(75, 20)
        Me.txtSugerido.StyleController = Me.LayoutControl1
        Me.txtSugerido.TabIndex = 15
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(1548, 91)
        Me.txtMaximo.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtMaximo.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtMaximo.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaximo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaximo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaximo.Properties.ReadOnly = True
        Me.txtMaximo.Size = New System.Drawing.Size(75, 20)
        Me.txtMaximo.StyleController = Me.LayoutControl1
        Me.txtMaximo.TabIndex = 14
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(1548, 67)
        Me.txtMinimo.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtMinimo.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtMinimo.Properties.Appearance.Options.UseForeColor = True
        Me.txtMinimo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimo.Properties.ReadOnly = True
        Me.txtMinimo.Size = New System.Drawing.Size(75, 20)
        Me.txtMinimo.StyleController = Me.LayoutControl1
        Me.txtMinimo.TabIndex = 13
        '
        'txtDisponible
        '
        Me.txtDisponible.Location = New System.Drawing.Point(1548, 43)
        Me.txtDisponible.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtDisponible.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtDisponible.Name = "txtDisponible"
        Me.txtDisponible.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtDisponible.Properties.Appearance.Options.UseForeColor = True
        Me.txtDisponible.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDisponible.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDisponible.Properties.ReadOnly = True
        Me.txtDisponible.Size = New System.Drawing.Size(75, 20)
        Me.txtDisponible.StyleController = Me.LayoutControl1
        Me.txtDisponible.TabIndex = 12
        '
        'txtTotalEgresos
        '
        Me.txtTotalEgresos.Location = New System.Drawing.Point(1342, 115)
        Me.txtTotalEgresos.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtTotalEgresos.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtTotalEgresos.Name = "txtTotalEgresos"
        Me.txtTotalEgresos.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.txtTotalEgresos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalEgresos.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalEgresos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalEgresos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalEgresos.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalEgresos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalEgresos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalEgresos.Properties.ReadOnly = True
        Me.txtTotalEgresos.Size = New System.Drawing.Size(75, 20)
        Me.txtTotalEgresos.StyleController = Me.LayoutControl1
        Me.txtTotalEgresos.TabIndex = 11
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Location = New System.Drawing.Point(1136, 115)
        Me.txtTotalIngresos.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtTotalIngresos.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTotalIngresos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalIngresos.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalIngresos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalIngresos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalIngresos.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalIngresos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalIngresos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalIngresos.Properties.ReadOnly = True
        Me.txtTotalIngresos.Size = New System.Drawing.Size(75, 20)
        Me.txtTotalIngresos.StyleController = Me.LayoutControl1
        Me.txtTotalIngresos.TabIndex = 10
        '
        'txtDeudaProyeccion
        '
        Me.txtDeudaProyeccion.Location = New System.Drawing.Point(1342, 91)
        Me.txtDeudaProyeccion.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaProyeccion.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaProyeccion.Name = "txtDeudaProyeccion"
        Me.txtDeudaProyeccion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDeudaProyeccion.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtDeudaProyeccion.Properties.Appearance.Options.UseFont = True
        Me.txtDeudaProyeccion.Properties.Appearance.Options.UseForeColor = True
        Me.txtDeudaProyeccion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeudaProyeccion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeudaProyeccion.Properties.ReadOnly = True
        Me.txtDeudaProyeccion.Size = New System.Drawing.Size(75, 20)
        Me.txtDeudaProyeccion.StyleController = Me.LayoutControl1
        Me.txtDeudaProyeccion.TabIndex = 9
        '
        'txtDeudaCampana
        '
        Me.txtDeudaCampana.Location = New System.Drawing.Point(1342, 67)
        Me.txtDeudaCampana.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaCampana.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaCampana.Name = "txtDeudaCampana"
        Me.txtDeudaCampana.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDeudaCampana.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtDeudaCampana.Properties.Appearance.Options.UseFont = True
        Me.txtDeudaCampana.Properties.Appearance.Options.UseForeColor = True
        Me.txtDeudaCampana.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeudaCampana.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeudaCampana.Properties.ReadOnly = True
        Me.txtDeudaCampana.Size = New System.Drawing.Size(75, 20)
        Me.txtDeudaCampana.StyleController = Me.LayoutControl1
        Me.txtDeudaCampana.TabIndex = 8
        '
        'txtDeudaRol
        '
        Me.txtDeudaRol.Location = New System.Drawing.Point(1342, 43)
        Me.txtDeudaRol.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaRol.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtDeudaRol.Name = "txtDeudaRol"
        Me.txtDeudaRol.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDeudaRol.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtDeudaRol.Properties.Appearance.Options.UseFont = True
        Me.txtDeudaRol.Properties.Appearance.Options.UseForeColor = True
        Me.txtDeudaRol.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeudaRol.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDeudaRol.Properties.ReadOnly = True
        Me.txtDeudaRol.Size = New System.Drawing.Size(75, 20)
        Me.txtDeudaRol.StyleController = Me.LayoutControl1
        Me.txtDeudaRol.TabIndex = 7
        '
        'txtProduccion
        '
        Me.txtProduccion.Location = New System.Drawing.Point(1136, 91)
        Me.txtProduccion.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtProduccion.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtProduccion.Name = "txtProduccion"
        Me.txtProduccion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtProduccion.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtProduccion.Properties.Appearance.Options.UseFont = True
        Me.txtProduccion.Properties.Appearance.Options.UseForeColor = True
        Me.txtProduccion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProduccion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtProduccion.Properties.ReadOnly = True
        Me.txtProduccion.Size = New System.Drawing.Size(75, 20)
        Me.txtProduccion.StyleController = Me.LayoutControl1
        Me.txtProduccion.TabIndex = 6
        '
        'txtEnsamble
        '
        Me.txtEnsamble.Location = New System.Drawing.Point(1136, 67)
        Me.txtEnsamble.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtEnsamble.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtEnsamble.Name = "txtEnsamble"
        Me.txtEnsamble.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEnsamble.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtEnsamble.Properties.Appearance.Options.UseFont = True
        Me.txtEnsamble.Properties.Appearance.Options.UseForeColor = True
        Me.txtEnsamble.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEnsamble.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEnsamble.Properties.ReadOnly = True
        Me.txtEnsamble.Size = New System.Drawing.Size(75, 20)
        Me.txtEnsamble.StyleController = Me.LayoutControl1
        Me.txtEnsamble.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(1136, 43)
        Me.txtStock.MaximumSize = New System.Drawing.Size(75, 20)
        Me.txtStock.MinimumSize = New System.Drawing.Size(75, 20)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtStock.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtStock.Properties.Appearance.Options.UseFont = True
        Me.txtStock.Properties.Appearance.Options.UseForeColor = True
        Me.txtStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStock.Properties.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(75, 20)
        Me.txtStock.StyleController = Me.LayoutControl1
        Me.txtStock.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lygIngresos, Me.lygEgresos, Me.lygSugerido, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.lycComentarios})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1647, 720)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lygIngresos
        '
        Me.lygIngresos.CustomizationFormText = "Ingresos"
        Me.lygIngresos.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycStock, Me.lycEnsamble, Me.lycProduccion, Me.lycTotalPositivo})
        Me.lygIngresos.Location = New System.Drawing.Point(1009, 0)
        Me.lygIngresos.Name = "lygIngresos"
        Me.lygIngresos.Size = New System.Drawing.Size(206, 139)
        Me.lygIngresos.Text = "Ingresos"
        '
        'lycStock
        '
        Me.lycStock.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycStock.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycStock.Control = Me.txtStock
        Me.lycStock.CustomizationFormText = "Stock"
        Me.lycStock.Location = New System.Drawing.Point(0, 0)
        Me.lycStock.Name = "lycStock"
        Me.lycStock.Size = New System.Drawing.Size(182, 24)
        Me.lycStock.Text = "Stock"
        Me.lycStock.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycEnsamble
        '
        Me.lycEnsamble.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycEnsamble.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycEnsamble.Control = Me.txtEnsamble
        Me.lycEnsamble.CustomizationFormText = "Ensamble"
        Me.lycEnsamble.Location = New System.Drawing.Point(0, 24)
        Me.lycEnsamble.Name = "lycEnsamble"
        Me.lycEnsamble.Size = New System.Drawing.Size(182, 24)
        Me.lycEnsamble.Text = "Ensamble"
        Me.lycEnsamble.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycProduccion
        '
        Me.lycProduccion.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycProduccion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycProduccion.Control = Me.txtProduccion
        Me.lycProduccion.CustomizationFormText = "Produccion"
        Me.lycProduccion.Location = New System.Drawing.Point(0, 48)
        Me.lycProduccion.Name = "lycProduccion"
        Me.lycProduccion.Size = New System.Drawing.Size(182, 24)
        Me.lycProduccion.Text = "Produccion"
        Me.lycProduccion.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycTotalPositivo
        '
        Me.lycTotalPositivo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycTotalPositivo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycTotalPositivo.Control = Me.txtTotalIngresos
        Me.lycTotalPositivo.CustomizationFormText = "Total Positivo"
        Me.lycTotalPositivo.Location = New System.Drawing.Point(0, 72)
        Me.lycTotalPositivo.Name = "lycTotalPositivo"
        Me.lycTotalPositivo.Size = New System.Drawing.Size(182, 24)
        Me.lycTotalPositivo.Text = "Total Positivo"
        Me.lycTotalPositivo.TextSize = New System.Drawing.Size(100, 13)
        '
        'lygEgresos
        '
        Me.lygEgresos.CustomizationFormText = "Egresos"
        Me.lygEgresos.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycDeudaRol, Me.lycDeudaCampana, Me.lycDeudaProyeccion, Me.lycTotalNegativo})
        Me.lygEgresos.Location = New System.Drawing.Point(1215, 0)
        Me.lygEgresos.Name = "lygEgresos"
        Me.lygEgresos.Size = New System.Drawing.Size(206, 139)
        Me.lygEgresos.Text = "Egresos"
        '
        'lycDeudaRol
        '
        Me.lycDeudaRol.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycDeudaRol.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycDeudaRol.Control = Me.txtDeudaRol
        Me.lycDeudaRol.CustomizationFormText = "Deuda Rol"
        Me.lycDeudaRol.Location = New System.Drawing.Point(0, 0)
        Me.lycDeudaRol.Name = "lycDeudaRol"
        Me.lycDeudaRol.Size = New System.Drawing.Size(182, 24)
        Me.lycDeudaRol.Text = "Deuda Rol"
        Me.lycDeudaRol.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycDeudaCampana
        '
        Me.lycDeudaCampana.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycDeudaCampana.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycDeudaCampana.Control = Me.txtDeudaCampana
        Me.lycDeudaCampana.CustomizationFormText = "Deuda Campana"
        Me.lycDeudaCampana.Location = New System.Drawing.Point(0, 24)
        Me.lycDeudaCampana.Name = "lycDeudaCampana"
        Me.lycDeudaCampana.Size = New System.Drawing.Size(182, 24)
        Me.lycDeudaCampana.Text = "Deuda Campana"
        Me.lycDeudaCampana.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycDeudaProyeccion
        '
        Me.lycDeudaProyeccion.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycDeudaProyeccion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycDeudaProyeccion.Control = Me.txtDeudaProyeccion
        Me.lycDeudaProyeccion.CustomizationFormText = "Deuda Proyeccion"
        Me.lycDeudaProyeccion.Location = New System.Drawing.Point(0, 48)
        Me.lycDeudaProyeccion.Name = "lycDeudaProyeccion"
        Me.lycDeudaProyeccion.Size = New System.Drawing.Size(182, 24)
        Me.lycDeudaProyeccion.Text = "Deuda Proyeccion"
        Me.lycDeudaProyeccion.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycTotalNegativo
        '
        Me.lycTotalNegativo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycTotalNegativo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycTotalNegativo.Control = Me.txtTotalEgresos
        Me.lycTotalNegativo.CustomizationFormText = "Total Negativo"
        Me.lycTotalNegativo.Location = New System.Drawing.Point(0, 72)
        Me.lycTotalNegativo.Name = "lycTotalNegativo"
        Me.lycTotalNegativo.Size = New System.Drawing.Size(182, 24)
        Me.lycTotalNegativo.Text = "Total Negativo"
        Me.lycTotalNegativo.TextSize = New System.Drawing.Size(100, 13)
        '
        'lygSugerido
        '
        Me.lygSugerido.CustomizationFormText = "Sugerido"
        Me.lygSugerido.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycDisponible, Me.lycMinimo, Me.lycMaximo, Me.lycSugerido})
        Me.lygSugerido.Location = New System.Drawing.Point(1421, 0)
        Me.lygSugerido.Name = "lygSugerido"
        Me.lygSugerido.Size = New System.Drawing.Size(206, 139)
        Me.lygSugerido.Text = "Sugerido"
        '
        'lycDisponible
        '
        Me.lycDisponible.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycDisponible.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycDisponible.Control = Me.txtDisponible
        Me.lycDisponible.CustomizationFormText = "Disponible"
        Me.lycDisponible.Location = New System.Drawing.Point(0, 0)
        Me.lycDisponible.Name = "lycDisponible"
        Me.lycDisponible.Size = New System.Drawing.Size(182, 24)
        Me.lycDisponible.Text = "Disponible"
        Me.lycDisponible.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycMinimo
        '
        Me.lycMinimo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycMinimo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycMinimo.Control = Me.txtMinimo
        Me.lycMinimo.CustomizationFormText = "Minimo"
        Me.lycMinimo.Location = New System.Drawing.Point(0, 24)
        Me.lycMinimo.Name = "lycMinimo"
        Me.lycMinimo.Size = New System.Drawing.Size(182, 24)
        Me.lycMinimo.Text = "Minimo"
        Me.lycMinimo.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycMaximo
        '
        Me.lycMaximo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycMaximo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycMaximo.Control = Me.txtMaximo
        Me.lycMaximo.CustomizationFormText = "Maximo"
        Me.lycMaximo.Location = New System.Drawing.Point(0, 48)
        Me.lycMaximo.Name = "lycMaximo"
        Me.lycMaximo.Size = New System.Drawing.Size(182, 24)
        Me.lycMaximo.Text = "Maximo"
        Me.lycMaximo.TextSize = New System.Drawing.Size(100, 13)
        '
        'lycSugerido
        '
        Me.lycSugerido.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycSugerido.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycSugerido.Control = Me.txtSugerido
        Me.lycSugerido.CustomizationFormText = "Sugerido"
        Me.lycSugerido.Location = New System.Drawing.Point(0, 72)
        Me.lycSugerido.Name = "lycSugerido"
        Me.lycSugerido.Size = New System.Drawing.Size(182, 24)
        Me.lycSugerido.Text = "Sugerido"
        Me.lycSugerido.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.txtCodigoArticulo
        Me.LayoutControlItem1.CustomizationFormText = "Codigo Articulo"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(852, 24)
        Me.LayoutControlItem1.Text = "Codigo Articulo"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.txtNombreArticulo
        Me.LayoutControlItem2.CustomizationFormText = "Nombre Articulo"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1009, 24)
        Me.LayoutControlItem2.Text = "Nombre Articulo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.txtDeLinea
        Me.LayoutControlItem3.CustomizationFormText = "De Linea?"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(852, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem3.Text = "De Linea?"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.grdIngresoOrdenes
        Me.LayoutControlItem4.CustomizationFormText = "Pedidos de Ensamble"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 139)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1627, 561)
        Me.LayoutControlItem4.Text = "Pedidos de Ensamble"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.StandaloneBarDockControl1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(366, 52)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(366, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(643, 52)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lycComentarios
        '
        Me.lycComentarios.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lycComentarios.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lycComentarios.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lycComentarios.Control = Me.mmeComentarios
        Me.lycComentarios.CustomizationFormText = "Comentarios"
        Me.lycComentarios.Location = New System.Drawing.Point(0, 100)
        Me.lycComentarios.Name = "lycComentarios"
        Me.lycComentarios.Size = New System.Drawing.Size(1009, 39)
        Me.lycComentarios.Text = "Comentarios"
        Me.lycComentarios.TextSize = New System.Drawing.Size(100, 13)
        '
        'frmOrdenEnsamble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1647, 720)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOrdenEnsamble"
        Me.Text = "frmIngresoOrden"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdviewCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdIngresoOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresoOrden1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueGrupoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueCodigoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumOrdenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueNumCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rslueOrigenAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbOrigenAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.mmeComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSugerido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalEgresos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalIngresos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeudaProyeccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeudaCampana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeudaRol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnsamble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lygIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycEnsamble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTotalPositivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lygEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDeudaRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDeudaCampana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDeudaProyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTotalNegativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lygSugerido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycSugerido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtTotalEgresos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalIngresos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeudaProyeccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeudaCampana As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeudaRol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProduccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEnsamble As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lycStock As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycEnsamble As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycProduccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDeudaRol As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDeudaCampana As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDeudaProyeccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycTotalPositivo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycTotalNegativo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lygIngresos As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lygEgresos As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtSugerido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lycDisponible As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycMinimo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycMaximo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycSugerido As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lygSugerido As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents grdIngresoOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDeLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barbtnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnEnsamble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnProduccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaRol As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaCampana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnDeudaProyeccion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnSAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdviewCP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdviewCC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdviewCP2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombreCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadEnsamble As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueOrigen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents rslueDestino As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueColores As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueGrupoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueCodigoCliente As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumOrdenVenta As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rslueNumCampana As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComentarios1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMetasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPradera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueCodigoCP As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mmeComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lycComentarios As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colDestinoCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barbtnAnalsisVenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colOrigenAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rslueOrigenAR As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoCP4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCP4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacen4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMetasa4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPradera4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducir4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinoCP4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduccion3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduccion4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprometido4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsIngresoOrden1 As waProduccion_Pedidos.dsIngresoOrden
    Friend WithEvents colOrigenAR4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbbOrigenAR As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents ssmEsperar As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
