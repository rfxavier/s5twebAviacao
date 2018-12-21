Namespace Win_Dashboards
    Partial Public Class dashCnProducaoProducaoIndicadores
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
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnProducaoProducaoIndicadores))
            Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim CustomSqlQuery3 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.gridDashboardItem2 = New DevExpress.DashboardCommon.GridDashboardItem()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartDashboardItem1
            '
            Dimension1.DataMember = "pDATA_EMISSAO"
            Dimension1.Name = "Ano"
            Dimension2.DataMember = "pDATA_EMISSAO"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension2.Name = "Mês"
            Dimension3.DataMember = "pDATA_EMISSAO"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Day
            Dimension3.Name = "Dia"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1, Dimension2, Dimension3})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            Measure1.DataMember = "pVLR_TOTAL_NOTA"
            Measure1.Name = "Valor Total"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem3")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.chartDashboardItem1.DataMember = "Query"
            Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.chartDashboardItem1.IsMasterFilterCrossDataSource = True
            Me.chartDashboardItem1.Legend.Visible = False
            Me.chartDashboardItem1.Name = "Faturamento"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "Valor Total"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem1.ShowCaption = True
            '
            'dashboardSqlDataSource1
            '
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "GIOVANA-LAPTOP\SQLEXPRESS_s5taviacao_Connection"
            MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters1.DatabaseName = "s5taviacao"
            MsSqlConnectionParameters1.ServerName = "GIOVANA-LAPTOP\SQLEXPRESS"
            Me.dashboardSqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            CustomSqlQuery2.Name = "Query_1"
            CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
            CustomSqlQuery3.Name = "Query_2"
            CustomSqlQuery3.Sql = resources.GetString("CustomSqlQuery3.Sql")
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2, CustomSqlQuery3})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'pieDashboardItem1
            '
            Dimension4.DataMember = "pESTADO"
            Dimension4.Name = "UF"
            Dimension4.TopNOptions.Enabled = True
            Measure2.DataMember = "pVLR_TOTAL_NOTA"
            Measure2.Name = "Valor Total"
            Dimension4.TopNOptions.Measure = Measure2
            Dimension4.TopNOptions.ShowOthers = True
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            Dimension5.DataMember = "pDATA_EMISSAO"
            Dimension5.Name = "Ano"
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1")
            Me.pieDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem2")
            Me.pieDashboardItem1.DataMember = "Query"
            Me.pieDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.pieDashboardItem1.IsMasterFilterCrossDataSource = True
            Me.pieDashboardItem1.Name = "Faturamento por UF"
            Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5})
            Me.pieDashboardItem1.ShowCaption = True
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'gridDashboardItem2
            '
            Dimension6.DataMember = "pDESCRICAO"
            Measure3.DataMember = "pVLR_TOTAL_NOTA"
            Dimension6.SortByMeasure = Measure3
            Dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension6.TopNOptions.Count = 30
            Dimension6.TopNOptions.Enabled = True
            Dimension6.TopNOptions.Measure = Measure3
            GridDimensionColumn1.Name = "Produto"
            GridDimensionColumn1.Weight = 122.93000815043374R
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension6)
            GridMeasureColumn1.Name = "Valor Total"
            GridMeasureColumn1.Weight = 55.128405716947078R
            GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn1.AddDataItem("Measure", Measure3)
            Measure4.DataMember = "pPESO_TOTAL"
            GridMeasureColumn2.Name = "Peso Total"
            GridMeasureColumn2.Weight = 47.524487687023345R
            GridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn2.AddDataItem("Measure", Measure4)
            Me.gridDashboardItem2.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridMeasureColumn1, GridMeasureColumn2})
            Me.gridDashboardItem2.ComponentName = "gridDashboardItem2"
            Me.gridDashboardItem2.DataItemRepository.Clear()
            Me.gridDashboardItem2.DataItemRepository.Add(Measure3, "DataItem1")
            Me.gridDashboardItem2.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.gridDashboardItem2.DataItemRepository.Add(Measure4, "DataItem0")
            Me.gridDashboardItem2.DataMember = "Query_2"
            Me.gridDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.gridDashboardItem2.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.AutoFitToContents
            Me.gridDashboardItem2.GridOptions.EnableBandedRows = True
            Me.gridDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem2.Name = "Top 30 Produtos Ano 2016"
            Me.gridDashboardItem2.ShowCaption = True
            '
            'dashCnProducaoProducaoIndicadores
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.chartDashboardItem1, Me.pieDashboardItem1, Me.gridDashboardItem2})
            DashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
            DashboardLayoutItem1.Weight = 50.098619329388562R
            DashboardLayoutItem2.DashboardItem = Me.pieDashboardItem1
            DashboardLayoutItem2.Weight = 49.901380670611438R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup2.Weight = 56.363636363636367R
            DashboardLayoutItem3.DashboardItem = Me.gridDashboardItem2
            DashboardLayoutItem3.Weight = 43.636363636363633R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.ImageUrl = "D:\Users\RENATO\Google Drive\Aviacao\LogoUAMpequeno.jpg"
            Me.Title.Text = "Indicadores de Vendas"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
        Friend WithEvents gridDashboardItem2 As DevExpress.DashboardCommon.GridDashboardItem

#End Region
    End Class
End Namespace