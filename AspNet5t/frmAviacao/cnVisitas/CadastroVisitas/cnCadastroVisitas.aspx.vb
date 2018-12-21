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

Public Class cnCadastroVisitas
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

        '''CARREGA COMBO VISITANTE
        'objVisitante = S5T.VisitanteVisitaCollection.LoadAll
        'cmbVisitante.Items.Clear()

        'If objVisitante IsNot Nothing Then
        '    For Each o In objVisitante
        '        cmbVisitante.Items.Add(o.pNome, o.pId)
        '    Next
        'End If

        '''CARREGA COMBO FUNCIONARIO
        'objFuncionario = S5T.FuncionarioVisitaCollection.LoadAll
        'cmbFuncionario.Items.Clear()

        'If objFuncionario IsNot Nothing Then
        '    For Each o In objFuncionario
        '        cmbFuncionario.Items.Add(o.pNome, o.pId)
        '    Next
        'End If

        '''CARREGA COMBO SETOR
        'objSetor = S5T.SetorVisitaCollection.LoadAll
        'cmbSetor.Items.Clear()

        'If objSetor IsNot Nothing Then
        '    For Each o In objSetor
        '        cmbSetor.Items.Add(o.pNome, o.pId)
        '    Next
        'End If

        '''CARREGA COMBO EMPRESA
        'objEmpresa = S5T.EmpresaVisitaCollection.LoadAll
        'cmbEmpresa.Items.Clear()

        'If objEmpresa IsNot Nothing Then
        '    For Each o In objEmpresa
        '        cmbEmpresa.Items.Add(o.pNome, o.pId)
        '    Next
        'End If


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

        TxtDATAVISITA.Value = S5T.AppConfig.LoadDataHoraBD

    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")
        PreencheFormComId(gridPesquisa.GetSelectedFieldValues("pId")(0).ToString)
    End Sub

    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        obj = S5T.VisitaMov.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId
            TxtDATAVISITA.Value = obj.pDataVisita
            If obj.oVisitante IsNot Nothing Then
                'cmbVisitante.SelectedIndex = cmbVisitante.Items.IndexOf(cmbVisitante.Items.FindByText(obj.oVisitante.pNome))
                cmbVisitante.Value = obj.oVisitante.pNome & " (" & obj.oVisitantepId & ")"
            End If
            If obj.oSetor IsNot Nothing Then
                'cmbSetor.SelectedIndex = cmbSetor.Items.IndexOf(cmbSetor.Items.FindByText(obj.oSetor.pNome))
                cmbSetor.Value = obj.oSetor.pNome & " (" & obj.oSetorpId & ")"
            End If
            If obj.oFuncionario IsNot Nothing Then
                'cmbFuncionario.SelectedIndex = cmbFuncionario.Items.IndexOf(cmbFuncionario.Items.FindByText(obj.oFuncionario.pNome))
                cmbFuncionario.Value = obj.oFuncionario.pNome & " (" & obj.oFuncionariopId & ")"
            End If
            If obj.oEmpresa IsNot Nothing Then
                'cmbEmpresa.SelectedIndex = cmbEmpresa.Items.IndexOf(cmbEmpresa.Items.FindByText(obj.oEmpresa.pNome))
                cmbEmpresa.Value = obj.oEmpresa.pNome & " (" & obj.oEmpresapId & ")"
            End If

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
                Dim objVisitaMov As New S5T.VisitaMov
                With objVisitaMov
                    .pDataVisita = IIf(TxtDATAVISITA.Text = "", Nothing, TxtDATAVISITA.Text)
                    .oVisitantepId = cmbVisitante.Text.Substring(cmbVisitante.Text.IndexOf("(") + 1, cmbVisitante.Text.LastIndexOf(")") - cmbVisitante.Text.IndexOf("(") - 1)
                    .oFuncionariopId = cmbFuncionario.Text.Substring(cmbFuncionario.Text.IndexOf("(") + 1, cmbFuncionario.Text.LastIndexOf(")") - cmbFuncionario.Text.IndexOf("(") - 1)
                    .oSetorpId = cmbSetor.Text.Substring(cmbSetor.Text.IndexOf("(") + 1, cmbSetor.Text.LastIndexOf(")") - cmbSetor.Text.IndexOf("(") - 1)
                    .oEmpresapId = cmbEmpresa.Text.Substring(cmbEmpresa.Text.IndexOf("(") + 1, cmbEmpresa.Text.LastIndexOf(")") - cmbEmpresa.Text.IndexOf("(") - 1)
                    .Save()
                End With

                ImprimeEtiquetaVisita(objVisitaMov.pId)


            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim objVisitaMov As S5T.VisitaMov = S5T.VisitaMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                With objVisitaMov
                    .pDataVisita = IIf(TxtDATAVISITA.Text = "", Nothing, TxtDATAVISITA.Text)

                    .oVisitantepId = cmbVisitante.Text.Substring(cmbVisitante.Text.IndexOf("(") + 1, cmbVisitante.Text.LastIndexOf(")") - cmbVisitante.Text.IndexOf("(") - 1)
                    .oFuncionariopId = cmbFuncionario.Text.Substring(cmbFuncionario.Text.IndexOf("(") + 1, cmbFuncionario.Text.LastIndexOf(")") - cmbFuncionario.Text.IndexOf("(") - 1)
                    .oSetorpId = cmbSetor.Text.Substring(cmbSetor.Text.IndexOf("(") + 1, cmbSetor.Text.LastIndexOf(")") - cmbSetor.Text.IndexOf("(") - 1)
                    .oEmpresapId = cmbEmpresa.Text.Substring(cmbEmpresa.Text.IndexOf("(") + 1, cmbEmpresa.Text.LastIndexOf(")") - cmbEmpresa.Text.IndexOf("(") - 1)
                    .Save()
                End With

                ImprimeEtiquetaVisita(objVisitaMov.pId)

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
    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles buttonAplicarFiltro.Click
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()

        ASPxPopupControl1.ShowOnPageLoad = False
    End Sub

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        Dim VwGrid As List(Of S5T.VisitaViewGrid) = Nothing
        'VwGrid = S5T.VisitaMovCollection.LoadAllViewGrid.OrderByDescending(Function(x) x.pDataVisita)
        VwGrid = S5T.VisitaMovCollection.LoadAllViewGrid
        gridPesquisa.DataSource = VwGrid.OrderByDescending(Function(x) x.pDataVisita)

    End Sub


#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
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

    Public Sub ImprimeEtiquetaVisita(ByVal parIdVisitaMov As Long)

        'IMPRIMIR CHEQUE
        Dim oRelatorio As New repEtiqueta

        Dim VisitaMov = S5T.VisitaMovCollection.LoadByIdViewGrid(parIdVisitaMov)

        oRelatorio.DataSource = VisitaMov
        'oRelatorio.CreateDocument()

        '        FormReportDX.DocumentViewer1.DocumentSource = oRelatorio


        ASPxWebDocumentViewer1.OpenReport(oRelatorio)
        ASPxWebDocumentViewer1.Visible = True
        ASPxPopupControl2.ShowOnPageLoad = True

        'Dim repPrintTool As New ReportPrintTool(oRelatorio)
        ''this is not working
        'repPrintTool.AutoShowParametersPanel = False
        ''and this prints my report
        'repPrintTool.Print()


    End Sub
    Protected Sub cmbEmpresa_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pId))) AS pId, pNome FROM (select RTRIM(LTRIM(str(pId))) as pId, pNome,  row_number() over(order by t.pNome) as rn from EmpresaVisita as t where ((pNome + ' ' + RTRIM(LTRIM(str(pId))) ) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub cmbEmpresa_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
    End Sub
    Protected Sub cmbSetor_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pId))) AS pId, pNome FROM (select RTRIM(LTRIM(str(pId))) as pId, pNome,  row_number() over(order by t.pNome) as rn from SetorVisita as t where ((pNome + ' ' + RTRIM(LTRIM(str(pId))) ) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub cmbSetor_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
    End Sub
    Protected Sub cmbFuncionario_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pId))) AS pId, pNome FROM (select RTRIM(LTRIM(str(pId))) as pId, pNome,  row_number() over(order by t.pNome) as rn from FuncionarioVisita as t where ((pNome + ' ' + RTRIM(LTRIM(str(pId))) ) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub cmbFuncionario_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
    End Sub
    Protected Sub cmbVisitante_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pId))) AS pId, pNome FROM (select RTRIM(LTRIM(str(pId))) as pId, pNome,  row_number() over(order by t.pNome) as rn from VisitanteVisita as t where ((pNome + ' ' + RTRIM(LTRIM(str(pId))) ) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub cmbVisitante_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
        'Dim value As Long = 0
        'If e.Value Is Nothing Then
        '    Return
        'End If
        'Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        'SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pCodigo))) as pCodigo, pNome FROM cidade WHERE (pCodigo = @pCodigo)"

        'SqlDataSource1.SelectParameters.Clear()
        'SqlDataSource1.SelectParameters.Add("pCodigo", TypeCode.String, e.Value.ToString())
        'comboBox.DataSource = SqlDataSource1
        'comboBox.DataBind()
    End Sub


End Class


