Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI

Public Class FormFracionamentoReimpressao
    Public Property OrdemNumero As String
    Public Property Produto As String

    Private Sub FormFracionamentoOrdens_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            btnImprimir.PerformClick()
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj =  S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(OrdemNumero)

        If obj IsNot Nothing Then
            obj = obj.Findall(function(x) x.G1_COMP = Produto)
            if obj isnot nothing then GridFracionamentoMov.DataSource = obj.OrderByDescending((function(y) y.pVez))
        Else
            GridFracionamentoMov.DataSource = Nothing
        End If

    End Sub

    

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridFracionamentoMovView.SelectedRowsCount = 1 And GridFracionamentoMovView.IsDataRow(GridFracionamentoMovView.FocusedRowHandle) Then

            Dim oRelatorio As New repEtiqueta

            Dim FracionamentoMov = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(OrdemNumero)
                
            'S5T.FracionamentoMovCollection.LoadEtiquetaMov(S5T.FracionamentoMovCollection.LoadByOrdemProdutoViewGrid(OrdemNumero, (GridFracionamentoMovView.GetRowCellValue(GridFracionamentoMovView.FocusedRowHandle, GridFracionamentoMovView.Columns.ColumnByFieldName("G1_COMP")))).OrderByDescending(Function(x) x.pId).FirstOrDefault.pId)

            if fracionamentomov is Nothing then
                exit sub
            End If
            FracionamentoMov = FracionamentoMov.FindAll(Function(x) x.pId =  (GridFracionamentoMovView.GetRowCellValue(GridFracionamentoMovView.FocusedRowHandle, GridFracionamentoMovView.Columns.ColumnByFieldName("pId"))))
            oRelatorio.DataSource = FracionamentoMov
            oRelatorio.CreateDocument()

            FormReportDX.DocumentViewer1.DocumentSource = oRelatorio


            ' THIS IS TO TAKE THE DEFAULT LOCAL PRINT
            Dim instance As New Printing.PrinterSettings
            Dim DefaultPrinter As String = instance.PrinterName

            ' THIS IS TO PRINT THE REPORT
            oRelatorio.PrinterName = DefaultPrinter
            oRelatorio.CreateDocument()
            oRelatorio.PrintingSystem.ShowMarginsWarning = False
            oRelatorio.Print()

            dim objNew as new S5T.LogFracionamento
            objnew.pDescricao = "Impressão Ordem: " & OrdemNumero & " /Produto: " & Produto & " /Vez: " & FracionamentoMov.FirstOrDefault().pVez
            objnew.pDataMov = s5t.AppConfig.LoadDataHoraBD()
            objNew.pNumOrdem = OrdemNumero
            objNew.pCodigoProduto = Produto
            objnew.pTipo = "IMPRESSAO"
            objnew.Save()

        End If
    End Sub


End Class