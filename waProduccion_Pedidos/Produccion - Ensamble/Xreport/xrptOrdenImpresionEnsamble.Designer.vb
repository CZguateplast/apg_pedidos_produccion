<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrptOrdenImpresionEnsamble
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.formatMat3Porcentaje = New DevExpress.XtraReports.UI.FormattingRule()
        Me.formatMat2Porcentaje = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.pHorasRequeridas = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pTurnosRequeridos = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pUsuario = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat1Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat2Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat3Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat1Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat2Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat3Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat1Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat2Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat3Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat1DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat2DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat3DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DsEnsambleOrdenImpresion1 = New waProduccion_Pedidos.dsEnsambleOrdenImpresion()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel4 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel59, Me.XrLabel57, Me.XrLabel2, Me.XrLabel67, Me.XrLabel69, Me.XrLabel70, Me.XrLabel71})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 48.6508!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel65})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 118.3958!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel66, Me.XrPageInfo3, Me.XrPageInfo2, Me.XrLine1, Me.XrPageInfo1, Me.XrLabel78})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 128.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel4, Me.XrPanel2, Me.XrPanel3, Me.XrLabel44, Me.XrPanel1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 761.6764!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLabel58, Me.XrLabel60, Me.XrLabel61, Me.XrLabel55, Me.XrLabel56})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.HeightF = 45.08516!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel63, Me.XrLabel62, Me.XrLabel54})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.HeightF = 62.28286!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel59
        '
        Me.XrLabel59.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel59.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.TipoMaterial")})
        Me.XrLabel59.Dpi = 254.0!
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(1830.024!, 0!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(169.7035!, 45.0849!)
        Me.XrLabel59.StylePriority.UseBorderColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "XrLabel59"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel57.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.Color")})
        Me.XrLabel57.Dpi = 254.0!
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(197.1136!, 0!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(108.8877!, 45.08492!)
        Me.XrLabel57.StylePriority.UseBorderColor = False
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "XrLabel57"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.CodigoPadre")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(11.53647!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(185.5771!, 45.08492!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel67
        '
        Me.XrLabel67.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel67.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel67.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.ProdFinal", "{0:#,#}")})
        Me.XrLabel67.Dpi = 254.0!
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(1653.32!, 0!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(169.703!, 45.08492!)
        Me.XrLabel67.StylePriority.UseBorderColor = False
        Me.XrLabel67.StylePriority.UseBorderDashStyle = False
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "XrLabel66"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel69
        '
        Me.XrLabel69.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel69.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel69.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.Completado", "{0:#,#}")})
        Me.XrLabel69.Dpi = 254.0!
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(1448.499!, 0!)
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(199.7612!, 45.08492!)
        Me.XrLabel69.StylePriority.UseBorderColor = False
        Me.XrLabel69.StylePriority.UseBorderDashStyle = False
        Me.XrLabel69.StylePriority.UseBorders = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.Text = "XrLabel64"
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel70
        '
        Me.XrLabel70.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel70.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel70.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.Planeado", "{0:#,#}")})
        Me.XrLabel70.Dpi = 254.0!
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(1252.025!, 0!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(191.4739!, 45.08492!)
        Me.XrLabel70.StylePriority.UseBorderColor = False
        Me.XrLabel70.StylePriority.UseBorderDashStyle = False
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseTextAlignment = False
        Me.XrLabel70.Text = "XrLabel63"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel71
        '
        Me.XrLabel71.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel71.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel71.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel71.CanGrow = False
        Me.XrLabel71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.NombreArticulo")})
        Me.XrLabel71.Dpi = 254.0!
        Me.XrLabel71.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(310.2791!, 0!)
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(938.0262!, 45.08492!)
        Me.XrLabel71.StylePriority.UseBorderColor = False
        Me.XrLabel71.StylePriority.UseBorderDashStyle = False
        Me.XrLabel71.StylePriority.UseBorders = False
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.Text = "XrLabel62"
        Me.XrLabel71.WordWrap = False
        '
        'XrLabel65
        '
        Me.XrLabel65.Dpi = 254.0!
        Me.XrLabel65.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(11.53647!, 47.48753!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(1991.042!, 70.90828!)
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "RESUMEN DE ENSAMBLE"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel66
        '
        Me.XrLabel66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pUsuario, "Text", "")})
        Me.XrLabel66.Dpi = 254.0!
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(1386.21!, 35.71875!)
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(353.7896!, 58.42!)
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "XrLabel66"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Dpi = 254.0!
        Me.XrPageInfo3.Format = "{0:hh:mm tt}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(1162.002!, 35.71875!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(224.2083!, 58.41999!)
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 254.0!
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(568.4541!, 35.71875!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(593.5475!, 58.42!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(15.87501!, 6.402878!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1986.703!, 26.67005!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo1.Format = "Pagina {0}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1740.0!, 33.07292!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0!, 58.42001!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel78
        '
        Me.XrLabel78.Dpi = 254.0!
        Me.XrLabel78.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 35.71875!)
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(543.4541!, 58.42001!)
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.Text = "Programa: waProduccion"
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel3
        '
        Me.XrPanel3.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel3.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel35, Me.XrLabel33, Me.XrLabel32, Me.XrLabel26, Me.XrLabel47, Me.XrLabel41, Me.XrLabel31, Me.XrLabel28, Me.XrLabel30, Me.XrLabel25, Me.XrLabel40, Me.XrLabel39})
        Me.XrPanel3.Dpi = 254.0!
        Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(11.53647!, 58.20831!)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.SizeF = New System.Drawing.SizeF(1991.042!, 182.5625!)
        Me.XrPanel3.StylePriority.UseBackColor = False
        Me.XrPanel3.StylePriority.UseBorderColor = False
        Me.XrPanel3.StylePriority.UseBorders = False
        '
        'XrLabel44
        '
        Me.XrLabel44.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XrLabel44.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel44.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel44.Dpi = 254.0!
        Me.XrLabel44.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(11.53646!, 13.12337!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(1991.042!, 45.08496!)
        Me.XrLabel44.StylePriority.UseBackColor = False
        Me.XrLabel44.StylePriority.UseBorderColor = False
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "PARAMETROS DE ENSAMBLE"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel1.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel74, Me.XrLabel73, Me.XrLabel46})
        Me.XrPanel1.Dpi = 254.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(11.53608!, 252.6693!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(988.2713!, 449.4356!)
        Me.XrPanel1.StylePriority.UseBackColor = False
        Me.XrPanel1.StylePriority.UseBorderColor = False
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel31.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel31.Dpi = 254.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Black
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(957.7138!, 24.39984!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(279.0551!, 45.08498!)
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Equipo Personas"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel28.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.ForeColor = System.Drawing.Color.Black
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(1471.983!, 120.4775!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(256.4799!, 45.08496!)
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Min. X Articulo"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel30.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel30.Dpi = 254.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.ForeColor = System.Drawing.Color.Black
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(1436.963!, 72.48492!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(291.5005!, 45.08497!)
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Ensamble X Hora"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel30.Visible = False
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel25.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.ForeColor = System.Drawing.Color.Black
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(1436.963!, 24.4!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(291.5005!, 45.08494!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Seg. X Articulo"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel25.Visible = False
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel40.Dpi = 254.0!
        Me.XrLabel40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.ForeColor = System.Drawing.Color.Black
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(35.77303!, 72.48492!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(314.8541!, 93.07758!)
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Nombre"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.ForeColor = System.Drawing.Color.Black
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(35.77295!, 24.40001!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(314.8542!, 45.08496!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Codigo Articulo"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel74
        '
        Me.XrLabel74.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel74.Dpi = 254.0!
        Me.XrLabel74.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(22.33083!, 387.1215!)
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(354.2704!, 45.08502!)
        Me.XrLabel74.StylePriority.UseBorders = False
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "Equip. Personas SDT"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel73
        '
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel73.Dpi = 254.0!
        Me.XrLabel73.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(578.085!, 387.1213!)
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(240.4995!, 45.08496!)
        Me.XrLabel73.StylePriority.UseBorders = False
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "Unds. Enfriado"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPanel2
        '
        Me.XrPanel2.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel50})
        Me.XrPanel2.Dpi = 254.0!
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(11.53608!, 713.7599!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(1981.755!, 47.9165!)
        Me.XrPanel2.StylePriority.UseBorderColor = False
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrLabel46
        '
        Me.XrLabel46.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.Dpi = 254.0!
        Me.XrLabel46.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(2.999999!, 2.999978!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(985.2712!, 45.085!)
        Me.XrLabel46.StylePriority.UseBackColor = False
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "INSTRUCCIONES DE TRABAJO"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel50
        '
        Me.XrLabel50.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel50.Dpi = 254.0!
        Me.XrLabel50.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(1.5749!, 1.999959!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(1980.18!, 42.08488!)
        Me.XrLabel50.StylePriority.UseBackColor = False
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "LISTA DE EMPAQUE"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel45
        '
        Me.XrLabel45.BackColor = System.Drawing.Color.Gray
        Me.XrLabel45.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel45.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel45.Dpi = 254.0!
        Me.XrLabel45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel45.ForeColor = System.Drawing.Color.White
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(1830.024!, 0!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(169.7035!, 45.08508!)
        Me.XrLabel45.StylePriority.UseBackColor = False
        Me.XrLabel45.StylePriority.UseBorderColor = False
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseForeColor = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "Material"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.BackColor = System.Drawing.Color.Gray
        Me.XrLabel58.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel58.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel58.Dpi = 254.0!
        Me.XrLabel58.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel58.ForeColor = System.Drawing.Color.White
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(1653.32!, 0!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(169.7035!, 45.08508!)
        Me.XrLabel58.StylePriority.UseBackColor = False
        Me.XrLabel58.StylePriority.UseBorderColor = False
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseForeColor = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "ProdFinal"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel60
        '
        Me.XrLabel60.BackColor = System.Drawing.Color.Gray
        Me.XrLabel60.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel60.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel60.Dpi = 254.0!
        Me.XrLabel60.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel60.ForeColor = System.Drawing.Color.White
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(1448.499!, 0!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(199.7612!, 45.08508!)
        Me.XrLabel60.StylePriority.UseBackColor = False
        Me.XrLabel60.StylePriority.UseBorderColor = False
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseForeColor = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "Completado"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel61
        '
        Me.XrLabel61.BackColor = System.Drawing.Color.Gray
        Me.XrLabel61.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel61.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel61.Dpi = 254.0!
        Me.XrLabel61.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel61.ForeColor = System.Drawing.Color.White
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(1252.025!, 0!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(191.4739!, 45.08514!)
        Me.XrLabel61.StylePriority.UseBackColor = False
        Me.XrLabel61.StylePriority.UseBorderColor = False
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseForeColor = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "Planeado"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel55
        '
        Me.XrLabel55.BackColor = System.Drawing.Color.Gray
        Me.XrLabel55.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel55.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.Dpi = 254.0!
        Me.XrLabel55.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel55.ForeColor = System.Drawing.Color.White
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(11.53646!, 0!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(294.4649!, 45.08508!)
        Me.XrLabel55.StylePriority.UseBackColor = False
        Me.XrLabel55.StylePriority.UseBorderColor = False
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseForeColor = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Codigo Articulo"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.BackColor = System.Drawing.Color.Gray
        Me.XrLabel56.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel56.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.Dpi = 254.0!
        Me.XrLabel56.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel56.ForeColor = System.Drawing.Color.White
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(310.2791!, 0!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(938.0262!, 45.08514!)
        Me.XrLabel56.StylePriority.UseBackColor = False
        Me.XrLabel56.StylePriority.UseBorderColor = False
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseForeColor = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Codigo Articulo"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(938.489!, 8.000033!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(309.8164!, 45.08499!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "TOTALES"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel63
        '
        Me.XrLabel63.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel63.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel63.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel63.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel63.CanGrow = False
        Me.XrLabel63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.Completado")})
        Me.XrLabel63.Dpi = 254.0!
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(1448.499!, 8.000033!)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(199.7612!, 45.08494!)
        Me.XrLabel63.StylePriority.UseBackColor = False
        Me.XrLabel63.StylePriority.UseBorderColor = False
        Me.XrLabel63.StylePriority.UseBorderDashStyle = False
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel63.Summary = XrSummary1
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel62
        '
        Me.XrLabel62.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel62.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel62.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel62.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel62.CanGrow = False
        Me.XrLabel62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.Planeado")})
        Me.XrLabel62.Dpi = 254.0!
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(1252.025!, 8.000033!)
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(191.4739!, 45.08494!)
        Me.XrLabel62.StylePriority.UseBackColor = False
        Me.XrLabel62.StylePriority.UseBorderColor = False
        Me.XrLabel62.StylePriority.UseBorderDashStyle = False
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel62.Summary = XrSummary2
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel54
        '
        Me.XrLabel54.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel54.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel54.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel54.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtProduccionHijos.ProdFinal")})
        Me.XrLabel54.Dpi = 254.0!
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(1653.32!, 8.000033!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(169.703!, 45.08494!)
        Me.XrLabel54.StylePriority.UseBackColor = False
        Me.XrLabel54.StylePriority.UseBorderColor = False
        Me.XrLabel54.StylePriority.UseBorderDashStyle = False
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,#}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel54.Summary = XrSummary3
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'formatMat3Porcentaje
        '
        Me.formatMat3Porcentaje.Condition = "[Parameters.pMat3Porcentaje] = ''"
        Me.formatMat3Porcentaje.Formatting.ForeColor = System.Drawing.Color.White
        Me.formatMat3Porcentaje.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.formatMat3Porcentaje.Name = "formatMat3Porcentaje"
        '
        'formatMat2Porcentaje
        '
        Me.formatMat2Porcentaje.Condition = "[Parameters.pMat2Porcentaje] = ''"
        Me.formatMat2Porcentaje.Formatting.ForeColor = System.Drawing.Color.White
        Me.formatMat2Porcentaje.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.formatMat2Porcentaje.Name = "formatMat2Porcentaje"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'pHorasRequeridas
        '
        Me.pHorasRequeridas.Description = "Parameter1"
        Me.pHorasRequeridas.Name = "pHorasRequeridas"
        Me.pHorasRequeridas.Visible = False
        '
        'pTurnosRequeridos
        '
        Me.pTurnosRequeridos.Description = "Parameter1"
        Me.pTurnosRequeridos.Name = "pTurnosRequeridos"
        Me.pTurnosRequeridos.Visible = False
        '
        'pUsuario
        '
        Me.pUsuario.Description = "Usuario APG"
        Me.pUsuario.Name = "pUsuario"
        Me.pUsuario.Visible = False
        '
        'pMat1Codigo
        '
        Me.pMat1Codigo.Description = "Codigo Material 1"
        Me.pMat1Codigo.Name = "pMat1Codigo"
        Me.pMat1Codigo.Visible = False
        '
        'pMat2Codigo
        '
        Me.pMat2Codigo.Description = "Codigo Material 2"
        Me.pMat2Codigo.Name = "pMat2Codigo"
        Me.pMat2Codigo.Visible = False
        '
        'pMat3Codigo
        '
        Me.pMat3Codigo.Description = "Codigo Material 3"
        Me.pMat3Codigo.Name = "pMat3Codigo"
        Me.pMat3Codigo.Visible = False
        '
        'pMat1Nombre
        '
        Me.pMat1Nombre.Description = "Parameter1"
        Me.pMat1Nombre.Name = "pMat1Nombre"
        Me.pMat1Nombre.Visible = False
        '
        'pMat2Nombre
        '
        Me.pMat2Nombre.Description = "Nombre Material 2"
        Me.pMat2Nombre.Name = "pMat2Nombre"
        Me.pMat2Nombre.Visible = False
        '
        'pMat3Nombre
        '
        Me.pMat3Nombre.Description = "Nombre Material 3"
        Me.pMat3Nombre.Name = "pMat3Nombre"
        Me.pMat3Nombre.Visible = False
        '
        'pMat1Porcentaje
        '
        Me.pMat1Porcentaje.Description = "Porcentaje Material 1"
        Me.pMat1Porcentaje.Name = "pMat1Porcentaje"
        Me.pMat1Porcentaje.Visible = False
        '
        'pMat2Porcentaje
        '
        Me.pMat2Porcentaje.Description = "Porcentaje Material 2"
        Me.pMat2Porcentaje.Name = "pMat2Porcentaje"
        Me.pMat2Porcentaje.Visible = False
        '
        'pMat3Porcentaje
        '
        Me.pMat3Porcentaje.Description = "Porcentaje Material 3"
        Me.pMat3Porcentaje.Name = "pMat3Porcentaje"
        Me.pMat3Porcentaje.Visible = False
        '
        'pMat1DescripcionCorta
        '
        Me.pMat1DescripcionCorta.Name = "pMat1DescripcionCorta"
        Me.pMat1DescripcionCorta.Visible = False
        '
        'pMat2DescripcionCorta
        '
        Me.pMat2DescripcionCorta.Name = "pMat2DescripcionCorta"
        Me.pMat2DescripcionCorta.Visible = False
        '
        'pMat3DescripcionCorta
        '
        Me.pMat3DescripcionCorta.Name = "pMat3DescripcionCorta"
        Me.pMat3DescripcionCorta.Visible = False
        '
        'DsEnsambleOrdenImpresion1
        '
        Me.DsEnsambleOrdenImpresion1.DataSetName = "dsEnsambleOrdenImpresion"
        Me.DsEnsambleOrdenImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLabel41
        '
        Me.XrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.CodigoArticulo")})
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(357.6272!, 24.99997!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(231.7322!, 44.48497!)
        Me.XrLabel41.Text = "XrLabel41"
        '
        'XrLabel47
        '
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.NombreArticulo")})
        Me.XrLabel47.Dpi = 254.0!
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(357.6272!, 72.48492!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(1029.919!, 93.07751!)
        Me.XrLabel47.Text = "XrLabel47"
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.SegundosXArticulo")})
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(1728.464!, 24.99993!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(243.5148!, 44.48497!)
        Me.XrLabel26.Text = "XrLabel26"
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.EnsamblesXHora")})
        Me.XrLabel32.Dpi = 254.0!
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(1728.464!, 72.48492!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(243.5148!, 45.08485!)
        Me.XrLabel32.Text = "XrLabel32"
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.MinutosXArticulo")})
        Me.XrLabel33.Dpi = 254.0!
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(1728.464!, 120.4775!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(243.5146!, 45.08502!)
        Me.XrLabel33.Text = "XrLabel33"
        '
        'XrLabel35
        '
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtParametrosEnsamble.EquipoPersonas")})
        Me.XrLabel35.Dpi = 254.0!
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(1240.489!, 24.99993!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(147.0579!, 44.48489!)
        Me.XrLabel35.Text = "XrLabel35"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtInstruccionesTrabajo.Descripcion")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(4.338943!, 48.085!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(973.3493!, 308.827!)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtInstruccionesTrabajo.PersonasEquipoSTD")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(376.6012!, 387.1214!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(164.0416!, 45.08511!)
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtInstruccionesTrabajo.EnfriamientoUnidades")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(818.5844!, 387.1214!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(159.1039!, 45.08511!)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrPanel4
        '
        Me.XrPanel4.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel4.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel6, Me.XrLabel7, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11})
        Me.XrPanel4.Dpi = 254.0!
        Me.XrPanel4.LocationFloat = New DevExpress.Utils.PointFloat(1024.891!, 252.6693!)
        Me.XrPanel4.Name = "XrPanel4"
        Me.XrPanel4.SizeF = New System.Drawing.SizeF(977.688!, 449.4356!)
        Me.XrPanel4.StylePriority.UseBackColor = False
        Me.XrPanel4.StylePriority.UseBorderColor = False
        Me.XrPanel4.StylePriority.UseBorders = False
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtInstruccionesTrabajo.EnfriamientoUnidades")})
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(797.4177!, 387.1214!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(159.1039!, 45.08511!)
        Me.XrLabel6.Text = "XrLabel5"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtInstruccionesTrabajo.PersonasEquipoSTD")})
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(376.6012!, 387.1214!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(164.0416!, 45.08511!)
        Me.XrLabel7.Text = "XrLabel4"
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(22.33083!, 387.1215!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(354.2704!, 45.08502!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Equip. Personas SDT"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(556.918!, 387.1213!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(240.4995!, 45.08496!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Unds. Enfriado"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.999978!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(969.1096!, 45.085!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "ADVERTENICIAS DE TRABAJO"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dadtAdvertenciasDeTrabajo.Descripcion")})
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(3.833584!, 48.08498!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(964.567!, 270.0866!)
        Me.XrLabel8.Text = "XrLabel8"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(24.99999!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(129.7802!, 45.08494!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Linea"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel13.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(154.7802!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(207.3834!, 45.08494!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Codigo"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel14.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(362.1635!, 0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(536.3011!, 45.08494!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Nombre Codigo"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel15.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(898.4647!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(164.1761!, 45.08494!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Cantidad"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel16.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(1062.641!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(165.9238!, 45.08494!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "U/Medida"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel17.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.ForeColor = System.Drawing.Color.Black
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(1228.566!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(194.3298!, 45.08494!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "U/Empaque"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel18.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.Black
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(1422.895!, 0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(560.6194!, 45.08494!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Comentarios"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12})
        Me.GroupHeader2.Dpi = 254.0!
        Me.GroupHeader2.HeightF = 45.08494!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.Dpi = 254.0!
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Dpi = 254.0!
        Me.Detail1.HeightF = 254.0!
        Me.Detail1.Name = "Detail1"
        '
        'xrptOrdenImpresionEnsamble
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1, Me.GroupHeader2, Me.DetailReport})
        Me.DataMember = "dsdtEnsambleOrdenImpresion"
        Me.DataSource = Me.DsEnsambleOrdenImpresion1
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formatMat3Porcentaje, Me.formatMat2Porcentaje})
        Me.Margins = New System.Drawing.Printing.Margins(79, 61, 118, 128)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pHorasRequeridas, Me.pTurnosRequeridos, Me.pUsuario, Me.pMat1Codigo, Me.pMat2Codigo, Me.pMat3Codigo, Me.pMat1Nombre, Me.pMat2Nombre, Me.pMat3Nombre, Me.pMat1Porcentaje, Me.pMat2Porcentaje, Me.pMat3Porcentaje, Me.pMat1DescripcionCorta, Me.pMat2DescripcionCorta, Me.pMat3DescripcionCorta})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "17.1"
        CType(Me.DsEnsambleOrdenImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pUsuario As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents pTurnosRequeridos As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pHorasRequeridas As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents pMat3DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents formatMat3Porcentaje As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents pMat2DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents formatMat2Porcentaje As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents pMat1DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat1Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat1Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents pMat1Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DsEnsambleOrdenImpresion1 As dsEnsambleOrdenImpresion
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel4 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
End Class
