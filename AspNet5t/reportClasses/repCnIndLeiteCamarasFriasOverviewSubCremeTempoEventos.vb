Public Class repCnIndLeiteCamarasFriasOverviewSubCremeTempoEventos
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
    Friend WithEvents chart4TempPasteurizacao As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart3Limpeza As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart2Automatico As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chart1MaqLigada As DevExpress.XtraReports.UI.XRChart
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
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.chart4TempPasteurizacao = New DevExpress.XtraReports.UI.XRChart()
        Me.chart3Limpeza = New DevExpress.XtraReports.UI.XRChart()
        Me.chart2Automatico = New DevExpress.XtraReports.UI.XRChart()
        Me.chart1MaqLigada = New DevExpress.XtraReports.UI.XRChart()
        Me.objectDsLeiteEvento = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.chart4TempPasteurizacao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart3Limpeza,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart2Automatico,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chart1MaqLigada,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesLabel4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(PieSeriesView8,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.chart4TempPasteurizacao, Me.chart3Limpeza, Me.chart2Automatico, Me.chart1MaqLigada})
        Me.ReportHeader.HeightF = 846!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'chart4TempPasteurizacao
        '
        Me.chart4TempPasteurizacao.BorderColor = System.Drawing.Color.Black
        Me.chart4TempPasteurizacao.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart4TempPasteurizacao.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart4TempPasteurizacao.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart4TempPasteurizacao.Legend.Name = "Default Legend"
        Me.chart4TempPasteurizacao.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart4TempPasteurizacao.LocationFloat = New DevExpress.Utils.PointFloat(0!, 564!)
        Me.chart4TempPasteurizacao.Name = "chart4TempPasteurizacao"
        Me.chart4TempPasteurizacao.PaletteName = "GreenRedCustom"
        Me.chart4TempPasteurizacao.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series1.ArgumentDataMember = "description"
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "pasteurizacaofora")})
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
        Me.chart4TempPasteurizacao.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.chart4TempPasteurizacao.SeriesTemplate.View = PieSeriesView2
        Me.chart4TempPasteurizacao.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle1.Text = "Tempo Temperatura Pasteurização"
        Me.chart4TempPasteurizacao.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'chart3Limpeza
        '
        Me.chart3Limpeza.BorderColor = System.Drawing.Color.Black
        Me.chart3Limpeza.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart3Limpeza.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart3Limpeza.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart3Limpeza.Legend.Name = "Default Legend"
        Me.chart3Limpeza.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart3Limpeza.LocationFloat = New DevExpress.Utils.PointFloat(193.75!, 282!)
        Me.chart3Limpeza.Name = "chart3Limpeza"
        Me.chart3Limpeza.PaletteName = "GreenRedCustom"
        Me.chart3Limpeza.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series2.ArgumentDataMember = "description"
        Series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "limpeza")})
        PieSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.TextPattern = "{HINT} ({VP:0.00%})"
        Series2.Label = PieSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.LegendName = "Default Legend"
        Series2.LegendTextPattern = "{A}"
        Series2.Name = "Series 1"
        Series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Series2.ToolTipHintDataMember = "tempo_hhmmss"
        Series2.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle2.Indent = 0
        SeriesTitle2.Text = "tempo total: "
        PieSeriesView3.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle2})
        Series2.View = PieSeriesView3
        Me.chart3Limpeza.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.chart3Limpeza.SeriesTemplate.View = PieSeriesView4
        Me.chart3Limpeza.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle2.Text = "Tempo de Operação"
        Me.chart3Limpeza.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'chart2Automatico
        '
        Me.chart2Automatico.BorderColor = System.Drawing.Color.Black
        Me.chart2Automatico.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart2Automatico.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart2Automatico.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart2Automatico.Legend.Name = "Default Legend"
        Me.chart2Automatico.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart2Automatico.LocationFloat = New DevExpress.Utils.PointFloat(370.0001!, 0!)
        Me.chart2Automatico.Name = "chart2Automatico"
        Me.chart2Automatico.PaletteName = "GreenRedCustom"
        Me.chart2Automatico.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series3.ArgumentDataMember = "description"
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "automatico")})
        PieSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.TextPattern = "{HINT} ({VP:0.00%})"
        Series3.Label = PieSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.LegendName = "Default Legend"
        Series3.LegendTextPattern = "{A}"
        Series3.Name = "Series 1"
        Series3.ToolTipHintDataMember = "tempo_hhmmss"
        Series3.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle3.Indent = 0
        SeriesTitle3.Text = "tempo total: "
        PieSeriesView5.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle3})
        Series3.View = PieSeriesView5
        Me.chart2Automatico.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.chart2Automatico.SeriesTemplate.View = PieSeriesView6
        Me.chart2Automatico.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle3.Text = "Tempo de Operação"
        Me.chart2Automatico.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'chart1MaqLigada
        '
        Me.chart1MaqLigada.BorderColor = System.Drawing.Color.Black
        Me.chart1MaqLigada.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chart1MaqLigada.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart1MaqLigada.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart1MaqLigada.Legend.Name = "Default Legend"
        Me.chart1MaqLigada.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart1MaqLigada.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05!, 0!)
        Me.chart1MaqLigada.Name = "chart1MaqLigada"
        Me.chart1MaqLigada.PaletteName = "GreenRedCustom"
        Me.chart1MaqLigada.PaletteRepository.Add("GreenRedCustom", New DevExpress.XtraCharts.Palette("GreenRedCustom", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(179,Byte),Integer), CType(CType(0,Byte),Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series4.ArgumentDataMember = "description"
        Series4.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("tag", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "maqligada")})
        PieSeriesLabel4.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel4.TextPattern = "{HINT} ({VP:0.00%})"
        Series4.Label = PieSeriesLabel4
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.LegendName = "Default Legend"
        Series4.LegendTextPattern = "{A}"
        Series4.Name = "Series 1"
        Series4.ToolTipHintDataMember = "tempo_hhmmss"
        Series4.ValueDataMembersSerializable = "tempo_segundos"
        SeriesTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        SeriesTitle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        SeriesTitle4.Indent = 0
        SeriesTitle4.Text = "tempo total: "
        PieSeriesView7.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle4})
        Series4.View = PieSeriesView7
        Me.chart1MaqLigada.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.chart1MaqLigada.SeriesTemplate.View = PieSeriesView8
        Me.chart1MaqLigada.SizeF = New System.Drawing.SizeF(370!, 282!)
        ChartTitle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle4.Indent = 0
        ChartTitle4.Text = "Tempo de Operação"
        Me.chart1MaqLigada.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'objectDsLeiteEvento
        '
        Me.objectDsLeiteEvento.DataMember = "GetTempoEventosCreme"
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
        Me.repParIdTag.ValueInfo = "20171010_AUTOGEN"
        Me.repParIdTag.Visible = false
        '
        'repCnIndLeiteCamarasFriasOverviewSubCremeTempoEventos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsLeiteEvento})
        Me.DataSource = Me.objectDsLeiteEvento
        Me.DisplayName = "repCnIndLeiteCamarasFriasOverviewSubCremeTempoEventos"
        Me.Margins = New System.Drawing.Printing.Margins(55, 55, 35, 36)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.1"
        CType(PieSeriesLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series1,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart4TempPasteurizacao,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel2,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series2,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart3Limpeza,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel3,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series3,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart2Automatico,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesLabel4,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series4,System.ComponentModel.ISupportInitialize).EndInit
        CType(PieSeriesView8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chart1MaqLigada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.objectDsLeiteEvento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class