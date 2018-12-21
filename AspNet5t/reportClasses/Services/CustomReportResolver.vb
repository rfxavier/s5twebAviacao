Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports Newtonsoft.Json

Namespace ReportingBackend.Services
    Friend Class ReportInfo
        Public Property DisplayName() As String
        Public Property GetReport() As Func(Of XtraReport)
    End Class

    Public Class reportInfoParamDia
        Public Property reportClass As String
        Public Property reportParamDia As String
    End Class
    Public Class reportInfoParamVendedorDiaInicialFinal
        Public Property reportClass As String
        Public Property reportParamCodVendedor As String
        Public Property reportParamDiaInicial As String
        Public Property reportParamDiaFinal As String
    End Class

    Public Class reportInfoParamVendedorClienteDiaInicialFinal
        Public Property reportClass As String
        Public Property reportParamCodVendedor As String
        Public Property reportParamCodCliente As String
        Public Property reportParamCodLoja As String
        Public Property reportParamDiaInicial As String
        Public Property reportParamDiaFinal As String
    End Class
    
    Public Class reportInfoParamVendedorClienteDiaInicialFinalStatusTitulos
        Public Property reportClass As String
        Public Property reportParamCodVendedor As String
        Public Property reportParamCodCliente As String
        Public Property reportParamCodLoja As String
        Public Property reportParamDiaVencimentoInicial As String
        Public Property reportParamDiaVencimentoFinal As String
        Public Property reportParamDiaEmissaoInicial As String
        Public Property reportParamDiaEmissaoFinal As String
        Public Property reportParamStatusTitulos As String
    End Class


    Public Class CustomReportResolver
        Implements IWebDocumentViewerReportResolver

        Private reports As New Dictionary(Of String, ReportInfo)()

        Private Function IWebDocumentViewerReportResolver_Resolve(ByVal reportEntry As String) As XtraReport Implements IWebDocumentViewerReportResolver.Resolve
            Dim objReportInfo = JsonConvert.DeserializeObject(reportEntry)

            Select Case objReportInfo.First.Value
                Case "repCnIndEnvaseOverview"
                    Dim objReportInfoTyped = New reportInfoParamDia()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamDia)(reportEntry)

                    'Dim varDataReferencia = Now.AddDays(-1)
                    Dim varDataReferencia = Convert.ToDateTime(objReportInfoTyped.reportParamDia)

                    Dim report = New repCnIndEnvaseOverview

                    report.Parameters(0).Value = varDataReferencia.ToString("yyyyMMdd") & "_AUTOGEN"

                    Return report
                Case "repCnIndLeiteCamarasFriasOverview"
                    Dim objReportInfoTyped = New reportInfoParamDia()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamDia)(reportEntry)

                    'Dim varDataReferencia = Now.AddDays(-1)
                    Dim varDataReferencia = Convert.ToDateTime(objReportInfoTyped.reportParamDia)

                    Dim report = New repCnIndLeiteCamarasFriasOverview

                    report.Parameters(0).Value = varDataReferencia.ToString("yyyyMMdd") & "_AUTOGEN"

                    Return report
                Case "repCnVendasVendasDiariaVendedorLive"
                    Dim objReportInfoTyped = New reportInfoParamVendedorDiaInicialFinal()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamVendedorDiaInicialFinal)(reportEntry)

                    Dim varCodVendedor = objReportInfoTyped.reportParamCodVendedor
                    Dim varDataReferenciaInicial = Convert.ToDateTime(objReportInfoTyped.reportParamDiaInicial)
                    Dim varDataReferenciaFinal = Convert.ToDateTime(objReportInfoTyped.reportParamDiaFinal)

                    Dim report = New repCnVendasVendasDiariaVendedorLive

                    report.Parameters(0).Value = varCodVendedor
                    report.Parameters(1).Value = varDataReferenciaInicial
                    report.Parameters(2).Value = varDataReferenciaFinal

                    Return report
                Case "repCnVendasVendasDiariaVendedorClienteLive"
                    Dim objReportInfoTyped = New reportInfoParamVendedorClienteDiaInicialFinal()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamVendedorClienteDiaInicialFinal)(reportEntry)

                    Dim varCodVendedor = objReportInfoTyped.reportParamCodVendedor
                    Dim varCodCliente = objReportInfoTyped.reportParamCodCliente
                    Dim varCodLoja = objReportInfoTyped.reportParamCodLoja
                    Dim varDataReferenciaInicial = Convert.ToDateTime(objReportInfoTyped.reportParamDiaInicial)
                    Dim varDataReferenciaFinal = Convert.ToDateTime(objReportInfoTyped.reportParamDiaFinal)

                    Dim report = New repCnVendasVendasDiariaVendedorClienteLive

                    report.Parameters("parRepCodVendedor").Value = varCodVendedor
                    report.Parameters("parRepCodCliente").Value = varCodCliente
                    report.Parameters("parRepCodLoja").Value = varCodLoja
                    report.Parameters("parRepDataInicial").Value = varDataReferenciaInicial
                    report.Parameters("parRepDataFinal").Value = varDataReferenciaFinal

                    Return report
                case "repCnFinanceiroTitulosVendedorCliente"
                    Dim objReportInfoTyped = New reportInfoParamVendedorClienteDiaInicialFinalStatusTitulos()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamVendedorClienteDiaInicialFinalStatusTitulos)(reportEntry)

                    Dim varCodVendedor = objReportInfoTyped.reportParamCodVendedor
                    Dim varCodCliente = objReportInfoTyped.reportParamCodCliente
                    Dim varCodLoja = objReportInfoTyped.reportParamCodLoja
                    Dim varDataReferenciaVencimentoInicial = Convert.ToDateTime(objReportInfoTyped.reportParamDiaVencimentoInicial)
                    Dim varDataReferenciaVencimentoFinal = Convert.ToDateTime(objReportInfoTyped.reportParamDiaVencimentoFinal)
                    Dim varDataReferenciaEmissaoInicial = Convert.ToDateTime(objReportInfoTyped.reportParamDiaEmissaoInicial)
                    Dim varDataReferenciaEmissaoFinal = Convert.ToDateTime(objReportInfoTyped.reportParamDiaEmissaoFinal)
                    Dim varStatusTitulos = objReportInfoTyped.reportParamStatusTitulos

                    Dim report = New repCnFinanceiroTitulosVendedorCliente

                    report.Parameters("parRepCodVendedor").Value = varCodVendedor
                    report.Parameters("parRepCodCliente").Value = varCodCliente
                    'report.Parameters("parRepCodLoja").Value = varCodLoja
                    report.Parameters("parRepDataInicial").Value = varDataReferenciaVencimentoInicial
                    report.Parameters("parRepDataFinal").Value = varDataReferenciaVencimentoFinal
                    report.Parameters("parRepDataEmisInicial").Value = varDataReferenciaEmissaoInicial
                    report.Parameters("parRepDataEmisFinal").Value = varDataReferenciaEmissaoFinal
                    report.Parameters("parStatusTitulos").Value = varStatusTitulos

                    Return report
                Case "repCnVendasPedidosAbertosVendedorClienteLive"
                    Dim objReportInfoTyped = New reportInfoParamVendedorClienteDiaInicialFinal()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamVendedorClienteDiaInicialFinal)(reportEntry)

                    Dim varCodVendedor = objReportInfoTyped.reportParamCodVendedor
                    Dim varCodCliente = objReportInfoTyped.reportParamCodCliente
                    Dim varCodLoja = objReportInfoTyped.reportParamCodLoja
                    Dim varDataReferenciaInicial = Convert.ToDateTime(objReportInfoTyped.reportParamDiaInicial)
                    Dim varDataReferenciaFinal = Convert.ToDateTime(objReportInfoTyped.reportParamDiaFinal)

                    Dim report = New repCnVendasPedidosAbertosVendedorClienteLive

                    report.Parameters("parRepCodVendedor").Value = varCodVendedor
                    report.Parameters("parRepCodCliente").Value = varCodCliente
                    report.Parameters("parRepCodLoja").Value = varCodLoja
                    report.Parameters("parRepDataInicial").Value = varDataReferenciaInicial
                    report.Parameters("parRepDataFinal").Value = varDataReferenciaFinal

                    Return report
                Case "repCnVendasClientesBloqueadosVendedor"
                    Dim objReportInfoTyped = New reportInfoParamVendedorDiaInicialFinal()
                    objReportInfoTyped = JsonConvert.DeserializeObject(Of reportInfoParamVendedorDiaInicialFinal)(reportEntry)

                    Dim varCodVendedor = objReportInfoTyped.reportParamCodVendedor

                    Dim report = New repCnVendasClientesBloqueadosVendedor

                    report.Parameters("parCodVendedor").Value = varCodVendedor

                    Return report
            End Select

            Return Nothing
        End Function

        ' Get the list of available reports from the server.
        Public Function GetAvailableReports() As Dictionary(Of String, String)
            Return reports.ToDictionary(Function(r) r.Key, Function(r) r.Value.DisplayName)
        End Function


    End Class
End Namespace