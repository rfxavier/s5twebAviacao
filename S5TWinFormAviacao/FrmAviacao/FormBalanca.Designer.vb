<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBalanca
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBalanca))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalvar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIntervaloSalvarAutomatico = New System.Windows.Forms.TextBox()
        Me.ChkStatus = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPortasCOM = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.TextBox()
        Me.label666 = New System.Windows.Forms.Label()
        Me.cmbStopBits = New System.Windows.Forms.ComboBox()
        Me.cmbParidade = New System.Windows.Forms.ComboBox()
        Me.txtBits = New System.Windows.Forms.TextBox()
        Me.txtVelocidade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumeroEtiquetas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 328)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SimpleButton1)
        Me.TabPage2.Controls.Add(Me.btnSalvar)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONFIGURAÇÃO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(224, 245)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 48)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Fechar"
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageOptions.Image = CType(resources.GetObject("btnSalvar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(339, 245)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(109, 48)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNumeroEtiquetas)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIntervaloSalvarAutomatico)
        Me.GroupBox1.Controls.Add(Me.ChkStatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbPortasCOM)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtIntervalo)
        Me.GroupBox1.Controls.Add(Me.label666)
        Me.GroupBox1.Controls.Add(Me.cmbStopBits)
        Me.GroupBox1.Controls.Add(Me.cmbParidade)
        Me.GroupBox1.Controls.Add(Me.txtBits)
        Me.GroupBox1.Controls.Add(Me.txtVelocidade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "(Milesegundos)"
        '
        'txtIntervaloSalvarAutomatico
        '
        Me.txtIntervaloSalvarAutomatico.Location = New System.Drawing.Point(93, 176)
        Me.txtIntervaloSalvarAutomatico.Name = "txtIntervaloSalvarAutomatico"
        Me.txtIntervaloSalvarAutomatico.Size = New System.Drawing.Size(89, 21)
        Me.txtIntervaloSalvarAutomatico.TabIndex = 6
        '
        'ChkStatus
        '
        Me.ChkStatus.AutoSize = True
        Me.ChkStatus.Location = New System.Drawing.Point(333, 12)
        Me.ChkStatus.Name = "ChkStatus"
        Me.ChkStatus.Size = New System.Drawing.Size(63, 17)
        Me.ChkStatus.TabIndex = 6
        Me.ChkStatus.Text = "Ativada"
        Me.ChkStatus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Intervalo Salvar:"
        '
        'cmbPortasCOM
        '
        Me.cmbPortasCOM.FormattingEnabled = True
        Me.cmbPortasCOM.Location = New System.Drawing.Point(94, 13)
        Me.cmbPortasCOM.Name = "cmbPortasCOM"
        Me.cmbPortasCOM.Size = New System.Drawing.Size(89, 21)
        Me.cmbPortasCOM.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(199, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "(Milesegundos)"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(93, 146)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(89, 21)
        Me.txtIntervalo.TabIndex = 5
        '
        'label666
        '
        Me.label666.AutoSize = True
        Me.label666.Location = New System.Drawing.Point(6, 149)
        Me.label666.Name = "label666"
        Me.label666.Size = New System.Drawing.Size(76, 13)
        Me.label666.TabIndex = 14
        Me.label666.Text = "Intervalo Bal.:"
        '
        'cmbStopBits
        '
        Me.cmbStopBits.FormattingEnabled = True
        Me.cmbStopBits.Location = New System.Drawing.Point(93, 118)
        Me.cmbStopBits.Name = "cmbStopBits"
        Me.cmbStopBits.Size = New System.Drawing.Size(89, 21)
        Me.cmbStopBits.TabIndex = 4
        '
        'cmbParidade
        '
        Me.cmbParidade.FormattingEnabled = True
        Me.cmbParidade.Location = New System.Drawing.Point(93, 65)
        Me.cmbParidade.Name = "cmbParidade"
        Me.cmbParidade.Size = New System.Drawing.Size(89, 21)
        Me.cmbParidade.TabIndex = 2
        '
        'txtBits
        '
        Me.txtBits.Location = New System.Drawing.Point(93, 92)
        Me.txtBits.Name = "txtBits"
        Me.txtBits.Size = New System.Drawing.Size(89, 21)
        Me.txtBits.TabIndex = 3
        '
        'txtVelocidade
        '
        Me.txtVelocidade.Location = New System.Drawing.Point(93, 39)
        Me.txtVelocidade.Name = "txtVelocidade"
        Me.txtVelocidade.Size = New System.Drawing.Size(89, 21)
        Me.txtVelocidade.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stop Bits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bits:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Paridade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Velocidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome da Porta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(199, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Intervalo de Kits para impressão de Etiquetas"
        '
        'txtNumeroEtiquetas
        '
        Me.txtNumeroEtiquetas.Location = New System.Drawing.Point(93, 203)
        Me.txtNumeroEtiquetas.Name = "txtNumeroEtiquetas"
        Me.txtNumeroEtiquetas.Size = New System.Drawing.Size(89, 21)
        Me.txtNumeroEtiquetas.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Inter. Etiquetas:"
        '
        'FormBalanca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBalanca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração da Balança"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVelocidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBits As System.Windows.Forms.TextBox
    Friend WithEvents cmbStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbParidade As System.Windows.Forms.ComboBox
    Friend WithEvents txtIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents label666 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents cmbPortasCOM As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkStatus As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIntervaloSalvarAutomatico As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumeroEtiquetas As TextBox
    Friend WithEvents Label10 As Label
End Class
