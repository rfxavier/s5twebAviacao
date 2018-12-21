<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadParametros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadParametros))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Excluir = New System.Windows.Forms.ToolStripButton()
        Me.Salvar = New System.Windows.Forms.ToolStripButton()
        Me.Desistir = New System.Windows.Forms.ToolStripButton()
        Me.Sair = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GridPesqDX = New DevExpress.XtraGrid.GridControl()
        Me.LinqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
        Me.GridPesqDXView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtProdutoFinal = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Datasource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMultiplasEtiquetas = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        CType(Me.GridPesqDX,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LinqServerModeSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridPesqDXView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        CType(Me.txtProdutoFinal.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Datasource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMultiplasEtiquetas.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Excluir, Me.Salvar, Me.Desistir, Me.Sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 59)
        Me.ToolStrip1.Stretch = true
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Excluir
        '
        Me.Excluir.AutoSize = false
        Me.Excluir.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"),System.Drawing.Image)
        Me.Excluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(56, 56)
        Me.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Salvar
        '
        Me.Salvar.AutoSize = false
        Me.Salvar.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Salvar.Image = CType(resources.GetObject("Salvar.Image"),System.Drawing.Image)
        Me.Salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(56, 56)
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Desistir
        '
        Me.Desistir.AutoSize = false
        Me.Desistir.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Desistir.Image = CType(resources.GetObject("Desistir.Image"),System.Drawing.Image)
        Me.Desistir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Desistir.Name = "Desistir"
        Me.Desistir.Size = New System.Drawing.Size(56, 56)
        Me.Desistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Desistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Sair
        '
        Me.Sair.AutoSize = false
        Me.Sair.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Sair.Image = CType(resources.GetObject("Sair.Image"),System.Drawing.Image)
        Me.Sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(56, 56)
        Me.Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(989, 579)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GridPesqDX)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(981, 553)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PESQUISAS"
        '
        'GridPesqDX
        '
        Me.GridPesqDX.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPesqDX.DataSource = Me.LinqServerModeSource1
        Me.GridPesqDX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPesqDX.Location = New System.Drawing.Point(3, 3)
        Me.GridPesqDX.LookAndFeel.SkinName = "Seven Classic"
        Me.GridPesqDX.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GridPesqDX.MainView = Me.GridPesqDXView1
        Me.GridPesqDX.Name = "GridPesqDX"
        Me.GridPesqDX.Size = New System.Drawing.Size(975, 547)
        Me.GridPesqDX.TabIndex = 6
        Me.GridPesqDX.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPesqDXView1})
        '
        'LinqServerModeSource1
        '
        Me.LinqServerModeSource1.ElementType = GetType(S5T.ParametrosFracionamentoCollection)
        Me.LinqServerModeSource1.KeyExpression = "[pId]"
        '
        'GridPesqDXView1
        '
        Me.GridPesqDXView1.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridPesqDXView1.Appearance.EvenRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridPesqDXView1.Appearance.FocusedRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridPesqDXView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridPesqDXView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseFont = true
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseForeColor = true
        Me.GridPesqDXView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.HorzLine.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.OddRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.Row.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridPesqDXView1.Appearance.SelectedRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.TopNewRow.Options.UseBackColor = true
        Me.GridPesqDXView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId, Me.colpCodigoProduto})
        Me.GridPesqDXView1.GridControl = Me.GridPesqDX
        Me.GridPesqDXView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "pId", Nothing, "")})
        Me.GridPesqDXView1.Name = "GridPesqDXView1"
        Me.GridPesqDXView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPesqDXView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPesqDXView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridPesqDXView1.OptionsBehavior.AutoExpandAllGroups = true
        Me.GridPesqDXView1.OptionsBehavior.Editable = false
        Me.GridPesqDXView1.OptionsBehavior.ReadOnly = true
        Me.GridPesqDXView1.OptionsCustomization.AllowColumnMoving = false
        Me.GridPesqDXView1.OptionsCustomization.AllowColumnResizing = false
        Me.GridPesqDXView1.OptionsCustomization.AllowQuickHideColumns = false
        Me.GridPesqDXView1.OptionsFind.FindNullPrompt = "Digite texto para pesquisar..."
        Me.GridPesqDXView1.OptionsView.EnableAppearanceEvenRow = true
        Me.GridPesqDXView1.OptionsView.EnableAppearanceOddRow = true
        Me.GridPesqDXView1.OptionsView.ShowAutoFilterRow = true
        Me.GridPesqDXView1.OptionsView.ShowFooter = true
        Me.GridPesqDXView1.OptionsView.ShowGroupPanel = false
        '
        'colpId
        '
        Me.colpId.FieldName = "pId"
        Me.colpId.Name = "colpId"
        Me.colpId.OptionsColumn.ShowInCustomizationForm = false
        Me.colpId.OptionsColumn.ShowInExpressionEditor = false
        '
        'colpCodigoProduto
        '
        Me.colpCodigoProduto.Caption = "Código Produto - Kit"
        Me.colpCodigoProduto.FieldName = "pCodigoProduto"
        Me.colpCodigoProduto.Name = "colpCodigoProduto"
        Me.colpCodigoProduto.Visible = true
        Me.colpCodigoProduto.VisibleIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtMultiplasEtiquetas)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtProdutoFinal)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(981, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DADOS BÁSICOS"
        '
        'txtProdutoFinal
        '
        Me.txtProdutoFinal.Location = New System.Drawing.Point(126, 10)
        Me.txtProdutoFinal.Name = "txtProdutoFinal"
        Me.txtProdutoFinal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtProdutoFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtProdutoFinal.TabIndex = 0
        Me.txtProdutoFinal.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "Produto Final (Kit):"
        '
        'Datasource
        '
        Me.Datasource.DataSource = GetType(S5T.TaraFracionamentoView)
        '
        'txtMultiplasEtiquetas
        '
        Me.txtMultiplasEtiquetas.EditValue = "S"
        Me.txtMultiplasEtiquetas.Location = New System.Drawing.Point(126, 36)
        Me.txtMultiplasEtiquetas.Name = "txtMultiplasEtiquetas"
        Me.txtMultiplasEtiquetas.Properties.Appearance.Options.UseTextOptions = true
        Me.txtMultiplasEtiquetas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMultiplasEtiquetas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMultiplasEtiquetas.Size = New System.Drawing.Size(31, 20)
        Me.txtMultiplasEtiquetas.TabIndex = 220
        Me.txtMultiplasEtiquetas.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Múltiplas Etiquetas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(163, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 15)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Imprime múltiplas Etiquetas no fechamento da Ordem"
        '
        'FormCadParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(989, 638)
        Me.ControlBox = false
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = true
        Me.Name = "FormCadParametros"
        Me.Text = "CADASTRO DE TARA POR PRODUTO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        CType(Me.GridPesqDX,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LinqServerModeSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridPesqDXView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        CType(Me.txtProdutoFinal.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Datasource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMultiplasEtiquetas.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents Excluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Desistir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridPesqDX As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridPesqDXView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Datasource As System.Windows.Forms.BindingSource
    Friend WithEvents colpId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtProdutoFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LinqServerModeSource1 As DevExpress.Data.Linq.LinqServerModeSource
    Friend WithEvents colpCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMultiplasEtiquetas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
End Class
