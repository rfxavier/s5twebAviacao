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
     System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, idtag={idtag}, pId={pId}"),  _
     System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.NameTypeConverter))>  _
    Partial Public Class IndustriaEnvaseSipMov
        Implements System.ICloneable, System.IComparable, System.IComparable(Of S5T.IndustriaEnvaseSipMov), CodeFluent.Runtime.ICodeFluentCollectionEntity(Of Long), System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable(Of S5T.IndustriaEnvaseSipMov)
        
        Private _raisePropertyChangedEvents As Boolean = true
        
        Private _entityState As CodeFluent.Runtime.CodeFluentEntityState
        
        Private _pId As Long = -1
        
        Private _idtag As String = CType(Nothing, String)
        
        Private _periodoINI As String = CType(Nothing, String)
        
        Private _periodoFIM As String = CType(Nothing, String)
        
        Private _itemid As Integer = CodeFluentPersistence.DefaultInt32Value
        
        Private _clock As Decimal = CodeFluentPersistence.DefaultDecimalValue
        
        Private _tm As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _value As Decimal = CodeFluentPersistence.DefaultDecimalValue
        
        Private _name As String = CType(Nothing, String)
        
        Private _multiplier As Decimal = CodeFluentPersistence.DefaultDecimalValue
        
        Private _host As String = CType(Nothing, String)
        
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
                Return Me.idtag
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
        Public Property idtag() As String
            Get
                Return Me._idtag
            End Get
            Set
                Me._idtag = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("idtag"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property periodoINI() As String
            Get
                Return Me._periodoINI
            End Get
            Set
                Me._periodoINI = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("periodoINI"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property periodoFIM() As String
            Get
                Return Me._periodoFIM
            End Get
            Set
                Me._periodoFIM = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("periodoFIM"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer))>  _
        Public Property itemid() As Integer
            Get
                Return Me._itemid
            End Get
            Set
                Me._itemid = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("itemid"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Decimal))>  _
        Public Property clock() As Decimal
            Get
                Return Me._clock
            End Get
            Set
                Me._clock = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("clock"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property tm() As Date
            Get
                Return Me._tm
            End Get
            Set
                Me._tm = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("tm"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Decimal))>  _
        Public Property value() As Decimal
            Get
                Return Me._value
            End Get
            Set
                Me._value = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("value"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property name() As String
            Get
                Return Me._name
            End Get
            Set
                Me._name = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("name"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Decimal))>  _
        Public Property multiplier() As Decimal
            Get
                Return Me._multiplier
            End Get
            Set
                Me._multiplier = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("multiplier"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property host() As String
            Get
                Return Me._host
            End Get
            Set
                Me._host = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("host"))
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
        
        Public Overloads Overridable Function Equals(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov) As Boolean Implements System.IEquatable(Of S5T.IndustriaEnvaseSipMov).Equals
            If (industriaEnvaseSipMov Is Nothing) Then
                Return false
            End If
            If (Me.pId = -1) Then
                Return MyBase.Equals(industriaEnvaseSipMov)
            End If
            Return (Me.pId.Equals(industriaEnvaseSipMov.pId) = true)
        End Function
        
        Public Overloads Overrides Function GetHashCode() As Integer
            Return Me.pId.GetHashCode
        End Function
        
        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov = Nothing
            Try 
                industriaEnvaseSipMov = CType(obj,S5T.IndustriaEnvaseSipMov)
            Catch icex As System.InvalidCastException
                industriaEnvaseSipMov = Nothing
            End Try
            Return Me.Equals(industriaEnvaseSipMov)
        End Function
        
        Overridable Function System_IComparable_CompareTo(ByVal value As Object) As Integer Implements System.IComparable.CompareTo
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov = Nothing
            Try 
                industriaEnvaseSipMov = CType(value,S5T.IndustriaEnvaseSipMov)
            Catch icex As System.InvalidCastException
                industriaEnvaseSipMov = Nothing
            End Try
            If (industriaEnvaseSipMov Is Nothing) Then
                Throw New System.ArgumentException("value")
            End If
            Dim localCompareTo As Integer = Me.CompareTo(industriaEnvaseSipMov)
            Return localCompareTo
        End Function
        
        Public Overridable Function CompareTo(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov) As Integer Implements System.IComparable(Of S5T.IndustriaEnvaseSipMov).CompareTo
            If (industriaEnvaseSipMov Is Nothing) Then
                Throw New System.ArgumentNullException("industriaEnvaseSipMov")
            End If
            Dim localCompareTo As Integer = Me.pId.CompareTo(industriaEnvaseSipMov.pId)
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
                    externalValidate = S5T.Resources.Manager.GetStringWithDefault(culture, "S5T.IndustriaEnvaseSipMov.ExternalValidate", "Type 'S5T.IndustriaEnvaseSipMov' cannot be validated.", Nothing)
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
            persistence.CreateStoredProcedureCommand(Nothing, "IndustriaEnvaseSipMov", "Delete")
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
                Me._idtag = CodeFluentPersistence.GetReaderValue(reader, "idtag", CType(CType(Nothing, String),String))
                Me._periodoINI = CodeFluentPersistence.GetReaderValue(reader, "periodoINI", CType(CType(Nothing, String),String))
                Me._periodoFIM = CodeFluentPersistence.GetReaderValue(reader, "periodoFIM", CType(CType(Nothing, String),String))
                Me._itemid = CodeFluentPersistence.GetReaderValue(reader, "itemid", CType(CodeFluentPersistence.DefaultInt32Value,Integer))
                Me._clock = CodeFluentPersistence.GetReaderValue(reader, "clock", CType(CodeFluentPersistence.DefaultDecimalValue,Decimal))
                Me._tm = CodeFluentPersistence.GetReaderValue(reader, "tm", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._value = CodeFluentPersistence.GetReaderValue(reader, "value", CType(CodeFluentPersistence.DefaultDecimalValue,Decimal))
                Me._name = CodeFluentPersistence.GetReaderValue(reader, "name", CType(CType(Nothing, String),String))
                Me._multiplier = CodeFluentPersistence.GetReaderValue(reader, "multiplier", CType(CodeFluentPersistence.DefaultDecimalValue,Decimal))
                Me._host = CodeFluentPersistence.GetReaderValue(reader, "host", CType(CType(Nothing, String),String))
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
        Public Shared Function Load(ByVal pId As Long) As S5T.IndustriaEnvaseSipMov
            If (pId = -1) Then
                Return Nothing
            End If
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov = New S5T.IndustriaEnvaseSipMov()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "IndustriaEnvaseSipMov", "Load")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    industriaEnvaseSipMov.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    industriaEnvaseSipMov.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return industriaEnvaseSipMov
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
        Public Shared Function LoadBypId(ByVal pId As Long) As S5T.IndustriaEnvaseSipMov
            If (pId = -1) Then
                Return Nothing
            End If
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov = New S5T.IndustriaEnvaseSipMov()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "IndustriaEnvaseSipMov", "LoadBypId")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    industriaEnvaseSipMov.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    industriaEnvaseSipMov.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return industriaEnvaseSipMov
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
            persistence.CreateStoredProcedureCommand(Nothing, "IndustriaEnvaseSipMov", "Load")
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
                S5T.IndustriaEnvaseSipMov.Delete(Me)
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
            persistence.CreateStoredProcedureCommand(Nothing, "IndustriaEnvaseSipMov", "Save")
            persistence.AddParameter("@pId", Me.pId, CType(-1,Long))
            persistence.AddParameter("@idtag", Me.idtag, CType(Nothing, String))
            persistence.AddParameter("@periodoINI", Me.periodoINI, CType(Nothing, String))
            persistence.AddParameter("@periodoFIM", Me.periodoFIM, CType(Nothing, String))
            persistence.AddParameter("@itemid", Me.itemid, CodeFluentPersistence.DefaultInt32Value)
            persistence.AddParameter("@clock", Me.clock, CodeFluentPersistence.DefaultDecimalValue)
            persistence.AddParameter("@tm", Me.tm, CodeFluentPersistence.DefaultDateTimeValue)
            persistence.AddParameter("@value", Me.value, CodeFluentPersistence.DefaultDecimalValue)
            persistence.AddParameter("@name", Me.name, CType(Nothing, String))
            persistence.AddParameter("@multiplier", Me.multiplier, CodeFluentPersistence.DefaultDecimalValue)
            persistence.AddParameter("@host", Me.host, CType(Nothing, String))
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
        Public Overloads Shared Function Save(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov) As Boolean
            If (industriaEnvaseSipMov Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = industriaEnvaseSipMov.Save
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Shared Function Insert(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov) As Boolean
            Dim ret As Boolean = S5T.IndustriaEnvaseSipMov.Save(industriaEnvaseSipMov)
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Shared Function Delete(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov) As Boolean
            If (industriaEnvaseSipMov Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = industriaEnvaseSipMov.Delete
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
            writer.Write("idtag=")
            writer.Write(Me.idtag)
            writer.Write(",")
            writer.Write("periodoINI=")
            writer.Write(Me.periodoINI)
            writer.Write(",")
            writer.Write("periodoFIM=")
            writer.Write(Me.periodoFIM)
            writer.Write(",")
            writer.Write("itemid=")
            writer.Write(Me.itemid)
            writer.Write(",")
            writer.Write("clock=")
            writer.Write(Me.clock)
            writer.Write(",")
            writer.Write("tm=")
            writer.Write(Me.tm)
            writer.Write(",")
            writer.Write("value=")
            writer.Write(Me.value)
            writer.Write(",")
            writer.Write("name=")
            writer.Write(Me.name)
            writer.Write(",")
            writer.Write("multiplier=")
            writer.Write(Me.multiplier)
            writer.Write(",")
            writer.Write("host=")
            writer.Write(Me.host)
            writer.Write(", EntityState=")
            writer.Write(Me.EntityState)
            writer.Write("]")
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function LoadByEntityKey(ByVal key As String) As S5T.IndustriaEnvaseSipMov
            If (key Is String.Empty) Then
                Return Nothing
            End If
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov
            Dim var As Long = CType(ConvertUtilities.ChangeType(key, GetType(Long), -1),Long)
            industriaEnvaseSipMov = S5T.IndustriaEnvaseSipMov.Load(var)
            Return industriaEnvaseSipMov
        End Function
        
        Protected Overridable Sub ValidateMember(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException))
        End Sub
        
        Public Overloads Function Clone(ByVal deep As Boolean) As S5T.IndustriaEnvaseSipMov
            Dim industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov = New S5T.IndustriaEnvaseSipMov()
            Me.CopyTo(industriaEnvaseSipMov, deep)
            Return industriaEnvaseSipMov
        End Function
        
        Public Overloads Function Clone() As S5T.IndustriaEnvaseSipMov
            Dim localClone As S5T.IndustriaEnvaseSipMov = Me.Clone(true)
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
            If (dict.Contains("value") = true) Then
                Me.value = CType(ConvertUtilities.ChangeType(dict("value"), GetType(Decimal), CodeFluentPersistence.DefaultDecimalValue),Decimal)
            End If
            If (dict.Contains("tm") = true) Then
                Me.tm = CType(ConvertUtilities.ChangeType(dict("tm"), GetType(Date), CodeFluentPersistence.DefaultDateTimeValue),Date)
            End If
            If (dict.Contains("name") = true) Then
                Me.name = CType(ConvertUtilities.ChangeType(dict("name"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("host") = true) Then
                Me.host = CType(ConvertUtilities.ChangeType(dict("host"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("multiplier") = true) Then
                Me.multiplier = CType(ConvertUtilities.ChangeType(dict("multiplier"), GetType(Decimal), CodeFluentPersistence.DefaultDecimalValue),Decimal)
            End If
            If (dict.Contains("periodoINI") = true) Then
                Me.periodoINI = CType(ConvertUtilities.ChangeType(dict("periodoINI"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("idtag") = true) Then
                Me.idtag = CType(ConvertUtilities.ChangeType(dict("idtag"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("periodoFIM") = true) Then
                Me.periodoFIM = CType(ConvertUtilities.ChangeType(dict("periodoFIM"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("clock") = true) Then
                Me.clock = CType(ConvertUtilities.ChangeType(dict("clock"), GetType(Decimal), CodeFluentPersistence.DefaultDecimalValue),Decimal)
            End If
            If (dict.Contains("itemid") = true) Then
                Me.itemid = CType(ConvertUtilities.ChangeType(dict("itemid"), GetType(Integer), CodeFluentPersistence.DefaultInt32Value),Integer)
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal industriaEnvaseSipMov As S5T.IndustriaEnvaseSipMov, ByVal deep As Boolean)
            If (industriaEnvaseSipMov Is Nothing) Then
                Throw New System.ArgumentNullException("industriaEnvaseSipMov")
            End If
            industriaEnvaseSipMov.pId = Me.pId
            industriaEnvaseSipMov.value = Me.value
            industriaEnvaseSipMov.tm = Me.tm
            industriaEnvaseSipMov.name = Me.name
            industriaEnvaseSipMov.host = Me.host
            industriaEnvaseSipMov.multiplier = Me.multiplier
            industriaEnvaseSipMov.periodoINI = Me.periodoINI
            industriaEnvaseSipMov.idtag = Me.idtag
            industriaEnvaseSipMov.periodoFIM = Me.periodoFIM
            industriaEnvaseSipMov.clock = Me.clock
            industriaEnvaseSipMov.itemid = Me.itemid
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, industriaEnvaseSipMov))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            dict("pId") = Me.pId
            dict("value") = Me.value
            dict("tm") = Me.tm
            dict("name") = Me.name
            dict("host") = Me.host
            dict("multiplier") = Me.multiplier
            dict("periodoINI") = Me.periodoINI
            dict("idtag") = Me.idtag
            dict("periodoFIM") = Me.periodoFIM
            dict("clock") = Me.clock
            dict("itemid") = Me.itemid
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict))
        End Sub
        
        Protected Sub OnCollectionKeyChanged(ByVal key As Long)
            If (Not (Me.KeyChangedEvent) Is Nothing) Then
                RaiseEvent KeyChanged(Me, New CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Long)(key))
            End If
        End Sub
    End Class
End Namespace