<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrptEnsambleListaMateriales
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
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.condi_SoloAR = New DevExpress.XtraReports.UI.FormattingRule()
        Me.xrptStyleDetalle_Linea = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.pCodigoArticulo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pId = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DsEnsambleOrdenImpresion1 = New waProduccion_Pedidos.dsEnsambleOrdenImpresion()
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrCheckBox1})
        Me.Detail.HeightF = 21.26221!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtEnsambleListaMateriales.Cantidad", "{0:#,#.0}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(651.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(66.66669!, 19.08336!)
        Me.XrLabel4.StyleName = "xrptStyleDetalle_Linea"
        Me.XrLabel4.StylePriority.UseBorderDashStyle = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtEnsambleListaMateriales.U/M")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(599.9583!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(46.04175!, 19.08336!)
        Me.XrLabel3.StyleName = "xrptStyleDetalle_Linea"
        Me.XrLabel3.StylePriority.UseBorderDashStyle = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtEnsambleListaMateriales.NombreCC")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(173.9583!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(421.0!, 19.08336!)
        Me.XrLabel2.StyleName = "xrptStyleDetalle_Linea"
        Me.XrLabel2.StylePriority.UseBorderDashStyle = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtEnsambleListaMateriales.CodigoCC")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(59.375!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(109.5833!, 19.08336!)
        Me.XrLabel1.StyleName = "xrptStyleDetalle_Linea"
        Me.XrLabel1.StylePriority.UseBorderDashStyle = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        '
        'XrCheckBox1
        '
        Me.XrCheckBox1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrCheckBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(38.54167!, 0.0!)
        Me.XrCheckBox1.Name = "XrCheckBox1"
        Me.XrCheckBox1.SizeF = New System.Drawing.SizeF(15.625!, 19.08336!)
        Me.XrCheckBox1.StylePriority.UseBorderDashStyle = False
        Me.XrCheckBox1.StylePriority.UseBorders = False
        Me.XrCheckBox1.StylePriority.UseTextAlignment = False
        Me.XrCheckBox1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 49.04166!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 27.05154!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5})
        Me.GroupHeader1.HeightF = 17.08333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XrLabel5.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(38.54167!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(679.125!, 17.08333!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Lista de Materiales"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'condi_SoloAR
        '
        Me.condi_SoloAR.Condition = "Iif(Substring([CodigoArticulo], 1  ,2 )= 'AR',TRUE  ,FALSE )"
        Me.condi_SoloAR.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.condi_SoloAR.Name = "condi_SoloAR"
        '
        'xrptStyleDetalle_Linea
        '
        Me.xrptStyleDetalle_Linea.BorderColor = System.Drawing.Color.Silver
        Me.xrptStyleDetalle_Linea.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrptStyleDetalle_Linea.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrptStyleDetalle_Linea.BorderWidth = 1.0!
        Me.xrptStyleDetalle_Linea.Name = "xrptStyleDetalle_Linea"
        '
        'pCodigoArticulo
        '
        Me.pCodigoArticulo.Description = "CodigoArticulo"
        Me.pCodigoArticulo.Name = "pCodigoArticulo"
        Me.pCodigoArticulo.Visible = False
        '
        'pId
        '
        Me.pId.Description = "Id Transaccion"
        Me.pId.Name = "pId"
        Me.pId.Visible = False
        '
        'DsEnsambleOrdenImpresion1
        '
        Me.DsEnsambleOrdenImpresion1.DataSetName = "dsEnsambleOrdenImpresion"
        Me.DsEnsambleOrdenImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrptEnsambleListaMateriales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.DataMember = "dsdtEnsambleListaMateriales"
        Me.DataSource = Me.DsEnsambleOrdenImpresion1
        Me.FilterString = "[CodigoArticulo] = ?pCodigoArticulo"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.condi_SoloAR})
        Me.Margins = New System.Drawing.Printing.Margins(56, 43, 49, 27)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pCodigoArticulo, Me.pId})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.xrptStyleDetalle_Linea})
        Me.Version = "17.1"
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents condi_SoloAR As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents xrptStyleDetalle_Linea As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents pCodigoArticulo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pId As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DsEnsambleOrdenImpresion1 As waProduccion_Pedidos.dsEnsambleOrdenImpresion
End Class
