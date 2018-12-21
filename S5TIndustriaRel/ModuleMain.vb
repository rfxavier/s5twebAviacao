Imports AspNet5t

Module ModuleMain

    Sub Main()
        Dim args As String() = Environment.GetCommandLineArgs()

        Dim strNomeRelatorio = args(1)

        Select Case strNomeRelatorio
            Case "EnvaseOverview"
                dim strIdtag As String = String.Empty
                dim strFullFileName As String = String.Empty

                if args.Length > 2 AndAlso args(2) <> "" AndAlso args(3) <> ""
                    strIdtag = args(2)
                    strFullFileName = args(3)

                    dim objReport = new repCnIndEnvaseOverview

                    objReport.Parameters(0).Value = strIdtag
                    objReport.ExportToPdf(strFullFileName)

                End If

            Case "LeiteCamarasFriasOverview"
                dim strIdtag As String = String.Empty
                dim strFullFileName As String = String.Empty

                if args.Length > 2 AndAlso args(2) <> "" AndAlso args(3) <> ""
                    strIdtag = args(2)
                    strFullFileName = args(3)

                    dim objReport = new repCnIndLeiteCamarasFriasOverview

                    objReport.Parameters(0).Value = strIdtag
                    objReport.ExportToPdf(strFullFileName)

                End If

        End Select

    End Sub

End Module
