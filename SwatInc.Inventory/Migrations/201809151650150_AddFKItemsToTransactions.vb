Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddFKItemsToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Items",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .PackSizeId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Transactions", "Items_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "Items_Id")
            AddForeignKey("dbo.Transactions", "Items_Id", "dbo.Items", "Id")
            DropColumn("dbo.Transactions", "ItemsId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "ItemsId", Function(c) c.Int(nullable := False))
            DropForeignKey("dbo.Transactions", "Items_Id", "dbo.Items")
            DropIndex("dbo.Transactions", New String() { "Items_Id" })
            DropColumn("dbo.Transactions", "Items_Id")
            DropTable("dbo.Items")
        End Sub
    End Class
End Namespace
