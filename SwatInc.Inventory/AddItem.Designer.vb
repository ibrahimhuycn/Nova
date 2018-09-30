<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItem
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPaneAddItem = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPageAddInventoryItem = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButtonAddItemType = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonAddUnits = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonAddVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEditVendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.TextEditCatalogNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEditUnits = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEditItemType = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonAssignLot = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditPackSize = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditItemName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TabNavigationPageLotInformation = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButtonAddLot = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPaneAddItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPaneAddItem.SuspendLayout()
        Me.TabNavigationPageAddInventoryItem.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LookUpEditVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditCatalogNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditPackSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPageLotInformation.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataSource = GetType(SwatInc.Inventory.Nova.Vendor)
        '
        'UnitsBindingSource
        '
        Me.UnitsBindingSource.DataSource = GetType(SwatInc.Inventory.Nova.Units)
        '
        'ItemTypesBindingSource
        '
        Me.ItemTypesBindingSource.DataSource = GetType(SwatInc.Inventory.Nova.ItemTypes)
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataSource = GetType(SwatInc.Inventory.Nova.Items)
        '
        'TabPaneAddItem
        '
        Me.TabPaneAddItem.Controls.Add(Me.TabNavigationPageAddInventoryItem)
        Me.TabPaneAddItem.Controls.Add(Me.TabNavigationPageLotInformation)
        Me.TabPaneAddItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPaneAddItem.Location = New System.Drawing.Point(0, 0)
        Me.TabPaneAddItem.Name = "TabPaneAddItem"
        Me.TabPaneAddItem.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPageAddInventoryItem, Me.TabNavigationPageLotInformation})
        Me.TabPaneAddItem.RegularSize = New System.Drawing.Size(495, 246)
        Me.TabPaneAddItem.SelectedPage = Me.TabNavigationPageAddInventoryItem
        Me.TabPaneAddItem.Size = New System.Drawing.Size(495, 246)
        Me.TabPaneAddItem.TabIndex = 14
        Me.TabPaneAddItem.Text = "Add Item"
        '
        'TabNavigationPageAddInventoryItem
        '
        Me.TabNavigationPageAddInventoryItem.Caption = "Add Inventory Item"
        Me.TabNavigationPageAddInventoryItem.Controls.Add(Me.GroupControl1)
        Me.TabNavigationPageAddInventoryItem.Name = "TabNavigationPageAddInventoryItem"
        Me.TabNavigationPageAddInventoryItem.Size = New System.Drawing.Size(477, 201)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButtonAddItemType)
        Me.GroupControl1.Controls.Add(Me.SimpleButtonAddUnits)
        Me.GroupControl1.Controls.Add(Me.SimpleButtonAddVendor)
        Me.GroupControl1.Controls.Add(Me.LookUpEditVendor)
        Me.GroupControl1.Controls.Add(Me.TextEditCatalogNumber)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LookUpEditUnits)
        Me.GroupControl1.Controls.Add(Me.LookUpEditItemType)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButtonAssignLot)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.TextEditPackSize)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.TextEditItemName)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(477, 201)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Item Information"
        '
        'SimpleButtonAddItemType
        '
        Me.SimpleButtonAddItemType.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButtonAddItemType.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.AddIcon16x16
        Me.SimpleButtonAddItemType.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButtonAddItemType.Location = New System.Drawing.Point(443, 136)
        Me.SimpleButtonAddItemType.Name = "SimpleButtonAddItemType"
        Me.SimpleButtonAddItemType.Size = New System.Drawing.Size(21, 21)
        Me.SimpleButtonAddItemType.TabIndex = 36
        '
        'SimpleButtonAddUnits
        '
        Me.SimpleButtonAddUnits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButtonAddUnits.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.AddIcon16x16
        Me.SimpleButtonAddUnits.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButtonAddUnits.Location = New System.Drawing.Point(257, 136)
        Me.SimpleButtonAddUnits.Name = "SimpleButtonAddUnits"
        Me.SimpleButtonAddUnits.Size = New System.Drawing.Size(21, 21)
        Me.SimpleButtonAddUnits.TabIndex = 35
        '
        'SimpleButtonAddVendor
        '
        Me.SimpleButtonAddVendor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButtonAddVendor.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.AddIcon16x16
        Me.SimpleButtonAddVendor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButtonAddVendor.Location = New System.Drawing.Point(207, 91)
        Me.SimpleButtonAddVendor.Name = "SimpleButtonAddVendor"
        Me.SimpleButtonAddVendor.Size = New System.Drawing.Size(21, 21)
        Me.SimpleButtonAddVendor.TabIndex = 34
        '
        'LookUpEditVendor
        '
        Me.LookUpEditVendor.Location = New System.Drawing.Point(5, 92)
        Me.LookUpEditVendor.Name = "LookUpEditVendor"
        Me.LookUpEditVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditVendor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "")})
        Me.LookUpEditVendor.Properties.DataSource = Me.VendorBindingSource
        Me.LookUpEditVendor.Properties.DisplayMember = "Name"
        Me.LookUpEditVendor.Properties.NullText = ""
        Me.LookUpEditVendor.Properties.ShowFooter = False
        Me.LookUpEditVendor.Properties.ShowHeader = False
        Me.LookUpEditVendor.Properties.Tag = ""
        Me.LookUpEditVendor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditVendor.Properties.ValueMember = "Id"
        Me.LookUpEditVendor.Size = New System.Drawing.Size(200, 20)
        Me.LookUpEditVendor.TabIndex = 2
        '
        'TextEditCatalogNumber
        '
        Me.TextEditCatalogNumber.Location = New System.Drawing.Point(240, 92)
        Me.TextEditCatalogNumber.Name = "TextEditCatalogNumber"
        Me.TextEditCatalogNumber.Size = New System.Drawing.Size(227, 20)
        Me.TextEditCatalogNumber.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(238, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Catalog Number"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Vendor"
        '
        'LookUpEditUnits
        '
        Me.LookUpEditUnits.Location = New System.Drawing.Point(132, 137)
        Me.LookUpEditUnits.Name = "LookUpEditUnits"
        Me.LookUpEditUnits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditUnits.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit", "")})
        Me.LookUpEditUnits.Properties.DataSource = Me.UnitsBindingSource
        Me.LookUpEditUnits.Properties.DisplayMember = "Unit"
        Me.LookUpEditUnits.Properties.NullText = ""
        Me.LookUpEditUnits.Properties.ShowFooter = False
        Me.LookUpEditUnits.Properties.ShowHeader = False
        Me.LookUpEditUnits.Properties.Tag = ""
        Me.LookUpEditUnits.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditUnits.Properties.ValueMember = "Id"
        Me.LookUpEditUnits.Size = New System.Drawing.Size(125, 20)
        Me.LookUpEditUnits.TabIndex = 5
        '
        'LookUpEditItemType
        '
        Me.LookUpEditItemType.Location = New System.Drawing.Point(287, 137)
        Me.LookUpEditItemType.Name = "LookUpEditItemType"
        Me.LookUpEditItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditItemType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "")})
        Me.LookUpEditItemType.Properties.DataSource = Me.ItemTypesBindingSource
        Me.LookUpEditItemType.Properties.DisplayMember = "Type"
        Me.LookUpEditItemType.Properties.NullText = ""
        Me.LookUpEditItemType.Properties.ShowFooter = False
        Me.LookUpEditItemType.Properties.ShowHeader = False
        Me.LookUpEditItemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditItemType.Properties.ValueMember = "Id"
        Me.LookUpEditItemType.Size = New System.Drawing.Size(156, 20)
        Me.LookUpEditItemType.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.request16x16
        Me.SimpleButton3.Location = New System.Drawing.Point(394, 167)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "Request"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.save16x16
        Me.SimpleButton2.Location = New System.Drawing.Point(232, 167)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Save"
        '
        'SimpleButtonAssignLot
        '
        Me.SimpleButtonAssignLot.ImageOptions.Image = Global.SwatInc.Inventory.My.Resources.Resources.SaveNewLot16x16
        Me.SimpleButtonAssignLot.Location = New System.Drawing.Point(313, 167)
        Me.SimpleButtonAssignLot.Name = "SimpleButtonAssignLot"
        Me.SimpleButtonAssignLot.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonAssignLot.TabIndex = 8
        Me.SimpleButtonAssignLot.Text = "Assign &Lot"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(287, 117)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Item Type"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(132, 118)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Unit(s)"
        '
        'TextEditPackSize
        '
        Me.TextEditPackSize.Location = New System.Drawing.Point(5, 137)
        Me.TextEditPackSize.Name = "TextEditPackSize"
        Me.TextEditPackSize.Size = New System.Drawing.Size(121, 20)
        Me.TextEditPackSize.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 118)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Pack Size"
        '
        'TextEditItemName
        '
        Me.TextEditItemName.Location = New System.Drawing.Point(5, 45)
        Me.TextEditItemName.Name = "TextEditItemName"
        Me.TextEditItemName.Size = New System.Drawing.Size(464, 20)
        Me.TextEditItemName.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Item Name"
        '
        'TabNavigationPageLotInformation
        '
        Me.TabNavigationPageLotInformation.Caption = "Lot Information"
        Me.TabNavigationPageLotInformation.Controls.Add(Me.SimpleButton1)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.SimpleButtonAddLot)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.GridControl1)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.LabelControl9)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.DateTimePicker1)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.LabelControl8)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.TextBox2)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.LabelControl5)
        Me.TabNavigationPageLotInformation.Controls.Add(Me.TextBox1)
        Me.TabNavigationPageLotInformation.Name = "TabNavigationPageLotInformation"
        Me.TabNavigationPageLotInformation.Size = New System.Drawing.Size(477, 201)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 21)
        Me.TextBox1.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Lot Number"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(139, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Quantity"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(65, 21)
        Me.TextBox2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(210, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl9.TabIndex = 5
        Me.LabelControl9.Text = "Expiration Date"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(471, 148)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SimpleButtonAddLot
        '
        Me.SimpleButtonAddLot.Location = New System.Drawing.Point(318, 22)
        Me.SimpleButtonAddLot.Name = "SimpleButtonAddLot"
        Me.SimpleButtonAddLot.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonAddLot.TabIndex = 7
        Me.SimpleButtonAddLot.Text = "Add Lot"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(399, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Save &Lot(s)"
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 246)
        Me.Controls.Add(Me.TabPaneAddItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddItem"
        Me.ShowInTaskbar = False
        Me.Text = "Add Item In: "
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPaneAddItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPaneAddItem.ResumeLayout(False)
        Me.TabNavigationPageAddInventoryItem.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LookUpEditVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditCatalogNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditPackSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPageLotInformation.ResumeLayout(False)
        Me.TabNavigationPageLotInformation.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents UnitsBindingSource As BindingSource
    Friend WithEvents ItemTypesBindingSource As BindingSource
    Friend WithEvents VendorBindingSource As BindingSource
    Friend WithEvents TabPaneAddItem As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPageAddInventoryItem As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButtonAddItemType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonAddUnits As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonAddVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEditVendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEditCatalogNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LookUpEditUnits As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditItemType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonAssignLot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditPackSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditItemName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabNavigationPageLotInformation As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonAddLot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox1 As TextBox
End Class
