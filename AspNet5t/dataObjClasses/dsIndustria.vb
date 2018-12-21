Public Class dsIndustria
    public class EnvaseMov
        public Property idtag As string
        public Property periodoINI As string
        public Property periodoFIM As string
        public Property itemid As Integer
        public Property clock As Decimal
        public Property tm As DateTime
        public Property value As Decimal
        public Property name As string
        public Property multiplier As Decimal
        public Property host As string
        public Property ultMaqLigada As Integer
        public Property ultDispPote As Integer
        public Property ultTipoPote As Integer
        public Property ultPesoDesejado As Decimal

        Public property ultStatusCorrecaoPeso As Integer
        public property ultLimInfCopo as Decimal
        public property ultLimSupCopo as Decimal
    End Class

    public class EnvasePesoMedio
        public Property idtag As string
        public Property periodoINI As string
        public Property periodoFIM As string
        Public Property envase_a_peso_medio_pote200_balanca1 As Decimal
        Public Property envase_a_peso_medio_pote500_balanca1 As Decimal
        Public Property envase_a_peso_medio_pote200_balanca2 As Decimal
        Public Property envase_a_peso_medio_pote500_balanca2 As Decimal
        Public Property envase_a_peso_medio_pote200_balanca1e2 As Decimal
        Public Property envase_a_peso_medio_pote500_balanca1e2 As Decimal
        Public Property envase_b_peso_medio_pote200_balanca1 As Decimal
        Public Property envase_b_peso_medio_pote500_balanca1 As Decimal
        Public Property envase_b_peso_medio_pote200_balanca2 As Decimal
        Public Property envase_b_peso_medio_pote500_balanca2 As Decimal
        Public Property envase_b_peso_medio_pote200_balanca1e2 As Decimal
        Public Property envase_b_peso_medio_pote500_balanca1e2 As Decimal
        Public Property envase_aeb_peso_medio_pote200_balanca1e2 As Decimal
        Public Property envase_aeb_peso_medio_pote500_balanca1e2 As Decimal
        Public Property envase_a_peso_medio_pote200_difdesejado_balanca1 As Decimal
        Public Property envase_a_peso_medio_pote500_difdesejado_balanca1 As Decimal
        Public Property envase_a_peso_medio_difdesejado_balanca1 As Decimal
        Public Property envase_a_peso_medio_pote200_difdesejado_balanca2 As Decimal
        Public Property envase_a_peso_medio_pote500_difdesejado_balanca2 As Decimal
        Public Property envase_a_peso_medio_difdesejado_balanca2 As Decimal
        Public Property envase_a_peso_medio_pote200_difdesejado_balanca1e2 As Decimal
        Public Property envase_a_peso_medio_pote500_difdesejado_balanca1e2 As Decimal
        Public Property envase_a_peso_medio_difdesejado_balanca1e2 As Decimal
        Public Property envase_b_peso_medio_pote200_difdesejado_balanca1 As Decimal
        Public Property envase_b_peso_medio_pote500_difdesejado_balanca1 As Decimal
        Public Property envase_b_peso_medio_difdesejado_balanca1 As Decimal
        Public Property envase_b_peso_medio_pote200_difdesejado_balanca2 As Decimal
        Public Property envase_b_peso_medio_pote500_difdesejado_balanca2 As Decimal
        Public Property envase_b_peso_medio_difdesejado_balanca2 As Decimal
        Public Property envase_b_peso_medio_pote200_difdesejado_balanca1e2 As Decimal
        Public Property envase_b_peso_medio_pote500_difdesejado_balanca1e2 As Decimal
        Public Property envase_b_peso_medio_difdesejado_balanca1e2 As Decimal
        Public Property envase_aeb_peso_medio_pote200_difdesejado_balanca1e2 As Decimal
        Public Property envase_aeb_peso_medio_pote500_difdesejado_balanca1e2 As Decimal
        Public Property envase_aeb_peso_medio_difdesejado_balanca1e2 As Decimal
        Public Property envase_a_ult_peso_desejado_pote200 As Decimal
        Public Property envase_a_ult_peso_desejado_pote500 As Decimal
        Public Property envase_b_ult_peso_desejado_pote200 As Decimal
        Public Property envase_b_ult_peso_desejado_pote500 As Decimal
        Public Property envase_a_media_liminfcopo_pote200 As Decimal
        Public Property envase_a_media_liminfcopo_pote500 As Decimal
        Public Property envase_a_media_limsupcopo_pote200 As Decimal
        Public Property envase_a_media_limsupcopo_pote500 As Decimal
        Public Property envase_b_media_liminfcopo_pote200 As Decimal
        Public Property envase_b_media_liminfcopo_pote500 As Decimal
        Public Property envase_b_media_limsupcopo_pote200 As Decimal
        Public Property envase_b_media_limsupcopo_pote500 As Decimal

        Public Property envase_a_contador_producao as decimal
        Public Property envase_b_contador_producao as decimal
        Public Property envase_a_e_b_contador_producao as decimal

        Public Property envase_a_contador_producao_pote200 as decimal
        Public Property envase_a_contador_producao_pote500 as decimal
        Public Property envase_b_contador_producao_pote200 as decimal
        Public Property envase_b_contador_producao_pote500 as decimal
        Public Property envase_a_e_b_contador_producao_pote200 as decimal
        Public Property envase_a_e_b_contador_producao_pote500 as decimal

    End Class

    public class EnvaseInfo
        public Property idtag As string
        public Property periodoINI As string
        public Property periodoFIM As string
        Public Property envase_a_tempo_sip_segundos As Integer        
        Public Property envase_a_tempo_sip_minutos  As Integer        
        Public Property envase_a_tempo_sip_horas    As Integer        
        Public Property envase_a_tempo_sip_dias     As Integer        
        Public Property envase_a_tempo_sip_dd       As Integer        
        Public Property envase_a_tempo_sip_hh       As Integer        
        Public Property envase_a_tempo_sip_mm       As Integer        
        Public Property envase_a_tempo_sip_ss       As Integer        
        Public Property envase_a_tempo_sip_hhmmss   As String        
        Public Property envase_a_tempo_sip_datetime As DateTime        
        Public Property envase_b_tempo_sip_segundos As Integer        
        Public Property envase_b_tempo_sip_minutos  As Integer        
        Public Property envase_b_tempo_sip_horas    As Integer        
        Public Property envase_b_tempo_sip_dias     As Integer        
        Public Property envase_b_tempo_sip_dd       As Integer        
        Public Property envase_b_tempo_sip_hh       As Integer        
        Public Property envase_b_tempo_sip_mm       As Integer        
        Public Property envase_b_tempo_sip_ss       As Integer        
        Public Property envase_b_tempo_sip_hhmmss   As String        
        Public Property envase_b_tempo_sip_datetime As DateTime

        Public Property envase_a_media_liminfcopo_pote200 As Decimal
        Public Property envase_a_media_liminfcopo_pote500 As Decimal
        Public Property envase_a_media_limsupcopo_pote200 As Decimal
        Public Property envase_a_media_limsupcopo_pote500 As Decimal
        Public Property envase_b_media_liminfcopo_pote200 As Decimal
        Public Property envase_b_media_liminfcopo_pote500 As Decimal
        Public Property envase_b_media_limsupcopo_pote200 As Decimal
        Public Property envase_b_media_limsupcopo_pote500 As Decimal

    End Class

    public class EnvaseSipMov
        public Property idtag As string
        public Property periodoINI As string
        public Property periodoFIM As string
        public Property itemid As Integer
        public Property clock As Decimal
        public Property tm As DateTime
        public Property value As Decimal
        public Property name As string
        public Property multiplier As Decimal
        public Property host As string

    End Class

    Public class EnvaseEvento
        public Property idtag As String
        public Property periodoINI As String
        public Property periodoFIM As String
        public Property objectid As Integer
        public Property description As String
        public Property hostname As String
        public Property numOcorrencia As Integer
        public Property tempo_hhmmss As String
        public Property tempo_dias As Integer
        public Property tempo_horas As Integer
        public Property tempo_minutos As Integer
        public Property tempo_segundos As Integer
        public Property tempo_datetime As DateTime
        public Property tempo_dd As Integer
        public Property tempo_hh As Integer
        public Property tempo_mm As Integer
        public Property tempo_ss As Integer
    End Class

    Public class LeiteEvento
        public Property idtag As String
        public Property periodoINI As String
        public Property periodoFIM As String
        public Property objectid As Integer
        public Property description As String
        public Property hostname As String
        public Property numOcorrencia As Integer
        public Property tempo_hhmmss As String
        public Property tempo_dias As Integer
        public Property tempo_horas As Integer
        public Property tempo_minutos As Integer
        public Property tempo_segundos As Integer
        public Property tempo_datetime As DateTime
        public Property tempo_dd As Integer
        public Property tempo_hh As Integer
        public Property tempo_mm As Integer
        public Property tempo_ss As Integer
    End Class

    public class LeiteInfo
        public Property idtag As string
        public Property periodoINI As string
        public Property periodoFIM As string
        Public Property limpeza_tempo_segundos As Integer        
        Public Property limpeza_tempo_minutos  As Integer        
        Public Property limpeza_tempo_horas    As Integer        
        Public Property limpeza_tempo_dias     As Integer        
        Public Property limpeza_tempo_dd       As Integer        
        Public Property limpeza_tempo_hh       As Integer        
        Public Property limpeza_tempo_mm       As Integer        
        Public Property limpeza_tempo_ss       As Integer        
        Public Property limpeza_tempo_hhmmss   As String        
        Public Property limpeza_tempo_datetime As DateTime        
        Public Property automatico_tempo_segundos As Integer        
        Public Property automatico_tempo_minutos  As Integer        
        Public Property automatico_tempo_horas    As Integer        
        Public Property automatico_tempo_dias     As Integer        
        Public Property automatico_tempo_dd       As Integer        
        Public Property automatico_tempo_hh       As Integer        
        Public Property automatico_tempo_mm       As Integer        
        Public Property automatico_tempo_ss       As Integer        
        Public Property automatico_tempo_hhmmss   As String        
        Public Property automatico_tempo_datetime As DateTime
        Public Property ligado_tempo_segundos As Integer        
        Public Property ligado_tempo_minutos  As Integer        
        Public Property ligado_tempo_horas    As Integer        
        Public Property ligado_tempo_dias     As Integer        
        Public Property ligado_tempo_dd       As Integer        
        Public Property ligado_tempo_hh       As Integer        
        Public Property ligado_tempo_mm       As Integer        
        Public Property ligado_tempo_ss       As Integer        
        Public Property ligado_tempo_hhmmss   As String        
        Public Property ligado_tempo_datetime As DateTime

    End Class

    Public class CamarasFriasEvento
        public Property idtag As String
        public Property periodoINI As String
        public Property periodoFIM As String
        public Property objectid As Integer
        public Property description As String
        public Property hostname As String
        public Property numOcorrencia As Integer
        public Property tempo_hhmmss As String
        public Property tempo_dias As Integer
        public Property tempo_horas As Integer
        public Property tempo_minutos As Integer
        public Property tempo_segundos As Integer
        public Property tempo_datetime As DateTime
        public Property tempo_dd As Integer
        public Property tempo_hh As Integer
        public Property tempo_mm As Integer
        public Property tempo_ss As Integer
    End Class
    
    Public Class TempoEventos
        Public property tag As string
        public Property description As String
        public Property tempo_hhmmss As String
        public Property tempo_segundos As Integer
    End Class


    Public Shared Function GetEnvaseMov(ByVal parIdTag As string) As List(Of EnvaseMov)
        'Movimentação de Pesos Médios ao longo do tempo
        dim envaseMov = new List(Of EnvaseMov)

        Dim envaseMovCollection = s5t.IndustriaEnvaseMovCollection.LoadByIdTag(parIdTag)

        envaseMov = envaseMovCollection.Select(Function(x) New EnvaseMov With {
                                                   .idtag = x.idtag, 
                                                   .periodoINI = x.periodoINI,
                                                   .periodoFIM = x.periodoFIM,
                                                   .itemid = x.itemid,
                                                   .clock = x.clock,
                                                   .tm = x.tm,
                                                   .value = x.value,
                                                   .name = x.name,
                                                   .multiplier = x.multiplier,
                                                   .host = x.host,
                                                   .ultMaqLigada = x.ultMaqLigada,
                                                   .ultDispPote = x.ultDispPote,
                                                   .ultTipoPote = x.ultTipoPote,
                                                   .ultPesoDesejado = x.ultPesoDesejado,
                                                   .ultStatusCorrecaoPeso = x.ultStatusCorrecaoPeso,
                                                   .ultLimInfCopo = x.ultLimInfCopo,
                                                   .ultLimSupCopo = x.ultLimSupCopo}).ToList()

        
        Return envaseMov
    End Function

    Public Shared Function GetEnvasePesoMedio(ByVal parIdTag As string) As List(Of EnvasePesoMedio)
        'Movimentação de Pesos Médios ao longo do tempo
        dim envasePesoMedio = new List(Of EnvasePesoMedio)

        Dim envasePesoMedioCollection = s5t.IndustriaEnvasePesoMedioCollection.LoadByIdTag(parIdTag)

        dim envaseContadorProducaoCollection = s5t.IndustriaEnvaseContadorProducaoCollection.LoadByIdTag(parIdTag)

        envasePesoMedio = envasePesoMedioCollection.Select(Function(x) New EnvasePesoMedio With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .envase_a_peso_medio_pote200_balanca1 = x.envase_a_peso_medio_pote200_balanca1,
                                        .envase_a_peso_medio_pote500_balanca1 = x.envase_a_peso_medio_pote500_balanca1,
                                        .envase_a_peso_medio_pote200_balanca2 = x.envase_a_peso_medio_pote200_balanca2,
                                        .envase_a_peso_medio_pote500_balanca2 = x.envase_a_peso_medio_pote500_balanca2,
                                        .envase_a_peso_medio_pote200_balanca1e2 = x.envase_a_peso_medio_pote200_balanca1e2,
                                        .envase_a_peso_medio_pote500_balanca1e2 = x.envase_a_peso_medio_pote500_balanca1e2,
                                        .envase_b_peso_medio_pote200_balanca1 = x.envase_b_peso_medio_pote200_balanca1,
                                        .envase_b_peso_medio_pote500_balanca1 = x.envase_b_peso_medio_pote500_balanca1,
                                        .envase_b_peso_medio_pote200_balanca2 = x.envase_b_peso_medio_pote200_balanca2,
                                        .envase_b_peso_medio_pote500_balanca2 = x.envase_b_peso_medio_pote500_balanca2,
                                        .envase_b_peso_medio_pote200_balanca1e2 = x.envase_b_peso_medio_pote200_balanca1e2,
                                        .envase_b_peso_medio_pote500_balanca1e2 = x.envase_b_peso_medio_pote500_balanca1e2,
                                        .envase_aeb_peso_medio_pote200_balanca1e2 = x.envase_aeb_peso_medio_pote200_balanca1e2,
                                        .envase_aeb_peso_medio_pote500_balanca1e2 = x.envase_aeb_peso_medio_pote500_balanca1e2,
                                        .envase_a_peso_medio_pote200_difdesejado_balanca1 = x.envase_a_peso_medio_pote200_difdesejado_balanca1,
                                        .envase_a_peso_medio_pote500_difdesejado_balanca1 = x.envase_a_peso_medio_pote500_difdesejado_balanca1,
                                        .envase_a_peso_medio_difdesejado_balanca1 = x.envase_a_peso_medio_difdesejado_balanca1,
                                        .envase_a_peso_medio_pote200_difdesejado_balanca2 = x.envase_a_peso_medio_pote200_difdesejado_balanca2,
                                        .envase_a_peso_medio_pote500_difdesejado_balanca2 = x.envase_a_peso_medio_pote500_difdesejado_balanca2,
                                        .envase_a_peso_medio_difdesejado_balanca2 = x.envase_a_peso_medio_difdesejado_balanca2,
                                        .envase_a_peso_medio_pote200_difdesejado_balanca1e2 = x.envase_a_peso_medio_pote200_difdesejado_balanca1e2,
                                        .envase_a_peso_medio_pote500_difdesejado_balanca1e2 = x.envase_a_peso_medio_pote500_difdesejado_balanca1e2,
                                        .envase_a_peso_medio_difdesejado_balanca1e2 = x.envase_a_peso_medio_difdesejado_balanca1e2,
                                        .envase_b_peso_medio_pote200_difdesejado_balanca1 = x.envase_b_peso_medio_pote200_difdesejado_balanca1,
                                        .envase_b_peso_medio_pote500_difdesejado_balanca1 = x.envase_b_peso_medio_pote500_difdesejado_balanca1,
                                        .envase_b_peso_medio_difdesejado_balanca1 = x.envase_b_peso_medio_difdesejado_balanca1,
                                        .envase_b_peso_medio_pote200_difdesejado_balanca2 = x.envase_b_peso_medio_pote200_difdesejado_balanca2,
                                        .envase_b_peso_medio_pote500_difdesejado_balanca2 = x.envase_b_peso_medio_pote500_difdesejado_balanca2,
                                        .envase_b_peso_medio_difdesejado_balanca2 = x.envase_b_peso_medio_difdesejado_balanca2,
                                        .envase_b_peso_medio_pote200_difdesejado_balanca1e2 = x.envase_b_peso_medio_pote200_difdesejado_balanca1e2,
                                        .envase_b_peso_medio_pote500_difdesejado_balanca1e2 = x.envase_b_peso_medio_pote500_difdesejado_balanca1e2,
                                        .envase_b_peso_medio_difdesejado_balanca1e2 = x.envase_b_peso_medio_difdesejado_balanca1e2,
                                        .envase_aeb_peso_medio_pote200_difdesejado_balanca1e2 = x.envase_aeb_peso_medio_pote200_difdesejado_balanca1e2,
                                        .envase_aeb_peso_medio_pote500_difdesejado_balanca1e2 = x.envase_aeb_peso_medio_pote500_difdesejado_balanca1e2,
                                        .envase_aeb_peso_medio_difdesejado_balanca1e2 = x.envase_aeb_peso_medio_difdesejado_balanca1e2,
                                        .envase_a_ult_peso_desejado_pote200 = x.envase_a_ult_peso_desejado_pote200,
                                        .envase_a_ult_peso_desejado_pote500 = x.envase_a_ult_peso_desejado_pote500,
                                        .envase_b_ult_peso_desejado_pote200 = x.envase_b_ult_peso_desejado_pote200,
                                        .envase_b_ult_peso_desejado_pote500 = x.envase_b_ult_peso_desejado_pote500,
                                        .envase_a_media_liminfcopo_pote200 = x.envase_a_media_liminfcopo_pote200,
                                        .envase_a_media_liminfcopo_pote500 = x.envase_a_media_liminfcopo_pote500,
                                        .envase_a_media_limsupcopo_pote200 = x.envase_a_media_limsupcopo_pote200,
                                        .envase_a_media_limsupcopo_pote500 = x.envase_a_media_limsupcopo_pote500,
                                        .envase_b_media_liminfcopo_pote200 = x.envase_b_media_liminfcopo_pote200,
                                        .envase_b_media_liminfcopo_pote500 = x.envase_b_media_liminfcopo_pote500,
                                        .envase_b_media_limsupcopo_pote200 = x.envase_b_media_limsupcopo_pote200,
                                        .envase_b_media_limsupcopo_pote500 = x.envase_b_media_limsupcopo_pote500
                                    }).ToList()
        
        if envasePesoMedio.Count > 0 then
            if envaseContadorProducaoCollection.Count > 0 then
                envasePesoMedio(0).envase_a_contador_producao = envaseContadorProducaoCollection(0).envase_a_contador_producao
                envasePesoMedio(0).envase_b_contador_producao = envaseContadorProducaoCollection(0).envase_b_contador_producao
                envasePesoMedio(0).envase_a_e_b_contador_producao = envaseContadorProducaoCollection(0).envase_a_e_b_contador_producao
                envasePesoMedio(0).envase_a_contador_producao_pote200 = envaseContadorProducaoCollection(0).envase_a_contador_producao_pote200
                envasePesoMedio(0).envase_a_contador_producao_pote500 = envaseContadorProducaoCollection(0).envase_a_contador_producao_pote500
                envasePesoMedio(0).envase_b_contador_producao_pote200 = envaseContadorProducaoCollection(0).envase_b_contador_producao_pote200
                envasePesoMedio(0).envase_b_contador_producao_pote500 = envaseContadorProducaoCollection(0).envase_b_contador_producao_pote500
                envasePesoMedio(0).envase_a_e_b_contador_producao_pote200 = envaseContadorProducaoCollection(0).envase_a_e_b_contador_producao_pote200
                envasePesoMedio(0).envase_a_e_b_contador_producao_pote500 = envaseContadorProducaoCollection(0).envase_a_e_b_contador_producao_pote500
            end if
        End If

        Return envasePesoMedio
    End Function

    Public shared function GetEnvaseInfo(byval parIdTag As String) As List(Of EnvaseInfo)
        dim envaseInfo = new List(Of EnvaseInfo)
        
        Dim envasePesoMedioCollection = s5t.IndustriaEnvasePesoMedioCollection.LoadByIdTag(parIdTag)

        dim envaseTempoSipCollection = s5t.IndustriaEnvaseTempoSipCollection.LoadByIdTag(parIdTag)

        envaseInfo = envasePesoMedioCollection.Select(Function(x) New EnvaseInfo With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .envase_a_media_liminfcopo_pote200 = x.envase_a_media_liminfcopo_pote200,
                                        .envase_a_media_liminfcopo_pote500 = x.envase_a_media_liminfcopo_pote500,
                                        .envase_a_media_limsupcopo_pote200 = x.envase_a_media_limsupcopo_pote200,
                                        .envase_a_media_limsupcopo_pote500 = x.envase_a_media_limsupcopo_pote500,
                                        .envase_b_media_liminfcopo_pote200 = x.envase_b_media_liminfcopo_pote200,
                                        .envase_b_media_liminfcopo_pote500 = x.envase_b_media_liminfcopo_pote500,
                                        .envase_b_media_limsupcopo_pote200 = x.envase_b_media_limsupcopo_pote200,
                                        .envase_b_media_limsupcopo_pote500 = x.envase_b_media_limsupcopo_pote500
                                    }).ToList()

        if envaseInfo.Count > 0 
            if envaseTempoSipCollection.count > 0 then
                envaseInfo(0).envase_a_tempo_sip_segundos = envaseTempoSipCollection(0).envase_a_tempo_sip_segundos
                envaseInfo(0).envase_a_tempo_sip_minutos  = envaseTempoSipCollection(0).envase_a_tempo_sip_minutos
                envaseInfo(0).envase_a_tempo_sip_horas    = envaseTempoSipCollection(0).envase_a_tempo_sip_horas
                envaseInfo(0).envase_a_tempo_sip_dias     = envaseTempoSipCollection(0).envase_a_tempo_sip_dias
                envaseInfo(0).envase_a_tempo_sip_dd       = envaseTempoSipCollection(0).envase_a_tempo_sip_dd
                envaseInfo(0).envase_a_tempo_sip_hh       = envaseTempoSipCollection(0).envase_a_tempo_sip_hh
                envaseInfo(0).envase_a_tempo_sip_mm       = envaseTempoSipCollection(0).envase_a_tempo_sip_mm
                envaseInfo(0).envase_a_tempo_sip_ss       = envaseTempoSipCollection(0).envase_a_tempo_sip_ss
                envaseInfo(0).envase_a_tempo_sip_hhmmss   = envaseTempoSipCollection(0).envase_a_tempo_sip_hhmmss
                envaseInfo(0).envase_a_tempo_sip_datetime = envaseTempoSipCollection(0).envase_a_tempo_sip_datetime
                envaseInfo(0).envase_b_tempo_sip_segundos = envaseTempoSipCollection(0).envase_b_tempo_sip_segundos
                envaseInfo(0).envase_b_tempo_sip_minutos  = envaseTempoSipCollection(0).envase_b_tempo_sip_minutos
                envaseInfo(0).envase_b_tempo_sip_horas    = envaseTempoSipCollection(0).envase_b_tempo_sip_horas
                envaseInfo(0).envase_b_tempo_sip_dias     = envaseTempoSipCollection(0).envase_b_tempo_sip_dias
                envaseInfo(0).envase_b_tempo_sip_dd       = envaseTempoSipCollection(0).envase_b_tempo_sip_dd
                envaseInfo(0).envase_b_tempo_sip_hh       = envaseTempoSipCollection(0).envase_b_tempo_sip_hh
                envaseInfo(0).envase_b_tempo_sip_mm       = envaseTempoSipCollection(0).envase_b_tempo_sip_mm
                envaseInfo(0).envase_b_tempo_sip_ss       = envaseTempoSipCollection(0).envase_b_tempo_sip_ss
                envaseInfo(0).envase_b_tempo_sip_hhmmss   = envaseTempoSipCollection(0).envase_b_tempo_sip_hhmmss
                envaseInfo(0).envase_b_tempo_sip_datetime = envaseTempoSipCollection(0).envase_b_tempo_sip_datetime
            End If
        End If

        Return envaseInfo
    End function

    Public Shared Function GetEnvaseSipMov(ByVal parIdTag As string) As List(Of EnvaseSipMov)
        dim envaseSipMov = new List(Of EnvaseSipMov)

        Dim envaseSipMovCollection = s5t.IndustriaEnvaseSipMovCollection.LoadByIdTag("20170629095030")

        envaseSipMov = envaseSipMovCollection.Select(Function(x) New EnvaseSipMov With {
                                                  .idtag = x.idtag, 
                                                  .periodoINI = x.periodoINI,
                                                  .periodoFIM = x.periodoFIM,
                                                  .itemid = x.itemid,
                                                  .clock = x.clock,
                                                  .tm = x.tm,
                                                  .value = x.value,
                                                  .name = x.name,
                                                  .multiplier = x.multiplier,
                                                  .host = x.host}).ToList()

        
        Return envaseSipMov
    End Function

    Public shared function GetEnvaseEvento(byval parIdTag As String) As List(Of EnvaseEvento)
        'Eventos dos hosts envase sumarizados
        dim envaseEvento = new List(Of EnvaseEvento)

        dim envaseEventoCollection = s5t.IndustriaEnvaseEventoCollection.LoadByIdTag(parIdTag)

        envaseEvento = envaseEventoCollection.Select(function(x) New EnvaseEvento With {
                                                            .idtag = x.idtag,
                                                            .periodoINI = x.periodoINI,
                                                            .periodoFIM = x.periodoFIM,
                                                            .objectid = x.objectid,
                                                            .description = x.description,
                                                            .hostname = x.hostname,
                                                            .numOcorrencia = x.numOcorrencia,
                                                            .tempo_hhmmss = x.tempo_hhmmss,
                                                            .tempo_dias = x.tempo_dias,
                                                            .tempo_horas = x.tempo_horas,
                                                            .tempo_minutos = x.tempo_minutos,
                                                            .tempo_segundos = x.tempo_segundos,
                                                            .tempo_datetime = x.tempo_datetime,
                                                            .tempo_dd = x.tempo_dd,
                                                            .tempo_hh = x.tempo_hh,
                                                            .tempo_mm = x.tempo_mm,
                                                            .tempo_ss = x.tempo_ss
                                                         }).ToList
        return envaseEvento
    End function

    Public Shared Function GetLeiteEvento(byval parIdTag As String) As List(Of LeiteEvento)
        'Eventos do host Leite sumarizados
        dim LeiteEvento = new List(Of LeiteEvento)

        dim LeiteEventoCollection = s5t.IndustriaLeiteEventoCollection.LoadByIdTag(parIdTag)

        LeiteEvento = LeiteEventoCollection.Select(function(x) New LeiteEvento With {
                                                            .idtag = x.idtag,
                                                            .periodoINI = x.periodoINI,
                                                            .periodoFIM = x.periodoFIM,
                                                            .objectid = x.objectid,
                                                            .description = x.description,
                                                            .hostname = x.hostname,
                                                            .numOcorrencia = x.numOcorrencia,
                                                            .tempo_hhmmss = x.tempo_hhmmss,
                                                            .tempo_dias = x.tempo_dias,
                                                            .tempo_horas = x.tempo_horas,
                                                            .tempo_minutos = x.tempo_minutos,
                                                            .tempo_segundos = x.tempo_segundos,
                                                            .tempo_datetime = x.tempo_datetime,
                                                            .tempo_dd = x.tempo_dd,
                                                            .tempo_hh = x.tempo_hh,
                                                            .tempo_mm = x.tempo_mm,
                                                            .tempo_ss = x.tempo_ss
                                                         }).ToList
        return LeiteEvento
    End Function

    Public shared function GetLeiteInfo(byval parIdTag As String) As List(Of LeiteInfo)
        dim leiteInfo = new List(Of LeiteInfo)
        
        dim leiteTempoLimpezaAutomaticoCollection = s5t.IndustriaLeiteTempoLimpezaAutomaticoCollection.LoadByIdTag(parIdTag)

        leiteInfo = leiteTempoLimpezaAutomaticoCollection.Select(Function(x) New LeiteInfo With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .limpeza_tempo_segundos    = x.limpeza_tempo_segundos,
                                        .limpeza_tempo_minutos     = x.limpeza_tempo_minutos,
                                        .limpeza_tempo_horas       = x.limpeza_tempo_horas,
                                        .limpeza_tempo_dias        = x.limpeza_tempo_dias,
                                        .limpeza_tempo_dd          = x.limpeza_tempo_dd,
                                        .limpeza_tempo_hh          = x.limpeza_tempo_hh,
                                        .limpeza_tempo_mm          = x.limpeza_tempo_mm,
                                        .limpeza_tempo_ss          = x.limpeza_tempo_ss,
                                        .limpeza_tempo_hhmmss      = x.limpeza_tempo_hhmmss,
                                        .limpeza_tempo_datetime    = x.limpeza_tempo_datetime,
                                        .automatico_tempo_segundos = x.automatico_tempo_segundos,
                                        .automatico_tempo_minutos  = x.automatico_tempo_minutos,
                                        .automatico_tempo_horas    = x.automatico_tempo_horas,
                                        .automatico_tempo_dias     = x.automatico_tempo_dias,
                                        .automatico_tempo_dd       = x.automatico_tempo_dd,
                                        .automatico_tempo_hh       = x.automatico_tempo_hh,
                                        .automatico_tempo_mm       = x.automatico_tempo_mm,
                                        .automatico_tempo_ss       = x.automatico_tempo_ss,
                                        .automatico_tempo_hhmmss   = x.automatico_tempo_hhmmss,
                                        .automatico_tempo_datetime = x.automatico_tempo_datetime,
                                        .ligado_tempo_segundos     = x.ligado_tempo_segundos,
                                        .ligado_tempo_minutos      = x.ligado_tempo_minutos,
                                        .ligado_tempo_horas        = x.ligado_tempo_horas,
                                        .ligado_tempo_dias         = x.ligado_tempo_dias,
                                        .ligado_tempo_dd           = x.ligado_tempo_dd,
                                        .ligado_tempo_hh           = x.ligado_tempo_hh,
                                        .ligado_tempo_mm           = x.ligado_tempo_mm,
                                        .ligado_tempo_ss           = x.ligado_tempo_ss,
                                        .ligado_tempo_hhmmss       = x.ligado_tempo_hhmmss,
                                        .ligado_tempo_datetime     = x.ligado_tempo_datetime
                                    }).ToList()

        Return leiteInfo
    End function

    Public shared function GetLeitelhoInfo(byval parIdTag As String) As List(Of LeiteInfo)
        dim leiteInfo = new List(Of LeiteInfo)
        
        dim leiteTempoLimpezaAutomaticoCollection = s5t.IndustriaLeitelhoTempoLimpezaAutomaticoCollection.LoadByIdTag(parIdTag)

        leiteInfo = leiteTempoLimpezaAutomaticoCollection.Select(Function(x) New LeiteInfo With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .limpeza_tempo_segundos    = x.limpeza_tempo_segundos,
                                        .limpeza_tempo_minutos     = x.limpeza_tempo_minutos,
                                        .limpeza_tempo_horas       = x.limpeza_tempo_horas,
                                        .limpeza_tempo_dias        = x.limpeza_tempo_dias,
                                        .limpeza_tempo_dd          = x.limpeza_tempo_dd,
                                        .limpeza_tempo_hh          = x.limpeza_tempo_hh,
                                        .limpeza_tempo_mm          = x.limpeza_tempo_mm,
                                        .limpeza_tempo_ss          = x.limpeza_tempo_ss,
                                        .limpeza_tempo_hhmmss      = x.limpeza_tempo_hhmmss,
                                        .limpeza_tempo_datetime    = x.limpeza_tempo_datetime,
                                        .automatico_tempo_segundos = x.automatico_tempo_segundos,
                                        .automatico_tempo_minutos  = x.automatico_tempo_minutos,
                                        .automatico_tempo_horas    = x.automatico_tempo_horas,
                                        .automatico_tempo_dias     = x.automatico_tempo_dias,
                                        .automatico_tempo_dd       = x.automatico_tempo_dd,
                                        .automatico_tempo_hh       = x.automatico_tempo_hh,
                                        .automatico_tempo_mm       = x.automatico_tempo_mm,
                                        .automatico_tempo_ss       = x.automatico_tempo_ss,
                                        .automatico_tempo_hhmmss   = x.automatico_tempo_hhmmss,
                                        .automatico_tempo_datetime = x.automatico_tempo_datetime,
                                        .ligado_tempo_segundos     = x.ligado_tempo_segundos,
                                        .ligado_tempo_minutos      = x.ligado_tempo_minutos,
                                        .ligado_tempo_horas        = x.ligado_tempo_horas,
                                        .ligado_tempo_dias         = x.ligado_tempo_dias,
                                        .ligado_tempo_dd           = x.ligado_tempo_dd,
                                        .ligado_tempo_hh           = x.ligado_tempo_hh,
                                        .ligado_tempo_mm           = x.ligado_tempo_mm,
                                        .ligado_tempo_ss           = x.ligado_tempo_ss,
                                        .ligado_tempo_hhmmss       = x.ligado_tempo_hhmmss,
                                        .ligado_tempo_datetime     = x.ligado_tempo_datetime
                                    }).ToList()

        Return leiteInfo
    End function

    Public shared function GetSoroDeQueijoInfo(byval parIdTag As String) As List(Of LeiteInfo)
        dim leiteInfo = new List(Of LeiteInfo)
        
        dim leiteTempoLimpezaAutomaticoCollection = s5t.IndustriaSoroDeQueijoTempoLimpezaAutomaticoCollection.LoadByIdTag(parIdTag)

        leiteInfo = leiteTempoLimpezaAutomaticoCollection.Select(Function(x) New LeiteInfo With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .limpeza_tempo_segundos    = x.limpeza_tempo_segundos,
                                        .limpeza_tempo_minutos     = x.limpeza_tempo_minutos,
                                        .limpeza_tempo_horas       = x.limpeza_tempo_horas,
                                        .limpeza_tempo_dias        = x.limpeza_tempo_dias,
                                        .limpeza_tempo_dd          = x.limpeza_tempo_dd,
                                        .limpeza_tempo_hh          = x.limpeza_tempo_hh,
                                        .limpeza_tempo_mm          = x.limpeza_tempo_mm,
                                        .limpeza_tempo_ss          = x.limpeza_tempo_ss,
                                        .limpeza_tempo_hhmmss      = x.limpeza_tempo_hhmmss,
                                        .limpeza_tempo_datetime    = x.limpeza_tempo_datetime,
                                        .automatico_tempo_segundos = x.automatico_tempo_segundos,
                                        .automatico_tempo_minutos  = x.automatico_tempo_minutos,
                                        .automatico_tempo_horas    = x.automatico_tempo_horas,
                                        .automatico_tempo_dias     = x.automatico_tempo_dias,
                                        .automatico_tempo_dd       = x.automatico_tempo_dd,
                                        .automatico_tempo_hh       = x.automatico_tempo_hh,
                                        .automatico_tempo_mm       = x.automatico_tempo_mm,
                                        .automatico_tempo_ss       = x.automatico_tempo_ss,
                                        .automatico_tempo_hhmmss   = x.automatico_tempo_hhmmss,
                                        .automatico_tempo_datetime = x.automatico_tempo_datetime,
                                        .ligado_tempo_segundos     = x.ligado_tempo_segundos,
                                        .ligado_tempo_minutos      = x.ligado_tempo_minutos,
                                        .ligado_tempo_horas        = x.ligado_tempo_horas,
                                        .ligado_tempo_dias         = x.ligado_tempo_dias,
                                        .ligado_tempo_dd           = x.ligado_tempo_dd,
                                        .ligado_tempo_hh           = x.ligado_tempo_hh,
                                        .ligado_tempo_mm           = x.ligado_tempo_mm,
                                        .ligado_tempo_ss           = x.ligado_tempo_ss,
                                        .ligado_tempo_hhmmss       = x.ligado_tempo_hhmmss,
                                        .ligado_tempo_datetime     = x.ligado_tempo_datetime
                                    }).ToList()

        Return leiteInfo
    End function

    Public shared function GetCremeInfo(byval parIdTag As String) As List(Of LeiteInfo)
        dim leiteInfo = new List(Of LeiteInfo)
        
        dim leiteTempoLimpezaAutomaticoCollection = s5t.IndustriaCremeTempoLimpezaAutomaticoCollection.LoadByIdTag(parIdTag)

        leiteInfo = leiteTempoLimpezaAutomaticoCollection.Select(Function(x) New LeiteInfo With {
                                        .idtag = x.idtag, 
                                        .periodoINI = x.periodoINI,
                                        .periodoFIM = x.periodoFIM,
                                        .limpeza_tempo_segundos    = x.limpeza_tempo_segundos,
                                        .limpeza_tempo_minutos     = x.limpeza_tempo_minutos,
                                        .limpeza_tempo_horas       = x.limpeza_tempo_horas,
                                        .limpeza_tempo_dias        = x.limpeza_tempo_dias,
                                        .limpeza_tempo_dd          = x.limpeza_tempo_dd,
                                        .limpeza_tempo_hh          = x.limpeza_tempo_hh,
                                        .limpeza_tempo_mm          = x.limpeza_tempo_mm,
                                        .limpeza_tempo_ss          = x.limpeza_tempo_ss,
                                        .limpeza_tempo_hhmmss      = x.limpeza_tempo_hhmmss,
                                        .limpeza_tempo_datetime    = x.limpeza_tempo_datetime,
                                        .automatico_tempo_segundos = x.automatico_tempo_segundos,
                                        .automatico_tempo_minutos  = x.automatico_tempo_minutos,
                                        .automatico_tempo_horas    = x.automatico_tempo_horas,
                                        .automatico_tempo_dias     = x.automatico_tempo_dias,
                                        .automatico_tempo_dd       = x.automatico_tempo_dd,
                                        .automatico_tempo_hh       = x.automatico_tempo_hh,
                                        .automatico_tempo_mm       = x.automatico_tempo_mm,
                                        .automatico_tempo_ss       = x.automatico_tempo_ss,
                                        .automatico_tempo_hhmmss   = x.automatico_tempo_hhmmss,
                                        .automatico_tempo_datetime = x.automatico_tempo_datetime,
                                        .ligado_tempo_segundos     = x.ligado_tempo_segundos,
                                        .ligado_tempo_minutos      = x.ligado_tempo_minutos,
                                        .ligado_tempo_horas        = x.ligado_tempo_horas,
                                        .ligado_tempo_dias         = x.ligado_tempo_dias,
                                        .ligado_tempo_dd           = x.ligado_tempo_dd,
                                        .ligado_tempo_hh           = x.ligado_tempo_hh,
                                        .ligado_tempo_mm           = x.ligado_tempo_mm,
                                        .ligado_tempo_ss           = x.ligado_tempo_ss,
                                        .ligado_tempo_hhmmss       = x.ligado_tempo_hhmmss,
                                        .ligado_tempo_datetime     = x.ligado_tempo_datetime
                                    }).ToList()

        Return leiteInfo
    End function


    Public Shared Function GetTempoEventosLeite(ByVal parIdTag As String) As List(Of TempoEventos)
        dim leiteInfo = new List(Of LeiteInfo)

        leiteInfo = GetLeiteInfo(parIdTag)

        dim leiteEvento = new List(Of LeiteEvento)

        leiteEvento = GetLeiteEvento(parIdTag)

        dim TempoEventos = new List(Of TempoEventos)

        'MÁQUINA LIGADA vs MÁQUINA DESLIGADA - Em tempo total: 24h
        dim objLeiteInfoMaqLigada As new TempoEventos

        objLeiteInfoMaqLigada.tag = "maqligada"
        objLeiteInfoMaqLigada.description = "Máquina Ligada"
        objLeiteInfoMaqLigada.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_hhmmss, "")
        objLeiteInfoMaqLigada.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqLigada)

        dim objLeiteInfoMaqDesligada As new TempoEventos

        objLeiteInfoMaqDesligada.tag = "maqligada"
        objLeiteInfoMaqDesligada.description = "Máquina Desligada"
        objLeiteInfoMaqDesligada.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos)
        objLeiteInfoMaqDesligada.tempo_segundos = (24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqDesligada)

        'MÁQUINA EM AUTOMÁTICO vs MÁQUINA EM MANUAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqAutomatico As new TempoEventos

        objLeiteInfoMaqAutomatico.tag = "automatico"
        objLeiteInfoMaqAutomatico.description = "Automático"
        objLeiteInfoMaqAutomatico.tempo_hhmmss =  if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_hhmmss, "")
        objLeiteInfoMaqAutomatico.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqAutomatico)

        dim objLeiteInfoMaqManual As new TempoEventos

        objLeiteInfoMaqManual.tag = "automatico"
        objLeiteInfoMaqManual.description = "Manual"
        objLeiteInfoMaqManual.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos -  objLeiteInfoMaqAutomatico.tempo_segundos)
        objLeiteInfoMaqManual.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqAutomatico.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqManual)

        'MÁQUINA EM LIMPEZA vs MÁQUINA EM OPERAÇÃO NORMAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqEmLimpeza As new TempoEventos

        objLeiteInfoMaqEmLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmLimpeza.description = "Em Limpeza"
        objLeiteInfoMaqEmLimpeza.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_hhmmss, "")
        objLeiteInfoMaqEmLimpeza.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqEmLimpeza)

        dim objLeiteInfoMaqEmNaoLimpeza As new TempoEventos

        objLeiteInfoMaqEmNaoLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmNaoLimpeza.description = "Em Operação Normal"
        objLeiteInfoMaqEmNaoLimpeza.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos)
        objLeiteInfoMaqEmNaoLimpeza.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqEmNaoLimpeza)

        'MÁQUINA COM TEMPERATURA DE PASTEURIZAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14085 = Temperatura DE PASTEURIZACAO no {HOST.NAME} ABAIXO DE 72 GRAUS
        dim objLeiteEventoPasteurizacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14085)

        dim objLeiteEventoTempoPasteurizacaoFora As new TempoEventos

        objLeiteEventoTempoPasteurizacaoFora.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoPasteurizacaoFora.tempo_hhmmss = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_hhmmss, "")  
        objLeiteEventoTempoPasteurizacaoFora.tempo_segundos = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoFora)

        dim objLeiteEventoTempoPasteurizacaoDentro As new TempoEventos

        objLeiteEventoTempoPasteurizacaoDentro.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoPasteurizacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos)
        objLeiteEventoTempoPasteurizacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoDentro)


        'MÁQUINA COM TEMPERATURA DE DESNATAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14086 = Temperatura DESNATACAO no {HOST.NAME} ACIMA de 78 GRAUS
        dim objLeiteEventoDesnatacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14086)

        dim objLeiteEventoTempoDesnatacaoFora As new TempoEventos

        objLeiteEventoTempoDesnatacaoFora.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoDesnatacaoFora.tempo_hhmmss = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_hhmmss, "") 
        objLeiteEventoTempoDesnatacaoFora.tempo_segundos = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_segundos, 0)   

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoFora)

        dim objLeiteEventoTempoDesnatacaoDentro As new TempoEventos

        objLeiteEventoTempoDesnatacaoDentro.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoDesnatacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos)
        objLeiteEventoTempoDesnatacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoDentro)

        return TempoEventos
    End Function

    Public Shared Function GetTempoEventosLeitelho(ByVal parIdTag As String) As List(Of TempoEventos)
        dim leiteInfo = new List(Of LeiteInfo)

        leiteInfo = GetLeitelhoInfo(parIdTag)

        dim leiteEvento = new List(Of LeiteEvento)

        leiteEvento = GetLeiteEvento(parIdTag)

        dim TempoEventos = new List(Of TempoEventos)

        'MÁQUINA LIGADA vs MÁQUINA DESLIGADA - Em tempo total: 24h
        dim objLeiteInfoMaqLigada As new TempoEventos

        objLeiteInfoMaqLigada.tag = "maqligada"
        objLeiteInfoMaqLigada.description = "Máquina Ligada"
        objLeiteInfoMaqLigada.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_hhmmss, "")
        objLeiteInfoMaqLigada.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqLigada)

        dim objLeiteInfoMaqDesligada As new TempoEventos

        objLeiteInfoMaqDesligada.tag = "maqligada"
        objLeiteInfoMaqDesligada.description = "Máquina Desligada"
        objLeiteInfoMaqDesligada.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos)
        objLeiteInfoMaqDesligada.tempo_segundos = (24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqDesligada)

        'MÁQUINA EM AUTOMÁTICO vs MÁQUINA EM MANUAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqAutomatico As new TempoEventos

        objLeiteInfoMaqAutomatico.tag = "automatico"
        objLeiteInfoMaqAutomatico.description = "Automático"
        objLeiteInfoMaqAutomatico.tempo_hhmmss =  if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_hhmmss, "")
        objLeiteInfoMaqAutomatico.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqAutomatico)

        dim objLeiteInfoMaqManual As new TempoEventos

        objLeiteInfoMaqManual.tag = "automatico"
        objLeiteInfoMaqManual.description = "Manual"
        objLeiteInfoMaqManual.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos -  objLeiteInfoMaqAutomatico.tempo_segundos)
        objLeiteInfoMaqManual.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqAutomatico.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqManual)

        'MÁQUINA EM LIMPEZA vs MÁQUINA EM OPERAÇÃO NORMAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqEmLimpeza As new TempoEventos

        objLeiteInfoMaqEmLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmLimpeza.description = "Em Limpeza"
        objLeiteInfoMaqEmLimpeza.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_hhmmss, "")
        objLeiteInfoMaqEmLimpeza.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqEmLimpeza)

        dim objLeiteInfoMaqEmNaoLimpeza As new TempoEventos

        objLeiteInfoMaqEmNaoLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmNaoLimpeza.description = "Em Operação Normal"
        objLeiteInfoMaqEmNaoLimpeza.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos)
        objLeiteInfoMaqEmNaoLimpeza.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqEmNaoLimpeza)

        'MÁQUINA COM TEMPERATURA DE PASTEURIZAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14068 = Temperatura DE PASTEURIZACAO no {HOST.NAME} ABAIXO DE 72 GRAUS
        dim objLeiteEventoPasteurizacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14068)

        dim objLeiteEventoTempoPasteurizacaoFora As new TempoEventos

        objLeiteEventoTempoPasteurizacaoFora.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoPasteurizacaoFora.tempo_hhmmss = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_hhmmss, "")  
        objLeiteEventoTempoPasteurizacaoFora.tempo_segundos = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoFora)

        dim objLeiteEventoTempoPasteurizacaoDentro As new TempoEventos

        objLeiteEventoTempoPasteurizacaoDentro.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoPasteurizacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos)
        objLeiteEventoTempoPasteurizacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoDentro)


        'MÁQUINA COM TEMPERATURA DE DESNATAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14069 = Temperatura DESNATACAO no {HOST.NAME} ACIMA de 78 GRAUS
        dim objLeiteEventoDesnatacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14069)

        dim objLeiteEventoTempoDesnatacaoFora As new TempoEventos

        objLeiteEventoTempoDesnatacaoFora.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoDesnatacaoFora.tempo_hhmmss = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_hhmmss, "") 
        objLeiteEventoTempoDesnatacaoFora.tempo_segundos = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_segundos, 0)   

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoFora)

        dim objLeiteEventoTempoDesnatacaoDentro As new TempoEventos

        objLeiteEventoTempoDesnatacaoDentro.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoDesnatacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos)
        objLeiteEventoTempoDesnatacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoDentro)

        return TempoEventos
    End Function

    Public Shared Function GetTempoEventosSoroDeQueijo(ByVal parIdTag As String) As List(Of TempoEventos)
        dim leiteInfo = new List(Of LeiteInfo)

        leiteInfo = GetSoroDeQueijoInfo(parIdTag)

        dim leiteEvento = new List(Of LeiteEvento)

        leiteEvento = GetLeiteEvento(parIdTag)

        dim TempoEventos = new List(Of TempoEventos)

        'MÁQUINA LIGADA vs MÁQUINA DESLIGADA - Em tempo total: 24h
        dim objLeiteInfoMaqLigada As new TempoEventos

        objLeiteInfoMaqLigada.tag = "maqligada"
        objLeiteInfoMaqLigada.description = "Máquina Ligada"
        objLeiteInfoMaqLigada.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_hhmmss, "")
        objLeiteInfoMaqLigada.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqLigada)

        dim objLeiteInfoMaqDesligada As new TempoEventos

        objLeiteInfoMaqDesligada.tag = "maqligada"
        objLeiteInfoMaqDesligada.description = "Máquina Desligada"
        objLeiteInfoMaqDesligada.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos)
        objLeiteInfoMaqDesligada.tempo_segundos = (24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqDesligada)

        'MÁQUINA EM AUTOMÁTICO vs MÁQUINA EM MANUAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqAutomatico As new TempoEventos

        objLeiteInfoMaqAutomatico.tag = "automatico"
        objLeiteInfoMaqAutomatico.description = "Automático"
        objLeiteInfoMaqAutomatico.tempo_hhmmss =  if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_hhmmss, "")
        objLeiteInfoMaqAutomatico.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqAutomatico)

        dim objLeiteInfoMaqManual As new TempoEventos

        objLeiteInfoMaqManual.tag = "automatico"
        objLeiteInfoMaqManual.description = "Manual"
        objLeiteInfoMaqManual.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos -  objLeiteInfoMaqAutomatico.tempo_segundos)
        objLeiteInfoMaqManual.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqAutomatico.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqManual)

        'MÁQUINA EM LIMPEZA vs MÁQUINA EM OPERAÇÃO NORMAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqEmLimpeza As new TempoEventos

        objLeiteInfoMaqEmLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmLimpeza.description = "Em Limpeza"
        objLeiteInfoMaqEmLimpeza.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_hhmmss, "")
        objLeiteInfoMaqEmLimpeza.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqEmLimpeza)

        dim objLeiteInfoMaqEmNaoLimpeza As new TempoEventos

        objLeiteInfoMaqEmNaoLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmNaoLimpeza.description = "Em Operação Normal"
        objLeiteInfoMaqEmNaoLimpeza.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos)
        objLeiteInfoMaqEmNaoLimpeza.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqEmNaoLimpeza)

        'MÁQUINA COM TEMPERATURA DE PASTEURIZAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14081 = Temperatura DE PASTEURIZACAO no {HOST.NAME} ABAIXO DE 72 GRAUS
        dim objLeiteEventoPasteurizacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14081)

        dim objLeiteEventoTempoPasteurizacaoFora As new TempoEventos

        objLeiteEventoTempoPasteurizacaoFora.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoPasteurizacaoFora.tempo_hhmmss = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_hhmmss, "")  
        objLeiteEventoTempoPasteurizacaoFora.tempo_segundos = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoFora)

        dim objLeiteEventoTempoPasteurizacaoDentro As new TempoEventos

        objLeiteEventoTempoPasteurizacaoDentro.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoPasteurizacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos)
        objLeiteEventoTempoPasteurizacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoDentro)


        'MÁQUINA COM TEMPERATURA DE DESNATAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14082 = Temperatura DESNATACAO no {HOST.NAME} ACIMA de 78 GRAUS
        dim objLeiteEventoDesnatacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14082)

        dim objLeiteEventoTempoDesnatacaoFora As new TempoEventos

        objLeiteEventoTempoDesnatacaoFora.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoDesnatacaoFora.tempo_hhmmss = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_hhmmss, "") 
        objLeiteEventoTempoDesnatacaoFora.tempo_segundos = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_segundos, 0)   

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoFora)

        dim objLeiteEventoTempoDesnatacaoDentro As new TempoEventos

        objLeiteEventoTempoDesnatacaoDentro.tag = "desnatacaofora"
        objLeiteEventoTempoDesnatacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoDesnatacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos)
        objLeiteEventoTempoDesnatacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoDesnatacaoDentro)

        return TempoEventos
    End Function

    Public Shared Function GetTempoEventosCreme(ByVal parIdTag As String) As List(Of TempoEventos)
        dim leiteInfo = new List(Of LeiteInfo)

        leiteInfo = GetCremeInfo(parIdTag)

        dim leiteEvento = new List(Of LeiteEvento)

        leiteEvento = GetLeiteEvento(parIdTag)

        dim TempoEventos = new List(Of TempoEventos)

        'MÁQUINA LIGADA vs MÁQUINA DESLIGADA - Em tempo total: 24h
        dim objLeiteInfoMaqLigada As new TempoEventos

        objLeiteInfoMaqLigada.tag = "maqligada"
        objLeiteInfoMaqLigada.description = "Máquina Ligada"
        objLeiteInfoMaqLigada.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_hhmmss, "")
        objLeiteInfoMaqLigada.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.ligado_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqLigada)

        dim objLeiteInfoMaqDesligada As new TempoEventos

        objLeiteInfoMaqDesligada.tag = "maqligada"
        objLeiteInfoMaqDesligada.description = "Máquina Desligada"
        objLeiteInfoMaqDesligada.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos)
        objLeiteInfoMaqDesligada.tempo_segundos = (24 * 60 * 60) -  objLeiteInfoMaqLigada.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqDesligada)

        'MÁQUINA EM AUTOMÁTICO vs MÁQUINA EM MANUAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqAutomatico As new TempoEventos

        objLeiteInfoMaqAutomatico.tag = "automatico"
        objLeiteInfoMaqAutomatico.description = "Automático"
        objLeiteInfoMaqAutomatico.tempo_hhmmss =  if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_hhmmss, "")
        objLeiteInfoMaqAutomatico.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.automatico_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqAutomatico)

        dim objLeiteInfoMaqManual As new TempoEventos

        objLeiteInfoMaqManual.tag = "automatico"
        objLeiteInfoMaqManual.description = "Manual"
        objLeiteInfoMaqManual.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos -  objLeiteInfoMaqAutomatico.tempo_segundos)
        objLeiteInfoMaqManual.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqAutomatico.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqManual)

        'MÁQUINA EM LIMPEZA vs MÁQUINA EM OPERAÇÃO NORMAL - Em tempo total: tempo máquina ligada
        dim objLeiteInfoMaqEmLimpeza As new TempoEventos

        objLeiteInfoMaqEmLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmLimpeza.description = "Em Limpeza"
        objLeiteInfoMaqEmLimpeza.tempo_hhmmss = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_hhmmss, "")
        objLeiteInfoMaqEmLimpeza.tempo_segundos = if(leiteinfo.FirstOrDefault IsNot nothing, leiteinfo.FirstOrDefault.limpeza_tempo_segundos, 0)

        TempoEventos.Add(objLeiteInfoMaqEmLimpeza)

        dim objLeiteInfoMaqEmNaoLimpeza As new TempoEventos

        objLeiteInfoMaqEmNaoLimpeza.tag = "limpeza"
        objLeiteInfoMaqEmNaoLimpeza.description = "Em Operação Normal"
        objLeiteInfoMaqEmNaoLimpeza.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos)
        objLeiteInfoMaqEmNaoLimpeza.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteInfoMaqEmLimpeza.tempo_segundos

        TempoEventos.Add(objLeiteInfoMaqEmNaoLimpeza)

        'MÁQUINA COM TEMPERATURA DE PASTEURIZAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        '14089 = Temperatura DE PASTEURIZACAO no {HOST.NAME} ABAIXO DE 72 GRAUS
        dim objLeiteEventoPasteurizacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14089)

        dim objLeiteEventoTempoPasteurizacaoFora As new TempoEventos

        objLeiteEventoTempoPasteurizacaoFora.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoFora.description = "Fora do Desejado"
        objLeiteEventoTempoPasteurizacaoFora.tempo_hhmmss = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_hhmmss, "")  
        objLeiteEventoTempoPasteurizacaoFora.tempo_segundos = if(objLeiteEventoPasteurizacaoFora IsNot nothing, objLeiteEventoPasteurizacaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoFora)

        dim objLeiteEventoTempoPasteurizacaoDentro As new TempoEventos

        objLeiteEventoTempoPasteurizacaoDentro.tag = "pasteurizacaofora"
        objLeiteEventoTempoPasteurizacaoDentro.description = "Dentro do Desejado"
        objLeiteEventoTempoPasteurizacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos)
        objLeiteEventoTempoPasteurizacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoPasteurizacaoFora.tempo_segundos

        TempoEventos.Add(objLeiteEventoTempoPasteurizacaoDentro)

        '*Host Creme NÃO POSSUI TRIGGER PARA DESNATAÇÃO

        ''MÁQUINA COM TEMPERATURA DE DESNATAÇÃO FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: tempo máquina ligada
        ''14082 = Temperatura DESNATACAO no {HOST.NAME} ACIMA de 78 GRAUS
        'dim objLeiteEventoDesnatacaoFora = leiteEvento.FirstOrDefault(function(x) x.objectid = 14082)

        'dim objLeiteEventoTempoDesnatacaoFora As new TempoEventos

        'objLeiteEventoTempoDesnatacaoFora.tag = "desnatacaofora"
        'objLeiteEventoTempoDesnatacaoFora.description = "Fora do Desejado"
        'objLeiteEventoTempoDesnatacaoFora.tempo_hhmmss = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_hhmmss, "") 
        'objLeiteEventoTempoDesnatacaoFora.tempo_segundos = if(objLeiteEventoDesnatacaoFora IsNot nothing, objLeiteEventoDesnatacaoFora.tempo_segundos, 0)   

        'TempoEventos.Add(objLeiteEventoTempoDesnatacaoFora)

        'dim objLeiteEventoTempoDesnatacaoDentro As new TempoEventos

        'objLeiteEventoTempoDesnatacaoDentro.tag = "desnatacaofora"
        'objLeiteEventoTempoDesnatacaoDentro.description = "Dentro do Desejado"
        'objLeiteEventoTempoDesnatacaoDentro.tempo_hhmmss = SecondsToHHMMSS(objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos)
        'objLeiteEventoTempoDesnatacaoDentro.tempo_segundos = objLeiteInfoMaqLigada.tempo_segundos - objLeiteEventoTempoDesnatacaoFora.tempo_segundos

        'TempoEventos.Add(objLeiteEventoTempoDesnatacaoDentro)

        return TempoEventos
    End Function


    Public Shared Function GetCamarasFriasEvento(byval parIdTag As String) As List(Of CamarasFriasEvento)
        'Eventos do hosts CamarasFrias sumarizados
        dim CamarasFriasEvento = new List(Of CamarasFriasEvento)

        dim CamarasFriasEventoCollection = s5t.IndustriaCamarasFriasEventoCollection.LoadByIdTag(parIdTag)

        CamarasFriasEvento = CamarasFriasEventoCollection.Select(function(x) New CamarasFriasEvento With {
                                                            .idtag = x.idtag,
                                                            .periodoINI = x.periodoINI,
                                                            .periodoFIM = x.periodoFIM,
                                                            .objectid = x.objectid,
                                                            .description = x.description,
                                                            .hostname = x.hostname,
                                                            .numOcorrencia = x.numOcorrencia,
                                                            .tempo_hhmmss = x.tempo_hhmmss,
                                                            .tempo_dias = x.tempo_dias,
                                                            .tempo_horas = x.tempo_horas,
                                                            .tempo_minutos = x.tempo_minutos,
                                                            .tempo_segundos = x.tempo_segundos,
                                                            .tempo_datetime = x.tempo_datetime,
                                                            .tempo_dd = x.tempo_dd,
                                                            .tempo_hh = x.tempo_hh,
                                                            .tempo_mm = x.tempo_mm,
                                                            .tempo_ss = x.tempo_ss
                                                         }).ToList
        return CamarasFriasEvento
    End Function

    Public Shared Function GetTempoEventosCamarasFrias(ByVal parIdTag As String) As List(Of TempoEventos)
        dim camarasfriasEvento = new List(Of CamarasFriasEvento)

        camarasfriasEvento = GetCamarasFriasEvento(parIdTag)

        dim TempoEventos = new List(Of TempoEventos)

        'FORA DO DESEJADO vs DENTRO DO DESEJADO - Em tempo total: 24 horas
        '14091 = Temperatura em Câmara Montanhês FORA DO DESEJADO
        dim objCamarasFriasEventoMontanhesFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14091)

        dim objCamarasFriasEventoTempoMontanhesFora As new TempoEventos

        objCamarasFriasEventoTempoMontanhesFora.tag = "montanhesfora"
        objCamarasFriasEventoTempoMontanhesFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoMontanhesFora.tempo_hhmmss = if(objCamarasFriasEventoMontanhesFora IsNot nothing, objCamarasFriasEventoMontanhesFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoMontanhesFora.tempo_segundos = if(objCamarasFriasEventoMontanhesFora IsNot nothing, objCamarasFriasEventoMontanhesFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoMontanhesFora)

        dim objCamarasFriasEventoTempoMontanhesDentro As new TempoEventos

        objCamarasFriasEventoTempoMontanhesDentro.tag = "montanhesfora"
        objCamarasFriasEventoTempoMontanhesDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoMontanhesDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoMontanhesFora.tempo_segundos)
        objCamarasFriasEventoTempoMontanhesDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoMontanhesFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoMontanhesDentro)


        '14092 = Temperatura em Câmara Salgada FORA DO DESEJADO
        dim objCamarasFriasEventoSalgadaFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14092)

        dim objCamarasFriasEventoTempoSalgadaFora As new TempoEventos

        objCamarasFriasEventoTempoSalgadaFora.tag = "salgadafora"
        objCamarasFriasEventoTempoSalgadaFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoSalgadaFora.tempo_hhmmss = if(objCamarasFriasEventoSalgadaFora IsNot nothing, objCamarasFriasEventoSalgadaFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoSalgadaFora.tempo_segundos = if(objCamarasFriasEventoSalgadaFora IsNot nothing, objCamarasFriasEventoSalgadaFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoSalgadaFora)

        dim objCamarasFriasEventoTempoSalgadaDentro As new TempoEventos

        objCamarasFriasEventoTempoSalgadaDentro.tag = "salgadafora"
        objCamarasFriasEventoTempoSalgadaDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoSalgadaDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoSalgadaFora.tempo_segundos)
        objCamarasFriasEventoTempoSalgadaDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoSalgadaFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoSalgadaDentro)


        '14093 = Temperatura em Câmara Maturacao FORA DO DESEJADO
        dim objCamarasFriasEventoMaturacaoFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14093)

        dim objCamarasFriasEventoTempoMaturacaoFora As new TempoEventos

        objCamarasFriasEventoTempoMaturacaoFora.tag = "maturacaofora"
        objCamarasFriasEventoTempoMaturacaoFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoMaturacaoFora.tempo_hhmmss = if(objCamarasFriasEventoMaturacaoFora IsNot nothing, objCamarasFriasEventoMaturacaoFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoMaturacaoFora.tempo_segundos = if(objCamarasFriasEventoMaturacaoFora IsNot nothing, objCamarasFriasEventoMaturacaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoMaturacaoFora)

        dim objCamarasFriasEventoTempoMaturacaoDentro As new TempoEventos

        objCamarasFriasEventoTempoMaturacaoDentro.tag = "maturacaofora"
        objCamarasFriasEventoTempoMaturacaoDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoMaturacaoDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoMaturacaoFora.tempo_segundos)
        objCamarasFriasEventoTempoMaturacaoDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoMaturacaoFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoMaturacaoDentro)




        '14094 = Temperatura em Câmara MinasRicota FORA DO DESEJADO
        dim objCamarasFriasEventoMinasRicotaFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14094)

        dim objCamarasFriasEventoTempoMinasRicotaFora As new TempoEventos

        objCamarasFriasEventoTempoMinasRicotaFora.tag = "minasricotafora"
        objCamarasFriasEventoTempoMinasRicotaFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoMinasRicotaFora.tempo_hhmmss = if(objCamarasFriasEventoMinasRicotaFora IsNot nothing, objCamarasFriasEventoMinasRicotaFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoMinasRicotaFora.tempo_segundos = if(objCamarasFriasEventoMinasRicotaFora IsNot nothing, objCamarasFriasEventoMinasRicotaFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoMinasRicotaFora)

        dim objCamarasFriasEventoTempoMinasRicotaDentro As new TempoEventos

        objCamarasFriasEventoTempoMinasRicotaDentro.tag = "minasricotafora"
        objCamarasFriasEventoTempoMinasRicotaDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoMinasRicotaDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoMinasRicotaFora.tempo_segundos)
        objCamarasFriasEventoTempoMinasRicotaDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoMinasRicotaFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoMinasRicotaDentro)


        '14095 = Temperatura em Câmara ProdutoAcabado FORA DO DESEJADO
        dim objCamarasFriasEventoProdutoAcabadoFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14095)

        dim objCamarasFriasEventoTempoProdutoAcabadoFora As new TempoEventos

        objCamarasFriasEventoTempoProdutoAcabadoFora.tag = "produtoacabadofora"
        objCamarasFriasEventoTempoProdutoAcabadoFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoProdutoAcabadoFora.tempo_hhmmss = if(objCamarasFriasEventoProdutoAcabadoFora IsNot nothing, objCamarasFriasEventoProdutoAcabadoFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoProdutoAcabadoFora.tempo_segundos = if(objCamarasFriasEventoProdutoAcabadoFora IsNot nothing, objCamarasFriasEventoProdutoAcabadoFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoProdutoAcabadoFora)

        dim objCamarasFriasEventoTempoProdutoAcabadoDentro As new TempoEventos

        objCamarasFriasEventoTempoProdutoAcabadoDentro.tag = "produtoacabadofora"
        objCamarasFriasEventoTempoProdutoAcabadoDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoProdutoAcabadoDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoProdutoAcabadoFora.tempo_segundos)
        objCamarasFriasEventoTempoProdutoAcabadoDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoProdutoAcabadoFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoProdutoAcabadoDentro)



        '14096 = Temperatura em Câmara Requeijao FORA DO DESEJADO
        dim objCamarasFriasEventoRequeijaoFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14096)

        dim objCamarasFriasEventoTempoRequeijaoFora As new TempoEventos

        objCamarasFriasEventoTempoRequeijaoFora.tag = "requeijaofora"
        objCamarasFriasEventoTempoRequeijaoFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoRequeijaoFora.tempo_hhmmss = if(objCamarasFriasEventoRequeijaoFora IsNot nothing, objCamarasFriasEventoRequeijaoFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoRequeijaoFora.tempo_segundos = if(objCamarasFriasEventoRequeijaoFora IsNot nothing, objCamarasFriasEventoRequeijaoFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoRequeijaoFora)

        dim objCamarasFriasEventoTempoRequeijaoDentro As new TempoEventos

        objCamarasFriasEventoTempoRequeijaoDentro.tag = "requeijaofora"
        objCamarasFriasEventoTempoRequeijaoDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoRequeijaoDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoRequeijaoFora.tempo_segundos)
        objCamarasFriasEventoTempoRequeijaoDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoRequeijaoFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoRequeijaoDentro)


        '14097 = Temperatura em Câmara Secagem FORA DO DESEJADO
        dim objCamarasFriasEventoSecagemFora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14097)

        dim objCamarasFriasEventoTempoSecagemFora As new TempoEventos

        objCamarasFriasEventoTempoSecagemFora.tag = "secagemfora"
        objCamarasFriasEventoTempoSecagemFora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoSecagemFora.tempo_hhmmss = if(objCamarasFriasEventoSecagemFora IsNot nothing, objCamarasFriasEventoSecagemFora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoSecagemFora.tempo_segundos = if(objCamarasFriasEventoSecagemFora IsNot nothing, objCamarasFriasEventoSecagemFora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoSecagemFora)

        dim objCamarasFriasEventoTempoSecagemDentro As new TempoEventos

        objCamarasFriasEventoTempoSecagemDentro.tag = "secagemfora"
        objCamarasFriasEventoTempoSecagemDentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoSecagemDentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoSecagemFora.tempo_segundos)
        objCamarasFriasEventoTempoSecagemDentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoSecagemFora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoSecagemDentro)


        '14098 = Temperatura em Câmara Secagem1 FORA DO DESEJADO
        dim objCamarasFriasEventoSecagem1Fora = camarasfriasEvento.FirstOrDefault(function(x) x.objectid = 14098)

        dim objCamarasFriasEventoTempoSecagem1Fora As new TempoEventos

        objCamarasFriasEventoTempoSecagem1Fora.tag = "secagem1fora"
        objCamarasFriasEventoTempoSecagem1Fora.description = "Fora do Desejado"
        objCamarasFriasEventoTempoSecagem1Fora.tempo_hhmmss = if(objCamarasFriasEventoSecagem1Fora IsNot nothing, objCamarasFriasEventoSecagem1Fora.tempo_hhmmss, "")  
        objCamarasFriasEventoTempoSecagem1Fora.tempo_segundos = if(objCamarasFriasEventoSecagem1Fora IsNot nothing, objCamarasFriasEventoSecagem1Fora.tempo_segundos, 0)  

        TempoEventos.Add(objCamarasFriasEventoTempoSecagem1Fora)

        dim objCamarasFriasEventoTempoSecagem1Dentro As new TempoEventos

        objCamarasFriasEventoTempoSecagem1Dentro.tag = "secagem1fora"
        objCamarasFriasEventoTempoSecagem1Dentro.description = "Dentro do Desejado"
        objCamarasFriasEventoTempoSecagem1Dentro.tempo_hhmmss = SecondsToHHMMSS((24 * 60 * 60) - objCamarasFriasEventoTempoSecagem1Fora.tempo_segundos)
        objCamarasFriasEventoTempoSecagem1Dentro.tempo_segundos = (24 * 60 * 60) - objCamarasFriasEventoTempoSecagem1Fora.tempo_segundos

        TempoEventos.Add(objCamarasFriasEventoTempoSecagem1Dentro)



        return TempoEventos
    End Function


End Class
