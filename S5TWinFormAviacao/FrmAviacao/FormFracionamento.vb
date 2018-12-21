
Imports System.Windows
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI


Public Class FormFracionamento

    Private _contSegundosBalanca As Integer = 0
    Private _pesoLiqAux As Double = 0
    Private _intervaloSalvAut As Integer = 2000
    Private _zerouBalanca As Boolean = True
    Private _modoDebug As Boolean = false
    Private _IntervaloEtiquetasImpressao As Integer = 0
    Private _imprimeMultiplasEtiquetasOrdem As String
    

    Sub New()
        InitializeComponent()

    End Sub

    Private Sub FormFracionamento_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetGaugePeso()

        Try
            Dim processos() As System.Diagnostics.Process
            processos = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName)
            If processos.Length > 1 Then
                MessageBox.Show("4TBalança já está inicado!")
                Me.Close()
            End If

            ConectaPorta()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtOrdem.Focus()

    End Sub

    Public Sub VerificaStatusPorta()
        If SerialPort.IsOpen = True Then
            lblStatus.Text = "Conectada"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Desconectada"
            lblStatus.ForeColor = Color.Red
            lblPeso.Text = "0,00"
        End If

    End Sub

    Private Sub ConectaPorta()



        Try
            
            If _modoDebug = True Then
                Dim o As S5T.BalancaFracionamentoCollection

                o = S5T.BalancaFracionamentoCollection.LoadAll

                If o.Count = 0 Then
                    MsgBox("Configuração da balança não configurada!", vbCritical, "Mensagem do Sistema")
                End If
                Timer1.Interval = CInt(o.FirstOrDefault.pIntervalo)
                _intervaloSalvAut = o.FirstOrDefault.pIntervaloSalvaAutomatico
                _IntervaloEtiquetasImpressao = o.FirstOrDefault.pNumeroEtiquetas
                Timer1.Enabled = True
                Exit Sub

            End If

            VerificaStatusPorta()
            Timer1.Enabled = False
            SerialPort.Close()


            Dim obj As S5T.BalancaFracionamentoCollection

            obj = S5T.BalancaFracionamentoCollection.LoadAll

            If obj.Count = 0 Then
                MsgBox("Configuração da balança não configurada!", vbCritical, "Mensagem do Sistema")
            End If
            Timer1.Interval = CInt(obj.FirstOrDefault.pIntervalo)
            _intervaloSalvAut = obj.FirstOrDefault.pIntervaloSalvaAutomatico
            _IntervaloEtiquetasImpressao = obj.FirstOrDefault.pNumeroEtiquetas

            With SerialPort
                .PortName = obj.FirstOrDefault.pPorta
                .BaudRate = obj.FirstOrDefault.pVelocidade
                .Parity = DirectCast(CInt(obj.FirstOrDefault.pParidade), IO.Ports.Parity)
                .DataBits = obj.FirstOrDefault.pBits
                .StopBits = DirectCast(CInt(obj.FirstOrDefault.pStopBits), IO.Ports.StopBits)
                .Handshake = IO.Ports.Handshake.None
                .Open()
            End With

            Timer1.Enabled = True
            VerificaStatusPorta()
            _zerouBalanca = True

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Mensagem do Sistema")
        End Try

    End Sub

    Private Sub txtOrdem_LostFocus(sender As Object, e As EventArgs) Handles txtOrdem.LostFocus

        If Trim(txtOrdem.EditValue) = "" Then Exit Sub

        lblProduto.Text = ""
        lblKits.Text = 0
        lblKitsPesados.Text = 0
        lblPesoMin.Text = "0,00"
        lblPesoMax.Text = "0,00"

        Try


            Dim FracionamentoMovViewGridList = FracionamentoController.GetFracionamentoOrdem("01", Trim(txtOrdem.EditValue))
            GridOrdem.DataSource = FracionamentoMovViewGridList

            lblProduto.Text = FracionamentoMovViewGridList.FirstOrDefault().B1_DESC_PROD
            lblKits.Text = FracionamentoMovViewGridList.FirstOrDefault().C2_QUANT

            Dim o =  S5T.ParametrosFracionamentoCollection.LoadAll 
            _imprimeMultiplasEtiquetasOrdem = o.ToList.FindAll(Function(x) x.pCodigoProduto =FracionamentoMovViewGridList.FirstOrDefault().C2_PRODUTO ).FirstOrDefault.pImprimeMultiplasEtiquetas

            GridOrdemView.FocusedRowHandle = 0
            SelecionaItemOrdem()
            GridOrdem.Focus()

        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally

        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        SerialPort.Close()

        Me.Close()
    End Sub

    Private Sub btnLimparAnalise_Click(sender As Object, e As EventArgs) Handles btnLimparAnalise.Click
        LimparCampos()
    End Sub
    Public Sub LimparCampos()
        GridOrdem.DataSource = Nothing
        txtOrdem.EditValue = Nothing
        lblProduto.Text = ""
        lblKits.Text = "0"
        lblKitsPesados.Text = "0"
        lblPesoMin.Text = "0,00"
        lblPesoMax.Text = "0,00"
        txtLote.Text = ""
        txtOrdem.Focus()


    End Sub

    Private Sub GridOrdemView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridOrdemView.FocusedRowChanged
        SelecionaItemOrdem()
    End Sub

    Public Sub SelecionaItemOrdem()
        If GridOrdemView.SelectedRowsCount = 1 And GridOrdemView.IsDataRow(GridOrdemView.FocusedRowHandle) Then

            If (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B1_UM"))) = "KG" Then
                lblPesoMin.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMIN"))) * 1000
                lblPesoMax.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMAX"))) * 1000
                lblPesoIdeal.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_QUANT"))) * 1000
            Else
                lblPesoMin.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMIN")))
                lblPesoMax.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMAX")))
                lblPesoIdeal.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_QUANT")))

            End If


            lblKitsPesados.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_QUJE")))


            'PREENCHER CAMPO LOTE
            Dim FilialCodigo As String = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_FILIAL")))
            Dim prodPrincipalCodigo As String = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_PRODUTO")))
            Dim prodCodigo As String = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_COMP")))


            txtLote.EditValue = ""

            If Trim(prodCodigo) = "" Or Trim(FilialCodigo) = "" Then Exit Sub

            Dim LotesFracionamentoList = FracionamentoController.GetFracionamentoLote(Trim(FilialCodigo), Trim(prodCodigo))
            If LotesFracionamentoList.Count > 0 Then
                Dim UltimoLoteUsado = s5t.FracionamentoMov.LoadByProduto(trim(prodCodigo))
        
                if UltimoLoteUsado isnot nothing then
                    dim LoteOracle = LotesFracionamentoList.FindAll(Function(x)x.B8_LOTECTL = UltimoLoteUsado.pLote)
                    if LoteOracle.Count > 0 then
                        if LoteOracle.FirstOrDefault().B8_SALDO > 0 Then
                            txtLote.EditValue = UltimoLoteUsado.pLote
                        else
                            txtLote.EditValue = LotesFracionamentoList.FirstOrDefault().B8_LOTECTL
                        End If
                    else
                        txtLote.EditValue = LotesFracionamentoList.FirstOrDefault().B8_LOTECTL
                    End If
                else
                    txtLote.EditValue = LotesFracionamentoList.FirstOrDefault().B8_LOTECTL
                End If
            End If

            Dim pesoMinimo As Double = CDbl(AppUtils.Nvl(lblPesoMin.Text, "0"))
            Dim pesoMaximo As Double = CDbl(AppUtils.Nvl(lblPesoMax.Text, "0"))
            Dim pesoIdeal As Double = CDbl(AppUtils.Nvl(lblPesoIdeal.Text, "0"))

            Dim pesoTara As Double

            Dim TaraProduto = S5T.TaraFracionamentoCollection.LoadView(prodPrincipalCodigo, prodCodigo)
            If TaraProduto.Count > 0 Then
                pesoTara = TaraProduto.FirstOrDefault.pEmbalagemPeso
            Else
                pesoTara = 0
            End If

            lblPesoTara.Text = pesoTara

            lblPesoLiq.Text = 0 - lblPesoTara.Text
        End If
    End Sub

    Private Sub FormFracionamento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'CHAMA TELA BUSCA DE ORDENS ABERTAS
        If e.KeyCode = Keys.F2 Then
            Dim oFormOrdensAbertas As New FormFracionamentoOrdens
            If oFormOrdensAbertas.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                txtOrdem.EditValue = oFormOrdensAbertas.NumeroOrdem
                Call txtOrdem_LostFocus(sender, e)
                'Filial = oFormOrdensAbertas.NumeroOrdem
                oFormOrdensAbertas = Nothing
                GridOrdem.Focus()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            Dim oFormLotes As New FormFracionamentoLotes
            Dim linhaGridSelecionada As Integer = GridOrdemView.FocusedRowHandle

            oFormLotes.Produto = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_COMP")))

            If oFormLotes.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                dim loteAux = oFormLotes.Lote
                oFormLotes = Nothing
                GridOrdemView.FocusedRowHandle = linhaGridSelecionada
                GridOrdem.Focus()

                GridOrdemView_FocusedRowChanged(sender, Nothing)
                txtLote.EditValue = loteAux
            End If

        ElseIf e.KeyCode = Keys.Enter Then
            Sv()
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Sv()
    End Sub

    Public Sub Sv()
        If GridOrdemView.SelectedRowsCount = 1 And GridOrdemView.IsDataRow(GridOrdemView.FocusedRowHandle) Then

            If _zerouBalanca = False Then
                Exit Sub
            End If

            If txtLote.Text.Trim = "" Then
                MsgBox("Lote não pode ser nulo", vbInformation, "Mensagem Do sistema")
                Exit Sub
            End If

            If lblPesoLiq.Text.Trim <> "" Then
                If CDbl(lblPesoLiq.Text) <= 0 Then
                    MsgBox("Peso não pode ser zeerado", vbInformation, "Mensagem Do sistema")
                    Exit Sub
                End If
            End If

            SplashScreenManager3.ShowWaitForm()

            Dim FracionamentoMovList As New List(Of S5T.FracionamentoMovViewGrid)
            Dim obj As New S5T.FracionamentoMovViewGrid
            Dim linhaGridSelecionada As Integer = GridOrdemView.FocusedRowHandle

            With obj
                .C2_EMISSAO = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_EMISSAO")))
                .C2_FILIAL = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_FILIAL")))
                .C2_ITEM = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_ITEM")))
                .C2_NUM = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_NUM")))
                .C2_PRODUTO = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_PRODUTO")))
                .C2_QUANT = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_QUANT")))
                .pVez = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_QUJE"))) + 1
                .C2_SEQUEN = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_SEQUEN")))

                .B1_DESC = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B1_DESC")))
                .G1_COMP = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_COMP")))
                .G1_QUANT = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_QUANT")))
                .G1_ZZQMIN = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMIN")))
                .G1_ZZQMAX = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_ZZQMAX")))

                .B1_UM = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B1_UM")))
                .B1_DESC_PROD = lblProduto.Text

                .pLote = Trim(txtLote.Text)

                If .B1_UM = "KG" Then
                    .pPesoPesado = CDbl(lblPesoLiq.Text) / 1000
                Else
                    .pPesoPesado = lblPesoLiq.Text
                End If

                .pDataMov = S5T.AppConfig.LoadDataHoraBD
                '.pUsuario = S5TUsuarioLogado.pLogin

                If .pVez > .C2_QUANT Then
                    MsgBox("Número de pesagens já realizado, operação cancelada.", vbCritical, "Mensagem do sistema")
                    SplashScreenManager3.CloseWaitForm()
                    Exit Sub
                End If

                If lblPesoLiq.Text < lblPesoMin.Text Or lblPesoLiq.Text > lblPesoMax.Text Then
                    MsgBox("Peso fora do permitido, operação cancelada.", vbCritical, "Mensagem do sistema")
                    SplashScreenManager3.CloseWaitForm()
                    Exit Sub
                End If

                FracionamentoMovList.Add(obj)

            End With

            S5T.FracionamentoMov.GravaOrdem(FracionamentoMovList)

            ImprimeEtiquetaMov(S5T.FracionamentoMovCollection.LoadByOrdemProdutoViewGrid(txtOrdem.Text, obj.G1_COMP).OrderByDescending(Function(x) x.pId).FirstOrDefault.pId)

            _zerouBalanca = False
            'Call txtOrdem_LostFocus(txtOrdem, EventArgs.Empty)

            Dim FracionamentoMovViewGridList = FracionamentoController.GetFracionamentoOrdem("01", Trim(txtOrdem.EditValue))
            GridOrdem.DataSource = FracionamentoMovViewGridList

            lblProduto.Text = FracionamentoMovViewGridList.FirstOrDefault().B1_DESC_PROD
            lblKits.Text = FracionamentoMovViewGridList.FirstOrDefault().C2_QUANT

            'verifica se pesou a quantidade total e pula pra proxima linha
            If FracionamentoMovList.FirstOrDefault.pVez >= FracionamentoMovList.FirstOrDefault.C2_QUANT Or (FracionamentoMovList.FirstOrDefault.pVez mod _IntervaloEtiquetasImpressao = 0) Then
                If linhaGridSelecionada < GridOrdemView.RowCount - 1 Then
                    GridOrdemView.FocusedRowHandle = linhaGridSelecionada + 1
                Else
                    GridOrdemView.FocusedRowHandle = linhaGridSelecionada
                End If
            Else
                GridOrdemView.FocusedRowHandle = linhaGridSelecionada
            End If

            _contSegundosBalanca = -5

            GridOrdem.Focus()

            lblKitsPesados.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("C2_QUJE")))
            SplashScreenManager3.CloseWaitForm()

            'BUSCA DOS DADOS DA ORDEM PARA IMPRESSAO DE ETIQUETAS OU ENVIO PROTHEUS
            Dim fracionamentoCollection = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(txtOrdem.EditValue)
            Dim objOrdem = FracionamentoController.GetFracionamentoOrdem("01", Trim(txtOrdem.EditValue))

            Dim parUltimoNumeroEtiqueta As Integer = 0
            parUltimoNumeroEtiqueta = fracionamentoCollection.FindAll(Function(x) x.G1_COMP = obj.G1_COMP).Max(Function(y) y.pVez)

            'VERIFICA SE ATINGIU O INTERVALO PARA IMPRESSAO DO NUMERO DE ETIQUETAS EM TODOS OS PRODUTOS
            If objOrdem.FindAll(Function(x) x.C2_QUJE < _IntervaloEtiquetasImpressao).Count = 0 Then
                'VERIFICA SE ESTÁ NO INTERVALO PARA IMPRESSÃO
                If (fracionamentoCollection.FindAll(Function(x) x.G1_COMP = obj.G1_COMP).Max(Function(y) y.pVez) Mod _IntervaloEtiquetasImpressao) = 0 Then
                    'ImprimeEtiquetaOrdem(Trim(txtOrdem.EditValue), _IntervaloEtiquetasImpressao, parUltimoNumeroEtiqueta, _imprimeMultiplasEtiquetasOrdem)
                End If
            End If


            'VERIFICA SE A ORDEM FOI TODA PESADA

            If objOrdem.FindAll(Function(x) x.C2_QUJE <> x.C2_QUANT).Count <= 0 Then
                'ordem toda pesada entao:

                '       2 - faz o envio pro protheus
                If MsgBox("Confirma fechamento de Ordem?", vbYesNo, "Mensagem do Sistema!") = vbYes Then

                    Dim objOrdemList = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(txtOrdem.Text).OrderByDescending(Function(x) x.pId)
                    '2
                    Me.Cursor = Cursors.WaitCursor

                    Dim NumRestanteEtiqueta As Integer = objOrdem.FirstOrDefault().C2_QUANT

                    While NumRestanteEtiqueta >= _IntervaloEtiquetasImpressao
                        NumRestanteEtiqueta = NumRestanteEtiqueta - _IntervaloEtiquetasImpressao
                    End While

                    'ImprimeEtiquetaOrdem(Trim(txtOrdem.EditValue), NumRestanteEtiqueta, parUltimoNumeroEtiqueta, _imprimeMultiplasEtiquetasOrdem)

                    EnviaOrdemProtheus(objOrdemList.ToList)

                    Me.Cursor = Cursors.Default
                    LimparCampos()
                End If

            End If



        End If

    End Sub
    'etiqueta da movimentação
    Public Sub ImprimeEtiquetaMov(ByVal parFracionamentoId As Long)

        Dim oRelatorio As New repEtiqueta

        Dim FracionamentoMov = S5T.FracionamentoMovCollection.LoadEtiquetaMov(parFracionamentoId)

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


    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim rnd As New Random()

        'Dim scale As Double = 10 ^ 4
        'Dim randomNumber As Double = rnd.Next(0, 2 * scale + 1)

        'lblPeso.Text = randomNumber / scale

        Try

            Dim StrValor As String
            StrValor = ""


            If _modoDebug = True Then

                'txtretorno.Text = "     56.78 g      17.78 g "
                txtretorno.Text = "    492.60 g      17.78 g "
                'txtretorno.Text = "    000.10 g      17.78 g "

                Dim PesoString As String


                If txtretorno.Text.Length >= 10 Then
                    'PesoString = Mid(.ReadExisting, 1, InStr(.ReadExisting, "g") - 1).Trim
                    PesoString = Mid(txtretorno.Text, 1, 10).Trim
                End If

                If PesoString.Trim <> "" Then
                    PesoString = PesoString.Replace(".", ",")
                    lblPeso.Text = CDbl(PesoString)
                    lblPesoLiq.Text = CDbl(PesoString) - CDbl(AppUtils.Nvl(lblPesoTara.Text, "0"))
                    _pesoLiqAux = CDbl(AppUtils.Nvl(lblPeso.Text, "0")) - CDbl(AppUtils.Nvl(lblPesoTara.Text, "0"))
                Else
                    lblPeso.Text = 0
                    lblPesoLiq.Text = 0
                    _pesoLiqAux = 0
                End If

                If lblPeso.Text <= 0.1 Then
                    _zerouBalanca = True
                End If
            Else

                With SerialPort
                    '.NewLine = vbCr

                    Dim ascP As Byte = Byte.Parse("50", Globalization.NumberStyles.HexNumber)
                    Dim asc13 As Byte = Byte.Parse("0D", Globalization.NumberStyles.HexNumber)
                    Dim asc10 As Byte = Byte.Parse("0A", Globalization.NumberStyles.HexNumber)

                    Dim byteslist As New List(Of Byte)
                    byteslist.Add(ascP)
                    byteslist.Add(asc13)
                    byteslist.Add(asc10)

                    Dim buff() As Byte = byteslist.ToArray

                    .Write(buff, 0, buff.Length)

                    txtretorno.Text = .ReadExisting

                    Dim PesoString As String


                    If txtretorno.Text.Length >= 10 Then
                        'PesoString = Mid(.ReadExisting, 1, InStr(.ReadExisting, "g") - 1).Trim
                        PesoString = Mid(txtretorno.Text, 1, 10).Trim
                    End If

                    If PesoString.Trim <> "" Then
                        PesoString = PesoString.Replace(".", ",")
                        lblPeso.Text = CDbl(PesoString)
                        lblPesoLiq.Text = CDbl(PesoString) - CDbl(AppUtils.Nvl(lblPesoTara.Text, "0"))
                        _pesoLiqAux = CDbl(AppUtils.Nvl(lblPeso.Text, "0")) - CDbl(AppUtils.Nvl(lblPesoTara.Text, "0"))
                    Else
                        lblPeso.Text = 0
                        lblPesoLiq.Text = 0
                        _pesoLiqAux = 0
                    End If

                    If lblPeso.Text <= 0 Then
                        _zerouBalanca = True
                    End If

                    .DiscardInBuffer()
                End With

            End If


            SetGaugePeso()

            If chkSalvarAut.Checked = True Then
                If _contSegundosBalanca >= (1 / CInt(Timer1.Interval)) * _intervaloSalvAut Then
                    Timer1.Enabled = False
                    Sv()
                    Timer1.Enabled = True
                    _contSegundosBalanca = 0
                End If
            End If



        Catch ex As Exception
            '    lblStatus.Text = "erro:" & ex.Message
        End Try

    End Sub

    Public Sub SetGaugePeso()
        lblPesoAbaixo.BackColor = Color.Transparent
        lblPesoMin.BackColor = Color.Transparent
        lblPesoIdeal.BackColor = Color.Transparent
        lblPesoMax.BackColor = Color.Transparent
        lblPesoAcima.BackColor = Color.Transparent

        Dim pesoLiq As Double = Format(CDbl(AppUtils.Nvl(lblPeso.Text, "0")) - CDbl(AppUtils.Nvl(lblPesoTara.Text, "0")), "#,###0.000")


        If pesoLiq >= lblPesoMin.Text And pesoLiq <= lblPesoMax.Text Then
            If Math.Round(pesoLiq, 2) = Math.Round(_pesoLiqAux, 2) Then
                _contSegundosBalanca += 1
            Else
                _contSegundosBalanca = 0
            End If
        End If


        If pesoLiq < lblPesoMin.Text Then
            lblPesoAbaixo.BackColor = Color.Red
        ElseIf pesoLiq >= lblPesoMin.Text And pesoLiq < lblPesoIdeal.Text Then
            lblPesoMin.BackColor = Color.Yellow
        ElseIf pesoLiq = lblPesoIdeal.Text Then
            lblPesoIdeal.BackColor = Color.Green
        ElseIf pesoLiq > lblPesoIdeal.Text And pesoLiq <= lblPesoMax.Text Then
            lblPesoMax.BackColor = Color.Yellow
        ElseIf pesoLiq > lblPesoMax.Text Then
            lblPesoAcima.BackColor = Color.Red
        End If

    End Sub

    Private Sub btnConfigBalanca_Click(sender As Object, e As EventArgs) Handles btnConfigBalanca.Click
        Dim oForm As New FormBalanca

        If oForm.ShowDialog() = DialogResult.OK Then
            oForm.Close()
        End If

        ConectaPorta()
    End Sub

    Private Sub chkSalvarAut_CheckedChanged(sender As Object, e As EventArgs) Handles chkSalvarAut.CheckedChanged
        GridOrdem.Focus()
    End Sub

    Private Sub btnFecharOrdem_Click(sender As Object, e As EventArgs) Handles btnFecharOrdem.Click
        If MsgBox("Confirma fechamento de Ordem?", vbYesNo, "Mensagem do Sistema!") = vbYes Then


            'VERIFICA SE A ORDEM FOI TODA PESADA
            Dim objOrdem = FracionamentoController.GetFracionamentoOrdem("01", Trim(txtOrdem.EditValue))

            If objOrdem.FindAll(Function(x) x.C2_QUJE <> x.C2_QUANT).Count <= 0 Then
                'ordem toda pesada entao:

                Dim objOrdemList = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(txtOrdem.Text).OrderByDescending(Function(x) x.pId)

                Dim retorno = EnviaOrdemProtheus(objOrdemList.ToList)

                If retorno = True Then
                    LimparCampos()
                End If
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
       
        Dim oForm As New FormFracionamentoReimpressao
        oform.OrdemNumero = txtOrdem.EditValue
        oform.Produto = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("G1_COMP")))
        oform.lblTitulo.Text = (GridOrdemView.GetRowCellValue(GridOrdemView.FocusedRowHandle, GridOrdemView.Columns.ColumnByFieldName("B1_DESC")))
        If oForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            oform.Close()

        End If

    End Sub

    Private Sub btnImpressoraEtiquetaOrdem_Click(sender As Object, e As EventArgs) Handles btnImpressoraEtiquetaOrdem.Click

        If txtOrdem.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim oForm As New FormFracionamentoReimpressaoOrdem
        oform.OrdemNumero = txtOrdem.EditValue
        oform.lblTitulo.Text = lblProduto.Text
        If oForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            oform.Close()
        End If
    End Sub

  
End Class
