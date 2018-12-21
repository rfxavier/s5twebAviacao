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
     System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, pLote={pLote}, pId={pId}"),  _
     System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.NameTypeConverter))>  _
    Partial Public Class PaleteMov
        Implements System.ICloneable, System.IComparable, System.IComparable(Of S5T.PaleteMov), CodeFluent.Runtime.ICodeFluentCollectionEntity(Of Long), System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable(Of S5T.PaleteMov)
        
        Private _raisePropertyChangedEvents As Boolean = true
        
        Private _entityState As CodeFluent.Runtime.CodeFluentEntityState
        
        Private _pId As Long = -1
        
        Private _pDataMov As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _pLote As String = CType(Nothing, String)
        
        Private _pQuantidade As Double = CodeFluentPersistence.DefaultDoubleValue
        
        Private _pTipoMov As String = CType(Nothing, String)
        
        Private _oPaleteProdutopId As Long = -1
        
        <System.NonSerializedAttribute()>  _
        Private _oPaleteProduto As S5T.PaleteProduto = Nothing
        
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
                Return Me.pLote
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
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property pDataMov() As Date
            Get
                Return Me._pDataMov
            End Get
            Set
                Me._pDataMov = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pDataMov"))
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
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pLote"))
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
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pQuantidade"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property pTipoMov() As String
            Get
                Return Me._pTipoMov
            End Get
            Set
                Me._pTipoMov = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("pTipoMov"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property oPaleteProdutopId() As Long
            Get
                If ((Me._oPaleteProdutopId = -1)  _
                            AndAlso (Not (Me._oPaleteProduto) Is Nothing)) Then
                    Me._oPaleteProdutopId = Me._oPaleteProduto.pId
                End If
                Return Me._oPaleteProdutopId
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Long).Default.Equals(value, Me.oPaleteProdutopId) = true) Then
                    Return
                End If
                Me._oPaleteProduto = Nothing
                Me._oPaleteProdutopId = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("oPaleteProduto"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("oPaleteProdutopId"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property oPaleteProduto() As S5T.PaleteProduto
            Get
                If (Me._oPaleteProduto Is Nothing) Then
                    Me._oPaleteProduto = S5T.PaleteProduto.Load(Me._oPaleteProdutopId)
                End If
                Return Me._oPaleteProduto
            End Get
            Set
                Me._oPaleteProdutopId = -1
                Me._oPaleteProduto = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("oPaleteProduto"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("oPaleteProdutopId"))
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
        
        Public Overloads Overridable Function Equals(ByVal paleteMov As S5T.PaleteMov) As Boolean Implements System.IEquatable(Of S5T.PaleteMov).Equals
            If (paleteMov Is Nothing) Then
                Return false
            End If
            If (Me.pId = -1) Then
                Return MyBase.Equals(paleteMov)
            End If
            Return (Me.pId.Equals(paleteMov.pId) = true)
        End Function
        
        Public Overloads Overrides Function GetHashCode() As Integer
            Return Me.pId.GetHashCode
        End Function
        
        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim paleteMov As S5T.PaleteMov = Nothing
            Try 
                paleteMov = CType(obj,S5T.PaleteMov)
            Catch icex As System.InvalidCastException
                paleteMov = Nothing
            End Try
            Return Me.Equals(paleteMov)
        End Function
        
        Overridable Function System_IComparable_CompareTo(ByVal value As Object) As Integer Implements System.IComparable.CompareTo
            Dim paleteMov As S5T.PaleteMov = Nothing
            Try 
                paleteMov = CType(value,S5T.PaleteMov)
            Catch icex As System.InvalidCastException
                paleteMov = Nothing
            End Try
            If (paleteMov Is Nothing) Then
                Throw New System.ArgumentException("value")
            End If
            Dim localCompareTo As Integer = Me.CompareTo(paleteMov)
            Return localCompareTo
        End Function
        
        Public Overridable Function CompareTo(ByVal paleteMov As S5T.PaleteMov) As Integer Implements System.IComparable(Of S5T.PaleteMov).CompareTo
            If (paleteMov Is Nothing) Then
                Throw New System.ArgumentNullException("paleteMov")
            End If
            Dim localCompareTo As Integer = Me.pId.CompareTo(paleteMov.pId)
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
                    externalValidate = S5T.Resources.Manager.GetStringWithDefault(culture, "S5T.PaleteMov.ExternalValidate", "Type 'S5T.PaleteMov' cannot be validated.", Nothing)
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
            persistence.CreateStoredProcedureCommand(Nothing, "PaleteMov", "Delete")
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
                Me._pDataMov = CodeFluentPersistence.GetReaderValue(reader, "pDataMov", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._pLote = CodeFluentPersistence.GetReaderValue(reader, "pLote", CType(CType(Nothing, String),String))
                Me._pQuantidade = CodeFluentPersistence.GetReaderValue(reader, "pQuantidade", CType(CodeFluentPersistence.DefaultDoubleValue,Double))
                Me._pTipoMov = CodeFluentPersistence.GetReaderValue(reader, "pTipoMov", CType(CType(Nothing, String),String))
                Me.oPaleteProdutopId = CodeFluentPersistence.GetReaderValue(reader, "oPaleteProduto_pId", CType(-1,Long))
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
        Public Shared Function Load(ByVal pId As Long) As S5T.PaleteMov
            If (pId = -1) Then
                Return Nothing
            End If
            Dim paleteMov As S5T.PaleteMov = New S5T.PaleteMov()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "PaleteMov", "Load")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    paleteMov.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    paleteMov.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return paleteMov
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
        Public Shared Function LoadBypId(ByVal pId As Long) As S5T.PaleteMov
            If (pId = -1) Then
                Return Nothing
            End If
            Dim paleteMov As S5T.PaleteMov = New S5T.PaleteMov()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(S5T.Constants.S5TStoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "PaleteMov", "LoadBypId")
            persistence.AddParameter("@pId", pId, CType(-1,Long))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    paleteMov.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    paleteMov.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return paleteMov
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
            persistence.CreateStoredProcedureCommand(Nothing, "PaleteMov", "Load")
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
                S5T.PaleteMov.Delete(Me)
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
            persistence.CreateStoredProcedureCommand(Nothing, "PaleteMov", "Save")
            persistence.AddParameter("@pId", Me.pId, CType(-1,Long))
            persistence.AddParameter("@pDataMov", Me.pDataMov, CodeFluentPersistence.DefaultDateTimeValue)
            persistence.AddParameter("@pLote", Me.pLote, CType(Nothing, String))
            persistence.AddParameter("@pQuantidade", Me.pQuantidade, CodeFluentPersistence.DefaultDoubleValue)
            persistence.AddParameter("@pTipoMov", Me.pTipoMov, CType(Nothing, String))
            persistence.AddParameter("@oPaleteProduto_pId", Me.oPaleteProdutopId, CType(-1,Long))
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
        Public Overloads Shared Function Save(ByVal paleteMov As S5T.PaleteMov) As Boolean
            If (paleteMov Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = paleteMov.Save
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Shared Function Insert(ByVal paleteMov As S5T.PaleteMov) As Boolean
            Dim ret As Boolean = S5T.PaleteMov.Save(paleteMov)
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Shared Function Delete(ByVal paleteMov As S5T.PaleteMov) As Boolean
            If (paleteMov Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = paleteMov.Delete
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
            writer.Write("pDataMov=")
            writer.Write(Me.pDataMov)
            writer.Write(",")
            writer.Write("pLote=")
            writer.Write(Me.pLote)
            writer.Write(",")
            writer.Write("pQuantidade=")
            writer.Write(Me.pQuantidade)
            writer.Write(",")
            writer.Write("pTipoMov=")
            writer.Write(Me.pTipoMov)
            writer.Write(",")
            writer.Write("oPaleteProduto=")
            If (Not (Me._oPaleteProduto) Is Nothing) Then
                CType(Me._oPaleteProduto,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(",")
            writer.Write("_oPaleteProdutopId=")
            writer.Write(Me._oPaleteProdutopId)
            writer.Write(", EntityState=")
            writer.Write(Me.EntityState)
            writer.Write("]")
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function LoadByEntityKey(ByVal key As String) As S5T.PaleteMov
            If (key Is String.Empty) Then
                Return Nothing
            End If
            Dim paleteMov As S5T.PaleteMov
            Dim var As Long = CType(ConvertUtilities.ChangeType(key, GetType(Long), -1),Long)
            paleteMov = S5T.PaleteMov.Load(var)
            Return paleteMov
        End Function
        
        Protected Overridable Sub ValidateMember(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException))
        End Sub
        
        Public Overloads Function Clone(ByVal deep As Boolean) As S5T.PaleteMov
            Dim paleteMov As S5T.PaleteMov = New S5T.PaleteMov()
            Me.CopyTo(paleteMov, deep)
            Return paleteMov
        End Function
        
        Public Overloads Function Clone() As S5T.PaleteMov
            Dim localClone As S5T.PaleteMov = Me.Clone(true)
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
            If (dict.Contains("pQuantidade") = true) Then
                Me.pQuantidade = CType(ConvertUtilities.ChangeType(dict("pQuantidade"), GetType(Double), CodeFluentPersistence.DefaultDoubleValue),Double)
            End If
            If (dict.Contains("pTipoMov") = true) Then
                Me.pTipoMov = CType(ConvertUtilities.ChangeType(dict("pTipoMov"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("pDataMov") = true) Then
                Me.pDataMov = CType(ConvertUtilities.ChangeType(dict("pDataMov"), GetType(Date), CodeFluentPersistence.DefaultDateTimeValue),Date)
            End If
            If (dict.Contains("pLote") = true) Then
                Me.pLote = CType(ConvertUtilities.ChangeType(dict("pLote"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("oPaleteProdutopId") = true) Then
                Me.oPaleteProdutopId = CType(ConvertUtilities.ChangeType(dict("oPaleteProdutopId"), GetType(Long), -1),Long)
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal paleteMov As S5T.PaleteMov, ByVal deep As Boolean)
            If (paleteMov Is Nothing) Then
                Throw New System.ArgumentNullException("paleteMov")
            End If
            paleteMov.pId = Me.pId
            paleteMov.pQuantidade = Me.pQuantidade
            paleteMov.pTipoMov = Me.pTipoMov
            paleteMov.pDataMov = Me.pDataMov
            paleteMov.pLote = Me.pLote
            paleteMov.oPaleteProdutopId = Me.oPaleteProdutopId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, paleteMov))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            dict("pId") = Me.pId
            dict("pQuantidade") = Me.pQuantidade
            dict("pTipoMov") = Me.pTipoMov
            dict("pDataMov") = Me.pDataMov
            dict("pLote") = Me.pLote
            dict("oPaleteProdutopId") = Me.oPaleteProdutopId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict))
        End Sub
        
        Protected Sub OnCollectionKeyChanged(ByVal key As Long)
            If (Not (Me.KeyChangedEvent) Is Nothing) Then
                RaiseEvent KeyChanged(Me, New CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Long)(key))
            End If
        End Sub
    End Class
End Namespace
