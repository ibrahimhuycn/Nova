Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DroppedItemTypeFromTransections
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Transactions", "ItemType_Id", "dbo.ItemTypes")
            DropIndex("dbo.Transactions", New String() { "ItemType_Id" })
            DropColumn("dbo.Transactions", "ItemType_Id")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "ItemType_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "ItemType_Id")
            AddForeignKey("dbo.Transactions", "ItemType_Id", "dbo.ItemTypes", "Id")
        End Sub
    End Class
End Namespace
