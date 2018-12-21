Imports DevExpress.DataAccess.ConnectionParameters
Imports Microsoft.AspNet.Identity
Imports DevExpress.Web

Public Class cnFinanceiroTitulosAbertoPorVendedor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnFinanceiroTitulosAbertoVendedorSeparado)
            ASPxDashboardViewer1.DataBind()

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)

            ASPxComboBox1.Focus()
        End If
    End Sub

    Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParametersOracle
    End Sub

    Private Sub ASPxDashboardViewer1_CustomParameters(sender As Object, e As DevExpress.DashboardWeb.CustomParametersWebEventArgs) Handles ASPxDashboardViewer1.CustomParameters
        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        If objUsuario IsNot Nothing Then
            If objUsuario.pCodigoVendedor = "" Then
                e.Parameters(0).Value = "000"
                e.Parameters(1).Value = "219"
            Else
                e.Parameters(0).Value = objUsuario.pCodigoVendedor
                e.Parameters(1).Value = objUsuario.pCodigoVendedor

            End If
        Else
            e.Parameters(0).Value = "000"
            e.Parameters(1).Value = "219"
        End If
    End Sub

    Protected Sub ASPxComboBox_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT pCODIGO, pNOME FROM (select pCODIGO, pNOME, row_number() over(order by t.pNOME) as rn from AviacaoTitulosClientes as t where ((pNOME + ' ' + pCODIGO) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

    Protected Sub ASPxComboBox_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
        Dim value As Long = 0
        If e.Value Is Nothing Then
            Return
        End If
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT pCODIGO, pNOME FROM AviacaoTitulosClientes WHERE (pCODIGO = @pCODIGO)"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("pCODIGO", TypeCode.String, e.Value.ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub

End Class