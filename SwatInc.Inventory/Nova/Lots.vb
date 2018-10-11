Imports System.ComponentModel.DataAnnotations.Schema

Namespace Nova

    Public Class Lots
        Public Property ExpirationDate As Date
        Public Property Id As String
        Public Property Item As Items
        Public Property Location As Locations
        Public Property Quantity As Integer
    End Class

End Namespace