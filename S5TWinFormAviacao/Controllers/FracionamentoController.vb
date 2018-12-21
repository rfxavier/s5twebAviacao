Imports Oracle.DataAccess.Client
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.IO
Imports DevExpress.XtraReports.UI

Module FracionamentoController

    Public Function GetFracionamentoOrdem(ByVal parFilial As String, ByVal parNumOrdem As String) As List(Of S5T.FracionamentoMovViewGrid)
        Dim Ordem = New List(Of S5T.FracionamentoMovViewGrid)
        Dim _ListaProdutosKits = s5t.ParametrosFracionamentoCollection.LoadAll()
        Dim _StrListaProdutosKits as string  = "'0'"

        for each obj in _ListaProdutosKits
            ''4113','4100','2107','4110','4114','2108','2109' 
            _StrListaProdutosKits = _StrListaProdutosKits & ",'" & obj.pCodigoProduto & "'"
        Next


        Dim Sql As String = vbEmpty
        Sql = "SELECT C2_FILIAL, "
        Sql = Sql & "   C2_NUM, "
        Sql = Sql & "   C2_ITEM, "
        Sql = Sql & "   C2_SEQUEN, "
        Sql = Sql & "   TO_DATE(C2_EMISSAO,'YYYYMMDD') C2_EMISSAO,"
        Sql = Sql & "   C2_PRODUTO, "
        Sql = Sql & "   PROD.B1_DESC as B1_DESC_PROD, "
        Sql = Sql & "   C2_QUANT,"
        Sql = Sql & "   C2_QUJE, "
        Sql = Sql & "   G1_COMP, "
        Sql = Sql & "   ITM.B1_DESC,"
        Sql = Sql & "   ITM.B1_UM,"
        Sql = Sql & "   G1_QUANT,"
        Sql = Sql & "   G1_ZZQMIN,"
        Sql = Sql & "   G1_ZZQMAX"
        Sql = Sql & "  FROM SC2010 SC2"
        Sql = Sql & "       INNER JOIN SG1010 SG1"
        Sql = Sql & "           ON  G1_FILIAL          = C2_FILIAL"
        Sql = Sql & "           And G1_COD = C2_PRODUTO"
        Sql = Sql & "           And SG1.D_E_L_E_T_ = ' '"
        Sql = Sql & "       INNER JOIN SB1010 PROD"
        Sql = Sql & "           On  PROD.B1_FILIAL      = C2_FILIAL"
        Sql = Sql & "           And PROD.B1_COD = C2_PRODUTO"
        Sql = Sql & "           And PROD.D_E_L_E_T_ = ' '"
        Sql = Sql & "       INNER JOIN SB1010 ITM "
        Sql = Sql & "           On  ITM.B1_FILIAL      = G1_FILIAL"
        Sql = Sql & "           And ITM.B1_COD = G1_COMP"
        Sql = Sql & "           And ITM.D_E_L_E_T_ = ' '"
        'Sql = Sql & "  WHERE C2_PRODUTO       in ('4113','4100','2107','4110','4114','2108','2109') "
        Sql = Sql & "  WHERE C2_PRODUTO       in (" & _StrListaProdutosKits & ") "
        Sql = Sql & "       And C2_QUJE < C2_QUANT "
        Sql = Sql & "       And C2_FILIAL = '" & parFilial & "' "
        Sql = Sql & "       AND SC2.D_E_L_E_T_ = ' ' "
        If parNumOrdem <> "" Then
            Sql = Sql & "       And C2_NUM = '" & parNumOrdem & "' "
        End If
        Sql = Sql & "   ORDER BY C2_NUM, C2_ITEM, C2_SEQUEN, C2_PRODUTO, G1_COMP "

        ''teste
        'Dim sConnectionString As String = "Provider=MSDAORA.1;User ID=PROTTST;password=PROTTST12;Data Source=192.168.50.92;Persist Security Info=False"
        ''"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.50.92)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=PROTHEUSTST)));User Id=PROTTST;Password=PROTTST12;"
        'Dim conn As OleDbConnection = New OleDbConnection(sConnectionString)
        ''OleDbConnection myConnection = New OleDbConnection(sConnectionString);

        'Dim myCommand As OleDbCommand = New OleDbCommand(Sql, conn)
        ''OleDbCommand myCommand = New OleDbCommand(mySelectQuery, myConnection);

        'conn.Open()

        'Dim drOrdem As OleDbDataReader = myCommand.ExecuteReader()
        ''OleDbDataReader myReader = myCommand.ExecuteReader();

        ''fim teste


        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmd As New OracleCommand(Sql, conn) With {.CommandType = CommandType.Text}

        Dim drOrdem As OracleDataReader = Nothing


        Try
            drOrdem = cmd.ExecuteReader()
            If drOrdem.HasRows Then

                'Pega os item que já foram pesados e salvos na base sqlserver
                Dim FracionamentoMovList As List(Of S5T.FracionamentoMovViewGrid)

                If parNumOrdem IsNot Nothing Then
                    FracionamentoMovList = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(parNumOrdem)
                End If

                'Do While drOrdem.Read
                Do While drOrdem.Read
                    Dim obj = New S5T.FracionamentoMovViewGrid

                    'obj.pId = AppUtils.Nvl(drOrdem.Item("pId"), "").ToString.Trim
                    obj.G1_COMP = AppUtils.Nvl(drOrdem.Item("G1_COMP"), "").ToString.Trim
                    obj.B1_DESC = AppUtils.Nvl(drOrdem.Item("B1_DESC"), "").ToString.Trim
                    obj.B1_UM = AppUtils.Nvl(drOrdem.Item("B1_UM"), "").ToString.Trim


                    obj.G1_QUANT = AppUtils.Nvl(drOrdem.Item("G1_QUANT"), "").ToString.Trim
                    obj.G1_ZZQMIN = AppUtils.Nvl(drOrdem.Item("G1_ZZQMIN"), "").ToString.Trim
                    obj.G1_ZZQMAX = AppUtils.Nvl(drOrdem.Item("G1_ZZQMAX"), "").ToString.Trim

                    obj.B1_DESC_PROD = AppUtils.Nvl(drOrdem.Item("B1_DESC_PROD"), "").ToString.Trim
                    'obj.pPesoPesado = AppUtils.Nvl(drOrdem.Item("pPesoPesado"), "").ToString.Trim
                    'obj.pLote = AppUtils.Nvl(drOrdem.Item("pLote"), "").ToString.Trim
                    'obj.pFracionamentoId = AppUtils.Nvl(drOrdem.Item("pFracionamentoId"), "").ToString.Trim
                    obj.C2_EMISSAO = AppUtils.Nvl(drOrdem.Item("C2_EMISSAO"), "").ToString.Trim
                    obj.C2_FILIAL = AppUtils.Nvl(drOrdem.Item("C2_FILIAL"), "").ToString.Trim
                    obj.C2_ITEM = AppUtils.Nvl(drOrdem.Item("C2_ITEM"), "").ToString.Trim
                    obj.C2_NUM = AppUtils.Nvl(drOrdem.Item("C2_NUM"), "").ToString.Trim
                    obj.C2_PRODUTO = AppUtils.Nvl(drOrdem.Item("C2_PRODUTO"), "").ToString.Trim
                    obj.C2_QUANT = AppUtils.Nvl(drOrdem.Item("C2_QUANT"), "").ToString.Trim
                    obj.C2_SEQUEN = AppUtils.Nvl(drOrdem.Item("C2_SEQUEN"), "").ToString.Trim


                    Dim QuantPesada As Integer = 0
                    If FracionamentoMovList IsNot Nothing Then
                        Dim FracionamentoMovProdList As List(Of S5T.FracionamentoMovViewGrid)

                        FracionamentoMovProdList = FracionamentoMovList
                        QuantPesada = FracionamentoMovProdList.FindAll(Function(x) x.G1_COMP = AppUtils.Nvl(drOrdem.Item("G1_COMP"), "").ToString.Trim).Count

                        obj.C2_QUJE = QuantPesada
                    Else
                        obj.C2_QUJE = AppUtils.Nvl(drOrdem.Item("C2_QUJE"), "").ToString.Trim

                    End If

                    'obj.pStatus = AppUtils.Nvl(drOrdem.Item("pStatus"), "").ToString.Trim

                    Ordem.Add(obj)
                Loop

                drOrdem.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drOrdem) Is Nothing) Then
                drOrdem.Dispose()
            End If
        End Try

        Return Ordem.OrderBy(Function(x) x.B1_DESC).ToList
    End Function

    Public Function GetFracionamentoLote(ByVal parFilial As String, ByVal parProduto As String) As List(Of S5T.LoteFracionamento)
        Dim Lotes = New List(Of S5T.LoteFracionamento)


        'fazer uma busca na base nas ordens que nao foram enviadas pro Protheus do produto
       Dim OrdensAbertas = S5T.FracionamentoMovCollection.LoadOrdensAbertasByProduto(parProduto)

        Dim Sql As String = vbEmpty
        Sql = "Select B8_FILIAL, "
        Sql = Sql & "     B8_PRODUTO,"
        Sql = Sql & "     B1_DESC,"
        Sql = Sql & "     B8_SALDO,"
        Sql = Sql & "     TO_DATE(B8_DTVALID,'YYYYMMDD') B8_DTVALID,"
        Sql = Sql & "     B8_LOTECTL"
        Sql = Sql & " From SB8010 SB8"
        Sql = Sql & " INNER Join SB1010 SB1"
        Sql = Sql & " On  B1_FILIAL                   = B8_FILIAL"
        Sql = Sql & " And B1_COD                  = B8_PRODUTO"
        Sql = Sql & "     And SB1.D_E_L_E_T_          = ' '"
        Sql = Sql & " WHERE B8_PRODUTO = '" & parProduto & "'"
        Sql = Sql & "     And (B8_SALDO - B8_EMPENHO) > 0"
        Sql = Sql & " And B8_FILIAL = '" & parFilial & "'"
        Sql = Sql & "     And SB8.D_E_L_E_T_          = ' '"

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmd As New OracleCommand(Sql, conn) With {.CommandType = CommandType.Text}

        Dim drLote As OracleDataReader = Nothing
        Try
            drLote = cmd.ExecuteReader()
            If drLote.HasRows Then
                Do While drLote.Read
                    Dim obj = New S5T.LoteFracionamento

                    Dim numPesoAbertoPorLote as Double = 0

                    if OrdensAbertas.Count > 0 Then
                        Dim Ordens = OrdensAbertas.FindAll(Function(x) x.pLote =  AppUtils.Nvl(drLote.Item("B8_LOTECTL"), "").ToString.Trim)

                        if Ordens IsNot Nothing then
                            numPesoAbertoPorLote = Ordens.Sum(Function(y) y.pPesoPesado)
                            else
                            numPesoAbertoPorLote = 0
                        End If
                    end if

                    

                    obj.B8_FILIAL = AppUtils.Nvl(drLote.Item("B8_FILIAL"), "").ToString.Trim
                    obj.B8_PRODUTO = AppUtils.Nvl(drLote.Item("B8_PRODUTO"), "").ToString.Trim
                    obj.B1_DESC = AppUtils.Nvl(drLote.Item("B1_DESC"), "").ToString.Trim
                    'obj.B8_SALDO = AppUtils.Nvl(drLote.Item("B8_SALDO"), "").ToString.Trim
                    obj.B8_SALDO = (AppUtils.Nvl(drLote.Item("B8_SALDO"), "") - numPesoAbertoPorLote).ToString.Trim
                    obj.B8_DTVALID = AppUtils.Nvl(drLote.Item("B8_DTVALID"), "").ToString.Trim
                    obj.B8_LOTECTL = AppUtils.Nvl(drLote.Item("B8_LOTECTL"), "").ToString.Trim

                    Lotes.Add(obj)
                Loop

                drLote.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drLote) Is Nothing) Then
                drLote.Dispose()
            End If
        End Try

      


        Return Lotes.OrderBy(Function(x) x.B8_DTVALID).ToList
    End Function

    Public Function EnviaOrdemProtheus(ByVal parORDEM As System.Collections.Generic.List(Of S5T.FracionamentoMovViewGrid)) As Boolean

        EnviaOrdemProtheus = False
        Try

            Dim ListLotes = parORDEM

            Dim ServiceFracionamentoProtheusClient As New ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAPClient

            Dim ServiceOrcamentoProtheusGsOrdem As New ServiceFracionamentoProtheusReference.GSORDPES
            Dim ServiceOrcamentoProtheusGsItensOrdem = New ServiceFracionamentoProtheusReference.ARRAYOFGSITMORDPES

            ServiceOrcamentoProtheusGsOrdem.ITEM = parORDEM.FirstOrDefault().C2_ITEM
            ServiceOrcamentoProtheusGsOrdem.NUMERO = parORDEM.FirstOrDefault().C2_NUM
            ServiceOrcamentoProtheusGsOrdem.PRODUTO = parORDEM.FirstOrDefault().C2_PRODUTO
            ServiceOrcamentoProtheusGsOrdem.SEQUENCIA = parORDEM.FirstOrDefault().C2_SEQUEN

            For Each obj In ListLotes.GroupBy(Function(x) x.G1_COMP).Select(Function(y) New With {.G1_COMP = y.Key})

                ServiceOrcamentoProtheusGsItensOrdem.Add(New ServiceFracionamentoProtheusReference.GSITMORDPES With {
                                                                        .LOTE = parORDEM.FirstOrDefault(Function(x) x.G1_COMP = obj.G1_COMP).pLote,
                                                                        .PRODUTO = obj.G1_COMP,
                                                                        .QUANTIDADE = parORDEM.FindAll(Function(x) x.G1_COMP = obj.G1_COMP).Sum(Function(y) y.pPesoPesado)})
            Next

            ServiceOrcamentoProtheusGsOrdem.ITENS = ServiceOrcamentoProtheusGsItensOrdem

            Dim varResultadoInclui = ServiceFracionamentoProtheusClient.AJUSTAPESOS(ServiceOrcamentoProtheusGsOrdem)

            If varResultadoInclui.ITENS.FirstOrDefault.ERRO <> "" Then
                dim erro as String = string.Empty

                for each obj in varResultadoInclui.ITENS
                    dim objNew as new S5T.LogFracionamento
                    

                    objnew.pNumOrdem = parORDEM.FirstOrDefault().C2_NUM
                    OBJNEW.pOrdemProduto = PARORDEM.FirstOrDefault().C2_PRODUTO
                    objNew.pOrdemData =   parORDEM.FindAll(Function(x) x.G1_COMP = obj.PRODUTO).FirstOrDefault().C2_EMISSAO
                    objnew.pCodigoProduto = obj.PRODUTO
                    objnew.pProdutoDescricao = parORDEM.FindAll(Function(x) x.G1_COMP = obj.PRODUTO).FirstOrDefault().B1_DESC_PROD
                    objnew.pQuantidade = obj.QUANTIDADE
                    objnew.pDescricao =  obj.ERRO.ToString()
                    objnew.pDataMov = S5T.AppConfig.LoadDataHoraBD()
                    objnew.pTipo = "ERRO"
                    objnew.Save()

                    erro += "PROD: " + obj.PRODUTO + "PESO:" + obj.QUANTIDADE + "ERRO: " + obj.ERRO.ToString() + "/"
                Next
                

                'envio de email com erro
                Dim Mail As New MailMessage()
                Mail.From = New MailAddress("bi@aviacao.ind.br", "Sistema Fracionamento Aviação")

                Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))
                Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))

                Mail.To.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("everton@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("claudia@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("compras@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("willian@aviacao.ind.br"))

                ' Specify other e-mail options.
                'Mail.Subject = "INDICADORES DE VENDA - " & CStr(Date.Now) & ""
                Mail.Subject = "Erro Ordem N." + varResultadoInclui.NUMERO.ToString() + " de envio para Protheus"
                Mail.Body = "Erro envio Protheus - Retorno: " + erro.ToString() +" </br></br>E-mail automático enviado do Sistema de Fracionamento 4T - NÃO RESPONDER ESSE E-MAIL"

                '' Send the e-mail message via the specified SMTP server.
                Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
                Smtp.Port = 587
                Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
                Smtp.EnableSsl = True
                
                Smtp.Send(Mail)

                msgBox("Erro Webservice Protheus - Retorno: " & varResultadoInclui.ITENS.FirstOrDefault.ERRO.ToString, vbCritical, "Mensagem do Sistema")
            Else
                Dim objFracionamento = S5T.Fracionamento.LoadByNumeroOrdem(parORDEM.FirstOrDefault().C2_NUM)
                objFracionamento.sStatus = S5T.FracionamentoStatus.EnviadaProtheus
                objFracionamento.Save()

                'ImprimeEtiquetaOrdem(objFracionamento.C2_NUM, objFracionamento.C2_QUANT)

                EnviaOrdemProtheus = True

            End If


        Catch ex As Exception
            'My.Log.WriteException(ex, TraceEventType.Error, varObservacaoPedido)
            'Dim varBaseDir = AppDomain.CurrentDomain.BaseDirectory

            MsgBox("Erro Webservice Protheus: " & ex.Message)

            'IO.File.AppendAllText(varBaseDir & "LogAspNet5t.txt", String.Format("{0}{1} {2} {3}", Environment.NewLine, Date.Now.ToString, ex.ToString(), varObservacaoPedido))
        Finally

        End Try

        Return EnviaOrdemProtheus

    End Function

    Public Sub ImprimeEtiquetaOrdem(ByVal parNumeroOrdem As String, ByVal parQuantidadeEtiquetas As Integer, ByVal parUltimoNumeroEtiqueta As Integer, byval parMultiplaEtiquetas As String)


        Dim FracionamentoMov = S5T.FracionamentoMovCollection.LoadByOrdemViewGrid(parNumeroOrdem)

        Dim I As Integer
        'Dim QtdEtiquetas As Integer = FracionamentoMov.FirstOrDefault().C2_QUANT

        If parMultiplaEtiquetas = "N" Then
            parUltimoNumeroEtiqueta = 1
            parQuantidadeEtiquetas = 1
        End If


        For I = (parUltimoNumeroEtiqueta - parQuantidadeEtiquetas) + 1 To parUltimoNumeroEtiqueta

            Dim oRelatorio As New repEtiquetaOrdem
            oRelatorio.Parameters(0).Value = I
            'código de barras gerado por aqui -Num 9 por que Cod Barras é Int e arranca os 0s da vez; 4 posições para a VEZ que está sendo impresso da ordem + Id da Fracionamento.
            oRelatorio.Parameters(1).Value = "9" & I.ToString.PadLeft(4,"0") & FracionamentoMov.FirstOrDefault.pFracionamentoId

            oRelatorio.DataSource = FracionamentoMov
            oRelatorio.CreateDocument()

            FormReportDX.DocumentViewer1.DocumentSource = oRelatorio


            ' THIS IS TO TAKE THE DEFAULT LOCAL PRINT
            Dim instance As New Printing.PrinterSettings
            Dim DefaultPrinter As String = instance.PrinterName

            ' THIS IS TO PRINT THE REPORT
            oRelatorio.PrinterName = DefaultPrinter
            'oRelatorio.CreateDocument()
            oRelatorio.PrintingSystem.ShowMarginsWarning = False


            oRelatorio.Print()
        Next I

    End Sub

End Module
