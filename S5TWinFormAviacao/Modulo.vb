
'string de conexão da locaweb
'Server=mysql01.w4tsistemas.hospedagemdesites.ws;User Id=w4tsistemas;password=e@4tsistemas;database=w4tsistemas;pooling=false
'string de conexão LOCAL
'Server=localhost;User Id=root;password=manager;database=w4tsistemas;pooling=false
'string de conexão notebook gui
'Server=172.16.0.9;User Id=root;password=manager;database=w4tsistemas;pooling=false
'string de conexão notebook acs
'Server=172.16.0.197;User Id=root;password=manager;database=w4tsistemas;pooling=false

Imports System.Data
Imports System.Net
Imports Microsoft.VisualBasic
Imports System.Windows.Forms.Control
Imports System.Security.Cryptography
Imports System.Text

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Reflection
Imports MySql.Data.MySqlClient




Module Modulo

    Public OwnSistema As String
    Public Empresa As Integer
    Public UserLogado As String
    Public UserLogadoAdmin As Boolean = False
    Public Filial As Integer
    Public NomeEmpresa As String
    Public NomeFilial As String
    Public CodSistema As Integer

    Public S5TEmpresa As S5T.Empresa
    Public S5TSistema As S5T.Sistema
    Public S5TUsuarioLogado As S5T.Usuario
    Public S5TFilial As S5T.Filial
    Public S5TFilialConfig As S5T.FilialConfigCollection
    Public S5TCidades As S5T.CidadeCollection

    Public S5TAppRelatorioAdmin As S5T.AppRelatorioView
    Public S5TAppRelatorio As S5T.AppRelatorioUsuarioView

    Public strTipoDocDebitoCliente As String
    Public intLocalCobRecDebitoCliente As Integer
    Public intTituloMovTipoBaixaAuto As Integer
    Public intCentroCustoReceitaTaxaCartao As Integer
    Public intCentroCustoReceitaComissionamento As Integer
    Public intCentroCustoReceitaArrendamento As Integer


    'VARIÁVEIS FINANCEIRO 
    Public configCodTituloTipoMovBaixaPadrao As Integer
    Public configCodTituloTipoMovJuroPadrao As Integer
    Public configCodTituloTipoMovDescontoPadrao As Integer


    Public VarErro As Boolean
    Public nomeDoSistema As String = ""
    Public TipoOperacao As Integer
    Public Cancela As Boolean

    Public CodAuxNovoRegistroCombo As String
    Public InserindoNovoRegistroCombo As Boolean = False


    Public Sub LimparTxt(ByVal ControleTxt As Control)
        Dim Ctl As Control
        For Each Ctl In ControleTxt.Controls
            If Ctl.GetType.Name = "TextBox" Then '   TypeOf Ctl Is TextBox Then 'COMENTADO RENATO - 15/06/14 - TypeOf estava limpando até controles textbox dentro dos grids
                DirectCast(Ctl, TextBox).Text = String.Empty
            ElseIf Ctl.Controls.Count > 0 Then
                LimparTxt(Ctl)
            End If
        Next
    End Sub

    Public Sub LimparMsk(ByVal ControleTxt As Control)
        Dim Ctl As Control
        For Each Ctl In ControleTxt.Controls
            If TypeOf Ctl Is MaskedTextBox Then
                DirectCast(Ctl, MaskedTextBox).Text = String.Empty
            ElseIf Ctl.Controls.Count > 0 Then
                LimparMsk(Ctl)
            End If
        Next
    End Sub
    Public Sub LimparCmb(ByVal ControleTxt As Control)
        Dim Ctl As Control
        For Each Ctl In ControleTxt.Controls
            If TypeOf Ctl Is ComboBox Then
                DirectCast(Ctl, ComboBox).SelectedIndex = 0
            ElseIf Ctl.Controls.Count > 0 Then
                LimparCmb(Ctl)
            End If
        Next
    End Sub
    Public Sub LimparDX(ByVal ControleTxt As Control)
        Dim Ctl As Control
        For Each Ctl In ControleTxt.Controls
            'Console.WriteLine(Ctl.GetType.ToString & ":" & Ctl.Name)
            If TypeOf Ctl Is DevExpress.XtraEditors.BaseEdit Then
                DirectCast(Ctl, DevExpress.XtraEditors.BaseEdit).EditValue = Nothing
            ElseIf Ctl.Controls.Count > 0 Then
                LimparDX(Ctl)
            End If
        Next

    End Sub

    Public Sub LimparDXValProviders(ByVal ControleForm As Object)
        For Each cmp In GetComponents(ControleForm)
            'Console.WriteLine(cmp.GetType.ToString & ":" & cmp.ToString)

            If TypeOf cmp Is DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Then
                Dim objDXValProvider = DirectCast(cmp, DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider)

                For i = objDXValProvider.GetInvalidControls.Count - 1 To 0 Step -1
                    objDXValProvider.RemoveControlError(objDXValProvider.GetInvalidControls(i))
                Next
            End If
        Next
    End Sub
    Public Function GetComponents(ByVal frm As Form) As List(Of Component)
        Dim components As New List(Of Component)
        Dim fieldInfos() As FieldInfo = frm.GetType.GetFields _
            (BindingFlags.NonPublic Or BindingFlags.Instance Or _
             BindingFlags.DeclaredOnly)
        For Each f As FieldInfo In fieldInfos
            If f.FieldType.BaseType Is GetType(Component) Then
                Dim c As Component = TryCast(f.GetValue(frm), Component)
                If c IsNot Nothing Then components.Add(c)
            End If
        Next
        Return components
    End Function
    Public Function FormataValor(ByVal WsValorFormato As String) As String
        If WsValorFormato <> "" Then
            WsValorFormato = FormatNumber(WsValorFormato, 2)
        Else
            WsValorFormato = "0,00"
        End If
        FormataValor = WsValorFormato
    End Function
    Public Function NvlCampo(ByVal WsNvlCampo As String) As Double
        If Trim(WsNvlCampo) = "" Then
            NvlCampo = 0
        Else
            NvlCampo = WsNvlCampo
        End If
    End Function
    Public Function TestaNumero(ByRef KeyAscii As Short, Optional ByVal Campo_SoParaDecimal As String = "", Optional ByVal CasasDecimais As Integer = 0) As Boolean
        TestaNumero = True
        If KeyAscii = 46 Then KeyAscii = 44
        If (Chr(KeyAscii) < "0" Or Chr(KeyAscii) > "9") And _
            KeyAscii <> 44 And _
            KeyAscii <> 45 And _
            KeyAscii <> 8 Or _
            KeyAscii = 32 Then
            KeyAscii = 0
            Beep()
            TestaNumero = False
            Exit Function
        End If
        If KeyAscii = 44 Then
            If IsNothing(Campo_SoParaDecimal) Then
                KeyAscii = 0
                Beep()
                TestaNumero = False
                Exit Function
            ElseIf InStr(1, Campo_SoParaDecimal, ",") <> 0 Or Len(Trim(Campo_SoParaDecimal)) = 0 Then
                KeyAscii = 0
                Beep()
                TestaNumero = False
                Exit Function
            End If
        End If

        If Not IsNothing(Campo_SoParaDecimal) And Not IsNothing(CasasDecimais) And KeyAscii <> 8 And KeyAscii <> 44 Then
            If InStr(1, Campo_SoParaDecimal, ",") <> 0 Then
                If (InStr(1, Campo_SoParaDecimal, ",") + CasasDecimais) <= Len(Campo_SoParaDecimal) Then
                    KeyAscii = 0
                    Beep()
                    TestaNumero = False
                    Exit Function
                End If
            End If
        End If
    End Function
    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890,", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
    Function Testadata(ByVal wsdata As String) As Boolean

        If wsdata <> "  /  /" Then
            If Mid(wsdata, 7, 4) < 1900 Then
                MsgBox("Data inválida.", vbExclamation, "Atençao")
                Return True
            End If

            If Not IsDate(wsdata) Then
                MsgBox("Data inválida.", vbExclamation, "Atençao")
                Return True
            End If
        End If
        Return False
    End Function


    Public Function parseExMsg(msg As String, Optional ByVal flg As String = "") As String
        Dim retmsg As String = ""
        Dim retmsgAux As String = ""

        If msg.Substring(0, 1) = "[" And msg.IndexOf("]") > 0 Then
            If flg = "name" Then
                retmsg = msg.Substring(1, msg.IndexOf("]") - 1)
            Else
                retmsgAux = msg.Substring(msg.IndexOf("]") + 1)
                If retmsgAux.IndexOf("[") > 0 Then
                    retmsg = retmsgAux.Substring(1, retmsgAux.IndexOf("[") - 1)
                End If

                retmsg = msg.Substring(msg.IndexOf("]") + 1)
            End If
        Else
            retmsg = msg
        End If

        'If msg.Substring(0, 1) = "{" And msg.IndexOf("}") > 0 Then
        '    If flg = "name" Then
        '        retmsg = msg.Substring(1, msg.IndexOf("}") - 1)
        '    Else
        '        retmsg = msg.Substring(msg.IndexOf("}") + 1)
        '    End If
        'Else
        '    retmsg = msg
        'End If

        Return retmsg
    End Function
    Public Function exMsgHasTag(msg As String) As Boolean
        Return (msg.Substring(0, 1) = "[" And msg.IndexOf("]") > 0)
    End Function


    Public Function stringNamePropResource(ByVal parNomeEntidade As String, parNomeProp As String, parCategoriaMsg As String)
        'cf://e[S5T.CadastroTipo]/p[pDescricao]/m[pt-BR_ajuda]
        Return "cf://e[" & parNomeEntidade & "]/p[" & parNomeProp & "]/m[pt-BR_" & parCategoriaMsg & "]"
    End Function


    Sub ValidaNumeroInteiro(ByVal campo As Control, e As KeyPressEventArgs)
        '46 VIRGULA
        '44 PONTO
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then
            e.Handled = True
        End If
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Modulo.TestaNumero(Keyascii, campo.Text, 0) = False Then
            e.Handled = True
        End If
    End Sub

    Sub ValidaNumeroDecimal(ByVal campo As Control, e As KeyPressEventArgs, ByVal casas As Int16)
        '46 VIRGULA
        '44 PONTO
        If Asc(e.KeyChar) = 46 Then
            e.Handled = True
        End If
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Modulo.TestaNumero(Keyascii, campo.Text, casas) = False Then
            e.Handled = True
        End If
    End Sub

    Public Sub ResolveS5TAppRelatorio(objTag As Object)
        If objTag IsNot Nothing Then
            If objTag.GetType.Name = "AppRelatorioView" Then
                S5TAppRelatorioAdmin = objTag

                S5TAppRelatorio = S5T.AppRelatorio.LoadByIdView(S5TAppRelatorioAdmin.pId)
            ElseIf objTag.GetType.Name = "AppRelatorioUsuarioView" Then
                S5TAppRelatorio = objTag
            End If
        End If
    End Sub

    Public Sub ResolveParametrosGlobais(ByVal parLoginRegistro As S5T.LoginRegistro)

        Filial = parLoginRegistro.pCodigoFilial
        UserLogado = parLoginRegistro.pLoginUsuario
        UserLogadoAdmin = (parLoginRegistro.pFlgAdminUsuario = "S")

        S5TFilial = S5T.Filial.LoadByCodEmpresaCodFilial(parLoginRegistro.pCodigoEmpresa, parLoginRegistro.pCodigoFilial)
        NomeFilial = S5TFilial.pNome

        S5TUsuarioLogado = S5T.Usuario.LoadBypLogin(parLoginRegistro.pLoginUsuario)

        S5TFilialConfig = S5T.FilialConfigCollection.LoadByFilial(S5TFilial)

        S5TCidades = S5T.CidadeCollection.LoadAll



    End Sub

    Function TestaHoraMinuto(ByVal wshoraminuto As String) As Boolean
        If wshoraminuto <> "  :" Then
            If Not IsDate(wshoraminuto) Or wshoraminuto.Length < 5 Then
                MsgBox("Horário inválido.", vbExclamation, "Atençao")
                Return True
            End If
        End If
        Return False
    End Function



    Public Class ValueAndText
        Private _value As Object
        Private _text As String
        Sub New(ByVal value As Object, ByVal text As String)
            _value = value
            _text = text
        End Sub
        Public Property Value() As Object
            Get
                Return _value
            End Get
            Set(ByVal value As Object)
                _value = value
            End Set
        End Property

        Public Property Text() As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                _text = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return _text
        End Function

    End Class
    Enum tpInsAlt
        Insercao
        Alteracao
    End Enum
End Module
