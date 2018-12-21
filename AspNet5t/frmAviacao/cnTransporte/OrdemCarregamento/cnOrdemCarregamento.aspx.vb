Imports DevExpress.Web
Imports CodeFluent.Runtime
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Owin
Imports S5T
Imports DevExpress.Export
'Imports DevExpress.XtraPrinting
Imports System.IO

Imports Microsoft.Owin.Security
Imports DevExpress
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting
Imports Oracle.DataAccess.Client

Public Class cnOrdemCarregamento
    Inherits System.Web.UI.Page
    Dim obj As S5T.VisitaMov = Nothing
    Dim objVisitante As S5T.VisitanteVisitaCollection
    Dim objFuncionario As S5T.FuncionarioVisitaCollection
    Dim objSetor As S5T.SetorVisitaCollection
    Dim objEmpresa As S5T.EmpresaVisitaCollection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If

        If Not IsPostBack Then
            InicializaForm()
        End If




        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()


    End Sub

    Private Sub InicializaForm()
        'LIMPA obj
        obj = Nothing

        'APAGA TODOS OS CONTROLES DE EDIÇÃO
        ASPxEdit.ClearEditorsInContainer(ASPxPageControl1)
        litMsgGenerica.Text = ""

        'RESETA O lbCodigo = LABEL (NÃO É CONTROLE DE EDIÇÃO)
        'lbCodigo.Text = "NOVO"

        '**** RESETA GRID PESQUISA - INÍCIO **
        'MANDA IR PARA PRIMEIRA PÁGINA DO GRID
        gridPesquisa.PageIndex = 0

        limparCamposPesquisa()

        'DES-SELECIONA O QUE TIVER SELECIONADO
        RemoveHandler gridPesquisa.SelectionChanged, AddressOf gridPesquisa_SelectionChanged
        gridPesquisa.Selection.UnselectAll()
        AddHandler gridPesquisa.SelectionChanged, AddressOf gridPesquisa_SelectionChanged

        'DESCONECTA E ZERA A DATASOURCE
        RemoveHandler gridPesquisa.DataBinding, AddressOf gridPesquisa_DataBinding
        gridPesquisa.DataSource = Nothing
        gridPesquisa.DataBind()
        AddHandler gridPesquisa.DataBinding, AddressOf gridPesquisa_DataBinding
        '**** RESETA GRID PESQUISA - FIM **

        'DESCONECTA E ZERA A DATASOURCE
        RemoveHandler GridLOTES.DataBinding, AddressOf GridLOTES_DataBinding
        GridLOTES.DataSource = Nothing
        'GridLOTES.DataBind()
        AddHandler GridLOTES.DataBinding, AddressOf GridLOTES_DataBinding
        '**** RESETA GRID PESQUISA - FIM **

        'DES-SELECIONA O QUE TIVER SELECIONADO
        RemoveHandler GridLOTES.SelectionChanged, AddressOf GridLOTES_SelectionChanged
        GridLOTES.Selection.UnselectAll()
        AddHandler GridLOTES.SelectionChanged, AddressOf GridLOTES_SelectionChanged


    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        'Dim i = (gridPesquisa.GetSelectedFieldValues("pId")(0).ToString.Trim)


        lblDescProduto.Text = gridPesquisa.GetSelectedFieldValues("pProdutoDescricao")(0).ToString
        lblQtdProdACarregar.Text = gridPesquisa.GetSelectedFieldValues("pQuantidade")(0).ToString
        GridLOTES.PageIndex = 0
        GridLOTES.DataBind()

        ASPxPopupControl1.ShowOnPageLoad = True


    End Sub

    Protected Sub GridLOTES_SelectionChanged(sender As Object, e As EventArgs) Handles GridLOTES.SelectionChanged
        'Dim i = (gridPesquisa.GetSelectedFieldValues("pId")(0).ToString.Trim)
        txtLOTE.Text = GridLOTES.GetSelectedFieldValues("pLote")(0).ToString.Trim
        Dim QuantLote As Double
        QuantLote = GridLOTES.GetSelectedFieldValues("pQuantidade")(0)

        If QuantLote > CDbl(lblQtdProdACarregar.Text) Then
            txtQTD_LOTE.Text = lblQtdProdACarregar.Text
        Else
            txtQTD_LOTE.Text = QuantLote
        End If

        'ASPxPopupControl1.ShowOnPageLoad = True
        'ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "FocoQuantidade();", True)
        txtQTD_LOTE.Focus()
    End Sub

    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        'obj = S5T.VisitaMov.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId

        End If

    End Sub

    'Protected Sub btnDesistir_Click(sender As Object, e As EventArgs) Handles btnDesistir.Click
    '    InicializaForm()
    '    gridPesquisa.PageIndex = 0
    '    gridPesquisa.DataBind()

    '    limparCamposPesquisa()
    'End Sub

#Region "tipoOperacaoTratamento"
    Enum tpInsAlt
        Insercao
        Alteracao
    End Enum

    Private Function tipoOperacao() As tpInsAlt
        If gridPesquisa.GetSelectedFieldValues("pId").Count = 0 Then
            tipoOperacao = tpInsAlt.Insercao
        Else
            tipoOperacao = tpInsAlt.Alteracao
        End If
    End Function
#End Region

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs)
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Insercao Then
                ''É INSERÇÃO
                Dim objVisitaMov As New S5T.VisitaMov
                With objVisitaMov
                    '.pDataVisita = IIf(TxtDATAVISITA.Text = "", Nothing, TxtDATAVISITA.Text)
                    '.oVisitantepId = cmbVisitante.Text.Substring(cmbVisitante.Text.IndexOf("(") + 1, cmbVisitante.Text.LastIndexOf(")") - cmbVisitante.Text.IndexOf("(") - 1)
                    '.oFuncionariopId = cmbFuncionario.Text.Substring(cmbFuncionario.Text.IndexOf("(") + 1, cmbFuncionario.Text.LastIndexOf(")") - cmbFuncionario.Text.IndexOf("(") - 1)
                    '.oSetorpId = cmbSetor.Text.Substring(cmbSetor.Text.IndexOf("(") + 1, cmbSetor.Text.LastIndexOf(")") - cmbSetor.Text.IndexOf("(") - 1)
                    '.oEmpresapId = cmbEmpresa.Text.Substring(cmbEmpresa.Text.IndexOf("(") + 1, cmbEmpresa.Text.LastIndexOf(")") - cmbEmpresa.Text.IndexOf("(") - 1)
                    '.Save()
                End With



            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim objVisitaMov As S5T.VisitaMov = S5T.VisitaMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                With objVisitaMov
                    '.pDataVisita = IIf(TxtDATAVISITA.Text = "", Nothing, TxtDATAVISITA.Text)

                    '.oVisitantepId = cmbVisitante.Text.Substring(cmbVisitante.Text.IndexOf("(") + 1, cmbVisitante.Text.LastIndexOf(")") - cmbVisitante.Text.IndexOf("(") - 1)
                    '.oFuncionariopId = cmbFuncionario.Text.Substring(cmbFuncionario.Text.IndexOf("(") + 1, cmbFuncionario.Text.LastIndexOf(")") - cmbFuncionario.Text.IndexOf("(") - 1)
                    '.oSetorpId = cmbSetor.Text.Substring(cmbSetor.Text.IndexOf("(") + 1, cmbSetor.Text.LastIndexOf(")") - cmbSetor.Text.IndexOf("(") - 1)
                    '.oEmpresapId = cmbEmpresa.Text.Substring(cmbEmpresa.Text.IndexOf("(") + 1, cmbEmpresa.Text.LastIndexOf(")") - cmbEmpresa.Text.IndexOf("(") - 1)
                    '.Save()
                End With


            End If


            InicializaForm()
            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()

            limparCamposPesquisa()


        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode

            If AppUtils.exMsgHasTag(msgEx) Then
                ''ACHOU TAG DELIMITADA COM [] ?
                ''VAI PROCURAR O CONTROLE COM NOME EQUIVALENTE PARA SETAR ERRO E MENSAGEM ESPECÍFICA A ESTE CONTROLE

                ''PRÉ-REQUISITO NOMENCLATURA DOS CONTROLES:
                ''ASPxPageControl1 - nome fixo
                ''ASPxFormLayoutN - nome dos ASPxFormLayout dentro de cada tab page do ASPxPageControl1, onde N = tab index de sua respectiva tab

                Dim nomeControle = resolveNomeControleCadastro(parseExMsg(msgEx, "name"))
                Dim boolAchouControle As Boolean = False

                For i = 1 To ASPxPageControl1.TabPages.Count - 1
                    ASPxPageControl1.ActiveTabIndex = i

                    Dim ctrl As System.Web.UI.Control = AppUtils.FindControlRecursive(AppUtils.FindControlRecursive(Me, "ASPxFormLayout" & i.ToString), nomeControle)
                    If ctrl IsNot Nothing Then
                        DirectCast(ctrl, DevExpress.Web.ASPxEdit).IsValid = False
                        DirectCast(ctrl, DevExpress.Web.ASPxEdit).ErrorText = AppUtils.parseExMsg(msgEx)
                        boolAchouControle = True
                        Exit For
                    End If
                Next

                If Not boolAchouControle Then
                    ASPxPageControl1.ActiveTabIndex = 1
                    litMsgGenerica.Text = msgEx
                End If
            Else
                litMsgGenerica.Text = msgEx
            End If
        Finally
            If (Not (scope) Is Nothing) Then
                scope.Dispose()
            End If
        End Try
    End Sub

    Private Function resolveNomeControleCadastro(tagControleFromPartial As String) As String
        '"TRADUÇÃO" DOS NOMES DE CONTROLES  ESPECÍFICOS
        Dim dictControles As New Dictionary(Of String, String)

        dictControles.Add("F" & "cmbVisitante", "cmbVisitante")
        dictControles.Add("F" & "cmbFuncionario", "cmbFuncionario")
        dictControles.Add("F" & "cmbSetor", "cmbSetor")
        dictControles.Add("F" & "cmbEmpresa", "cmbEmpresa")
        dictControles.Add("F" & "TxtDATAVISITA", "TxtDATAVISITA")



        If dictControles.ContainsKey(tagControleFromPartial) Then
            resolveNomeControleCadastro = dictControles.Item(tagControleFromPartial)
        Else
            resolveNomeControleCadastro = tagControleFromPartial
        End If
    End Function
    Public Sub limparCamposPesquisa()
        'txtdescricaoPesq.Text = ""
    End Sub

#Region "btnPesquisarTratamento"
    'Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles buttonAplicarFiltro.Click
    '    gridPesquisa.PageIndex = 0
    '    gridPesquisa.DataBind()

    '    ASPxPopupControl1.ShowOnPageLoad = False
    'End Sub

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        'Dim VwGrid As List(Of S5T.VisitaViewGrid) = Nothing
        ''VwGrid = S5T.VisitaMovCollection.LoadAllViewGrid.OrderByDescending(Function(x) x.pDataVisita)
        'VwGrid = S5T.VisitaMovCollection.LoadAllViewGrid

        Dim OrdemCarregamento As New List(Of lwOrdemCarregamento)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdDadosOrdemCarregamento As New OracleCommand("SELECT decode(A1_NOME,null, RPAD(' ', 40), A1_NOME || ' * shirinkado') CLIENTE,
                C6_PRODUTO PRODUTO, B1_DESC DESCRICAO,
                SUM(C6_UNSVEN) QUANTIDADE, ROUND(SUM(C6_UNSVEN * B1_M3), 2) B1_M3,
                ROUND(SUM(
                CASE
                    WHEN B1_GRUPO  = '3' AND C6_PRODUTO NOT IN ('315500', '310000', '325001') THEN 
                        C6_QTDBRU
                    ELSE 
                        C6_UNSVEN * B1_PESBRU
                    END), 2) PESO,
                SUM(C6_QTDPCT) FORMAS
                FROM SC5010 SC5
                INNER JOIN SC6010 SC6 ON  C6_FILIAL = C5_FILIAL
                AND C6_NUM         = C5_NUM
                AND SC6.D_E_L_E_T_ = ' '
                INNER JOIN SB1010 SB1
                ON  B1_FILIAL          = C6_FILIAL
                AND B1_COD         = C6_PRODUTO
                AND SB1.D_E_L_E_T_ = ' '
                LEFT JOIN SA1010 SA1
                ON  A1_FILIAL          = C5_FILIAL
                AND A1_COD         = DECODE(C6_SHIRINK, 'N', RPAD(' ', 6), C5_CLIENTE)
                AND SA1.D_E_L_E_T_ = ' '
                WHERE 0=0
                and C5_AGREG BETWEEN '71006SC0' AND '71006SC0'
                AND C5_FILIAL      = '01'
                AND SC5.D_E_L_E_T_ = ' '
                GROUP BY  decode(A1_NOME,null, RPAD(' ', 40), A1_NOME || ' * shirinkado'),
                C6_PRODUTO,
                B1_DESC
                ORDER BY 1,
                C6_PRODUTO ", conn) With {.CommandType = CommandType.Text}
        Dim drDadosOrdemCarregamento As OracleDataReader = Nothing
        Dim i As Integer = 1
        Try
            drDadosOrdemCarregamento = cmdDadosOrdemCarregamento.ExecuteReader()
            If drDadosOrdemCarregamento.HasRows Then
                Do While drDadosOrdemCarregamento.Read
                    Dim objDadosOrdemCarregamento = New lwOrdemCarregamento


                    objDadosOrdemCarregamento.pId = i

                    objDadosOrdemCarregamento.pClienteDescricao = AppUtils.Nvl(drDadosOrdemCarregamento.Item("CLIENTE"), "")
                    objDadosOrdemCarregamento.pProdutoCodigo = AppUtils.Nvl(drDadosOrdemCarregamento.Item("PRODUTO"), "")
                    objDadosOrdemCarregamento.pProdutoDescricao = AppUtils.Nvl(drDadosOrdemCarregamento.Item("DESCRICAO"), "")
                    objDadosOrdemCarregamento.pQuantidade = AppUtils.Nvl(drDadosOrdemCarregamento.Item("QUANTIDADE"), 0)
                    objDadosOrdemCarregamento.pM3 = AppUtils.Nvl(drDadosOrdemCarregamento.Item("B1_M3"), 0)
                    objDadosOrdemCarregamento.pPeso = AppUtils.Nvl(drDadosOrdemCarregamento.Item("PESO"), 0)
                    objDadosOrdemCarregamento.pFormas = AppUtils.Nvl(drDadosOrdemCarregamento.Item("FORMAS"), 0)

                    OrdemCarregamento.Add(objDadosOrdemCarregamento)

                    i += 1
                Loop
                drDadosOrdemCarregamento.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drDadosOrdemCarregamento) Is Nothing) Then
                drDadosOrdemCarregamento.Dispose()
            End If
        End Try
        'gridPesquisa.DataSource = VwGrid.OrderByDescending(Function(x) x.pDataVisita)


        gridPesquisa.DataSource = OrdemCarregamento

    End Sub


#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs)
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Alteracao Then

                Dim obj As S5T.VisitaMov = S5T.VisitaMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))
                obj.Delete()

            End If

            InicializaForm()

            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()

            limparCamposPesquisa()

        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode

            If AppUtils.exMsgHasTag(msgEx) Then

                'Dim nomeControle = resolveNomeControleCadastro(parseExMsg(msgEx, "name"), IIf(rbPFPJ.SelectedIndex = 0, "F", "J"))
                Dim boolAchouControle As Boolean = False

                For i = 1 To ASPxPageControl1.TabPages.Count - 1
                    ASPxPageControl1.ActiveTabIndex = i

                    Dim ctrl As System.Web.UI.Control = AppUtils.FindControlRecursive(AppUtils.FindControlRecursive(Me, "ASPxFormLayout" & i.ToString), nomeControle)
                    If ctrl IsNot Nothing Then
                        DirectCast(ctrl, DevExpress.Web.ASPxEdit).IsValid = False
                        DirectCast(ctrl, DevExpress.Web.ASPxEdit).ErrorText = AppUtils.parseExMsg(msgEx)
                        boolAchouControle = True
                        Exit For
                    End If
                Next

                If Not boolAchouControle Then
                    ASPxPageControl1.ActiveTabIndex = 1
                    litMsgGenerica.Text = msgEx
                End If
            Else
                litMsgGenerica.Text = msgEx
            End If
        Finally
            If (Not (scope) Is Nothing) Then
                scope.Dispose()
            End If
        End Try
    End Sub



    Protected Sub GridLOTES_DataBinding(sender As Object, e As EventArgs) Handles GridLOTES.DataBinding

        Dim LotesLiberados As New List(Of lwLotesLiberados)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdLotesLiberados As New OracleCommand(String.Format("SELECT B8_FILIAL,
                        B8_PRODUTO,
                        B1_DESC,
                        B8_LOTECTL,
                        substr(B8_DATA,7,2) || '/' || substr(B8_DATA,5,2) || '/' || substr(B8_DATA,1,4) as B8_DATA,
                        substr(B8_DTVALID,7,2) || '/' || substr(B8_DTVALID,5,2) || '/' || substr(B8_DTVALID,1,4) as B8_DTVALID,
                        B1_GRUPO,
                        ROUND(CASE
                        WHEN B1_GRUPO = '3'
                        AND B8_PRODUTO NOT IN ('315500', '310000', '325001')
                        THEN B8_SALDO / B1_ZZPESOP
                        ELSE
                        CASE
                        WHEN B1_TIPCONV = 'D'
                        THEN B8_SALDO / B1_CONV
                        WHEN B1_TIPCONV = 'M'
                        THEN B8_SALDO * B1_CONV
                        ELSE 0
                        END
                        END, 2) AS B8_SALDO
                        FROM SB8010 SB8
                        INNER JOIN SB1010 SB1
                        ON B1_COD = B8_PRODUTO
                        AND B1_FILIAL = '01'
                        AND SB1.D_E_L_E_T_ = ' '
                        WHERE B1_TIPO = 'PA'
                        AND
                        (
                        B8_SALDO - B8_EMPENHO
                        )
                        > 0
                        AND B8_FILIAL = '01'
                        AND SB8.D_E_L_E_T_ = ' '
                        AND RTRIM(LTRIM(B8_PRODUTO)) LIKE '{0}'
                        ORDER BY B8_FILIAL,
                        B8_PRODUTO,
                        B8_DTVALID,
                        B8_LOTECTL", gridPesquisa.GetSelectedFieldValues("pProdutoCodigo")(0).ToString.Trim), conn) With {.CommandType = CommandType.Text}
        Dim drDadosLotesLiberados As OracleDataReader = Nothing
        Dim i As Integer = 1
        Try
            drDadosLotesLiberados = cmdLotesLiberados.ExecuteReader()
            If drDadosLotesLiberados.HasRows Then
                Do While drDadosLotesLiberados.Read
                    Dim objDados = New lwLotesLiberados

                    objDados.pId = i
                    objDados.pProdutoCodigo = AppUtils.Nvl(drDadosLotesLiberados.Item("B8_PRODUTO"), "")
                    objDados.pDataValidade = AppUtils.Nvl(drDadosLotesLiberados.Item("B8_DTVALID"), "")
                    objDados.pLote = AppUtils.Nvl(drDadosLotesLiberados.Item("B8_LOTECTL"), "")
                    objDados.pQuantidade = AppUtils.Nvl(drDadosLotesLiberados.Item("B8_SALDO"), 0)

                    LotesLiberados.Add(objDados)

                    i += 1
                Loop
                drDadosLotesLiberados.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drDadosLotesLiberados) Is Nothing) Then
                drDadosLotesLiberados.Dispose()
            End If
        End Try

        GridLOTES.DataSource = LotesLiberados

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        lblQtdProdACarregar.Text = CDbl(lblQtdProdACarregar.Text) - CDbl(txtQTD_LOTE.Text)
        txtLOTE.Text = ""
        txtQTD_LOTE.Text = ""
    End Sub


End Class


