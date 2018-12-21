Imports System.Runtime.Serialization
Imports Oracle.DataAccess.Client

Public Class PedidoSubstTrib
    Public Class S5TCliente
        Public Property A1_COD As String
        Public Property A1_LOJA As String
        Public Property A1_VEND As String
        Public Property A1_GRPTRIB As String
        Public Property A1_EST As String
    End Class

    Public Class S5TProduto
        Public Property B1_COD As String
        Public Property B1_GRUPO As String
        Public Property B1_GRTRIB As String
        Public Property B1_PICMRET As Double
        Public Property B1_TESMG As String
        Public Property B1_TESSP As String
    End Class

    Public Class S5TF7
        Public Property FILIAL As String
        Public Property GRTRIB As String
        Public Property SEQUEN As String
        Public Property EST As String
        Public Property ALIQINT As Double
        Public Property ALIQEXT As Double
        Public Property MARGEM As Double
        Public Property ALIQDST As Double
        Public Property GRPCLI As String
    End Class

    Public Class S5TF4
        Public Property FILIAL As String
        Public Property CODIGO As String
        Public Property CREDST As String
        Public Property BASEICM As Double
        Public Property BSICMST As Double
    End Class


    'Pedido para mapear POST
    <DataContract>
    Public Class S5TPedido
        Public Property numPedido As Long
        <DataMember>
        Public Property codCliente As String
        <DataMember>
        Public Property codLoja As String
        <DataMember>
        Public Property codVendedor As String
        <DataMember>
        Public Property pedidoValorSubstTrib As Double
        <DataMember>
        Public Property items As List(Of S5TPedidoItems)
    End Class

    'Pedido items para mapear POST
    Public Class S5TPedidoItems
        <DataMember>
        Public Property B1_COD As String
        <DataMember>
        Public Property prodValorTotal As Double
        <DataMember>
        Public Property prodValorSubstTrib As Double
    End Class

    Public Shared Function GetCliente(ByVal parA1_VEND As String, ByVal parA1_COD As String, ByVal parA1_LOJA As String) As S5TCliente
        Dim objCliente = New S5TCliente

        Dim varSqlBase = "SELECT A1_COD, A1_LOJA, A1_VEND, A1_GRPTRIB, A1_EST FROM SA1010 SA1 WHERE A1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' '"

        varSqlBase &= " AND A1_VEND = '" & parA1_VEND & "' AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "'"

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdCliente As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

        'Dim cmdCliente As OracleCommand

        Dim drCliente As OracleDataReader = Nothing
        Try
            drCliente = cmdCliente.ExecuteReader()
            If drCliente.HasRows Then
                Do While drCliente.Read
                    objCliente.A1_COD = AppUtils.Nvl(drCliente.Item("A1_COD"), "").ToString.Trim
                    objCliente.A1_LOJA = AppUtils.Nvl(drCliente.Item("A1_LOJA"), "").ToString.Trim
                    objCliente.A1_VEND = AppUtils.Nvl(drCliente.Item("A1_VEND"), "").ToString.Trim
                    objCliente.A1_GRPTRIB = AppUtils.Nvl(drCliente.Item("A1_GRPTRIB"), "").ToString.Trim
                    objCliente.A1_EST = AppUtils.Nvl(drCliente.Item("A1_EST"), "").ToString.Trim
                Loop

                drCliente.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drCliente) Is Nothing) Then
                drCliente.Dispose()
            End If
        End Try

        Return objCliente
    End Function

    Public Shared Function GetProdutos(ByVal parA1_COD As String, ByVal parA1_LOJA As String, ByVal parA1_VEND As String, ByVal parPRODUTOS As List(Of String)) As List(Of S5TProduto)
        Dim Produtos = New List(Of S5TProduto)

        'Dim varSqlBase = " SELECT B1_COD, B1_GRUPO, B1_GRTRIB, B1_PICMRET, B1_TESMG FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' INNER JOIN SB1010 SB1 ON B1_COD = DA1_CODPRO AND B1_FILIAL = '01' AND SB1.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = B1_COD AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND DA1_ATIVO = '1' AND B1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' '"
        'varSqlBase &= " AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "' AND A1_VEND = '" & parA1_VEND & "'"

        'Dim varListaDeCodigos As String

        'varListaDeCodigos = String.Join(",", parPRODUTOS.ToArray())

        'varSqlBase &= String.Format(" AND B1_COD IN ( {0} )", varListaDeCodigos)


        Dim varSqlBase01 = "SELECT B1_COD, B1_GRUPO, B1_GRTRIB, B1_PICMRET, B1_TESMG, B1_TESSP FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' INNER JOIN SB1010 SB1 ON B1_COD = DA1_CODPRO AND B1_FILIAL = '04' AND SB1.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = B1_COD AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND DA1_ATIVO = '1' AND B1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' ' AND B1_COD IN ('000015', '000066')"
        varSqlBase01 &= " AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "' AND A1_VEND = '" & parA1_VEND & "'"

        Dim varSqlBase02 = "SELECT B1_COD, B1_GRUPO, B1_GRTRIB, B1_PICMRET, B1_TESMG, B1_TESSP FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' INNER JOIN SB1010 SB1 ON B1_COD = DA1_CODPRO AND B1_FILIAL = '01' AND SB1.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = B1_COD AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND DA1_ATIVO = '1' AND B1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' ' AND B1_COD NOT IN ('000015', '000066')"
        varSqlBase02 &= " AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "' AND A1_VEND = '" & parA1_VEND & "'"


        Dim varListaDeCodigos As String

        varListaDeCodigos = String.Join(",", parPRODUTOS.ToArray())

        varSqlBase02 &= String.Format(" AND B1_COD IN ( {0} )", varListaDeCodigos)

        varSqlBase = varSqlBase01 & " UNION " & varSqlBase02


        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdProduto As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

        'Dim cmdProduto As OracleCommand

        Dim drProduto As OracleDataReader = Nothing
        Try
            drProduto = cmdProduto.ExecuteReader()
            If drProduto.HasRows Then
                Do While drProduto.Read
                    Dim objProduto = New S5TProduto

                    objProduto.B1_COD = AppUtils.Nvl(drProduto.Item("B1_COD"), "").ToString.Trim
                    objProduto.B1_GRUPO = AppUtils.Nvl(drProduto.Item("B1_GRUPO"), "").ToString.Trim

                    objProduto.B1_GRTRIB = AppUtils.Nvl(drProduto.Item("B1_GRTRIB"), "").ToString.Trim
                    objProduto.B1_PICMRET = AppUtils.Nvl(drProduto.Item("B1_PICMRET"), 0)
                    objProduto.B1_TESMG = AppUtils.Nvl(drProduto.Item("B1_TESMG"), "").ToString.Trim
                    objProduto.B1_TESSP = AppUtils.Nvl(drProduto.Item("B1_TESSP"), "").ToString.Trim

                    Produtos.Add(objProduto)
                Loop

                drProduto.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drProduto) Is Nothing) Then
                drProduto.Dispose()
            End If
        End Try

        Return Produtos
    End Function

    Public Shared Function GetF7s(ByVal parGRPCLI As String) As List(Of S5TF7)
        Dim F7s = New List(Of S5TF7)

        Dim varSqlBase = "SELECT F7.F7_FILIAL, F7.F7_GRTRIB, F7.F7_SEQUEN, F7.F7_EST, F7.F7_ALIQINT, F7.F7_ALIQEXT, F7.F7_MARGEM, F7.F7_ALIQDST, F7.F7_GRPCLI FROM SF7010 F7 WHERE F7.D_E_L_E_T_ = ' '"

        varSqlBase &= " AND F7_GRPCLI = '" & parGRPCLI & "'"

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdF7 As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

        Dim drF7 As OracleDataReader = Nothing
        Try
            drF7 = cmdF7.ExecuteReader()
            If drF7.HasRows Then
                Do While drF7.Read
                    Dim objF7 = New S5TF7

                    objF7.FILIAL = AppUtils.Nvl(drF7.Item("F7_FILIAL"), "").ToString.Trim
                    objF7.GRTRIB = AppUtils.Nvl(drF7.Item("F7_GRTRIB"), "").ToString.Trim

                    objF7.SEQUEN = AppUtils.Nvl(drF7.Item("F7_SEQUEN"), "").ToString.Trim
                    objF7.EST = AppUtils.Nvl(drF7.Item("F7_EST"), "").ToString.Trim
                    objF7.ALIQINT = AppUtils.Nvl(drF7.Item("F7_ALIQINT"), 0)
                    objF7.ALIQEXT = AppUtils.Nvl(drF7.Item("F7_ALIQEXT"), 0)
                    objF7.MARGEM = AppUtils.Nvl(drF7.Item("F7_MARGEM"), 0)
                    objF7.ALIQDST = AppUtils.Nvl(drF7.Item("F7_ALIQDST"), 0)
                    objF7.GRPCLI = AppUtils.Nvl(drF7.Item("F7_GRPCLI"), "").ToString.Trim

                    F7s.Add(objF7)
                Loop

                drF7.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drF7) Is Nothing) Then
                drF7.Dispose()
            End If
        End Try

        Return F7s

    End Function

    Public Shared Function GetF4s(ByVal parCODIGOS As List(Of String), Optional ByVal parECAFE As Boolean = False) As List(Of S5TF4)
        'parECAFE = É PARA PEGAR F4s DE PRODUTO CAFÉ? 
        'SIGNIFICA QUE SE FOR PEGAR PARA CAFÉ, A FILIAL = 04
        'DEFAULT É DEMAIS PRODUTOS, ONDE A FILIAL = 01
        Dim F4s = New List(Of S5TF4)

        Dim varSqlBase As String = String.Empty

        If parECAFE Then
            varSqlBase = "SELECT F4_FILIAL, F4_CODIGO, F4.F4_CREDST, F4_BASEICM, F4_BSICMST FROM SF4010 F4 WHERE F4.D_E_L_E_T_ = ' ' AND F4.F4_FILIAL = '04'"
        Else
            varSqlBase = "SELECT F4_FILIAL, F4_CODIGO, F4.F4_CREDST, F4_BASEICM, F4_BSICMST FROM SF4010 F4 WHERE F4.D_E_L_E_T_ = ' ' AND F4.F4_FILIAL = '01'"
        End If

        Dim varListaDeCodigos As String

        varListaDeCodigos = String.Join("','", parCODIGOS.ToArray())

        varSqlBase &= String.Format(" AND F4.F4_CODIGO IN ( '{0}' )", varListaDeCodigos)


        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdF4 As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

        'Dim cmdF4 As OracleCommand

        Dim drF4 As OracleDataReader = Nothing
        Try
            drF4 = cmdF4.ExecuteReader()
            If drF4.HasRows Then
                Do While drF4.Read
                    Dim objF4 = New S5TF4

                    objF4.FILIAL = AppUtils.Nvl(drF4.Item("F4_FILIAL"), "").ToString.Trim
                    objF4.CODIGO = AppUtils.Nvl(drF4.Item("F4_CODIGO"), "").ToString.Trim
                    objF4.CREDST = AppUtils.Nvl(drF4.Item("F4_CREDST"), "").ToString.Trim
                    objF4.BASEICM = AppUtils.Nvl(drF4.Item("F4_BASEICM"), 0)
                    objF4.BSICMST = AppUtils.Nvl(drF4.Item("F4_BSICMST"), 0)

                    F4s.Add(objF4)
                Loop

                drF4.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drF4) Is Nothing) Then
                drF4.Dispose()
            End If
        End Try

        Return F4s
    End Function

    Public Shared Function ProcessaSubstTribPedido(ByVal oPedido As S5TPedido) As S5TPedido
        'BUSCA INFORMAÇÕES DE CLIENTE
        Dim objCliente = New S5TCliente

        objCliente = GetCliente(oPedido.codVendedor, oPedido.codCliente, oPedido.codLoja)

        'BUSCA INFORMAÇÕES DE PRODUTOS
        Dim Produtos = New List(Of S5TProduto)

        Dim listaCodigosProdutos As List(Of String) = oPedido.items.Select(Function(x) New String(x.B1_COD)).ToList

        Produtos = GetProdutos(oPedido.codCliente, oPedido.codLoja, oPedido.codVendedor, listaCodigosProdutos)

        'BUSCA INFORMAÇÕES DA F7 - DADOS TRIBUTAÇÃO
        Dim F7s = New List(Of S5TF7)

        F7s = GetF7s(objCliente.A1_GRPTRIB)

        'BUSCA INFORMAÇÕES DA F4 - DADOS TRIBUTAÇÃO REDUÇÃO BASE CASO SEJA CLIENTE EM ESTADO MG
        Dim F4s = New List(Of S5TF4)

        If objCliente.A1_EST = "MG" Then
            'CASO SEJA CLIENTE EM ESTADO MG, VERIFICA F4s COM BASE EM B1_TESMG

            Dim listaCodigosTES = Produtos.Select(Function(x) New String(x.B1_TESMG)).ToList

            F4s = GetF4s(listaCodigosTES)
        ElseIf oPedido.items.Any(Function(x) x.B1_COD = "000015") Or oPedido.items.Any(Function(x) x.B1_COD = "000066") Then
            'CASO SEJA CAFÉ, VERIFICA F4s COM BASE EM B1_TESMG

            Dim listaCodigosTES = Produtos.Select(Function(x) New String(x.B1_TESSP)).ToList

            F4s = GetF4s(listaCodigosTES, True)
        End If

        'COEFICIENTE REDUÇÃO BASE DE CÁLCULO ST - PADRÃO = 1 (SEM REDUÇÃO)
        Dim varCoefReducaoBase As Double = 1
        Dim varCoefReducaoBaseIcmsSt As Double = 1

        For Each objPedidoItem In oPedido.items
            Dim objProduto = Produtos.FirstOrDefault(Function(x) x.B1_COD = objPedidoItem.B1_COD)

            If objProduto IsNot Nothing Then
                Dim varAliqInt = 0

                Dim varAliqExt = 0

                Dim varMargem As Double = 0

                Dim objF7 As S5TF7 = Nothing

                If objCliente.A1_EST = "MG" Then
                    'CASO SEJA CLIENTE EM ESTADO MG, VERIFICA SE ACHA REDUÇÃO PREVISTA EM BASE CÁCULO ST
                    Dim objF4 = F4s.FirstOrDefault(Function(x) x.CODIGO = objProduto.B1_TESMG)

                    If objF4 IsNot Nothing Then
                        If objF4.BASEICM > 0 Then
                            varCoefReducaoBase = objF4.BASEICM / 100
                        Else
                            varCoefReducaoBase = 1
                        End If

                        If objF4.BSICMST > 0 Then
                            varCoefReducaoBaseIcmsSt = objF4.BSICMST / 100
                        Else
                            varCoefReducaoBaseIcmsSt = 1
                        End If
                    End If

                    varAliqInt = 18

                    varAliqExt = 18

                    varMargem = objProduto.B1_PICMRET
                ElseIf {"000015", "000066"}.Contains(objProduto.B1_COD)
                    'CASO SEJA CAFÉ, VERIFICA SE ACHA REDUÇÃO PREVISTA EM BASE CÁCULO ST, BASEANDO EM B1_TESSP
                    Dim objF4 = F4s.FirstOrDefault(Function(x) x.CODIGO = objProduto.B1_TESSP)

                    If objF4 IsNot Nothing Then
                        If objF4.BASEICM > 0 Then
                            varCoefReducaoBase = objF4.BASEICM / 100
                        Else
                            varCoefReducaoBase = 1
                        End If

                        If objF4.BSICMST > 0 Then
                            varCoefReducaoBaseIcmsSt = objF4.BSICMST / 100
                        Else
                            varCoefReducaoBaseIcmsSt = 1
                        End If
                    End If

                    varAliqInt = 18

                    varAliqExt = 18

                    varMargem = objProduto.B1_PICMRET
                Else
                    objF7 = F7s.FirstOrDefault(Function(x) x.GRTRIB = objProduto.B1_GRTRIB)

                    If objCliente.A1_EST = "SP" And objProduto.B1_GRUPO = "1" Then
                        varAliqInt = 7

                        varAliqExt = 7

                        If objF7 IsNot Nothing Then varMargem = objF7.MARGEM
                    Else

                        If objF7 IsNot Nothing Then
                            varAliqInt = objF7.ALIQINT

                            varAliqExt = objF7.ALIQEXT

                            If objF7 IsNot Nothing Then varMargem = objF7.MARGEM
                        End If
                    End If
                End If

                Dim varValorVenda = objPedidoItem.prodValorTotal

                Dim varValorBaseIcms = Math.Round(varValorVenda * varCoefReducaoBase, 2)

                Dim varValorIcms = Math.Round(varValorBaseIcms * varAliqExt / 100, 2)

                Dim varValorBaseIcmsSt = Math.Round(((Math.Round(varValorVenda * varCoefReducaoBaseIcmsSt, 2)) * (1 + varMargem / 100)), 2)

                Dim varValorInter = Math.Round(varValorBaseIcmsSt * varAliqInt / 100, 2)

                Dim varValorIcmsSt = varValorInter - varValorIcms

                objPedidoItem.prodValorSubstTrib = Math.Round(varValorIcmsSt, 2)

            End If
        Next

        oPedido.pedidoValorSubstTrib = Math.Round(oPedido.items.Sum(Function(x) x.prodValorSubstTrib), 2)

        Return oPedido
    End Function 
End Class
