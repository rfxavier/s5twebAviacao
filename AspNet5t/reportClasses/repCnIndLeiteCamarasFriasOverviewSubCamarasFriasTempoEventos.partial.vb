Imports System.Drawing.Printing

Public Partial Class repCnIndLeiteCamarasFriasOverviewSubCamarasFriasTempoEventos
    Private Sub repCnIndLeiteCamarasFriasOverviewSubCamarasFriasTempoEventos_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim reportIList As IList = TryCast(me.DataSource, DevExpress.DataAccess.ObjectBinding.ObjectDataSource)
        Dim dsReport = reportIList.Cast(of dsindustria.TempoEventos).ToList

        If dsReport IsNot Nothing
            Dim dsReportMontanhes = dsReport.Where(function(x) x.tag = "montanhesfora").ToList
            dim varTempoTotalMontanhesForaDentro = dsReportMontanhes.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalMontanhesForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalMontanhesForaDentro)

            DirectCast(DirectCast(chart1Montanhes.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalMontanhesForaDentroHHMMSS)



            Dim dsReportSalgada = dsReport.Where(function(x) x.tag = "salgadafora").ToList
            dim varTempoTotalSalgadaForaDentro = dsReportSalgada.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalSalgadaForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalSalgadaForaDentro)

            DirectCast(DirectCast(chart2Salgada.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalSalgadaForaDentroHHMMSS)


            Dim dsReportMaturacao = dsReport.Where(function(x) x.tag = "maturacaofora").ToList
            dim varTempoTotalMaturacaoForaDentro = dsReportMaturacao.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalMaturacaoForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalMaturacaoForaDentro)

            DirectCast(DirectCast(chart3Maturacao.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalMaturacaoForaDentroHHMMSS)


            Dim dsReportMinasRicota = dsReport.Where(function(x) x.tag = "minasricotafora").ToList
            dim varTempoTotalMinasRicotaForaDentro = dsReportMinasRicota.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalMinasRicotaForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalMinasRicotaForaDentro)

            DirectCast(DirectCast(chart4MinasRicota.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalMinasRicotaForaDentroHHMMSS)


            Dim dsReportProdutoAcabado = dsReport.Where(function(x) x.tag = "produtoacabadofora").ToList
            dim varTempoTotalProdutoAcabadoForaDentro = dsReportProdutoAcabado.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalProdutoAcabadoForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalProdutoAcabadoForaDentro)

            DirectCast(DirectCast(chart5ProdutoAcabado.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalProdutoAcabadoForaDentroHHMMSS)


            Dim dsReportRequeijao = dsReport.Where(function(x) x.tag = "requeijaofora").ToList
            dim varTempoTotalRequeijaoForaDentro = dsReportRequeijao.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalRequeijaoForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalRequeijaoForaDentro)

            DirectCast(DirectCast(chart6Requeijao.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalRequeijaoForaDentroHHMMSS)


            Dim dsReportSecagem = dsReport.Where(function(x) x.tag = "secagemfora").ToList
            dim varTempoTotalSecagemForaDentro = dsReportSecagem.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalSecagemForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalSecagemForaDentro)

            DirectCast(DirectCast(chart7Secagem.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalSecagemForaDentroHHMMSS)


            Dim dsReportSecagem1 = dsReport.Where(function(x) x.tag = "secagem1fora").ToList
            dim varTempoTotalSecagem1ForaDentro = dsReportSecagem1.Sum(function (x) x.tempo_segundos)
            dim varTempoTotalSecagem1ForaDentroHHMMSS = SecondsToHHMMSS(varTempoTotalSecagem1ForaDentro)

            DirectCast(DirectCast(chart8Secagem1.Series.FirstOrDefault, DevExpress.XtraCharts.Series).View, DevExpress.XtraCharts.PieSeriesView).Titles(0).Text = String.Format("tempo total: {0}", varTempoTotalSecagem1ForaDentroHHMMSS)


        End If

    End Sub
End Class
