Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Public Class FormFracionamentoOrdens
    Public Property FilialOrdem As String
    Public Property NumeroOrdem As String

    Private Sub FormFracionamentoOrdens_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            GridOrdem_Click(GridOrdem, e)
        End If
    End Sub

    Private Sub FormPivotAnalise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj = GetFracionamentoOrdem("01", Nothing)

        If obj IsNot Nothing Then
            GridOrdem.DataSource = obj.GroupBy(Function(x) x.C2_NUM).Select(Function(y) New With {.C2_NUM = y.Key,
                                                         .B1_DESC_PROD = y.Min(Function(z) z.B1_DESC_PROD),
                                                         .C2_EMISSAO = y.Min(Function(z) z.C2_EMISSAO),
                                                         .C2_FILIAL = y.Min(Function(z) z.C2_FILIAL),
                                                         .C2_ITEM = y.Min(Function(z) z.C2_ITEM),
                                                         .C2_SEQUEN = y.Min(Function(z) z.C2_SEQUEN),
                                                         .C2_PRODUTO = y.Min(Function(z) z.C2_PRODUTO),
                                                         .C2_QUANT = y.Min(Function(z) z.C2_QUANT),
                                                         .C2_QUJE = y.Min(Function(z) z.C2_QUJE)})
            

        Else
            GridOrdem.DataSource = Nothing
        End If

    End Sub



    Private Sub GridOrdem_Click(sender As Object, e As EventArgs) Handles GridOrdem.Click
        If GridOrdemView.SelectedRowsCount = 1 And GridOrdemView.IsDataRow(GridOrdemView.FocusedRowHandle) Then

            FilialOrdem = GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_FILIAL"))
            NumeroOrdem = GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_NUM"))

            DialogResult = DialogResult.OK

            Me.Hide()
        End If
    End Sub



End Class