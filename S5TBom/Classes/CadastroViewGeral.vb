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
    Partial Public Class CadastroViewGeral
        Implements CodeFluent.Runtime.ICodeFluentLightEntity
        
        Private _pId As Long = -1
        
        Private _pNome As String = CType(Nothing, String)
        
        Private _pCodigo As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pPFPJ As String = CType(Nothing, String)
        
        Private _pEndereco As String = CType(Nothing, String)
        
        Private _pEnderLogradouro As String = CType(Nothing, String)
        
        Private _pEnderComplemento As String = CType(Nothing, String)
        
        Private _pEnderBairro As String = CType(Nothing, String)
        
        Private _pEnderNumero As String = CType(Nothing, String)
        
        Private _pEnderAuxLogradouro As String = CType(Nothing, String)
        
        Private _pEnderAuxNumero As String = CType(Nothing, String)
        
        Private _pEnderAuxBairro As String = CType(Nothing, String)
        
        Private _pEnderAuxComplemento As String = CType(Nothing, String)
        
        Private _pEnderecoAux As String = CType(Nothing, String)
        
        Private _pEmail As String = CType(Nothing, String)
        
        Private _pCpfCnpj As String = CType(Nothing, String)
        
        Private _pDataNascimento As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pRgIe As String = CType(Nothing, String)
        
        Private _pNomeFantasia As String = CType(Nothing, String)
        
        Private _pFlgSexo As String = CType(Nothing, String)
        
        Private _pDataCadastro As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pDataBaixa As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pTelefone As String = CType(Nothing, String)
        
        Private _pTelefoneAux As String = CType(Nothing, String)
        
        Private _pCelular As String = CType(Nothing, String)
        
        Private _pCodigoCidade As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pNomeCidade As String = CType(Nothing, String)
        
        Private _pUFCidade As String = CType(Nothing, String)
        
        Private _pCodigoCidadeAux As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pNomeCidadeaux As String = CType(Nothing, String)
        
        Private _pUFCidadeAux As String = CType(Nothing, String)
        
        Private _pCodigoEmpresa As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _pNomeEmpresa As String = CType(Nothing, String)
        
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
        Public Property pNome() As String
            Get
                Return Me._pNome
            End Get
            Set
                Me._pNome = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pCodigo() As Integer
            Get
                Return Me._pCodigo
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Integer).Default.Equals(value, Me._pCodigo) = true) Then
                    Return
                End If
                Me._pCodigo = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pPFPJ() As String
            Get
                Return Me._pPFPJ
            End Get
            Set
                Me._pPFPJ = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEndereco() As String
            Get
                Return Me._pEndereco
            End Get
            Set
                Me._pEndereco = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderLogradouro() As String
            Get
                Return Me._pEnderLogradouro
            End Get
            Set
                Me._pEnderLogradouro = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderComplemento() As String
            Get
                Return Me._pEnderComplemento
            End Get
            Set
                Me._pEnderComplemento = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderBairro() As String
            Get
                Return Me._pEnderBairro
            End Get
            Set
                Me._pEnderBairro = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderNumero() As String
            Get
                Return Me._pEnderNumero
            End Get
            Set
                Me._pEnderNumero = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderAuxLogradouro() As String
            Get
                Return Me._pEnderAuxLogradouro
            End Get
            Set
                Me._pEnderAuxLogradouro = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderAuxNumero() As String
            Get
                Return Me._pEnderAuxNumero
            End Get
            Set
                Me._pEnderAuxNumero = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderAuxBairro() As String
            Get
                Return Me._pEnderAuxBairro
            End Get
            Set
                Me._pEnderAuxBairro = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderAuxComplemento() As String
            Get
                Return Me._pEnderAuxComplemento
            End Get
            Set
                Me._pEnderAuxComplemento = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEnderecoAux() As String
            Get
                Return Me._pEnderecoAux
            End Get
            Set
                Me._pEnderecoAux = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pEmail() As String
            Get
                Return Me._pEmail
            End Get
            Set
                Me._pEmail = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCpfCnpj() As String
            Get
                Return Me._pCpfCnpj
            End Get
            Set
                Me._pCpfCnpj = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataNascimento() As Date
            Get
                Return Me._pDataNascimento
            End Get
            Set
                Me._pDataNascimento = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pRgIe() As String
            Get
                Return Me._pRgIe
            End Get
            Set
                Me._pRgIe = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNomeFantasia() As String
            Get
                Return Me._pNomeFantasia
            End Get
            Set
                Me._pNomeFantasia = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pFlgSexo() As String
            Get
                Return Me._pFlgSexo
            End Get
            Set
                Me._pFlgSexo = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataCadastro() As Date
            Get
                Return Me._pDataCadastro
            End Get
            Set
                Me._pDataCadastro = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataBaixa() As Date
            Get
                Return Me._pDataBaixa
            End Get
            Set
                Me._pDataBaixa = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pTelefone() As String
            Get
                Return Me._pTelefone
            End Get
            Set
                Me._pTelefone = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pTelefoneAux() As String
            Get
                Return Me._pTelefoneAux
            End Get
            Set
                Me._pTelefoneAux = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pCelular() As String
            Get
                Return Me._pCelular
            End Get
            Set
                Me._pCelular = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pCodigoCidade() As Integer
            Get
                Return Me._pCodigoCidade
            End Get
            Set
                Me._pCodigoCidade = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNomeCidade() As String
            Get
                Return Me._pNomeCidade
            End Get
            Set
                Me._pNomeCidade = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pUFCidade() As String
            Get
                Return Me._pUFCidade
            End Get
            Set
                Me._pUFCidade = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pCodigoCidadeAux() As Integer
            Get
                Return Me._pCodigoCidadeAux
            End Get
            Set
                Me._pCodigoCidadeAux = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNomeCidadeaux() As String
            Get
                Return Me._pNomeCidadeaux
            End Get
            Set
                Me._pNomeCidadeaux = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pUFCidadeAux() As String
            Get
                Return Me._pUFCidadeAux
            End Get
            Set
                Me._pUFCidadeAux = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property pCodigoEmpresa() As Integer
            Get
                Return Me._pCodigoEmpresa
            End Get
            Set
                Me._pCodigoEmpresa = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pNomeEmpresa() As String
            Get
                Return Me._pNomeEmpresa
            End Get
            Set
                Me._pNomeEmpresa = value
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
                Me._pNome = CodeFluentPersistence.GetReaderValue(reader, "pNome", CType(CType(Nothing, String),String))
                Me._pCodigo = CodeFluentPersistence.GetReaderValue(reader, "pCodigo", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pPFPJ = CodeFluentPersistence.GetReaderValue(reader, "pPFPJ", CType(CType(Nothing, String),String))
                Me._pEndereco = CodeFluentPersistence.GetReaderValue(reader, "pEndereco", CType(CType(Nothing, String),String))
                Me._pEnderLogradouro = CodeFluentPersistence.GetReaderValue(reader, "pEnderLogradouro", CType(CType(Nothing, String),String))
                Me._pEnderComplemento = CodeFluentPersistence.GetReaderValue(reader, "pEnderComplemento", CType(CType(Nothing, String),String))
                Me._pEnderBairro = CodeFluentPersistence.GetReaderValue(reader, "pEnderBairro", CType(CType(Nothing, String),String))
                Me._pEnderNumero = CodeFluentPersistence.GetReaderValue(reader, "pEnderNumero", CType(CType(Nothing, String),String))
                Me._pEnderAuxLogradouro = CodeFluentPersistence.GetReaderValue(reader, "pEnderAuxLogradouro", CType(CType(Nothing, String),String))
                Me._pEnderAuxNumero = CodeFluentPersistence.GetReaderValue(reader, "pEnderAuxNumero", CType(CType(Nothing, String),String))
                Me._pEnderAuxBairro = CodeFluentPersistence.GetReaderValue(reader, "pEnderAuxBairro", CType(CType(Nothing, String),String))
                Me._pEnderAuxComplemento = CodeFluentPersistence.GetReaderValue(reader, "pEnderAuxComplemento", CType(CType(Nothing, String),String))
                Me._pEnderecoAux = CodeFluentPersistence.GetReaderValue(reader, "pEnderecoAux", CType(CType(Nothing, String),String))
                Me._pEmail = CodeFluentPersistence.GetReaderValue(reader, "pEmail", CType(CType(Nothing, String),String))
                Me._pCpfCnpj = CodeFluentPersistence.GetReaderValue(reader, "pCpfCnpj", CType(CType(Nothing, String),String))
                Me._pDataNascimento = CodeFluentPersistence.GetReaderValue(reader, "pDataNascimento", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pRgIe = CodeFluentPersistence.GetReaderValue(reader, "pRgIe", CType(CType(Nothing, String),String))
                Me._pNomeFantasia = CodeFluentPersistence.GetReaderValue(reader, "pNomeFantasia", CType(CType(Nothing, String),String))
                Me._pFlgSexo = CodeFluentPersistence.GetReaderValue(reader, "pFlgSexo", CType(CType(Nothing, String),String))
                Me._pDataCadastro = CodeFluentPersistence.GetReaderValue(reader, "pDataCadastro", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pDataBaixa = CodeFluentPersistence.GetReaderValue(reader, "pDataBaixa", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pTelefone = CodeFluentPersistence.GetReaderValue(reader, "pTelefone", CType(CType(Nothing, String),String))
                Me._pTelefoneAux = CodeFluentPersistence.GetReaderValue(reader, "pTelefoneAux", CType(CType(Nothing, String),String))
                Me._pCelular = CodeFluentPersistence.GetReaderValue(reader, "pCelular", CType(CType(Nothing, String),String))
                Me._pCodigoCidade = CodeFluentPersistence.GetReaderValue(reader, "pCodigoCidade", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pNomeCidade = CodeFluentPersistence.GetReaderValue(reader, "pNomeCidade", CType(CType(Nothing, String),String))
                Me._pUFCidade = CodeFluentPersistence.GetReaderValue(reader, "pUFCidade", CType(CType(Nothing, String),String))
                Me._pCodigoCidadeAux = CodeFluentPersistence.GetReaderValue(reader, "pCodigoCidadeAux", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pNomeCidadeaux = CodeFluentPersistence.GetReaderValue(reader, "pNomeCidadeaux", CType(CType(Nothing, String),String))
                Me._pUFCidadeAux = CodeFluentPersistence.GetReaderValue(reader, "pUFCidadeAux", CType(CType(Nothing, String),String))
                Me._pCodigoEmpresa = CodeFluentPersistence.GetReaderValue(reader, "pCodigoEmpresa", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._pNomeEmpresa = CodeFluentPersistence.GetReaderValue(reader, "pNomeEmpresa", CType(CType(Nothing, String),String))
            End If
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentLightEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
    End Class
End Namespace