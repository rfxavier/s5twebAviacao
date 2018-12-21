
Imports System.Drawing.Printing
Imports DevExpress.XtraCharts

Public Partial Class repCnIndEnvaseOverview
    Private Sub repCnIndEnvaseOverview_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        dim dsEnvaseInfo = dsIndustria.GetEnvaseInfo(Parameters("repParIdTag").Value)
        dim objEnvaseInfo As dsIndustria.EnvaseInfo = dsEnvaseInfo.FirstOrDefault

        'ANNOTATIONS ENVASE A
        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnABal1200g
        if chartEnABal1200g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_a_media_liminfcopo_pote200, objEnvaseInfo.envase_a_media_limsupcopo_pote200)
            End If

            DirectCast((chartEnABal1200g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnABal2200g
        if chartEnABal2200g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_a_media_liminfcopo_pote200, objEnvaseInfo.envase_a_media_limsupcopo_pote200)
            End If

            DirectCast((chartEnABal2200g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnABal1500g
        if chartEnABal1500g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_a_media_liminfcopo_pote500, objEnvaseInfo.envase_a_media_limsupcopo_pote500)
            End If

            DirectCast((chartEnABal1500g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnABal2500g
        if chartEnABal2500g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_a_media_liminfcopo_pote500, objEnvaseInfo.envase_a_media_limsupcopo_pote500)
            End If

            DirectCast((chartEnABal2500g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If


        'ANNOTATIONS ENVASE B
        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - ChartEnBBal1200g
        if ChartEnBBal1200g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_b_media_liminfcopo_pote200, objEnvaseInfo.envase_b_media_limsupcopo_pote200)
            End If

            DirectCast((ChartEnBBal1200g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnBBal2200g
        if chartEnBBal2200g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_b_media_liminfcopo_pote200, objEnvaseInfo.envase_b_media_limsupcopo_pote200)
            End If

            DirectCast((chartEnBBal2200g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnBBal1500g
        if chartEnBBal1500g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_b_media_liminfcopo_pote500, objEnvaseInfo.envase_b_media_limsupcopo_pote500)
            End If

            DirectCast((chartEnBBal1500g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If

        'ANNOTATION DOS LIMITES INFERIOR DE SUPERIOR - chartEnBBal2500g
        if chartEnBBal2500g.Annotations.Count > 0 then
            dim varTextoLimitesCopo As String = string.Empty

            if objEnvaseInfo IsNot nothing Then
                varTextoLimitesCopo = string.Format("LIMITES COPO" & vbCrLf & vbCrLf & "Média Superior" & vbCrLf & "{1:#0}g" & vbCrLf & vbCrLf & "Média Inferior" & vbCrLf & "{0:#0}g", objEnvaseInfo.envase_b_media_liminfcopo_pote500, objEnvaseInfo.envase_b_media_limsupcopo_pote500)
            End If

            DirectCast((chartEnBBal2500g.Annotations.Item(0)), DevExpress.XtraCharts.TextAnnotation).[Text]	= varTextoLimitesCopo
        End If


        Dim dsChart1IList As IList = TryCast(chartEnABal1200g.DataSource, DevExpress.DataAccess.ObjectBinding.ObjectDataSource)
        dim dsChart1 = dsChart1IList.Cast(of dsindustria.EnvaseMov).ToList

        Dim dsChartsEnvaseABalanca1200g = dsChart1.Where(function(x) x.itemid = 25677 And x.ultTipoPote = 0).ToList
        Dim dsChartsEnvaseABalanca1500g = dsChart1.Where(function(x) x.itemid = 25677 And x.ultTipoPote = 1).ToList
        Dim dsChartsEnvaseABalanca2200g = dsChart1.Where(function(x) x.itemid = 25679 And x.ultTipoPote = 0).ToList
        Dim dsChartsEnvaseABalanca2500g = dsChart1.Where(function(x) x.itemid = 25679 And x.ultTipoPote = 1).ToList
        Dim dsChartsEnvaseBBalanca1200g = dsChart1.Where(function(x) x.itemid = 25874 And x.ultTipoPote = 0).ToList
        Dim dsChartsEnvaseBBalanca1500g = dsChart1.Where(function(x) x.itemid = 25874 And x.ultTipoPote = 1).ToList
        Dim dsChartsEnvaseBBalanca2200g = dsChart1.Where(function(x) x.itemid = 25838 And x.ultTipoPote = 0).ToList
        Dim dsChartsEnvaseBBalanca2500g = dsChart1.Where(function(x) x.itemid = 25838 And x.ultTipoPote = 1).ToList

        dim arrSlotsYLocation(8) As Double

        'arrSlotsYLocation(0) = 164.54
        arrSlotsYLocation(0) = chartEnABal1200g.LocationF.Y
        arrSlotsYLocation(1) = arrSlotsYLocation(0) + 400
        arrSlotsYLocation(2) = arrSlotsYLocation(1) + 400
        arrSlotsYLocation(3) = arrSlotsYLocation(2) + 400
        arrSlotsYLocation(4) = arrSlotsYLocation(3) + 400
        arrSlotsYLocation(5) = arrSlotsYLocation(4) + 400
        arrSlotsYLocation(6) = arrSlotsYLocation(5) + 400
        arrSlotsYLocation(7) = arrSlotsYLocation(6) + 400

        dim posArraySlots As Integer = 0

        if dsChartsEnvaseABalanca1200g.Count > 0 Then
            chartEnABal1200g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnABal1200g.Visible = False
        End If

        if dsChartsEnvaseABalanca1500g.Count > 0 Then
            chartEnABal1500g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnABal1500g.Visible = False
        End If

        if dsChartsEnvaseABalanca2200g.Count > 0 Then
            chartEnABal2200g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnABal2200g.Visible = False
        End If
        
        if dsChartsEnvaseABalanca2500g.Count > 0 Then
            chartEnABal2500g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnABal2500g.Visible = False
        End If

        if dsChartsEnvaseBBalanca1200g.Count > 0 Then
            chartEnBBal1200g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnBBal1200g.Visible = False
        End If
        
        if dsChartsEnvaseBBalanca1500g.Count > 0 Then
            chartEnBBal1500g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnBBal1500g.Visible = False
        End If
        
        if dsChartsEnvaseBBalanca2200g.Count > 0 Then
            chartEnBBal2200g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnBBal2200g.Visible = False
        End If

        if dsChartsEnvaseBBalanca2500g.Count > 0 Then
            chartEnBBal2500g.LocationF = new drawing.PointF(0, arrSlotsYLocation(posArraySlots))
            posArraySlots +=1
        else
            chartEnBBal2500g.Visible = False
        End If

        'Dim dsChartsEnvaseABalanca1 = dsChart1.Where(function(x) x.itemid = 25677).ToList
        'Dim dsChartsEnvaseABalanca2 = dsChart1.Where(function(x) x.itemid = 25679).ToList
        'Dim dsChartsEnvaseBBalanca1 = dsChart1.Where(function(x) x.itemid = 25874).ToList
        'Dim dsChartsEnvaseBBalanca2 = dsChart1.Where(function(x) x.itemid = 25838).ToList

        'dim varYAxisMinPote200 = 200
        'dim varYAxisMaxPote200 = 212

        'dim varYAxisMinPote500 = 500
        'dim varYAxisMaxPote500 = 525

        'Dim varYAxisMinEnvaseABalanca1 as Integer = varYAxisMinPote200
        'Dim varYAxisMaxEnvaseABalanca1 as Integer = varYAxisMaxPote200

        'Dim varYAxisMinEnvaseABalanca2 as Integer = varYAxisMinPote200
        'Dim varYAxisMaxEnvaseABalanca2 as Integer = varYAxisMaxPote200

        'Dim varYAxisMinEnvaseBBalanca1 as Integer = varYAxisMinPote200
        'Dim varYAxisMaxEnvaseBBalanca1 as Integer = varYAxisMaxPote200

        'Dim varYAxisMinEnvaseBBalanca2 as Integer = varYAxisMinPote200
        'Dim varYAxisMaxEnvaseBBalanca2 as Integer = varYAxisMaxPote200

        ''ENVASE A BALANÇA 1
        'if dsChartsEnvaseABalanca1.Count > 0 Then
        '    dim varSeriesMinPoteEnvaseABalanca1 = dsChartsEnvaseABalanca1.OrderBy(function(x) x.ultTipoPote).FirstOrDefault.ultTipoPote
        '    dim varSeriesMaxPoteEnvaseABalanca1 = dsChartsEnvaseABalanca1.OrderByDescending(function(x) x.ultTipoPote).FirstOrDefault.ultTipoPote

        '    if varSeriesMinPoteEnvaseABalanca1 = 0 then
        '        varYAxisMinEnvaseABalanca1 = varYAxisMinPote200
        '    else
        '        varYAxisMinEnvaseABalanca1 = varYAxisMinPote500
        '    End If

        '    if varSeriesMaxPoteEnvaseABalanca1 = 0
        '        varYAxisMaxEnvaseABalanca1 = varYAxisMaxPote200
        '    else
        '        varYAxisMaxEnvaseABalanca1 = varYAxisMaxPote500
        '    End If
            
        'End If

        'TryCast(chartEnABal1200g.Diagram, XYDiagram).AxisY.WholeRange.SetMinMaxValues(varYAxisMinEnvaseABalanca1, varYAxisMaxEnvaseABalanca1) 
    End Sub
End Class