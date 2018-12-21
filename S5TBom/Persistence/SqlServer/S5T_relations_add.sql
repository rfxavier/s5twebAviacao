/* CodeFluent Generated . TargetVersion:Sql2014. Culture:pt-BR. UiCulture:pt-BR. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
ALTER TABLE [dbo].[AviacaoCaminhao] WITH NOCHECK ADD CONSTRAINT [FK_Avia_oAvi_pId_AviM] FOREIGN KEY (
 [oAviacaoMotorista_pId]
) REFERENCES [dbo].[AviacaoMotorista](

 [pId]
)
ALTER TABLE [dbo].[AviacaoCaminhao] NOCHECK CONSTRAINT [FK_Avia_oAvi_pId_AviM]
ALTER TABLE [dbo].[AviacaoPivotAnalise] WITH NOCHECK ADD CONSTRAINT [FK_Avii_oUsu_pId_usua] FOREIGN KEY (
 [oUsuario_pId]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[AviacaoPivotAnalise] NOCHECK CONSTRAINT [FK_Avii_oUsu_pId_usua]
ALTER TABLE [dbo].[AviacaoViagemMov] WITH NOCHECK ADD CONSTRAINT [FK_Avi9_oAvi_pId_AviL] FOREIGN KEY (
 [oAviacaoLocalLinha_pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[AviacaoViagemMov] NOCHECK CONSTRAINT [FK_Avi9_oAvi_pId_AviL]
ALTER TABLE [dbo].[AviacaoViagemMov] WITH NOCHECK ADD CONSTRAINT [FK_Avi9_oAva_pId_AviM] FOREIGN KEY (
 [oAviacaoMotorista_pId]
) REFERENCES [dbo].[AviacaoMotorista](

 [pId]
)
ALTER TABLE [dbo].[AviacaoViagemMov] NOCHECK CONSTRAINT [FK_Avi9_oAva_pId_AviM]
ALTER TABLE [dbo].[AviacaoViagemMov] WITH NOCHECK ADD CONSTRAINT [FK_Avi9_oAvc_pId_Avia] FOREIGN KEY (
 [oAviacaoCaminhao_pId]
) REFERENCES [dbo].[AviacaoCaminhao](

 [pId]
)
ALTER TABLE [dbo].[AviacaoViagemMov] NOCHECK CONSTRAINT [FK_Avi9_oAvc_pId_Avia]
ALTER TABLE [dbo].[AviacaoViagemMov] WITH NOCHECK ADD CONSTRAINT [FK_Avi9_oAvo_pId_AviL] FOREIGN KEY (
 [oAviacaoLocalLinhaRetorno_pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[AviacaoViagemMov] NOCHECK CONSTRAINT [FK_Avi9_oAvo_pId_AviL]
ALTER TABLE [dbo].[cadastro] WITH NOCHECK ADD CONSTRAINT [FK_cada_oCid_pId_cida] FOREIGN KEY (
 [oCidade_pId]
) REFERENCES [dbo].[cidade](

 [pId]
)
ALTER TABLE [dbo].[cadastro] NOCHECK CONSTRAINT [FK_cada_oCid_pId_cida]
ALTER TABLE [dbo].[cadastro] WITH NOCHECK ADD CONSTRAINT [FK_cada_oCia_pId_cida] FOREIGN KEY (
 [oCidadeAux_pId]
) REFERENCES [dbo].[cidade](

 [pId]
)
ALTER TABLE [dbo].[cadastro] NOCHECK CONSTRAINT [FK_cada_oCia_pId_cida]
ALTER TABLE [dbo].[cadastro] WITH NOCHECK ADD CONSTRAINT [FK_cada_oUsu_pId_usua] FOREIGN KEY (
 [oUsuario_pId]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[cadastro] NOCHECK CONSTRAINT [FK_cada_oUsu_pId_usua]
ALTER TABLE [dbo].[cadastro] WITH NOCHECK ADD CONSTRAINT [FK_cada_oCad_pId_fili] FOREIGN KEY (
 [oCadastroFilial_pId]
) REFERENCES [dbo].[filial](

 [pId]
)
ALTER TABLE [dbo].[cadastro] NOCHECK CONSTRAINT [FK_cada_oCad_pId_fili]
ALTER TABLE [dbo].[cidade] WITH NOCHECK ADD CONSTRAINT [FK_cida_oUF__pId_uf] FOREIGN KEY (
 [oUF_pId]
) REFERENCES [dbo].[uf](

 [pId]
)
ALTER TABLE [dbo].[cidade] NOCHECK CONSTRAINT [FK_cida_oUF__pId_uf]
ALTER TABLE [dbo].[ControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_Cont_oAvi_pId_Avia] FOREIGN KEY (
 [oAviacaoCaminhao_pId]
) REFERENCES [dbo].[AviacaoCaminhao](

 [pId]
)
ALTER TABLE [dbo].[ControleViagemAg] NOCHECK CONSTRAINT [FK_Cont_oAvi_pId_Avia]
ALTER TABLE [dbo].[ControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_Cont_oAva_pId_AviM] FOREIGN KEY (
 [oAviacaoMotorista_pId]
) REFERENCES [dbo].[AviacaoMotorista](

 [pId]
)
ALTER TABLE [dbo].[ControleViagemAg] NOCHECK CONSTRAINT [FK_Cont_oAva_pId_AviM]
ALTER TABLE [dbo].[ControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_Cont_oLoc_pId_AviL] FOREIGN KEY (
 [oLocalLinhaOrigem_pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[ControleViagemAg] NOCHECK CONSTRAINT [FK_Cont_oLoc_pId_AviL]
ALTER TABLE [dbo].[ControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_Cont_oLoa_pId_AviL] FOREIGN KEY (
 [oLocalLinhaDestino_pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[ControleViagemAg] NOCHECK CONSTRAINT [FK_Cont_oLoa_pId_AviL]
ALTER TABLE [dbo].[CTeControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_CTeC_oCon_pId_Cont] FOREIGN KEY (
 [oControleViagemAg_pId]
) REFERENCES [dbo].[ControleViagemAg](

 [pId]
)
ALTER TABLE [dbo].[CTeControleViagemAg] NOCHECK CONSTRAINT [FK_CTeC_oCon_pId_Cont]
ALTER TABLE [dbo].[filial] WITH NOCHECK ADD CONSTRAINT [FK_fili_oEmp_pId_empr] FOREIGN KEY (
 [oEmpresa_pId]
) REFERENCES [dbo].[empresa](

 [pId]
)
ALTER TABLE [dbo].[filial] NOCHECK CONSTRAINT [FK_fili_oEmp_pId_empr]
ALTER TABLE [dbo].[filial] WITH NOCHECK ADD CONSTRAINT [FK_fili_oCad_pId_cada] FOREIGN KEY (
 [oCadastro_pId]
) REFERENCES [dbo].[cadastro](

 [pId]
)
ALTER TABLE [dbo].[filial] NOCHECK CONSTRAINT [FK_fili_oCad_pId_cada]
ALTER TABLE [dbo].[filialconfig] WITH NOCHECK ADD CONSTRAINT [FK_fila_oFil_pId_fili] FOREIGN KEY (
 [oFilial_pId]
) REFERENCES [dbo].[filial](

 [pId]
)
ALTER TABLE [dbo].[filialconfig] NOCHECK CONSTRAINT [FK_fila_oFil_pId_fili]
ALTER TABLE [dbo].[FracionamentoMov] WITH NOCHECK ADD CONSTRAINT [FK_Frai_oFra_pId_Frac] FOREIGN KEY (
 [oFracionamento_pId]
) REFERENCES [dbo].[Fracionamento](

 [pId]
)
ALTER TABLE [dbo].[FracionamentoMov] NOCHECK CONSTRAINT [FK_Frai_oFra_pId_Frac]
ALTER TABLE [dbo].[IdRoleClaim] WITH NOCHECK ADD CONSTRAINT [FK_IdRl_Role_Id_IdRo] FOREIGN KEY (
 [Role_Id]
) REFERENCES [dbo].[IdRole](

 [Id]
)
ALTER TABLE [dbo].[IdRoleClaim] NOCHECK CONSTRAINT [FK_IdRl_Role_Id_IdRo]
ALTER TABLE [dbo].[IdUser] WITH NOCHECK ADD CONSTRAINT [FK_IdUs_oUsu_pId_usua] FOREIGN KEY (
 [oUsuario_pId]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[IdUser] NOCHECK CONSTRAINT [FK_IdUs_oUsu_pId_usua]
ALTER TABLE [dbo].[IdUserClaim] WITH NOCHECK ADD CONSTRAINT [FK_IdUe_User_Id_IdUs] FOREIGN KEY (
 [User_Id]
) REFERENCES [dbo].[IdUser](

 [Id]
)
ALTER TABLE [dbo].[IdUserClaim] NOCHECK CONSTRAINT [FK_IdUe_User_Id_IdUs]
ALTER TABLE [dbo].[IdUserLogin] WITH NOCHECK ADD CONSTRAINT [FK_IdUr_User_Id_IdUs] FOREIGN KEY (
 [User_Id]
) REFERENCES [dbo].[IdUser](

 [Id]
)
ALTER TABLE [dbo].[IdUserLogin] NOCHECK CONSTRAINT [FK_IdUr_User_Id_IdUs]
ALTER TABLE [dbo].[LoteControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_Lote_oCon_pId_Cont] FOREIGN KEY (
 [oControleViagemAg_pId]
) REFERENCES [dbo].[ControleViagemAg](

 [pId]
)
ALTER TABLE [dbo].[LoteControleViagemAg] NOCHECK CONSTRAINT [FK_Lote_oCon_pId_Cont]
ALTER TABLE [dbo].[menu] WITH NOCHECK ADD CONSTRAINT [FK_menu_oSis_pId_sist] FOREIGN KEY (
 [oSistema_pId]
) REFERENCES [dbo].[sistema](

 [pId]
)
ALTER TABLE [dbo].[menu] NOCHECK CONSTRAINT [FK_menu_oSis_pId_sist]
ALTER TABLE [dbo].[menupermissao] WITH NOCHECK ADD CONSTRAINT [FK_menp_oUsu_pId_usua] FOREIGN KEY (
 [oUsuario_pId]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[menupermissao] NOCHECK CONSTRAINT [FK_menp_oUsu_pId_usua]
ALTER TABLE [dbo].[menupermissao] WITH NOCHECK ADD CONSTRAINT [FK_menp_oSis_pId_sist] FOREIGN KEY (
 [oSistema_pId]
) REFERENCES [dbo].[sistema](

 [pId]
)
ALTER TABLE [dbo].[menupermissao] NOCHECK CONSTRAINT [FK_menp_oSis_pId_sist]
ALTER TABLE [dbo].[MovimentacaoLote] WITH NOCHECK ADD CONSTRAINT [FK_Movi_oPro_pId_Prod] FOREIGN KEY (
 [oProduto_pId]
) REFERENCES [dbo].[Produto](

 [pId]
)
ALTER TABLE [dbo].[MovimentacaoLote] NOCHECK CONSTRAINT [FK_Movi_oPro_pId_Prod]
ALTER TABLE [dbo].[NFControleViagemAg] WITH NOCHECK ADD CONSTRAINT [FK_NFCo_oCon_pId_Cont] FOREIGN KEY (
 [oControleViagemAg_pId]
) REFERENCES [dbo].[ControleViagemAg](

 [pId]
)
ALTER TABLE [dbo].[NFControleViagemAg] NOCHECK CONSTRAINT [FK_NFCo_oCon_pId_Cont]
ALTER TABLE [dbo].[PaleteMov] WITH NOCHECK ADD CONSTRAINT [FK_Pale_oPal_pId_Palt] FOREIGN KEY (
 [oPaleteProduto_pId]
) REFERENCES [dbo].[PaleteProduto](

 [pId]
)
ALTER TABLE [dbo].[PaleteMov] NOCHECK CONSTRAINT [FK_Pale_oPal_pId_Palt]
ALTER TABLE [dbo].[ProdutoPrevisao] WITH NOCHECK ADD CONSTRAINT [FK_Prou_oPro_pId_Prod] FOREIGN KEY (
 [oProduto_pId]
) REFERENCES [dbo].[Produto](

 [pId]
)
ALTER TABLE [dbo].[ProdutoPrevisao] NOCHECK CONSTRAINT [FK_Prou_oPro_pId_Prod]
ALTER TABLE [dbo].[TaraFracionamento] WITH NOCHECK ADD CONSTRAINT [FK_Tara_oEmb_pId_Emba] FOREIGN KEY (
 [oEmbalagem_pId]
) REFERENCES [dbo].[EmbalagemFracionamento](

 [pId]
)
ALTER TABLE [dbo].[TaraFracionamento] NOCHECK CONSTRAINT [FK_Tara_oEmb_pId_Emba]
ALTER TABLE [dbo].[uf] WITH NOCHECK ADD CONSTRAINT [FK_uf_oPai_pId_pais] FOREIGN KEY (
 [oPais_pId]
) REFERENCES [dbo].[pais](

 [pId]
)
ALTER TABLE [dbo].[uf] NOCHECK CONSTRAINT [FK_uf_oPai_pId_pais]
ALTER TABLE [dbo].[usuario] WITH NOCHECK ADD CONSTRAINT [FK_usua_oCad_pId_cada] FOREIGN KEY (
 [oCadastro_pId]
) REFERENCES [dbo].[cadastro](

 [pId]
)
ALTER TABLE [dbo].[usuario] NOCHECK CONSTRAINT [FK_usua_oCad_pId_cada]
ALTER TABLE [dbo].[usuario] WITH NOCHECK ADD CONSTRAINT [FK_usua_oIdU_Id_IdUs] FOREIGN KEY (
 [oIdUser_Id]
) REFERENCES [dbo].[IdUser](

 [Id]
)
ALTER TABLE [dbo].[usuario] NOCHECK CONSTRAINT [FK_usua_oIdU_Id_IdUs]
ALTER TABLE [dbo].[VisitaMov] WITH NOCHECK ADD CONSTRAINT [FK_Visi_oVis_pId_Vist] FOREIGN KEY (
 [oVisitante_pId]
) REFERENCES [dbo].[VisitanteVisita](

 [pId]
)
ALTER TABLE [dbo].[VisitaMov] NOCHECK CONSTRAINT [FK_Visi_oVis_pId_Vist]
ALTER TABLE [dbo].[VisitaMov] WITH NOCHECK ADD CONSTRAINT [FK_Visi_oFun_pId_Func] FOREIGN KEY (
 [oFuncionario_pId]
) REFERENCES [dbo].[FuncionarioVisita](

 [pId]
)
ALTER TABLE [dbo].[VisitaMov] NOCHECK CONSTRAINT [FK_Visi_oFun_pId_Func]
ALTER TABLE [dbo].[VisitaMov] WITH NOCHECK ADD CONSTRAINT [FK_Visi_oSet_pId_Seto] FOREIGN KEY (
 [oSetor_pId]
) REFERENCES [dbo].[SetorVisita](

 [pId]
)
ALTER TABLE [dbo].[VisitaMov] NOCHECK CONSTRAINT [FK_Visi_oSet_pId_Seto]
ALTER TABLE [dbo].[VisitaMov] WITH NOCHECK ADD CONSTRAINT [FK_Visi_oEmp_pId_Empe] FOREIGN KEY (
 [oEmpresa_pId]
) REFERENCES [dbo].[EmpresaVisita](

 [pId]
)
ALTER TABLE [dbo].[VisitaMov] NOCHECK CONSTRAINT [FK_Visi_oEmp_pId_Empe]
ALTER TABLE [dbo].[VisitanteVisita] WITH NOCHECK ADD CONSTRAINT [FK_Vist_oCid_pId_cida] FOREIGN KEY (
 [oCidade_pId]
) REFERENCES [dbo].[cidade](

 [pId]
)
ALTER TABLE [dbo].[VisitanteVisita] NOCHECK CONSTRAINT [FK_Vist_oCid_pId_cida]
ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] WITH NOCHECK ADD CONSTRAINT [FK_appl_pId_pId_appr] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[apprelatorio](

 [pId]
)
ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] NOCHECK CONSTRAINT [FK_appl_pId_pId_appr]
ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] WITH NOCHECK ADD CONSTRAINT [FK_appl_pId2_pId_usua] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[apprelatorio_oUsuarios_usuario_oAppRelatorios] NOCHECK CONSTRAINT [FK_appl_pId2_pId_usua]
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] WITH NOCHECK ADD CONSTRAINT [FK_Avi__pId_pId_AviL] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] NOCHECK CONSTRAINT [FK_Avi__pId_pId_AviL]
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] WITH NOCHECK ADD CONSTRAINT [FK_Avi__pId2_pId_Avi9] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[AviacaoViagemMov](

 [pId]
)
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagensMovs_AviacaoViagemMov_oAviacaoLocalLinhas] NOCHECK CONSTRAINT [FK_Avi__pId2_pId_Avi9]
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] WITH NOCHECK ADD CONSTRAINT [FK_Av10_pId_pId_AviL] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[AviacaoLocalLinha](

 [pId]
)
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] NOCHECK CONSTRAINT [FK_Av10_pId_pId_AviL]
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] WITH NOCHECK ADD CONSTRAINT [FK_Av10_pId2_pId_Avi9] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[AviacaoViagemMov](

 [pId]
)
ALTER TABLE [dbo].[AviacaoLocalLinha_oAviacaoViagemMovsRetornos_AviacaoViagemMov_oAviacaoLocalLinhasRetorno] NOCHECK CONSTRAINT [FK_Av10_pId2_pId_Avi9]
ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] WITH NOCHECK ADD CONSTRAINT [FK_cadt_pId_pId_cada] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[cadastro](

 [pId]
)
ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] NOCHECK CONSTRAINT [FK_cadt_pId_pId_cada]
ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] WITH NOCHECK ADD CONSTRAINT [FK_cadt_pId2_pId_empr] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[empresa](

 [pId]
)
ALTER TABLE [dbo].[cadastro_oempresas_empresa_ocadastros] NOCHECK CONSTRAINT [FK_cadt_pId2_pId_empr]
ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] WITH NOCHECK ADD CONSTRAINT [FK_cadr_pId_pId_cada] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[cadastro](

 [pId]
)
ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] NOCHECK CONSTRAINT [FK_cadr_pId_pId_cada]
ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] WITH NOCHECK ADD CONSTRAINT [FK_cadr_pId2_pId_cads] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[cadastrotipo](

 [pId]
)
ALTER TABLE [dbo].[cadastro_ocadastrostipo_cadastrotipo_ocadastros] NOCHECK CONSTRAINT [FK_cadr_pId2_pId_cads]
ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] WITH NOCHECK ADD CONSTRAINT [FK_emps_pId_pId_empr] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[empresa](

 [pId]
)
ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] NOCHECK CONSTRAINT [FK_emps_pId_pId_empr]
ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] WITH NOCHECK ADD CONSTRAINT [FK_emps_pId2_pId_sist] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[sistema](

 [pId]
)
ALTER TABLE [dbo].[empresa_osistemas_sistema_oempresas] NOCHECK CONSTRAINT [FK_emps_pId2_pId_sist]
ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] WITH NOCHECK ADD CONSTRAINT [FK_fill_pId_pId_fili] FOREIGN KEY (
 [pId]
) REFERENCES [dbo].[filial](

 [pId]
)
ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] NOCHECK CONSTRAINT [FK_fill_pId_pId_fili]
ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] WITH NOCHECK ADD CONSTRAINT [FK_fill_pId2_pId_usua] FOREIGN KEY (
 [pId2]
) REFERENCES [dbo].[usuario](

 [pId]
)
ALTER TABLE [dbo].[filial_ousuarios_usuario_ofiliais] NOCHECK CONSTRAINT [FK_fill_pId2_pId_usua]
ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] WITH NOCHECK ADD CONSTRAINT [FK_IdRe_Id_Id_IdRo] FOREIGN KEY (
 [Id]
) REFERENCES [dbo].[IdRole](

 [Id]
)
ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] NOCHECK CONSTRAINT [FK_IdRe_Id_Id_IdRo]
ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] WITH NOCHECK ADD CONSTRAINT [FK_IdRe_Id2_Id_IdUs] FOREIGN KEY (
 [Id2]
) REFERENCES [dbo].[IdUser](

 [Id]
)
ALTER TABLE [dbo].[IdRole_Users_IdUser_Roles] NOCHECK CONSTRAINT [FK_IdRe_Id2_Id_IdUs]
