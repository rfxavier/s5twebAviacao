Namespace S5T

    Partial Public Class TaraFracionamento
        Private Sub OnBeforeSave()
            If Me.C2_PRODUTO = "" Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Produto Final não pode ser nulo")
            End If
            If Me.G1_COMP = "" Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Produto - Matéria Prima não pode ser nulo")
            End If
            If Me.oEmbalagempId = 0 Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Embalagem não pode ser nula")
            End If
            If Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created Then
                If (S5T.TaraFracionamentoCollection.LoadByProdutos(Me.C2_PRODUTO,me.G1_COMP).count) > 0 Then
                    Throw New CodeFluent.Runtime.CodeFluentValidationException("INCLUSÃO NEGADA - Embalagem vinculada para o Produto Final e Matéria Prima.")
                End If
                
            End If

        End Sub
        Private Sub OnBeforeDelete()
          
        End Sub

    End Class
End Namespace
