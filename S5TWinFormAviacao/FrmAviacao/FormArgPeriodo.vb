Public Class FormArgPeriodo
    Private Sub CmdDesistir_Click(sender As Object, e As EventArgs) Handles CmdDesistir.Click
        Cancela = False
        Me.Hide()
    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        If Testadata(MskDataInicial.Text) = True Then
            MskDataInicial.Focus()
            Exit Sub
        End If

        If Testadata(MskDataFinal.Text) = True Then
            MskDataFinal.Focus()
            Exit Sub
        End If

        Cancela = True
        Me.Hide()
    End Sub

    Private Sub FormArgPeriodo_Load(sender As Object, e As EventArgs) Handles Me.Load
        MskDataInicial.Text = Date.Today
        MskDataFinal.Text = Date.Today

        MskDataInicial.Focus()
    End Sub
End Class