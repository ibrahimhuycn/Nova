<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaUI
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovaUI))
        Me.NovaRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonAddItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonAddUser = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonResetPassword = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonDashboard = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonReorder = New DevExpress.XtraBars.BarButtonItem()
        Me.RequestsMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonMakePurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.NovaRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestsMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NovaRibbon
        '
        Me.NovaRibbon.ExpandCollapseItem.Id = 0
        Me.NovaRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NovaRibbon.ExpandCollapseItem, Me.BarButtonRequests, Me.BarButtonInventory, Me.BarButtonAddItem, Me.BarButtonAddUser, Me.BarButtonChangePassword, Me.BarButtonResetPassword, Me.BarButtonDashboard, Me.BarButtonReorder, Me.BarButtonMakePurchaseOrder})
        Me.NovaRibbon.Location = New System.Drawing.Point(0, 0)
        Me.NovaRibbon.MaxItemId = 2
        Me.NovaRibbon.Name = "NovaRibbon"
        Me.NovaRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage3})
        Me.NovaRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.NovaRibbon.Size = New System.Drawing.Size(1273, 143)
        Me.NovaRibbon.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonRequests
        '
        Me.BarButtonRequests.ActAsDropDown = True
        Me.BarButtonRequests.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonRequests.Caption = "Requests"
        Me.BarButtonRequests.DropDownControl = Me.RequestsMenu
        Me.BarButtonRequests.Id = 1
        Me.BarButtonRequests.ImageOptions.Image = CType(resources.GetObject("BarButtonRequests.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonRequests.Name = "BarButtonRequests"
        Me.BarButtonRequests.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonInventory
        '
        Me.BarButtonInventory.Caption = "Inventory"
        Me.BarButtonInventory.Id = 2
        Me.BarButtonInventory.ImageOptions.Image = CType(resources.GetObject("BarButtonInventory.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonInventory.Name = "BarButtonInventory"
        Me.BarButtonInventory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonAddItem
        '
        Me.BarButtonAddItem.Caption = "ADD ITEM"
        Me.BarButtonAddItem.Id = 3
        Me.BarButtonAddItem.ImageOptions.Image = CType(resources.GetObject("BarButtonAddItem.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonAddItem.Name = "BarButtonAddItem"
        Me.BarButtonAddItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BarButtonAddUser
        '
        Me.BarButtonAddUser.Caption = "Add User"
        Me.BarButtonAddUser.Id = 8
        Me.BarButtonAddUser.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonAddUser.Name = "BarButtonAddUser"
        Me.BarButtonAddUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonChangePassword
        '
        Me.BarButtonChangePassword.Caption = "Change Password"
        Me.BarButtonChangePassword.Id = 9
        Me.BarButtonChangePassword.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonChangePassword.Name = "BarButtonChangePassword"
        Me.BarButtonChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonResetPassword
        '
        Me.BarButtonResetPassword.Caption = "Reset Password"
        Me.BarButtonResetPassword.Id = 10
        Me.BarButtonResetPassword.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonResetPassword.Name = "BarButtonResetPassword"
        Me.BarButtonResetPassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonDashboard
        '
        Me.BarButtonDashboard.Caption = "Dashboard"
        Me.BarButtonDashboard.Id = 11
        Me.BarButtonDashboard.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonDashboard.Name = "BarButtonDashboard"
        Me.BarButtonDashboard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Nova"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonDashboard)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonRequests)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonInventory)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonReorder)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Requests And Inventory"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonAddUser)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonChangePassword)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonResetPassword)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Users And Authentication"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Help"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 612)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.NovaRibbon
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1273, 31)
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Members | Authentication"
        '
        'BarButtonReorder
        '
        Me.BarButtonReorder.Caption = "Reorder"
        Me.BarButtonReorder.Id = 12
        Me.BarButtonReorder.ImageOptions.Image = CType(resources.GetObject("BarButtonItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonReorder.Name = "BarButtonReorder"
        Me.BarButtonReorder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RequestsMenu
        '
        Me.RequestsMenu.ItemLinks.Add(Me.BarButtonMakePurchaseOrder)
        Me.RequestsMenu.Name = "RequestsMenu"
        Me.RequestsMenu.Ribbon = Me.NovaRibbon
        '
        'BarButtonMakePurchaseOrder
        '
        Me.BarButtonMakePurchaseOrder.Caption = "Make Purchase Order"
        Me.BarButtonMakePurchaseOrder.Id = 1
        Me.BarButtonMakePurchaseOrder.ImageOptions.Image = CType(resources.GetObject("BarButtonMakePurchaseOrder.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonMakePurchaseOrder.Name = "BarButtonMakePurchaseOrder"
        Me.BarButtonMakePurchaseOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'NovaUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 643)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.NovaRibbon)
        Me.Name = "NovaUI"
        Me.Ribbon = Me.NovaRibbon
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "NovaUI"
        CType(Me.NovaRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestsMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NovaRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonAddItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonAddUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonResetPassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonDashboard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RequestsMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonReorder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonMakePurchaseOrder As DevExpress.XtraBars.BarButtonItem
End Class
