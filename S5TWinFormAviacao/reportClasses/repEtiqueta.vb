Public Class repEtiqueta
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

    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents cfPeso As DevExpress.XtraReports.UI.CalculatedField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cfPeso = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me.ObjectDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'XrCrossBandBox1
        '
        XrCrossBandBox1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None
        XrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        XrCrossBandBox1.BorderWidth = 2!
        XrCrossBandBox1.Dpi = 254!
        XrCrossBandBox1.EndBand = Me.BottomMargin
        XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(5.999997!, 523.0626!)
        XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(5.999997!, 11!)
        XrCrossBandBox1.Name = "XrCrossBandBox1"
        XrCrossBandBox1.StartBand = Me.BottomMargin
        XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(5.999997!, 11!)
        XrCrossBandBox1.WidthF = 735.8074!
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254!
        Me.BottomMargin.HeightF = 11!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.BottomMargin.Visible = false
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel4, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel17, Me.XrLabel18, Me.XrLabel15, Me.XrLabel16, Me.XrLabel13, Me.XrLabel14, Me.XrLine2, Me.XrLabel12, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel7, Me.XrLabel8, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrBarCode1})
        Me.Detail.Dpi = 254!
        Me.Detail.HeightF = 534.6042!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(23.58069!, 205.4!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(698.8386!, 5!)
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Unicode MS", 15!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(374.4756!, 342.72!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(150.7053!, 63.79999!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.Text = "VEZ:"
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pVez")})
        Me.XrLabel22.Dpi = 254!
        Me.XrLabel22.Font = New System.Drawing.Font("Arial Unicode MS", 15!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(525.1809!, 342.72!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(195.8191!, 63.79999!)
        Me.XrLabel22.StylePriority.UseFont = false
        Me.XrLabel22.WordWrap = false
        '
        'XrLabel23
        '
        Me.XrLabel23.Dpi = 254!
        Me.XrLabel23.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(25.58042!, 361.72!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(179.431!, 44.79999!)
        Me.XrLabel23.StylePriority.UseFont = false
        Me.XrLabel23.Text = "TOTAL VEZ:"
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_QUANT")})
        Me.XrLabel24.Dpi = 254!
        Me.XrLabel24.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(205.0114!, 361.72!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(158.3327!, 44.80002!)
        Me.XrLabel24.StylePriority.UseFont = false
        Me.XrLabel24.WordWrap = false
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pUsuario")})
        Me.XrLabel21.Dpi = 254!
        Me.XrLabel21.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(525.1809!, 262.1999!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(199.0583!, 44.79999!)
        Me.XrLabel21.StylePriority.UseFont = false
        Me.XrLabel21.WordWrap = false
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 254!
        Me.XrLabel20.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(374.2951!, 262.2!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(150.8858!, 44.79996!)
        Me.XrLabel20.StylePriority.UseFont = false
        Me.XrLabel20.Text = "USUÁRIO:"
        '
        'XrLabel19
        '
        Me.XrLabel19.Dpi = 254!
        Me.XrLabel19.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 262.2!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(113.8441!, 44.79996!)
        Me.XrLabel19.StylePriority.UseFont = false
        Me.XrLabel19.Text = "PROD.:"
        '
        'XrLabel17
        '
        Me.XrLabel17.Dpi = 254!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 217.4!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(91.88155!, 44.79999!)
        Me.XrLabel17.StylePriority.UseFont = false
        Me.XrLabel17.Text = "CÓD.:"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "G1_COMP")})
        Me.XrLabel18.Dpi = 254!
        Me.XrLabel18.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(117.2816!, 217.4!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(246.0625!, 44.79999!)
        Me.XrLabel18.StylePriority.UseFont = false
        Me.XrLabel18.WordWrap = false
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_SEQUEN")})
        Me.XrLabel15.Dpi = 254!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(633.3282!, 101.8!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(90.9104!, 44.79999!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.WordWrap = false
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254!
        Me.XrLabel16.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(549.6393!, 101.8!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(79.88153!, 44.79999!)
        Me.XrLabel16.StylePriority.UseFont = false
        Me.XrLabel16.Text = "SEQ:"
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 254!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 101.8!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(131.9274!, 44.79999!)
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.Text = "ORDEM:"
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_NUM")})
        Me.XrLabel14.Dpi = 254!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(157.3274!, 101.8!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(174.625!, 44.79999!)
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.WordWrap = false
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 81.79999!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(698.8386!, 5!)
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "B1_DESC")})
        Me.XrLabel12.Dpi = 254!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial Unicode MS", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 160.6!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(698.8386!, 44.79999!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel12.WordWrap = false
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(374.2951!, 217.4!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(103.8816!, 44.79999!)
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.Text = "LOTE:"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pLote")})
        Me.XrLabel10.Dpi = 254!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(478.1767!, 217.4!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(246.0625!, 44.79999!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.WordWrap = false
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pDataMov", "{0:dd/MM/yyyy}")})
        Me.XrLabel11.Dpi = 254!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(144.2441!, 262.2!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(219.0999!, 44.79996!)
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.WordWrap = false
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 307!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(102.1357!, 39.72!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.Text = "PESO:"
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfPeso", "{0:n4}")})
        Me.XrLabel8.Dpi = 254!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(129.1772!, 307!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(234.3473!, 39.72!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.WordWrap = false
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_ITEM")})
        Me.XrLabel3.Dpi = 254!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(432.4274!, 101.8!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(108.4792!, 44.79999!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.WordWrap = false
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "B1_DESC_PROD")})
        Me.XrLabel2.Dpi = 254!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(25.4!, 25.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(698.8386!, 56.79999!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel2.WordWrap = false
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(340.5458!, 101.8!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(91.88155!, 44.79999!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.Text = "ITEM:"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = true
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pId")})
        Me.XrBarCode1.Dpi = 254!
        Me.XrBarCode1.Font = New System.Drawing.Font("Harlow Solid Italic", 12!)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(25.58042!, 425.52!)
        Me.XrBarCode1.Module = 5.08!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(698.6582!, 95.0842!)
        Me.XrBarCode1.StylePriority.UseFont = false
        Me.XrBarCode1.StylePriority.UseTextAlignment = false
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.TopMargin.Visible = false
        '
        'cfPeso
        '
        Me.cfPeso.Expression = "iif([B1_UM] LIKE 'KG', Concat(([pPesoPesado] * 1000),'g'), [pPesoPesado])"
        Me.cfPeso.Name = "cfPeso"
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(S5T.FracionamentoMovViewGrid)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'repEtiqueta
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.cfPeso})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {XrCrossBandBox1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Dpi = 254!
        Me.Font = New System.Drawing.Font("Harlow Solid Italic", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 11)
        Me.PageHeight = 1651
        Me.PageWidth = 746
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RollPaper = true
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = false
        Me.SnapGridSize = 1!
        Me.Version = "17.1"
        CType(Me.ObjectDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class