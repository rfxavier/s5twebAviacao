<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWebCam
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CameraControl1 = New DevExpress.XtraEditors.Camera.CameraControl()
        Me.btnCapturar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSair = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Chocolate
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(320, 22)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "WEBCAM"
        '
        'CameraControl1
        '
        Me.CameraControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CameraControl1.Appearance.Options.UseBackColor = True
        Me.CameraControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CameraControl1.DeviceNotFoundString = "Não há dispositivo disponível"
        Me.CameraControl1.Location = New System.Drawing.Point(4, 30)
        Me.CameraControl1.Name = "CameraControl1"
        Me.CameraControl1.Size = New System.Drawing.Size(320, 240)
        Me.CameraControl1.TabIndex = 14
        Me.CameraControl1.Text = "CameraControl1"
        '
        'btnCapturar
        '
        Me.btnCapturar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCapturar.Location = New System.Drawing.Point(4, 272)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(235, 23)
        Me.btnCapturar.TabIndex = 16
        Me.btnCapturar.Text = "Capturar"
        '
        'btnSair
        '
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Location = New System.Drawing.Point(245, 272)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(79, 23)
        Me.btnSair.TabIndex = 17
        Me.btnSair.Text = "Sair"
        '
        'FormWebCam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCapturar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.CameraControl1)
        Me.Name = "FormWebCam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebCam"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CameraControl1 As DevExpress.XtraEditors.Camera.CameraControl
    Friend WithEvents btnCapturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSair As DevExpress.XtraEditors.SimpleButton
End Class
