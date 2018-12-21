Imports Oracle.DataAccess.Client

Public Class dsVendas
    Public Class VendasVendedorPeriodo
        Public Property pNUMERO_NF As String
        Public Property pSERIE As String
        Public Property pCLIENTE As String
        Public Property pCNPJCLIENTE As String
        Public Property pFILIAL As Integer
        Public Property pLOJA As String
        Public Property pNOME_CLIENTE As String
        Public Property pEND_CLIENTE As String
        Public Property pESTADO_CLIENTE As String
        Public Property pCIDADE_CLIENTE As String
        Public Property pBAIRRO_CLIENTE As String
        Public Property pCODIGO_VENDEDOR As String
        Public Property pNOME_VENDEDOR As String
        Public Property pDATA_EMISSAO As Date
        Public Property pPRODUTO As String
        Public Property pGRUPO_PRODUTO As String
        Public Property pQTD_EM_CAIXA As Double
        Public Property pPESO_TOTAL As Double
        Public Property pDESCRICAO As String
        Public Property pQUANTIDADE As Double
        Public Property pVLR_TOTAL_PRODUTO As Double
        Public Property pVLR_DESCONTO As Double
        Public Property pVLR_TOTAL_NOTA As Double
        Public Property pVLR_SEM_ICMSST As Double
        Public Property pNRO_PEDIDO_CLIENTE As String
        Public Property pVLR_ST As Double
        Public Property pVLR_TOTAL_PRODUTO_SEMST As Double
        Public Property pUNIDADE As String

    End Class

    Public Class PedidosAbertosVendedorPeriodo
        Public Property pFILIAL As Integer
        Public Property pNUMERO_PED As String
        Public Property pDATA_EMISSAO As Date
        Public Property pCLIENTE As String
        Public Property pLOJA As String
        Public Property pCODIGO_VENDEDOR As String
        Public Property pNOME_CLIENTE As String
        Public Property pEND_CLIENTE As String
        Public Property pESTADO_CLIENTE As String
        Public Property pCIDADE_CLIENTE As String
        Public Property pBAIRRO_CLIENTE As String
        Public Property pNOME_VENDEDOR As String
        Public Property pCNPJCLIENTE As String
        Public Property pPRODUTO As String
        Public Property pDESCRICAO As String
        Public Property pQUANTIDADE As Double
        Public Property pVLR_UNIT_PRODUTO As Double
        Public Property pVLR_VEN_PRODUTO As Double
        Public Property pVLR_TOTAL_PRODUTO As Double

    End Class

    Public Class ClientesBloqueados
        Public Property pFILIAL As Integer
        Public Property pCOD_CLIENTE As String
        Public Property pLOJA As String
        Public Property pNOME_CLIENTE As String
        Public Property pEND_CLIENTE As String
        Public Property pCNPJ_CLIENTE As String
    End Class



    Public Shared Function GetVendasVendedorPeriodo(ByVal parCodVendedor As String, ByVal parDataInicial As Date, parDataFinal As Date) As List(Of VendasVendedorPeriodo)
        'sql antigo - antes da troca de layout e estrutura do protheus 10/05/18
        'Dim Vendas = New List(Of VendasVendedorPeriodo)

        'Dim varSql = ""
        'varSql = varSql & " Select D2.D2_FILIAL FILIAL, D2.D2_COD COD, B1.B1_DESC DESCRICAO, SUM(D2.D2_QUANT) QUANTIDADE, "
        'varSql = varSql & " D2.D2_UM UNIDADE, D2.D2_PRCVEN PRECO_VENDA, SUM(D2.D2_TOTAL) TOTAL_ITEM, D2.D2_CF CFOP, "
        'varSql = varSql & " D2.D2_PEDIDO NRO_PEDIDO, D2.D2_CLIENTE COD_CLIENTE, A1.A1_NOME CLIENTE, A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, D2.D2_LOJA LOJA, "
        'varSql = varSql & " D2.D2_DOC DOCUMENTO, D2.D2_SERIE SERIE, TO_DATE(D2.D2_EMISSAO,'YYYYMMDD') EMISSAO, SUM(D2.D2_DESCON) DESCONTO, "
        'varSql = varSql & " SUM(D2.D2_ICMSRET) ST, F2.F2_VEND1 COD_VEND, A3.A3_NOME NOME_VEND, A1.A1_CGC CNPJ_CLIENTE"
        'varSql = varSql & " FROM "
        'varSql = varSql & " SD2010 D2 INNER Join SB1010 B1 On "
        'varSql = varSql & " B1.B1_FILIAL = D2.D2_FILIAL And "
        'varSql = varSql & " B1.B1_COD = D2.D2_COD And B1.D_E_L_E_T_ = ' ' "
        'varSql = varSql & " INNER Join SA1010 A1 ON "
        'varSql = varSql & " A1.A1_FILIAL = D2.D2_FILIAL And A1.A1_COD = D2.D2_CLIENTE And "
        'varSql = varSql & " A1.A1_LOJA = D2.D2_LOJA And A1.D_E_L_E_T_ = ' ' "
        'varSql = varSql & " INNER JOIN SF2010 F2 ON "
        'varSql = varSql & " F2.F2_FILIAL = D2.D2_FILIAL And F2.F2_DOC = D2.D2_DOC And "
        'varSql = varSql & " F2.F2_SERIE = D2.D2_SERIE And F2.F2_CLIENTE = D2.D2_CLIENTE And F2.F2_LOJA = D2.D2_LOJA And F2.D_E_L_E_T_ = ' ' "
        'varSql = varSql & " INNER Join SA3010 A3 on "
        'varSql = varSql & " A3.A3_COD = F2.F2_VEND1 and A3.D_E_L_E_T_ = ' ' "
        'varSql = varSql & " WHERE "
        'varSql = varSql & " D2.D_E_L_E_T_ = ' ' AND D2_EMISSAO BETWEEN '{1}' AND '{2}' AND F2.F2_VEND1 = '{0}' AND "
        'varSql = varSql & " D2.D2_COD BETWEEN ' ' AND 'ZZZZZZ' AND D2.D2_LOJA BETWEEN ' ' AND 'ZZ' "
        'varSql = varSql & " GROUP BY "
        'varSql = varSql & " D2.D2_FILIAL,  D2.D2_COD,  B1.B1_DESC,  D2.D2_UM,  D2.D2_PRCVEN,  D2.D2_CF,  D2.D2_PEDIDO,  D2.D2_CLIENTE, "
        'varSql = varSql & " A1.A1_NOME, D2.D2_LOJA, D2.D2_DOC, D2.D2_SERIE, D2.D2_EMISSAO, F2.F2_VEND1, A3.A3_NOME, "
        'varSql = varSql & " A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, A1.A1_CGC "
        'varSql = varSql & " ORDER BY  A1.A1_CGC,  D2.D2_EMISSAO,  D2.D2_DOC"

        'varSql = String.Format(varSql, parCodVendedor, parDataInicial.ToString("yyyyMMdd"), parDataFinal.ToString("yyyyMMdd"))

        'Dim conn As OracleConnection = Nothing
        'Dim oradbConn As String = String.Empty

        'Dim oradb As String = AppUtils.dbConnectionString

        'conn = New OracleConnection(oradb)
        'conn.Open()

        'Dim cmdVendas As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        ''Dim cmdProduto As OracleCommand

        'Dim drVendas As OracleDataReader = Nothing
        'Try
        '    drVendas = cmdVendas.ExecuteReader()
        '    If drVendas.HasRows Then
        '        Do While drVendas.Read
        '            Dim objVenda = New VendasVendedorPeriodo

        '            objVenda.pNUMERO_NF = AppUtils.Nvl(drVendas.Item("DOCUMENTO"), "").ToString.Trim
        '            objVenda.pSERIE = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
        '            objVenda.pCLIENTE = AppUtils.Nvl(drVendas.Item("COD_CLIENTE"), "").ToString.Trim
        '            objVenda.pCNPJCLIENTE = AppUtils.Nvl(drVendas.Item("CNPJ_CLIENTE"), "").ToString.Trim
        '            objVenda.pFILIAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
        '            objVenda.pLOJA = AppUtils.Nvl(drVendas.Item("FILIAL"), "").ToString.Trim
        '            objVenda.pNOME_CLIENTE = AppUtils.Nvl(drVendas.Item("CLIENTE"), "").ToString.Trim
        '            objVenda.pEND_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_END"), "").ToString.Trim
        '            objVenda.pBAIRRO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_BAIRRO"), "").ToString.Trim
        '            objVenda.pCIDADE_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_MUN"), "").ToString.Trim
        '            objVenda.pESTADO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_EST"), "").ToString.Trim
        '            objVenda.pCODIGO_VENDEDOR = AppUtils.Nvl(drVendas.Item("COD_VEND"), "").ToString.Trim
        '            objVenda.pNOME_VENDEDOR = AppUtils.Nvl(drVendas.Item("NOME_VEND"), "").ToString.Trim
        '            objVenda.pDATA_EMISSAO = AppUtils.Nvl(drVendas.Item("EMISSAO"), datetime.MinValue)
        '            objVenda.pPRODUTO = AppUtils.Nvl(drVendas.Item("COD"), "").ToString.Trim
        '            objVenda.pGRUPO_PRODUTO = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
        '            objVenda.pQTD_EM_CAIXA = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
        '            objVenda.pPESO_TOTAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
        '            objVenda.pDESCRICAO = AppUtils.Nvl(drVendas.Item("DESCRICAO"), "").ToString.Trim
        '            objVenda.pQUANTIDADE = AppUtils.Nvl(drVendas.Item("QUANTIDADE"), 0)
        '            objVenda.pVLR_TOTAL_PRODUTO = AppUtils.Nvl(drVendas.Item("TOTAL_ITEM"), 0)
        '            objVenda.pVLR_DESCONTO = AppUtils.Nvl(drVendas.Item("DESCONTO"), 0)
        '            objVenda.pVLR_TOTAL_NOTA = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
        '            objVenda.pVLR_SEM_ICMSST = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
        '            objVenda.pNRO_PEDIDO_CLIENTE = AppUtils.Nvl(drVendas.Item("NRO_PEDIDO"), "").ToString.Trim
        '            objVenda.pVLR_ST = AppUtils.Nvl(drVendas.Item("ST"), 0)
        '            objVenda.pUNIDADE = AppUtils.Nvl(drVendas.Item("UNIDADE"), "").ToString.Trim


        '            Vendas.Add(objVenda)
        '        Loop

        '        drVendas.Close()
        '    End If
        'Catch ex As Exception
        '    'Return InternalServerError(ex)
        'Finally
        '    conn.Close()
        '    If (Not (drVendas) Is Nothing) Then
        '        drVendas.Dispose()
        '    End If
        'End Try

        'Return Vendas

        Dim Vendas = New List(Of VendasVendedorPeriodo)

        Dim varSql = ""
        varSql = varSql & " Select D2.D2_FILIAL FILIAL, D2.D2_COD COD, B1.B1_DESC DESCRICAO, SUM(D2.D2_QUANT) QUANTIDADE, "
        varSql = varSql & " D2.D2_UM UNIDADE, D2.D2_PRCVEN PRECO_VENDA, SUM(D2.D2_TOTAL) TOTAL_ITEM, D2.D2_CF CFOP, "
        varSql = varSql & " D2.D2_PEDIDO NRO_PEDIDO, D2.D2_CLIENTE COD_CLIENTE, A1.A1_NOME CLIENTE, A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, D2.D2_LOJA LOJA, "
        varSql = varSql & " D2.D2_DOC DOCUMENTO, D2.D2_SERIE SERIE, TO_DATE(D2.D2_EMISSAO,'YYYYMMDD') EMISSAO, SUM(D2.D2_DESCON) DESCONTO, "
        varSql = varSql & " SUM(D2.D2_ICMSRET) ST, (SUM(D2.D2_TOTAL) - SUM(D2.D2_ICMSRET)) TOTAL_ITEM_SEMST, F2.F2_VEND1 COD_VEND, A3.A3_NOME NOME_VEND, A1.A1_CGC CNPJ_CLIENTE"
        varSql = varSql & " FROM "
        varSql = varSql & " SD2010 D2 INNER Join SB1010 B1 On "
        varSql = varSql & " B1.B1_FILIAL = D2.D2_FILIAL And "
        varSql = varSql & " B1.B1_COD = D2.D2_COD And B1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER Join SA1010 A1 ON "
        varSql = varSql & " A1.A1_FILIAL = D2.D2_FILIAL And A1.A1_COD = D2.D2_CLIENTE And "
        varSql = varSql & " A1.A1_LOJA = D2.D2_LOJA And A1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER JOIN SF2010 F2 ON "
        varSql = varSql & " F2.F2_FILIAL = D2.D2_FILIAL And F2.F2_DOC = D2.D2_DOC And "
        varSql = varSql & " F2.F2_SERIE = D2.D2_SERIE And F2.F2_CLIENTE = D2.D2_CLIENTE And F2.F2_LOJA = D2.D2_LOJA And F2.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER Join SA3010 A3 on "
        varSql = varSql & " A3.A3_FILIAL = F2.F2_FILIAL AND A3.A3_COD = F2.F2_VEND1 and A3.D_E_L_E_T_ = ' ' "
        varSql = varSql & " WHERE "
        varSql = varSql & " D2.D_E_L_E_T_ = ' ' AND D2_EMISSAO BETWEEN '{1}' AND '{2}' AND F2.F2_VEND1 = '{0}' AND "
        varSql = varSql & " D2.D2_COD BETWEEN ' ' AND 'ZZZZZZ' "
        varSql = varSql & " GROUP BY "
        varSql = varSql & " D2.D2_FILIAL,  D2.D2_COD,  B1.B1_DESC,  D2.D2_UM,  D2.D2_PRCVEN,  D2.D2_CF,  D2.D2_PEDIDO,  D2.D2_CLIENTE, "
        varSql = varSql & " A1.A1_NOME, D2.D2_LOJA, D2.D2_DOC, D2.D2_SERIE, D2.D2_EMISSAO, F2.F2_VEND1, A3.A3_NOME, "
        varSql = varSql & " A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, A1.A1_CGC "
        varSql = varSql & " ORDER BY  A1.A1_CGC,  D2.D2_EMISSAO,  D2.D2_DOC"

        varSql = String.Format(varSql, parCodVendedor, parDataInicial.ToString("yyyyMMdd"), parDataFinal.ToString("yyyyMMdd"))

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdVendas As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drVendas As OracleDataReader = Nothing
        Try
            drVendas = cmdVendas.ExecuteReader()
            If drVendas.HasRows Then
                Do While drVendas.Read
                    Dim objVenda = New VendasVendedorPeriodo

                    objVenda.pNUMERO_NF = AppUtils.Nvl(drVendas.Item("DOCUMENTO"), "").ToString.Trim
                    objVenda.pSERIE = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
                    objVenda.pCLIENTE = AppUtils.Nvl(drVendas.Item("COD_CLIENTE"), "").ToString.Trim
                    objVenda.pCNPJCLIENTE = AppUtils.Nvl(drVendas.Item("CNPJ_CLIENTE"), "").ToString.Trim
                    objVenda.pFILIAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pLOJA = AppUtils.Nvl(drVendas.Item("FILIAL"), "").ToString.Trim
                    objVenda.pNOME_CLIENTE = AppUtils.Nvl(drVendas.Item("CLIENTE"), "").ToString.Trim
                    objVenda.pEND_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_END"), "").ToString.Trim
                    objVenda.pBAIRRO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_BAIRRO"), "").ToString.Trim
                    objVenda.pCIDADE_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_MUN"), "").ToString.Trim
                    objVenda.pESTADO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_EST"), "").ToString.Trim
                    objVenda.pCODIGO_VENDEDOR = AppUtils.Nvl(drVendas.Item("COD_VEND"), "").ToString.Trim
                    objVenda.pNOME_VENDEDOR = AppUtils.Nvl(drVendas.Item("NOME_VEND"), "").ToString.Trim
                    objVenda.pDATA_EMISSAO = AppUtils.Nvl(drVendas.Item("EMISSAO"), datetime.MinValue)
                    objVenda.pPRODUTO = AppUtils.Nvl(drVendas.Item("COD"), "").ToString.Trim
                    objVenda.pGRUPO_PRODUTO = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
                    objVenda.pQTD_EM_CAIXA = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pPESO_TOTAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pDESCRICAO = AppUtils.Nvl(drVendas.Item("DESCRICAO"), "").ToString.Trim
                    objVenda.pQUANTIDADE = AppUtils.Nvl(drVendas.Item("QUANTIDADE"), 0)
                    objVenda.pVLR_TOTAL_PRODUTO = AppUtils.Nvl(drVendas.Item("TOTAL_ITEM"), 0)
                    objVenda.pVLR_DESCONTO = AppUtils.Nvl(drVendas.Item("DESCONTO"), 0)
                    objVenda.pVLR_TOTAL_NOTA = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
                    objVenda.pVLR_SEM_ICMSST = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
                    objVenda.pNRO_PEDIDO_CLIENTE = AppUtils.Nvl(drVendas.Item("NRO_PEDIDO"), "").ToString.Trim
                    objVenda.pVLR_ST = AppUtils.Nvl(drVendas.Item("ST"), 0)
                    objVenda.pVLR_TOTAL_PRODUTO_SEMST = AppUtils.Nvl(drVendas.Item("TOTAL_ITEM_SEMST"), 0)
                    objVenda.pUNIDADE = AppUtils.Nvl(drVendas.Item("UNIDADE"), "").ToString.Trim


                    Vendas.Add(objVenda)
                Loop

                drVendas.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drVendas) Is Nothing) Then
                drVendas.Dispose()
            End If
        End Try

        Return Vendas




    End Function

    Public Shared Function GetVendasVendedorClientePeriodo(ByVal parCodVendedor As String, parCodCliente As String, parCodLoja As String, ByVal parDataInicial As Date, parDataFinal As Date) As List(Of VendasVendedorPeriodo)
        Dim Vendas = New List(Of VendasVendedorPeriodo)

        Dim varSql = ""
        varSql = varSql & " Select D2.D2_FILIAL FILIAL, D2.D2_COD COD, B1.B1_DESC DESCRICAO, SUM(D2.D2_QUANT) QUANTIDADE, "
        varSql = varSql & " D2.D2_UM UNIDADE, D2.D2_PRCVEN PRECO_VENDA, SUM(D2.D2_TOTAL) TOTAL_ITEM, D2.D2_CF CFOP, "
        varSql = varSql & " D2.D2_PEDIDO NRO_PEDIDO, D2.D2_CLIENTE COD_CLIENTE, A1.A1_NOME CLIENTE, A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, D2.D2_LOJA LOJA, "
        varSql = varSql & " D2.D2_DOC DOCUMENTO, D2.D2_SERIE SERIE, TO_DATE(D2.D2_EMISSAO,'YYYYMMDD') EMISSAO, SUM(D2.D2_DESCON) DESCONTO, "
        varSql = varSql & " SUM(D2.D2_ICMSRET) ST, (SUM(D2.D2_TOTAL) - SUM(D2.D2_ICMSRET)) TOTAL_ITEM_SEMST, F2.F2_VEND1 COD_VEND, A3.A3_NOME NOME_VEND, A1.A1_CGC CNPJ_CLIENTE"
        varSql = varSql & " FROM "
        varSql = varSql & " SD2010 D2 INNER Join SB1010 B1 On "
        varSql = varSql & " B1.B1_FILIAL = D2.D2_FILIAL And "
        varSql = varSql & " B1.B1_COD = D2.D2_COD And B1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER Join SA1010 A1 ON "
        varSql = varSql & " A1.A1_FILIAL = D2.D2_FILIAL And A1.A1_COD = D2.D2_CLIENTE And "
        varSql = varSql & " A1.A1_LOJA = D2.D2_LOJA And A1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER JOIN SF2010 F2 ON "
        varSql = varSql & " F2.F2_FILIAL = D2.D2_FILIAL And F2.F2_DOC = D2.D2_DOC And "
        varSql = varSql & " F2.F2_SERIE = D2.D2_SERIE And F2.F2_CLIENTE = D2.D2_CLIENTE And F2.F2_LOJA = D2.D2_LOJA And F2.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER Join SA3010 A3 on "
        varSql = varSql & " A3.A3_FILIAL = F2.F2_FILIAL AND A3.A3_COD = F2.F2_VEND1 and A3.D_E_L_E_T_ = ' ' "
        varSql = varSql & " WHERE "
        varSql = varSql & " D2.D_E_L_E_T_ = ' ' AND D2_EMISSAO BETWEEN '{1}' AND '{2}' AND F2.F2_VEND1 = '{0}' AND "
        varSql = varSql & " D2.D2_CLIENTE = '{3}' AND D2.D2_LOJA = '{4}' AND "
        varSql = varSql & " D2.D2_COD BETWEEN ' ' AND 'ZZZZZZ' "
        varSql = varSql & " GROUP BY "
        varSql = varSql & " D2.D2_FILIAL,  D2.D2_COD,  B1.B1_DESC,  D2.D2_UM,  D2.D2_PRCVEN,  D2.D2_CF,  D2.D2_PEDIDO,  D2.D2_CLIENTE, "
        varSql = varSql & " A1.A1_NOME, D2.D2_LOJA, D2.D2_DOC, D2.D2_SERIE, D2.D2_EMISSAO, F2.F2_VEND1, A3.A3_NOME, "
        varSql = varSql & " A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, A1.A1_CGC "
        varSql = varSql & " ORDER BY  A1.A1_CGC,  D2.D2_EMISSAO,  D2.D2_DOC"

        varSql = String.Format(varSql, parCodVendedor, parDataInicial.ToString("yyyyMMdd"), parDataFinal.ToString("yyyyMMdd"), parCodCliente, parCodLoja)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdVendas As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drVendas As OracleDataReader = Nothing
        Try
            drVendas = cmdVendas.ExecuteReader()
            If drVendas.HasRows Then
                Do While drVendas.Read
                    Dim objVenda = New VendasVendedorPeriodo

                    objVenda.pNUMERO_NF = AppUtils.Nvl(drVendas.Item("DOCUMENTO"), "").ToString.Trim
                    objVenda.pSERIE = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
                    objVenda.pCLIENTE = AppUtils.Nvl(drVendas.Item("COD_CLIENTE"), "").ToString.Trim
                    objVenda.pCNPJCLIENTE = AppUtils.Nvl(drVendas.Item("CNPJ_CLIENTE"), "").ToString.Trim
                    objVenda.pFILIAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pLOJA = AppUtils.Nvl(drVendas.Item("FILIAL"), "").ToString.Trim
                    objVenda.pNOME_CLIENTE = AppUtils.Nvl(drVendas.Item("CLIENTE"), "").ToString.Trim
                    objVenda.pEND_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_END"), "").ToString.Trim
                    objVenda.pBAIRRO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_BAIRRO"), "").ToString.Trim
                    objVenda.pCIDADE_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_MUN"), "").ToString.Trim
                    objVenda.pESTADO_CLIENTE = AppUtils.Nvl(drVendas.Item("A1_EST"), "").ToString.Trim
                    objVenda.pCODIGO_VENDEDOR = AppUtils.Nvl(drVendas.Item("COD_VEND"), "").ToString.Trim
                    objVenda.pNOME_VENDEDOR = AppUtils.Nvl(drVendas.Item("NOME_VEND"), "").ToString.Trim
                    objVenda.pDATA_EMISSAO = AppUtils.Nvl(drVendas.Item("EMISSAO"), datetime.MinValue)
                    objVenda.pPRODUTO = AppUtils.Nvl(drVendas.Item("COD"), "").ToString.Trim
                    objVenda.pGRUPO_PRODUTO = "" 'AppUtils.Nvl(drVendas.Item(""), "").ToString.Trim
                    objVenda.pQTD_EM_CAIXA = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pPESO_TOTAL = 0 'AppUtils.Nvl(drVendas.Item(""), 0)
                    objVenda.pDESCRICAO = AppUtils.Nvl(drVendas.Item("DESCRICAO"), "").ToString.Trim
                    objVenda.pQUANTIDADE = AppUtils.Nvl(drVendas.Item("QUANTIDADE"), 0)
                    objVenda.pVLR_TOTAL_PRODUTO = AppUtils.Nvl(drVendas.Item("TOTAL_ITEM"), 0)
                    objVenda.pVLR_DESCONTO = AppUtils.Nvl(drVendas.Item("DESCONTO"), 0)
                    objVenda.pVLR_TOTAL_NOTA = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
                    objVenda.pVLR_SEM_ICMSST = 0 'AppUtils.Nvl(drVendas.Item(""), 0).ToString.Trim
                    objVenda.pNRO_PEDIDO_CLIENTE = AppUtils.Nvl(drVendas.Item("NRO_PEDIDO"), "").ToString.Trim
                    objVenda.pVLR_ST = AppUtils.Nvl(drVendas.Item("ST"), 0)
                    objVenda.pVLR_TOTAL_PRODUTO_SEMST = AppUtils.Nvl(drVendas.Item("TOTAL_ITEM_SEMST"), 0)
                    objVenda.pUNIDADE = AppUtils.Nvl(drVendas.Item("UNIDADE"), "").ToString.Trim


                    Vendas.Add(objVenda)
                Loop

                drVendas.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drVendas) Is Nothing) Then
                drVendas.Dispose()
            End If
        End Try

        Return Vendas
    End Function

    Public Shared Function GetPedidosAbertosVendedorClientePeriodo(ByVal parCodVendedor As String, parCodCliente As String, parCodLoja As String, ByVal parDataInicial As Date, parDataFinal As Date) As List(Of PedidosAbertosVendedorPeriodo)
        Dim Pedidos = New List(Of PedidosAbertosVendedorPeriodo)

        Dim varSql = ""
        varSql = varSql & " SELECT C5.C5_FILIAL FILIAL, C5.C5_NUM PEDIDO, to_date(C5.C5_EMISSAO,'YYYYMMDD') EMISSAO, "
        varSql = varSql & " C5.C5_CLIENTE COD_CLIENTE, C5.C5_LOJACLI LOJA, C5.C5_VEND1 COD_VENDEDOR, "
        varSql = varSql & " A1.A1_NOME CLIENTE, A1.A1_END, A1.A1_EST, A1.A1_MUN, A1.A1_BAIRRO, A3.A3_NOME NOME_VEND, "
        varSql = varSql & " A1.A1_CGC CNPJ_CLIENTE, C6.C6_PRODUTO COD_PRODUTO, C6.C6_DESCRI DESC_PRODUTO,"
        varSql = varSql & " C6.C6_QTDVEN QTDE, C6.C6_PRUNIT VL_UNIT, C6.C6_PRCVEN VL_VENDA, C6.C6_VALOR VL_TOTAL"
        varSql = varSql & " FROM "
        varSql = varSql & " SC5010 C5 INNER JOIN SC6010 C6 ON"
        varSql = varSql & " C6.C6_FILIAL = C5.C5_FILIAL AND C6.C6_NUM = C5.C5_NUM AND C6.C6_CLI = C5.C5_CLIENTE AND C6.C6_LOJA = C5.C5_LOJACLI AND C6.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER JOIN SA1010 A1 ON "
        varSql = varSql & " A1.A1_FILIAL = C5.C5_FILIAL AND A1.A1_COD = C5.C5_CLIENTE AND A1.A1_LOJA = C5.C5_LOJACLI AND A1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " INNER JOIN SA3010 A3 ON "
        varSql = varSql & " A3.A3_COD = C5.C5_VEND1 AND A3.D_E_L_E_T_ = ' ' "
        varSql = varSql & " WHERE "
        varSql = varSql & " C5.D_E_L_E_T_ = ' ' And C5.C5_NOTA = ' ' "
        varSql = varSql & " And C5.C5_EMISSAO BETWEEN '{1}' AND '{2}' "
        varSql = varSql & " And C5.C5_VEND1 = '{0}' "
        varSql = varSql & " And c5_cliente = '{3}' And C5.C5_LOJACLI = '{4}' "
        varSql = varSql & " ORDER BY C5.C5_EMISSAO ASC "
        varSql = String.Format(varSql, parCodVendedor, parDataInicial.ToString("yyyyMMdd"), parDataFinal.ToString("yyyyMMdd"), parCodCliente, parCodLoja)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdPedidos As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drPedidos As OracleDataReader = Nothing
        Try
            drPedidos = cmdPedidos.ExecuteReader()
            If drPedidos.HasRows Then
                Do While drPedidos.Read
                    Dim objPedidos = New PedidosAbertosVendedorPeriodo
                    objPedidos.pFILIAL = AppUtils.Nvl(drPedidos.Item("FILIAL"), "").ToString.Trim
                    objPedidos.pNUMERO_PED = AppUtils.Nvl(drPedidos.Item("PEDIDO"), "").ToString.Trim
                    objPedidos.pDATA_EMISSAO = AppUtils.Nvl(drPedidos.Item("EMISSAO"), DateTime.MinValue)
                    objPedidos.pCLIENTE = AppUtils.Nvl(drPedidos.Item("COD_CLIENTE"), "").ToString.Trim
                    objPedidos.pLOJA = AppUtils.Nvl(drPedidos.Item("LOJA"), "").ToString.Trim
                    objPedidos.pCODIGO_VENDEDOR = AppUtils.Nvl(drPedidos.Item("COD_VENDEDOR"), "").ToString.Trim
                    objPedidos.pNOME_CLIENTE = AppUtils.Nvl(drPedidos.Item("CLIENTE"), "").ToString.Trim
                    objPedidos.pEND_CLIENTE = AppUtils.Nvl(drPedidos.Item("A1_END"), "").ToString.Trim
                    objPedidos.pBAIRRO_CLIENTE = AppUtils.Nvl(drPedidos.Item("A1_BAIRRO"), "").ToString.Trim
                    objPedidos.pCIDADE_CLIENTE = AppUtils.Nvl(drPedidos.Item("A1_MUN"), "").ToString.Trim
                    objPedidos.pESTADO_CLIENTE = AppUtils.Nvl(drPedidos.Item("A1_EST"), "").ToString.Trim
                    objPedidos.pCIDADE_CLIENTE = AppUtils.Nvl(drPedidos.Item("A1_MUN"), "").ToString.Trim
                    objPedidos.pNOME_VENDEDOR = AppUtils.Nvl(drPedidos.Item("NOME_VEND"), "").ToString.Trim
                    objPedidos.pCNPJCLIENTE = AppUtils.Nvl(drPedidos.Item("CNPJ_CLIENTE"), "").ToString.Trim
                    objPedidos.pPRODUTO = AppUtils.Nvl(drPedidos.Item("COD_PRODUTO"), "").ToString.Trim
                    objPedidos.pDESCRICAO = AppUtils.Nvl(drPedidos.Item("DESC_PRODUTO"), "").ToString.Trim
                    objPedidos.pQUANTIDADE = AppUtils.Nvl(drPedidos.Item("QTDE"), "").ToString.Trim
                    objPedidos.pVLR_UNIT_PRODUTO = AppUtils.Nvl(drPedidos.Item("VL_UNIT"), "").ToString.Trim
                    objPedidos.pVLR_VEN_PRODUTO = AppUtils.Nvl(drPedidos.Item("VL_VENDA"), "").ToString.Trim
                    objPedidos.pVLR_TOTAL_PRODUTO = AppUtils.Nvl(drPedidos.Item("VL_TOTAL"), "").ToString.Trim

                    Pedidos.Add(objPedidos)
                Loop

                drPedidos.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drPedidos) Is Nothing) Then
                drPedidos.Dispose()
            End If
        End Try

        Return Pedidos
    End Function

    Public Shared Function GetClientesBloqueados(ByVal parCodVendedor As String) As List(Of ClientesBloqueados)
        Dim ClientesBloqueados = New List(Of ClientesBloqueados)

        Dim varSql = ""

        varSql = varSql & " SELECT A1_FILIAL FILIAL, A1_COD COD_CLIENTE, A1_LOJA LOJA, A1_NOME NOME_CLIENTE, A1_END END, "
        varSql = varSql & " SUBSTR(A1_CGC, 1, 2) || '.' || SUBSTR(A1_CGC, 3, 3) || '.' || SUBSTR(A1_CGC, 6, 3) || '/' || SUBSTR(A1_CGC, 9, 4) || '-' || SUBSTR(A1_CGC, 13, 2) CNPJ_CLIENTE "
        varSql = varSql & " FROM "
        varSql = varSql & " SA1010 SA1"
        varSql = varSql & " WHERE 0=0 "
        varSql = varSql & " And A1_VEND  = '{0}' "
        varSql = varSql & " AND A1_MSBLQL = '1' "
        varSql = varSql & " And SA1.D_E_L_E_T_ = ' ' "
        varSql = varSql & " ORDER BY A1_NOME ASC "
        varSql = String.Format(varSql, parCodVendedor)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdClientesBloqueados As New OracleCommand(varSql, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drClientesBloqueados As OracleDataReader = Nothing
        Try
            drClientesBloqueados = cmdClientesBloqueados.ExecuteReader()
            If drClientesBloqueados.HasRows Then
                Do While drClientesBloqueados.Read
                    Dim objClientesBloqueados = New ClientesBloqueados

                    objClientesBloqueados.pFILIAL = AppUtils.Nvl(drClientesBloqueados.Item("FILIAL"), "").ToString.Trim
                    objClientesBloqueados.pCOD_CLIENTE = AppUtils.Nvl(drClientesBloqueados.Item("COD_CLIENTE"), "").ToString.Trim
                    objClientesBloqueados.pLOJA = AppUtils.Nvl(drClientesBloqueados.Item("LOJA"), "").ToString.Trim
                    objClientesBloqueados.pNOME_CLIENTE = AppUtils.Nvl(drClientesBloqueados.Item("NOME_CLIENTE"), "").ToString.Trim
                    objClientesBloqueados.pEND_CLIENTE = AppUtils.Nvl(drClientesBloqueados.Item("END"), "").ToString.Trim
                    objClientesBloqueados.pCNPJ_CLIENTE = AppUtils.Nvl(drClientesBloqueados.Item("CNPJ_CLIENTE"), "").ToString.Trim

                    ClientesBloqueados.Add(objClientesBloqueados)
                Loop

                drClientesBloqueados.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drClientesBloqueados) Is Nothing) Then
                drClientesBloqueados.Dispose()
            End If
        End Try

        Return ClientesBloqueados
    End Function
End Class
