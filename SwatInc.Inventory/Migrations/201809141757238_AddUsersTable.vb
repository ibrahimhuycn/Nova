Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddUsersTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UsersId = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .Username = c.String()
                    }) _
                .PrimaryKey(Function(t) t.UsersId)
            
            AddColumn("dbo.Transections", "UsersId", Function(c) c.Int(nullable := False))
            DropColumn("dbo.Transections", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transections", "UserId", Function(c) c.Int(nullable := False))
            DropColumn("dbo.Transections", "UsersId")
            DropTable("dbo.Users")
        End Sub
    End Class
End Namespace
