Public Class repCnIndEnvaseOverview
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
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents subreport3 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents subreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents chartEnBBal1500g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents objectDsEnvaseMov As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents chartEnABal2500g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chartEnABal1500g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chartEnBBal2200g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chartEnBBal1200g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents chartEnABal2200g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents pageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents chartEnABal1200g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents chartEnBBal2500g As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents subreport4 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents subreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calculatedField1 As DevExpress.XtraReports.UI.CalculatedField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint1 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition1 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView2 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView3 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView1 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView4 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation2 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint2 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition2 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane2 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView5 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView6 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView7 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView2 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView8 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation3 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint3 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition3 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane3 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY3 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series9 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView9 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series10 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView10 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series11 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView11 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series12 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView3 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView12 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation4 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint4 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition4 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane4 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY4 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series13 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView13 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series14 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView14 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series15 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView15 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series16 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView4 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView16 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation5 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint5 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition5 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram5 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane5 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY5 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series17 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView17 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series18 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView18 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series19 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView19 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series20 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView5 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView20 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation6 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint6 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition6 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram6 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane6 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY6 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series21 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView21 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series22 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView22 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series23 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView23 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series24 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView6 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView24 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation7 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint7 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition7 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram7 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane7 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY7 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series25 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView25 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series26 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView26 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series27 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView27 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series28 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView7 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView28 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim TextAnnotation8 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim ChartAnchorPoint8 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
        Dim FreePosition8 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        Dim XyDiagram8 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagramPane8 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
        Dim SecondaryAxisY8 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series29 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView29 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series30 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView30 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series31 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim AreaSeriesView31 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim Series32 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeAreaSeriesView8 As DevExpress.XtraCharts.RangeAreaSeriesView = New DevExpress.XtraCharts.RangeAreaSeriesView()
        Dim AreaSeriesView32 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
        Dim ChartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repCnIndEnvaseOverview))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.subreport3 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.subreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.chartEnBBal1500g = New DevExpress.XtraReports.UI.XRChart()
        Me.chartEnABal2500g = New DevExpress.XtraReports.UI.XRChart()
        Me.chartEnABal1500g = New DevExpress.XtraReports.UI.XRChart()
        Me.chartEnBBal2200g = New DevExpress.XtraReports.UI.XRChart()
        Me.chartEnBBal1200g = New DevExpress.XtraReports.UI.XRChart()
        Me.chartEnABal2200g = New DevExpress.XtraReports.UI.XRChart()
        Me.pageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.chartEnABal1200g = New DevExpress.XtraReports.UI.XRChart()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.chartEnBBal2500g = New DevExpress.XtraReports.UI.XRChart()
        Me.subreport4 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.subreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.objectDsEnvaseMov = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.chartEnBBal1500g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnABal2500g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnABal1500g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series12,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView12,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnBBal2200g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series13,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView13,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series14,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView14,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series15,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView15,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series16,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView16,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnBBal1200g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series17,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView17,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series18,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView18,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series19,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView19,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series20,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView20,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnABal2200g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series21,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView21,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series22,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView22,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series23,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView23,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnABal1200g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series25,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView25,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series26,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView26,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series27,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView27,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series28,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView28,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartEnBBal2500g,System.ComponentModel.ISupportInitialize).BeginInit
        CType(TextAnnotation8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagram8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(XyDiagramPane8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(SecondaryAxisY8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series29,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView29,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series30,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView30,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series31,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView31,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Series32,System.ComponentModel.ISupportInitialize).BeginInit
        CType(RangeAreaSeriesView8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(AreaSeriesView32,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.objectDsEnvaseMov,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 41!
        Me.TopMargin.Name = "TopMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label10, Me.pageBreak2, Me.subreport3, Me.subreport1, Me.chartEnBBal1500g, Me.chartEnABal2500g, Me.chartEnABal1500g, Me.chartEnBBal2200g, Me.chartEnBBal1200g, Me.chartEnABal2200g, Me.pageBreak1, Me.label9, Me.label8, Me.chartEnABal1200g, Me.label5, Me.label7, Me.chartEnBBal2500g, Me.subreport4, Me.subreport2})
        Me.Detail.HeightF = 3412.41!
        Me.Detail.Name = "Detail"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 116.6667!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.pictureBox1, Me.label2, Me.label3, Me.label4, Me.label6})
        Me.PageHeader.HeightF = 117.7083!
        Me.PageHeader.Name = "PageHeader"
        '
        'label10
        '
        Me.label10.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 142.6632!)
        Me.label10.Multiline = true
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label10.SizeF = New System.Drawing.SizeF(431.7865!, 21.87498!)
        Me.label10.StylePriority.UseFont = false
        Me.label10.StylePriority.UseTextAlignment = false
        Me.label10.Text = "Eventos"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pageBreak2
        '
        Me.pageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.78825!)
        Me.pageBreak2.Name = "pageBreak2"
        '
        'subreport3
        '
        Me.subreport3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 116.6632!)
        Me.subreport3.Name = "subreport3"
        Me.subreport3.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport3.ReportSource = New AspNet5t.repCnIndEnvaseOverviewSubEnvaseInfo()
        Me.subreport3.SizeF = New System.Drawing.SizeF(753!, 24!)
        '
        'subreport1
        '
        Me.subreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.91667!)
        Me.subreport1.Name = "subreport1"
        Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport1.ReportSource = New AspNet5t.repCnIndEnvaseOverviewSubPesoMedio()
        Me.subreport1.SizeF = New System.Drawing.SizeF(753!, 23.99664!)
        '
        'chartEnBBal1500g
        '
        ChartAnchorPoint1.X = 624
        ChartAnchorPoint1.Y = 118
        TextAnnotation1.AnchorPoint = ChartAnchorPoint1
        TextAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation1.Name = "Annotation 1"
        TextAnnotation1.Shadow.Visible = true
        FreePosition1.InnerIndents.Left = 619
        FreePosition1.InnerIndents.Top = 134
        TextAnnotation1.ShapePosition = FreePosition1
        TextAnnotation1.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation1.Visible = false
        Me.chartEnBBal1500g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
        Me.chartEnBBal1500g.BorderColor = System.Drawing.Color.Black
        Me.chartEnBBal1500g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnBBal1500g.DataSource = Me.objectDsEnvaseMov
        XyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram1.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.WholeRange.Auto = false
        XyDiagram1.AxisY.WholeRange.MaxValueSerializable = "525"
        XyDiagram1.AxisY.WholeRange.MinValueSerializable = "500"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.Weight = 5R
        XyDiagramPane1.Name = "Pane 1"
        XyDiagramPane1.PaneID = 0
        XyDiagramPane1.Visible = false
        XyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane1})
        SecondaryAxisY1.AxisID = 0
        SecondaryAxisY1.Label.Visible = false
        SecondaryAxisY1.Name = "Secondary AxisY 1"
        SecondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY1.VisibleInPanesSerializable = "-1"
        XyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY1})
        Me.chartEnBBal1500g.Diagram = XyDiagram1
        Me.chartEnBBal1500g.Legend.Name = "Default Legend"
        Me.chartEnBBal1500g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2212.41!)
        Me.chartEnBBal1500g.Name = "chartEnBBal1500g"
        Series1.ArgumentDataMember = "tm"
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "Peso Médio"
        Series1.ValueDataMembersSerializable = "value"
        AreaSeriesView1.MarkerOptions.Size = 4
        AreaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.View = AreaSeriesView1
        Series2.ArgumentDataMember = "tm"
        Series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.Name = "Peso Desejado"
        Series2.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.View = AreaSeriesView2
        Series3.ArgumentDataMember = "tm"
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series3.Name = "Correção Peso"
        Series3.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView3.AxisYName = "Secondary AxisY 1"
        AreaSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView3.PaneName = "Pane 1"
        AreaSeriesView3.Transparency = CType(0,Byte)
        Series3.View = AreaSeriesView3
        Series3.Visible = false
        Series4.ArgumentDataMember = "tm"
        Series4.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series4.Name = "Limites Copo"
        Series4.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView1.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView1.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView1.Transparency = CType(220,Byte)
        Series4.View = RangeAreaSeriesView1
        Series4.Visible = false
        Me.chartEnBBal1500g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4}
        AreaSeriesView4.Transparency = CType(0,Byte)
        Me.chartEnBBal1500g.SeriesTemplate.View = AreaSeriesView4
        Me.chartEnBBal1500g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle1.Text = "Envase B - Balança 1 - Pote 500g"
        Me.chartEnBBal1500g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'chartEnABal2500g
        '
        ChartAnchorPoint2.X = 624
        ChartAnchorPoint2.Y = 118
        TextAnnotation2.AnchorPoint = ChartAnchorPoint2
        TextAnnotation2.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation2.Name = "annotationLimitesCopo"
        TextAnnotation2.Shadow.Visible = true
        FreePosition2.InnerIndents.Left = 619
        FreePosition2.InnerIndents.Top = 134
        TextAnnotation2.ShapePosition = FreePosition2
        TextAnnotation2.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation2.Visible = false
        Me.chartEnABal2500g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation2})
        Me.chartEnABal2500g.BorderColor = System.Drawing.Color.Black
        Me.chartEnABal2500g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnABal2500g.DataSource = Me.objectDsEnvaseMov
        XyDiagram2.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram2.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram2.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.WholeRange.Auto = false
        XyDiagram2.AxisY.WholeRange.MaxValueSerializable = "525"
        XyDiagram2.AxisY.WholeRange.MinValueSerializable = "500"
        XyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.Weight = 5R
        XyDiagramPane2.Name = "Pane 1"
        XyDiagramPane2.PaneID = 0
        XyDiagramPane2.Visible = false
        XyDiagram2.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane2})
        SecondaryAxisY2.AxisID = 0
        SecondaryAxisY2.Label.Visible = false
        SecondaryAxisY2.Name = "Secondary AxisY 1"
        SecondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY2.VisibleInPanesSerializable = "-1"
        XyDiagram2.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY2})
        Me.chartEnABal2500g.Diagram = XyDiagram2
        Me.chartEnABal2500g.Legend.Name = "Default Legend"
        Me.chartEnABal2500g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1412.41!)
        Me.chartEnABal2500g.Name = "chartEnABal2500g"
        Series5.ArgumentDataMember = "tm"
        Series5.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series5.Name = "Peso Médio"
        Series5.ValueDataMembersSerializable = "value"
        AreaSeriesView5.MarkerOptions.Size = 4
        AreaSeriesView5.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series5.View = AreaSeriesView5
        Series6.ArgumentDataMember = "tm"
        Series6.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series6.Name = "Peso Desejado"
        Series6.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView6.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series6.View = AreaSeriesView6
        Series7.ArgumentDataMember = "tm"
        Series7.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series7.Name = "Correção Peso"
        Series7.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView7.AxisYName = "Secondary AxisY 1"
        AreaSeriesView7.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView7.PaneName = "Pane 1"
        AreaSeriesView7.Transparency = CType(0,Byte)
        Series7.View = AreaSeriesView7
        Series7.Visible = false
        Series8.ArgumentDataMember = "tm"
        Series8.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series8.Name = "Limites Copo"
        Series8.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView2.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView2.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView2.Transparency = CType(220,Byte)
        Series8.View = RangeAreaSeriesView2
        Series8.Visible = false
        Me.chartEnABal2500g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5, Series6, Series7, Series8}
        AreaSeriesView8.Transparency = CType(0,Byte)
        Me.chartEnABal2500g.SeriesTemplate.View = AreaSeriesView8
        Me.chartEnABal2500g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle2.Text = "Envase A - Balança 2 - Pote 500g"
        Me.chartEnABal2500g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'chartEnABal1500g
        '
        ChartAnchorPoint3.X = 624
        ChartAnchorPoint3.Y = 118
        TextAnnotation3.AnchorPoint = ChartAnchorPoint3
        TextAnnotation3.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation3.Name = "annotationLimitesCopo"
        TextAnnotation3.Shadow.Visible = true
        FreePosition3.InnerIndents.Left = 619
        FreePosition3.InnerIndents.Top = 134
        TextAnnotation3.ShapePosition = FreePosition3
        TextAnnotation3.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation3.Visible = false
        Me.chartEnABal1500g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation3})
        Me.chartEnABal1500g.BorderColor = System.Drawing.Color.Black
        Me.chartEnABal1500g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnABal1500g.DataSource = Me.objectDsEnvaseMov
        XyDiagram3.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram3.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram3.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram3.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.WholeRange.Auto = false
        XyDiagram3.AxisY.WholeRange.MaxValueSerializable = "525"
        XyDiagram3.AxisY.WholeRange.MinValueSerializable = "500"
        XyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.Weight = 5R
        XyDiagramPane3.Name = "Pane 1"
        XyDiagramPane3.PaneID = 0
        XyDiagramPane3.Visible = false
        XyDiagram3.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane3})
        SecondaryAxisY3.AxisID = 0
        SecondaryAxisY3.Label.Visible = false
        SecondaryAxisY3.Name = "Secondary AxisY 1"
        SecondaryAxisY3.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY3.VisibleInPanesSerializable = "-1"
        XyDiagram3.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY3})
        Me.chartEnABal1500g.Diagram = XyDiagram3
        Me.chartEnABal1500g.Legend.Name = "Default Legend"
        Me.chartEnABal1500g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 612.4101!)
        Me.chartEnABal1500g.Name = "chartEnABal1500g"
        Series9.ArgumentDataMember = "tm"
        Series9.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series9.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series9.Name = "Peso Médio"
        Series9.ValueDataMembersSerializable = "value"
        AreaSeriesView9.MarkerOptions.Size = 4
        AreaSeriesView9.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series9.View = AreaSeriesView9
        Series10.ArgumentDataMember = "tm"
        Series10.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series10.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series10.Name = "Peso Desejado"
        Series10.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView10.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series10.View = AreaSeriesView10
        Series11.ArgumentDataMember = "tm"
        Series11.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series11.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series11.Name = "Correção Peso"
        Series11.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView11.AxisYName = "Secondary AxisY 1"
        AreaSeriesView11.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView11.PaneName = "Pane 1"
        AreaSeriesView11.Transparency = CType(0,Byte)
        Series11.View = AreaSeriesView11
        Series11.Visible = false
        Series12.ArgumentDataMember = "tm"
        Series12.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series12.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series12.Name = "Limites Copo"
        Series12.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView3.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView3.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView3.Transparency = CType(220,Byte)
        Series12.View = RangeAreaSeriesView3
        Series12.Visible = false
        Me.chartEnABal1500g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series9, Series10, Series11, Series12}
        AreaSeriesView12.Transparency = CType(0,Byte)
        Me.chartEnABal1500g.SeriesTemplate.View = AreaSeriesView12
        Me.chartEnABal1500g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle3.Text = "Envase A - Balança 1 - Pote 500g"
        Me.chartEnABal1500g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'chartEnBBal2200g
        '
        ChartAnchorPoint4.X = 624
        ChartAnchorPoint4.Y = 118
        TextAnnotation4.AnchorPoint = ChartAnchorPoint4
        TextAnnotation4.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation4.Name = "annotationLimitesCopo"
        TextAnnotation4.Shadow.Visible = true
        FreePosition4.InnerIndents.Left = 619
        FreePosition4.InnerIndents.Top = 134
        TextAnnotation4.ShapePosition = FreePosition4
        TextAnnotation4.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation4.Visible = false
        Me.chartEnBBal2200g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation4})
        Me.chartEnBBal2200g.BorderColor = System.Drawing.Color.Black
        Me.chartEnBBal2200g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnBBal2200g.DataSource = Me.objectDsEnvaseMov
        XyDiagram4.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram4.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram4.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram4.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.WholeRange.Auto = false
        XyDiagram4.AxisY.WholeRange.MaxValueSerializable = "212"
        XyDiagram4.AxisY.WholeRange.MinValueSerializable = "200"
        XyDiagram4.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.Weight = 5R
        XyDiagramPane4.Name = "Pane 1"
        XyDiagramPane4.PaneID = 0
        XyDiagramPane4.Visible = false
        XyDiagram4.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane4})
        SecondaryAxisY4.AxisID = 0
        SecondaryAxisY4.Label.Visible = false
        SecondaryAxisY4.Name = "Secondary AxisY 1"
        SecondaryAxisY4.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY4.VisibleInPanesSerializable = "-1"
        XyDiagram4.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY4})
        Me.chartEnBBal2200g.Diagram = XyDiagram4
        Me.chartEnBBal2200g.Legend.Name = "Default Legend"
        Me.chartEnBBal2200g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2612.41!)
        Me.chartEnBBal2200g.Name = "chartEnBBal2200g"
        Series13.ArgumentDataMember = "tm"
        Series13.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series13.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series13.Name = "Peso Médio"
        Series13.ValueDataMembersSerializable = "value"
        AreaSeriesView13.MarkerOptions.Size = 4
        AreaSeriesView13.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series13.View = AreaSeriesView13
        Series14.ArgumentDataMember = "tm"
        Series14.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series14.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series14.Name = "Peso Desejado"
        Series14.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView14.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series14.View = AreaSeriesView14
        Series15.ArgumentDataMember = "tm"
        Series15.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series15.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series15.Name = "Correção Peso"
        Series15.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView15.AxisYName = "Secondary AxisY 1"
        AreaSeriesView15.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView15.PaneName = "Pane 1"
        AreaSeriesView15.Transparency = CType(0,Byte)
        Series15.View = AreaSeriesView15
        Series15.Visible = false
        Series16.ArgumentDataMember = "tm"
        Series16.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series16.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series16.Name = "Limites Copo"
        Series16.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView4.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView4.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView4.Transparency = CType(220,Byte)
        Series16.View = RangeAreaSeriesView4
        Series16.Visible = false
        Me.chartEnBBal2200g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series13, Series14, Series15, Series16}
        AreaSeriesView16.Transparency = CType(0,Byte)
        Me.chartEnBBal2200g.SeriesTemplate.View = AreaSeriesView16
        Me.chartEnBBal2200g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle4.Text = "Envase B - Balança 2 - Pote 200g"
        Me.chartEnBBal2200g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'chartEnBBal1200g
        '
        ChartAnchorPoint5.X = 624
        ChartAnchorPoint5.Y = 118
        TextAnnotation5.AnchorPoint = ChartAnchorPoint5
        TextAnnotation5.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation5.Name = "annotationLimitesCopo"
        TextAnnotation5.Shadow.Visible = true
        FreePosition5.InnerIndents.Left = 619
        FreePosition5.InnerIndents.Top = 134
        TextAnnotation5.ShapePosition = FreePosition5
        TextAnnotation5.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation5.Visible = false
        Me.chartEnBBal1200g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation5})
        Me.chartEnBBal1200g.BorderColor = System.Drawing.Color.Black
        Me.chartEnBBal1200g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnBBal1200g.DataSource = Me.objectDsEnvaseMov
        XyDiagram5.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram5.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram5.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram5.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram5.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram5.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram5.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram5.AxisY.WholeRange.Auto = false
        XyDiagram5.AxisY.WholeRange.MaxValueSerializable = "212"
        XyDiagram5.AxisY.WholeRange.MinValueSerializable = "200"
        XyDiagram5.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.Weight = 5R
        XyDiagramPane5.Name = "Pane 1"
        XyDiagramPane5.PaneID = 0
        XyDiagramPane5.Visible = false
        XyDiagram5.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane5})
        SecondaryAxisY5.AxisID = 0
        SecondaryAxisY5.Label.Visible = false
        SecondaryAxisY5.Name = "Secondary AxisY 1"
        SecondaryAxisY5.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY5.VisibleInPanesSerializable = "-1"
        XyDiagram5.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY5})
        Me.chartEnBBal1200g.Diagram = XyDiagram5
        Me.chartEnBBal1200g.Legend.Name = "Default Legend"
        Me.chartEnBBal1200g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1812.41!)
        Me.chartEnBBal1200g.Name = "chartEnBBal1200g"
        Series17.ArgumentDataMember = "tm"
        Series17.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series17.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series17.Name = "Peso Médio"
        Series17.ValueDataMembersSerializable = "value"
        AreaSeriesView17.MarkerOptions.Size = 4
        AreaSeriesView17.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series17.View = AreaSeriesView17
        Series18.ArgumentDataMember = "tm"
        Series18.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series18.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series18.Name = "Peso Desejado"
        Series18.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView18.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series18.View = AreaSeriesView18
        Series19.ArgumentDataMember = "tm"
        Series19.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series19.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series19.Name = "Correção Peso"
        Series19.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView19.AxisYName = "Secondary AxisY 1"
        AreaSeriesView19.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView19.PaneName = "Pane 1"
        AreaSeriesView19.Transparency = CType(0,Byte)
        Series19.View = AreaSeriesView19
        Series19.Visible = false
        Series20.ArgumentDataMember = "tm"
        Series20.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25874), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series20.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series20.Name = "Limites Copo"
        Series20.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView5.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView5.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView5.Transparency = CType(220,Byte)
        Series20.View = RangeAreaSeriesView5
        Series20.Visible = false
        Me.chartEnBBal1200g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series17, Series18, Series19, Series20}
        AreaSeriesView20.Transparency = CType(0,Byte)
        Me.chartEnBBal1200g.SeriesTemplate.View = AreaSeriesView20
        Me.chartEnBBal1200g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle5.Text = "Envase B - Balança 1 - Pote 200g"
        Me.chartEnBBal1200g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle5})
        '
        'chartEnABal2200g
        '
        ChartAnchorPoint6.X = 624
        ChartAnchorPoint6.Y = 118
        TextAnnotation6.AnchorPoint = ChartAnchorPoint6
        TextAnnotation6.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation6.Name = "annotationLimitesCopo"
        TextAnnotation6.Shadow.Visible = true
        FreePosition6.InnerIndents.Left = 619
        FreePosition6.InnerIndents.Top = 134
        TextAnnotation6.ShapePosition = FreePosition6
        TextAnnotation6.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation6.Visible = false
        Me.chartEnABal2200g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation6})
        Me.chartEnABal2200g.BorderColor = System.Drawing.Color.Black
        Me.chartEnABal2200g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnABal2200g.DataSource = Me.objectDsEnvaseMov
        XyDiagram6.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram6.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram6.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram6.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram6.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram6.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram6.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram6.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram6.AxisY.WholeRange.Auto = false
        XyDiagram6.AxisY.WholeRange.MaxValueSerializable = "212"
        XyDiagram6.AxisY.WholeRange.MinValueSerializable = "200"
        XyDiagram6.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.Weight = 5R
        XyDiagramPane6.Name = "Pane 1"
        XyDiagramPane6.PaneID = 0
        XyDiagramPane6.Visible = false
        XyDiagram6.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane6})
        SecondaryAxisY6.AxisID = 0
        SecondaryAxisY6.Label.Visible = false
        SecondaryAxisY6.Name = "Secondary AxisY 1"
        SecondaryAxisY6.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY6.VisibleInPanesSerializable = "-1"
        XyDiagram6.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY6})
        Me.chartEnABal2200g.Diagram = XyDiagram6
        Me.chartEnABal2200g.Legend.Name = "Default Legend"
        Me.chartEnABal2200g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1012.41!)
        Me.chartEnABal2200g.Name = "chartEnABal2200g"
        Series21.ArgumentDataMember = "tm"
        Series21.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series21.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series21.Name = "Peso Médio"
        Series21.ValueDataMembersSerializable = "value"
        AreaSeriesView21.MarkerOptions.Size = 4
        AreaSeriesView21.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series21.View = AreaSeriesView21
        Series22.ArgumentDataMember = "tm"
        Series22.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series22.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series22.Name = "Peso Desejado"
        Series22.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView22.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series22.View = AreaSeriesView22
        Series23.ArgumentDataMember = "tm"
        Series23.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series23.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series23.Name = "Correção Peso"
        Series23.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView23.AxisYName = "Secondary AxisY 1"
        AreaSeriesView23.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView23.PaneName = "Pane 1"
        AreaSeriesView23.Transparency = CType(0,Byte)
        Series23.View = AreaSeriesView23
        Series23.Visible = false
        Series24.ArgumentDataMember = "tm"
        Series24.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25679), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series24.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series24.Name = "Limites Copo"
        Series24.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView6.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView6.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView6.Transparency = CType(220,Byte)
        Series24.View = RangeAreaSeriesView6
        Series24.Visible = false
        Me.chartEnABal2200g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series21, Series22, Series23, Series24}
        AreaSeriesView24.Transparency = CType(0,Byte)
        Me.chartEnABal2200g.SeriesTemplate.View = AreaSeriesView24
        Me.chartEnABal2200g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle6.Text = "Envase A - Balança 2 - Pote 200g"
        Me.chartEnABal2200g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle6})
        '
        'pageBreak1
        '
        Me.pageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 190.5351!)
        Me.pageBreak1.Name = "pageBreak1"
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 190.5351!)
        Me.label9.Multiline = true
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(431.7865!, 21.87498!)
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "Gráficos de Pesagens no Dia"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 94.78823!)
        Me.label8.Multiline = true
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(431.7865!, 21.87498!)
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "Outras Informações"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'chartEnABal1200g
        '
        ChartAnchorPoint7.X = 624
        ChartAnchorPoint7.Y = 118
        TextAnnotation7.AnchorPoint = ChartAnchorPoint7
        TextAnnotation7.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation7.Name = "annotationLimitesCopo"
        TextAnnotation7.Shadow.Visible = true
        FreePosition7.InnerIndents.Left = 619
        FreePosition7.InnerIndents.Top = 134
        TextAnnotation7.ShapePosition = FreePosition7
        TextAnnotation7.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation7.Visible = false
        Me.chartEnABal1200g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation7})
        Me.chartEnABal1200g.BorderColor = System.Drawing.Color.Black
        Me.chartEnABal1200g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnABal1200g.DataSource = Me.objectDsEnvaseMov
        XyDiagram7.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram7.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram7.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram7.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram7.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram7.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram7.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram7.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram7.AxisY.WholeRange.Auto = false
        XyDiagram7.AxisY.WholeRange.MaxValueSerializable = "212"
        XyDiagram7.AxisY.WholeRange.MinValueSerializable = "200"
        XyDiagram7.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.Weight = 5R
        XyDiagramPane7.Name = "Pane 1"
        XyDiagramPane7.PaneID = 0
        XyDiagramPane7.Visible = false
        XyDiagram7.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane7})
        SecondaryAxisY7.AxisID = 0
        SecondaryAxisY7.Label.Visible = false
        SecondaryAxisY7.Name = "Secondary AxisY 1"
        SecondaryAxisY7.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY7.VisibleInPanesSerializable = "-1"
        XyDiagram7.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY7})
        Me.chartEnABal1200g.Diagram = XyDiagram7
        Me.chartEnABal1200g.Legend.Name = "Default Legend"
        Me.chartEnABal1200g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 212.4101!)
        Me.chartEnABal1200g.Name = "chartEnABal1200g"
        Series25.ArgumentDataMember = "tm"
        Series25.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series25.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series25.Name = "Peso Médio"
        Series25.ValueDataMembersSerializable = "value"
        AreaSeriesView25.MarkerOptions.Size = 4
        AreaSeriesView25.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series25.View = AreaSeriesView25
        Series26.ArgumentDataMember = "tm"
        Series26.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series26.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series26.Name = "Peso Desejado"
        Series26.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView26.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series26.View = AreaSeriesView26
        Series27.ArgumentDataMember = "tm"
        Series27.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series27.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series27.Name = "Correção Peso"
        Series27.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView27.AxisYName = "Secondary AxisY 1"
        AreaSeriesView27.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView27.PaneName = "Pane 1"
        AreaSeriesView27.Transparency = CType(0,Byte)
        Series27.View = AreaSeriesView27
        Series27.Visible = false
        Series28.ArgumentDataMember = "tm"
        Series28.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25677), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 0)})
        Series28.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series28.Name = "Limites Copo"
        Series28.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView7.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView7.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView7.Transparency = CType(220,Byte)
        Series28.View = RangeAreaSeriesView7
        Series28.Visible = false
        Me.chartEnABal1200g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series25, Series26, Series27, Series28}
        AreaSeriesView28.Transparency = CType(0,Byte)
        Me.chartEnABal1200g.SeriesTemplate.View = AreaSeriesView28
        Me.chartEnABal1200g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle7.Text = "Envase A - Balança 1 - Pote 200g"
        Me.chartEnABal1200g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle7})
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(0.3277461!, 1.041667!)
        Me.label5.Multiline = true
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(282.2916!, 21.875!)
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.Text = "Resumo de Pesagens Médias"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.91331!)
        Me.label7.Multiline = true
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(431.7865!, 21.87498!)
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "Resumo dos Diferenciais ao Peso Desejado"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'chartEnBBal2500g
        '
        ChartAnchorPoint8.X = 624
        ChartAnchorPoint8.Y = 118
        TextAnnotation8.AnchorPoint = ChartAnchorPoint8
        TextAnnotation8.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
        TextAnnotation8.Name = "annotationLimitesCopo"
        TextAnnotation8.Shadow.Visible = true
        FreePosition8.InnerIndents.Left = 619
        FreePosition8.InnerIndents.Top = 134
        TextAnnotation8.ShapePosition = FreePosition8
        TextAnnotation8.Text = "LIMITES COPO"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Inferior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"180g"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Média Superior"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"240g"
        TextAnnotation8.Visible = false
        Me.chartEnBBal2500g.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation8})
        Me.chartEnBBal2500g.BorderColor = System.Drawing.Color.Black
        Me.chartEnBBal2500g.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chartEnBBal2500g.DataSource = Me.objectDsEnvaseMov
        XyDiagram8.AxisX.DateTimeScaleOptions.AutoGrid = false
        XyDiagram8.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Minute
        XyDiagram8.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
        XyDiagram8.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertEmptyPoints
        XyDiagram8.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram8.AxisX.WholeRange.AutoSideMargins = false
        XyDiagram8.AxisX.WholeRange.SideMarginsValue = 0R
        XyDiagram8.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram8.AxisY.WholeRange.Auto = false
        XyDiagram8.AxisY.WholeRange.MaxValueSerializable = "525"
        XyDiagram8.AxisY.WholeRange.MinValueSerializable = "500"
        XyDiagram8.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.Weight = 5R
        XyDiagramPane8.Name = "Pane 1"
        XyDiagramPane8.PaneID = 0
        XyDiagramPane8.Visible = false
        XyDiagram8.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane8})
        SecondaryAxisY8.AxisID = 0
        SecondaryAxisY8.Label.Visible = false
        SecondaryAxisY8.Name = "Secondary AxisY 1"
        SecondaryAxisY8.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SecondaryAxisY8.VisibleInPanesSerializable = "-1"
        XyDiagram8.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY8})
        Me.chartEnBBal2500g.Diagram = XyDiagram8
        Me.chartEnBBal2500g.Legend.Name = "Default Legend"
        Me.chartEnBBal2500g.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3012.41!)
        Me.chartEnBBal2500g.Name = "chartEnBBal2500g"
        Series29.ArgumentDataMember = "tm"
        Series29.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series29.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series29.Name = "Peso Médio"
        Series29.ValueDataMembersSerializable = "value"
        AreaSeriesView29.MarkerOptions.Size = 4
        AreaSeriesView29.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series29.View = AreaSeriesView29
        Series30.ArgumentDataMember = "tm"
        Series30.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series30.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series30.Name = "Peso Desejado"
        Series30.ValueDataMembersSerializable = "ultPesoDesejado"
        AreaSeriesView30.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series30.View = AreaSeriesView30
        Series31.ArgumentDataMember = "tm"
        Series31.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series31.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series31.Name = "Correção Peso"
        Series31.ValueDataMembersSerializable = "ultStatusCorrecaoPeso"
        AreaSeriesView31.AxisYName = "Secondary AxisY 1"
        AreaSeriesView31.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
        AreaSeriesView31.PaneName = "Pane 1"
        AreaSeriesView31.Transparency = CType(0,Byte)
        Series31.View = AreaSeriesView31
        Series31.Visible = false
        Series32.ArgumentDataMember = "tm"
        Series32.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.XRDataFilter("itemid", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 25838), New DevExpress.XtraCharts.XRDataFilter("ultTipoPote", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        Series32.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series32.Name = "Limites Copo"
        Series32.ValueDataMembersSerializable = "ultLimInfCopo;ultLimSupCopo"
        RangeAreaSeriesView8.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView8.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[False]
        RangeAreaSeriesView8.Transparency = CType(220,Byte)
        Series32.View = RangeAreaSeriesView8
        Series32.Visible = false
        Me.chartEnBBal2500g.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series29, Series30, Series31, Series32}
        AreaSeriesView32.Transparency = CType(0,Byte)
        Me.chartEnBBal2500g.SeriesTemplate.View = AreaSeriesView32
        Me.chartEnBBal2500g.SizeF = New System.Drawing.SizeF(753!, 400!)
        ChartTitle8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        ChartTitle8.Text = "Envase B - Balança 2 - Pote 500g"
        Me.chartEnBBal2500g.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle8})
        '
        'subreport4
        '
        Me.subreport4.LocationFloat = New DevExpress.Utils.PointFloat(0.3277542!, 164.5382!)
        Me.subreport4.Name = "subreport4"
        Me.subreport4.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport4.ReportSource = New AspNet5t.repCnIndEnvaseOverviewSubEnvaseEvento()
        Me.subreport4.SizeF = New System.Drawing.SizeF(752.3422!, 23.00003!)
        '
        'subreport2
        '
        Me.subreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.78828!)
        Me.subreport2.Name = "subreport2"
        Me.subreport2.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("repParIdTag", Me.repParIdTag))
        Me.subreport2.ReportSource = New AspNet5t.repCnIndEnvaseOverviewSubPesoMedioDifDesejado()
        Me.subreport2.SizeF = New System.Drawing.SizeF(752.67!, 23!)
        '
        'objectDsEnvaseMov
        '
        Me.objectDsEnvaseMov.DataMember = "GetEnvaseMov"
        Me.objectDsEnvaseMov.DataSource = GetType(AspNet5t.dsIndustria)
        Me.objectDsEnvaseMov.Name = "objectDsEnvaseMov"
        Parameter1.Name = "parIdTag"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.repParIdTag]", GetType(String))
        Me.objectDsEnvaseMov.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
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
        Me.label3.Text = "Envase de Manteiga - Overview Diário da Produção"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(224.286!, 95.83334!)
        Me.label4.Multiline = true
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(208.3333!, 21.875!)
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.Text = "Data:"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label6
        '
        Me.label6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.objectDsEnvaseMov, "calculatedField1")})
        Me.label6.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(432.6195!, 95.83334!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(129.1667!, 21.875!)
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "label6"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'calculatedField1
        '
        Me.calculatedField1.DataSource = Me.objectDsEnvaseMov
        Me.calculatedField1.DisplayName = "cfPeriodoINIData"
        Me.calculatedField1.Expression = "Substring([periodoINI], 8, 2) + '/' + Substring([periodoINI], 5, 2) + '/' + Subst"& _ 
    "ring([periodoINI], 0, 4)"
        Me.calculatedField1.Name = "calculatedField1"
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20171016_AUTOGEN"
        Me.repParIdTag.Visible = false
        '
        'repCnIndEnvaseOverview
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calculatedField1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsEnvaseMov})
        Me.Margins = New System.Drawing.Printing.Margins(50, 47, 41, 117)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.Version = "17.1"
        CType(TextAnnotation1,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane1,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY1,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram1,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series1,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series2,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series3,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series4,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnBBal1500g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation2,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane2,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY2,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram2,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series5,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series6,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series7,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series8,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnABal2500g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation3,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane3,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY3,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram3,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series9,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series10,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series11,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series12,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnABal1500g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation4,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane4,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY4,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram4,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView13,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series13,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView14,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series14,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView15,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series15,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series16,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView16,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnBBal2200g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation5,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane5,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY5,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram5,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView17,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series17,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView18,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series18,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView19,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series19,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series20,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView20,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnBBal1200g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation6,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane6,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY6,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram6,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView21,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series21,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView22,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series22,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView23,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series23,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series24,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnABal2200g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation7,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane7,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY7,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram7,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView25,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series25,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView26,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series26,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView27,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series27,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series28,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView28,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnABal1200g,System.ComponentModel.ISupportInitialize).EndInit
        CType(TextAnnotation8,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagramPane8,System.ComponentModel.ISupportInitialize).EndInit
        CType(SecondaryAxisY8,System.ComponentModel.ISupportInitialize).EndInit
        CType(XyDiagram8,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView29,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series29,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView30,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series30,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView31,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series31,System.ComponentModel.ISupportInitialize).EndInit
        CType(RangeAreaSeriesView8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Series32,System.ComponentModel.ISupportInitialize).EndInit
        CType(AreaSeriesView32,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartEnBBal2500g,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.objectDsEnvaseMov,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class