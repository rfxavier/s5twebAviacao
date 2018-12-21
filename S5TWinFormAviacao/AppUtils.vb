Imports System
Imports System.IO
Imports System.Web
Imports System.Configuration
Imports Oracle.DataAccess.Client
Imports DevExpress.DataAccess.ConnectionParameters
Imports System.Collections

Module AppUtils
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

        Return retmsg
    End Function
    Public Function exMsgHasTag(msg As String) As Boolean
        Return (msg.Substring(0, 1) = "[" And msg.IndexOf("]") > 0)
    End Function


    Function HasConnectionToDb() As Boolean
        Dim oradbConnMask As String = String.Empty
        Dim oradb As String = String.Empty


        If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
            If ConfigurationManager.AppSettings("dashDbPointer") = "LocalBI4T" Then
                oradbConnMask = ConfigurationManager.AppSettings("connOracleConnectionMask_LocalBI4T")
                oradb = String.Format(oradbConnMask, ConfigurationManager.AppSettings("dashDbUserName_LocalBI4T"), ConfigurationManager.AppSettings("dashDbPassword_LocalBI4T"))
            ElseIf ConfigurationManager.AppSettings("dashDbPointer") = "DbUAMBI4T" Then
                oradbConnMask = ConfigurationManager.AppSettings("connOracleConnectionMask_DbUAMBI4T")
                oradb = String.Format(oradbConnMask, ConfigurationManager.AppSettings("dashDbUserName_DbUAMBI4T"), ConfigurationManager.AppSettings("dashDbPassword_DbUAMBI4T"))
            End If
        End If

        'TENTA ABRIR CONEXÃO COM O BD 
        Dim conn As OracleConnection = New OracleConnection(oradb)

        Try
            conn.Open()

            HasConnectionToDb = True
        Catch ex As Exception
            HasConnectionToDb = False
        Finally
            conn.Close()
        End Try
    End Function

    Sub LogUserAccess(userName As String, relPath As String)
        Try
            If userName <> "admin@4t.com.br" Then
                Dim objLoginRegistro As New S5T.LoginRegistro

                objLoginRegistro.pLoginUsuario = userName
                objLoginRegistro.pObsLog = relPath
                objLoginRegistro.pDataHora = Now
                objLoginRegistro.Save()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function Nvl(Of T)(ByVal Value As T, ByVal DefaultValue As T) As T
        If Value Is Nothing OrElse IsDBNull(Value) OrElse Value.ToString = "" Then
            Return DefaultValue
        Else
            Return Value
        End If
    End Function

    Function dashConnectionParameters() As DevExpress.DataAccess.ConnectionParameters.DataConnectionParametersBase
        dashConnectionParameters = Nothing

        If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
            If ConfigurationManager.AppSettings("dashDbPointerDualInstance") = "LocalBI4T" Then
                Dim oraclepar = New OracleConnectionParameters

                oraclepar.ServerName = ConfigurationManager.AppSettings("dashDbServerName_LocalBI4T")
                oraclepar.UserName = ConfigurationManager.AppSettings("dashDbUserName_LocalBI4T")
                oraclepar.Password = ConfigurationManager.AppSettings("dashDbPassword_LocalBI4T")

                dashConnectionParameters = oraclepar

            ElseIf ConfigurationManager.AppSettings("dashDbPointer") = "DbUAMBI4T" Then

                Dim oraclepar = New OracleConnectionParameters

                oraclepar.ServerName = ConfigurationManager.AppSettings("dashDbServerName_DbUAMBI4T")
                oraclepar.UserName = ConfigurationManager.AppSettings("dashDbUserName_DbUAMBI4T")
                oraclepar.Password = ConfigurationManager.AppSettings("dashDbPassword_DbUAMBI4T")

                dashConnectionParameters = oraclepar
            End If
        ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
            Dim sqlserverpar = New MsSqlConnectionParameters

            If ConfigurationManager.AppSettings("dashDbAuthType_MSSqlServer") = "SqlServer" Then
                sqlserverpar.AuthorizationType = MsSqlAuthorizationType.SqlServer
            ElseIf ConfigurationManager.AppSettings("dashDbAuthType_MSSqlServer") = "Windows" Then
                sqlserverpar.AuthorizationType = MsSqlAuthorizationType.Windows
            End If

            sqlserverpar.ServerName = ConfigurationManager.AppSettings("dashDbServerName_MSSqlServer")
            sqlserverpar.DatabaseName = ConfigurationManager.AppSettings("dashDbDatabaseName_MSSqlServer")
            sqlserverpar.UserName = ConfigurationManager.AppSettings("dashDbUserName_MSSqlServer")
            sqlserverpar.Password = ConfigurationManager.AppSettings("dashDbPassword_MSSqlServer")

            dashConnectionParameters = sqlserverpar
        End If
    End Function

    Function dashConnectionParametersOracle() As DevExpress.DataAccess.ConnectionParameters.DataConnectionParametersBase
        dashConnectionParametersOracle = Nothing


        Dim oraclepar = New OracleConnectionParameters

        oraclepar.ServerName = ConfigurationManager.AppSettings("dashDbServerName_DbUAMBI4T")
        oraclepar.UserName = ConfigurationManager.AppSettings("dashDbUserName_DbUAMBI4T")
        oraclepar.Password = ConfigurationManager.AppSettings("dashDbPassword_DbUAMBI4T")

        dashConnectionParametersOracle = oraclepar

    End Function

    Function dbConnectionString() As String
        dbConnectionString = String.Empty

        'If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
        If ConfigurationManager.AppSettings("dashDbPointer") = "LocalBI4T" Then
            dbConnectionString = ConfigurationManager.AppSettings("connOracleConnection_LocalBI4T")
        ElseIf ConfigurationManager.AppSettings("dashDbPointer") = "DbUAMBI4T" Then
            dbConnectionString = ConfigurationManager.AppSettings("connOracleConnection_DbUAMBI4T")
        End If
        'End If
    End Function

    Function dbConnectionStringTeste() As String
        dbConnectionStringTeste = String.Empty

        'If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
        If ConfigurationManager.AppSettings("dashDbPointer") = "LocalBI4T_Teste" Then
            dbConnectionStringTeste = ConfigurationManager.AppSettings("connOracleConnection_LocalBI4T_Teste")
        ElseIf ConfigurationManager.AppSettings("dashDbPointer") = "DbUAMBI4T" Then
            dbConnectionStringTeste = ConfigurationManager.AppSettings("connOracleConnection_DbUAMBI4T_Teste")
        End If
        'End If
    End Function

    Function dbConnectionStringDesignTime() As String
        dbConnectionStringDesignTime = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.50.36)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=PROTHEUSPROD)));User Id=P11;Password=P1112;"
    End Function

    Function GetDashboardInstance(parDash As dashboardsList) As Object
        GetDashboardInstance = Nothing

        Select Case parDash
            Case dashboardsList.dashCnVendasVendasPorCliente
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasVendasPorClienteProdutoMSSQL
                End If
            Case dashboardsList.dashCnVendasVendasPorClienteAgrup
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasVendasPorClienteProdutoAgrupMSSQL
                End If
            Case dashboardsList.dashCnProducaoProducaoPedido
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoPedido
                End If
            Case dashboardsList.dashCnProducaoProducaoPedidoObjDs
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoPedidoObjDs
                End If
            Case dashboardsList.dashCnProducaoProducaoPedidoSemDetalhe
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoPedidoSemDetalhe
                End If
            Case dashboardsList.dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutro
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutro
                End If
            Case dashboardsList.dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroObjDs
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroObjDs
                End If
            Case dashboardsList.dashCnProducaoProducaoIndicadores
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoIndicadores
                End If
            Case dashboardsList.dashCnProducaoProducaoIndicadoresAnoMenos1
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoProducaoIndicadoresAnoMenos1
                End If
            Case dashboardsList.dashCnProducaoProducaoIndicadoresParaVendedor3Meses
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasIndicadoresParaVendedor3Meses
                End If
            Case dashboardsList.dashCnVendasComparativoClientes
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasComparativoClientes
                End If
            Case dashboardsList.dashCnVendasComparativoClientesProduto
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasComparativoClientesProduto
                End If
            Case dashboardsList.dashCnVendasComparativoClientesV2
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasComparativoClientesV2
                End If
            Case dashboardsList.dashCnVendasComparativoClientesComProdutoV2
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasComparativoClientesComProdutoV2
                End If
            Case dashboardsList.dashCnFinanceiroTitulosAbertoVendedor
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnFinanceiroTitulosAbertoVendedor
                End If
            Case dashboardsList.dashCnFinanceiroTitulosAbertoVendedorSeparado
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnFinanceiroTitulosAbertoVendedorSeparado
                End If
            Case dashboardsList.dashGerencialPorRegiaoGrupoproduto
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashGerencialPorRegiaoGrupoproduto
                End If
            Case dashboardsList.dashCnTransporteMovimentacaoDeViagemDash
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnTransporteMovimentacaoDeViagem
                End If
            Case dashboardsList.dashCnTransporteMovimentacaoDeViagemDashEmail
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnTransporteMovimentacaoDeViagemDashEmail
                End If
            Case dashboardsList.dashCnVendasMapaVendas
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnVendasMapaVendas
                End If
            Case dashboardsList.dashCnProducaoEstoqueMaturacao
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnProducaoEstoqueMaturacao
                End If
            Case dashboardsList.dashCnIndustriaEnvaseEventos
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashCnIndustriaEnvaseEventos
                End If

            Case dashboardsList.dashResumoSemanalDeProdutividade
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoSemanalDeProdutividade
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXEstagioP
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXEstagioP
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXEstagioPF
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXEstagioPF
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXPivoP
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXPivoP
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXPivoPF
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXPivoPF
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXPropriedadePF
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXPropriedadePF
                End If
            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXRegiaoDeCortePF
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXRegiaoDeCortePF
                End If

            Case dashboardsList.dashResumoDoFechamentoDeProdutividadeXVariedadePF
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoDeProdutividadeXVariedadePF
                End If
            Case dashboardsList.dashResumoDoFechamentoPorFazenda
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dash_ResumoDoFechamentoPorFazenda
                End If
            Case dashboardsList.dashProdutosLiberados
                If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
                    GetDashboardInstance = Nothing
                ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetDashboardInstance = New Win_Dashboards.dashProdutosLiberados
                End If


        End Select
    End Function

    Function dashXML(parDash As dashboardsList) As String
        dashXML = String.Empty
        Dim definitionPath As String = String.Empty
        Dim dashboardDefinition As String = String.Empty

        Select Case parDash
            'Case dashboardsList.dashCnEntCanaEntradasCanaMapa
            '    If ConfigurationManager.AppSettings("dashDbType") = "Oracle" Then
            '        definitionPath = HttpContext.Current.Server.MapPath("~/dashXmls/dashCnEntCanaEntradasCanaMapa.xml")
            '        dashboardDefinition = File.ReadAllText(definitionPath)

            '        dashXML = dashboardDefinition
            '    ElseIf ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
            '        definitionPath = HttpContext.Current.Server.MapPath("~/dashXmls/dashCnEntCanaEntradasCanaMapaMSSQL.xml")
            '        dashboardDefinition = File.ReadAllText(definitionPath)

            '        dashXML = dashboardDefinition
            '    End If
        End Select
    End Function

    Function dashboardEnumToString(parDash As dashboardsList) As String
        dashboardEnumToString = [Enum].GetName(GetType(AppUtils.dashboardsList), parDash)
    End Function

    Function GetReportInstance(parReport As reportsList) As Object
        GetReportInstance = Nothing

        Select Case parReport
            Case reportsList.repCnIndEnvaseOverview
                If ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    'GetReportInstance = New repCnIndEnvaseOverview
                End If

        End Select
    End Function

    Function GetReportTypeName(parReport As reportsList) As String
        GetReportTypeName = String.Empty

        Select Case parReport
            Case reportsList.repCnIndEnvaseOverview
                If ConfigurationManager.AppSettings("dashDbType") = "MSSqlServer" Then
                    GetReportTypeName = "AspNet5t.repCnIndEnvaseOverview"
                End If
        End Select
    End Function



    Enum dashboardsList
        dashCnVendasVendasPorCliente
        dashCnVendasVendasPorClienteAgrup
        dashCnProducaoProducaoPedido
        dashCnProducaoProducaoPedidoObjDs
        dashCnProducaoProducaoPedidoSemDetalhe
        dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutro
        dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroObjDs
        dashCnProducaoProducaoIndicadores
        dashCnProducaoProducaoIndicadoresAnoMenos1
        dashCnProducaoProducaoIndicadoresParaVendedor3Meses
        dashCnVendasComparativoClientes
        dashCnVendasComparativoClientesProduto
        dashCnVendasComparativoClientesV2
        dashCnVendasComparativoClientesComProdutoV2
        dashCnFinanceiroTitulosAbertoVendedor
        dashCnFinanceiroTitulosAbertoVendedorSeparado
        dashGerencialPorRegiaoGrupoproduto
        dashCnTransporteMovimentacaoDeViagemDash
        dashCnTransporteMovimentacaoDeViagemDashEmail
        dashCnVendasMapaVendas
        dashCnProducaoEstoqueMaturacao
        dashCnIndustriaEnvaseEventos
        dashResumoSemanalDeProdutividade
        dashResumoDoFechamentoDeProdutividadeXEstagioP
        dashResumoDoFechamentoDeProdutividadeXEstagioPF
        dashResumoDoFechamentoDeProdutividadeXPivoP
        dashResumoDoFechamentoDeProdutividadeXPivoPF
        dashResumoDoFechamentoDeProdutividadeXPropriedadePF
        dashResumoDoFechamentoDeProdutividadeXRegiaoDeCortePF
        dashResumoDoFechamentoDeProdutividadeXVariedadePF
        dashResumoDoFechamentoPorFazenda
        dashProdutosLiberados
    End Enum

    Enum reportsList
        repCnIndEnvaseOverview
    End Enum

    Function NvlDbNull(parListSourceFieldValue As Object) As Double
        Dim valRetorno As Double = 0

        If Not (TypeOf parListSourceFieldValue Is System.DBNull) Then
            valRetorno = Convert.ToDouble(parListSourceFieldValue)
        End If

        Return valRetorno
    End Function

    <System.Runtime.CompilerServices.Extension>
    Public Function IndexOfNth(input As String, value As String, startIndex As Integer, nth As Integer) As Integer
        If nth < 1 Then
            Throw New NotSupportedException("Param 'nth' must be greater than 0!")
        End If
        If nth = 1 Then
            Return input.IndexOf(value, startIndex)
        End If
        Dim idx = input.IndexOf(value, startIndex)
        If idx = -1 Then
            Return -1
        End If
        Return input.IndexOfNth(value, idx + 1, System.Threading.Interlocked.Decrement(nth))
    End Function

    Public Function pivot4tCriteriaListaClientesString(ByVal parCriteriaString As String, ByVal parClientesArr As ArrayList) As String
        Dim varRetorno As String = String.Empty

        If parClientesArr.Count > 0 Then
            If parClientesArr.Count = 1 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}')", parClientesArr(0))
            ElseIf parClientesArr.Count = 2 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}')", parClientesArr(0), parClientesArr(1))
            ElseIf parClientesArr.Count = 3 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}' Or [fieldpNOMECLIENTE] = '{2}')", parClientesArr(0), parClientesArr(1), parClientesArr(2))
            ElseIf parClientesArr.Count = 4 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}' Or [fieldpNOMECLIENTE] = '{2}' Or [fieldpNOMECLIENTE] = '{3}')", parClientesArr(0), parClientesArr(1), parClientesArr(2), parClientesArr(3))
            ElseIf parClientesArr.Count = 5 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}' Or [fieldpNOMECLIENTE] = '{2}' Or [fieldpNOMECLIENTE] = '{3}' Or [fieldpNOMECLIENTE] = '{4}')", parClientesArr(0), parClientesArr(1), parClientesArr(2), parClientesArr(3), parClientesArr(4))
            ElseIf parClientesArr.Count = 6 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}' Or [fieldpNOMECLIENTE] = '{2}' Or [fieldpNOMECLIENTE] = '{3}' Or [fieldpNOMECLIENTE] = '{4}' Or [fieldpNOMECLIENTE] = '{5}')", parClientesArr(0), parClientesArr(1), parClientesArr(2), parClientesArr(3), parClientesArr(4), parClientesArr(5))
            ElseIf parClientesArr.Count >= 7 Then
                varRetorno = String.Format("([fieldpNOMECLIENTE] = '{0}' Or [fieldpNOMECLIENTE] = '{1}' Or [fieldpNOMECLIENTE] = '{2}' Or [fieldpNOMECLIENTE] = '{3}' Or [fieldpNOMECLIENTE] = '{4}' Or [fieldpNOMECLIENTE] = '{5}' Or [fieldpNOMECLIENTE] = '{6}')", parClientesArr(0), parClientesArr(1), parClientesArr(2), parClientesArr(3), parClientesArr(4), parClientesArr(5), parClientesArr(6))
            End If

        End If

        pivot4tCriteriaListaClientesString = varRetorno
    End Function


End Module

