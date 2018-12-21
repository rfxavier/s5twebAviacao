Public Class repEtiquetaOrdem
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents parVez As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parCodigoBarras As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.parVez = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.parCodigoBarras = New DevExpress.XtraReports.Parameters.Parameter()
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
        Me.Detail.Dpi = 254!
        Me.Detail.HeightF = 0.1458244!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = false
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
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(S5T.FracionamentoMovViewGrid)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrBarCode2, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLine1, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel17, Me.XrLabel18})
        Me.ReportHeader.Dpi = 254!
        Me.ReportHeader.HeightF = 537.1042!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.parVez, "Text", "")})
        Me.XrLabel1.Dpi = 254!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Unicode MS", 20!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(23.76083!, 286.6658!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(697.2391!, 115.3542!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel1.WordWrap = false
        '
        'parVez
        '
        Me.parVez.Description = "Contador de impressão da Etiqueta de Ordem"
        Me.parVez.Name = "parVez"
        Me.parVez.Type = GetType(Integer)
        Me.parVez.ValueInfo = "0"
        '
        'XrBarCode2
        '
        Me.XrBarCode2.AutoModule = true
        Me.XrBarCode2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.parCodigoBarras, "Text", "")})
        Me.XrBarCode2.Dpi = 254!
        Me.XrBarCode2.Font = New System.Drawing.Font("Harlow Solid Italic", 12!)
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(23.76083!, 402.02!)
        Me.XrBarCode2.Module = 5.08!
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254!)
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(698.6582!, 119.0842!)
        Me.XrBarCode2.StylePriority.UseFont = false
        Me.XrBarCode2.StylePriority.UseTextAlignment = false
        Me.XrBarCode2.Symbology = Code128Generator1
        Me.XrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(338.7262!, 172.4659!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(91.88155!, 44.79999!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.Text = "ITEM:"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "B1_DESC_PROD")})
        Me.XrLabel5.Dpi = 254!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial Unicode MS", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(23.58041!, 19.35417!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(698.8386!, 135.5117!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_ITEM")})
        Me.XrLabel6.Dpi = 254!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(430.6078!, 172.4659!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(108.4792!, 44.79999!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.WordWrap = false
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(23.58041!, 154.8658!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(698.8386!, 5!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_NUM")})
        Me.XrLabel7.Dpi = 254!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(155.5078!, 172.4659!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(174.625!, 44.79999!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.WordWrap = false
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(23.58041!, 172.4659!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(131.9274!, 44.79999!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.Text = "ORDEM:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(547.8197!, 172.4659!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(79.88153!, 44.79999!)
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.Text = "SEQ:"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_SEQUEN")})
        Me.XrLabel10.Dpi = 254!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(631.5086!, 172.4659!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(90.9104!, 44.79999!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.WordWrap = false
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 254!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(372.4755!, 241.8658!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(150.8858!, 44.79996!)
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.Text = "USUÁRIO:"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pUsuario")})
        Me.XrLabel12.Dpi = 254!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(523.3613!, 241.8658!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(199.0583!, 44.79999!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.WordWrap = false
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "C2_QUANT")})
        Me.XrLabel17.Dpi = 254!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(186.1918!, 241.8658!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(170.3321!, 44.80002!)
        Me.XrLabel17.StylePriority.UseFont = false
        Me.XrLabel17.WordWrap = false
        '
        'XrLabel18
        '
        Me.XrLabel18.Dpi = 254!
        Me.XrLabel18.Font = New System.Drawing.Font("Arial Unicode MS", 8!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(23.76083!, 241.8658!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(162.431!, 44.79999!)
        Me.XrLabel18.StylePriority.UseFont = false
        Me.XrLabel18.Text = "TOTAL KIT:"
        '
        'parCodigoBarras
        '
        Me.parCodigoBarras.Description = "Codigo Barras"
        Me.parCodigoBarras.Name = "parCodigoBarras"
        '
        'repEtiquetaOrdem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {XrCrossBandBox1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Dpi = 254!
        Me.Font = New System.Drawing.Font("Harlow Solid Italic", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 11)
        Me.PageHeight = 1651
        Me.PageWidth = 746
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parVez, Me.parCodigoBarras})
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