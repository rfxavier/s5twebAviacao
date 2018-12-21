<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFracionamentoLotes
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
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridOrdem = New DevExpress.XtraGrid.GridControl()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridOrdemView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB8_FILIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB8_LOTECTL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB8_DTVALID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB8_SALDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridOrdem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOrdemView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseTextOptions = True
        Me.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lblTitulo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.lblTitulo.Location = New System.Drawing.Point(2, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(670, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Lotes"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridOrdem)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(674, 319)
        Me.PanelControl2.TabIndex = 2
        '
        'GridOrdem
        '
        Me.GridOrdem.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridOrdem.DataSource = Me.BS
        Me.GridOrdem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrdem.Location = New System.Drawing.Point(2, 2)
        Me.GridOrdem.LookAndFeel.SkinName = "Seven Classic"
        Me.GridOrdem.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridOrdem.MainView = Me.GridOrdemView
        Me.GridOrdem.Name = "GridOrdem"
        Me.GridOrdem.Size = New System.Drawing.Size(670, 315)
        Me.GridOrdem.TabIndex = 8
        Me.GridOrdem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridOrdemView})
        '
        'BS
        '
        Me.BS.DataSource = GetType(S5T.LoteFracionamento)
        '
        'GridOrdemView
        '
        Me.GridOrdemView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridOrdemView.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridOrdemView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridOrdemView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridOrdemView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridOrdemView.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.GroupRow.Options.UseFont = True
        Me.GridOrdemView.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridOrdemView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridOrdemView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridOrdemView.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.OddRow.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridOrdemView.Appearance.Row.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.Row.Options.UseFont = True
        Me.GridOrdemView.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridOrdemView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridOrdemView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridOrdemView.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridOrdemView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId, Me.colB8_FILIAL, Me.colB8_LOTECTL, Me.colB8_DTVALID, Me.colB8_SALDO})
        Me.GridOrdemView.GridControl = Me.GridOrdem
        Me.GridOrdemView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "pId", Nothing, "")})
        Me.GridOrdemView.Name = "GridOrdemView"
        Me.GridOrdemView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridOrdemView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridOrdemView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridOrdemView.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridOrdemView.OptionsBehavior.Editable = False
        Me.GridOrdemView.OptionsBehavior.ReadOnly = True
        Me.GridOrdemView.OptionsCustomization.AllowColumnMoving = False
        Me.GridOrdemView.OptionsCustomization.AllowColumnResizing = False
        Me.GridOrdemView.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridOrdemView.OptionsFind.FindNullPrompt = "Digite texto para pesquisar..."
        Me.GridOrdemView.OptionsView.EnableAppearanceEvenRow = True
        Me.GridOrdemView.OptionsView.EnableAppearanceOddRow = True
        Me.GridOrdemView.OptionsView.ShowAutoFilterRow = True
        Me.GridOrdemView.OptionsView.ShowFooter = True
        Me.GridOrdemView.OptionsView.ShowGroupPanel = False
        '
        'colpId
        '
        Me.colpId.FieldName = "pId"
        Me.colpId.Name = "colpId"
        Me.colpId.OptionsColumn.ShowInCustomizationForm = False
        Me.colpId.OptionsColumn.ShowInExpressionEditor = False
        '
        'colB8_FILIAL
        '
        Me.colB8_FILIAL.Caption = "Filial"
        Me.colB8_FILIAL.FieldName = "B8_FILIAL"
        Me.colB8_FILIAL.Name = "colB8_FILIAL"
        Me.colB8_FILIAL.Visible = True
        Me.colB8_FILIAL.VisibleIndex = 0
        Me.colB8_FILIAL.Width = 96
        '
        'colB8_LOTECTL
        '
        Me.colB8_LOTECTL.Caption = "Lote"
        Me.colB8_LOTECTL.FieldName = "B8_LOTECTL"
        Me.colB8_LOTECTL.Name = "colB8_LOTECTL"
        Me.colB8_LOTECTL.Visible = True
        Me.colB8_LOTECTL.VisibleIndex = 1
        Me.colB8_LOTECTL.Width = 302
        '
        'colB8_DTVALID
        '
        Me.colB8_DTVALID.Caption = "Data Validade"
        Me.colB8_DTVALID.FieldName = "B8_DTVALID"
        Me.colB8_DTVALID.Name = "colB8_DTVALID"
        Me.colB8_DTVALID.Visible = True
        Me.colB8_DTVALID.VisibleIndex = 2
        Me.colB8_DTVALID.Width = 125
        '
        'colB8_SALDO
        '
        Me.colB8_SALDO.Caption = "Saldo"
        Me.colB8_SALDO.FieldName = "B8_SALDO"
        Me.colB8_SALDO.Name = "colB8_SALDO"
        Me.colB8_SALDO.Visible = True
        Me.colB8_SALDO.VisibleIndex = 3
        Me.colB8_SALDO.Width = 129
        '
        'FormFracionamentoLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 357)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFracionamentoLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordens abertas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridOrdem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOrdemView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BS As BindingSource
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridOrdem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridOrdemView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB8_FILIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB8_LOTECTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB8_DTVALID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB8_SALDO As DevExpress.XtraGrid.Columns.GridColumn
End Class
