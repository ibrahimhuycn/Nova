Public Class NewRequest
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dbContext As Nova.NovaContext = New Nova.NovaContext
        Dim Query = From i In dbContext.Items
                    Select i

        For Each item In Query
            ComboBoxEdit1.Properties.Items.Add(item)
        Next
    End Sub
End Class