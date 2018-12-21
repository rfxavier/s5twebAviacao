Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Public Class FormPivotAnalise
    Public Property XmlLayout As Byte()
    Public Property NomeAnalise As String
    Public Property IdAnalise As Long
    Dim obj As S5T.AviacaoPivotAnalise
    Private Sub FormPivotAnalise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objAnalises = S5T.AviacaoPivotAnaliseCollection.LoadByPivotName("pivotVendasWinForm")


        If S5TUsuarioLogado IsNot Nothing Then
            If S5TUsuarioLogado.pFlgAdmin = "N" Then
                objAnalises = objAnalises.FindAll(Function(x) x.pUsuarioLogin = S5TUsuarioLogado.pLogin)
            End If
        End If

        GridAnalises.DataSource = objAnalises


        'Dim col As GridColumn = GridPesqView1.Columns.AddVisible("Excluir", String.Empty)
        'col.UnboundType = DevExpress.Data.UnboundColumnType.Object
        'Dim repButton As RepositoryItemButtonEdit = New RepositoryItemButtonEdit()
        'repButton.Name = "rb1"
        'repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        'GridAnalises.RepositoryItems.Add(repButton)
        'col.ColumnEdit = repButton
        'col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        ''GridPesqView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(mainView_CustomUnboundColumnData)
        'AddHandler GridPesqView1.CustomUnboundColumnData, AddressOf mainView_CustomUnboundColumnData




    End Sub

    Private Sub mainView_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
        If (e.Column.FieldName = "Excluir") Then
            e.Value = "Excluir"
        End If
    End Sub

    Private Sub GridAnalises_DoubleClick(sender As Object, e As EventArgs) Handles GridAnalises.DoubleClick
        If GridPesqView1.SelectedRowsCount = 1 And GridPesqView1.IsDataRow(GridPesqView1.FocusedRowHandle) Then


            XmlLayout = GridPesqView1.GetRowCellValue(GridPesqView1.FocusedRowHandle, GridPesqView1.Columns.ColumnByFieldName("pModeloAnaliseByte"))
            NomeAnalise = GridPesqView1.GetRowCellValue(GridPesqView1.FocusedRowHandle, GridPesqView1.Columns.ColumnByFieldName("pDescricao"))
            IdAnalise = GridPesqView1.GetRowCellValue(GridPesqView1.FocusedRowHandle, GridPesqView1.Columns.ColumnByFieldName("pId"))

            DialogResult = DialogResult.OK

            Me.Hide()
        End If
    End Sub

End Class