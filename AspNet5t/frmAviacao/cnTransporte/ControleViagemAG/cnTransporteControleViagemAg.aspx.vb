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


Public Class cnTransporteControleViagemAg
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
            For Each o In objMotorista.ToList.FindAll(Function(x) x.sStatus = Status.Ativo)
                CmbMotorista.Items.Add(o.pNOME_MOTORISTA, o.pId)
                CmbMotoristaPesq.Items.Add(o.pNOME_MOTORISTA, o.pId)
            Next
        End If

        ''CARREGA COMBO CAMINHAO
        objCaminhao = S5T.AviacaoCaminhaoCollection.LoadAll
        CmbCaminhao.Items.Clear()
        CmbCaminhaoPesq.Items.Clear()

        If objCaminhao IsNot Nothing Then
            For Each o In objCaminhao.ToList.FindAll(Function(x) x.sStatus = Status.Ativo)
                CmbCaminhao.Items.Add(o.pPLACA, o.pId)
                CmbCaminhaoPesq.Items.Add(o.pPLACA, o.pId)
            Next
        End If

        ''CARREGA COMBO LOCAL LINHA
        objLocalLinha = S5T.AviacaoLocalLinhaCollection.LoadAll
        'CmbLocalLinha.Items.Clear()
        CmbLocalLinhaRetorno.Items.Clear()
        CmbLocalLinhaPesq.Items.Clear()

        ' Dim list As ASPxListBox = ASPxDropDownEdit1.FindControl("listBox")

        'If Not IsPostBack Then
        '    If objLocalLinha IsNot Nothing Then
        '        For Each o In objLocalLinha
        '            list.Items.Add(o.pDESCRICAO, o.pId)
        '        Next
        '    End If

        'End If


        If objLocalLinha IsNot Nothing Then
            For Each o In objLocalLinha
                'CmbLocalLinha.Items.Add(o.pDESCRICAO, o.pId)
                'list.Items.Add(o.pDESCRICAO, o.pId)
                CmbLocalLinhaRetorno.Items.Add(o.pDESCRICAO, o.pId)
                CmbLocalLinhaPesq.Items.Add(o.pDESCRICAO, o.pId)
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



            End If
            If obj.oAviacaoLocalLinhaRetorno IsNot Nothing Then
                CmbLocalLinhaRetorno.SelectedIndex = CmbLocalLinhaRetorno.Items.IndexOf(CmbLocalLinhaRetorno.Items.FindByText(obj.oAviacaoLocalLinhaRetorno.pDESCRICAO))
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



                    For Each objALC In S5T.AviacaoLocalLinhaCollection.LoadAll
                        obj.oAviacaoLocalLinhas.Remove(objALC)
                    Next


                    obj.oAviacaoLocalLinhaRetornopId = CmbLocalLinhaRetorno.Value
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
        gridPesquisa.DataSource = VwGrid
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





End Class

