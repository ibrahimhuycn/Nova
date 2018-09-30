﻿Imports System.Data.Entity
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid

Public Class Inventory
    Dim dbContext As Nova.NovaContext = New Nova.NovaContext()

    Sub New()

        InitializeComponent()

        ' This line of code is generated by Data Source Configuration Wizard
        ' Instantiate a new DBContext
        ' Call the Load method to get the data for the given DbSet from the database.
        '

        ItemDataLoadRequired()

        'Group Columns
        If GridView1.GroupedColumns.Count = 0 Then
            GridView1.Columns("Lab").GroupIndex = 1
            GridView1.Columns("ItemName").GroupIndex = 2
        End If
        GridView1.Columns("Expiry").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        AddHandler NovaUI.ActiveLaboratoryChanged, AddressOf LabChanged
        AddHandler GridView1.RowClick, AddressOf RowClicked
        AddHandler InventoryItemEditing, AddressOf UpdateChanges

        NovaUI.RaiseEventActiveLaboratoryChanged()
    End Sub

    Public Event InventoryItemEdited(ByVal sender As Object, e As EventArgs)

    Public Event InventoryItemEditing(ByVal sender As Object, e As EventArgs)

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
                                        Key .PackSize = i.PackSize.Size,
                                        Key .Expiry = l.ExpirationDate,
                                        Key .Lab = labs.Name}
        ItemsDataQuery.Load()
        GridControl1.DataSource = ItemsDataQuery.ToList
    End Sub

    Private Sub LabChanged(ByVal sender As Object, ByVal e As ActiveLaboratoryEventArgs)
        If Not e.LaboratoryName = "All Labs" Then
            GridView1.ActiveFilterCriteria = New BinaryOperator("Lab", e.LaboratoryName)
        Else
            GridView1.ActiveFilterCriteria = Nothing
        End If
    End Sub

    Private Sub RowClicked(ByVal sender As Object, e As RowClickEventArgs)
        Dim VendorId As Integer
        Dim ItemTypeId As Integer
        Dim PackSizeId As Integer
        Dim LabId As Integer
        Dim UnitsId As Integer

        Dim lotNumber As String
        Dim UserSelectedItemId As Integer

        If Not e.RowHandle < 0 Then
            Dim UserResponse = MsgBox("Do you want to edit the item?", vbYesNo, "Edit Inventory")

            If UserResponse = MsgBoxResult.Yes Then
                UserSelectedItemId = GridView1.GetFocusedRowCellValue("ItemId")
                lotNumber = GridView1.GetFocusedRowCellValue("LotNumber")
                'Get VendorId, ItemType, PackSize,LabName from ItemId

                Dim IdsFromItemId = From I In dbContext.Items Join V In dbContext.Vendor On I.Vendor.Id Equals V.Id
                                    Join u In dbContext.Units On I.Unit.Id Equals u.Id
                                    Join It In dbContext.ItemType On I.Type.Id Equals It.Id
                                    Join Ps In dbContext.PackSizes On I.PackSize.Id Equals Ps.Id
                                    From L In dbContext.Laboratory From Li In dbContext.Laboratory_Items
                                    Where Li.Item.Id = I.Id And Li.Laboratory.Id = L.Id
                                    Where I.Id = UserSelectedItemId
                                    Select New With {Key .VendorId = V.Id, Key .ItemTypeId = It.Id, Key .PackSizeId = Ps.Id,
                                        Key .LabId = L.Id, Key .UnitsId = u.Id}

                For Each id In IdsFromItemId
                    VendorId = id.VendorId
                    ItemTypeId = id.ItemTypeId
                    PackSizeId = id.PackSizeId
                    LabId = id.LabId
                    UnitsId = id.UnitsId
                Next

                RaiseEvent InventoryItemEditing(Me, New InventoryItemEditEventArgs With {.UserSelectedItemId = UserSelectedItemId,
                                                .LotNumber = lotNumber, .ItemTypeId = ItemTypeId, .LabId = LabId, .PackSizeId = PackSizeId,
                                                .UnitsId = UnitsId, .VendorId = VendorId})
            End If

        End If
    End Sub

    Private Sub UpdateChanges(ByVal sender As Object, ByVal e As InventoryItemEditEventArgs)

    End Sub

End Class