Namespace Win_Dashboards
    Partial Public Class dashCnVendasComparativoClientesProduto
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
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnVendasComparativoClientesProduto))
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter3 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter4 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter5 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter6 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.chartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartDashboardItem2
            '
            Dimension1.DataMember = "pDATA_EMISSAO"
            Dimension1.DateTimeFormat.MonthFormat = DevExpress.DashboardCommon.MonthFormat.Full
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension1.Name = "Mês"
            Me.chartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.chartDashboardItem2.AxisX.TitleVisible = False
            Me.chartDashboardItem2.ComponentName = "chartDashboardItem2"
            Dimension2.DataMember = "pDATA_EMISSAO"
            Dimension2.Name = "Ano"
            Measure1.DataMember = "pQTD_EM_CAIXA"
            Measure1.Name = "Qtde Caixa/peça"
            Me.chartDashboardItem2.DataItemRepository.Clear()
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem4")
            Me.chartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem3")
            Me.chartDashboardItem2.DataMember = "Query"
            Me.chartDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem2.InteractivityOptions.TargetDimensions = DevExpress.DashboardCommon.TargetDimensions.Series
            Me.chartDashboardItem2.Name = "Quantidade"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.chartDashboardItem2.ShowCaption = True
            '
            'dashboardSqlDataSource1
            '
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "GIOVANA-LAPTOP\SQLEXPRESS_s5taviacao_Connection"
            MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters1.DatabaseName = "s5taviacao"
            MsSqlConnectionParameters1.ServerName = "192.168.50.39"
            Me.dashboardSqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            QueryParameter1.Name = "parCliente"
            QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashCliente]", GetType(String))
            QueryParameter2.Name = "parLojaIni"
            QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashLojaIni]", GetType(String))
            QueryParameter3.Name = "parLojaFin"
            QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashLojaFin]", GetType(String))
            QueryParameter4.Name = "parProduto"
            QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashProduto]", GetType(String))
            QueryParameter5.Name = "parMarca"
            QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashMarca]", GetType(String))
            QueryParameter6.Name = "parRegiao"
            QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.parDashRegiao]", GetType(String))
            CustomSqlQuery1.Parameters.Add(QueryParameter1)
            CustomSqlQuery1.Parameters.Add(QueryParameter2)
            CustomSqlQuery1.Parameters.Add(QueryParameter3)
            CustomSqlQuery1.Parameters.Add(QueryParameter4)
            CustomSqlQuery1.Parameters.Add(QueryParameter5)
            CustomSqlQuery1.Parameters.Add(QueryParameter6)
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'dashCnVendasComparativoClientesProduto
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.chartDashboardItem2})
            DashboardLayoutItem1.DashboardItem = Me.chartDashboardItem2
            DashboardLayoutItem1.Weight = 72.97592997811816R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "parDashCliente"
            DashboardParameter1.Type = GetType(String)
            DashboardParameter1.Value = "052399"
            DashboardParameter2.Name = "parDashLojaIni"
            DashboardParameter2.Type = GetType(String)
            DashboardParameter2.Value = "00"
            DashboardParameter3.Name = "parDashLojaFin"
            DashboardParameter3.Type = GetType(String)
            DashboardParameter3.Value = "ZZ"
            DashboardParameter4.Name = "parDashProduto"
            DashboardParameter4.Type = GetType(String)
            DashboardParameter4.Value = "0"
            DashboardParameter5.Name = "parDashMarca"
            DashboardParameter5.Type = GetType(String)
            DashboardParameter5.Value = "%"
            DashboardParameter6.Name = "parDashRegiao"
            DashboardParameter6.Type = GetType(String)
            DashboardParameter6.Value = "%"
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2, DashboardParameter3, DashboardParameter4, DashboardParameter5, DashboardParameter6})
            Me.Title.ImageUrl = "D:\Users\RENATO\Google Drive\Aviacao\LogoUAMpequeno.jpg"
            Me.Title.Text = "Comparativo Clientes"
            Me.Title.Visible = False
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents chartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource


#End Region
    End Class
End Namespace