Imports System.ComponentModel
Imports System.Data.Entity
Imports DevExpress.XtraEditors.Repository

Public Class AddItem

    Dim ItemTypes As IQueryable(Of Nova.ItemTypes)
    Dim SelectedLabId As Integer

    Dim Units As IQueryable(Of Nova.Units)
    Dim Vendors As IQueryable(Of Nova.Vendor)

    Public Sub New(context As Nova.NovaContext,
        vendors As IQueryable(Of Nova.Vendor),
        units As IQueryable(Of Nova.Units),
        itemTypes As IQueryable(Of Nova.ItemTypes))

        InitializeComponent()

        itemTypes.Load()
        units.Load()
        vendors.Load()

        Me.Vendors = vendors
        Me.Units = units
        Me.ItemTypes = itemTypes

        VendorBindingSource.DataSource = context.Vendor.Local
        ItemTypesBindingSource.DataSource = context.ItemType.Local
        UnitsBindingSource.DataSource = context.Units.Local

        AddHandler NovaUI.ActiveLaboratoryChanged, AddressOf LabChanged

    End Sub

    Private Sub LabChanged(ByVal sender As Object, ByVal e As ActiveLaboratoryEventArgs)
        SelectedLabId = e.LaboratoryId
        Me.Text = "Add Item to: " & e.LaboratoryName

    End Sub

    Private Sub LookUpEditItemType_EditValueChanged(sender As Object, e As EventArgs)
        MsgBox(LookUpEditItemType.EditValue)
    End Sub

    Private Sub SimpleButtonAssignLot_Click(sender As Object, e As EventArgs) Handles SimpleButtonAssignLot.Click
        '? NEW ITEM || EDITING EXISTING ITEM || REQUEST EXISTING ITEM

    End Sub

End Class