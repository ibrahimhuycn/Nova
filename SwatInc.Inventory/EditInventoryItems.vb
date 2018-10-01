Imports System.Data.Entity

Public Class EditInventoryItems
    Public _dbContext As Nova.NovaContext
    Dim EditArgs As InventoryItemEditEventArgs

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

        If Not e Is Nothing Then
            EditArgs = e
            SetupEditingItem(Me, e)
        End If
    End Sub

    Private Sub EditInventoryItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LookUpEditItemType.EditValue = LookUpEditItemType.Properties.GetKeyValueByDisplayText(EditArgs.ItemType)
        Me.LookUpEditLaboratory.EditValue = LookUpEditLaboratory.Properties.GetKeyValueByDisplayText(EditArgs.Lab)
        Me.LookUpEditUnits.EditValue = LookUpEditUnits.Properties.GetKeyValueByDisplayText(EditArgs.Unit)
        Me.LookUpEditVendor.EditValue = LookUpEditVendor.Properties.GetKeyValueByDisplayText(EditArgs.Vendor)
    End Sub

    Private Sub SetupEditingItem(sender As Object, e As InventoryItemEditEventArgs)
        Me.TextEditItemName.Text = e.ItemName
        Me.TextEditCatalogNumber.Text = e.CatalogNumber
        Me.TextEditPackSize.Text = e.PackSize
        Me.GridControl1.DataSource = e.LotsCollection
    End Sub

End Class