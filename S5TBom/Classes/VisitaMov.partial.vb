Imports CodeFluent.Runtime

Namespace S5T
    Public Class VisitaMov
        Private Sub OnBeforeSave()
            If Me.pDataVisita = Nothing Then
                Throw New CodeFluentValidationException("[TxtDATAVISITA] ")
            End If

            If Me.oVisitante Is Nothing Then
                Throw New CodeFluentValidationException("[cmbVisitante] ")
            End If
            If Me.oSetor Is Nothing Then
                Throw New CodeFluentValidationException("[cmbSetor] ")
            End If
            If Me.oFuncionario Is Nothing Then
                Throw New CodeFluentValidationException("[cmbFuncionario]")
            End If

            If Me.oEmpresa Is Nothing Then
                Throw New CodeFluentValidationException("[cmbEmpresa] ")
            End If




        End Sub


    End Class
End Namespace
