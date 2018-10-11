Imports SwatInc.Security

Public Class UserInformationEnteredEventArgs
    Inherits AuthenticationEventArgs
    Private _authenticated As Boolean
    Private _userHash As String

    Public Sub New()
        MyBase.New
    End Sub

    Property EnteredUserName As String
        Get
            Return UserName
        End Get
        Set
            'Todo: USERNAME SHOULD BE AN INDEXED UNIQUE FIELD IN DB
            Dim users = From u In dbContext.Users
                        Where u.Username = Value
                        Select u
            If Not users.Count > 1 Then
                For Each user In users

                    AccessLevel = user.AccessLevel
                    Designation = user.Designation
                    FullName = user.Name
                    _userHash = user.PasswordHash
                Next
            Else
                MsgBox("Duplicate usernames present in the database. Please contact your database administrator!", vbCritical, "User Authentication")

            End If

            UserName = Value

        End Set
    End Property

    ReadOnly Property UserHash As String
        Get
            Return _userHash
        End Get
    End Property

    Public ReadOnly Property Authenticated As Boolean
        Get
            Return _authenticated
        End Get
    End Property

    Public WriteOnly Property PassPhrase As String
        Set
            _authenticated = Hashing.VerifyPassword(Value, UserHash)
        End Set
    End Property

    Public Shared Function GetParent(ByVal e As UserInformationEnteredEventArgs)
        Dim MyParent As New AuthenticationEventArgs With {.AccessLevel = e.AccessLevel,
                            .Designation = e.Designation,
                            .FullName = e.FullName,
                            .UserName = e.UserName}
        Return MyParent
    End Function

End Class