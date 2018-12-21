Public Class repCnIndLeiteCamarasFriasOverviewSubCamarasFriasTempoEventos
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
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents chart8Secagem1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart7Secagem As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart4MinasRicota As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart6Requeijao As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart5ProdutoAcabado As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart3Maturacao As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart2Salgada As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart1Montanhes As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents pageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents objectDsLeiteEvento As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView3 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle2 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView4 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel3 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView5 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle3 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView6 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel4 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView7 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle4 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView8 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel5 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView9 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle5 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView10 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel6 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView11 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle6 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView12 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel7 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView13 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle7 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView14 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel8 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView15 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle8 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Dim PieSeriesView16 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.chart8Secagem1 = New DevExpress.XtraReports.UI.XRChart()
        Me.chart7Secagem = New DevExpress.XtraReports.UI.XRChart()
        Me.chart4MinasRicota = New DevExpress.XtraReports.UI.XRChart()
        Me.chart6Requeijao = New DevExpress.XtraReports.UI.XRChart()
        Me.chart5ProdutoAcabado = New DevExpress.XtraReports.UI.XRChart()
        Me.chart3Maturacao = New DevExpress.XtraReports.UI.XRChart()
        Me.chart2Salgada = New DevExpress.XtraReports.UI.XRChart()
        Me.chart1Montanhes = New DevExpress.XtraReports.UI.XRChart()
        Me.pageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.objectDsLeiteEvento = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.chart8Secagem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart7Secagem,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart4MinasRicota,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart6Requeijao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart5ProdutoAcabado,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart3Maturacao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView12,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart2Salgada,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView13,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView14,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart1Montanhes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView15,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView16,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.objectDsLeiteEvento,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 35!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'detailBand1
        '
        Me.detailBand1.HeightF = 20!
        Me.detailBand1.Name = "detailBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.HeightF = 36!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.label9, Me.chart8Secagem1, Me.chart7Secagem, Me.chart4MinasRicota, Me.chart6Requeijao, Me.chart5ProdutoAcabado, Me.chart3Maturacao, Me.chart2Salgada, Me.chart1Montanhes, Me.pageBreak1})
        Me.ReportHeader.HeightF = 1173.75!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 869.8751!)
        Me.label1.Multiline = true
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(739.9999!, 21.875!)
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseTextAlignment = false
        Me.label1.Text = "Resumo Câmaras Frias - Tempo da Temperatura de Operação"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(6.763648E-05!, 0!)
        Me.label9.Multiline = true
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(739.9999!, 21.875!)
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "Resumo Câmaras Frias - Tempo da Temperatura de Operação"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'chart8Secagem1
        '
        Me.chart8Secagem1.BorderColor = System.Drawing.Color.Black
        Me.chart8Secagem1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart8Secagem1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart8Secagem1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart8Secagem1.Legend.Name = "Default Legend"
        Me.chart8Secagem1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart8Secagem1.LocationFloat = New DevExpress.Utils.PointFloat(370!, 891.7501!)
        Me.chart8Secagem1.Name = "chart8Secagem1"
        Me.chart8Secagem1.PaletteName = "GreenRedCustom"
        Me.chart8Secagem1.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series1.ArgumentDataMember = "description"
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "secagem1fora")})
        PieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel1.TextPattern = "{HINT} ({VP:0.00%})"
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.LegendName = "Default Legend"
        Series1.LegendTextPattern = "{A}"
        Series1.Name = "Series 1"
        Series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series1.ToolTipHintDataMember = "tempo_hhmmss"
        Series1.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle1.Indent = 0
        SeriesTitle1.Text = "tempo total: "
        PieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
        Series1.View = PieSeriesView1
        Me.chart8Secagem1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.chart8Secagem1.SeriesTemplate.View = PieSeriesView2
        Me.chart8Secagem1.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle1.Text = "Secagem 1"
        Me.chart8Secagem1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'chart7Secagem
        '
        Me.chart7Secagem.BorderColor = System.Drawing.Color.Black
        Me.chart7Secagem.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart7Secagem.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart7Secagem.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart7Secagem.Legend.Name = "Default Legend"
        Me.chart7Secagem.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart7Secagem.LocationFloat = New DevExpress.Utils.PointFloat(0!, 891.7501!)
        Me.chart7Secagem.Name = "chart7Secagem"
        Me.chart7Secagem.PaletteName = "GreenRedCustom"
        Me.chart7Secagem.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series2.ArgumentDataMember = "description"
        Series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "secagemfora")})
        PieSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.TextPattern = "{HINT} ({VP:0.00%})"
        Series2.Label = PieSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.LegendName = "Default Legend"
        Series2.LegendTextPattern = "{A}"
        Series2.Name = "Series 1"
        Series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series2.ToolTipHintDataMember = "tempo_hhmmss"
        Series2.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle2.Indent = 0
        SeriesTitle2.Text = "tempo total: "
        PieSeriesView3.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle2})
        Series2.View = PieSeriesView3
        Me.chart7Secagem.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.chart7Secagem.SeriesTemplate.View = PieSeriesView4
        Me.chart7Secagem.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle2.Text = "Secagem"
        Me.chart7Secagem.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'chart4MinasRicota
        '
        Me.chart4MinasRicota.BorderColor = System.Drawing.Color.Black
        Me.chart4MinasRicota.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart4MinasRicota.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart4MinasRicota.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart4MinasRicota.Legend.Name = "Default Legend"
        Me.chart4MinasRicota.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart4MinasRicota.LocationFloat = New DevExpress.Utils.PointFloat(370!, 303.875!)
        Me.chart4MinasRicota.Name = "chart4MinasRicota"
        Me.chart4MinasRicota.PaletteName = "GreenRedCustom"
        Me.chart4MinasRicota.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series3.ArgumentDataMember = "description"
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "minasricotafora")})
        PieSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.TextPattern = "{HINT} ({VP:0.00%})"
        Series3.Label = PieSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.LegendName = "Default Legend"
        Series3.LegendTextPattern = "{A}"
        Series3.Name = "Series 1"
        Series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series3.ToolTipHintDataMember = "tempo_hhmmss"
        Series3.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle3.Indent = 0
        SeriesTitle3.Text = "tempo total: "
        PieSeriesView5.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle3})
        Series3.View = PieSeriesView5
        Me.chart4MinasRicota.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.chart4MinasRicota.SeriesTemplate.View = PieSeriesView6
        Me.chart4MinasRicota.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle3.Text = "Minas Ricota"
        Me.chart4MinasRicota.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'chart6Requeijao
        '
        Me.chart6Requeijao.BorderColor = System.Drawing.Color.Black
        Me.chart6Requeijao.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart6Requeijao.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart6Requeijao.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart6Requeijao.Legend.Name = "Default Legend"
        Me.chart6Requeijao.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart6Requeijao.LocationFloat = New DevExpress.Utils.PointFloat(369.9999!, 585.875!)
        Me.chart6Requeijao.Name = "chart6Requeijao"
        Me.chart6Requeijao.PaletteName = "GreenRedCustom"
        Me.chart6Requeijao.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series4.ArgumentDataMember = "description"
        Series4.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "requeijaofora")})
        PieSeriesLabel4.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel4.TextPattern = "{HINT} ({VP:0.00%})"
        Series4.Label = PieSeriesLabel4
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.LegendName = "Default Legend"
        Series4.LegendTextPattern = "{A}"
        Series4.Name = "Series 1"
        Series4.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series4.ToolTipHintDataMember = "tempo_hhmmss"
        Series4.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle4.Indent = 0
        SeriesTitle4.Text = "tempo total: "
        PieSeriesView7.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle4})
        Series4.View = PieSeriesView7
        Me.chart6Requeijao.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.chart6Requeijao.SeriesTemplate.View = PieSeriesView8
        Me.chart6Requeijao.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle4.Text = "Requeijão"
        Me.chart6Requeijao.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'chart5ProdutoAcabado
        '
        Me.chart5ProdutoAcabado.BorderColor = System.Drawing.Color.Black
        Me.chart5ProdutoAcabado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart5ProdutoAcabado.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart5ProdutoAcabado.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart5ProdutoAcabado.Legend.Name = "Default Legend"
        Me.chart5ProdutoAcabado.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart5ProdutoAcabado.LocationFloat = New DevExpress.Utils.PointFloat(0!, 585.875!)
        Me.chart5ProdutoAcabado.Name = "chart5ProdutoAcabado"
        Me.chart5ProdutoAcabado.PaletteName = "GreenRedCustom"
        Me.chart5ProdutoAcabado.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series5.ArgumentDataMember = "description"
        Series5.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "produtoacabadofora")})
        PieSeriesLabel5.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel5.TextPattern = "{HINT} ({VP:0.00%})"
        Series5.Label = PieSeriesLabel5
        Series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series5.LegendName = "Default Legend"
        Series5.LegendTextPattern = "{A}"
        Series5.Name = "Series 1"
        Series5.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series5.ToolTipHintDataMember = "tempo_hhmmss"
        Series5.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle5.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle5.Indent = 0
        SeriesTitle5.Text = "tempo total: "
        PieSeriesView9.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle5})
        Series5.View = PieSeriesView9
        Me.chart5ProdutoAcabado.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5}
        Me.chart5ProdutoAcabado.SeriesTemplate.View = PieSeriesView10
        Me.chart5ProdutoAcabado.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle5.Text = "Produto Acabado"
        Me.chart5ProdutoAcabado.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle5})
        '
        'chart3Maturacao
        '
        Me.chart3Maturacao.BorderColor = System.Drawing.Color.Black
        Me.chart3Maturacao.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart3Maturacao.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart3Maturacao.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart3Maturacao.Legend.Name = "Default Legend"
        Me.chart3Maturacao.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart3Maturacao.LocationFloat = New DevExpress.Utils.PointFloat(0!, 303.875!)
        Me.chart3Maturacao.Name = "chart3Maturacao"
        Me.chart3Maturacao.PaletteName = "GreenRedCustom"
        Me.chart3Maturacao.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series6.ArgumentDataMember = "description"
        Series6.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "maturacaofora")})
        PieSeriesLabel6.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel6.TextPattern = "{HINT} ({VP:0.00%})"
        Series6.Label = PieSeriesLabel6
        Series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series6.LegendName = "Default Legend"
        Series6.LegendTextPattern = "{A}"
        Series6.Name = "Series 1"
        Series6.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series6.ToolTipHintDataMember = "tempo_hhmmss"
        Series6.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle6.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle6.Indent = 0
        SeriesTitle6.Text = "tempo total: "
        PieSeriesView11.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle6})
        Series6.View = PieSeriesView11
        Me.chart3Maturacao.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series6}
        Me.chart3Maturacao.SeriesTemplate.View = PieSeriesView12
        Me.chart3Maturacao.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle6.Text = "Maturação"
        Me.chart3Maturacao.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle6})
        '
        'chart2Salgada
        '
        Me.chart2Salgada.BorderColor = System.Drawing.Color.Black
        Me.chart2Salgada.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart2Salgada.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart2Salgada.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart2Salgada.Legend.Name = "Default Legend"
        Me.chart2Salgada.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart2Salgada.LocationFloat = New DevExpress.Utils.PointFloat(370!, 21.87502!)
        Me.chart2Salgada.Name = "chart2Salgada"
        Me.chart2Salgada.PaletteName = "GreenRedCustom"
        Me.chart2Salgada.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series7.ArgumentDataMember = "description"
        Series7.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "salgadafora")})
        PieSeriesLabel7.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel7.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel7.TextPattern = "{HINT} ({VP:0.00%})"
        Series7.Label = PieSeriesLabel7
        Series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series7.LegendName = "Default Legend"
        Series7.LegendTextPattern = "{A}"
        Series7.Name = "Series 1"
        Series7.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series7.ToolTipHintDataMember = "tempo_hhmmss"
        Series7.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle7.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle7.Indent = 0
        SeriesTitle7.Text = "tempo total: "
        PieSeriesView13.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle7})
        Series7.View = PieSeriesView13
        Me.chart2Salgada.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series7}
        Me.chart2Salgada.SeriesTemplate.View = PieSeriesView14
        Me.chart2Salgada.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle7.Text = "Salgada"
        Me.chart2Salgada.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle7})
        '
        'chart1Montanhes
        '
        Me.chart1Montanhes.BorderColor = System.Drawing.Color.Black
        Me.chart1Montanhes.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart1Montanhes.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart1Montanhes.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart1Montanhes.Legend.Name = "Default Legend"
        Me.chart1Montanhes.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart1Montanhes.LocationFloat = New DevExpress.Utils.PointFloat(0!, 21.87499!)
        Me.chart1Montanhes.Name = "chart1Montanhes"
        Me.chart1Montanhes.PaletteName = "GreenRedCustom"
        Me.chart1Montanhes.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series8.ArgumentDataMember = "description"
        Series8.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "montanhesfora")})
        PieSeriesLabel8.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel8.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel8.TextPattern = "{HINT} ({VP:0.00%})"
        Series8.Label = PieSeriesLabel8
        Series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series8.LegendName = "Default Legend"
        Series8.LegendTextPattern = "{A}"
        Series8.Name = "Series 1"
        Series8.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series8.ToolTipHintDataMember = "tempo_hhmmss"
        Series8.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle8.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle8.Indent = 0
        SeriesTitle8.Text = "tempo total: "
        PieSeriesView15.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle8})
        Series8.View = PieSeriesView15
        Me.chart1Montanhes.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series8}
        Me.chart1Montanhes.SeriesTemplate.View = PieSeriesView16
        Me.chart1Montanhes.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle8.Indent = 0
        ChartTitle8.Text = "Montanhês"
        Me.chart1Montanhes.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle8})
        '
        'pageBreak1
        '
        Me.pageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 867.8751!)
        Me.pageBreak1.Name = "pageBreak1"
        '
        'objectDsLeiteEvento
        '
        Me.objectDsLeiteEvento.DataMember = "GetTempoEventosCamarasFrias"
        Me.objectDsLeiteEvento.DataSource = GetType(AspNet5t.dsIndustria)
        Me.objectDsLeiteEvento.Name = "objectDsLeiteEvento"
        Parameter1.Name = "parIdTag"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.repParIdTag]", GetType(String))
        Me.objectDsLeiteEvento.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption3
        '
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3
        '
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(231,Byte),Integer), CType(CType(231,Byte),Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaptionBackground3
        '
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206,Byte),Integer), CType(CType(206,Byte),Integer), CType(CType(206,Byte),Integer))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2!
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20171009_AUTOGEN"
        Me.repParIdTag.Visible = false
        '
        'repCnIndLeiteCamarasFriasOverviewSubCamarasFriasTempoEventos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsLeiteEvento})
        Me.DataSource = Me.objectDsLeiteEvento
        Me.Margins = New System.Drawing.Printing.Margins(55, 55, 35, 36)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.1"
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart8Secagem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series2,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart7Secagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel3,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series3,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart4MinasRicota,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel4,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series4,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart6Requeijao,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel5,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series5,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart5ProdutoAcabado,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel6,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series6,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart3Maturacao,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel7,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView13,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series7,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView14,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart2Salgada,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel8,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView15,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series8,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView16,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart1Montanhes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.objectDsLeiteEvento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class