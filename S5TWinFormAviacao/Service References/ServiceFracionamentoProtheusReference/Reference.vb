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
Imports System.Runtime.Serialization

Namespace ServiceFracionamentoProtheusReference
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSORDPES", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSORDPES
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private ITEMField As String
        
        Private ITENSField As ServiceFracionamentoProtheusReference.ARRAYOFGSITMORDPES
        
        Private NUMEROField As String
        
        Private PRODUTOField As String
        
        Private SEQUENCIAField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property ITEM() As String
            Get
                Return Me.ITEMField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ITEMField, value) <> true) Then
                    Me.ITEMField = value
                    Me.RaisePropertyChanged("ITEM")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property ITENS() As ServiceFracionamentoProtheusReference.ARRAYOFGSITMORDPES
            Get
                Return Me.ITENSField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ITENSField, value) <> true) Then
                    Me.ITENSField = value
                    Me.RaisePropertyChanged("ITENS")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property NUMERO() As String
            Get
                Return Me.NUMEROField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NUMEROField, value) <> true) Then
                    Me.NUMEROField = value
                    Me.RaisePropertyChanged("NUMERO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PRODUTO() As String
            Get
                Return Me.PRODUTOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PRODUTOField, value) <> true) Then
                    Me.PRODUTOField = value
                    Me.RaisePropertyChanged("PRODUTO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property SEQUENCIA() As String
            Get
                Return Me.SEQUENCIAField
            End Get
            Set
                If (Object.ReferenceEquals(Me.SEQUENCIAField, value) <> true) Then
                    Me.SEQUENCIAField = value
                    Me.RaisePropertyChanged("SEQUENCIA")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ARRAYOFGSITMORDPES", [Namespace]:="http://192.168.50.35:9595/", ItemName:="GSITMORDPES"),  _
     System.SerializableAttribute()>  _
    Public Class ARRAYOFGSITMORDPES
        Inherits System.Collections.Generic.List(Of ServiceFracionamentoProtheusReference.GSITMORDPES)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSITMORDPES", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSITMORDPES
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LOTEField As String
        
        Private PRODUTOField As String
        
        Private QUANTIDADEField As Single
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property LOTE() As String
            Get
                Return Me.LOTEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.LOTEField, value) <> true) Then
                    Me.LOTEField = value
                    Me.RaisePropertyChanged("LOTE")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PRODUTO() As String
            Get
                Return Me.PRODUTOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PRODUTOField, value) <> true) Then
                    Me.PRODUTOField = value
                    Me.RaisePropertyChanged("PRODUTO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property QUANTIDADE() As Single
            Get
                Return Me.QUANTIDADEField
            End Get
            Set
                If (Me.QUANTIDADEField.Equals(value) <> true) Then
                    Me.QUANTIDADEField = value
                    Me.RaisePropertyChanged("QUANTIDADE")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSRESORD", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSRESORD
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private ITEMField As String
        
        Private ITENSField As ServiceFracionamentoProtheusReference.ARRAYOFGSITMRESORD
        
        Private NUMEROField As String
        
        Private PRODUTOField As String
        
        Private SEQUENCIAField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property ITEM() As String
            Get
                Return Me.ITEMField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ITEMField, value) <> true) Then
                    Me.ITEMField = value
                    Me.RaisePropertyChanged("ITEM")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property ITENS() As ServiceFracionamentoProtheusReference.ARRAYOFGSITMRESORD
            Get
                Return Me.ITENSField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ITENSField, value) <> true) Then
                    Me.ITENSField = value
                    Me.RaisePropertyChanged("ITENS")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property NUMERO() As String
            Get
                Return Me.NUMEROField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NUMEROField, value) <> true) Then
                    Me.NUMEROField = value
                    Me.RaisePropertyChanged("NUMERO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PRODUTO() As String
            Get
                Return Me.PRODUTOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PRODUTOField, value) <> true) Then
                    Me.PRODUTOField = value
                    Me.RaisePropertyChanged("PRODUTO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property SEQUENCIA() As String
            Get
                Return Me.SEQUENCIAField
            End Get
            Set
                If (Object.ReferenceEquals(Me.SEQUENCIAField, value) <> true) Then
                    Me.SEQUENCIAField = value
                    Me.RaisePropertyChanged("SEQUENCIA")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ARRAYOFGSITMRESORD", [Namespace]:="http://192.168.50.35:9595/", ItemName:="GSITMRESORD"),  _
     System.SerializableAttribute()>  _
    Public Class ARRAYOFGSITMRESORD
        Inherits System.Collections.Generic.List(Of ServiceFracionamentoProtheusReference.GSITMRESORD)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSITMRESORD", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSITMRESORD
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ERROField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LOTEField As String
        
        Private PRODUTOField As String
        
        Private QUANTIDADEField As Single
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property ERRO() As String
            Get
                Return Me.ERROField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ERROField, value) <> true) Then
                    Me.ERROField = value
                    Me.RaisePropertyChanged("ERRO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property LOTE() As String
            Get
                Return Me.LOTEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.LOTEField, value) <> true) Then
                    Me.LOTEField = value
                    Me.RaisePropertyChanged("LOTE")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PRODUTO() As String
            Get
                Return Me.PRODUTOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PRODUTOField, value) <> true) Then
                    Me.PRODUTOField = value
                    Me.RaisePropertyChanged("PRODUTO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property QUANTIDADE() As Single
            Get
                Return Me.QUANTIDADEField
            End Get
            Set
                If (Me.QUANTIDADEField.Equals(value) <> true) Then
                    Me.QUANTIDADEField = value
                    Me.RaisePropertyChanged("QUANTIDADE")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://192.168.50.35:9595/", ConfigurationName:="ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP")>  _
    Public Interface GSORDEMPESAGEMSOAP
        
        'CODEGEN: Generating message contract since the wrapper name (AJUSTAPESOSRESPONSE) of message AJUSTAPESOSResponse does not match the default value (AJUSTAPESOS)
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/AJUSTAPESOS", ReplyAction:="*")>  _
        Function AJUSTAPESOS(ByVal request As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest) As ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/AJUSTAPESOS", ReplyAction:="*")>  _
        Function AJUSTAPESOSAsync(ByVal request As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest) As System.Threading.Tasks.Task(Of ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="AJUSTAPESOS", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class AJUSTAPESOSRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public ORDEM As ServiceFracionamentoProtheusReference.GSORDPES
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ORDEM As ServiceFracionamentoProtheusReference.GSORDPES)
            MyBase.New
            Me.ORDEM = ORDEM
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="AJUSTAPESOSRESPONSE", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class AJUSTAPESOSResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public AJUSTAPESOSRESULT As ServiceFracionamentoProtheusReference.GSRESORD
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AJUSTAPESOSRESULT As ServiceFracionamentoProtheusReference.GSRESORD)
            MyBase.New
            Me.AJUSTAPESOSRESULT = AJUSTAPESOSRESULT
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface GSORDEMPESAGEMSOAPChannel
        Inherits ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class GSORDEMPESAGEMSOAPClient
        Inherits System.ServiceModel.ClientBase(Of ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP)
        Implements ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceFracionamentoProtheusReference_GSORDEMPESAGEMSOAP_AJUSTAPESOS(ByVal request As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest) As ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse Implements ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP.AJUSTAPESOS
            Return MyBase.Channel.AJUSTAPESOS(request)
        End Function
        
        Public Function AJUSTAPESOS(ByVal ORDEM As ServiceFracionamentoProtheusReference.GSORDPES) As ServiceFracionamentoProtheusReference.GSRESORD
            Dim inValue As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest = New ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest()
            inValue.ORDEM = ORDEM
            Dim retVal As ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse = CType(Me,ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP).AJUSTAPESOS(inValue)
            Return retVal.AJUSTAPESOSRESULT
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceFracionamentoProtheusReference_GSORDEMPESAGEMSOAP_AJUSTAPESOSAsync(ByVal request As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest) As System.Threading.Tasks.Task(Of ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse) Implements ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP.AJUSTAPESOSAsync
            Return MyBase.Channel.AJUSTAPESOSAsync(request)
        End Function
        
        Public Function AJUSTAPESOSAsync(ByVal ORDEM As ServiceFracionamentoProtheusReference.GSORDPES) As System.Threading.Tasks.Task(Of ServiceFracionamentoProtheusReference.AJUSTAPESOSResponse)
            Dim inValue As ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest = New ServiceFracionamentoProtheusReference.AJUSTAPESOSRequest()
            inValue.ORDEM = ORDEM
            Return CType(Me,ServiceFracionamentoProtheusReference.GSORDEMPESAGEMSOAP).AJUSTAPESOSAsync(inValue)
        End Function
    End Class
End Namespace