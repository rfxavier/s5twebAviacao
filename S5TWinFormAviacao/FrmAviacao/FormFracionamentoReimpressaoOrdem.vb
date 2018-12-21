Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI

Public Class FormFracionamentoReimpressaoOrdem
    Public Property OrdemNumero As String
    Private _maximoVez As Integer
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
            _maximoVez = obj.Max(Function(x) x.pVez)
        Else
            _maximoVez =1   
        End If

        txtVezIni.EditValue = 1
        txtVezFim.EditValue = _maximoVez

    End Sub
      

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If txtVezIni.EditValue isnot nothing And txtVezFim.EditValue isnot nothing   Then

            If txtVezFim.EditValue > _maximoVez Then
                MsgBox ("Número de Vez máximo fora do intervalo permitido.", vbInformation, "Mensagem do Sistema")
                Exit Sub
            End If
            
            Dim quantidadeEtiquetas As Integer
            quantidadeEtiquetas = txtVezFim.EditValue - txtVezIni.EditValue + 1

            ImprimeEtiquetaOrdem(OrdemNumero,quantidadeEtiquetas,txtVezFim.EditValue, "S")
           
            dim objNew as new S5T.LogFracionamento
            objnew.pDescricao = "Impressão Etiqueta Ordem: " & OrdemNumero & " /Vez: " & txtVezIni.EditValue & " a " & txtVezFim.EditValue
            objnew.pDataMov = s5t.AppConfig.LoadDataHoraBD()
            objnew.pNumOrdem = OrdemNumero
            objnew.pTipo = "IMPRESSAO"
            objnew.Save()

        End If
    End Sub


End Class