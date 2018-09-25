Namespace Nova

    Public Class Laboratory_Items
        Public Property Id As Integer
        Public Property Item As Items
        Public Property Laboratory As Laboratory
    End Class

    Public Class Users
        Public Property AccessLevel As UserAccessLevel
        Public Property Id As Integer
        Public Property Name As String
        Public Property PasswordHash As String
        Public Property Username As String
    End Class

End Namespace