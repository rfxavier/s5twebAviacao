Imports System.Drawing.Printing

Public partial Class repCnIndLeiteCamarasFriasOverviewSubLeiteTempoEventos
    Private Sub repCnIndLeiteCamarasFriasOverviewSubLeiteTempoEventos_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim reportIList As IList = TryCast(me.DataSource, DevExpress.DataAccess.ObjectBinding.ObjectDataSource)
        Dim dsReport = reportIList.Cast(of dsindustria.TempoEventos).ToList

        If dsReport IsNot Nothing
            Dim dsReportMaqLigada = dsReport.Where(function(x) x.tag = "maqligada").ToList
            dim varTempoTotalMaqLigadaDesligada = dsReportMaqLigada.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalMaqLigadaDesligadaHHMMSS = SecondsToHHMMSS(varTempoTotalMaqLigadaDesligada)

            DirectCast(DirectCast(chart1MaqLigada.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalMaqLigadaDesligadaHHMMSS)


            Dim dsReportAutomatico = dsReport.Where(function(x) x.tag = "automatico").ToList
            dim varTempoTotalAutomaticoManual = dsReportAutomatico.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalAutomaticoManualHHMMSS = SecondsToHHMMSS(varTempoTotalAutomaticoManual)

            DirectCast(DirectCast(chart2Automatico.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total máquina ligada: {0}", varTempoTotalAutomaticoManualHHMMSS)


            Dim dsReportLimpeza = dsReport.Where(function(x) x.tag = "limpeza").ToList
            dim varTempoTotalLimpezaOperacaoNormal = dsReportLimpeza.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalLimpezaOperacaoNormalHHMMSS = SecondsToHHMMSS(varTempoTotalLimpezaOperacaoNormal)

            DirectCast(DirectCast(chart3Limpeza.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total máquina ligada: {0}", varTempoTotalLimpezaOperacaoNormalHHMMSS)


            Dim dsReportPasteurizacaoFora = dsReport.Where(function(x) x.tag = "pasteurizacaofora").ToList
            dim varTempoTotalPasteurizacaoForaDentro = dsReportPasteurizacaoFora.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalPasteurizacaoForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalPasteurizacaoForaDentro)

            DirectCast(DirectCast(chart4TempPasteurizacao.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total máquina ligada: {0}", varTempoTotalPasteurizacaoForaDentroHHMMSS)


            Dim dsReportDesnatacaoFora = dsReport.Where(function(x) x.tag = "desnatacaofora").ToList
            dim varTempoTotalDesnatacaoForaDentro = dsReportDesnatacaoFora.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalDesnatacaoForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalDesnatacaoForaDentro)

            DirectCast(DirectCast(chart5TempDesnatacao.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total máquina ligada: {0}", varTempoTotalDesnatacaoForaDentroHHMMSS)

        End If
    End Sub
End Class
