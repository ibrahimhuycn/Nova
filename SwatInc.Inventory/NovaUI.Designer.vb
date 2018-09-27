<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovaUI
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NovaSplashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.SwatInc.Inventory.NovaSplash), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovaUI))
        Me.NovaRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.RequestsMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonMakePurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonAddUser = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonResetPassword = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonDashboard = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonReorder = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemSelectLaboratory = New DevExpress.XtraBars.BarButtonItem()
        Me.LaboratoriesMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarStaticItemLoggedInUser = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemSelectedLaboratoryName = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemCompanyName = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RequestsAndInventory = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.UsersAndAuthentication = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Laboratory = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Help = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.NovaRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestsMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriesMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NovaSplashManager
        '
        NovaSplashManager.ClosingDelay = 500
        '
        'NovaRibbon
        '
        Me.NovaRibbon.ExpandCollapseItem.Id = 0
        Me.NovaRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NovaRibbon.ExpandCollapseItem, Me.BarButtonRequests, Me.BarButtonInventory, Me.BarButtonAddUser, Me.BarButtonChangePassword, Me.BarButtonResetPassword, Me.BarButtonDashboard, Me.BarButtonReorder, Me.BarButtonMakePurchaseOrder, Me.BarButtonItemSelectLaboratory, Me.BarStaticItemLoggedInUser, Me.BarStaticItemSelectedLaboratoryName, Me.BarStaticItemCompanyName, Me.BarButtonItem1})
        Me.NovaRibbon.Location = New System.Drawing.Point(0, 0)
        Me.NovaRibbon.MaxItemId = 3
        Me.NovaRibbon.Name = "NovaRibbon"
        Me.NovaRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.Help})
        Me.NovaRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.NovaRibbon.Size = New System.Drawing.Size(1208, 143)
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
        'BarButtonInventory
        '
        Me.BarButtonInventory.Caption = "Inventory"
        Me.BarButtonInventory.Id = 2
        Me.BarButtonInventory.ImageOptions.Image = CType(resources.GetObject("BarButtonInventory.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonInventory.Name = "BarButtonInventory"
        Me.BarButtonInventory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonAddUser
        '
        Me.BarButtonAddUser.Caption = "Add User"
        Me.BarButtonAddUser.Id = 8
        Me.BarButtonAddUser.ImageOptions.Image = CType(resources.GetObject("BarButtonAddUser.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonAddUser.Name = "BarButtonAddUser"
        Me.BarButtonAddUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonChangePassword
        '
        Me.BarButtonChangePassword.Caption = "Change Password"
        Me.BarButtonChangePassword.Id = 9
        Me.BarButtonChangePassword.ImageOptions.Image = CType(resources.GetObject("BarButtonChangePassword.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonChangePassword.Name = "BarButtonChangePassword"
        Me.BarButtonChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonResetPassword
        '
        Me.BarButtonResetPassword.Caption = "Reset Password"
        Me.BarButtonResetPassword.Id = 10
        Me.BarButtonResetPassword.ImageOptions.Image = CType(resources.GetObject("BarButtonResetPassword.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonResetPassword.Name = "BarButtonResetPassword"
        Me.BarButtonResetPassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonDashboard
        '
        Me.BarButtonDashboard.Caption = "Dashboard"
        Me.BarButtonDashboard.Id = 11
        Me.BarButtonDashboard.ImageOptions.Image = CType(resources.GetObject("BarButtonDashboard.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonDashboard.Name = "BarButtonDashboard"
        Me.BarButtonDashboard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonReorder
        '
        Me.BarButtonReorder.Caption = "Reorder"
        Me.BarButtonReorder.Id = 12
        Me.BarButtonReorder.ImageOptions.Image = CType(resources.GetObject("BarButtonReorder.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonReorder.Name = "BarButtonReorder"
        Me.BarButtonReorder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemSelectLaboratory
        '
        Me.BarButtonItemSelectLaboratory.ActAsDropDown = True
        Me.BarButtonItemSelectLaboratory.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItemSelectLaboratory.Caption = "Select Laboratory"
        Me.BarButtonItemSelectLaboratory.DropDownControl = Me.LaboratoriesMenu
        Me.BarButtonItemSelectLaboratory.Id = 2
        Me.BarButtonItemSelectLaboratory.ImageOptions.Image = CType(resources.GetObject("BarButtonItemSelectLaboratory.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemSelectLaboratory.Name = "BarButtonItemSelectLaboratory"
        Me.BarButtonItemSelectLaboratory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'LaboratoriesMenu
        '
        Me.LaboratoriesMenu.Name = "LaboratoriesMenu"
        Me.LaboratoriesMenu.Ribbon = Me.NovaRibbon
        '
        'BarStaticItemLoggedInUser
        '
        Me.BarStaticItemLoggedInUser.Caption = "User: "
        Me.BarStaticItemLoggedInUser.Id = 3
        Me.BarStaticItemLoggedInUser.Name = "BarStaticItemLoggedInUser"
        '
        'BarStaticItemSelectedLaboratoryName
        '
        Me.BarStaticItemSelectedLaboratoryName.Caption = "Laboratory: "
        Me.BarStaticItemSelectedLaboratoryName.Id = 4
        Me.BarStaticItemSelectedLaboratoryName.Name = "BarStaticItemSelectedLaboratoryName"
        '
        'BarStaticItemCompanyName
        '
        Me.BarStaticItemCompanyName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemCompanyName.Caption = "Swat, Inc."
        Me.BarStaticItemCompanyName.Id = 5
        Me.BarStaticItemCompanyName.Name = "BarStaticItemCompanyName"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Log Out"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RequestsAndInventory, Me.UsersAndAuthentication, Me.Laboratory})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Nova"
        '
        'RequestsAndInventory
        '
        Me.RequestsAndInventory.ItemLinks.Add(Me.BarButtonDashboard)
        Me.RequestsAndInventory.ItemLinks.Add(Me.BarButtonRequests)
        Me.RequestsAndInventory.ItemLinks.Add(Me.BarButtonInventory)
        Me.RequestsAndInventory.ItemLinks.Add(Me.BarButtonReorder)
        Me.RequestsAndInventory.Name = "RequestsAndInventory"
        Me.RequestsAndInventory.Text = "Requests And Inventory"
        '
        'UsersAndAuthentication
        '
        Me.UsersAndAuthentication.ItemLinks.Add(Me.BarButtonAddUser)
        Me.UsersAndAuthentication.ItemLinks.Add(Me.BarButtonChangePassword)
        Me.UsersAndAuthentication.ItemLinks.Add(Me.BarButtonResetPassword)
        Me.UsersAndAuthentication.ItemLinks.Add(Me.BarButtonItem1)
        Me.UsersAndAuthentication.Name = "UsersAndAuthentication"
        Me.UsersAndAuthentication.Text = "Users And Authentication"
        '
        'Laboratory
        '
        Me.Laboratory.ItemLinks.Add(Me.BarButtonItemSelectLaboratory)
        Me.Laboratory.Name = "Laboratory"
        Me.Laboratory.Text = "Laboratory"
        '
        'Help
        '
        Me.Help.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.Help.Name = "Help"
        Me.Help.Text = "Help"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItemLoggedInUser)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItemSelectedLaboratoryName)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItemCompanyName)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 463)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.NovaRibbon
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1208, 31)
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'NovaUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 494)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.NovaRibbon)
        Me.IsMdiContainer = True
        Me.Name = "NovaUI"
        Me.Ribbon = Me.NovaRibbon
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "NovaUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NovaRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestsMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriesMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NovaRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RequestsAndInventory As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Help As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonAddUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents UsersAndAuthentication As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonResetPassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonDashboard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RequestsMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonReorder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonMakePurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Laboratory As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemSelectLaboratory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LaboratoriesMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarStaticItemLoggedInUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemSelectedLaboratoryName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemCompanyName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
