Imports Oracle.DataAccess.Client

Public Class dsFinanceiro
    Public Class TituloPorVendedorCliente
        Public Property pFILIAL As String
        Public Property pSERIE As String
        Public Property pNOTA As Integer
        Public Property pPARCELA As String
        Public Property pVENDEDOR As String
        Public Property pCODCLI As String
        Public Property pLOJA As Integer
        Public Property pNOMECLI As String
        Public Property pDATA_EMISSAO As Date
        Public Property pDATA_VENCIMENTO As Date
        Public Property pDATA_BAIXA As Date
        Public Property pVALOR_TITULO As Double
        Public Property pSALDO_TITULO As Double
        Public Property pCNPJ As String
        Public Property pENDERECO As String
        Public Property pBAIRRO As String
        Public Property pMUNICIPIO As String
        Public Property pESTADO As String

    End Class

    Public Shared Function GetTituloPorVendedorCliente(ByVal parCodVendedor As String, ByVal parCodCliente As String, ByVal parDataVectoInicial As Date, ByVal parDataVectoFinal As Date, ByVal parFlgStatusTitulos As String, ByVal parDataEmissaoInicial As Date, ByVal parDataEmissaoFinal As Date) As List(Of TituloPorVendedorCliente)
        'parFlgStatusTitulos
        'A = Aberto
        'F = Fechado

        Dim Titulos = New List(Of TituloPorVendedorCliente)

        Dim varSinalDeComparacao As String = ">" 'Default = 'A'

        If parFlgStatusTitulos.ToUpper() = "A" Then
            varSinalDeComparacao = ">"
        ElseIf parFlgStatusTitulos.ToUpper() = "F" Then
            varSinalDeComparacao = "<="
        End If

        Dim varSql = ""
        varSql = varSql & " Select E1.E1_FILIAL FILIAL, E1.E1_PREFIXO AS SERIE, E1_NUM AS NOTA, E1.E1_PARCELA AS PARCELA, "
        varSql = varSql & " E1.E1_VEND1 AS VENDEDOR, E1_CLIENTE AS CODCLI, E1_LOJA AS LOJA, "

        'PARTE DA QUERY QUE TRAZ O NOME DO CLIENTE
        varSql = varSql & " (select TRIM(min(e2.E1_NOMCLI)) From SE1010 E2 Where e2.e1_cliente = e1.e1_cliente "
        varSql = varSql & " And E2.E1_SALDO {4} '0' And E2.D_E_L_E_T_ = ' ' "
        varSql = varSql & " And E2.E1_VEND1 BETWEEN '{0}' AND '{0}' "
        varSql = varSql & " And E2.E1_TIPO = 'NF') as NOMECLI, "

        varSql = varSql & " TO_DATE(E1.E1_EMISSAO, 'YYYY/MM/DD') AS DATA_EMISSAO, "
        varSql = varSql & " TO_DATE(E1.E1_VENCREA, 'YYYY/MM/DD') AS DATA_VENCIMENTO, "
        varSql = varSql & " E1.E1_VALOR AS VALOR_TITULO, "
        varSql = varSql & " E1.E1_SALDO AS SALDO_TITULO, "
        varSql = varSql & " A1.A1_CGC AS CNPJ, "
        varSql = varSql & " A1.A1_END AS ENDERECO, A1.A1_BAIRRO as BAIRRO, "
        varSql = varSql & " A1.A1_MUN as MUNICIPIO, A1.A1_EST AS ESTADO, "
        varSql = varSql & " decode(E1.E1_BAIXA,'        ',null,TO_DATE(E1.E1_BAIXA, 'YYYY/MM/DD')) AS DATA_BAIXA"
        'varSql = varSql & " E1.E1_BAIXA AS DATA_BAIXA"
        varSql = varSql & " FROM "
        varSql = varSql & " SE1010 E1 "
        varSql = varSql & " INNER Join SA1010 A1 On "
        varSql = varSql & " A1.A1_FILIAL = E1.E1_FILIAL "
        varSql = varSql & " And A1.A1_COD = E1.E1_CLIENTE "
        varSql = varSql & " And A1.A1_LOJA = E1.E1_LOJA "
        varSql = varSql & " And A1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " WHERE "
        varSql = varSql & " E1.E1_SALDO {4} '0' And E1.D_E_L_E_T_ = ' ' And E1.E1_TIPO = 'NF' "
        varSql = varSql & " And Trim(E1_VEND1) BETWEEN '{0}' AND '{0}' "
        varSql = varSql & " And E1.E1_CLIENTE = '{1}' "
        varSql = varSql & " And E1.E1_VENCREA >= '{2}' "
        varSql = varSql & " And E1.E1_VENCREA <= '{3}' "
        varSql = varSql & " And E1.E1_EMISSAO >= '{5}' "
        varSql = varSql & " And E1.E1_EMISSAO <= '{6}' "

        varSql = String.Format(varSql, parCodVendedor, parCodCliente, parDataVectoInicial.ToString("yyyyMMdd"), parDataVectoFinal.ToString("yyyyMMdd"), varSinalDeComparacao, parDataEmissaoInicial.ToString("yyyyMMdd"), parDataEmissaoFinal.ToString("yyyyMMdd"))

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdTitulos As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drTitulos As OracleDataReader = Nothing
        Try
            drTitulos = cmdTitulos.ExecuteReader()
            If drTitulos.HasRows Then
                Do While drTitulos.Read
                    Dim objTitulo = New TituloPorVendedorCliente

                    objTitulo.pFILIAL = AppUtils.Nvl(drTitulos.Item("FILIAL"), "").ToString.Trim
                    objTitulo.pSERIE = AppUtils.Nvl(drTitulos.Item("SERIE"), "").ToString.Trim
                    objTitulo.pNOTA = AppUtils.Nvl(drTitulos.Item("NOTA"), 0).ToString.Trim
                    objTitulo.pPARCELA = AppUtils.Nvl(drTitulos.Item("PARCELA"), "").ToString.Trim
                    objTitulo.pVENDEDOR = AppUtils.Nvl(drTitulos.Item("VENDEDOR"), "").ToString.Trim
                    objTitulo.pCODCLI = AppUtils.Nvl(drTitulos.Item("CODCLI"), "").ToString.Trim
                    objTitulo.pLOJA = AppUtils.Nvl(drTitulos.Item("LOJA"), "").ToString.Trim
                    objTitulo.pNOMECLI = AppUtils.Nvl(drTitulos.Item("NOMECLI"), "").ToString.Trim
                    objTitulo.pDATA_EMISSAO = AppUtils.Nvl(drTitulos.Item("DATA_EMISSAO"), DateTime.MinValue).ToString.Trim
                    objTitulo.pDATA_VENCIMENTO = AppUtils.Nvl(drTitulos.Item("DATA_VENCIMENTO"), DateTime.MinValue).ToString.Trim
                    objTitulo.pDATA_BAIXA = AppUtils.Nvl(drTitulos.Item("DATA_BAIXA"), DateTime.MinValue).ToString.Trim
                    objTitulo.pVALOR_TITULO = AppUtils.Nvl(drTitulos.Item("VALOR_TITULO"), 0).ToString.Trim
                    objTitulo.pSALDO_TITULO = AppUtils.Nvl(drTitulos.Item("SALDO_TITULO"), 0).ToString.Trim
                    objTitulo.pCNPJ = AppUtils.Nvl(drTitulos.Item("CNPJ"), "").ToString.Trim
                    objTitulo.pENDERECO = AppUtils.Nvl(drTitulos.Item("ENDERECO"), "").ToString.Trim
                    objTitulo.pBAIRRO = AppUtils.Nvl(drTitulos.Item("BAIRRO"), "").ToString.Trim
                    objTitulo.pMUNICIPIO = AppUtils.Nvl(drTitulos.Item("MUNICIPIO"), "").ToString.Trim
                    objTitulo.pESTADO = AppUtils.Nvl(drTitulos.Item("ESTADO"), "").ToString.Trim

                    Titulos.Add(objTitulo)
                Loop

                drTitulos.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drTitulos) Is Nothing) Then
                drTitulos.Dispose()
            End If
        End Try

        Return Titulos
    End Function
End Class
