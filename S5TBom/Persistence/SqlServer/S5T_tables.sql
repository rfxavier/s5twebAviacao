/* CodeFluent Generated . TargetVersion:Sql2014. Culture:pt-BR. UiCulture:pt-BR. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[appconfig]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[appconfig]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AppFvendasPedidos]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AppFvendasPedidos]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AppFvendasPedidosCompra]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AppFvendasPedidosCompra]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AppFvendasPedidosCompraMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AppFvendasPedidosCompraMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AppFvendasPedidosMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AppFvendasPedidosMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[apprelatorio]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[apprelatorio]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoCaminhao]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoCaminhao]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoClienteGrupos]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoClienteGrupos]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoClientes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoClientes]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoConhecimentoFrete]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoConhecimentoFrete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoConhecimentoFreteAgrup]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoFinanceiro]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoFinanceiro]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoLocalLinha]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoLocalLinha]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoMotorista]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoMotorista]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoPedidosFaturamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoPedidosFaturamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoPivotAnalise]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoPivotAnalise]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoProdutoGrupos]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoProdutoGrupos]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoProdutos]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoProdutos]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoRedespachos]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoRedespachos]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoTitulosClientes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoTitulosClientes]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoTransportadores]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoTransportadores]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendas]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendas]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendas3Meses]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendas3Meses]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendas3MesesAnoMenos1]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendas3MesesAnoMenos2]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasAgrup]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasAgrup]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasAgrupAnoMenos1]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasAgrupAnoMenos2]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasAnoMenos1]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasAnoMenos1]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasAnoMenos2]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasAnoMenos2]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendasComDevolucao]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendasComDevolucao]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendedores]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendedores]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoVendedoresEmail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoVendedoresEmail]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoViagemMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoViagemMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[BalancaFracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[BalancaFracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[BevBoleAgri]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[BevBoleAgri]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[cadastro]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[cadastro]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[cadastrotipo]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[cadastrotipo]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[cidade]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[cidade]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ControleViagemAg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ControleViagemAg]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[CTeControleViagemAg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[CTeControleViagemAg]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[EmbalagemFracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[EmbalagemFracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[empresa]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[empresa]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[EmpresaVisita]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[EmpresaVisita]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[filial]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[filial]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[filialconfig]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[filialconfig]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[Fracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Fracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FracionamentoMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[FracionamentoMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FuncionarioVisita]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[FuncionarioVisita]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdRole]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdRole]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdRoleClaim]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdRoleClaim]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdUser]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdUser]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdUserClaim]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdUserClaim]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdUserLogin]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdUserLogin]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaCamarasFriasEvento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaCamarasFriasEvento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvaseContadorProducao]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvaseEvento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvaseEvento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvaseMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvaseMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvasePesoMedio]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvasePesoMedio]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvaseSipMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvaseSipMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaEnvaseTempoSip]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaEnvaseTempoSip]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaLeiteEvento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaLeiteEvento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[LogFracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[LogFracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[loginregistro]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[loginregistro]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[LoteControleViagemAg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[LoteControleViagemAg]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[menu]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[menu]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[menupermissao]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[menupermissao]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[MovimentacaoLote]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[MovimentacaoLote]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[NFControleViagemAg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[NFControleViagemAg]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[pais]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[pais]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PaleteMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[PaleteMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PaleteProduto]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[PaleteProduto]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ParametrosFracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ParametrosFracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[Produto]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Produto]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ProdutoPrevisao]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ProdutoPrevisao]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[SetorVisita]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[SetorVisita]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[sistema]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[sistema]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[TaraFracionamento]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[TaraFracionamento]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[uf]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[uf]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[usuario]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[usuario]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[VisitaMov]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[VisitaMov]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[VisitanteVisita]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[VisitanteVisita]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[WebSiteMap]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[WebSiteMap]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[cadastro_oempresas_empresa_ocadastros]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[empresa_osistemas_sistema_oempresas]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[filial_ousuarios_usuario_ofiliais]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[IdRole_Users_IdUser_Roles]
GO

/* no fk for 'PK_appc_pId_appc', tableName='appconfig' table='appconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appc_pId_appc]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [PK_appc_pId_appc]
GO
/* no fk for 'DF_appc__trk', tableName='appconfig' table='appconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trk]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [DF_appc__trk]
GO
/* no fk for 'DF_appc__trr', tableName='appconfig' table='appconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trr]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [DF_appc__trr]
GO
CREATE TABLE [dbo].[appconfig] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_appc__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_appc__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_appc_pId_appc] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_AppF_pId_AppF', tableName='AppFvendasPedidos' table='AppFvendasPedidos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AppF_pId_AppF]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [PK_AppF_pId_AppF]
GO
/* no fk for 'DF_AppF__trk', tableName='AppFvendasPedidos' table='AppFvendasPedidos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [DF_AppF__trk]
GO
/* no fk for 'DF_AppF__trr', tableName='AppFvendasPedidos' table='AppFvendasPedidos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [DF_AppF__trr]
GO
CREATE TABLE [dbo].[AppFvendasPedidos] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pA1_COD] [nvarchar] (256) NULL,
 [pA3_COD] [nvarchar] (256) NULL,
 [pA1_LOJA] [nvarchar] (256) NULL,
 [pObservacao] [nvarchar] (256) NULL,
 [pObservacaoResumida] [nvarchar] (256) NULL,
 [pDataEmissao] [datetime] NULL,
 [pDataEntrega] [datetime] NULL,
 [pFlgStatus] [nvarchar] (256) NULL,
 [pNumeroPedido] [bigint] NULL,
 [pA3_NOME] [nvarchar] (256) NULL,
 [pA3_COTA] [nvarchar] (256) NULL,
 [pA1_NOME] [nvarchar] (256) NULL,
 [pNumeroItens] [int] NULL,
 [pValorTotal] [float] NULL,
 [pNumeroPedidoCliente] [nvarchar] (256) NULL,
 [pWsOrcamento_DESCRICAO] [nvarchar] (256) NULL,
 [pWsOrcamento_STATUS] [nvarchar] (256) NULL,
 [pWsOrcamento_ITENS] [nvarchar] (256) NULL,
 [pA1_END] [nvarchar] (256) NULL,
 [pFlgStatusEnvioCliente] [nvarchar] (256) NULL,
 [pFlgStatusEnvioClienteObs] [nvarchar] (256) NULL,
 [pCodigoSubVendedor] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AppF__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AppF__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_AppF_pId_AppF] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Appv_pId_Appv', tableName='AppFvendasPedidosCompra' table='AppFvendasPedidosCompra' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appv_pId_Appv]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [PK_Appv_pId_Appv]
GO
/* no fk for 'DF_Appv__trk', tableName='AppFvendasPedidosCompra' table='AppFvendasPedidosCompra' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [DF_Appv__trk]
GO
/* no fk for 'DF_Appv__trr', tableName='AppFvendasPedidosCompra' table='AppFvendasPedidosCompra' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [DF_Appv__trr]
GO
CREATE TABLE [dbo].[AppFvendasPedidosCompra] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigoFilial] [nvarchar] (256) NULL,
 [pNumeroPedido] [nvarchar] (256) NULL,
 [pCodigoFornecedor] [nvarchar] (256) NULL,
 [pCodigoLoja] [nvarchar] (256) NULL,
 [pNomeFornecedor] [nvarchar] (256) NULL,
 [pDataEmissao] [date] NULL,
 [pValorTotal] [float] NULL,
 [pUltimoCodigoAprovador] [nvarchar] (256) NULL,
 [pUltimoStatusRetorno] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Appv__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Appv__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Appv_pId_Appv] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Appe_pId_Appe', tableName='AppFvendasPedidosCompraMov' table='AppFvendasPedidosCompraMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appe_pId_Appe]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [PK_Appe_pId_Appe]
GO
/* no fk for 'DF_Appe__trk', tableName='AppFvendasPedidosCompraMov' table='AppFvendasPedidosCompraMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [DF_Appe__trk]
GO
/* no fk for 'DF_Appe__trr', tableName='AppFvendasPedidosCompraMov' table='AppFvendasPedidosCompraMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [DF_Appe__trr]
GO
CREATE TABLE [dbo].[AppFvendasPedidosCompraMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigoFilial] [nvarchar] (256) NULL,
 [pNumeroPedido] [nvarchar] (256) NULL,
 [pCodigoFornecedor] [nvarchar] (256) NULL,
 [pCodigoLoja] [nvarchar] (256) NULL,
 [pNomeFornecedor] [nvarchar] (256) NULL,
 [pDataEmissao] [date] NULL,
 [pValorTotal] [float] NULL,
 [pCodigoAprovador] [nvarchar] (256) NULL,
 [pDataEnvio] [date] NULL,
 [pFlgOperacao] [nvarchar] (256) NULL,
 [pStatusRetorno] [nvarchar] (256) NULL,
 [pStatusRetornoDescricao] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Appe__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Appe__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Appe_pId_Appe] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Appn_pId_Appn', tableName='AppFvendasPedidosMov' table='AppFvendasPedidosMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appn_pId_Appn]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [PK_Appn_pId_Appn]
GO
/* no fk for 'DF_Appn__trk', tableName='AppFvendasPedidosMov' table='AppFvendasPedidosMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [DF_Appn__trk]
GO
/* no fk for 'DF_Appn__trr', tableName='AppFvendasPedidosMov' table='AppFvendasPedidosMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [DF_Appn__trr]
GO
CREATE TABLE [dbo].[AppFvendasPedidosMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pB1_COD] [nvarchar] (256) NULL,
 [pQuantidade] [float] NULL,
 [pQuantidadeCaixas] [float] NULL,
 [pObservacao] [nvarchar] (256) NULL,
 [pNumeroPedido] [bigint] NULL,
 [pB1_DESC] [nvarchar] (256) NULL,
 [pDA1_PRCVEN] [float] NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pB1_TIPCONV] [nvarchar] (256) NULL,
 [pB1_GRUPO] [nvarchar] (256) NULL,
 [pB1_ZZPESOP] [float] NULL,
 [pZP_SALDO] [float] NULL,
 [pZP_STATUS] [nvarchar] (256) NULL,
 [pValorTotalProduto] [float] NULL,
 [pPed_A1_COD] [nvarchar] (256) NULL,
 [pPed_A1_LOJA] [nvarchar] (256) NULL,
 [pPed_A1_NOME] [nvarchar] (256) NULL,
 [pPed_A3_COD] [nvarchar] (256) NULL,
 [pPed_A3_COTA] [nvarchar] (256) NULL,
 [pPed_A3_NOME] [nvarchar] (256) NULL,
 [pPed_DataEmissao] [date] NULL,
 [pPed_DataEntrega] [date] NULL,
 [pPed_FlgStatus] [nvarchar] (256) NULL,
 [pPed_Observacao] [nvarchar] (256) NULL,
 [pB1_GRUPO_DESC] [nvarchar] (256) NULL,
 [pPed_NumeroPedidoCliente] [nvarchar] (256) NULL,
 [pPed_WsOrcamento_DESCRICAO] [nvarchar] (256) NULL,
 [pPed_WsOrcamento_ITENS] [nvarchar] (256) NULL,
 [pPed_WsOrcamento_STATUS] [nvarchar] (256) NULL,
 [pPed_A1_END] [nvarchar] (256) NULL,
 [pPed_pCodigoSubVendedor] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Appn__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Appn__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Appn_pId_Appn] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appr_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [PK_appr_pId_appr]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trk]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [DF_appr__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [DF_appr__trr]
GO
CREATE TABLE [dbo].[apprelatorio] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNomeFormArgumento] [nvarchar] (256) NULL,
 [pNomeRelatorio] [nvarchar] (20) NOT NULL,
 [pNomeRdlc] [nvarchar] (256) NULL,
 [pNomeDataSet] [nvarchar] (256) NULL,
 [sCategoria] [int] NULL,
 [pTituloRelatorio] [nvarchar] (256) NULL,
 [pSequencia] [int] NULL,
 [pCategoriaRelatorio] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_appr__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_appr__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_appr_pId_appr] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_appr_pNoe_appr] UNIQUE
 (

  [pNomeRelatorio] ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvc_pId_Avia]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAvi_pId_Avia]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAvi_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviCam]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [PK_Avi_pId_AviCam]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvc_pId_Avia]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAvi_pId_Avia]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAvi_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [DF_Avia__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvc_pId_Avia]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAvi_pId_Avia]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAvi_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [DF_Avia__trr]
GO
CREATE TABLE [dbo].[AviacaoCaminhao] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pTIPO] [nvarchar] (256) NULL,
 [pDESC_VEICULO] [nvarchar] (256) NULL,
 [pCAPACIDADE_TON] [decimal] (28,13) NULL,
 [pCAPACIDADE_PALETE] [decimal] (28,13) NULL,
 [oAviacaoMotorista_pId] [bigint] NULL,
 [sStatus] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avia__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avia__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi_pId_AviCam] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avic_pId_Avic', tableName='AviacaoClienteGrupos' table='AviacaoClienteGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avic_pId_Avic]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [PK_Avic_pId_Avic]
GO
/* no fk for 'DF_Avic__trk', tableName='AviacaoClienteGrupos' table='AviacaoClienteGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [DF_Avic__trk]
GO
/* no fk for 'DF_Avic__trr', tableName='AviacaoClienteGrupos' table='AviacaoClienteGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [DF_Avic__trr]
GO
CREATE TABLE [dbo].[AviacaoClienteGrupos] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avic__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avic__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avic_pId_Avic] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avio_pId_Avio', tableName='AviacaoClientes' table='AviacaoClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avio_pId_Avio]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [PK_Avio_pId_Avio]
GO
/* no fk for 'DF_Avio__trk', tableName='AviacaoClientes' table='AviacaoClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [DF_Avio__trk]
GO
/* no fk for 'DF_Avio__trr', tableName='AviacaoClientes' table='AviacaoClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [DF_Avio__trr]
GO
CREATE TABLE [dbo].[AviacaoClientes] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avio__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avio__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avio_pId_Avio] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avo_pId_AviConFre', tableName='AviacaoConhecimentoFrete' table='AviacaoConhecimentoFrete' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFre]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [PK_Avo_pId_AviConFre]
GO
/* no fk for 'DF_Avin__trk', tableName='AviacaoConhecimentoFrete' table='AviacaoConhecimentoFrete' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [DF_Avin__trk]
GO
/* no fk for 'DF_Avin__trr', tableName='AviacaoConhecimentoFrete' table='AviacaoConhecimentoFrete' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [DF_Avin__trr]
GO
CREATE TABLE [dbo].[AviacaoConhecimentoFrete] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pGW1_FILIAL] [nvarchar] (256) NULL,
 [pGW1_EMISDC] [nvarchar] (256) NULL,
 [pGW1_CDTPDC] [nvarchar] (256) NULL,
 [pGV5_DSTPDC] [nvarchar] (256) NULL,
 [pGW1_DTEMIS] [date] NULL,
 [pGW1_DTEMIS_DIA] [nvarchar] (256) NULL,
 [pGW1_DTEMIS_MES] [nvarchar] (256) NULL,
 [pGW1_DTEMIS_ANO] [nvarchar] (256) NULL,
 [pGW1_SERDC] [nvarchar] (256) NULL,
 [pGW1_NRDC] [nvarchar] (256) NULL,
 [pGW1_CDREM] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_REM] [nvarchar] (256) NULL,
 [pGU3_CDERP_REM] [nvarchar] (256) NULL,
 [pGU3_CDCERP_REM] [nvarchar] (256) NULL,
 [pGW1_CDDEST] [nvarchar] (256) NULL,
 [pGU3_NMEMIT] [nvarchar] (256) NULL,
 [pGU3_CDERP] [nvarchar] (256) NULL,
 [pGU3_CDCERP] [nvarchar] (256) NULL,
 [pGW1_NRROM] [nvarchar] (256) NULL,
 [pGW1_TPFRET] [nvarchar] (256) NULL,
 [pGW1_DTSAI] [date] NULL,
 [pGW1_DTSAI_DIA] [nvarchar] (256) NULL,
 [pGW1_DTSAI_MES] [nvarchar] (256) NULL,
 [pGW1_DTSAI_ANO] [nvarchar] (256) NULL,
 [pGW1_DSESP] [nvarchar] (256) NULL,
 [pGW1_QTVOL] [float] NULL,
 [pGW8_SEQ] [nvarchar] (256) NULL,
 [pGW8_ITEM] [nvarchar] (256) NULL,
 [pGW8_DSITEM] [nvarchar] (256) NULL,
 [pGW8_QTDE] [float] NULL,
 [pGW8_VALOR] [float] NULL,
 [pGW8_VOLUME] [float] NULL,
 [pGW8_PESOR] [float] NULL,
 [pGW8_CFOP] [nvarchar] (256) NULL,
 [pD2_ITEM] [nvarchar] (256) NULL,
 [pD2_COD] [nvarchar] (256) NULL,
 [pD2_DOC] [nvarchar] (256) NULL,
 [pD2_SERIE] [nvarchar] (256) NULL,
 [pD2_QUANT] [float] NULL,
 [pD2_TOTAL] [float] NULL,
 [pD2_VALBRUT] [float] NULL,
 [pGWU_SEQ] [nvarchar] (256) NULL,
 [pGWU_CDTRP] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_TRETRAN] [nvarchar] (256) NULL,
 [pGU3_CDTERP_TRETRAN] [nvarchar] (256) NULL,
 [pGWU_NRCIDD] [nvarchar] (256) NULL,
 [pGU7_NMCID] [nvarchar] (256) NULL,
 [pGU7_CDUF] [nvarchar] (256) NULL,
 [pGWF_NRCALC] [nvarchar] (256) NULL,
 [pGWF_TRANSP] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_CALCTRP] [nvarchar] (256) NULL,
 [pGU3_CDTERP_CALCTRP] [nvarchar] (256) NULL,
 [pGWF_EMIREM] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_CALCREM] [nvarchar] (256) NULL,
 [pGU3_CDERP_CALCREM] [nvarchar] (256) NULL,
 [pGU3_CDCERP_CALCREM] [nvarchar] (256) NULL,
 [pGWF_EMIDES] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_CALCDES] [nvarchar] (256) NULL,
 [pGU3_CDERP_CALCDES] [nvarchar] (256) NULL,
 [pGU3_CDCERP_CALCDES] [nvarchar] (256) NULL,
 [pGWF_EMIRED] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_CALCRED] [nvarchar] (256) NULL,
 [pGU3_CDTERP_CALCRED] [nvarchar] (256) NULL,
 [pGWF_EMIPAG] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_CALCPAG] [nvarchar] (256) NULL,
 [pGU3_CDERP_CALCPAG] [nvarchar] (256) NULL,
 [pGU3_CDCERP_CALCPAG] [nvarchar] (256) NULL,
 [pGWF_TPCALC] [nvarchar] (256) NULL,
 [pGWF_CIDORI] [nvarchar] (256) NULL,
 [pGU7_NMCID_CALCCDORI] [nvarchar] (256) NULL,
 [pGU7_CDUF_CALCCDORI] [nvarchar] (256) NULL,
 [PGWF_CIDDES] [nvarchar] (256) NULL,
 [pGU7_NMCID_CALCCDDES] [nvarchar] (256) NULL,
 [pGU7_CDUF_CALCCDDES] [nvarchar] (256) NULL,
 [pGWF_NRROM] [nvarchar] (256) NULL,
 [pGW3_CDESP] [nvarchar] (256) NULL,
 [pGW3_EMISDF] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_TRANS] [nvarchar] (256) NULL,
 [pGW3_SERDF] [nvarchar] (256) NULL,
 [pGW3_NRDF] [nvarchar] (256) NULL,
 [pGW3_DTEMIS] [date] NULL,
 [pGW3_DTEMIS_DIA] [nvarchar] (256) NULL,
 [pGW3_DTEMIS_MES] [nvarchar] (256) NULL,
 [pGW3_DTEMIS_ANO] [nvarchar] (256) NULL,
 [pGW3_TPDF] [nvarchar] (256) NULL,
 [pGW3_DTENT] [date] NULL,
 [pGW3_DTENT_DIA] [nvarchar] (256) NULL,
 [pGW3_DTENT_MES] [nvarchar] (256) NULL,
 [pGW3_DTENT_ANO] [nvarchar] (256) NULL,
 [pGW3_CFOP] [nvarchar] (256) NULL,
 [pGW3_CDREM] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_DFREM] [nvarchar] (256) NULL,
 [pGU3_CDERP_DFREM] [nvarchar] (256) NULL,
 [pGU3_CDCERP_DFREM] [nvarchar] (256) NULL,
 [pGW3_CDDEST] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_DFDES] [nvarchar] (256) NULL,
 [pGU3_CDERP_DFDES] [nvarchar] (256) NULL,
 [pGU3_CDCERP_DFDES] [nvarchar] (256) NULL,
 [pGW3_VLDF] [float] NULL,
 [pGW3_TAXAS] [float] NULL,
 [pGW3_PEDAG] [float] NULL,
 [pGW3_FRPESO] [float] NULL,
 [pGW3_FRVAL] [float] NULL,
 [pGW3_PESOR] [float] NULL,
 [pGW3_VLCARG] [float] NULL,
 [pGW4_NRDC] [nvarchar] (256) NULL,
 [pGW4_SERDC] [nvarchar] (256) NULL,
 [pGW4_EMISDC] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_DDFEMIS] [nvarchar] (256) NULL,
 [pGU3_CDERP_DDFEMIS] [nvarchar] (256) NULL,
 [pGU3_CDCERP_DDFEMIS] [nvarchar] (256) NULL,
 [pGWN_NRROM] [nvarchar] (256) NULL,
 [pGWN_CDTRP] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_ROMCAR] [nvarchar] (256) NULL,
 [pGU3_CDTERP_ROMCAR] [nvarchar] (256) NULL,
 [pGWN_CDTPOP] [nvarchar] (256) NULL,
 [pGV4_DSTPOP] [nvarchar] (256) NULL,
 [pGWN_CDCLFR] [nvarchar] (256) NULL,
 [pGUB_DSCLFR] [nvarchar] (256) NULL,
 [pGWN_CDTPVC] [nvarchar] (256) NULL,
 [pGWN_CDMTR] [nvarchar] (256) NULL,
 [pGW6_EMIFAT] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_FATFRT] [nvarchar] (256) NULL,
 [pGU3_CDERP_FATFRT] [nvarchar] (256) NULL,
 [pCDCERP_FATFRT] [nvarchar] (256) NULL,
 [pGW6_SERFAT] [nvarchar] (256) NULL,
 [pGW6_NRFAT] [nvarchar] (256) NULL,
 [pGW6_DTEMIS] [date] NULL,
 [pGW6_DTEMIS_DIA] [nvarchar] (256) NULL,
 [pGW6_DTEMIS_MES] [nvarchar] (256) NULL,
 [pGW6_DTEMIS_ANO] [nvarchar] (256) NULL,
 [pGW6_DTVENC] [date] NULL,
 [pGW6_DTVENC_DIA] [nvarchar] (256) NULL,
 [pGW6_DTVENC_MES] [nvarchar] (256) NULL,
 [pGW6_DTVENC_ANO] [nvarchar] (256) NULL,
 [pGW6_VLFATU] [float] NULL,
 [pGW6_VLDESC] [float] NULL,
 [pGW6_VLJURO] [float] NULL,
 [pREGIAO_ORIGEM] [nvarchar] (256) NULL,
 [pREGIAO_DESTINO] [nvarchar] (256) NULL,
 [pGWM_VLFRET_RTDCCAR] [float] NULL,
 [pGWM_VLFRET_RTDCFRT] [float] NULL,
 [pGWM_VLFRET_RTDCCAR_TOTAL] [float] NULL,
 [pGWM_VLFRET_RTDCCAR_PERCRATEIO] [float] NULL,
 [pGW8_VALOR_RATEIO] [float] NULL,
 [pGW8_VALOR_BRUTO_RATEIO] [float] NULL,
 [pGW8_QTDE_RATEIO] [float] NULL,
 [pGW8_VOLUME_RATEIO] [float] NULL,
 [pGW8_PESOR_RATEIO] [float] NULL,
 [pGW8_VALOR_TOTAL_NOTA] [float] NULL,
 [pGW8_VALOR_BRUTO_TOTAL_NOTA] [float] NULL,
 [pF2_PBRUTO] [float] NULL,
 [pF2_PLIQUI] [float] NULL,
 [pGWU_DTENT] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avin__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avin__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avo_pId_AviConFre] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avo_pId_AviConFreAg', tableName='AviacaoConhecimentoFreteAgrup' table='AviacaoConhecimentoFreteAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFreAg]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [PK_Avo_pId_AviConFreAg]
GO
/* no fk for 'DF_Avih__trk', tableName='AviacaoConhecimentoFreteAgrup' table='AviacaoConhecimentoFreteAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [DF_Avih__trk]
GO
/* no fk for 'DF_Avih__trr', tableName='AviacaoConhecimentoFreteAgrup' table='AviacaoConhecimentoFreteAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [DF_Avih__trr]
GO
CREATE TABLE [dbo].[AviacaoConhecimentoFreteAgrup] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pGW1_FILIAL] [nvarchar] (256) NULL,
 [pGW1_EMISDC] [nvarchar] (256) NULL,
 [pGW1_CDTPDC] [nvarchar] (256) NULL,
 [pGV5_DSTPDC] [nvarchar] (256) NULL,
 [pGW1_DTEMIS] [date] NULL,
 [pGW1_DTEMIS_DIA] [nvarchar] (256) NULL,
 [pGW1_DTEMIS_MES] [nvarchar] (256) NULL,
 [pGW1_DTEMIS_ANO] [nvarchar] (256) NULL,
 [pGW1_SERDC] [nvarchar] (256) NULL,
 [pGW1_NRDC] [nvarchar] (256) NULL,
 [pGW1_CDREM] [nvarchar] (256) NULL,
 [pGU3_NMEMIT_REM] [nvarchar] (256) NULL,
 [pGU3_CDERP_REM] [nvarchar] (256) NULL,
 [pGU3_CDCERP_REM] [nvarchar] (256) NULL,
 [pGW1_CDDEST] [nvarchar] (256) NULL,
 [pGU3_NMEMIT] [nvarchar] (256) NULL,
 [pGU3_CDERP] [nvarchar] (256) NULL,
 [pGU3_CDCERP] [nvarchar] (256) NULL,
 [pGW1_NRROM] [nvarchar] (256) NULL,
 [pGW1_TPFRET] [nvarchar] (256) NULL,
 [pGW1_DTSAI] [date] NULL,
 [pGW1_DTSAI_DIA] [nvarchar] (256) NULL,
 [pGW1_DTSAI_MES] [nvarchar] (256) NULL,
 [pGW1_DTSAI_ANO] [nvarchar] (256) NULL,
 [pGW1_DSESP] [nvarchar] (256) NULL,
 [pGW3_NRDF] [nvarchar] (256) NULL,
 [pGW1_QTVOL] [float] NULL,
 [pGW8_VALOR_TOTAL_NOTA] [float] NULL,
 [pGW8_VALOR_BRUTO_TOTAL_NOTA] [float] NULL,
 [pVALOR_TOTAL_NF_FRETE_AGRUPADO] [float] NULL,
 [pVALOR_FRETE_TOTAL] [float] NULL,
 [pPERC_NF_FRETE_AGRUPADO] [float] NULL,
 [pGWM_VLFRET_CFRT_CCAR_NOVOFRETE] [float] NULL,
 [pGWM_VLFRET_RTDCCAR_TOTALNRDC] [float] NULL,
 [pSTATUS_GFE] [nvarchar] (256) NULL,
 [pF2_PBRUTO_TOTALNRDC] [float] NULL,
 [pF2_PLIQUI_TOTALNRDC] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avih__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avih__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avo_pId_AviConFreAg] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_AviF_pId_AviF', tableName='AviacaoFinanceiro' table='AviacaoFinanceiro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviF_pId_AviF]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [PK_AviF_pId_AviF]
GO
/* no fk for 'DF_AviF__trk', tableName='AviacaoFinanceiro' table='AviacaoFinanceiro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [DF_AviF__trk]
GO
/* no fk for 'DF_AviF__trr', tableName='AviacaoFinanceiro' table='AviacaoFinanceiro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [DF_AviF__trr]
GO
CREATE TABLE [dbo].[AviacaoFinanceiro] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pFILIAL] [nvarchar] (256) NULL,
 [pNUM] [nvarchar] (256) NULL,
 [pPARCELA] [nvarchar] (256) NULL,
 [pTIPO] [nvarchar] (256) NULL,
 [pCOD_NATUREZA] [nvarchar] (256) NULL,
 [pNATUREZA] [nvarchar] (256) NULL,
 [pPORTADO] [nvarchar] (256) NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDATA_DIA_EMISSAO] [nvarchar] (256) NULL,
 [pDATA_MES_EMISSAO] [nvarchar] (256) NULL,
 [pDATA_ANO_EMISSAO] [nvarchar] (256) NULL,
 [pVENCREA_DT] [date] NULL,
 [pVENCREA_DIA] [nvarchar] (256) NULL,
 [pVENCREA_MES] [nvarchar] (256) NULL,
 [pVENCREA_ANO] [nvarchar] (256) NULL,
 [pVENCORI_DT] [date] NULL,
 [pVENCORI_DIA] [nvarchar] (256) NULL,
 [pVENCORI_MES] [nvarchar] (256) NULL,
 [pVENCORI_ANO] [nvarchar] (256) NULL,
 [pVALOR] [float] NULL,
 [pHIST] [nvarchar] (256) NULL,
 [pSALDO] [float] NULL,
 [pFORNECE_CLIENTE] [nvarchar] (256) NULL,
 [pNOMFOR_NOMCLI] [nvarchar] (256) NULL,
 [pAGENCIA_DEPOSITARIA] [nvarchar] (256) NULL,
 [pNRO_PED_VENDA] [nvarchar] (256) NULL,
 [pCENARIO] [nvarchar] (256) NULL,
 [pTIPO_SALDO] [nvarchar] (256) NULL,
 [pORDEM] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviF__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviF__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_AviF_pId_AviF] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvi_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvi_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvo_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvo_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoa_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoa_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoc_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoc_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviLocLi]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [PK_Avi_pId_AviLocLi]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvi_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvi_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvo_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvo_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoa_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoa_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoc_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoc_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [DF_AviL__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvi_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvi_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvo_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvo_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoa_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoa_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoc_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoc_pId_AviL]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [DF_AviL__trr]
GO
CREATE TABLE [dbo].[AviacaoLocalLinha] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCODIGO] [nvarchar] (256) NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviL__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviL__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi_pId_AviLocLi] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avia_oAvi_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [FK_Avia_oAvi_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviMot]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [PK_Avi_pId_AviMot]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avia_oAvi_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [FK_Avia_oAvi_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [DF_AviM__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avia_oAvi_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [FK_Avia_oAvi_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAva_pId_AviM]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [DF_AviM__trr]
GO
CREATE TABLE [dbo].[AviacaoMotorista] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCOD_MOTORISTA] [nvarchar] (256) NULL,
 [pNOME_MOTORISTA] [nvarchar] (256) NULL,
 [sStatus] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviM__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviM__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi_pId_AviMot] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_AvVP_pId_AvVP', tableName='AviacaoPedidosFaturamento' table='AviacaoPedidosFaturamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AvVP_pId_AvVP]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [PK_AvVP_pId_AvVP]
GO
/* no fk for 'DF_AviP__trk', tableName='AviacaoPedidosFaturamento' table='AviacaoPedidosFaturamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [DF_AviP__trk]
GO
/* no fk for 'DF_AviP__trr', tableName='AviacaoPedidosFaturamento' table='AviacaoPedidosFaturamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [DF_AviP__trr]
GO
CREATE TABLE [dbo].[AviacaoPedidosFaturamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pTIPO_OP] [nvarchar] (256) NULL,
 [pFILIAL] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pNOTA_FISCAL] [nvarchar] (256) NULL,
 [pSERIE_NF] [nvarchar] (256) NULL,
 [pCOD_CLIENTE] [nvarchar] (256) NULL,
 [pUF_CLIENTE] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pDESC_CLIENTE] [nvarchar] (256) NULL,
 [pCOD_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pDT_EMISSAO] [date] NULL,
 [pCOD_GRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDESC_GRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pCODIGO_PRODUTO] [nvarchar] (256) NULL,
 [pDESC_PRODUTO] [nvarchar] (256) NULL,
 [pB1_PESBRU] [float] NULL,
 [pBM_DESC] [nvarchar] (256) NULL,
 [pQUANT_UNIDADE] [float] NULL,
 [pPRECO_VENDA] [float] NULL,
 [pQUANT_CAIXA] [float] NULL,
 [pQTDPCT] [float] NULL,
 [pQTDBRU] [float] NULL,
 [pNUMERO_ORCAMENTO] [nvarchar] (256) NULL,
 [pFORMAS] [float] NULL,
 [pTOTAL_ITEM] [float] NULL,
 [pPEDCLI] [nvarchar] (256) NULL,
 [pPRUNIT] [float] NULL,
 [pDT_EMISSAO_PED] [date] NULL,
 [pDT_EMISSAO_FAT] [date] NULL,
 [pDIAS_PEDIDO] [int] NULL,
 [pSTATUS] [nvarchar] (256) NULL,
 [pDTDIA_EMISSAO_PED] [nvarchar] (256) NULL,
 [pDTMES_EMISSAO_PED] [nvarchar] (256) NULL,
 [pDTANO_EMISSAO_PED] [nvarchar] (256) NULL,
 [pDTDIA_EMISSAO_FAT] [nvarchar] (256) NULL,
 [pDTMES_EMISSAO_FAT] [nvarchar] (256) NULL,
 [pDTANO_EMISSAO_FAT] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviP__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviP__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_AvVP_pId_AvVP] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avii_pId_Avii', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avii_pId_Avii]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [PK_Avii_pId_Avii]
GO
/* no fk for 'DF_Avii__trk', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [DF_Avii__trk]
GO
/* no fk for 'DF_Avii__trr', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [DF_Avii__trr]
GO
CREATE TABLE [dbo].[AviacaoPivotAnalise] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [oUsuario_pId] [bigint] NULL,
 [pModeloAnaliseXml] [xml] NULL,
 [pLayoutVersion] [nvarchar] (256) NULL,
 [pPivotNome] [nvarchar] (256) NULL,
 [pPastaNome] [nvarchar] (256) NULL,
 [pFlgCompartilhada] [nvarchar] (256) NULL,
 [pModeloAnaliseByte] [varbinary] (max) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avii__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avii__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avii_pId_Avii] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avir_pId_Avir', tableName='AviacaoProdutoGrupos' table='AviacaoProdutoGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avir_pId_Avir]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [PK_Avir_pId_Avir]
GO
/* no fk for 'DF_Avir__trk', tableName='AviacaoProdutoGrupos' table='AviacaoProdutoGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [DF_Avir__trk]
GO
/* no fk for 'DF_Avir__trr', tableName='AviacaoProdutoGrupos' table='AviacaoProdutoGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [DF_Avir__trr]
GO
CREATE TABLE [dbo].[AviacaoProdutoGrupos] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avir__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avir__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avir_pId_Avir] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avid_pId_Avid', tableName='AviacaoProdutos' table='AviacaoProdutos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avid_pId_Avid]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [PK_Avid_pId_Avid]
GO
/* no fk for 'DF_Avid__trk', tableName='AviacaoProdutos' table='AviacaoProdutos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [DF_Avid__trk]
GO
/* no fk for 'DF_Avid__trr', tableName='AviacaoProdutos' table='AviacaoProdutos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [DF_Avid__trr]
GO
CREATE TABLE [dbo].[AviacaoProdutos] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avid__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avid__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avid_pId_Avid] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avie_pId_Avie', tableName='AviacaoRedespachos' table='AviacaoRedespachos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avie_pId_Avie]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [PK_Avie_pId_Avie]
GO
/* no fk for 'DF_Avie__trk', tableName='AviacaoRedespachos' table='AviacaoRedespachos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [DF_Avie__trk]
GO
/* no fk for 'DF_Avie__trr', tableName='AviacaoRedespachos' table='AviacaoRedespachos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [DF_Avie__trr]
GO
CREATE TABLE [dbo].[AviacaoRedespachos] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avie__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avie__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avie_pId_Avie] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_AviT_pId_AviT', tableName='AviacaoTitulosClientes' table='AviacaoTitulosClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviT_pId_AviT]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [PK_AviT_pId_AviT]
GO
/* no fk for 'DF_AviT__trk', tableName='AviacaoTitulosClientes' table='AviacaoTitulosClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [DF_AviT__trk]
GO
/* no fk for 'DF_AviT__trr', tableName='AviacaoTitulosClientes' table='AviacaoTitulosClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [DF_AviT__trr]
GO
CREATE TABLE [dbo].[AviacaoTitulosClientes] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCODIGO] [nvarchar] (256) NULL,
 [pNOME] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviT__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviT__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_AviT_pId_AviT] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avis_pId_Avis', tableName='AviacaoTransportadores' table='AviacaoTransportadores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avis_pId_Avis]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [PK_Avis_pId_Avis]
GO
/* no fk for 'DF_Avis__trk', tableName='AviacaoTransportadores' table='AviacaoTransportadores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [DF_Avis__trk]
GO
/* no fk for 'DF_Avis__trr', tableName='AviacaoTransportadores' table='AviacaoTransportadores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [DF_Avis__trr]
GO
CREATE TABLE [dbo].[AviacaoTransportadores] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avis__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avis__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avis_pId_Avis] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_AviV_pId_AviV', tableName='AviacaoVendas' table='AviacaoVendas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviV_pId_AviV]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [PK_AviV_pId_AviV]
GO
/* no fk for 'DF_AviV__trk', tableName='AviacaoVendas' table='AviacaoVendas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [DF_AviV__trk]
GO
/* no fk for 'DF_AviV__trr', tableName='AviacaoVendas' table='AviacaoVendas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [DF_AviV__trr]
GO
CREATE TABLE [dbo].[AviacaoVendas] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pVALOR_DESC_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_AviV__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_AviV__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_AviV_pId_AviV] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi3_pId_Avi3', tableName='AviacaoVendas3Meses' table='AviacaoVendas3Meses' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi3_pId_Avi3]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [PK_Avi3_pId_Avi3]
GO
/* no fk for 'DF_Avi3__trk', tableName='AviacaoVendas3Meses' table='AviacaoVendas3Meses' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [DF_Avi3__trk]
GO
/* no fk for 'DF_Avi3__trr', tableName='AviacaoVendas3Meses' table='AviacaoVendas3Meses' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [DF_Avi3__trr]
GO
CREATE TABLE [dbo].[AviacaoVendas3Meses] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi3__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi3__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi3_pId_Avi3] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi1_pId_Avi1', tableName='AviacaoVendas3MesesAnoMenos1' table='AviacaoVendas3MesesAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi1_pId_Avi1]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [PK_Avi1_pId_Avi1]
GO
/* no fk for 'DF_Avi1__trk', tableName='AviacaoVendas3MesesAnoMenos1' table='AviacaoVendas3MesesAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [DF_Avi1__trk]
GO
/* no fk for 'DF_Avi1__trr', tableName='AviacaoVendas3MesesAnoMenos1' table='AviacaoVendas3MesesAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [DF_Avi1__trr]
GO
CREATE TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi1__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi1__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi1_pId_Avi1] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi2_pId_Avi2', tableName='AviacaoVendas3MesesAnoMenos2' table='AviacaoVendas3MesesAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi2_pId_Avi2]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [PK_Avi2_pId_Avi2]
GO
/* no fk for 'DF_Avi2__trk', tableName='AviacaoVendas3MesesAnoMenos2' table='AviacaoVendas3MesesAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [DF_Avi2__trk]
GO
/* no fk for 'DF_Avi2__trr', tableName='AviacaoVendas3MesesAnoMenos2' table='AviacaoVendas3MesesAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [DF_Avi2__trr]
GO
CREATE TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi2__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi2__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi2_pId_Avi2] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avig_pId_Avig', tableName='AviacaoVendasAgrup' table='AviacaoVendasAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avig_pId_Avig]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [PK_Avig_pId_Avig]
GO
/* no fk for 'DF_Avig__trk', tableName='AviacaoVendasAgrup' table='AviacaoVendasAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [DF_Avig__trk]
GO
/* no fk for 'DF_Avig__trr', tableName='AviacaoVendasAgrup' table='AviacaoVendasAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [DF_Avig__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasAgrup] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pVALOR_DESC_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avig__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avig__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avig_pId_Avig] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Aviu_pId_Aviu', tableName='AviacaoVendasAgrupAnoMenos1' table='AviacaoVendasAgrupAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Aviu_pId_Aviu]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [PK_Aviu_pId_Aviu]
GO
/* no fk for 'DF_Aviu__trk', tableName='AviacaoVendasAgrupAnoMenos1' table='AviacaoVendasAgrupAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [DF_Aviu__trk]
GO
/* no fk for 'DF_Aviu__trr', tableName='AviacaoVendasAgrupAnoMenos1' table='AviacaoVendasAgrupAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [DF_Aviu__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Aviu__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Aviu__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Aviu_pId_Aviu] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi0_pId_Avi0', tableName='AviacaoVendasAgrupAnoMenos2' table='AviacaoVendasAgrupAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi0_pId_Avi0]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [PK_Avi0_pId_Avi0]
GO
/* no fk for 'DF_Avi0__trk', tableName='AviacaoVendasAgrupAnoMenos2' table='AviacaoVendasAgrupAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [DF_Avi0__trk]
GO
/* no fk for 'DF_Avi0__trr', tableName='AviacaoVendasAgrupAnoMenos2' table='AviacaoVendasAgrupAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [DF_Avi0__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi0__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi0__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi0_pId_Avi0] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi4_pId_Avi4', tableName='AviacaoVendasAnoMenos1' table='AviacaoVendasAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi4_pId_Avi4]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [PK_Avi4_pId_Avi4]
GO
/* no fk for 'DF_Avi4__trk', tableName='AviacaoVendasAnoMenos1' table='AviacaoVendasAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [DF_Avi4__trk]
GO
/* no fk for 'DF_Avi4__trr', tableName='AviacaoVendasAnoMenos1' table='AviacaoVendasAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [DF_Avi4__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasAnoMenos1] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi4__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi4__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi4_pId_Avi4] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi5_pId_Avi5', tableName='AviacaoVendasAnoMenos2' table='AviacaoVendasAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi5_pId_Avi5]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [PK_Avi5_pId_Avi5]
GO
/* no fk for 'DF_Avi5__trk', tableName='AviacaoVendasAnoMenos2' table='AviacaoVendasAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [DF_Avi5__trk]
GO
/* no fk for 'DF_Avi5__trr', tableName='AviacaoVendasAnoMenos2' table='AviacaoVendasAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [DF_Avi5__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasAnoMenos2] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi5__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi5__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi5_pId_Avi5] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi6_pId_Avi6', tableName='AviacaoVendasComDevolucao' table='AviacaoVendasComDevolucao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi6_pId_Avi6]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [PK_Avi6_pId_Avi6]
GO
/* no fk for 'DF_Avi6__trk', tableName='AviacaoVendasComDevolucao' table='AviacaoVendasComDevolucao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [DF_Avi6__trk]
GO
/* no fk for 'DF_Avi6__trr', tableName='AviacaoVendasComDevolucao' table='AviacaoVendasComDevolucao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [DF_Avi6__trr]
GO
CREATE TABLE [dbo].[AviacaoVendasComDevolucao] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pTIPOMOV] [nvarchar] (256) NULL,
 [pNUMERO_NF] [nvarchar] (256) NULL,
 [pSERIE] [nvarchar] (256) NULL,
 [pCLIENTE] [nvarchar] (256) NULL,
 [pFILIAL] [int] NULL,
 [pLOJA] [nvarchar] (256) NULL,
 [pNOME_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE] [nvarchar] (256) NULL,
 [pCIDADE_CLIENTE_IBGE] [nvarchar] (256) NULL,
 [pESTADO] [nvarchar] (256) NULL,
 [pREGIAO] [nvarchar] (256) NULL,
 [pPERCENT_DESCONTO] [float] NULL,
 [pPORCENT_COMISSAO] [float] NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [pVALOR_COMISSAO] [float] NULL,
 [pDATA_EMISSAO] [date] NULL,
 [pDIA_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EMISSAO] [nvarchar] (256) NULL,
 [pMES_EXTENSO] [nvarchar] (256) NULL,
 [pANO_EMISSAO] [nvarchar] (256) NULL,
 [pTRIMESTRE] [nvarchar] (256) NULL,
 [pCODIGO_TRANSP] [nvarchar] (256) NULL,
 [pNOME_TRANSP] [nvarchar] (256) NULL,
 [pREDESPACHO] [nvarchar] (256) NULL,
 [pNOME_REDESPACHO] [nvarchar] (256) NULL,
 [pPRODUTO] [nvarchar] (256) NULL,
 [pGRUPO_PRODUTO] [nvarchar] (256) NULL,
 [pPESO_PRODUTO] [float] NULL,
 [pQTD_P_CAIXA] [nvarchar] (256) NULL,
 [pQTD_EM_CAIXA] [float] NULL,
 [pPESO_TOTAL] [float] NULL,
 [pPESO_BRUTO] [float] NULL,
 [pDESCRICAO] [nvarchar] (256) NULL,
 [pQUANTIDADE] [float] NULL,
 [pPRECO_TABELA] [float] NULL,
 [pVLR_TOTAL_PRODUTO] [float] NULL,
 [pPRECO_DE_VENDA] [float] NULL,
 [pVLR_DESCONTO] [float] NULL,
 [pVLR_BASE_ICM] [float] NULL,
 [pVLR_TOTAL_NOTA] [float] NULL,
 [pVLR_SEM_ICMSST] [float] NULL,
 [pVLR_ICM] [float] NULL,
 [pVLR_COFINS] [float] NULL,
 [pVLR_PIS] [float] NULL,
 [pPRECO_FORA_IMPOSTO] [float] NULL,
 [pPRECO_FORA_IMPOSTO_UNIT] [float] NULL,
 [pIMPOSTO_TOTAL_NOTA] [float] NULL,
 [pB1_QE] [nvarchar] (256) NULL,
 [pB1_CONV] [nvarchar] (256) NULL,
 [pPLACA] [nvarchar] (256) NULL,
 [pCFOP] [nvarchar] (256) NULL,
 [pMARCA] [nvarchar] (256) NULL,
 [pGRUPO_CLIENTE] [nvarchar] (256) NULL,
 [pDT_ENTRADA] [date] NULL,
 [pDIA_ENTRADA] [nvarchar] (256) NULL,
 [pMES_ENTRADA] [nvarchar] (256) NULL,
 [pANO_ENTRADA] [nvarchar] (256) NULL,
 [pDESCON_FINAN] [float] NULL,
 [pVALOR_DESC_FINAN] [float] NULL,
 [pCUSTO_PRODUTO] [float] NULL,
 [pCUSTO_PROD_QTD] [float] NULL,
 [pNRO_PEDIDO_CLIENTE] [nvarchar] (256) NULL,
 [pPEDIDO] [nvarchar] (256) NULL,
 [pENDERECO_CLI] [nvarchar] (256) NULL,
 [pBAIRRO_CLIE] [nvarchar] (256) NULL,
 [pULTIMA_COMPRA] [date] NULL,
 [pDEVOL_NF_ORIGEM] [nvarchar] (256) NULL,
 [pDEVOL_SERIE_ORIGEM] [nvarchar] (256) NULL,
 [pDEVOL_DESPESAS] [float] NULL,
 [pDEVOL_TIPO_DOCTO] [nvarchar] (256) NULL,
 [pDEVOL_TP] [nvarchar] (256) NULL,
 [pDEVOL_TES] [nvarchar] (256) NULL,
 [pDEVOL_MOTIVO_DEVOL] [nvarchar] (256) NULL,
 [pDEVOL_TIPO_DEVOLUCAO] [nvarchar] (256) NULL,
 [pQUANTIDADE_VENDA] [float] NULL,
 [pQUANTIDADE_DEVOL] [float] NULL,
 [pVLR_TOTAL_PRODUTO_VENDA] [float] NULL,
 [pVLR_TOTAL_NOTA_VENDA] [float] NULL,
 [pVLR_TOTAL_PRODUTO_DEVOL] [float] NULL,
 [pVLR_TOTAL_NOTA_DEVOL] [float] NULL,
 [pVALOR_FRETE_ITEM_SEQ_TOTAL] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi6__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi6__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi6_pId_Avi6] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi_pId_AviVend', tableName='AviacaoVendedores' table='AviacaoVendedores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviVend]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [PK_Avi_pId_AviVend]
GO
/* no fk for 'DF_Avi7__trk', tableName='AviacaoVendedores' table='AviacaoVendedores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [DF_Avi7__trk]
GO
/* no fk for 'DF_Avi7__trr', tableName='AviacaoVendedores' table='AviacaoVendedores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [DF_Avi7__trr]
GO
CREATE TABLE [dbo].[AviacaoVendedores] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pNOME_VENDEDOR] [nvarchar] (256) NULL,
 [pCIDADE_VENDEDOR] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi7__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi7__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi_pId_AviVend] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi8_pId_Avi8', tableName='AviacaoVendedoresEmail' table='AviacaoVendedoresEmail' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi8_pId_Avi8]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [PK_Avi8_pId_Avi8]
GO
/* no fk for 'DF_Avi8__trk', tableName='AviacaoVendedoresEmail' table='AviacaoVendedoresEmail' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [DF_Avi8__trk]
GO
/* no fk for 'DF_Avi8__trr', tableName='AviacaoVendedoresEmail' table='AviacaoVendedoresEmail' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [DF_Avi8__trr]
GO
CREATE TABLE [dbo].[AviacaoVendedoresEmail] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCODIGO_VENDEDOR] [nvarchar] (256) NULL,
 [pEMAIL_VENDEDOR] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi8__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi8__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi8_pId_Avi8] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviViaMov]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [PK_Avi_pId_AviViaMov]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [DF_Avi9__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [DF_Avi9__trr]
GO
CREATE TABLE [dbo].[AviacaoViagemMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDATA_SAIDA] [datetime] NULL,
 [pDATA_PREV_RETORNO] [date] NULL,
 [pDATA_RETORNO] [datetime] NULL,
 [oAviacaoLocalLinha_pId] [bigint] NULL,
 [oAviacaoMotorista_pId] [bigint] NULL,
 [oAviacaoCaminhao_pId] [bigint] NULL,
 [pRODIZIO] [nvarchar] (256) NULL,
 [pSTATUS] [nvarchar] (256) NULL,
 [oAviacaoLocalLinhaRetorno_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Avi9__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Avi9__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Avi_pId_AviViaMov] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Bala_pId_Bala', tableName='BalancaFracionamento' table='BalancaFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Bala_pId_Bala]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [PK_Bala_pId_Bala]
GO
/* no fk for 'DF_Bala__trk', tableName='BalancaFracionamento' table='BalancaFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trk]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [DF_Bala__trk]
GO
/* no fk for 'DF_Bala__trr', tableName='BalancaFracionamento' table='BalancaFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trr]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [DF_Bala__trr]
GO
CREATE TABLE [dbo].[BalancaFracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pPorta] [nvarchar] (256) NULL,
 [pVelocidade] [nvarchar] (256) NULL,
 [pParidade] [nvarchar] (256) NULL,
 [pBits] [nvarchar] (256) NULL,
 [pStopBits] [nvarchar] (256) NULL,
 [pIntervalo] [nvarchar] (256) NULL,
 [sStatus] [int] NULL,
 [pIntervaloSalvaAutomatico] [int] NULL,
 [pNumeroEtiquetas] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Bala__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Bala__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Bala_pId_Bala] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_BevB_pId_BevB', tableName='BevBoleAgri' table='BevBoleAgri' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_BevB_pId_BevB]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [PK_BevB_pId_BevB]
GO
/* no fk for 'DF_BevB__trk', tableName='BevBoleAgri' table='BevBoleAgri' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trk]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [DF_BevB__trk]
GO
/* no fk for 'DF_BevB__trr', tableName='BevBoleAgri' table='BevBoleAgri' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trr]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [DF_BevB__trr]
GO
CREATE TABLE [dbo].[BevBoleAgri] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pTipoResumo] [nvarchar] (256) NULL,
 [pSemanas] [nvarchar] (256) NULL,
 [pCriterio] [nvarchar] (256) NULL,
 [pCriterioDescricao] [nvarchar] (256) NULL,
 [pIdadeMeses] [float] NULL,
 [pAreaColhidaHA] [float] NULL,
 [pTonColhida] [float] NULL,
 [pTCHPrevisto] [float] NULL,
 [pTCHRealizado] [float] NULL,
 [pTCHDifPercentual] [float] NULL,
 [pATRPrevisto] [float] NULL,
 [pATRRealizado] [float] NULL,
 [pATRDifPercentual] [float] NULL,
 [pPCPrevisto] [float] NULL,
 [pPCRealizado] [float] NULL,
 [pPCDifPercentual] [float] NULL,
 [pTPHPrevisto] [float] NULL,
 [pTPHRealizado] [float] NULL,
 [pTPHDifPercentual] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_BevB__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_BevB__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_BevB_pId_BevB] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cada_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [PK_cada_pId_cada]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trk]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [DF_cada__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trr]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [DF_cada__trr]
GO
CREATE TABLE [dbo].[cadastro] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [pCodigo] [int] NOT NULL,
 [pPFPJ] [nvarchar] (1) NULL,
 [pEndereco] [nvarchar] (256) NULL,
 [oCidade_pId] [bigint] NULL,
 [pEnderLogradouro] [nvarchar] (256) NULL,
 [pEnderComplemento] [nvarchar] (256) NULL,
 [pEnderBairro] [nvarchar] (256) NULL,
 [pEnderNumero] [nvarchar] (256) NULL,
 [pEnderAuxLogradouro] [nvarchar] (256) NULL,
 [pEnderAuxNumero] [nvarchar] (256) NULL,
 [pEnderAuxBairro] [nvarchar] (256) NULL,
 [pEnderAuxComplemento] [nvarchar] (256) NULL,
 [pEnderecoAux] [nvarchar] (256) NULL,
 [pEmail] [nvarchar] (256) NULL,
 [oCidadeAux_pId] [bigint] NULL,
 [pCpfCnpj] [nvarchar] (20) NULL,
 [pDataNascimento] [date] NULL,
 [pRgIe] [nvarchar] (256) NULL,
 [pNomeFantasia] [nvarchar] (256) NULL,
 [pFlgSexo] [nvarchar] (256) NULL,
 [pDataCadastro] [date] NULL,
 [pDataBaixa] [date] NULL,
 [pTelefone] [nvarchar] (256) NULL,
 [pTelefoneAux] [nvarchar] (256) NULL,
 [pCelular] [nvarchar] (256) NULL,
 [pFax] [nvarchar] (256) NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [oUsuario_pId] [bigint] NULL,
 [pCep] [nvarchar] (256) NULL,
 [pCepAux] [nvarchar] (256) NULL,
 [pFlgPreCadastro] [nvarchar] (1) NULL,
 [oCadastroFilial_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_cada__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_cada__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_cada_pId_cada] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_cada_pCod_cada] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cads_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [PK_cads_pId_cads]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trk]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [DF_cads__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trr]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [DF_cads__trr]
GO
CREATE TABLE [dbo].[cadastrotipo] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [pFlgCadastro] [nvarchar] (256) NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_cads__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_cads__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_cads_pId_cads] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cida_pId_cida]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [PK_cida_pId_cida]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trk]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [DF_cida__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trr]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [DF_cida__trr]
GO
CREATE TABLE [dbo].[cidade] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [pCodigo] [int] NOT NULL,
 [pCodigoIbge] [int] NULL,
 [oUF_pId] [bigint] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_cida__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_cida__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_cida_pId_cida] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_cida_pCod_cida] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY],
 CONSTRAINT [IX_cida_pCoi_cida] UNIQUE
 (

  [pCodigoIbge] ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Cont_pId_Cont]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [PK_Cont_pId_Cont]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trk]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [DF_Cont__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trr]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [DF_Cont__trr]
GO
CREATE TABLE [dbo].[ControleViagemAg] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDataSaida] [datetime] NULL,
 [oAviacaoCaminhao_pId] [bigint] NULL,
 [oAviacaoMotorista_pId] [bigint] NULL,
 [pNumeroViagem] [nvarchar] (256) NULL,
 [oLocalLinhaOrigem_pId] [bigint] NULL,
 [oLocalLinhaDestino_pId] [bigint] NULL,
 [pMonitorado] [nvarchar] (256) NULL,
 [pAverbado] [nvarchar] (256) NULL,
 [pValorCTeCafe] [float] NULL,
 [pValorCTeLaticinios] [float] NULL,
 [pValorCTeOutros] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Cont__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Cont__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Cont_pId_Cont] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_CTeC_pId_CTeC', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_CTeC_pId_CTeC]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [PK_CTeC_pId_CTeC]
GO
/* no fk for 'DF_CTeC__trk', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trk]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [DF_CTeC__trk]
GO
/* no fk for 'DF_CTeC__trr', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trr]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [DF_CTeC__trr]
GO
CREATE TABLE [dbo].[CTeControleViagemAg] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCTEde] [nvarchar] (256) NULL,
 [pCTEate] [nvarchar] (256) NULL,
 [oControleViagemAg_pId] [bigint] NULL,
 [pCTECancelado] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_CTeC__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_CTeC__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_CTeC_pId_CTeC] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Emba_pId_Emba]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [PK_Emba_pId_Emba]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trk]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [DF_Emba__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trr]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [DF_Emba__trr]
GO
CREATE TABLE [dbo].[EmbalagemFracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [pPeso] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Emba__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Emba__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Emba_pId_Emba] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId2_pId_empr]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId2_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oEmp_pId_empr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oEmp_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_empr_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [PK_empr_pId_empr]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId2_pId_empr]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId2_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oEmp_pId_empr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oEmp_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trk]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [DF_empr__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId2_pId_empr]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId2_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oEmp_pId_empr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oEmp_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [DF_empr__trr]
GO
CREATE TABLE [dbo].[empresa] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigo] [int] NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [pSimplesNacionalValorAliquotaCreditoICMS] [float] NULL,
 [sSimplesNacionalCategoria] [int] NULL,
 [sCodigoRegimeTributario] [int] NULL,
 [sCodigoRegimeTributarioNormal] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_empr__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_empr__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_empr_pId_empr] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_empr_pCod_empr] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Empe_pId_Empe]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [PK_Empe_pId_Empe]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trk]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [DF_Empe__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trr]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [DF_Empe__trr]
GO
CREATE TABLE [dbo].[EmpresaVisita] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Empe__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Empe__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Empe_pId_Empe] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fili_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [PK_fili_pId_fili]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trk]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [DF_fili__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [DF_fili__trr]
GO
CREATE TABLE [dbo].[filial] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigo] [int] NULL,
 [pNome] [nvarchar] (256) NULL,
 [sTipo] [int] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [oEmpresa_pId] [bigint] NULL,
 [oCadastro_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_fili__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_fili__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_fili_pId_fili] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_fila_pId_fila', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fila_pId_fila]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [PK_fila_pId_fila]
GO
/* no fk for 'DF_fila__trk', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trk]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [DF_fila__trk]
GO
/* no fk for 'DF_fila__trr', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trr]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [DF_fila__trr]
GO
CREATE TABLE [dbo].[filialconfig] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [sTipo] [int] NULL,
 [pConteudo] [nvarchar] (256) NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [oFilial_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_fila__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_fila__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_fila_pId_fila] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frac_pId_Frac]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [PK_Frac_pId_Frac]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trk]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [DF_Frac__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trr]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [DF_Frac__trr]
GO
CREATE TABLE [dbo].[Fracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [C2_FILIAL] [nvarchar] (256) NULL,
 [C2_NUM] [nvarchar] (256) NULL,
 [C2_ITEM] [nvarchar] (256) NULL,
 [C2_SEQUEN] [nvarchar] (256) NULL,
 [C2_EMISSAO] [nvarchar] (256) NULL,
 [C2_PRODUTO] [nvarchar] (256) NULL,
 [C2_QUANT] [float] NULL,
 [C2_QUJE] [float] NULL,
 [sStatus] [int] NULL,
 [B1_DESC_PROD] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Frac__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Frac__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Frac_pId_Frac] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Frai_pId_Frai', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frai_pId_Frai]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [PK_Frai_pId_Frai]
GO
/* no fk for 'DF_Frai__trk', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trk]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [DF_Frai__trk]
GO
/* no fk for 'DF_Frai__trr', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trr]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [DF_Frai__trr]
GO
CREATE TABLE [dbo].[FracionamentoMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [G1_COMP] [nvarchar] (256) NULL,
 [B1_DESC] [nvarchar] (256) NULL,
 [G1_QUANT] [float] NULL,
 [G1_ZZQMIN] [float] NULL,
 [G1_ZZQMAX] [float] NULL,
 [pPesoPesado] [float] NULL,
 [pLote] [nvarchar] (256) NULL,
 [oFracionamento_pId] [bigint] NULL,
 [pDataMov] [datetime] NULL,
 [pUsuario] [nvarchar] (256) NULL,
 [B1_UM] [nvarchar] (256) NULL,
 [pTara] [float] NULL,
 [pVez] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Frai__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Frai__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Frai_pId_Frai] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Func_pId_Func]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [PK_Func_pId_Func]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trk]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [DF_Func__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trr]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [DF_Func__trr]
GO
CREATE TABLE [dbo].[FuncionarioVisita] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Func__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Func__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Func_pId_Func] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRl_Role_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [FK_IdRl_Role_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRo_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [PK_IdRo_Id_IdRo]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRl_Role_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [FK_IdRl_Role_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trk]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [DF_IdRo__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRl_Role_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [FK_IdRl_Role_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trr]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [DF_IdRo__trr]
GO
CREATE TABLE [dbo].[IdRole] (
 [Id] [bigint] IDENTITY (1, 1) NOT NULL,
 [Name] [nvarchar] (70) NOT NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IdRo__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IdRo__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IdRo_Id_IdRo] PRIMARY KEY CLUSTERED
 (

  [Id]
 ) ON [PRIMARY],
 CONSTRAINT [IX_IdRo_Name_IdRo] UNIQUE
 (

  [Name] ) ON [PRIMARY]
)
GO

/* no fk for 'PK_IdRl_Id_IdRl', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRl_Id_IdRl]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [PK_IdRl_Id_IdRl]
GO
/* no fk for 'DF_IdRl__trk', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trk]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [DF_IdRl__trk]
GO
/* no fk for 'DF_IdRl__trr', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trr]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [DF_IdRl__trr]
GO
CREATE TABLE [dbo].[IdRoleClaim] (
 [Id] [bigint] IDENTITY (1, 1) NOT NULL,
 [Type] [nvarchar] (256) NOT NULL,
 [Value] [nvarchar] (256) NULL,
 [ValueType] [nvarchar] (256) NULL,
 [Role_Id] [bigint] NOT NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IdRl__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IdRl__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IdRl_Id_IdRl] PRIMARY KEY CLUSTERED
 (

  [Id]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUs_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [PK_IdUs_Id_IdUs]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trk]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [DF_IdUs__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trr]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [DF_IdUs__trr]
GO
CREATE TABLE [dbo].[IdUser] (
 [Id] [bigint] IDENTITY (1, 1) NOT NULL,
 [UserName] [nvarchar] (70) NOT NULL,
 [CreationDateUTC] [datetime] NOT NULL,
 [Email] [nvarchar] (70) NULL,
 [EmailConfirmed] [bit] NOT NULL,
 [PhoneNumber] [nvarchar] (256) NULL,
 [PhoneNumberConfirmed] [bit] NOT NULL,
 [Password] [nvarchar] (256) NULL,
 [LastPasswordChangeDate] [datetime] NULL,
 [AccessFailedCount] [int] NOT NULL,
 [AccessFailedWindowStart] [datetime] NULL,
 [LockoutEnabled] [bit] NOT NULL,
 [LockoutEndDateUtc] [datetime] NULL,
 [LastProfileUpdateDate] [datetime] NULL,
 [SecurityStamp] [nvarchar] (256) NOT NULL,
 [TwoFactorEnabled] [bit] NOT NULL,
 [oUsuario_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IdUs__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IdUs__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IdUs_Id_IdUs] PRIMARY KEY CLUSTERED
 (

  [Id]
 ) ON [PRIMARY],
 CONSTRAINT [IX_IdUs_User_IdUs] UNIQUE
 (

  [UserName] ) ON [PRIMARY],
 CONSTRAINT [IX_IdUs_Emai_IdUs] UNIQUE
 (

  [Email] ) ON [PRIMARY]
)
GO

/* no fk for 'PK_IdUe_Id_IdUe', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUe_Id_IdUe]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [PK_IdUe_Id_IdUe]
GO
/* no fk for 'DF_IdUe__trk', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trk]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [DF_IdUe__trk]
GO
/* no fk for 'DF_IdUe__trr', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trr]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [DF_IdUe__trr]
GO
CREATE TABLE [dbo].[IdUserClaim] (
 [Id] [bigint] IDENTITY (1, 1) NOT NULL,
 [Type] [nvarchar] (256) NOT NULL,
 [Value] [nvarchar] (256) NULL,
 [ValueType] [nvarchar] (256) NULL,
 [Issuer] [nvarchar] (256) NULL,
 [OriginalIssuer] [nvarchar] (256) NULL,
 [User_Id] [bigint] NOT NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IdUe__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IdUe__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IdUe_Id_IdUe] PRIMARY KEY CLUSTERED
 (

  [Id]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_IdUr_Id_IdUr', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUr_Id_IdUr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [PK_IdUr_Id_IdUr]
GO
/* no fk for 'DF_IdUr__trk', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trk]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [DF_IdUr__trk]
GO
/* no fk for 'DF_IdUr__trr', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [DF_IdUr__trr]
GO
CREATE TABLE [dbo].[IdUserLogin] (
 [Id] [bigint] IDENTITY (1, 1) NOT NULL,
 [ProviderName] [nvarchar] (256) NOT NULL,
 [ProviderKey] [nvarchar] (256) NOT NULL,
 [ProviderDisplayName] [nvarchar] (256) NOT NULL,
 [User_Id] [bigint] NOT NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IdUr__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IdUr__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IdUr_Id_IdUr] PRIMARY KEY CLUSTERED
 (

  [Id]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_IndCFEve', tableName='IndustriaCamarasFriasEvento' table='IndustriaCamarasFriasEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndCFEve]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [PK_Inds_pId_IndCFEve]
GO
/* no fk for 'DF_Indu__trk', tableName='IndustriaCamarasFriasEvento' table='IndustriaCamarasFriasEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [DF_Indu__trk]
GO
/* no fk for 'DF_Indu__trr', tableName='IndustriaCamarasFriasEvento' table='IndustriaCamarasFriasEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [DF_Indu__trr]
GO
CREATE TABLE [dbo].[IndustriaCamarasFriasEvento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [objectid] [int] NULL,
 [description] [nvarchar] (256) NULL,
 [hostname] [nvarchar] (256) NULL,
 [numOcorrencia] [int] NULL,
 [tempo_hhmmss] [nvarchar] (256) NULL,
 [tempo_dias] [int] NULL,
 [tempo_horas] [int] NULL,
 [tempo_minutos] [int] NULL,
 [tempo_segundos] [int] NULL,
 [tempo_datetime] [datetime] NULL,
 [tempo_dd] [int] NULL,
 [tempo_hh] [int] NULL,
 [tempo_mm] [int] NULL,
 [tempo_ss] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indu__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indu__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_IndCFEve] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_Creme', tableName='IndustriaCremeTempoLimpezaAutomatico' table='IndustriaCremeTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Creme]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Creme]
GO
/* no fk for 'DF_Inds__trk', tableName='IndustriaCremeTempoLimpezaAutomatico' table='IndustriaCremeTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Inds__trk]
GO
/* no fk for 'DF_Inds__trr', tableName='IndustriaCremeTempoLimpezaAutomatico' table='IndustriaCremeTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Inds__trr]
GO
CREATE TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [limpeza_tempo_segundos] [int] NULL,
 [limpeza_tempo_minutos] [int] NULL,
 [limpeza_tempo_horas] [int] NULL,
 [limpeza_tempo_dias] [int] NULL,
 [limpeza_tempo_dd] [int] NULL,
 [limpeza_tempo_hh] [int] NULL,
 [limpeza_tempo_mm] [int] NULL,
 [limpeza_tempo_ss] [int] NULL,
 [limpeza_tempo_hhmmss] [nvarchar] (256) NULL,
 [limpeza_tempo_datetime] [datetime] NULL,
 [automatico_tempo_segundos] [int] NULL,
 [automatico_tempo_minutos] [int] NULL,
 [automatico_tempo_horas] [int] NULL,
 [automatico_tempo_dias] [int] NULL,
 [automatico_tempo_dd] [int] NULL,
 [automatico_tempo_hh] [int] NULL,
 [automatico_tempo_mm] [int] NULL,
 [automatico_tempo_ss] [int] NULL,
 [automatico_tempo_hhmmss] [nvarchar] (256) NULL,
 [automatico_tempo_datetime] [datetime] NULL,
 [ligado_tempo_segundos] [int] NULL,
 [ligado_tempo_minutos] [int] NULL,
 [ligado_tempo_horas] [int] NULL,
 [ligado_tempo_dias] [int] NULL,
 [ligado_tempo_dd] [int] NULL,
 [ligado_tempo_hh] [int] NULL,
 [ligado_tempo_mm] [int] NULL,
 [ligado_tempo_ss] [int] NULL,
 [ligado_tempo_hhmmss] [nvarchar] (256) NULL,
 [ligado_tempo_datetime] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Inds__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Inds__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_Creme] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Indt_pId_Indt', tableName='IndustriaEnvaseContadorProducao' table='IndustriaEnvaseContadorProducao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indt_pId_Indt]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [PK_Indt_pId_Indt]
GO
/* no fk for 'DF_Indt__trk', tableName='IndustriaEnvaseContadorProducao' table='IndustriaEnvaseContadorProducao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [DF_Indt__trk]
GO
/* no fk for 'DF_Indt__trr', tableName='IndustriaEnvaseContadorProducao' table='IndustriaEnvaseContadorProducao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [DF_Indt__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvaseContadorProducao] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [envase_a_contador_producao] [decimal] (28,13) NULL,
 [envase_b_contador_producao] [decimal] (28,13) NULL,
 [envase_a_e_b_contador_producao] [decimal] (28,13) NULL,
 [envase_a_contador_producao_pote200] [decimal] (28,13) NULL,
 [envase_a_contador_producao_pote500] [decimal] (28,13) NULL,
 [envase_b_contador_producao_pote200] [decimal] (28,13) NULL,
 [envase_b_contador_producao_pote500] [decimal] (28,13) NULL,
 [envase_a_e_b_contador_producao_pote200] [decimal] (28,13) NULL,
 [envase_a_e_b_contador_producao_pote500] [decimal] (28,13) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indt__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indt__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Indt_pId_Indt] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_IndEve', tableName='IndustriaEnvaseEvento' table='IndustriaEnvaseEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndEve]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [PK_Inds_pId_IndEve]
GO
/* no fk for 'DF_Indr__trk', tableName='IndustriaEnvaseEvento' table='IndustriaEnvaseEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [DF_Indr__trk]
GO
/* no fk for 'DF_Indr__trr', tableName='IndustriaEnvaseEvento' table='IndustriaEnvaseEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [DF_Indr__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvaseEvento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [objectid] [int] NULL,
 [description] [nvarchar] (256) NULL,
 [hostname] [nvarchar] (256) NULL,
 [numOcorrencia] [int] NULL,
 [tempo_hhmmss] [nvarchar] (256) NULL,
 [tempo_dias] [int] NULL,
 [tempo_horas] [int] NULL,
 [tempo_minutos] [int] NULL,
 [tempo_segundos] [int] NULL,
 [tempo_datetime] [datetime] NULL,
 [tempo_dd] [int] NULL,
 [tempo_hh] [int] NULL,
 [tempo_mm] [int] NULL,
 [tempo_ss] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indr__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indr__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_IndEve] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Indi_pId_Indi', tableName='IndustriaEnvaseMov' table='IndustriaEnvaseMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indi_pId_Indi]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [PK_Indi_pId_Indi]
GO
/* no fk for 'DF_Indi__trk', tableName='IndustriaEnvaseMov' table='IndustriaEnvaseMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [DF_Indi__trk]
GO
/* no fk for 'DF_Indi__trr', tableName='IndustriaEnvaseMov' table='IndustriaEnvaseMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [DF_Indi__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvaseMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [itemid] [int] NULL,
 [clock] [decimal] (28,13) NULL,
 [tm] [datetime] NULL,
 [value] [decimal] (28,13) NULL,
 [name] [nvarchar] (256) NULL,
 [multiplier] [decimal] (28,13) NULL,
 [host] [nvarchar] (256) NULL,
 [ultMaqLigada] [int] NULL,
 [ultDispPote] [int] NULL,
 [ultTipoPote] [int] NULL,
 [ultPesoDesejado] [decimal] (28,13) NULL,
 [valueDifPesoDesejado] [decimal] (28,13) NULL,
 [ultStatusCorrecaoPeso] [int] NULL,
 [ultLimInfCopo] [decimal] (28,13) NULL,
 [ultLimSupCopo] [decimal] (28,13) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indi__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indi__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Indi_pId_Indi] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inda_pId_Inda', tableName='IndustriaEnvasePesoMedio' table='IndustriaEnvasePesoMedio' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inda_pId_Inda]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [PK_Inda_pId_Inda]
GO
/* no fk for 'DF_Inda__trk', tableName='IndustriaEnvasePesoMedio' table='IndustriaEnvasePesoMedio' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [DF_Inda__trk]
GO
/* no fk for 'DF_Inda__trr', tableName='IndustriaEnvasePesoMedio' table='IndustriaEnvasePesoMedio' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [DF_Inda__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvasePesoMedio] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [envase_a_peso_medio_pote200_balanca1] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_balanca1] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote200_balanca2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_balanca2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote200_balanca1e2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_balanca1e2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_balanca1] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_balanca1] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_balanca2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_balanca2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_balanca1e2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_balanca1e2] [decimal] (28,13) NULL,
 [envase_aeb_peso_medio_pote200_balanca1e2] [decimal] (28,13) NULL,
 [envase_aeb_peso_medio_pote500_balanca1e2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote200_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_a_peso_medio_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote200_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote200_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_pote500_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_a_peso_medio_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_b_peso_medio_difdesejado_balanca1] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_difdesejado_balanca2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote200_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_pote500_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_b_peso_medio_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_aeb_peso_medio_pote200_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_aeb_peso_medio_pote500_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_aeb_peso_medio_difdesejado_balanca1e2] [decimal] (28,13) NULL,
 [envase_a_ult_peso_desejado_pote200] [decimal] (28,13) NULL,
 [envase_a_ult_peso_desejado_pote500] [decimal] (28,13) NULL,
 [envase_b_ult_peso_desejado_pote200] [decimal] (28,13) NULL,
 [envase_b_ult_peso_desejado_pote500] [decimal] (28,13) NULL,
 [envase_a_media_liminfcopo_pote200] [decimal] (28,13) NULL,
 [envase_a_media_liminfcopo_pote500] [decimal] (28,13) NULL,
 [envase_a_media_limsupcopo_pote200] [decimal] (28,13) NULL,
 [envase_a_media_limsupcopo_pote500] [decimal] (28,13) NULL,
 [envase_b_media_liminfcopo_pote200] [decimal] (28,13) NULL,
 [envase_b_media_liminfcopo_pote500] [decimal] (28,13) NULL,
 [envase_b_media_limsupcopo_pote200] [decimal] (28,13) NULL,
 [envase_b_media_limsupcopo_pote500] [decimal] (28,13) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Inda__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Inda__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inda_pId_Inda] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_IndE_pId_IndE', tableName='IndustriaEnvaseSipMov' table='IndustriaEnvaseSipMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IndE_pId_IndE]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [PK_IndE_pId_IndE]
GO
/* no fk for 'DF_IndE__trk', tableName='IndustriaEnvaseSipMov' table='IndustriaEnvaseSipMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [DF_IndE__trk]
GO
/* no fk for 'DF_IndE__trr', tableName='IndustriaEnvaseSipMov' table='IndustriaEnvaseSipMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [DF_IndE__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvaseSipMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [itemid] [int] NULL,
 [clock] [decimal] (28,13) NULL,
 [tm] [datetime] NULL,
 [value] [decimal] (28,13) NULL,
 [name] [nvarchar] (256) NULL,
 [multiplier] [decimal] (28,13) NULL,
 [host] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IndE__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IndE__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_IndE_pId_IndE] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Indn_pId_Indn', tableName='IndustriaEnvaseTempoSip' table='IndustriaEnvaseTempoSip' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indn_pId_Indn]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [PK_Indn_pId_Indn]
GO
/* no fk for 'DF_Indn__trk', tableName='IndustriaEnvaseTempoSip' table='IndustriaEnvaseTempoSip' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [DF_Indn__trk]
GO
/* no fk for 'DF_Indn__trr', tableName='IndustriaEnvaseTempoSip' table='IndustriaEnvaseTempoSip' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [DF_Indn__trr]
GO
CREATE TABLE [dbo].[IndustriaEnvaseTempoSip] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [envase_a_tempo_sip_segundos] [int] NULL,
 [envase_a_tempo_sip_minutos] [int] NULL,
 [envase_a_tempo_sip_horas] [int] NULL,
 [envase_a_tempo_sip_dias] [int] NULL,
 [envase_a_tempo_sip_dd] [int] NULL,
 [envase_a_tempo_sip_hh] [int] NULL,
 [envase_a_tempo_sip_mm] [int] NULL,
 [envase_a_tempo_sip_ss] [int] NULL,
 [envase_a_tempo_sip_hhmmss] [nvarchar] (256) NULL,
 [envase_a_tempo_sip_datetime] [datetime] NULL,
 [envase_b_tempo_sip_segundos] [int] NULL,
 [envase_b_tempo_sip_minutos] [int] NULL,
 [envase_b_tempo_sip_horas] [int] NULL,
 [envase_b_tempo_sip_dias] [int] NULL,
 [envase_b_tempo_sip_dd] [int] NULL,
 [envase_b_tempo_sip_hh] [int] NULL,
 [envase_b_tempo_sip_mm] [int] NULL,
 [envase_b_tempo_sip_ss] [int] NULL,
 [envase_b_tempo_sip_hhmmss] [nvarchar] (256) NULL,
 [envase_b_tempo_sip_datetime] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indn__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indn__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Indn_pId_Indn] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_IndLEve', tableName='IndustriaLeiteEvento' table='IndustriaLeiteEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndLEve]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [PK_Inds_pId_IndLEve]
GO
/* no fk for 'DF_IndL__trk', tableName='IndustriaLeiteEvento' table='IndustriaLeiteEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [DF_IndL__trk]
GO
/* no fk for 'DF_IndL__trr', tableName='IndustriaLeiteEvento' table='IndustriaLeiteEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [DF_IndL__trr]
GO
CREATE TABLE [dbo].[IndustriaLeiteEvento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [objectid] [int] NULL,
 [description] [nvarchar] (256) NULL,
 [hostname] [nvarchar] (256) NULL,
 [numOcorrencia] [int] NULL,
 [tempo_hhmmss] [nvarchar] (256) NULL,
 [tempo_dias] [int] NULL,
 [tempo_horas] [int] NULL,
 [tempo_minutos] [int] NULL,
 [tempo_segundos] [int] NULL,
 [tempo_datetime] [datetime] NULL,
 [tempo_dd] [int] NULL,
 [tempo_hh] [int] NULL,
 [tempo_mm] [int] NULL,
 [tempo_ss] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_IndL__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_IndL__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_IndLEve] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_Leitelho', tableName='IndustriaLeitelhoTempoLimpezaAutomatico' table='IndustriaLeitelhoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Leitelho]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Leitelho]
GO
/* no fk for 'DF_Indh__trk', tableName='IndustriaLeitelhoTempoLimpezaAutomatico' table='IndustriaLeitelhoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indh__trk]
GO
/* no fk for 'DF_Indh__trr', tableName='IndustriaLeitelhoTempoLimpezaAutomatico' table='IndustriaLeitelhoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indh__trr]
GO
CREATE TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [limpeza_tempo_segundos] [int] NULL,
 [limpeza_tempo_minutos] [int] NULL,
 [limpeza_tempo_horas] [int] NULL,
 [limpeza_tempo_dias] [int] NULL,
 [limpeza_tempo_dd] [int] NULL,
 [limpeza_tempo_hh] [int] NULL,
 [limpeza_tempo_mm] [int] NULL,
 [limpeza_tempo_ss] [int] NULL,
 [limpeza_tempo_hhmmss] [nvarchar] (256) NULL,
 [limpeza_tempo_datetime] [datetime] NULL,
 [automatico_tempo_segundos] [int] NULL,
 [automatico_tempo_minutos] [int] NULL,
 [automatico_tempo_horas] [int] NULL,
 [automatico_tempo_dias] [int] NULL,
 [automatico_tempo_dd] [int] NULL,
 [automatico_tempo_hh] [int] NULL,
 [automatico_tempo_mm] [int] NULL,
 [automatico_tempo_ss] [int] NULL,
 [automatico_tempo_hhmmss] [nvarchar] (256) NULL,
 [automatico_tempo_datetime] [datetime] NULL,
 [ligado_tempo_segundos] [int] NULL,
 [ligado_tempo_minutos] [int] NULL,
 [ligado_tempo_horas] [int] NULL,
 [ligado_tempo_dias] [int] NULL,
 [ligado_tempo_dd] [int] NULL,
 [ligado_tempo_hh] [int] NULL,
 [ligado_tempo_mm] [int] NULL,
 [ligado_tempo_ss] [int] NULL,
 [ligado_tempo_hhmmss] [nvarchar] (256) NULL,
 [ligado_tempo_datetime] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indh__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indh__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_Leitelho] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Indm_pId_Indm', tableName='IndustriaLeiteTempoLimpezaAutomatico' table='IndustriaLeiteTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indm_pId_Indm]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Indm_pId_Indm]
GO
/* no fk for 'DF_Indm__trk', tableName='IndustriaLeiteTempoLimpezaAutomatico' table='IndustriaLeiteTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indm__trk]
GO
/* no fk for 'DF_Indm__trr', tableName='IndustriaLeiteTempoLimpezaAutomatico' table='IndustriaLeiteTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indm__trr]
GO
CREATE TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [limpeza_tempo_segundos] [int] NULL,
 [limpeza_tempo_minutos] [int] NULL,
 [limpeza_tempo_horas] [int] NULL,
 [limpeza_tempo_dias] [int] NULL,
 [limpeza_tempo_dd] [int] NULL,
 [limpeza_tempo_hh] [int] NULL,
 [limpeza_tempo_mm] [int] NULL,
 [limpeza_tempo_ss] [int] NULL,
 [limpeza_tempo_hhmmss] [nvarchar] (256) NULL,
 [limpeza_tempo_datetime] [datetime] NULL,
 [automatico_tempo_segundos] [int] NULL,
 [automatico_tempo_minutos] [int] NULL,
 [automatico_tempo_horas] [int] NULL,
 [automatico_tempo_dias] [int] NULL,
 [automatico_tempo_dd] [int] NULL,
 [automatico_tempo_hh] [int] NULL,
 [automatico_tempo_mm] [int] NULL,
 [automatico_tempo_ss] [int] NULL,
 [automatico_tempo_hhmmss] [nvarchar] (256) NULL,
 [automatico_tempo_datetime] [datetime] NULL,
 [ligado_tempo_segundos] [int] NULL,
 [ligado_tempo_minutos] [int] NULL,
 [ligado_tempo_horas] [int] NULL,
 [ligado_tempo_dias] [int] NULL,
 [ligado_tempo_dd] [int] NULL,
 [ligado_tempo_hh] [int] NULL,
 [ligado_tempo_mm] [int] NULL,
 [ligado_tempo_ss] [int] NULL,
 [ligado_tempo_hhmmss] [nvarchar] (256) NULL,
 [ligado_tempo_datetime] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indm__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indm__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Indm_pId_Indm] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Inds_pId_Soro', tableName='IndustriaSoroDeQueijoTempoLimpezaAutomatico' table='IndustriaSoroDeQueijoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Soro]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Soro]
GO
/* no fk for 'DF_Indo__trk', tableName='IndustriaSoroDeQueijoTempoLimpezaAutomatico' table='IndustriaSoroDeQueijoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indo__trk]
GO
/* no fk for 'DF_Indo__trr', tableName='IndustriaSoroDeQueijoTempoLimpezaAutomatico' table='IndustriaSoroDeQueijoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indo__trr]
GO
CREATE TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [idtag] [nvarchar] (256) NULL,
 [periodoINI] [nvarchar] (256) NULL,
 [periodoFIM] [nvarchar] (256) NULL,
 [limpeza_tempo_segundos] [int] NULL,
 [limpeza_tempo_minutos] [int] NULL,
 [limpeza_tempo_horas] [int] NULL,
 [limpeza_tempo_dias] [int] NULL,
 [limpeza_tempo_dd] [int] NULL,
 [limpeza_tempo_hh] [int] NULL,
 [limpeza_tempo_mm] [int] NULL,
 [limpeza_tempo_ss] [int] NULL,
 [limpeza_tempo_hhmmss] [nvarchar] (256) NULL,
 [limpeza_tempo_datetime] [datetime] NULL,
 [automatico_tempo_segundos] [int] NULL,
 [automatico_tempo_minutos] [int] NULL,
 [automatico_tempo_horas] [int] NULL,
 [automatico_tempo_dias] [int] NULL,
 [automatico_tempo_dd] [int] NULL,
 [automatico_tempo_hh] [int] NULL,
 [automatico_tempo_mm] [int] NULL,
 [automatico_tempo_ss] [int] NULL,
 [automatico_tempo_hhmmss] [nvarchar] (256) NULL,
 [automatico_tempo_datetime] [datetime] NULL,
 [ligado_tempo_segundos] [int] NULL,
 [ligado_tempo_minutos] [int] NULL,
 [ligado_tempo_horas] [int] NULL,
 [ligado_tempo_dias] [int] NULL,
 [ligado_tempo_dd] [int] NULL,
 [ligado_tempo_hh] [int] NULL,
 [ligado_tempo_mm] [int] NULL,
 [ligado_tempo_ss] [int] NULL,
 [ligado_tempo_hhmmss] [nvarchar] (256) NULL,
 [ligado_tempo_datetime] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Indo__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Indo__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Inds_pId_Soro] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_LogF_pId_LogF', tableName='LogFracionamento' table='LogFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_LogF_pId_LogF]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [PK_LogF_pId_LogF]
GO
/* no fk for 'DF_LogF__trk', tableName='LogFracionamento' table='LogFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trk]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [DF_LogF__trk]
GO
/* no fk for 'DF_LogF__trr', tableName='LogFracionamento' table='LogFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trr]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [DF_LogF__trr]
GO
CREATE TABLE [dbo].[LogFracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (max) NULL,
 [pDataMov] [datetime] NULL,
 [pCodigoProduto] [nvarchar] (256) NULL,
 [pProdutoDescricao] [nvarchar] (256) NULL,
 [pQuantidade] [float] NULL,
 [pNumOrdem] [nvarchar] (256) NULL,
 [pOrdemProduto] [nvarchar] (256) NULL,
 [pOrdemData] [date] NULL,
 [pTipo] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_LogF__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_LogF__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_LogF_pId_LogF] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_logi_pId_logi', tableName='loginregistro' table='loginregistro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_logi_pId_logi]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [PK_logi_pId_logi]
GO
/* no fk for 'DF_logi__trk', tableName='loginregistro' table='loginregistro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trk]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [DF_logi__trk]
GO
/* no fk for 'DF_logi__trr', tableName='loginregistro' table='loginregistro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trr]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [DF_logi__trr]
GO
CREATE TABLE [dbo].[loginregistro] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDataHora] [datetime] NULL,
 [pSenha] [nvarchar] (256) NULL,
 [pObsLog] [nvarchar] (256) NULL,
 [pCodigoUsuario] [int] NULL,
 [pLoginUsuario] [nvarchar] (256) NULL,
 [pFlgAdminUsuario] [nvarchar] (1) NULL,
 [pCodigoFilial] [int] NULL,
 [pCodigoEmpresa] [int] NULL,
 [pLoginValidado] [bit] NULL,
 [sUsuarioStatus] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_logi__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_logi__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_logi_pId_logi] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Lote_pId_Lote', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Lote_pId_Lote]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [PK_Lote_pId_Lote]
GO
/* no fk for 'DF_Lote__trk', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trk]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [DF_Lote__trk]
GO
/* no fk for 'DF_Lote__trr', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trr]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [DF_Lote__trr]
GO
CREATE TABLE [dbo].[LoteControleViagemAg] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pLote] [nvarchar] (256) NULL,
 [oControleViagemAg_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Lote__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Lote__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Lote_pId_Lote] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_menu_pId_menu', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menu_pId_menu]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [PK_menu_pId_menu]
GO
/* no fk for 'DF_menu__trk', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trk]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [DF_menu__trk]
GO
/* no fk for 'DF_menu__trr', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trr]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [DF_menu__trr]
GO
CREATE TABLE [dbo].[menu] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [pNomeToolStrip] [nvarchar] (256) NULL,
 [oSistema_pId] [bigint] NULL,
 [pNivelPosicao] [int] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_menu__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_menu__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_menu_pId_menu] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_menp_pId_menp', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menp_pId_menp]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [PK_menp_pId_menp]
GO
/* no fk for 'DF_menp__trk', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trk]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [DF_menp__trk]
GO
/* no fk for 'DF_menp__trr', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trr]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [DF_menp__trr]
GO
CREATE TABLE [dbo].[menupermissao] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [oUsuario_pId] [bigint] NULL,
 [oSistema_pId] [bigint] NULL,
 [pNomeToolStripPerm] [nvarchar] (256) NOT NULL,
 [pFlgPermissao] [nvarchar] (1) NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_menp__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_menp__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_menp_pId_menp] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Movi_pId_Movi', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Movi_pId_Movi]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [PK_Movi_pId_Movi]
GO
/* no fk for 'DF_Movi__trk', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trk]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [DF_Movi__trk]
GO
/* no fk for 'DF_Movi__trr', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trr]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [DF_Movi__trr]
GO
CREATE TABLE [dbo].[MovimentacaoLote] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [oProduto_pId] [bigint] NULL,
 [pLote] [nvarchar] (256) NULL,
 [pFormas] [int] NULL,
 [pDataFabricacao] [date] NULL,
 [pDataMaturacao] [date] NULL,
 [pFinalizado] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Movi__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Movi__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Movi_pId_Movi] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_NFCo_pId_NFCo', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_NFCo_pId_NFCo]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [PK_NFCo_pId_NFCo]
GO
/* no fk for 'DF_NFCo__trk', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trk]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [DF_NFCo__trk]
GO
/* no fk for 'DF_NFCo__trr', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trr]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [DF_NFCo__trr]
GO
CREATE TABLE [dbo].[NFControleViagemAg] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNFde] [nvarchar] (256) NULL,
 [pNFate] [nvarchar] (256) NULL,
 [oControleViagemAg_pId] [bigint] NULL,
 [pNFCancelada] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_NFCo__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_NFCo__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_NFCo_pId_NFCo] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_pais_pId_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [PK_pais_pId_pais]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trk]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [DF_pais__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trr]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [DF_pais__trr]
GO
CREATE TABLE [dbo].[pais] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigo] [int] NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [pSigla] [nvarchar] (3) NULL,
 [pCodigoIbge] [int] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_pais__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_pais__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_pais_pId_pais] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_pais_pSig_pais] UNIQUE
 (

  [pSigla] ) ON [PRIMARY],
 CONSTRAINT [IX_pais_pCoi_pais] UNIQUE
 (

  [pCodigoIbge] ) ON [PRIMARY],
 CONSTRAINT [IX_pais_pCod_pais] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Pale_pId_Pale', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Pale_pId_Pale]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [PK_Pale_pId_Pale]
GO
/* no fk for 'DF_Pale__trk', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trk]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [DF_Pale__trk]
GO
/* no fk for 'DF_Pale__trr', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trr]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [DF_Pale__trr]
GO
CREATE TABLE [dbo].[PaleteMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDataMov] [datetime] NULL,
 [pLote] [nvarchar] (256) NULL,
 [pQuantidade] [float] NULL,
 [pTipoMov] [nvarchar] (256) NULL,
 [oPaleteProduto_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Pale__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Pale__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Pale_pId_Pale] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Palt_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [PK_Palt_pId_Palt]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trk]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [DF_Palt__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trr]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [DF_Palt__trr]
GO
CREATE TABLE [dbo].[PaleteProduto] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodProduto] [nvarchar] (256) NULL,
 [pDescProduto] [nvarchar] (256) NULL,
 [pProdutoEmb] [nvarchar] (256) NULL,
 [pQuantidade] [float] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Palt__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Palt__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Palt_pId_Palt] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Para_pId_Para', tableName='ParametrosFracionamento' table='ParametrosFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Para_pId_Para]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [PK_Para_pId_Para]
GO
/* no fk for 'DF_Para__trk', tableName='ParametrosFracionamento' table='ParametrosFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trk]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [DF_Para__trk]
GO
/* no fk for 'DF_Para__trr', tableName='ParametrosFracionamento' table='ParametrosFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trr]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [DF_Para__trr]
GO
CREATE TABLE [dbo].[ParametrosFracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigoProduto] [nvarchar] (256) NULL,
 [pImprimeMultiplasEtiquetas] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Para__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Para__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Para_pId_Para] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Movi_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [FK_Movi_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Prou_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [FK_Prou_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Prod_pId_Prod]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [PK_Prod_pId_Prod]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Movi_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [FK_Movi_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Prou_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [FK_Prou_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trk]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [DF_Prod__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Movi_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [FK_Movi_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Prou_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [FK_Prou_oPro_pId_Prod]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trr]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [DF_Prod__trr]
GO
CREATE TABLE [dbo].[Produto] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [pDiasMaturacao] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Prod__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Prod__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Prod_pId_Prod] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Prou_pId_Prou', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Prou_pId_Prou]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [PK_Prou_pId_Prou]
GO
/* no fk for 'DF_Prou__trk', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trk]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [DF_Prou__trk]
GO
/* no fk for 'DF_Prou__trr', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trr]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [DF_Prou__trr]
GO
CREATE TABLE [dbo].[ProdutoPrevisao] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [oProduto_pId] [bigint] NULL,
 [pFormas] [int] NULL,
 [pCaixas] [int] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Prou__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Prou__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Prou_pId_Prou] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Seto_pId_Seto]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [PK_Seto_pId_Seto]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trk]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [DF_Seto__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trr]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [DF_Seto__trr]
GO
CREATE TABLE [dbo].[SetorVisita] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Seto__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Seto__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Seto_pId_Seto] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId2_pId_sist]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId2_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menu_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [FK_menu_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_sist_pId_sist]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [PK_sist_pId_sist]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId2_pId_sist]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId2_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menu_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [FK_menu_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trk]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [DF_sist__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId2_pId_sist]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId2_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menu_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [FK_menu_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trr]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [DF_sist__trr]
GO
CREATE TABLE [dbo].[sistema] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [pCodigo] [int] NOT NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_sist__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_sist__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_sist_pId_sist] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_sist_pCod_sist] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Tara_pId_Tara', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Tara_pId_Tara]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [PK_Tara_pId_Tara]
GO
/* no fk for 'DF_Tara__trk', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trk]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [DF_Tara__trk]
GO
/* no fk for 'DF_Tara__trr', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trr]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [DF_Tara__trr]
GO
CREATE TABLE [dbo].[TaraFracionamento] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [C2_PRODUTO] [nvarchar] (256) NULL,
 [G1_COMP] [nvarchar] (256) NULL,
 [oEmbalagem_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Tara__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Tara__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Tara_pId_Tara] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_uf_pId_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [PK_uf_pId_uf]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trk]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [DF_uf__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trr]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [DF_uf__trr]
GO
CREATE TABLE [dbo].[uf] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigo] [int] NOT NULL,
 [pDescricao] [nvarchar] (256) NULL,
 [pSigla] [nvarchar] (2) NULL,
 [pCodigoIbge] [int] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [oPais_pId] [bigint] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_uf__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_uf__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_uf_pId_uf] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_uf_pSig_uf] UNIQUE
 (

  [pSigla] ) ON [PRIMARY],
 CONSTRAINT [IX_uf_pCoi_uf] UNIQUE
 (

  [pCodigoIbge] ) ON [PRIMARY],
 CONSTRAINT [IX_uf_pCod_uf] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avii_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [FK_Avii_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUs_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [FK_IdUs_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_usua_pId_usua]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [PK_usua_pId_usua]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avii_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [FK_Avii_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUs_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [FK_IdUs_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trk]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [DF_usua__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avii_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [FK_Avii_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId2_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUs_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [FK_IdUs_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oUsu_pId_usua]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trr]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [DF_usua__trr]
GO
CREATE TABLE [dbo].[usuario] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pCodigo] [int] NOT NULL,
 [pLogin] [nvarchar] (20) NOT NULL,
 [pSenha] [nvarchar] (256) NULL,
 [pFlgAdmin] [nvarchar] (1) NULL,
 [sStatus] [int] NULL,
 [xDataHoraReg] [datetime] NULL,
 [xLoginReg] [nvarchar] (30) NULL,
 [oCadastro_pId] [bigint] NULL,
 [oIdUser_Id] [bigint] NULL,
 [pCodigoVendedor] [nvarchar] (256) NULL,
 [pCodigoAprovador] [nvarchar] (256) NULL,
 [pCodigoVendedorVinculado] [nvarchar] (256) NULL,
 [pCodigoSubVendedor] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_usua__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_usua__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_usua_pId_usua] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY],
 CONSTRAINT [IX_usua_pLog_usua] UNIQUE
 (

  [pLogin] ) ON [PRIMARY],
 CONSTRAINT [IX_usua_pCod_usua] UNIQUE
 (

  [pCodigo] ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Visi_pId_Visi', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Visi_pId_Visi]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [PK_Visi_pId_Visi]
GO
/* no fk for 'DF_Visi__trk', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trk]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [DF_Visi__trk]
GO
/* no fk for 'DF_Visi__trr', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trr]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [DF_Visi__trr]
GO
CREATE TABLE [dbo].[VisitaMov] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [oVisitante_pId] [bigint] NULL,
 [oFuncionario_pId] [bigint] NULL,
 [oSetor_pId] [bigint] NULL,
 [oEmpresa_pId] [bigint] NULL,
 [pDataVisita] [datetime] NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Visi__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Visi__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Visi_pId_Visi] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Vist_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [PK_Vist_pId_Vist]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trk]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [DF_Vist__trk]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trr]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [DF_Vist__trr]
GO
CREATE TABLE [dbo].[VisitanteVisita] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pNome] [nvarchar] (256) NULL,
 [pTipoFJ] [nvarchar] (256) NULL,
 [pCpfCnpj] [nvarchar] (256) NULL,
 [pRg] [nvarchar] (256) NULL,
 [pHabilitacao] [nvarchar] (256) NULL,
 [pTelefoneFixo] [nvarchar] (256) NULL,
 [pSexo] [nvarchar] (256) NULL,
 [pDeficienteFisico] [nvarchar] (256) NULL,
 [pEnderLogradouro] [nvarchar] (256) NULL,
 [pEnderComplemento] [nvarchar] (256) NULL,
 [pEnderBairro] [nvarchar] (256) NULL,
 [pEnderNumero] [nvarchar] (256) NULL,
 [pEnderCep] [nvarchar] (256) NULL,
 [oCidade_pId] [bigint] NULL,
 [pTelefoneCelular] [nvarchar] (256) NULL,
 [pEmail] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_Vist__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_Vist__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_Vist_pId_Vist] PRIMARY KEY NONCLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_WebS_pId_WebS', tableName='WebSiteMap' table='WebSiteMap' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_WebS_pId_WebS]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [PK_WebS_pId_WebS]
GO
/* no fk for 'DF_WebS__trk', tableName='WebSiteMap' table='WebSiteMap' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trk]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [DF_WebS__trk]
GO
/* no fk for 'DF_WebS__trr', tableName='WebSiteMap' table='WebSiteMap' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trr]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [DF_WebS__trr]
GO
CREATE TABLE [dbo].[WebSiteMap] (
 [pId] [bigint] IDENTITY (1, 1) NOT NULL,
 [pRelPath] [nvarchar] (256) NULL,
 [pNode] [nvarchar] (256) NULL,
 [pDescription] [nvarchar] (256) NULL,
 [_trackLastWriteTime] [datetime] NOT NULL CONSTRAINT [DF_WebS__trk] DEFAULT (GETDATE()),
 [_trackCreationTime] [datetime] NOT NULL CONSTRAINT [DF_WebS__trr] DEFAULT (GETDATE()),
 [_trackLastWriteUser] [nvarchar] (64) NOT NULL,
 [_trackCreationUser] [nvarchar] (64) NOT NULL,
 CONSTRAINT [PK_WebS_pId_WebS] PRIMARY KEY CLUSTERED
 (

  [pId]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_appl_pId_pId2_appl', tableName='apprelatorio_oUsuarios_usuario_oAppRelatorios' table='apprelatorio_oUsuarios_usuario_oAppRelatorios' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appl_pId_pId2_appl]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [PK_appl_pId_pId2_appl]
GO
CREATE TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_appl_pId_pId2_appl] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Avi__pId_pId2_Avi_', tableName='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' table='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi__pId_pId2_Avi_]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [PK_Avi__pId_pId2_Avi_]
GO
CREATE TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_Avi__pId_pId2_Avi_] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_Av10_pId_pId2_Av10', tableName='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' table='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Av10_pId_pId2_Av10]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [PK_Av10_pId_pId2_Av10]
GO
CREATE TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_Av10_pId_pId2_Av10] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_cadt_pId_pId2_cadt', tableName='cadastro_oempresas_empresa_ocadastros' table='cadastro_oempresas_empresa_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadt_pId_pId2_cadt]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [PK_cadt_pId_pId2_cadt]
GO
CREATE TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_cadt_pId_pId2_cadt] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_cadr_pId_pId2_cadr', tableName='cadastro_ocadastrostipo_cadastrotipo_ocadastros' table='cadastro_ocadastrostipo_cadastrotipo_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadr_pId_pId2_cadr]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [PK_cadr_pId_pId2_cadr]
GO
CREATE TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_cadr_pId_pId2_cadr] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_emps_pId_pId2_emps', tableName='empresa_osistemas_sistema_oempresas' table='empresa_osistemas_sistema_oempresas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_emps_pId_pId2_emps]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [PK_emps_pId_pId2_emps]
GO
CREATE TABLE [dbo].[empresa_osistemas_sistema_oempresas] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_emps_pId_pId2_emps] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_fill_pId_pId2_fill', tableName='filial_ousuarios_usuario_ofiliais' table='filial_ousuarios_usuario_ofiliais' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fill_pId_pId2_fill]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [PK_fill_pId_pId2_fill]
GO
CREATE TABLE [dbo].[filial_ousuarios_usuario_ofiliais] (
 [pId] [bigint] NOT NULL,
 [pId2] [bigint] NOT NULL,
 CONSTRAINT [PK_fill_pId_pId2_fill] PRIMARY KEY NONCLUSTERED
 (

  [pId],
  [pId2]
 ) ON [PRIMARY]
)
GO

/* no fk for 'PK_IdRe_Id_Id2_IdRe', tableName='IdRole_Users_IdUser_Roles' table='IdRole_Users_IdUser_Roles' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRe_Id_Id2_IdRe]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [PK_IdRe_Id_Id2_IdRe]
GO
CREATE TABLE [dbo].[IdRole_Users_IdUser_Roles] (
 [Id] [bigint] NOT NULL,
 [Id2] [bigint] NOT NULL,
 CONSTRAINT [PK_IdRe_Id_Id2_IdRe] PRIMARY KEY NONCLUSTERED
 (

  [Id],
  [Id2]
 ) ON [PRIMARY]
)
GO

