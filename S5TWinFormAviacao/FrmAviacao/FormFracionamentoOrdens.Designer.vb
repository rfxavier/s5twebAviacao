<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFracionamentoOrdens
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridOrdem = New DevExpress.XtraGrid.GridControl()
        Me.GridOrdemView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_FILIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_NUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_SEQUEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_PRODUTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_QUANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB1_DESC_PROD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colC2_EMISSAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BSPivotAnalise = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        CType(Me.GridOrdem,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridOrdemView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BSPivotAnalise,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(884, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Appearance.Options.UseTextOptions = true
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(880, 34)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Ordens Abertas"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridOrdem)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(884, 319)
        Me.PanelControl2.TabIndex = 2
        '
        'GridOrdem
        '
        Me.GridOrdem.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridOrdem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrdem.Location = New System.Drawing.Point(2, 2)
        Me.GridOrdem.LookAndFeel.SkinName = "Seven Classic"
        Me.GridOrdem.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GridOrdem.MainView = Me.GridOrdemView
        Me.GridOrdem.Name = "GridOrdem"
        Me.GridOrdem.Size = New System.Drawing.Size(880, 315)
        Me.GridOrdem.TabIndex = 8
        Me.GridOrdem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridOrdemView})
        '
        'GridOrdemView
        '
        Me.GridOrdemView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridOrdemView.Appearance.EvenRow.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridOrdemView.Appearance.FocusedRow.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridOrdemView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridOrdemView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridOrdemView.Appearance.GroupRow.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.GroupRow.Options.UseFont = true
        Me.GridOrdemView.Appearance.GroupRow.Options.UseForeColor = true
        Me.GridOrdemView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold)
        Me.GridOrdemView.Appearance.HeaderPanel.Options.UseFont = true
        Me.GridOrdemView.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.HorzLine.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.OddRow.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12!)
        Me.GridOrdemView.Appearance.Row.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.Row.Options.UseFont = true
        Me.GridOrdemView.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridOrdemView.Appearance.SelectedRow.Options.UseBackColor = true
        Me.GridOrdemView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.TopNewRow.Options.UseBackColor = true
        Me.GridOrdemView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId, Me.colC2_FILIAL, Me.colC2_NUM, Me.colC2_ITEM, Me.colC2_SEQUEN, Me.colC2_PRODUTO, Me.colC2_QUANT, Me.colB1_DESC_PROD, Me.colC2_EMISSAO})
        Me.GridOrdemView.GridControl = Me.GridOrdem
        Me.GridOrdemView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "pId", Nothing, "")})
        Me.GridOrdemView.Name = "GridOrdemView"
        Me.GridOrdemView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridOrdemView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridOrdemView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridOrdemView.OptionsBehavior.AutoExpandAllGroups = true
        Me.GridOrdemView.OptionsBehavior.Editable = false
        Me.GridOrdemView.OptionsBehavior.ReadOnly = true
        Me.GridOrdemView.OptionsCustomization.AllowColumnMoving = false
        Me.GridOrdemView.OptionsCustomization.AllowColumnResizing = false
        Me.GridOrdemView.OptionsCustomization.AllowQuickHideColumns = false
        Me.GridOrdemView.OptionsFind.FindNullPrompt = "Digite texto para pesquisar..."
        Me.GridOrdemView.OptionsView.EnableAppearanceEvenRow = true
        Me.GridOrdemView.OptionsView.EnableAppearanceOddRow = true
        Me.GridOrdemView.OptionsView.ShowAutoFilterRow = true
        Me.GridOrdemView.OptionsView.ShowFooter = true
        Me.GridOrdemView.OptionsView.ShowGroupPanel = false
        Me.GridOrdemView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colC2_EMISSAO, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colpId
        '
        Me.colpId.FieldName = "pId"
        Me.colpId.Name = "colpId"
        Me.colpId.OptionsColumn.ShowInCustomizationForm = false
        Me.colpId.OptionsColumn.ShowInExpressionEditor = false
        '
        'colC2_FILIAL
        '
        Me.colC2_FILIAL.Caption = "Filial"
        Me.colC2_FILIAL.FieldName = "C2_FILIAL"
        Me.colC2_FILIAL.Name = "colC2_FILIAL"
        Me.colC2_FILIAL.Width = 64
        '
        'colC2_NUM
        '
        Me.colC2_NUM.Caption = "Ordem"
        Me.colC2_NUM.FieldName = "C2_NUM"
        Me.colC2_NUM.Name = "colC2_NUM"
        Me.colC2_NUM.Visible = true
        Me.colC2_NUM.VisibleIndex = 0
        Me.colC2_NUM.Width = 140
        '
        'colC2_ITEM
        '
        Me.colC2_ITEM.Caption = "Item"
        Me.colC2_ITEM.FieldName = "C2_ITEM"
        Me.colC2_ITEM.Name = "colC2_ITEM"
        Me.colC2_ITEM.Visible = true
        Me.colC2_ITEM.VisibleIndex = 2
        Me.colC2_ITEM.Width = 62
        '
        'colC2_SEQUEN
        '
        Me.colC2_SEQUEN.Caption = "Seq"
        Me.colC2_SEQUEN.FieldName = "C2_SEQUEN"
        Me.colC2_SEQUEN.Name = "colC2_SEQUEN"
        Me.colC2_SEQUEN.Visible = true
        Me.colC2_SEQUEN.VisibleIndex = 3
        Me.colC2_SEQUEN.Width = 67
        '
        'colC2_PRODUTO
        '
        Me.colC2_PRODUTO.Caption = "Produto"
        Me.colC2_PRODUTO.FieldName = "C2_PRODUTO"
        Me.colC2_PRODUTO.Name = "colC2_PRODUTO"
        Me.colC2_PRODUTO.Visible = true
        Me.colC2_PRODUTO.VisibleIndex = 4
        Me.colC2_PRODUTO.Width = 98
        '
        'colC2_QUANT
        '
        Me.colC2_QUANT.Caption = "Qtd."
        Me.colC2_QUANT.FieldName = "C2_QUANT"
        Me.colC2_QUANT.Name = "colC2_QUANT"
        Me.colC2_QUANT.Visible = true
        Me.colC2_QUANT.VisibleIndex = 6
        Me.colC2_QUANT.Width = 106
        '
        'colB1_DESC_PROD
        '
        Me.colB1_DESC_PROD.Caption = "Descrição"
        Me.colB1_DESC_PROD.FieldName = "B1_DESC_PROD"
        Me.colB1_DESC_PROD.Name = "colB1_DESC_PROD"
        Me.colB1_DESC_PROD.Visible = true
        Me.colB1_DESC_PROD.VisibleIndex = 5
        Me.colB1_DESC_PROD.Width = 339
        '
        'colC2_EMISSAO
        '
        Me.colC2_EMISSAO.Caption = "Emissão"
        Me.colC2_EMISSAO.DisplayFormat.FormatString = "d"
        Me.colC2_EMISSAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colC2_EMISSAO.FieldName = "C2_EMISSAO"
        Me.colC2_EMISSAO.Name = "colC2_EMISSAO"
        Me.colC2_EMISSAO.Visible = true
        Me.colC2_EMISSAO.VisibleIndex = 1
        Me.colC2_EMISSAO.Width = 184
        '
        'BSPivotAnalise
        '
        Me.BSPivotAnalise.DataSource = GetType(S5T.AviacaoPivotAnaliseViewGrid)
        '
        'FormFracionamentoOrdens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 357)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = true
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormFracionamentoOrdens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordens abertas"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(false)
        CType(Me.GridOrdem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridOrdemView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BSPivotAnalise,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BSPivotAnalise As BindingSource
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridOrdem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridOrdemView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_FILIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_SEQUEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_PRODUTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_QUANT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB1_DESC_PROD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC2_EMISSAO As DevExpress.XtraGrid.Columns.GridColumn
End Class
