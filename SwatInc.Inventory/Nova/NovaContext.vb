Imports System.Data.Entity

Namespace Nova

    Public Class NovaContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("NovaConnectionString")
        End Sub

        Public Property CurrentStockLevels() As DbSet(Of CurrentStockLevels)
        Public Property Items() As DbSet(Of Items)
        Public Property Items_Locations() As DbSet(Of Items_Locations)
        Public Property Locations() As DbSet(Of Locations)
        Public Property Lots() As DbSet(Of Lots)
        Public Property PackSizes() As DbSet(Of PackSizes)
        Public Property PurchaseOrders() As DbSet(Of PurchaseOrders)
        Public Property StockLevelSettings() As DbSet(Of StockLevelSettings)
        Public Property Transactions() As DbSet(Of Transactions)

        Public Property Type() As DbSet(Of TransactionType)
        Public Property Users() As DbSet(Of Users)
    End Class

End Namespace