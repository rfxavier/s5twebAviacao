Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Public Class FormFracionamentoLotes
    Public Property Lote As String
    Public Property Produto As String

    Private Sub FormFracionamentoOrdens_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            GridOrdem_Click(GridOrdem, e)
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj = GetFracionamentoLote("01", Produto)

        If obj IsNot Nothing Then
            GridOrdem.DataSource = obj
        Else
            GridOrdem.DataSource = Nothing
        End If

    End Sub



    Private Sub GridOrdem_Click(sender As Object, e As EventArgs) Handles GridOrdem.Click
        If GridOrdemView.SelectedRowsCount = 1 And GridOrdemView.IsDataRow(GridOrdemView.FocusedRowHandle) Then
            IF GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B8_SALDO")) <=0 THEN
                MsgBox ("Lote não possui peso suficiente, escolha outro lote!", vbInformation, "Atenção")
                Exit Sub
            End If
            Lote = GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B8_LOTECTL"))

            DialogResult = DialogResult.OK

            Me.Hide()
        End If
    End Sub



End Class