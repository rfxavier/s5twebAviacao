
Imports System.ComponentModel.DataAnnotations
Imports Newtonsoft.Json

Namespace WebAPIServer.Models
    ' Models used as parameters to AccountController actions.

    Public Class AddExternalLoginBindingModel
        <Required>
        <Display(Name:="External access token")>
        Public Property ExternalAccessToken() As String
            Get
                Return m_ExternalAccessToken
            End Get
            Set
                m_ExternalAccessToken = Value
            End Set
        End Property
        Private m_ExternalAccessToken As String
    End Class

    Public Class ChangePasswordBindingModel
        <Required>
        <DataType(DataType.Password)>
        <Display(Name:="Current password")>
        Public Property OldPassword() As String
            Get
                Return m_OldPassword
            End Get
            Set
                m_OldPassword = Value
            End Set
        End Property
        Private m_OldPassword As String

        <Required>
        <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
        <DataType(DataType.Password)>
        <Display(Name:="New password")>
        Public Property NewPassword() As String
            Get
                Return m_NewPassword
            End Get
            Set
                m_NewPassword = Value
            End Set
        End Property
        Private m_NewPassword As String

        <DataType(DataType.Password)>
        <Display(Name:="Confirm new password")>
        <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")>
        Public Property ConfirmPassword() As String
            Get
                Return m_ConfirmPassword
            End Get
            Set
                m_ConfirmPassword = Value
            End Set
        End Property
        Private m_ConfirmPassword As String
    End Class

    Public Class RegisterBindingModel
        <Required>
        <Display(Name:="Email")>
        Public Property Email() As String
            Get
                Return m_Email
            End Get
            Set
                m_Email = Value
            End Set
        End Property
        Private m_Email As String

        <Required>
        <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
        <DataType(DataType.Password)>
        <Display(Name:="Password")>
        Public Property Password() As String
            Get
                Return m_Password
            End Get
            Set
                m_Password = Value
            End Set
        End Property
        Private m_Password As String

        <DataType(DataType.Password)>
        <Display(Name:="Confirm password")>
        <Compare("Password", ErrorMessage:="The password and confirmation password do not match.")>
        Public Property ConfirmPassword() As String
            Get
                Return m_ConfirmPassword
            End Get
            Set
                m_ConfirmPassword = Value
            End Set
        End Property
        Private m_ConfirmPassword As String
    End Class

    Public Class RegisterExternalBindingModel
        <Required>
        <Display(Name:="Email")>
        Public Property Email() As String
            Get
                Return m_Email
            End Get
            Set
                m_Email = Value
            End Set
        End Property
        Private m_Email As String
    End Class

    Public Class RemoveLoginBindingModel
        <Required>
        <Display(Name:="Login provider")>
        Public Property LoginProvider() As String
            Get
                Return m_LoginProvider
            End Get
            Set
                m_LoginProvider = Value
            End Set
        End Property
        Private m_LoginProvider As String

        <Required>
        <Display(Name:="Provider key")>
        Public Property ProviderKey() As String
            Get
                Return m_ProviderKey
            End Get
            Set
                m_ProviderKey = Value
            End Set
        End Property
        Private m_ProviderKey As String
    End Class

    Public Class SetPasswordBindingModel
        <Required>
        <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
        <DataType(DataType.Password)>
        <Display(Name:="New password")>
        Public Property NewPassword() As String
            Get
                Return m_NewPassword
            End Get
            Set
                m_NewPassword = Value
            End Set
        End Property
        Private m_NewPassword As String

        <DataType(DataType.Password)>
        <Display(Name:="Confirm new password")>
        <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")>
        Public Property ConfirmPassword() As String
            Get
                Return m_ConfirmPassword
            End Get
            Set
                m_ConfirmPassword = Value
            End Set
        End Property
        Private m_ConfirmPassword As String
    End Class

End Namespace
