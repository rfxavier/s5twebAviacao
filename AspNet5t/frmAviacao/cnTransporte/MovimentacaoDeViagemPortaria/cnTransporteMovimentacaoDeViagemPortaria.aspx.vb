Imports DevExpress.Web
Imports CodeFluent.Runtime
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Owin
Imports S5T

Public Class cnTransporteMovimentacaoDeViagemPortaria
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
            'cbCaminhaoDisponivel.Checked = True

        End If
        ''CARREGA COMBO MOTORISTA
        objMotorista = S5T.AviacaoMotoristaCollection.LoadAll
        CmbMotorista.Items.Clear()

        If objMotorista IsNot Nothing Then
            For Each o In objMotorista
                CmbMotorista.Items.Add(o.pNOME_MOTORISTA, o.pId)
            Next
        End If

        ''CARREGA COMBO CAMINHAO
        objCaminhao = S5T.AviacaoCaminhaoCollection.LoadAll
        CmbCaminhao.Items.Clear()

        If objCaminhao IsNot Nothing Then
            For Each o In objCaminhao
                CmbCaminhao.Items.Add(o.pPLACA, o.pId)
            Next
        End If

        ''CARREGA COMBO LOCAL LINHA
        objLocalLinha = S5T.AviacaoLocalLinhaCollection.LoadAll
        CmbLocalLinha.Items.Clear()
        CmbLocalLinhaRetorno.Items.Clear()


        If objLocalLinha IsNot Nothing Then
            For Each o In objLocalLinha
                CmbLocalLinha.Items.Add(o.pDESCRICAO, o.pId)
                CmbLocalLinhaRetorno.Items.Add(o.pDESCRICAO, o.pId)
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
                mskDatSaida.Value = Date.Now
            Else
                mskDatSaida.Value = obj.pDATA_SAIDA
            End If
            If obj.oAviacaoMotorista IsNot Nothing Then
                CmbMotorista.SelectedIndex = CmbMotorista.Items.IndexOf(CmbMotorista.Items.FindByText(obj.oAviacaoMotorista.pNOME_MOTORISTA))
            End If
            If obj.oAviacaoCaminhao IsNot Nothing Then
                CmbCaminhao.SelectedIndex = CmbCaminhao.Items.IndexOf(CmbCaminhao.Items.FindByText(obj.oAviacaoCaminhao.pPLACA))
            End If
            If obj.oAviacaoLocalLinha IsNot Nothing Then
                CmbLocalLinha.SelectedIndex = CmbLocalLinha.Items.IndexOf(CmbLocalLinha.Items.FindByText(obj.oAviacaoLocalLinha.pDESCRICAO))
            End If
            If obj.oAviacaoLocalLinhaRetorno IsNot Nothing Then
                CmbLocalLinhaRetorno.SelectedIndex = CmbLocalLinhaRetorno.Items.IndexOf(CmbLocalLinhaRetorno.Items.FindByText(obj.oAviacaoLocalLinhaRetorno.pDESCRICAO))
            End If

            If obj.pSTATUS = "RETORNO" Or obj.pSTATUS = "EM VIAGEM" Then
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

                'Dim objNew As New S5T.AviacaoViagemMov

                'objNew.pDATA_SAIDA = mskDatSaida.Text
                'objNew.pDATA_PREV_RETORNO = mskDatPrev.Text
                'objNew.pDATA_RETORNO = IIf(mskDatRetorno.Text = "", Nothing, mskDatRetorno.Text)
                'objNew.oAviacaoMotoristapId = CmbMotorista.Value
                'objNew.oAviacaoLocalLinhapId = CmbLocalLinha.Value
                ''objNew.oAviacaoCaminhaopId = CmbCaminhao.Value

                'If CmbCaminhao.Text <> "" Then
                '    Dim FinalDaPlaca = Mid(CmbCaminhao.Text, 7, 1)
                '    Select Case FinalDaPlaca
                '        Case "1", "2"
                '            objNew.pRODIZIO = "Segunda-feira"
                '        Case "3", "4"
                '            objNew.pRODIZIO = "Terça-feira"
                '        Case "5", "6"
                '            objNew.pRODIZIO = "Quarta-feira"
                '        Case "7", "8"
                '            objNew.pRODIZIO = "Quinta-feira"
                '        Case "9", "0"
                '            objNew.pRODIZIO = "Sexta-feira"
                '        Case Else
                '            objNew.pRODIZIO = Nothing
                '    End Select
                'End If


                'objNew.Save()

            ElseIf tipoOperacao() = tpInsAlt.Alteracao Then
                'É ALTERAÇÃO

                Dim obj As S5T.AviacaoViagemMov = S5T.AviacaoViagemMov.LoadByEntityKey(gridPesquisa.GetSelectedFieldValues("pId")(0))

                obj.pDATA_RETORNO = IIf(mskDatRetorno.Text = "", Nothing, mskDatRetorno.Text)
                obj.pSTATUS = Nothing

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

                    Dim ctrl As Control = AppUtils.FindControlRecursive(AppUtils.FindControlRecursive(Me, "ASPxFormLayout" & i.ToString), nomeControle)
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

    Protected Sub gridPesquisa_DataBinding(sender As Object, e As EventArgs) Handles gridPesquisa.DataBinding
        Dim VwGrid As List(Of S5T.AviacaoViagemMovViewGrid) = Nothing

        VwGrid = S5T.AviacaoViagemMov.LoadByParametros(Nothing,
                                                       Nothing,
                                                       Nothing,
                                                       Nothing,
                                                       Nothing,
                                                       Nothing,
                                                       Nothing, Nothing,
                                                       Nothing, "S", "pDATA_SAIDA DESC")
        If VwGrid.Count > 0 Then
            VwGrid = VwGrid.FindAll(Function(x) x.pSTATUS <> "DISPONÍVEL" And x.pSTATUS <> "EM MANUTENÇÃO")
        End If

        gridPesquisa.DataSource = VwGrid
    End Sub

#End Region
    Dim parDataSaidaAux As String = String.Empty
    Dim parDataRetornoAux As String = String.Empty
    Protected Sub gv_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs) Handles gridPesquisa.HtmlDataCellPrepared

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

