﻿Imports System.Data.Entity

Public Class EditInventoryItems
    Public _dbContext As Nova.NovaContext
    Dim EditArgs As InventoryItemEditEventArgs
    Dim GridViewInFocus As Boolean = False

    Public Sub New(Optional e As EventArgs = Nothing)

        InitializeComponent()
        _dbContext = New Nova.NovaContext

        Dim TransectionTypeData = From ttd In _dbContext.TransactionType Select ttd
        Dim ItemTypeData = From itd In _dbContext.ItemType Select itd
        Dim LocationData = From ld In _dbContext.Locations Select ld
        Dim PackSizeData = From psd In _dbContext.PackSizes Select psd
        Dim UnitsData = From ud In _dbContext.Units Select ud
        Dim VendorsData = From vd In _dbContext.Vendor Select vd
        Dim Labs = From L In _dbContext.Laboratory Select L

        '? PO Flags

        TransectionTypeData.Load
        ItemTypeData.Load
        LocationData.Load
        PackSizeData.Load
        UnitsData.Load
        VendorsData.Load
        Labs.Load

        VendorBindingSource.DataSource = _dbContext.Vendor.Local
        ItemTypesBindingSource.DataSource = _dbContext.ItemType.Local
        UnitsBindingSource.DataSource = _dbContext.Units.Local
        LaboratoryBindingSource.DataSource = _dbContext.Laboratory.Local
        PackSizesBindingSource.DataSource = _dbContext.PackSizes.Local

        If Not e Is Nothing Then
            EditArgs = e
            SetupEditingItem(Me, e)
        End If
    End Sub

    Public Event InventoryItemSaved(ByVal sender As Object, ByVal e As InventoryItemEditEventArgs)

    Private Sub EditInventoryItems_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                If TabPaneAddItem.SelectedPage.Name = "TabNavigationPageLotInformation" And GridViewInFocus = True Then

                    GridView1.DeleteSelectedRows()
                    MsgBox(EditArgs.LotsCollection.Count)
                End If
        End Select
    End Sub

    Private Sub EditInventoryItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LookUpEditItemType.EditValue = LookUpEditItemType.Properties.GetKeyValueByDisplayText(EditArgs.ItemType)
        Me.LookUpEditLaboratory.EditValue = LookUpEditLaboratory.Properties.GetKeyValueByDisplayText(EditArgs.Lab)
        Me.LookUpEditUnits.EditValue = LookUpEditUnits.Properties.GetKeyValueByDisplayText(EditArgs.Unit)
        Me.LookUpEditVendor.EditValue = LookUpEditVendor.Properties.GetKeyValueByDisplayText(EditArgs.Vendor)
        Me.LookUpEditPackSize.EditValue = LookUpEditPackSize.Properties.GetKeyValueByDisplayText(EditArgs.PackSize)
    End Sub

    Private Sub GridView1_GotFocus(sender As Object, e As EventArgs) Handles GridView1.GotFocus
        GridViewInFocus = True
    End Sub

    Private Sub GridView1_LostFocus(sender As Object, e As EventArgs) Handles GridView1.LostFocus
        GridViewInFocus = False
    End Sub

    Private Sub SaveData()
        'Variables
        Dim DelimitedLotNumbersFromServer As String = Nothing
        Dim ServerLotNumbers() As String
        Dim FinishedInserts As Boolean = False

        Dim SaveData As New InventoryItemEditEventArgs With {.ItemName = Me.TextEditItemName.Text,
                            .Lab = LookUpEditLaboratory.Text,
                            .CatalogNumber = Me.TextEditCatalogNumber.Text,
                            .ItemType = Me.LookUpEditItemType.Text,
                            .ItemTypeId = Me.LookUpEditItemType.EditValue,
                            .LabId = LookUpEditLaboratory.EditValue,
                            .LotsCollection = EditArgs.LotsCollection,
                            .PackSize = LookUpEditPackSize.Text,
                            .PackSizeId = LookUpEditPackSize.EditValue,
                            .Unit = LookUpEditUnits.Text,
                            .UnitsId = LookUpEditUnits.EditValue,
                            .UserSelectedItemId = EditArgs.UserSelectedItemId,
                            .Vendor = LookUpEditVendor.Text,
                            .VendorId = LookUpEditVendor.EditValue}
        'Save Item
        Dim ItemSaveHandler = _dbContext.Items.Find(SaveData.UserSelectedItemId)
        ItemSaveHandler.CatalogNumber = SaveData.CatalogNumber
        ItemSaveHandler.Name = SaveData.ItemName
        ItemSaveHandler.PackSize.Id = SaveData.PackSizeId
        ItemSaveHandler.Type.Id = SaveData.ItemTypeId
        ItemSaveHandler.Unit.Id = SaveData.UnitsId
        ItemSaveHandler.Vendor.Id = SaveData.VendorId

        'Save Lots
        '1.Get All LotNumbers in Server for ItemId
        '2.SaveData: Not present | Server: Present | Action: Delete on server
        '3.SaveData: Present | Server: Present| Action: Update to server
        '4.SaveData: Present | Server: Absent | Action: Insert

        Dim LotNumber = From L In _dbContext.Lots Where L.Item.Id = SaveData.UserSelectedItemId Select New With {Key .LotNumber = L.Id}

        For Each sLot In LotNumber   'Iterate lots on server
            If DelimitedLotNumbersFromServer = Nothing Then
                DelimitedLotNumbersFromServer = sLot.LotNumber
            Else
                DelimitedLotNumbersFromServer = DelimitedLotNumbersFromServer & "|" & sLot.LotNumber
            End If
        Next
        ServerLotNumbers = DelimitedLotNumbersFromServer.Split("|")

        For Each LN In ServerLotNumbers
            Dim FoundMatchWithServerLot As Boolean = False
            For Each lot In SaveData.LotsCollection  'Iterate LOTS in SaveData

                Dim NewLot As Boolean = True
                'Look for new lots to insert.
                For Each LNs In ServerLotNumbers
                    If LNs = lot.LotNumber Then NewLot = False
                Next
                If NewLot = True Then
                    Using sqlquery As New Nova.NovaContext
                        Dim NoRowsInserted As Integer = sqlquery.Database.ExecuteSqlCommand(String.Format("INSERT INTO [dbo].[Lots] (Id,ExpirationDate,Quantity,Item_Id) VALUES ('{0}',{1},{2},{3})", lot.LotNumber, lot.Expiry.ToString("yyyy-MM-dd"), lot.Quantity, EditArgs.UserSelectedItemId))
                        If Not NoRowsInserted = 1 Then MsgBox("Cannot insert lot: " & lot.LotNumber)
                    End Using
                End If
                If lot.LotNumber = LN Then  'Do an UpDate
                    FoundMatchWithServerLot = True
                    Dim Query = _dbContext.Lots.Find(lot.LotNumber)
                    Query.ExpirationDate = lot.Expiry
                    Query.Quantity = lot.Quantity

                End If

            Next
            FinishedInserts = True
            If FoundMatchWithServerLot = False Then 'Lot not in save data,  Do a DELETE operation on Server
                Dim RemoveLot = _dbContext.Lots.Find(LN)
                _dbContext.Lots.Remove(RemoveLot)
            End If
        Next

        'Save Changes to db
        _dbContext.SaveChanges()
    End Sub

    Private Sub SetupEditingItem(sender As Object, e As InventoryItemEditEventArgs)
        Me.TextEditItemName.Text = e.ItemName
        Me.TextEditCatalogNumber.Text = e.CatalogNumber
        Me.GridControl1.DataSource = e.LotsCollection
    End Sub

    Private Sub SimpleButtonAddLot_Click(sender As Object, e As EventArgs) Handles SimpleButtonAddLot.Click
        If Not TextBoxLotNumber.Text = "" And Not TextBoxQuantity.Text = "" Then
            Dim NewLot As New LotsCollectionForItem With {.LotNumber = TextBoxLotNumber.Text,
                .Quantity = TextBoxQuantity.Text, .Expiry = DateTimePickerExpirationDate.Text}

            EditArgs.LotsCollection.Add(NewLot)
        End If

    End Sub

    Private Sub SimpleButtonSave1_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave1.Click
        SaveData()
    End Sub

    Private Sub SimpleButtonSave2_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave2.Click
        SaveData()
    End Sub

End Class