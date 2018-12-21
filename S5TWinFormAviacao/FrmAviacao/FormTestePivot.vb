Imports System.Xml.Linq
Imports DevExpress.Utils.Serializing

'Imports DevExpress.Xpf.WindowsUI
Imports System.Windows
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet

Public Class FormTestePivot
    Private pIdAtual As Long
    Sub New()
        InitializeComponent()
        LinqServerModeSource2.QueryableSource = New S5TWinFormAviacao.DataClassesAviacaoVendasDataContext().AviacaoVendas
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim pivotExportOptions As New DevExpress.XtraPivotGrid.PivotXlsxExportOptions()
        pivotExportOptions.ExportType = DevExpress.Export.ExportType.DataAware
        Dim oForm As New SaveFileDialog
        oForm.FileName = "pivotVendas"
        If oForm.ShowDialog() = DialogResult.OK Then
            PivotGridControl1.ExportToXlsx(oForm.FileName & ".xlsx", pivotExportOptions)
        End If

        ' Exports to an XLS file.
        ChartControl1.ExportToXls(oForm.FileName & "Grafico.xls")


        Dim ctrl As New SpreadsheetControl
        ctrl.LoadDocument(oForm.FileName & ".xlsx")


        Dim ctrl2 As New SpreadsheetControl
        ctrl.LoadDocument(oForm.FileName & "Grafico.xls")

        ctrl.Document.Worksheets.Add("Grafico")



    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim oForm As New FormPivotAnalise

        If oForm.ShowDialog = DialogResult.OK Then

            Dim LayoutRestore As New IO.MemoryStream(oForm.XmlLayout)
            PivotGridControl1.RestoreLayoutFromStream(LayoutRestore)

            lblNomeAnalise.Text = oForm.NomeAnalise
            pIdAtual = oForm.IdAnalise

        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim oForm As New FormPivotAnaliseNovo
        Dim s As New IO.MemoryStream
        PivotGridControl1.SaveLayoutToStream(s)
        oForm.LayoutPivot = s.GetBuffer
        oForm.pIdAnalise = pIdAtual
        oForm.nomeAnalise = lblNomeAnalise.Text

        If oForm.ShowDialog = DialogResult.OK Then

            lblNomeAnalise.Text = oForm.nomeAnalise
            pIdAtual = oForm.pIdAnalise

            'WinUIMessageBox.Show("Análise salva com sucesso!", "Mensagem do Sistema", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.None, MessageBoxOptions.None) 'FloatingMode.Adorner)
            MsgBox("Análise salva com sucesso!", vbInformation, "Mensagem do Sistema")
        End If

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim resposta = MsgBox("Deseja realmente sair?", vbYesNo, "Mensagem do Sistema")
        If resposta = MessageBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLimparAnalise_Click(sender As Object, e As EventArgs) Handles btnLimparAnalise.Click
        pIdAtual = Nothing
        lblNomeAnalise.Text = ""

    End Sub

    Private Sub PivotGridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class