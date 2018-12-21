<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
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
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.btnCapturar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAtualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbCadastroVisitante = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.cmbCamera = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalvarAlteracoes = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCaminhoSalvar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.cmbCadastroVisitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.cmbCamera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaminhoSalvar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(677, 359)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(677, 359)
        Me.TabPane1.TabIndex = 7
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Camera"
        Me.TabNavigationPage1.Controls.Add(Me.btnCapturar)
        Me.TabNavigationPage1.Controls.Add(Me.btnAtualizar)
        Me.TabNavigationPage1.Controls.Add(Me.cmbCadastroVisitante)
        Me.TabNavigationPage1.Controls.Add(Me.LabelControl1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(659, 314)
        '
        'btnCapturar
        '
        Me.btnCapturar.Location = New System.Drawing.Point(481, 4)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(88, 23)
        Me.btnCapturar.TabIndex = 1
        Me.btnCapturar.Text = "Capturar"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(575, 5)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar Foto"
        '
        'cmbCadastroVisitante
        '
        Me.cmbCadastroVisitante.Location = New System.Drawing.Point(63, 7)
        Me.cmbCadastroVisitante.Name = "cmbCadastroVisitante"
        Me.cmbCadastroVisitante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCadastroVisitante.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pNome", "Nome")})
        Me.cmbCadastroVisitante.Properties.DisplayMember = "pNome"
        Me.cmbCadastroVisitante.Properties.NullText = ""
        Me.cmbCadastroVisitante.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbCadastroVisitante.Properties.ValueMember = "pId"
        Me.cmbCadastroVisitante.Size = New System.Drawing.Size(412, 20)
        Me.cmbCadastroVisitante.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Cadastro:"
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Configuração"
        Me.TabNavigationPage2.Controls.Add(Me.cmbCamera)
        Me.TabNavigationPage2.Controls.Add(Me.LabelControl5)
        Me.TabNavigationPage2.Controls.Add(Me.btnSalvarAlteracoes)
        Me.TabNavigationPage2.Controls.Add(Me.txtCaminhoSalvar)
        Me.TabNavigationPage2.Controls.Add(Me.LabelControl2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(659, 314)
        '
        'cmbCamera
        '
        Me.cmbCamera.Location = New System.Drawing.Point(96, 34)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCamera.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbCamera.Size = New System.Drawing.Size(445, 20)
        Me.cmbCamera.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(42, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Camêra:"
        '
        'btnSalvarAlteracoes
        '
        Me.btnSalvarAlteracoes.Location = New System.Drawing.Point(466, 79)
        Me.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes"
        Me.btnSalvarAlteracoes.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarAlteracoes.TabIndex = 2
        Me.btnSalvarAlteracoes.Text = "Salvar"
        '
        'txtCaminhoSalvar
        '
        Me.txtCaminhoSalvar.Location = New System.Drawing.Point(96, 8)
        Me.txtCaminhoSalvar.Name = "txtCaminhoSalvar"
        Me.txtCaminhoSalvar.Size = New System.Drawing.Size(445, 20)
        Me.txtCaminhoSalvar.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Caminho Salvar:"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 359)
        Me.Controls.Add(Me.TabPane1)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de WebCam - 4T Sistemas"
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(Me.cmbCadastroVisitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        Me.TabNavigationPage2.PerformLayout()
        CType(Me.cmbCamera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaminhoSalvar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents btnCapturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAtualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCadastroVisitante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCaminhoSalvar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalvarAlteracoes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCamera As DevExpress.XtraEditors.ComboBoxEdit
End Class
