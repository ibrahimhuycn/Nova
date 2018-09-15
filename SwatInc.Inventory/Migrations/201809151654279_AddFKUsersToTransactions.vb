Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddFKUsersToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .Username = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Transactions", "User_Id", Function(c) c.Int())
            CreateIndex("dbo.Transactions", "User_Id")
            AddForeignKey("dbo.Transactions", "User_Id", "dbo.Users", "Id")
            DropColumn("dbo.Transactions", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "UserId", Function(c) c.Int(nullable := False))
            DropForeignKey("dbo.Transactions", "User_Id", "dbo.Users")
            DropIndex("dbo.Transactions", New String() { "User_Id" })
            DropColumn("dbo.Transactions", "User_Id")
            DropTable("dbo.Users")
        End Sub
    End Class
End Namespace
