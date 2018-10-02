Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddFKLocationsToItemsAndLots
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Items", "DefaultLocation_Id", Function(c) c.Int())
            AddColumn("dbo.Lots", "Location_Id", Function(c) c.Int())
            CreateIndex("dbo.Items", "DefaultLocation_Id")
            CreateIndex("dbo.Lots", "Location_Id")
            AddForeignKey("dbo.Items", "DefaultLocation_Id", "dbo.Locations", "Id")
            AddForeignKey("dbo.Lots", "Location_Id", "dbo.Locations", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Lots", "Location_Id", "dbo.Locations")
            DropForeignKey("dbo.Items", "DefaultLocation_Id", "dbo.Locations")
            DropIndex("dbo.Lots", New String() { "Location_Id" })
            DropIndex("dbo.Items", New String() { "DefaultLocation_Id" })
            DropColumn("dbo.Lots", "Location_Id")
            DropColumn("dbo.Items", "DefaultLocation_Id")
        End Sub
    End Class
End Namespace
