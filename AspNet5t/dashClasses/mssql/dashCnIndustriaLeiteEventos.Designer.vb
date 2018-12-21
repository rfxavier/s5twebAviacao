Namespace Win_Dashboards
    Partial Public Class dashCnIndustriaLeiteEventos
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
        Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
        Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim GridDimensionColumn2 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
        Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim GridDimensionColumn3 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
        Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
        Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
        Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
        Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
        Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
        Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnIndustriaLeiteEventos))
        Dim CalculatedField2 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
        Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
        Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
        Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
        Me.rangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
        Me.comboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
        Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
        CType(Me.gridDashboardItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Measure1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Measure2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chartDashboardItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Measure3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.rangeFilterDashboardItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Measure4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.comboBoxDashboardItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dashboardSqlDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'gridDashboardItem1
        '
        Dimension1.DataMember = "hostname"
        Dimension1.Name = "Envase"
        Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
        GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridDimensionColumn1.AddDataItem("Dimension", Dimension1)
        Dimension2.DataMember = "description"
        Dimension2.Name = "Descrição"
        Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
        GridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridDimensionColumn2.AddDataItem("Dimension", Dimension2)
        Dimension3.DataMember = "calcData"
        Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
        Dimension3.Name = "Data"
        GridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridDimensionColumn3.AddDataItem("Dimension", Dimension3)
        Measure1.DataMember = "numOcorrencia"
        Measure1.Name = "Número Ocorrências"
        GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridMeasureColumn1.AddDataItem("Measure", Measure1)
        Measure2.DataMember = "calcSumSegundosHHMMSS"
        Measure2.Name = "Tempo de Duração"
        Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
        GridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridMeasureColumn2.AddDataItem("Measure", Measure2)
        Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridMeasureColumn1, GridMeasureColumn2})
        Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
        Me.gridDashboardItem1.DataItemRepository.Clear
        Me.gridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
        Me.gridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
        Me.gridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
        Me.gridDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3")
        Me.gridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem4")
        Me.gridDashboardItem1.DataMember = "IndustriaEnvaseEvento"
        Me.gridDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false
        Me.gridDashboardItem1.InteractivityOptions.IsDrillDownEnabled = true
        Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
        Me.gridDashboardItem1.Name = "Ocorrência de Eventos e Tempo de Duração"
        Me.gridDashboardItem1.ShowCaption = true
        '
        'chartDashboardItem1
        '
        Dimension4.DataMember = "calcData"
        Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
        Dimension4.Name = "Data"
        Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
        Me.chartDashboardItem1.AxisX.TitleVisible = false
        Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
        Measure3.DataMember = "numOcorrencia"
        Measure3.Name = "Número Ocorrências"
        Me.chartDashboardItem1.DataItemRepository.Clear
        Me.chartDashboardItem1.DataItemRepository.Add(Measure3, "DataItem1")
        Me.chartDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem0")
        Me.chartDashboardItem1.DataMember = "IndustriaEnvaseEvento"
        Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false
        Me.chartDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
        Me.chartDashboardItem1.Legend.Visible = false
        Me.chartDashboardItem1.Name = "Ocorrência de Eventos por Dia"
        ChartPane1.Name = "Pane 1"
        ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true
        ChartPane1.PrimaryAxisY.ShowGridLines = true
        ChartPane1.PrimaryAxisY.TitleVisible = true
        ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true
        ChartPane1.SecondaryAxisY.ShowGridLines = false
        ChartPane1.SecondaryAxisY.TitleVisible = true
        SimpleSeries1.AddDataItem("Value", Measure3)
        ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
        Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
        Me.chartDashboardItem1.ShowCaption = true
        '
        'rangeFilterDashboardItem1
        '
        Dimension5.DataMember = "calcData"
        Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
        Dimension5.Name = "Data"
        Me.rangeFilterDashboardItem1.Argument = Dimension5
        Me.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1"
        Measure4.DataMember = "numOcorrencia"
        Measure4.Name = "Número Ocorrências"
        Me.rangeFilterDashboardItem1.DataItemRepository.Clear
        Me.rangeFilterDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0")
        Me.rangeFilterDashboardItem1.DataItemRepository.Add(Measure4, "DataItem1")
        Me.rangeFilterDashboardItem1.DataMember = "IndustriaEnvaseEvento"
        Me.rangeFilterDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true
        Me.rangeFilterDashboardItem1.Name = "Range Filter 1"
        SimpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Area
        SimpleSeries2.AddDataItem("Value", Measure4)
        Me.rangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() {SimpleSeries2})
        Me.rangeFilterDashboardItem1.ShowCaption = false
        '
        'comboBoxDashboardItem1
        '
        Me.comboBoxDashboardItem1.ComponentName = "comboBoxDashboardItem1"
        Dimension6.DataMember = "calcData"
        Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
        Dimension6.Name = "Mês"
        Dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
        Me.comboBoxDashboardItem1.DataItemRepository.Clear
        Me.comboBoxDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem0")
        Me.comboBoxDashboardItem1.DataMember = "IndustriaEnvaseEvento"
        Me.comboBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.comboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
        Me.comboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true
        Me.comboBoxDashboardItem1.Name = "Combo Box 1"
        Me.comboBoxDashboardItem1.ShowAllValue = false
        Me.comboBoxDashboardItem1.ShowCaption = false
        '
        'dashboardSqlDataSource1
        '
        CalculatedField1.DataMember = "IndustriaEnvaseEvento"
        CalculatedField1.Expression = resources.GetString("CalculatedField1.Expression")
        CalculatedField1.Name = "calcSumSegundosHHMMSS"
        CalculatedField2.DataMember = "IndustriaEnvaseEvento"
        CalculatedField2.Expression = "ToDateTime([periodoINI])"
        CalculatedField2.Name = "calcData"
        Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1, CalculatedField2})
        Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
        Me.dashboardSqlDataSource1.ConnectionName = "localhost_s5taviacao_Connection"
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
        MsSqlConnectionParameters1.DatabaseName = "s5taviacao"
        MsSqlConnectionParameters1.Password = "Manager4ts"
        MsSqlConnectionParameters1.ServerName = "192.168.50.39"
        MsSqlConnectionParameters1.UserName = "4t"
        Me.dashboardSqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
        Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
        CustomSqlQuery1.MetaSerializable = Nothing
        CustomSqlQuery1.Name = "IndustriaEnvaseEvento"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
        '
        'dashCnIndustriaLeiteEventos
        '
        Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
        Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1, Me.chartDashboardItem1, Me.rangeFilterDashboardItem1, Me.comboBoxDashboardItem1})
        DashboardLayoutItem1.DashboardItem = Me.comboBoxDashboardItem1
        DashboardLayoutItem1.Weight = 10.079051383399209R
        DashboardLayoutItem2.DashboardItem = Me.gridDashboardItem1
        DashboardLayoutItem2.Weight = 26.284584980237153R
        DashboardLayoutItem3.DashboardItem = Me.chartDashboardItem1
        DashboardLayoutItem3.Weight = 49.604743083003953R
        DashboardLayoutItem4.DashboardItem = Me.rangeFilterDashboardItem1
        DashboardLayoutItem4.Weight = 14.031620553359684R
        DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3, DashboardLayoutItem4})
        DashboardLayoutGroup1.DashboardItem = Nothing
        DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
        Me.LayoutRoot = DashboardLayoutGroup1
        Me.Title.Text = "Overview Eventos Leite"
        CType(Dimension1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Measure1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Measure2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridDashboardItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Measure3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chartDashboardItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Measure4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.rangeFilterDashboardItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.comboBoxDashboardItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dashboardSqlDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

        Friend WithEvents gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents rangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem
        Friend WithEvents comboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace