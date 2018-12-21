<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTestePaleteMOv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTestePaleteMOv))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gridCadastro = New System.Windows.Forms.DataGridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtQuantArmazenada = New DevExpress.XtraEditors.TextEdit()
        Me.LblResumo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtQtdDefault = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmbalagem = New DevExpress.XtraEditors.TextEdit()
        Me.TxtQuant = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDescricao = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCodProduto = New DevExpress.XtraEditors.TextEdit()
        Me.TxtLote = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodbarra = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMultiplasEtiquetas = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdutoFinal = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDataMov = New DevExpress.XtraEditors.DateEdit()
        Me.Datasource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridPesqDX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPesqDXView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtQuantArmazenada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtQtdDefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmbalagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtQuant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodbarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMultiplasEtiquetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdutoFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataMov.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datasource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Excluir, Me.Salvar, Me.Desistir, Me.Sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 59)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Excluir
        '
        Me.Excluir.AutoSize = False
        Me.Excluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(56, 56)
        Me.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Salvar
        '
        Me.Salvar.AutoSize = False
        Me.Salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salvar.Image = CType(resources.GetObject("Salvar.Image"), System.Drawing.Image)
        Me.Salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(56, 56)
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Desistir
        '
        Me.Desistir.AutoSize = False
        Me.Desistir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desistir.Image = CType(resources.GetObject("Desistir.Image"), System.Drawing.Image)
        Me.Desistir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Desistir.Name = "Desistir"
        Me.Desistir.Size = New System.Drawing.Size(56, 56)
        Me.Desistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Desistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Sair
        '
        Me.Sair.AutoSize = False
        Me.Sair.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.Image = CType(resources.GetObject("Sair.Image"), System.Drawing.Image)
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
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GridPesqDX.LookAndFeel.UseDefaultLookAndFeel = False
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
        Me.GridPesqDXView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridPesqDXView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridPesqDXView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridPesqDXView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridPesqDXView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridPesqDXView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.Row.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridPesqDXView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridPesqDXView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridPesqDXView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId, Me.colpCodigoProduto})
        Me.GridPesqDXView1.GridControl = Me.GridPesqDX
        Me.GridPesqDXView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "pId", Nothing, "")})
        Me.GridPesqDXView1.Name = "GridPesqDXView1"
        Me.GridPesqDXView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPesqDXView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPesqDXView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridPesqDXView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridPesqDXView1.OptionsBehavior.Editable = False
        Me.GridPesqDXView1.OptionsBehavior.ReadOnly = True
        Me.GridPesqDXView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridPesqDXView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridPesqDXView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridPesqDXView1.OptionsFind.FindNullPrompt = "Digite texto para pesquisar..."
        Me.GridPesqDXView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridPesqDXView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridPesqDXView1.OptionsView.ShowAutoFilterRow = True
        Me.GridPesqDXView1.OptionsView.ShowFooter = True
        Me.GridPesqDXView1.OptionsView.ShowGroupPanel = False
        '
        'colpId
        '
        Me.colpId.FieldName = "pId"
        Me.colpId.Name = "colpId"
        Me.colpId.OptionsColumn.ShowInCustomizationForm = False
        Me.colpId.OptionsColumn.ShowInExpressionEditor = False
        '
        'colpCodigoProduto
        '
        Me.colpCodigoProduto.Caption = "Código Produto - Kit"
        Me.colpCodigoProduto.FieldName = "pCodigoProduto"
        Me.colpCodigoProduto.Name = "colpCodigoProduto"
        Me.colpCodigoProduto.Visible = True
        Me.colpCodigoProduto.VisibleIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.gridCadastro)
        Me.TabPage2.Controls.Add(Me.SimpleButton1)
        Me.TabPage2.Controls.Add(Me.TxtQuantArmazenada)
        Me.TabPage2.Controls.Add(Me.LblResumo)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtQtdDefault)
        Me.TabPage2.Controls.Add(Me.TxtEmbalagem)
        Me.TabPage2.Controls.Add(Me.TxtQuant)
        Me.TabPage2.Controls.Add(Me.TxtDescricao)
        Me.TabPage2.Controls.Add(Me.TxtCodProduto)
        Me.TabPage2.Controls.Add(Me.TxtLote)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtCodbarra)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TextEdit1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtMultiplasEtiquetas)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtProdutoFinal)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtDataMov)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(981, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MOVIMENTAÇÃO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(167, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 15)
        Me.Label15.TabIndex = 248
        Me.Label15.Text = "TOTAL DA PRODUÇÃO DO LOTE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(712, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 15)
        Me.Label14.TabIndex = 247
        Me.Label14.Text = "QTD POR PALETE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(615, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 246
        Me.Label13.Text = "EMBALAGEM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(321, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 15)
        Me.Label12.TabIndex = 245
        Me.Label12.Text = "DESC. PRODUTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(169, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 15)
        Me.Label11.TabIndex = 244
        Me.Label11.Text = "CÓD. PRODUTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(168, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 243
        Me.Label10.Text = "LOTE"
        '
        'gridCadastro
        '
        Me.gridCadastro.AllowUserToAddRows = False
        Me.gridCadastro.AllowUserToDeleteRows = False
        Me.gridCadastro.AllowUserToResizeColumns = False
        Me.gridCadastro.AllowUserToResizeRows = False
        Me.gridCadastro.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridCadastro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridCadastro.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridCadastro.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.gridCadastro.Location = New System.Drawing.Point(552, 288)
        Me.gridCadastro.Name = "gridCadastro"
        Me.gridCadastro.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridCadastro.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridCadastro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gridCadastro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridCadastro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkRed
        Me.gridCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCadastro.Size = New System.Drawing.Size(304, 139)
        Me.gridCadastro.TabIndex = 242
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(630, 436)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(68, 56)
        Me.SimpleButton1.TabIndex = 241
        Me.SimpleButton1.Text = "OK"
        '
        'TxtQuantArmazenada
        '
        Me.TxtQuantArmazenada.Location = New System.Drawing.Point(550, 438)
        Me.TxtQuantArmazenada.Name = "TxtQuantArmazenada"
        Me.TxtQuantArmazenada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantArmazenada.Properties.Appearance.Options.UseFont = True
        Me.TxtQuantArmazenada.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtQuantArmazenada.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtQuantArmazenada.Properties.AutoHeight = False
        Me.TxtQuantArmazenada.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtQuantArmazenada.Size = New System.Drawing.Size(74, 53)
        Me.TxtQuantArmazenada.TabIndex = 240
        Me.TxtQuantArmazenada.Tag = ""
        '
        'LblResumo
        '
        Me.LblResumo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblResumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResumo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblResumo.Location = New System.Drawing.Point(19, 291)
        Me.LblResumo.Name = "LblResumo"
        Me.LblResumo.Size = New System.Drawing.Size(456, 136)
        Me.LblResumo.TabIndex = 239
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(19, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(456, 30)
        Me.Label9.TabIndex = 238
        Me.Label9.Text = "PRODUÇÃO REF. AO CÓD. BARRA LIDO"
        '
        'TxtQtdDefault
        '
        Me.TxtQtdDefault.Location = New System.Drawing.Point(715, 151)
        Me.TxtQtdDefault.Name = "TxtQtdDefault"
        Me.TxtQtdDefault.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtdDefault.Properties.Appearance.Options.UseFont = True
        Me.TxtQtdDefault.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtQtdDefault.Size = New System.Drawing.Size(67, 22)
        Me.TxtQtdDefault.TabIndex = 237
        Me.TxtQtdDefault.Tag = ""
        '
        'TxtEmbalagem
        '
        Me.TxtEmbalagem.Location = New System.Drawing.Point(616, 151)
        Me.TxtEmbalagem.Name = "TxtEmbalagem"
        Me.TxtEmbalagem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmbalagem.Properties.Appearance.Options.UseFont = True
        Me.TxtEmbalagem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtEmbalagem.Size = New System.Drawing.Size(93, 22)
        Me.TxtEmbalagem.TabIndex = 235
        Me.TxtEmbalagem.Tag = ""
        '
        'TxtQuant
        '
        Me.TxtQuant.Location = New System.Drawing.Point(170, 191)
        Me.TxtQuant.Name = "TxtQuant"
        Me.TxtQuant.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuant.Properties.Appearance.Options.UseFont = True
        Me.TxtQuant.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtQuant.Size = New System.Drawing.Size(144, 22)
        Me.TxtQuant.TabIndex = 234
        Me.TxtQuant.Tag = ""
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(321, 151)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescricao.Properties.Appearance.Options.UseFont = True
        Me.TxtDescricao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtDescricao.Size = New System.Drawing.Size(289, 22)
        Me.TxtDescricao.TabIndex = 233
        Me.TxtDescricao.Tag = ""
        '
        'TxtCodProduto
        '
        Me.TxtCodProduto.Location = New System.Drawing.Point(171, 151)
        Me.TxtCodProduto.Name = "TxtCodProduto"
        Me.TxtCodProduto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProduto.Properties.Appearance.Options.UseFont = True
        Me.TxtCodProduto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtCodProduto.Size = New System.Drawing.Size(144, 22)
        Me.TxtCodProduto.TabIndex = 232
        Me.TxtCodProduto.Tag = ""
        '
        'TxtLote
        '
        Me.TxtLote.Location = New System.Drawing.Point(171, 111)
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLote.Properties.Appearance.Options.UseFont = True
        Me.TxtLote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtLote.Size = New System.Drawing.Size(144, 22)
        Me.TxtLote.TabIndex = 231
        Me.TxtLote.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(522, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 15)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "Data Movimentação:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(18, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 15)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Desc Código de barra:"
        '
        'TxtCodbarra
        '
        Me.TxtCodbarra.Location = New System.Drawing.Point(171, 59)
        Me.TxtCodbarra.Name = "TxtCodbarra"
        Me.TxtCodbarra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtCodbarra.Properties.MaxLength = 20
        Me.TxtCodbarra.Size = New System.Drawing.Size(348, 20)
        Me.TxtCodbarra.TabIndex = 227
        Me.TxtCodbarra.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(208, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "( E ) Entrada - ( S ) Saída"
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "E"
        Me.TextEdit1.Location = New System.Drawing.Point(171, 33)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Size = New System.Drawing.Size(31, 20)
        Me.TextEdit1.TabIndex = 224
        Me.TextEdit1.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 225
        Me.Label6.Text = "Tipo Movimentação:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(18, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 223
        Me.Label3.Text = "Data Movimentação:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(172, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 15)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Imprime múltiplas Etiquetas no fechamento da Ordem"
        Me.Label2.Visible = False
        '
        'txtMultiplasEtiquetas
        '
        Me.txtMultiplasEtiquetas.EditValue = "S"
        Me.txtMultiplasEtiquetas.Location = New System.Drawing.Point(135, 455)
        Me.txtMultiplasEtiquetas.Name = "txtMultiplasEtiquetas"
        Me.txtMultiplasEtiquetas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMultiplasEtiquetas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMultiplasEtiquetas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMultiplasEtiquetas.Size = New System.Drawing.Size(31, 20)
        Me.txtMultiplasEtiquetas.TabIndex = 220
        Me.txtMultiplasEtiquetas.Tag = ""
        Me.txtMultiplasEtiquetas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Múltiplas Etiquetas:"
        Me.Label1.Visible = False
        '
        'txtProdutoFinal
        '
        Me.txtProdutoFinal.Location = New System.Drawing.Point(135, 429)
        Me.txtProdutoFinal.Name = "txtProdutoFinal"
        Me.txtProdutoFinal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtProdutoFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtProdutoFinal.TabIndex = 0
        Me.txtProdutoFinal.Tag = ""
        Me.txtProdutoFinal.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "Produto Final (Kit):"
        Me.Label4.Visible = False
        '
        'TxtDataMov
        '
        Me.TxtDataMov.EditValue = Nothing
        Me.TxtDataMov.Location = New System.Drawing.Point(525, 59)
        Me.TxtDataMov.Name = "TxtDataMov"
        Me.TxtDataMov.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtDataMov.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDataMov.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDataMov.Properties.DisplayFormat.FormatString = ""
        Me.TxtDataMov.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtDataMov.Properties.EditFormat.FormatString = ""
        Me.TxtDataMov.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtDataMov.Properties.Mask.EditMask = ""
        Me.TxtDataMov.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtDataMov.Size = New System.Drawing.Size(191, 20)
        Me.TxtDataMov.TabIndex = 229
        Me.TxtDataMov.Tag = ""
        '
        'Datasource
        '
        Me.Datasource.DataSource = GetType(S5T.TaraFracionamentoView)
        '
        'FormTestePaleteMOv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(989, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FormTestePaleteMOv"
        Me.Text = "CONTROLE DE PRODUTO POR LOTE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridPesqDX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPesqDXView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.gridCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtQuantArmazenada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtQtdDefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmbalagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtQuant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodbarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMultiplasEtiquetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdutoFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataMov.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datasource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label5 As Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodbarra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDataMov As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtDescricao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodProduto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtLote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtQuant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEmbalagem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtQtdDefault As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents LblResumo As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtQuantArmazenada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridCadastro As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
End Class
