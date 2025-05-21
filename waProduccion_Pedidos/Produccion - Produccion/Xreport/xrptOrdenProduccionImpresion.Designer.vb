<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrptOrdenProduccionImpresion
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
        Dim pHorasRequeridas As DevExpress.XtraReports.Parameters.Parameter
        Dim pTurnosRequeridos As DevExpress.XtraReports.Parameters.Parameter
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pUsuario = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DsOrdenProduccionImpresion1 = New waProduccion_Pedidos.dsOrdenProduccionImpresion()
        Me.DsdtProduccionPadresTableAdapter = New waProduccion_Pedidos.dsOrdenProduccionImpresionTableAdapters.dsdtProduccionPadresTableAdapter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo5 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo6 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat3DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.formatMat3Porcentaje = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat2DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.formatMat2Porcentaje = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat1DescripcionCorta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat3Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat3Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat2Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat1Porcentaje = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat2Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat1Nombre = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMat3Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat2Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pMat1Codigo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DsOrdenProduccionImpresion2 = New waProduccion_Pedidos.dsOrdenProduccionImpresion()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrSubreportOrdenProduccionComentarios = New DevExpress.XtraReports.UI.XRSubreport()
        pHorasRequeridas = New DevExpress.XtraReports.Parameters.Parameter()
        pTurnosRequeridos = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOrdenProduccionImpresion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pHorasRequeridas
        '
        pHorasRequeridas.Description = "Parameter1"
        pHorasRequeridas.Name = "pHorasRequeridas"
        pHorasRequeridas.Visible = False
        '
        'pTurnosRequeridos
        '
        pTurnosRequeridos.Description = "Parameter1"
        pTurnosRequeridos.Name = "pTurnosRequeridos"
        pTurnosRequeridos.Visible = False
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
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel65})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 118.3958!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel65.Text = "RESUMEN DE PRODUCCION"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
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
        'pUsuario
        '
        Me.pUsuario.Description = "Usuario APG"
        Me.pUsuario.Name = "pUsuario"
        Me.pUsuario.Visible = False
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Dpi = 254.0!
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(1162.002!, 35.71875!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(224.2083!, 58.41999!)
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo3.TextFormatString = "{0:hh:mm tt}"
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
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(15.87501!, 6.402878!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1986.703!, 26.67005!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1740.0!, 33.07292!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0!, 58.42001!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "Pagina {0}"
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
        'DsOrdenProduccionImpresion1
        '
        Me.DsOrdenProduccionImpresion1.DataSetName = "dsOrdenProduccionImpresion"
        Me.DsOrdenProduccionImpresion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsdtProduccionPadresTableAdapter
        '
        Me.DsdtProduccionPadresTableAdapter.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo4, Me.XrPageInfo5, Me.XrLabel27, Me.XrPageInfo6, Me.XrPanel3, Me.XrLabel44, Me.XrPanel1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 781.9552!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.BorderColor = System.Drawing.Color.LightGray
        Me.XrPageInfo4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPageInfo4.Dpi = 254.0!
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(326.5205!, 713.7599!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(593.5475!, 58.42!)
        Me.XrPageInfo4.StylePriority.UseBorderColor = False
        Me.XrPageInfo4.StylePriority.UseBorders = False
        Me.XrPageInfo4.StylePriority.UseTextAlignment = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo5
        '
        Me.XrPageInfo5.BorderColor = System.Drawing.Color.LightGray
        Me.XrPageInfo5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPageInfo5.Dpi = 254.0!
        Me.XrPageInfo5.LocationFloat = New DevExpress.Utils.PointFloat(930.0681!, 713.7599!)
        Me.XrPageInfo5.Name = "XrPageInfo5"
        Me.XrPageInfo5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo5.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo5.SizeF = New System.Drawing.SizeF(224.2083!, 58.41999!)
        Me.XrPageInfo5.StylePriority.UseBorderColor = False
        Me.XrPageInfo5.StylePriority.UseBorders = False
        Me.XrPageInfo5.StylePriority.UseTextAlignment = False
        Me.XrPageInfo5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPageInfo5.TextFormatString = "{0:hh:mm tt}"
        '
        'XrLabel27
        '
        Me.XrLabel27.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel27.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pUsuario, "Text", "")})
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(1164.276!, 713.7599!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(353.7896!, 58.42!)
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "XrLabel66"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo6
        '
        Me.XrPageInfo6.BorderColor = System.Drawing.Color.LightGray
        Me.XrPageInfo6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPageInfo6.Dpi = 254.0!
        Me.XrPageInfo6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo6.LocationFloat = New DevExpress.Utils.PointFloat(1528.066!, 713.7599!)
        Me.XrPageInfo6.Name = "XrPageInfo6"
        Me.XrPageInfo6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo6.SizeF = New System.Drawing.SizeF(161.125!, 58.41998!)
        Me.XrPageInfo6.StylePriority.UseBorderColor = False
        Me.XrPageInfo6.StylePriority.UseBorders = False
        Me.XrPageInfo6.StylePriority.UseFont = False
        Me.XrPageInfo6.StylePriority.UseTextAlignment = False
        Me.XrPageInfo6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPageInfo6.TextFormatString = "Pagina {0}"
        '
        'XrPanel3
        '
        Me.XrPanel3.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel3.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel33, Me.XrLabel38, Me.XrLabel31, Me.XrLabel26, Me.XrLabel28, Me.XrLabel35, Me.XrLabel32, Me.XrLabel37, Me.XrLabel30, Me.XrLabel25, Me.XrLabel48, Me.XrLabel47, Me.XrLabel40, Me.XrLabel39})
        Me.XrPanel3.Dpi = 254.0!
        Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(11.53647!, 58.20831!)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.SizeF = New System.Drawing.SizeF(1991.042!, 182.5625!)
        Me.XrPanel3.StylePriority.UseBackColor = False
        Me.XrPanel3.StylePriority.UseBorderColor = False
        Me.XrPanel3.StylePriority.UseBorders = False
        '
        'XrLabel33
        '
        Me.XrLabel33.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosMolde.Cavidades")})
        Me.XrLabel33.Dpi = 254.0!
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(770.016!, 24.40001!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(147.0576!, 45.08495!)
        Me.XrLabel33.StylePriority.UseBorderColor = False
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel38
        '
        Me.XrLabel38.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel38.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosMolde.Unidades")})
        Me.XrLabel38.Dpi = 254.0!
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(1303.049!, 24.40006!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(146.2313!, 45.08493!)
        Me.XrLabel38.StylePriority.UseBorderColor = False
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "XrLabel38"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel31.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel31.Dpi = 254.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Black
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(1147.465!, 24.40001!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(154.7573!, 45.08497!)
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Unidades"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel26
        '
        Me.XrLabel26.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel26.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.ForeColor = System.Drawing.Color.Black
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(589.3594!, 24.40001!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(180.6571!, 45.08497!)
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Cavidades"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(346.5044!, 45.08495!)
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Maquina Preferencial"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosMolde.MaquinaPreferencial")})
        Me.XrLabel35.Dpi = 254.0!
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(1818.488!, 120.4775!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(153.4902!, 45.08502!)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "XrLabel35"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosMolde.Bodega")})
        Me.XrLabel32.Dpi = 254.0!
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(1677.655!, 24.40002!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(294.3224!, 45.08493!)
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "XrLabel32"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel37.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosMolde.Ubicacion")})
        Me.XrLabel37.Dpi = 254.0!
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(1677.655!, 72.48488!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(294.3224!, 45.08496!)
        Me.XrLabel37.StylePriority.UseBorderColor = False
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "XrLabel37"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel30.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel30.Dpi = 254.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.ForeColor = System.Drawing.Color.Black
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(1471.983!, 72.48492!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(205.6719!, 45.08497!)
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Ubicación"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel25.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.ForeColor = System.Drawing.Color.Black
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(1471.983!, 24.40006!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(205.6719!, 45.08493!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Bodega"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel48
        '
        Me.XrLabel48.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel48.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosCodigosProducidos.Descripcion")})
        Me.XrLabel48.Dpi = 254.0!
        Me.XrLabel48.ForeColor = System.Drawing.Color.Black
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(357.6272!, 72.48495!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(1091.653!, 93.07755!)
        Me.XrLabel48.StylePriority.UseBorderColor = False
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseForeColor = False
        Me.XrLabel48.Text = "XrLabel48"
        '
        'XrLabel47
        '
        Me.XrLabel47.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel47.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosCodigosProducidos.Id")})
        Me.XrLabel47.Dpi = 254.0!
        Me.XrLabel47.ForeColor = System.Drawing.Color.Black
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(357.6272!, 24.40001!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(230.9279!, 45.08495!)
        Me.XrLabel47.StylePriority.UseBorderColor = False
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseForeColor = False
        Me.XrLabel47.Text = "XrLabel47"
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
        Me.XrLabel39.Text = "Codigo Producido"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.XrLabel44.Text = "PARAMETROS DE CODIGOS PRODUCIDOS (CP)"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel1.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel81, Me.XrLabel82, Me.XrLabel83, Me.XrLabel80, Me.XrLabel79, Me.XrLabel77, Me.XrLabel76, Me.XrLabel75, Me.XrLabel74, Me.XrLabel73, Me.XrPanel2, Me.XrLabel15, Me.XrLabel24, Me.XrLabel21, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel13, Me.XrLabel22, Me.XrLabel23, Me.XrLabel14, Me.XrLabel4, Me.XrLabel12, Me.XrLabel7, Me.XrLabel9, Me.XrLabel11, Me.XrLabel10, Me.XrLabel3, Me.XrLabel6, Me.XrLabel5, Me.XrLabel8, Me.XrLabel46})
        Me.XrPanel1.Dpi = 254.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(11.53608!, 252.6693!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(1991.042!, 449.4356!)
        Me.XrPanel1.StylePriority.UseBackColor = False
        Me.XrPanel1.StylePriority.UseBorderColor = False
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel81
        '
        Me.XrLabel81.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel81.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel81.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel81.Dpi = 254.0!
        Me.XrLabel81.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel81.ForeColor = System.Drawing.Color.Black
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(1778.061!, 110.6659!)
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(189.5582!, 45.08496!)
        Me.XrLabel81.StylePriority.UseBackColor = False
        Me.XrLabel81.StylePriority.UseBorderColor = False
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseForeColor = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "X Turno"
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel82.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.Dpi = 254.0!
        Me.XrLabel82.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel82.ForeColor = System.Drawing.Color.Black
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(1582.915!, 110.6659!)
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(190.1458!, 45.08499!)
        Me.XrLabel82.StylePriority.UseBackColor = False
        Me.XrLabel82.StylePriority.UseBorderColor = False
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseForeColor = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "X Hora"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel83
        '
        Me.XrLabel83.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel83.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel83.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.Dpi = 254.0!
        Me.XrLabel83.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel83.ForeColor = System.Drawing.Color.Black
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(1582.915!, 62.50036!)
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(384.7037!, 45.08496!)
        Me.XrLabel83.StylePriority.UseBackColor = False
        Me.XrLabel83.StylePriority.UseBorderColor = False
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseForeColor = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "Unidades"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel80.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel80.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.Dpi = 254.0!
        Me.XrLabel80.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel80.ForeColor = System.Drawing.Color.Black
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(589.3589!, 62.50036!)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(384.7037!, 45.08496!)
        Me.XrLabel80.StylePriority.UseBackColor = False
        Me.XrLabel80.StylePriority.UseBorderColor = False
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseForeColor = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "Ciclos"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel79
        '
        Me.XrLabel79.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel79.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel79.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel79.Dpi = 254.0!
        Me.XrLabel79.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel79.ForeColor = System.Drawing.Color.Black
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(22.33084!, 62.50036!)
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(547.4163!, 45.0849!)
        Me.XrLabel79.StylePriority.UseBackColor = False
        Me.XrLabel79.StylePriority.UseBorderColor = False
        Me.XrLabel79.StylePriority.UseBorders = False
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseForeColor = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "Segundos X Ciclo"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel77.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel77.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel77.Dpi = 254.0!
        Me.XrLabel77.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel77.ForeColor = System.Drawing.Color.Black
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(994.0635!, 62.50054!)
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(568.8526!, 45.0849!)
        Me.XrLabel77.StylePriority.UseBackColor = False
        Me.XrLabel77.StylePriority.UseBorderColor = False
        Me.XrLabel77.StylePriority.UseBorders = False
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UseForeColor = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.Text = "PESO EN GRMS POR COMPONENTE"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel76
        '
        Me.XrLabel76.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel76.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(pTurnosRequeridos, "Text", "")})
        Me.XrLabel76.Dpi = 254.0!
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 387.1213!)
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(188.145!, 45.08502!)
        Me.XrLabel76.StylePriority.UseBorderColor = False
        Me.XrLabel76.StylePriority.UseBorders = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.Text = "XrLabel76"
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel75
        '
        Me.XrLabel75.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel75.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(pHorasRequeridas, "Text", "")})
        Me.XrLabel75.Dpi = 254.0!
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 330.4536!)
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(188.1452!, 45.08502!)
        Me.XrLabel75.StylePriority.UseBorderColor = False
        Me.XrLabel75.StylePriority.UseBorders = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.Text = "XrLabel75"
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.XrLabel74.Text = "Turnos Requeridos"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel73
        '
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel73.Dpi = 254.0!
        Me.XrLabel73.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(22.33083!, 330.4536!)
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(354.2704!, 45.08496!)
        Me.XrLabel73.StylePriority.UseBorders = False
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "Horas Requeridas"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPanel2
        '
        Me.XrPanel2.BorderColor = System.Drawing.Color.Silver
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel36, Me.XrLabel34, Me.XrLabel29, Me.XrLabel88, Me.XrLabel87, Me.XrLabel86, Me.XrLabel84, Me.XrLabel49, Me.XrLabel53, Me.XrLabel43, Me.XrLabel52, Me.XrLabel42, Me.XrLabel50})
        Me.XrPanel2.Dpi = 254.0!
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(589.3591!, 214.9566!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(1378.26!, 217.2498!)
        Me.XrPanel2.StylePriority.UseBorderColor = False
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat3DescripcionCorta, "Text", "")})
        Me.XrLabel36.Dpi = 254.0!
        Me.XrLabel36.FormattingRules.Add(Me.formatMat3Porcentaje)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(142.957!, 165.1652!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(176.2158!, 41.93309!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "XrLabel36"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pMat3DescripcionCorta
        '
        Me.pMat3DescripcionCorta.Name = "pMat3DescripcionCorta"
        Me.pMat3DescripcionCorta.Visible = False
        '
        'formatMat3Porcentaje
        '
        Me.formatMat3Porcentaje.Condition = "[Parameters.pMat3Porcentaje] = ''"
        Me.formatMat3Porcentaje.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.formatMat3Porcentaje.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.formatMat3Porcentaje.Name = "formatMat3Porcentaje"
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat2DescripcionCorta, "Text", "")})
        Me.XrLabel34.Dpi = 254.0!
        Me.XrLabel34.FormattingRules.Add(Me.formatMat2Porcentaje)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(142.9569!, 115.4971!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(176.2159!, 39.87018!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pMat2DescripcionCorta
        '
        Me.pMat2DescripcionCorta.Name = "pMat2DescripcionCorta"
        Me.pMat2DescripcionCorta.Visible = False
        '
        'formatMat2Porcentaje
        '
        Me.formatMat2Porcentaje.Condition = "[Parameters.pMat2Porcentaje] = ''"
        Me.formatMat2Porcentaje.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.formatMat2Porcentaje.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.formatMat2Porcentaje.Name = "formatMat2Porcentaje"
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat1DescripcionCorta, "Text", "")})
        Me.XrLabel29.Dpi = 254.0!
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(142.9569!, 57.43577!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(176.457!, 44.28505!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "XrLabel29"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pMat1DescripcionCorta
        '
        Me.pMat1DescripcionCorta.Name = "pMat1DescripcionCorta"
        Me.pMat1DescripcionCorta.Visible = False
        '
        'XrLabel88
        '
        Me.XrLabel88.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel88.CanGrow = False
        Me.XrLabel88.Dpi = 254.0!
        Me.XrLabel88.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel88.FormattingRules.Add(Me.formatMat3Porcentaje)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(97.97186!, 165.1652!)
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(44.74388!, 41.93306!)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.Text = "%"
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat3Porcentaje, "Text", "")})
        Me.XrLabel87.Dpi = 254.0!
        Me.XrLabel87.FormattingRules.Add(Me.formatMat3Porcentaje)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(25.39605!, 165.1652!)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(72.57585!, 41.93324!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "XrLabel87"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'pMat3Porcentaje
        '
        Me.pMat3Porcentaje.Description = "Porcentaje Material 3"
        Me.pMat3Porcentaje.Name = "pMat3Porcentaje"
        Me.pMat3Porcentaje.Visible = False
        '
        'XrLabel86
        '
        Me.XrLabel86.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel86.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat3Nombre, "Text", "")})
        Me.XrLabel86.Dpi = 254.0!
        Me.XrLabel86.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel86.LocationFloat = New DevExpress.Utils.PointFloat(328.9316!, 165.1652!)
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel86.SizeF = New System.Drawing.SizeF(1024.328!, 41.93304!)
        Me.XrLabel86.StylePriority.UseBorders = False
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.Text = "XrLabel86"
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pMat3Nombre
        '
        Me.pMat3Nombre.Description = "Nombre Material 3"
        Me.pMat3Nombre.Name = "pMat3Nombre"
        Me.pMat3Nombre.Visible = False
        '
        'XrLabel84
        '
        Me.XrLabel84.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel84.CanGrow = False
        Me.XrLabel84.Dpi = 254.0!
        Me.XrLabel84.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel84.FormattingRules.Add(Me.formatMat2Porcentaje)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(98.21301!, 115.4971!)
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(44.74389!, 39.8701!)
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "%"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.Dpi = 254.0!
        Me.XrLabel49.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(98.21301!, 57.03593!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(44.74393!, 44.68494!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "%"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat2Porcentaje, "Text", "")})
        Me.XrLabel53.Dpi = 254.0!
        Me.XrLabel53.FormattingRules.Add(Me.formatMat2Porcentaje)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(26.82659!, 115.4971!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(71.38628!, 39.87015!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "XrLabel53"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'pMat2Porcentaje
        '
        Me.pMat2Porcentaje.Description = "Porcentaje Material 2"
        Me.pMat2Porcentaje.Name = "pMat2Porcentaje"
        Me.pMat2Porcentaje.Visible = False
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat1Porcentaje, "Text", "")})
        Me.XrLabel43.Dpi = 254.0!
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(26.82659!, 57.43578!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(71.38641!, 44.28504!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "XrLabel43"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'pMat1Porcentaje
        '
        Me.pMat1Porcentaje.Description = "Porcentaje Material 1"
        Me.pMat1Porcentaje.Name = "pMat1Porcentaje"
        Me.pMat1Porcentaje.Visible = False
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat2Nombre, "Text", "")})
        Me.XrLabel52.Dpi = 254.0!
        Me.XrLabel52.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(329.1729!, 115.4971!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(1024.087!, 39.87018!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "XrLabel52"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pMat2Nombre
        '
        Me.pMat2Nombre.Description = "Nombre Material 2"
        Me.pMat2Nombre.Name = "pMat2Nombre"
        Me.pMat2Nombre.Visible = False
        '
        'XrLabel42
        '
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel42.CanGrow = False
        Me.XrLabel42.CanShrink = True
        Me.XrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pMat1Nombre, "Text", "")})
        Me.XrLabel42.Dpi = 254.0!
        Me.XrLabel42.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(329.1729!, 56.63583!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(1024.087!, 45.08502!)
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "XrLabel42"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel42.WordWrap = False
        '
        'pMat1Nombre
        '
        Me.pMat1Nombre.Description = "Parameter1"
        Me.pMat1Nombre.Name = "pMat1Nombre"
        Me.pMat1Nombre.Visible = False
        '
        'XrLabel50
        '
        Me.XrLabel50.BackColor = System.Drawing.Color.SkyBlue
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel50.Dpi = 254.0!
        Me.XrLabel50.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(1.574893!, 1.999948!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(1375.108!, 42.08493!)
        Me.XrLabel50.StylePriority.UseBackColor = False
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "MATERIALES"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.Ciclo")})
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(22.33069!, 156.7503!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(172.1355!, 45.08493!)
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel24.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.Sacos25KG")})
        Me.XrLabel24.Dpi = 254.0!
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 271.9925!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(188.1454!, 45.0849!)
        Me.XrLabel24.StylePriority.UseBorderColor = False
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel21.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.PesoInyeccionGrms")})
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(994.0635!, 156.7506!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(185.8535!, 45.08499!)
        Me.XrLabel21.StylePriority.UseBorderColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.CicloHora")})
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(589.3589!, 156.7504!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(193.1456!, 45.08496!)
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.CicloMax")})
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 156.7503!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(188.1454!, 45.08499!)
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.CicloMin")})
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(199.466!, 156.7503!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(177.1353!, 45.08496!)
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.CicloTurno")})
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(786.5045!, 156.7506!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(187.5582!, 45.08493!)
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.LbHora")})
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 214.9566!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(188.1456!, 45.08493!)
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel13.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.ArticulosHora", "{0:#,#}")})
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1582.915!, 156.7503!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(190.1459!, 45.08499!)
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.RangoPesoGrmsMax")})
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1376.063!, 156.7508!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(186.8534!, 45.08499!)
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel23.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.RangoPesoGrmsMin")})
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1183.917!, 156.7508!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(187.8535!, 45.0849!)
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dsdtImpresionDatosProduccion.ArticulosTurno", "{0:#,#}")})
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1778.061!, 156.7503!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(189.5574!, 45.08493!)
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel4.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(589.3589!, 110.6659!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(193.1457!, 45.08496!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "X Hora"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(22.33069!, 271.9925!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(354.2705!, 45.08502!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Sacos Dia [25kg]"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel7.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(786.5045!, 110.666!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(187.5585!, 45.0849!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "X Turno"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel9.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(994.0635!, 110.666!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(185.8535!, 45.08496!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = " Estándar"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel11.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1183.917!, 110.6659!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(187.8535!, 45.08493!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Minimo"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel10.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1376.063!, 110.6659!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(186.8534!, 45.08493!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Maximo"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel3.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(22.33069!, 110.6658!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(172.1354!, 45.08496!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Ciclo"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel6.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(199.466!, 110.6658!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(177.1353!, 45.08502!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Minimo"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrLabel5.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(381.6016!, 110.666!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(188.1454!, 45.08496!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Maximo"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(22.33069!, 214.9566!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(354.2705!, 45.08493!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Libras Hora"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel46
        '
        Me.XrLabel46.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.Dpi = 254.0!
        Me.XrLabel46.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(3.000008!, 3.000008!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(1985.191!, 45.085!)
        Me.XrLabel46.StylePriority.UseBackColor = False
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "PARAMETROS DE PRODUCCIÓN"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pMat3Codigo
        '
        Me.pMat3Codigo.Description = "Codigo Material 3"
        Me.pMat3Codigo.Name = "pMat3Codigo"
        Me.pMat3Codigo.Visible = False
        '
        'pMat2Codigo
        '
        Me.pMat2Codigo.Description = "Codigo Material 2"
        Me.pMat2Codigo.Name = "pMat2Codigo"
        Me.pMat2Codigo.Visible = False
        '
        'pMat1Codigo
        '
        Me.pMat1Codigo.Description = "Codigo Material 1"
        Me.pMat1Codigo.Name = "pMat1Codigo"
        Me.pMat1Codigo.Visible = False
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
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLabel58, Me.XrLabel60, Me.XrLabel61, Me.XrLabel55, Me.XrLabel56})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.HeightF = 45.08516!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
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
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel63, Me.XrLabel62, Me.XrLabel54})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.HeightF = 62.28286!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.XrLabel63.BackColor = System.Drawing.Color.Gainsboro
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
        Me.XrLabel62.BackColor = System.Drawing.Color.Gainsboro
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
        Me.XrLabel54.BackColor = System.Drawing.Color.Gainsboro
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
        'DsOrdenProduccionImpresion2
        '
        Me.DsOrdenProduccionImpresion2.DataSetName = "dsOrdenProduccionImpresion"
        Me.DsOrdenProduccionImpresion2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreportOrdenProduccionComentarios})
        Me.GroupFooter2.Dpi = 254.0!
        Me.GroupFooter2.HeightF = 102.2087!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrSubreportOrdenProduccionComentarios
        '
        Me.XrSubreportOrdenProduccionComentarios.Dpi = 254.0!
        Me.XrSubreportOrdenProduccionComentarios.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.XrSubreportOrdenProduccionComentarios.Name = "XrSubreportOrdenProduccionComentarios"
        Me.XrSubreportOrdenProduccionComentarios.SizeF = New System.Drawing.SizeF(1974.73!, 58.42!)
        '
        'xrptOrdenProduccionImpresion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter2})
        Me.DataMember = "dsdtImpresionDatosCodigosProducidos"
        Me.DataSource = Me.DsOrdenProduccionImpresion1
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formatMat3Porcentaje, Me.formatMat2Porcentaje})
        Me.Margins = New System.Drawing.Printing.Margins(79, 61, 118, 128)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {pHorasRequeridas, pTurnosRequeridos, Me.pUsuario, Me.pMat1Codigo, Me.pMat2Codigo, Me.pMat3Codigo, Me.pMat1Nombre, Me.pMat2Nombre, Me.pMat3Nombre, Me.pMat1Porcentaje, Me.pMat2Porcentaje, Me.pMat3Porcentaje, Me.pMat1DescripcionCorta, Me.pMat2DescripcionCorta, Me.pMat3DescripcionCorta})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "19.2"
        CType(Me.DsOrdenProduccionImpresion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOrdenProduccionImpresion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsOrdenProduccionImpresion1 As waProduccion_Pedidos.dsOrdenProduccionImpresion
    Friend WithEvents DsdtProduccionPadresTableAdapter As waProduccion_Pedidos.dsOrdenProduccionImpresionTableAdapters.dsdtProduccionPadresTableAdapter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsOrdenProduccionImpresion2 As waProduccion_Pedidos.dsOrdenProduccionImpresion
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pUsuario As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMat1Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMat1Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat1Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Codigo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Nombre As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat2Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pMat3Porcentaje As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents formatMat3Porcentaje As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents formatMat2Porcentaje As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo5 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo6 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMat3DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMat2DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMat1DescripcionCorta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrSubreportOrdenProduccionComentarios As DevExpress.XtraReports.UI.XRSubreport
End Class
