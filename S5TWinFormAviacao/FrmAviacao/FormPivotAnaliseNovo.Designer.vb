<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPivotAnaliseNovo
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNomeLayout = New DevExpress.XtraEditors.TextEdit()
        Me.cmbPasta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.chkAnaliseCompartilhada = New DevExpress.XtraEditors.CheckEdit()
        Me.btnSalvar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtNomeLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnaliseCompartilhada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Nome:"
        '
        'txtNomeLayout
        '
        Me.txtNomeLayout.Location = New System.Drawing.Point(66, 22)
        Me.txtNomeLayout.Name = "txtNomeLayout"
        Me.txtNomeLayout.Size = New System.Drawing.Size(395, 20)
        Me.txtNomeLayout.TabIndex = 0
        '
        'cmbPasta
        '
        Me.cmbPasta.Location = New System.Drawing.Point(66, 48)
        Me.cmbPasta.Name = "cmbPasta"
        Me.cmbPasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPasta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pPastaNome", "Pasta")})
        Me.cmbPasta.Properties.DisplayMember = "pPastaNome"
        Me.cmbPasta.Properties.NullText = ""
        Me.cmbPasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbPasta.Properties.ValueMember = "pPastaNome"
        Me.cmbPasta.Size = New System.Drawing.Size(395, 20)
        Me.cmbPasta.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Pasta:"
        '
        'chkAnaliseCompartilhada
        '
        Me.chkAnaliseCompartilhada.Location = New System.Drawing.Point(66, 74)
        Me.chkAnaliseCompartilhada.Name = "chkAnaliseCompartilhada"
        Me.chkAnaliseCompartilhada.Properties.Caption = "Compartilhada"
        Me.chkAnaliseCompartilhada.Size = New System.Drawing.Size(94, 19)
        Me.chkAnaliseCompartilhada.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(386, 107)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar Análise"
        '
        'FormPivotAnaliseNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 138)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.chkAnaliseCompartilhada)
        Me.Controls.Add(Me.cmbPasta)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNomeLayout)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPivotAnaliseNovo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gravação do modelo de Análise"
        CType(Me.txtNomeLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnaliseCompartilhada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNomeLayout As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbPasta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAnaliseCompartilhada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnSalvar As DevExpress.XtraEditors.SimpleButton
End Class
