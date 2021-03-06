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
<Assembly: CodeFluent.Runtime.Utilities.CodeFluentGeneratedAttribute("1.0.61214.0931", "NoDiff", CodeFluent.Runtime.Utilities.CodeFluentGeneratedAttributeOptions.CompiledWithVisualStudio, 0UI)> 

Namespace S5T.Resources
    
    'CodeFluent Entities generated (http://www.softfluent.com). Date: .
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.01234.05678")>  _
    Partial Public NotInheritable Class Manager
        
        Private Shared _loader As Manager
        
        Private _resources As System.Resources.ResourceManager
        
        Private Sub New()
            MyBase.New
            Me._resources = New System.Resources.ResourceManager("S5T", System.Reflection.[Assembly].GetExecutingAssembly)
            Try 
                Me._resources.GetString("_cf_build")
            Catch e As System.Resources.MissingManifestResourceException
                Throw New CodeFluent.Runtime.CodeFluentRuntimeException("CF6050: Cannot find resource set in the current assembly. If this project was com"& _ 
                        "piled with CodeFluent, you should not specify the 'runtimeResourceBaseName' attr"& _ 
                        "ibute, nor the 'resourceFileFormat' attribute in CodeDomProducer configuration. "& _ 
                        "If this project was compiled with Microsoft Visual Studio 2003 or higher, please"& _ 
                        " make sure the project's Default Namespace is empty, or configure CodeDomProduce"& _ 
                        "r with the 'runtimeResourceBaseName' attribute. If this project was compiled wit"& _ 
                        "h Microsoft Visual Studio 2005 or higher, please make sure the 'resourceFileForm"& _ 
                        "at' attribute is set to 'resx' as well.", e)
            End Try
        End Sub
        
        Public Shared ReadOnly Property CFV_EmailValidator_S5T_Cadastro_pEmail_Failed() As String
            Get
                Return Manager.GetString("CFV.EmailValidator.S5T.Cadastro.pEmail.Failed", "CFV.EmailValidator.S5T.Cadastro.pEmail.Failed")
            End Get
        End Property
        
        Public Shared ReadOnly Property CFV_RegularExpressionValidator_S5T_Cadastro_pCep_Null() As String
            Get
                Return Manager.GetString("CFV.RegularExpressionValidator.S5T.Cadastro.pCep.Null", "CFV.RegularExpressionValidator.S5T.Cadastro.pCep.Null")
            End Get
        End Property
        
        Public Shared ReadOnly Property CFV_RegularExpressionValidator_S5T_Cadastro_pCep_Empty() As String
            Get
                Return Manager.GetString("CFV.RegularExpressionValidator.S5T.Cadastro.pCep.Empty", "CFV.RegularExpressionValidator.S5T.Cadastro.pCep.Empty")
            End Get
        End Property
        
        Public Shared ReadOnly Property CFV_RegularExpressionValidator_S5T_Cadastro_pCep_RegexFailed() As String
            Get
                Return Manager.GetString("CFV.RegularExpressionValidator.S5T.Cadastro.pCep.RegexFailed", "CFV.RegularExpressionValidator.S5T.Cadastro.pCep.RegexFailed")
            End Get
        End Property
        
        Private Shared Function GetLoader() As Manager
            If (Manager._loader Is Nothing) Then
                Dim type As System.Type = GetType(Manager)
                System.Threading.Monitor.Enter(type)
                Try 
                    If (Manager._loader Is Nothing) Then
                        Manager._loader = New Manager()
                    End If
                Finally
                    System.Threading.Monitor.Exit(type)
                End Try
            End If
            Return Manager._loader
        End Function
        
        Public Overloads Shared Function GetObject(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal defaultValue As String) As Object
            Dim loader As Manager = Manager.GetLoader
            Dim obj As Object = loader._resources.GetObject(name, culture)
            If (obj Is Nothing) Then
                Return defaultValue
            End If
            Return obj
        End Function
        
        Public Overloads Shared Function GetObject(ByVal name As String, ByVal defaultValue As String) As Object
            Return Manager.GetObject(Nothing, name, defaultValue)
        End Function
        
        Public Overloads Shared Function GetString(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal args() As Object) As String
            Dim loader As Manager = Manager.GetLoader
            Dim str As String = loader._resources.GetString(name, culture)
            If (str Is Nothing) Then
                Return name
            End If
            If (Not (args) Is Nothing) Then
                Return String.Format(culture, str, args)
            Else
                Return str
            End If
        End Function
        
        Public Overloads Shared Function GetString(ByVal name As String, ByVal args() As Object) As String
            Return Manager.GetString(Nothing, name, args)
        End Function
        
        Public Overloads Shared Function GetString(ByVal name As String, ByVal defaultValue As String) As String
            Return Manager.GetStringWithDefault(Nothing, name, defaultValue, Nothing)
        End Function
        
        Public Overloads Shared Function GetStringWithDefault(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal defaultValue As String, ByVal args() As Object) As String
            Dim loader As Manager = Manager.GetLoader
            Dim str As String = loader._resources.GetString(name, culture)
            If (str Is Nothing) Then
                If ((defaultValue Is Nothing)  _
                            OrElse (args Is Nothing)) Then
                    Return defaultValue
                Else
                    Return String.Format(culture, defaultValue, args)
                End If
            End If
            If (Not (args) Is Nothing) Then
                Return String.Format(culture, str, args)
            Else
                Return str
            End If
        End Function
        
        Public Overloads Shared Function GetStringWithDefault(ByVal name As String, ByVal defaultValue As String, ByVal args() As Object) As String
            Return Manager.GetStringWithDefault(Nothing, name, defaultValue, args)
        End Function
        
        Public Overloads Shared Function GetStringWithDefault(ByVal name As String, ByVal defaultValue As String) As String
            Return Manager.GetStringWithDefault(Nothing, name, defaultValue, Nothing)
        End Function
        
        Public Shared Function GetUserMessage(ByVal culture As System.Globalization.CultureInfo, ByVal type As CodeFluent.Runtime.UserExceptionType, ByVal name As String, <System.ParamArrayAttribute()> ByVal args() As Object) As String
            Dim code As String = String.Concat(CodeFluent.Runtime.CodeFluentRuntimeException.UserMessagePrefix, ".", type.ToString, ".", name)
            Dim loader As Manager = Manager.GetLoader
            Dim str As String = loader._resources.GetString(code, culture)
            If (str Is Nothing) Then
                code = String.Concat(CodeFluent.Runtime.CodeFluentRuntimeException.UserMessagePrefix, ".", type.ToString)
                str = loader._resources.GetString(code, culture)
                If (str Is Nothing) Then
                    str = CodeFluent.Runtime.CodeFluentRuntimeException.GetUserMessage(culture, type, args)
                End If
            End If
            If (Not (args) Is Nothing) Then
                Return String.Format(culture, str, args)
            Else
                Return str
            End If
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.01234.05678")>  _
    Partial Public NotInheritable Class ValueValidationFailureHandler
        Inherits CodeFluent.Runtime.Rules.BaseValueValidationFailureHandler
        
        Private Shared _current As S5T.Resources.ValueValidationFailureHandler = New S5T.Resources.ValueValidationFailureHandler()
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property Current() As S5T.Resources.ValueValidationFailureHandler
            Get
                Return S5T.Resources.ValueValidationFailureHandler._current
            End Get
        End Property
        
        Public Overloads Overrides Function GetMessage(ByVal culture As System.Globalization.CultureInfo, ByVal validator As CodeFluent.Runtime.Rules.ValueValidator, ByVal failureCode As String, ByVal arguments() As Object) As String
            Dim baseMessage As String = MyBase.GetMessage(culture, validator, failureCode, arguments)
            Dim code As String = Me.GetCode(validator, failureCode)
            Dim message As String = S5T.Resources.Manager.GetString(culture, code, arguments)
            If (message = code) Then
                Return baseMessage
            End If
            Return message
        End Function
    End Class
End Namespace

Namespace S5T
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.01234.05678")>  _
    Partial Public NotInheritable Class Constants
        
        Public Const S5TStoreName As String = "S5T"
        
        Private Sub New()
            MyBase.New
        End Sub
    End Class
End Namespace
