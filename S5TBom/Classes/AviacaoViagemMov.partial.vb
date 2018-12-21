Imports CodeFluent.Runtime

Namespace S5T
    Public Class AviacaoViagemMov
        Private Sub OnBeforeSave()
            If Me.EntityState = CodeFluentEntityState.Modified Then


                If Me.pSTATUS <> "EM MANUTENÇÃO" Then
                    If Me.oAviacaoCaminhao Is Nothing Then
                        Throw New CodeFluentValidationException("* Caminhão não informado")
                    End If

                    'If Me.oAviacaoLocalLinha Is Nothing Then
                    '    Throw New CodeFluentValidationException("[CmbLocalLinha] Local/Linha não informado")
                    'End If

                    'If Me.oAviacaoMotorista Is Nothing Then
                    '    Throw New CodeFluentValidationException("[CmbMotorista] Motorista não informado")
                    'End If

                    'If Me.pDATA_SAIDA = Nothing Then
                    '    Throw New CodeFluentValidationException("[MskDtSaida] Data de Saída não informada")
                    'Else
                    'If Me.pDATA_RETORNO <> Nothing Then
                    '    If Me.pDATA_RETORNO < Me.pDATA_SAIDA Then
                    '        Throw New CodeFluentValidationException("* Data de Retorno menor que Data de Saída")
                    '    End If
                    'End If
                    'End If
                End If

            End If


            If Me.pSTATUS = Nothing Then
                If Me.pDATA_SAIDA = Nothing Then
                    Me.pSTATUS = "DISPONÍVEL"
                ElseIf Me.pDATA_SAIDA <> Nothing And Me.pDATA_RETORNO = Nothing Then
                    If Me.oAviacaoLocalLinhasRetorno.Count <> 0 Then
                        'If Me.oAviacaoLocalLinhapId <> Me.oAviacaoLocalLinhaRetornopId Then
                        Me.pSTATUS = "RETORNO"
                        'End If
                    Else
                        Me.pSTATUS = "EM VIAGEM"
                    End If
                ElseIf Me.pDATA_SAIDA <> Nothing And Me.pDATA_RETORNO <> Nothing Then
                    Me.pSTATUS = "VIAGEM CONCLUÍDA"
                End If


            End If

        End Sub
        Private Sub OnBeforeDelete()
            'Dim obj = S5T.AviacaoViagemMov.LoadByParametros(Me.pDATA_SAIDA, Nothing, Nothing, Nothing, Nothing, Nothing, Me.oAviacaoCaminhaopId, Nothing, Nothing, "N", "pDATA_SAIDA")
            'If Me.o Then
            '    Throw New CodeFluentValidationException("Há viagens posterior, não foi possível a exclusão!")
            'Else
            '    For Each objViagens In obj
            '        S5T.AviacaoViagemMov.LoadBypId(objViagens.pId).Delete()
            '    Next
            'End If
            If Me.pSTATUS = "DISPONÍVEL" Then
                Throw New CodeFluentValidationException("Não é possível excluir!")
            End If

            If Me.pSTATUS = "EM MANUTENÇÃO" Or Me.pSTATUS = "EM VIAGEM" Then
                Dim objNew As New S5T.AviacaoViagemMov

                objNew.pDATA_SAIDA = Nothing
                objNew.pDATA_PREV_RETORNO = Nothing
                objNew.pDATA_RETORNO = Nothing
                objNew.oAviacaoMotoristapId = Me.oAviacaoCaminhao.oAviacaoMotoristapId
                objNew.oAviacaoLocalLinhapId = Nothing
                objNew.oAviacaoCaminhaopId = Me.oAviacaoCaminhaopId

                objNew.Save()
            End If

        End Sub

        Private Sub OnAfterSave()
            If Me.pDATA_RETORNO <> Nothing And Me.pSTATUS <> "EM VIAGEM" Then

                Dim objNew As New S5T.AviacaoViagemMov

                objNew.pDATA_SAIDA = Nothing
                objNew.pDATA_PREV_RETORNO = Nothing
                objNew.pDATA_RETORNO = Nothing

                objNew.oAviacaoMotoristapId = Me.oAviacaoCaminhao.oAviacaoMotoristapId
                objNew.oAviacaoLocalLinhapId = Nothing
                objNew.oAviacaoCaminhaopId = Me.oAviacaoCaminhaopId

                objNew.Save()
            End If
        End Sub

    End Class
End Namespace
