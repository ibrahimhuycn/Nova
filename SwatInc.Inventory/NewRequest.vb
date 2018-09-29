Imports System.Data.Entity

Public Class NewRequest
    Dim dbContext As Nova.NovaContext = New Nova.NovaContext
    Dim ItemsQuery As Object
    Dim SelectedItemId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim Query = From i In dbContext.Items
                    Select i
        ItemsQuery = Query
        For Each item In Query
            ComboBoxEdit1.Properties.Items.Add(item.Name)

        Next
    End Sub

    Private Sub ComboBoxEdit1_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEdit1.LostFocus

        Dim Query = From i In dbContext.Items.Where(Function(i) i.Name = ComboBoxEdit1.Text)
                    Join v In dbContext.Vendor On i.Vendor.Id Equals v.Id
                    Select New With {Key .ItemVendorName = i.Vendor.Name, Key .ItemId = i.Id}

        For Each item In Query
            ComboBoxEdit2.Properties.Items.Add(item.ItemVendorName)
            LabelControlItemsId.Text = item.ItemId
        Next

    End Sub

End Class