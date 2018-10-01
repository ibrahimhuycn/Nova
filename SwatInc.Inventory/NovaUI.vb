Public Class NovaUI
    Public dbContext As Nova.NovaContext = New Nova.NovaContext()
    Public ItemTypes As IQueryable(Of Nova.ItemTypes)
    Public Locations As IQueryable(Of Nova.Locations)
    Public PackSizes As IQueryable(Of Nova.PackSizes)
    Public TransectionTypes As IQueryable(Of Nova.TransactionType)
    Public Units As IQueryable(Of Nova.Units)
    Public Vendors As IQueryable(Of Nova.Vendor)

#Region "User Interface Setup"

    Friend WithEvents Labs As DevExpress.XtraBars.BarButtonItem
    Dim ActiveLaboratory As New ActiveLaboratoryEventArgs

    Public Event ActiveLaboratoryChanged(ByVal sender As Object, e As ActiveLaboratoryEventArgs)

    Public Sub RaiseEventActiveLaboratoryChanged()
        RaiseEvent ActiveLaboratoryChanged(Me, ActiveLaboratory)
    End Sub

    Private Sub SelectActiveLaboratory(ByVal sender As Object, ByVal e As ActiveLaboratoryEventArgs) Handles Me.ActiveLaboratoryChanged
        BarButtonItemSelectLaboratory.Glyph = e.LaboratoryLogo
        BarButtonItemSelectLaboratory.Caption = e.LaboratoryName
        BarStaticItemSelectedLaboratoryName.Caption = "Laboratory: " & e.LaboratoryName
    End Sub

    Private Sub SetupRibbon(ByVal e As ActiveLaboratoryEventArgs)
        Dim Laboratories = From l In dbContext.Laboratory
                           Select l

        For Each LabName In Laboratories
            e.LaboratoryName = LabName.Name
            e.LaboratoryId = LabName.Id
            Labs = New DevExpress.XtraBars.BarButtonItem()
            LaboratoriesMenu.ItemLinks.Add(Labs)
            Labs.Name = e.LaboratoryName
            Labs.Caption = e.LaboratoryName
            Labs.Glyph = e.LaboratoryLogo
            Labs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

            AddHandler Labs.ItemClick, AddressOf LaboratorySeclection
        Next

        e.LaboratoryName = My.Resources.DefaultLabName
        RaiseEvent ActiveLaboratoryChanged(Me, e)

    End Sub

#End Region

    Public Sub EnableRibbon(ByVal RibbonIsEnabled As Boolean)
        If RibbonIsEnabled = True Then
            NovaRibbon.Enabled = True
        ElseIf RibbonIsEnabled = False Then
            NovaRibbon.Enabled = False
        End If
    End Sub

    Public Sub LoadLoginScreen()

        'Opens Login Screen
        Dim Authenticate As New Authenticate() With {.MdiParent = Me}
        Authenticate.Show()
    End Sub

    Private Sub BarButtonItemInventoryList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemInventoryList.ItemClick
        Dim InventoryList As New Inventory With {.MdiParent = Me,
    .StartPosition = FormStartPosition.CenterParent,
    .ShowInTaskbar = False}
        InventoryList.Show()
    End Sub

    Private Sub BarButtonItemNewItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNewItem.ItemClick
        Dim AddNewItem As New AddItem(dbContext, Vendors, Units, ItemTypes) With {.MdiParent = Me, .ShowInTaskbar = False, .StartPosition = FormStartPosition.CenterScreen}
        AddNewItem.Show()
        RaiseEvent ActiveLaboratoryChanged(Me, ActiveLaboratory)
    End Sub

    Private Sub BarButtonReorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonReorder.ItemClick
        Dim RequestNewItems As New NewRequest With {.MdiParent = Me,
                                   .StartPosition = FormStartPosition.CenterParent,
                                   .ShowInTaskbar = False}
        RequestNewItems.Show()
    End Sub

    Private Sub LaboratorySeclection(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        ActiveLaboratory.LaboratoryName = e.Item.Name
        RaiseEvent ActiveLaboratoryChanged(Me, ActiveLaboratory)
    End Sub

    Private Sub LoadStartUpData()
        Dim TransectionTypeData = From ttd In dbContext.TransactionType
                                  Select ttd
        TransectionTypes = TransectionTypeData
        Dim ItemTypeData = From itd In dbContext.ItemType
                           Select itd
        ItemTypes = ItemTypeData
        Dim LocationData = From ld In dbContext.Locations
                           Select ld
        Locations = LocationData
        Dim PackSizeData = From psd In dbContext.PackSizes
                           Select psd
        PackSizes = PackSizeData
        Dim UnitsData = From ud In dbContext.Units
                        Select ud
        Units = UnitsData
        '? PO Flags
        Dim VendorsData = From vd In dbContext.Vendor
                          Select vd
        Vendors = VendorsData

    End Sub

    Private Sub NovaUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupRibbon(ActiveLaboratory)

        'Disable Ribbon. Will be enabled after Authentication.
        EnableRibbon(False)
        LoadStartUpData()
        LoadLoginScreen()

    End Sub

End Class