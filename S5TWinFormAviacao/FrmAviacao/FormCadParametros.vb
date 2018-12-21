Imports System.Data
Imports System.Net
Imports CodeFluent.Runtime
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class FormCadParametros
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
                SV()
            End If
        End If
    End Sub

    Private Sub FormCadReserva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tipoOperacao = tpInsAlt.Insercao
      
        LinqServerModeSource1.KeyExpression = "pId"
        LinqServerModeSource1.QueryableSource = New S5TWinFormAviacao.DataClassesParametrosFracionamentoDataContext().ParametrosFracionamentos

    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        SV()
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        If tipoOperacao = tpInsAlt.Alteracao Then
            If msgbox ("Deseja excluir o registro atual?",vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.ParametrosFracionamento.Delete(S5T.ParametrosFracionamento.LoadByEntityKey(Me.pIdAtual))
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
            MsgBox( Modulo.parseExMsg(msgEx),vbCritical, "Mensagem do Sistema")
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
    

End Class