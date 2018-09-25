Namespace Nova

    Public Enum UserAccessLevel

        'Basic
        Assistant

        'All access except authorizations
        Technologist

        'Super user
        InCharge

    End Enum

    Public Class Users
        Public Property AccessLevel As UserAccessLevel
        Public Property Id As Integer
        Public Property Name As String
        Public Property PasswordHash As String
        Public Property Username As String
    End Class

End Namespace