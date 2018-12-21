Imports Microsoft.AspNet.Identity

Public Class RelVendasDiariaVendedor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsPostBack) And (Not IsCallback) Then
            'dataReferencia.Date = Now.AddDays(-8)
            dataReferencia.Date = Now
        End If

        'Dim oRelatorio = New repCnVendasVendasDiariaVendedor
        'Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)
        'Dim dsDados = S5T.AviacaoVendasCollection.LoadViewRelVendedor(dataReferencia.Date, dataReferencia.Date)

        'If dsDados IsNot Nothing And objUsuario IsNot Nothing Then
        '    dsDados = dsDados.FindAll(Function(x) Trim(x.pCODIGO_VENDEDOR) = Trim(objUsuario.pCodigoVendedor))
        'End If

        'oRelatorio.DataSource = dsDados

        'oRelatorio.CreateDocument()



        Dim parCodVendedor As String = "015"

        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        if objUsuario IsNot Nothing
            parCodVendedor = objUsuario.pCodigoVendedor
        End If

        Dim oRelatorio = New repCnVendasVendasDiariaVendedorLive

        oRelatorio.Parameters(0).Value = parCodVendedor
        oRelatorio.Parameters(1).Value = dataReferencia.Date
        oRelatorio.Parameters(2).Value = dataReferencia.Date


        ASPxWebDocumentViewer.OpenReport(oRelatorio)

    End Sub

End Class