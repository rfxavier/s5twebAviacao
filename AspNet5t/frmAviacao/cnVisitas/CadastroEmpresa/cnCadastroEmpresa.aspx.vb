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

Public Class cnCadastroEmpresa
    Inherits System.Web.UI.Page
    Dim obj As S5T.EmpresaVisita = Nothing
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



    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")
        PreencheFormComId(gridPesquisa.GetSelectedFieldValues("pId")(0).ToString)
    End Sub

    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        obj = S5T.EmpresaVisita.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId
            TXTNOME.Text = obj.pNome

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

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Insercao Then
                ''É INSERÇÃO
                Dim obj As New S5T.EmpresaVisita
                With obj
                    .pNome = TXTNOME.Text
                    .Save()
                End With

            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim obj As S5T.EmpresaVisita = S5T.EmpresaVisita.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                With obj
                    .pNome = TXTNOME.Text
                    .Save()
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

        dictControles.Add("F" & "txtnome", "txtnome")

        If dictControles.ContainsKey(tagControleFromPartial) Then
            resolveNomeControleCadastro = dictControles.Item(tagControleFromPartial)
        Else
            resolveNomeControleCadastro = tagControleFromPartial
        End If
    End Function
    Public Sub limparCamposPesquisa()

        '
    End Sub

#Region "btnPesquisarTratamento"
    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles buttonAplicarFiltro.Click
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()

        ASPxPopupControl1.ShowOnPageLoad = False
    End Sub

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        Dim VwGrid As S5T.EmpresaVisitaCollection = Nothing
        'VwGrid = S5T.VisitaMovCollection.LoadAllViewGrid.OrderByDescending(Function(x) x.pDataVisita)
        VwGrid = S5T.EmpresaVisitaCollection.LoadAll
        gridPesquisa.DataSource = VwGrid.OrderBy(Function(x) x.pNome)

    End Sub


#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Alteracao Then

                Dim obj As S5T.EmpresaVisita = S5T.EmpresaVisita.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))
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

End Class


