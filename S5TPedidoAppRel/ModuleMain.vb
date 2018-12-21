Imports AspNet5t

Module ModuleMain

    Sub Main()
        Try
            Dim args As String() = Environment.GetCommandLineArgs()

            Dim strNomeRelatorio = args(1)

            Select Case strNomeRelatorio
                Case "PedidoEspelho"
                    Console.WriteLine(args(1))

                    Dim strPedidoNumero As String = String.Empty
                    Dim strFullFileName As String = String.Empty

                    If args.Length > 2 AndAlso args(2) <> "" AndAlso args(3) <> "" Then
                        strPedidoNumero = args(2)
                        strFullFileName = args(3)

                        Console.WriteLine(args(2))
                        Console.WriteLine(args(3))


                        Dim objReport = New repPedidoAppForcaVendas

                        objReport.Parameters(0).Value = strPedidoNumero
                        objReport.ExportToPdf(strFullFileName)

                        Console.WriteLine("ExportToPdf")


                    End If
            End Select
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Module
