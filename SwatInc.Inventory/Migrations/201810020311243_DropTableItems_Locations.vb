Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DropTableItems_Locations
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Items_Locations", "Item_Id", "dbo.Items")
            DropForeignKey("dbo.Items_Locations", "location_Id", "dbo.Locations")
            DropIndex("dbo.Items_Locations", New String() { "Item_Id" })
            DropIndex("dbo.Items_Locations", New String() { "location_Id" })
            DropTable("dbo.Items_Locations")
        End Sub
        
        Public Overrides Sub Down()
            CreateTable(
                "dbo.Items_Locations",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Item_Id = c.Int(),
                        .location_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateIndex("dbo.Items_Locations", "location_Id")
            CreateIndex("dbo.Items_Locations", "Item_Id")
            AddForeignKey("dbo.Items_Locations", "location_Id", "dbo.Locations", "Id")
            AddForeignKey("dbo.Items_Locations", "Item_Id", "dbo.Items", "Id")
        End Sub
    End Class
End Namespace
