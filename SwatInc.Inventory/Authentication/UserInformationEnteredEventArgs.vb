Imports SwatInc.Security

Public Class UserInformationEnteredEventArgs
    Inherits AuthenticationEventArgs
    Private _generatedHash As String
    Private _userHash As String

    Public Sub New()
        MyBase.New
    End Sub

    Property EnteredUserName As String
        Get
            Return UserName
        End Get
        Set
            Dim users = From u In dbContext.Users
                        Where u.Username = UserName
                        Select u

            If Not users.Count > 1 Then
                For Each user In users
                    Me.AccessLevel = user.AccessLevel
                    Me.Designation = user.Designation
                    Me.FullName = user.Name
                    Me._userHash = user.PasswordHash
                Next
                UserName = Value
            Else
                MsgBox("Duplicate usernames present in the database. Please contact your database administrator!", vbCritical, "User Authentication")
            End If

        End Set
    End Property

    ReadOnly Property UserHash As String
        Get
            Return _userHash
        End Get
    End Property

    Public ReadOnly Property GeneratedHash As String
        Get
            Return _generatedHash
        End Get
    End Property

    Public WriteOnly Property PassPhrase As String
        Set
            _generatedHash = Hashing.CreateHashSHA512(Value)
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