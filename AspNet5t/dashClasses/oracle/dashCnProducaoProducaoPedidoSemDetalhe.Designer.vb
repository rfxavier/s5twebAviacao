Namespace Win_Dashboards
    Partial Public Class dashCnProducaoProducaoPedidoSemDetalhe
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
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn3 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn4 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridItemFormatRule1 As DevExpress.DashboardCommon.GridItemFormatRule = New DevExpress.DashboardCommon.GridItemFormatRule()
            Dim FormatConditionExpression1 As DevExpress.DashboardCommon.FormatConditionExpression = New DevExpress.DashboardCommon.FormatConditionExpression()
            Dim AppearanceSettings1 As DevExpress.DashboardCommon.AppearanceSettings = New DevExpress.DashboardCommon.AppearanceSettings()
            Dim GridItemFormatRule2 As DevExpress.DashboardCommon.GridItemFormatRule = New DevExpress.DashboardCommon.GridItemFormatRule()
            Dim FormatConditionExpression2 As DevExpress.DashboardCommon.FormatConditionExpression = New DevExpress.DashboardCommon.FormatConditionExpression()
            Dim AppearanceSettings2 As DevExpress.DashboardCommon.AppearanceSettings = New DevExpress.DashboardCommon.AppearanceSettings()
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField2 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField3 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField4 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField5 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField6 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim OracleConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.OracleConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.OracleConnectionParameters()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashCnProducaoProducaoPedidoSemDetalhe))
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'gridDashboardItem1
            '
            Dimension1.DataMember = "C6_FILIAL"
            GridDimensionColumn1.Name = "Filial"
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension1)
            Dimension2.DataMember = "C6_DESCRI"
            GridDimensionColumn2.Name = "Produto"
            GridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn2.AddDataItem("Dimension", Dimension2)
            Measure1.DataMember = "QtdeEstoqueConv"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Precision = 0
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn1.Name = "Quantidade em Estoque"
            GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn1.AddDataItem("Measure", Measure1)
            Measure2.DataMember = "QtdePedidoConv"
            Measure2.Name = "Quantidade em Pedido Conv."
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Precision = 0
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn2.Name = "Quantidade em Pedido"
            GridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn2.AddDataItem("Measure", Measure2)
            Measure3.DataMember = "QtdeEmpenhadaConv"
            Measure3.Name = "Quantidade Empenhada"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Precision = 0
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn3.AddDataItem("Measure", Measure3)
            Measure4.DataMember = "Resultado"
            Measure4.Name = "Qtde Estoque - Qtde Pedido"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Precision = 0
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn4.AddDataItem("Measure", Measure4)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridMeasureColumn1, GridMeasureColumn2, GridMeasureColumn3, GridMeasureColumn4})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Measure5.DataMember = "B2_QATU"
            Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure5.NumericFormat.IncludeGroupSeparator = True
            Measure5.NumericFormat.Precision = 0
            Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
            Measure6.DataMember = "QTDVEN"
            Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure6.NumericFormat.IncludeGroupSeparator = True
            Measure6.NumericFormat.Precision = 0
            Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem5")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem6")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure4, "DataItem4")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure5, "DataItem3")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure6, "DataItem2")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure3, "DataItem7")
            Me.gridDashboardItem1.DataMember = "Query"
            Me.gridDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            FormatConditionExpression1.Expression = "[DataItem5] >= [DataItem6]"
            AppearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.Red
            FormatConditionExpression1.StyleSettings = AppearanceSettings1
            GridItemFormatRule1.Condition = FormatConditionExpression1
            GridItemFormatRule1.DataItem = Measure5
            GridItemFormatRule1.DataItemApplyTo = Measure4
            GridItemFormatRule1.Name = "FormatRule 1"
            FormatConditionExpression2.Expression = "[DataItem5] < [DataItem6]"
            AppearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.Green
            FormatConditionExpression2.StyleSettings = AppearanceSettings2
            GridItemFormatRule2.Condition = FormatConditionExpression2
            GridItemFormatRule2.DataItem = Measure5
            GridItemFormatRule2.DataItemApplyTo = Measure4
            GridItemFormatRule2.Name = "FormatRule 2"
            Me.gridDashboardItem1.FormatRules.AddRange(New DevExpress.DashboardCommon.GridItemFormatRule() {GridItemFormatRule1, GridItemFormatRule2})
            Me.gridDashboardItem1.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() {Measure5, Measure6})
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.gridDashboardItem1.Name = "Produção"
            Me.gridDashboardItem1.ShowCaption = True
            '
            'dashboardSqlDataSource1
            '
            CalculatedField1.DataMember = "Query"
            CalculatedField1.Expression = "Iif([B2_QATU] <= [QTDVEN], 'Falta Produzir', 'Sobra Produção')"
            CalculatedField1.Name = "Status"
            CalculatedField2.DataMember = "Query"
            CalculatedField2.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField2.Expression = "[QtdeEstoqueConv] - [QtdePedidoConv]"
            CalculatedField2.Name = "Resultado"
            CalculatedField3.DataMember = "Query"
            CalculatedField3.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField3.Expression = "Sum([QTDVEN]) / Avg([FATOR_CONV])"
            CalculatedField3.Name = "QtdePedidoConv"
            CalculatedField4.DataMember = "Query"
            CalculatedField4.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField4.Expression = "(Avg([B2_QATU]) - Avg([B2_QEMP])) / Avg([FATOR_CONV])"
            CalculatedField4.Name = "QtdeEstoqueConv"
            CalculatedField5.DataMember = "Query"
            CalculatedField5.Expression = "Concat('Pedido:', [C5_NUM], ' - Emissão: ', Substring([C5_EMISSAO], 6, 2), '/', S" & _
        "ubstring([C5_EMISSAO], 4, 2), '/', Substring([C5_EMISSAO], 0, 4))"
            CalculatedField5.Name = "PedidoDataCalc"
            CalculatedField6.DataMember = "Query"
            CalculatedField6.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField6.Expression = "Avg([B2_QEMP]) / Avg([FATOR_CONV])"
            CalculatedField6.Name = "QtdeEmpenhadaConv"
            Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1, CalculatedField2, CalculatedField3, CalculatedField4, CalculatedField5, CalculatedField6})
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "192.168.50.36/PROTHEUSPROD_PROTHEUSPROD_Connection"
            OracleConnectionParameters1.ServerName = "192.168.50.36/PROTHEUSPROD"
            Me.dashboardSqlDataSource1.ConnectionParameters = OracleConnectionParameters1
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'dashCnProducaoProducaoPedidoSemDetalhe
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            DashboardLayoutItem1.Weight = 44.57593688362919R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.ImageUrl = "D:\Users\RENATO\Google Drive\Aviacao\LogoUAMpequeno.jpg"
            Me.Title.Text = "Acompanhamento Produção x Pedidos"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource

#End Region
    End Class
End Namespace