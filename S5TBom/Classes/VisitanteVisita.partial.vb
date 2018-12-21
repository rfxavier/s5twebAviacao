Imports CodeFluent.Runtime

Namespace S5T
    Public Class VisitanteVisita
        Private Sub OnBeforeSave()
            If Me.pNome = "" Then
                Throw New CodeFluentValidationException("Nome não pode ser nulo.")
            End If
            If Me.pCpfCnpj = "" and Me.pRg = "" Then
                Throw New CodeFluentValidationException("CPF ou RG deve ser peenchido.")
            End If

            If Me.pCpfCnpj <> "" Then

                Dim cpfcnpj1 As New valida_CNPJ_CPF
                cpfcnpj1.cpf = Me.pCpfCnpj
                cpfcnpj1.cnpj = Me.pCpfCnpj

                If (cpfcnpj1.isCpfValido = False) And (cpfcnpj1.isCnpjValido = False And cpfcnpj1.cpf <> "") Then
                    Throw New CodeFluentValidationException("CPF inválido")
                End If

            End If
            'If Me.pTelefoneCelular = "" Then
            '    Throw New CodeFluentValidationException("[TxtTELEFONECEL]")
            'End If
        End Sub

        Private Sub OnBeforeDelete()
            If Me.oVisitaMovs.Count > 0 Then
                Throw New CodeFluentValidationException("[VisitanteVisita] Há visítas atreladas a este visitante, não é possível excluir o registro!")

            End If
        End Sub
    End Class
End Namespace
