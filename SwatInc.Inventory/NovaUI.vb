Public Class NovaUI

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
        Dim Laboratories() As String = {"All Labs", "Haematology", "Biochemistry", "Oncology"}

        For Each LabName In Laboratories
            e.LaboratoryName = LabName
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

    Private Sub BarButtonInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonInventory.ItemClick
        Dim InventoryList As New Inventory With {.MdiParent = Me,
            .StartPosition = FormStartPosition.CenterParent,
            .ShowInTaskbar = False}
        InventoryList.Show()
    End Sub

    Private Sub BarButtonItemSelectLaboratory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSelectLaboratory.ItemClick

    End Sub

    Private Sub BarButtonReorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub LaboratorySeclection(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        ActiveLaboratory.LaboratoryName = e.Item.Name
        RaiseEvent ActiveLaboratoryChanged(Me, ActiveLaboratory)
    End Sub

    Private Sub NovaUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupRibbon(ActiveLaboratory)

        'Prompt for Login

        'Disable Ribbon. Will be enabled after Authentication.
        EnableRibbon(False)

        LoadLoginScreen()
        ' Log.Info("Form LisMini loaded!")

    End Sub

End Class