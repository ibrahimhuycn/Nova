Imports System.Data.Entity

Namespace Nova

    Public Class NovaContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("NovaConnectionString")
        End Sub

        Public Property Items() As DbSet(Of Items)
        Public Property Lots() As DbSet(Of Lots)
        Public Property Transactions() As DbSet(Of Transactions)

        Public Property Type() As DbSet(Of TransactionType)
        Public Property Users() As DbSet(Of Users)
    End Class

End Namespace