
Imports DevExpress.Xpf.WindowsUI
Imports System.Windows
Public Class MDIPrincipal
    Dim PosicaoSubMenu As Integer = 1


    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click


        Dim resposta = MsgBox("Deseja sair do sistema?", vbYesNo, "Mensagem do Sistema")
        If resposta = MessageBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load

        'ResolveParametrosGlobais()

        'Me.Text = S5TEmpresa.pNome + " - " + Modulo.nomeDoSistema


        'With FormHome
        '    .MdiParent = Me
        '    .Dock = DockStyle.Fill
        '    .Show()
        '    'Me.Text = Me.Text & " - " & .Text
        '    Me.LayoutMdi(MdiLayout.Cascade)
        '    Me.Top = 0
        'End With
        
    End Sub

    Enum operacaoPercorrerMenus
        gravarMenus = 0
        desabilitarMenus = 1
        desaparecerMenus = 2
    End Enum

    Private Sub AtualizaMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        S5T.MenuCollection.DeleteBySistema(S5T.Sistema.LoadByCodSistemaCodEmpresa(CodSistema, Empresa))

        PercorreToolStripMenus(operacaoPercorrerMenus.gravarMenus)
    End Sub
    Private Sub PercorreToolStripMenus(op As operacaoPercorrerMenus)
        For Each _control As Object In Me.Controls
            If TypeOf (_control) Is MenuStrip Then

                For Each itm As ToolStripMenuItem In _control.items
                    If op = operacaoPercorrerMenus.gravarMenus Then
                        Dim objSistema = S5T.Sistema.LoadBypCodigo(CodSistema)

                        PosicaoSubMenu = 1

                        Dim objMenu As New S5T.Menu

                        objMenu.oSistema = objSistema
                        objMenu.pDescricao = itm.Text
                        objMenu.pNomeToolStrip = itm.Name
                        objMenu.pNivelPosicao = 1
                        objMenu.Save()

                        'For Each objUsuario In S5T.UsuarioCollection.LoadAll
                        '    Dim objMenuPerm = S5T.MenuPermissao.LoadBySistemaUsuarioToolStrip(S5T.Sistema.LoadBypCodigo(CodSistema).pId, objUsuario.pId, itm.Name)

                        '    If objMenuPerm Is Nothing Then
                        '        Dim objMenuPermNew As New S5T.MenuPermissao

                        '        objMenuPermNew.pNomeToolStripPerm = itm.Name
                        '        objMenuPermNew.pFlgPermissao = "N"
                        '        objMenuPermNew.oSistema = objSistema
                        '        objMenuPermNew.oUsuario = objUsuario
                        '        objMenuPermNew.Save()
                        '    End If

                        'Next

                        If itm.DropDownItems.Count > 0 Then
                            PosicaoSubMenu = PosicaoSubMenu + 1
                            LoopMenuItems(itm, operacaoPercorrerMenus.gravarMenus)
                        End If
                    ElseIf op = operacaoPercorrerMenus.desabilitarMenus Then
                        itm.Enabled = False

                        If itm.DropDownItems.Count > 0 Then
                            PosicaoSubMenu = PosicaoSubMenu + 1
                            LoopMenuItems(itm, operacaoPercorrerMenus.desabilitarMenus)
                        End If
                    ElseIf op = operacaoPercorrerMenus.desaparecerMenus Then
                        itm.Visible = False

                        If itm.DropDownItems.Count > 0 Then
                            PosicaoSubMenu = PosicaoSubMenu + 1
                            LoopMenuItems(itm, operacaoPercorrerMenus.desaparecerMenus)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Function LoopMenuItems(ByVal parent As ToolStripMenuItem, op As operacaoPercorrerMenus) As Object
        Dim retval As Object = Nothing

        For Each child As Object In parent.DropDownItems
            If op = operacaoPercorrerMenus.gravarMenus Then
                Dim objSistema = S5T.Sistema.LoadBypCodigo(CodSistema)

                Dim objMenu As New S5T.Menu

                objMenu.oSistema = objSistema
                objMenu.pDescricao = child.Text
                objMenu.pNomeToolStrip = child.Name
                objMenu.pNivelPosicao = PosicaoSubMenu
                objMenu.Save()

                'For Each objUsuario In S5T.UsuarioCollection.LoadAll
                '    Dim objMenuPerm = S5T.MenuPermissao.LoadBySistemaUsuarioToolStrip(S5T.Sistema.LoadBypCodigo(CodSistema).pId, objUsuario.pId, child.Name)

                '    If objMenuPerm Is Nothing Then
                '        Dim objMenuPermNew As New S5T.MenuPermissao

                '        objMenuPermNew.pNomeToolStripPerm = child.Name
                '        objMenuPermNew.pFlgPermissao = "N"
                '        objMenuPermNew.oSistema = objSistema
                '        objMenuPermNew.oUsuario = objUsuario
                '        objMenuPermNew.Save()
                '    End If

                'Next

                If TypeOf (child) Is ToolStripMenuItem Then
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, operacaoPercorrerMenus.gravarMenus)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If
            ElseIf op = operacaoPercorrerMenus.desabilitarMenus Then
                child.Enabled = False

                If TypeOf (child) Is ToolStripMenuItem Then
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, operacaoPercorrerMenus.desabilitarMenus)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If
            ElseIf op = operacaoPercorrerMenus.desaparecerMenus Then
                child.Visible = False

                If TypeOf (child) Is ToolStripMenuItem Then
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, operacaoPercorrerMenus.desaparecerMenus)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If

            End If
        Next

        Return retval
    End Function

    'Private Sub PermissõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissõesToolStripMenuItem.Click
    '    With FormPermissao
    '        .MdiParent = Me
    '        .Dock = DockStyle.Fill
    '        .Show()
    '        Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
    '        Me.LayoutMdi(MdiLayout.Cascade)
    '        Me.Top = 0
    '    End With
    'End Sub

    Public Function GetControlByName(ByVal Name As String) As Object

        'now, why would I put a "_" in front of the name? 
        Dim info As System.Reflection.FieldInfo = Me.GetType().GetField("_" & Name,
        System.Reflection.BindingFlags.NonPublic Or
        System.Reflection.BindingFlags.Instance Or
        System.Reflection.BindingFlags.Public Or
        System.Reflection.BindingFlags.IgnoreCase)

        If info Is Nothing Then Return Nothing
        Dim o As Object = info.GetValue(Me)
        Return o

    End Function

    Private Sub MapaDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapaDeVendasToolStripMenuItem.Click

        With FrmExemplo
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With
    End Sub


    Private Sub PivotVendas2017ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PivotVendas2017ToolStripMenuItem.Click
        Dim oform As New FormTestePivot

        With oform
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With

    End Sub

    Private Sub PesagemDeMatériaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesagemDeMatériaPrimaToolStripMenuItem.Click
        Dim oform As New FormFracionamento

        With oform
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With
    End Sub

    Private Sub CadastroDeTaraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeTaraToolStripMenuItem.Click
        Dim oform As New FormCadTaraProduto

        With oform
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With
    End Sub

    Private Sub CadastroDeProdutosKitOrdemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeProdutosKitOrdemToolStripMenuItem.Click
        Dim oform As New FormCadParametros

        With oform
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With
    End Sub

    Private Sub ControleDeLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDeLoteToolStripMenuItem.Click
        Dim oform As New FormTestePaleteMOv

        With oform
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            'Me.Text = S5TClinica.pNome + " - " + Modulo.nomeDoSistema + "  [ " + .Text + " ]"
            Me.LayoutMdi(MdiLayout.Cascade)
            Me.Top = 0
        End With

    End Sub

    Private Sub OrdensNãoEnviadasProtheusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdensNãoEnviadasProtheusToolStripMenuItem.Click
       
      
        With FormArgPeriodo
            .ShowDialog()
            If Cancela Then
                Me.Cursor = Cursors.WaitCursor

                
                'IMPRIMIR REL DX
                Dim oRelatorio As New RelOrdensErroProtheus
                dim parDataInicial as Date = CDate(.MskDataInicial.Text)
                dim parDataFinal as Date= CDate(.MskDataFinal.Text)

                oRelatorio.DataSource = S5T.LogFracionamentoCollection.LoadPeriodo(parDataInicial,parDataFinal)
                oRelatorio.Parameters(0).Value = parDataInicial + " a " + parDataFinal

                'Orelatorio.infoNomeEmpresa.Value = S5TFilial.oCadastro.pNome
                'Orelatorio.infoCNPJ.Value = S5TFilial.oCadastro.pCpfCnpj
                'Orelatorio.infoEnderecoTelefone.Value = S5TFilial.oCadastro.pEndereco & " " & S5TFilial.oCadastro.pTelefone
                'Orelatorio.infoCepCidadeUF.Value = S5TFilial.oCadastro.pCep & " " & S5TFilial.oCadastro.oCidade.pNome & " " & S5TFilial.oCadastro.oCidade.oUF.pSigla
                'Orelatorio.infoTituloRelatorio.Value = "Relatório de Visítas pagas no dia - " & parData

                Orelatorio.CreateDocument()
                FormReportDX.DocumentViewer1.DocumentSource = Orelatorio

                Me.Cursor = Cursors.Default
                
                'FormReportDX.Show()
                FormReportDX.MdiParent = Me
                FormReportDX.Dock = DockStyle.Fill
                Me.LayoutMdi(MdiLayout.Cascade)
                Me.Top = 0
                FormReportDX.Show()
            End If
        End With

        
    End Sub

    Private Sub WebServiceSasCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebServiceSasCarToolStripMenuItem.Click
        FormSasCarWebService.Show()
    End Sub

    Private Sub PesagemDeOrdensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesagemDeOrdensToolStripMenuItem.Click
        
      
        With FormArgPeriodoProduto
            .ShowDialog()
            If Cancela Then
                Me.Cursor = Cursors.WaitCursor
                
                'IMPRIMIR REL DX
                Dim oRelatorio As New RelOrdensPesadas
                dim parDataInicial as string = Cdate(.MskDataInicial.Text).ToString("yyyy-MM-dd")
                dim parDataFinal as string= CDate(.MskDataFinal.Text).ToString("yyyy-MM-dd")
                Dim parProduto As String = .cmbProduto.EditValue

                dim ds = S5T.FracionamentoMovCollection.LoadByPeriodo(parDataInicial,parDataFinal)

                if parProduto isnot nothing then
                    ds = ds.FindAll(Function(x) x.G1_COMP = parProduto)
                    oRelatorio.Parameters(1).Value =   true
                End If

                oRelatorio.DataSource = ds
                oRelatorio.Parameters(0).Value = parDataInicial + " a " + parDataFinal

                
              
                Orelatorio.CreateDocument()
                FormReportDX.DocumentViewer1.DocumentSource = Orelatorio

                Me.Cursor = Cursors.Default
                
                'FormReportDX.Show()
                FormReportDX.MdiParent = Me
                FormReportDX.Dock = DockStyle.Fill
                Me.LayoutMdi(MdiLayout.Cascade)
                Me.Top = 0
                FormReportDX.Show()
            End If
        End With
    End Sub
End Class
