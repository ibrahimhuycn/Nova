Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddItemTypesTableAndRelationships
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ItemTypes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Type = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Transactions", "ItemType_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "ItemType_Id")
            AddForeignKey("dbo.Transactions", "ItemType_Id", "dbo.ItemTypes", "Id")
            DropColumn("dbo.Transactions", "ItemTypeId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "ItemTypeId", Function(c) c.Int(nullable := False))
            DropForeignKey("dbo.Transactions", "ItemType_Id", "dbo.ItemTypes")
            DropIndex("dbo.Transactions", New String() { "ItemType_Id" })
            DropColumn("dbo.Transactions", "ItemType_Id")
            DropTable("dbo.ItemTypes")
        End Sub
    End Class
End Namespace
