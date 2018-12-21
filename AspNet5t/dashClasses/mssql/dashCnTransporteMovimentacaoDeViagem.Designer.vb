Namespace Win_Dashboards
    Partial Public Class dashCnTransporteMovimentacaoDeViagem
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
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField2 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim AllColumns1 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnTransporteMovimentacaoDeViagem))
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.comboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.listBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'comboBoxDashboardItem1
            '
            Me.comboBoxDashboardItem1.ComponentName = "comboBoxDashboardItem1"
            Dimension1.DataMember = "pMOTORISTA_NOME"
            Me.comboBoxDashboardItem1.DataItemRepository.Clear()
            Me.comboBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.comboBoxDashboardItem1.DataMember = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            Me.comboBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.comboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.comboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.comboBoxDashboardItem1.Name = "Motorista"
            Me.comboBoxDashboardItem1.ShowCaption = True
            '
            'chartDashboardItem1
            '
            Dimension2.DataMember = "pSTATUS"
            Dimension2.Name = "Status"
            Dimension3.DataMember = "DataSaida"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension4.DataMember = "pLOCAL_LINHA_DESCRICAO"
            Dimension4.Name = "Local Linha"
            Dimension5.DataMember = "pMOTORISTA_NOME"
            Dimension5.Name = "Motorista"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2, Dimension3, Dimension4, Dimension5})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            Dimension6.DataMember = "pSTATUS"
            Dimension6.Name = "Status"
            Measure1.DataMember = "LocalLinhaDescricao"
            Measure1.Name = "Local Linha "
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem4")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem6")
            Me.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.chartDashboardItem1.DataMember = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem1.Name = " "
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.PointLabelOptions.Orientation = DevExpress.DashboardCommon.PointLabelOrientation.RotateRight
            SimpleSeries1.PointLabelOptions.OverlappingMode = DevExpress.DashboardCommon.PointLabelOverlappingMode.Reposition
            SimpleSeries1.PointLabelOptions.ShowForZeroValues = True
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
            Me.chartDashboardItem1.ShowCaption = True
            '
            'listBoxDashboardItem1
            '
            Me.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1"
            Dimension7.DataMember = "pLOCAL_LINHA_DESCRICAO"
            Me.listBoxDashboardItem1.DataItemRepository.Clear()
            Me.listBoxDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem0")
            Me.listBoxDashboardItem1.DataMember = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            Me.listBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.listBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7})
            Me.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.listBoxDashboardItem1.Name = "Local Linha"
            Me.listBoxDashboardItem1.ShowCaption = True
            '
            'dashboardSqlDataSource1
            '
            CalculatedField1.DataMember = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            CalculatedField1.Expression = "Iif([pSTATUS] = 'DISPONÍVEL', Now(), [pDATA_SAIDA])"
            CalculatedField1.Name = "DataSaida"
            CalculatedField2.DataMember = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            CalculatedField2.Expression = "Iif(IsNullOrEmpty([pLOCAL_LINHA_DESCRICAO]), 'a', [pLOCAL_LINHA_DESCRICAO])"
            CalculatedField2.Name = "LocalLinhaDescricao"
            Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1, CalculatedField2})
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "192.168.50.39_s5taviacao_Connection"
            MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters1.DatabaseName = "s5taviacao"
            MsSqlConnectionParameters1.ServerName = "192.168.50.39"
            Me.dashboardSqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            Table1.MetaSerializable = "30|30|125|540"
            Table1.Name = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            AllColumns1.Table = Table1
            SelectQuery1.Columns.Add(AllColumns1)
            SelectQuery1.Name = "vaviacaoviagemmovaviacaoviagemmovviewgrid"
            SelectQuery1.Tables.Add(Table1)
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'dashCnTransporteMovimentacaoDeViagem
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.comboBoxDashboardItem1, Me.chartDashboardItem1, Me.listBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.comboBoxDashboardItem1
            DashboardLayoutItem1.Weight = 10.079051383399209R
            DashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            DashboardLayoutItem2.Weight = 80.748663101604279R
            DashboardLayoutItem3.DashboardItem = Me.listBoxDashboardItem1
            DashboardLayoutItem3.Weight = 19.251336898395721R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 89.9209486166008R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutGroup2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents comboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents listBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem

#End Region
    End Class
End Namespace