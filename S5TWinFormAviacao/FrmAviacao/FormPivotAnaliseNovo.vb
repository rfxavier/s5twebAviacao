Public Class FormPivotAnaliseNovo
    Public Property pIdAnalise As Long
    Public Property LayoutPivot As Byte()
    Public Property nomeAnalise As String

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim objNew As New S5T.AviacaoPivotAnalise

        If pIdAnalise = Nothing Then
            With objNew
                .pDescricao = Trim(UCase(txtNomeLayout.Text))
                .pModeloAnaliseByte = LayoutPivot
                .oUsuario = S5TUsuarioLogado
                .pLayoutVersion = "v1.0"
                .pPivotNome = "pivotVendasWinForm"
                .pPastaNome = cmbPasta.EditValue
                .pFlgCompartilhada = IIf(chkAnaliseCompartilhada.Checked, "S", "N")
                .Save()

                DialogResult = DialogResult.OK
                Me.Close()
            End With
        Else

            Dim obj = S5T.AviacaoPivotAnalise.LoadBypId(pIdAnalise)

            With objNew
                .pDescricao = Trim(UCase(txtNomeLayout.Text))
                .pModeloAnaliseByte = LayoutPivot
                .oUsuario = S5TUsuarioLogado
                .pLayoutVersion = "v1." & Mid(obj.pLayoutVersion, 4) + 1
                .pPivotNome = "pivotVendasWinForm"
                .pPastaNome = cmbPasta.EditValue
                .pFlgCompartilhada = IIf(chkAnaliseCompartilhada.Checked, "S", "N")
                .Save()

                DialogResult = DialogResult.OK
                Me.Close()

            End With
        End If
        pIdAnalise = objNew.pId
        nomeAnalise = Trim(UCase(txtNomeLayout.Text))
    End Sub

    Private Sub FormPivotAnaliseNovo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ListaPastas = S5T.AviacaoPivotAnalise.LoadAllNomePasta

        If ListaPastas IsNot Nothing Then
            'For Each objLista In ListaPastas.GroupBy(Function(X) X.pPastaNome).Select(Function(y) New With {.pPastaNome = y.Key}).ToList

            cmbPasta.Properties.DataSource = ListaPastas
            cmbPasta.Properties.DisplayMember = "pPastaNome"
            cmbPasta.Properties.ValueMember = "pPastaNome"
            'Next
        End If

        txtNomeLayout.EditValue = nomeAnalise

    End Sub
End Class