Public Class repCnIndEnvaseOverviewSubPesoMedioDifDesejado
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
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents label51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents line3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents label52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label68 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents label50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents objectDsEnvasePesoMedio As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents cfEnvase_a_media_g_un_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_b_media_g_un_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_e_b_media_g_un_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_difdesejado_balanca1kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_difdesejado_balanca1kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_media_g_un_pote200_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_b_media_g_un_pote200_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_e_b_media_g_un_pote200_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_media_g_un_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_b_media_g_un_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_e_b_media_g_un_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_contador_producao_pote200_e_pote500 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_b_contador_producao_pote200_e_pote500 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_e_b_contador_producao_pote200_e_pote500 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg As DevExpress.XtraReports.UI.CalculatedField
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.label51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.line3 = New DevExpress.XtraReports.UI.XRLine()
        Me.label52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.label59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label68 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.label43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.label50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.objectDsEnvasePesoMedio = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.cfEnvase_a_media_g_un_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_b_media_g_un_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_e_b_media_g_un_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_difdesejado_balanca1kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_difdesejado_balanca1kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_media_g_un_pote200_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_b_media_g_un_pote200_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_e_b_media_g_un_pote200_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_media_g_un_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_b_media_g_un_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_e_b_media_g_un_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_contador_producao_pote200_e_pote500 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_b_contador_producao_pote200_e_pote500 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_e_b_contador_producao_pote200_e_pote500 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg = New DevExpress.XtraReports.UI.CalculatedField()
        Me.repParIdTag = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.table3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 34!
        Me.TopMargin.Name = "TopMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label51, Me.line3, Me.label52, Me.label53, Me.label54, Me.label55, Me.label56, Me.label57, Me.label58, Me.table3, Me.label59, Me.label60, Me.label61, Me.label62, Me.label65, Me.label66, Me.label67, Me.label68, Me.label70, Me.label71, Me.label73, Me.label74, Me.label75, Me.label26, Me.label27, Me.label28, Me.label29, Me.label30, Me.label31, Me.label32, Me.label33, Me.label34, Me.label35, Me.label36, Me.label37, Me.label38, Me.label39, Me.label40, Me.label41, Me.label42, Me.table2, Me.label43, Me.label44, Me.label45, Me.label46, Me.label47, Me.label48, Me.label49, Me.line2, Me.label50, Me.label21, Me.line1, Me.label20, Me.label19, Me.label18, Me.label15, Me.label14, Me.label12, Me.label11, Me.table1, Me.label13, Me.label16, Me.label17, Me.label8, Me.label23, Me.label25, Me.label9, Me.label5, Me.label1, Me.label4, Me.label24, Me.label6, Me.label2, Me.label22, Me.label7, Me.label3, Me.label10})
        Me.Detail.HeightF = 531.9333!
        Me.Detail.Name = "Detail"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 23!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'label51
        '
        Me.label51.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label51.LocationFloat = New DevExpress.Utils.PointFloat(0.0001513769!, 378.0583!)
        Me.label51.Name = "label51"
        Me.label51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label51.SizeF = New System.Drawing.SizeF(664.2304!, 23!)
        Me.label51.StylePriority.UseBorders = false
        Me.label51.StylePriority.UseFont = false
        Me.label51.StylePriority.UseTextAlignment = false
        Me.label51.Text = "POTE 200g + POTE 500g"
        Me.label51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'line3
        '
        Me.line3.LineWidth = 2
        Me.line3.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 529.9333!)
        Me.line3.Name = "line3"
        Me.line3.SizeF = New System.Drawing.SizeF(664.8144!, 2.000015!)
        '
        'label52
        '
        Me.label52.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label52.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label52.LocationFloat = New DevExpress.Utils.PointFloat(284.1134!, 502.8917!)
        Me.label52.Name = "label52"
        Me.label52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label52.SizeF = New System.Drawing.SizeF(166.7422!, 27.04175!)
        Me.label52.StylePriority.UseBorders = false
        Me.label52.StylePriority.UseFont = false
        Me.label52.StylePriority.UseTextAlignment = false
        Me.label52.Text = "Média"
        Me.label52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label53
        '
        Me.label53.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label53.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label53.LocationFloat = New DevExpress.Utils.PointFloat(284.1134!, 472.85!)
        Me.label53.Name = "label53"
        Me.label53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label53.SizeF = New System.Drawing.SizeF(166.3504!, 30.04166!)
        Me.label53.StylePriority.UseBorders = false
        Me.label53.StylePriority.UseFont = false
        Me.label53.StylePriority.UseTextAlignment = false
        Me.label53.Text = "Contador Produção"
        Me.label53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label54
        '
        Me.label54.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label54.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label54.LocationFloat = New DevExpress.Utils.PointFloat(567.533!, 502.8916!)
        Me.label54.Name = "label54"
        Me.label54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label54.SizeF = New System.Drawing.SizeF(97.62036!, 27.04166!)
        Me.label54.StylePriority.UseBorders = false
        Me.label54.StylePriority.UseFont = false
        Me.label54.StylePriority.UseTextAlignment = false
        Me.label54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label55
        '
        Me.label55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label55.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label55.LocationFloat = New DevExpress.Utils.PointFloat(471.9416!, 502.8915!)
        Me.label55.Name = "label55"
        Me.label55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label55.SizeF = New System.Drawing.SizeF(93.79828!, 27.04169!)
        Me.label55.StylePriority.UseFont = false
        Me.label55.StylePriority.UseTextAlignment = false
        Me.label55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label56
        '
        Me.label56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label56.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label56.LocationFloat = New DevExpress.Utils.PointFloat(188.3575!, 502.8917!)
        Me.label56.Name = "label56"
        Me.label56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label56.SizeF = New System.Drawing.SizeF(94.83051!, 27.0417!)
        Me.label56.StylePriority.UseFont = false
        Me.label56.StylePriority.UseTextAlignment = false
        Me.label56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label57
        '
        Me.label57.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label57.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label57.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 502.8917!)
        Me.label57.Name = "label57"
        Me.label57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label57.SizeF = New System.Drawing.SizeF(163.125!, 27.04171!)
        Me.label57.StylePriority.UseBorders = false
        Me.label57.StylePriority.UseFont = false
        Me.label57.StylePriority.UseTextAlignment = false
        Me.label57.Text = "Média"
        Me.label57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label58
        '
        Me.label58.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label58.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label58.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 472.85!)
        Me.label58.Name = "label58"
        Me.label58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label58.SizeF = New System.Drawing.SizeF(163.125!, 30.04164!)
        Me.label58.StylePriority.UseBorders = false
        Me.label58.StylePriority.UseFont = false
        Me.label58.StylePriority.UseTextAlignment = false
        Me.label58.Text = "Contador Produção"
        Me.label58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'table3
        '
        Me.table3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.table3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 447.85!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(664.945!, 25!)
        Me.table3.StylePriority.UseBorders = false
        Me.table3.StylePriority.UseFont = false
        Me.table3.StylePriority.UseTextAlignment = false
        Me.table3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label59
        '
        Me.label59.BackColor = System.Drawing.Color.Transparent
        Me.label59.BorderColor = System.Drawing.Color.Black
        Me.label59.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label59.BorderWidth = 1!
        Me.label59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_contador_producao_pote200_e_pote500", "{0:#,#0} un")})
        Me.label59.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label59.ForeColor = System.Drawing.Color.Black
        Me.label59.LocationFloat = New DevExpress.Utils.PointFloat(188.3575!, 472.85!)
        Me.label59.Name = "label59"
        Me.label59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label59.SizeF = New System.Drawing.SizeF(95.03891!, 30.04163!)
        Me.label59.StylePriority.UseBackColor = false
        Me.label59.StylePriority.UseBorderColor = false
        Me.label59.StylePriority.UseBorderDashStyle = false
        Me.label59.StylePriority.UseBorders = false
        Me.label59.StylePriority.UseBorderWidth = false
        Me.label59.StylePriority.UseFont = false
        Me.label59.StylePriority.UseForeColor = false
        Me.label59.StylePriority.UsePadding = false
        Me.label59.StylePriority.UseTextAlignment = false
        Me.label59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label60
        '
        Me.label60.BackColor = System.Drawing.Color.Transparent
        Me.label60.BorderColor = System.Drawing.Color.Black
        Me.label60.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label60.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label60.BorderWidth = 1!
        Me.label60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_b_contador_producao_pote200_e_pote500", "{0:#,#0} un")})
        Me.label60.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label60.ForeColor = System.Drawing.Color.Black
        Me.label60.LocationFloat = New DevExpress.Utils.PointFloat(471.9416!, 472.85!)
        Me.label60.Name = "label60"
        Me.label60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label60.SizeF = New System.Drawing.SizeF(95.19235!, 30.04163!)
        Me.label60.StylePriority.UseBackColor = false
        Me.label60.StylePriority.UseBorderColor = false
        Me.label60.StylePriority.UseBorderDashStyle = false
        Me.label60.StylePriority.UseBorders = false
        Me.label60.StylePriority.UseBorderWidth = false
        Me.label60.StylePriority.UseFont = false
        Me.label60.StylePriority.UseForeColor = false
        Me.label60.StylePriority.UsePadding = false
        Me.label60.StylePriority.UseTextAlignment = false
        Me.label60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label61
        '
        Me.label61.BackColor = System.Drawing.Color.Transparent
        Me.label61.BorderColor = System.Drawing.Color.Black
        Me.label61.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label61.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label61.BorderWidth = 1!
        Me.label61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_e_b_contador_producao_pote200_e_pote500", "{0:#,#0} un")})
        Me.label61.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label61.ForeColor = System.Drawing.Color.Black
        Me.label61.LocationFloat = New DevExpress.Utils.PointFloat(567.134!, 472.8499!)
        Me.label61.Name = "label61"
        Me.label61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label61.SizeF = New System.Drawing.SizeF(97.75226!, 30.04169!)
        Me.label61.StylePriority.UseBackColor = false
        Me.label61.StylePriority.UseBorderColor = false
        Me.label61.StylePriority.UseBorderDashStyle = false
        Me.label61.StylePriority.UseBorders = false
        Me.label61.StylePriority.UseBorderWidth = false
        Me.label61.StylePriority.UseFont = false
        Me.label61.StylePriority.UseForeColor = false
        Me.label61.StylePriority.UsePadding = false
        Me.label61.StylePriority.UseTextAlignment = false
        Me.label61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label62
        '
        Me.label62.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label62.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label62.LocationFloat = New DevExpress.Utils.PointFloat(0!, 401.0583!)
        Me.label62.Name = "label62"
        Me.label62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label62.SizeF = New System.Drawing.SizeF(283.263!, 23!)
        Me.label62.StylePriority.UseBorders = false
        Me.label62.StylePriority.UseFont = false
        Me.label62.StylePriority.UseTextAlignment = false
        Me.label62.Text = "ENVASE A"
        Me.label62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label65
        '
        Me.label65.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label65.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label65.LocationFloat = New DevExpress.Utils.PointFloat(284.1136!, 401.0583!)
        Me.label65.Name = "label65"
        Me.label65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label65.SizeF = New System.Drawing.SizeF(283.0205!, 23!)
        Me.label65.StylePriority.UseBorders = false
        Me.label65.StylePriority.UseFont = false
        Me.label65.StylePriority.UseTextAlignment = false
        Me.label65.Text = "ENVASE B"
        Me.label65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label66
        '
        Me.label66.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label66.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label66.LocationFloat = New DevExpress.Utils.PointFloat(379.9471!, 424.0582!)
        Me.label66.Name = "label66"
        Me.label66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label66.SizeF = New System.Drawing.SizeF(93.4234!, 23.79193!)
        Me.label66.StylePriority.UseBorders = false
        Me.label66.StylePriority.UseFont = false
        Me.label66.StylePriority.UseTextAlignment = false
        Me.label66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label67
        '
        Me.label67.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label67.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label67.LocationFloat = New DevExpress.Utils.PointFloat(0!, 424.0582!)
        Me.label67.Name = "label67"
        Me.label67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label67.SizeF = New System.Drawing.SizeF(96.75388!, 23.79184!)
        Me.label67.StylePriority.UseBorders = false
        Me.label67.StylePriority.UseFont = false
        Me.label67.StylePriority.UseTextAlignment = false
        Me.label67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label68
        '
        Me.label68.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label68.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label68.LocationFloat = New DevExpress.Utils.PointFloat(284.3221!, 424.0583!)
        Me.label68.Name = "label68"
        Me.label68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label68.SizeF = New System.Drawing.SizeF(95.625!, 23.79181!)
        Me.label68.StylePriority.UseBorders = false
        Me.label68.StylePriority.UseFont = false
        Me.label68.StylePriority.UseTextAlignment = false
        Me.label68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label70
        '
        Me.label70.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label70.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label70.LocationFloat = New DevExpress.Utils.PointFloat(474.6207!, 424.0582!)
        Me.label70.Name = "label70"
        Me.label70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label70.SizeF = New System.Drawing.SizeF(92.74149!, 23.79193!)
        Me.label70.StylePriority.UseBorders = false
        Me.label70.StylePriority.UseFont = false
        Me.label70.StylePriority.UseTextAlignment = false
        Me.label70.Text = "balança 1+2"
        Me.label70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label71
        '
        Me.label71.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label71.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label71.LocationFloat = New DevExpress.Utils.PointFloat(96.75388!, 424.0582!)
        Me.label71.Name = "label71"
        Me.label71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label71.SizeF = New System.Drawing.SizeF(94.45731!, 23.79181!)
        Me.label71.StylePriority.UseBorders = false
        Me.label71.StylePriority.UseFont = false
        Me.label71.StylePriority.UseTextAlignment = false
        Me.label71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label73
        '
        Me.label73.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label73.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label73.LocationFloat = New DevExpress.Utils.PointFloat(567.6667!, 424.0583!)
        Me.label73.Name = "label73"
        Me.label73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label73.SizeF = New System.Drawing.SizeF(96.77203!, 23.79169!)
        Me.label73.StylePriority.UseBorders = false
        Me.label73.StylePriority.UseFont = false
        Me.label73.StylePriority.UseTextAlignment = false
        Me.label73.Text = "balança 1+2"
        Me.label73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label74
        '
        Me.label74.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label74.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label74.LocationFloat = New DevExpress.Utils.PointFloat(191.2112!, 424.0583!)
        Me.label74.Name = "label74"
        Me.label74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label74.SizeF = New System.Drawing.SizeF(92.39375!, 23.79181!)
        Me.label74.StylePriority.UseBorders = false
        Me.label74.StylePriority.UseFont = false
        Me.label74.StylePriority.UseTextAlignment = false
        Me.label74.Text = "balança 1+2"
        Me.label74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label75
        '
        Me.label75.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label75.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label75.LocationFloat = New DevExpress.Utils.PointFloat(567.8751!, 401.0583!)
        Me.label75.Name = "label75"
        Me.label75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label75.SizeF = New System.Drawing.SizeF(96.56372!, 23.00003!)
        Me.label75.StylePriority.UseBorders = false
        Me.label75.StylePriority.UseFont = false
        Me.label75.StylePriority.UseTextAlignment = false
        Me.label75.Text = "ENVASE A+B"
        Me.label75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label26
        '
        Me.label26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label26.LocationFloat = New DevExpress.Utils.PointFloat(567.6667!, 211.5417!)
        Me.label26.Name = "label26"
        Me.label26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label26.SizeF = New System.Drawing.SizeF(96.56372!, 46.12495!)
        Me.label26.StylePriority.UseBorders = false
        Me.label26.StylePriority.UseFont = false
        Me.label26.StylePriority.UseTextAlignment = false
        Me.label26.Text = "ENVASE A+B"
        Me.label26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label27
        '
        Me.label27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label27.LocationFloat = New DevExpress.Utils.PointFloat(189.322!, 257.6666!)
        Me.label27.Name = "label27"
        Me.label27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label27.SizeF = New System.Drawing.SizeF(95.00002!, 23.58344!)
        Me.label27.StylePriority.UseBorders = false
        Me.label27.StylePriority.UseFont = false
        Me.label27.StylePriority.UseTextAlignment = false
        Me.label27.Text = "balança 1+2"
        Me.label27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label28
        '
        Me.label28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label28.LocationFloat = New DevExpress.Utils.PointFloat(567.7592!, 257.6667!)
        Me.label28.Name = "label28"
        Me.label28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label28.SizeF = New System.Drawing.SizeF(96.47113!, 23.58344!)
        Me.label28.StylePriority.UseBorders = false
        Me.label28.StylePriority.UseFont = false
        Me.label28.StylePriority.UseTextAlignment = false
        Me.label28.Text = "balança 1+2"
        Me.label28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label29
        '
        Me.label29.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label29.LocationFloat = New DevExpress.Utils.PointFloat(0!, 234.5416!)
        Me.label29.Name = "label29"
        Me.label29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label29.SizeF = New System.Drawing.SizeF(163.125!, 23.12497!)
        Me.label29.StylePriority.UseBorders = false
        Me.label29.StylePriority.UseFont = false
        Me.label29.StylePriority.UseTextAlignment = false
        Me.label29.Text = "Peso Desejado:"
        Me.label29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label30
        '
        Me.label30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label30.LocationFloat = New DevExpress.Utils.PointFloat(95.05506!, 257.6666!)
        Me.label30.Name = "label30"
        Me.label30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label30.SizeF = New System.Drawing.SizeF(94.23306!, 23.5834!)
        Me.label30.StylePriority.UseBorders = false
        Me.label30.StylePriority.UseFont = false
        Me.label30.StylePriority.UseTextAlignment = false
        Me.label30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label31
        '
        Me.label31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label31.LocationFloat = New DevExpress.Utils.PointFloat(473.3705!, 257.6666!)
        Me.label31.Name = "label31"
        Me.label31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label31.SizeF = New System.Drawing.SizeF(93.99173!, 23.5835!)
        Me.label31.StylePriority.UseBorders = false
        Me.label31.StylePriority.UseFont = false
        Me.label31.StylePriority.UseTextAlignment = false
        Me.label31.Text = "balança 1+2"
        Me.label31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label32
        '
        Me.label32.BackColor = System.Drawing.Color.Transparent
        Me.label32.BorderColor = System.Drawing.Color.Black
        Me.label32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label32.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label32.BorderWidth = 1!
        Me.label32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_ult_peso_desejado_pote500", "{0:#,#0.00} g")})
        Me.label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label32.ForeColor = System.Drawing.Color.Black
        Me.label32.LocationFloat = New DevExpress.Utils.PointFloat(459.1361!, 234.5416!)
        Me.label32.Name = "label32"
        Me.label32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label32.SizeF = New System.Drawing.SizeF(108.5305!, 23.12497!)
        Me.label32.StylePriority.UseBackColor = false
        Me.label32.StylePriority.UseBorderColor = false
        Me.label32.StylePriority.UseBorderDashStyle = false
        Me.label32.StylePriority.UseBorders = false
        Me.label32.StylePriority.UseBorderWidth = false
        Me.label32.StylePriority.UseFont = false
        Me.label32.StylePriority.UseForeColor = false
        Me.label32.StylePriority.UsePadding = false
        Me.label32.StylePriority.UseTextAlignment = false
        Me.label32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label33
        '
        Me.label33.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label33.LocationFloat = New DevExpress.Utils.PointFloat(284.3221!, 257.6667!)
        Me.label33.Name = "label33"
        Me.label33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label33.SizeF = New System.Drawing.SizeF(95!, 23.5834!)
        Me.label33.StylePriority.UseBorders = false
        Me.label33.StylePriority.UseFont = false
        Me.label33.StylePriority.UseTextAlignment = false
        Me.label33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label34
        '
        Me.label34.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label34.LocationFloat = New DevExpress.Utils.PointFloat(0!, 257.6666!)
        Me.label34.Name = "label34"
        Me.label34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label34.SizeF = New System.Drawing.SizeF(94.81277!, 23.58337!)
        Me.label34.StylePriority.UseBorders = false
        Me.label34.StylePriority.UseFont = false
        Me.label34.StylePriority.UseTextAlignment = false
        Me.label34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label35
        '
        Me.label35.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label35.LocationFloat = New DevExpress.Utils.PointFloat(379.322!, 257.6666!)
        Me.label35.Name = "label35"
        Me.label35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label35.SizeF = New System.Drawing.SizeF(94.04849!, 23.58347!)
        Me.label35.StylePriority.UseBorders = false
        Me.label35.StylePriority.UseFont = false
        Me.label35.StylePriority.UseTextAlignment = false
        Me.label35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label36
        '
        Me.label36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label36.LocationFloat = New DevExpress.Utils.PointFloat(284.322!, 211.5417!)
        Me.label36.Name = "label36"
        Me.label36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label36.SizeF = New System.Drawing.SizeF(283.2968!, 23!)
        Me.label36.StylePriority.UseBorders = false
        Me.label36.StylePriority.UseFont = false
        Me.label36.StylePriority.UseTextAlignment = false
        Me.label36.Text = "ENVASE B"
        Me.label36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label37
        '
        Me.label37.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label37.LocationFloat = New DevExpress.Utils.PointFloat(284.3221!, 234.5416!)
        Me.label37.Name = "label37"
        Me.label37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label37.SizeF = New System.Drawing.SizeF(163.5027!, 23.12497!)
        Me.label37.StylePriority.UseBorders = false
        Me.label37.StylePriority.UseFont = false
        Me.label37.StylePriority.UseTextAlignment = false
        Me.label37.Text = "Peso Desejado:"
        Me.label37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label38
        '
        Me.label38.BackColor = System.Drawing.Color.Transparent
        Me.label38.BorderColor = System.Drawing.Color.Black
        Me.label38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label38.BorderWidth = 1!
        Me.label38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_ult_peso_desejado_pote500", "{0:#,#0.00} g")})
        Me.label38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label38.ForeColor = System.Drawing.Color.Black
        Me.label38.LocationFloat = New DevExpress.Utils.PointFloat(172.3127!, 234.5416!)
        Me.label38.Name = "label38"
        Me.label38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label38.SizeF = New System.Drawing.SizeF(112.0093!, 23.12497!)
        Me.label38.StylePriority.UseBackColor = false
        Me.label38.StylePriority.UseBorderColor = false
        Me.label38.StylePriority.UseBorderDashStyle = false
        Me.label38.StylePriority.UseBorders = false
        Me.label38.StylePriority.UseBorderWidth = false
        Me.label38.StylePriority.UseFont = false
        Me.label38.StylePriority.UseForeColor = false
        Me.label38.StylePriority.UsePadding = false
        Me.label38.StylePriority.UseTextAlignment = false
        Me.label38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label39
        '
        Me.label39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label39.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 211.5417!)
        Me.label39.Name = "label39"
        Me.label39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label39.SizeF = New System.Drawing.SizeF(283.9052!, 23!)
        Me.label39.StylePriority.UseBorders = false
        Me.label39.StylePriority.UseFont = false
        Me.label39.StylePriority.UseTextAlignment = false
        Me.label39.Text = "ENVASE A"
        Me.label39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label40
        '
        Me.label40.BackColor = System.Drawing.Color.Transparent
        Me.label40.BorderColor = System.Drawing.Color.Black
        Me.label40.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label40.BorderWidth = 1!
        Me.label40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_e_b_contador_producao_pote500", "{0:#,#0} un")})
        Me.label40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label40.ForeColor = System.Drawing.Color.Black
        Me.label40.LocationFloat = New DevExpress.Utils.PointFloat(568.0776!, 306.25!)
        Me.label40.Name = "label40"
        Me.label40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label40.SizeF = New System.Drawing.SizeF(96.9223!, 30.04163!)
        Me.label40.StylePriority.UseBackColor = false
        Me.label40.StylePriority.UseBorderColor = false
        Me.label40.StylePriority.UseBorderDashStyle = false
        Me.label40.StylePriority.UseBorders = false
        Me.label40.StylePriority.UseBorderWidth = false
        Me.label40.StylePriority.UseFont = false
        Me.label40.StylePriority.UseForeColor = false
        Me.label40.StylePriority.UsePadding = false
        Me.label40.StylePriority.UseTextAlignment = false
        Me.label40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label41
        '
        Me.label41.BackColor = System.Drawing.Color.Transparent
        Me.label41.BorderColor = System.Drawing.Color.Black
        Me.label41.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label41.BorderWidth = 1!
        Me.label41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_contador_producao_pote500", "{0:#,#0} un")})
        Me.label41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label41.ForeColor = System.Drawing.Color.Black
        Me.label41.LocationFloat = New DevExpress.Utils.PointFloat(472.6826!, 306.25!)
        Me.label41.Name = "label41"
        Me.label41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label41.SizeF = New System.Drawing.SizeF(95.19235!, 30.04163!)
        Me.label41.StylePriority.UseBackColor = false
        Me.label41.StylePriority.UseBorderColor = false
        Me.label41.StylePriority.UseBorderDashStyle = false
        Me.label41.StylePriority.UseBorders = false
        Me.label41.StylePriority.UseBorderWidth = false
        Me.label41.StylePriority.UseFont = false
        Me.label41.StylePriority.UseForeColor = false
        Me.label41.StylePriority.UsePadding = false
        Me.label41.StylePriority.UseTextAlignment = false
        Me.label41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label42
        '
        Me.label42.BackColor = System.Drawing.Color.Transparent
        Me.label42.BorderColor = System.Drawing.Color.Black
        Me.label42.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label42.BorderWidth = 1!
        Me.label42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_contador_producao_pote500", "{0:#,#0} un")})
        Me.label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label42.ForeColor = System.Drawing.Color.Black
        Me.label42.LocationFloat = New DevExpress.Utils.PointFloat(189.2829!, 306.25!)
        Me.label42.Name = "label42"
        Me.label42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label42.SizeF = New System.Drawing.SizeF(94.3219!, 30.04163!)
        Me.label42.StylePriority.UseBackColor = false
        Me.label42.StylePriority.UseBorderColor = false
        Me.label42.StylePriority.UseBorderDashStyle = false
        Me.label42.StylePriority.UseBorders = false
        Me.label42.StylePriority.UseBorderWidth = false
        Me.label42.StylePriority.UseFont = false
        Me.label42.StylePriority.UseForeColor = false
        Me.label42.StylePriority.UsePadding = false
        Me.label42.StylePriority.UseTextAlignment = false
        Me.label42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'table2
        '
        Me.table2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 281.25!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(664.945!, 25!)
        Me.table2.StylePriority.UseBorders = false
        Me.table2.StylePriority.UseFont = false
        Me.table2.StylePriority.UseTextAlignment = false
        Me.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label43
        '
        Me.label43.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label43.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label43.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 306.25!)
        Me.label43.Name = "label43"
        Me.label43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label43.SizeF = New System.Drawing.SizeF(163.125!, 30.04164!)
        Me.label43.StylePriority.UseBorders = false
        Me.label43.StylePriority.UseFont = false
        Me.label43.StylePriority.UseTextAlignment = false
        Me.label43.Text = "Contador Produção"
        Me.label43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label44
        '
        Me.label44.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label44.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label44.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 336.2916!)
        Me.label44.Name = "label44"
        Me.label44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label44.SizeF = New System.Drawing.SizeF(163.125!, 27.04171!)
        Me.label44.StylePriority.UseBorders = false
        Me.label44.StylePriority.UseFont = false
        Me.label44.StylePriority.UseTextAlignment = false
        Me.label44.Text = "Média"
        Me.label44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label45
        '
        Me.label45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_media_g_un_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label45.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label45.LocationFloat = New DevExpress.Utils.PointFloat(188.3577!, 336.2916!)
        Me.label45.Name = "label45"
        Me.label45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label45.SizeF = New System.Drawing.SizeF(95.24725!, 27.04169!)
        Me.label45.StylePriority.UseFont = false
        Me.label45.StylePriority.UseTextAlignment = false
        Me.label45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label46
        '
        Me.label46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_b_media_g_un_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label46.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label46.LocationFloat = New DevExpress.Utils.PointFloat(472.6826!, 336.2916!)
        Me.label46.Name = "label46"
        Me.label46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label46.SizeF = New System.Drawing.SizeF(94.93613!, 27.04169!)
        Me.label46.StylePriority.UseFont = false
        Me.label46.StylePriority.UseTextAlignment = false
        Me.label46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label47
        '
        Me.label47.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_e_b_media_g_un_pote500_difdesejado", "{0:#,#0.00} g/un")})
        Me.label47.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label47.LocationFloat = New DevExpress.Utils.PointFloat(568.1326!, 336.2916!)
        Me.label47.Name = "label47"
        Me.label47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label47.SizeF = New System.Drawing.SizeF(96.86731!, 27.04169!)
        Me.label47.StylePriority.UseBorders = false
        Me.label47.StylePriority.UseFont = false
        Me.label47.StylePriority.UseTextAlignment = false
        Me.label47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label48
        '
        Me.label48.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label48.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label48.LocationFloat = New DevExpress.Utils.PointFloat(284.3219!, 306.25!)
        Me.label48.Name = "label48"
        Me.label48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label48.SizeF = New System.Drawing.SizeF(166.1419!, 30.04163!)
        Me.label48.StylePriority.UseBorders = false
        Me.label48.StylePriority.UseFont = false
        Me.label48.StylePriority.UseTextAlignment = false
        Me.label48.Text = "Contador Produção"
        Me.label48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label49
        '
        Me.label49.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label49.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label49.LocationFloat = New DevExpress.Utils.PointFloat(284.3219!, 336.2916!)
        Me.label49.Name = "label49"
        Me.label49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label49.SizeF = New System.Drawing.SizeF(166.5338!, 27.04172!)
        Me.label49.StylePriority.UseBorders = false
        Me.label49.StylePriority.UseFont = false
        Me.label49.StylePriority.UseTextAlignment = false
        Me.label49.Text = "Média"
        Me.label49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'line2
        '
        Me.line2.LineWidth = 2
        Me.line2.LocationFloat = New DevExpress.Utils.PointFloat(0.2083461!, 363.3333!)
        Me.line2.Name = "line2"
        Me.line2.SizeF = New System.Drawing.SizeF(664.8144!, 2.000015!)
        '
        'label50
        '
        Me.label50.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label50.LocationFloat = New DevExpress.Utils.PointFloat(0!, 188.5417!)
        Me.label50.Name = "label50"
        Me.label50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label50.SizeF = New System.Drawing.SizeF(664.2304!, 23!)
        Me.label50.StylePriority.UseBorders = false
        Me.label50.StylePriority.UseFont = false
        Me.label50.StylePriority.UseTextAlignment = false
        Me.label50.Text = "POTE 500g"
        Me.label50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label21
        '
        Me.label21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label21.SizeF = New System.Drawing.SizeF(664.2304!, 23!)
        Me.label21.StylePriority.UseBorders = false
        Me.label21.StylePriority.UseFont = false
        Me.label21.StylePriority.UseTextAlignment = false
        Me.label21.Text = "POTE 200g"
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'line1
        '
        Me.line1.LineWidth = 2
        Me.line1.LocationFloat = New DevExpress.Utils.PointFloat(0.1856562!, 174.7916!)
        Me.line1.Name = "line1"
        Me.line1.SizeF = New System.Drawing.SizeF(664.8144!, 2.000015!)
        '
        'label20
        '
        Me.label20.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label20.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(285.1695!, 147.75!)
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label20.SizeF = New System.Drawing.SizeF(165.478!, 27.04173!)
        Me.label20.StylePriority.UseBorders = false
        Me.label20.StylePriority.UseFont = false
        Me.label20.StylePriority.UseTextAlignment = false
        Me.label20.Text = "Média"
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label19
        '
        Me.label19.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(285.1695!, 117.7083!)
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label19.SizeF = New System.Drawing.SizeF(165.0862!, 30.04164!)
        Me.label19.StylePriority.UseBorders = false
        Me.label19.StylePriority.UseFont = false
        Me.label19.StylePriority.UseTextAlignment = false
        Me.label19.Text = "Contador Produção"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label18
        '
        Me.label18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_e_b_media_g_un_pote200_difdesejado", "{0:#,#0.00} g/un")})
        Me.label18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(568.1328!, 147.75!)
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label18.SizeF = New System.Drawing.SizeF(96.86731!, 27.04169!)
        Me.label18.StylePriority.UseBorders = false
        Me.label18.StylePriority.UseFont = false
        Me.label18.StylePriority.UseTextAlignment = false
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_b_media_g_un_pote200_difdesejado", "{0:#,#0.00} g/un")})
        Me.label15.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(472.6827!, 147.75!)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label15.SizeF = New System.Drawing.SizeF(94.93613!, 27.04169!)
        Me.label15.StylePriority.UseFont = false
        Me.label15.StylePriority.UseTextAlignment = false
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfEnvase_a_media_g_un_pote200_difdesejado", "{0:#,#0.00} g/un")})
        Me.label14.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(189.4915!, 147.75!)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label14.SizeF = New System.Drawing.SizeF(94.83051!, 27.0417!)
        Me.label14.StylePriority.UseFont = false
        Me.label14.StylePriority.UseTextAlignment = false
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 147.75!)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label12.SizeF = New System.Drawing.SizeF(163.125!, 27.04171!)
        Me.label12.StylePriority.UseBorders = false
        Me.label12.StylePriority.UseFont = false
        Me.label12.StylePriority.UseTextAlignment = false
        Me.label12.Text = "Média"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label11
        '
        Me.label11.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 117.7083!)
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label11.SizeF = New System.Drawing.SizeF(163.125!, 30.04164!)
        Me.label11.StylePriority.UseBorders = false
        Me.label11.StylePriority.UseFont = false
        Me.label11.StylePriority.UseTextAlignment = false
        Me.label11.Text = "Contador Produção"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'table1
        '
        Me.table1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.70834!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(665!, 25!)
        Me.table1.StylePriority.UseBorders = false
        Me.table1.StylePriority.UseFont = false
        Me.table1.StylePriority.UseTextAlignment = false
        Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label13
        '
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.BorderColor = System.Drawing.Color.Black
        Me.label13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label13.BorderWidth = 1!
        Me.label13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_contador_producao_pote200", "{0:#,#0} un")})
        Me.label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label13.ForeColor = System.Drawing.Color.Black
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(189.4915!, 117.7083!)
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label13.SizeF = New System.Drawing.SizeF(95.03891!, 30.04163!)
        Me.label13.StylePriority.UseBackColor = false
        Me.label13.StylePriority.UseBorderColor = false
        Me.label13.StylePriority.UseBorderDashStyle = false
        Me.label13.StylePriority.UseBorders = false
        Me.label13.StylePriority.UseBorderWidth = false
        Me.label13.StylePriority.UseFont = false
        Me.label13.StylePriority.UseForeColor = false
        Me.label13.StylePriority.UsePadding = false
        Me.label13.StylePriority.UseTextAlignment = false
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label16
        '
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.BorderColor = System.Drawing.Color.Black
        Me.label16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label16.BorderWidth = 1!
        Me.label16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_contador_producao_pote200", "{0:#,#0} un")})
        Me.label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label16.ForeColor = System.Drawing.Color.Black
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(472.6827!, 117.7083!)
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label16.SizeF = New System.Drawing.SizeF(95.19235!, 30.04163!)
        Me.label16.StylePriority.UseBackColor = false
        Me.label16.StylePriority.UseBorderColor = false
        Me.label16.StylePriority.UseBorderDashStyle = false
        Me.label16.StylePriority.UseBorders = false
        Me.label16.StylePriority.UseBorderWidth = false
        Me.label16.StylePriority.UseFont = false
        Me.label16.StylePriority.UseForeColor = false
        Me.label16.StylePriority.UsePadding = false
        Me.label16.StylePriority.UseTextAlignment = false
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.Transparent
        Me.label17.BorderColor = System.Drawing.Color.Black
        Me.label17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label17.BorderWidth = 1!
        Me.label17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_e_b_contador_producao_pote200", "{0:#,#0} un")})
        Me.label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label17.ForeColor = System.Drawing.Color.Black
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(568.0778!, 117.7084!)
        Me.label17.Name = "label17"
        Me.label17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label17.SizeF = New System.Drawing.SizeF(96.9223!, 30.04163!)
        Me.label17.StylePriority.UseBackColor = false
        Me.label17.StylePriority.UseBorderColor = false
        Me.label17.StylePriority.UseBorderDashStyle = false
        Me.label17.StylePriority.UseBorders = false
        Me.label17.StylePriority.UseBorderWidth = false
        Me.label17.StylePriority.UseFont = false
        Me.label17.StylePriority.UseForeColor = false
        Me.label17.StylePriority.UsePadding = false
        Me.label17.StylePriority.UseTextAlignment = false
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.99999!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label8.SizeF = New System.Drawing.SizeF(284.5305!, 23!)
        Me.label8.StylePriority.UseBorders = false
        Me.label8.StylePriority.UseFont = false
        Me.label8.StylePriority.UseTextAlignment = false
        Me.label8.Text = "ENVASE A"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label23
        '
        Me.label23.BackColor = System.Drawing.Color.Transparent
        Me.label23.BorderColor = System.Drawing.Color.Black
        Me.label23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label23.BorderWidth = 1!
        Me.label23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_a_ult_peso_desejado_pote200", "{0:#,#0.00} g")})
        Me.label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label23.ForeColor = System.Drawing.Color.Black
        Me.label23.LocationFloat = New DevExpress.Utils.PointFloat(172.5211!, 45.99997!)
        Me.label23.Name = "label23"
        Me.label23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label23.SizeF = New System.Drawing.SizeF(112.0093!, 23.12497!)
        Me.label23.StylePriority.UseBackColor = false
        Me.label23.StylePriority.UseBorderColor = false
        Me.label23.StylePriority.UseBorderDashStyle = false
        Me.label23.StylePriority.UseBorders = false
        Me.label23.StylePriority.UseBorderWidth = false
        Me.label23.StylePriority.UseFont = false
        Me.label23.StylePriority.UseForeColor = false
        Me.label23.StylePriority.UsePadding = false
        Me.label23.StylePriority.UseTextAlignment = false
        Me.label23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label25
        '
        Me.label25.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label25.LocationFloat = New DevExpress.Utils.PointFloat(284.5305!, 45.99997!)
        Me.label25.Name = "label25"
        Me.label25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label25.SizeF = New System.Drawing.SizeF(163.5027!, 23.12497!)
        Me.label25.StylePriority.UseBorders = false
        Me.label25.StylePriority.UseFont = false
        Me.label25.StylePriority.UseTextAlignment = false
        Me.label25.Text = "Peso Desejado:"
        Me.label25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label9
        '
        Me.label9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top),DevExpress.XtraPrinting.BorderSide)
        Me.label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(284.5305!, 22.99999!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label9.SizeF = New System.Drawing.SizeF(283.3446!, 23!)
        Me.label9.StylePriority.UseBorders = false
        Me.label9.StylePriority.UseFont = false
        Me.label9.StylePriority.UseTextAlignment = false
        Me.label9.Text = "ENVASE B"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label5
        '
        Me.label5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(379.5305!, 69.12492!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label5.SizeF = New System.Drawing.SizeF(94.04849!, 23.58342!)
        Me.label5.StylePriority.UseBorders = false
        Me.label5.StylePriority.UseFont = false
        Me.label5.StylePriority.UseTextAlignment = false
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.12495!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label1.SizeF = New System.Drawing.SizeF(95.00009!, 23.5834!)
        Me.label1.StylePriority.UseBorders = false
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseTextAlignment = false
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(284.5305!, 69.12495!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label4.SizeF = New System.Drawing.SizeF(95!, 23.5834!)
        Me.label4.StylePriority.UseBorders = false
        Me.label4.StylePriority.UseFont = false
        Me.label4.StylePriority.UseTextAlignment = false
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label24
        '
        Me.label24.BackColor = System.Drawing.Color.Transparent
        Me.label24.BorderColor = System.Drawing.Color.Black
        Me.label24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.label24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label24.BorderWidth = 1!
        Me.label24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "envase_b_ult_peso_desejado_pote200", "{0:#,#0.00} g")})
        Me.label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label24.ForeColor = System.Drawing.Color.Black
        Me.label24.LocationFloat = New DevExpress.Utils.PointFloat(459.3445!, 45.99997!)
        Me.label24.Name = "label24"
        Me.label24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label24.SizeF = New System.Drawing.SizeF(108.5305!, 23.12497!)
        Me.label24.StylePriority.UseBackColor = false
        Me.label24.StylePriority.UseBorderColor = false
        Me.label24.StylePriority.UseBorderDashStyle = false
        Me.label24.StylePriority.UseBorders = false
        Me.label24.StylePriority.UseBorderWidth = false
        Me.label24.StylePriority.UseFont = false
        Me.label24.StylePriority.UseForeColor = false
        Me.label24.StylePriority.UsePadding = false
        Me.label24.StylePriority.UseTextAlignment = false
        Me.label24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label6
        '
        Me.label6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(473.627!, 69.12495!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label6.SizeF = New System.Drawing.SizeF(93.99173!, 23.5834!)
        Me.label6.StylePriority.UseBorders = false
        Me.label6.StylePriority.UseFont = false
        Me.label6.StylePriority.UseTextAlignment = false
        Me.label6.Text = "balança 1+2"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(95.05506!, 69.12492!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label2.SizeF = New System.Drawing.SizeF(94.4754!, 23.58342!)
        Me.label2.StylePriority.UseBorders = false
        Me.label2.StylePriority.UseFont = false
        Me.label2.StylePriority.UseTextAlignment = false
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label22
        '
        Me.label22.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.99997!)
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label22.SizeF = New System.Drawing.SizeF(163.125!, 23.12497!)
        Me.label22.StylePriority.UseBorders = false
        Me.label22.StylePriority.UseFont = false
        Me.label22.StylePriority.UseTextAlignment = false
        Me.label22.Text = "Peso Desejado:"
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label7
        '
        Me.label7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(567.9677!, 69.12495!)
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label7.SizeF = New System.Drawing.SizeF(96.47107!, 23.5834!)
        Me.label7.StylePriority.UseBorders = false
        Me.label7.StylePriority.UseFont = false
        Me.label7.StylePriority.UseTextAlignment = false
        Me.label7.Text = "balança 1+2"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(189.5304!, 69.12492!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label3.SizeF = New System.Drawing.SizeF(95.00003!, 23.58342!)
        Me.label3.StylePriority.UseBorders = false
        Me.label3.StylePriority.UseFont = false
        Me.label3.StylePriority.UseTextAlignment = false
        Me.label3.Text = "balança 1+2"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right),DevExpress.XtraPrinting.BorderSide)
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(567.8751!, 22.99999!)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.label10.SizeF = New System.Drawing.SizeF(96.56372!, 46.12495!)
        Me.label10.StylePriority.UseBorders = false
        Me.label10.StylePriority.UseFont = false
        Me.label10.StylePriority.UseTextAlignment = false
        Me.label10.Text = "ENVASE A+B"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21})
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 1R
        '
        'tableCell15
        '
        Me.tableCell15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StylePriority.UseBorders = false
        Me.tableCell15.Weight = 0.94945015835132551R
        '
        'tableCell16
        '
        Me.tableCell16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StylePriority.UseBorders = false
        Me.tableCell16.Weight = 0.94999985613144255R
        '
        'tableCell17
        '
        Me.tableCell17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_a_peso_medio_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.StylePriority.UseBorders = false
        Me.tableCell17.Weight = 0.93960038248934863R
        '
        'tableCell18
        '
        Me.tableCell18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StylePriority.UseBorders = false
        Me.tableCell18.Weight = 0.96039932977353648R
        '
        'tableCell19
        '
        Me.tableCell19.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.StylePriority.UseBorders = false
        Me.tableCell19.Weight = 0.9399342450937771R
        '
        'tableCell20
        '
        Me.tableCell20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_b_peso_medio_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.StylePriority.UseBorders = false
        Me.tableCell20.Weight = 0.94153214425456733R
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Weight = 0.968533026458119R
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14})
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1R
        '
        'tableCell8
        '
        Me.tableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBorders = false
        Me.tableCell8.Weight = 0.94945015835132551R
        '
        'tableCell9
        '
        Me.tableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBorders = false
        Me.tableCell9.Weight = 0.94999985613144255R
        '
        'tableCell10
        '
        Me.tableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseBorders = false
        Me.tableCell10.Weight = 0.94168564831076562R
        '
        'tableCell11
        '
        Me.tableCell11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StylePriority.UseBorders = false
        Me.tableCell11.Weight = 0.95831406395211949R
        '
        'tableCell12
        '
        Me.tableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StylePriority.UseBorders = false
        Me.tableCell12.Weight = 0.9399342450937771R
        '
        'tableCell13
        '
        Me.tableCell13.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StylePriority.UseBorders = false
        Me.tableCell13.Weight = 0.94225113829455831R
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.Weight = 0.967814032418128R
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7})
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1R
        '
        'tableCell1
        '
        Me.tableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseBorders = false
        Me.tableCell1.Weight = 0.94999993244429826R
        '
        'tableCell2
        '
        Me.tableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseBorders = false
        Me.tableCell2.Weight = 0.94999985613144255R
        '
        'tableCell3
        '
        Me.tableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseBorders = false
        Me.tableCell3.Weight = 0.94999985613144267R
        '
        'tableCell4
        '
        Me.tableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBorders = false
        Me.tableCell4.Weight = 0.94999985613144244R
        '
        'tableCell5
        '
        Me.tableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBorders = false
        Me.tableCell5.Weight = 0.9399342450937771R
        '
        'tableCell6
        '
        Me.tableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBorders = false
        Me.tableCell6.Weight = 0.95192215744876674R
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg", "{0:#,#0.00} kg")})
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.Weight = 0.9581430132639196R
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
        'cfEnvase_a_media_g_un_difdesejado
        '
        Me.cfEnvase_a_media_g_un_difdesejado.Expression = "[envase_a_contador_producao] / [envase_a_peso_medio_difdesejado_balanca1e2]"
        Me.cfEnvase_a_media_g_un_difdesejado.Name = "cfEnvase_a_media_g_un_difdesejado"
        '
        'cfEnvase_b_media_g_un_difdesejado
        '
        Me.cfEnvase_b_media_g_un_difdesejado.Expression = "[envase_b_contador_producao] / [envase_b_peso_medio_difdesejado_balanca1e2]"
        Me.cfEnvase_b_media_g_un_difdesejado.Name = "cfEnvase_b_media_g_un_difdesejado"
        '
        'cfEnvase_a_e_b_media_g_un_difdesejado
        '
        Me.cfEnvase_a_e_b_media_g_un_difdesejado.Expression = "[envase_a_e_b_contador_producao] / [envase_aeb_peso_medio_difdesejado_balanca1e2]"& _ 
    ""
        Me.cfEnvase_a_e_b_media_g_un_difdesejado.Name = "cfEnvase_a_e_b_media_g_un_difdesejado"
        '
        'cfenvase_a_peso_medio_difdesejado_balanca1kg
        '
        Me.cfenvase_a_peso_medio_difdesejado_balanca1kg.Expression = "[envase_a_peso_medio_difdesejado_balanca1] / 1000"
        Me.cfenvase_a_peso_medio_difdesejado_balanca1kg.Name = "cfenvase_a_peso_medio_difdesejado_balanca1kg"
        '
        'cfenvase_a_peso_medio_difdesejado_balanca2kg
        '
        Me.cfenvase_a_peso_medio_difdesejado_balanca2kg.Expression = "[envase_a_peso_medio_difdesejado_balanca2] / 1000"
        Me.cfenvase_a_peso_medio_difdesejado_balanca2kg.Name = "cfenvase_a_peso_medio_difdesejado_balanca2kg"
        '
        'cfenvase_a_peso_medio_difdesejado_balanca1e2kg
        '
        Me.cfenvase_a_peso_medio_difdesejado_balanca1e2kg.Expression = "[cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg] + [cfenvase_a_peso_medio"& _ 
    "_pote500_difdesejado_balanca1e2kg]"
        Me.cfenvase_a_peso_medio_difdesejado_balanca1e2kg.Name = "cfenvase_a_peso_medio_difdesejado_balanca1e2kg"
        '
        'cfenvase_b_peso_medio_difdesejado_balanca1e2kg
        '
        Me.cfenvase_b_peso_medio_difdesejado_balanca1e2kg.Expression = "[cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg] + [cfenvase_b_peso_medio"& _ 
    "_pote500_difdesejado_balanca1e2kg]"
        Me.cfenvase_b_peso_medio_difdesejado_balanca1e2kg.Name = "cfenvase_b_peso_medio_difdesejado_balanca1e2kg"
        '
        'cfenvase_b_peso_medio_difdesejado_balanca1kg
        '
        Me.cfenvase_b_peso_medio_difdesejado_balanca1kg.Expression = "[envase_b_peso_medio_difdesejado_balanca1] / 1000"
        Me.cfenvase_b_peso_medio_difdesejado_balanca1kg.Name = "cfenvase_b_peso_medio_difdesejado_balanca1kg"
        '
        'cfenvase_b_peso_medio_difdesejado_balanca2kg
        '
        Me.cfenvase_b_peso_medio_difdesejado_balanca2kg.Expression = "[envase_b_peso_medio_difdesejado_balanca2] / 1000"
        Me.cfenvase_b_peso_medio_difdesejado_balanca2kg.Name = "cfenvase_b_peso_medio_difdesejado_balanca2kg"
        '
        'calculatedField1
        '
        Me.calculatedField1.DisplayName = "cfenvase_a_peso_medio_pote200_difdesejado_balanca1kg"
        Me.calculatedField1.Expression = "[envase_a_peso_medio_pote200_difdesejado_balanca1] / 1000"
        Me.calculatedField1.Name = "calculatedField1"
        '
        'cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg
        '
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg.Expression = "[envase_a_peso_medio_pote200_difdesejado_balanca2] / 1000"
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg.Name = "cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg"
        '
        'cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg
        '
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg.Expression = "(Round(([envase_a_peso_medio_pote200_balanca1e2] - [envase_a_ult_peso_desejado_po"& _ 
    "te200]),2) * [envase_a_contador_producao_pote200]) / 1000"
        Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg.Name = "cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg"
        '
        'cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg
        '
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg.Expression = "(Round(([envase_b_peso_medio_pote200_balanca1] - [envase_b_ult_peso_desejado_pote"& _ 
    "200]),2) * [envase_b_contador_producao_pote200]) / 1000"
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg.Name = "cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg"
        '
        'cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg
        '
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg.Expression = "(Round(([envase_b_peso_medio_pote200_balanca2] - [envase_b_ult_peso_desejado_pote"& _ 
    "200]),2) * [envase_b_contador_producao_pote200]) / 1000"
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg.Name = "cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg"
        '
        'cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg
        '
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg.Expression = "(Round(([envase_b_peso_medio_pote200_balanca1e2] - [envase_b_ult_peso_desejado_po"& _ 
    "te200]),2) * [envase_b_contador_producao_pote200]) / 1000"
        Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg.Name = "cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg"
        '
        'cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg
        '
        Me.cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg.Expression = "[cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg] + [cfenvase_b_peso_medio"& _ 
    "_pote200_difdesejado_balanca1e2kg]"
        Me.cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg.Name = "cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg"
        '
        'cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg
        '
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg.Expression = "[envase_a_peso_medio_pote500_difdesejado_balanca1] / 1000"
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg.Name = "cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg"
        '
        'cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg
        '
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg.Expression = "[envase_a_peso_medio_pote500_difdesejado_balanca2] / 1000"
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg.Name = "cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg"
        '
        'cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg
        '
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg.Expression = "(Round(([envase_a_peso_medio_pote500_balanca1e2] - [envase_a_ult_peso_desejado_po"& _ 
    "te500]),2) * [envase_a_contador_producao_pote500]) / 1000"
        Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg.Name = "cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg"
        '
        'cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg
        '
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg.Expression = "[envase_b_peso_medio_pote500_difdesejado_balanca1] / 1000"
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg.Name = "cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg"
        '
        'cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg
        '
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg.Expression = "[envase_b_peso_medio_pote500_difdesejado_balanca2] / 1000"
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg.Name = "cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg"
        '
        'cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg
        '
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg.Expression = "(Round(([envase_b_peso_medio_pote500_balanca1e2] - [envase_b_ult_peso_desejado_po"& _ 
    "te500]),2) * [envase_b_contador_producao_pote500]) / 1000"
        Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg.Name = "cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg"
        '
        'cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg
        '
        Me.cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg.Expression = "[cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg] + [cfenvase_b_peso_medio"& _ 
    "_pote500_difdesejado_balanca1e2kg]"
        Me.cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg.Name = "cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg"
        '
        'cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg
        '
        Me.cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg.Expression = "[envase_aeb_peso_medio_difdesejado_balanca1e2] / 1000"
        Me.cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg.Name = "cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg"
        '
        'cfEnvase_a_media_g_un_pote200_difdesejado
        '
        Me.cfEnvase_a_media_g_un_pote200_difdesejado.Expression = "([cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg] * 1000) / [envase_a_con"& _ 
    "tador_producao_pote200]"
        Me.cfEnvase_a_media_g_un_pote200_difdesejado.Name = "cfEnvase_a_media_g_un_pote200_difdesejado"
        '
        'cfEnvase_b_media_g_un_pote200_difdesejado
        '
        Me.cfEnvase_b_media_g_un_pote200_difdesejado.Expression = "([cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg] * 1000) / [envase_b_con"& _ 
    "tador_producao_pote200]"
        Me.cfEnvase_b_media_g_un_pote200_difdesejado.Name = "cfEnvase_b_media_g_un_pote200_difdesejado"
        '
        'cfEnvase_a_e_b_media_g_un_pote200_difdesejado
        '
        Me.cfEnvase_a_e_b_media_g_un_pote200_difdesejado.Expression = "([cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg] * 1000)"&Global.Microsoft.VisualBasic.ChrW(10)&" / [envase_a_"& _ 
    "e_b_contador_producao_pote200]"
        Me.cfEnvase_a_e_b_media_g_un_pote200_difdesejado.Name = "cfEnvase_a_e_b_media_g_un_pote200_difdesejado"
        '
        'cfEnvase_a_media_g_un_pote500_difdesejado
        '
        Me.cfEnvase_a_media_g_un_pote500_difdesejado.Expression = "([cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg] * 1000) / [envase_a_con"& _ 
    "tador_producao_pote500]"
        Me.cfEnvase_a_media_g_un_pote500_difdesejado.Name = "cfEnvase_a_media_g_un_pote500_difdesejado"
        '
        'cfEnvase_b_media_g_un_pote500_difdesejado
        '
        Me.cfEnvase_b_media_g_un_pote500_difdesejado.Expression = "([cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg] * 1000) / [envase_b_con"& _ 
    "tador_producao_pote500]"
        Me.cfEnvase_b_media_g_un_pote500_difdesejado.Name = "cfEnvase_b_media_g_un_pote500_difdesejado"
        '
        'cfEnvase_a_e_b_media_g_un_pote500_difdesejado
        '
        Me.cfEnvase_a_e_b_media_g_un_pote500_difdesejado.Expression = "([cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg] * 1000)"&Global.Microsoft.VisualBasic.ChrW(10)&" / [envase_a_"& _ 
    "e_b_contador_producao_pote500]"
        Me.cfEnvase_a_e_b_media_g_un_pote500_difdesejado.Name = "cfEnvase_a_e_b_media_g_un_pote500_difdesejado"
        '
        'cfEnvase_a_contador_producao_pote200_e_pote500
        '
        Me.cfEnvase_a_contador_producao_pote200_e_pote500.Expression = "[envase_a_contador_producao_pote200] + [envase_a_contador_producao_pote500]"
        Me.cfEnvase_a_contador_producao_pote200_e_pote500.Name = "cfEnvase_a_contador_producao_pote200_e_pote500"
        '
        'cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado
        '
        Me.cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado.Expression = "([cfenvase_a_peso_medio_difdesejado_balanca1e2kg] * 1000)"&Global.Microsoft.VisualBasic.ChrW(10)&" / [cfEnvase_a_contador"& _ 
    "_producao_pote200_e_pote500]"
        Me.cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado.Name = "cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado"
        '
        'cfEnvase_b_contador_producao_pote200_e_pote500
        '
        Me.cfEnvase_b_contador_producao_pote200_e_pote500.Expression = "[envase_b_contador_producao_pote200] + [envase_b_contador_producao_pote500]"
        Me.cfEnvase_b_contador_producao_pote200_e_pote500.Name = "cfEnvase_b_contador_producao_pote200_e_pote500"
        '
        'cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado
        '
        Me.cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado.Expression = "([cfenvase_b_peso_medio_difdesejado_balanca1e2kg] * 1000)"&Global.Microsoft.VisualBasic.ChrW(10)&" / [cfEnvase_b_contador"& _ 
    "_producao_pote200_e_pote500]"
        Me.cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado.Name = "cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado"
        '
        'cfEnvase_a_e_b_contador_producao_pote200_e_pote500
        '
        Me.cfEnvase_a_e_b_contador_producao_pote200_e_pote500.Expression = "[cfEnvase_a_contador_producao_pote200_e_pote500] + [cfEnvase_b_contador_producao_"& _ 
    "pote200_e_pote500]"
        Me.cfEnvase_a_e_b_contador_producao_pote200_e_pote500.Name = "cfEnvase_a_e_b_contador_producao_pote200_e_pote500"
        '
        'cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado
        '
        Me.cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado.Expression = "([cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg] * 1000) / ["& _ 
    "cfEnvase_a_e_b_contador_producao_pote200_e_pote500]"
        Me.cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado.Name = "cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado"
        '
        'cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg
        '
        Me.cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg.Expression = "[cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg] + [cfenvase_aeb_peso_m"& _ 
    "edio_pote500_difdesejado_balanca1e2kg]"
        Me.cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg.Name = "cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg"
        '
        'repParIdTag
        '
        Me.repParIdTag.Name = "repParIdTag"
        Me.repParIdTag.ValueInfo = "20171016_AUTOGEN"
        Me.repParIdTag.Visible = false
        '
        'repCnIndEnvaseOverviewSubPesoMedioDifDesejado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.cfEnvase_a_media_g_un_difdesejado, Me.cfEnvase_b_media_g_un_difdesejado, Me.cfEnvase_a_e_b_media_g_un_difdesejado, Me.cfenvase_a_peso_medio_difdesejado_balanca1kg, Me.cfenvase_a_peso_medio_difdesejado_balanca2kg, Me.cfenvase_a_peso_medio_difdesejado_balanca1e2kg, Me.cfenvase_b_peso_medio_difdesejado_balanca1e2kg, Me.cfenvase_b_peso_medio_difdesejado_balanca1kg, Me.cfenvase_b_peso_medio_difdesejado_balanca2kg, Me.calculatedField1, Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca2kg, Me.cfenvase_a_peso_medio_pote200_difdesejado_balanca1e2kg, Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1kg, Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca2kg, Me.cfenvase_b_peso_medio_pote200_difdesejado_balanca1e2kg, Me.cfenvase_aeb_peso_medio_pote200_difdesejado_balanca1e2kg, Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1kg, Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca2kg, Me.cfenvase_a_peso_medio_pote500_difdesejado_balanca1e2kg, Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1kg, Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca2kg, Me.cfenvase_b_peso_medio_pote500_difdesejado_balanca1e2kg, Me.cfenvase_aeb_peso_medio_pote500_difdesejado_balanca1e2kg, Me.cfenvase_aeb_peso_medio_difdesejado_balanca1e2kg, Me.cfEnvase_a_media_g_un_pote200_difdesejado, Me.cfEnvase_b_media_g_un_pote200_difdesejado, Me.cfEnvase_a_e_b_media_g_un_pote200_difdesejado, Me.cfEnvase_a_media_g_un_pote500_difdesejado, Me.cfEnvase_b_media_g_un_pote500_difdesejado, Me.cfEnvase_a_e_b_media_g_un_pote500_difdesejado, Me.cfEnvase_a_contador_producao_pote200_e_pote500, Me.cfEnvase_a_media_g_un_pote200_e_pote500_difdesejado, Me.cfEnvase_b_contador_producao_pote200_e_pote500, Me.cfEnvase_b_media_g_un_pote200_e_pote500_difdesejado, Me.cfEnvase_a_e_b_contador_producao_pote200_e_pote500, Me.cfEnvase_a_e_b_media_g_un_pote200_e_pote500_difdesejado, Me.cfenvase_aeb_peso_medio_difdesejado_pote200_e_pote500_balanca1e2kg})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDsEnvasePesoMedio})
        Me.DataSource = Me.objectDsEnvasePesoMedio
        Me.Margins = New System.Drawing.Printing.Margins(55, 53, 34, 23)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.repParIdTag})
        Me.Version = "17.1"
        CType(Me.table3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.objectDsEnvasePesoMedio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

#End Region

End Class