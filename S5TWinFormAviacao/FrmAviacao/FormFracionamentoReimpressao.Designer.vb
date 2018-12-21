<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFracionamentoReimpressao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFracionamentoReimpressao))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridFracionamentoMov = New DevExpress.XtraGrid.GridControl()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridFracionamentoMovView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpDataMov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpPesoPesado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpVez = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        CType(Me.GridFracionamentoMov,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BS,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridFracionamentoMovView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTitulo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(674, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitulo.Appearance.Options.UseFont = true
        Me.lblTitulo.Appearance.Options.UseTextOptions = true
        Me.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lblTitulo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.lblTitulo.Location = New System.Drawing.Point(2, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(670, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Pesagens realizadas"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel2)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(674, 360)
        Me.PanelControl2.TabIndex = 2
        '
        'GridFracionamentoMov
        '
        Me.GridFracionamentoMov.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridFracionamentoMov.DataSource = Me.BS
        Me.GridFracionamentoMov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFracionamentoMov.Location = New System.Drawing.Point(0, 0)
        Me.GridFracionamentoMov.LookAndFeel.SkinName = "Seven Classic"
        Me.GridFracionamentoMov.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GridFracionamentoMov.MainView = Me.GridFracionamentoMovView
        Me.GridFracionamentoMov.Name = "GridFracionamentoMov"
        Me.GridFracionamentoMov.Size = New System.Drawing.Size(670, 323)
        Me.GridFracionamentoMov.TabIndex = 8
        Me.GridFracionamentoMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridFracionamentoMovView})
        '
        'BS
        '
        Me.BS.DataSource = GetType(S5T.FracionamentoMovViewGrid)
        '
        'GridFracionamentoMovView
        '
        Me.GridFracionamentoMovView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridFracionamentoMovView.Appearance.EvenRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridFracionamentoMovView.Appearance.FocusedRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridFracionamentoMovView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridFracionamentoMovView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridFracionamentoMovView.Appearance.GroupRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.GroupRow.Options.UseFont = true
        Me.GridFracionamentoMovView.Appearance.GroupRow.Options.UseForeColor = true
        Me.GridFracionamentoMovView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold)
        Me.GridFracionamentoMovView.Appearance.HeaderPanel.Options.UseFont = true
        Me.GridFracionamentoMovView.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridFracionamentoMovView.Appearance.HorzLine.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridFracionamentoMovView.Appearance.OddRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridFracionamentoMovView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12!)
        Me.GridFracionamentoMovView.Appearance.Row.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.Row.Options.UseFont = true
        Me.GridFracionamentoMovView.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridFracionamentoMovView.Appearance.SelectedRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridFracionamentoMovView.Appearance.TopNewRow.Options.UseBackColor = true
        Me.GridFracionamentoMovView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId, Me.colpDataMov, Me.colpLote, Me.colpPesoPesado, Me.colpVez})
        Me.GridFracionamentoMovView.GridControl = Me.GridFracionamentoMov
        Me.GridFracionamentoMovView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "pId", Nothing, "")})
        Me.GridFracionamentoMovView.Name = "GridFracionamentoMovView"
        Me.GridFracionamentoMovView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridFracionamentoMovView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridFracionamentoMovView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridFracionamentoMovView.OptionsBehavior.AutoExpandAllGroups = true
        Me.GridFracionamentoMovView.OptionsBehavior.Editable = false
        Me.GridFracionamentoMovView.OptionsBehavior.ReadOnly = true
        Me.GridFracionamentoMovView.OptionsCustomization.AllowColumnMoving = false
        Me.GridFracionamentoMovView.OptionsCustomization.AllowColumnResizing = false
        Me.GridFracionamentoMovView.OptionsCustomization.AllowQuickHideColumns = false
        Me.GridFracionamentoMovView.OptionsFind.FindNullPrompt = "Digite texto para pesquisar..."
        Me.GridFracionamentoMovView.OptionsView.EnableAppearanceEvenRow = true
        Me.GridFracionamentoMovView.OptionsView.EnableAppearanceOddRow = true
        Me.GridFracionamentoMovView.OptionsView.ShowAutoFilterRow = true
        Me.GridFracionamentoMovView.OptionsView.ShowFooter = true
        Me.GridFracionamentoMovView.OptionsView.ShowGroupPanel = false
        '
        'colpId
        '
        Me.colpId.FieldName = "pId"
        Me.colpId.Name = "colpId"
        Me.colpId.OptionsColumn.ShowInCustomizationForm = false
        Me.colpId.OptionsColumn.ShowInExpressionEditor = false
        '
        'colpDataMov
        '
        Me.colpDataMov.Caption = "Data"
        Me.colpDataMov.FieldName = "pDataMov"
        Me.colpDataMov.Name = "colpDataMov"
        Me.colpDataMov.Visible = true
        Me.colpDataMov.VisibleIndex = 0
        Me.colpDataMov.Width = 201
        '
        'colpLote
        '
        Me.colpLote.Caption = "Lote"
        Me.colpLote.FieldName = "pLote"
        Me.colpLote.Name = "colpLote"
        Me.colpLote.Visible = true
        Me.colpLote.VisibleIndex = 1
        Me.colpLote.Width = 233
        '
        'colpPesoPesado
        '
        Me.colpPesoPesado.Caption = "Peso"
        Me.colpPesoPesado.FieldName = "pPesoPesado"
        Me.colpPesoPesado.Name = "colpPesoPesado"
        Me.colpPesoPesado.Visible = true
        Me.colpPesoPesado.VisibleIndex = 2
        Me.colpPesoPesado.Width = 128
        '
        'colpVez
        '
        Me.colpVez.Caption = "Vez"
        Me.colpVez.FieldName = "pVez"
        Me.colpVez.Name = "colpVez"
        Me.colpVez.Visible = true
        Me.colpVez.VisibleIndex = 3
        Me.colpVez.Width = 90
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 325)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 33)
        Me.Panel1.TabIndex = 46
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Appearance.Options.UseBackColor = true
        Me.btnImprimir.Appearance.Options.UseBorderColor = true
        Me.btnImprimir.Appearance.Options.UseFont = true
        Me.btnImprimir.Appearance.Options.UseForeColor = true
        Me.btnImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"),System.Drawing.Image)
        Me.btnImprimir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnImprimir.Location = New System.Drawing.Point(556, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnImprimir.Size = New System.Drawing.Size(106, 25)
        Me.btnImprimir.TabIndex = 44
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTip = "Salvar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridFracionamentoMov)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 323)
        Me.Panel2.TabIndex = 47
        '
        'FormFracionamentoReimpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 398)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = true
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormFracionamentoReimpressao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpressão de Pesagens"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(false)
        CType(Me.GridFracionamentoMov,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BS,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridFracionamentoMovView,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BS As BindingSource
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridFracionamentoMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridFracionamentoMovView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpDataMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpPesoPesado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpVez As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
