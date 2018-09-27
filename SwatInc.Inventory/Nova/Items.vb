Namespace Nova

    Public Class Items
        Public Property CatalogNumber As String
        Public Property Id As Integer
        Public Property Name As String
        Public Property PackSize As PackSizes
        Public Property Type As ItemTypes
        Public Property Vendor As Vendor

    End Class

    Public Class Vendor
        Public Property Id As Integer
        Public Property Name As String

    End Class

End Namespace