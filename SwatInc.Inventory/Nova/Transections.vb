﻿Namespace Nova

    Public Class Transactions
        Public Property Id As Integer
        Public Property IsAccepted As Boolean
        Public Property Items As Items
        Public Property Lab As Laboratory
        Public Property Lot As Lots
        Public Property Notes As String
        Public Property Quantity As Integer
        Public Property Time As DateTime
        Public Property TransectionDate As DateTime
        Public Property Type As TransactionType
        Public Property User As Users 'Record Card Number
    End Class

End Namespace