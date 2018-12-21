Public Class repPedidoAppForcaVendas
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

    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents label34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents calcTotalPedidoComIcmsST As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcPed_DataEntrega As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcValorUnProduto As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents parRepNumeroPedido As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repPedidoAppForcaVendas))
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.label34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.calcTotalPedidoComIcmsST = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcPed_DataEntrega = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcValorUnProduto = New DevExpress.XtraReports.UI.CalculatedField()
        Me.parRepNumeroPedido = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.objectDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 52.08333!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label35, Me.label8, Me.label6, Me.label4, Me.label3})
        Me.detailBand1.HeightF = 23!
        Me.detailBand1.Name = "detailBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.HeightF = 71.2916!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label26, Me.label25, Me.line2, Me.label19, Me.label18, Me.label7, Me.label15, Me.label14, Me.label13, Me.label12, Me.label11, Me.label10, Me.label9, Me.line1})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("pNumeroPedido", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 102.1042!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label34, Me.label5, Me.label33, Me.label31, Me.label32, Me.label28, Me.label27, Me.label23, Me.label22, Me.label21, Me.label20, Me.label16, Me.label17})
        Me.GroupFooter1.HeightF = 234.9584!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label24, Me.label1, Me.label2, Me.label30, Me.label29, Me.pictureBox1})
        Me.PageHeader.HeightF = 117.7083!
        Me.PageHeader.Name = "PageHeader"
        '
        'label35
        '
        Me.label35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calcValorUnProduto", "{0:#,#0.00}")})
        Me.label35.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label35.LocationFloat = New DevExpress.Utils.PointFloat(509.4169!, 0!)
        Me.label35.Name = "label35"
        Me.label35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label35.SizeF = New System.Drawing.SizeF(73.95813!, 23!)
        Me.label35.StylePriority.UseFont = false
        Me.label35.StylePriority.UseTextAlignment = false
        Me.label35.Text = "label35"
        Me.label35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label8
        '
        Me.label8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pValorTotalProduto", "{0:#,#0.00}")})
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(594.1669!, 0!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(104.8336!, 23!)
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "label8"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label6
        '
        Me.label6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pQuantidade")})
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(432.3332!, 0!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(66.66672!, 23!)
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "label6"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label4
        '
        Me.label4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pB1_DESC")})
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(56.25!, 0!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(363.5832!, 23!)
        Me.label4.StylePriority.UseFont = false
        Me.label4.Text = "label4"
        '
        'label3
        '
        Me.label3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pB1_COD")})
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(56.25!, 23!)
        Me.label3.StylePriority.UseFont = false
        Me.label3.Text = "label3"
        '
        'label26
        '
        Me.label26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_DataEmissao", "{0:dd/MM/yyyy}")})
        Me.label26.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label26.LocationFloat = New DevExpress.Utils.PointFloat(113!, 0!)
        Me.label26.Name = "label26"
        Me.label26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label26.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.label26.StylePriority.UseFont = false
        Me.label26.Text = "label26"
        '
        'label25
        '
        Me.label25.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label25.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label25.Name = "label25"
        Me.label25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label25.SizeF = New System.Drawing.SizeF(110!, 23!)
        Me.label25.StylePriority.UseFont = false
        Me.label25.StylePriority.UseTextAlignment = false
        Me.label25.Text = "Data Emissão:"
        Me.label25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'line2
        '
        Me.line2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 100.0209!)
        Me.line2.Name = "line2"
        Me.line2.SizeF = New System.Drawing.SizeF(699.0003!, 2.083336!)
        '
        'label19
        '
        Me.label19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(594.1666!, 77.02087!)
        Me.label19.Multiline = true
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label19.SizeF = New System.Drawing.SizeF(104.8336!, 23.00002!)
        Me.label19.StylePriority.UseFont = false
        Me.label19.StylePriority.UseTextAlignment = false
        Me.label19.Text = "Valor Total"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label18
        '
        Me.label18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(509.4169!, 77.02087!)
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label18.SizeF = New System.Drawing.SizeF(73.95819!, 23.00001!)
        Me.label18.StylePriority.UseFont = false
        Me.label18.StylePriority.UseTextAlignment = false
        Me.label18.Text = "Preço Un."
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(432.3332!, 77.02087!)
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(66.66666!, 23.00001!)
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "Quant."
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label15
        '
        Me.label15.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 77.02087!)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label15.SizeF = New System.Drawing.SizeF(110!, 23!)
        Me.label15.StylePriority.UseFont = false
        Me.label15.StylePriority.UseTextAlignment = false
        Me.label15.Text = "Produto"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'label14
        '
        Me.label14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_A1_END")})
        Me.label14.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(113!, 48.93751!)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label14.SizeF = New System.Drawing.SizeF(586.0001!, 23!)
        Me.label14.StylePriority.UseFont = false
        Me.label14.Text = "label14"
        '
        'label13
        '
        Me.label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 48.93751!)
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label13.SizeF = New System.Drawing.SizeF(110!, 23!)
        Me.label13.StylePriority.UseFont = false
        Me.label13.StylePriority.UseTextAlignment = false
        Me.label13.Text = "Endereço:"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(554.6253!, 24.93749!)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label12.SizeF = New System.Drawing.SizeF(44.375!, 23!)
        Me.label12.StylePriority.UseFont = false
        Me.label12.StylePriority.UseTextAlignment = false
        Me.label12.Text = "Loja:"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label11
        '
        Me.label11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_A1_LOJA")})
        Me.label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(599.0003!, 24.93749!)
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label11.SizeF = New System.Drawing.SizeF(43.75!, 23!)
        Me.label11.StylePriority.UseFont = false
        Me.label11.Text = "label11"
        '
        'label10
        '
        Me.label10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_A1_NOME")})
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(113.417!, 24.93749!)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label10.SizeF = New System.Drawing.SizeF(441.2084!, 23!)
        Me.label10.StylePriority.UseFont = false
        Me.label10.Text = "label10"
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 24.93749!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(110!, 23!)
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "Cliente:"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'line1
        '
        Me.line1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 74.93752!)
        Me.line1.Name = "line1"
        Me.line1.SizeF = New System.Drawing.SizeF(699.0003!, 2.083336!)
        '
        'label34
        '
        Me.label34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calcPed_DataEntrega", "{0:dd/MM/yyyy}")})
        Me.label34.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label34.LocationFloat = New DevExpress.Utils.PointFloat(113.417!, 104.6459!)
        Me.label34.Name = "label34"
        Me.label34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label34.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.label34.StylePriority.UseFont = False
        '
        'label5
        '
        Me.label5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calcTotalPedidoComIcmsST", "{0:#,#0.00}")})
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(594.1649!, 54.0!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label5.SizeF = New System.Drawing.SizeF(104.8351!, 23.0!)
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "label5"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label33
        '
        Me.label33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_ValorTotalProduto", "{0:#,#0.00}")})
        Me.label33.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label33.LocationFloat = New DevExpress.Utils.PointFloat(594.1654!, 31.00001!)
        Me.label33.Name = "label33"
        Me.label33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label33.SizeF = New System.Drawing.SizeF(104.8345!, 23.0!)
        Me.label33.StylePriority.UseFont = False
        Me.label33.StylePriority.UseTextAlignment = False
        Me.label33.Text = "label33"
        Me.label33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label31
        '
        Me.label31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_pedidoValorSubstTrib", "{0:#,#0.00}")})
        Me.label31.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label31.LocationFloat = New DevExpress.Utils.PointFloat(594.166!, 7.999992!)
        Me.label31.Name = "label31"
        Me.label31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label31.SizeF = New System.Drawing.SizeF(104.834!, 23.0!)
        Me.label31.StylePriority.UseFont = False
        Me.label31.StylePriority.UseTextAlignment = False
        Me.label31.Text = "label31"
        Me.label31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label32
        '
        Me.label32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_WsOrcamento_ITENS")})
        Me.label32.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label32.LocationFloat = New DevExpress.Utils.PointFloat(0!, 211.9584!)
        Me.label32.Name = "label32"
        Me.label32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label32.SizeF = New System.Drawing.SizeF(699.0004!, 23.0!)
        Me.label32.StylePriority.UseFont = False
        Me.label32.Text = "label32"
        '
        'label28
        '
        Me.label28.CanGrow = False
        Me.label28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_Observacao")})
        Me.label28.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label28.LocationFloat = New DevExpress.Utils.PointFloat(0!, 162.1875!)
        Me.label28.Name = "label28"
        Me.label28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label28.SizeF = New System.Drawing.SizeF(699.0001!, 49.77086!)
        Me.label28.StylePriority.UseFont = False
        Me.label28.Text = "label28"
        '
        'label27
        '
        Me.label27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_NumeroPedidoCliente")})
        Me.label27.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label27.LocationFloat = New DevExpress.Utils.PointFloat(421.7503!, 104.6459!)
        Me.label27.Name = "label27"
        Me.label27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label27.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.label27.StylePriority.UseFont = False
        Me.label27.Text = "label27"
        '
        'label23
        '
        Me.label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline)
        Me.label23.LocationFloat = New DevExpress.Utils.PointFloat(0!, 139.1875!)
        Me.label23.Multiline = True
        Me.label23.Name = "label23"
        Me.label23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label23.SizeF = New System.Drawing.SizeF(110.0!, 23.00001!)
        Me.label23.StylePriority.UseFont = False
        Me.label23.StylePriority.UseTextAlignment = False
        Me.label23.Text = "Observações:"
        Me.label23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'label22
        '
        Me.label22.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(308.3333!, 104.6459!)
        Me.label22.Multiline = True
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label22.SizeF = New System.Drawing.SizeF(110.0!, 23.00001!)
        Me.label22.StylePriority.UseFont = False
        Me.label22.StylePriority.UseTextAlignment = False
        Me.label22.Text = "No Ped. Cliente:"
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label21
        '
        Me.label21.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 104.6458!)
        Me.label21.Multiline = True
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label21.SizeF = New System.Drawing.SizeF(110.0!, 23.00001!)
        Me.label21.StylePriority.UseFont = False
        Me.label21.StylePriority.UseTextAlignment = False
        Me.label21.Text = "Data Entrega:"
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label20
        '
        Me.label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(358.3751!, 53.99997!)
        Me.label20.Multiline = True
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label20.SizeF = New System.Drawing.SizeF(225.0001!, 23.00002!)
        Me.label20.StylePriority.UseFont = False
        Me.label20.StylePriority.UseTextAlignment = False
        Me.label20.Text = "Total do Pedido Com ICMS ST"
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label16
        '
        Me.label16.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(431.2917!, 30.99995!)
        Me.label16.Multiline = True
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label16.SizeF = New System.Drawing.SizeF(152.0834!, 23.00002!)
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Total do Pedido"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label17
        '
        Me.label17.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(457.3333!, 7.999992!)
        Me.label17.Multiline = True
        Me.label17.Name = "label17"
        Me.label17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label17.SizeF = New System.Drawing.SizeF(126.0417!, 23.00002!)
        Me.label17.StylePriority.UseFont = False
        Me.label17.StylePriority.UseTextAlignment = False
        Me.label17.Text = "Valor ICMS ST"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label24
        '
        Me.label24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pPed_A3_NOME")})
        Me.label24.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.label24.LocationFloat = New DevExpress.Utils.PointFloat(222.9584!, 65.625!)
        Me.label24.Name = "label24"
        Me.label24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label24.SizeF = New System.Drawing.SizeF(476.0417!, 23.0!)
        Me.label24.StylePriority.UseFont = False
        Me.label24.StylePriority.UseTextAlignment = False
        Me.label24.Text = "label24"
        Me.label24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(253.0836!, 88.70834!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.SizeF = New System.Drawing.SizeF(232.9166!, 23.0!)
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "Referência App:"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'label2
        '
        Me.label2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "pNumeroPedido", "{0:#,#0}")})
        Me.label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(489.0003!, 88.70834!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label2.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label2.StylePriority.UseFont = False
        Me.label2.Text = "label2"
        '
        'label30
        '
        Me.label30.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.label30.LocationFloat = New DevExpress.Utils.PointFloat(222.9584!, 36.75!)
        Me.label30.Multiline = True
        Me.label30.Name = "label30"
        Me.label30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label30.SizeF = New System.Drawing.SizeF(476.0416!, 21.87501!)
        Me.label30.StylePriority.UseFont = False
        Me.label30.StylePriority.UseTextAlignment = False
        Me.label30.Text = "PEDIDO DE VENDA"
        Me.label30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label29
        '
        Me.label29.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label29.LocationFloat = New DevExpress.Utils.PointFloat(222.9584!, 0!)
        Me.label29.Multiline = True
        Me.label29.Name = "label29"
        Me.label29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label29.SizeF = New System.Drawing.SizeF(476.0416!, 31.25001!)
        Me.label29.StylePriority.UseFont = False
        Me.label29.StylePriority.UseTextAlignment = False
        Me.label29.Text = "GONÇALVES SALLES S.A. IND. E COM."
        Me.label29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.SizeF = New System.Drawing.SizeF(203.125!, 117.7083!)
        Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'objectDataSource1
        '
        Me.objectDataSource1.DataMember = "GetPedidosMov"
        Me.objectDataSource1.DataSource = GetType(AspNet5t.dsAppForcaVendas)
        Me.objectDataSource1.Name = "objectDataSource1"
        Parameter1.Name = "parNumeroPedido"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.parRepNumeroPedido]", GetType(Long))
        Me.objectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption3
        '
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3
        '
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaptionBackground3
        '
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2.0!
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'calcTotalPedidoComIcmsST
        '
        Me.calcTotalPedidoComIcmsST.Expression = "[pPed_ValorTotalProduto] + [pPed_pedidoValorSubstTrib]"
        Me.calcTotalPedidoComIcmsST.Name = "calcTotalPedidoComIcmsST"
        '
        'calcPed_DataEntrega
        '
        Me.calcPed_DataEntrega.Expression = "Iif([pPed_DataEntrega] = '01/01/0001 00:00:00', '', [pPed_DataEntrega])"
        Me.calcPed_DataEntrega.Name = "calcPed_DataEntrega"
        '
        'calcValorUnProduto
        '
        Me.calcValorUnProduto.Expression = "[pValorTotalProduto] / [pQuantidade]"
        Me.calcValorUnProduto.Name = "calcValorUnProduto"
        '
        'parRepNumeroPedido
        '
        Me.parRepNumeroPedido.Name = "parRepNumeroPedido"
        Me.parRepNumeroPedido.Type = GetType(Long)
        Me.parRepNumeroPedido.ValueInfo = "10683"
        Me.parRepNumeroPedido.Visible = false
        '
        'repPedidoAppForcaVendas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.groupHeaderBand1, Me.GroupFooter1, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcTotalPedidoComIcmsST, Me.calcPed_DataEntrega, Me.calcValorUnProduto})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
        Me.DataSource = Me.objectDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(76, 75, 52, 71)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parRepNumeroPedido})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.1"
        CType(Me.objectDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class