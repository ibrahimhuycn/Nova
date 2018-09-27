Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTableVendorAndRelationShips
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Vendors",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Items", "Vendor_Id", Function(c) c.Int())
            CreateIndex("dbo.Items", "Vendor_Id")
            AddForeignKey("dbo.Items", "Vendor_Id", "dbo.Vendors", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Items", "Vendor_Id", "dbo.Vendors")
            DropIndex("dbo.Items", New String() { "Vendor_Id" })
            DropColumn("dbo.Items", "Vendor_Id")
            DropTable("dbo.Vendors")
        End Sub
    End Class
End Namespace
