Imports DevExpress.Utils
Imports DevExpress.Web.ASPxPivotGrid
Imports Microsoft.AspNet.Identity
Imports DevExpress.Web
Imports DevExpress.Export
Public Class pivotVendasAgrupAnoMenos1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ASPxPivotGrid1.DataBind()

        If (Not IsPostBack) AndAlso (Not IsCallback) Then
            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)

            Session("clientesArrList") = Nothing
        Else
            'ASPxPivotGrid1.OptionsView.ShowRowGrandTotals = cbShowRowGrandTotals.Checked
            'ASPxPivotGrid1.OptionsView.ShowRowTotals = cbShowRowTotals.Checked

        End If

        If cbDataHeader.Checked Then
            ASPxPivotGrid1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.RowArea
        Else
            ASPxPivotGrid1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        End If

        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)
        If objUsuario IsNot Nothing Then
            SqlDataSourceGridPivotAnalise.SelectCommand = "SELECT * FROM AviacaoPivotAnalise where (oUsuario_pId= " & objUsuario.pId & " or pFlgCompartilhada ='S') and pPivotNome = '" & Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1) & "' Order by pDescricao asc"
        Else
            SqlDataSourceGridPivotAnalise.SelectCommand = "SELECT * FROM AviacaoPivotAnalise where pPivotNome = '" & Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1) & "' Order by pDescricao asc"
        End If

        Dim ListaPastas = S5T.AviacaoPivotAnaliseCollection.LoadAll

        If ListaPastas.Count > 0 Then
            For Each objLista In ListaPastas.GroupBy(Function(X) X.pPastaNome).Select(Function(y) New With {.pPastaNome = y.Key}).ToList
                ASPxComboBoxPasta.Items.Add(objLista.pPastaNome, objLista.pPastaNome)
            Next
        End If

        ASPxGridView2.GroupBy(ASPxGridView2.Columns("pPastaNome"))

        SqlDataSourceGridPivotAnalise.DataBind()
    End Sub

    Private Sub ASPxPivotGrid1_DataBinding(sender As Object, e As EventArgs) Handles ASPxPivotGrid1.DataBinding
        ASPxPivotGrid1.DataSource = LinqServerModeDataSource1

    End Sub

    Protected Sub buttonSaveAs_Click(sender As Object, e As EventArgs) Handles buttonSaveAs.Click
        Export(True)
    End Sub

    Private Sub Export(ByVal saveAs As Boolean)
        For Each field As PivotGridField In ASPxPivotGrid1.Fields
            If field.ValueFormat IsNot Nothing AndAlso (Not String.IsNullOrEmpty(field.ValueFormat.FormatString)) Then
                field.UseNativeFormat = DefaultBoolean.True
            End If
        Next field
        ASPxPivotGridExporter1.OptionsPrint.PrintHeadersOnEveryPage = DefaultBoolean.False
        ASPxPivotGridExporter1.OptionsPrint.MergeColumnFieldValues = DefaultBoolean.True
        ASPxPivotGridExporter1.OptionsPrint.MergeRowFieldValues = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False

        ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = DefaultBoolean.False

        ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = DefaultBoolean.False

        Dim fileName As String = "PivotVendas"

        ASPxPivotGridExporter1.ExportXlsToResponse(fileName, saveAs)
    End Sub
    Protected Sub buttonSaveAsRaw_Click(sender As Object, e As EventArgs) Handles buttonSaveAsRaw.Click
        ExportRaw(True)
    End Sub

    Private Sub ExportRaw(ByVal saveAs As Boolean)
        For Each field As DevExpress.Web.ASPxPivotGrid.PivotGridField In ASPxPivotGrid1.Fields
            If field.ValueFormat IsNot Nothing AndAlso (Not String.IsNullOrEmpty(field.ValueFormat.FormatString)) Then
                field.UseNativeFormat = DefaultBoolean.True
            End If
        Next field
        Dim options As DevExpress.XtraPrinting.XlsxExportOptionsEx

        options = New DevExpress.XtraPrinting.XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG, .AllowGrouping = DefaultBoolean.False, .RawDataMode = True, .ShowColumnHeaders = DefaultBoolean.True}

        ASPxPivotGridExporter1.OptionsPrint.PrintHeadersOnEveryPage = DefaultBoolean.False
        ASPxPivotGridExporter1.OptionsPrint.MergeColumnFieldValues = DefaultBoolean.True
        ASPxPivotGridExporter1.OptionsPrint.MergeRowFieldValues = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False

        ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = DefaultBoolean.True

        ASPxPivotGridExporter1.OptionsPrint.PrintHorzLines = DefaultBoolean.True
        ASPxPivotGridExporter1.OptionsPrint.PrintVertLines = DefaultBoolean.True

        Dim fileName As String = "PivotVendas"

        ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs)
    End Sub
    Protected Sub ASPxButtonNova_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        'Dim objNew As New S5T.AviacaoPivotAnalise
        'With objNew
        '    .pDescricao = Trim(UCase(txtNomeAnalise.Text))
        '    .pModeloAnaliseXml = ASPxPivotGrid1.SaveLayoutToString
        '    .oUsuario = objUsuario
        '    .pLayoutVersion = "v1.0"
        '    .pPivotNome = Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1)
        '    .pPastaNome = ASPxComboBoxPasta.Text
        '    .pFlgCompartilhada = IIf(ASPxCheckBoxCompartilhada.Checked, "S", "N")
        '    .Save()
        'End With
        'ASPxLabelNomeAnalise.Text = "Análise: " & Trim(UCase(txtNomeAnalise.Text))

        'ASPxButtonRestaurar.ClientVisible = False
        'ASPxPopupControl1.ShowOnPageLoad = False

        ''AtualizaGridAnalises()
        'ASPxButtonRestaurar.ClientVisible = True
        'ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "refreshGridAnalises();", True)


        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        Dim obj As S5T.AviacaoPivotAnalise
        If objUsuario IsNot Nothing Then
            obj = S5T.AviacaoPivotAnaliseCollection.LoadbyDescricao(Trim(UCase(txtNomeAnalise.Text)), objUsuario.pId).OrderByDescending(Function(y) y.pId).FirstOrDefault
        Else
            obj = Nothing
        End If

        If obj IsNot Nothing Then
            Dim objNew As New S5T.AviacaoPivotAnalise
            With objNew
                .pDescricao = Trim(UCase(txtNomeAnalise.Text))
                .pModeloAnaliseXml = ASPxPivotGrid1.SaveLayoutToString
                .oUsuario = objUsuario
                .pLayoutVersion = "v1." & Mid(obj.pLayoutVersion, 4) + 1
                .pPivotNome = Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1)
                .pPastaNome = ASPxComboBoxPasta.Text
                .pFlgCompartilhada = IIf(ASPxCheckBoxCompartilhada.Checked, "S", "N")
                .Save()

                ASPxLabelNomeAnalise.Text = "Análise: " & Trim(UCase(txtNomeAnalise.Text))
            End With
        Else
            Dim objNew As New S5T.AviacaoPivotAnalise
            With objNew
                .pDescricao = Trim(UCase(txtNomeAnalise.Text))
                .pModeloAnaliseXml = ASPxPivotGrid1.SaveLayoutToString
                .oUsuario = objUsuario
                .pLayoutVersion = "v1.0"
                .pPivotNome = Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1)
                .pPastaNome = ASPxComboBoxPasta.Text
                .pFlgCompartilhada = IIf(ASPxCheckBoxCompartilhada.Checked, "S", "N")
                .Save()

                ASPxLabelNomeAnalise.Text = "Análise: " & Trim(UCase(txtNomeAnalise.Text))
            End With
        End If

        ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "refreshGridAnalises();", True)
        ASPxPopupControl1.ShowOnPageLoad = False



    End Sub

    Protected Sub ASPxButtonRestaurar_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Session("PiVeLay" & User.Identity.GetUserName) = ASPxPivotGrid1.SaveLayoutToString()
        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        Dim obj As S5T.AviacaoPivotAnalise
        If objUsuario IsNot Nothing Then
            obj = S5T.AviacaoPivotAnaliseCollection.LoadbyDescricao(Trim(UCase(txtNomeAnalise.Text)), objUsuario.pId).LastOrDefault
        Else
            obj = Nothing
        End If

        If obj IsNot Nothing Then
            Dim objNew As New S5T.AviacaoPivotAnalise
            With objNew
                .pDescricao = Trim(UCase(txtNomeAnalise.Text))
                .pModeloAnaliseXml = ASPxPivotGrid1.SaveLayoutToString
                .oUsuario = objUsuario
                .pLayoutVersion = "v1." & Mid(obj.pLayoutVersion, 4) + 1
                .pPivotNome = Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1)
                .pPastaNome = ASPxComboBoxPasta.Text
                .pFlgCompartilhada = IIf(ASPxCheckBoxCompartilhada.Checked, "S", "N")
                .Save()

                ASPxLabelNomeAnalise.Text = "Análise: " & Trim(UCase(txtNomeAnalise.Text))
            End With
        Else
            Dim objNew As New S5T.AviacaoPivotAnalise
            With objNew
                .pDescricao = Trim(UCase(txtNomeAnalise.Text))
                .pModeloAnaliseXml = ASPxPivotGrid1.SaveLayoutToString
                .oUsuario = objUsuario
                .pLayoutVersion = "v1.0"
                .pPivotNome = Request.CurrentExecutionFilePath.Remove(0, Request.CurrentExecutionFilePath.LastIndexOf("/") + 1)
                .pPastaNome = ASPxComboBoxPasta.Text
                .pFlgCompartilhada = IIf(ASPxCheckBoxCompartilhada.Checked, "S", "N")
                .Save()

                ASPxLabelNomeAnalise.Text = "Análise: " & Trim(UCase(txtNomeAnalise.Text))
            End With
        End If

        ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "refreshGridAnalises();", True)
        ASPxPopupControl1.ShowOnPageLoad = False

    End Sub

    Protected Sub ASPxButtonExcluir_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim pid As Integer
        If ASPxHiddenField1.Contains("pId") Then
            pid = ASPxHiddenField1("pId")
        End If

        Dim obj = S5T.AviacaoPivotAnalise.LoadBypId(pid)
        obj.Delete()

        ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "refreshGridAnalises();", True)
        'ASPxPopupControl2.ShowOnPageLoad = False

    End Sub
    Protected Function RetornaIdUsuario()
        Return User.Identity.GetUserId
    End Function
    Protected Sub ASPxButton3_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim pid As Integer
        If ASPxHiddenField1.Contains("pId") Then
            pid = ASPxHiddenField1("pId")
        End If

        Dim obj = S5T.AviacaoPivotAnalise.LoadBypId(pid)
        ASPxPivotGrid1.LoadLayoutFromString(obj.pModeloAnaliseXml)

        ASPxPopupControl2.ShowOnPageLoad = False

        txtNomeAnalise.Text = obj.pDescricao
        ASPxComboBoxPasta.Text = obj.pPastaNome
        If obj.pFlgCompartilhada = "S" Then
            ASPxCheckBoxCompartilhada.Checked = True
        Else
            ASPxCheckBoxCompartilhada.Checked = False
        End If

        ASPxLabelNomeAnalise.Text = "Análise: " & obj.pDescricao

        'ASPxButtonRestaurar.ClientVisible = True
        ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "refreshGridAnalises();", True)

    End Sub
    Protected Sub ASPxButtonPesquisar_Click(sender As Object, e As EventArgs) Handles ASPxButtonPesquisar.Click
        Dim varClienteArrList As ArrayList = New ArrayList

        If Session("clientesArrList") IsNot Nothing Then
            varClienteArrList = CType(Session("clientesArrList"), ArrayList)
        End If

        varClienteArrList.Insert(0, ASPxComboBox1.Value.ToString)

        Session("clientesArrList") = varClienteArrList

        Dim str1 = pivot4tCriteriaListaClientesString(ASPxPivotGrid1.Prefilter.CriteriaString, varClienteArrList)

        ASPxPivotGrid1.Prefilter.CriteriaString = str1

        ASPxComboBox1.SelectedIndex = -1
    End Sub
    Protected Sub ASPxComboBox_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
        Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
        SqlDataSource1.SelectCommand = "SELECT pCLIENTE, pNOME_CLIENTE FROM (select pCLIENTE, pNOME_CLIENTE, row_number() over(order by t.pNOME_CLIENTE) as rn from AviacaoClientes as t where ((pNOME_CLIENTE + ' ' + pCLIENTE) LIKE @filter)) as st where st.rn between @startIndex and @endIndex"

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
        SqlDataSource1.SelectCommand = "SELECT pCLIENTE, pNOME_CLIENTE FROM AviacaoClientes WHERE (pCLIENTE = @pCLIENTE)"

        SqlDataSource1.SelectParameters.Clear()
        SqlDataSource1.SelectParameters.Add("pCLIENTE", TypeCode.String, e.Value.ToString())
        comboBox.DataSource = SqlDataSource1
        comboBox.DataBind()
    End Sub
    Protected Sub ASPxPivotGrid1_CustomCellValue(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs)
        If e.DataField Is calcPRECOMEDIOVENDA Then
            Dim valorPrecoMedio As Double = GetPrecoMedio(e)
            e.Value = valorPrecoMedio
        ElseIf e.DataField Is calcCUSTOPRODQTD Then
            Dim valorCustoProd As Double = GetCustoProdQtd(e)
            e.Value = valorCustoProd
        End If

    End Sub

    Private Function GetPrecoMedio(ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs) As Double

        Dim values As New Double
        Dim valuesProduto As New Double
        Dim valuesQuantidade As New Double

        valuesProduto = e.GetFieldValue(fieldpVLRTOTALPRODUTO1)
        valuesQuantidade = e.GetFieldValue(fieldpQUANTIDADE1)

        If valuesProduto > 0 And valuesQuantidade > 0 Then
            values = valuesProduto / valuesQuantidade
        Else
            values = 0
        End If

        Return values
    End Function

    Private Function GetCustoProdQtd(ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs) As Double

        Dim values As New Double
        Dim valuesProduto As New Double
        Dim valuesQuantidade As New Double

        valuesProduto = e.GetFieldValue(fieldpCUSTOPRODUTO1)
        valuesQuantidade = e.GetFieldValue(fieldpQUANTIDADE1)

        If valuesProduto > 0 And valuesQuantidade > 0 Then
            values = valuesProduto / valuesQuantidade
        Else
            values = 0
        End If

        Return values
    End Function



End Class