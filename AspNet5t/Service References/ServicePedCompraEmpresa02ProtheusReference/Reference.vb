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

Namespace ServicePedCompraEmpresa02ProtheusReference
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSPEDLIB", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSPEDLIB
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private APROVADORField As String
        
        Private PEDIDOSField As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSPEDCOM
        
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
        Public Property APROVADOR() As String
            Get
                Return Me.APROVADORField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APROVADORField, value) <> true) Then
                    Me.APROVADORField = value
                    Me.RaisePropertyChanged("APROVADOR")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PEDIDOS() As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSPEDCOM
            Get
                Return Me.PEDIDOSField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PEDIDOSField, value) <> true) Then
                    Me.PEDIDOSField = value
                    Me.RaisePropertyChanged("PEDIDOS")
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
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ARRAYOFGSPEDCOM", [Namespace]:="http://192.168.50.35:9595/", ItemName:="GSPEDCOM"),  _
     System.SerializableAttribute()>  _
    Public Class ARRAYOFGSPEDCOM
        Inherits System.Collections.Generic.List(Of ServicePedCompraEmpresa02ProtheusReference.GSPEDCOM)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSPEDCOM", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSPEDCOM
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private FILPEDField As String
        
        Private PEDIDOField As String
        
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
        Public Property FILPED() As String
            Get
                Return Me.FILPEDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FILPEDField, value) <> true) Then
                    Me.FILPEDField = value
                    Me.RaisePropertyChanged("FILPED")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PEDIDO() As String
            Get
                Return Me.PEDIDOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PEDIDOField, value) <> true) Then
                    Me.PEDIDOField = value
                    Me.RaisePropertyChanged("PEDIDO")
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
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ARRAYOFGSCONFPED", [Namespace]:="http://192.168.50.35:9595/", ItemName:="GSCONFPED"),  _
     System.SerializableAttribute()>  _
    Public Class ARRAYOFGSCONFPED
        Inherits System.Collections.Generic.List(Of ServicePedCompraEmpresa02ProtheusReference.GSCONFPED)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GSCONFPED", [Namespace]:="http://192.168.50.35:9595/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GSCONFPED
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private DESCRICAOField As String
        
        Private FILPEDField As String
        
        Private PEDIDOField As String
        
        Private STATUSField As String
        
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
        Public Property DESCRICAO() As String
            Get
                Return Me.DESCRICAOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DESCRICAOField, value) <> true) Then
                    Me.DESCRICAOField = value
                    Me.RaisePropertyChanged("DESCRICAO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property FILPED() As String
            Get
                Return Me.FILPEDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FILPEDField, value) <> true) Then
                    Me.FILPEDField = value
                    Me.RaisePropertyChanged("FILPED")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property PEDIDO() As String
            Get
                Return Me.PEDIDOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PEDIDOField, value) <> true) Then
                    Me.PEDIDOField = value
                    Me.RaisePropertyChanged("PEDIDO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, EmitDefaultValue:=false)>  _
        Public Property STATUS() As String
            Get
                Return Me.STATUSField
            End Get
            Set
                If (Object.ReferenceEquals(Me.STATUSField, value) <> true) Then
                    Me.STATUSField = value
                    Me.RaisePropertyChanged("STATUS")
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
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://192.168.50.35:9595/", ConfigurationName:="ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP")>  _
    Public Interface GSLIBPEDCOMSOAP
        
        'CODEGEN: Generating message contract since the wrapper name (BLOQUEARRESPONSE) of message BLOQUEARResponse does not match the default value (BLOQUEAR)
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/BLOQUEAR", ReplyAction:="*")>  _
        Function BLOQUEAR(ByVal request As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest) As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/BLOQUEAR", ReplyAction:="*")>  _
        Function BLOQUEARAsync(ByVal request As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse)
        
        'CODEGEN: Generating message contract since the wrapper name (LIBERARRESPONSE) of message LIBERARResponse does not match the default value (LIBERAR)
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/LIBERAR", ReplyAction:="*")>  _
        Function LIBERAR(ByVal request As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest) As ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.50.35:9595/LIBERAR", ReplyAction:="*")>  _
        Function LIBERARAsync(ByVal request As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="BLOQUEAR", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class BLOQUEARRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB)
            MyBase.New
            Me.PEDIDOSCOMPRA = PEDIDOSCOMPRA
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="BLOQUEARRESPONSE", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class BLOQUEARResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public BLOQUEARRESULT As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal BLOQUEARRESULT As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED)
            MyBase.New
            Me.BLOQUEARRESULT = BLOQUEARRESULT
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="LIBERAR", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class LIBERARRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB)
            MyBase.New
            Me.PEDIDOSCOMPRA = PEDIDOSCOMPRA
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="LIBERARRESPONSE", WrapperNamespace:="http://192.168.50.35:9595/", IsWrapped:=true)>  _
    Partial Public Class LIBERARResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://192.168.50.35:9595/", Order:=0)>  _
        Public LIBERARRESULT As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal LIBERARRESULT As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED)
            MyBase.New
            Me.LIBERARRESULT = LIBERARRESULT
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface GSLIBPEDCOMSOAPChannel
        Inherits ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class GSLIBPEDCOMSOAPClient
        Inherits System.ServiceModel.ClientBase(Of ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP)
        Implements ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP
        
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
        Function ServicePedCompraEmpresa02ProtheusReference_GSLIBPEDCOMSOAP_BLOQUEAR(ByVal request As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest) As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse Implements ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP.BLOQUEAR
            Return MyBase.Channel.BLOQUEAR(request)
        End Function
        
        Public Function BLOQUEAR(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB) As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED
            Dim inValue As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest = New ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest()
            inValue.PEDIDOSCOMPRA = PEDIDOSCOMPRA
            Dim retVal As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse = CType(Me,ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP).BLOQUEAR(inValue)
            Return retVal.BLOQUEARRESULT
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServicePedCompraEmpresa02ProtheusReference_GSLIBPEDCOMSOAP_BLOQUEARAsync(ByVal request As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse) Implements ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP.BLOQUEARAsync
            Return MyBase.Channel.BLOQUEARAsync(request)
        End Function
        
        Public Function BLOQUEARAsync(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.BLOQUEARResponse)
            Dim inValue As ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest = New ServicePedCompraEmpresa02ProtheusReference.BLOQUEARRequest()
            inValue.PEDIDOSCOMPRA = PEDIDOSCOMPRA
            Return CType(Me,ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP).BLOQUEARAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServicePedCompraEmpresa02ProtheusReference_GSLIBPEDCOMSOAP_LIBERAR(ByVal request As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest) As ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse Implements ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP.LIBERAR
            Return MyBase.Channel.LIBERAR(request)
        End Function
        
        Public Function LIBERAR(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB) As ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSCONFPED
            Dim inValue As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest = New ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest()
            inValue.PEDIDOSCOMPRA = PEDIDOSCOMPRA
            Dim retVal As ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse = CType(Me,ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP).LIBERAR(inValue)
            Return retVal.LIBERARRESULT
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServicePedCompraEmpresa02ProtheusReference_GSLIBPEDCOMSOAP_LIBERARAsync(ByVal request As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse) Implements ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP.LIBERARAsync
            Return MyBase.Channel.LIBERARAsync(request)
        End Function
        
        Public Function LIBERARAsync(ByVal PEDIDOSCOMPRA As ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB) As System.Threading.Tasks.Task(Of ServicePedCompraEmpresa02ProtheusReference.LIBERARResponse)
            Dim inValue As ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest = New ServicePedCompraEmpresa02ProtheusReference.LIBERARRequest()
            inValue.PEDIDOSCOMPRA = PEDIDOSCOMPRA
            Return CType(Me,ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAP).LIBERARAsync(inValue)
        End Function
    End Class
End Namespace
