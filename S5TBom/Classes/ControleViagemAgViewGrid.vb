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
    Partial Public Class ControleViagemAgViewGrid
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pId As Long = -1
        
        Private _pDataSaida As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pNumeroViagem As String = CType(Nothing, String)
        
        Private _pMonitorado As String = CType(Nothing, String)
        
        Private _pAverbado As String = CType(Nothing, String)
        
        Private _pValorCTeCafe As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pValorCTeLaticinios As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pValorCTeOutros As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pCaminhaoId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pCaminhaoPlaca As String = CType(Nothing, String)
        
        Private _pMotoristaId As String = CType(Nothing, String)
        
        Private _pMotoristaNome As String = CType(Nothing, String)
        
        Private _pLocalLinhaOrigemId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pLocalLinhaOrigemDescricao As String = CType(Nothing, String)
        
        Private _pLocalLinhaDestinoId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pLocalLinhaDestinoDescricao As String = CType(Nothing, String)
        
        Private _pLote As String = CType(Nothing, String)
        
        Private _pNFde As String = CType(Nothing, String)
        
        Private _pNFate As String = CType(Nothing, String)
        
        Private _pNFCancelada As String = CType(Nothing, String)
        
        Private _pCTEde As String = CType(Nothing, String)
        
        Private _pCTEate As String = CType(Nothing, String)
        
        Private _pCTECancelado As String = CType(Nothing, String)
        
        Private _pLoteId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pNFId As Long = CodeFluentPersistence.DefaultInt64Value
        
        Private _pCTEId As Long = CodeFluentPersistence.DefaultInt64Value
        
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
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataSaida() As Date
            Get
                Return Me._pDataSaida
            End Get
            Set
                Me._pDataSaida = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNumeroViagem() As String
            Get
                Return Me._pNumeroViagem
            End Get
            Set
                Me._pNumeroViagem = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pMonitorado() As String
            Get
                Return Me._pMonitorado
            End Get
            Set
                Me._pMonitorado = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pAverbado() As String
            Get
                Return Me._pAverbado
            End Get
            Set
                Me._pAverbado = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pValorCTeCafe() As Double
            Get
                Return Me._pValorCTeCafe
            End Get
            Set
                Me._pValorCTeCafe = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pValorCTeLaticinios() As Double
            Get
                Return Me._pValorCTeLaticinios
            End Get
            Set
                Me._pValorCTeLaticinios = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultDoubleValue),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Double))>  _
        Public Property pValorCTeOutros() As Double
            Get
                Return Me._pValorCTeOutros
            End Get
            Set
                Me._pValorCTeOutros = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pCaminhaoId() As Long
            Get
                Return Me._pCaminhaoId
            End Get
            Set
                Me._pCaminhaoId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCaminhaoPlaca() As String
            Get
                Return Me._pCaminhaoPlaca
            End Get
            Set
                Me._pCaminhaoPlaca = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pMotoristaId() As String
            Get
                Return Me._pMotoristaId
            End Get
            Set
                Me._pMotoristaId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pMotoristaNome() As String
            Get
                Return Me._pMotoristaNome
            End Get
            Set
                Me._pMotoristaNome = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pLocalLinhaOrigemId() As Long
            Get
                Return Me._pLocalLinhaOrigemId
            End Get
            Set
                Me._pLocalLinhaOrigemId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pLocalLinhaOrigemDescricao() As String
            Get
                Return Me._pLocalLinhaOrigemDescricao
            End Get
            Set
                Me._pLocalLinhaOrigemDescricao = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pLocalLinhaDestinoId() As Long
            Get
                Return Me._pLocalLinhaDestinoId
            End Get
            Set
                Me._pLocalLinhaDestinoId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pLocalLinhaDestinoDescricao() As String
            Get
                Return Me._pLocalLinhaDestinoDescricao
            End Get
            Set
                Me._pLocalLinhaDestinoDescricao = value
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
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNFde() As String
            Get
                Return Me._pNFde
            End Get
            Set
                Me._pNFde = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNFate() As String
            Get
                Return Me._pNFate
            End Get
            Set
                Me._pNFate = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNFCancelada() As String
            Get
                Return Me._pNFCancelada
            End Get
            Set
                Me._pNFCancelada = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCTEde() As String
            Get
                Return Me._pCTEde
            End Get
            Set
                Me._pCTEde = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCTEate() As String
            Get
                Return Me._pCTEate
            End Get
            Set
                Me._pCTEate = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCTECancelado() As String
            Get
                Return Me._pCTECancelado
            End Get
            Set
                Me._pCTECancelado = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pLoteId() As Long
            Get
                Return Me._pLoteId
            End Get
            Set
                Me._pLoteId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pNFId() As Long
            Get
                Return Me._pNFId
            End Get
            Set
                Me._pNFId = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt64Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long))>  _
        Public Property pCTEId() As Long
            Get
                Return Me._pCTEId
            End Get
            Set
                Me._pCTEId = value
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
                Me._pDataSaida = CodeFluentPersistence.GetReaderValue(reader, "pDataSaida", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pNumeroViagem = CodeFluentPersistence.GetReaderValue(reader, "pNumeroViagem", CType(CType(Nothing, String),String))
                Me._pMonitorado = CodeFluentPersistence.GetReaderValue(reader, "pMonitorado", CType(CType(Nothing, String),String))
                Me._pAverbado = CodeFluentPersistence.GetReaderValue(reader, "pAverbado", CType(CType(Nothing, String),String))
                Me._pValorCTeCafe = CodeFluentPersistence.GetReaderValue(reader, "pValorCTeCafe", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pValorCTeLaticinios = CodeFluentPersistence.GetReaderValue(reader, "pValorCTeLaticinios", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pValorCTeOutros = CodeFluentPersistence.GetReaderValue(reader, "pValorCTeOutros", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pCaminhaoId = CodeFluentPersistence.GetReaderValue(reader, "pCaminhaoId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pCaminhaoPlaca = CodeFluentPersistence.GetReaderValue(reader, "pCaminhaoPlaca", CType(CType(Nothing, String),String))
                Me._pMotoristaId = CodeFluentPersistence.GetReaderValue(reader, "pMotoristaId", CType(CType(Nothing, String),String))
                Me._pMotoristaNome = CodeFluentPersistence.GetReaderValue(reader, "pMotoristaNome", CType(CType(Nothing, String),String))
                Me._pLocalLinhaOrigemId = CodeFluentPersistence.GetReaderValue(reader, "pLocalLinhaOrigemId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pLocalLinhaOrigemDescricao = CodeFluentPersistence.GetReaderValue(reader, "pLocalLinhaOrigemDescricao", CType(CType(Nothing, String),String))
                Me._pLocalLinhaDestinoId = CodeFluentPersistence.GetReaderValue(reader, "pLocalLinhaDestinoId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pLocalLinhaDestinoDescricao = CodeFluentPersistence.GetReaderValue(reader, "pLocalLinhaDestinoDescricao", CType(CType(Nothing, String),String))
                Me._pLote = CodeFluentPersistence.GetReaderValue(reader, "pLote", CType(CType(Nothing, String),String))
                Me._pNFde = CodeFluentPersistence.GetReaderValue(reader, "pNFde", CType(CType(Nothing, String),String))
                Me._pNFate = CodeFluentPersistence.GetReaderValue(reader, "pNFate", CType(CType(Nothing, String),String))
                Me._pNFCancelada = CodeFluentPersistence.GetReaderValue(reader, "pNFCancelada", CType(CType(Nothing, String),String))
                Me._pCTEde = CodeFluentPersistence.GetReaderValue(reader, "pCTEde", CType(CType(Nothing, String),String))
                Me._pCTEate = CodeFluentPersistence.GetReaderValue(reader, "pCTEate", CType(CType(Nothing, String),String))
                Me._pCTECancelado = CodeFluentPersistence.GetReaderValue(reader, "pCTECancelado", CType(CType(Nothing, String),String))
                Me._pLoteId = CodeFluentPersistence.GetReaderValue(reader, "pLoteId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pNFId = CodeFluentPersistence.GetReaderValue(reader, "pNFId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
                Me._pCTEId = CodeFluentPersistence.GetReaderValue(reader, "pCTEId", CType(CodeFluentPersistence.DefaultInt64Value,Long))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace
