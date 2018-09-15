Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddFKTypeToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.TransactionTypes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Type = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Transactions", "Type_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "Type_Id")
            AddForeignKey("dbo.Transactions", "Type_Id", "dbo.TransactionTypes", "Id")
            DropColumn("dbo.Transactions", "TypeId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "TypeId", Function(c) c.Int(nullable := False))
            DropForeignKey("dbo.Transactions", "Type_Id", "dbo.TransactionTypes")
            DropIndex("dbo.Transactions", New String() { "Type_Id" })
            DropColumn("dbo.Transactions", "Type_Id")
            DropTable("dbo.TransactionTypes")
        End Sub
    End Class
End Namespace
