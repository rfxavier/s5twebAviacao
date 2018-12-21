Public Class repCnIndLeiteCamarasFriasOverview
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

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents subreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents subreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents pageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents subreport3 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents pageBreak3 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents subreport4 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents pageBreak4 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents subreport5 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents labelData As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calculatedField1 As DevExpress.XtraReports.UI.CalculatedField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repCnIndLeiteCamarasFriasOverview))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.subreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.subreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.pageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.subreport3 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.pageBreak3 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.subreport4 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.pageBreak4 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.subreport5 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.labelData = New DevExpress.XtraReports.UI.XRLabel()
        Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 41!
        Me.TopMargin.Name = "TopMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label8, Me.label7, Me.label6, Me.label5, Me.pageBreak1, Me.subreport1, Me.subreport2, Me.pageBreak2, Me.subreport3, Me.pageBreak3, Me.subreport4, Me.pageBreak4, Me.subreport5})
        Me.Detail.HeightF = 209.5417!
        Me.Detail.Name = "Detail"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 57!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.pictureBox1, Me.label2, Me.label3, Me.label4, Me.labelData})
        Me.PageHeader.HeightF = 117.7083!
        Me.PageHeader.Name = "PageHeader"
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 139.6667!)
        Me.label8.Multiline = true
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(753!, 21.875!)
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "Resumo Máquina Creme"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.79166!)
        Me.label7.Multiline = true
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(753!, 21.875!)
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "Resumo Máquina Soro de Queijo"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 47.91667!)
        Me.label6.Multiline = true
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(753!, 21.875!)
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "Resumo Máquina Leitelho"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.041667!)
        Me.label5.Multiline = true
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(753!, 21.875!)
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.Text = "Resumo Máquina Leite"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pageBreak1
        '
        Me.pageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.91665!)
        Me.pageBreak1.Name = "pageBreak1"
        '
        'subreport1
        '
        Me.subreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.91667!)
        Me.subreport1.Name = "subreport1"
        Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport1.ReportSource = New AspNet5t.repCnIndLeiteCamarasFriasOverviewSubLeiteTempoEventos()
        Me.subreport1.SizeF = New System.Drawing.SizeF(753!, 23!)
        '
        'subreport2
        '
        Me.subreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.79166!)
        Me.subreport2.Name = "subreport2"
        Me.subreport2.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport2.ReportSource = New AspNet5t.repCnIndLeiteCamarasFriasOverviewSubLeitelhoTempoEventos()
        Me.subreport2.SizeF = New System.Drawing.SizeF(753!, 23!)
        '
        'pageBreak2
        '
        Me.pageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 90.79164!)
        Me.pageBreak2.Name = "pageBreak2"
        '
        'subreport3
        '
        Me.subreport3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 114.6667!)
        Me.subreport3.Name = "subreport3"
        Me.subreport3.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport3.ReportSource = New AspNet5t.repCnIndLeiteCamarasFriasOverviewSubSoroDeQueijoTempoEventos()
        Me.subreport3.SizeF = New System.Drawing.SizeF(753!, 23!)
        '
        'pageBreak3
        '
        Me.pageBreak3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 137.6667!)
        Me.pageBreak3.Name = "pageBreak3"
        '
        'subreport4
        '
        Me.subreport4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 161.5417!)
        Me.subreport4.Name = "subreport4"
        Me.subreport4.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport4.ReportSource = New AspNet5t.repCnIndLeiteCamarasFriasOverviewSubCremeTempoEventos()
        Me.subreport4.SizeF = New System.Drawing.SizeF(753!, 23!)
        '
        'pageBreak4
        '
        Me.pageBreak4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 184.5417!)
        Me.pageBreak4.Name = "pageBreak4"
        '
        'subreport5
        '
        Me.subreport5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 186.5417!)
        Me.subreport5.Name = "subreport5"
        Me.subreport5.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport5.ReportSource = New AspNet5t.repCnIndLeiteCamarasFriasOverviewSubCamarasFriasTempoEventos()
        Me.subreport5.SizeF = New System.Drawing.SizeF(753!, 23!)
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Arial", 16!, System.Drawing.FontStyle.Bold)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(224.286!, 0!)
        Me.label1.Multiline = true
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(476.0416!, 31.25001!)
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseTextAlignment = false
        Me.label1.Text = "GONÇALVES SALLES S.A. IND. E COM."
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
        Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.3277496!, 0!)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.SizeF = New System.Drawing.SizeF(203.125!, 117.7083!)
        Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Arial", 12!)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(224.286!, 31.25001!)
        Me.label2.Multiline = true
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(476.0416!, 21.87501!)
        Me.label2.StylePriority.UseFont = false
        Me.label2.StylePriority.UseTextAlignment = false
        Me.label2.Text = "INDÚSTRIA DE LATICÍNIOS"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Arial", 12!)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(224.286!, 53.12502!)
        Me.label3.Multiline = true
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(476.0416!, 21.87501!)
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.Text = "Linha Leite e Câmaras Frias - Overview Diário"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(224.286!, 84.83334!)
        Me.label4.Multiline = true
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(208.3333!, 21.875!)
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.Text = "Data:"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'labelData
        '
        Me.labelData.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.labelData.LocationFloat = New DevExpress.Utils.PointFloat(432.6195!, 84.83334!)
        Me.labelData.Name = "labelData"
        Me.labelData.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.labelData.SizeF = New System.Drawing.SizeF(129.1667!, 21.875!)
        Me.labelData.StylePriority.UseFont = false
        Me.labelData.StylePriority.UseTextAlignment = false
        Me.labelData.Text = "labelData"
        Me.labelData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'calculatedField1
        '
        Me.calculatedField1.DisplayName = "cfPeriodoINIData"
        Me.calculatedField1.Expression = "Substring([periodoINI], 8, 2) + '/' + Substring([periodoINI], 5, 2) + '/' + Subst"& _ 
    "ring([periodoINI], 0, 4)"
        Me.calculatedField1.Name = "calculatedField1"
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20171010_AUTOGEN"
        Me.repParIdTag.Visible = false
        '
        'repCnIndLeiteCamarasFriasOverview
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calculatedField1})
        Me.Margins = New System.Drawing.Printing.Margins(50, 47, 41, 57)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.Version = "17.1"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class