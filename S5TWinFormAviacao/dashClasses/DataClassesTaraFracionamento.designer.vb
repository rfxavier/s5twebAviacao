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
Partial Public Class DataClassesTaraFracionamentoDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.S5TWinFormAviacao.Settings.Default.s5taviacaoConnectionString1, mappingSource)
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
	
	Public ReadOnly Property vTaraFracionamentoTaraFracionamentoViews() As System.Data.Linq.Table(Of vTaraFracionamentoTaraFracionamentoView)
		Get
			Return Me.GetTable(Of vTaraFracionamentoTaraFracionamentoView)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.vTaraFracionamentoTaraFracionamentoView")>  _
Partial Public Class vTaraFracionamentoTaraFracionamentoView
	
	Private _pId As Long
	
	Private _C2_PRODUTO As String
	
	Private _G1_COMP As String
	
	Private _pEmbalagemDescricao As String
	
	Private _pEmbalagemPeso As System.Nullable(Of Double)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pId", DbType:="BigInt NOT NULL")>  _
	Public Property pId() As Long
		Get
			Return Me._pId
		End Get
		Set
			If ((Me._pId = value)  _
						= false) Then
				Me._pId = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_C2_PRODUTO", DbType:="NVarChar(256)")>  _
	Public Property C2_PRODUTO() As String
		Get
			Return Me._C2_PRODUTO
		End Get
		Set
			If (String.Equals(Me._C2_PRODUTO, value) = false) Then
				Me._C2_PRODUTO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_G1_COMP", DbType:="NVarChar(256)")>  _
	Public Property G1_COMP() As String
		Get
			Return Me._G1_COMP
		End Get
		Set
			If (String.Equals(Me._G1_COMP, value) = false) Then
				Me._G1_COMP = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pEmbalagemDescricao", DbType:="NVarChar(256)")>  _
	Public Property pEmbalagemDescricao() As String
		Get
			Return Me._pEmbalagemDescricao
		End Get
		Set
			If (String.Equals(Me._pEmbalagemDescricao, value) = false) Then
				Me._pEmbalagemDescricao = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pEmbalagemPeso", DbType:="Float")>  _
	Public Property pEmbalagemPeso() As System.Nullable(Of Double)
		Get
			Return Me._pEmbalagemPeso
		End Get
		Set
			If (Me._pEmbalagemPeso.Equals(value) = false) Then
				Me._pEmbalagemPeso = value
			End If
		End Set
	End Property
End Class