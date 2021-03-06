﻿Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid
Imports SwatInc.Inventory
Imports System.ComponentModel
Imports System.Data.Entity

Public Class Inventory
    Dim dbContext As Nova.NovaContext = New Nova.NovaContext()

    Sub New()

        InitializeComponent()

        ItemDataLoadRequired()
        'Group Columns
        If GridView1.GroupedColumns.Count = 0 Then
            GridView1.Columns("Lab").GroupIndex = 1
            GridView1.Columns("ItemName").GroupIndex = 2
        End If
        GridView1.Columns("Expiry").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        AddHandler NovaUI.OnActiveLaboratoryChanged, AddressOf LabChanged
        AddHandler GridView1.RowClick, AddressOf RowClicked
        AddHandler EditInventoryItems.OnInventoryListUpdated, AddressOf RefreshEffectedItem

        NovaUI.RaiseEventActiveLaboratoryChanged()
    End Sub

    Public Event OnInventoryItemEditing(ByVal sender As Object, e As EventArgs)

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub ItemDataLoadRequired()
        Dim ItemsDataQuery = From i In dbContext.Items
                             From l In dbContext.Lots Where l.Item.Id = i.Id
                             From LabItems In dbContext.Laboratory_Items
                             From u In dbContext.Units Where i.Unit.Id = u.Id
                             From labs In dbContext.Laboratory Where (LabItems.Item.Id = i.Id And LabItems.Laboratory.Id = labs.Id)
                             Select New With {Key .ItemId = i.Id,
                                        Key .ItemName = i.Name,
                                        Key .Vendor = i.Vendor.Name,
                                        Key .Amount = l.Quantity & " " & u.Unit,
                                        i.CatalogNumber,
                                        Key .ItemType = i.Type.Type,
                                        Key .LotNumber = l.Id,
                                        Key .LotLocation = l.Location.Location,
                                        Key .PackSize = i.PackSize.Size,
                                        Key .Expiry = l.ExpirationDate,
                                        Key .Lab = labs.Name}
        ItemsDataQuery.Load()
        GridControl1.DataSource = ItemsDataQuery.ToList
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub LabChanged(ByVal sender As Object, ByVal e As ActiveLaboratoryEventArgs)
        If Not e.LaboratoryName = "All Labs" Then
            GridView1.ActiveFilterCriteria = New BinaryOperator("Lab", e.LaboratoryName)
        Else
            GridView1.ActiveFilterCriteria = Nothing
        End If
    End Sub

    Private Sub RefreshEffectedItem(sender As Object, e As InventoryItemUpdateEventArgs)
        'TODO: This needs to load only the effected Item. I am gonna load the whole table for the time being
        ItemDataLoadRequired()

    End Sub

    Private Sub RowClicked(ByVal sender As Object, e As RowClickEventArgs)
        Select Case e.Button
            Case MouseButtons.Right
            Case MouseButtons.Left
                If Not e.Clicks = 2 Then
                    Exit Sub
                End If
        End Select
        Dim VendorId As Integer
        Dim ItemTypeId As Integer
        Dim PackSizeId As Integer
        Dim LabId As Integer
        Dim UnitsId As Integer

        Dim UserSelectedItemId As Integer

        Dim ItemName As String
        Dim Vendor As String
        Dim CatalogNumber As String
        Dim ItemType As String
        Dim PackSize As String
        Dim Lab As String
        Dim LotLocation As String
        Dim unit As String 'Fetch unit from server

        If Not e.RowHandle < 0 Then

            UserSelectedItemId = GridView1.GetFocusedRowCellValue("ItemId")
            ItemName = GridView1.GetFocusedRowCellValue("ItemName")
            Vendor = GridView1.GetFocusedRowCellValue("Vendor")
            CatalogNumber = GridView1.GetFocusedRowCellValue("CatalogNumber")
            ItemType = GridView1.GetFocusedRowCellValue("ItemType")
            PackSize = GridView1.GetFocusedRowCellValue("PackSize")
            Lab = GridView1.GetFocusedRowCellValue("Lab")
            LotLocation = GridView1.GetFocusedRowCellValue("LotLocation")

            'Get VendorId, ItemType, PackSize,LabName, UnitsId and Unit from ItemId
            Dim IdsFromItemId = From I In dbContext.Items Join V In dbContext.Vendor On I.Vendor.Id Equals V.Id
                                Join u In dbContext.Units On I.Unit.Id Equals u.Id
                                Join It In dbContext.ItemType On I.Type.Id Equals It.Id
                                Join Ps In dbContext.PackSizes On I.PackSize.Id Equals Ps.Id
                                From L In dbContext.Laboratory From Li In dbContext.Laboratory_Items
                                Where Li.Item.Id = I.Id And Li.Laboratory.Id = L.Id
                                Where I.Id = UserSelectedItemId
                                Select New With {Key .VendorId = V.Id, Key .ItemTypeId = It.Id, Key .PackSizeId = Ps.Id,
                                    Key .LabId = L.Id, Key .UnitsId = u.Id, Key .ItemUnit = u.Unit}

            Dim LotDetailsForItem = From Lot In dbContext.Lots
                                    From Ll In dbContext.Locations Where Lot.Location.Id = Ll.Id
                                    Where Lot.Item.Id = UserSelectedItemId
                                    Select New With {Lot.Id,
                                               Lot.Quantity,
                                               Lot.ExpirationDate,
                                               Key .LotLocation = Lot.Location.Location}

            Dim LotInformation As New BindingList(Of LotsCollectionForItem)

            For Each detail In LotDetailsForItem
                Dim LotInfo As New LotsCollectionForItem With {.LotNumber = detail.Id,
                                   .Quantity = detail.Quantity,
                                   .Expiry = detail.ExpirationDate,
                                   .LotLocation = detail.LotLocation}
                LotInformation.Add(LotInfo)
            Next

            For Each id In IdsFromItemId
                VendorId = id.VendorId
                ItemTypeId = id.ItemTypeId
                PackSizeId = id.PackSizeId
                LabId = id.LabId
                UnitsId = id.UnitsId
                unit = id.ItemUnit
            Next

            Dim EditItem As New EditInventoryItems(New InventoryItemUpdateEventArgs With {.UserSelectedItemId = UserSelectedItemId,
                                                    .ItemTypeId = ItemTypeId,
                                                    .LabId = LabId,
                                                    .PackSizeId = PackSizeId,
                                                    .UnitsId = UnitsId,
                                                    .VendorId = VendorId,
                                                    .CatalogNumber = CatalogNumber,
                                                    .ItemName = ItemName,
                                                    .ItemType = ItemType,
                                                    .Lab = Lab,
                                                    .PackSize = PackSize,
                                                    .Unit = unit,
                                                    .Vendor = Vendor,
                                                    .LotsCollection = LotInformation}) With {.MdiParent = NovaUI,
                                .StartPosition = FormStartPosition.CenterScreen,
                                .ShowInTaskbar = False}
            EditItem.Show()

        End If
    End Sub

End Class