Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddForeignKeyLabIdToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Transactions", "Lab_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "Lab_Id")
            AddForeignKey("dbo.Transactions", "Lab_Id", "dbo.Laboratories", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Transactions", "Lab_Id", "dbo.Laboratories")
            DropIndex("dbo.Transactions", New String() { "Lab_Id" })
            DropColumn("dbo.Transactions", "Lab_Id")
        End Sub
    End Class
End Namespace
