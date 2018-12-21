<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPivotAnalise
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
        Me.GridAnalises = New DevExpress.XtraGrid.GridControl()
        Me.BSPivotAnalise = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPesqView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpDescricao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpLayoutVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpPastaNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpFlgCompartilhada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpModeloAnaliseXml = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpModeloAnaliseByte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridAnalises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSPivotAnalise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPesqView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(674, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(670, 34)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Análises Salvas - Pivot"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridAnalises)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(674, 319)
        Me.PanelControl2.TabIndex = 2
        '
        'GridAnalises
        '
        Me.GridAnalises.DataSource = Me.BSPivotAnalise
        Me.GridAnalises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAnalises.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GridAnalises.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(7)})
        Me.GridAnalises.EmbeddedNavigator.Text = "teste"
        Me.GridAnalises.Location = New System.Drawing.Point(2, 2)
        Me.GridAnalises.MainView = Me.GridPesqView1
        Me.GridAnalises.Name = "GridAnalises"
        Me.GridAnalises.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridAnalises.Size = New System.Drawing.Size(670, 315)
        Me.GridAnalises.TabIndex = 213
        Me.GridAnalises.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPesqView1})
        '
        'BSPivotAnalise
        '
        Me.BSPivotAnalise.DataSource = GetType(S5T.AviacaoPivotAnaliseViewGrid)
        '
        'GridPesqView1
        '
        Me.GridPesqView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.GridPesqView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridPesqView1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridPesqView1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.GridPesqView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpId1, Me.colpDescricao, Me.colpLayoutVersion, Me.colpPastaNome, Me.colpFlgCompartilhada, Me.colpModeloAnaliseXml, Me.colpModeloAnaliseByte})
        Me.GridPesqView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridPesqView1.GridControl = Me.GridAnalises
        Me.GridPesqView1.GroupCount = 1
        Me.GridPesqView1.Name = "GridPesqView1"
        Me.GridPesqView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPesqView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridPesqView1.OptionsBehavior.Editable = False
        Me.GridPesqView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridPesqView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridPesqView1.OptionsFind.AllowFindPanel = False
        Me.GridPesqView1.OptionsFind.FindNullPrompt = "Digite o texto para procurar"
        Me.GridPesqView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridPesqView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridPesqView1.OptionsView.ShowAutoFilterRow = True
        Me.GridPesqView1.OptionsView.ShowFooter = True
        Me.GridPesqView1.OptionsView.ShowGroupPanel = False
        Me.GridPesqView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpPastaNome, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GridPesqView1.ViewCaption = "Análises Salvas - Pivot"
        '
        'colpId1
        '
        Me.colpId1.FieldName = "pId"
        Me.colpId1.Name = "colpId1"
        '
        'colpDescricao
        '
        Me.colpDescricao.Caption = "Nome da Análise"
        Me.colpDescricao.FieldName = "pDescricao"
        Me.colpDescricao.Name = "colpDescricao"
        Me.colpDescricao.Visible = True
        Me.colpDescricao.VisibleIndex = 0
        Me.colpDescricao.Width = 393
        '
        'colpLayoutVersion
        '
        Me.colpLayoutVersion.Caption = "Versão"
        Me.colpLayoutVersion.FieldName = "pLayoutVersion"
        Me.colpLayoutVersion.Name = "colpLayoutVersion"
        Me.colpLayoutVersion.Visible = True
        Me.colpLayoutVersion.VisibleIndex = 1
        Me.colpLayoutVersion.Width = 44
        '
        'colpPastaNome
        '
        Me.colpPastaNome.Caption = "Pasta"
        Me.colpPastaNome.FieldName = "pPastaNome"
        Me.colpPastaNome.Name = "colpPastaNome"
        Me.colpPastaNome.Visible = True
        Me.colpPastaNome.VisibleIndex = 2
        '
        'colpFlgCompartilhada
        '
        Me.colpFlgCompartilhada.Caption = "Compartilhada"
        Me.colpFlgCompartilhada.FieldName = "pFlgCompartilhada"
        Me.colpFlgCompartilhada.Name = "colpFlgCompartilhada"
        Me.colpFlgCompartilhada.Visible = True
        Me.colpFlgCompartilhada.VisibleIndex = 2
        Me.colpFlgCompartilhada.Width = 109
        '
        'colpModeloAnaliseXml
        '
        Me.colpModeloAnaliseXml.FieldName = "pModeloAnaliseXml"
        Me.colpModeloAnaliseXml.Name = "colpModeloAnaliseXml"
        '
        'colpModeloAnaliseByte
        '
        Me.colpModeloAnaliseByte.FieldName = "pModeloAnaliseByte"
        Me.colpModeloAnaliseByte.Name = "colpModeloAnaliseByte"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'FormPivotAnalise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 357)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPivotAnalise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restauração do Modelo de Análise"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridAnalises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSPivotAnalise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPesqView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridAnalises As DevExpress.XtraGrid.GridControl
    Friend WithEvents BSPivotAnalise As BindingSource
    Friend WithEvents GridPesqView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpLayoutVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpPastaNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpFlgCompartilhada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents colpModeloAnaliseXml As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpModeloAnaliseByte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
