﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CodeFluent.Runtime
Imports CodeFluent.Runtime.Utilities

Namespace S5T
    
    'CodeFluent Entities generated (http://www.softfluent.com). Date: .
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.01234.05678"),  _
     System.SerializableAttribute(),  _
     System.ComponentModel.DataObjectAttribute()>  _
    Partial Public Class MovimentacaoLoteViewDashboard
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pId As Long = -1
        
        Private _pLote As String = CType(Nothing, String)
        
        Private _pFormas As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pDataFabricacao As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pDataMaturacao As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pFinalizado As String = CType(Nothing, String)
        
        Private _pProdutoDescricao As String = CType(Nothing, String)
        
        Private _pProdutoPrevisaoDescricao As String = CType(Nothing, String)
        
        Private _pProdutoPrevisaoFormas As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pProdutoPrevisaoCaixas As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(CType(-1,Long)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long)),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property pId() As Long
            Get
                Return Me._pId
            End Get
            Set
                Me._pId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pLote() As String
            Get
                Return Me._pLote
            End Get
            Set
                Me._pLote = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pFormas() As Integer
            Get
                Return Me._pFormas
            End Get
            Set
                Me._pFormas = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataFabricacao() As Date
            Get
                Return Me._pDataFabricacao
            End Get
            Set
                Me._pDataFabricacao = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataMaturacao() As Date
            Get
                Return Me._pDataMaturacao
            End Get
            Set
                Me._pDataMaturacao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pFinalizado() As String
            Get
                Return Me._pFinalizado
            End Get
            Set
                Me._pFinalizado = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pProdutoDescricao() As String
            Get
                Return Me._pProdutoDescricao
            End Get
            Set
                Me._pProdutoDescricao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pProdutoPrevisaoDescricao() As String
            Get
                Return Me._pProdutoPrevisaoDescricao
            End Get
            Set
                Me._pProdutoPrevisaoDescricao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pProdutoPrevisaoFormas() As Integer
            Get
                Return Me._pProdutoPrevisaoFormas
            End Get
            Set
                Me._pProdutoPrevisaoFormas = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pProdutoPrevisaoCaixas() As Integer
            Get
                Return Me._pProdutoPrevisaoCaixas
            End Get
            Set
                Me._pProdutoPrevisaoCaixas = value
            End Set
        End Property
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._pId = CodeFluentPersistence.GetReaderValue(reader, "pId", CType(-1,Long))
                Me._pLote = CodeFluentPersistence.GetReaderValue(reader, "pLote", CType(CType(Nothing, String),String))
                Me._pFormas = CodeFluentPersistence.GetReaderValue(reader, "pFormas", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pDataFabricacao = CodeFluentPersistence.GetReaderValue(reader, "pDataFabricacao", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pDataMaturacao = CodeFluentPersistence.GetReaderValue(reader, "pDataMaturacao", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pFinalizado = CodeFluentPersistence.GetReaderValue(reader, "pFinalizado", CType(CType(Nothing, String),String))
                Me._pProdutoDescricao = CodeFluentPersistence.GetReaderValue(reader, "pProdutoDescricao", CType(CType(Nothing, String),String))
                Me._pProdutoPrevisaoDescricao = CodeFluentPersistence.GetReaderValue(reader, "pProdutoPrevisaoDescricao", CType(CType(Nothing, String),String))
                Me._pProdutoPrevisaoFormas = CodeFluentPersistence.GetReaderValue(reader, "pProdutoPrevisaoFormas", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pProdutoPrevisaoCaixas = CodeFluentPersistence.GetReaderValue(reader, "pProdutoPrevisaoCaixas", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
