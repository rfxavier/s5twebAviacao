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
    Partial Public Class LogAcessoUsuariosViewRaw
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pDataHora As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pLoginUsuario As String = CType(Nothing, String)
        
        Private _pObsLog As String = CType(Nothing, String)
        
        Private _pNode As String = CType(Nothing, String)
        
        Private _pDescription As String = CType(Nothing, String)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataHora() As Date
            Get
                Return Me._pDataHora
            End Get
            Set
                Me._pDataHora = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pLoginUsuario() As String
            Get
                Return Me._pLoginUsuario
            End Get
            Set
                Me._pLoginUsuario = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pObsLog() As String
            Get
                Return Me._pObsLog
            End Get
            Set
                Me._pObsLog = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNode() As String
            Get
                Return Me._pNode
            End Get
            Set
                Me._pNode = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pDescription() As String
            Get
                Return Me._pDescription
            End Get
            Set
                Me._pDescription = value
            End Set
        End Property
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._pDataHora = CodeFluentPersistence.GetReaderValue(reader, "pDataHora", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pLoginUsuario = CodeFluentPersistence.GetReaderValue(reader, "pLoginUsuario", CType(CType(Nothing, String),String))
                Me._pObsLog = CodeFluentPersistence.GetReaderValue(reader, "pObsLog", CType(CType(Nothing, String),String))
                Me._pNode = CodeFluentPersistence.GetReaderValue(reader, "pNode", CType(CType(Nothing, String),String))
                Me._pDescription = CodeFluentPersistence.GetReaderValue(reader, "pDescription", CType(CType(Nothing, String),String))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
