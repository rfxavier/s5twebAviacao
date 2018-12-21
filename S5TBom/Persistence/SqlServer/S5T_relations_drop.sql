/* CodeFluent Generated . TargetVersion:Sql2014. Culture:pt-BR. UiCulture:pt-BR. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvc_pId_Avia]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAvi_pId_Avia]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAvi_pId_Avia]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avia_oAvi_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoCaminhao]'))
 ALTER TABLE [dbo].[AviacaoCaminhao] DROP CONSTRAINT [FK_Avia_oAvi_pId_AviM]
GO
/* no fk for 'FK_Avii_oUsu_pId_usua', tableName='AviacaoPivotAnalise' table='AviacaoPivotAnalise' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avii_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[AviacaoPivotAnalise]'))
 ALTER TABLE [dbo].[AviacaoPivotAnalise] DROP CONSTRAINT [FK_Avii_oUsu_pId_usua]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvi_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvi_pId_AviL]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAva_pId_AviM]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvc_pId_Avia]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi9_oAvo_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoViagemMov]'))
 ALTER TABLE [dbo].[AviacaoViagemMov] DROP CONSTRAINT [FK_Avi9_oAvo_pId_AviL]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oUsu_pId_usua]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCia_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCia_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAvi_pId_Avia]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAvi_pId_Avia]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oAva_pId_AviM]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oAva_pId_AviM]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoc_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoc_pId_AviL]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Cont_oLoa_pId_AviL]') AND parent_obj = object_id(N'[dbo].[ControleViagemAg]'))
 ALTER TABLE [dbo].[ControleViagemAg] DROP CONSTRAINT [FK_Cont_oLoa_pId_AviL]
GO
/* no fk for 'FK_CTeC_oCon_pId_Cont', tableName='CTeControleViagemAg' table='CTeControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_CTeC_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[CTeControleViagemAg]'))
 ALTER TABLE [dbo].[CTeControleViagemAg] DROP CONSTRAINT [FK_CTeC_oCon_pId_Cont]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oEmp_pId_empr]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oEmp_pId_empr]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cada_oCad_pId_fili]') AND parent_obj = object_id(N'[dbo].[cadastro]'))
 ALTER TABLE [dbo].[cadastro] DROP CONSTRAINT [FK_cada_oCad_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fili_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[filial]'))
 ALTER TABLE [dbo].[filial] DROP CONSTRAINT [FK_fili_oCad_pId_cada]
GO
/* no fk for 'FK_fila_oFil_pId_fili', tableName='filialconfig' table='filialconfig' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fila_oFil_pId_fili]') AND parent_obj = object_id(N'[dbo].[filialconfig]'))
 ALTER TABLE [dbo].[filialconfig] DROP CONSTRAINT [FK_fila_oFil_pId_fili]
GO
/* no fk for 'FK_Frai_oFra_pId_Frac', tableName='FracionamentoMov' table='FracionamentoMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Frai_oFra_pId_Frac]') AND parent_obj = object_id(N'[dbo].[FracionamentoMov]'))
 ALTER TABLE [dbo].[FracionamentoMov] DROP CONSTRAINT [FK_Frai_oFra_pId_Frac]
GO
/* no fk for 'FK_IdRl_Role_Id_IdRo', tableName='IdRoleClaim' table='IdRoleClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRl_Role_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRoleClaim]'))
 ALTER TABLE [dbo].[IdRoleClaim] DROP CONSTRAINT [FK_IdRl_Role_Id_IdRo]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUs_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[IdUser]'))
 ALTER TABLE [dbo].[IdUser] DROP CONSTRAINT [FK_IdUs_oUsu_pId_usua]
GO
/* no fk for 'FK_IdUe_User_Id_IdUs', tableName='IdUserClaim' table='IdUserClaim' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUe_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserClaim]'))
 ALTER TABLE [dbo].[IdUserClaim] DROP CONSTRAINT [FK_IdUe_User_Id_IdUs]
GO
/* no fk for 'FK_IdUr_User_Id_IdUs', tableName='IdUserLogin' table='IdUserLogin' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdUr_User_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdUserLogin]'))
 ALTER TABLE [dbo].[IdUserLogin] DROP CONSTRAINT [FK_IdUr_User_Id_IdUs]
GO
/* no fk for 'FK_Lote_oCon_pId_Cont', tableName='LoteControleViagemAg' table='LoteControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Lote_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[LoteControleViagemAg]'))
 ALTER TABLE [dbo].[LoteControleViagemAg] DROP CONSTRAINT [FK_Lote_oCon_pId_Cont]
GO
/* no fk for 'FK_menu_oSis_pId_sist', tableName='menu' table='menu' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menu_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menu]'))
 ALTER TABLE [dbo].[menu] DROP CONSTRAINT [FK_menu_oSis_pId_sist]
GO
/* no fk for 'FK_menp_oUsu_pId_usua', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oUsu_pId_usua]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oUsu_pId_usua]
GO
/* no fk for 'FK_menp_oSis_pId_sist', tableName='menupermissao' table='menupermissao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_menp_oSis_pId_sist]') AND parent_obj = object_id(N'[dbo].[menupermissao]'))
 ALTER TABLE [dbo].[menupermissao] DROP CONSTRAINT [FK_menp_oSis_pId_sist]
GO
/* no fk for 'FK_Movi_oPro_pId_Prod', tableName='MovimentacaoLote' table='MovimentacaoLote' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Movi_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[MovimentacaoLote]'))
 ALTER TABLE [dbo].[MovimentacaoLote] DROP CONSTRAINT [FK_Movi_oPro_pId_Prod]
GO
/* no fk for 'FK_NFCo_oCon_pId_Cont', tableName='NFControleViagemAg' table='NFControleViagemAg' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_NFCo_oCon_pId_Cont]') AND parent_obj = object_id(N'[dbo].[NFControleViagemAg]'))
 ALTER TABLE [dbo].[NFControleViagemAg] DROP CONSTRAINT [FK_NFCo_oCon_pId_Cont]
GO
/* no fk for 'FK_Pale_oPal_pId_Palt', tableName='PaleteMov' table='PaleteMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Pale_oPal_pId_Palt]') AND parent_obj = object_id(N'[dbo].[PaleteMov]'))
 ALTER TABLE [dbo].[PaleteMov] DROP CONSTRAINT [FK_Pale_oPal_pId_Palt]
GO
/* no fk for 'FK_Prou_oPro_pId_Prod', tableName='ProdutoPrevisao' table='ProdutoPrevisao' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Prou_oPro_pId_Prod]') AND parent_obj = object_id(N'[dbo].[ProdutoPrevisao]'))
 ALTER TABLE [dbo].[ProdutoPrevisao] DROP CONSTRAINT [FK_Prou_oPro_pId_Prod]
GO
/* no fk for 'FK_Tara_oEmb_pId_Emba', tableName='TaraFracionamento' table='TaraFracionamento' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Tara_oEmb_pId_Emba]') AND parent_obj = object_id(N'[dbo].[TaraFracionamento]'))
 ALTER TABLE [dbo].[TaraFracionamento] DROP CONSTRAINT [FK_Tara_oEmb_pId_Emba]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cida_oUF__pId_uf]') AND parent_obj = object_id(N'[dbo].[cidade]'))
 ALTER TABLE [dbo].[cidade] DROP CONSTRAINT [FK_cida_oUF__pId_uf]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_uf_oPai_pId_pais]') AND parent_obj = object_id(N'[dbo].[uf]'))
 ALTER TABLE [dbo].[uf] DROP CONSTRAINT [FK_uf_oPai_pId_pais]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oCad_pId_cada]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oCad_pId_cada]
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
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_usua_oIdU_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[usuario]'))
 ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usua_oIdU_Id_IdUs]
GO
/* no fk for 'FK_Visi_oVis_pId_Vist', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
GO
/* no fk for 'FK_Visi_oFun_pId_Func', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oFun_pId_Func]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oFun_pId_Func]
GO
/* no fk for 'FK_Visi_oSet_pId_Seto', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oSet_pId_Seto]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oSet_pId_Seto]
GO
/* no fk for 'FK_Visi_oEmp_pId_Empe', tableName='VisitaMov' table='VisitaMov' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oEmp_pId_Empe]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oEmp_pId_Empe]
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Visi_oVis_pId_Vist]') AND parent_obj = object_id(N'[dbo].[VisitaMov]'))
 ALTER TABLE [dbo].[VisitaMov] DROP CONSTRAINT [FK_Visi_oVis_pId_Vist]
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Vist_oCid_pId_cida]') AND parent_obj = object_id(N'[dbo].[VisitanteVisita]'))
 ALTER TABLE [dbo].[VisitanteVisita] DROP CONSTRAINT [FK_Vist_oCid_pId_cida]
GO
/* no fk for 'FK_appl_pId_pId_appr', tableName='apprelatorio_oUsuarios_usuario_oAppRelatorios' table='apprelatorio_oUsuarios_usuario_oAppRelatorios' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId_pId_appr]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId_pId_appr]
GO
/* no fk for 'FK_appl_pId2_pId_usua', tableName='apprelatorio_oUsuarios_usuario_oAppRelatorios' table='apprelatorio_oUsuarios_usuario_oAppRelatorios' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_appl_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios]'))
 ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] DROP CONSTRAINT [FK_appl_pId2_pId_usua]
GO
/* no fk for 'FK_Avi__pId_pId_AviL', tableName='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' table='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId_pId_AviL]
GO
/* no fk for 'FK_Avi__pId2_pId_Avi9', tableName='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' table='AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Avi__pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] DROP CONSTRAINT [FK_Avi__pId2_pId_Avi9]
GO
/* no fk for 'FK_Av10_pId_pId_AviL', tableName='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' table='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId_pId_AviL]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId_pId_AviL]
GO
/* no fk for 'FK_Av10_pId2_pId_Avi9', tableName='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' table='AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_Av10_pId2_pId_Avi9]') AND parent_obj = object_id(N'[dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno]'))
 ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] DROP CONSTRAINT [FK_Av10_pId2_pId_Avi9]
GO
/* no fk for 'FK_cadt_pId_pId_cada', tableName='cadastro_oempresas_empresa_ocadastros' table='cadastro_oempresas_empresa_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId_pId_cada]
GO
/* no fk for 'FK_cadt_pId2_pId_empr', tableName='cadastro_oempresas_empresa_ocadastros' table='cadastro_oempresas_empresa_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadt_pId2_pId_empr]') AND parent_obj = object_id(N'[dbo].[cadastro_oempresas_empresa_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] DROP CONSTRAINT [FK_cadt_pId2_pId_empr]
GO
/* no fk for 'FK_cadr_pId_pId_cada', tableName='cadastro_ocadastrostipo_cadastrotipo_ocadastros' table='cadastro_ocadastrostipo_cadastrotipo_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId_pId_cada]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId_pId_cada]
GO
/* no fk for 'FK_cadr_pId2_pId_cads', tableName='cadastro_ocadastrostipo_cadastrotipo_ocadastros' table='cadastro_ocadastrostipo_cadastrotipo_ocadastros' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_cadr_pId2_pId_cads]') AND parent_obj = object_id(N'[dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros]'))
 ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] DROP CONSTRAINT [FK_cadr_pId2_pId_cads]
GO
/* no fk for 'FK_emps_pId_pId_empr', tableName='empresa_osistemas_sistema_oempresas' table='empresa_osistemas_sistema_oempresas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId_pId_empr]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId_pId_empr]
GO
/* no fk for 'FK_emps_pId2_pId_sist', tableName='empresa_osistemas_sistema_oempresas' table='empresa_osistemas_sistema_oempresas' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_emps_pId2_pId_sist]') AND parent_obj = object_id(N'[dbo].[empresa_osistemas_sistema_oempresas]'))
 ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] DROP CONSTRAINT [FK_emps_pId2_pId_sist]
GO
/* no fk for 'FK_fill_pId_pId_fili', tableName='filial_ousuarios_usuario_ofiliais' table='filial_ousuarios_usuario_ofiliais' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId_pId_fili]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId_pId_fili]
GO
/* no fk for 'FK_fill_pId2_pId_usua', tableName='filial_ousuarios_usuario_ofiliais' table='filial_ousuarios_usuario_ofiliais' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_fill_pId2_pId_usua]') AND parent_obj = object_id(N'[dbo].[filial_ousuarios_usuario_ofiliais]'))
 ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] DROP CONSTRAINT [FK_fill_pId2_pId_usua]
GO
/* no fk for 'FK_IdRe_Id_Id_IdRo', tableName='IdRole_Users_IdUser_Roles' table='IdRole_Users_IdUser_Roles' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id_Id_IdRo]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id_Id_IdRo]
GO
/* no fk for 'FK_IdRe_Id2_Id_IdUs', tableName='IdRole_Users_IdUser_Roles' table='IdRole_Users_IdUser_Roles' */
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[FK_IdRe_Id2_Id_IdUs]') AND parent_obj = object_id(N'[dbo].[IdRole_Users_IdUser_Roles]'))
 ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] DROP CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
GO
