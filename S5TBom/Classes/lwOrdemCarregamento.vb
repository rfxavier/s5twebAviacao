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
    Partial Public Class lwOrdemCarregamento
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pClienteDescricao As String = CType(Nothing, String)
        
        Private _pProdutoCodigo As String = CType(Nothing, String)
        
        Private _pProdutoDescricao As String = CType(Nothing, String)
        
        Private _pQuantidade As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pM3 As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pPeso As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pFormas As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pQuantidadeCarregada As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pClienteDescricao() As String
            Get
                Return Me._pClienteDescricao
            End Get
            Set
                Me._pClienteDescricao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pProdutoCodigo() As String
            Get
                Return Me._pProdutoCodigo
            End Get
            Set
                Me._pProdutoCodigo = value
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
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pQuantidade() As Double
            Get
                Return Me._pQuantidade
            End Get
            Set
                Me._pQuantidade = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pM3() As Double
            Get
                Return Me._pM3
            End Get
            Set
                Me._pM3 = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pPeso() As Double
            Get
                Return Me._pPeso
            End Get
            Set
                Me._pPeso = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pFormas() As Double
            Get
                Return Me._pFormas
            End Get
            Set
                Me._pFormas = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pId() As Long
            Get
                Return Me._pId
            End Get
            Set
                Me._pId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pQuantidadeCarregada() As Double
            Get
                Return Me._pQuantidadeCarregada
            End Get
            Set
                Me._pQuantidadeCarregada = value
            End Set
        End Property
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._pClienteDescricao = CodeFluentPersistence.GetReaderValue(reader, "pClienteDescricao", CType(CType(Nothing, String),String))
                Me._pProdutoCodigo = CodeFluentPersistence.GetReaderValue(reader, "pProdutoCodigo", CType(CType(Nothing, String),String))
                Me._pProdutoDescricao = CodeFluentPersistence.GetReaderValue(reader, "pProdutoDescricao", CType(CType(Nothing, String),String))
                Me._pQuantidade = CodeFluentPersistence.GetReaderValue(reader, "pQuantidade", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pM3 = CodeFluentPersistence.GetReaderValue(reader, "pM3", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pPeso = CodeFluentPersistence.GetReaderValue(reader, "pPeso", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pFormas = CodeFluentPersistence.GetReaderValue(reader, "pFormas", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pId = CodeFluentPersistence.GetReaderValue(reader, "pId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pQuantidadeCarregada = CodeFluentPersistence.GetReaderValue(reader, "pQuantidadeCarregada", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
