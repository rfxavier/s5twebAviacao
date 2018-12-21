<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFracionamentoReimpressaoOrdem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFracionamentoReimpressaoOrdem))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVezFim = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVezIni = New DevExpress.XtraEditors.TextEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.txtVezFim.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtVezIni.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.BS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTitulo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(528, 65)
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
        Me.lblTitulo.Size = New System.Drawing.Size(524, 61)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ordem"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel2)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 65)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(528, 142)
        Me.PanelControl2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.txtVezFim)
        Me.Panel2.Controls.Add(Me.LabelControl3)
        Me.Panel2.Controls.Add(Me.txtVezIni)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 101)
        Me.Panel2.TabIndex = 47
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Location = New System.Drawing.Point(256, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "a"
        '
        'txtVezFim
        '
        Me.txtVezFim.Location = New System.Drawing.Point(275, 42)
        Me.txtVezFim.Name = "txtVezFim"
        Me.txtVezFim.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtVezFim.Properties.Appearance.Options.UseFont = true
        Me.txtVezFim.Properties.Appearance.Options.UseTextOptions = true
        Me.txtVezFim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVezFim.Properties.DisplayFormat.FormatString = "n0"
        Me.txtVezFim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVezFim.Properties.EditFormat.FormatString = "n0"
        Me.txtVezFim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVezFim.Size = New System.Drawing.Size(60, 26)
        Me.txtVezFim.TabIndex = 1
        Me.txtVezFim.ToolTip = "(F2 - Para pesquisar Ordens abertas)"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl3.Appearance.Options.UseFont = true
        Me.LabelControl3.Location = New System.Drawing.Point(148, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Vez:"
        '
        'txtVezIni
        '
        Me.txtVezIni.EditValue = "1"
        Me.txtVezIni.Location = New System.Drawing.Point(190, 42)
        Me.txtVezIni.Name = "txtVezIni"
        Me.txtVezIni.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtVezIni.Properties.Appearance.Options.UseFont = true
        Me.txtVezIni.Properties.Appearance.Options.UseTextOptions = true
        Me.txtVezIni.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVezIni.Properties.DisplayFormat.FormatString = "n0"
        Me.txtVezIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVezIni.Properties.EditFormat.FormatString = "n0"
        Me.txtVezIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVezIni.Size = New System.Drawing.Size(60, 26)
        Me.txtVezIni.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 37)
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
        Me.btnImprimir.Location = New System.Drawing.Point(408, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnImprimir.Size = New System.Drawing.Size(106, 25)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTip = "Salvar"
        '
        'BS
        '
        Me.BS.DataSource = GetType(S5T.FracionamentoMovViewGrid)
        '
        'FormFracionamentoReimpressaoOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 207)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = true
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormFracionamentoReimpressaoOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpressão de Etiquetas - Ordem"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.txtVezFim.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtVezIni.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        CType(Me.BS,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BS As BindingSource
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVezFim As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVezIni As DevExpress.XtraEditors.TextEdit
End Class
