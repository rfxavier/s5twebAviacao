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
    Partial Public Class MenuVw
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pId As Long = -1
        
        Private _pDescricao As String = CType(Nothing, String)
        
        Private _pNomeToolStrip As String = CType(Nothing, String)
        
        Private _pNivelPosicao As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pSistemaCodigo As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pSistemaNome As String = CType(Nothing, String)
        
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
        Public Property pDescricao() As String
            Get
                Return Me._pDescricao
            End Get
            Set
                Me._pDescricao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNomeToolStrip() As String
            Get
                Return Me._pNomeToolStrip
            End Get
            Set
                Me._pNomeToolStrip = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pNivelPosicao() As Integer
            Get
                Return Me._pNivelPosicao
            End Get
            Set
                Me._pNivelPosicao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pSistemaCodigo() As Integer
            Get
                Return Me._pSistemaCodigo
            End Get
            Set
                Me._pSistemaCodigo = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pSistemaNome() As String
            Get
                Return Me._pSistemaNome
            End Get
            Set
                Me._pSistemaNome = value
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
                Me._pDescricao = CodeFluentPersistence.GetReaderValue(reader, "pDescricao", CType(CType(Nothing, String),String))
                Me._pNomeToolStrip = CodeFluentPersistence.GetReaderValue(reader, "pNomeToolStrip", CType(CType(Nothing, String),String))
                Me._pNivelPosicao = CodeFluentPersistence.GetReaderValue(reader, "pNivelPosicao", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pSistemaCodigo = CodeFluentPersistence.GetReaderValue(reader, "pSistemaCodigo", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pSistemaNome = CodeFluentPersistence.GetReaderValue(reader, "pSistemaNome", CType(CType(Nothing, String),String))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
