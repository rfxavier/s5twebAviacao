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
    Partial Public Class lwMovimentacaoDeEstoqueEntradaPorProducao
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _produtoCodigo As String = CType(Nothing, String)
        
        Private _produtoDescricao As String = CType(Nothing, String)
        
        Private _dataFabricacao As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _dataValidade As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _lote As String = CType(Nothing, String)
        
        Private _caixas As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _quantidade As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property ProdutoCodigo() As String
            Get
                Return Me._produtoCodigo
            End Get
            Set
                Me._produtoCodigo = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property ProdutoDescricao() As String
            Get
                Return Me._produtoDescricao
            End Get
            Set
                Me._produtoDescricao = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property DataFabricacao() As Date
            Get
                Return Me._dataFabricacao
            End Get
            Set
                Me._dataFabricacao = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property DataValidade() As Date
            Get
                Return Me._dataValidade
            End Get
            Set
                Me._dataValidade = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Lote() As String
            Get
                Return Me._lote
            End Get
            Set
                Me._lote = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property Caixas() As Integer
            Get
                Return Me._caixas
            End Get
            Set
                Me._caixas = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property Quantidade() As Integer
            Get
                Return Me._quantidade
            End Get
            Set
                Me._quantidade = value
            End Set
        End Property
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._produtoCodigo = CodeFluentPersistence.GetReaderValue(reader, "ProdutoCodigo", CType(CType(Nothing, String),String))
                Me._produtoDescricao = CodeFluentPersistence.GetReaderValue(reader, "ProdutoDescricao", CType(CType(Nothing, String),String))
                Me._dataFabricacao = CodeFluentPersistence.GetReaderValue(reader, "DataFabricacao", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._dataValidade = CodeFluentPersistence.GetReaderValue(reader, "DataValidade", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._lote = CodeFluentPersistence.GetReaderValue(reader, "Lote", CType(CType(Nothing, String),String))
                Me._caixas = CodeFluentPersistence.GetReaderValue(reader, "Caixas", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._quantidade = CodeFluentPersistence.GetReaderValue(reader, "Quantidade", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
