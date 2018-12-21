Namespace Win_Dashboards
    Partial Public Class dashGerencialPorRegiaoGrupoproduto
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashGerencialPorRegiaoGrupoproduto))
            Dim MsSqlConnectionParameters2 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.chartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.chartDashboardItem3 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.dashboardSqlDataSource2 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartDashboardItem2
            '
            Dimension1.DataMember = "pDESCRICAO"
            Dimension1.Name = "Descrição Produto"
            Measure1.DataMember = "pVLR_TOTAL_PRODUTO"
            Measure1.Name = "Faturamento"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Millions
            Dimension1.SortByMeasure = Measure1
            Dimension1.TopNOptions.Count = 3
            Dimension1.TopNOptions.Measure = Measure1
            Me.chartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.chartDashboardItem2.AxisX.TitleVisible = False
            Me.chartDashboardItem2.ComponentName = "chartDashboardItem2"
            Dimension2.ColoringMode = DevExpress.DashboardCommon.ColoringMode.None
            Dimension2.DataMember = "pDESCRICAO"
            Dimension2.Name = "Descrição Produto"
            Dimension2.SortByMeasure = Measure1
            Dimension2.TopNOptions.Count = 10
            Dimension2.TopNOptions.Enabled = True
            Dimension2.TopNOptions.Measure = Measure1
            Measure2.DataMember = "pVLR_TOTAL_PRODUTO"
            Measure2.Name = "Faturamento"
            Me.chartDashboardItem2.DataItemRepository.Clear()
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.chartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem1")
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem3")
            Me.chartDashboardItem2.DataItemRepository.Add(Measure2, "DataItem2")
            Me.chartDashboardItem2.DataMember = "Query"
            Me.chartDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem2.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            Me.chartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem2.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.chartDashboardItem2.Legend.Visible = False
            Me.chartDashboardItem2.Name = "TOP 10 PRODUTOS (ANO ATUAL) - R$"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = False
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem2.Rotated = True
            Me.chartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.chartDashboardItem2.ShowCaption = True
            '
            'chartDashboardItem3
            '
            Dimension3.DataMember = "pESTADO"
            Dimension3.Name = "Estado"
            Measure3.DataMember = "pVLR_TOTAL_PRODUTO"
            Measure3.Name = "Faturamento"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Millions
            Dimension3.SortByMeasure = Measure3
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension4.DataMember = "pDATA_EMISSAO"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension4.Name = "Mes"
            Me.chartDashboardItem3.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3, Dimension4})
            Me.chartDashboardItem3.AxisX.TitleVisible = False
            Me.chartDashboardItem3.ComponentName = "chartDashboardItem3"
            Me.chartDashboardItem3.DataItemRepository.Clear()
            Me.chartDashboardItem3.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.chartDashboardItem3.DataItemRepository.Add(Measure3, "DataItem0")
            Me.chartDashboardItem3.DataItemRepository.Add(Dimension4, "DataItem4")
            Me.chartDashboardItem3.DataMember = "Query"
            Me.chartDashboardItem3.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem3.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem3.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem3.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.chartDashboardItem3.Legend.Visible = False
            Me.chartDashboardItem3.Name = "FATURAMENTO POR ESTADO (ANO ATUAL) - R$"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = False
            ChartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.PointLabelOptions.Orientation = DevExpress.DashboardCommon.PointLabelOrientation.RotateLeft
            SimpleSeries2.PointLabelOptions.ShowPointLabels = True
            SimpleSeries2.AddDataItem("Value", Measure3)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.chartDashboardItem3.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.chartDashboardItem3.ShowCaption = True
            '
            'pieDashboardItem1
            '
            Dimension5.DataMember = "pREGIAO"
            Dimension5.Name = "Região"
            Dimension6.DataMember = "cfGRUPOPRODUTO"
            Dimension6.Name = "Grupo de Produtos"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5, Dimension6})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            Measure4.DataMember = "pVLR_TOTAL_PRODUTO"
            Measure4.Name = "Faturamento"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Millions
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem1")
            Me.pieDashboardItem1.DataItemRepository.Add(Measure4, "DataItem2")
            Me.pieDashboardItem1.DataMember = "Query"
            Me.pieDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.pieDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.pieDashboardItem1.LabelContentType = CType(((DevExpress.DashboardCommon.PieValueType.Argument Or DevExpress.DashboardCommon.PieValueType.Percent) _
            Or DevExpress.DashboardCommon.PieValueType.Value), DevExpress.DashboardCommon.PieValueType)
            Me.pieDashboardItem1.Name = "FATURAMENTO POR REGIÃO/GRUPO DE PRODUTOS (ANO ATUAL) - R$"
            Me.pieDashboardItem1.ShowCaption = True
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure4})
            '
            'dashboardSqlDataSource1
            '
            CalculatedField1.DataMember = "Query"
            CalculatedField1.Expression = "Trim([pGRUPO_PRODUTO])"
            CalculatedField1.Name = "cfGRUPOPRODUTO"
            Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1})
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "192.168.50.39_s5taviacao_Connection"
            MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters1.DatabaseName = "s5taviacao"
            MsSqlConnectionParameters1.ServerName = "192.168.50.39"
            Me.dashboardSqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'dashboardSqlDataSource2
            '
            Me.dashboardSqlDataSource2.ComponentName = "dashboardSqlDataSource2"
            Me.dashboardSqlDataSource2.ConnectionName = "192.168.50.39_s5taviacao_Connection"
            MsSqlConnectionParameters2.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters2.DatabaseName = "s5taviacao"
            MsSqlConnectionParameters2.ServerName = "192.168.50.39"
            Me.dashboardSqlDataSource2.ConnectionParameters = MsSqlConnectionParameters2
            Me.dashboardSqlDataSource2.Name = "SQL Data Source 2"
            CustomSqlQuery2.Name = "Query"
            CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
            Me.dashboardSqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
            Me.dashboardSqlDataSource2.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource2.ResultSchemaSerializable")
            '
            'dashGerencialPorRegiaoGrupoproduto
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1, Me.dashboardSqlDataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.chartDashboardItem2, Me.chartDashboardItem3, Me.pieDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
            DashboardLayoutItem1.Weight = 54.759358288770052R
            DashboardLayoutItem2.DashboardItem = Me.chartDashboardItem2
            DashboardLayoutItem2.Weight = 45.240641711229948R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 61.491935483870968R
            DashboardLayoutItem3.DashboardItem = Me.chartDashboardItem3
            DashboardLayoutItem3.Weight = 38.508064516129032R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Alignment = DevExpress.DashboardCommon.DashboardTitleAlignment.Left
            Me.Title.ImageUrl = "C:\Users\sandro\Downloads\logo_aviacao_grande.jpg"
            Me.Title.Text = "FATURAMENTO - LATICÍNIOS"
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents chartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents chartDashboardItem3 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
        Friend WithEvents dashboardSqlDataSource2 As DevExpress.DashboardCommon.DashboardSqlDataSource

#End Region
    End Class
End Namespace