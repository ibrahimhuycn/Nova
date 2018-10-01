Public Class InventoryItemEditEventArgs
    Inherits EventArgs
    Public Property CatalogNumber As String
    Public Property ItemName As String
    Public Property ItemType As String
    Public Property ItemTypeId As Integer
    Public Property Lab As String
    Public Property LabId As Integer
    Public Property LotsCollection As List(Of LotsCollectionForItem)
    Public Property PackSize As String
    Public Property PackSizeId As Integer
    Public Property Unit As String
    Public Property UnitsId As Integer
    Public Property UserSelectedItemId As Integer
    Public Property Vendor As String
    Public Property VendorId As Integer
End Class

Public Class LotsCollectionForItem

#Region "Keeping order"

    Property LotNumber() As String

#End Region

    Property Expiry() As Date
    Property Quantity() As Integer
End Class