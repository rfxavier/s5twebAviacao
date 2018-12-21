Imports System.Data
Imports System.Net
Imports CodeFluent.Runtime
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class FormCadTaraProduto
    Dim Obj As S5T.TaraFracionamento
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
                SV()
            End If
        End If
    End Sub

    Private Sub FormCadReserva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tipoOperacao = tpInsAlt.Insercao
        
        cmbEmbalagem.DataSource = S5T.EmbalagemFracionamentoCollection.LoadAll()
        cmbEmbalagem.DisplayMember = "pDescricao"
        cmbEmbalagem.ValueMember = "pId"

        LinqServerModeSource1.KeyExpression = "pId"
        LinqServerModeSource1.QueryableSource = New S5TWinFormAviacao.DataClassesTaraFracionamentoDataContext().vTaraFracionamentoTaraFracionamentoViews
        
        'Me.Cursor = Cursors.WaitCursor
        'GridPesqDX.DataSource = Nothing
        'PreencheGridDX()
        'Me.Cursor = Cursors.Default

    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        SV()
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        If tipoOperacao = tpInsAlt.Alteracao Then
            If msgbox ("Deseja excluir o registro atual?",vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.TaraFracionamento.Delete(S5T.TaraFracionamento.LoadByEntityKey(Me.pIdAtual))
                Catch ex As CodeFluentValidationException
                    MsgBox( ex.MessageWithoutCode, vbCritical, "Mensagem do Sistema")
                    Exit Sub
                End Try
            End If
            Modulo.LimparDX(Me)
            Modulo.LimparMsk(Me)
            Modulo.LimparTxt(Me)
            'habilitaPk()
            tipoOperacao = tpInsAlt.Insercao
            cmbEmbalagem.SelectedItem = 0
            txtProdutoFinal.Focus()

        End If
    End Sub

    Private Sub Desistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desistir.Click
        Modulo.LimparDX(Me)
        Modulo.LimparTxt(Me)
        Modulo.LimparMsk(Me)

        TabControl1.SelectedTab = TabPage1
        tipoOperacao = tpInsAlt.Insercao
        cmbEmbalagem.SelectedItem = 0

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

            Dim ObjTara = S5T.TaraFracionamento.LoadByEntityKey(GridPesqDXView1.GetRowCellValue(GridPesqDXView1.FocusedRowHandle, GridPesqDXView1.Columns.ColumnByFieldName("pId")))

            Me.pIdAtual = ObjTara.pId

            txtProdutoFinal.EditValue = ObjTara.C2_PRODUTO
            TXTPRODUTOMATERIAPRIMA.EditValue = ObjTara.G1_COMP
            cmbEmbalagem.SelectedValue = ObjTara.oEmbalagempId

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
                Dim ObjNew As New S5T.TaraFracionamento
                ObjNew.C2_PRODUTO = txtProdutoFinal.EditValue
                ObjNew.G1_COMP = txtProdutoMateriaPrima.EditValue
                ObjNew.oEmbalagempId = cmbEmbalagem.SelectedValue

                ObjNew.Save()
            ElseIf tipoOperacao = tpInsAlt.Alteracao Then
                Dim obj = S5T.TaraFracionamento.LoadByEntityKey(Me.pIdAtual)

               obj.C2_PRODUTO = txtProdutoFinal.EditValue
               obj.G1_COMP = txtProdutoMateriaPrima.EditValue
               obj.oEmbalagempId = cmbEmbalagem.SelectedValue

                obj.Save()
            End If
        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode
            MsgBox( Modulo.parseExMsg(msgEx),vbCritical, "Mensagem do Sistema")
            Exit Sub
        End Try
        Modulo.LimparDX(Me)
        Modulo.LimparMsk(Me)
        Modulo.LimparTxt(Me)
        'habilitaPk()
        tipoOperacao = tpInsAlt.Insercao
        cmbEmbalagem.SelectedItem = 0
        txtProdutoFinal.Focus()
    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab Is TabPage2 Then
            txtProdutoFinal.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub PreencheGridDX()
       
        Dim VwGrid = S5T.TaraFracionamentoCollection.LoadAllView()

        If VwGrid Is Nothing Then
            MsgBox("Nenhum registro encontrado para a pesquisa selecionada", vbInformation, "Mensagem do Sistema")
            Exit Sub
        End If

        With GridPesqDX
            .DataSource = Nothing
            .DataSource = VwGrid
        End With
    End Sub
    

End Class