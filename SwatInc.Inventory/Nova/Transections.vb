Namespace Nova

    Public Class Transections
        Public Property IsAccepted() As Boolean
        Public Property ItemsId() As Integer
        Public Property ItemTypeId() As Integer
        Public Property LotId() As String

        'Accepted | Rejected
        Public Property Notes As String

        Public Property TransectionDate() As DateTime
        Public Property TransectionsId() As Integer
        Public Property TypeId() As Integer
        Public Property UsersId() As Users 'Record Card Number
    End Class

    Public Class Users
        Public Property Name() As String
        Public Property Username() As String
        Public Property UsersId() As Integer
    End Class

End Namespace
