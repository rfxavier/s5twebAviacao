Imports Oracle.DataAccess.Client
Imports CodeFluent.Runtime

Public Class dsProducaoPedido
    Public Class S5TProducaoPedido
        Public Property C6_FILIAL As String
        Public Property C6_PRODUTO As String
        Public Property C6_DESCRI As String
        Public Property C5_NUM As String
        Public Property C5_EMISSAO As String
        Public Property C5_EMISSAO_DATE As Date
        Public Property QTDVEN As Double
        Public Property LOTE_AVIACAO As String
        Public Property LOTE_AVIACAO_5POS As String
        Public Property CLIENTE As String
        Public Property LOJA As String
        Public Property DESCRICAO As String
        Public Property ESTADO As String
        Public Property COD_MUNICIPIO As String
        Public Property FATOR_CONV As Integer
        Public Property TIPO_CONV As String
        Public Property B2_FILIAL As String
        Public Property B2_COD As String
        Public Property B1_DESC As String
        Public Property B2_QATU As Double
        Public Property B2_QEMP As Double
        Public Property ULTLOTE As String
        Public Property QTDVEN_ULTLOTE As Double
        Public Property TEM_FERIA_DIA As String
    End Class

    Private Class S5TProducaoPedidoProdutoAgrup
        Public Property C6_FILIAL As String
        Public Property C6_PRODUTO As String
        Public Property LOTE_AVIACAO_5POS As String
        Public Property QTDVEN As Double
    End Class
    Public Shared Function GetProducaoPedido(ByVal parComCriterioViradaFeria As Boolean) As List(Of S5TProducaoPedido)
        Dim ProducaoPedido As New List(Of S5TProducaoPedido)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdDadosProducaoPedido As New OracleCommand("SELECT * FROM   (SELECT C6_FILIAL,     C6_PRODUTO,     C6_DESCRI,     C5_NUM,     C5_EMISSAO,     TO_DATE(CONCAT(CONCAT(CONCAT(SUBSTR(C5_EMISSAO, 7, 2), '/'),CONCAT(SUBSTR(C5_EMISSAO, 5, 2), '/')),SUBSTR(C5_EMISSAO, 1, 4)), 'DD/MM/YYYY') AS C5_EMISSAO_DATE,     SUM(C6_QTDVEN)                                                                                                                              AS QTDVEN,     SC5.C5_AGREG                                                                                                                                AS LOTE_AVIACAO ,     SC5.C5_CLIENTE                                                                                                                              AS CLIENTE,     SC5.C5_LOJACLI                                                                                                                              AS LOJA,     A1.A1_NOME                                                                                                                                  AS DESCRICAO,     A1_EST                                                                                                                                      AS ESTADO,     A1_COD_MUN                                                                                                                                  AS COD_MUNICIPIO,     DECODE(TRIM(C6_PRODUTO),'314510',16,DECODE(TRIM(C6_PRODUTO),'312905',20,DECODE(TRIM(C6_PRODUTO),'325001',20,DECODE(TRIM(C6_PRODUTO),'322305',20,DECODE(SUBSTR(C6_PRODUTO,1,1),'3',1,B1.B1_CONV))))) AS FATOR_CONV ,     B1.B1_TIPCONV                                                                                                                               AS TIPO_CONV   FROM SC6010 SC6   INNER JOIN SC5010 SC5   ON SC5.D_E_L_E_T_<>'*'   AND C5_FILIAL     = C6_FILIAL   AND C5_NUM        = C6_NUM   INNER JOIN SB1010 B1   ON B1_FILIAL      = C6_FILIAL   AND B1_COD        = C6_PRODUTO   AND B1.D_E_L_E_T_ = ' '   INNER JOIN SA1010 A1   ON A1.A1_FILIAL                                                                     = SC5.C5_FILIAL   AND A1.A1_COD                                                                       = SC5.C5_CLIENTE   AND A1.A1_LOJA                                                                      = SC5.C5_LOJACLI   AND A1.D_E_L_E_T_                                                                   = ' '   WHERE SC6.D_E_L_E_T_                                                               <>'*'   AND C5_NOTA                                                                         = ' '   AND C5_EMISSAO                                                                     >= TO_CHAR(SYSDATE - 30,'YYYYMMDD')   AND C5_FILIAL NOT                                                                                    IN ('02','03')   AND NVL(LENGTH(TRIM(TRANSLATE(SUBSTR(SC5.C5_AGREG,1,5), ' +-.0123456789', ' '))),0) = 0   AND SC5.C5_AGREG                                                                   <> ' '   GROUP BY C6_FILIAL,     C6_PRODUTO,     C6_DESCRI,     C5_NUM,     C5_EMISSAO,     SC5.C5_AGREG,     B1.B1_CONV ,     B1.B1_TIPCONV,     SC5.C5_CLIENTE,     SC5.C5_LOJACLI,     A1.A1_NOME,     A1_EST,     A1_COD_MUN   ORDER BY C6_FILIAL,     C6_PRODUTO,     C6_DESCRI,     C5_NUM,     C5_EMISSAO,     SC6.C6_AGREG,     B1.B1_CONV ,     B1.B1_TIPCONV,     SC5.C5_CLIENTE,     SC5.C5_LOJACLI,     A1.A1_NOME,     A1_EST,     A1_COD_MUN   ) a LEFT JOIN   (SELECT B2_FILIAL,     B2_COD,     B1.B1_DESC,     B2_QATU,     B2_QEMP   FROM SB2010 SB2   INNER JOIN SB1010 B1   ON B1.B1_FILIAL       = SB2.B2_FILIAL   AND B1.B1_COD         = SB2.B2_COD   AND B1.D_E_L_E_T_     = ' '   WHERE SB2.D_E_L_E_T_ <>'*'   AND SB2.B2_LOCAL     IN ('01','04')   AND SB2.B2_FILIAL    IN ('01','04')   AND B1.B1_TIPO        = 'PA'   ) b ON a.c6_produto   = b.b2_cod AND a.C6_FILIAL         = b.b2_filial ORDER BY a.c6_produto", conn) With {.CommandType = CommandType.Text}
        'Dim cmdDadosProducaoPedido As New OracleCommand("SELECT * FROM (SELECT C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, TO_DATE(CONCAT(CONCAT(CONCAT(SUBSTR(C5_EMISSAO, 7, 2), '/'),CONCAT(SUBSTR(C5_EMISSAO, 5, 2), '/')),SUBSTR(C5_EMISSAO, 1, 4)), 'DD/MM/YYYY') AS C5_EMISSAO_DATE, SUM(C6_QTDVEN) AS QTDVEN, SC5.C5_AGREG AS LOTE_AVIACAO , SC5.C5_CLIENTE AS CLIENTE, SC5.C5_LOJACLI AS LOJA, A1.A1_NOME AS DESCRICAO, A1_EST AS ESTADO, A1_COD_MUN AS COD_MUNICIPIO, DECODE(TRIM(C6_PRODUTO),'325001',20,DECODE(SUBSTR(C6_PRODUTO,1,1),'3',1,B1.B1_CONV)) AS FATOR_CONV , B1.B1_TIPCONV AS TIPO_CONV FROM SC6010 SC6 INNER JOIN SC5010 SC5 ON SC5.D_E_L_E_T_<>'*' AND C5_FILIAL = C6_FILIAL AND C5_NUM = C6_NUM INNER JOIN SB1010 B1 ON B1_FILIAL = C6_FILIAL AND B1_COD = C6_PRODUTO AND B1.D_E_L_E_T_ = ' ' INNER JOIN SA1010 A1 ON A1.A1_FILIAL = SC5.C5_FILIAL AND A1.A1_COD = SC5.C5_CLIENTE AND A1.A1_LOJA = SC5.C5_LOJACLI AND A1.D_E_L_E_T_ = ' ' WHERE SC6.D_E_L_E_T_ <>'*' AND C5_NOTA = ' ' AND C5_EMISSAO >= TO_CHAR(SYSDATE - 30,'YYYYMMDD') AND C5_FILIAL NOT IN ('02','03') AND NVL(LENGTH(TRIM(TRANSLATE(SUBSTR(SC5.C5_AGREG,1,5), ' +-.0123456789', ' '))),0) = 0 AND SC5.C5_AGREG <> ' ' GROUP BY C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, SC5.C5_AGREG, B1.B1_CONV , B1.B1_TIPCONV, SC5.C5_CLIENTE, SC5.C5_LOJACLI, A1.A1_NOME, A1_EST, A1_COD_MUN ORDER BY C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, SC6.C6_AGREG, B1.B1_CONV , B1.B1_TIPCONV, SC5.C5_CLIENTE, SC5.C5_LOJACLI, A1.A1_NOME, A1_EST, A1_COD_MUN ) a LEFT JOIN (SELECT B2_FILIAL, B2_COD, B1.B1_DESC, B2_QATU, B2_QEMP FROM SB2010 SB2 INNER JOIN SB1010 B1 ON B1.B1_FILIAL = SB2.B2_FILIAL AND B1.B1_COD = SB2.B2_COD AND B1.D_E_L_E_T_ = ' ' WHERE SB2.D_E_L_E_T_ <>'*' AND SB2.B2_LOCAL IN ('01','04') AND SB2.B2_FILIAL IN ('01','04') AND B1.B1_TIPO = 'PA' ) b ON a.c6_produto = b.b2_cod AND a.C6_FILIAL = b.b2_filial ORDER BY a.c6_produto", conn) With {.CommandType = CommandType.Text}
        'Dim cmdDadosProducaoPedido As New OracleCommand("SELECT * FROM (SELECT C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, TO_DATE(CONCAT(CONCAT(CONCAT(SUBSTR(C5_EMISSAO, 7, 2), '/'),CONCAT(SUBSTR(C5_EMISSAO, 5, 2), '/')),SUBSTR(C5_EMISSAO, 1, 4)), 'DD/MM/YYYY') AS C5_EMISSAO_DATE, SUM(C6_QTDVEN) AS QTDVEN, SC5.C5_AGREG AS LOTE_AVIACAO , SC5.C5_CLIENTE AS CLIENTE, SC5.C5_LOJACLI AS LOJA, A1.A1_NOME AS DESCRICAO, A1_EST AS ESTADO, A1_COD_MUN AS COD_MUNICIPIO, DECODE(TRIM(C6_PRODUTO),'325001',20,DECODE(SUBSTR(C6_PRODUTO,1,1),'3',1,B1.B1_CONV)) AS FATOR_CONV , B1.B1_TIPCONV AS TIPO_CONV FROM SC6010 SC6 INNER JOIN SC5010 SC5 ON SC5.D_E_L_E_T_<>'*' AND C5_FILIAL = C6_FILIAL AND C5_NUM = C6_NUM INNER JOIN SB1010 B1 ON B1_FILIAL = C6_FILIAL AND B1_COD = C6_PRODUTO AND B1.D_E_L_E_T_ = ' ' INNER JOIN SA1010 A1 ON A1.A1_FILIAL = SC5.C5_FILIAL AND A1.A1_COD = SC5.C5_CLIENTE AND A1.A1_LOJA = SC5.C5_LOJACLI AND A1.D_E_L_E_T_ = ' ' WHERE SC6.D_E_L_E_T_ <>'*' AND C5_NOTA = ' ' AND C5_EMISSAO >= TO_CHAR(SYSDATE - 30,'YYYYMMDD') AND C5_FILIAL NOT IN ('02','03') AND NVL(LENGTH(TRIM(TRANSLATE(SUBSTR(SC5.C5_AGREG,1,5), ' +-.0123456789', ' '))),0) = 0 AND SC5.C5_AGREG <> ' ' and C6_PRODUTO = '000015' GROUP BY C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, SC5.C5_AGREG, B1.B1_CONV , B1.B1_TIPCONV, SC5.C5_CLIENTE, SC5.C5_LOJACLI, A1.A1_NOME, A1_EST, A1_COD_MUN ORDER BY C6_FILIAL, C6_PRODUTO, C6_DESCRI, C5_NUM, C5_EMISSAO, SC6.C6_AGREG, B1.B1_CONV , B1.B1_TIPCONV, SC5.C5_CLIENTE, SC5.C5_LOJACLI, A1.A1_NOME, A1_EST, A1_COD_MUN ) a LEFT JOIN (SELECT B2_FILIAL, B2_COD, B1.B1_DESC, B2_QATU, B2_QEMP FROM SB2010 SB2 INNER JOIN SB1010 B1 ON B1.B1_FILIAL = SB2.B2_FILIAL AND B1.B1_COD = SB2.B2_COD AND B1.D_E_L_E_T_ = ' ' WHERE SB2.D_E_L_E_T_ <>'*' AND SB2.B2_LOCAL IN ('01','04') AND SB2.B2_FILIAL IN ('01','04') AND B1.B1_TIPO = 'PA' ) b ON a.c6_produto = b.b2_cod ORDER BY a.c6_produto", conn) With {.CommandType = CommandType.Text}

        Dim drDadosProducaoPedido As OracleDataReader = Nothing
        Try
            drDadosProducaoPedido = cmdDadosProducaoPedido.ExecuteReader()
            If drDadosProducaoPedido.HasRows Then
                Do While drDadosProducaoPedido.Read
                    Dim objDadosProducaoPedido = New S5TProducaoPedido

                    objDadosProducaoPedido.C6_FILIAL = AppUtils.Nvl(drDadosProducaoPedido.Item("C6_FILIAL"), "")
                    objDadosProducaoPedido.C6_PRODUTO = AppUtils.Nvl(drDadosProducaoPedido.Item("C6_PRODUTO"), "")
                    objDadosProducaoPedido.C6_DESCRI = AppUtils.Nvl(drDadosProducaoPedido.Item("C6_DESCRI"), "")
                    objDadosProducaoPedido.C5_NUM = AppUtils.Nvl(drDadosProducaoPedido.Item("C5_NUM"), "")
                    objDadosProducaoPedido.C5_EMISSAO = AppUtils.Nvl(drDadosProducaoPedido.Item("C5_EMISSAO"), "")
                    objDadosProducaoPedido.C5_EMISSAO_DATE = AppUtils.Nvl(drDadosProducaoPedido.Item("C5_EMISSAO_DATE"), DateTime.MinValue)
                    objDadosProducaoPedido.QTDVEN = AppUtils.Nvl(drDadosProducaoPedido.Item("QTDVEN"), 0)
                    objDadosProducaoPedido.LOTE_AVIACAO = AppUtils.Nvl(drDadosProducaoPedido.Item("LOTE_AVIACAO"), "")
                    objDadosProducaoPedido.LOTE_AVIACAO_5POS = objDadosProducaoPedido.LOTE_AVIACAO.Substring(0, 5)
                    objDadosProducaoPedido.CLIENTE = AppUtils.Nvl(drDadosProducaoPedido.Item("CLIENTE"), "")
                    objDadosProducaoPedido.LOJA = AppUtils.Nvl(drDadosProducaoPedido.Item("LOJA"), "")
                    objDadosProducaoPedido.DESCRICAO = AppUtils.Nvl(drDadosProducaoPedido.Item("DESCRICAO"), "")
                    objDadosProducaoPedido.ESTADO = AppUtils.Nvl(drDadosProducaoPedido.Item("ESTADO"), "")
                    objDadosProducaoPedido.COD_MUNICIPIO = AppUtils.Nvl(drDadosProducaoPedido.Item("COD_MUNICIPIO"), "")
                    objDadosProducaoPedido.FATOR_CONV = AppUtils.Nvl(drDadosProducaoPedido.Item("FATOR_CONV"), 0)
                    objDadosProducaoPedido.TIPO_CONV = AppUtils.Nvl(drDadosProducaoPedido.Item("TIPO_CONV"), "")
                    objDadosProducaoPedido.B2_FILIAL = AppUtils.Nvl(drDadosProducaoPedido.Item("B2_FILIAL"), "")
                    objDadosProducaoPedido.B2_COD = AppUtils.Nvl(drDadosProducaoPedido.Item("B2_COD"), "")
                    objDadosProducaoPedido.B1_DESC = AppUtils.Nvl(drDadosProducaoPedido.Item("B1_DESC"), "")
                    objDadosProducaoPedido.B2_QATU = AppUtils.Nvl(drDadosProducaoPedido.Item("B2_QATU"), 0)
                    objDadosProducaoPedido.B2_QEMP = AppUtils.Nvl(drDadosProducaoPedido.Item("B2_QEMP"), 0)

                    ProducaoPedido.Add(objDadosProducaoPedido)
                Loop

                drDadosProducaoPedido.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drDadosProducaoPedido) Is Nothing) Then
                drDadosProducaoPedido.Dispose()
            End If
        End Try

        'CÁLCULO DE FÉRIA DO DIA ATUAL
        'SEMPRE O DIA ANTERIOR É A REFERÊNCIA
        'NÃO CONSIDERAR SÁBADOS E DOMINGOS
        'TEMPLATE É:
        '60806
        '6 - Ano 2016
        '08 - Mês
        '06 - Dia
        Dim varDataOntem = Now.AddDays(-1)
        Dim varDataAnteriorSemFds = varDataOntem

        If varDataOntem.DayOfWeek = DayOfWeek.Sunday Then
            varDataAnteriorSemFds = Now.AddDays(-3)
        ElseIf varDataOntem.DayOfWeek = DayOfWeek.Saturday Then
            varDataAnteriorSemFds = Now.AddDays(-2)
        End If

        'FÉRIA ANTERIOR = DIA ANTERIOR
        Dim varFeriaAnteriorAno = varDataAnteriorSemFds.Year.ToString.Substring(3, 1)
        Dim varFeriaAnteriorMes = varDataAnteriorSemFds.Month.ToString.PadLeft(2, "0")
        Dim varFeriaAnteriorDia = varDataAnteriorSemFds.Day.ToString.PadLeft(2, "0")

        Dim varFeriaAnterior = varFeriaAnteriorAno & varFeriaAnteriorMes & varFeriaAnteriorDia

        'FÉRIA ATUAL = DIA DE HOJE
        Dim varFeriaAtualAno = Now.Year.ToString.Substring(3, 1)
        Dim varFeriaAtualMes = Now.Month.ToString.PadLeft(2, "0")
        Dim varFeriaAtualDia = Now.Day.ToString.PadLeft(2, "0")

        Dim varFeriaAtual = varFeriaAtualAno & varFeriaAtualMes & varFeriaAtualDia


        Dim ProducaoPedidoProdutoLoteAgrup = GetProducaoPedidoProdutoLoteAgrup(ProducaoPedido)

        For Each objProducaoPedido In ProducaoPedido
            Dim objProducaoPedidoProdutoLoteAgrupC6_PRODUTO = ProducaoPedidoProdutoLoteAgrup.FindAll(Function(x) x.C6_FILIAL = objProducaoPedido.C6_FILIAL And x.C6_PRODUTO = objProducaoPedido.C6_PRODUTO)

            If objProducaoPedidoProdutoLoteAgrupC6_PRODUTO IsNot Nothing Then
                'ACHOU ALGUÉM COM C6_PRODUTO IGUAL
                'ORDENA CRESCENTE E PEGA A PRIMEIRA OCORRÊNCIA "= (0)" DA COLEÇÃO
                objProducaoPedido.ULTLOTE = objProducaoPedidoProdutoLoteAgrupC6_PRODUTO.OrderBy(Function(y) y.LOTE_AVIACAO_5POS)(0).LOTE_AVIACAO_5POS
                objProducaoPedido.QTDVEN_ULTLOTE = objProducaoPedidoProdutoLoteAgrupC6_PRODUTO.OrderBy(Function(y) y.LOTE_AVIACAO_5POS)(0).QTDVEN

                'VERIFICA SE O C6_PRODUTO ATUAL, TEM FÉRIA DO DIA ANTERIOR, PARA SETAR TEM_FERIA_DIA
                If objProducaoPedidoProdutoLoteAgrupC6_PRODUTO.FindAll(Function(x) x.LOTE_AVIACAO_5POS = varFeriaAnterior).Count > 0 Then
                    objProducaoPedido.TEM_FERIA_DIA = "S"
                Else
                    objProducaoPedido.TEM_FERIA_DIA = "N"
                End If

                'If objProducaoPedidoProdutoLoteAgrupC6_PRODUTO.FindAll(Function(x) x.LOTE_AVIACAO_5POS = "60808").Count > 0 Then
                '    objProducaoPedido.TEM_FERIA_DIA = "S"
                'Else
                '    objProducaoPedido.TEM_FERIA_DIA = "N"
                'End If

            End If
        Next

        Dim ProducaoPedidoFeriaAnterior As List(Of S5TProducaoPedido)

        If parComCriterioViradaFeria Then
            ProducaoPedidoFeriaAnterior = ProducaoPedido.FindAll(Function(x) x.TEM_FERIA_DIA = "S")

            If ProducaoPedidoFeriaAnterior.Count = 0 Then
                'FAZ NOVA TENTATIVA PARA VER SE TRAZ COM A FÉRIA ATUAL
                For Each objProducaoPedido In ProducaoPedido
                    Dim objProducaoPedidoProdutoLoteAgrupC6_PRODUTO = ProducaoPedidoProdutoLoteAgrup.FindAll(Function(x) x.C6_FILIAL = objProducaoPedido.C6_FILIAL And x.C6_PRODUTO = objProducaoPedido.C6_PRODUTO)

                    'VERIFICA SE O C6_PRODUTO ATUAL, TEM FÉRIA DO DIA ATUAL, PARA SETAR TEM_FERIA_DIA
                    If objProducaoPedidoProdutoLoteAgrupC6_PRODUTO.FindAll(Function(x) x.LOTE_AVIACAO_5POS = varFeriaAtual).Count > 0 Then
                        objProducaoPedido.TEM_FERIA_DIA = "S"
                    Else
                        objProducaoPedido.TEM_FERIA_DIA = "N"
                    End If
                Next

                ProducaoPedidoFeriaAnterior = ProducaoPedido.FindAll(Function(x) x.TEM_FERIA_DIA = "S")
            End If
        Else
            ProducaoPedidoFeriaAnterior = ProducaoPedido
        End If

        'ACRESCENTA PRODUTOS QUE TEM EM ESTOQUE MAS NÃO TEM EM PEDIDO
        Dim ProducaoPedidoProdutoLoteMergeComEstoque = GetProducaoPedidoProdutoLoteMergeComEstoque(ProducaoPedidoFeriaAnterior)

        'Return ProducaoPedidoFeriaAnterior
        Return ProducaoPedidoProdutoLoteMergeComEstoque
    End Function

    Public Shared Function GetProdutosEstoque() As List(Of S5TProducaoPedido)
        Dim ProdutosEstoque As New List(Of S5TProducaoPedido)

        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = String.Empty

        Dim oradb As String = AppUtils.dbConnectionString

        conn = New OracleConnection(oradb)
        conn.Open()

        Dim cmdDadosProdutosEstoque As New OracleCommand("select b2.B2_FILIAL, b2.B2_COD, B1.B1_DESC, b1.b1_grupo, b2.B2_QATU, B1.B1_CONV FATOR_CONV, B1.B1_TIPCONV TIPO_CONV, b2.B2_QEMP + b2.b2_RESERVA B2_QEMP from SB2010 b2 INNER JOIN SB1010 B1 ON B1_FILIAL = B2_FILIAL AND B1_COD = B2_COD AND B1_GRUPO IN ('1','2','3','4','5','7') AND B1.B1_TIPO IN ('PA','ME') AND B1.D_E_L_E_T_ = ' ' WHERE 0=0 and (B2_QATU <> 0 OR B2_COD IN ('000015','413000')) AND B2.D_E_L_E_T_ = ' ' AND B2.B2_FILIAL IN ( '01','04') AND B2.B2_COD NOT IN ('000079')", conn) With {.CommandType = CommandType.Text}

        Dim drDadosProdutosEstoque As OracleDataReader = Nothing
        Try
            drDadosProdutosEstoque = cmdDadosProdutosEstoque.ExecuteReader()
            If drDadosProdutosEstoque.HasRows Then
                Do While drDadosProdutosEstoque.Read
                    Dim objDadosProdutosEstoque = New S5TProducaoPedido

                    objDadosProdutosEstoque.C6_FILIAL = AppUtils.Nvl(drDadosProdutosEstoque.Item("B2_FILIAL"), "")
                    objDadosProdutosEstoque.C6_PRODUTO = AppUtils.Nvl(drDadosProdutosEstoque.Item("B2_COD"), "")
                    objDadosProdutosEstoque.C6_DESCRI = AppUtils.Nvl(drDadosProdutosEstoque.Item("B1_DESC"), "")
                    objDadosProdutosEstoque.C5_NUM = "N/D"
                    objDadosProdutosEstoque.C5_EMISSAO = "00010101"
                    objDadosProdutosEstoque.C5_EMISSAO_DATE = DateTime.MinValue
                    objDadosProdutosEstoque.QTDVEN = 0
                    objDadosProdutosEstoque.LOTE_AVIACAO = "N/D     "
                    objDadosProdutosEstoque.LOTE_AVIACAO_5POS = "N/D  "
                    objDadosProdutosEstoque.CLIENTE = "N/D"
                    objDadosProdutosEstoque.LOJA = "N/D"
                    objDadosProdutosEstoque.DESCRICAO = "N/D"
                    objDadosProdutosEstoque.ESTADO = "N/D"
                    objDadosProdutosEstoque.COD_MUNICIPIO = "N/D"
                    objDadosProdutosEstoque.FATOR_CONV = IIf(AppUtils.Nvl(drDadosProdutosEstoque.Item("FATOR_CONV"), 0) = 0, 1, AppUtils.Nvl(drDadosProdutosEstoque.Item("FATOR_CONV"), 0))
                    objDadosProdutosEstoque.TIPO_CONV = AppUtils.Nvl(drDadosProdutosEstoque.Item("TIPO_CONV"), "")
                    objDadosProdutosEstoque.B2_FILIAL = "N/D"
                    objDadosProdutosEstoque.B2_COD = AppUtils.Nvl(drDadosProdutosEstoque.Item("B2_COD"), "")
                    objDadosProdutosEstoque.B1_DESC = AppUtils.Nvl(drDadosProdutosEstoque.Item("B1_DESC"), "")
                    objDadosProdutosEstoque.B2_QATU = AppUtils.Nvl(drDadosProdutosEstoque.Item("B2_QATU"), 0)
                    objDadosProdutosEstoque.B2_QEMP = AppUtils.Nvl(drDadosProdutosEstoque.Item("B2_QEMP"), 0)

                    ProdutosEstoque.Add(objDadosProdutosEstoque)
                Loop

                drDadosProdutosEstoque.Close()
            End If
        Catch ex As Exception
            'Return InternalServerError(ex)
        Finally
            conn.Close()
            If (Not (drDadosProdutosEstoque) Is Nothing) Then
                drDadosProdutosEstoque.Dispose()
            End If
        End Try

        Return ProdutosEstoque
    End Function


    Private Shared Function GetProducaoPedidoProdutoLoteAgrup(parProducaoPedido As List(Of S5TProducaoPedido)) As List(Of S5TProducaoPedidoProdutoAgrup)
        Dim ProducaoPedidoProdutoLoteAgrup = parProducaoPedido.GroupBy(Function(k) New With {Key .C6_FILIAL = k.C6_FILIAL, _
                                                                                             Key .C6_PRODUTO = k.C6_PRODUTO, _
                                                                                             Key .LOTE_AVIACAO_5POS = k.LOTE_AVIACAO_5POS}).Select(Function(y) New S5TProducaoPedidoProdutoAgrup With {.C6_FILIAL = y.Key.C6_FILIAL, _
                                                                                                                                                                                                       .C6_PRODUTO = y.Key.C6_PRODUTO, _
                                                                                                                                                                                                       .LOTE_AVIACAO_5POS = y.Key.LOTE_AVIACAO_5POS, _
                                                                                                                                                                                                       .QTDVEN = Math.Round(y.Sum(Function(group) group.QTDVEN), 2)}).ToList

        Return ProducaoPedidoProdutoLoteAgrup
    End Function


    Private Shared Function GetProducaoPedidoProdutoLoteMergeComEstoque(parProducaoPedido As List(Of S5TProducaoPedido)) As List(Of S5TProducaoPedido)
        Dim ProdutosEstoque = GetProdutosEstoque()

        For Each objProdutoEstoque In ProdutosEstoque
            If parProducaoPedido.FindAll(Function(x) x.C6_FILIAL = objProdutoEstoque.C6_FILIAL And x.B2_COD = objProdutoEstoque.B2_COD).Count = 0 Then
                'NÃO ACHOU PRODUTO QUE CONSTA TENDO ESTOQUE, DENTRO DA LISTA DE parProducaoPedido
                'FAZ UM MERGE
                parProducaoPedido.Add(New S5TProducaoPedido With {.C6_FILIAL = objProdutoEstoque.C6_FILIAL, _
                                                                    .C6_PRODUTO = objProdutoEstoque.C6_PRODUTO, _
                                                                    .C6_DESCRI = objProdutoEstoque.C6_DESCRI, _
                                                                    .C5_NUM = objProdutoEstoque.C5_NUM, _
                                                                    .C5_EMISSAO = objProdutoEstoque.C5_EMISSAO, _
                                                                    .C5_EMISSAO_DATE = objProdutoEstoque.C5_EMISSAO_DATE, _
                                                                    .QTDVEN = objProdutoEstoque.QTDVEN, _
                                                                    .LOTE_AVIACAO = objProdutoEstoque.LOTE_AVIACAO, _
                                                                    .LOTE_AVIACAO_5POS = objProdutoEstoque.LOTE_AVIACAO_5POS, _
                                                                    .CLIENTE = objProdutoEstoque.CLIENTE, _
                                                                    .LOJA = objProdutoEstoque.LOJA, _
                                                                    .DESCRICAO = objProdutoEstoque.DESCRICAO, _
                                                                    .ESTADO = objProdutoEstoque.ESTADO, _
                                                                    .COD_MUNICIPIO = objProdutoEstoque.COD_MUNICIPIO, _
                                                                    .FATOR_CONV = objProdutoEstoque.FATOR_CONV, _
                                                                    .TIPO_CONV = objProdutoEstoque.TIPO_CONV, _
                                                                    .B2_FILIAL = objProdutoEstoque.B2_FILIAL, _
                                                                    .B2_COD = objProdutoEstoque.B2_COD, _
                                                                    .B1_DESC = objProdutoEstoque.B1_DESC, _
                                                                    .B2_QATU = objProdutoEstoque.B2_QATU, _
                                                                    .B2_QEMP = objProdutoEstoque.B2_QEMP})
            End If
        Next

        Return parProducaoPedido
    End Function
End Class
