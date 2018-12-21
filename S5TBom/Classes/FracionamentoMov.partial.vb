Imports CodeFluent.Runtime

Namespace S5T
    Public Class FracionamentoMov
        Private Sub OnBeforeSave()

            'If Me.pLote = Nothing Then
            '    Throw New CodeFluentValidationException("[txtLote] Lote não informado")
            'End If

            'If Me.pPesoPesado = Nothing Then
            '    Throw New CodeFluentValidationException("[lblpeso] Peso não informado")
            'End If


        End Sub

        Protected Shared Sub GravaOrdemPartial(ByVal parFracionamentoMovView As System.Collections.Generic.List(Of S5T.FracionamentoMovViewGrid))

            'verifica se já existe a ORDEM na base
            Dim objOrdem = S5T.Fracionamento.LoadByNumeroOrdem(parFracionamentoMovView.FirstOrDefault.C2_NUM)

            'se não achou a ordem na base, então salva uma nova
            If objOrdem Is Nothing Then
                'GRAVAÇÃO DA ORDEM NA BASE
                Dim obj As New S5T.Fracionamento
                With obj
                    .C2_EMISSAO = parFracionamentoMovView.FirstOrDefault.C2_EMISSAO
                    .C2_FILIAL = parFracionamentoMovView.FirstOrDefault.C2_FILIAL
                    .C2_ITEM = parFracionamentoMovView.FirstOrDefault.C2_ITEM
                    .C2_NUM = parFracionamentoMovView.FirstOrDefault.C2_NUM
                    .C2_PRODUTO = parFracionamentoMovView.FirstOrDefault.C2_PRODUTO
                    .C2_QUANT = parFracionamentoMovView.FirstOrDefault.C2_QUANT
                    .C2_SEQUEN = parFracionamentoMovView.FirstOrDefault.C2_SEQUEN
                    .B1_DESC_PROD = parFracionamentoMovView.FirstOrDefault.B1_DESC_PROD
                    .sStatus = FracionamentoStatus.Aberta

                    .Save()
                End With

                'GRAVAÇÃO DA MOV NA BASE
                For Each objFM In parFracionamentoMovView
                    Dim ObjMov As New S5T.FracionamentoMov
                    With ObjMov
                        .B1_DESC = objFM.B1_DESC
                        .G1_COMP = objFM.G1_COMP
                        .G1_QUANT = objFM.G1_QUANT
                        .G1_ZZQMIN = objFM.G1_ZZQMIN
                        .G1_ZZQMAX = objFM.G1_ZZQMAX
                        .pLote = objFM.pLote
                        .pDataMov = objFM.pDataMov
                        .pVez = objFM.pVez
                        .pPesoPesado = objFM.pPesoPesado

                        .oFracionamentopId = obj.pId
                        .Save()
                    End With
                Next
                'Se há ordem na base, então só insere a mov
            Else
                'GRAVAÇÃO DA MOV NA BASE
                For Each objFM In parFracionamentoMovView

                    Dim ObjMov As New S5T.FracionamentoMov
                    With ObjMov

                        .B1_DESC = objFM.B1_DESC
                        .G1_COMP = objFM.G1_COMP
                        .G1_QUANT = objFM.G1_QUANT
                        .G1_ZZQMIN = objFM.G1_ZZQMIN
                        .G1_ZZQMAX = objFM.G1_ZZQMAX
                        .pLote = objFM.pLote
                        .pDataMov = objFM.pDataMov
                        .pVez = objFM.pVez

                        .pPesoPesado = objFM.pPesoPesado

                        .oFracionamentopId = objOrdem.pId
                        .Save()
                    End With
                Next
            End If

        End Sub

    End Class
End Namespace
