Public Class repCnIndEnvaseOverviewSubPesoMedio
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

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents objectDsEnvasePesoMedio As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents repParIdTag As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.objectDsEnvasePesoMedio = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100!
        Me.TopMargin.HeightF = 34!
        Me.TopMargin.Name = "TopMargin"
        '
        'label18
        '
        Me.label18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label18.Dpi = 100!
        Me.label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 154.25!)
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label18.SizeF = New System.Drawing.SizeF(95.00009!, 23!)
        Me.label18.StylePriority.UseBorders = false
        Me.label18.StylePriority.UseFont = false
        Me.label18.StylePriority.UseTextAlignment = false
        Me.label18.Text = "balança 1"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'objectDsEnvasePesoMedio
        '
        Me.objectDsEnvasePesoMedio.DataMember = "GetEnvasePesoMedio"
        Me.objectDsEnvasePesoMedio.DataSource = GetType(AspNet5t.dsIndustria)
        Me.objectDsEnvasePesoMedio.Name = "objectDsEnvasePesoMedio"
        Parameter1.Name = "parIdTag"
        Parameter1.Type = GetType(DevExpress.DataAccess.Expression)
        Parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.repParIdTag]", GetType(String))
        Me.objectDsEnvasePesoMedio.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'label16
        '
        Me.label16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label16.Dpi = 100!
        Me.label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(190!, 154.25!)
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label16.SizeF = New System.Drawing.SizeF(95.00002!, 23!)
        Me.label16.StylePriority.UseBorders = false
        Me.label16.StylePriority.UseFont = false
        Me.label16.StylePriority.UseTextAlignment = false
        Me.label16.Text = "balança 1+2"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label1.Dpi = 100!
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.99998!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(95.00009!, 23!)
        Me.label1.StylePriority.UseBorders = false
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseTextAlignment = false
        Me.label1.Text = "balança 1"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell6
        '
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote200_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell6.Dpi = 100!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.Weight = 0.94999985613144255R
        '
        'label5
        '
        Me.label5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label5.Dpi = 100!
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(380!, 45.99998!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(95!, 23!)
        Me.label5.StylePriority.UseBorders = false
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.Text = "balança 2"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_aeb_peso_medio_pote500_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell14.Dpi = 100!
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.Weight = 0.94999970354357843R
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100!
        Me.BottomMargin.HeightF = 23!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'tableCell5
        '
        Me.tableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote200_balanca2", "{0:#,#0.00} g")})
        Me.tableCell5.Dpi = 100!
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.Weight = 0.94999985613144244R
        '
        'label17
        '
        Me.label17.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label17.Dpi = 100!
        Me.label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(94.99998!, 154.25!)
        Me.label17.Name = "label17"
        Me.label17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label17.SizeF = New System.Drawing.SizeF(95.00003!, 23!)
        Me.label17.StylePriority.UseBorders = false
        Me.label17.StylePriority.UseFont = false
        Me.label17.StylePriority.UseTextAlignment = false
        Me.label17.Text = "balança 2"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell1
        '
        Me.tableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote200_balanca1", "{0:#,#0.00} g")})
        Me.tableCell1.Dpi = 100!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.Weight = 0.94999985613144244R
        '
        'label12
        '
        Me.label12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label12.Dpi = 100!
        Me.label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 154.25!)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label12.SizeF = New System.Drawing.SizeF(94.99991!, 23!)
        Me.label12.StylePriority.UseBorders = false
        Me.label12.StylePriority.UseFont = false
        Me.label12.StylePriority.UseTextAlignment = false
        Me.label12.Text = "balança 1+2"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'table1
        '
        Me.table1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.table1.Dpi = 100!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.99997!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(665!, 25!)
        Me.table1.StylePriority.UseBorders = false
        Me.table1.StylePriority.UseFont = false
        Me.table1.StylePriority.UseTextAlignment = false
        Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label2.Dpi = 100!
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(94.99998!, 45.99998!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(95.00003!, 23!)
        Me.label2.StylePriority.UseBorders = false
        Me.label2.StylePriority.UseFont = false
        Me.label2.StylePriority.UseTextAlignment = false
        Me.label2.Text = "balança 2"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14})
        Me.tableRow2.Dpi = 100!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1R
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_aeb_peso_medio_pote200_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell7.Dpi = 100!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.Weight = 0.94999970354357843R
        '
        'tableCell12
        '
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote500_balanca2", "{0:#,#0.00} g")})
        Me.tableCell12.Dpi = 100!
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.Weight = 0.94999985613144244R
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20170713RX"
        Me.repParIdTag.Visible = false
        '
        'label14
        '
        Me.label14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label14.Dpi = 100!
        Me.label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(380!, 154.25!)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label14.SizeF = New System.Drawing.SizeF(95!, 23!)
        Me.label14.StylePriority.UseBorders = false
        Me.label14.StylePriority.UseFont = false
        Me.label14.StylePriority.UseTextAlignment = false
        Me.label14.Text = "balança 2"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label13
        '
        Me.label13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label13.Dpi = 100!
        Me.label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(285!, 154.25!)
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label13.SizeF = New System.Drawing.SizeF(95!, 23!)
        Me.label13.StylePriority.UseBorders = false
        Me.label13.StylePriority.UseFont = false
        Me.label13.StylePriority.UseTextAlignment = false
        Me.label13.Text = "balança 1"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label19
        '
        Me.label19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label19.Dpi = 100!
        Me.label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(569.9999!, 131.25!)
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label19.SizeF = New System.Drawing.SizeF(95.00012!, 23!)
        Me.label19.StylePriority.UseBorders = false
        Me.label19.StylePriority.UseFont = false
        Me.label19.StylePriority.UseTextAlignment = false
        Me.label19.Text = "ENVASE A+B"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7})
        Me.tableRow1.Dpi = 100!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1R
        '
        'tableCell11
        '
        Me.tableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote500_balanca1", "{0:#,#0.00} g")})
        Me.tableCell11.Dpi = 100!
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.Weight = 0.94999985613144244R
        '
        'tableCell8
        '
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote500_balanca1", "{0:#,#0.00} g")})
        Me.tableCell8.Dpi = 100!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.Weight = 0.94999985613144244R
        '
        'tableCell10
        '
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote500_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell10.Dpi = 100!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.Weight = 0.94999985613144267R
        '
        'label9
        '
        Me.label9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label9.Dpi = 100!
        Me.label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(285!, 23!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(284.9999!, 23!)
        Me.label9.StylePriority.UseBorders = false
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "ENVASE B"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell2
        '
        Me.tableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote200_balanca2", "{0:#,#0.00} g")})
        Me.tableCell2.Dpi = 100!
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.Weight = 0.94999985613144255R
        '
        'label11
        '
        Me.label11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label11.Dpi = 100!
        Me.label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.40667E-05!)
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label11.SizeF = New System.Drawing.SizeF(664.7916!, 23!)
        Me.label11.StylePriority.UseBorders = false
        Me.label11.StylePriority.UseFont = false
        Me.label11.StylePriority.UseTextAlignment = false
        Me.label11.Text = "POTE 200g"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label7.Dpi = 100!
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 45.99998!)
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(94.99991!, 23!)
        Me.label7.StylePriority.UseBorders = false
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "balança 1+2"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label8.Dpi = 100!
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(285!, 23!)
        Me.label8.StylePriority.UseBorders = false
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "ENVASE A"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell3
        '
        Me.tableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote200_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell3.Dpi = 100!
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.Weight = 0.94999985613144267R
        '
        'label15
        '
        Me.label15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label15.Dpi = 100!
        Me.label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(475!, 154.25!)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label15.SizeF = New System.Drawing.SizeF(94.99991!, 23!)
        Me.label15.StylePriority.UseBorders = false
        Me.label15.StylePriority.UseFont = false
        Me.label15.StylePriority.UseTextAlignment = false
        Me.label15.Text = "balança 1+2"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label6.Dpi = 100!
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(475!, 45.99998!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(94.99991!, 23!)
        Me.label6.StylePriority.UseBorders = false
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "balança 1+2"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote500_balanca1e2", "{0:#,#0.00} g")})
        Me.tableCell13.Dpi = 100!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.Weight = 0.94999985613144255R
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label12, Me.label13, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.label19, Me.label20, Me.label21, Me.table2, Me.label22, Me.label11, Me.table1, Me.label8, Me.label9, Me.label10, Me.label1, Me.label2, Me.label3, Me.label6, Me.label5, Me.label4, Me.label7})
        Me.Detail.Dpi = 100!
        Me.Detail.HeightF = 202.25!
        Me.Detail.Name = "Detail"
        '
        'label3
        '
        Me.label3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label3.Dpi = 100!
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(190!, 45.99998!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(95.00002!, 23!)
        Me.label3.StylePriority.UseBorders = false
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.Text = "balança 1+2"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label22
        '
        Me.label22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label22.Dpi = 100!
        Me.label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 108.25!)
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label22.SizeF = New System.Drawing.SizeF(664.7916!, 23!)
        Me.label22.StylePriority.UseBorders = false
        Me.label22.StylePriority.UseFont = false
        Me.label22.StylePriority.UseTextAlignment = false
        Me.label22.Text = "POTE 500g"
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell9
        '
        Me.tableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_peso_medio_pote500_balanca2", "{0:#,#0.00} g")})
        Me.tableCell9.Dpi = 100!
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.Weight = 0.94999985613144255R
        '
        'label4
        '
        Me.label4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label4.Dpi = 100!
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(285!, 45.99998!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(95!, 23!)
        Me.label4.StylePriority.UseBorders = false
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.Text = "balança 1"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label10.Dpi = 100!
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(569.9999!, 23!)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label10.SizeF = New System.Drawing.SizeF(95.00012!, 23!)
        Me.label10.StylePriority.UseBorders = false
        Me.label10.StylePriority.UseFont = false
        Me.label10.StylePriority.UseTextAlignment = false
        Me.label10.Text = "ENVASE A+B"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell4
        '
        Me.tableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_peso_medio_pote200_balanca1", "{0:#,#0.00} g")})
        Me.tableCell4.Dpi = 100!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.Weight = 0.94999985613144244R
        '
        'table2
        '
        Me.table2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.table2.Dpi = 100!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 177.25!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(665!, 25!)
        Me.table2.StylePriority.UseBorders = false
        Me.table2.StylePriority.UseFont = false
        Me.table2.StylePriority.UseTextAlignment = false
        Me.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label21
        '
        Me.label21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label21.Dpi = 100!
        Me.label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 131.25!)
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label21.SizeF = New System.Drawing.SizeF(285!, 23!)
        Me.label21.StylePriority.UseBorders = false
        Me.label21.StylePriority.UseFont = false
        Me.label21.StylePriority.UseTextAlignment = false
        Me.label21.Text = "ENVASE A"
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label20
        '
        Me.label20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label20.Dpi = 100!
        Me.label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(285!, 131.25!)
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label20.SizeF = New System.Drawing.SizeF(284.9999!, 23!)
        Me.label20.StylePriority.UseBorders = false
        Me.label20.StylePriority.UseFont = false
        Me.label20.StylePriority.UseTextAlignment = false
        Me.label20.Text = "ENVASE B"
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'repCnIndEnvaseOverviewSubPesoMedio
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsEnvasePesoMedio})
        Me.DataSource = Me.objectDsEnvasePesoMedio
        Me.Margins = New System.Drawing.Printing.Margins(55, 52, 34, 23)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.Version = "16.1"
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class