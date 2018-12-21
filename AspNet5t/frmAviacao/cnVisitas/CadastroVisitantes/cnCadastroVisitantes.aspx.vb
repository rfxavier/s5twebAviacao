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

Imports System.Web.Services
Imports System.Security
Imports DevExpress.XtraEditors.Controls

Public Class cnCadastroVisitantes
    Inherits System.Web.UI.Page
    Dim obj As S5T.VisitanteVisita = Nothing
    Dim objCidade As S5T.CidadeCollection


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If


        'If Not Me.IsPostBack Then
        '    If Request.InputStream.Length > 0 Then
        '        Using reader As New StreamReader(Request.InputStream)
        '            Dim hexString As String = Server.UrlEncode(reader.ReadToEnd())
        '            Dim imageName As String = DateTime.Now.ToString("dd-MM-yy hh-mm-ss")
        '            Dim imagePath As String = String.Format("~/Captures/{0}.png", imageName)
        '            File.WriteAllBytes(Server.MapPath(imagePath), ConvertHexToBytes(hexString))
        '            Session("CapturedImage") = ResolveUrl(imagePath)
        '        End Using
        '    End If
        'End If


        If Not IsPostBack Then
            InicializaForm()
        End If

        '''CARREGA COMBO CIDADE
        'objCidade = S5T.CidadeCollection.LoadAll
        'cmbCidade.Items.Clear()

        'If objCidade IsNot Nothing Then
        '    For Each o In objCidade.ToList.OrderBy(Function(x) x.pNome)
        '        cmbCidade.Items.Add(o.pNome, o.pId)
        '    Next
        'End If

        ''COMBO SEXO
        cmbSexo.Items.Clear()
        cmbSexo.Items.Add("FEMININO", "FEMININO")
        cmbSexo.Items.Add("MASCULINO", "MASCULINO")

        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()


    End Sub


    Private Shared Function ConvertHexToBytes(hex As String) As Byte()
        Dim bytes As Byte() = New Byte(hex.Length / 2 - 1) {}
        For i As Integer = 0 To hex.Length - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return bytes
    End Function

    <WebMethod(EnableSession:=True)>
    Public Shared Function GetCapturedImage() As String
        Dim url As String = HttpContext.Current.Session("CapturedImage").ToString()
        HttpContext.Current.Session("CapturedImage") = Nothing
        Return url
    End Function


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

        ImgFoto.ImageUrl = "~/ImagensWebCam/semfoto.jpg"

    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")
        PreencheFormComId(gridPesquisa.GetSelectedFieldValues("pId")(0).ToString)
    End Sub

    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        obj = S5T.VisitanteVisita.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId
            TxtNome.Text = obj.pNome
            TxtHABILITACAO.Text = obj.pHabilitacao
            TxtCPF.Text = obj.pCpfCnpj
            TxtRG.Text = obj.pRg
            TxtTELEFONE.Text = obj.pTelefoneFixo
            TxtTELEFONECEL.Text = obj.pTelefoneCelular
            TxtENDERECO.Text = obj.pEnderLogradouro
            TxtNUMERO.Text = obj.pEnderNumero
            TxtCOMPLEMENTO.Text = obj.pEnderComplemento
            TxtBAIRRO.Text = obj.pEnderBairro
            TxtCEP.Text = obj.pEnderCep

            If obj.pSexo IsNot Nothing Then
                cmbSexo.SelectedIndex = cmbSexo.Items.IndexOf(cmbSexo.Items.FindByText(obj.pSexo))
            End If

            If obj.oCidade IsNot Nothing Then
                'cmbCidade.SelectedIndex = cmbCidade.Items.IndexOf(cmbCidade.Items.FindByText(obj.oCidade.pNome))
                'Dim result = cmbCidade.Items.Cast(Of ComboBoxItem)().Where(Function(i) (Integer.Parse(i.Value.ToString())) = obj.oCidadepId)
                cmbCidade.Value = obj.oCidade.pNome & " (" & obj.oCidadepId & ")"

            End If

            


            ImgFoto.ImageUrl = "~/ImagensWebCam/" & obj.pId & ".jpg"

            'If ImgFoto.Height.Value = 0 Then
            '    ImgFoto.ImageUrl = "~/ImagensWebCam/semFoto.jpg"
            'End If
            'ASPxPopupWebCam.ShowOnPageLoad = True
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
    Protected Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        TxtNome.Text = ""
        TxtHABILITACAO.Text = ""
        TxtCPF.Text = ""
        TxtRG.Text = ""
        TxtTELEFONE.Text = ""
        TxtTELEFONECEL.Text = ""
        TxtENDERECO.Text = ""
        TxtNUMERO.Text = ""
        TxtCOMPLEMENTO.Text = ""
        TxtBAIRRO.Text = ""
        TxtCEP.Text = ""

        cmbSexo.SelectedIndex = 0
        cmbCidade.SelectedIndex = 0

        InicializaForm()

        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()
    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Insercao Then
                ''É INSERÇÃO
                Dim objVisitante As New S5T.VisitanteVisita
                With objVisitante

                    .pNome = TxtNome.Text
                    .pHabilitacao = TxtHABILITACAO.Text
                    .pCpfCnpj = TxtCPF.Text
                    .pRg = TxtRG.Text
                    .pTelefoneFixo = TxtTELEFONE.Text
                    .pTelefoneCelular = TxtTELEFONECEL.Text
                    .pEnderLogradouro = TxtENDERECO.Text
                    .pEnderNumero = TxtNUMERO.Text
                    .pEnderComplemento = TxtCOMPLEMENTO.Text
                    .pEnderBairro = TxtBAIRRO.Text
                    .pEnderCep = TxtCEP.Text

                    .pSexo = IIf(cmbSexo.Value = Nothing, Nothing, cmbSexo.Value)
                    .oCidadepId = cmbCidade.Text.Substring(cmbCidade.Text.IndexOf("(") + 1, cmbCidade.Text.LastIndexOf(")") - cmbCidade.Text.IndexOf("(") - 1)

                    .Save()
                End With


            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim objVisitante As S5T.VisitanteVisita = S5T.VisitanteVisita.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                With objVisitante
                    .pNome = TxtNome.Text
                    .pHabilitacao = TxtHABILITACAO.Text
                    .pCpfCnpj = TxtCPF.Text
                    .pRg = TxtRG.Text
                    .pTelefoneFixo = TxtTELEFONE.Text
                    .pTelefoneCelular = TxtTELEFONECEL.Text
                    .pEnderLogradouro = TxtENDERECO.Text
                    .pEnderNumero = TxtNUMERO.Text
                    .pEnderComplemento = TxtCOMPLEMENTO.Text
                    .pEnderBairro = TxtBAIRRO.Text
                    .pEnderCep = TxtCEP.Text

                    .pSexo = IIf(cmbSexo.Value = Nothing, Nothing, cmbSexo.Value)
                    .oCidadepId = cmbCidade.Text.Substring(cmbCidade.Text.IndexOf("(") + 1, cmbCidade.Text.LastIndexOf(")") - cmbCidade.Text.IndexOf("(") - 1)
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

        dictControles.Add("F" & "TxtCpf", "txtCPF")
        dictControles.Add("F" & "TxtNome", "TxtNome")
        dictControles.Add("F" & "TxtTELEFONECEL", "TxtTELEFONECEL")

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
        Dim VwGrid As List(Of S5T.VisitanteVisitaViewGrid) = Nothing

        VwGrid = S5T.VisitanteVisitaCollection.LoadAllViewGrid
        gridPesquisa.DataSource = VwGrid.OrderBy(Function(x) x.pNome)

    End Sub


#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Alteracao Then

                Dim obj As S5T.VisitanteVisita = S5T.VisitanteVisita.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))
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

    Protected Sub ASPxComboBox_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT RTRIM(LTRIM(str(pId))) AS pId, pNome FROM (select RTRIM(LTRIM(str(pId))) as pId, pNome,  row_number() over(order by t.pNome) as rn from Cidade as t where ((pNome + ' ' + RTRIM(LTRIM(str(pId))) ) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub ASPxComboBox_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
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



    'Private Sub btnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click

    '    Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("S5TWebCam")

    '    For Each p As Process In pProcess
    '        p.Kill()
    '    Next

    '    'Dim PWeb = Process.Start("C:\4TWebCam\S5TWebCam.exe", "c:\inetpub\wwwroot\biaviacao\ImagensWebCam\ " & gridPesquisa.GetSelectedFieldValues("pId")(0))

    '    Dim PWeb = New Process
    '    Dim username As String = "t-4tsistemas"
    '    Dim password As SecureString = ConvertToSecureString("Manager4ts")
    '    Dim domain As String = "aviacao"

    '    PWeb.StartInfo.Verb = "runas"
    '    PWeb.StartInfo.LoadUserProfile = True
    '    PWeb.StartInfo.WorkingDirectory = "C:\\4TWebCam"
    '    PWeb.StartInfo.FileName = "C:\\4TWebCam\\S5TWebCam.exe"
    '    PWeb.StartInfo.Arguments = "c:\inetpub\wwwroot\biaviacao\ImagensWebCam\ " & gridPesquisa.GetSelectedFieldValues("pId")(0)
    '    PWeb.StartInfo.UseShellExecute = False
    '    PWeb.StartInfo.UserName = username
    '    PWeb.StartInfo.Password = password
    '    PWeb.StartInfo.Domain = domain



    '    PWeb.Start()

    '    While Not PWeb.HasExited
    '        'só pra aguardar tirar a foto ou cancelar
    '    End While

    '    Dim Id As Integer = gridPesquisa.GetSelectedFieldValues("pId")(0)
    '    ImgFoto.ImageUrl = "~/ImagensWebCam/" & Id & ".jpg"

    '    If ImgFoto.Height.Value = 0 Then
    '        ImgFoto.ImageUrl = "~/ImagensWebCam/semFoto.jpg"
    '    End If

    'End Sub

    'Function ConvertToSecureString(ByVal str As String)
    '    Dim password As New SecureString
    '    For Each c As Char In str.ToCharArray
    '        password.AppendChar(c)
    '    Next
    '    Return password
    'End Function
End Class


