Imports DevExpress.Web
Imports CodeFluent.Runtime
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Owin
Imports S5T
Imports DevExpress.Export
'Imports DevExpress.XtraPrinting
Imports System.IO
'Imports Winnovative

Imports Microsoft.Owin.Security


Public Class cnEstoqueMaturacao
    Inherits System.Web.UI.Page
    Dim obj As S5T.MovimentacaoLote = Nothing
    Dim objProduto As S5T.ProdutoCollection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If

        If Not IsPostBack Then
            InicializaForm()
            cbFinalizado.Checked = False

        End If
        ''CARREGA COMBO MOTORISTA
        objProduto = S5T.ProdutoCollection.LoadAll
        CmbProduto.Items.Clear()
        CmbProdutoPesq.Items.Clear()

        If objProduto IsNot Nothing Then
            For Each o In objProduto.ToList
                CmbProduto.Items.Add(o.pDescricao, o.pId)
                CmbProdutoPesq.Items.Add(o.pDescricao, o.pId)
            Next
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

        gridDetalhe.Visible = False

        mskDatFabricacao.Enabled = True
        txtLote.Enabled = True
        CmbProduto.Enabled = True


    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")

        Dim VwGrid As List(Of S5T.MovimentacaoLoteViewGrid) = Nothing

        VwGrid = S5T.MovimentacaoLoteCollection.LoadAllViewGrid

        If cbFinalizadoPesq.Checked = False Then
            'nao mostrar os finalizados
            VwGrid = VwGrid.FindAll(Function(x) x.pProdutoId = gridPesquisa.GetSelectedFieldValues("pProdutoId")(0).ToString And x.pFinalizado = "N").OrderByDescending(Function(x) x.pDataMaturacao).ToList
        Else
            VwGrid = VwGrid.FindAll(Function(x) x.pProdutoId = gridPesquisa.GetSelectedFieldValues("pProdutoId")(0).ToString).OrderByDescending(Function(x) x.pDataMaturacao).ToList
        End If


        gridDetalhe.DataSource = VwGrid
        gridDetalhe.DataBind()

        gridPesquisa.Visible = False
        gridDetalhe.Visible = True

    End Sub

    Protected Sub gridDetalhe_SelectionChanged(sender As Object, e As EventArgs) Handles gridDetalhe.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")
        PreencheFormComId(gridDetalhe.GetSelectedFieldValues("pId")(0).ToString)

    End Sub


    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        obj = S5T.MovimentacaoLote.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId
            mskDatFabricacao.Value = obj.pDataFabricacao


            If obj.oProduto IsNot Nothing Then
                CmbProduto.SelectedIndex = CmbProduto.Items.IndexOf(CmbProduto.Items.FindByText(obj.oProduto.pDescricao))
            End If

            txtLote.Text = obj.pLote
            txtFormas.Text = obj.pFormas

            If obj.pFinalizado = "S" Then
                cbFinalizado.Checked = True
            Else
                cbFinalizado.Checked = False
            End If

        End If

        mskDatFabricacao.Enabled = False
        txtLote.Enabled = False
        CmbProduto.Enabled = False


        gridPesquisa.Visible = False
        gridDetalhe.Visible = True
    End Sub

    Protected Sub btnDesistir_Click(sender As Object, e As EventArgs) Handles btnDesistir.Click
        InicializaForm()
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()
        gridPesquisa.Visible = True
        gridDetalhe.DataSource = Nothing
        gridDetalhe.Visible = False

        limparCamposPesquisa()
    End Sub

#Region "tipoOperacaoTratamento"
    Enum tpInsAlt
        Insercao
        Alteracao
    End Enum

    Private Function tipoOperacao() As tpInsAlt
        If gridDetalhe.GetSelectedFieldValues("pId").Count = 0 Then
            tipoOperacao = tpInsAlt.Insercao
        Else
            tipoOperacao = tpInsAlt.Alteracao
        End If
    End Function
#End Region

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Insercao Then
                ''É INSERÇÃO
                Dim objMovimentacaoLote As New S5T.MovimentacaoLote
                With objMovimentacaoLote
                    .pDataFabricacao = IIf(mskDatFabricacao.Text = "", Nothing, mskDatFabricacao.Text)
                    Dim diasMaturacao As Integer = S5T.Produto.LoadBypId(CmbProduto.Value).pDiasMaturacao
                    .pDataMaturacao = CDate(mskDatFabricacao.Text).AddDays(diasMaturacao)
                    .pLote = UCase(txtLote.Text)
                    .pFormas = txtFormas.Text
                    .oProdutopId = IIf(CmbProduto.Value = Nothing, Nothing, CmbProduto.Value)
                    .pFinalizado = IIf(cbFinalizado.Checked = True, "S", "N")
                    .Save()
                End With


            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim obj As S5T.MovimentacaoLote = S5T.MovimentacaoLote.LoadByEntityKey(gridDetalhe.GetSelectedFieldValues("pId")(0))

                With obj
                    .pFormas = txtFormas.Text
                    .pFinalizado = IIf(cbFinalizado.Checked = True, "S", "N")
                    .Save()
                End With

            End If

            InicializaForm()
            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()
            gridDetalhe.Visible = False


            limparCamposPesquisa()


        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode

            If AppUtils.exMsgHasTag(msgEx) Then
                ''ACHOU TAG DELIMITADA COM [] ?
                ''VAI PROCURAR O CONTROLE COM NOME EQUIVALENTE PARA SETAR ERRO E MENSAGEM ESPECÍFICA A ESTE CONTROLE

                ''PRÉ-REQUISITO NOMENCLATURA DOS CONTROLES:
                ''ASPxPageControl1 - nome fixo
                ''ASPxFormLayoutN - nome dos ASPxFormLayout dentro de cada tab page do ASPxPageControl1, onde N = tab index de sua respectiva tab

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
    Public Sub limparCamposPesquisa()
        mskDatFabFinPesq.Text = ""
        mskDatFabIniPesq.Text = ""
        mskDatMatFinPesq.Text = ""
        mskDatMatIniPesq.Text = ""
        CmbProdutoPesq.Text = ""
        cbFinalizadoPesq.Checked = False

        mskDatFabricacao.Enabled = True
        txtLote.Enabled = True
        CmbProduto.Enabled = True
    End Sub

#Region "btnPesquisarTratamento"
    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles buttonAplicarFiltro.Click
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()
        gridDetalhe.Visible = False

        ASPxPopupControl1.ShowOnPageLoad = False
    End Sub

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        Dim VwGrid As List(Of S5T.MovimentacaoLoteViewGrid) = Nothing
        Dim parDatFabIniPesq As String
        Dim parDatFabFinPesq As String

        If mskDatFabIniPesq.Text <> "" Then
            parDatFabIniPesq = Format(CDate(mskDatFabIniPesq.Text), "yyyy-MM-dd").ToString
        End If
        If mskDatFabFinPesq.Text <> "" Then
            parDatFabFinPesq = Format(CDate(mskDatFabFinPesq.Text), "yyyy-MM-dd").ToString
        End If

        Dim parDatMatIniPesq As String
        Dim parDatMatFinPesq As String

        If mskDatMatIniPesq.Text <> "" Then
            parDatMatIniPesq = Format(CDate(mskDatMatIniPesq.Text), "yyyy-MM-dd").ToString
        End If
        If mskDatmatFinPesq.Text <> "" Then
            parDatMatFinPesq = Format(CDate(mskDatMatFinPesq.Text), "yyyy-MM-dd").ToString
        End If



        VwGrid = S5T.MovimentacaoLote.LoadViewParametros(IIf(mskDatFabIniPesq.Text = "", Nothing, parDatFabIniPesq),
                                                       IIf(mskDatFabFinPesq.Text = "", Nothing, parDatFabFinPesq),
                                                       IIf(mskDatMatIniPesq.Text = "", Nothing, parDatMatIniPesq),
                                                       IIf(mskDatMatFinPesq.Text = "", Nothing, parDatMatFinPesq),
                                                       CmbProdutoPesq.Value, IIf(cbFinalizadoPesq.Checked = True, "S", "N"), "pDataMaturacao asc")



        'VwGrid = S5T.MovimentacaoLoteCollection.LoadAllViewGrid

        Dim vwGridAgrupado As New List(Of MovimentacaoLoteViewGridAgrupado)

        If VwGrid IsNot Nothing Then

            For Each objvw In VwGrid
                If vwGridAgrupado.FindAll(Function(x) x.pProdutoId = objvw.pProdutoId).Count = 0 Then

                    Dim objvwagrupado As New MovimentacaoLoteViewGridAgrupado

                    With objvwagrupado
                        .pProdutoId = objvw.pProdutoId
                        .pProdutoDescricao = objvw.pProdutoDescricao
                        .pTotalFormas = VwGrid.FindAll(Function(x) x.pProdutoId = objvw.pProdutoId).Sum(Function(x) x.pFormas)
                        .pTotalFormasMaturada = VwGrid.FindAll(Function(x) x.pProdutoId = objvw.pProdutoId And x.pDataMaturacao <= Date.Now).Sum(Function(x) x.pFormas)
                    End With

                    vwGridAgrupado.Add(objvwagrupado)

                End If
            Next
        End If


        'If cbFinalizado.Checked = True Then
        '    If VwGrid IsNot Nothing Then
        '        VwGrid = VwGrid.FindAll(Function(x) x.pFinalizado = "S")
        '    End If
        'End If
        gridPesquisa.DataSource = vwGridAgrupado
        gridDetalhe.Visible = False
    End Sub

    Protected Sub gridDetalhe_DataBinding(sender As Object, e As EventArgs) Handles gridDetalhe.DataBinding
        'Dim VwGrid As List(Of S5T.MovimentacaoLoteViewGrid) = Nothing

        'VwGrid = S5T.MovimentacaoLoteCollection.LoadAllViewGrid
        'gridDetalhe.DataSource = VwGrid

    End Sub




#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Alteracao Then

                Dim obj As S5T.MovimentacaoLote = S5T.MovimentacaoLote.LoadByEntityKey(gridDetalhe.GetSelectedFieldValues("pId")(0))
                obj.Delete()

            End If

            InicializaForm()

            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()
            gridDetalhe.Visible = False
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

    Dim parDataSaidaAux As String = String.Empty
    Dim parDataRetornoAux As String = String.Empty
    'Protected Sub gv_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs) Handles gridPesquisa.HtmlDataCellPrepared

    '    If e.DataColumn.FieldName = "pSTATUS" Then
    '        If e.CellValue = "DISPONÍVEL" Then
    '            e.Cell.ForeColor = System.Drawing.Color.White
    '            e.Cell.BackColor = System.Drawing.Color.Green
    '        ElseIf e.CellValue = "EM VIAGEM" Then
    '            e.Cell.ForeColor = System.Drawing.Color.White
    '            e.Cell.BackColor = System.Drawing.Color.Red
    '        ElseIf e.CellValue = "VIAGEM CONCLUÍDA" Then
    '            e.Cell.ForeColor = System.Drawing.Color.Black
    '            e.Cell.BackColor = System.Drawing.Color.Yellow
    '        ElseIf e.CellValue = "EM MANUTENÇÃO" Then
    '            e.Cell.ForeColor = System.Drawing.Color.White
    '            e.Cell.BackColor = System.Drawing.Color.Blue
    '        ElseIf e.CellValue = "RETORNO" Then
    '            e.Cell.ForeColor = System.Drawing.Color.White
    '            e.Cell.BackColor = System.Drawing.Color.Brown
    '        End If
    '    End If

    'End Sub




End Class


