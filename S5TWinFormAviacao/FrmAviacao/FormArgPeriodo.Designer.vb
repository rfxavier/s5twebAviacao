<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArgPeriodo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormArgPeriodo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.MskDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.CmdDesistir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MskDataFinal)
        Me.GroupBox1.Controls.Add(Me.MskDataInicial)
        Me.GroupBox1.Controls.Add(Me.CmdDesistir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmdImprimir)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 73)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = false
        '
        'MskDataFinal
        '
        Me.MskDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MskDataFinal.Location = New System.Drawing.Point(65, 40)
        Me.MskDataFinal.Name = "MskDataFinal"
        Me.MskDataFinal.Size = New System.Drawing.Size(95, 20)
        Me.MskDataFinal.TabIndex = 1
        Me.MskDataFinal.Value = New Date(2015, 6, 12, 0, 0, 0, 0)
        '
        'MskDataInicial
        '
        Me.MskDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MskDataInicial.Location = New System.Drawing.Point(65, 13)
        Me.MskDataInicial.Name = "MskDataInicial"
        Me.MskDataInicial.Size = New System.Drawing.Size(95, 20)
        Me.MskDataInicial.TabIndex = 0
        Me.MskDataInicial.Value = New Date(2015, 6, 12, 0, 0, 0, 0)
        '
        'CmdDesistir
        '
        Me.CmdDesistir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdDesistir.FlatAppearance.BorderSize = 0
        Me.CmdDesistir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.CmdDesistir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.CmdDesistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDesistir.Image = CType(resources.GetObject("CmdDesistir.Image"),System.Drawing.Image)
        Me.CmdDesistir.Location = New System.Drawing.Point(234, 9)
        Me.CmdDesistir.Name = "CmdDesistir"
        Me.CmdDesistir.Size = New System.Drawing.Size(56, 56)
        Me.CmdDesistir.TabIndex = 3
        Me.CmdDesistir.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Período:"
        '
        'CmdImprimir
        '
        Me.CmdImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdImprimir.FlatAppearance.BorderSize = 0
        Me.CmdImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.CmdImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.CmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"),System.Drawing.Image)
        Me.CmdImprimir.Location = New System.Drawing.Point(172, 9)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(56, 56)
        Me.CmdImprimir.TabIndex = 2
        Me.CmdImprimir.UseVisualStyleBackColor = true
        '
        'FormArgPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(304, 74)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormArgPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Período - Relatório"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MskDataInicial As DateTimePicker
    Friend WithEvents CmdDesistir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdImprimir As Button
    Friend WithEvents MskDataFinal As DateTimePicker
End Class
