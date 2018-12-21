Imports System.Web.Http
Imports Oracle.DataAccess.Client
Imports System.Runtime.Serialization
Imports System.Net.Http
Imports System.Web.Http.Cors
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.AspNet.Identity

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/UsuarioAppPedidos")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class UsuarioAppPedidosController
        Inherits ApiController

        Private _userManager As ApplicationUserManager
        Public Property UserManager() As ApplicationUserManager
            Get
                Return If(_userManager, Request.GetOwinContext().GetUserManager(Of ApplicationUserManager)())
            End Get
            Private Set
                _userManager = Value
            End Set
        End Property

        Private Class S5TAppRelatoriosUsuario
            Public Property nomeRelatorio As String
            Public Property tituloRelatorio As String
            Public Property sequencia As Integer
            Public Property nomeFormArgumento As String

        End Class


        <DataContract>
        Private Class S5TUsuarioAppPedido
            <DataMember>
            Public Property codigoVendedor As String
            <DataMember>
            Public Property nomeVendedor As String
            <DataMember>
            Public Property utilizaCota As String    '-- 1=Utiliza Cota; 2=Não Utiliza Cota
            <DataMember>
            Public Property codigoAprovador As String
            <DataMember>
            Public Property nomeAprovador As String
            <DataMember>
            Public Property codigoVendedorVinculado As String
            <DataMember>
            Public Property nomeVendedorVinculado As String
            <DataMember>
            Public Property codigoSubVendedor As String
            <DataMember>
            Public Property relatoriosContagem As Integer
            <DataMember>
            Public Property listaRelatorios As List(Of S5TAppRelatoriosUsuario)
        End Class

        ' GET: api/UsuarioAppPedidos
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/UsuarioAppPedidos/5
        <HttpGet>
        <Route("{parUsername}/")>
        Public Function GetValueUsuarioAppPedidos(<FromUri> ByVal parUsername As String) As IHttpActionResult
            Dim objUsuarioPedidoVazio = New S5TUsuarioAppPedido With {.codigoVendedor = "",
                                                                      .nomeVendedor = "",
                                                                      .utilizaCota = "",
                                                                      .codigoAprovador = "",
                                                                      .nomeAprovador = "",
                                                                      .codigoVendedorVinculado = "",
                                                                      .nomeVendedorVinculado = "",
                                                                      .codigoSubVendedor = "",
                                                                      .relatoriosContagem = 0,
                                                                      .listaRelatorios = New List(Of S5TAppRelatoriosUsuario)}

            Dim objUsuarioPedidoAdmin = New S5TUsuarioAppPedido With {.codigoVendedor = "015",
                                                                      .nomeVendedor = "Admin",
                                                                      .utilizaCota = "",
                                                                      .codigoAprovador = "000029",
                                                                      .nomeAprovador = "Admin Aprovador",
                                                                      .codigoVendedorVinculado = "",
                                                                      .nomeVendedorVinculado = "",
                                                                      .codigoSubVendedor = "",
                                                                      .relatoriosContagem = 0,
                                                                      .listaRelatorios = New List(Of S5TAppRelatoriosUsuario)}

            If parUsername = "admin@4t.com.br" Then
                Return Ok(objUsuarioPedidoAdmin)
            Else
                Dim userCustom = UserManager.FindByName(parUsername.Trim)

                If userCustom Is Nothing Then
                    Return Ok(objUsuarioPedidoVazio)
                Else
                    If userCustom.oUsuario Is Nothing Then
                        Return Ok(objUsuarioPedidoVazio)
                    End If
                End If

                'BUSCA DADOS DO USUÁRIO EM BASE ORACLE PROTHEUS
                Dim varNomeVendedor As String = String.Empty
                Dim varUtilizaCota As String = String.Empty

                Dim varNomeVendedorVinculado As String = String.Empty
                Dim varUtilizaCotaVendedorVinculado As String = String.Empty

                Dim varNomeAprovador As String = String.Empty

                Dim conn As OracleConnection = Nothing
                Dim oradbConn As String = String.Empty

                Dim oradb As String = AppUtils.dbConnectionString

                Dim drVendedor As OracleDataReader = Nothing
                Dim drAprovador As OracleDataReader = Nothing

                conn = New OracleConnection(oradb)
                conn.Open()

                Try
                    If userCustom.oUsuario.pCodigoVendedor IsNot Nothing Then
                        If userCustom.oUsuario.pCodigoVendedor.Trim <> "" Then
                            'É VENDEDOR, BUSCA DADOS
                            Dim cmdVendedor As New OracleCommand(String.Format("SELECT A3_COD, A3_NOME,A3_COTA FROM SA3010 SA3 WHERE SA3.D_E_L_E_T_ = ' ' AND A3_STATUS= '1' AND A3_FILIAL = '01' AND SA3.A3_COD = '{0}'", userCustom.oUsuario.pCodigoVendedor.Trim), conn) With {.CommandType = CommandType.Text}
                            'cmdVendedor.Parameters.Add(":p0", OracleDbType.Varchar2).Value = userCustom.oUsuario.pCodigoVendedor.Trim

                            Try
                                drVendedor = cmdVendedor.ExecuteReader()
                                If drVendedor.HasRows Then
                                    Do While drVendedor.Read
                                        varNomeVendedor = AppUtils.Nvl(drVendedor.Item("A3_NOME"), "").ToString.Trim
                                        varUtilizaCota = AppUtils.Nvl(drVendedor.Item("A3_COTA"), "").ToString.Trim
                                    Loop

                                    drVendedor.Close()
                                End If
                            Catch ex As Exception
                                'Return InternalServerError(ex)
                            Finally
                                If (Not (drVendedor) Is Nothing) Then
                                    drVendedor.Dispose()
                                End If
                            End Try
                        End If
                    ElseIf userCustom.oUsuario.pCodigoVendedor Is Nothing And userCustom.oUsuario.pCodigoVendedorVinculado IsNot Nothing Then
                        If userCustom.oUsuario.pCodigoVendedorVinculado.Trim <> "" Then
                            'É "SUB-VENDEDOR", POSSUI VENDEDOR VINCULADO, BUSCA DADOS
                            Dim cmdVendedor As New OracleCommand(String.Format("SELECT A3_COD, A3_NOME,A3_COTA FROM SA3010 SA3 WHERE SA3.D_E_L_E_T_ = ' ' AND A3_STATUS= '1' AND A3_FILIAL = '01' AND SA3.A3_COD = '{0}'", userCustom.oUsuario.pCodigoVendedorVinculado.Trim), conn) With {.CommandType = CommandType.Text}

                            Try
                                drVendedor = cmdVendedor.ExecuteReader()
                                If drVendedor.HasRows Then
                                    Do While drVendedor.Read
                                        varNomeVendedorVinculado = AppUtils.Nvl(drVendedor.Item("A3_NOME"), "").ToString.Trim
                                        varUtilizaCotaVendedorVinculado = AppUtils.Nvl(drVendedor.Item("A3_COTA"), "").ToString.Trim
                                    Loop

                                    drVendedor.Close()
                                End If
                            Catch ex As Exception
                                'Return InternalServerError(ex)
                            Finally
                                If (Not (drVendedor) Is Nothing) Then
                                    drVendedor.Dispose()
                                End If
                            End Try
                        End If
                    End If

                    If userCustom.oUsuario.pCodigoAprovador IsNot Nothing Then
                        If userCustom.oUsuario.pCodigoAprovador.Trim <> "" Then
                            'É APROVADOR, BUSCA DADOS
                            Dim cmdAprovador As New OracleCommand(String.Format("SELECT AK_NOME FROM SAK010 SAK  WHERE AK_USER = '{0}'  AND AK_FILIAL = '01'  AND SAK.D_E_L_E_T_ = ' '", userCustom.oUsuario.pCodigoAprovador.Trim), conn) With {.CommandType = CommandType.Text}
                            'cmdAprovador.Parameters.Add(":p0", OracleDbType.Varchar2).Value = userCustom.oUsuario.pCodigoAprovador.Trim

                            Try
                                drAprovador = cmdAprovador.ExecuteReader()
                                If drAprovador.HasRows Then
                                    Do While drAprovador.Read
                                        varNomeAprovador = AppUtils.Nvl(drAprovador.Item("AK_NOME"), "").ToString.Trim
                                    Loop

                                    drAprovador.Close()
                                End If
                            Catch ex As Exception
                                'Return InternalServerError(ex)
                            Finally
                                If (Not (drAprovador) Is Nothing) Then
                                    drAprovador.Dispose()
                                End If
                            End Try
                        End If
                    End If

                Catch ex As Exception

                Finally
                    conn.Close()
                End Try

                Dim listaRelatoriosUsuario = userCustom.oUsuario.oAppRelatorios.Select(Function(x) New S5TAppRelatoriosUsuario With {.nomeRelatorio = x.pNomeRelatorio,
                                                                                                                                      .tituloRelatorio = x.pTituloRelatorio,
                                                                                                                                      .sequencia = x.pSequencia,
                                                                                                                                      .nomeFormArgumento = x.pNomeFormArgumento}).ToList

                Dim objUsuarioAppPedido = New S5TUsuarioAppPedido With {.codigoVendedor = userCustom.oUsuario.pCodigoVendedor,
                                                                        .nomeVendedor = varNomeVendedor,
                                                                        .utilizaCota = varUtilizaCota,
                                                                        .codigoAprovador = userCustom.oUsuario.pCodigoAprovador,
                                                                        .nomeAprovador = varNomeAprovador,
                                                                        .codigoVendedorVinculado = userCustom.oUsuario.pCodigoVendedorVinculado,
                                                                        .nomeVendedorVinculado = varNomeVendedorVinculado,
                                                                        .codigoSubVendedor = userCustom.oUsuario.pCodigoSubVendedor,
                                                                        .relatoriosContagem = userCustom.oUsuario.oAppRelatorios.Count,
                                                                        .listaRelatorios = listaRelatoriosUsuario}

                Return Ok(objUsuarioAppPedido)
            End If
        End Function

        ' POST: api/UsuarioAppPedidos
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/UsuarioAppPedidos/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/UsuarioAppPedidos/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace