Imports System.ComponentModel
Imports System.IO
Imports System.Text
Public Class FormBalanca
    Dim configs As String()
    Dim parametros As Boolean
    Dim dirFilePeso As String
    Dim dirFileConfig As String
    Dim x As Integer
    Dim obj As S5T.BalancaFracionamento
    Dim pIdAtual As Long


    Private Sub Balanca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARREGA ENUM PARIDADE
        For Each i In [Enum].GetValues(GetType(IO.Ports.Parity))
            cmbParidade.Items.Add(i)
        Next

        'CARREGA ENUM STOPBITS
        For Each i In [Enum].GetValues(GetType(IO.Ports.StopBits))
            cmbStopBits.Items.Add(i)
        Next

        'CARREGA AS PORTAS COM ATIVAS
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbPortasCOM.Items.Add(sp)
        Next

        cmbPortasCOM.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            If pIdAtual = 0 Then
                Dim objNew As New S5T.BalancaFracionamento

                With objNew
                    .pPorta = cmbPortasCOM.SelectedItem
                    .pVelocidade = txtVelocidade.Text
                    .pParidade = DirectCast(CInt(cmbParidade.SelectedItem), IO.Ports.Parity)
                    .pBits = txtBits.Text
                    .pStopBits = DirectCast(CInt(cmbStopBits.SelectedItem), IO.Ports.StopBits)
                    .pIntervalo = txtIntervalo.Text
                    .pIntervaloSalvaAutomatico = txtIntervaloSalvarAutomatico.Text
                    '.sStatus = IIf(ChkStatus.Checked = True, S5T.BalancaStatus.Ativa, S5T.BalancaStatus.Inativa)
                    .pNumeroEtiquetas = txtNumeroEtiquetas.Text
                    .sStatus = S5T.BalancaStatus.Ativa
                    .Save()
                End With
            Else

                obj = S5T.BalancaFracionamento.LoadBypId(pIdAtual)

                With obj
                    .pPorta = cmbPortasCOM.SelectedItem
                    .pVelocidade = txtVelocidade.Text
                    .pParidade = DirectCast(CInt(cmbParidade.SelectedItem), IO.Ports.Parity)
                    .pBits = txtBits.Text
                    .pStopBits = DirectCast(CInt(cmbStopBits.SelectedItem), IO.Ports.StopBits)
                    .pIntervalo = txtIntervalo.Text
                    .pIntervaloSalvaAutomatico = txtIntervaloSalvarAutomatico.Text
                    .pNumeroEtiquetas = txtNumeroEtiquetas.Text
                    .sStatus = IIf(ChkStatus.Checked = True, S5T.BalancaStatus.Ativa, S5T.BalancaStatus.Inativa)

                    .Save()
                End With
            End If

            MsgBox("Operação realizada com sucesso!", vbInformation, "Mensagem do Sistema")

        Catch ex As Exception
            MsgBox("Operação cancelada, " & ex.Message.ToString, vbInformation, "Mensagem do Sistema")

        End Try
    End Sub

    Private Sub cmbPortasCOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPortasCOM.SelectedIndexChanged

        Dim objBalanca As S5T.BalancaFracionamento = S5T.BalancaFracionamento.LoadByPortaCOM(cmbPortasCOM.SelectedItem.ToString)

        If objBalanca IsNot Nothing Then

            With objBalanca
                pIdAtual = .pId
                txtVelocidade.Text = .pVelocidade
                cmbParidade.SelectedItem = DirectCast(CInt(.pParidade), IO.Ports.Parity)
                txtBits.Text = .pBits
                cmbStopBits.SelectedItem = DirectCast(CInt(.pStopBits), IO.Ports.StopBits)
                txtIntervalo.Text = .pIntervalo
                txtIntervaloSalvarAutomatico.Text = .pIntervaloSalvaAutomatico
                txtNumeroEtiquetas.Text = .pNumeroEtiquetas
                IIf(.sStatus = S5T.BalancaStatus.Ativa, ChkStatus.Checked = True, ChkStatus.Checked = False)
            End With

        Else
            pIdAtual = 0
            txtVelocidade.Text = ""
            cmbParidade.SelectedItem = Nothing
            txtBits.Text = ""
            cmbStopBits.SelectedItem = Nothing
            txtIntervalo.Text = ""
            txtIntervaloSalvarAutomatico.Text = 2000
            txtNumeroEtiquetas.Text = ""
            ChkStatus.Checked = False
        End If
    End Sub
End Class