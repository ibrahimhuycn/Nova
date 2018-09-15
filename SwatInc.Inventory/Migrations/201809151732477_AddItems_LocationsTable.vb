Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddItems_LocationsTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Items_Locations",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Item_Id = c.Int(),
                        .location_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .ForeignKey("dbo.Locations", Function(t) t.location_Id) _
                .Index(Function(t) t.Item_Id) _
                .Index(Function(t) t.location_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Items_Locations", "location_Id", "dbo.Locations")
            DropForeignKey("dbo.Items_Locations", "Item_Id", "dbo.Items")
            DropIndex("dbo.Items_Locations", New String() { "location_Id" })
            DropIndex("dbo.Items_Locations", New String() { "Item_Id" })
            DropTable("dbo.Items_Locations")
        End Sub
    End Class
End Namespace
