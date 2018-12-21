Imports System.ComponentModel
Imports System.IO
Imports System.Text
Public Class Balanca
    Dim configs As String()
    Dim parametros As Boolean
    Dim dirFilePeso As String
    Dim dirFileConfig As String
    Dim x As Integer
    Private Sub Balanca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim processos() As System.Diagnostics.Process
            processos = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName)
            If processos.Length > 1 Then
                MessageBox.Show("4TBalança já está inicado!")
                Me.Close()
            End If

            'mudei o nome do arquivo para não ficar muito na "CARA". PESO.TXT passou para WEIGHT.4TW
            'dirFilePeso = My.Application.Info.DirectoryPath & "\" & "4WEIGHTt.4TW"
            'System.IO.File.WriteAllText(dirFilePeso, "")


            ''Verifica Status da Porta
            'VerificaStatusPorta()

            'cmdDesconectar.Enabled = False

            'CARREGA ENUM PARIDADE
            For Each i In [Enum].GetValues(GetType(IO.Ports.Parity))
                cmbParidade.Items.Add(i)
            Next

            'CARREGA ENUM STOPBITS
            For Each i In [Enum].GetValues(GetType(IO.Ports.StopBits))
                cmbStopBits.Items.Add(i)
            Next

            'CARREGA ENUM HANDSHAKE
            For Each i In [Enum].GetValues(GetType(IO.Ports.Handshake))
                cmbHandShake.Items.Add(i)
            Next


            'LerArquivoConfiguracao()

            'Dim Price As Integer
            'Int32.TryParse(txtIntervalo.Text, Price)

            'TimerIntervalo.Interval = CInt(txtIntervalo.Text)



            'With SerialPort
            '    .PortName = txtNomePorta.Text
            '    .BaudRate = txtVelocidade.Text
            '    .Parity = DirectCast(cmbParidade.SelectedItem, IO.Ports.Parity)
            '    .DataBits = txtBits.Text
            '    .StopBits = DirectCast(cmbStopBits.SelectedItem, IO.Ports.StopBits)
            '    .Handshake = DirectCast(cmbHandShake.SelectedItem, IO.Ports.Handshake)
            '    .Open()
            '    'MsgBox("depois do open")
            '    '.NewLine = vbCr
            '    'MsgBox("depois do vbcr")
            '    'StrValor = .ReadExisting
            '    'MsgBox("depois do readexisting")
            '    'txtPeso.Text = .ReadExisting
            '    '.DiscardInBuffer()
            'End With


            cmdConectar_Click(Me, e)
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub cmdConectar_Click(sender As Object, e As EventArgs) Handles cmdConectar.Click

        With SerialPort
            .PortName = txtNomePorta.Text
            .BaudRate = txtVelocidade.Text
            .Parity = DirectCast(cmbParidade.SelectedItem, IO.Ports.Parity)
            .DataBits = txtBits.Text
            .StopBits = DirectCast(cmbStopBits.SelectedItem, IO.Ports.StopBits)
            .Handshake = DirectCast(cmbHandShake.SelectedItem, IO.Ports.Handshake)
            .Open()
            'MsgBox("depois do open")
            '.NewLine = vbCr
            'MsgBox("depois do vbcr")
            'StrValor = .ReadExisting
            'MsgBox("depois do readexisting")
            'txtPeso.Text = .ReadExisting
            '.DiscardInBuffer()
        End With
        TimerIntervalo.Interval = CInt(txtIntervalo.Text)


        'If parametros = False Then Exit Sub

        TimerIntervalo.Enabled = True
        cmdConectar.Enabled = False
        cmdDesconectar.Enabled = True
    End Sub

    Private Sub cmdDesconectar_Click(sender As Object, e As EventArgs) Handles cmdDesconectar.Click
        TimerIntervalo.Enabled = False
        cmdDesconectar.Enabled = False
        cmdConectar.Enabled = True
        VerificaStatusPorta()
        System.IO.File.WriteAllText(dirFilePeso, "")
    End Sub

    Private Sub TimerIntervalo_Tick(sender As Object, e As EventArgs) Handles TimerIntervalo.Tick

        LerBalanca()

    End Sub
    Private Sub LerBalanca()

        'txtPeso.Text = ""

        ''SIMULAR GRAVACAO TXT SEM COMUNCAR COM A BALANCA

        'If txtSimularTXT.Text = "S" Then
        '    x = x + 1
        '    txtPeso.Text = Format(x, "000000")
        '    Exit Sub
        'End If

        'VerificaStatusPorta()

        Try

            Dim StrValor As String
            StrValor = ""
            'With SerialPort
            '    If .IsOpen = True Then .Close()
            '    .PortName = "COM2"
            '    .BaudRate = "9600"
            '    .Parity = IO.Ports.Parity.None
            '    .DataBits = "8"
            '    .StopBits = IO.Ports.StopBits.One
            '    SerialPort.Open()
            '    StrValor = .ReadLine()
            '    txtPeso.Text = StrValor
            '    SerialPort.DiscardInBuffer()
            'End With

            With SerialPort
                'MsgBox("depois do open")
                .NewLine = vbCr
                'MsgBox("depois do vbcr")
                'StrValor = .ReadExisting
                'MsgBox("depois do readexisting")
                txtPeso.Text = .ReadExisting
                .DiscardInBuffer()
            End With



            '.PortName = "COM2"
            '.BaudRate = "4800"
            '.Parity = IO.Ports.Parity.None
            '.DataBits = "7"
            '.StopBits = IO.Ports.StopBits.Two
            '.Handshake = IO.Ports.Handshake.None
            '.Open()
            '.NewLine = vbCr
            'StrValor = .ReadExisting
            '.DiscardInBuffer()




        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub
    Public Sub GravarPeso(ByVal parTexto As String)

        Try

            Dim fluxoTexto As IO.StreamWriter

            System.IO.File.WriteAllText(dirFilePeso, "")

            fluxoTexto = New IO.StreamWriter(dirFilePeso, True)
            fluxoTexto.Write(parTexto)
            fluxoTexto.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtPeso_TextChanged(sender As Object, e As EventArgs) Handles txtPeso.TextChanged
        'GRAVAR ARQUIVO DE TEXTO PARA CADA ALTERACAO

        ' GravarPeso(txtPeso.Text)

    End Sub
    Public Sub VerificaStatusPorta()
        If SerialPort.IsOpen = True Then
            lblStatus.Text = "Porta Aberta"
        Else
            lblStatus.Text = "Porta Fechada"
        End If

    End Sub

    Private Sub LerArquivoConfiguracao()
        Try

            parametros = False
            'mudei o nome do arquivo para não ficar muito na "CARA". DE CONFIG.TXT PARA 4PARAMETERt.4TC
            dirFileConfig = My.Application.Info.DirectoryPath & "\" & "4PARAMETERt.4TC"

            Dim fluxoTexto As IO.StreamReader
            Dim linhaTexto As String


            If IO.File.Exists(dirFileConfig) Then
                fluxoTexto = New IO.StreamReader(dirFileConfig)
                linhaTexto = fluxoTexto.ReadLine

                fluxoTexto.Close()

                configs = linhaTexto.Split(",")
                AtualizaCamposConfiguracao()

            Else

                'Dim SW As New StreamWriter(Program.DefaultFolder & "\log.txt")
                'SW.Close()
                'SW.Dispose()

                'MessageBox.Show("Arquivo de log não existe")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub AtualizaCamposConfiguracao()
        Try

            If configs.Count = 7 Then
                txtNomePorta.Text = configs(0)
                txtVelocidade.Text = configs(1)
                cmbParidade.SelectedItem = DirectCast(CInt(configs(2)), IO.Ports.Parity)
                txtBits.Text = configs(3)
                cmbStopBits.SelectedItem = DirectCast(CInt(configs(4)), IO.Ports.StopBits)
                txtSimularTXT.Text = configs(5)
                txtIntervalo.Text = configs(6)
                parametros = True
            Else
                'MsgBox("Formato inválido do Arquivo de Configuração.", vbInformation)
                lblStatus.Text = "Formato inválido do Arquivo de Configuração."
                parametros = False
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub




    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim StrValor As String
        'StrValor = ""

        'Try

        '    With SerialPort
        '        If .IsOpen = True Then .Close()
        '        .PortName = "COM2"
        '        .BaudRate = "9600"
        '        .Parity = IO.Ports.Parity.None
        '        .DataBits = "7"
        '        .StopBits = IO.Ports.StopBits.Two
        '        .Handshake = IO.Ports.Handshake.None
        '        .Open()
        '        MsgBox("CAR3")
        '        .NewLine = vbCr
        '        StrValor = .ReadExisting
        '        MsgBox("2")
        '        Dim strm As New StreamWriter(My.Application.Info.DirectoryPath & "\" & "pesocapturado.txt")
        '        strm.WriteLine(StrValor)
        '        strm.Close()
        '        .DiscardInBuffer()
        '    End With

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        Dim StrValor As String
        StrValor = ""

        Try
            With SerialPort
                MsgBox("CAR3")
                .NewLine = vbCr
                StrValor = .ReadExisting
                MsgBox("2")
                Dim strm As New StreamWriter(My.Application.Info.DirectoryPath & "\" & "pesocapturado.txt")
                strm.WriteLine(StrValor)
                strm.Close()
                .DiscardInBuffer()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub


    Private Sub Balanca_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            NotifyIcon1.BalloonTipText = "4T BALANÇA ONLINE"
            NotifyIcon1.ShowBalloonTip(1)
        End If
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Label6_DoubleClick(sender As Object, e As EventArgs) Handles Label6.DoubleClick
        Button1.Visible = True
    End Sub


End Class