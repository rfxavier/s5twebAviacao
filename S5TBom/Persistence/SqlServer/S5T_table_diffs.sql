/* CodeFluent Generated . TargetVersion:Sql2014. Culture:pt-BR. UiCulture:pt-BR. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
/* no fk for 'PK_appc_pId_appc', tableName='appconfig' table='appconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appc_pId_appc]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [PK_appc_pId_appc]
GO
/* no fk for 'PK_appc_pId_appc', tableName='appconfig' table='appconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appc_pId_appc]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [PK_appc_pId_appc]
GO
ALTER TABLE [dbo].[appconfig] ADD CONSTRAINT [PK_appc_pId_appc] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_AppF_pId_AppF', tableName='AppFvendasPedidos' table='AppFvendasPedidos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AppF_pId_AppF]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [PK_AppF_pId_AppF]
GO
/* no fk for 'PK_AppF_pId_AppF', tableName='AppFvendasPedidos' table='AppFvendasPedidos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AppF_pId_AppF]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [PK_AppF_pId_AppF]
GO
ALTER TABLE [dbo].[AppFvendasPedidos] ADD CONSTRAINT [PK_AppF_pId_AppF] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Appv_pId_Appv', tableName='AppFvendasPedidosCompra' table='AppFvendasPedidosCompra' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appv_pId_Appv]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [PK_Appv_pId_Appv]
GO
/* no fk for 'PK_Appv_pId_Appv', tableName='AppFvendasPedidosCompra' table='AppFvendasPedidosCompra' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appv_pId_Appv]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [PK_Appv_pId_Appv]
GO
ALTER TABLE [dbo].[AppFvendasPedidosCompra] ADD CONSTRAINT [PK_Appv_pId_Appv] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Appe_pId_Appe', tableName='AppFvendasPedidosCompraMov' table='AppFvendasPedidosCompraMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appe_pId_Appe]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [PK_Appe_pId_Appe]
GO
/* no fk for 'PK_Appe_pId_Appe', tableName='AppFvendasPedidosCompraMov' table='AppFvendasPedidosCompraMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appe_pId_Appe]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [PK_Appe_pId_Appe]
GO
ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] ADD CONSTRAINT [PK_Appe_pId_Appe] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Appn_pId_Appn', tableName='AppFvendasPedidosMov' table='AppFvendasPedidosMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appn_pId_Appn]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [PK_Appn_pId_Appn]
GO
/* no fk for 'PK_Appn_pId_Appn', tableName='AppFvendasPedidosMov' table='AppFvendasPedidosMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Appn_pId_Appn]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [PK_Appn_pId_Appn]
GO
ALTER TABLE [dbo].[AppFvendasPedidosMov] ADD CONSTRAINT [PK_Appn_pId_Appn] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appr_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [PK_appr_pId_appr]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appr_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [PK_appr_pId_appr]
GO
ALTER TABLE [dbo].[apprelatorio] ADD CONSTRAINT [PK_appr_pId_appr] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_appr_pNoe_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [IX_appr_pNoe_appr]
GO
ALTER TABLE [dbo].[apprelatorio] ADD CONSTRAINT [IX_appr_pNoe_appr] UNIQUE
(

  [pNomeRelatorio] ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviCam]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [PK_Avi_pId_AviCam]
GO
ALTER TABLE [dbo].[AviacaoCaminhao] ADD CONSTRAINT [PK_Avi_pId_AviCam] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avic_pId_Avic', tableName='AviacaoClienteGrupos' table='AviacaoClienteGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avic_pId_Avic]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [PK_Avic_pId_Avic]
GO
/* no fk for 'PK_Avic_pId_Avic', tableName='AviacaoClienteGrupos' table='AviacaoClienteGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avic_pId_Avic]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [PK_Avic_pId_Avic]
GO
ALTER TABLE [dbo].[AviacaoClienteGrupos] ADD CONSTRAINT [PK_Avic_pId_Avic] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avio_pId_Avio', tableName='AviacaoClientes' table='AviacaoClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avio_pId_Avio]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [PK_Avio_pId_Avio]
GO
/* no fk for 'PK_Avio_pId_Avio', tableName='AviacaoClientes' table='AviacaoClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avio_pId_Avio]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [PK_Avio_pId_Avio]
GO
ALTER TABLE [dbo].[AviacaoClientes] ADD CONSTRAINT [PK_Avio_pId_Avio] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avo_pId_AviConFre', tableName='AviacaoConhecimentoFrete' table='AviacaoConhecimentoFrete' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFre]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [PK_Avo_pId_AviConFre]
GO
/* no fk for 'PK_Avo_pId_AviConFre', tableName='AviacaoConhecimentoFrete' table='AviacaoConhecimentoFrete' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFre]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [PK_Avo_pId_AviConFre]
GO
ALTER TABLE [dbo].[AviacaoConhecimentoFrete] ADD CONSTRAINT [PK_Avo_pId_AviConFre] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avo_pId_AviConFreAg', tableName='AviacaoConhecimentoFreteAgrup' table='AviacaoConhecimentoFreteAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFreAg]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [PK_Avo_pId_AviConFreAg]
GO
/* no fk for 'PK_Avo_pId_AviConFreAg', tableName='AviacaoConhecimentoFreteAgrup' table='AviacaoConhecimentoFreteAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avo_pId_AviConFreAg]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [PK_Avo_pId_AviConFreAg]
GO
ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] ADD CONSTRAINT [PK_Avo_pId_AviConFreAg] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_AviF_pId_AviF', tableName='AviacaoFinanceiro' table='AviacaoFinanceiro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviF_pId_AviF]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [PK_AviF_pId_AviF]
GO
/* no fk for 'PK_AviF_pId_AviF', tableName='AviacaoFinanceiro' table='AviacaoFinanceiro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviF_pId_AviF]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [PK_AviF_pId_AviF]
GO
ALTER TABLE [dbo].[AviacaoFinanceiro] ADD CONSTRAINT [PK_AviF_pId_AviF] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviLocLi]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [PK_Avi_pId_AviLocLi]
GO
ALTER TABLE [dbo].[AviacaoLocalLinha] ADD CONSTRAINT [PK_Avi_pId_AviLocLi] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviMot]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [PK_Avi_pId_AviMot]
GO
ALTER TABLE [dbo].[AviacaoMotorista] ADD CONSTRAINT [PK_Avi_pId_AviMot] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_AvVP_pId_AvVP', tableName='AviacaoPedidosFaturamento' table='AviacaoPedidosFaturamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AvVP_pId_AvVP]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [PK_AvVP_pId_AvVP]
GO
/* no fk for 'PK_AvVP_pId_AvVP', tableName='AviacaoPedidosFaturamento' table='AviacaoPedidosFaturamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AvVP_pId_AvVP]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [PK_AvVP_pId_AvVP]
GO
ALTER TABLE [dbo].[AviacaoPedidosFaturamento] ADD CONSTRAINT [PK_AvVP_pId_AvVP] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* column 'pModeloAnaliseByte', old length:-1, new length: 99999*/
ALTER TABLE [dbo].[AviacaoPivotAnalise] ALTER COLUMN [pModeloAnaliseByte] [varbinary] (max) NULL
/* no fk for 'PK_Avii_pId_Avii', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avii_pId_Avii]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [PK_Avii_pId_Avii]
GO
/* no fk for 'PK_Avii_pId_Avii', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avii_pId_Avii]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [PK_Avii_pId_Avii]
GO
ALTER TABLE [dbo].[AviacaoPivotAnalise] ADD CONSTRAINT [PK_Avii_pId_Avii] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avir_pId_Avir', tableName='AviacaoProdutoGrupos' table='AviacaoProdutoGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avir_pId_Avir]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [PK_Avir_pId_Avir]
GO
/* no fk for 'PK_Avir_pId_Avir', tableName='AviacaoProdutoGrupos' table='AviacaoProdutoGrupos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avir_pId_Avir]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [PK_Avir_pId_Avir]
GO
ALTER TABLE [dbo].[AviacaoProdutoGrupos] ADD CONSTRAINT [PK_Avir_pId_Avir] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avid_pId_Avid', tableName='AviacaoProdutos' table='AviacaoProdutos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avid_pId_Avid]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [PK_Avid_pId_Avid]
GO
/* no fk for 'PK_Avid_pId_Avid', tableName='AviacaoProdutos' table='AviacaoProdutos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avid_pId_Avid]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [PK_Avid_pId_Avid]
GO
ALTER TABLE [dbo].[AviacaoProdutos] ADD CONSTRAINT [PK_Avid_pId_Avid] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avie_pId_Avie', tableName='AviacaoRedespachos' table='AviacaoRedespachos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avie_pId_Avie]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [PK_Avie_pId_Avie]
GO
/* no fk for 'PK_Avie_pId_Avie', tableName='AviacaoRedespachos' table='AviacaoRedespachos' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avie_pId_Avie]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [PK_Avie_pId_Avie]
GO
ALTER TABLE [dbo].[AviacaoRedespachos] ADD CONSTRAINT [PK_Avie_pId_Avie] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_AviT_pId_AviT', tableName='AviacaoTitulosClientes' table='AviacaoTitulosClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviT_pId_AviT]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [PK_AviT_pId_AviT]
GO
/* no fk for 'PK_AviT_pId_AviT', tableName='AviacaoTitulosClientes' table='AviacaoTitulosClientes' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviT_pId_AviT]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [PK_AviT_pId_AviT]
GO
ALTER TABLE [dbo].[AviacaoTitulosClientes] ADD CONSTRAINT [PK_AviT_pId_AviT] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avis_pId_Avis', tableName='AviacaoTransportadores' table='AviacaoTransportadores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avis_pId_Avis]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [PK_Avis_pId_Avis]
GO
/* no fk for 'PK_Avis_pId_Avis', tableName='AviacaoTransportadores' table='AviacaoTransportadores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avis_pId_Avis]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [PK_Avis_pId_Avis]
GO
ALTER TABLE [dbo].[AviacaoTransportadores] ADD CONSTRAINT [PK_Avis_pId_Avis] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_AviV_pId_AviV', tableName='AviacaoVendas' table='AviacaoVendas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviV_pId_AviV]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [PK_AviV_pId_AviV]
GO
/* no fk for 'PK_AviV_pId_AviV', tableName='AviacaoVendas' table='AviacaoVendas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_AviV_pId_AviV]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [PK_AviV_pId_AviV]
GO
ALTER TABLE [dbo].[AviacaoVendas] ADD CONSTRAINT [PK_AviV_pId_AviV] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi3_pId_Avi3', tableName='AviacaoVendas3Meses' table='AviacaoVendas3Meses' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi3_pId_Avi3]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [PK_Avi3_pId_Avi3]
GO
/* no fk for 'PK_Avi3_pId_Avi3', tableName='AviacaoVendas3Meses' table='AviacaoVendas3Meses' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi3_pId_Avi3]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [PK_Avi3_pId_Avi3]
GO
ALTER TABLE [dbo].[AviacaoVendas3Meses] ADD CONSTRAINT [PK_Avi3_pId_Avi3] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi1_pId_Avi1', tableName='AviacaoVendas3MesesAnoMenos1' table='AviacaoVendas3MesesAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi1_pId_Avi1]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [PK_Avi1_pId_Avi1]
GO
/* no fk for 'PK_Avi1_pId_Avi1', tableName='AviacaoVendas3MesesAnoMenos1' table='AviacaoVendas3MesesAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi1_pId_Avi1]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [PK_Avi1_pId_Avi1]
GO
ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] ADD CONSTRAINT [PK_Avi1_pId_Avi1] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi2_pId_Avi2', tableName='AviacaoVendas3MesesAnoMenos2' table='AviacaoVendas3MesesAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi2_pId_Avi2]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [PK_Avi2_pId_Avi2]
GO
/* no fk for 'PK_Avi2_pId_Avi2', tableName='AviacaoVendas3MesesAnoMenos2' table='AviacaoVendas3MesesAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi2_pId_Avi2]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [PK_Avi2_pId_Avi2]
GO
ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] ADD CONSTRAINT [PK_Avi2_pId_Avi2] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avig_pId_Avig', tableName='AviacaoVendasAgrup' table='AviacaoVendasAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avig_pId_Avig]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [PK_Avig_pId_Avig]
GO
/* no fk for 'PK_Avig_pId_Avig', tableName='AviacaoVendasAgrup' table='AviacaoVendasAgrup' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avig_pId_Avig]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [PK_Avig_pId_Avig]
GO
ALTER TABLE [dbo].[AviacaoVendasAgrup] ADD CONSTRAINT [PK_Avig_pId_Avig] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Aviu_pId_Aviu', tableName='AviacaoVendasAgrupAnoMenos1' table='AviacaoVendasAgrupAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Aviu_pId_Aviu]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [PK_Aviu_pId_Aviu]
GO
/* no fk for 'PK_Aviu_pId_Aviu', tableName='AviacaoVendasAgrupAnoMenos1' table='AviacaoVendasAgrupAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Aviu_pId_Aviu]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [PK_Aviu_pId_Aviu]
GO
ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] ADD CONSTRAINT [PK_Aviu_pId_Aviu] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi0_pId_Avi0', tableName='AviacaoVendasAgrupAnoMenos2' table='AviacaoVendasAgrupAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi0_pId_Avi0]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [PK_Avi0_pId_Avi0]
GO
/* no fk for 'PK_Avi0_pId_Avi0', tableName='AviacaoVendasAgrupAnoMenos2' table='AviacaoVendasAgrupAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi0_pId_Avi0]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [PK_Avi0_pId_Avi0]
GO
ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] ADD CONSTRAINT [PK_Avi0_pId_Avi0] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi4_pId_Avi4', tableName='AviacaoVendasAnoMenos1' table='AviacaoVendasAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi4_pId_Avi4]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [PK_Avi4_pId_Avi4]
GO
/* no fk for 'PK_Avi4_pId_Avi4', tableName='AviacaoVendasAnoMenos1' table='AviacaoVendasAnoMenos1' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi4_pId_Avi4]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [PK_Avi4_pId_Avi4]
GO
ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] ADD CONSTRAINT [PK_Avi4_pId_Avi4] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi5_pId_Avi5', tableName='AviacaoVendasAnoMenos2' table='AviacaoVendasAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi5_pId_Avi5]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [PK_Avi5_pId_Avi5]
GO
/* no fk for 'PK_Avi5_pId_Avi5', tableName='AviacaoVendasAnoMenos2' table='AviacaoVendasAnoMenos2' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi5_pId_Avi5]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [PK_Avi5_pId_Avi5]
GO
ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] ADD CONSTRAINT [PK_Avi5_pId_Avi5] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi6_pId_Avi6', tableName='AviacaoVendasComDevolucao' table='AviacaoVendasComDevolucao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi6_pId_Avi6]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [PK_Avi6_pId_Avi6]
GO
/* no fk for 'PK_Avi6_pId_Avi6', tableName='AviacaoVendasComDevolucao' table='AviacaoVendasComDevolucao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi6_pId_Avi6]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [PK_Avi6_pId_Avi6]
GO
ALTER TABLE [dbo].[AviacaoVendasComDevolucao] ADD CONSTRAINT [PK_Avi6_pId_Avi6] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi_pId_AviVend', tableName='AviacaoVendedores' table='AviacaoVendedores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviVend]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [PK_Avi_pId_AviVend]
GO
/* no fk for 'PK_Avi_pId_AviVend', tableName='AviacaoVendedores' table='AviacaoVendedores' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviVend]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [PK_Avi_pId_AviVend]
GO
ALTER TABLE [dbo].[AviacaoVendedores] ADD CONSTRAINT [PK_Avi_pId_AviVend] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi8_pId_Avi8', tableName='AviacaoVendedoresEmail' table='AviacaoVendedoresEmail' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi8_pId_Avi8]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [PK_Avi8_pId_Avi8]
GO
/* no fk for 'PK_Avi8_pId_Avi8', tableName='AviacaoVendedoresEmail' table='AviacaoVendedoresEmail' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi8_pId_Avi8]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [PK_Avi8_pId_Avi8]
GO
ALTER TABLE [dbo].[AviacaoVendedoresEmail] ADD CONSTRAINT [PK_Avi8_pId_Avi8] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi_pId_AviViaMov]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [PK_Avi_pId_AviViaMov]
GO
ALTER TABLE [dbo].[AviacaoViagemMov] ADD CONSTRAINT [PK_Avi_pId_AviViaMov] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Bala_pId_Bala', tableName='BalancaFracionamento' table='BalancaFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Bala_pId_Bala]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [PK_Bala_pId_Bala]
GO
/* no fk for 'PK_Bala_pId_Bala', tableName='BalancaFracionamento' table='BalancaFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Bala_pId_Bala]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [PK_Bala_pId_Bala]
GO
ALTER TABLE [dbo].[BalancaFracionamento] ADD CONSTRAINT [PK_Bala_pId_Bala] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_BevB_pId_BevB', tableName='BevBoleAgri' table='BevBoleAgri' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_BevB_pId_BevB]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [PK_BevB_pId_BevB]
GO
/* no fk for 'PK_BevB_pId_BevB', tableName='BevBoleAgri' table='BevBoleAgri' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_BevB_pId_BevB]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [PK_BevB_pId_BevB]
GO
ALTER TABLE [dbo].[BevBoleAgri] ADD CONSTRAINT [PK_BevB_pId_BevB] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cada_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [PK_cada_pId_cada]
GO
ALTER TABLE [dbo].[cadastro] ADD CONSTRAINT [PK_cada_pId_cada] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_cada_pCod_cada]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [IX_cada_pCod_cada]
GO
ALTER TABLE [dbo].[cadastro] ADD CONSTRAINT [IX_cada_pCod_cada] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cads_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [PK_cads_pId_cads]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cads_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [PK_cads_pId_cads]
GO
ALTER TABLE [dbo].[cadastrotipo] ADD CONSTRAINT [PK_cads_pId_cads] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cida_pId_cida]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [PK_cida_pId_cida]
GO
ALTER TABLE [dbo].[cidade] ADD CONSTRAINT [PK_cida_pId_cida] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_cida_pCod_cida]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [IX_cida_pCod_cida]
GO
ALTER TABLE [dbo].[cidade] ADD CONSTRAINT [IX_cida_pCod_cida] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_cida_pCoi_cida]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [IX_cida_pCoi_cida]
GO
ALTER TABLE [dbo].[cidade] ADD CONSTRAINT [IX_cida_pCoi_cida] UNIQUE
(

  [pCodigoIbge] ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Cont_pId_Cont]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [PK_Cont_pId_Cont]
GO
ALTER TABLE [dbo].[ControleViagemAg] ADD CONSTRAINT [PK_Cont_pId_Cont] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_CTeC_pId_CTeC', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_CTeC_pId_CTeC]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [PK_CTeC_pId_CTeC]
GO
/* no fk for 'PK_CTeC_pId_CTeC', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_CTeC_pId_CTeC]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [PK_CTeC_pId_CTeC]
GO
ALTER TABLE [dbo].[CTeControleViagemAg] ADD CONSTRAINT [PK_CTeC_pId_CTeC] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Emba_pId_Emba]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [PK_Emba_pId_Emba]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Emba_pId_Emba]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [PK_Emba_pId_Emba]
GO
ALTER TABLE [dbo].[EmbalagemFracionamento] ADD CONSTRAINT [PK_Emba_pId_Emba] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_empr_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [PK_empr_pId_empr]
GO
ALTER TABLE [dbo].[empresa] ADD CONSTRAINT [PK_empr_pId_empr] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId2_pId_empr]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId2_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oEmp_pId_empr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oEmp_pId_empr]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_empr_pCod_empr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [IX_empr_pCod_empr]
GO
ALTER TABLE [dbo].[empresa] ADD CONSTRAINT [IX_empr_pCod_empr] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Empe_pId_Empe]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [PK_Empe_pId_Empe]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Empe_pId_Empe]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [PK_Empe_pId_Empe]
GO
ALTER TABLE [dbo].[EmpresaVisita] ADD CONSTRAINT [PK_Empe_pId_Empe] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fili_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [PK_fili_pId_fili]
GO
ALTER TABLE [dbo].[filial] ADD CONSTRAINT [PK_fili_pId_fili] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_fila_pId_fila', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fila_pId_fila]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [PK_fila_pId_fila]
GO
/* no fk for 'PK_fila_pId_fila', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fila_pId_fila]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [PK_fila_pId_fila]
GO
ALTER TABLE [dbo].[filialconfig] ADD CONSTRAINT [PK_fila_pId_fila] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frac_pId_Frac]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [PK_Frac_pId_Frac]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frac_pId_Frac]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [PK_Frac_pId_Frac]
GO
ALTER TABLE [dbo].[Fracionamento] ADD CONSTRAINT [PK_Frac_pId_Frac] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Frai_pId_Frai', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frai_pId_Frai]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [PK_Frai_pId_Frai]
GO
/* no fk for 'PK_Frai_pId_Frai', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Frai_pId_Frai]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [PK_Frai_pId_Frai]
GO
ALTER TABLE [dbo].[FracionamentoMov] ADD CONSTRAINT [PK_Frai_pId_Frai] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Func_pId_Func]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [PK_Func_pId_Func]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Func_pId_Func]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [PK_Func_pId_Func]
GO
ALTER TABLE [dbo].[FuncionarioVisita] ADD CONSTRAINT [PK_Func_pId_Func] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRo_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [PK_IdRo_Id_IdRo]
GO
ALTER TABLE [dbo].[IdRole] ADD CONSTRAINT [PK_IdRo_Id_IdRo] PRIMARY KEY CLUSTERED
(

 [Id]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRl_Role_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [FK_IdRl_Role_Id_IdRo]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_IdRo_Name_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [IX_IdRo_Name_IdRo]
GO
ALTER TABLE [dbo].[IdRole] ADD CONSTRAINT [IX_IdRo_Name_IdRo] UNIQUE
(

  [Name] ) ON [PRIMARY]
/* no fk for 'PK_IdRl_Id_IdRl', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRl_Id_IdRl]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [PK_IdRl_Id_IdRl]
GO
/* no fk for 'PK_IdRl_Id_IdRl', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRl_Id_IdRl]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [PK_IdRl_Id_IdRl]
GO
ALTER TABLE [dbo].[IdRoleClaim] ADD CONSTRAINT [PK_IdRl_Id_IdRl] PRIMARY KEY CLUSTERED
(

 [Id]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUs_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [PK_IdUs_Id_IdUs]
GO
ALTER TABLE [dbo].[IdUser] ADD CONSTRAINT [PK_IdUs_Id_IdUs] PRIMARY KEY CLUSTERED
(

 [Id]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_IdUs_User_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [IX_IdUs_User_IdUs]
GO
ALTER TABLE [dbo].[IdUser] ADD CONSTRAINT [IX_IdUs_User_IdUs] UNIQUE
(

  [UserName] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_IdUs_Emai_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [IX_IdUs_Emai_IdUs]
GO
ALTER TABLE [dbo].[IdUser] ADD CONSTRAINT [IX_IdUs_Emai_IdUs] UNIQUE
(

  [Email] ) ON [PRIMARY]
/* no fk for 'PK_IdUe_Id_IdUe', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUe_Id_IdUe]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [PK_IdUe_Id_IdUe]
GO
/* no fk for 'PK_IdUe_Id_IdUe', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUe_Id_IdUe]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [PK_IdUe_Id_IdUe]
GO
ALTER TABLE [dbo].[IdUserClaim] ADD CONSTRAINT [PK_IdUe_Id_IdUe] PRIMARY KEY CLUSTERED
(

 [Id]
 ) ON [PRIMARY]
/* no fk for 'PK_IdUr_Id_IdUr', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUr_Id_IdUr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [PK_IdUr_Id_IdUr]
GO
/* no fk for 'PK_IdUr_Id_IdUr', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdUr_Id_IdUr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [PK_IdUr_Id_IdUr]
GO
ALTER TABLE [dbo].[IdUserLogin] ADD CONSTRAINT [PK_IdUr_Id_IdUr] PRIMARY KEY CLUSTERED
(

 [Id]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_IndCFEve', tableName='IndustriaCamarasFriasEvento' table='IndustriaCamarasFriasEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndCFEve]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [PK_Inds_pId_IndCFEve]
GO
/* no fk for 'PK_Inds_pId_IndCFEve', tableName='IndustriaCamarasFriasEvento' table='IndustriaCamarasFriasEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndCFEve]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [PK_Inds_pId_IndCFEve]
GO
ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] ADD CONSTRAINT [PK_Inds_pId_IndCFEve] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_Creme', tableName='IndustriaCremeTempoLimpezaAutomatico' table='IndustriaCremeTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Creme]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Creme]
GO
/* no fk for 'PK_Inds_pId_Creme', tableName='IndustriaCremeTempoLimpezaAutomatico' table='IndustriaCremeTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Creme]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Creme]
GO
ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] ADD CONSTRAINT [PK_Inds_pId_Creme] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Indt_pId_Indt', tableName='IndustriaEnvaseContadorProducao' table='IndustriaEnvaseContadorProducao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indt_pId_Indt]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [PK_Indt_pId_Indt]
GO
/* no fk for 'PK_Indt_pId_Indt', tableName='IndustriaEnvaseContadorProducao' table='IndustriaEnvaseContadorProducao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indt_pId_Indt]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [PK_Indt_pId_Indt]
GO
ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] ADD CONSTRAINT [PK_Indt_pId_Indt] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_IndEve', tableName='IndustriaEnvaseEvento' table='IndustriaEnvaseEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndEve]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [PK_Inds_pId_IndEve]
GO
/* no fk for 'PK_Inds_pId_IndEve', tableName='IndustriaEnvaseEvento' table='IndustriaEnvaseEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndEve]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [PK_Inds_pId_IndEve]
GO
ALTER TABLE [dbo].[IndustriaEnvaseEvento] ADD CONSTRAINT [PK_Inds_pId_IndEve] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Indi_pId_Indi', tableName='IndustriaEnvaseMov' table='IndustriaEnvaseMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indi_pId_Indi]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [PK_Indi_pId_Indi]
GO
/* no fk for 'PK_Indi_pId_Indi', tableName='IndustriaEnvaseMov' table='IndustriaEnvaseMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indi_pId_Indi]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [PK_Indi_pId_Indi]
GO
ALTER TABLE [dbo].[IndustriaEnvaseMov] ADD CONSTRAINT [PK_Indi_pId_Indi] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inda_pId_Inda', tableName='IndustriaEnvasePesoMedio' table='IndustriaEnvasePesoMedio' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inda_pId_Inda]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [PK_Inda_pId_Inda]
GO
/* no fk for 'PK_Inda_pId_Inda', tableName='IndustriaEnvasePesoMedio' table='IndustriaEnvasePesoMedio' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inda_pId_Inda]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [PK_Inda_pId_Inda]
GO
ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] ADD CONSTRAINT [PK_Inda_pId_Inda] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_IndE_pId_IndE', tableName='IndustriaEnvaseSipMov' table='IndustriaEnvaseSipMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IndE_pId_IndE]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [PK_IndE_pId_IndE]
GO
/* no fk for 'PK_IndE_pId_IndE', tableName='IndustriaEnvaseSipMov' table='IndustriaEnvaseSipMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IndE_pId_IndE]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [PK_IndE_pId_IndE]
GO
ALTER TABLE [dbo].[IndustriaEnvaseSipMov] ADD CONSTRAINT [PK_IndE_pId_IndE] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Indn_pId_Indn', tableName='IndustriaEnvaseTempoSip' table='IndustriaEnvaseTempoSip' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indn_pId_Indn]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [PK_Indn_pId_Indn]
GO
/* no fk for 'PK_Indn_pId_Indn', tableName='IndustriaEnvaseTempoSip' table='IndustriaEnvaseTempoSip' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indn_pId_Indn]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [PK_Indn_pId_Indn]
GO
ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] ADD CONSTRAINT [PK_Indn_pId_Indn] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_IndLEve', tableName='IndustriaLeiteEvento' table='IndustriaLeiteEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndLEve]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [PK_Inds_pId_IndLEve]
GO
/* no fk for 'PK_Inds_pId_IndLEve', tableName='IndustriaLeiteEvento' table='IndustriaLeiteEvento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_IndLEve]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [PK_Inds_pId_IndLEve]
GO
ALTER TABLE [dbo].[IndustriaLeiteEvento] ADD CONSTRAINT [PK_Inds_pId_IndLEve] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_Leitelho', tableName='IndustriaLeitelhoTempoLimpezaAutomatico' table='IndustriaLeitelhoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Leitelho]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Leitelho]
GO
/* no fk for 'PK_Inds_pId_Leitelho', tableName='IndustriaLeitelhoTempoLimpezaAutomatico' table='IndustriaLeitelhoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Leitelho]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Leitelho]
GO
ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] ADD CONSTRAINT [PK_Inds_pId_Leitelho] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Indm_pId_Indm', tableName='IndustriaLeiteTempoLimpezaAutomatico' table='IndustriaLeiteTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indm_pId_Indm]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Indm_pId_Indm]
GO
/* no fk for 'PK_Indm_pId_Indm', tableName='IndustriaLeiteTempoLimpezaAutomatico' table='IndustriaLeiteTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Indm_pId_Indm]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Indm_pId_Indm]
GO
ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] ADD CONSTRAINT [PK_Indm_pId_Indm] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Inds_pId_Soro', tableName='IndustriaSoroDeQueijoTempoLimpezaAutomatico' table='IndustriaSoroDeQueijoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Soro]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Soro]
GO
/* no fk for 'PK_Inds_pId_Soro', tableName='IndustriaSoroDeQueijoTempoLimpezaAutomatico' table='IndustriaSoroDeQueijoTempoLimpezaAutomatico' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Inds_pId_Soro]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [PK_Inds_pId_Soro]
GO
ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] ADD CONSTRAINT [PK_Inds_pId_Soro] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* column 'pDescricao', old length:-1, new length: 9999*/
ALTER TABLE [dbo].[LogFracionamento] ALTER COLUMN [pDescricao] [nvarchar] (max) NULL
/* column 'pOrdemProduto' was not found in table 'LogFracionamento'. */
ALTER TABLE [dbo].[LogFracionamento] ADD [pOrdemProduto] [nvarchar] (256) NULL
GO
/* column 'pOrdemData' was not found in table 'LogFracionamento'. */
ALTER TABLE [dbo].[LogFracionamento] ADD [pOrdemData] [date] NULL
GO
/* column 'pTipo' was not found in table 'LogFracionamento'. */
ALTER TABLE [dbo].[LogFracionamento] ADD [pTipo] [nvarchar] (256) NULL
GO
/* no fk for 'PK_LogF_pId_LogF', tableName='LogFracionamento' table='LogFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_LogF_pId_LogF]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [PK_LogF_pId_LogF]
GO
/* no fk for 'PK_LogF_pId_LogF', tableName='LogFracionamento' table='LogFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_LogF_pId_LogF]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [PK_LogF_pId_LogF]
GO
ALTER TABLE [dbo].[LogFracionamento] ADD CONSTRAINT [PK_LogF_pId_LogF] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_logi_pId_logi', tableName='loginregistro' table='loginregistro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_logi_pId_logi]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [PK_logi_pId_logi]
GO
/* no fk for 'PK_logi_pId_logi', tableName='loginregistro' table='loginregistro' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_logi_pId_logi]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [PK_logi_pId_logi]
GO
ALTER TABLE [dbo].[loginregistro] ADD CONSTRAINT [PK_logi_pId_logi] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Lote_pId_Lote', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Lote_pId_Lote]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [PK_Lote_pId_Lote]
GO
/* no fk for 'PK_Lote_pId_Lote', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Lote_pId_Lote]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [PK_Lote_pId_Lote]
GO
ALTER TABLE [dbo].[LoteControleViagemAg] ADD CONSTRAINT [PK_Lote_pId_Lote] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_menu_pId_menu', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menu_pId_menu]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [PK_menu_pId_menu]
GO
/* no fk for 'PK_menu_pId_menu', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menu_pId_menu]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [PK_menu_pId_menu]
GO
ALTER TABLE [dbo].[menu] ADD CONSTRAINT [PK_menu_pId_menu] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_menp_pId_menp', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menp_pId_menp]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [PK_menp_pId_menp]
GO
/* no fk for 'PK_menp_pId_menp', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_menp_pId_menp]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [PK_menp_pId_menp]
GO
ALTER TABLE [dbo].[menupermissao] ADD CONSTRAINT [PK_menp_pId_menp] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Movi_pId_Movi', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Movi_pId_Movi]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [PK_Movi_pId_Movi]
GO
/* no fk for 'PK_Movi_pId_Movi', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Movi_pId_Movi]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [PK_Movi_pId_Movi]
GO
ALTER TABLE [dbo].[MovimentacaoLote] ADD CONSTRAINT [PK_Movi_pId_Movi] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_NFCo_pId_NFCo', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_NFCo_pId_NFCo]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [PK_NFCo_pId_NFCo]
GO
/* no fk for 'PK_NFCo_pId_NFCo', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_NFCo_pId_NFCo]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [PK_NFCo_pId_NFCo]
GO
ALTER TABLE [dbo].[NFControleViagemAg] ADD CONSTRAINT [PK_NFCo_pId_NFCo] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_pais_pId_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [PK_pais_pId_pais]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_pais_pId_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [PK_pais_pId_pais]
GO
ALTER TABLE [dbo].[pais] ADD CONSTRAINT [PK_pais_pId_pais] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_pais_pSig_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [IX_pais_pSig_pais]
GO
ALTER TABLE [dbo].[pais] ADD CONSTRAINT [IX_pais_pSig_pais] UNIQUE
(

  [pSigla] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_pais_pCoi_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [IX_pais_pCoi_pais]
GO
ALTER TABLE [dbo].[pais] ADD CONSTRAINT [IX_pais_pCoi_pais] UNIQUE
(

  [pCodigoIbge] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_pais_pCod_pais]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [IX_pais_pCod_pais]
GO
ALTER TABLE [dbo].[pais] ADD CONSTRAINT [IX_pais_pCod_pais] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
/* no fk for 'PK_Pale_pId_Pale', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Pale_pId_Pale]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [PK_Pale_pId_Pale]
GO
/* no fk for 'PK_Pale_pId_Pale', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Pale_pId_Pale]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [PK_Pale_pId_Pale]
GO
ALTER TABLE [dbo].[PaleteMov] ADD CONSTRAINT [PK_Pale_pId_Pale] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Palt_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [PK_Palt_pId_Palt]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Palt_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [PK_Palt_pId_Palt]
GO
ALTER TABLE [dbo].[PaleteProduto] ADD CONSTRAINT [PK_Palt_pId_Palt] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Para_pId_Para', tableName='ParametrosFracionamento' table='ParametrosFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Para_pId_Para]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [PK_Para_pId_Para]
GO
/* no fk for 'PK_Para_pId_Para', tableName='ParametrosFracionamento' table='ParametrosFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Para_pId_Para]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [PK_Para_pId_Para]
GO
ALTER TABLE [dbo].[ParametrosFracionamento] ADD CONSTRAINT [PK_Para_pId_Para] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Prod_pId_Prod]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [PK_Prod_pId_Prod]
GO
ALTER TABLE [dbo].[Produto] ADD CONSTRAINT [PK_Prod_pId_Prod] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_Prou_pId_Prou', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Prou_pId_Prou]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [PK_Prou_pId_Prou]
GO
/* no fk for 'PK_Prou_pId_Prou', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Prou_pId_Prou]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [PK_Prou_pId_Prou]
GO
ALTER TABLE [dbo].[ProdutoPrevisao] ADD CONSTRAINT [PK_Prou_pId_Prou] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Seto_pId_Seto]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [PK_Seto_pId_Seto]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Seto_pId_Seto]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [PK_Seto_pId_Seto]
GO
ALTER TABLE [dbo].[SetorVisita] ADD CONSTRAINT [PK_Seto_pId_Seto] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_sist_pId_sist]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [PK_sist_pId_sist]
GO
ALTER TABLE [dbo].[sistema] ADD CONSTRAINT [PK_sist_pId_sist] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId2_pId_sist]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId2_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menu_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [FK_menu_oSis_pId_sist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_sist_pCod_sist]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [IX_sist_pCod_sist]
GO
ALTER TABLE [dbo].[sistema] ADD CONSTRAINT [IX_sist_pCod_sist] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
/* no fk for 'PK_Tara_pId_Tara', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Tara_pId_Tara]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [PK_Tara_pId_Tara]
GO
/* no fk for 'PK_Tara_pId_Tara', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Tara_pId_Tara]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [PK_Tara_pId_Tara]
GO
ALTER TABLE [dbo].[TaraFracionamento] ADD CONSTRAINT [PK_Tara_pId_Tara] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_uf_pId_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [PK_uf_pId_uf]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_uf_pId_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [PK_uf_pId_uf]
GO
ALTER TABLE [dbo].[uf] ADD CONSTRAINT [PK_uf_pId_uf] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_uf_pSig_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [IX_uf_pSig_uf]
GO
ALTER TABLE [dbo].[uf] ADD CONSTRAINT [IX_uf_pSig_uf] UNIQUE
(

  [pSigla] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_uf_pCoi_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [IX_uf_pCoi_uf]
GO
ALTER TABLE [dbo].[uf] ADD CONSTRAINT [IX_uf_pCoi_uf] UNIQUE
(

  [pCodigoIbge] ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_uf_pCod_uf]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [IX_uf_pCod_uf]
GO
ALTER TABLE [dbo].[uf] ADD CONSTRAINT [IX_uf_pCod_uf] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_usua_pId_usua]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [PK_usua_pId_usua]
GO
ALTER TABLE [dbo].[usuario] ADD CONSTRAINT [PK_usua_pId_usua] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_usua_pLog_usua]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [IX_usua_pLog_usua]
GO
ALTER TABLE [dbo].[usuario] ADD CONSTRAINT [IX_usua_pLog_usua] UNIQUE
(

  [pLogin] ) ON [PRIMARY]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[IX_usua_pCod_usua]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [IX_usua_pCod_usua]
GO
ALTER TABLE [dbo].[usuario] ADD CONSTRAINT [IX_usua_pCod_usua] UNIQUE
(

  [pCodigo] ) ON [PRIMARY]
/* no fk for 'PK_Visi_pId_Visi', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Visi_pId_Visi]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [PK_Visi_pId_Visi]
GO
/* no fk for 'PK_Visi_pId_Visi', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Visi_pId_Visi]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [PK_Visi_pId_Visi]
GO
ALTER TABLE [dbo].[VisitaMov] ADD CONSTRAINT [PK_Visi_pId_Visi] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Vist_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [PK_Vist_pId_Vist]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Vist_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [PK_Vist_pId_Vist]
GO
ALTER TABLE [dbo].[VisitanteVisita] ADD CONSTRAINT [PK_Vist_pId_Vist] PRIMARY KEY NONCLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_WebS_pId_WebS', tableName='WebSiteMap' table='WebSiteMap' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_WebS_pId_WebS]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [PK_WebS_pId_WebS]
GO
/* no fk for 'PK_WebS_pId_WebS', tableName='WebSiteMap' table='WebSiteMap' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_WebS_pId_WebS]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [PK_WebS_pId_WebS]
GO
ALTER TABLE [dbo].[WebSiteMap] ADD CONSTRAINT [PK_WebS_pId_WebS] PRIMARY KEY CLUSTERED
(

 [pId]
 ) ON [PRIMARY]
/* no fk for 'PK_appl_pId_pId2_appl', tableName='apprelatorio_oUsuarios_usuario_oAppRelatorios' table='apprelatorio_oUsuarios_usuario_oAppRelatorios' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appl_pId_pId2_appl]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [PK_appl_pId_pId2_appl]
GO
/* no fk for 'PK_appl_pId_pId2_appl', tableName='apprelatorio_oUsuarios_usuario_oAppRelatorios' table='apprelatorio_oUsuarios_usuario_oAppRelatorios' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_appl_pId_pId2_appl]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [PK_appl_pId_pId2_appl]
GO
ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] ADD CONSTRAINT [PK_appl_pId_pId2_appl] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_Avi__pId_pId2_Avi_', tableName='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' table='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi__pId_pId2_Avi_]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [PK_Avi__pId_pId2_Avi_]
GO
/* no fk for 'PK_Avi__pId_pId2_Avi_', tableName='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' table='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Avi__pId_pId2_Avi_]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [PK_Avi__pId_pId2_Avi_]
GO
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] ADD CONSTRAINT [PK_Avi__pId_pId2_Avi_] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_Av10_pId_pId2_Av10', tableName='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' table='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Av10_pId_pId2_Av10]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [PK_Av10_pId_pId2_Av10]
GO
/* no fk for 'PK_Av10_pId_pId2_Av10', tableName='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' table='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_Av10_pId_pId2_Av10]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [PK_Av10_pId_pId2_Av10]
GO
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] ADD CONSTRAINT [PK_Av10_pId_pId2_Av10] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_cadt_pId_pId2_cadt', tableName='cadastro_oempresas_empresa_ocadastros' table='cadastro_oempresas_empresa_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadt_pId_pId2_cadt]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [PK_cadt_pId_pId2_cadt]
GO
/* no fk for 'PK_cadt_pId_pId2_cadt', tableName='cadastro_oempresas_empresa_ocadastros' table='cadastro_oempresas_empresa_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadt_pId_pId2_cadt]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [PK_cadt_pId_pId2_cadt]
GO
ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] ADD CONSTRAINT [PK_cadt_pId_pId2_cadt] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_cadr_pId_pId2_cadr', tableName='cadastro_ocadastrostipo_cadastrotipo_ocadastros' table='cadastro_ocadastrostipo_cadastrotipo_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadr_pId_pId2_cadr]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [PK_cadr_pId_pId2_cadr]
GO
/* no fk for 'PK_cadr_pId_pId2_cadr', tableName='cadastro_ocadastrostipo_cadastrotipo_ocadastros' table='cadastro_ocadastrostipo_cadastrotipo_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_cadr_pId_pId2_cadr]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [PK_cadr_pId_pId2_cadr]
GO
ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] ADD CONSTRAINT [PK_cadr_pId_pId2_cadr] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_emps_pId_pId2_emps', tableName='empresa_osistemas_sistema_oempresas' table='empresa_osistemas_sistema_oempresas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_emps_pId_pId2_emps]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [PK_emps_pId_pId2_emps]
GO
/* no fk for 'PK_emps_pId_pId2_emps', tableName='empresa_osistemas_sistema_oempresas' table='empresa_osistemas_sistema_oempresas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_emps_pId_pId2_emps]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [PK_emps_pId_pId2_emps]
GO
ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] ADD CONSTRAINT [PK_emps_pId_pId2_emps] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_fill_pId_pId2_fill', tableName='filial_ousuarios_usuario_ofiliais' table='filial_ousuarios_usuario_ofiliais' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fill_pId_pId2_fill]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [PK_fill_pId_pId2_fill]
GO
/* no fk for 'PK_fill_pId_pId2_fill', tableName='filial_ousuarios_usuario_ofiliais' table='filial_ousuarios_usuario_ofiliais' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_fill_pId_pId2_fill]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [PK_fill_pId_pId2_fill]
GO
ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] ADD CONSTRAINT [PK_fill_pId_pId2_fill] PRIMARY KEY NONCLUSTERED
(

 [pId],
 [pId2]
 ) ON [PRIMARY]
/* no fk for 'PK_IdRe_Id_Id2_IdRe', tableName='IdRole_Users_IdUser_Roles' table='IdRole_Users_IdUser_Roles' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRe_Id_Id2_IdRe]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [PK_IdRe_Id_Id2_IdRe]
GO
/* no fk for 'PK_IdRe_Id_Id2_IdRe', tableName='IdRole_Users_IdUser_Roles' table='IdRole_Users_IdUser_Roles' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[PK_IdRe_Id_Id2_IdRe]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [PK_IdRe_Id_Id2_IdRe]
GO
ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] ADD CONSTRAINT [PK_IdRe_Id_Id2_IdRe] PRIMARY KEY NONCLUSTERED
(

 [Id],
 [Id2]
 ) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trk]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trk]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [DF_appc__trk]

 ALTER TABLE [dbo].[appconfig] ADD CONSTRAINT [DF_appc__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trr]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appc__trr]') AND parent_obj = object_id(N'[dbo].[appconfig]'))
 ALTER TABLE [dbo].[appconfig] DROP CONSTRAINT [DF_appc__trr]

 ALTER TABLE [dbo].[appconfig] ADD CONSTRAINT [DF_appc__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [DF_AppF__trk]

 ALTER TABLE [dbo].[AppFvendasPedidos] ADD CONSTRAINT [DF_AppF__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AppF__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidos]'))
 ALTER TABLE [dbo].[AppFvendasPedidos] DROP CONSTRAINT [DF_AppF__trr]

 ALTER TABLE [dbo].[AppFvendasPedidos] ADD CONSTRAINT [DF_AppF__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [DF_Appv__trk]

 ALTER TABLE [dbo].[AppFvendasPedidosCompra] ADD CONSTRAINT [DF_Appv__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appv__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompra]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompra] DROP CONSTRAINT [DF_Appv__trr]

 ALTER TABLE [dbo].[AppFvendasPedidosCompra] ADD CONSTRAINT [DF_Appv__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [DF_Appe__trk]

 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] ADD CONSTRAINT [DF_Appe__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appe__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosCompraMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] DROP CONSTRAINT [DF_Appe__trr]

 ALTER TABLE [dbo].[AppFvendasPedidosCompraMov] ADD CONSTRAINT [DF_Appe__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trk]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [DF_Appn__trk]

 ALTER TABLE [dbo].[AppFvendasPedidosMov] ADD CONSTRAINT [DF_Appn__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Appn__trr]') AND parent_obj = object_id(N'[dbo].[AppFvendasPedidosMov]'))
 ALTER TABLE [dbo].[AppFvendasPedidosMov] DROP CONSTRAINT [DF_Appn__trr]

 ALTER TABLE [dbo].[AppFvendasPedidosMov] ADD CONSTRAINT [DF_Appn__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trk]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trk]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [DF_appr__trk]

 ALTER TABLE [dbo].[apprelatorio] ADD CONSTRAINT [DF_appr__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_appr__trr]') AND parent_obj = object_id(N'[dbo].[apprelatorio]'))
 ALTER TABLE [dbo].[apprelatorio] DROP CONSTRAINT [DF_appr__trr]

 ALTER TABLE [dbo].[apprelatorio] ADD CONSTRAINT [DF_appr__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [DF_Avia__trk]

 ALTER TABLE [dbo].[AviacaoCaminhao] ADD CONSTRAINT [DF_Avia__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avia__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [DF_Avia__trr]

 ALTER TABLE [dbo].[AviacaoCaminhao] ADD CONSTRAINT [DF_Avia__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [DF_Avic__trk]

 ALTER TABLE [dbo].[AviacaoClienteGrupos] ADD CONSTRAINT [DF_Avic__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avic__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClienteGrupos]'))
 ALTER TABLE [dbo].[AviacaoClienteGrupos] DROP CONSTRAINT [DF_Avic__trr]

 ALTER TABLE [dbo].[AviacaoClienteGrupos] ADD CONSTRAINT [DF_Avic__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [DF_Avio__trk]

 ALTER TABLE [dbo].[AviacaoClientes] ADD CONSTRAINT [DF_Avio__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avio__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoClientes]'))
 ALTER TABLE [dbo].[AviacaoClientes] DROP CONSTRAINT [DF_Avio__trr]

 ALTER TABLE [dbo].[AviacaoClientes] ADD CONSTRAINT [DF_Avio__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [DF_Avin__trk]

 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] ADD CONSTRAINT [DF_Avin__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avin__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFrete]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] DROP CONSTRAINT [DF_Avin__trr]

 ALTER TABLE [dbo].[AviacaoConhecimentoFrete] ADD CONSTRAINT [DF_Avin__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [DF_Avih__trk]

 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] ADD CONSTRAINT [DF_Avih__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avih__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoConhecimentoFreteAgrup]'))
 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] DROP CONSTRAINT [DF_Avih__trr]

 ALTER TABLE [dbo].[AviacaoConhecimentoFreteAgrup] ADD CONSTRAINT [DF_Avih__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [DF_AviF__trk]

 ALTER TABLE [dbo].[AviacaoFinanceiro] ADD CONSTRAINT [DF_AviF__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviF__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoFinanceiro]'))
 ALTER TABLE [dbo].[AviacaoFinanceiro] DROP CONSTRAINT [DF_AviF__trr]

 ALTER TABLE [dbo].[AviacaoFinanceiro] ADD CONSTRAINT [DF_AviF__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [DF_AviL__trk]

 ALTER TABLE [dbo].[AviacaoLocalLinha] ADD CONSTRAINT [DF_AviL__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviL__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha] DROP CONSTRAINT [DF_AviL__trr]

 ALTER TABLE [dbo].[AviacaoLocalLinha] ADD CONSTRAINT [DF_AviL__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [DF_AviM__trk]

 ALTER TABLE [dbo].[AviacaoMotorista] ADD CONSTRAINT [DF_AviM__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviM__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoMotorista]'))
 ALTER TABLE [dbo].[AviacaoMotorista] DROP CONSTRAINT [DF_AviM__trr]

 ALTER TABLE [dbo].[AviacaoMotorista] ADD CONSTRAINT [DF_AviM__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [DF_AviP__trk]

 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] ADD CONSTRAINT [DF_AviP__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviP__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPedidosFaturamento]'))
 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] DROP CONSTRAINT [DF_AviP__trr]

 ALTER TABLE [dbo].[AviacaoPedidosFaturamento] ADD CONSTRAINT [DF_AviP__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [DF_Avii__trk]

 ALTER TABLE [dbo].[AviacaoPivotAnalise] ADD CONSTRAINT [DF_Avii__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avii__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [DF_Avii__trr]

 ALTER TABLE [dbo].[AviacaoPivotAnalise] ADD CONSTRAINT [DF_Avii__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [DF_Avir__trk]

 ALTER TABLE [dbo].[AviacaoProdutoGrupos] ADD CONSTRAINT [DF_Avir__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avir__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutoGrupos]'))
 ALTER TABLE [dbo].[AviacaoProdutoGrupos] DROP CONSTRAINT [DF_Avir__trr]

 ALTER TABLE [dbo].[AviacaoProdutoGrupos] ADD CONSTRAINT [DF_Avir__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [DF_Avid__trk]

 ALTER TABLE [dbo].[AviacaoProdutos] ADD CONSTRAINT [DF_Avid__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avid__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoProdutos]'))
 ALTER TABLE [dbo].[AviacaoProdutos] DROP CONSTRAINT [DF_Avid__trr]

 ALTER TABLE [dbo].[AviacaoProdutos] ADD CONSTRAINT [DF_Avid__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [DF_Avie__trk]

 ALTER TABLE [dbo].[AviacaoRedespachos] ADD CONSTRAINT [DF_Avie__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avie__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoRedespachos]'))
 ALTER TABLE [dbo].[AviacaoRedespachos] DROP CONSTRAINT [DF_Avie__trr]

 ALTER TABLE [dbo].[AviacaoRedespachos] ADD CONSTRAINT [DF_Avie__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [DF_AviT__trk]

 ALTER TABLE [dbo].[AviacaoTitulosClientes] ADD CONSTRAINT [DF_AviT__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviT__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTitulosClientes]'))
 ALTER TABLE [dbo].[AviacaoTitulosClientes] DROP CONSTRAINT [DF_AviT__trr]

 ALTER TABLE [dbo].[AviacaoTitulosClientes] ADD CONSTRAINT [DF_AviT__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [DF_Avis__trk]

 ALTER TABLE [dbo].[AviacaoTransportadores] ADD CONSTRAINT [DF_Avis__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avis__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoTransportadores]'))
 ALTER TABLE [dbo].[AviacaoTransportadores] DROP CONSTRAINT [DF_Avis__trr]

 ALTER TABLE [dbo].[AviacaoTransportadores] ADD CONSTRAINT [DF_Avis__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [DF_AviV__trk]

 ALTER TABLE [dbo].[AviacaoVendas] ADD CONSTRAINT [DF_AviV__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_AviV__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas]'))
 ALTER TABLE [dbo].[AviacaoVendas] DROP CONSTRAINT [DF_AviV__trr]

 ALTER TABLE [dbo].[AviacaoVendas] ADD CONSTRAINT [DF_AviV__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [DF_Avi3__trk]

 ALTER TABLE [dbo].[AviacaoVendas3Meses] ADD CONSTRAINT [DF_Avi3__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi3__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3Meses]'))
 ALTER TABLE [dbo].[AviacaoVendas3Meses] DROP CONSTRAINT [DF_Avi3__trr]

 ALTER TABLE [dbo].[AviacaoVendas3Meses] ADD CONSTRAINT [DF_Avi3__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [DF_Avi1__trk]

 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] ADD CONSTRAINT [DF_Avi1__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi1__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] DROP CONSTRAINT [DF_Avi1__trr]

 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos1] ADD CONSTRAINT [DF_Avi1__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [DF_Avi2__trk]

 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] ADD CONSTRAINT [DF_Avi2__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi2__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendas3MesesAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] DROP CONSTRAINT [DF_Avi2__trr]

 ALTER TABLE [dbo].[AviacaoVendas3MesesAnoMenos2] ADD CONSTRAINT [DF_Avi2__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [DF_Avig__trk]

 ALTER TABLE [dbo].[AviacaoVendasAgrup] ADD CONSTRAINT [DF_Avig__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avig__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrup]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrup] DROP CONSTRAINT [DF_Avig__trr]

 ALTER TABLE [dbo].[AviacaoVendasAgrup] ADD CONSTRAINT [DF_Avig__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [DF_Aviu__trk]

 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] ADD CONSTRAINT [DF_Aviu__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Aviu__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] DROP CONSTRAINT [DF_Aviu__trr]

 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos1] ADD CONSTRAINT [DF_Aviu__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [DF_Avi0__trk]

 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] ADD CONSTRAINT [DF_Avi0__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi0__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAgrupAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] DROP CONSTRAINT [DF_Avi0__trr]

 ALTER TABLE [dbo].[AviacaoVendasAgrupAnoMenos2] ADD CONSTRAINT [DF_Avi0__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [DF_Avi4__trk]

 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] ADD CONSTRAINT [DF_Avi4__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi4__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos1]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] DROP CONSTRAINT [DF_Avi4__trr]

 ALTER TABLE [dbo].[AviacaoVendasAnoMenos1] ADD CONSTRAINT [DF_Avi4__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [DF_Avi5__trk]

 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] ADD CONSTRAINT [DF_Avi5__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi5__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasAnoMenos2]'))
 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] DROP CONSTRAINT [DF_Avi5__trr]

 ALTER TABLE [dbo].[AviacaoVendasAnoMenos2] ADD CONSTRAINT [DF_Avi5__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [DF_Avi6__trk]

 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] ADD CONSTRAINT [DF_Avi6__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi6__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendasComDevolucao]'))
 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] DROP CONSTRAINT [DF_Avi6__trr]

 ALTER TABLE [dbo].[AviacaoVendasComDevolucao] ADD CONSTRAINT [DF_Avi6__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [DF_Avi7__trk]

 ALTER TABLE [dbo].[AviacaoVendedores] ADD CONSTRAINT [DF_Avi7__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi7__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedores]'))
 ALTER TABLE [dbo].[AviacaoVendedores] DROP CONSTRAINT [DF_Avi7__trr]

 ALTER TABLE [dbo].[AviacaoVendedores] ADD CONSTRAINT [DF_Avi7__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [DF_Avi8__trk]

 ALTER TABLE [dbo].[AviacaoVendedoresEmail] ADD CONSTRAINT [DF_Avi8__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi8__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoVendedoresEmail]'))
 ALTER TABLE [dbo].[AviacaoVendedoresEmail] DROP CONSTRAINT [DF_Avi8__trr]

 ALTER TABLE [dbo].[AviacaoVendedoresEmail] ADD CONSTRAINT [DF_Avi8__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trk]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [DF_Avi9__trk]

 ALTER TABLE [dbo].[AviacaoViagemMov] ADD CONSTRAINT [DF_Avi9__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Avi9__trr]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [DF_Avi9__trr]

 ALTER TABLE [dbo].[AviacaoViagemMov] ADD CONSTRAINT [DF_Avi9__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trk]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trk]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [DF_Bala__trk]

 ALTER TABLE [dbo].[BalancaFracionamento] ADD CONSTRAINT [DF_Bala__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trr]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Bala__trr]') AND parent_obj = object_id(N'[dbo].[BalancaFracionamento]'))
 ALTER TABLE [dbo].[BalancaFracionamento] DROP CONSTRAINT [DF_Bala__trr]

 ALTER TABLE [dbo].[BalancaFracionamento] ADD CONSTRAINT [DF_Bala__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trk]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trk]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [DF_BevB__trk]

 ALTER TABLE [dbo].[BevBoleAgri] ADD CONSTRAINT [DF_BevB__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trr]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_BevB__trr]') AND parent_obj = object_id(N'[dbo].[BevBoleAgri]'))
 ALTER TABLE [dbo].[BevBoleAgri] DROP CONSTRAINT [DF_BevB__trr]

 ALTER TABLE [dbo].[BevBoleAgri] ADD CONSTRAINT [DF_BevB__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trk]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trk]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [DF_cada__trk]

 ALTER TABLE [dbo].[cadastro] ADD CONSTRAINT [DF_cada__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trr]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cada__trr]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [DF_cada__trr]

 ALTER TABLE [dbo].[cadastro] ADD CONSTRAINT [DF_cada__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trk]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trk]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [DF_cads__trk]

 ALTER TABLE [dbo].[cadastrotipo] ADD CONSTRAINT [DF_cads__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trr]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cads__trr]') AND parent_obj = object_id(N'[dbo].[cadastrotipo]'))
 ALTER TABLE [dbo].[cadastrotipo] DROP CONSTRAINT [DF_cads__trr]

 ALTER TABLE [dbo].[cadastrotipo] ADD CONSTRAINT [DF_cads__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trk]') AND parent_obj = object_id(N'[dbo].[cidade]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trk]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [DF_cida__trk]

 ALTER TABLE [dbo].[cidade] ADD CONSTRAINT [DF_cida__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trr]') AND parent_obj = object_id(N'[dbo].[cidade]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_cida__trr]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [DF_cida__trr]

 ALTER TABLE [dbo].[cidade] ADD CONSTRAINT [DF_cida__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trk]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trk]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [DF_Cont__trk]

 ALTER TABLE [dbo].[ControleViagemAg] ADD CONSTRAINT [DF_Cont__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trr]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Cont__trr]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [DF_Cont__trr]

 ALTER TABLE [dbo].[ControleViagemAg] ADD CONSTRAINT [DF_Cont__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trk]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trk]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [DF_CTeC__trk]

 ALTER TABLE [dbo].[CTeControleViagemAg] ADD CONSTRAINT [DF_CTeC__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trr]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_CTeC__trr]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [DF_CTeC__trr]

 ALTER TABLE [dbo].[CTeControleViagemAg] ADD CONSTRAINT [DF_CTeC__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trk]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trk]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [DF_Emba__trk]

 ALTER TABLE [dbo].[EmbalagemFracionamento] ADD CONSTRAINT [DF_Emba__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trr]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Emba__trr]') AND parent_obj = object_id(N'[dbo].[EmbalagemFracionamento]'))
 ALTER TABLE [dbo].[EmbalagemFracionamento] DROP CONSTRAINT [DF_Emba__trr]

 ALTER TABLE [dbo].[EmbalagemFracionamento] ADD CONSTRAINT [DF_Emba__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trk]') AND parent_obj = object_id(N'[dbo].[empresa]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trk]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [DF_empr__trk]

 ALTER TABLE [dbo].[empresa] ADD CONSTRAINT [DF_empr__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_empr__trr]') AND parent_obj = object_id(N'[dbo].[empresa]'))
 ALTER TABLE [dbo].[empresa] DROP CONSTRAINT [DF_empr__trr]

 ALTER TABLE [dbo].[empresa] ADD CONSTRAINT [DF_empr__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trk]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trk]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [DF_Empe__trk]

 ALTER TABLE [dbo].[EmpresaVisita] ADD CONSTRAINT [DF_Empe__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trr]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Empe__trr]') AND parent_obj = object_id(N'[dbo].[EmpresaVisita]'))
 ALTER TABLE [dbo].[EmpresaVisita] DROP CONSTRAINT [DF_Empe__trr]

 ALTER TABLE [dbo].[EmpresaVisita] ADD CONSTRAINT [DF_Empe__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trk]') AND parent_obj = object_id(N'[dbo].[filial]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trk]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [DF_fili__trk]

 ALTER TABLE [dbo].[filial] ADD CONSTRAINT [DF_fili__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trr]') AND parent_obj = object_id(N'[dbo].[filial]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fili__trr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [DF_fili__trr]

 ALTER TABLE [dbo].[filial] ADD CONSTRAINT [DF_fili__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trk]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trk]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [DF_fila__trk]

 ALTER TABLE [dbo].[filialconfig] ADD CONSTRAINT [DF_fila__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trr]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_fila__trr]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [DF_fila__trr]

 ALTER TABLE [dbo].[filialconfig] ADD CONSTRAINT [DF_fila__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trk]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trk]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [DF_Frac__trk]

 ALTER TABLE [dbo].[Fracionamento] ADD CONSTRAINT [DF_Frac__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trr]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frac__trr]') AND parent_obj = object_id(N'[dbo].[Fracionamento]'))
 ALTER TABLE [dbo].[Fracionamento] DROP CONSTRAINT [DF_Frac__trr]

 ALTER TABLE [dbo].[Fracionamento] ADD CONSTRAINT [DF_Frac__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trk]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trk]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [DF_Frai__trk]

 ALTER TABLE [dbo].[FracionamentoMov] ADD CONSTRAINT [DF_Frai__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trr]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Frai__trr]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [DF_Frai__trr]

 ALTER TABLE [dbo].[FracionamentoMov] ADD CONSTRAINT [DF_Frai__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trk]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trk]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [DF_Func__trk]

 ALTER TABLE [dbo].[FuncionarioVisita] ADD CONSTRAINT [DF_Func__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trr]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Func__trr]') AND parent_obj = object_id(N'[dbo].[FuncionarioVisita]'))
 ALTER TABLE [dbo].[FuncionarioVisita] DROP CONSTRAINT [DF_Func__trr]

 ALTER TABLE [dbo].[FuncionarioVisita] ADD CONSTRAINT [DF_Func__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trk]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trk]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [DF_IdRo__trk]

 ALTER TABLE [dbo].[IdRole] ADD CONSTRAINT [DF_IdRo__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trr]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRo__trr]') AND parent_obj = object_id(N'[dbo].[IdRole]'))
 ALTER TABLE [dbo].[IdRole] DROP CONSTRAINT [DF_IdRo__trr]

 ALTER TABLE [dbo].[IdRole] ADD CONSTRAINT [DF_IdRo__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trk]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trk]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [DF_IdRl__trk]

 ALTER TABLE [dbo].[IdRoleClaim] ADD CONSTRAINT [DF_IdRl__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trr]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdRl__trr]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [DF_IdRl__trr]

 ALTER TABLE [dbo].[IdRoleClaim] ADD CONSTRAINT [DF_IdRl__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trk]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trk]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [DF_IdUs__trk]

 ALTER TABLE [dbo].[IdUser] ADD CONSTRAINT [DF_IdUs__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trr]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUs__trr]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [DF_IdUs__trr]

 ALTER TABLE [dbo].[IdUser] ADD CONSTRAINT [DF_IdUs__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trk]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trk]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [DF_IdUe__trk]

 ALTER TABLE [dbo].[IdUserClaim] ADD CONSTRAINT [DF_IdUe__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trr]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUe__trr]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [DF_IdUe__trr]

 ALTER TABLE [dbo].[IdUserClaim] ADD CONSTRAINT [DF_IdUe__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trk]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trk]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [DF_IdUr__trk]

 ALTER TABLE [dbo].[IdUserLogin] ADD CONSTRAINT [DF_IdUr__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IdUr__trr]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [DF_IdUr__trr]

 ALTER TABLE [dbo].[IdUserLogin] ADD CONSTRAINT [DF_IdUr__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [DF_Indu__trk]

 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] ADD CONSTRAINT [DF_Indu__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indu__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCamarasFriasEvento]'))
 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] DROP CONSTRAINT [DF_Indu__trr]

 ALTER TABLE [dbo].[IndustriaCamarasFriasEvento] ADD CONSTRAINT [DF_Indu__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Inds__trk]

 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Inds__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inds__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaCremeTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Inds__trr]

 ALTER TABLE [dbo].[IndustriaCremeTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Inds__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [DF_Indt__trk]

 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] ADD CONSTRAINT [DF_Indt__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indt__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseContadorProducao]'))
 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] DROP CONSTRAINT [DF_Indt__trr]

 ALTER TABLE [dbo].[IndustriaEnvaseContadorProducao] ADD CONSTRAINT [DF_Indt__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [DF_Indr__trk]

 ALTER TABLE [dbo].[IndustriaEnvaseEvento] ADD CONSTRAINT [DF_Indr__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indr__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseEvento]'))
 ALTER TABLE [dbo].[IndustriaEnvaseEvento] DROP CONSTRAINT [DF_Indr__trr]

 ALTER TABLE [dbo].[IndustriaEnvaseEvento] ADD CONSTRAINT [DF_Indr__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [DF_Indi__trk]

 ALTER TABLE [dbo].[IndustriaEnvaseMov] ADD CONSTRAINT [DF_Indi__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indi__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseMov] DROP CONSTRAINT [DF_Indi__trr]

 ALTER TABLE [dbo].[IndustriaEnvaseMov] ADD CONSTRAINT [DF_Indi__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [DF_Inda__trk]

 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] ADD CONSTRAINT [DF_Inda__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Inda__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvasePesoMedio]'))
 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] DROP CONSTRAINT [DF_Inda__trr]

 ALTER TABLE [dbo].[IndustriaEnvasePesoMedio] ADD CONSTRAINT [DF_Inda__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [DF_IndE__trk]

 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] ADD CONSTRAINT [DF_IndE__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndE__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseSipMov]'))
 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] DROP CONSTRAINT [DF_IndE__trr]

 ALTER TABLE [dbo].[IndustriaEnvaseSipMov] ADD CONSTRAINT [DF_IndE__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [DF_Indn__trk]

 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] ADD CONSTRAINT [DF_Indn__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indn__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaEnvaseTempoSip]'))
 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] DROP CONSTRAINT [DF_Indn__trr]

 ALTER TABLE [dbo].[IndustriaEnvaseTempoSip] ADD CONSTRAINT [DF_Indn__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [DF_IndL__trk]

 ALTER TABLE [dbo].[IndustriaLeiteEvento] ADD CONSTRAINT [DF_IndL__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_IndL__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteEvento]'))
 ALTER TABLE [dbo].[IndustriaLeiteEvento] DROP CONSTRAINT [DF_IndL__trr]

 ALTER TABLE [dbo].[IndustriaLeiteEvento] ADD CONSTRAINT [DF_IndL__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indh__trk]

 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indh__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indh__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeitelhoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indh__trr]

 ALTER TABLE [dbo].[IndustriaLeitelhoTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indh__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indm__trk]

 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indm__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indm__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaLeiteTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indm__trr]

 ALTER TABLE [dbo].[IndustriaLeiteTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indm__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trk]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indo__trk]

 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indo__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Indo__trr]') AND parent_obj = object_id(N'[dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico]'))
 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] DROP CONSTRAINT [DF_Indo__trr]

 ALTER TABLE [dbo].[IndustriaSoroDeQueijoTempoLimpezaAutomatico] ADD CONSTRAINT [DF_Indo__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trk]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trk]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [DF_LogF__trk]

 ALTER TABLE [dbo].[LogFracionamento] ADD CONSTRAINT [DF_LogF__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trr]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_LogF__trr]') AND parent_obj = object_id(N'[dbo].[LogFracionamento]'))
 ALTER TABLE [dbo].[LogFracionamento] DROP CONSTRAINT [DF_LogF__trr]

 ALTER TABLE [dbo].[LogFracionamento] ADD CONSTRAINT [DF_LogF__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trk]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trk]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [DF_logi__trk]

 ALTER TABLE [dbo].[loginregistro] ADD CONSTRAINT [DF_logi__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trr]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_logi__trr]') AND parent_obj = object_id(N'[dbo].[loginregistro]'))
 ALTER TABLE [dbo].[loginregistro] DROP CONSTRAINT [DF_logi__trr]

 ALTER TABLE [dbo].[loginregistro] ADD CONSTRAINT [DF_logi__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trk]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trk]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [DF_Lote__trk]

 ALTER TABLE [dbo].[LoteControleViagemAg] ADD CONSTRAINT [DF_Lote__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trr]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Lote__trr]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [DF_Lote__trr]

 ALTER TABLE [dbo].[LoteControleViagemAg] ADD CONSTRAINT [DF_Lote__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trk]') AND parent_obj = object_id(N'[dbo].[menu]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trk]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [DF_menu__trk]

 ALTER TABLE [dbo].[menu] ADD CONSTRAINT [DF_menu__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trr]') AND parent_obj = object_id(N'[dbo].[menu]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menu__trr]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [DF_menu__trr]

 ALTER TABLE [dbo].[menu] ADD CONSTRAINT [DF_menu__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trk]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trk]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [DF_menp__trk]

 ALTER TABLE [dbo].[menupermissao] ADD CONSTRAINT [DF_menp__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trr]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_menp__trr]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [DF_menp__trr]

 ALTER TABLE [dbo].[menupermissao] ADD CONSTRAINT [DF_menp__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trk]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trk]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [DF_Movi__trk]

 ALTER TABLE [dbo].[MovimentacaoLote] ADD CONSTRAINT [DF_Movi__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trr]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Movi__trr]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [DF_Movi__trr]

 ALTER TABLE [dbo].[MovimentacaoLote] ADD CONSTRAINT [DF_Movi__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trk]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trk]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [DF_NFCo__trk]

 ALTER TABLE [dbo].[NFControleViagemAg] ADD CONSTRAINT [DF_NFCo__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trr]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_NFCo__trr]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [DF_NFCo__trr]

 ALTER TABLE [dbo].[NFControleViagemAg] ADD CONSTRAINT [DF_NFCo__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trk]') AND parent_obj = object_id(N'[dbo].[pais]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trk]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [DF_pais__trk]

 ALTER TABLE [dbo].[pais] ADD CONSTRAINT [DF_pais__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trr]') AND parent_obj = object_id(N'[dbo].[pais]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_pais__trr]') AND parent_obj = object_id(N'[dbo].[pais]'))
 ALTER TABLE [dbo].[pais] DROP CONSTRAINT [DF_pais__trr]

 ALTER TABLE [dbo].[pais] ADD CONSTRAINT [DF_pais__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trk]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trk]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [DF_Pale__trk]

 ALTER TABLE [dbo].[PaleteMov] ADD CONSTRAINT [DF_Pale__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trr]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Pale__trr]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [DF_Pale__trr]

 ALTER TABLE [dbo].[PaleteMov] ADD CONSTRAINT [DF_Pale__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trk]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trk]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [DF_Palt__trk]

 ALTER TABLE [dbo].[PaleteProduto] ADD CONSTRAINT [DF_Palt__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trr]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Palt__trr]') AND parent_obj = object_id(N'[dbo].[PaleteProduto]'))
 ALTER TABLE [dbo].[PaleteProduto] DROP CONSTRAINT [DF_Palt__trr]

 ALTER TABLE [dbo].[PaleteProduto] ADD CONSTRAINT [DF_Palt__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trk]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trk]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [DF_Para__trk]

 ALTER TABLE [dbo].[ParametrosFracionamento] ADD CONSTRAINT [DF_Para__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trr]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Para__trr]') AND parent_obj = object_id(N'[dbo].[ParametrosFracionamento]'))
 ALTER TABLE [dbo].[ParametrosFracionamento] DROP CONSTRAINT [DF_Para__trr]

 ALTER TABLE [dbo].[ParametrosFracionamento] ADD CONSTRAINT [DF_Para__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trk]') AND parent_obj = object_id(N'[dbo].[Produto]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trk]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [DF_Prod__trk]

 ALTER TABLE [dbo].[Produto] ADD CONSTRAINT [DF_Prod__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trr]') AND parent_obj = object_id(N'[dbo].[Produto]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prod__trr]') AND parent_obj = object_id(N'[dbo].[Produto]'))
 ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [DF_Prod__trr]

 ALTER TABLE [dbo].[Produto] ADD CONSTRAINT [DF_Prod__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trk]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trk]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [DF_Prou__trk]

 ALTER TABLE [dbo].[ProdutoPrevisao] ADD CONSTRAINT [DF_Prou__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trr]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Prou__trr]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [DF_Prou__trr]

 ALTER TABLE [dbo].[ProdutoPrevisao] ADD CONSTRAINT [DF_Prou__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trk]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trk]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [DF_Seto__trk]

 ALTER TABLE [dbo].[SetorVisita] ADD CONSTRAINT [DF_Seto__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trr]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Seto__trr]') AND parent_obj = object_id(N'[dbo].[SetorVisita]'))
 ALTER TABLE [dbo].[SetorVisita] DROP CONSTRAINT [DF_Seto__trr]

 ALTER TABLE [dbo].[SetorVisita] ADD CONSTRAINT [DF_Seto__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trk]') AND parent_obj = object_id(N'[dbo].[sistema]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trk]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [DF_sist__trk]

 ALTER TABLE [dbo].[sistema] ADD CONSTRAINT [DF_sist__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trr]') AND parent_obj = object_id(N'[dbo].[sistema]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_sist__trr]') AND parent_obj = object_id(N'[dbo].[sistema]'))
 ALTER TABLE [dbo].[sistema] DROP CONSTRAINT [DF_sist__trr]

 ALTER TABLE [dbo].[sistema] ADD CONSTRAINT [DF_sist__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trk]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trk]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [DF_Tara__trk]

 ALTER TABLE [dbo].[TaraFracionamento] ADD CONSTRAINT [DF_Tara__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trr]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Tara__trr]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [DF_Tara__trr]

 ALTER TABLE [dbo].[TaraFracionamento] ADD CONSTRAINT [DF_Tara__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trk]') AND parent_obj = object_id(N'[dbo].[uf]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trk]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [DF_uf__trk]

 ALTER TABLE [dbo].[uf] ADD CONSTRAINT [DF_uf__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trr]') AND parent_obj = object_id(N'[dbo].[uf]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_uf__trr]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [DF_uf__trr]

 ALTER TABLE [dbo].[uf] ADD CONSTRAINT [DF_uf__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trk]') AND parent_obj = object_id(N'[dbo].[usuario]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trk]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [DF_usua__trk]

 ALTER TABLE [dbo].[usuario] ADD CONSTRAINT [DF_usua__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trr]') AND parent_obj = object_id(N'[dbo].[usuario]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_usua__trr]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [DF_usua__trr]

 ALTER TABLE [dbo].[usuario] ADD CONSTRAINT [DF_usua__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trk]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trk]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [DF_Visi__trk]

 ALTER TABLE [dbo].[VisitaMov] ADD CONSTRAINT [DF_Visi__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trr]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Visi__trr]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [DF_Visi__trr]

 ALTER TABLE [dbo].[VisitaMov] ADD CONSTRAINT [DF_Visi__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trk]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trk]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [DF_Vist__trk]

 ALTER TABLE [dbo].[VisitanteVisita] ADD CONSTRAINT [DF_Vist__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trr]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_Vist__trr]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [DF_Vist__trr]

 ALTER TABLE [dbo].[VisitanteVisita] ADD CONSTRAINT [DF_Vist__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trk]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trk]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [DF_WebS__trk]

 ALTER TABLE [dbo].[WebSiteMap] ADD CONSTRAINT [DF_WebS__trk] DEFAULT (GETDATE()) FOR [_trackLastWriteTime]
END
GO
IF NOT EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trr]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
BEGIN
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DF_WebS__trr]') AND parent_obj = object_id(N'[dbo].[WebSiteMap]'))
 ALTER TABLE [dbo].[WebSiteMap] DROP CONSTRAINT [DF_WebS__trr]

 ALTER TABLE [dbo].[WebSiteMap] ADD CONSTRAINT [DF_WebS__trr] DEFAULT (GETDATE()) FOR [_trackCreationTime]
END
GO
