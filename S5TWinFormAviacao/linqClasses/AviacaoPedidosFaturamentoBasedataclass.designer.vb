﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="s5taviacao")>  _
Partial Public Class AviacaoPedidosFaturamentoBasedataclassDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAviacaoPedidosFaturamento(instance As AviacaoPedidosFaturamento)
    End Sub
  Partial Private Sub UpdateAviacaoPedidosFaturamento(instance As AviacaoPedidosFaturamento)
    End Sub
  Partial Private Sub DeleteAviacaoPedidosFaturamento(instance As AviacaoPedidosFaturamento)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("s5taviacaoConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property AviacaoPedidosFaturamentos() As System.Data.Linq.Table(Of AviacaoPedidosFaturamento)
		Get
			Return Me.GetTable(Of AviacaoPedidosFaturamento)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AviacaoPedidosFaturamento")>  _
Partial Public Class AviacaoPedidosFaturamento
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _pId As Long
	
	Private _pTIPO_OP As String
	
	Private _pFILIAL As String
	
	Private _pPEDIDO As String
	
	Private _pNOTA_FISCAL As String
	
	Private _pSERIE_NF As String
	
	Private _pCOD_CLIENTE As String
	
	Private _pLOJA As String
	
	Private _pDESC_CLIENTE As String
	
	Private _pCOD_VENDEDOR As String
	
	Private _pNOME_VENDEDOR As String
	
	Private _pDT_EMISSAO As System.Nullable(Of Date)
	
	Private _pCOD_GRUPO_CLIENTE As String
	
	Private _pDESC_GRUPO_CLIENTE As String
	
	Private _pCODIGO_PRODUTO As String
	
	Private _pDESC_PRODUTO As String
	
	Private _pB1_PESBRU As System.Nullable(Of Double)
	
	Private _pQUANT_UNIDADE As System.Nullable(Of Double)
	
	Private _pPRECO_VENDA As System.Nullable(Of Double)
	
	Private _pQUANT_CAIXA As System.Nullable(Of Double)
	
	Private _pQTDPCT As System.Nullable(Of Double)
	
	Private _pQTDBRU As System.Nullable(Of Double)
	
	Private _pNUMERO_ORCAMENTO As String
	
	Private _pFORMAS As System.Nullable(Of Double)
	
	Private _pTOTAL_ITEM As System.Nullable(Of Double)
	
	Private _pPEDCLI As String
	
	Private _pPRUNIT As System.Nullable(Of Double)
	
	Private _pDT_EMISSAO_PED As System.Nullable(Of Date)
	
	Private _pDT_EMISSAO_FAT As System.Nullable(Of Date)
	
	Private _pDIAS_PEDIDO As System.Nullable(Of Integer)
	
	Private _pSTATUS As String
	
	Private _pDTDIA_EMISSAO_PED As String
	
	Private _pDTMES_EMISSAO_PED As String
	
	Private _pDTANO_EMISSAO_PED As String
	
	Private _pDTDIA_EMISSAO_FAT As String
	
	Private _pDTMES_EMISSAO_FAT As String
	
	Private _pDTANO_EMISSAO_FAT As String
	
	Private __trackLastWriteTime As Date
	
	Private __trackCreationTime As Date
	
	Private __trackLastWriteUser As String
	
	Private __trackCreationUser As String
	
	Private _pUF_CLIENTE As String
	
	Private _pREGIAO As String
	
	Private _pBM_DESC As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnpIdChanging(value As Long)
    End Sub
    Partial Private Sub OnpIdChanged()
    End Sub
    Partial Private Sub OnpTIPO_OPChanging(value As String)
    End Sub
    Partial Private Sub OnpTIPO_OPChanged()
    End Sub
    Partial Private Sub OnpFILIALChanging(value As String)
    End Sub
    Partial Private Sub OnpFILIALChanged()
    End Sub
    Partial Private Sub OnpPEDIDOChanging(value As String)
    End Sub
    Partial Private Sub OnpPEDIDOChanged()
    End Sub
    Partial Private Sub OnpNOTA_FISCALChanging(value As String)
    End Sub
    Partial Private Sub OnpNOTA_FISCALChanged()
    End Sub
    Partial Private Sub OnpSERIE_NFChanging(value As String)
    End Sub
    Partial Private Sub OnpSERIE_NFChanged()
    End Sub
    Partial Private Sub OnpCOD_CLIENTEChanging(value As String)
    End Sub
    Partial Private Sub OnpCOD_CLIENTEChanged()
    End Sub
    Partial Private Sub OnpLOJAChanging(value As String)
    End Sub
    Partial Private Sub OnpLOJAChanged()
    End Sub
    Partial Private Sub OnpDESC_CLIENTEChanging(value As String)
    End Sub
    Partial Private Sub OnpDESC_CLIENTEChanged()
    End Sub
    Partial Private Sub OnpCOD_VENDEDORChanging(value As String)
    End Sub
    Partial Private Sub OnpCOD_VENDEDORChanged()
    End Sub
    Partial Private Sub OnpNOME_VENDEDORChanging(value As String)
    End Sub
    Partial Private Sub OnpNOME_VENDEDORChanged()
    End Sub
    Partial Private Sub OnpDT_EMISSAOChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnpDT_EMISSAOChanged()
    End Sub
    Partial Private Sub OnpCOD_GRUPO_CLIENTEChanging(value As String)
    End Sub
    Partial Private Sub OnpCOD_GRUPO_CLIENTEChanged()
    End Sub
    Partial Private Sub OnpDESC_GRUPO_CLIENTEChanging(value As String)
    End Sub
    Partial Private Sub OnpDESC_GRUPO_CLIENTEChanged()
    End Sub
    Partial Private Sub OnpCODIGO_PRODUTOChanging(value As String)
    End Sub
    Partial Private Sub OnpCODIGO_PRODUTOChanged()
    End Sub
    Partial Private Sub OnpDESC_PRODUTOChanging(value As String)
    End Sub
    Partial Private Sub OnpDESC_PRODUTOChanged()
    End Sub
    Partial Private Sub OnpB1_PESBRUChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpB1_PESBRUChanged()
    End Sub
    Partial Private Sub OnpQUANT_UNIDADEChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpQUANT_UNIDADEChanged()
    End Sub
    Partial Private Sub OnpPRECO_VENDAChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpPRECO_VENDAChanged()
    End Sub
    Partial Private Sub OnpQUANT_CAIXAChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpQUANT_CAIXAChanged()
    End Sub
    Partial Private Sub OnpQTDPCTChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpQTDPCTChanged()
    End Sub
    Partial Private Sub OnpQTDBRUChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpQTDBRUChanged()
    End Sub
    Partial Private Sub OnpNUMERO_ORCAMENTOChanging(value As String)
    End Sub
    Partial Private Sub OnpNUMERO_ORCAMENTOChanged()
    End Sub
    Partial Private Sub OnpFORMASChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpFORMASChanged()
    End Sub
    Partial Private Sub OnpTOTAL_ITEMChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpTOTAL_ITEMChanged()
    End Sub
    Partial Private Sub OnpPEDCLIChanging(value As String)
    End Sub
    Partial Private Sub OnpPEDCLIChanged()
    End Sub
    Partial Private Sub OnpPRUNITChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnpPRUNITChanged()
    End Sub
    Partial Private Sub OnpDT_EMISSAO_PEDChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnpDT_EMISSAO_PEDChanged()
    End Sub
    Partial Private Sub OnpDT_EMISSAO_FATChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnpDT_EMISSAO_FATChanged()
    End Sub
    Partial Private Sub OnpDIAS_PEDIDOChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnpDIAS_PEDIDOChanged()
    End Sub
    Partial Private Sub OnpSTATUSChanging(value As String)
    End Sub
    Partial Private Sub OnpSTATUSChanged()
    End Sub
    Partial Private Sub OnpDTDIA_EMISSAO_PEDChanging(value As String)
    End Sub
    Partial Private Sub OnpDTDIA_EMISSAO_PEDChanged()
    End Sub
    Partial Private Sub OnpDTMES_EMISSAO_PEDChanging(value As String)
    End Sub
    Partial Private Sub OnpDTMES_EMISSAO_PEDChanged()
    End Sub
    Partial Private Sub OnpDTANO_EMISSAO_PEDChanging(value As String)
    End Sub
    Partial Private Sub OnpDTANO_EMISSAO_PEDChanged()
    End Sub
    Partial Private Sub OnpDTDIA_EMISSAO_FATChanging(value As String)
    End Sub
    Partial Private Sub OnpDTDIA_EMISSAO_FATChanged()
    End Sub
    Partial Private Sub OnpDTMES_EMISSAO_FATChanging(value As String)
    End Sub
    Partial Private Sub OnpDTMES_EMISSAO_FATChanged()
    End Sub
    Partial Private Sub OnpDTANO_EMISSAO_FATChanging(value As String)
    End Sub
    Partial Private Sub OnpDTANO_EMISSAO_FATChanged()
    End Sub
    Partial Private Sub On_trackLastWriteTimeChanging(value As Date)
    End Sub
    Partial Private Sub On_trackLastWriteTimeChanged()
    End Sub
    Partial Private Sub On_trackCreationTimeChanging(value As Date)
    End Sub
    Partial Private Sub On_trackCreationTimeChanged()
    End Sub
    Partial Private Sub On_trackLastWriteUserChanging(value As String)
    End Sub
    Partial Private Sub On_trackLastWriteUserChanged()
    End Sub
    Partial Private Sub On_trackCreationUserChanging(value As String)
    End Sub
    Partial Private Sub On_trackCreationUserChanged()
    End Sub
    Partial Private Sub OnpUF_CLIENTEChanging(value As String)
    End Sub
    Partial Private Sub OnpUF_CLIENTEChanged()
    End Sub
    Partial Private Sub OnpREGIAOChanging(value As String)
    End Sub
    Partial Private Sub OnpREGIAOChanged()
    End Sub
    Partial Private Sub OnpBM_DESCChanging(value As String)
    End Sub
    Partial Private Sub OnpBM_DESCChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pId", AutoSync:=AutoSync.OnInsert, DbType:="BigInt NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property pId() As Long
		Get
			Return Me._pId
		End Get
		Set
			If ((Me._pId = value)  _
						= false) Then
				Me.OnpIdChanging(value)
				Me.SendPropertyChanging
				Me._pId = value
				Me.SendPropertyChanged("pId")
				Me.OnpIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pTIPO_OP", DbType:="NVarChar(256)")>  _
	Public Property pTIPO_OP() As String
		Get
			Return Me._pTIPO_OP
		End Get
		Set
			If (String.Equals(Me._pTIPO_OP, value) = false) Then
				Me.OnpTIPO_OPChanging(value)
				Me.SendPropertyChanging
				Me._pTIPO_OP = value
				Me.SendPropertyChanged("pTIPO_OP")
				Me.OnpTIPO_OPChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pFILIAL", DbType:="NVarChar(256)")>  _
	Public Property pFILIAL() As String
		Get
			Return Me._pFILIAL
		End Get
		Set
			If (String.Equals(Me._pFILIAL, value) = false) Then
				Me.OnpFILIALChanging(value)
				Me.SendPropertyChanging
				Me._pFILIAL = value
				Me.SendPropertyChanged("pFILIAL")
				Me.OnpFILIALChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pPEDIDO", DbType:="NVarChar(256)")>  _
	Public Property pPEDIDO() As String
		Get
			Return Me._pPEDIDO
		End Get
		Set
			If (String.Equals(Me._pPEDIDO, value) = false) Then
				Me.OnpPEDIDOChanging(value)
				Me.SendPropertyChanging
				Me._pPEDIDO = value
				Me.SendPropertyChanged("pPEDIDO")
				Me.OnpPEDIDOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pNOTA_FISCAL", DbType:="NVarChar(256)")>  _
	Public Property pNOTA_FISCAL() As String
		Get
			Return Me._pNOTA_FISCAL
		End Get
		Set
			If (String.Equals(Me._pNOTA_FISCAL, value) = false) Then
				Me.OnpNOTA_FISCALChanging(value)
				Me.SendPropertyChanging
				Me._pNOTA_FISCAL = value
				Me.SendPropertyChanged("pNOTA_FISCAL")
				Me.OnpNOTA_FISCALChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pSERIE_NF", DbType:="NVarChar(256)")>  _
	Public Property pSERIE_NF() As String
		Get
			Return Me._pSERIE_NF
		End Get
		Set
			If (String.Equals(Me._pSERIE_NF, value) = false) Then
				Me.OnpSERIE_NFChanging(value)
				Me.SendPropertyChanging
				Me._pSERIE_NF = value
				Me.SendPropertyChanged("pSERIE_NF")
				Me.OnpSERIE_NFChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pCOD_CLIENTE", DbType:="NVarChar(256)")>  _
	Public Property pCOD_CLIENTE() As String
		Get
			Return Me._pCOD_CLIENTE
		End Get
		Set
			If (String.Equals(Me._pCOD_CLIENTE, value) = false) Then
				Me.OnpCOD_CLIENTEChanging(value)
				Me.SendPropertyChanging
				Me._pCOD_CLIENTE = value
				Me.SendPropertyChanged("pCOD_CLIENTE")
				Me.OnpCOD_CLIENTEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pLOJA", DbType:="NVarChar(256)")>  _
	Public Property pLOJA() As String
		Get
			Return Me._pLOJA
		End Get
		Set
			If (String.Equals(Me._pLOJA, value) = false) Then
				Me.OnpLOJAChanging(value)
				Me.SendPropertyChanging
				Me._pLOJA = value
				Me.SendPropertyChanged("pLOJA")
				Me.OnpLOJAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDESC_CLIENTE", DbType:="NVarChar(256)")>  _
	Public Property pDESC_CLIENTE() As String
		Get
			Return Me._pDESC_CLIENTE
		End Get
		Set
			If (String.Equals(Me._pDESC_CLIENTE, value) = false) Then
				Me.OnpDESC_CLIENTEChanging(value)
				Me.SendPropertyChanging
				Me._pDESC_CLIENTE = value
				Me.SendPropertyChanged("pDESC_CLIENTE")
				Me.OnpDESC_CLIENTEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pCOD_VENDEDOR", DbType:="NVarChar(256)")>  _
	Public Property pCOD_VENDEDOR() As String
		Get
			Return Me._pCOD_VENDEDOR
		End Get
		Set
			If (String.Equals(Me._pCOD_VENDEDOR, value) = false) Then
				Me.OnpCOD_VENDEDORChanging(value)
				Me.SendPropertyChanging
				Me._pCOD_VENDEDOR = value
				Me.SendPropertyChanged("pCOD_VENDEDOR")
				Me.OnpCOD_VENDEDORChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pNOME_VENDEDOR", DbType:="NVarChar(256)")>  _
	Public Property pNOME_VENDEDOR() As String
		Get
			Return Me._pNOME_VENDEDOR
		End Get
		Set
			If (String.Equals(Me._pNOME_VENDEDOR, value) = false) Then
				Me.OnpNOME_VENDEDORChanging(value)
				Me.SendPropertyChanging
				Me._pNOME_VENDEDOR = value
				Me.SendPropertyChanged("pNOME_VENDEDOR")
				Me.OnpNOME_VENDEDORChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDT_EMISSAO", DbType:="Date")>  _
	Public Property pDT_EMISSAO() As System.Nullable(Of Date)
		Get
			Return Me._pDT_EMISSAO
		End Get
		Set
			If (Me._pDT_EMISSAO.Equals(value) = false) Then
				Me.OnpDT_EMISSAOChanging(value)
				Me.SendPropertyChanging
				Me._pDT_EMISSAO = value
				Me.SendPropertyChanged("pDT_EMISSAO")
				Me.OnpDT_EMISSAOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pCOD_GRUPO_CLIENTE", DbType:="NVarChar(256)")>  _
	Public Property pCOD_GRUPO_CLIENTE() As String
		Get
			Return Me._pCOD_GRUPO_CLIENTE
		End Get
		Set
			If (String.Equals(Me._pCOD_GRUPO_CLIENTE, value) = false) Then
				Me.OnpCOD_GRUPO_CLIENTEChanging(value)
				Me.SendPropertyChanging
				Me._pCOD_GRUPO_CLIENTE = value
				Me.SendPropertyChanged("pCOD_GRUPO_CLIENTE")
				Me.OnpCOD_GRUPO_CLIENTEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDESC_GRUPO_CLIENTE", DbType:="NVarChar(256)")>  _
	Public Property pDESC_GRUPO_CLIENTE() As String
		Get
			Return Me._pDESC_GRUPO_CLIENTE
		End Get
		Set
			If (String.Equals(Me._pDESC_GRUPO_CLIENTE, value) = false) Then
				Me.OnpDESC_GRUPO_CLIENTEChanging(value)
				Me.SendPropertyChanging
				Me._pDESC_GRUPO_CLIENTE = value
				Me.SendPropertyChanged("pDESC_GRUPO_CLIENTE")
				Me.OnpDESC_GRUPO_CLIENTEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pCODIGO_PRODUTO", DbType:="NVarChar(256)")>  _
	Public Property pCODIGO_PRODUTO() As String
		Get
			Return Me._pCODIGO_PRODUTO
		End Get
		Set
			If (String.Equals(Me._pCODIGO_PRODUTO, value) = false) Then
				Me.OnpCODIGO_PRODUTOChanging(value)
				Me.SendPropertyChanging
				Me._pCODIGO_PRODUTO = value
				Me.SendPropertyChanged("pCODIGO_PRODUTO")
				Me.OnpCODIGO_PRODUTOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDESC_PRODUTO", DbType:="NVarChar(256)")>  _
	Public Property pDESC_PRODUTO() As String
		Get
			Return Me._pDESC_PRODUTO
		End Get
		Set
			If (String.Equals(Me._pDESC_PRODUTO, value) = false) Then
				Me.OnpDESC_PRODUTOChanging(value)
				Me.SendPropertyChanging
				Me._pDESC_PRODUTO = value
				Me.SendPropertyChanged("pDESC_PRODUTO")
				Me.OnpDESC_PRODUTOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pB1_PESBRU", DbType:="Float")>  _
	Public Property pB1_PESBRU() As System.Nullable(Of Double)
		Get
			Return Me._pB1_PESBRU
		End Get
		Set
			If (Me._pB1_PESBRU.Equals(value) = false) Then
				Me.OnpB1_PESBRUChanging(value)
				Me.SendPropertyChanging
				Me._pB1_PESBRU = value
				Me.SendPropertyChanged("pB1_PESBRU")
				Me.OnpB1_PESBRUChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pQUANT_UNIDADE", DbType:="Float")>  _
	Public Property pQUANT_UNIDADE() As System.Nullable(Of Double)
		Get
			Return Me._pQUANT_UNIDADE
		End Get
		Set
			If (Me._pQUANT_UNIDADE.Equals(value) = false) Then
				Me.OnpQUANT_UNIDADEChanging(value)
				Me.SendPropertyChanging
				Me._pQUANT_UNIDADE = value
				Me.SendPropertyChanged("pQUANT_UNIDADE")
				Me.OnpQUANT_UNIDADEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pPRECO_VENDA", DbType:="Float")>  _
	Public Property pPRECO_VENDA() As System.Nullable(Of Double)
		Get
			Return Me._pPRECO_VENDA
		End Get
		Set
			If (Me._pPRECO_VENDA.Equals(value) = false) Then
				Me.OnpPRECO_VENDAChanging(value)
				Me.SendPropertyChanging
				Me._pPRECO_VENDA = value
				Me.SendPropertyChanged("pPRECO_VENDA")
				Me.OnpPRECO_VENDAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pQUANT_CAIXA", DbType:="Float")>  _
	Public Property pQUANT_CAIXA() As System.Nullable(Of Double)
		Get
			Return Me._pQUANT_CAIXA
		End Get
		Set
			If (Me._pQUANT_CAIXA.Equals(value) = false) Then
				Me.OnpQUANT_CAIXAChanging(value)
				Me.SendPropertyChanging
				Me._pQUANT_CAIXA = value
				Me.SendPropertyChanged("pQUANT_CAIXA")
				Me.OnpQUANT_CAIXAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pQTDPCT", DbType:="Float")>  _
	Public Property pQTDPCT() As System.Nullable(Of Double)
		Get
			Return Me._pQTDPCT
		End Get
		Set
			If (Me._pQTDPCT.Equals(value) = false) Then
				Me.OnpQTDPCTChanging(value)
				Me.SendPropertyChanging
				Me._pQTDPCT = value
				Me.SendPropertyChanged("pQTDPCT")
				Me.OnpQTDPCTChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pQTDBRU", DbType:="Float")>  _
	Public Property pQTDBRU() As System.Nullable(Of Double)
		Get
			Return Me._pQTDBRU
		End Get
		Set
			If (Me._pQTDBRU.Equals(value) = false) Then
				Me.OnpQTDBRUChanging(value)
				Me.SendPropertyChanging
				Me._pQTDBRU = value
				Me.SendPropertyChanged("pQTDBRU")
				Me.OnpQTDBRUChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pNUMERO_ORCAMENTO", DbType:="NVarChar(256)")>  _
	Public Property pNUMERO_ORCAMENTO() As String
		Get
			Return Me._pNUMERO_ORCAMENTO
		End Get
		Set
			If (String.Equals(Me._pNUMERO_ORCAMENTO, value) = false) Then
				Me.OnpNUMERO_ORCAMENTOChanging(value)
				Me.SendPropertyChanging
				Me._pNUMERO_ORCAMENTO = value
				Me.SendPropertyChanged("pNUMERO_ORCAMENTO")
				Me.OnpNUMERO_ORCAMENTOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pFORMAS", DbType:="Float")>  _
	Public Property pFORMAS() As System.Nullable(Of Double)
		Get
			Return Me._pFORMAS
		End Get
		Set
			If (Me._pFORMAS.Equals(value) = false) Then
				Me.OnpFORMASChanging(value)
				Me.SendPropertyChanging
				Me._pFORMAS = value
				Me.SendPropertyChanged("pFORMAS")
				Me.OnpFORMASChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pTOTAL_ITEM", DbType:="Float")>  _
	Public Property pTOTAL_ITEM() As System.Nullable(Of Double)
		Get
			Return Me._pTOTAL_ITEM
		End Get
		Set
			If (Me._pTOTAL_ITEM.Equals(value) = false) Then
				Me.OnpTOTAL_ITEMChanging(value)
				Me.SendPropertyChanging
				Me._pTOTAL_ITEM = value
				Me.SendPropertyChanged("pTOTAL_ITEM")
				Me.OnpTOTAL_ITEMChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pPEDCLI", DbType:="NVarChar(256)")>  _
	Public Property pPEDCLI() As String
		Get
			Return Me._pPEDCLI
		End Get
		Set
			If (String.Equals(Me._pPEDCLI, value) = false) Then
				Me.OnpPEDCLIChanging(value)
				Me.SendPropertyChanging
				Me._pPEDCLI = value
				Me.SendPropertyChanged("pPEDCLI")
				Me.OnpPEDCLIChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pPRUNIT", DbType:="Float")>  _
	Public Property pPRUNIT() As System.Nullable(Of Double)
		Get
			Return Me._pPRUNIT
		End Get
		Set
			If (Me._pPRUNIT.Equals(value) = false) Then
				Me.OnpPRUNITChanging(value)
				Me.SendPropertyChanging
				Me._pPRUNIT = value
				Me.SendPropertyChanged("pPRUNIT")
				Me.OnpPRUNITChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDT_EMISSAO_PED", DbType:="Date")>  _
	Public Property pDT_EMISSAO_PED() As System.Nullable(Of Date)
		Get
			Return Me._pDT_EMISSAO_PED
		End Get
		Set
			If (Me._pDT_EMISSAO_PED.Equals(value) = false) Then
				Me.OnpDT_EMISSAO_PEDChanging(value)
				Me.SendPropertyChanging
				Me._pDT_EMISSAO_PED = value
				Me.SendPropertyChanged("pDT_EMISSAO_PED")
				Me.OnpDT_EMISSAO_PEDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDT_EMISSAO_FAT", DbType:="Date")>  _
	Public Property pDT_EMISSAO_FAT() As System.Nullable(Of Date)
		Get
			Return Me._pDT_EMISSAO_FAT
		End Get
		Set
			If (Me._pDT_EMISSAO_FAT.Equals(value) = false) Then
				Me.OnpDT_EMISSAO_FATChanging(value)
				Me.SendPropertyChanging
				Me._pDT_EMISSAO_FAT = value
				Me.SendPropertyChanged("pDT_EMISSAO_FAT")
				Me.OnpDT_EMISSAO_FATChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDIAS_PEDIDO", DbType:="Int")>  _
	Public Property pDIAS_PEDIDO() As System.Nullable(Of Integer)
		Get
			Return Me._pDIAS_PEDIDO
		End Get
		Set
			If (Me._pDIAS_PEDIDO.Equals(value) = false) Then
				Me.OnpDIAS_PEDIDOChanging(value)
				Me.SendPropertyChanging
				Me._pDIAS_PEDIDO = value
				Me.SendPropertyChanged("pDIAS_PEDIDO")
				Me.OnpDIAS_PEDIDOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pSTATUS", DbType:="NVarChar(256)")>  _
	Public Property pSTATUS() As String
		Get
			Return Me._pSTATUS
		End Get
		Set
			If (String.Equals(Me._pSTATUS, value) = false) Then
				Me.OnpSTATUSChanging(value)
				Me.SendPropertyChanging
				Me._pSTATUS = value
				Me.SendPropertyChanged("pSTATUS")
				Me.OnpSTATUSChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTDIA_EMISSAO_PED", DbType:="NVarChar(256)")>  _
	Public Property pDTDIA_EMISSAO_PED() As String
		Get
			Return Me._pDTDIA_EMISSAO_PED
		End Get
		Set
			If (String.Equals(Me._pDTDIA_EMISSAO_PED, value) = false) Then
				Me.OnpDTDIA_EMISSAO_PEDChanging(value)
				Me.SendPropertyChanging
				Me._pDTDIA_EMISSAO_PED = value
				Me.SendPropertyChanged("pDTDIA_EMISSAO_PED")
				Me.OnpDTDIA_EMISSAO_PEDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTMES_EMISSAO_PED", DbType:="NVarChar(256)")>  _
	Public Property pDTMES_EMISSAO_PED() As String
		Get
			Return Me._pDTMES_EMISSAO_PED
		End Get
		Set
			If (String.Equals(Me._pDTMES_EMISSAO_PED, value) = false) Then
				Me.OnpDTMES_EMISSAO_PEDChanging(value)
				Me.SendPropertyChanging
				Me._pDTMES_EMISSAO_PED = value
				Me.SendPropertyChanged("pDTMES_EMISSAO_PED")
				Me.OnpDTMES_EMISSAO_PEDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTANO_EMISSAO_PED", DbType:="NVarChar(256)")>  _
	Public Property pDTANO_EMISSAO_PED() As String
		Get
			Return Me._pDTANO_EMISSAO_PED
		End Get
		Set
			If (String.Equals(Me._pDTANO_EMISSAO_PED, value) = false) Then
				Me.OnpDTANO_EMISSAO_PEDChanging(value)
				Me.SendPropertyChanging
				Me._pDTANO_EMISSAO_PED = value
				Me.SendPropertyChanged("pDTANO_EMISSAO_PED")
				Me.OnpDTANO_EMISSAO_PEDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTDIA_EMISSAO_FAT", DbType:="NVarChar(256)")>  _
	Public Property pDTDIA_EMISSAO_FAT() As String
		Get
			Return Me._pDTDIA_EMISSAO_FAT
		End Get
		Set
			If (String.Equals(Me._pDTDIA_EMISSAO_FAT, value) = false) Then
				Me.OnpDTDIA_EMISSAO_FATChanging(value)
				Me.SendPropertyChanging
				Me._pDTDIA_EMISSAO_FAT = value
				Me.SendPropertyChanged("pDTDIA_EMISSAO_FAT")
				Me.OnpDTDIA_EMISSAO_FATChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTMES_EMISSAO_FAT", DbType:="NVarChar(256)")>  _
	Public Property pDTMES_EMISSAO_FAT() As String
		Get
			Return Me._pDTMES_EMISSAO_FAT
		End Get
		Set
			If (String.Equals(Me._pDTMES_EMISSAO_FAT, value) = false) Then
				Me.OnpDTMES_EMISSAO_FATChanging(value)
				Me.SendPropertyChanging
				Me._pDTMES_EMISSAO_FAT = value
				Me.SendPropertyChanged("pDTMES_EMISSAO_FAT")
				Me.OnpDTMES_EMISSAO_FATChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pDTANO_EMISSAO_FAT", DbType:="NVarChar(256)")>  _
	Public Property pDTANO_EMISSAO_FAT() As String
		Get
			Return Me._pDTANO_EMISSAO_FAT
		End Get
		Set
			If (String.Equals(Me._pDTANO_EMISSAO_FAT, value) = false) Then
				Me.OnpDTANO_EMISSAO_FATChanging(value)
				Me.SendPropertyChanging
				Me._pDTANO_EMISSAO_FAT = value
				Me.SendPropertyChanged("pDTANO_EMISSAO_FAT")
				Me.OnpDTANO_EMISSAO_FATChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[_trackLastWriteTime]", Storage:="__trackLastWriteTime", DbType:="DateTime NOT NULL")>  _
	Public Property _trackLastWriteTime() As Date
		Get
			Return Me.__trackLastWriteTime
		End Get
		Set
			If ((Me.__trackLastWriteTime = value)  _
						= false) Then
				Me.On_trackLastWriteTimeChanging(value)
				Me.SendPropertyChanging
				Me.__trackLastWriteTime = value
				Me.SendPropertyChanged("_trackLastWriteTime")
				Me.On_trackLastWriteTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[_trackCreationTime]", Storage:="__trackCreationTime", DbType:="DateTime NOT NULL")>  _
	Public Property _trackCreationTime() As Date
		Get
			Return Me.__trackCreationTime
		End Get
		Set
			If ((Me.__trackCreationTime = value)  _
						= false) Then
				Me.On_trackCreationTimeChanging(value)
				Me.SendPropertyChanging
				Me.__trackCreationTime = value
				Me.SendPropertyChanged("_trackCreationTime")
				Me.On_trackCreationTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[_trackLastWriteUser]", Storage:="__trackLastWriteUser", DbType:="NVarChar(64) NOT NULL", CanBeNull:=false)>  _
	Public Property _trackLastWriteUser() As String
		Get
			Return Me.__trackLastWriteUser
		End Get
		Set
			If (String.Equals(Me.__trackLastWriteUser, value) = false) Then
				Me.On_trackLastWriteUserChanging(value)
				Me.SendPropertyChanging
				Me.__trackLastWriteUser = value
				Me.SendPropertyChanged("_trackLastWriteUser")
				Me.On_trackLastWriteUserChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[_trackCreationUser]", Storage:="__trackCreationUser", DbType:="NVarChar(64) NOT NULL", CanBeNull:=false)>  _
	Public Property _trackCreationUser() As String
		Get
			Return Me.__trackCreationUser
		End Get
		Set
			If (String.Equals(Me.__trackCreationUser, value) = false) Then
				Me.On_trackCreationUserChanging(value)
				Me.SendPropertyChanging
				Me.__trackCreationUser = value
				Me.SendPropertyChanged("_trackCreationUser")
				Me.On_trackCreationUserChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pUF_CLIENTE", DbType:="NVarChar(256)")>  _
	Public Property pUF_CLIENTE() As String
		Get
			Return Me._pUF_CLIENTE
		End Get
		Set
			If (String.Equals(Me._pUF_CLIENTE, value) = false) Then
				Me.OnpUF_CLIENTEChanging(value)
				Me.SendPropertyChanging
				Me._pUF_CLIENTE = value
				Me.SendPropertyChanged("pUF_CLIENTE")
				Me.OnpUF_CLIENTEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pREGIAO", DbType:="NVarChar(256)")>  _
	Public Property pREGIAO() As String
		Get
			Return Me._pREGIAO
		End Get
		Set
			If (String.Equals(Me._pREGIAO, value) = false) Then
				Me.OnpREGIAOChanging(value)
				Me.SendPropertyChanging
				Me._pREGIAO = value
				Me.SendPropertyChanged("pREGIAO")
				Me.OnpREGIAOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pBM_DESC", DbType:="NVarChar(256)")>  _
	Public Property pBM_DESC() As String
		Get
			Return Me._pBM_DESC
		End Get
		Set
			If (String.Equals(Me._pBM_DESC, value) = false) Then
				Me.OnpBM_DESCChanging(value)
				Me.SendPropertyChanging
				Me._pBM_DESC = value
				Me.SendPropertyChanged("pBM_DESC")
				Me.OnpBM_DESCChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
