/* CodeFluent Generated . TargetVersion:Sql2014. Culture:pt-BR. UiCulture:pt-BR. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vappconfig' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vappconfig]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAppFvendasPedidos' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAppFvendasPedidos]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAppFvendasPedidosCompra' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAppFvendasPedidosCompra]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAppFvendasPedidosCompraMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAppFvendasPedidosCompraMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAppFvendasPedidosMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAppFvendasPedidosMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vapprelatorio' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vapprelatorio]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vapprelatorioapprelatoriousuarioview' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vapprelatorioapprelatoriousuarioview]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vapprelatorioapprelatorioview' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vapprelatorioapprelatorioview]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoCaminhao' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoCaminhao]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoCaminhaoAviacaoCaminhaoViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoCaminhaoAviacaoCaminhaoViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoClienteGrupos' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoClienteGrupos]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoClientes' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoClientes]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoConhecimentoFrete' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoConhecimentoFrete]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoConhecimentoFreteAgrup' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoConhecimentoFreteAgrup]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoFinanceiro' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoFinanceiro]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoLocalLinha' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoLocalLinha]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoLocalLinhaAviacaoLocalLinhaViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoLocalLinhaAviacaoLocalLinhaViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoMotorista' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoMotorista]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoMotoristaAviacaoMotoristaViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoMotoristaAviacaoMotoristaViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoPedidosFaturamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoPedidosFaturamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoPivotAnalise' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoPivotAnalise]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoPivotAnaliseAviacaoPivotAnaliseViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoPivotAnaliseAviacaoPivotAnaliseViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoProdutoGrupos' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoProdutoGrupos]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoProdutos' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoProdutos]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoRedespachos' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoRedespachos]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoTitulosClientes' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoTitulosClientes]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoTransportadores' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoTransportadores]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendas' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendas]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendas3Meses' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendas3Meses]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendas3MesesAnoMenos1' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendas3MesesAnoMenos1]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendas3MesesAnoMenos2' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendas3MesesAnoMenos2]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAgrup' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAgrup]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAgrupAnoMenos1' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAgrupAnoMenos1]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAgrupAnoMenos2' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAgrupAnoMenos2]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAnoMenos1' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAnoMenos1]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vaviacaovendasanomenos1aviacaovendasanomenos1viewmarca' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vaviacaovendasanomenos1aviacaovendasanomenos1viewmarca]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAnoMenos2' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAnoMenos2]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasAviacaoVendasRelVendedor' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasAviacaoVendasRelVendedor]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendasComDevolucao' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendasComDevolucao]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendedores' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendedores]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoVendedoresEmail' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoVendedoresEmail]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vaviacaovendedoresemailaviacaovendedoresemailview' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vaviacaovendedoresemailaviacaovendedoresemailview]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vAviacaoViagemMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vAviacaoViagemMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vaviacaoviagemmovaviacaoviagemmovviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vaviacaoviagemmovaviacaoviagemmovviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vBalancaFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vBalancaFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vBevBoleAgri' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vBevBoleAgri]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcadastro' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcadastro]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcadastrocadastroviewgeral' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcadastrocadastroviewgeral]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcadastrocadastroviewgeraltipo' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcadastrocadastroviewgeraltipo]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcadastrotipo' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcadastrotipo]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcadastrotipocadastrotipoviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcadastrotipocadastrotipoviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcidade' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcidade]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcidadecidadeviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcidadecidadeviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vControleViagemAg' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vControleViagemAg]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vcontroleviagemagcontroleviagemagviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vcontroleviagemagcontroleviagemagviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vCTeControleViagemAg' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vCTeControleViagemAg]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vEmbalagemFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vEmbalagemFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vEmbalagemFracionamentoEmbalagemFracionamentoView' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vEmbalagemFracionamentoEmbalagemFracionamentoView]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vempresa' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vempresa]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vEmpresaVisita' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vEmpresaVisita]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vfilial' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vfilial]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vfilialconfig' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vfilialconfig]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vfilialfilialviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vfilialfilialviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vfilialfilialviewusuarios' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vfilialfilialviewusuarios]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vFracionamentoMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vFracionamentoMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vFracionamentoMovFracionamentoMovViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vFracionamentoMovFracionamentoMovViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vFuncionarioVisita' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vFuncionarioVisita]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIdRole' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIdRole]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIdRoleClaim' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIdRoleClaim]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIdUser' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIdUser]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIdUserClaim' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIdUserClaim]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIdUserLogin' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIdUserLogin]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaCamarasFriasEvento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaCamarasFriasEvento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaCremeTempoLimpezaAutomatico' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaCremeTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvaseContadorProducao' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvaseContadorProducao]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvaseEvento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvaseEvento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvaseMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvaseMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvasePesoMedio' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvasePesoMedio]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvaseSipMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvaseSipMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaEnvaseTempoSip' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaEnvaseTempoSip]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaLeiteEvento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaLeiteEvento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaLeitelhoTempoLimpezaAutomatico' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaLeitelhoTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaLeiteTempoLimpezaAutomatico' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaLeiteTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vIndustriaSoroDeQueijoTempoLimpezaAutomatico' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vIndustriaSoroDeQueijoTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vLogFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vLogFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vLogFracionamentoLogFracionamentoView' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vLogFracionamentoLogFracionamentoView]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vloginregistro' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vloginregistro]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vLoteControleViagemAg' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vLoteControleViagemAg]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vmenu' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vmenu]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vmenumenuvw' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vmenumenuvw]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vmenumenuvwperm' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vmenumenuvwperm]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vmenupermissao' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vmenupermissao]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vMovimentacaoLote' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vMovimentacaoLote]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vMovimentacaoLoteMovimentacaoLoteViewDashboard' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vMovimentacaoLoteMovimentacaoLoteViewDashboard]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vMovimentacaoLoteMovimentacaoLoteViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vMovimentacaoLoteMovimentacaoLoteViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vNFControleViagemAg' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vNFControleViagemAg]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vpais' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vpais]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vpaispaisviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vpaispaisviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vPaleteMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vPaleteMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vPaleteProduto' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vPaleteProduto]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vParametrosFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vParametrosFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vProduto' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vProduto]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vProdutoPrevisao' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vProdutoPrevisao]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vProdutoPrevisaoProdutoPrevisaoView' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vProdutoPrevisaoProdutoPrevisaoView]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vProdutoProdutoViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vProdutoProdutoViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vSetorVisita' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vSetorVisita]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vsistema' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vsistema]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vTaraFracionamento' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vTaraFracionamento]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vTaraFracionamentoTaraFracionamentoView' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vTaraFracionamentoTaraFracionamentoView]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vuf' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vuf]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vufufviewgrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vufufviewgrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vusuario' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vusuario]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vVisitaMov' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vVisitaMov]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vVisitaMovVisitaViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vVisitaMovVisitaViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vVisitanteVisita' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vVisitanteVisita]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vVisitanteVisitaVisitanteVisitaViewGrid' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vVisitanteVisitaVisitanteVisitaViewGrid]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vWebSiteMap' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vWebSiteMap]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'vwebsitemaplogacessousuariosviewraw' AND TABLE_SCHEMA = 'dbo')
DROP VIEW [dbo].[vwebsitemaplogacessousuariosviewraw]
GO

CREATE VIEW [dbo].[vappconfig]
AS
SELECT [appconfig].[pId], [appconfig].[_trackCreationTime], [appconfig].[_trackLastWriteTime], [appconfig].[_trackCreationUser], [appconfig].[_trackLastWriteUser] 
    FROM [appconfig]
GO

CREATE VIEW [dbo].[vAppFvendasPedidos]
AS
SELECT [AppFvendasPedidos].[pId], [AppFvendasPedidos].[pA1_COD], [AppFvendasPedidos].[pA3_COD], [AppFvendasPedidos].[pA1_LOJA], [AppFvendasPedidos].[pObservacao], [AppFvendasPedidos].[pObservacaoResumida], [AppFvendasPedidos].[pDataEmissao], [AppFvendasPedidos].[pDataEntrega], [AppFvendasPedidos].[pFlgStatus], [AppFvendasPedidos].[pNumeroPedido], [AppFvendasPedidos].[pA3_NOME], [AppFvendasPedidos].[pA3_COTA], [AppFvendasPedidos].[pA1_NOME], [AppFvendasPedidos].[pNumeroItens], [AppFvendasPedidos].[pValorTotal], [AppFvendasPedidos].[pNumeroPedidoCliente], [AppFvendasPedidos].[pWsOrcamento_DESCRICAO], [AppFvendasPedidos].[pWsOrcamento_STATUS], [AppFvendasPedidos].[pWsOrcamento_ITENS], [AppFvendasPedidos].[pA1_END], [AppFvendasPedidos].[pFlgStatusEnvioCliente], [AppFvendasPedidos].[pFlgStatusEnvioClienteObs], [AppFvendasPedidos].[pCodigoSubVendedor], [AppFvendasPedidos].[_trackCreationTime], [AppFvendasPedidos].[_trackLastWriteTime], [AppFvendasPedidos].[_trackCreationUser], [AppFvendasPedidos].[_trackLastWriteUser] 
    FROM [AppFvendasPedidos]
GO

CREATE VIEW [dbo].[vAppFvendasPedidosCompra]
AS
SELECT [AppFvendasPedidosCompra].[pId], [AppFvendasPedidosCompra].[pCodigoFilial], [AppFvendasPedidosCompra].[pNumeroPedido], [AppFvendasPedidosCompra].[pCodigoFornecedor], [AppFvendasPedidosCompra].[pCodigoLoja], [AppFvendasPedidosCompra].[pNomeFornecedor], [AppFvendasPedidosCompra].[pDataEmissao], [AppFvendasPedidosCompra].[pValorTotal], [AppFvendasPedidosCompra].[pUltimoCodigoAprovador], [AppFvendasPedidosCompra].[pUltimoStatusRetorno], [AppFvendasPedidosCompra].[_trackCreationTime], [AppFvendasPedidosCompra].[_trackLastWriteTime], [AppFvendasPedidosCompra].[_trackCreationUser], [AppFvendasPedidosCompra].[_trackLastWriteUser] 
    FROM [AppFvendasPedidosCompra]
GO

CREATE VIEW [dbo].[vAppFvendasPedidosCompraMov]
AS
SELECT [AppFvendasPedidosCompraMov].[pId], [AppFvendasPedidosCompraMov].[pCodigoFilial], [AppFvendasPedidosCompraMov].[pNumeroPedido], [AppFvendasPedidosCompraMov].[pCodigoFornecedor], [AppFvendasPedidosCompraMov].[pCodigoLoja], [AppFvendasPedidosCompraMov].[pNomeFornecedor], [AppFvendasPedidosCompraMov].[pDataEmissao], [AppFvendasPedidosCompraMov].[pValorTotal], [AppFvendasPedidosCompraMov].[pCodigoAprovador], [AppFvendasPedidosCompraMov].[pDataEnvio], [AppFvendasPedidosCompraMov].[pFlgOperacao], [AppFvendasPedidosCompraMov].[pStatusRetorno], [AppFvendasPedidosCompraMov].[pStatusRetornoDescricao], [AppFvendasPedidosCompraMov].[_trackCreationTime], [AppFvendasPedidosCompraMov].[_trackLastWriteTime], [AppFvendasPedidosCompraMov].[_trackCreationUser], [AppFvendasPedidosCompraMov].[_trackLastWriteUser] 
    FROM [AppFvendasPedidosCompraMov]
GO

CREATE VIEW [dbo].[vAppFvendasPedidosMov]
AS
SELECT [AppFvendasPedidosMov].[pId], [AppFvendasPedidosMov].[pB1_COD], [AppFvendasPedidosMov].[pQuantidade], [AppFvendasPedidosMov].[pQuantidadeCaixas], [AppFvendasPedidosMov].[pObservacao], [AppFvendasPedidosMov].[pNumeroPedido], [AppFvendasPedidosMov].[pB1_DESC], [AppFvendasPedidosMov].[pDA1_PRCVEN], [AppFvendasPedidosMov].[pB1_CONV], [AppFvendasPedidosMov].[pB1_TIPCONV], [AppFvendasPedidosMov].[pB1_GRUPO], [AppFvendasPedidosMov].[pB1_ZZPESOP], [AppFvendasPedidosMov].[pZP_SALDO], [AppFvendasPedidosMov].[pZP_STATUS], [AppFvendasPedidosMov].[pValorTotalProduto], [AppFvendasPedidosMov].[pPed_A1_COD], [AppFvendasPedidosMov].[pPed_A1_LOJA], [AppFvendasPedidosMov].[pPed_A1_NOME], [AppFvendasPedidosMov].[pPed_A3_COD], [AppFvendasPedidosMov].[pPed_A3_COTA], [AppFvendasPedidosMov].[pPed_A3_NOME], [AppFvendasPedidosMov].[pPed_DataEmissao], [AppFvendasPedidosMov].[pPed_DataEntrega], [AppFvendasPedidosMov].[pPed_FlgStatus], [AppFvendasPedidosMov].[pPed_Observacao], [AppFvendasPedidosMov].[pB1_GRUPO_DESC], [AppFvendasPedidosMov].[pPed_NumeroPedidoCliente], [AppFvendasPedidosMov].[pPed_WsOrcamento_DESCRICAO], [AppFvendasPedidosMov].[pPed_WsOrcamento_ITENS], [AppFvendasPedidosMov].[pPed_WsOrcamento_STATUS], [AppFvendasPedidosMov].[pPed_A1_END], [AppFvendasPedidosMov].[pPed_pCodigoSubVendedor], [AppFvendasPedidosMov].[_trackCreationTime], [AppFvendasPedidosMov].[_trackLastWriteTime], [AppFvendasPedidosMov].[_trackCreationUser], [AppFvendasPedidosMov].[_trackLastWriteUser] 
    FROM [AppFvendasPedidosMov]
GO

CREATE VIEW [dbo].[vapprelatorio]
AS
SELECT [apprelatorio].[pId], [apprelatorio].[pNomeFormArgumento], [apprelatorio].[pNomeRelatorio], [apprelatorio].[pNomeRdlc], [apprelatorio].[pNomeDataSet], [apprelatorio].[sCategoria], [apprelatorio].[pTituloRelatorio], [apprelatorio].[pSequencia], [apprelatorio].[pCategoriaRelatorio], [apprelatorio].[_trackCreationTime], [apprelatorio].[_trackLastWriteTime], [apprelatorio].[_trackCreationUser], [apprelatorio].[_trackLastWriteUser] 
    FROM [apprelatorio]
GO

CREATE VIEW [dbo].[vapprelatorioapprelatoriousuarioview]
AS
SELECT [apprelatorio].[pId], [apprelatorio].[pNomeFormArgumento], [apprelatorio].[pNomeRelatorio], [apprelatorio].[pNomeRdlc], [apprelatorio].[pNomeDataSet], [apprelatorio].[sCategoria], [apprelatorio].[pTituloRelatorio], [apprelatorio].[pSequencia], [apprelatorio].[pCategoriaRelatorio], [usuario].[pLogin] AS 'pUsuarioLogin', [apprelatorio].[_trackCreationTime], [apprelatorio].[_trackLastWriteTime], [apprelatorio].[_trackCreationUser], [apprelatorio].[_trackLastWriteUser] 
    FROM [apprelatorio]
        LEFT OUTER JOIN [apprelatorio_oUsuarios_usuario_oAppRelatorios] ON ([apprelatorio].[pId] = [apprelatorio_oUsuarios_usuario_oAppRelatorios].[pId])
                LEFT OUTER JOIN [usuario] ON ([apprelatorio_oUsuarios_usuario_oAppRelatorios].[pId2] = [usuario].[pId])
GO

CREATE VIEW [dbo].[vapprelatorioapprelatorioview]
AS
SELECT [apprelatorio].[pId], [apprelatorio].[pNomeFormArgumento], [apprelatorio].[pNomeRelatorio], [apprelatorio].[pNomeRdlc], [apprelatorio].[pNomeDataSet], [apprelatorio].[sCategoria], [apprelatorio].[pTituloRelatorio], [apprelatorio].[pSequencia], [apprelatorio].[pCategoriaRelatorio], [apprelatorio].[_trackCreationTime], [apprelatorio].[_trackLastWriteTime], [apprelatorio].[_trackCreationUser], [apprelatorio].[_trackLastWriteUser] 
    FROM [apprelatorio]
GO

CREATE VIEW [dbo].[vAviacaoCaminhao]
AS
SELECT [AviacaoCaminhao].[pId], [AviacaoCaminhao].[pPLACA], [AviacaoCaminhao].[pTIPO], [AviacaoCaminhao].[pDESC_VEICULO], [AviacaoCaminhao].[pCAPACIDADE_TON], [AviacaoCaminhao].[pCAPACIDADE_PALETE], [AviacaoCaminhao].[oAviacaoMotorista_pId], [AviacaoCaminhao].[sStatus], [AviacaoCaminhao].[_trackCreationTime], [AviacaoCaminhao].[_trackLastWriteTime], [AviacaoCaminhao].[_trackCreationUser], [AviacaoCaminhao].[_trackLastWriteUser] 
    FROM [AviacaoCaminhao]
GO

CREATE VIEW [dbo].[vAviacaoCaminhaoAviacaoCaminhaoViewGrid]
AS
SELECT [AviacaoCaminhao].[pId], [AviacaoCaminhao].[pPLACA], [AviacaoCaminhao].[pTIPO], [AviacaoCaminhao].[pDESC_VEICULO], [AviacaoCaminhao].[pCAPACIDADE_TON], [AviacaoCaminhao].[pCAPACIDADE_PALETE], [AviacaoCaminhao].[sStatus], [AviacaoCaminhao].[_trackCreationTime], [AviacaoCaminhao].[_trackLastWriteTime], [AviacaoCaminhao].[_trackCreationUser], [AviacaoCaminhao].[_trackLastWriteUser] 
    FROM [AviacaoCaminhao]
GO

CREATE VIEW [dbo].[vAviacaoClienteGrupos]
AS
SELECT [AviacaoClienteGrupos].[pId], [AviacaoClienteGrupos].[pGRUPO_CLIENTE], [AviacaoClienteGrupos].[_trackCreationTime], [AviacaoClienteGrupos].[_trackLastWriteTime], [AviacaoClienteGrupos].[_trackCreationUser], [AviacaoClienteGrupos].[_trackLastWriteUser] 
    FROM [AviacaoClienteGrupos]
GO

CREATE VIEW [dbo].[vAviacaoClientes]
AS
SELECT [AviacaoClientes].[pId], [AviacaoClientes].[pCLIENTE], [AviacaoClientes].[pNOME_CLIENTE], [AviacaoClientes].[pCIDADE_CLIENTE], [AviacaoClientes].[pCIDADE_CLIENTE_IBGE], [AviacaoClientes].[pESTADO], [AviacaoClientes].[pREGIAO], [AviacaoClientes].[pENDERECO_CLI], [AviacaoClientes].[pBAIRRO_CLIE], [AviacaoClientes].[_trackCreationTime], [AviacaoClientes].[_trackLastWriteTime], [AviacaoClientes].[_trackCreationUser], [AviacaoClientes].[_trackLastWriteUser] 
    FROM [AviacaoClientes]
GO

CREATE VIEW [dbo].[vAviacaoConhecimentoFrete]
AS
SELECT [AviacaoConhecimentoFrete].[pId], [AviacaoConhecimentoFrete].[pGW1_FILIAL], [AviacaoConhecimentoFrete].[pGW1_EMISDC], [AviacaoConhecimentoFrete].[pGW1_CDTPDC], [AviacaoConhecimentoFrete].[pGV5_DSTPDC], [AviacaoConhecimentoFrete].[pGW1_DTEMIS], [AviacaoConhecimentoFrete].[pGW1_DTEMIS_DIA], [AviacaoConhecimentoFrete].[pGW1_DTEMIS_MES], [AviacaoConhecimentoFrete].[pGW1_DTEMIS_ANO], [AviacaoConhecimentoFrete].[pGW1_SERDC], [AviacaoConhecimentoFrete].[pGW1_NRDC], [AviacaoConhecimentoFrete].[pGW1_CDREM], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_REM], [AviacaoConhecimentoFrete].[pGU3_CDERP_REM], [AviacaoConhecimentoFrete].[pGU3_CDCERP_REM], [AviacaoConhecimentoFrete].[pGW1_CDDEST], [AviacaoConhecimentoFrete].[pGU3_NMEMIT], [AviacaoConhecimentoFrete].[pGU3_CDERP], [AviacaoConhecimentoFrete].[pGU3_CDCERP], [AviacaoConhecimentoFrete].[pGW1_NRROM], [AviacaoConhecimentoFrete].[pGW1_TPFRET], [AviacaoConhecimentoFrete].[pGW1_DTSAI], [AviacaoConhecimentoFrete].[pGW1_DTSAI_DIA], [AviacaoConhecimentoFrete].[pGW1_DTSAI_MES], [AviacaoConhecimentoFrete].[pGW1_DTSAI_ANO], [AviacaoConhecimentoFrete].[pGW1_DSESP], [AviacaoConhecimentoFrete].[pGW1_QTVOL], [AviacaoConhecimentoFrete].[pGW8_SEQ], [AviacaoConhecimentoFrete].[pGW8_ITEM], [AviacaoConhecimentoFrete].[pGW8_DSITEM], [AviacaoConhecimentoFrete].[pGW8_QTDE], [AviacaoConhecimentoFrete].[pGW8_VALOR], [AviacaoConhecimentoFrete].[pGW8_VOLUME], [AviacaoConhecimentoFrete].[pGW8_PESOR], [AviacaoConhecimentoFrete].[pGW8_CFOP], [AviacaoConhecimentoFrete].[pD2_ITEM], [AviacaoConhecimentoFrete].[pD2_COD], [AviacaoConhecimentoFrete].[pD2_DOC], [AviacaoConhecimentoFrete].[pD2_SERIE], [AviacaoConhecimentoFrete].[pD2_QUANT], [AviacaoConhecimentoFrete].[pD2_TOTAL], [AviacaoConhecimentoFrete].[pD2_VALBRUT], [AviacaoConhecimentoFrete].[pGWU_SEQ], [AviacaoConhecimentoFrete].[pGWU_CDTRP], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_TRETRAN], [AviacaoConhecimentoFrete].[pGU3_CDTERP_TRETRAN], [AviacaoConhecimentoFrete].[pGWU_NRCIDD], [AviacaoConhecimentoFrete].[pGU7_NMCID], [AviacaoConhecimentoFrete].[pGU7_CDUF], [AviacaoConhecimentoFrete].[pGWF_NRCALC], [AviacaoConhecimentoFrete].[pGWF_TRANSP], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_CALCTRP], [AviacaoConhecimentoFrete].[pGU3_CDTERP_CALCTRP], [AviacaoConhecimentoFrete].[pGWF_EMIREM], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_CALCREM], [AviacaoConhecimentoFrete].[pGU3_CDERP_CALCREM], [AviacaoConhecimentoFrete].[pGU3_CDCERP_CALCREM], [AviacaoConhecimentoFrete].[pGWF_EMIDES], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_CALCDES], [AviacaoConhecimentoFrete].[pGU3_CDERP_CALCDES], [AviacaoConhecimentoFrete].[pGU3_CDCERP_CALCDES], [AviacaoConhecimentoFrete].[pGWF_EMIRED], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_CALCRED], [AviacaoConhecimentoFrete].[pGU3_CDTERP_CALCRED], [AviacaoConhecimentoFrete].[pGWF_EMIPAG], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_CALCPAG], [AviacaoConhecimentoFrete].[pGU3_CDERP_CALCPAG], [AviacaoConhecimentoFrete].[pGU3_CDCERP_CALCPAG], [AviacaoConhecimentoFrete].[pGWF_TPCALC], [AviacaoConhecimentoFrete].[pGWF_CIDORI], [AviacaoConhecimentoFrete].[pGU7_NMCID_CALCCDORI], [AviacaoConhecimentoFrete].[pGU7_CDUF_CALCCDORI], [AviacaoConhecimentoFrete].[PGWF_CIDDES], [AviacaoConhecimentoFrete].[pGU7_NMCID_CALCCDDES], [AviacaoConhecimentoFrete].[pGU7_CDUF_CALCCDDES], [AviacaoConhecimentoFrete].[pGWF_NRROM], [AviacaoConhecimentoFrete].[pGW3_CDESP], [AviacaoConhecimentoFrete].[pGW3_EMISDF], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_TRANS], [AviacaoConhecimentoFrete].[pGW3_SERDF], [AviacaoConhecimentoFrete].[pGW3_NRDF], [AviacaoConhecimentoFrete].[pGW3_DTEMIS], [AviacaoConhecimentoFrete].[pGW3_DTEMIS_DIA], [AviacaoConhecimentoFrete].[pGW3_DTEMIS_MES], [AviacaoConhecimentoFrete].[pGW3_DTEMIS_ANO], [AviacaoConhecimentoFrete].[pGW3_TPDF], [AviacaoConhecimentoFrete].[pGW3_DTENT], [AviacaoConhecimentoFrete].[pGW3_DTENT_DIA], [AviacaoConhecimentoFrete].[pGW3_DTENT_MES], [AviacaoConhecimentoFrete].[pGW3_DTENT_ANO], [AviacaoConhecimentoFrete].[pGW3_CFOP], [AviacaoConhecimentoFrete].[pGW3_CDREM], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_DFREM], [AviacaoConhecimentoFrete].[pGU3_CDERP_DFREM], [AviacaoConhecimentoFrete].[pGU3_CDCERP_DFREM], [AviacaoConhecimentoFrete].[pGW3_CDDEST], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_DFDES], [AviacaoConhecimentoFrete].[pGU3_CDERP_DFDES], [AviacaoConhecimentoFrete].[pGU3_CDCERP_DFDES], [AviacaoConhecimentoFrete].[pGW3_VLDF], [AviacaoConhecimentoFrete].[pGW3_TAXAS], [AviacaoConhecimentoFrete].[pGW3_PEDAG], [AviacaoConhecimentoFrete].[pGW3_FRPESO], [AviacaoConhecimentoFrete].[pGW3_FRVAL], [AviacaoConhecimentoFrete].[pGW3_PESOR], [AviacaoConhecimentoFrete].[pGW3_VLCARG], [AviacaoConhecimentoFrete].[pGW4_NRDC], [AviacaoConhecimentoFrete].[pGW4_SERDC], [AviacaoConhecimentoFrete].[pGW4_EMISDC], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_DDFEMIS], [AviacaoConhecimentoFrete].[pGU3_CDERP_DDFEMIS], [AviacaoConhecimentoFrete].[pGU3_CDCERP_DDFEMIS], [AviacaoConhecimentoFrete].[pGWN_NRROM], [AviacaoConhecimentoFrete].[pGWN_CDTRP], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_ROMCAR], [AviacaoConhecimentoFrete].[pGU3_CDTERP_ROMCAR], [AviacaoConhecimentoFrete].[pGWN_CDTPOP], [AviacaoConhecimentoFrete].[pGV4_DSTPOP], [AviacaoConhecimentoFrete].[pGWN_CDCLFR], [AviacaoConhecimentoFrete].[pGUB_DSCLFR], [AviacaoConhecimentoFrete].[pGWN_CDTPVC], [AviacaoConhecimentoFrete].[pGWN_CDMTR], [AviacaoConhecimentoFrete].[pGW6_EMIFAT], [AviacaoConhecimentoFrete].[pGU3_NMEMIT_FATFRT], [AviacaoConhecimentoFrete].[pGU3_CDERP_FATFRT], [AviacaoConhecimentoFrete].[pCDCERP_FATFRT], [AviacaoConhecimentoFrete].[pGW6_SERFAT], [AviacaoConhecimentoFrete].[pGW6_NRFAT], [AviacaoConhecimentoFrete].[pGW6_DTEMIS], [AviacaoConhecimentoFrete].[pGW6_DTEMIS_DIA], [AviacaoConhecimentoFrete].[pGW6_DTEMIS_MES], [AviacaoConhecimentoFrete].[pGW6_DTEMIS_ANO], [AviacaoConhecimentoFrete].[pGW6_DTVENC], [AviacaoConhecimentoFrete].[pGW6_DTVENC_DIA], [AviacaoConhecimentoFrete].[pGW6_DTVENC_MES], [AviacaoConhecimentoFrete].[pGW6_DTVENC_ANO], [AviacaoConhecimentoFrete].[pGW6_VLFATU], [AviacaoConhecimentoFrete].[pGW6_VLDESC], [AviacaoConhecimentoFrete].[pGW6_VLJURO], [AviacaoConhecimentoFrete].[pREGIAO_ORIGEM], [AviacaoConhecimentoFrete].[pREGIAO_DESTINO], [AviacaoConhecimentoFrete].[pGWM_VLFRET_RTDCCAR], [AviacaoConhecimentoFrete].[pGWM_VLFRET_RTDCFRT], [AviacaoConhecimentoFrete].[pGWM_VLFRET_RTDCCAR_TOTAL], [AviacaoConhecimentoFrete].[pGWM_VLFRET_RTDCCAR_PERCRATEIO], [AviacaoConhecimentoFrete].[pGW8_VALOR_RATEIO], [AviacaoConhecimentoFrete].[pGW8_VALOR_BRUTO_RATEIO], [AviacaoConhecimentoFrete].[pGW8_QTDE_RATEIO], [AviacaoConhecimentoFrete].[pGW8_VOLUME_RATEIO], [AviacaoConhecimentoFrete].[pGW8_PESOR_RATEIO], [AviacaoConhecimentoFrete].[pGW8_VALOR_TOTAL_NOTA], [AviacaoConhecimentoFrete].[pGW8_VALOR_BRUTO_TOTAL_NOTA], [AviacaoConhecimentoFrete].[pF2_PBRUTO], [AviacaoConhecimentoFrete].[pF2_PLIQUI], [AviacaoConhecimentoFrete].[pGWU_DTENT], [AviacaoConhecimentoFrete].[_trackCreationTime], [AviacaoConhecimentoFrete].[_trackLastWriteTime], [AviacaoConhecimentoFrete].[_trackCreationUser], [AviacaoConhecimentoFrete].[_trackLastWriteUser] 
    FROM [AviacaoConhecimentoFrete]
GO

CREATE VIEW [dbo].[vAviacaoConhecimentoFreteAgrup]
AS
SELECT [AviacaoConhecimentoFreteAgrup].[pId], [AviacaoConhecimentoFreteAgrup].[pGW1_FILIAL], [AviacaoConhecimentoFreteAgrup].[pGW1_EMISDC], [AviacaoConhecimentoFreteAgrup].[pGW1_CDTPDC], [AviacaoConhecimentoFreteAgrup].[pGV5_DSTPDC], [AviacaoConhecimentoFreteAgrup].[pGW1_DTEMIS], [AviacaoConhecimentoFreteAgrup].[pGW1_DTEMIS_DIA], [AviacaoConhecimentoFreteAgrup].[pGW1_DTEMIS_MES], [AviacaoConhecimentoFreteAgrup].[pGW1_DTEMIS_ANO], [AviacaoConhecimentoFreteAgrup].[pGW1_SERDC], [AviacaoConhecimentoFreteAgrup].[pGW1_NRDC], [AviacaoConhecimentoFreteAgrup].[pGW1_CDREM], [AviacaoConhecimentoFreteAgrup].[pGU3_NMEMIT_REM], [AviacaoConhecimentoFreteAgrup].[pGU3_CDERP_REM], [AviacaoConhecimentoFreteAgrup].[pGU3_CDCERP_REM], [AviacaoConhecimentoFreteAgrup].[pGW1_CDDEST], [AviacaoConhecimentoFreteAgrup].[pGU3_NMEMIT], [AviacaoConhecimentoFreteAgrup].[pGU3_CDERP], [AviacaoConhecimentoFreteAgrup].[pGU3_CDCERP], [AviacaoConhecimentoFreteAgrup].[pGW1_NRROM], [AviacaoConhecimentoFreteAgrup].[pGW1_TPFRET], [AviacaoConhecimentoFreteAgrup].[pGW1_DTSAI], [AviacaoConhecimentoFreteAgrup].[pGW1_DTSAI_DIA], [AviacaoConhecimentoFreteAgrup].[pGW1_DTSAI_MES], [AviacaoConhecimentoFreteAgrup].[pGW1_DTSAI_ANO], [AviacaoConhecimentoFreteAgrup].[pGW1_DSESP], [AviacaoConhecimentoFreteAgrup].[pGW3_NRDF], [AviacaoConhecimentoFreteAgrup].[pGW1_QTVOL], [AviacaoConhecimentoFreteAgrup].[pGW8_VALOR_TOTAL_NOTA], [AviacaoConhecimentoFreteAgrup].[pGW8_VALOR_BRUTO_TOTAL_NOTA], [AviacaoConhecimentoFreteAgrup].[pVALOR_TOTAL_NF_FRETE_AGRUPADO], [AviacaoConhecimentoFreteAgrup].[pVALOR_FRETE_TOTAL], [AviacaoConhecimentoFreteAgrup].[pPERC_NF_FRETE_AGRUPADO], [AviacaoConhecimentoFreteAgrup].[pGWM_VLFRET_CFRT_CCAR_NOVOFRETE], [AviacaoConhecimentoFreteAgrup].[pGWM_VLFRET_RTDCCAR_TOTALNRDC], [AviacaoConhecimentoFreteAgrup].[pSTATUS_GFE], [AviacaoConhecimentoFreteAgrup].[pF2_PBRUTO_TOTALNRDC], [AviacaoConhecimentoFreteAgrup].[pF2_PLIQUI_TOTALNRDC], [AviacaoConhecimentoFreteAgrup].[_trackCreationTime], [AviacaoConhecimentoFreteAgrup].[_trackLastWriteTime], [AviacaoConhecimentoFreteAgrup].[_trackCreationUser], [AviacaoConhecimentoFreteAgrup].[_trackLastWriteUser] 
    FROM [AviacaoConhecimentoFreteAgrup]
GO

CREATE VIEW [dbo].[vAviacaoFinanceiro]
AS
SELECT [AviacaoFinanceiro].[pId], [AviacaoFinanceiro].[pFILIAL], [AviacaoFinanceiro].[pNUM], [AviacaoFinanceiro].[pPARCELA], [AviacaoFinanceiro].[pTIPO], [AviacaoFinanceiro].[pCOD_NATUREZA], [AviacaoFinanceiro].[pNATUREZA], [AviacaoFinanceiro].[pPORTADO], [AviacaoFinanceiro].[pLOJA], [AviacaoFinanceiro].[pDATA_EMISSAO], [AviacaoFinanceiro].[pDATA_DIA_EMISSAO], [AviacaoFinanceiro].[pDATA_MES_EMISSAO], [AviacaoFinanceiro].[pDATA_ANO_EMISSAO], [AviacaoFinanceiro].[pVENCREA_DT], [AviacaoFinanceiro].[pVENCREA_DIA], [AviacaoFinanceiro].[pVENCREA_MES], [AviacaoFinanceiro].[pVENCREA_ANO], [AviacaoFinanceiro].[pVENCORI_DT], [AviacaoFinanceiro].[pVENCORI_DIA], [AviacaoFinanceiro].[pVENCORI_MES], [AviacaoFinanceiro].[pVENCORI_ANO], [AviacaoFinanceiro].[pVALOR], [AviacaoFinanceiro].[pHIST], [AviacaoFinanceiro].[pSALDO], [AviacaoFinanceiro].[pFORNECE_CLIENTE], [AviacaoFinanceiro].[pNOMFOR_NOMCLI], [AviacaoFinanceiro].[pAGENCIA_DEPOSITARIA], [AviacaoFinanceiro].[pNRO_PED_VENDA], [AviacaoFinanceiro].[pCENARIO], [AviacaoFinanceiro].[pTIPO_SALDO], [AviacaoFinanceiro].[pORDEM], [AviacaoFinanceiro].[_trackCreationTime], [AviacaoFinanceiro].[_trackLastWriteTime], [AviacaoFinanceiro].[_trackCreationUser], [AviacaoFinanceiro].[_trackLastWriteUser] 
    FROM [AviacaoFinanceiro]
GO

CREATE VIEW [dbo].[vAviacaoLocalLinha]
AS
SELECT [AviacaoLocalLinha].[pId], [AviacaoLocalLinha].[pCODIGO], [AviacaoLocalLinha].[pDESCRICAO], [AviacaoLocalLinha].[_trackCreationTime], [AviacaoLocalLinha].[_trackLastWriteTime], [AviacaoLocalLinha].[_trackCreationUser], [AviacaoLocalLinha].[_trackLastWriteUser] 
    FROM [AviacaoLocalLinha]
GO

CREATE VIEW [dbo].[vAviacaoLocalLinhaAviacaoLocalLinhaViewGrid]
AS
SELECT [AviacaoLocalLinha].[pId], [AviacaoLocalLinha].[pCODIGO], [AviacaoLocalLinha].[pDESCRICAO], [AviacaoLocalLinha].[_trackCreationTime], [AviacaoLocalLinha].[_trackLastWriteTime], [AviacaoLocalLinha].[_trackCreationUser], [AviacaoLocalLinha].[_trackLastWriteUser] 
    FROM [AviacaoLocalLinha]
GO

CREATE VIEW [dbo].[vAviacaoMotorista]
AS
SELECT [AviacaoMotorista].[pId], [AviacaoMotorista].[pCOD_MOTORISTA], [AviacaoMotorista].[pNOME_MOTORISTA], [AviacaoMotorista].[sStatus], [AviacaoMotorista].[_trackCreationTime], [AviacaoMotorista].[_trackLastWriteTime], [AviacaoMotorista].[_trackCreationUser], [AviacaoMotorista].[_trackLastWriteUser] 
    FROM [AviacaoMotorista]
GO

CREATE VIEW [dbo].[vAviacaoMotoristaAviacaoMotoristaViewGrid]
AS
SELECT [AviacaoMotorista].[pId], [AviacaoMotorista].[pCOD_MOTORISTA], [AviacaoMotorista].[pNOME_MOTORISTA], [AviacaoMotorista].[sStatus], [AviacaoMotorista].[_trackCreationTime], [AviacaoMotorista].[_trackLastWriteTime], [AviacaoMotorista].[_trackCreationUser], [AviacaoMotorista].[_trackLastWriteUser] 
    FROM [AviacaoMotorista]
GO

CREATE VIEW [dbo].[vAviacaoPedidosFaturamento]
AS
SELECT [AviacaoPedidosFaturamento].[pId], [AviacaoPedidosFaturamento].[pTIPO_OP], [AviacaoPedidosFaturamento].[pFILIAL], [AviacaoPedidosFaturamento].[pPEDIDO], [AviacaoPedidosFaturamento].[pNOTA_FISCAL], [AviacaoPedidosFaturamento].[pSERIE_NF], [AviacaoPedidosFaturamento].[pCOD_CLIENTE], [AviacaoPedidosFaturamento].[pUF_CLIENTE], [AviacaoPedidosFaturamento].[pREGIAO], [AviacaoPedidosFaturamento].[pLOJA], [AviacaoPedidosFaturamento].[pDESC_CLIENTE], [AviacaoPedidosFaturamento].[pCOD_VENDEDOR], [AviacaoPedidosFaturamento].[pNOME_VENDEDOR], [AviacaoPedidosFaturamento].[pDT_EMISSAO], [AviacaoPedidosFaturamento].[pCOD_GRUPO_CLIENTE], [AviacaoPedidosFaturamento].[pDESC_GRUPO_CLIENTE], [AviacaoPedidosFaturamento].[pCODIGO_PRODUTO], [AviacaoPedidosFaturamento].[pDESC_PRODUTO], [AviacaoPedidosFaturamento].[pB1_PESBRU], [AviacaoPedidosFaturamento].[pBM_DESC], [AviacaoPedidosFaturamento].[pQUANT_UNIDADE], [AviacaoPedidosFaturamento].[pPRECO_VENDA], [AviacaoPedidosFaturamento].[pQUANT_CAIXA], [AviacaoPedidosFaturamento].[pQTDPCT], [AviacaoPedidosFaturamento].[pQTDBRU], [AviacaoPedidosFaturamento].[pNUMERO_ORCAMENTO], [AviacaoPedidosFaturamento].[pFORMAS], [AviacaoPedidosFaturamento].[pTOTAL_ITEM], [AviacaoPedidosFaturamento].[pPEDCLI], [AviacaoPedidosFaturamento].[pPRUNIT], [AviacaoPedidosFaturamento].[pDT_EMISSAO_PED], [AviacaoPedidosFaturamento].[pDT_EMISSAO_FAT], [AviacaoPedidosFaturamento].[pDIAS_PEDIDO], [AviacaoPedidosFaturamento].[pSTATUS], [AviacaoPedidosFaturamento].[pDTDIA_EMISSAO_PED], [AviacaoPedidosFaturamento].[pDTMES_EMISSAO_PED], [AviacaoPedidosFaturamento].[pDTANO_EMISSAO_PED], [AviacaoPedidosFaturamento].[pDTDIA_EMISSAO_FAT], [AviacaoPedidosFaturamento].[pDTMES_EMISSAO_FAT], [AviacaoPedidosFaturamento].[pDTANO_EMISSAO_FAT], [AviacaoPedidosFaturamento].[_trackCreationTime], [AviacaoPedidosFaturamento].[_trackLastWriteTime], [AviacaoPedidosFaturamento].[_trackCreationUser], [AviacaoPedidosFaturamento].[_trackLastWriteUser] 
    FROM [AviacaoPedidosFaturamento]
GO

CREATE VIEW [dbo].[vAviacaoPivotAnalise]
AS
SELECT [AviacaoPivotAnalise].[pId], [AviacaoPivotAnalise].[pDescricao], [AviacaoPivotAnalise].[oUsuario_pId], [AviacaoPivotAnalise].[pModeloAnaliseXml], [AviacaoPivotAnalise].[pLayoutVersion], [AviacaoPivotAnalise].[pPivotNome], [AviacaoPivotAnalise].[pPastaNome], [AviacaoPivotAnalise].[pFlgCompartilhada], [AviacaoPivotAnalise].[pModeloAnaliseByte], [AviacaoPivotAnalise].[_trackCreationTime], [AviacaoPivotAnalise].[_trackLastWriteTime], [AviacaoPivotAnalise].[_trackCreationUser], [AviacaoPivotAnalise].[_trackLastWriteUser] 
    FROM [AviacaoPivotAnalise]
GO

CREATE VIEW [dbo].[vAviacaoPivotAnaliseAviacaoPivotAnaliseViewGrid]
AS
SELECT [AviacaoPivotAnalise].[pId], [AviacaoPivotAnalise].[pDescricao], [AviacaoPivotAnalise].[pModeloAnaliseXml], [AviacaoPivotAnalise].[pLayoutVersion], [AviacaoPivotAnalise].[pPivotNome], [AviacaoPivotAnalise].[pPastaNome], [AviacaoPivotAnalise].[pFlgCompartilhada], [AviacaoPivotAnalise].[pModeloAnaliseByte], [usuario].[pLogin] AS 'pUsuarioLogin', [AviacaoPivotAnalise].[_trackCreationTime], [AviacaoPivotAnalise].[_trackLastWriteTime], [AviacaoPivotAnalise].[_trackCreationUser], [AviacaoPivotAnalise].[_trackLastWriteUser] 
    FROM [AviacaoPivotAnalise]
        LEFT OUTER JOIN [usuario] ON ([AviacaoPivotAnalise].[oUsuario_pId] = [usuario].[pId])
GO

CREATE VIEW [dbo].[vAviacaoProdutoGrupos]
AS
SELECT [AviacaoProdutoGrupos].[pId], [AviacaoProdutoGrupos].[pGRUPO_PRODUTO], [AviacaoProdutoGrupos].[_trackCreationTime], [AviacaoProdutoGrupos].[_trackLastWriteTime], [AviacaoProdutoGrupos].[_trackCreationUser], [AviacaoProdutoGrupos].[_trackLastWriteUser] 
    FROM [AviacaoProdutoGrupos]
GO

CREATE VIEW [dbo].[vAviacaoProdutos]
AS
SELECT [AviacaoProdutos].[pId], [AviacaoProdutos].[pPRODUTO], [AviacaoProdutos].[pDESCRICAO], [AviacaoProdutos].[_trackCreationTime], [AviacaoProdutos].[_trackLastWriteTime], [AviacaoProdutos].[_trackCreationUser], [AviacaoProdutos].[_trackLastWriteUser] 
    FROM [AviacaoProdutos]
GO

CREATE VIEW [dbo].[vAviacaoRedespachos]
AS
SELECT [AviacaoRedespachos].[pId], [AviacaoRedespachos].[pREDESPACHO], [AviacaoRedespachos].[pNOME_REDESPACHO], [AviacaoRedespachos].[_trackCreationTime], [AviacaoRedespachos].[_trackLastWriteTime], [AviacaoRedespachos].[_trackCreationUser], [AviacaoRedespachos].[_trackLastWriteUser] 
    FROM [AviacaoRedespachos]
GO

CREATE VIEW [dbo].[vAviacaoTitulosClientes]
AS
SELECT [AviacaoTitulosClientes].[pId], [AviacaoTitulosClientes].[pCODIGO], [AviacaoTitulosClientes].[pNOME], [AviacaoTitulosClientes].[_trackCreationTime], [AviacaoTitulosClientes].[_trackLastWriteTime], [AviacaoTitulosClientes].[_trackCreationUser], [AviacaoTitulosClientes].[_trackLastWriteUser] 
    FROM [AviacaoTitulosClientes]
GO

CREATE VIEW [dbo].[vAviacaoTransportadores]
AS
SELECT [AviacaoTransportadores].[pId], [AviacaoTransportadores].[pCODIGO_TRANSP], [AviacaoTransportadores].[pNOME_TRANSP], [AviacaoTransportadores].[_trackCreationTime], [AviacaoTransportadores].[_trackLastWriteTime], [AviacaoTransportadores].[_trackCreationUser], [AviacaoTransportadores].[_trackLastWriteUser] 
    FROM [AviacaoTransportadores]
GO

CREATE VIEW [dbo].[vAviacaoVendas]
AS
SELECT [AviacaoVendas].[pId], [AviacaoVendas].[pNUMERO_NF], [AviacaoVendas].[pSERIE], [AviacaoVendas].[pCLIENTE], [AviacaoVendas].[pFILIAL], [AviacaoVendas].[pLOJA], [AviacaoVendas].[pNOME_CLIENTE], [AviacaoVendas].[pCIDADE_CLIENTE], [AviacaoVendas].[pCIDADE_CLIENTE_IBGE], [AviacaoVendas].[pESTADO], [AviacaoVendas].[pREGIAO], [AviacaoVendas].[pPERCENT_DESCONTO], [AviacaoVendas].[pPORCENT_COMISSAO], [AviacaoVendas].[pCODIGO_VENDEDOR], [AviacaoVendas].[pNOME_VENDEDOR], [AviacaoVendas].[pCIDADE_VENDEDOR], [AviacaoVendas].[pVALOR_COMISSAO], [AviacaoVendas].[pDATA_EMISSAO], [AviacaoVendas].[pDIA_EMISSAO], [AviacaoVendas].[pMES_EMISSAO], [AviacaoVendas].[pMES_EXTENSO], [AviacaoVendas].[pANO_EMISSAO], [AviacaoVendas].[pTRIMESTRE], [AviacaoVendas].[pCODIGO_TRANSP], [AviacaoVendas].[pNOME_TRANSP], [AviacaoVendas].[pREDESPACHO], [AviacaoVendas].[pNOME_REDESPACHO], [AviacaoVendas].[pPRODUTO], [AviacaoVendas].[pGRUPO_PRODUTO], [AviacaoVendas].[pPESO_PRODUTO], [AviacaoVendas].[pQTD_P_CAIXA], [AviacaoVendas].[pQTD_EM_CAIXA], [AviacaoVendas].[pPESO_TOTAL], [AviacaoVendas].[pPESO_BRUTO], [AviacaoVendas].[pDESCRICAO], [AviacaoVendas].[pQUANTIDADE], [AviacaoVendas].[pPRECO_TABELA], [AviacaoVendas].[pVLR_TOTAL_PRODUTO], [AviacaoVendas].[pPRECO_DE_VENDA], [AviacaoVendas].[pVLR_DESCONTO], [AviacaoVendas].[pVLR_BASE_ICM], [AviacaoVendas].[pVLR_TOTAL_NOTA], [AviacaoVendas].[pVLR_SEM_ICMSST], [AviacaoVendas].[pVLR_ICM], [AviacaoVendas].[pVLR_COFINS], [AviacaoVendas].[pVLR_PIS], [AviacaoVendas].[pPRECO_FORA_IMPOSTO], [AviacaoVendas].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendas].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendas].[pB1_QE], [AviacaoVendas].[pB1_CONV], [AviacaoVendas].[pPLACA], [AviacaoVendas].[pCFOP], [AviacaoVendas].[pMARCA], [AviacaoVendas].[pGRUPO_CLIENTE], [AviacaoVendas].[pDT_ENTRADA], [AviacaoVendas].[pDIA_ENTRADA], [AviacaoVendas].[pMES_ENTRADA], [AviacaoVendas].[pANO_ENTRADA], [AviacaoVendas].[pDESCON_FINAN], [AviacaoVendas].[pVALOR_DESC_FINAN], [AviacaoVendas].[pCUSTO_PRODUTO], [AviacaoVendas].[pCUSTO_PROD_QTD], [AviacaoVendas].[pNRO_PEDIDO_CLIENTE], [AviacaoVendas].[pPEDIDO], [AviacaoVendas].[pENDERECO_CLI], [AviacaoVendas].[pBAIRRO_CLIE], [AviacaoVendas].[pULTIMA_COMPRA], [AviacaoVendas].[_trackCreationTime], [AviacaoVendas].[_trackLastWriteTime], [AviacaoVendas].[_trackCreationUser], [AviacaoVendas].[_trackLastWriteUser] 
    FROM [AviacaoVendas]
GO

CREATE VIEW [dbo].[vAviacaoVendas3Meses]
AS
SELECT [AviacaoVendas3Meses].[pId], [AviacaoVendas3Meses].[pNUMERO_NF], [AviacaoVendas3Meses].[pSERIE], [AviacaoVendas3Meses].[pCLIENTE], [AviacaoVendas3Meses].[pFILIAL], [AviacaoVendas3Meses].[pLOJA], [AviacaoVendas3Meses].[pNOME_CLIENTE], [AviacaoVendas3Meses].[pCIDADE_CLIENTE], [AviacaoVendas3Meses].[pCIDADE_CLIENTE_IBGE], [AviacaoVendas3Meses].[pESTADO], [AviacaoVendas3Meses].[pREGIAO], [AviacaoVendas3Meses].[pPERCENT_DESCONTO], [AviacaoVendas3Meses].[pPORCENT_COMISSAO], [AviacaoVendas3Meses].[pCODIGO_VENDEDOR], [AviacaoVendas3Meses].[pNOME_VENDEDOR], [AviacaoVendas3Meses].[pCIDADE_VENDEDOR], [AviacaoVendas3Meses].[pVALOR_COMISSAO], [AviacaoVendas3Meses].[pDATA_EMISSAO], [AviacaoVendas3Meses].[pDIA_EMISSAO], [AviacaoVendas3Meses].[pMES_EMISSAO], [AviacaoVendas3Meses].[pMES_EXTENSO], [AviacaoVendas3Meses].[pANO_EMISSAO], [AviacaoVendas3Meses].[pTRIMESTRE], [AviacaoVendas3Meses].[pCODIGO_TRANSP], [AviacaoVendas3Meses].[pNOME_TRANSP], [AviacaoVendas3Meses].[pREDESPACHO], [AviacaoVendas3Meses].[pNOME_REDESPACHO], [AviacaoVendas3Meses].[pPRODUTO], [AviacaoVendas3Meses].[pGRUPO_PRODUTO], [AviacaoVendas3Meses].[pPESO_PRODUTO], [AviacaoVendas3Meses].[pQTD_P_CAIXA], [AviacaoVendas3Meses].[pQTD_EM_CAIXA], [AviacaoVendas3Meses].[pPESO_TOTAL], [AviacaoVendas3Meses].[pPESO_BRUTO], [AviacaoVendas3Meses].[pDESCRICAO], [AviacaoVendas3Meses].[pQUANTIDADE], [AviacaoVendas3Meses].[pPRECO_TABELA], [AviacaoVendas3Meses].[pVLR_TOTAL_PRODUTO], [AviacaoVendas3Meses].[pPRECO_DE_VENDA], [AviacaoVendas3Meses].[pVLR_DESCONTO], [AviacaoVendas3Meses].[pVLR_BASE_ICM], [AviacaoVendas3Meses].[pVLR_TOTAL_NOTA], [AviacaoVendas3Meses].[pVLR_SEM_ICMSST], [AviacaoVendas3Meses].[pVLR_ICM], [AviacaoVendas3Meses].[pVLR_COFINS], [AviacaoVendas3Meses].[pVLR_PIS], [AviacaoVendas3Meses].[pPRECO_FORA_IMPOSTO], [AviacaoVendas3Meses].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendas3Meses].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendas3Meses].[pB1_QE], [AviacaoVendas3Meses].[pB1_CONV], [AviacaoVendas3Meses].[pPLACA], [AviacaoVendas3Meses].[pCFOP], [AviacaoVendas3Meses].[pMARCA], [AviacaoVendas3Meses].[pGRUPO_CLIENTE], [AviacaoVendas3Meses].[pDT_ENTRADA], [AviacaoVendas3Meses].[pDIA_ENTRADA], [AviacaoVendas3Meses].[pMES_ENTRADA], [AviacaoVendas3Meses].[pANO_ENTRADA], [AviacaoVendas3Meses].[pDESCON_FINAN], [AviacaoVendas3Meses].[pCUSTO_PRODUTO], [AviacaoVendas3Meses].[pCUSTO_PROD_QTD], [AviacaoVendas3Meses].[pNRO_PEDIDO_CLIENTE], [AviacaoVendas3Meses].[pPEDIDO], [AviacaoVendas3Meses].[pENDERECO_CLI], [AviacaoVendas3Meses].[pBAIRRO_CLIE], [AviacaoVendas3Meses].[pULTIMA_COMPRA], [AviacaoVendas3Meses].[_trackCreationTime], [AviacaoVendas3Meses].[_trackLastWriteTime], [AviacaoVendas3Meses].[_trackCreationUser], [AviacaoVendas3Meses].[_trackLastWriteUser] 
    FROM [AviacaoVendas3Meses]
GO

CREATE VIEW [dbo].[vAviacaoVendas3MesesAnoMenos1]
AS
SELECT [AviacaoVendas3MesesAnoMenos1].[pId], [AviacaoVendas3MesesAnoMenos1].[pNUMERO_NF], [AviacaoVendas3MesesAnoMenos1].[pSERIE], [AviacaoVendas3MesesAnoMenos1].[pCLIENTE], [AviacaoVendas3MesesAnoMenos1].[pFILIAL], [AviacaoVendas3MesesAnoMenos1].[pLOJA], [AviacaoVendas3MesesAnoMenos1].[pNOME_CLIENTE], [AviacaoVendas3MesesAnoMenos1].[pCIDADE_CLIENTE], [AviacaoVendas3MesesAnoMenos1].[pCIDADE_CLIENTE_IBGE], [AviacaoVendas3MesesAnoMenos1].[pESTADO], [AviacaoVendas3MesesAnoMenos1].[pREGIAO], [AviacaoVendas3MesesAnoMenos1].[pPERCENT_DESCONTO], [AviacaoVendas3MesesAnoMenos1].[pPORCENT_COMISSAO], [AviacaoVendas3MesesAnoMenos1].[pCODIGO_VENDEDOR], [AviacaoVendas3MesesAnoMenos1].[pNOME_VENDEDOR], [AviacaoVendas3MesesAnoMenos1].[pCIDADE_VENDEDOR], [AviacaoVendas3MesesAnoMenos1].[pVALOR_COMISSAO], [AviacaoVendas3MesesAnoMenos1].[pDATA_EMISSAO], [AviacaoVendas3MesesAnoMenos1].[pDIA_EMISSAO], [AviacaoVendas3MesesAnoMenos1].[pMES_EMISSAO], [AviacaoVendas3MesesAnoMenos1].[pMES_EXTENSO], [AviacaoVendas3MesesAnoMenos1].[pANO_EMISSAO], [AviacaoVendas3MesesAnoMenos1].[pTRIMESTRE], [AviacaoVendas3MesesAnoMenos1].[pCODIGO_TRANSP], [AviacaoVendas3MesesAnoMenos1].[pNOME_TRANSP], [AviacaoVendas3MesesAnoMenos1].[pREDESPACHO], [AviacaoVendas3MesesAnoMenos1].[pNOME_REDESPACHO], [AviacaoVendas3MesesAnoMenos1].[pPRODUTO], [AviacaoVendas3MesesAnoMenos1].[pGRUPO_PRODUTO], [AviacaoVendas3MesesAnoMenos1].[pPESO_PRODUTO], [AviacaoVendas3MesesAnoMenos1].[pQTD_P_CAIXA], [AviacaoVendas3MesesAnoMenos1].[pQTD_EM_CAIXA], [AviacaoVendas3MesesAnoMenos1].[pPESO_TOTAL], [AviacaoVendas3MesesAnoMenos1].[pPESO_BRUTO], [AviacaoVendas3MesesAnoMenos1].[pDESCRICAO], [AviacaoVendas3MesesAnoMenos1].[pQUANTIDADE], [AviacaoVendas3MesesAnoMenos1].[pPRECO_TABELA], [AviacaoVendas3MesesAnoMenos1].[pVLR_TOTAL_PRODUTO], [AviacaoVendas3MesesAnoMenos1].[pPRECO_DE_VENDA], [AviacaoVendas3MesesAnoMenos1].[pVLR_DESCONTO], [AviacaoVendas3MesesAnoMenos1].[pVLR_BASE_ICM], [AviacaoVendas3MesesAnoMenos1].[pVLR_TOTAL_NOTA], [AviacaoVendas3MesesAnoMenos1].[pVLR_SEM_ICMSST], [AviacaoVendas3MesesAnoMenos1].[pVLR_ICM], [AviacaoVendas3MesesAnoMenos1].[pVLR_COFINS], [AviacaoVendas3MesesAnoMenos1].[pVLR_PIS], [AviacaoVendas3MesesAnoMenos1].[pPRECO_FORA_IMPOSTO], [AviacaoVendas3MesesAnoMenos1].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendas3MesesAnoMenos1].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendas3MesesAnoMenos1].[pB1_QE], [AviacaoVendas3MesesAnoMenos1].[pB1_CONV], [AviacaoVendas3MesesAnoMenos1].[pPLACA], [AviacaoVendas3MesesAnoMenos1].[pCFOP], [AviacaoVendas3MesesAnoMenos1].[pMARCA], [AviacaoVendas3MesesAnoMenos1].[pGRUPO_CLIENTE], [AviacaoVendas3MesesAnoMenos1].[pDT_ENTRADA], [AviacaoVendas3MesesAnoMenos1].[pDIA_ENTRADA], [AviacaoVendas3MesesAnoMenos1].[pMES_ENTRADA], [AviacaoVendas3MesesAnoMenos1].[pANO_ENTRADA], [AviacaoVendas3MesesAnoMenos1].[pDESCON_FINAN], [AviacaoVendas3MesesAnoMenos1].[pCUSTO_PRODUTO], [AviacaoVendas3MesesAnoMenos1].[pCUSTO_PROD_QTD], [AviacaoVendas3MesesAnoMenos1].[pNRO_PEDIDO_CLIENTE], [AviacaoVendas3MesesAnoMenos1].[pPEDIDO], [AviacaoVendas3MesesAnoMenos1].[pENDERECO_CLI], [AviacaoVendas3MesesAnoMenos1].[pBAIRRO_CLIE], [AviacaoVendas3MesesAnoMenos1].[pULTIMA_COMPRA], [AviacaoVendas3MesesAnoMenos1].[_trackCreationTime], [AviacaoVendas3MesesAnoMenos1].[_trackLastWriteTime], [AviacaoVendas3MesesAnoMenos1].[_trackCreationUser], [AviacaoVendas3MesesAnoMenos1].[_trackLastWriteUser] 
    FROM [AviacaoVendas3MesesAnoMenos1]
GO

CREATE VIEW [dbo].[vAviacaoVendas3MesesAnoMenos2]
AS
SELECT [AviacaoVendas3MesesAnoMenos2].[pId], [AviacaoVendas3MesesAnoMenos2].[pNUMERO_NF], [AviacaoVendas3MesesAnoMenos2].[pSERIE], [AviacaoVendas3MesesAnoMenos2].[pCLIENTE], [AviacaoVendas3MesesAnoMenos2].[pFILIAL], [AviacaoVendas3MesesAnoMenos2].[pLOJA], [AviacaoVendas3MesesAnoMenos2].[pNOME_CLIENTE], [AviacaoVendas3MesesAnoMenos2].[pCIDADE_CLIENTE], [AviacaoVendas3MesesAnoMenos2].[pCIDADE_CLIENTE_IBGE], [AviacaoVendas3MesesAnoMenos2].[pESTADO], [AviacaoVendas3MesesAnoMenos2].[pREGIAO], [AviacaoVendas3MesesAnoMenos2].[pPERCENT_DESCONTO], [AviacaoVendas3MesesAnoMenos2].[pPORCENT_COMISSAO], [AviacaoVendas3MesesAnoMenos2].[pCODIGO_VENDEDOR], [AviacaoVendas3MesesAnoMenos2].[pNOME_VENDEDOR], [AviacaoVendas3MesesAnoMenos2].[pCIDADE_VENDEDOR], [AviacaoVendas3MesesAnoMenos2].[pVALOR_COMISSAO], [AviacaoVendas3MesesAnoMenos2].[pDATA_EMISSAO], [AviacaoVendas3MesesAnoMenos2].[pDIA_EMISSAO], [AviacaoVendas3MesesAnoMenos2].[pMES_EMISSAO], [AviacaoVendas3MesesAnoMenos2].[pMES_EXTENSO], [AviacaoVendas3MesesAnoMenos2].[pANO_EMISSAO], [AviacaoVendas3MesesAnoMenos2].[pTRIMESTRE], [AviacaoVendas3MesesAnoMenos2].[pCODIGO_TRANSP], [AviacaoVendas3MesesAnoMenos2].[pNOME_TRANSP], [AviacaoVendas3MesesAnoMenos2].[pREDESPACHO], [AviacaoVendas3MesesAnoMenos2].[pNOME_REDESPACHO], [AviacaoVendas3MesesAnoMenos2].[pPRODUTO], [AviacaoVendas3MesesAnoMenos2].[pGRUPO_PRODUTO], [AviacaoVendas3MesesAnoMenos2].[pPESO_PRODUTO], [AviacaoVendas3MesesAnoMenos2].[pQTD_P_CAIXA], [AviacaoVendas3MesesAnoMenos2].[pQTD_EM_CAIXA], [AviacaoVendas3MesesAnoMenos2].[pPESO_TOTAL], [AviacaoVendas3MesesAnoMenos2].[pPESO_BRUTO], [AviacaoVendas3MesesAnoMenos2].[pDESCRICAO], [AviacaoVendas3MesesAnoMenos2].[pQUANTIDADE], [AviacaoVendas3MesesAnoMenos2].[pPRECO_TABELA], [AviacaoVendas3MesesAnoMenos2].[pVLR_TOTAL_PRODUTO], [AviacaoVendas3MesesAnoMenos2].[pPRECO_DE_VENDA], [AviacaoVendas3MesesAnoMenos2].[pVLR_DESCONTO], [AviacaoVendas3MesesAnoMenos2].[pVLR_BASE_ICM], [AviacaoVendas3MesesAnoMenos2].[pVLR_TOTAL_NOTA], [AviacaoVendas3MesesAnoMenos2].[pVLR_SEM_ICMSST], [AviacaoVendas3MesesAnoMenos2].[pVLR_ICM], [AviacaoVendas3MesesAnoMenos2].[pVLR_COFINS], [AviacaoVendas3MesesAnoMenos2].[pVLR_PIS], [AviacaoVendas3MesesAnoMenos2].[pPRECO_FORA_IMPOSTO], [AviacaoVendas3MesesAnoMenos2].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendas3MesesAnoMenos2].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendas3MesesAnoMenos2].[pB1_QE], [AviacaoVendas3MesesAnoMenos2].[pB1_CONV], [AviacaoVendas3MesesAnoMenos2].[pPLACA], [AviacaoVendas3MesesAnoMenos2].[pCFOP], [AviacaoVendas3MesesAnoMenos2].[pMARCA], [AviacaoVendas3MesesAnoMenos2].[pGRUPO_CLIENTE], [AviacaoVendas3MesesAnoMenos2].[pDT_ENTRADA], [AviacaoVendas3MesesAnoMenos2].[pDIA_ENTRADA], [AviacaoVendas3MesesAnoMenos2].[pMES_ENTRADA], [AviacaoVendas3MesesAnoMenos2].[pANO_ENTRADA], [AviacaoVendas3MesesAnoMenos2].[pDESCON_FINAN], [AviacaoVendas3MesesAnoMenos2].[pCUSTO_PRODUTO], [AviacaoVendas3MesesAnoMenos2].[pCUSTO_PROD_QTD], [AviacaoVendas3MesesAnoMenos2].[pNRO_PEDIDO_CLIENTE], [AviacaoVendas3MesesAnoMenos2].[pPEDIDO], [AviacaoVendas3MesesAnoMenos2].[pENDERECO_CLI], [AviacaoVendas3MesesAnoMenos2].[pBAIRRO_CLIE], [AviacaoVendas3MesesAnoMenos2].[pULTIMA_COMPRA], [AviacaoVendas3MesesAnoMenos2].[_trackCreationTime], [AviacaoVendas3MesesAnoMenos2].[_trackLastWriteTime], [AviacaoVendas3MesesAnoMenos2].[_trackCreationUser], [AviacaoVendas3MesesAnoMenos2].[_trackLastWriteUser] 
    FROM [AviacaoVendas3MesesAnoMenos2]
GO

CREATE VIEW [dbo].[vAviacaoVendasAgrup]
AS
SELECT [AviacaoVendasAgrup].[pId], [AviacaoVendasAgrup].[pCLIENTE], [AviacaoVendasAgrup].[pFILIAL], [AviacaoVendasAgrup].[pLOJA], [AviacaoVendasAgrup].[pNOME_CLIENTE], [AviacaoVendasAgrup].[pCIDADE_CLIENTE], [AviacaoVendasAgrup].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasAgrup].[pESTADO], [AviacaoVendasAgrup].[pREGIAO], [AviacaoVendasAgrup].[pCODIGO_VENDEDOR], [AviacaoVendasAgrup].[pNOME_VENDEDOR], [AviacaoVendasAgrup].[pVALOR_COMISSAO], [AviacaoVendasAgrup].[pDATA_EMISSAO], [AviacaoVendasAgrup].[pTRIMESTRE], [AviacaoVendasAgrup].[pPRODUTO], [AviacaoVendasAgrup].[pGRUPO_PRODUTO], [AviacaoVendasAgrup].[pPESO_PRODUTO], [AviacaoVendasAgrup].[pQTD_P_CAIXA], [AviacaoVendasAgrup].[pQTD_EM_CAIXA], [AviacaoVendasAgrup].[pPESO_TOTAL], [AviacaoVendasAgrup].[pPESO_BRUTO], [AviacaoVendasAgrup].[pDESCRICAO], [AviacaoVendasAgrup].[pQUANTIDADE], [AviacaoVendasAgrup].[pPRECO_TABELA], [AviacaoVendasAgrup].[pVLR_TOTAL_PRODUTO], [AviacaoVendasAgrup].[pPRECO_DE_VENDA], [AviacaoVendasAgrup].[pVLR_DESCONTO], [AviacaoVendasAgrup].[pVLR_BASE_ICM], [AviacaoVendasAgrup].[pVLR_TOTAL_NOTA], [AviacaoVendasAgrup].[pVLR_SEM_ICMSST], [AviacaoVendasAgrup].[pVLR_ICM], [AviacaoVendasAgrup].[pVLR_COFINS], [AviacaoVendasAgrup].[pVLR_PIS], [AviacaoVendasAgrup].[pPRECO_FORA_IMPOSTO], [AviacaoVendasAgrup].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasAgrup].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasAgrup].[pCFOP], [AviacaoVendasAgrup].[pDESCON_FINAN], [AviacaoVendasAgrup].[pVALOR_DESC_FINAN], [AviacaoVendasAgrup].[pCUSTO_PRODUTO], [AviacaoVendasAgrup].[pCUSTO_PROD_QTD], [AviacaoVendasAgrup].[pANO_EMISSAO], [AviacaoVendasAgrup].[pMES_EMISSAO], [AviacaoVendasAgrup].[_trackCreationTime], [AviacaoVendasAgrup].[_trackLastWriteTime], [AviacaoVendasAgrup].[_trackCreationUser], [AviacaoVendasAgrup].[_trackLastWriteUser] 
    FROM [AviacaoVendasAgrup]
GO

CREATE VIEW [dbo].[vAviacaoVendasAgrupAnoMenos1]
AS
SELECT [AviacaoVendasAgrupAnoMenos1].[pId], [AviacaoVendasAgrupAnoMenos1].[pCLIENTE], [AviacaoVendasAgrupAnoMenos1].[pFILIAL], [AviacaoVendasAgrupAnoMenos1].[pLOJA], [AviacaoVendasAgrupAnoMenos1].[pNOME_CLIENTE], [AviacaoVendasAgrupAnoMenos1].[pCIDADE_CLIENTE], [AviacaoVendasAgrupAnoMenos1].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasAgrupAnoMenos1].[pESTADO], [AviacaoVendasAgrupAnoMenos1].[pREGIAO], [AviacaoVendasAgrupAnoMenos1].[pCODIGO_VENDEDOR], [AviacaoVendasAgrupAnoMenos1].[pNOME_VENDEDOR], [AviacaoVendasAgrupAnoMenos1].[pVALOR_COMISSAO], [AviacaoVendasAgrupAnoMenos1].[pDATA_EMISSAO], [AviacaoVendasAgrupAnoMenos1].[pTRIMESTRE], [AviacaoVendasAgrupAnoMenos1].[pPRODUTO], [AviacaoVendasAgrupAnoMenos1].[pGRUPO_PRODUTO], [AviacaoVendasAgrupAnoMenos1].[pPESO_PRODUTO], [AviacaoVendasAgrupAnoMenos1].[pQTD_P_CAIXA], [AviacaoVendasAgrupAnoMenos1].[pQTD_EM_CAIXA], [AviacaoVendasAgrupAnoMenos1].[pPESO_TOTAL], [AviacaoVendasAgrupAnoMenos1].[pPESO_BRUTO], [AviacaoVendasAgrupAnoMenos1].[pDESCRICAO], [AviacaoVendasAgrupAnoMenos1].[pQUANTIDADE], [AviacaoVendasAgrupAnoMenos1].[pPRECO_TABELA], [AviacaoVendasAgrupAnoMenos1].[pVLR_TOTAL_PRODUTO], [AviacaoVendasAgrupAnoMenos1].[pPRECO_DE_VENDA], [AviacaoVendasAgrupAnoMenos1].[pVLR_DESCONTO], [AviacaoVendasAgrupAnoMenos1].[pVLR_BASE_ICM], [AviacaoVendasAgrupAnoMenos1].[pVLR_TOTAL_NOTA], [AviacaoVendasAgrupAnoMenos1].[pVLR_SEM_ICMSST], [AviacaoVendasAgrupAnoMenos1].[pVLR_ICM], [AviacaoVendasAgrupAnoMenos1].[pVLR_COFINS], [AviacaoVendasAgrupAnoMenos1].[pVLR_PIS], [AviacaoVendasAgrupAnoMenos1].[pPRECO_FORA_IMPOSTO], [AviacaoVendasAgrupAnoMenos1].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasAgrupAnoMenos1].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasAgrupAnoMenos1].[pCFOP], [AviacaoVendasAgrupAnoMenos1].[pDESCON_FINAN], [AviacaoVendasAgrupAnoMenos1].[pCUSTO_PRODUTO], [AviacaoVendasAgrupAnoMenos1].[pCUSTO_PROD_QTD], [AviacaoVendasAgrupAnoMenos1].[pANO_EMISSAO], [AviacaoVendasAgrupAnoMenos1].[pMES_EMISSAO], [AviacaoVendasAgrupAnoMenos1].[_trackCreationTime], [AviacaoVendasAgrupAnoMenos1].[_trackLastWriteTime], [AviacaoVendasAgrupAnoMenos1].[_trackCreationUser], [AviacaoVendasAgrupAnoMenos1].[_trackLastWriteUser] 
    FROM [AviacaoVendasAgrupAnoMenos1]
GO

CREATE VIEW [dbo].[vAviacaoVendasAgrupAnoMenos2]
AS
SELECT [AviacaoVendasAgrupAnoMenos2].[pId], [AviacaoVendasAgrupAnoMenos2].[pCLIENTE], [AviacaoVendasAgrupAnoMenos2].[pFILIAL], [AviacaoVendasAgrupAnoMenos2].[pLOJA], [AviacaoVendasAgrupAnoMenos2].[pNOME_CLIENTE], [AviacaoVendasAgrupAnoMenos2].[pCIDADE_CLIENTE], [AviacaoVendasAgrupAnoMenos2].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasAgrupAnoMenos2].[pESTADO], [AviacaoVendasAgrupAnoMenos2].[pREGIAO], [AviacaoVendasAgrupAnoMenos2].[pCODIGO_VENDEDOR], [AviacaoVendasAgrupAnoMenos2].[pNOME_VENDEDOR], [AviacaoVendasAgrupAnoMenos2].[pVALOR_COMISSAO], [AviacaoVendasAgrupAnoMenos2].[pDATA_EMISSAO], [AviacaoVendasAgrupAnoMenos2].[pTRIMESTRE], [AviacaoVendasAgrupAnoMenos2].[pPRODUTO], [AviacaoVendasAgrupAnoMenos2].[pGRUPO_PRODUTO], [AviacaoVendasAgrupAnoMenos2].[pPESO_PRODUTO], [AviacaoVendasAgrupAnoMenos2].[pQTD_P_CAIXA], [AviacaoVendasAgrupAnoMenos2].[pQTD_EM_CAIXA], [AviacaoVendasAgrupAnoMenos2].[pPESO_TOTAL], [AviacaoVendasAgrupAnoMenos2].[pPESO_BRUTO], [AviacaoVendasAgrupAnoMenos2].[pDESCRICAO], [AviacaoVendasAgrupAnoMenos2].[pQUANTIDADE], [AviacaoVendasAgrupAnoMenos2].[pPRECO_TABELA], [AviacaoVendasAgrupAnoMenos2].[pVLR_TOTAL_PRODUTO], [AviacaoVendasAgrupAnoMenos2].[pPRECO_DE_VENDA], [AviacaoVendasAgrupAnoMenos2].[pVLR_DESCONTO], [AviacaoVendasAgrupAnoMenos2].[pVLR_BASE_ICM], [AviacaoVendasAgrupAnoMenos2].[pVLR_TOTAL_NOTA], [AviacaoVendasAgrupAnoMenos2].[pVLR_SEM_ICMSST], [AviacaoVendasAgrupAnoMenos2].[pVLR_ICM], [AviacaoVendasAgrupAnoMenos2].[pVLR_COFINS], [AviacaoVendasAgrupAnoMenos2].[pVLR_PIS], [AviacaoVendasAgrupAnoMenos2].[pPRECO_FORA_IMPOSTO], [AviacaoVendasAgrupAnoMenos2].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasAgrupAnoMenos2].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasAgrupAnoMenos2].[pCFOP], [AviacaoVendasAgrupAnoMenos2].[pDESCON_FINAN], [AviacaoVendasAgrupAnoMenos2].[pCUSTO_PRODUTO], [AviacaoVendasAgrupAnoMenos2].[pCUSTO_PROD_QTD], [AviacaoVendasAgrupAnoMenos2].[pANO_EMISSAO], [AviacaoVendasAgrupAnoMenos2].[pMES_EMISSAO], [AviacaoVendasAgrupAnoMenos2].[_trackCreationTime], [AviacaoVendasAgrupAnoMenos2].[_trackLastWriteTime], [AviacaoVendasAgrupAnoMenos2].[_trackCreationUser], [AviacaoVendasAgrupAnoMenos2].[_trackLastWriteUser] 
    FROM [AviacaoVendasAgrupAnoMenos2]
GO

CREATE VIEW [dbo].[vAviacaoVendasAnoMenos1]
AS
SELECT [AviacaoVendasAnoMenos1].[pId], [AviacaoVendasAnoMenos1].[pNUMERO_NF], [AviacaoVendasAnoMenos1].[pSERIE], [AviacaoVendasAnoMenos1].[pCLIENTE], [AviacaoVendasAnoMenos1].[pFILIAL], [AviacaoVendasAnoMenos1].[pLOJA], [AviacaoVendasAnoMenos1].[pNOME_CLIENTE], [AviacaoVendasAnoMenos1].[pCIDADE_CLIENTE], [AviacaoVendasAnoMenos1].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasAnoMenos1].[pESTADO], [AviacaoVendasAnoMenos1].[pREGIAO], [AviacaoVendasAnoMenos1].[pPERCENT_DESCONTO], [AviacaoVendasAnoMenos1].[pPORCENT_COMISSAO], [AviacaoVendasAnoMenos1].[pCODIGO_VENDEDOR], [AviacaoVendasAnoMenos1].[pNOME_VENDEDOR], [AviacaoVendasAnoMenos1].[pCIDADE_VENDEDOR], [AviacaoVendasAnoMenos1].[pVALOR_COMISSAO], [AviacaoVendasAnoMenos1].[pDATA_EMISSAO], [AviacaoVendasAnoMenos1].[pDIA_EMISSAO], [AviacaoVendasAnoMenos1].[pMES_EMISSAO], [AviacaoVendasAnoMenos1].[pMES_EXTENSO], [AviacaoVendasAnoMenos1].[pANO_EMISSAO], [AviacaoVendasAnoMenos1].[pTRIMESTRE], [AviacaoVendasAnoMenos1].[pCODIGO_TRANSP], [AviacaoVendasAnoMenos1].[pNOME_TRANSP], [AviacaoVendasAnoMenos1].[pREDESPACHO], [AviacaoVendasAnoMenos1].[pNOME_REDESPACHO], [AviacaoVendasAnoMenos1].[pPRODUTO], [AviacaoVendasAnoMenos1].[pGRUPO_PRODUTO], [AviacaoVendasAnoMenos1].[pPESO_PRODUTO], [AviacaoVendasAnoMenos1].[pQTD_P_CAIXA], [AviacaoVendasAnoMenos1].[pQTD_EM_CAIXA], [AviacaoVendasAnoMenos1].[pPESO_TOTAL], [AviacaoVendasAnoMenos1].[pPESO_BRUTO], [AviacaoVendasAnoMenos1].[pDESCRICAO], [AviacaoVendasAnoMenos1].[pQUANTIDADE], [AviacaoVendasAnoMenos1].[pPRECO_TABELA], [AviacaoVendasAnoMenos1].[pVLR_TOTAL_PRODUTO], [AviacaoVendasAnoMenos1].[pPRECO_DE_VENDA], [AviacaoVendasAnoMenos1].[pVLR_DESCONTO], [AviacaoVendasAnoMenos1].[pVLR_BASE_ICM], [AviacaoVendasAnoMenos1].[pVLR_TOTAL_NOTA], [AviacaoVendasAnoMenos1].[pVLR_SEM_ICMSST], [AviacaoVendasAnoMenos1].[pVLR_ICM], [AviacaoVendasAnoMenos1].[pVLR_COFINS], [AviacaoVendasAnoMenos1].[pVLR_PIS], [AviacaoVendasAnoMenos1].[pPRECO_FORA_IMPOSTO], [AviacaoVendasAnoMenos1].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasAnoMenos1].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasAnoMenos1].[pB1_QE], [AviacaoVendasAnoMenos1].[pB1_CONV], [AviacaoVendasAnoMenos1].[pPLACA], [AviacaoVendasAnoMenos1].[pCFOP], [AviacaoVendasAnoMenos1].[pMARCA], [AviacaoVendasAnoMenos1].[pGRUPO_CLIENTE], [AviacaoVendasAnoMenos1].[pDT_ENTRADA], [AviacaoVendasAnoMenos1].[pDIA_ENTRADA], [AviacaoVendasAnoMenos1].[pMES_ENTRADA], [AviacaoVendasAnoMenos1].[pANO_ENTRADA], [AviacaoVendasAnoMenos1].[pDESCON_FINAN], [AviacaoVendasAnoMenos1].[pCUSTO_PRODUTO], [AviacaoVendasAnoMenos1].[pCUSTO_PROD_QTD], [AviacaoVendasAnoMenos1].[pNRO_PEDIDO_CLIENTE], [AviacaoVendasAnoMenos1].[pPEDIDO], [AviacaoVendasAnoMenos1].[pENDERECO_CLI], [AviacaoVendasAnoMenos1].[pBAIRRO_CLIE], [AviacaoVendasAnoMenos1].[pULTIMA_COMPRA], [AviacaoVendasAnoMenos1].[_trackCreationTime], [AviacaoVendasAnoMenos1].[_trackLastWriteTime], [AviacaoVendasAnoMenos1].[_trackCreationUser], [AviacaoVendasAnoMenos1].[_trackLastWriteUser] 
    FROM [AviacaoVendasAnoMenos1]
GO

CREATE VIEW [dbo].[vaviacaovendasanomenos1aviacaovendasanomenos1viewmarca]
AS
SELECT [AviacaoVendasAnoMenos1].[pCLIENTE], [AviacaoVendasAnoMenos1].[pMARCA], [AviacaoVendasAnoMenos1].[_trackCreationTime], [AviacaoVendasAnoMenos1].[_trackLastWriteTime], [AviacaoVendasAnoMenos1].[_trackCreationUser], [AviacaoVendasAnoMenos1].[_trackLastWriteUser] 
    FROM [AviacaoVendasAnoMenos1]
GO

CREATE VIEW [dbo].[vAviacaoVendasAnoMenos2]
AS
SELECT [AviacaoVendasAnoMenos2].[pId], [AviacaoVendasAnoMenos2].[pNUMERO_NF], [AviacaoVendasAnoMenos2].[pSERIE], [AviacaoVendasAnoMenos2].[pCLIENTE], [AviacaoVendasAnoMenos2].[pFILIAL], [AviacaoVendasAnoMenos2].[pLOJA], [AviacaoVendasAnoMenos2].[pNOME_CLIENTE], [AviacaoVendasAnoMenos2].[pCIDADE_CLIENTE], [AviacaoVendasAnoMenos2].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasAnoMenos2].[pESTADO], [AviacaoVendasAnoMenos2].[pREGIAO], [AviacaoVendasAnoMenos2].[pPERCENT_DESCONTO], [AviacaoVendasAnoMenos2].[pPORCENT_COMISSAO], [AviacaoVendasAnoMenos2].[pCODIGO_VENDEDOR], [AviacaoVendasAnoMenos2].[pNOME_VENDEDOR], [AviacaoVendasAnoMenos2].[pCIDADE_VENDEDOR], [AviacaoVendasAnoMenos2].[pVALOR_COMISSAO], [AviacaoVendasAnoMenos2].[pDATA_EMISSAO], [AviacaoVendasAnoMenos2].[pDIA_EMISSAO], [AviacaoVendasAnoMenos2].[pMES_EMISSAO], [AviacaoVendasAnoMenos2].[pMES_EXTENSO], [AviacaoVendasAnoMenos2].[pANO_EMISSAO], [AviacaoVendasAnoMenos2].[pTRIMESTRE], [AviacaoVendasAnoMenos2].[pCODIGO_TRANSP], [AviacaoVendasAnoMenos2].[pNOME_TRANSP], [AviacaoVendasAnoMenos2].[pREDESPACHO], [AviacaoVendasAnoMenos2].[pNOME_REDESPACHO], [AviacaoVendasAnoMenos2].[pPRODUTO], [AviacaoVendasAnoMenos2].[pGRUPO_PRODUTO], [AviacaoVendasAnoMenos2].[pPESO_PRODUTO], [AviacaoVendasAnoMenos2].[pQTD_P_CAIXA], [AviacaoVendasAnoMenos2].[pQTD_EM_CAIXA], [AviacaoVendasAnoMenos2].[pPESO_TOTAL], [AviacaoVendasAnoMenos2].[pPESO_BRUTO], [AviacaoVendasAnoMenos2].[pDESCRICAO], [AviacaoVendasAnoMenos2].[pQUANTIDADE], [AviacaoVendasAnoMenos2].[pPRECO_TABELA], [AviacaoVendasAnoMenos2].[pVLR_TOTAL_PRODUTO], [AviacaoVendasAnoMenos2].[pPRECO_DE_VENDA], [AviacaoVendasAnoMenos2].[pVLR_DESCONTO], [AviacaoVendasAnoMenos2].[pVLR_BASE_ICM], [AviacaoVendasAnoMenos2].[pVLR_TOTAL_NOTA], [AviacaoVendasAnoMenos2].[pVLR_SEM_ICMSST], [AviacaoVendasAnoMenos2].[pVLR_ICM], [AviacaoVendasAnoMenos2].[pVLR_COFINS], [AviacaoVendasAnoMenos2].[pVLR_PIS], [AviacaoVendasAnoMenos2].[pPRECO_FORA_IMPOSTO], [AviacaoVendasAnoMenos2].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasAnoMenos2].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasAnoMenos2].[pB1_QE], [AviacaoVendasAnoMenos2].[pB1_CONV], [AviacaoVendasAnoMenos2].[pPLACA], [AviacaoVendasAnoMenos2].[pCFOP], [AviacaoVendasAnoMenos2].[pMARCA], [AviacaoVendasAnoMenos2].[pGRUPO_CLIENTE], [AviacaoVendasAnoMenos2].[pDT_ENTRADA], [AviacaoVendasAnoMenos2].[pDIA_ENTRADA], [AviacaoVendasAnoMenos2].[pMES_ENTRADA], [AviacaoVendasAnoMenos2].[pANO_ENTRADA], [AviacaoVendasAnoMenos2].[pDESCON_FINAN], [AviacaoVendasAnoMenos2].[pCUSTO_PRODUTO], [AviacaoVendasAnoMenos2].[pCUSTO_PROD_QTD], [AviacaoVendasAnoMenos2].[pNRO_PEDIDO_CLIENTE], [AviacaoVendasAnoMenos2].[pPEDIDO], [AviacaoVendasAnoMenos2].[pENDERECO_CLI], [AviacaoVendasAnoMenos2].[pBAIRRO_CLIE], [AviacaoVendasAnoMenos2].[pULTIMA_COMPRA], [AviacaoVendasAnoMenos2].[_trackCreationTime], [AviacaoVendasAnoMenos2].[_trackLastWriteTime], [AviacaoVendasAnoMenos2].[_trackCreationUser], [AviacaoVendasAnoMenos2].[_trackLastWriteUser] 
    FROM [AviacaoVendasAnoMenos2]
GO

CREATE VIEW [dbo].[vAviacaoVendasAviacaoVendasRelVendedor]
AS
SELECT [AviacaoVendas].[pNUMERO_NF], [AviacaoVendas].[pSERIE], [AviacaoVendas].[pCLIENTE], [AviacaoVendas].[pFILIAL], [AviacaoVendas].[pLOJA], [AviacaoVendas].[pNOME_CLIENTE], [AviacaoVendas].[pCODIGO_VENDEDOR], [AviacaoVendas].[pNOME_VENDEDOR], [AviacaoVendas].[pDATA_EMISSAO], [AviacaoVendas].[pPRODUTO], [AviacaoVendas].[pGRUPO_PRODUTO], [AviacaoVendas].[pQTD_EM_CAIXA], [AviacaoVendas].[pPESO_TOTAL], [AviacaoVendas].[pDESCRICAO], [AviacaoVendas].[pQUANTIDADE], [AviacaoVendas].[pVLR_TOTAL_PRODUTO], [AviacaoVendas].[pVLR_DESCONTO], [AviacaoVendas].[pVLR_TOTAL_NOTA], [AviacaoVendas].[pVLR_SEM_ICMSST], [AviacaoVendas].[pNRO_PEDIDO_CLIENTE], [AviacaoVendas].[_trackCreationTime], [AviacaoVendas].[_trackLastWriteTime], [AviacaoVendas].[_trackCreationUser], [AviacaoVendas].[_trackLastWriteUser] 
    FROM [AviacaoVendas]
GO

CREATE VIEW [dbo].[vAviacaoVendasComDevolucao]
AS
SELECT [AviacaoVendasComDevolucao].[pId], [AviacaoVendasComDevolucao].[pTIPOMOV], [AviacaoVendasComDevolucao].[pNUMERO_NF], [AviacaoVendasComDevolucao].[pSERIE], [AviacaoVendasComDevolucao].[pCLIENTE], [AviacaoVendasComDevolucao].[pFILIAL], [AviacaoVendasComDevolucao].[pLOJA], [AviacaoVendasComDevolucao].[pNOME_CLIENTE], [AviacaoVendasComDevolucao].[pCIDADE_CLIENTE], [AviacaoVendasComDevolucao].[pCIDADE_CLIENTE_IBGE], [AviacaoVendasComDevolucao].[pESTADO], [AviacaoVendasComDevolucao].[pREGIAO], [AviacaoVendasComDevolucao].[pPERCENT_DESCONTO], [AviacaoVendasComDevolucao].[pPORCENT_COMISSAO], [AviacaoVendasComDevolucao].[pCODIGO_VENDEDOR], [AviacaoVendasComDevolucao].[pNOME_VENDEDOR], [AviacaoVendasComDevolucao].[pCIDADE_VENDEDOR], [AviacaoVendasComDevolucao].[pVALOR_COMISSAO], [AviacaoVendasComDevolucao].[pDATA_EMISSAO], [AviacaoVendasComDevolucao].[pDIA_EMISSAO], [AviacaoVendasComDevolucao].[pMES_EMISSAO], [AviacaoVendasComDevolucao].[pMES_EXTENSO], [AviacaoVendasComDevolucao].[pANO_EMISSAO], [AviacaoVendasComDevolucao].[pTRIMESTRE], [AviacaoVendasComDevolucao].[pCODIGO_TRANSP], [AviacaoVendasComDevolucao].[pNOME_TRANSP], [AviacaoVendasComDevolucao].[pREDESPACHO], [AviacaoVendasComDevolucao].[pNOME_REDESPACHO], [AviacaoVendasComDevolucao].[pPRODUTO], [AviacaoVendasComDevolucao].[pGRUPO_PRODUTO], [AviacaoVendasComDevolucao].[pPESO_PRODUTO], [AviacaoVendasComDevolucao].[pQTD_P_CAIXA], [AviacaoVendasComDevolucao].[pQTD_EM_CAIXA], [AviacaoVendasComDevolucao].[pPESO_TOTAL], [AviacaoVendasComDevolucao].[pPESO_BRUTO], [AviacaoVendasComDevolucao].[pDESCRICAO], [AviacaoVendasComDevolucao].[pQUANTIDADE], [AviacaoVendasComDevolucao].[pPRECO_TABELA], [AviacaoVendasComDevolucao].[pVLR_TOTAL_PRODUTO], [AviacaoVendasComDevolucao].[pPRECO_DE_VENDA], [AviacaoVendasComDevolucao].[pVLR_DESCONTO], [AviacaoVendasComDevolucao].[pVLR_BASE_ICM], [AviacaoVendasComDevolucao].[pVLR_TOTAL_NOTA], [AviacaoVendasComDevolucao].[pVLR_SEM_ICMSST], [AviacaoVendasComDevolucao].[pVLR_ICM], [AviacaoVendasComDevolucao].[pVLR_COFINS], [AviacaoVendasComDevolucao].[pVLR_PIS], [AviacaoVendasComDevolucao].[pPRECO_FORA_IMPOSTO], [AviacaoVendasComDevolucao].[pPRECO_FORA_IMPOSTO_UNIT], [AviacaoVendasComDevolucao].[pIMPOSTO_TOTAL_NOTA], [AviacaoVendasComDevolucao].[pB1_QE], [AviacaoVendasComDevolucao].[pB1_CONV], [AviacaoVendasComDevolucao].[pPLACA], [AviacaoVendasComDevolucao].[pCFOP], [AviacaoVendasComDevolucao].[pMARCA], [AviacaoVendasComDevolucao].[pGRUPO_CLIENTE], [AviacaoVendasComDevolucao].[pDT_ENTRADA], [AviacaoVendasComDevolucao].[pDIA_ENTRADA], [AviacaoVendasComDevolucao].[pMES_ENTRADA], [AviacaoVendasComDevolucao].[pANO_ENTRADA], [AviacaoVendasComDevolucao].[pDESCON_FINAN], [AviacaoVendasComDevolucao].[pVALOR_DESC_FINAN], [AviacaoVendasComDevolucao].[pCUSTO_PRODUTO], [AviacaoVendasComDevolucao].[pCUSTO_PROD_QTD], [AviacaoVendasComDevolucao].[pNRO_PEDIDO_CLIENTE], [AviacaoVendasComDevolucao].[pPEDIDO], [AviacaoVendasComDevolucao].[pENDERECO_CLI], [AviacaoVendasComDevolucao].[pBAIRRO_CLIE], [AviacaoVendasComDevolucao].[pULTIMA_COMPRA], [AviacaoVendasComDevolucao].[pDEVOL_NF_ORIGEM], [AviacaoVendasComDevolucao].[pDEVOL_SERIE_ORIGEM], [AviacaoVendasComDevolucao].[pDEVOL_DESPESAS], [AviacaoVendasComDevolucao].[pDEVOL_TIPO_DOCTO], [AviacaoVendasComDevolucao].[pDEVOL_TP], [AviacaoVendasComDevolucao].[pDEVOL_TES], [AviacaoVendasComDevolucao].[pDEVOL_MOTIVO_DEVOL], [AviacaoVendasComDevolucao].[pDEVOL_TIPO_DEVOLUCAO], [AviacaoVendasComDevolucao].[pQUANTIDADE_VENDA], [AviacaoVendasComDevolucao].[pQUANTIDADE_DEVOL], [AviacaoVendasComDevolucao].[pVLR_TOTAL_PRODUTO_VENDA], [AviacaoVendasComDevolucao].[pVLR_TOTAL_NOTA_VENDA], [AviacaoVendasComDevolucao].[pVLR_TOTAL_PRODUTO_DEVOL], [AviacaoVendasComDevolucao].[pVLR_TOTAL_NOTA_DEVOL], [AviacaoVendasComDevolucao].[pVALOR_FRETE_ITEM_SEQ_TOTAL], [AviacaoVendasComDevolucao].[_trackCreationTime], [AviacaoVendasComDevolucao].[_trackLastWriteTime], [AviacaoVendasComDevolucao].[_trackCreationUser], [AviacaoVendasComDevolucao].[_trackLastWriteUser] 
    FROM [AviacaoVendasComDevolucao]
GO

CREATE VIEW [dbo].[vAviacaoVendedores]
AS
SELECT [AviacaoVendedores].[pId], [AviacaoVendedores].[pCODIGO_VENDEDOR], [AviacaoVendedores].[pNOME_VENDEDOR], [AviacaoVendedores].[pCIDADE_VENDEDOR], [AviacaoVendedores].[_trackCreationTime], [AviacaoVendedores].[_trackLastWriteTime], [AviacaoVendedores].[_trackCreationUser], [AviacaoVendedores].[_trackLastWriteUser] 
    FROM [AviacaoVendedores]
GO

CREATE VIEW [dbo].[vAviacaoVendedoresEmail]
AS
SELECT [AviacaoVendedoresEmail].[pId], [AviacaoVendedoresEmail].[pCODIGO_VENDEDOR], [AviacaoVendedoresEmail].[pEMAIL_VENDEDOR], [AviacaoVendedoresEmail].[_trackCreationTime], [AviacaoVendedoresEmail].[_trackLastWriteTime], [AviacaoVendedoresEmail].[_trackCreationUser], [AviacaoVendedoresEmail].[_trackLastWriteUser] 
    FROM [AviacaoVendedoresEmail]
GO

CREATE VIEW [dbo].[vaviacaovendedoresemailaviacaovendedoresemailview]
AS
SELECT [AviacaoVendedoresEmail].[pId], [AviacaoVendedoresEmail].[pCODIGO_VENDEDOR], [AviacaoVendedoresEmail].[pEMAIL_VENDEDOR], [AviacaoVendedoresEmail].[_trackCreationTime], [AviacaoVendedoresEmail].[_trackLastWriteTime], [AviacaoVendedoresEmail].[_trackCreationUser], [AviacaoVendedoresEmail].[_trackLastWriteUser] 
    FROM [AviacaoVendedoresEmail]
GO

CREATE VIEW [dbo].[vAviacaoViagemMov]
AS
SELECT [AviacaoViagemMov].[pId], [AviacaoViagemMov].[pDATA_SAIDA], [AviacaoViagemMov].[pDATA_PREV_RETORNO], [AviacaoViagemMov].[pDATA_RETORNO], [AviacaoViagemMov].[oAviacaoLocalLinha_pId], [AviacaoViagemMov].[oAviacaoMotorista_pId], [AviacaoViagemMov].[oAviacaoCaminhao_pId], [AviacaoViagemMov].[pRODIZIO], [AviacaoViagemMov].[pSTATUS], [AviacaoViagemMov].[oAviacaoLocalLinhaRetorno_pId], [AviacaoViagemMov].[_trackCreationTime], [AviacaoViagemMov].[_trackLastWriteTime], [AviacaoViagemMov].[_trackCreationUser], [AviacaoViagemMov].[_trackLastWriteUser] 
    FROM [AviacaoViagemMov]
GO

CREATE VIEW [dbo].[vaviacaoviagemmovaviacaoviagemmovviewgrid]
AS
SELECT [AviacaoViagemMov].[pId], [AviacaoViagemMov].[pDATA_SAIDA], [AviacaoViagemMov].[pDATA_PREV_RETORNO], [AviacaoViagemMov].[pDATA_RETORNO], [AviacaoViagemMov].[pRODIZIO], [AviacaoViagemMov].[pSTATUS], [AviacaoLocalLinha].[pId] AS 'pLOCAL_LINHA_ID', [AviacaoLocalLinha].[pCODIGO] AS 'pLOCAL_LINHA_CODIGO', [AviacaoLocalLinha].[pDESCRICAO] AS 'pLOCAL_LINHA_DESCRICAO', [AviacaoMotorista].[pId] AS 'pMOTORISTA_ID', [AviacaoMotorista].[pCOD_MOTORISTA] AS 'pMOTORISTA_CODIGO', [AviacaoMotorista].[pNOME_MOTORISTA] AS 'pMOTORISTA_NOME', [AviacaoCaminhao].[pId] AS 'pCAMINHAO_ID', [AviacaoCaminhao].[pPLACA] AS 'pCAMINHAO_PLACA', [AviacaoCaminhao].[pTIPO] AS 'pCAMINHAO_TIPO', [AviacaoCaminhao].[pDESC_VEICULO] AS 'pCAMINHAO_DESCRICAO', [AviacaoCaminhao].[pCAPACIDADE_TON] AS 'pCAMINHAO_CAPACIDADE_TON', [AviacaoCaminhao].[pCAPACIDADE_PALETE] AS 'pCAMINHAO_CAPACIDADE_PALETE', [AviacaoLocalLinha$1].[pId] AS 'pLOCAL_LINHA_RETORNO_ID', [AviacaoLocalLinha$1].[pCODIGO] AS 'pLOCAL_LINHA_RETORNO_CODIGO', [AviacaoLocalLinha$1].[pDESCRICAO] AS 'pLOCAL_LINHA_RETORNO_DESCRICAO', [AviacaoCaminhao].[sStatus] AS 'pCAMINHAO_STATUS', [AviacaoViagemMov].[_trackCreationTime], [AviacaoViagemMov].[_trackLastWriteTime], [AviacaoViagemMov].[_trackCreationUser], [AviacaoViagemMov].[_trackLastWriteUser] 
    FROM [AviacaoViagemMov]
        LEFT OUTER JOIN [AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] ON ([AviacaoViagemMov].[pId] = [AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas].[pId2])
                LEFT OUTER JOIN [AviacaoLocalLinha] ON ([AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas].[pId] = [AviacaoLocalLinha].[pId])
                LEFT OUTER JOIN [AviacaoMotorista] ON ([AviacaoViagemMov].[oAviacaoMotorista_pId] = [AviacaoMotorista].[pId])
                LEFT OUTER JOIN [AviacaoCaminhao] ON ([AviacaoViagemMov].[oAviacaoCaminhao_pId] = [AviacaoCaminhao].[pId])
        LEFT OUTER JOIN [AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] ON ([AviacaoViagemMov].[pId] = [AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno].[pId2])
                LEFT OUTER JOIN [AviacaoLocalLinha] [AviacaoLocalLinha$1] ON ([AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno].[pId] = [AviacaoLocalLinha$1].[pId])
GO

CREATE VIEW [dbo].[vBalancaFracionamento]
AS
SELECT [BalancaFracionamento].[pId], [BalancaFracionamento].[pPorta], [BalancaFracionamento].[pVelocidade], [BalancaFracionamento].[pParidade], [BalancaFracionamento].[pBits], [BalancaFracionamento].[pStopBits], [BalancaFracionamento].[pIntervalo], [BalancaFracionamento].[sStatus], [BalancaFracionamento].[pIntervaloSalvaAutomatico], [BalancaFracionamento].[pNumeroEtiquetas], [BalancaFracionamento].[_trackCreationTime], [BalancaFracionamento].[_trackLastWriteTime], [BalancaFracionamento].[_trackCreationUser], [BalancaFracionamento].[_trackLastWriteUser] 
    FROM [BalancaFracionamento]
GO

CREATE VIEW [dbo].[vBevBoleAgri]
AS
SELECT [BevBoleAgri].[pId], [BevBoleAgri].[pTipoResumo], [BevBoleAgri].[pSemanas], [BevBoleAgri].[pCriterio], [BevBoleAgri].[pCriterioDescricao], [BevBoleAgri].[pIdadeMeses], [BevBoleAgri].[pAreaColhidaHA], [BevBoleAgri].[pTonColhida], [BevBoleAgri].[pTCHPrevisto], [BevBoleAgri].[pTCHRealizado], [BevBoleAgri].[pTCHDifPercentual], [BevBoleAgri].[pATRPrevisto], [BevBoleAgri].[pATRRealizado], [BevBoleAgri].[pATRDifPercentual], [BevBoleAgri].[pPCPrevisto], [BevBoleAgri].[pPCRealizado], [BevBoleAgri].[pPCDifPercentual], [BevBoleAgri].[pTPHPrevisto], [BevBoleAgri].[pTPHRealizado], [BevBoleAgri].[pTPHDifPercentual], [BevBoleAgri].[_trackCreationTime], [BevBoleAgri].[_trackLastWriteTime], [BevBoleAgri].[_trackCreationUser], [BevBoleAgri].[_trackLastWriteUser] 
    FROM [BevBoleAgri]
GO

CREATE VIEW [dbo].[vcadastro]
AS
SELECT [cadastro].[pId], [cadastro].[pNome], [cadastro].[pCodigo], [cadastro].[pPFPJ], [cadastro].[pEndereco], [cadastro].[oCidade_pId], [cadastro].[pEnderLogradouro], [cadastro].[pEnderComplemento], [cadastro].[pEnderBairro], [cadastro].[pEnderNumero], [cadastro].[pEnderAuxLogradouro], [cadastro].[pEnderAuxNumero], [cadastro].[pEnderAuxBairro], [cadastro].[pEnderAuxComplemento], [cadastro].[pEnderecoAux], [cadastro].[pEmail], [cadastro].[oCidadeAux_pId], [cadastro].[pCpfCnpj], [cadastro].[pDataNascimento], [cadastro].[pRgIe], [cadastro].[pNomeFantasia], [cadastro].[pFlgSexo], [cadastro].[pDataCadastro], [cadastro].[pDataBaixa], [cadastro].[pTelefone], [cadastro].[pTelefoneAux], [cadastro].[pCelular], [cadastro].[pFax], [cadastro].[xDataHoraReg], [cadastro].[xLoginReg], [cadastro].[oUsuario_pId], [cadastro].[pCep], [cadastro].[pCepAux], [cadastro].[pFlgPreCadastro], [cadastro].[oCadastroFilial_pId], [cadastro].[_trackCreationTime], [cadastro].[_trackLastWriteTime], [cadastro].[_trackCreationUser], [cadastro].[_trackLastWriteUser] 
    FROM [cadastro]
GO

CREATE VIEW [dbo].[vcadastrocadastroviewgeral]
AS
SELECT [cadastro].[pId], [cadastro].[pNome], [cadastro].[pCodigo], [cadastro].[pPFPJ], [cadastro].[pEndereco], [cadastro].[pEnderLogradouro], [cadastro].[pEnderComplemento], [cadastro].[pEnderBairro], [cadastro].[pEnderNumero], [cadastro].[pEnderAuxLogradouro], [cadastro].[pEnderAuxNumero], [cadastro].[pEnderAuxBairro], [cadastro].[pEnderAuxComplemento], [cadastro].[pEnderecoAux], [cadastro].[pEmail], [cadastro].[pCpfCnpj], [cadastro].[pDataNascimento], [cadastro].[pRgIe], [cadastro].[pNomeFantasia], [cadastro].[pFlgSexo], [cadastro].[pDataCadastro], [cadastro].[pDataBaixa], [cadastro].[pTelefone], [cadastro].[pTelefoneAux], [cadastro].[pCelular], [cidade].[pCodigo] AS 'pCodigoCidade', [cidade].[pNome] AS 'pNomeCidade', [uf].[pSigla] AS 'pUFCidade', [cidade$1].[pCodigo] AS 'pCodigoCidadeAux', [cidade$1].[pNome] AS 'pNomeCidadeaux', [uf$1].[pSigla] AS 'pUFCidadeAux', [empresa].[pCodigo] AS 'pCodigoEmpresa', [empresa].[pNome] AS 'pNomeEmpresa', [cadastro].[_trackCreationTime], [cadastro].[_trackLastWriteTime], [cadastro].[_trackCreationUser], [cadastro].[_trackLastWriteUser] 
    FROM [cadastro]
        LEFT OUTER JOIN [cidade] ON ([cadastro].[oCidade_pId] = [cidade].[pId])
                LEFT OUTER JOIN [uf] ON ([cidade].[oUF_pId] = [uf].[pId])
                LEFT OUTER JOIN [cidade] [cidade$1] ON ([cadastro].[oCidadeAux_pId] = [cidade$1].[pId])
                LEFT OUTER JOIN [cidade] [cidade$2] ON ([cadastro].[oCidadeAux_pId] = [cidade$2].[pId])
                        LEFT OUTER JOIN [uf] [uf$1] ON ([cidade$2].[oUF_pId] = [uf$1].[pId])
        LEFT OUTER JOIN [cadastro_oempresas_empresa_ocadastros] ON ([cadastro].[pId] = [cadastro_oempresas_empresa_ocadastros].[pId])
                LEFT OUTER JOIN [empresa] ON ([cadastro_oempresas_empresa_ocadastros].[pId2] = [empresa].[pId])
GO

CREATE VIEW [dbo].[vcadastrocadastroviewgeraltipo]
AS
SELECT [cadastro].[pId], [cadastro].[pNome], [cadastro].[pCodigo], [cadastro].[pPFPJ], [cadastro].[pEndereco], [cadastro].[pEnderLogradouro], [cadastro].[pEnderComplemento], [cadastro].[pEnderBairro], [cadastro].[pEnderNumero], [cadastro].[pEnderAuxLogradouro], [cadastro].[pEnderAuxNumero], [cadastro].[pEnderAuxBairro], [cadastro].[pEnderAuxComplemento], [cadastro].[pEnderecoAux], [cadastro].[pEmail], [cadastro].[pCpfCnpj], [cadastro].[pDataNascimento], [cadastro].[pRgIe], [cadastro].[pNomeFantasia], [cadastro].[pFlgSexo], [cadastro].[pDataCadastro], [cadastro].[pDataBaixa], [cadastro].[pTelefone], [cadastro].[pTelefoneAux], [cadastro].[pCelular], [cidade].[pCodigo] AS 'pCodigoCidade', [cidade].[pNome] AS 'pNomeCidade', [uf].[pSigla] AS 'pUFCidade', [cidade$1].[pCodigo] AS 'pCodigoCidadeAux', [cidade$1].[pNome] AS 'pNomeCidadeaux', [uf$1].[pSigla] AS 'pUFCidadeAux', [empresa].[pCodigo] AS 'pCodigoEmpresa', [empresa].[pNome] AS 'pNomeEmpresa', [cadastrotipo].[pFlgCadastro] AS 'pCadastroTipoFlgTipo', [cadastrotipo].[pDescricao] AS 'pCadastroTipoDescricao', [cadastro].[_trackCreationTime], [cadastro].[_trackLastWriteTime], [cadastro].[_trackCreationUser], [cadastro].[_trackLastWriteUser] 
    FROM [cadastro]
        LEFT OUTER JOIN [cidade] ON ([cadastro].[oCidade_pId] = [cidade].[pId])
                LEFT OUTER JOIN [uf] ON ([cidade].[oUF_pId] = [uf].[pId])
                LEFT OUTER JOIN [cidade] [cidade$1] ON ([cadastro].[oCidadeAux_pId] = [cidade$1].[pId])
                LEFT OUTER JOIN [cidade] [cidade$2] ON ([cadastro].[oCidadeAux_pId] = [cidade$2].[pId])
                        LEFT OUTER JOIN [uf] [uf$1] ON ([cidade$2].[oUF_pId] = [uf$1].[pId])
        LEFT OUTER JOIN [cadastro_oempresas_empresa_ocadastros] ON ([cadastro].[pId] = [cadastro_oempresas_empresa_ocadastros].[pId])
                LEFT OUTER JOIN [empresa] ON ([cadastro_oempresas_empresa_ocadastros].[pId2] = [empresa].[pId])
        LEFT OUTER JOIN [cadastro_ocadastrostipo_cadastrotipo_ocadastros] ON ([cadastro].[pId] = [cadastro_ocadastrostipo_cadastrotipo_ocadastros].[pId])
                LEFT OUTER JOIN [cadastrotipo] ON ([cadastro_ocadastrostipo_cadastrotipo_ocadastros].[pId2] = [cadastrotipo].[pId])
GO

CREATE VIEW [dbo].[vcadastrotipo]
AS
SELECT [cadastrotipo].[pId], [cadastrotipo].[pDescricao], [cadastrotipo].[pFlgCadastro], [cadastrotipo].[xDataHoraReg], [cadastrotipo].[xLoginReg], [cadastrotipo].[_trackCreationTime], [cadastrotipo].[_trackLastWriteTime], [cadastrotipo].[_trackCreationUser], [cadastrotipo].[_trackLastWriteUser] 
    FROM [cadastrotipo]
GO

CREATE VIEW [dbo].[vcadastrotipocadastrotipoviewgrid]
AS
SELECT [cadastrotipo].[pId], [cadastrotipo].[pDescricao], [cadastrotipo].[pFlgCadastro], [cadastrotipo].[_trackCreationTime], [cadastrotipo].[_trackLastWriteTime], [cadastrotipo].[_trackCreationUser], [cadastrotipo].[_trackLastWriteUser] 
    FROM [cadastrotipo]
GO

CREATE VIEW [dbo].[vcidade]
AS
SELECT [cidade].[pId], [cidade].[pNome], [cidade].[pCodigo], [cidade].[pCodigoIbge], [cidade].[oUF_pId], [cidade].[xDataHoraReg], [cidade].[xLoginReg], [cidade].[_trackCreationTime], [cidade].[_trackLastWriteTime], [cidade].[_trackCreationUser], [cidade].[_trackLastWriteUser] 
    FROM [cidade]
GO

CREATE VIEW [dbo].[vcidadecidadeviewgrid]
AS
SELECT [cidade].[pId], [cidade].[pNome], [cidade].[pCodigo], [cidade].[pCodigoIbge], [uf].[pDescricao] AS 'UF', [uf].[pSigla] AS 'Sigla', [cidade].[_trackCreationTime], [cidade].[_trackLastWriteTime], [cidade].[_trackCreationUser], [cidade].[_trackLastWriteUser] 
    FROM [cidade]
        LEFT OUTER JOIN [uf] ON ([cidade].[oUF_pId] = [uf].[pId])
GO

CREATE VIEW [dbo].[vControleViagemAg]
AS
SELECT [ControleViagemAg].[pId], [ControleViagemAg].[pDataSaida], [ControleViagemAg].[oAviacaoCaminhao_pId], [ControleViagemAg].[oAviacaoMotorista_pId], [ControleViagemAg].[pNumeroViagem], [ControleViagemAg].[oLocalLinhaOrigem_pId], [ControleViagemAg].[oLocalLinhaDestino_pId], [ControleViagemAg].[pMonitorado], [ControleViagemAg].[pAverbado], [ControleViagemAg].[pValorCTeCafe], [ControleViagemAg].[pValorCTeLaticinios], [ControleViagemAg].[pValorCTeOutros], [ControleViagemAg].[_trackCreationTime], [ControleViagemAg].[_trackLastWriteTime], [ControleViagemAg].[_trackCreationUser], [ControleViagemAg].[_trackLastWriteUser] 
    FROM [ControleViagemAg]
GO

CREATE VIEW [dbo].[vcontroleviagemagcontroleviagemagviewgrid]
AS
SELECT [ControleViagemAg].[pId], [ControleViagemAg].[pDataSaida], [ControleViagemAg].[pNumeroViagem], [ControleViagemAg].[pMonitorado], [ControleViagemAg].[pAverbado], [ControleViagemAg].[pValorCTeCafe], [ControleViagemAg].[pValorCTeLaticinios], [ControleViagemAg].[pValorCTeOutros], [AviacaoCaminhao].[pId] AS 'pCaminhaoId', [AviacaoCaminhao].[pPLACA] AS 'pCaminhaoPlaca', [AviacaoMotorista].[pCOD_MOTORISTA] AS 'pMotoristaId', [AviacaoMotorista].[pNOME_MOTORISTA] AS 'pMotoristaNome', [AviacaoLocalLinha].[pId] AS 'pLocalLinhaOrigemId', [AviacaoLocalLinha].[pDESCRICAO] AS 'pLocalLinhaOrigemDescricao', [AviacaoLocalLinha$1].[pId] AS 'pLocalLinhaDestinoId', [AviacaoLocalLinha$1].[pDESCRICAO] AS 'pLocalLinhaDestinoDescricao', [LoteControleViagemAg].[pLote], [NFControleViagemAg].[pNFde], [NFControleViagemAg].[pNFate], [NFControleViagemAg].[pNFCancelada], [CTeControleViagemAg].[pCTEde], [CTeControleViagemAg].[pCTEate], [CTeControleViagemAg].[pCTECancelado], [LoteControleViagemAg].[pId] AS 'pLoteId', [NFControleViagemAg].[pId] AS 'pNFId', [CTeControleViagemAg].[pId] AS 'pCTEId', [ControleViagemAg].[_trackCreationTime], [ControleViagemAg].[_trackLastWriteTime], [ControleViagemAg].[_trackCreationUser], [ControleViagemAg].[_trackLastWriteUser] 
    FROM [ControleViagemAg]
        LEFT OUTER JOIN [AviacaoCaminhao] ON ([ControleViagemAg].[oAviacaoCaminhao_pId] = [AviacaoCaminhao].[pId])
                LEFT OUTER JOIN [AviacaoMotorista] ON ([ControleViagemAg].[oAviacaoMotorista_pId] = [AviacaoMotorista].[pId])
                LEFT OUTER JOIN [AviacaoLocalLinha] ON ([ControleViagemAg].[oLocalLinhaOrigem_pId] = [AviacaoLocalLinha].[pId])
                LEFT OUTER JOIN [AviacaoLocalLinha] [AviacaoLocalLinha$1] ON ([ControleViagemAg].[oLocalLinhaDestino_pId] = [AviacaoLocalLinha$1].[pId])
                LEFT OUTER JOIN [LoteControleViagemAg] ON ([ControleViagemAg].[pId] = [LoteControleViagemAg].[oControleViagemAg_pId])
                LEFT OUTER JOIN [NFControleViagemAg] ON ([ControleViagemAg].[pId] = [NFControleViagemAg].[oControleViagemAg_pId])
                LEFT OUTER JOIN [CTeControleViagemAg] ON ([ControleViagemAg].[pId] = [CTeControleViagemAg].[oControleViagemAg_pId])
GO

CREATE VIEW [dbo].[vCTeControleViagemAg]
AS
SELECT [CTeControleViagemAg].[pId], [CTeControleViagemAg].[pCTEde], [CTeControleViagemAg].[pCTEate], [CTeControleViagemAg].[oControleViagemAg_pId], [CTeControleViagemAg].[pCTECancelado], [CTeControleViagemAg].[_trackCreationTime], [CTeControleViagemAg].[_trackLastWriteTime], [CTeControleViagemAg].[_trackCreationUser], [CTeControleViagemAg].[_trackLastWriteUser] 
    FROM [CTeControleViagemAg]
GO

CREATE VIEW [dbo].[vEmbalagemFracionamento]
AS
SELECT [EmbalagemFracionamento].[pId], [EmbalagemFracionamento].[pDescricao], [EmbalagemFracionamento].[pPeso], [EmbalagemFracionamento].[_trackCreationTime], [EmbalagemFracionamento].[_trackLastWriteTime], [EmbalagemFracionamento].[_trackCreationUser], [EmbalagemFracionamento].[_trackLastWriteUser] 
    FROM [EmbalagemFracionamento]
GO

CREATE VIEW [dbo].[vEmbalagemFracionamentoEmbalagemFracionamentoView]
AS
SELECT [EmbalagemFracionamento].[pId], [EmbalagemFracionamento].[pDescricao], [EmbalagemFracionamento].[pPeso], [EmbalagemFracionamento].[_trackCreationTime], [EmbalagemFracionamento].[_trackLastWriteTime], [EmbalagemFracionamento].[_trackCreationUser], [EmbalagemFracionamento].[_trackLastWriteUser] 
    FROM [EmbalagemFracionamento]
GO

CREATE VIEW [dbo].[vempresa]
AS
SELECT [empresa].[pId], [empresa].[pCodigo], [empresa].[pNome], [empresa].[xDataHoraReg], [empresa].[xLoginReg], [empresa].[pSimplesNacionalValorAliquotaCreditoICMS], [empresa].[sSimplesNacionalCategoria], [empresa].[sCodigoRegimeTributario], [empresa].[sCodigoRegimeTributarioNormal], [empresa].[_trackCreationTime], [empresa].[_trackLastWriteTime], [empresa].[_trackCreationUser], [empresa].[_trackLastWriteUser] 
    FROM [empresa]
GO

CREATE VIEW [dbo].[vEmpresaVisita]
AS
SELECT [EmpresaVisita].[pId], [EmpresaVisita].[pNome], [EmpresaVisita].[_trackCreationTime], [EmpresaVisita].[_trackLastWriteTime], [EmpresaVisita].[_trackCreationUser], [EmpresaVisita].[_trackLastWriteUser] 
    FROM [EmpresaVisita]
GO

CREATE VIEW [dbo].[vfilial]
AS
SELECT [filial].[pId], [filial].[pCodigo], [filial].[pNome], [filial].[sTipo], [filial].[xDataHoraReg], [filial].[xLoginReg], [filial].[oEmpresa_pId], [filial].[oCadastro_pId], [filial].[_trackCreationTime], [filial].[_trackLastWriteTime], [filial].[_trackCreationUser], [filial].[_trackLastWriteUser] 
    FROM [filial]
GO

CREATE VIEW [dbo].[vfilialconfig]
AS
SELECT [filialconfig].[pId], [filialconfig].[sTipo], [filialconfig].[pConteudo], [filialconfig].[xDataHoraReg], [filialconfig].[xLoginReg], [filialconfig].[oFilial_pId], [filialconfig].[_trackCreationTime], [filialconfig].[_trackLastWriteTime], [filialconfig].[_trackCreationUser], [filialconfig].[_trackLastWriteUser] 
    FROM [filialconfig]
GO

CREATE VIEW [dbo].[vfilialfilialviewgrid]
AS
SELECT [filial].[pId], [filial].[pCodigo], [filial].[pNome], [filial].[sTipo], [empresa].[pCodigo] AS 'pCodEmpresa', [empresa].[pNome] AS 'pNomEmpresa', [cadastro].[pCpfCnpj] AS 'pCNPJ', [filial].[_trackCreationTime], [filial].[_trackLastWriteTime], [filial].[_trackCreationUser], [filial].[_trackLastWriteUser] 
    FROM [filial]
        LEFT OUTER JOIN [empresa] ON ([filial].[oEmpresa_pId] = [empresa].[pId])
                LEFT OUTER JOIN [cadastro] ON ([filial].[pId] = [cadastro].[oCadastroFilial_pId])
GO

CREATE VIEW [dbo].[vfilialfilialviewusuarios]
AS
SELECT [filial].[pId], [filial].[pCodigo], [filial].[pNome], [filial].[sTipo], [empresa].[pCodigo] AS 'pEmpresaCodigo', [empresa].[pNome] AS 'pEmpresaNome', [usuario].[pLogin] AS 'pUsuarioLogin', [filial].[_trackCreationTime], [filial].[_trackLastWriteTime], [filial].[_trackCreationUser], [filial].[_trackLastWriteUser] 
    FROM [filial]
        LEFT OUTER JOIN [empresa] ON ([filial].[oEmpresa_pId] = [empresa].[pId])
        LEFT OUTER JOIN [filial_ousuarios_usuario_ofiliais] ON ([filial].[pId] = [filial_ousuarios_usuario_ofiliais].[pId])
                LEFT OUTER JOIN [usuario] ON ([filial_ousuarios_usuario_ofiliais].[pId2] = [usuario].[pId])
GO

CREATE VIEW [dbo].[vFracionamento]
AS
SELECT [Fracionamento].[pId], [Fracionamento].[C2_FILIAL], [Fracionamento].[C2_NUM], [Fracionamento].[C2_ITEM], [Fracionamento].[C2_SEQUEN], [Fracionamento].[C2_EMISSAO], [Fracionamento].[C2_PRODUTO], [Fracionamento].[C2_QUANT], [Fracionamento].[C2_QUJE], [Fracionamento].[sStatus], [Fracionamento].[B1_DESC_PROD], [Fracionamento].[_trackCreationTime], [Fracionamento].[_trackLastWriteTime], [Fracionamento].[_trackCreationUser], [Fracionamento].[_trackLastWriteUser] 
    FROM [Fracionamento]
GO

CREATE VIEW [dbo].[vFracionamentoMov]
AS
SELECT [FracionamentoMov].[pId], [FracionamentoMov].[G1_COMP], [FracionamentoMov].[B1_DESC], [FracionamentoMov].[G1_QUANT], [FracionamentoMov].[G1_ZZQMIN], [FracionamentoMov].[G1_ZZQMAX], [FracionamentoMov].[pPesoPesado], [FracionamentoMov].[pLote], [FracionamentoMov].[oFracionamento_pId], [FracionamentoMov].[pDataMov], [FracionamentoMov].[pUsuario], [FracionamentoMov].[B1_UM], [FracionamentoMov].[pTara], [FracionamentoMov].[pVez], [FracionamentoMov].[_trackCreationTime], [FracionamentoMov].[_trackLastWriteTime], [FracionamentoMov].[_trackCreationUser], [FracionamentoMov].[_trackLastWriteUser] 
    FROM [FracionamentoMov]
GO

CREATE VIEW [dbo].[vFracionamentoMovFracionamentoMovViewGrid]
AS
SELECT [FracionamentoMov].[pId], [FracionamentoMov].[G1_COMP], [FracionamentoMov].[B1_DESC], [FracionamentoMov].[G1_QUANT], [FracionamentoMov].[G1_ZZQMIN], [FracionamentoMov].[G1_ZZQMAX], [FracionamentoMov].[pPesoPesado], [FracionamentoMov].[pLote], [FracionamentoMov].[pDataMov], [FracionamentoMov].[pUsuario], [FracionamentoMov].[B1_UM], [FracionamentoMov].[pTara], [FracionamentoMov].[pVez], [Fracionamento].[pId] AS 'pFracionamentoId', [Fracionamento].[C2_EMISSAO], [Fracionamento].[C2_FILIAL], [Fracionamento].[C2_ITEM], [Fracionamento].[C2_NUM], [Fracionamento].[C2_PRODUTO], [Fracionamento].[C2_QUANT], [Fracionamento].[C2_QUJE], [Fracionamento].[C2_SEQUEN], [Fracionamento].[sStatus] AS 'pStatus', [Fracionamento].[B1_DESC_PROD], [FracionamentoMov].[_trackCreationTime], [FracionamentoMov].[_trackLastWriteTime], [FracionamentoMov].[_trackCreationUser], [FracionamentoMov].[_trackLastWriteUser] 
    FROM [FracionamentoMov]
        LEFT OUTER JOIN [Fracionamento] ON ([FracionamentoMov].[oFracionamento_pId] = [Fracionamento].[pId])
GO

CREATE VIEW [dbo].[vFuncionarioVisita]
AS
SELECT [FuncionarioVisita].[pId], [FuncionarioVisita].[pNome], [FuncionarioVisita].[_trackCreationTime], [FuncionarioVisita].[_trackLastWriteTime], [FuncionarioVisita].[_trackCreationUser], [FuncionarioVisita].[_trackLastWriteUser] 
    FROM [FuncionarioVisita]
GO

CREATE VIEW [dbo].[vIdRole]
AS
SELECT [IdRole].[Id], [IdRole].[Name], [IdRole].[_trackCreationTime], [IdRole].[_trackLastWriteTime], [IdRole].[_trackCreationUser], [IdRole].[_trackLastWriteUser] 
    FROM [IdRole]
GO

CREATE VIEW [dbo].[vIdRoleClaim]
AS
SELECT [IdRoleClaim].[Id], [IdRoleClaim].[Type], [IdRoleClaim].[Value], [IdRoleClaim].[ValueType], [IdRoleClaim].[Role_Id], [IdRoleClaim].[_trackCreationTime], [IdRoleClaim].[_trackLastWriteTime], [IdRoleClaim].[_trackCreationUser], [IdRoleClaim].[_trackLastWriteUser] 
    FROM [IdRoleClaim]
GO

CREATE VIEW [dbo].[vIdUser]
AS
SELECT [IdUser].[Id], [IdUser].[UserName], [IdUser].[CreationDateUTC], [IdUser].[Email], [IdUser].[EmailConfirmed], [IdUser].[PhoneNumber], [IdUser].[PhoneNumberConfirmed], [IdUser].[Password], [IdUser].[LastPasswordChangeDate], [IdUser].[AccessFailedCount], [IdUser].[AccessFailedWindowStart], [IdUser].[LockoutEnabled], [IdUser].[LockoutEndDateUtc], [IdUser].[LastProfileUpdateDate], [IdUser].[SecurityStamp], [IdUser].[TwoFactorEnabled], [IdUser].[oUsuario_pId], [IdUser].[_trackCreationTime], [IdUser].[_trackLastWriteTime], [IdUser].[_trackCreationUser], [IdUser].[_trackLastWriteUser] 
    FROM [IdUser]
GO

CREATE VIEW [dbo].[vIdUserClaim]
AS
SELECT [IdUserClaim].[Id], [IdUserClaim].[Type], [IdUserClaim].[Value], [IdUserClaim].[ValueType], [IdUserClaim].[Issuer], [IdUserClaim].[OriginalIssuer], [IdUserClaim].[User_Id], [IdUserClaim].[_trackCreationTime], [IdUserClaim].[_trackLastWriteTime], [IdUserClaim].[_trackCreationUser], [IdUserClaim].[_trackLastWriteUser] 
    FROM [IdUserClaim]
GO

CREATE VIEW [dbo].[vIdUserLogin]
AS
SELECT [IdUserLogin].[Id], [IdUserLogin].[ProviderName], [IdUserLogin].[ProviderKey], [IdUserLogin].[ProviderDisplayName], [IdUserLogin].[User_Id], [IdUserLogin].[_trackCreationTime], [IdUserLogin].[_trackLastWriteTime], [IdUserLogin].[_trackCreationUser], [IdUserLogin].[_trackLastWriteUser] 
    FROM [IdUserLogin]
GO

CREATE VIEW [dbo].[vIndustriaCamarasFriasEvento]
AS
SELECT [IndustriaCamarasFriasEvento].[pId], [IndustriaCamarasFriasEvento].[idtag], [IndustriaCamarasFriasEvento].[periodoINI], [IndustriaCamarasFriasEvento].[periodoFIM], [IndustriaCamarasFriasEvento].[objectid], [IndustriaCamarasFriasEvento].[description], [IndustriaCamarasFriasEvento].[hostname], [IndustriaCamarasFriasEvento].[numOcorrencia], [IndustriaCamarasFriasEvento].[tempo_hhmmss], [IndustriaCamarasFriasEvento].[tempo_dias], [IndustriaCamarasFriasEvento].[tempo_horas], [IndustriaCamarasFriasEvento].[tempo_minutos], [IndustriaCamarasFriasEvento].[tempo_segundos], [IndustriaCamarasFriasEvento].[tempo_datetime], [IndustriaCamarasFriasEvento].[tempo_dd], [IndustriaCamarasFriasEvento].[tempo_hh], [IndustriaCamarasFriasEvento].[tempo_mm], [IndustriaCamarasFriasEvento].[tempo_ss], [IndustriaCamarasFriasEvento].[_trackCreationTime], [IndustriaCamarasFriasEvento].[_trackLastWriteTime], [IndustriaCamarasFriasEvento].[_trackCreationUser], [IndustriaCamarasFriasEvento].[_trackLastWriteUser] 
    FROM [IndustriaCamarasFriasEvento]
GO

CREATE VIEW [dbo].[vIndustriaCremeTempoLimpezaAutomatico]
AS
SELECT [IndustriaCremeTempoLimpezaAutomatico].[pId], [IndustriaCremeTempoLimpezaAutomatico].[idtag], [IndustriaCremeTempoLimpezaAutomatico].[periodoINI], [IndustriaCremeTempoLimpezaAutomatico].[periodoFIM], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_segundos], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_minutos], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_horas], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_dias], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_dd], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_hh], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_mm], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_ss], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_hhmmss], [IndustriaCremeTempoLimpezaAutomatico].[limpeza_tempo_datetime], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_segundos], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_minutos], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_horas], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_dias], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_dd], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_hh], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_mm], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_ss], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_hhmmss], [IndustriaCremeTempoLimpezaAutomatico].[automatico_tempo_datetime], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_segundos], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_minutos], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_horas], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_dias], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_dd], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_hh], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_mm], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_ss], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_hhmmss], [IndustriaCremeTempoLimpezaAutomatico].[ligado_tempo_datetime], [IndustriaCremeTempoLimpezaAutomatico].[_trackCreationTime], [IndustriaCremeTempoLimpezaAutomatico].[_trackLastWriteTime], [IndustriaCremeTempoLimpezaAutomatico].[_trackCreationUser], [IndustriaCremeTempoLimpezaAutomatico].[_trackLastWriteUser] 
    FROM [IndustriaCremeTempoLimpezaAutomatico]
GO

CREATE VIEW [dbo].[vIndustriaEnvaseContadorProducao]
AS
SELECT [IndustriaEnvaseContadorProducao].[pId], [IndustriaEnvaseContadorProducao].[idtag], [IndustriaEnvaseContadorProducao].[periodoINI], [IndustriaEnvaseContadorProducao].[periodoFIM], [IndustriaEnvaseContadorProducao].[envase_a_contador_producao], [IndustriaEnvaseContadorProducao].[envase_b_contador_producao], [IndustriaEnvaseContadorProducao].[envase_a_e_b_contador_producao], [IndustriaEnvaseContadorProducao].[envase_a_contador_producao_pote200], [IndustriaEnvaseContadorProducao].[envase_a_contador_producao_pote500], [IndustriaEnvaseContadorProducao].[envase_b_contador_producao_pote200], [IndustriaEnvaseContadorProducao].[envase_b_contador_producao_pote500], [IndustriaEnvaseContadorProducao].[envase_a_e_b_contador_producao_pote200], [IndustriaEnvaseContadorProducao].[envase_a_e_b_contador_producao_pote500], [IndustriaEnvaseContadorProducao].[_trackCreationTime], [IndustriaEnvaseContadorProducao].[_trackLastWriteTime], [IndustriaEnvaseContadorProducao].[_trackCreationUser], [IndustriaEnvaseContadorProducao].[_trackLastWriteUser] 
    FROM [IndustriaEnvaseContadorProducao]
GO

CREATE VIEW [dbo].[vIndustriaEnvaseEvento]
AS
SELECT [IndustriaEnvaseEvento].[pId], [IndustriaEnvaseEvento].[idtag], [IndustriaEnvaseEvento].[periodoINI], [IndustriaEnvaseEvento].[periodoFIM], [IndustriaEnvaseEvento].[objectid], [IndustriaEnvaseEvento].[description], [IndustriaEnvaseEvento].[hostname], [IndustriaEnvaseEvento].[numOcorrencia], [IndustriaEnvaseEvento].[tempo_hhmmss], [IndustriaEnvaseEvento].[tempo_dias], [IndustriaEnvaseEvento].[tempo_horas], [IndustriaEnvaseEvento].[tempo_minutos], [IndustriaEnvaseEvento].[tempo_segundos], [IndustriaEnvaseEvento].[tempo_datetime], [IndustriaEnvaseEvento].[tempo_dd], [IndustriaEnvaseEvento].[tempo_hh], [IndustriaEnvaseEvento].[tempo_mm], [IndustriaEnvaseEvento].[tempo_ss], [IndustriaEnvaseEvento].[_trackCreationTime], [IndustriaEnvaseEvento].[_trackLastWriteTime], [IndustriaEnvaseEvento].[_trackCreationUser], [IndustriaEnvaseEvento].[_trackLastWriteUser] 
    FROM [IndustriaEnvaseEvento]
GO

CREATE VIEW [dbo].[vIndustriaEnvaseMov]
AS
SELECT [IndustriaEnvaseMov].[pId], [IndustriaEnvaseMov].[idtag], [IndustriaEnvaseMov].[periodoINI], [IndustriaEnvaseMov].[periodoFIM], [IndustriaEnvaseMov].[itemid], [IndustriaEnvaseMov].[clock], [IndustriaEnvaseMov].[tm], [IndustriaEnvaseMov].[value], [IndustriaEnvaseMov].[name], [IndustriaEnvaseMov].[multiplier], [IndustriaEnvaseMov].[host], [IndustriaEnvaseMov].[ultMaqLigada], [IndustriaEnvaseMov].[ultDispPote], [IndustriaEnvaseMov].[ultTipoPote], [IndustriaEnvaseMov].[ultPesoDesejado], [IndustriaEnvaseMov].[valueDifPesoDesejado], [IndustriaEnvaseMov].[ultStatusCorrecaoPeso], [IndustriaEnvaseMov].[ultLimInfCopo], [IndustriaEnvaseMov].[ultLimSupCopo], [IndustriaEnvaseMov].[_trackCreationTime], [IndustriaEnvaseMov].[_trackLastWriteTime], [IndustriaEnvaseMov].[_trackCreationUser], [IndustriaEnvaseMov].[_trackLastWriteUser] 
    FROM [IndustriaEnvaseMov]
GO

CREATE VIEW [dbo].[vIndustriaEnvasePesoMedio]
AS
SELECT [IndustriaEnvasePesoMedio].[pId], [IndustriaEnvasePesoMedio].[idtag], [IndustriaEnvasePesoMedio].[periodoINI], [IndustriaEnvasePesoMedio].[periodoFIM], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_balanca1], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_balanca1], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_balanca2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_balanca2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_balanca1e2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_balanca1e2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_balanca1], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_balanca1], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_balanca2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_balanca2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_balanca1e2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_balanca1e2], [IndustriaEnvasePesoMedio].[envase_aeb_peso_medio_pote200_balanca1e2], [IndustriaEnvasePesoMedio].[envase_aeb_peso_medio_pote500_balanca1e2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote200_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_pote500_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_a_peso_medio_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_difdesejado_balanca1], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_difdesejado_balanca2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote200_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_pote500_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_b_peso_medio_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_aeb_peso_medio_pote200_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_aeb_peso_medio_pote500_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_aeb_peso_medio_difdesejado_balanca1e2], [IndustriaEnvasePesoMedio].[envase_a_ult_peso_desejado_pote200], [IndustriaEnvasePesoMedio].[envase_a_ult_peso_desejado_pote500], [IndustriaEnvasePesoMedio].[envase_b_ult_peso_desejado_pote200], [IndustriaEnvasePesoMedio].[envase_b_ult_peso_desejado_pote500], [IndustriaEnvasePesoMedio].[envase_a_media_liminfcopo_pote200], [IndustriaEnvasePesoMedio].[envase_a_media_liminfcopo_pote500], [IndustriaEnvasePesoMedio].[envase_a_media_limsupcopo_pote200], [IndustriaEnvasePesoMedio].[envase_a_media_limsupcopo_pote500], [IndustriaEnvasePesoMedio].[envase_b_media_liminfcopo_pote200], [IndustriaEnvasePesoMedio].[envase_b_media_liminfcopo_pote500], [IndustriaEnvasePesoMedio].[envase_b_media_limsupcopo_pote200], [IndustriaEnvasePesoMedio].[envase_b_media_limsupcopo_pote500], [IndustriaEnvasePesoMedio].[_trackCreationTime], [IndustriaEnvasePesoMedio].[_trackLastWriteTime], [IndustriaEnvasePesoMedio].[_trackCreationUser], [IndustriaEnvasePesoMedio].[_trackLastWriteUser] 
    FROM [IndustriaEnvasePesoMedio]
GO

CREATE VIEW [dbo].[vIndustriaEnvaseSipMov]
AS
SELECT [IndustriaEnvaseSipMov].[pId], [IndustriaEnvaseSipMov].[idtag], [IndustriaEnvaseSipMov].[periodoINI], [IndustriaEnvaseSipMov].[periodoFIM], [IndustriaEnvaseSipMov].[itemid], [IndustriaEnvaseSipMov].[clock], [IndustriaEnvaseSipMov].[tm], [IndustriaEnvaseSipMov].[value], [IndustriaEnvaseSipMov].[name], [IndustriaEnvaseSipMov].[multiplier], [IndustriaEnvaseSipMov].[host], [IndustriaEnvaseSipMov].[_trackCreationTime], [IndustriaEnvaseSipMov].[_trackLastWriteTime], [IndustriaEnvaseSipMov].[_trackCreationUser], [IndustriaEnvaseSipMov].[_trackLastWriteUser] 
    FROM [IndustriaEnvaseSipMov]
GO

CREATE VIEW [dbo].[vIndustriaEnvaseTempoSip]
AS
SELECT [IndustriaEnvaseTempoSip].[pId], [IndustriaEnvaseTempoSip].[idtag], [IndustriaEnvaseTempoSip].[periodoINI], [IndustriaEnvaseTempoSip].[periodoFIM], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_segundos], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_minutos], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_horas], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_dias], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_dd], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_hh], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_mm], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_ss], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_hhmmss], [IndustriaEnvaseTempoSip].[envase_a_tempo_sip_datetime], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_segundos], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_minutos], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_horas], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_dias], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_dd], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_hh], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_mm], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_ss], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_hhmmss], [IndustriaEnvaseTempoSip].[envase_b_tempo_sip_datetime], [IndustriaEnvaseTempoSip].[_trackCreationTime], [IndustriaEnvaseTempoSip].[_trackLastWriteTime], [IndustriaEnvaseTempoSip].[_trackCreationUser], [IndustriaEnvaseTempoSip].[_trackLastWriteUser] 
    FROM [IndustriaEnvaseTempoSip]
GO

CREATE VIEW [dbo].[vIndustriaLeiteEvento]
AS
SELECT [IndustriaLeiteEvento].[pId], [IndustriaLeiteEvento].[idtag], [IndustriaLeiteEvento].[periodoINI], [IndustriaLeiteEvento].[periodoFIM], [IndustriaLeiteEvento].[objectid], [IndustriaLeiteEvento].[description], [IndustriaLeiteEvento].[hostname], [IndustriaLeiteEvento].[numOcorrencia], [IndustriaLeiteEvento].[tempo_hhmmss], [IndustriaLeiteEvento].[tempo_dias], [IndustriaLeiteEvento].[tempo_horas], [IndustriaLeiteEvento].[tempo_minutos], [IndustriaLeiteEvento].[tempo_segundos], [IndustriaLeiteEvento].[tempo_datetime], [IndustriaLeiteEvento].[tempo_dd], [IndustriaLeiteEvento].[tempo_hh], [IndustriaLeiteEvento].[tempo_mm], [IndustriaLeiteEvento].[tempo_ss], [IndustriaLeiteEvento].[_trackCreationTime], [IndustriaLeiteEvento].[_trackLastWriteTime], [IndustriaLeiteEvento].[_trackCreationUser], [IndustriaLeiteEvento].[_trackLastWriteUser] 
    FROM [IndustriaLeiteEvento]
GO

CREATE VIEW [dbo].[vIndustriaLeitelhoTempoLimpezaAutomatico]
AS
SELECT [IndustriaLeitelhoTempoLimpezaAutomatico].[pId], [IndustriaLeitelhoTempoLimpezaAutomatico].[idtag], [IndustriaLeitelhoTempoLimpezaAutomatico].[periodoINI], [IndustriaLeitelhoTempoLimpezaAutomatico].[periodoFIM], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_segundos], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_minutos], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_horas], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_dias], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_dd], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_hh], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_mm], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_ss], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_hhmmss], [IndustriaLeitelhoTempoLimpezaAutomatico].[limpeza_tempo_datetime], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_segundos], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_minutos], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_horas], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_dias], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_dd], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_hh], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_mm], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_ss], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_hhmmss], [IndustriaLeitelhoTempoLimpezaAutomatico].[automatico_tempo_datetime], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_segundos], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_minutos], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_horas], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_dias], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_dd], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_hh], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_mm], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_ss], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_hhmmss], [IndustriaLeitelhoTempoLimpezaAutomatico].[ligado_tempo_datetime], [IndustriaLeitelhoTempoLimpezaAutomatico].[_trackCreationTime], [IndustriaLeitelhoTempoLimpezaAutomatico].[_trackLastWriteTime], [IndustriaLeitelhoTempoLimpezaAutomatico].[_trackCreationUser], [IndustriaLeitelhoTempoLimpezaAutomatico].[_trackLastWriteUser] 
    FROM [IndustriaLeitelhoTempoLimpezaAutomatico]
GO

CREATE VIEW [dbo].[vIndustriaLeiteTempoLimpezaAutomatico]
AS
SELECT [IndustriaLeiteTempoLimpezaAutomatico].[pId], [IndustriaLeiteTempoLimpezaAutomatico].[idtag], [IndustriaLeiteTempoLimpezaAutomatico].[periodoINI], [IndustriaLeiteTempoLimpezaAutomatico].[periodoFIM], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_segundos], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_minutos], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_horas], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_dias], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_dd], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_hh], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_mm], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_ss], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_hhmmss], [IndustriaLeiteTempoLimpezaAutomatico].[limpeza_tempo_datetime], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_segundos], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_minutos], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_horas], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_dias], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_dd], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_hh], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_mm], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_ss], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_hhmmss], [IndustriaLeiteTempoLimpezaAutomatico].[automatico_tempo_datetime], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_segundos], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_minutos], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_horas], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_dias], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_dd], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_hh], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_mm], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_ss], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_hhmmss], [IndustriaLeiteTempoLimpezaAutomatico].[ligado_tempo_datetime], [IndustriaLeiteTempoLimpezaAutomatico].[_trackCreationTime], [IndustriaLeiteTempoLimpezaAutomatico].[_trackLastWriteTime], [IndustriaLeiteTempoLimpezaAutomatico].[_trackCreationUser], [IndustriaLeiteTempoLimpezaAutomatico].[_trackLastWriteUser] 
    FROM [IndustriaLeiteTempoLimpezaAutomatico]
GO

CREATE VIEW [dbo].[vIndustriaSoroDeQueijoTempoLimpezaAutomatico]
AS
SELECT [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[pId], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[idtag], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[periodoINI], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[periodoFIM], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_segundos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_minutos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_horas], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_dias], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_dd], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_hh], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_mm], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_ss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_hhmmss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[limpeza_tempo_datetime], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_segundos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_minutos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_horas], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_dias], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_dd], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_hh], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_mm], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_ss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_hhmmss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[automatico_tempo_datetime], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_segundos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_minutos], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_horas], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_dias], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_dd], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_hh], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_mm], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_ss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_hhmmss], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[ligado_tempo_datetime], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[_trackCreationTime], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[_trackLastWriteTime], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[_trackCreationUser], [IndustriaSoroDeQueijoTempoLimpezaAutomatico].[_trackLastWriteUser] 
    FROM [IndustriaSoroDeQueijoTempoLimpezaAutomatico]
GO

CREATE VIEW [dbo].[vLogFracionamento]
AS
SELECT [LogFracionamento].[pId], [LogFracionamento].[pDescricao], [LogFracionamento].[pDataMov], [LogFracionamento].[pCodigoProduto], [LogFracionamento].[pProdutoDescricao], [LogFracionamento].[pQuantidade], [LogFracionamento].[pNumOrdem], [LogFracionamento].[pOrdemProduto], [LogFracionamento].[pOrdemData], [LogFracionamento].[pTipo], [LogFracionamento].[_trackCreationTime], [LogFracionamento].[_trackLastWriteTime], [LogFracionamento].[_trackCreationUser], [LogFracionamento].[_trackLastWriteUser] 
    FROM [LogFracionamento]
GO

CREATE VIEW [dbo].[vLogFracionamentoLogFracionamentoView]
AS
SELECT [LogFracionamento].[pId], [LogFracionamento].[pDescricao], [LogFracionamento].[pDataMov], [LogFracionamento].[pCodigoProduto], [LogFracionamento].[pProdutoDescricao], [LogFracionamento].[pQuantidade], [LogFracionamento].[pNumOrdem], [LogFracionamento].[pOrdemProduto], [LogFracionamento].[pOrdemData], [LogFracionamento].[pTipo], [LogFracionamento].[_trackCreationTime], [LogFracionamento].[_trackLastWriteTime], [LogFracionamento].[_trackCreationUser], [LogFracionamento].[_trackLastWriteUser] 
    FROM [LogFracionamento]
GO

CREATE VIEW [dbo].[vloginregistro]
AS
SELECT [loginregistro].[pId], [loginregistro].[pDataHora], [loginregistro].[pSenha], [loginregistro].[pObsLog], [loginregistro].[pCodigoUsuario], [loginregistro].[pLoginUsuario], [loginregistro].[pFlgAdminUsuario], [loginregistro].[pCodigoFilial], [loginregistro].[pCodigoEmpresa], [loginregistro].[pLoginValidado], [loginregistro].[sUsuarioStatus], [loginregistro].[_trackCreationTime], [loginregistro].[_trackLastWriteTime], [loginregistro].[_trackCreationUser], [loginregistro].[_trackLastWriteUser] 
    FROM [loginregistro]
GO

CREATE VIEW [dbo].[vLoteControleViagemAg]
AS
SELECT [LoteControleViagemAg].[pId], [LoteControleViagemAg].[pLote], [LoteControleViagemAg].[oControleViagemAg_pId], [LoteControleViagemAg].[_trackCreationTime], [LoteControleViagemAg].[_trackLastWriteTime], [LoteControleViagemAg].[_trackCreationUser], [LoteControleViagemAg].[_trackLastWriteUser] 
    FROM [LoteControleViagemAg]
GO

CREATE VIEW [dbo].[vmenu]
AS
SELECT [menu].[pId], [menu].[pDescricao], [menu].[pNomeToolStrip], [menu].[oSistema_pId], [menu].[pNivelPosicao], [menu].[xDataHoraReg], [menu].[xLoginReg], [menu].[_trackCreationTime], [menu].[_trackLastWriteTime], [menu].[_trackCreationUser], [menu].[_trackLastWriteUser] 
    FROM [menu]
GO

CREATE VIEW [dbo].[vmenumenuvw]
AS
SELECT [menu].[pId], [menu].[pDescricao], [menu].[pNomeToolStrip], [menu].[pNivelPosicao], [sistema].[pCodigo] AS 'pSistemaCodigo', [sistema].[pNome] AS 'pSistemaNome', [menu].[_trackCreationTime], [menu].[_trackLastWriteTime], [menu].[_trackCreationUser], [menu].[_trackLastWriteUser] 
    FROM [menu]
        LEFT OUTER JOIN [sistema] ON ([menu].[oSistema_pId] = [sistema].[pId])
GO

CREATE VIEW [dbo].[vmenupermissao]
AS
SELECT [menupermissao].[pId], [menupermissao].[oUsuario_pId], [menupermissao].[oSistema_pId], [menupermissao].[pNomeToolStripPerm], [menupermissao].[pFlgPermissao], [menupermissao].[xDataHoraReg], [menupermissao].[xLoginReg], [menupermissao].[_trackCreationTime], [menupermissao].[_trackLastWriteTime], [menupermissao].[_trackCreationUser], [menupermissao].[_trackLastWriteUser] 
    FROM [menupermissao]
GO

CREATE VIEW [dbo].[vMovimentacaoLote]
AS
SELECT [MovimentacaoLote].[pId], [MovimentacaoLote].[oProduto_pId], [MovimentacaoLote].[pLote], [MovimentacaoLote].[pFormas], [MovimentacaoLote].[pDataFabricacao], [MovimentacaoLote].[pDataMaturacao], [MovimentacaoLote].[pFinalizado], [MovimentacaoLote].[_trackCreationTime], [MovimentacaoLote].[_trackLastWriteTime], [MovimentacaoLote].[_trackCreationUser], [MovimentacaoLote].[_trackLastWriteUser] 
    FROM [MovimentacaoLote]
GO

CREATE VIEW [dbo].[vMovimentacaoLoteMovimentacaoLoteViewDashboard]
AS
SELECT [MovimentacaoLote].[pId], [MovimentacaoLote].[pLote], [MovimentacaoLote].[pFormas], [MovimentacaoLote].[pDataFabricacao], [MovimentacaoLote].[pDataMaturacao], [MovimentacaoLote].[pFinalizado], [Produto].[pDescricao] AS 'pProdutoDescricao', [ProdutoPrevisao].[pDescricao] AS 'pProdutoPrevisaoDescricao', [ProdutoPrevisao].[pFormas] AS 'pProdutoPrevisaoFormas', [ProdutoPrevisao].[pCaixas] AS 'pProdutoPrevisaoCaixas', [MovimentacaoLote].[_trackCreationTime], [MovimentacaoLote].[_trackLastWriteTime], [MovimentacaoLote].[_trackCreationUser], [MovimentacaoLote].[_trackLastWriteUser] 
    FROM [MovimentacaoLote]
        LEFT OUTER JOIN [Produto] ON ([MovimentacaoLote].[oProduto_pId] = [Produto].[pId])
                LEFT OUTER JOIN [ProdutoPrevisao] ON ([Produto].[pId] = [ProdutoPrevisao].[oProduto_pId])
GO

CREATE VIEW [dbo].[vMovimentacaoLoteMovimentacaoLoteViewGrid]
AS
SELECT [MovimentacaoLote].[pId], [MovimentacaoLote].[pLote], [MovimentacaoLote].[pFormas], [MovimentacaoLote].[pDataFabricacao], [MovimentacaoLote].[pDataMaturacao], [MovimentacaoLote].[pFinalizado], [Produto].[pId] AS 'pProdutoId', [Produto].[pDescricao] AS 'pProdutoDescricao', [MovimentacaoLote].[_trackCreationTime], [MovimentacaoLote].[_trackLastWriteTime], [MovimentacaoLote].[_trackCreationUser], [MovimentacaoLote].[_trackLastWriteUser] 
    FROM [MovimentacaoLote]
        LEFT OUTER JOIN [Produto] ON ([MovimentacaoLote].[oProduto_pId] = [Produto].[pId])
GO

CREATE VIEW [dbo].[vNFControleViagemAg]
AS
SELECT [NFControleViagemAg].[pId], [NFControleViagemAg].[pNFde], [NFControleViagemAg].[pNFate], [NFControleViagemAg].[oControleViagemAg_pId], [NFControleViagemAg].[pNFCancelada], [NFControleViagemAg].[_trackCreationTime], [NFControleViagemAg].[_trackLastWriteTime], [NFControleViagemAg].[_trackCreationUser], [NFControleViagemAg].[_trackLastWriteUser] 
    FROM [NFControleViagemAg]
GO

CREATE VIEW [dbo].[vpais]
AS
SELECT [pais].[pId], [pais].[pCodigo], [pais].[pNome], [pais].[pSigla], [pais].[pCodigoIbge], [pais].[xDataHoraReg], [pais].[xLoginReg], [pais].[_trackCreationTime], [pais].[_trackLastWriteTime], [pais].[_trackCreationUser], [pais].[_trackLastWriteUser] 
    FROM [pais]
GO

CREATE VIEW [dbo].[vpaispaisviewgrid]
AS
SELECT [pais].[pId], [pais].[pCodigo], [pais].[pCodigoIbge], [pais].[pNome], [pais].[_trackCreationTime], [pais].[_trackLastWriteTime], [pais].[_trackCreationUser], [pais].[_trackLastWriteUser] 
    FROM [pais]
GO

CREATE VIEW [dbo].[vPaleteMov]
AS
SELECT [PaleteMov].[pId], [PaleteMov].[pDataMov], [PaleteMov].[pLote], [PaleteMov].[pQuantidade], [PaleteMov].[pTipoMov], [PaleteMov].[oPaleteProduto_pId], [PaleteMov].[_trackCreationTime], [PaleteMov].[_trackLastWriteTime], [PaleteMov].[_trackCreationUser], [PaleteMov].[_trackLastWriteUser] 
    FROM [PaleteMov]
GO

CREATE VIEW [dbo].[vPaleteProduto]
AS
SELECT [PaleteProduto].[pId], [PaleteProduto].[pCodProduto], [PaleteProduto].[pDescProduto], [PaleteProduto].[pProdutoEmb], [PaleteProduto].[pQuantidade], [PaleteProduto].[_trackCreationTime], [PaleteProduto].[_trackLastWriteTime], [PaleteProduto].[_trackCreationUser], [PaleteProduto].[_trackLastWriteUser] 
    FROM [PaleteProduto]
GO

CREATE VIEW [dbo].[vParametrosFracionamento]
AS
SELECT [ParametrosFracionamento].[pId], [ParametrosFracionamento].[pCodigoProduto], [ParametrosFracionamento].[pImprimeMultiplasEtiquetas], [ParametrosFracionamento].[_trackCreationTime], [ParametrosFracionamento].[_trackLastWriteTime], [ParametrosFracionamento].[_trackCreationUser], [ParametrosFracionamento].[_trackLastWriteUser] 
    FROM [ParametrosFracionamento]
GO

CREATE VIEW [dbo].[vProduto]
AS
SELECT [Produto].[pId], [Produto].[pDescricao], [Produto].[pDiasMaturacao], [Produto].[_trackCreationTime], [Produto].[_trackLastWriteTime], [Produto].[_trackCreationUser], [Produto].[_trackLastWriteUser] 
    FROM [Produto]
GO

CREATE VIEW [dbo].[vProdutoPrevisao]
AS
SELECT [ProdutoPrevisao].[pId], [ProdutoPrevisao].[pDescricao], [ProdutoPrevisao].[oProduto_pId], [ProdutoPrevisao].[pFormas], [ProdutoPrevisao].[pCaixas], [ProdutoPrevisao].[_trackCreationTime], [ProdutoPrevisao].[_trackLastWriteTime], [ProdutoPrevisao].[_trackCreationUser], [ProdutoPrevisao].[_trackLastWriteUser] 
    FROM [ProdutoPrevisao]
GO

CREATE VIEW [dbo].[vProdutoPrevisaoProdutoPrevisaoView]
AS
SELECT [ProdutoPrevisao].[pId], [ProdutoPrevisao].[pDescricao], [ProdutoPrevisao].[pFormas], [ProdutoPrevisao].[pCaixas], [Produto].[pId] AS 'pProdutoId', [Produto].[pDescricao] AS 'pProdutoDescricao', [ProdutoPrevisao].[_trackCreationTime], [ProdutoPrevisao].[_trackLastWriteTime], [ProdutoPrevisao].[_trackCreationUser], [ProdutoPrevisao].[_trackLastWriteUser] 
    FROM [ProdutoPrevisao]
        LEFT OUTER JOIN [Produto] ON ([ProdutoPrevisao].[oProduto_pId] = [Produto].[pId])
GO

CREATE VIEW [dbo].[vProdutoProdutoViewGrid]
AS
SELECT [Produto].[pId], [Produto].[pDescricao], [Produto].[pDiasMaturacao], [Produto].[_trackCreationTime], [Produto].[_trackLastWriteTime], [Produto].[_trackCreationUser], [Produto].[_trackLastWriteUser] 
    FROM [Produto]
GO

CREATE VIEW [dbo].[vSetorVisita]
AS
SELECT [SetorVisita].[pId], [SetorVisita].[pNome], [SetorVisita].[_trackCreationTime], [SetorVisita].[_trackLastWriteTime], [SetorVisita].[_trackCreationUser], [SetorVisita].[_trackLastWriteUser] 
    FROM [SetorVisita]
GO

CREATE VIEW [dbo].[vsistema]
AS
SELECT [sistema].[pId], [sistema].[pNome], [sistema].[pCodigo], [sistema].[xDataHoraReg], [sistema].[xLoginReg], [sistema].[_trackCreationTime], [sistema].[_trackLastWriteTime], [sistema].[_trackCreationUser], [sistema].[_trackLastWriteUser] 
    FROM [sistema]
GO

CREATE VIEW [dbo].[vTaraFracionamento]
AS
SELECT [TaraFracionamento].[pId], [TaraFracionamento].[C2_PRODUTO], [TaraFracionamento].[G1_COMP], [TaraFracionamento].[oEmbalagem_pId], [TaraFracionamento].[_trackCreationTime], [TaraFracionamento].[_trackLastWriteTime], [TaraFracionamento].[_trackCreationUser], [TaraFracionamento].[_trackLastWriteUser] 
    FROM [TaraFracionamento]
GO

CREATE VIEW [dbo].[vTaraFracionamentoTaraFracionamentoView]
AS
SELECT [TaraFracionamento].[pId], [TaraFracionamento].[C2_PRODUTO], [TaraFracionamento].[G1_COMP], [EmbalagemFracionamento].[pDescricao] AS 'pEmbalagemDescricao', [EmbalagemFracionamento].[pPeso] AS 'pEmbalagemPeso', [TaraFracionamento].[_trackCreationTime], [TaraFracionamento].[_trackLastWriteTime], [TaraFracionamento].[_trackCreationUser], [TaraFracionamento].[_trackLastWriteUser] 
    FROM [TaraFracionamento]
        LEFT OUTER JOIN [EmbalagemFracionamento] ON ([TaraFracionamento].[oEmbalagem_pId] = [EmbalagemFracionamento].[pId])
GO

CREATE VIEW [dbo].[vuf]
AS
SELECT [uf].[pId], [uf].[pCodigo], [uf].[pDescricao], [uf].[pSigla], [uf].[pCodigoIbge], [uf].[xDataHoraReg], [uf].[xLoginReg], [uf].[oPais_pId], [uf].[_trackCreationTime], [uf].[_trackLastWriteTime], [uf].[_trackCreationUser], [uf].[_trackLastWriteUser] 
    FROM [uf]
GO

CREATE VIEW [dbo].[vufufviewgrid]
AS
SELECT [uf].[pId], [uf].[pCodigo], [uf].[pDescricao], [uf].[pSigla], [uf].[_trackCreationTime], [uf].[_trackLastWriteTime], [uf].[_trackCreationUser], [uf].[_trackLastWriteUser] 
    FROM [uf]
GO

CREATE VIEW [dbo].[vusuario]
AS
SELECT [usuario].[pId], [usuario].[pCodigo], [usuario].[pLogin], [usuario].[pSenha], [usuario].[pFlgAdmin], [usuario].[sStatus], [usuario].[xDataHoraReg], [usuario].[xLoginReg], [usuario].[oCadastro_pId], [usuario].[oIdUser_Id], [usuario].[pCodigoVendedor], [usuario].[pCodigoAprovador], [usuario].[pCodigoVendedorVinculado], [usuario].[pCodigoSubVendedor], [usuario].[_trackCreationTime], [usuario].[_trackLastWriteTime], [usuario].[_trackCreationUser], [usuario].[_trackLastWriteUser] 
    FROM [usuario]
GO

CREATE VIEW [dbo].[vVisitaMov]
AS
SELECT [VisitaMov].[pId], [VisitaMov].[oVisitante_pId], [VisitaMov].[oFuncionario_pId], [VisitaMov].[oSetor_pId], [VisitaMov].[oEmpresa_pId], [VisitaMov].[pDataVisita], [VisitaMov].[_trackCreationTime], [VisitaMov].[_trackLastWriteTime], [VisitaMov].[_trackCreationUser], [VisitaMov].[_trackLastWriteUser] 
    FROM [VisitaMov]
GO

CREATE VIEW [dbo].[vVisitaMovVisitaViewGrid]
AS
SELECT [VisitaMov].[pId], [VisitaMov].[pDataVisita], [VisitanteVisita].[pId] AS 'pVisitanteId', [VisitanteVisita].[pNome] AS 'pVisitanteNome', [FuncionarioVisita].[pId] AS 'pFuncionarioId', [FuncionarioVisita].[pNome] AS 'pFuncionarioNome', [SetorVisita].[pId] AS 'pSetorId', [SetorVisita].[pNome] AS 'pSetorNome', [EmpresaVisita].[pId] AS 'pEmpresaId', [EmpresaVisita].[pNome] AS 'pEmpresaNome', [VisitaMov].[_trackCreationTime], [VisitaMov].[_trackLastWriteTime], [VisitaMov].[_trackCreationUser], [VisitaMov].[_trackLastWriteUser] 
    FROM [VisitaMov]
        LEFT OUTER JOIN [VisitanteVisita] ON ([VisitaMov].[oVisitante_pId] = [VisitanteVisita].[pId])
                LEFT OUTER JOIN [FuncionarioVisita] ON ([VisitaMov].[oFuncionario_pId] = [FuncionarioVisita].[pId])
                LEFT OUTER JOIN [SetorVisita] ON ([VisitaMov].[oSetor_pId] = [SetorVisita].[pId])
                LEFT OUTER JOIN [EmpresaVisita] ON ([VisitaMov].[oEmpresa_pId] = [EmpresaVisita].[pId])
GO

CREATE VIEW [dbo].[vVisitanteVisita]
AS
SELECT [VisitanteVisita].[pId], [VisitanteVisita].[pNome], [VisitanteVisita].[pTipoFJ], [VisitanteVisita].[pCpfCnpj], [VisitanteVisita].[pRg], [VisitanteVisita].[pHabilitacao], [VisitanteVisita].[pTelefoneFixo], [VisitanteVisita].[pSexo], [VisitanteVisita].[pDeficienteFisico], [VisitanteVisita].[pEnderLogradouro], [VisitanteVisita].[pEnderComplemento], [VisitanteVisita].[pEnderBairro], [VisitanteVisita].[pEnderNumero], [VisitanteVisita].[pEnderCep], [VisitanteVisita].[oCidade_pId], [VisitanteVisita].[pTelefoneCelular], [VisitanteVisita].[pEmail], [VisitanteVisita].[_trackCreationTime], [VisitanteVisita].[_trackLastWriteTime], [VisitanteVisita].[_trackCreationUser], [VisitanteVisita].[_trackLastWriteUser] 
    FROM [VisitanteVisita]
GO

CREATE VIEW [dbo].[vVisitanteVisitaVisitanteVisitaViewGrid]
AS
SELECT [VisitanteVisita].[pId], [VisitanteVisita].[pNome], [VisitanteVisita].[pTipoFJ], [VisitanteVisita].[pCpfCnpj], [VisitanteVisita].[pRg], [VisitanteVisita].[pHabilitacao], [VisitanteVisita].[pTelefoneFixo], [VisitanteVisita].[pSexo], [VisitanteVisita].[pDeficienteFisico], [VisitanteVisita].[pEnderLogradouro], [VisitanteVisita].[pEnderComplemento], [VisitanteVisita].[pEnderBairro], [VisitanteVisita].[pEnderNumero], [VisitanteVisita].[pEnderCep], [VisitanteVisita].[pTelefoneCelular], [VisitanteVisita].[pEmail], [cidade].[pNome] AS 'pCidadeNome', [uf].[pSigla] AS 'pCidadeUF', [VisitanteVisita].[_trackCreationTime], [VisitanteVisita].[_trackLastWriteTime], [VisitanteVisita].[_trackCreationUser], [VisitanteVisita].[_trackLastWriteUser] 
    FROM [VisitanteVisita]
        LEFT OUTER JOIN [cidade] ON ([VisitanteVisita].[oCidade_pId] = [cidade].[pId])
                LEFT OUTER JOIN [uf] ON ([cidade].[oUF_pId] = [uf].[pId])
GO

CREATE VIEW [dbo].[vWebSiteMap]
AS
SELECT [WebSiteMap].[pId], [WebSiteMap].[pRelPath], [WebSiteMap].[pNode], [WebSiteMap].[pDescription], [WebSiteMap].[_trackCreationTime], [WebSiteMap].[_trackLastWriteTime], [WebSiteMap].[_trackCreationUser], [WebSiteMap].[_trackLastWriteUser] 
    FROM [WebSiteMap]
GO

CREATE VIEW [dbo].[vwebsitemaplogacessousuariosviewraw]
AS
SELECT loginregistro.pDataHora, loginregistro.pLoginUsuario, loginregistro.pObsLog, websitemap.pNode, websitemap.pDescription FROM loginregistro LEFT OUTER JOIN websitemap ON loginregistro.pObsLog = websitemap.pRelPath
GO

