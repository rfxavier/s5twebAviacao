Imports DevExpress.Web
Imports CodeFluent.Runtime
Imports Microsoft.AspNet.Identity
Imports S5T


Public Class cnTransporteMovimentacaoDeViagem
    Inherits System.Web.UI.Page
    Dim obj As S5T.AviacaoViagemMov = Nothing
    Dim objMotorista As S5T.AviacaoMotoristaCollection
    Dim objCaminhao As S5T.AviacaoCaminhaoCollection
    Dim objLocalLinha As S5T.AviacaoLocalLinhaCollection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If

        If Not IsPostBack Then
            InicializaForm()
            cbCaminhaoDisponivel.Checked = True

        End If
        ''CARREGA COMBO MOTORISTA
        objMotorista = S5T.AviacaoMotoristaCollection.LoadAll
        CmbMotorista.Items.Clear()
        CmbMotoristaPesq.Items.Clear()

        If objMotorista IsNot Nothing Then
            For Each o In objMotorista.ToList.FindAll(Function(x) x.sStatus = Status.Ativo).OrderBy(Function(x) x.pNOME_MOTORISTA)
                CmbMotorista.Items.Add(o.pNOME_MOTORISTA, o.pId)
                CmbMotoristaPesq.Items.Add(o.pNOME_MOTORISTA, o.pId)
            Next
        End If

        ''CARREGA COMBO CAMINHAO
        objCaminhao = S5T.AviacaoCaminhaoCollection.LoadAll
        CmbCaminhao.Items.Clear()
        CmbCaminhaoPesq.Items.Clear()

        If objCaminhao IsNot Nothing Then
            For Each o In objCaminhao.ToList.FindAll(Function(x) x.sStatus = Status.Ativo).OrderBy(Function(x) x.pPLACA)
                CmbCaminhao.Items.Add(o.pPLACA, o.pId)
                CmbCaminhaoPesq.Items.Add(o.pPLACA, o.pId)
            Next
        End If

        ''CARREGA COMBO LOCAL LINHA
        objLocalLinha = S5T.AviacaoLocalLinhaCollection.LoadAll
        'CmbLocalLinha.Items.Clear()
        'CmbLocalLinhaRetorno.Items.Clear()
        CmbLocalLinhaPesq.Items.Clear()

        Dim list As ASPxListBox = ASPxDropDownEdit1.FindControl("listBox")

        'If Not IsPostBack Then
        '    If objLocalLinha IsNot Nothing Then
        '        For Each o In objLocalLinha
        '            list.Items.Add(o.pDESCRICAO, o.pId)
        '        Next
        '    End If

        'End If


        If objLocalLinha IsNot Nothing Then
            For Each o In objLocalLinha.OrderBy(Function(x) x.pDESCRICAO)
                'CmbLocalLinha.Items.Add(o.pDESCRICAO, o.pId)
                'list.Items.Add(o.pDESCRICAO, o.pId)
                'CmbLocalLinhaRetorno.Items.Add(o.pDESCRICAO, o.pId)
                CmbLocalLinhaPesq.Items.Add(o.pDESCRICAO, o.pId)
            Next
        End If

        'Preenche combo do Dia Saída Pesquisa
        With CmbDiaSaidaPesq
            .Items.Add("Selecione", 10)
            .Items.Add("Segunda-feira", 1)
            .Items.Add("Terça-feira", 2)
            .Items.Add("Quarta-feira", 3)
            .Items.Add("Quinta-feira", 4)
            .Items.Add("Sexta-feira", 5)
            .Items.Add("Sabado", 6)
            .Items.Add("Domingo", 0)
        End With


        'preenche combo de pesquisa Veiculo
        Dim objVeiculo = S5T.AviacaoCaminhaoCollection.LoadAll
        If objVeiculo IsNot Nothing Then
            With CmbVeiculoPesq
                .Items.Add("Selecione", "")
                For Each objTipoVeiculo In objVeiculo.GroupBy(Function(x) x.pDESC_VEICULO).Select(Function(y) New With {.pDESC_VEICULO = y.Key}).ToList.OrderBy(function(x) x.pDESC_VEICULO)
                    .Items.Add(Trim(objTipoVeiculo.pDESC_VEICULO), Trim(objTipoVeiculo.pDESC_VEICULO))
                Next
            End With
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

        'MANDA IR PARA PRIMEIRA TAB DO ASPxPageControl
        ASPxPageControl1.ActiveTabIndex = 0




        'limpa campos de pesquisa
        CmbCaminhaoPesq.SelectedIndex = -1
        CmbDiaSaidaPesq.SelectedIndex = -1
        CmbLocalLinhaPesq.SelectedIndex = -1
        CmbMotoristaPesq.SelectedIndex = -1
        CmbVeiculoPesq.SelectedIndex = -1
        mskDatPrevFinPesq.Text = ""
        mskDatPrevIniPesq.Text = ""
        mskDatRetornoFinPesq.Text = ""
        mskDatRetornoIniPesq.Text = ""
        mskDatSaidaFinPesq.Text = ""
        mskDatSaidaIniPesq.Text = ""
        cbCaminhaoDisponivel.Checked = True


    End Sub

    Protected Sub gridPesquisa_SelectionChanged(sender As Object, e As EventArgs) Handles gridPesquisa.SelectionChanged
        ASPxPageControl1.ActiveTabPage = ASPxPageControl1.TabPages.FindByName("tabDados1")
        'ASPxPageControl1.ActiveTabIndex = 1
        PreencheFormComId(gridPesquisa.GetSelectedFieldValues("pId")(0).ToString)
    End Sub

    Private Sub PreencheFormComId(ByVal parId As Long)
        'PREENCHE O FORM COM OS DADOS APÓS O EVENTO gridPesquisa.SelectionChanged
        obj = S5T.AviacaoViagemMov.LoadByEntityKey(parId)

        If Not obj Is Nothing Then
            'lblId.Text = obj.pId
            mskDatPrev.Value = obj.pDATA_PREV_RETORNO
            mskDatRetorno.Value = obj.pDATA_RETORNO
            If obj.pDATA_SAIDA = Nothing Then
                mskDatSaida.Value = S5T.AppConfig.LoadDataHoraBD
            Else
                mskDatSaida.Value = obj.pDATA_SAIDA
            End If
            If obj.oAviacaoMotorista IsNot Nothing Then
                CmbMotorista.SelectedIndex = CmbMotorista.Items.IndexOf(CmbMotorista.Items.FindByText(obj.oAviacaoMotorista.pNOME_MOTORISTA))
            End If
            If obj.oAviacaoCaminhao IsNot Nothing Then
                CmbCaminhao.SelectedIndex = CmbCaminhao.Items.IndexOf(CmbCaminhao.Items.FindByText(obj.oAviacaoCaminhao.pPLACA))
            End If
            If obj.oAviacaoLocalLinhas IsNot Nothing Then
                'CmbLocalLinha.SelectedIndex = CmbLocalLinha.Items.IndexOf(CmbLocalLinha.Items.FindByText(obj.oAviacaoLocalLinha.pDESCRICAO))

                Dim list As ASPxListBox = ASPxDropDownEdit1.FindControl("listBox")

                Dim textAspxDropDown As String = String.Empty
                For Each listItem In list.Items
                    If obj.oAviacaoLocalLinhas.ToList.FindLast(Function(x) x.pId = listItem.value) IsNot Nothing Then
                        listItem.Selected = True
                        textAspxDropDown = textAspxDropDown & "/" & listItem.text
                    End If
                Next

                ASPxDropDownEdit1.Text = Mid(textAspxDropDown, 2)

            End If
            'If obj.oAviacaoLocalLinhaRetorno IsNot Nothing Then
            '    CmbLocalLinhaRetorno.SelectedIndex = CmbLocalLinhaRetorno.Items.IndexOf(CmbLocalLinhaRetorno.Items.FindByText(obj.oAviacaoLocalLinhaRetorno.pDESCRICAO))
            'End If
            If obj.oAviacaoLocalLinhasRetorno IsNot Nothing Then

                Dim list As ASPxListBox = ASPxDropDownEdit2.FindControl("listBoxRet")

                Dim textAspxDropDown As String = String.Empty
                For Each listItem In list.Items
                    If obj.oAviacaoLocalLinhasRetorno.ToList.FindLast(Function(x) x.pId = listItem.value) IsNot Nothing Then
                        listItem.Selected = True
                        textAspxDropDown = textAspxDropDown & "/" & listItem.text
                    End If
                Next

                ASPxDropDownEdit2.Text = Mid(textAspxDropDown, 2)

            End If



            If obj.pSTATUS = "EM MANUTENÇÃO" Then
                cbEmManutencao.Checked = True
                mskDatSaida.Value = Nothing
            Else
                cbEmManutencao.Checked = False
            End If

            If obj.pSTATUS = "RETORNO" Then
                mskDatRetorno.Value = S5T.AppConfig.LoadDataHoraBD
            End If
        End If
    End Sub

    Protected Sub btnDesistir_Click(sender As Object, e As EventArgs) Handles btnDesistir.Click
        InicializaForm()
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()
    End Sub

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

            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim obj As S5T.AviacaoViagemMov = S5T.AviacaoViagemMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                If cbEmManutencao.Checked = True Then
                    obj.pSTATUS = "EM MANUTENÇÃO"
                Else
                    obj.pDATA_SAIDA = IIf(mskDatSaida.Text = "", Nothing, mskDatSaida.Text)
                    obj.pDATA_PREV_RETORNO = IIf(mskDatPrev.Text = "", Nothing, mskDatPrev.Text)
                    obj.pDATA_RETORNO = IIf(mskDatRetorno.Text = "", Nothing, mskDatRetorno.Text)
                    obj.oAviacaoMotoristapId = IIf(CmbMotorista.Value = Nothing, Nothing, CmbMotorista.Value)
                    'obj.oAviacaoLocalLinhapId = CmbLocalLinha.Value

                    Dim list As ASPxListBox = ASPxDropDownEdit1.FindControl("listBox")

                    For Each objALC In S5T.AviacaoLocalLinhaCollection.LoadAll
                        obj.oAviacaoLocalLinhas.Remove(objALC)
                    Next

                    For Each listItem In list.SelectedItems
                        obj.oAviacaoLocalLinhas.Add(S5T.AviacaoLocalLinha.LoadBypId(listItem.Value))
                    Next


                    'Local Linhas Retorno
                    Dim listRet As ASPxListBox = ASPxDropDownEdit2.FindControl("listBoxRet")

                    For Each objALCRet In S5T.AviacaoLocalLinhaCollection.LoadAll
                        obj.oAviacaoLocalLinhasRetorno.Remove(objALCRet)
                    Next

                    For Each listItem In listRet.SelectedItems
                        obj.oAviacaoLocalLinhasRetorno.Add(S5T.AviacaoLocalLinha.LoadBypId(listItem.Value))
                    Next


                    'obj.oAviacaoLocalLinhaRetornopId = CmbLocalLinhaRetorno.Value
                    obj.pSTATUS = Nothing
                End If

                If CmbCaminhao.Text <> "" Then
                    Dim FinalDaPlaca = Mid(CmbCaminhao.Text, 7, 1)
                    Select Case FinalDaPlaca
                        Case "1", "2"
                            obj.pRODIZIO = "Segunda-feira"
                        Case "3", "4"
                            obj.pRODIZIO = "Terça-feira"
                        Case "5", "6"
                            obj.pRODIZIO = "Quarta-feira"
                        Case "7", "8"
                            obj.pRODIZIO = "Quinta-feira"
                        Case "9", "0"
                            obj.pRODIZIO = "Sexta-feira"
                        Case Else
                            obj.pRODIZIO = Nothing
                    End Select
                End If

                obj.Save()

            End If

            InicializaForm()

            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()

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



#Region "btnPesquisarTratamento"
    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles buttonAplicarFiltro.Click
        gridPesquisa.PageIndex = 0
        gridPesquisa.DataBind()

        ASPxPopupControl1.ShowOnPageLoad = False
    End Sub

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        Dim VwGrid As List(Of S5T.AviacaoViagemMovViewGrid) = Nothing
        Dim parDatSaidaIniPesq As String
        Dim parDatSaidaFinPesq As String

        If mskDatSaidaIniPesq.Text <> "" Then
            parDatSaidaIniPesq = Format(CDate(mskDatSaidaIniPesq.Text), "MM-dd-yyyy").ToString
        End If
        If mskDatSaidaFinPesq.Text <> "" Then
            parDatSaidaFinPesq = Format(CDate(mskDatSaidaFinPesq.Text), "MM-dd-yyyy").ToString
        End If

        Dim parDatPrevIniPesq As String
        Dim parDatPrevFinPesq As String

        If mskDatPrevIniPesq.Text <> "" Then
            parDatPrevIniPesq = Format(CDate(mskDatPrevIniPesq.Text), "MM-dd-yyyy").ToString
        End If
        If mskDatPrevFinPesq.Text <> "" Then
            parDatPrevFinPesq = Format(CDate(mskDatPrevFinPesq.Text), "MM-dd-yyyy").ToString
        End If
        'data deve vir com essa formatação
        Dim parDatRetIniPesq As String
        Dim parDatRetFinPesq As String

        If mskDatRetornoIniPesq.Text <> "" Then
            parDatRetIniPesq = Format(CDate(mskDatRetornoIniPesq.Text), "MM-dd-yyyy").ToString
        End If
        If mskDatRetornoFinPesq.Text <> "" Then
            parDatRetFinPesq = Format(CDate(mskDatRetornoFinPesq.Text), "MM-dd-yyyy").ToString
        End If

        VwGrid = S5T.AviacaoViagemMov.LoadByParametros(IIf(mskDatSaidaIniPesq.Text = "", Nothing, parDatSaidaIniPesq),
                                                       IIf(mskDatSaidaFinPesq.Text = "", Nothing, parDatSaidaFinPesq),
                                                       IIf(mskDatPrevIniPesq.Text = "", Nothing, parDatPrevIniPesq),
                                                       IIf(mskDatPrevFinPesq.Text = "", Nothing, parDatPrevFinPesq),
                                                       IIf(mskDatRetornoIniPesq.Text = "", Nothing, parDatRetIniPesq),
                                                       IIf(mskDatRetornoFinPesq.Text = "", Nothing, parDatRetFinPesq),
                                                       CmbCaminhaoPesq.Value, CmbMotoristaPesq.Value,
                                                       CmbLocalLinhaPesq.Text, IIf(cbCaminhaoDisponivel.Checked = True, "S", "N"), "pDATA_SAIDA DESC")

        If cbCaminhaoDisponivel.Checked = True Then
            If VwGrid IsNot Nothing Then
                VwGrid = VwGrid.FindAll(Function(x) x.pCAMINHAO_STATUS = Status.Ativo)
            End If
        End If

        If CmbDiaSaidaPesq.Value <> 10 And CmbDiaSaidaPesq.Value IsNot Nothing Then
            VwGrid = VwGrid.FindAll(Function(x) x.pDATA_SAIDA.DayOfWeek = CmbDiaSaidaPesq.Value)
        End If

        If CmbVeiculoPesq.Value <> "" Then
            VwGrid = VwGrid.FindAll(Function(x) Trim(x.pCAMINHAO_DESCRICAO) = Trim(CmbVeiculoPesq.Value))
        End If


        if VwGrid isnot nothing  then
            gridPesquisa.DataSource = VwGrid.ToList.OrderByDescending(Function(x) x.pDATA_SAIDA)
        else
            gridPesquisa.DataSource = VwGrid
        End If

    End Sub

#End Region
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim scope As System.Transactions.TransactionScope = Nothing
        Try
            Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
            scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)

            If tipoOperacao() = tpInsAlt.Alteracao Then

                Dim obj As S5T.AviacaoViagemMov = S5T.AviacaoViagemMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))
                'Dim obj As S5T.AviacaoViagemMov = S5T.AviacaoViagemMov.LoadByEntityKey(lblId.Text)
                obj.Delete()

            End If

            InicializaForm()

            scope.Complete()

            gridPesquisa.PageIndex = 0
            gridPesquisa.DataBind()

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
    Protected Sub gv_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs) Handles gridPesquisa.HtmlDataCellPrepared
        'If e.DataColumn.FieldName = "pDATA_SAIDA" Then
        '    parDataSaidaAux = e.CellValue
        'End If
        'If e.DataColumn.FieldName = "pDATA_RETORNO" Then
        '    parDataRetornoAux = e.CellValue
        'End If

        'If e.DataColumn.FieldName = "" Then
        '    If parDataSaidaAux = "00:00:00" Then
        '        e.Cell.ForeColor = System.Drawing.Color.White
        '        e.Cell.BackColor = System.Drawing.Color.Green
        '        e.Cell.Text = "DISPONÍVEL"
        '    ElseIf parDataSaidaAux <> "00:00:00" And parDataRetornoAux = "00:00:00" Then
        '        e.Cell.ForeColor = System.Drawing.Color.White
        '        e.Cell.BackColor = System.Drawing.Color.Red
        '        e.Cell.Text = "EM VIAGEM"
        '    ElseIf parDataSaidaAux <> "00:00:00" And parDataRetornoAux <> "00:00:00" Then
        '        e.Cell.ForeColor = System.Drawing.Color.Black
        '        e.Cell.BackColor = System.Drawing.Color.Yellow
        '        e.Cell.Text = "VIAGEM CONCLUIDA"
        '    End If
        'End If
        If e.DataColumn.FieldName = "pDATA_SAIDA" Then
            If Mid(e.CellValue, 1, 8) = "00:00:00" Then
                e.Cell.Text = ""
            End If
        End If

        If e.DataColumn.FieldName = "pDATA_PREV_RETORNO" Then
            If Mid(e.CellValue, 1, 8) = "00:00:00" Then
                e.Cell.Text = ""
            End If
        End If

        If e.DataColumn.FieldName = "pDATA_RETORNO" Then
            If Mid(e.CellValue, 1, 8) = "00:00:00" Then
                e.Cell.Text = ""
            End If
        End If

        If e.DataColumn.Caption = "Dia Saída" Then
            If Mid(e.CellValue, 1, 8) <> "00:00:00" Then
                e.Cell.Text = CDate(e.CellValue).ToString("dddd")
            Else
                e.Cell.Text = ""
            End If
        End If

        If e.DataColumn.FieldName = "pSTATUS" Then
            If e.CellValue = "DISPONÍVEL" Then
                e.Cell.ForeColor = System.Drawing.Color.White
                e.Cell.BackColor = System.Drawing.Color.Green
            ElseIf e.CellValue = "EM VIAGEM" Then
                e.Cell.ForeColor = System.Drawing.Color.White
                e.Cell.BackColor = System.Drawing.Color.Red
            ElseIf e.CellValue = "VIAGEM CONCLUÍDA" Then
                e.Cell.ForeColor = System.Drawing.Color.Black
                e.Cell.BackColor = System.Drawing.Color.Yellow
            ElseIf e.CellValue = "EM MANUTENÇÃO" Then
                e.Cell.ForeColor = System.Drawing.Color.White
                e.Cell.BackColor = System.Drawing.Color.Blue
            ElseIf e.CellValue = "RETORNO" Then
                e.Cell.ForeColor = System.Drawing.Color.White
                e.Cell.BackColor = System.Drawing.Color.Brown
            End If
        End If

    End Sub

    Protected Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click

        ''Response.ContentType = "application/pdf"
        ''Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf")
        ''Response.Cache.SetCacheability(HttpCacheability.NoCache)
        ''Dim sw As New StringWriter()
        ''Dim hw As New HtmlTextWriter(sw)
        ''Me.Page.RenderControl(hw)
        ''Dim sr As New StringReader(sw.ToString())
        ''Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        ''Dim htmlparser As New HTMLWorker(pdfDoc)
        ''PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
        ''pdfDoc.Open()
        ''htmlparser.Parse(sr)
        ''pdfDoc.Close()
        ''Response.Write(pdfDoc)
        ''Response.[End]()

        'Dim fileName As String = "PlanilhaViagemTransporte"

        ''Dim appPath As String = HttpContext.Current.Request.ApplicationPath
        ''Dim path As String = Server.MapPath(appPath & "/Test.pdf")
        ''Dim sw As New StringWriter()
        ''Dim hw As New HtmlTextWriter(sw)
        ''Me.RenderControl(hw)
        ''Dim output = New FileStream(path, FileMode.Create)
        ''Dim sr = New StringReader(sw.ToString())
        ''Dim pdfDoc As New iTextSharp.text.Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        ''Dim htmlparser As New HTMLWorker(pdfDoc)
        ''iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, output)
        ''pdfDoc.Open()

        ''htmlparser.Parse(sr)
        ''pdfDoc.Close()

        '' Create a HTML to PDF converter object with default settings
        'Dim htmlToPdfConverter As New HtmlToPdfConverter()

        '' Set license key received after purchase to use the converter in licensed mode
        '' Leave it not set to use the converter in demo mode
        ''htmlToPdfConverter.LicenseKey = "fvDh8eDx4fHg4P/h8eLg/+Dj/+jo6Og="
        'htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

        ''' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
        ''htmlToPdfConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)
        'htmlToPdfConverter.HtmlViewerWidth = Integer.Parse(1024)

        ''' Set HTML viewer height in pixels to convert the top part of a HTML page 
        ''' Leave it not set to convert the entire HTML
        ''If htmlViewerHeightTextBox.Text.Length > 0 Then
        ''    htmlToPdfConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
        ''End If

        ''' Set PDF page size which can be a predefined size like A4 or a custom size in points 
        ''' Leave it not set to have a default A4 PDF page
        ''htmlToPdfConverter.PdfDocumentOptions.PdfPageSize = SelectedPdfPageSize()

        ''' Set PDF page orientation to Portrait or Landscape
        ''' Leave it not set to have a default Portrait orientation for PDF page
        ''htmlToPdfConverter.PdfDocumentOptions.PdfPageOrientation = SelectedPdfPageOrientation()

        ''' Set the maximum time in seconds to wait for HTML page to be loaded 
        ''' Leave it not set for a default 60 seconds maximum wait time
        ''htmlToPdfConverter.NavigationTimeout = Integer.Parse(navigationTimeoutTextBox.Text)

        ''' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
        ''' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
        ''If conversionDelayTextBox.Text.Length > 0 Then
        ''    htmlToPdfConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
        ''End If


        '' Convert HTML to PDF using the settings above
        'Dim outPdfFile As String = Server.MapPath(appPath & "/Test.pdf")
        'Try

        '    Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
        '    Dim signinManager = Context.GetOwinContext().GetUserManager(Of ApplicationSignInManager)()

        '    ' This doen't count login failures towards account lockout
        '    ' To enable password failures to trigger lockout, change to shouldLockout := True
        '    Session("DummySession") = "DummySession"

        '    Dim result = signinManager.PasswordSignIn("admin@4t.com.br", "b", True, shouldLockout:=False)


        '    Dim url As String = HttpContext.Current.Request.Url.AbsoluteUri

        '    ' Convert the HTML page given by an URL to a PDF document in a memory buffer
        '    Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

        '        ' Write the memory buffer in a PDF file
        '        System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)

        'Catch ex As Exception
        '    ' The HTML to PDF conversion failed
        '    'MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
        '    Return
        'Finally
        '    'Cursor = Cursors.Arrow
        'End Try

        '' Open the created PDF document in default PDF viewer
        'Try
        '    Process.Start(outPdfFile)
        'Catch ex As Exception
        '    'MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
        'End Try


    End Sub



End Class

