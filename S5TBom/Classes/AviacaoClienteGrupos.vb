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
     System.ComponentModel.DataObjectAttribute(),  _
     System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, pGRUPO_CLIENTE={pGRUPO_CLIENTE}, pId={pId}"),  _
     System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.NameTypeConverter))>  _
    Partial Public Class AviacaoClienteGrupos
        Implements System.ICloneable, System.IComparable, System.IComparable(Of S5T.AviacaoClienteGrupos), CodeFluent.Runtime.ICodeFluentCollectionEntity(Of Long), System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable(Of S5T.AviacaoClienteGrupos)
        
        Private _raisePropertyChangedEvents As Boolean = true
        
        Private _entityState As CodeFluent.Runtime.CodeFluentEntityState
        
        Private _pId As Long = -1
        
        Private _pGRUPO_CLIENTE As String = CType(Nothing, String)
        
        Public Sub New()
            MyBase.New
            Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created
        End Sub
        
        <System.ComponentModel.BrowsableAttribute(false),  _
         System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Overridable Property RaisePropertyChangedEvents() As Boolean
            Get
                Return Me._raisePropertyChangedEvents
            End Get
            Set
                Me._raisePropertyChangedEvents = value
            End Set
        End Property
        
        Public Overridable Property EntityKey() As String Implements CodeFluent.Runtime.ICodeFluentEntity.EntityKey
            Get
                Return Me.pId.ToString
            End Get
            Set
                Me.pId = CType(ConvertUtilities.ChangeType(value, GetType(Long), -1),Long)
            End Set
        End Property
        
        Public Overridable ReadOnly Property EntityDisplayName() As String Implements CodeFluent.Runtime.ICodeFluentEntity.EntityDisplayName
            Get
                Return Me.pGRUPO_CLIENTE
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(-1,Long)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Long)),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property pId() As Long
            Get
                Return Me._pId
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Long).Default.Equals(value, Me._pId) = true) Then
                    Return
                End If
                Dim oldKey As Long = Me._pId
                Me._pId = value
                Try 
                    Me.OnCollectionKeyChanged(oldKey)
                Catch __exception As System.ArgumentException
                    Me._pId = oldKey
                    Return
                End Try
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pId"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pGRUPO_CLIENTE() As String
            Get
                Return Me._pGRUPO_CLIENTE
            End Get
            Set
                Me._pGRUPO_CLIENTE = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pGRUPO_CLIENTE"))
            End Set
        End Property
        
        ReadOnly Property System_ComponentModel_IDataErrorInfo_Error() As String Implements System.ComponentModel.IDataErrorInfo.[Error]
            Get
                Return Me.Validate(System.Globalization.CultureInfo.CurrentCulture)
            End Get
        End Property
        
        ReadOnly Property System_ComponentModel_IDataErrorInfo_Item(ByVal columnName As String) As String Implements System.ComponentModel.IDataErrorInfo.Item
            Get
                Return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, Me, columnName, Nothing)
            End Get
        End Property
        
        ReadOnly Property CodeFluent_Runtime_Utilities_IKeyable_System_Int64__Key() As Long Implements CodeFluent.Runtime.Utilities.IKeyable(Of Long).Key
            Get
                Return Me.pId
            End Get
        End Property
        
        Public Overridable Property EntityState() As CodeFluent.Runtime.CodeFluentEntityState Implements CodeFluent.Runtime.ICodeFluentEntity.EntityState
            Get
                Return Me._entityState
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of CodeFluent.Runtime.CodeFluentEntityState).Default.Equals(value, Me.EntityState) = true) Then
                    Return
                End If
                If ((Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted)  _
                            AndAlso (value = CodeFluent.Runtime.CodeFluentEntityState.Modified)) Then
                    Return
                End If
                If ((Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created)  _
                            AndAlso (value = CodeFluent.Runtime.CodeFluentEntityState.Modified)) Then
                    Return
                End If
                Me._entityState = value
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("EntityState"))
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Public Event EntityAction As CodeFluent.Runtime.CodeFluentEntityActionEventHandler Implements CodeFluent.Runtime.ICodeFluentEntity.EntityAction
        
        Public Event KeyChanged As System.EventHandler(Of CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Long)) Implements CodeFluent.Runtime.Utilities.IKeyable(Of Long).KeyChanged
        
        Protected Overridable Sub OnPropertyChanged(ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If (Me.RaisePropertyChangedEvents = false) Then
                Return
            End If
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, e)
            End If
        End Sub
        
        Protected Overridable Sub OnEntityAction(ByVal e As CodeFluent.Runtime.CodeFluentEntityActionEventArgs)
            If (Not (Me.EntityActionEvent) Is Nothing) Then
                RaiseEvent EntityAction(Me, e)
            End If
        End Sub
        
        Public Overloads Overridable Function Equals(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos) As Boolean Implements System.IEquatable(Of S5T.AviacaoClienteGrupos).Equals
            If (aviacaoClienteGrupos Is Nothing) Then
                Return false
            End If
            If (Me.pId = -1) Then
                Return MyBase.Equals(aviacaoClienteGrupos)
            End If
            Return (Me.pId.Equals(aviacaoClienteGrupos.pId) = true)
        End Function
        
        Public Overloads Overrides Function GetHashCode() As Integer
            Return Me.pId.GetHashCode
        End Function
        
        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos = Nothing
            Try 
                aviacaoClienteGrupos = CType(obj,S5T.AviacaoClienteGrupos)
            Catch icex As System.InvalidCastException
                aviacaoClienteGrupos = Nothing
            End Try
            Return Me.Equals(aviacaoClienteGrupos)
        End Function
        
        Overridable Function System_IComparable_CompareTo(ByVal value As Object) As Integer Implements System.IComparable.CompareTo
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos = Nothing
            Try 
                aviacaoClienteGrupos = CType(value,S5T.AviacaoClienteGrupos)
            Catch icex As System.InvalidCastException
                aviacaoClienteGrupos = Nothing
            End Try
            If (aviacaoClienteGrupos Is Nothing) Then
                Throw New System.ArgumentException("value")
            End If
            Dim localCompareTo As Integer = Me.CompareTo(aviacaoClienteGrupos)
            Return localCompareTo
        End Function
        
        Public Overridable Function CompareTo(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos) As Integer Implements System.IComparable(Of S5T.AviacaoClienteGrupos).CompareTo
            If (aviacaoClienteGrupos Is Nothing) Then
                Throw New System.ArgumentNullException("aviacaoClienteGrupos")
            End If
            Dim localCompareTo As Integer = Me.pId.CompareTo(aviacaoClienteGrupos.pId)
            Return localCompareTo
        End Function
        
        Public Overloads Overridable Function Validate(ByVal culture As System.Globalization.CultureInfo) As String
            Return CodeFluentPersistence.Validate(culture, Me, Nothing)
        End Function
        
        Public Overloads Overridable Sub Validate(ByVal culture As System.Globalization.CultureInfo, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException)) Implements CodeFluent.Runtime.ICodeFluentSummaryValidator.Validate
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results)
            evt.Culture = culture
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Dim externalValidate As String
                If (Not (evt.Argument) Is Nothing) Then
                    externalValidate = evt.Argument.ToString
                Else
                    externalValidate = S5T.Resources.Manager.GetStringWithDefault(culture, "S5T.AviacaoClienteGrupos.ExternalValidate", "Type 'S5T.AviacaoClienteGrupos' cannot be validated.", Nothing)
                End If
                CodeFluentPersistence.AddValidationError(results, externalValidate)
            End If
            CodeFluentPersistence.ValidateMember(culture, results, Me, Nothing)
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results))
        End Sub
        
        Public Overloads Sub Validate()
            Dim var As String = Me.Validate(System.Globalization.CultureInfo.CurrentCulture)
            If (Not (var) Is Nothing) Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException(var)
            End If
        End Sub
        
        Function CodeFluent_Runtime_ICodeFluentValidator_Validate(ByVal culture As System.Globalization.CultureInfo) As String Implements CodeFluent.Runtime.ICodeFluentValidator.Validate
            Dim localValidate As String = Me.Validate(culture)
            Return localValidate
        End Function
        
        Sub CodeFluent_Runtime_ICodeFluentMemberValidator_Validate(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException)) Implements CodeFluent.Runtime.ICodeFluentMemberValidator.Validate
            Me.ValidateMember(culture, memberName, results)
        End Sub
        
        Public Overloads Overridable Function Delete() As Boolean Implements CodeFluent.Runtime.ICodeFluentEntity.Delete
            Dim ret As Boolean = false
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true)
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Return ret
            End If
            If (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted) Then
                Return ret
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "AviacaoClienteGrupos", "Delete")
            persistence.AddParameter("@pId", Me.pId, CType(-1,Long))
            persistence.ExecuteNonQuery
            Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false))
            ret = true
            Return ret
        End Function
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._pId = CodeFluentPersistence.GetReaderValue(reader, "pId", CType(-1,Long))
                Me._pGRUPO_CLIENTE = CodeFluentPersistence.GetReaderValue(reader, "pGRUPO_CLIENTE", CType(CType(Nothing, String),String))
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false))
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
        
        Protected Overridable Sub ReadRecordOnSave(ByVal reader As System.Data.IDataReader)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            Me._pId = CodeFluentPersistence.GetReaderValue(reader, "pId", CType(-1,Long))
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false))
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentEntity_ReadRecordOnSave(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave
            Me.ReadRecordOnSave(reader)
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function Load(ByVal pId As Long) As S5T.AviacaoClienteGrupos
            If (pId = -1) Then
                Return Nothing
            End If
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos = New S5T.AviacaoClienteGrupos()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "AviacaoClienteGrupos", "Load")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    aviacaoClienteGrupos.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    aviacaoClienteGrupos.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return aviacaoClienteGrupos
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return Nothing
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], false)>  _
        Public Shared Function LoadBypId(ByVal pId As Long) As S5T.AviacaoClienteGrupos
            If (pId = -1) Then
                Return Nothing
            End If
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos = New S5T.AviacaoClienteGrupos()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "AviacaoClienteGrupos", "LoadBypId")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    aviacaoClienteGrupos.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    aviacaoClienteGrupos.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return aviacaoClienteGrupos
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return Nothing
        End Function
        
        Public Overridable Function Reload(ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions) As Boolean
            Dim ret As Boolean = false
            If (Me.pId = -1) Then
                Return ret
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "AviacaoClienteGrupos", "Load")
            persistence.AddParameter("@pId", Me.pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    Me.ReadRecord(reader, options)
                    Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    ret = true
                Else
                    Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return ret
        End Function
        
        Protected Overridable Function BaseSave(ByVal force As Boolean) As Boolean
            If (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) Then
                S5T.AviacaoClienteGrupos.Delete(Me)
                Return false
            End If
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true)
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Return false
            End If
            CodeFluentPersistence.ThrowIfDeleted(Me)
            Me.Validate
            If ((force = false)  _
                        AndAlso (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged)) Then
                Return false
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "AviacaoClienteGrupos", "Save")
            persistence.AddParameter("@pId", Me.pId, CType(-1,Long))
            persistence.AddParameter("@pGRUPO_CLIENTE", Me.pGRUPO_CLIENTE, CType(Nothing, String))
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name)
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    Me.ReadRecordOnSave(reader)
                End If
                CodeFluentPersistence.NextResults(reader)
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false))
            Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
            Return true
        End Function
        
        Public Overloads Overridable Function Save() As Boolean Implements CodeFluent.Runtime.ICodeFluentEntity.Save
            Dim localSave As Boolean = Me.BaseSave(false)
            Return localSave
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Shared Function Save(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos) As Boolean
            If (aviacaoClienteGrupos Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = aviacaoClienteGrupos.Save
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Shared Function Insert(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos) As Boolean
            Dim ret As Boolean = S5T.AviacaoClienteGrupos.Save(aviacaoClienteGrupos)
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Shared Function Delete(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos) As Boolean
            If (aviacaoClienteGrupos Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = aviacaoClienteGrupos.Delete
            Return ret
        End Function
        
        Public Function Trace() As String
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim stringWriter As System.IO.StringWriter = New System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture)
            Dim writer As System.CodeDom.Compiler.IndentedTextWriter = New System.CodeDom.Compiler.IndentedTextWriter(stringWriter)
            Me.BaseTrace(writer)
            writer.Flush
            CType(writer,System.IDisposable).Dispose
            CType(stringWriter,System.IDisposable).Dispose
            Dim sr As String = stringBuilder.ToString
            Return sr
        End Function
        
        <System.ComponentModel.BrowsableAttribute(false),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>  _
        Sub CodeFluent_Runtime_ICodeFluentObject_Trace(ByVal writer As System.CodeDom.Compiler.IndentedTextWriter) Implements CodeFluent.Runtime.ICodeFluentObject.Trace
            Me.BaseTrace(writer)
        End Sub
        
        Protected Overridable Sub BaseTrace(ByVal writer As System.CodeDom.Compiler.IndentedTextWriter)
            writer.Write("[")
            writer.Write("pId=")
            writer.Write(Me.pId)
            writer.Write(",")
            writer.Write("pGRUPO_CLIENTE=")
            writer.Write(Me.pGRUPO_CLIENTE)
            writer.Write(", EntityState=")
            writer.Write(Me.EntityState)
            writer.Write("]")
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function LoadByEntityKey(ByVal key As String) As S5T.AviacaoClienteGrupos
            If (key Is String.Empty) Then
                Return Nothing
            End If
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos
            Dim var As Long = CType(ConvertUtilities.ChangeType(key, GetType(Long), -1),Long)
            aviacaoClienteGrupos = S5T.AviacaoClienteGrupos.Load(var)
            Return aviacaoClienteGrupos
        End Function
        
        Protected Overridable Sub ValidateMember(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException))
        End Sub
        
        Public Overloads Function Clone(ByVal deep As Boolean) As S5T.AviacaoClienteGrupos
            Dim aviacaoClienteGrupos As S5T.AviacaoClienteGrupos = New S5T.AviacaoClienteGrupos()
            Me.CopyTo(aviacaoClienteGrupos, deep)
            Return aviacaoClienteGrupos
        End Function
        
        Public Overloads Function Clone() As S5T.AviacaoClienteGrupos
            Dim localClone As S5T.AviacaoClienteGrupos = Me.Clone(true)
            Return localClone
        End Function
        
        Function System_ICloneable_Clone() As Object Implements System.ICloneable.Clone
            Dim localClone As Object = Me.Clone
            Return localClone
        End Function
        
        Public Overridable Sub CopyFrom(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            If (dict.Contains("pId") = true) Then
                Me.pId = CType(ConvertUtilities.ChangeType(dict("pId"), GetType(Long), -1),Long)
            End If
            If (dict.Contains("pGRUPO_CLIENTE") = true) Then
                Me.pGRUPO_CLIENTE = CType(ConvertUtilities.ChangeType(dict("pGRUPO_CLIENTE"), GetType(String), CType(Nothing, String)),String)
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal aviacaoClienteGrupos As S5T.AviacaoClienteGrupos, ByVal deep As Boolean)
            If (aviacaoClienteGrupos Is Nothing) Then
                Throw New System.ArgumentNullException("aviacaoClienteGrupos")
            End If
            aviacaoClienteGrupos.pId = Me.pId
            aviacaoClienteGrupos.pGRUPO_CLIENTE = Me.pGRUPO_CLIENTE
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, aviacaoClienteGrupos))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            dict("pId") = Me.pId
            dict("pGRUPO_CLIENTE") = Me.pGRUPO_CLIENTE
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict))
        End Sub
        
        Protected Sub OnCollectionKeyChanged(ByVal key As Long)
            If (Not (Me.KeyChangedEvent) Is Nothing) Then
                RaiseEvent KeyChanged(Me, New CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Long)(key))
            End If
        End Sub
    End Class
End Namespace
