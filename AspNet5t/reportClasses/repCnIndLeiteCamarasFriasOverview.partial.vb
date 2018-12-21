Imports System.Drawing.Printing

Public partial Class repCnIndLeiteCamarasFriasOverview
    Private Sub repCnIndLeiteCamarasFriasOverview_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim varDataYYYYMMDD = Parameters("repParIdTag").Value.ToString.Substring(0,8)
        Dim varData As Date = Date.ParseExact(varDataYYYYMMDD, "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        'labelData.Text = Parameters("repParIdTag").Value

        labelData.Text =  CDate(varData).ToString("dd/MM/yyyy")
    End Sub
End Class
