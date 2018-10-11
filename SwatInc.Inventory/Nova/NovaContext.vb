Imports System.Data.Entity

Namespace Nova

    Public Class NovaContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("NovaConnectionString")
        End Sub

        Public Property CurrentStockLevels() As DbSet(Of CurrentStockLevels)
        Public Property Items() As DbSet(Of Items)
        Public Property ItemType() As DbSet(Of ItemTypes)
        Public Property Laboratory() As DbSet(Of Laboratory)
        Public Property Laboratory_Items() As DbSet(Of Laboratory_Items)
        Public Property Locations() As DbSet(Of Locations)
        Public Property Lots() As DbSet(Of Lots)
        Public Property PackSizes() As DbSet(Of PackSizes)
        Public Property PurchaseOrders() As DbSet(Of PurchaseOrders)
        Public Property StockLevelSettings() As DbSet(Of StockLevelSettings)
        Public Property Transactions() As DbSet(Of Transactions)
        Public Property TransactionType() As DbSet(Of TransactionType)
        Public Property Units() As DbSet(Of Units)
        Public Property Users() As DbSet(Of Users)
        Public Property Vendor() As DbSet(Of Vendor)
    End Class

End Namespace