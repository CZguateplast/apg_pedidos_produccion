<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrptOrdenProduccionImpresionListaMat
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsOrdenProduccionImpresion1 = New waProduccion_Pedidos.dsOrdenProduccionImpresion()
        Me.DsdtProduccionPadresTableAdapter = New waProduccion_Pedidos.dsOrdenProduccionImpresionTableAdapters.dsdtProduccionPadresTableAdapter()
        Me.pCodigoArticulo = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrCheckBox1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.HeightF = 27.08333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCheckBox1
        '
        Me.XrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrCheckBox1.Name = "XrCheckBox1"
        Me.XrCheckBox1.SizeF = New System.Drawing.SizeF(44.79167!, 23.0!)
        Me.XrCheckBox1.StylePriority.UseTextAlignment = False
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionListaMateriales.U/M")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionListaMateriales.Cantidad")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionListaMateriales.NombreCC")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(144.7917!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(305.2083!, 23.0!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionListaMateriales.CodigoCC")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(44.79167!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsOrdenProduccionImpresion1
        '
        Me.DsOrdenProduccionImpresion1.DataSetName = "dsOrdenProduccionImpresion"
        Me.DsOrdenProduccionImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsdtProduccionPadresTableAdapter
        '
        Me.DsdtProduccionPadresTableAdapter.ClearBeforeFill = True
        '
        'pCodigoArticulo
        '
        Me.pCodigoArticulo.Description = "CodigoArticulo"
        Me.pCodigoArticulo.Name = "pCodigoArticulo"
        Me.pCodigoArticulo.Visible = False
        '
        'xrptOrdenProduccionImpresionListaMat
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataMember = "dsdtImpresionListaMateriales"
        Me.DataSource = Me.DsOrdenProduccionImpresion1
        Me.FilterString = "[CodigoArticulo] = ?pCodigoArticulo"
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pCodigoArticulo})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "13.2"
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsOrdenProduccionImpresion1 As waProduccion_Pedidos.dsOrdenProduccionImpresion
    Friend WithEvents DsdtProduccionPadresTableAdapter As waProduccion_Pedidos.dsOrdenProduccionImpresionTableAdapters.dsdtProduccionPadresTableAdapter
    Friend WithEvents XrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pCodigoArticulo As DevExpress.XtraReports.Parameters.Parameter
End Class
