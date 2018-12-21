Namespace Win_Dashboards
    Partial Public Class dashCnVendasVendasPorClienteProdutoAgrupMSSQL
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
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim TableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
            Dim TableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo5 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo6 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo7 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo8 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo9 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo10 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo11 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo12 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo13 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo14 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo15 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo16 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo17 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo18 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo19 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo20 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo21 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo22 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo23 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo24 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo25 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo26 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo27 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo28 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo29 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo30 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo31 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo32 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo33 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo34 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo35 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo36 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo37 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo38 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo39 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnVendasVendasPorClienteProdutoAgrupMSSQL))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn2 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn3 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn4 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn3 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn4 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.comboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.gridDashboardItem2 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.chartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'comboBoxDashboardItem1
            '
            Me.comboBoxDashboardItem1.ComponentName = "comboBoxDashboardItem1"
            Dimension1.DataMember = "pREGIAO"
            Dimension1.Name = "Região"
            Me.comboBoxDashboardItem1.DataItemRepository.Clear()
            Me.comboBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.comboBoxDashboardItem1.DataMember = "AviacaoVendas"
            Me.comboBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.comboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.comboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.comboBoxDashboardItem1.Name = "Região"
            Me.comboBoxDashboardItem1.ShowCaption = True
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
            TableQuery1.Name = "AviacaoVendas"
            TableInfo1.Name = "AviacaoVendasAgrup"
            ColumnInfo1.Name = "pCLIENTE"
            ColumnInfo2.Name = "pFILIAL"
            ColumnInfo3.Name = "pLOJA"
            ColumnInfo4.Name = "pNOME_CLIENTE"
            ColumnInfo5.Name = "pCIDADE_CLIENTE"
            ColumnInfo6.Name = "pCIDADE_CLIENTE_IBGE"
            ColumnInfo7.Name = "pESTADO"
            ColumnInfo8.Name = "pREGIAO"
            ColumnInfo9.Name = "pCODIGO_VENDEDOR"
            ColumnInfo10.Name = "pNOME_VENDEDOR"
            ColumnInfo11.Name = "pVALOR_COMISSAO"
            ColumnInfo12.Name = "pDATA_EMISSAO"
            ColumnInfo13.Name = "pTRIMESTRE"
            ColumnInfo14.Name = "pPRODUTO"
            ColumnInfo15.Name = "pGRUPO_PRODUTO"
            ColumnInfo16.Name = "pPESO_PRODUTO"
            ColumnInfo17.Name = "pQTD_P_CAIXA"
            ColumnInfo18.Name = "pQTD_EM_CAIXA"
            ColumnInfo19.Name = "pPESO_TOTAL"
            ColumnInfo20.Name = "pPESO_BRUTO"
            ColumnInfo21.Name = "pDESCRICAO"
            ColumnInfo22.Name = "pQUANTIDADE"
            ColumnInfo23.Name = "pPRECO_TABELA"
            ColumnInfo24.Name = "pVLR_TOTAL_PRODUTO"
            ColumnInfo25.Name = "pPRECO_DE_VENDA"
            ColumnInfo26.Name = "pVLR_DESCONTO"
            ColumnInfo27.Name = "pVLR_BASE_ICM"
            ColumnInfo28.Name = "pVLR_TOTAL_NOTA"
            ColumnInfo29.Name = "pVLR_SEM_ICMSST"
            ColumnInfo30.Name = "pVLR_ICM"
            ColumnInfo31.Name = "pVLR_COFINS"
            ColumnInfo32.Name = "pVLR_PIS"
            ColumnInfo33.Name = "pPRECO_FORA_IMPOSTO"
            ColumnInfo34.Name = "pPRECO_FORA_IMPOSTO_UNIT"
            ColumnInfo35.Name = "pIMPOSTO_TOTAL_NOTA"
            ColumnInfo36.Name = "pCFOP"
            ColumnInfo37.Name = "pDESCON_FINAN"
            ColumnInfo38.Name = "pCUSTO_PRODUTO"
            ColumnInfo39.Name = "pCUSTO_PROD_QTD"
            TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1, ColumnInfo2, ColumnInfo3, ColumnInfo4, ColumnInfo5, ColumnInfo6, ColumnInfo7, ColumnInfo8, ColumnInfo9, ColumnInfo10, ColumnInfo11, ColumnInfo12, ColumnInfo13, ColumnInfo14, ColumnInfo15, ColumnInfo16, ColumnInfo17, ColumnInfo18, ColumnInfo19, ColumnInfo20, ColumnInfo21, ColumnInfo22, ColumnInfo23, ColumnInfo24, ColumnInfo25, ColumnInfo26, ColumnInfo27, ColumnInfo28, ColumnInfo29, ColumnInfo30, ColumnInfo31, ColumnInfo32, ColumnInfo33, ColumnInfo34, ColumnInfo35, ColumnInfo36, ColumnInfo37, ColumnInfo38, ColumnInfo39})
            TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1})
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'gridDashboardItem1
            '
            Dimension2.DataMember = "pNOME_CLIENTE"
            Dimension2.Name = "Cliente"
            Measure1.DataMember = "pVLR_TOTAL_NOTA"
            Measure1.Name = "Valor Total"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension2.SortByMeasure = Measure1
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            GridDimensionColumn1.Name = "Cliente"
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension2)
            Dimension3.DataMember = "pDESCRICAO"
            Dimension3.Name = "Produto"
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            GridDimensionColumn2.Name = "Produto"
            GridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn2.AddDataItem("Dimension", Dimension3)
            GridMeasureColumn1.Name = "Valor Total"
            GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn1.AddDataItem("Measure", Measure1)
            Measure2.DataMember = "pPESO_TOTAL"
            Measure2.Name = "Peso Total"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn2.Name = "Peso Total"
            GridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn2.AddDataItem("Measure", Measure2)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridMeasureColumn1, GridMeasureColumn2})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem3")
            Me.gridDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem4")
            Me.gridDashboardItem1.DataMember = "AviacaoVendas"
            Me.gridDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.gridDashboardItem1.GridOptions.EnableBandedRows = True
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.gridDashboardItem1.Name = "Por Cliente / Produto"
            Me.gridDashboardItem1.ShowCaption = True
            '
            'gridDashboardItem2
            '
            Dimension4.DataMember = "pDATA_EMISSAO"
            Dimension4.Name = "Ano"
            GridDimensionColumn3.Name = "Ano"
            GridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn3.AddDataItem("Dimension", Dimension4)
            Dimension5.DataMember = "pDATA_EMISSAO"
            Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension5.Name = "Mês"
            GridDimensionColumn4.Name = "Mês"
            GridDimensionColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn4.AddDataItem("Dimension", Dimension5)
            Measure3.DataMember = "pVLR_TOTAL_NOTA"
            Measure3.Name = "Valor Total"
            GridMeasureColumn3.Name = "Valor Total"
            GridMeasureColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn3.AddDataItem("Measure", Measure3)
            Measure4.DataMember = "pPESO_TOTAL"
            Measure4.Name = "Peso Total"
            GridMeasureColumn4.Name = "Peso Total"
            GridMeasureColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn4.AddDataItem("Measure", Measure4)
            Me.gridDashboardItem2.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn3, GridDimensionColumn4, GridMeasureColumn3, GridMeasureColumn4})
            Me.gridDashboardItem2.ComponentName = "gridDashboardItem2"
            Me.gridDashboardItem2.DataItemRepository.Clear()
            Me.gridDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.gridDashboardItem2.DataItemRepository.Add(Measure3, "DataItem2")
            Me.gridDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem3")
            Me.gridDashboardItem2.DataItemRepository.Add(Measure4, "DataItem4")
            Me.gridDashboardItem2.DataMember = "AviacaoVendas"
            Me.gridDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.gridDashboardItem2.GridOptions.EnableBandedRows = True
            Me.gridDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem2.InteractivityOptions.IsDrillDownEnabled = True
            Me.gridDashboardItem2.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.gridDashboardItem2.Name = "Por Ano / Mês"
            Me.gridDashboardItem2.ShowCaption = True
            '
            'chartDashboardItem1
            '
            Dimension6.DataMember = "pDATA_EMISSAO"
            Dimension6.Name = "Ano"
            Dimension7.DataMember = "pDATA_EMISSAO"
            Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension7.Name = "Mês"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6, Dimension7})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            Measure5.DataMember = "pVLR_TOTAL_NOTA"
            Measure5.Name = "Valor Total (R$)"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem4")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem5")
            Me.chartDashboardItem1.DataItemRepository.Add(Measure5, "DataItem1")
            Me.chartDashboardItem1.DataMember = "AviacaoVendas"
            Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem1.Legend.Visible = False
            Me.chartDashboardItem1.Name = "Evolução Valor Total Ano / Mês"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "Valor Total (R$)"
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.AddDataItem("Value", Measure5)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem1.ShowCaption = True
            '
            'chartDashboardItem2
            '
            Dimension8.DataMember = "pDATA_EMISSAO"
            Dimension8.Name = "Ano"
            Dimension9.DataMember = "pDATA_EMISSAO"
            Dimension9.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension9.Name = "Mês"
            Me.chartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension8, Dimension9})
            Me.chartDashboardItem2.AxisX.TitleVisible = False
            Me.chartDashboardItem2.ComponentName = "chartDashboardItem2"
            Measure6.DataMember = "pPESO_TOTAL"
            Measure6.Name = "Peso Total (Kg)"
            Me.chartDashboardItem2.DataItemRepository.Clear()
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension8, "DataItem2")
            Me.chartDashboardItem2.DataItemRepository.Add(Dimension9, "DataItem3")
            Me.chartDashboardItem2.DataItemRepository.Add(Measure6, "DataItem0")
            Me.chartDashboardItem2.DataMember = "AviacaoVendas"
            Me.chartDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem2.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem2.Legend.Visible = False
            Me.chartDashboardItem2.Name = "Evolução Peso Total Ano / Mês"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.Name = "Peso Total (Kg)"
            SimpleSeries2.PointLabelOptions.ShowPointLabels = True
            SimpleSeries2.AddDataItem("Value", Measure6)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.chartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.chartDashboardItem2.ShowCaption = True
            '
            'dashCnVendasVendasPorClienteProdutoAgrupMSSQL
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1, Me.gridDashboardItem2, Me.chartDashboardItem1, Me.chartDashboardItem2, Me.comboBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.comboBoxDashboardItem1
            DashboardLayoutItem1.Weight = 9.82318271119843R
            DashboardLayoutItem2.DashboardItem = Me.gridDashboardItem1
            DashboardLayoutItem2.Weight = 63.236669784845652R
            DashboardLayoutItem3.DashboardItem = Me.gridDashboardItem2
            DashboardLayoutItem3.Weight = 36.763330215154348R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 46.168958742632611R
            DashboardLayoutItem4.DashboardItem = Me.chartDashboardItem1
            DashboardLayoutItem4.Weight = 49.953227315247894R
            DashboardLayoutItem5.DashboardItem = Me.chartDashboardItem2
            DashboardLayoutItem5.Weight = 50.046772684752106R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem4, DashboardLayoutItem5})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Weight = 44.007858546168961R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Vendas por Cliente"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents gridDashboardItem2 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents chartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents comboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace