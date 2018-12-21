Public Class repCnIndEnvaseOverviewSubEnvaseInfo
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

    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents objectDsEnvasePesoMedio As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.label24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.objectDsEnvasePesoMedio = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'label22
        '
        Me.label22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label22.Dpi = 100!
        Me.label22.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(284.7915!, 149.2292!)
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label22.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label22.StylePriority.UseBorders = false
        Me.label22.StylePriority.UseFont = false
        Me.label22.StylePriority.UseTextAlignment = false
        Me.label22.Text = "Média Limite Inferior Copo"
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label25
        '
        Me.label25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label25.Dpi = 100!
        Me.label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label25.LocationFloat = New DevExpress.Utils.PointFloat(285.2084!, 36.66668!)
        Me.label25.Name = "label25"
        Me.label25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label25.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label25.StylePriority.UseBorders = false
        Me.label25.StylePriority.UseFont = false
        Me.label25.StylePriority.UseTextAlignment = false
        Me.label25.Text = "Pote 200g"
        Me.label25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label8
        '
        Me.label8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label8.Dpi = 100!
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(285!, 23!)
        Me.label8.StylePriority.UseBorders = false
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "ENVASE A"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_media_liminfcopo_pote500", "{0:#,#0.00} g")})
        Me.label15.Dpi = 100!
        Me.label15.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(474.7914!, 149.2292!)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label15.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label15.StylePriority.UseFont = false
        Me.label15.StylePriority.UseTextAlignment = false
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label26, Me.label25, Me.label13, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.label22, Me.label23, Me.label24, Me.label10, Me.label12, Me.label11, Me.label7, Me.label6, Me.label5, Me.label4, Me.label3, Me.label2, Me.label1, Me.label21, Me.label20, Me.label19})
        Me.Detail.Dpi = 100!
        Me.Detail.HeightF = 200.5417!
        Me.Detail.Name = "Detail"
        '
        'label24
        '
        Me.label24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label24.Dpi = 100!
        Me.label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label24.LocationFloat = New DevExpress.Utils.PointFloat(0!, 124.2292!)
        Me.label24.Name = "label24"
        Me.label24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label24.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label24.StylePriority.UseBorders = false
        Me.label24.StylePriority.UseFont = false
        Me.label24.StylePriority.UseTextAlignment = false
        Me.label24.Text = "Pote 500g"
        Me.label24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_media_liminfcopo_pote200", "{0:#,#0.00} g")})
        Me.label3.Dpi = 100!
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(475.2082!, 61.66668!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label4.Dpi = 100!
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(0.2084096!, 86.66668!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(177.7084!, 25.00002!)
        Me.label4.StylePriority.UseBorders = false
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.Text = "Média Limite Superior Copo"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100!
        Me.BottomMargin.HeightF = 23!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'label18
        '
        Me.label18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_media_limsupcopo_pote500", "{0:#,#0.00} g")})
        Me.label18.Dpi = 100!
        Me.label18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(474.7915!, 174.2292!)
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label18.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label18.StylePriority.UseFont = false
        Me.label18.StylePriority.UseTextAlignment = false
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_media_liminfcopo_pote500", "{0:#,#0.00} g")})
        Me.label14.Dpi = 100!
        Me.label14.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(189.7915!, 149.2292!)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label14.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label14.StylePriority.UseFont = false
        Me.label14.StylePriority.UseTextAlignment = false
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_media_limsupcopo_pote200", "{0:#,#0.00} g")})
        Me.label6.Dpi = 100!
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(475.2083!, 86.66668!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label1.Dpi = 100!
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.4166285!, 61.66668!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label1.StylePriority.UseBorders = false
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseTextAlignment = false
        Me.label1.Text = "Média Limite Inferior Copo"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label19
        '
        Me.label19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label19.Dpi = 100!
        Me.label19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 0!)
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label19.SizeF = New System.Drawing.SizeF(177.7084!, 25.00001!)
        Me.label19.StylePriority.UseBorders = false
        Me.label19.StylePriority.UseFont = false
        Me.label19.StylePriority.UseTextAlignment = false
        Me.label19.Text = "Tempo em Sip"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label26
        '
        Me.label26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label26.Dpi = 100!
        Me.label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label26.LocationFloat = New DevExpress.Utils.PointFloat(285.2084!, 124.2292!)
        Me.label26.Name = "label26"
        Me.label26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label26.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label26.StylePriority.UseBorders = false
        Me.label26.StylePriority.UseFont = false
        Me.label26.StylePriority.UseTextAlignment = false
        Me.label26.Text = "Pote 500g"
        Me.label26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label9
        '
        Me.label9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label9.Dpi = 100!
        Me.label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(285!, 0!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(284.9999!, 23!)
        Me.label9.StylePriority.UseBorders = false
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "ENVASE B"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label12.Dpi = 100!
        Me.label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(285!, 86.66668!)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label12.SizeF = New System.Drawing.SizeF(177.7084!, 25.00002!)
        Me.label12.StylePriority.UseBorders = false
        Me.label12.StylePriority.UseFont = false
        Me.label12.StylePriority.UseTextAlignment = false
        Me.label12.Text = "Média Limite Superior Copo"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label20
        '
        Me.label20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_tempo_sip_hhmmss")})
        Me.label20.Dpi = 100!
        Me.label20.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(190.2083!, 0!)
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label20.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label20.StylePriority.UseFont = false
        Me.label20.StylePriority.UseTextAlignment = false
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label11
        '
        Me.label11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label11.Dpi = 100!
        Me.label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(285.2083!, 61.66668!)
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label11.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label11.StylePriority.UseBorders = false
        Me.label11.StylePriority.UseFont = false
        Me.label11.StylePriority.UseTextAlignment = false
        Me.label11.Text = "Média Limite Inferior Copo"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label7
        '
        Me.label7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label7.Dpi = 100!
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(285!, 0!)
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(177.7084!, 25.00001!)
        Me.label7.StylePriority.UseBorders = false
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "Tempo em Sip"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'objectDsEnvasePesoMedio
        '
        Me.objectDsEnvasePesoMedio.DataMember = "GetEnvaseInfo"
        Me.objectDsEnvasePesoMedio.DataSource = GetType(AspNet5t.dsIndustria)
        Me.objectDsEnvasePesoMedio.Name = "objectDsEnvasePesoMedio"
        Parameter1.Name = "parIdTag"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.repParIdTag]", GetType(String))
        Me.objectDsEnvasePesoMedio.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'label17
        '
        Me.label17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_media_limsupcopo_pote500", "{0:#,#0.00} g")})
        Me.label17.Dpi = 100!
        Me.label17.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(189.7917!, 174.2292!)
        Me.label17.Name = "label17"
        Me.label17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label17.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label17.StylePriority.UseFont = false
        Me.label17.StylePriority.UseTextAlignment = false
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100!
        Me.TopMargin.HeightF = 34!
        Me.TopMargin.Name = "TopMargin"
        '
        'label13
        '
        Me.label13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label13.Dpi = 100!
        Me.label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 149.2292!)
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label13.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label13.StylePriority.UseBorders = false
        Me.label13.StylePriority.UseFont = false
        Me.label13.StylePriority.UseTextAlignment = false
        Me.label13.Text = "Média Limite Inferior Copo"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label23
        '
        Me.label23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label23.Dpi = 100!
        Me.label23.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label23.LocationFloat = New DevExpress.Utils.PointFloat(284.5832!, 174.2292!)
        Me.label23.Name = "label23"
        Me.label23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label23.SizeF = New System.Drawing.SizeF(177.7084!, 25.00002!)
        Me.label23.StylePriority.UseBorders = false
        Me.label23.StylePriority.UseFont = false
        Me.label23.StylePriority.UseTextAlignment = false
        Me.label23.Text = "Média Limite Superior Copo"
        Me.label23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label5
        '
        Me.label5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_media_limsupcopo_pote200", "{0:#,#0.00} g")})
        Me.label5.Dpi = 100!
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(190.2085!, 86.66668!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label8, Me.label9})
        Me.PageHeader.Dpi = 100!
        Me.PageHeader.HeightF = 23!
        Me.PageHeader.Name = "PageHeader"
        '
        'label10
        '
        Me.label10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label10.Dpi = 100!
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(0.4167557!, 36.66668!)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label10.SizeF = New System.Drawing.SizeF(177.5!, 25.00001!)
        Me.label10.StylePriority.UseBorders = false
        Me.label10.StylePriority.UseFont = false
        Me.label10.StylePriority.UseTextAlignment = false
        Me.label10.Text = "Pote 200g"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label16
        '
        Me.label16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label16.Dpi = 100!
        Me.label16.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 174.2292!)
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label16.SizeF = New System.Drawing.SizeF(177.7084!, 25.00002!)
        Me.label16.StylePriority.UseBorders = false
        Me.label16.StylePriority.UseFont = false
        Me.label16.StylePriority.UseTextAlignment = false
        Me.label16.Text = "Média Limite Superior Copo"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label21
        '
        Me.label21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_tempo_sip_hhmmss")})
        Me.label21.Dpi = 100!
        Me.label21.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(475.2083!, 7.629395E-06!)
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label21.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label21.StylePriority.UseFont = false
        Me.label21.StylePriority.UseTextAlignment = false
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20170713RX"
        Me.repParIdTag.Visible = false
        '
        'label2
        '
        Me.label2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_media_liminfcopo_pote200", "{0:#,#0.00} g")})
        Me.label2.Dpi = 100!
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(190.2083!, 61.66668!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(94.79166!, 25.00001!)
        Me.label2.StylePriority.UseFont = false
        Me.label2.StylePriority.UseTextAlignment = false
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'repCnIndEnvaseOverviewSubEnvaseInfo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsEnvasePesoMedio})
        Me.DataSource = Me.objectDsEnvasePesoMedio
        Me.Margins = New System.Drawing.Printing.Margins(55, 52, 34, 23)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.Version = "16.1"
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class