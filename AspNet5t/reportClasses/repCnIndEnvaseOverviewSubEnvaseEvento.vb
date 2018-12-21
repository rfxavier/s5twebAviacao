Public Class repCnIndEnvaseOverviewSubEnvaseEvento
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents objectDsEnvaseEvento As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.objectDsEnvaseEvento = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.objectDsEnvaseEvento,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 35!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label6, Me.label5, Me.label4})
        Me.detailBand1.HeightF = 20!
        Me.detailBand1.Name = "detailBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.HeightF = 36!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label3, Me.label2, Me.label8, Me.label1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("hostname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 56.25005!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'label6
        '
        Me.label6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tempo_hhmmss")})
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(493.5418!, 0!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(146.4582!, 20!)
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label5
        '
        Me.label5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "numOcorrencia")})
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(344.375!, 0!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(132.9167!, 20!)
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label4
        '
        Me.label4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "description")})
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(332.9166!, 20!)
        Me.label4.StylePriority.UseFont = false
        Me.label4.Text = "label4"
        '
        'label3
        '
        Me.label3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(493.5418!, 33.25005!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(146.4583!, 23!)
        Me.label3.StylePriority.UseBorders = false
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.Text = "Duração (hh:mm:ss)"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(344.375!, 33.25005!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(132.9167!, 23!)
        Me.label2.StylePriority.UseBorders = false
        Me.label2.StylePriority.UseFont = false
        Me.label2.StylePriority.UseTextAlignment = false
        Me.label2.Text = "Nº Ocorrências"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 33.25005!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(332.9166!, 23!)
        Me.label8.StylePriority.UseBorders = false
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "Evento"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "hostname")})
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8.250046!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(209.375!, 23!)
        Me.label1.StylePriority.UseFont = false
        Me.label1.Text = "label1"
        '
        'objectDsEnvaseEvento
        '
        Me.objectDsEnvaseEvento.DataMember = "GetEnvaseEvento"
        Me.objectDsEnvaseEvento.DataSource = GetType(AspNet5t.dsIndustria)
        Me.objectDsEnvaseEvento.Name = "objectDsEnvaseEvento"
        Parameter1.Name = "parIdTag"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.repParIdTag]", GetType(String))
        Me.objectDsEnvaseEvento.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption3
        '
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3
        '
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(231,Byte),Integer), CType(CType(231,Byte),Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaptionBackground3
        '
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206,Byte),Integer), CType(CType(206,Byte),Integer), CType(CType(206,Byte),Integer))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2!
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20170823RX"
        Me.repParIdTag.Visible = false
        '
        'repCnIndEnvaseOverviewSubEnvaseEvento
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.GroupHeader1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsEnvaseEvento})
        Me.DataSource = Me.objectDsEnvaseEvento
        Me.Margins = New System.Drawing.Printing.Margins(58, 49, 35, 36)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.1"
        CType(Me.objectDsEnvaseEvento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class