Imports System.Data
Imports System.Net
Imports CodeFluent.Runtime
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class FormTestePaleteMOv
    Dim Obj As S5T.ParametrosFracionamento
    Private tipoOperacao As tpInsAlt
    Private pIdAtual As Long

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        If MsgBox("Deseja sair da tela " & Me.Text & " ?", vbYesNo, "Mensagem do Sistema") = vbYes Then
            Me.Close()
            'MDIPrincipal.Text = "Sistema 'S5TFilial.pNome '+ " - " + Modulo.nomeDoSistema
        End If
    End Sub

    Private Sub FormCadTara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If TabControl1.SelectedIndex = 1 Then
            If e.KeyCode = Keys.Return Then
                TxtLote.EditValue = ""
                TxtCodProduto.EditValue = ""
                TxtQuant.EditValue = ""
                TxtEmbalagem.EditValue = ""

                If TxtCodbarra.EditValue <> "" Then

                    TxtLote.EditValue = Mid(TxtCodbarra.EditValue, 1, 4)
                    TxtCodProduto.EditValue = Mid(TxtCodbarra.EditValue, 5, 6)
                    If TxtCodProduto.EditValue = 103300 Then
                        TxtDescricao.EditValue = "MANT. POTE 200G COM SAL"
                        TxtEmbalagem.EditValue = "48 x 200"
                    Else
                        TxtDescricao.EditValue = "MANT. POTE 200G COM SAL"
                        TxtEmbalagem.EditValue = "24 x 200"
                    End If
                    TxtQuant.EditValue = Mid(TxtCodbarra.EditValue, 11, 3)
                    TxtQtdDefault.EditValue = 50
                    TxtQuantArmazenada.EditValue = TxtQtdDefault.EditValue
                    TxtDataMov.Text = Now
                    TxtCodbarra.EditValue = ""
                    If TxtQuant.EditValue = 79 Then
                        LblResumo.Text = "1 palete com 50 caixas + 1 palete com 29 caixas"
                    End If
                    If TxtQuant.EditValue = 115 Then
                        LblResumo.Text = "2 paletes com 50 caixas + 1 palete com 15 caixas"
                    End If
                    PreencheGridLote()
                End If


                'SV()

            End If
        End If
    End Sub

    Private Sub PreencheGridLote()

        Dim totalcaixas As Double
        totalcaixas = 0


        With gridCadastro

            .Rows.Add("palete nº " & .Rows.Count + 1, TxtQuantArmazenada.EditValue)
            For i = 0 To .Rows.Count - 1
                totalcaixas = totalcaixas + .Rows(i).Cells(1).Value.ToString()
            Next
            If totalcaixas > TxtQuant.EditValue Then
                MsgBox("ATENÇÃO, QUANTIDADE NÃO CORRESPONDE COM O TOTAL DO CÓDIGO DE BARRA", vbExclamation)
                .Rows.RemoveAt(.CurrentRow.Index + 1)
                TxtQuantArmazenada.Focus()
            End If
        End With

    End Sub
    Private Sub FormatGridCadastro()

        With gridCadastro
            ' Create an unbound DataGridView by declaring a column count.
            .ColumnCount = 2
            .ColumnHeadersVisible = True

            ' Set the column header style.
            Dim columnHeaderStyle As New DataGridViewCellStyle()

            columnHeaderStyle.BackColor = Color.Beige
            columnHeaderStyle.Font = New Font("Arial", 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle

            ' Set the column header names.
            .Columns(0).Name = "palete"
            .Columns(1).Name = "quantidade"


            .Columns(0).Width = 100
            .Columns(1).Width = 150
        End With

    End Sub


    Private Sub FormCadReserva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tipoOperacao = tpInsAlt.Insercao
        FormatGridCadastro()
        'LinqServerModeSource1.KeyExpression = "pId"
        'LinqServerModeSource1.QueryableSource = New S5TWinFormAviacao.DataClassesParametrosFracionamentoDataContext().ParametrosFracionamentos

    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        SV()
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        If tipoOperacao = tpInsAlt.Alteracao Then
            If MsgBox("Deseja excluir o registro atual?", vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.ParametrosFracionamento.Delete(S5T.ParametrosFracionamento.LoadByEntityKey(Me.pIdAtual))
                Catch ex As CodeFluentValidationException
                    MsgBox(ex.MessageWithoutCode, vbCritical, "Mensagem do Sistema")
                    Exit Sub
                End Try
            End If
            Modulo.LimparDX(Me)
            Modulo.LimparMsk(Me)
            Modulo.LimparTxt(Me)
            'habilitaPk()
            tipoOperacao = tpInsAlt.Insercao
            txtMultiplasEtiquetas.EditValue = "S"

            txtProdutoFinal.Focus()

        End If
    End Sub

    Private Sub Desistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desistir.Click
        Modulo.LimparDX(Me)
        Modulo.LimparTxt(Me)
        Modulo.LimparMsk(Me)

        txtMultiplasEtiquetas.EditValue = "S"

        TabControl1.SelectedTab = TabPage1
        tipoOperacao = tpInsAlt.Insercao

        'habilitaPk()
    End Sub


    Private Sub CmdPesquisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '----DX COMPONENTE DxValidationProvider
        'CONSISTÊNCIAS NA INTERFACE DO USUÁRIO



    End Sub

    Private Sub GridPesqDX_DoubleClick(sender As Object, e As EventArgs) Handles GridPesqDX.DoubleClick

        Modulo.LimparDX(Me)
        Modulo.LimparMsk(Me)
        Modulo.LimparTxt(Me)


        If GridPesqDXView1.SelectedRowsCount = 1 And GridPesqDXView1.IsDataRow(GridPesqDXView1.FocusedRowHandle) Then

            Dim ObjParametros = S5T.ParametrosFracionamento.LoadByEntityKey(GridPesqDXView1.GetRowCellValue(GridPesqDXView1.FocusedRowHandle, GridPesqDXView1.Columns.ColumnByFieldName("pId")))

            Me.pIdAtual = ObjParametros.pId

            txtProdutoFinal.EditValue = ObjParametros.pCodigoProduto
            txtMultiplasEtiquetas.EditValue = ObjParametros.pImprimeMultiplasEtiquetas

            tipoOperacao = tpInsAlt.Alteracao
            TabControl1.SelectedTab = TabPage2
            txtProdutoFinal.Focus()
            DesabilitaPk()

        End If
    End Sub
    Public Sub DesabilitaPk()
        Dim cControl As Control
        For Each cControl In Me.TabControl1.TabPages
            For Each cControlTab As Control In cControl.Controls
                If cControlTab.Tag = "key" Then
                    cControlTab.Enabled = False
                    'Exit Sub
                End If
            Next
        Next cControl
    End Sub
    Public Sub habilitaPk()
        Dim cControl As Control
        For Each cControl In Me.TabControl1.TabPages
            For Each cControlTab As Control In cControl.Controls
                If cControlTab.Tag = "key" Then
                    cControlTab.Enabled = True
                    'Exit Sub
                End If
            Next
        Next cControl
    End Sub

    Private Sub SV()
        Dim boolValidado As Boolean = False

        '----DX COMPONENTE DxValidationProvider
        'CONSISTÊNCIAS NA INTERFACE DO USUÁRIO



        Try
            If tipoOperacao = tpInsAlt.Insercao Then
                Dim ObjNew As New S5T.ParametrosFracionamento
                ObjNew.pCodigoProduto = txtProdutoFinal.EditValue
                ObjNew.pImprimeMultiplasEtiquetas = txtMultiplasEtiquetas.EditValue

                ObjNew.Save()
            ElseIf tipoOperacao = tpInsAlt.Alteracao Then
                Dim obj = S5T.ParametrosFracionamento.LoadByEntityKey(Me.pIdAtual)

                obj.pCodigoProduto = txtProdutoFinal.EditValue
                obj.pImprimeMultiplasEtiquetas = txtMultiplasEtiquetas.EditValue

                obj.Save()
            End If
        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode
            MsgBox(Modulo.parseExMsg(msgEx), vbCritical, "Mensagem do Sistema")
            Exit Sub
        End Try
        Modulo.LimparDX(Me)
        Modulo.LimparMsk(Me)
        Modulo.LimparTxt(Me)
        'habilitaPk()
        txtMultiplasEtiquetas.EditValue = "S"
        tipoOperacao = tpInsAlt.Insercao
        txtProdutoFinal.Focus()
    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab Is TabPage2 Then
            txtProdutoFinal.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub PreencheGridDX()


    End Sub

    Private Sub TxtCodbarra_Leave(sender As Object, e As EventArgs) Handles TxtCodbarra.Leave
        'If TxtCodbarra.EditValue <> "" Then
        '    TxtLote.EditValue = Mid(TxtCodbarra.EditValue, 1, 4)
        '    TxtCodProduto.EditValue = Mid(TxtCodProduto.EditValue, 5, 6)
        '    If TxtCodProduto.EditValue = 103300 Then
        '        TxtDescricao.EditValue = "MANT. POTE 200G COM SAL"
        '        TxtEmbalagem.EditValue = "48 x 200"
        '    Else
        '        TxtDescricao.EditValue = "MANT. POTE 200G COM SAL"
        '        TxtEmbalagem.EditValue = "24 x 200"
        '    End If
        '    TxtQuant.EditValue = Mid(TxtCodbarra.EditValue, 11, 4)
        'End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PreencheGridLote()
    End Sub
End Class