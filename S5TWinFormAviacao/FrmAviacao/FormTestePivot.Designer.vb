<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTestePivot
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTestePivot))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLimparAnalise = New DevExpress.XtraEditors.SimpleButton()
        Me.lblNomeAnalise = New DevExpress.XtraEditors.LabelControl()
        Me.btnSair = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAbrir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalvar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.LinqServerModeSource2 = New DevExpress.Data.Linq.LinqServerModeSource()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinqServerModeSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLimparAnalise)
        Me.PanelControl1.Controls.Add(Me.lblNomeAnalise)
        Me.PanelControl1.Controls.Add(Me.btnSair)
        Me.PanelControl1.Controls.Add(Me.btnAbrir)
        Me.PanelControl1.Controls.Add(Me.btnSalvar)
        Me.PanelControl1.Controls.Add(Me.btnExcel)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1133, 46)
        Me.PanelControl1.TabIndex = 2
        '
        'btnLimparAnalise
        '
        Me.btnLimparAnalise.AutoSize = True
        Me.btnLimparAnalise.ImageOptions.Image = CType(resources.GetObject("btnLimparAnalise.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLimparAnalise.Location = New System.Drawing.Point(94, 3)
        Me.btnLimparAnalise.Name = "btnLimparAnalise"
        Me.btnLimparAnalise.Size = New System.Drawing.Size(40, 38)
        Me.btnLimparAnalise.TabIndex = 7
        Me.btnLimparAnalise.ToolTip = "Limpar Análise"
        Me.btnLimparAnalise.ToolTipTitle = "Limpar Análise"
        '
        'lblNomeAnalise
        '
        Me.lblNomeAnalise.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeAnalise.Appearance.Options.UseFont = True
        Me.lblNomeAnalise.Appearance.Options.UseTextOptions = True
        Me.lblNomeAnalise.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblNomeAnalise.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNomeAnalise.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblNomeAnalise.Location = New System.Drawing.Point(506, 2)
        Me.lblNomeAnalise.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.lblNomeAnalise.Name = "lblNomeAnalise"
        Me.lblNomeAnalise.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lblNomeAnalise.Size = New System.Drawing.Size(625, 42)
        Me.lblNomeAnalise.TabIndex = 6
        '
        'btnSair
        '
        Me.btnSair.AutoSize = True
        Me.btnSair.ImageOptions.Image = CType(resources.GetObject("btnSair.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(186, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(40, 38)
        Me.btnSair.TabIndex = 5
        Me.btnSair.ToolTip = "Sair"
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoSize = True
        Me.btnAbrir.ImageOptions.Image = CType(resources.GetObject("btnAbrir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAbrir.Location = New System.Drawing.Point(48, 4)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(40, 38)
        Me.btnAbrir.TabIndex = 4
        Me.btnAbrir.ToolTip = "Abrir"
        '
        'btnSalvar
        '
        Me.btnSalvar.AutoSize = True
        Me.btnSalvar.ImageOptions.Image = CType(resources.GetObject("btnSalvar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(2, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(40, 38)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.ToolTip = "Salvar"
        '
        'btnExcel
        '
        Me.btnExcel.AutoSize = True
        Me.btnExcel.ImageOptions.Image = CType(resources.GetObject("btnExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(140, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(40, 38)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.ToolTip = "Exportar Excel"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 46)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 466)
        Me.SplitterControl1.TabIndex = 4
        Me.SplitterControl1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PivotGridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1124, 462)
        Me.SplitContainer1.SplitterDistance = 304
        Me.SplitContainer1.TabIndex = 3
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.LinqServerModeSource2
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField3, Me.PivotGridField9, Me.PivotGridField10})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1124, 304)
        Me.PivotGridControl1.TabIndex = 2
        '
        'LinqServerModeSource2
        '
        Me.LinqServerModeSource2.DefaultSorting = "pPRODUTO ASC"
        Me.LinqServerModeSource2.ElementType = GetType(S5TWinFormAviacao.AviacaoVenda)
        Me.LinqServerModeSource2.KeyExpression = "pId"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 3
        Me.PivotGridField1.Caption = "ANO EMISSÃO"
        Me.PivotGridField1.FieldName = "pANO_EMISSAO"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 4
        Me.PivotGridField2.Caption = "MÊS EMISSÃO"
        Me.PivotGridField2.FieldName = "pMES_EMISSAO"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "DESC PRODUTO"
        Me.PivotGridField4.FieldName = "pDESCRICAO"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.AreaIndex = 7
        Me.PivotGridField5.Caption = "VALOR TOTAL NOTA"
        Me.PivotGridField5.CellFormat.FormatString = "N2"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "pVLR_TOTAL_NOTA"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.TotalCellFormat.FormatString = "n2"
        Me.PivotGridField5.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.ValueFormat.FormatString = "n2"
        Me.PivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField6
        '
        Me.PivotGridField6.AreaIndex = 5
        Me.PivotGridField6.Caption = "QTD EM CAIXA"
        Me.PivotGridField6.CellFormat.FormatString = "N2"
        Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.FieldName = "pQTD_EM_CAIXA"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.TotalCellFormat.FormatString = "N2"
        Me.PivotGridField6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.ValueFormat.FormatString = "n2"
        Me.PivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 6
        Me.PivotGridField7.Caption = "QTD UNITÁRIO"
        Me.PivotGridField7.CellFormat.FormatString = "N2"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.FieldName = "pQUANTIDADE"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.TotalCellFormat.FormatString = "N2"
        Me.PivotGridField7.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.ValueFormat.FormatString = "n2"
        Me.PivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 0
        Me.PivotGridField8.Caption = "CLIENTE"
        Me.PivotGridField8.FieldName = "pNOME_CLIENTE"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "GRUPO PRODUTO"
        Me.PivotGridField3.FieldName = "pGRUPO_PRODUTO"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 8
        Me.PivotGridField9.Caption = "PESO LIQ"
        Me.PivotGridField9.CellFormat.FormatString = "N2"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "pPESO_BRUTO"
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.TotalCellFormat.FormatString = "N2"
        Me.PivotGridField9.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.ValueFormat.FormatString = "N2"
        Me.PivotGridField9.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField10
        '
        Me.PivotGridField10.AreaIndex = 9
        Me.PivotGridField10.Caption = "PESO TOTAL"
        Me.PivotGridField10.CellFormat.FormatString = "N2"
        Me.PivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.FieldName = "pPESO_TOTAL"
        Me.PivotGridField10.Name = "PivotGridField10"
        Me.PivotGridField10.TotalCellFormat.FormatString = "N2"
        Me.PivotGridField10.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.ValueFormat.FormatString = "N2"
        Me.PivotGridField10.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'ChartControl1
        '
        Me.ChartControl1.CrosshairOptions.ShowArgumentLabels = True
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.PivotGridControl1
        XyDiagram1.AxisX.Label.TextPattern = "{A}"
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.TextPattern = "{V:n2}"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        SideBySideBarSeriesLabel1.TextPattern = "{S} ({V:n2})"
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.LegendName = "Default Legend"
        Me.ChartControl1.SeriesTemplate.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.ToolTipPointPattern = "{S} - {A} - {V:#.00}"
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.Size = New System.Drawing.Size(1124, 154)
        Me.ChartControl1.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Azure
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.SplitContainer1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(5, 46)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1128, 466)
        Me.PanelControl2.TabIndex = 6
        '
        'FormTestePivot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 512)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTestePivot"
        Me.Text = "PIVOT DADOS VENDAS (CUBO)"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinqServerModeSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LinqServerModeSource2 As DevExpress.Data.Linq.LinqServerModeSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNomeAnalise As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLimparAnalise As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
