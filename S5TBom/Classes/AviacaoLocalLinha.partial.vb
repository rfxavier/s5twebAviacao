Imports CodeFluent.Runtime

Namespace S5T
    Public Class AviacaoLocalLinha
        Private Sub OnBeforeSave()
            If Me.EntityState = CodeFluentEntityState.Created Then

                Dim objMaxCodigo = S5T.AviacaoLocalLinha.LoadMaxCodigo
                If objMaxCodigo Is Nothing Then
                    Me.pCODIGO = 1
                Else
                    Me.pCODIGO = objMaxCodigo.pId + 1
                End If

            End If
        End Sub

    End Class
End Namespace
