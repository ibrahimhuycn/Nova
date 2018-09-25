Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddUserAccessLevelsAndHashField
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Users", "AccessLevel", Function(c) c.Int(nullable := False))
            AddColumn("dbo.Users", "PasswordHash", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Users", "PasswordHash")
            DropColumn("dbo.Users", "AccessLevel")
        End Sub
    End Class
End Namespace
