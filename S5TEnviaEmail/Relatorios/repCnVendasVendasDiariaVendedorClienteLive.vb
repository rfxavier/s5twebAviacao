Public Class repCnVendasVendasDiariaVendedorClienteLive
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents parRepDataFinal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents parRepDataInicial As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupCNPJCliente As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupNF As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents cfGroupClienteLoja As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfValorProdutoComDesconto As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents parRepCodVendedor As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repCnVendasVendasDiariaVendedorClienteLive))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim Parameter2 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim Parameter3 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim Parameter4 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim Parameter5 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.parRepDataFinal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.parRepDataInicial = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupCNPJCliente = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupNF = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.cfGroupClienteLoja = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfValorProdutoComDesconto = New DevExpress.XtraReports.UI.CalculatedField()
        Me.parRepCodVendedor = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.ObjectDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label5, Me.XrLabel37, Me.XrLabel16, Me.XrLabel32, Me.XrLabel1, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel9})
        Me.Detail.HeightF = 15!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'label5
        '
        Me.label5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_TOTAL_PRODUTO", "{0:n2}")})
        Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(550.2928!, 0!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(78.02435!, 14.99999!)
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel37
        '
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pUNIDADE", "{0:#,#}")})
        Me.XrLabel37.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(503.1875!, 0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(37.64691!, 15!)
        Me.XrLabel37.StylePriority.UseFont = false
        Me.XrLabel37.StylePriority.UseTextAlignment = false
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_ST", "{0:n2}")})
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(745.2266!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(65.77344!, 14.99999!)
        Me.XrLabel16.StylePriority.UseBackColor = false
        Me.XrLabel16.StylePriority.UseFont = false
        Me.XrLabel16.StylePriority.UseTextAlignment = false
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_DESCONTO", "{0:n2}")})
        Me.XrLabel32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(672.5146!, 0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(66.93011!, 14.99999!)
        Me.XrLabel32.StylePriority.UseBackColor = false
        Me.XrLabel32.StylePriority.UseFont = false
        Me.XrLabel32.StylePriority.UseTextAlignment = false
        Me.XrLabel32.Text = "XrLabel32"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pNUMERO_NF")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(7.685059!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(72!, 15!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pLOJA")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(92.04299!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(30.20833!, 15!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPRODUTO")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(122.2513!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(51.58334!, 15!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pDESCRICAO")})
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(173.8347!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(265.0453!, 15!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.Text = "XrLabel6"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pQUANTIDADE", "{0:#,#}")})
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(454.0822!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(49.10535!, 15!)
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.StylePriority.UseTextAlignment = false
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label3, Me.label2, Me.label1, Me.XrLine1, Me.XrLabel10, Me.XrLabel24, Me.XrLabel11, Me.XrLine3, Me.XrPictureBox1, Me.XrLabel18})
        Me.TopMargin.HeightF = 150!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Tahoma", 9!)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(173.8346!, 125.3507!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(22.77182!, 15!)
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.Text = "a"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label2
        '
        Me.label2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.parRepDataFinal, "Text", "{0:dd/MM/yyyy}")})
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9!)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(196.6064!, 125.7013!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(100!, 14.64936!)
        Me.label2.StylePriority.UseFont = false
        Me.label2.Text = "label2"
        '
        'parRepDataFinal
        '
        Me.parRepDataFinal.Name = "parRepDataFinal"
        Me.parRepDataFinal.Type = GetType(Date)
        Me.parRepDataFinal.ValueInfo = "2018-05-08"
        Me.parRepDataFinal.Visible = false
        '
        'label1
        '
        Me.label1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.parRepDataInicial, "Text", "{0:dd/MM/yyyy}")})
        Me.label1.Font = New System.Drawing.Font("Tahoma", 9!)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(104.0001!, 125.7013!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(69.83455!, 14.64937!)
        Me.label1.StylePriority.UseFont = false
        Me.label1.Text = "label1"
        '
        'parRepDataInicial
        '
        Me.parRepDataInicial.Description = "Data Inicial"
        Me.parRepDataInicial.Name = "parRepDataInicial"
        Me.parRepDataInicial.Type = GetType(Date)
        Me.parRepDataInicial.ValueInfo = "2018-05-08"
        Me.parRepDataInicial.Visible = false
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(7.685059!, 141.25!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(809.6299!, 2!)
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pNOME_VENDEDOR")})
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(104.0001!, 109.3507!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(304.6715!, 15!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.Text = "XrLabel10"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(8!, 109.3507!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(72!, 15!)
        Me.XrLabel24.StylePriority.UseFont = false
        Me.XrLabel24.Text = "Vendedor:"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(8!, 125.3507!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(96.00007!, 15!)
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.Text = "Período:"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(8!, 102.3507!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(809.6299!, 2!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"),System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(8!, 17.6493!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(96.00007!, 64.70141!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 16!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(104.0001!, 17.6493!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(706.9999!, 64.70142!)
        Me.XrLabel18.StylePriority.UseFont = false
        Me.XrLabel18.StylePriority.UseTextAlignment = false
        Me.XrLabel18.Text = "Relatório diário de Vendas por Vendedor"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 19!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.BottomMargin.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel44, Me.XrPageInfo2, Me.XrLabel25, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 37.99998!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel44
        '
        Me.XrLabel44.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(7.685057!, 0!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(716.7917!, 15!)
        Me.XrLabel44.StylePriority.UseFont = false
        Me.XrLabel44.Text = "(*) => Valor total do item na nota fiscal LÍQUIDO (sem valor ST e sem valor DESCO"& _ 
    "NTO)"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 8!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(7.685065!, 21.00004!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(217.6997!, 14.75!)
        Me.XrPageInfo2.StylePriority.UseFont = false
        Me.XrPageInfo2.StylePriority.UseTextAlignment = false
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(722.4666!, 21.00004!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(48.91199!, 14.75!)
        Me.XrLabel25.StylePriority.UseFont = false
        Me.XrLabel25.StylePriority.UseTextAlignment = false
        Me.XrLabel25.Text = "Pág.:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(771.3786!, 21.00004!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(45.93634!, 14.75!)
        Me.XrPageInfo1.StylePriority.UseFont = false
        Me.XrPageInfo1.StylePriority.UseTextAlignment = false
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel43, Me.XrLabel42, Me.XrLabel26, Me.XrLabel15})
        Me.ReportFooter.HeightF = 22.91667!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel43
        '
        Me.XrLabel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_ST")})
        Me.XrLabel43.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(745.2266!, 4.000028!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(65.7735!, 15!)
        Me.XrLabel43.StylePriority.UseBackColor = false
        Me.XrLabel43.StylePriority.UseFont = false
        Me.XrLabel43.StylePriority.UseTextAlignment = false
        XrSummary1.FormatString = "{0:n}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel43.Summary = XrSummary1
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel42
        '
        Me.XrLabel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_DESCONTO")})
        Me.XrLabel42.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(672.5146!, 3.999964!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(66.93011!, 15!)
        Me.XrLabel42.StylePriority.UseBackColor = false
        Me.XrLabel42.StylePriority.UseFont = false
        Me.XrLabel42.StylePriority.UseTextAlignment = false
        XrSummary2.FormatString = "{0:n}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel42.Summary = XrSummary2
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_TOTAL_PRODUTO")})
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(550.293!, 4.00004!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(78.38861!, 15!)
        Me.XrLabel26.StylePriority.UseFont = false
        Me.XrLabel26.StylePriority.UseTextAlignment = false
        XrSummary3.FormatString = "{0:n}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel26.Summary = XrSummary3
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(462.446!, 4.00004!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(78.38843!, 15!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.StylePriority.UseTextAlignment = false
        Me.XrLabel15.Text = "Total Geral:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupCNPJCliente
        '
        Me.GroupCNPJCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel51, Me.XrLabel50, Me.XrLabel39, Me.XrLabel30, Me.XrLabel27, Me.XrLabel49, Me.XrLabel48, Me.XrLabel47, Me.XrLabel46, Me.XrLabel45, Me.XrLabel8, Me.XrLabel38, Me.XrLabel2})
        Me.GroupCNPJCliente.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("pCNPJCLIENTE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupCNPJCliente.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupCNPJCliente.HeightF = 64.37503!
        Me.GroupCNPJCliente.KeepTogether = true
        Me.GroupCNPJCliente.Level = 1
        Me.GroupCNPJCliente.Name = "GroupCNPJCliente"
        Me.GroupCNPJCliente.RepeatEveryPage = true
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(8.000032!, 47.37501!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(67.56354!, 15!)
        Me.XrLabel51.StylePriority.UseFont = false
        Me.XrLabel51.StylePriority.UseTextAlignment = false
        Me.XrLabel51.Text = "Cidade:"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(586.5285!, 47.37501!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(42.51746!, 15!)
        Me.XrLabel50.StylePriority.UseFont = false
        Me.XrLabel50.StylePriority.UseTextAlignment = false
        Me.XrLabel50.Text = "Estado:"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(586.1642!, 32.37502!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(42.51746!, 15!)
        Me.XrLabel39.StylePriority.UseFont = false
        Me.XrLabel39.StylePriority.UseTextAlignment = false
        Me.XrLabel39.Text = "Bairro:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(8!, 32.37502!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(67.56354!, 15!)
        Me.XrLabel30.StylePriority.UseFont = false
        Me.XrLabel30.StylePriority.UseTextAlignment = false
        Me.XrLabel30.Text = "Endereço:"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(8!, 17.37502!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(67.56354!, 15!)
        Me.XrLabel27.StylePriority.UseFont = false
        Me.XrLabel27.StylePriority.UseTextAlignment = false
        Me.XrLabel27.Text = "Cliente:"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(8.000032!, 0!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(135.5417!, 15!)
        Me.XrLabel49.StylePriority.UseFont = false
        Me.XrLabel49.Text = "Dados do Cliente:"
        '
        'XrLabel48
        '
        Me.XrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pESTADO_CLIENTE")})
        Me.XrLabel48.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(630.5099!, 47.37501!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(79.90198!, 15!)
        Me.XrLabel48.StylePriority.UseFont = false
        Me.XrLabel48.StylePriority.UseTextAlignment = false
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel48.WordWrap = false
        '
        'XrLabel47
        '
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pCIDADE_CLIENTE")})
        Me.XrLabel47.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(75.56354!, 47.37501!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(498.2966!, 15!)
        Me.XrLabel47.StylePriority.UseFont = false
        Me.XrLabel47.WordWrap = false
        '
        'XrLabel46
        '
        Me.XrLabel46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pBAIRRO_CLIENTE")})
        Me.XrLabel46.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(630.5099!, 32.37502!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(180.4901!, 15!)
        Me.XrLabel46.StylePriority.UseFont = false
        Me.XrLabel46.WordWrap = false
        '
        'XrLabel45
        '
        Me.XrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pEND_CLIENTE")})
        Me.XrLabel45.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(75.56354!, 32.37502!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(498.2966!, 15!)
        Me.XrLabel45.StylePriority.UseFont = false
        Me.XrLabel45.WordWrap = false
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(586.5285!, 17.37502!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(42.15314!, 15!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "Loja:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pLOJA")})
        Me.XrLabel38.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(630.5099!, 17.37502!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(79.90198!, 15!)
        Me.XrLabel38.StylePriority.UseFont = false
        Me.XrLabel38.StylePriority.UseTextAlignment = false
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel38.WordWrap = false
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pNOME_CLIENTE")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(75.56354!, 17.37502!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(498.2966!, 15!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.WordWrap = false
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLabel22, Me.XrLabel35, Me.XrLabel34, Me.XrLabel28})
        Me.GroupFooter1.HeightF = 23.95833!
        Me.GroupFooter1.KeepTogether = true
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLine4
        '
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(462.446!, 21.25001!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(354.869!, 2!)
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(373.3058!, 4.166654!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(167.5287!, 15!)
        Me.XrLabel22.StylePriority.UseFont = false
        Me.XrLabel22.StylePriority.UseTextAlignment = false
        Me.XrLabel22.Text = "Total NF:"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_ST")})
        Me.XrLabel35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(745.2264!, 4.166667!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(65.77362!, 14.99999!)
        Me.XrLabel35.StylePriority.UseBackColor = false
        Me.XrLabel35.StylePriority.UseFont = false
        Me.XrLabel35.StylePriority.UseTextAlignment = false
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel35.Summary = XrSummary4
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel34
        '
        Me.XrLabel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_DESCONTO")})
        Me.XrLabel34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(672.5146!, 4.166667!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(66.93018!, 14.99999!)
        Me.XrLabel34.StylePriority.UseBackColor = false
        Me.XrLabel34.StylePriority.UseFont = false
        Me.XrLabel34.StylePriority.UseTextAlignment = false
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel34.Summary = XrSummary5
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_TOTAL_PRODUTO")})
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(550.2928!, 4.166654!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(78.38855!, 15!)
        Me.XrLabel28.StylePriority.UseFont = false
        Me.XrLabel28.StylePriority.UseTextAlignment = false
        XrSummary6.FormatString = "{0:n}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel28.Summary = XrSummary6
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel41, Me.XrLabel40, Me.XrLabel29, Me.XrLine2, Me.XrLabel3})
        Me.GroupFooter3.HeightF = 26.04167!
        Me.GroupFooter3.KeepTogether = true
        Me.GroupFooter3.Level = 1
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'XrLabel41
        '
        Me.XrLabel41.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_ST")})
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(746.6114!, 3.000005!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(64.38867!, 15!)
        Me.XrLabel41.StylePriority.UseBackColor = false
        Me.XrLabel41.StylePriority.UseFont = false
        Me.XrLabel41.StylePriority.UseTextAlignment = false
        XrSummary7.FormatString = "{0:n}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel41.Summary = XrSummary7
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_DESCONTO")})
        Me.XrLabel40.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(673.8996!, 3.000005!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(66.93011!, 15!)
        Me.XrLabel40.StylePriority.UseBackColor = false
        Me.XrLabel40.StylePriority.UseFont = false
        Me.XrLabel40.StylePriority.UseTextAlignment = false
        XrSummary8.FormatString = "{0:n}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel40.Summary = XrSummary8
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(436.4044!, 3.41667!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(104.4301!, 15!)
        Me.XrLabel29.StylePriority.UseFont = false
        Me.XrLabel29.StylePriority.UseTextAlignment = false
        Me.XrLabel29.Text = "Total por Cliente:"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(7.685059!, 21.06252!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(809.6299!, 2!)
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVLR_TOTAL_PRODUTO")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(550.293!, 3.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(78.38861!, 15!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        XrSummary9.FormatString = "{0:n}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel3.Summary = XrSummary9
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupNF
        '
        Me.GroupNF.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label6, Me.label4, Me.XrLabel14, Me.XrLabel12, Me.XrLabel36, Me.XrLabel13, Me.XrLabel31, Me.XrLabel23, Me.XrLabel20, Me.XrLabel19, Me.XrLabel17, Me.XrLabel33})
        Me.GroupNF.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("pNUMERO_NF", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupNF.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupNF.HeightF = 62.50004!
        Me.GroupNF.KeepTogether = true
        Me.GroupNF.Name = "GroupNF"
        Me.GroupNF.RepeatEveryPage = true
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.label6.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(672.5146!, 0!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(138.4855!, 27.70834!)
        Me.label6.StylePriority.UseBackColor = false
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "Valores para conferência"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(549.9286!, 0!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(78.38852!, 34.7917!)
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.Text = "Valor Total liquido (*)"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pDATA_EMISSAO", "{0:dd/MM/yyyy}")})
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(92.04303!, 4!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(104.5634!, 15!)
        Me.XrLabel14.StylePriority.UseFont = false
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(8.000032!, 4!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(84.043!, 15!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.Text = "Dt. Emissão:"
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(503.1875!, 0!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(37.64697!, 34.79166!)
        Me.XrLabel36.StylePriority.UseFont = false
        Me.XrLabel36.StylePriority.UseTextAlignment = false
        Me.XrLabel36.Text = "Unid."
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(8.000032!, 19.7916!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(72!, 15!)
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.Text = "Nota Fiscal"
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel31.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(672.5147!, 27.70834!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(66.93018!, 34.7917!)
        Me.XrLabel31.StylePriority.UseBackColor = false
        Me.XrLabel31.StylePriority.UseFont = false
        Me.XrLabel31.StylePriority.UseTextAlignment = false
        Me.XrLabel31.Text = "Valor Total Desconto"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(454.0822!, 0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(49.10535!, 34.79166!)
        Me.XrLabel23.StylePriority.UseFont = false
        Me.XrLabel23.StylePriority.UseTextAlignment = false
        Me.XrLabel23.Text = "Qtd. em Unid"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(173.8348!, 19.7916!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(265.0451!, 15!)
        Me.XrLabel20.StylePriority.UseFont = false
        Me.XrLabel20.Text = "Produto"
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(122.2514!, 19.7916!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(51.58334!, 15!)
        Me.XrLabel19.StylePriority.UseFont = false
        Me.XrLabel19.Text = "Cód."
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(92.04303!, 19.7916!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(30.20833!, 15!)
        Me.XrLabel17.StylePriority.UseFont = false
        Me.XrLabel17.StylePriority.UseTextAlignment = false
        Me.XrLabel17.Text = "Loja"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrLabel33.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(745.2266!, 27.70834!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(65.77344!, 34.7917!)
        Me.XrLabel33.StylePriority.UseBackColor = false
        Me.XrLabel33.StylePriority.UseFont = false
        Me.XrLabel33.StylePriority.UseTextAlignment = false
        Me.XrLabel33.Text = "Valor Total ST"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataMember = "GetVendasVendedorPeriodo"
        Me.ObjectDataSource1.DataSource = GetType(AspNet5t.dsVendas)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        Parameter1.Name = "parCodVendedor"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.parRepCodVendedor]", GetType(String))
        Parameter2.Name = "parDataInicial"
        Parameter2.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.parRepDataInicial]", GetType(Date))
        Parameter3.Name = "parDataFinal"
        Parameter3.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.parRepDataFinal]", GetType(Date))
        Me.ObjectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1, Parameter2, Parameter3})
        '
        'cfGroupClienteLoja
        '
        Me.cfGroupClienteLoja.Expression = "Concat([pCLIENTE],[pLOJA])"
        Me.cfGroupClienteLoja.Name = "cfGroupClienteLoja"
        '
        'cfValorProdutoComDesconto
        '
        Me.cfValorProdutoComDesconto.Expression = "[pVLR_TOTAL_PRODUTO] -[pVLR_DESCONTO] + [pVLR_ST]"
        Me.cfValorProdutoComDesconto.Name = "cfValorProdutoComDesconto"
        '
        'parRepCodVendedor
        '
        Me.parRepCodVendedor.Description = "Vendedor"
        Me.parRepCodVendedor.Name = "parRepCodVendedor"
        Me.parRepCodVendedor.ValueInfo = "015"
        Me.parRepCodVendedor.Visible = false
        '
        'repCnVendasVendasDiariaVendedorClienteLive
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportFooter, Me.GroupCNPJCliente, Me.GroupFooter1, Me.GroupFooter3, Me.GroupNF})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.cfGroupClienteLoja, Me.cfValorProdutoComDesconto})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(10, 15, 150, 19)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parRepCodVendedor, Me.parRepDataInicial, Me.parRepDataFinal})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.2"
        CType(Me.ObjectDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class