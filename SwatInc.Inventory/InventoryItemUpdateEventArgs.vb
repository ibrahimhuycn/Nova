Imports System.ComponentModel

Public Class InventoryItemUpdateEventArgs
    Inherits EventArgs
    Public Property CatalogNumber As String
    Public Property ItemName As String
    Public Property ItemType As String
    Public Property ItemTypeId As Integer
    Public Property Lab As String
    Public Property LabId As Integer
    Public Property LotsCollection As BindingList(Of LotsCollectionForItem)
    Public Property PackSize As String
    Public Property PackSizeId As Integer
    Public Property Unit As String
    Public Property UnitsId As Integer
    Public Property UserSelectedItemId As Integer
    Public Property Vendor As String
    Public Property VendorId As Integer
End Class