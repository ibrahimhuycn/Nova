Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddColumnDesignationToUsersTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Users", "Designation", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Users", "Designation")
        End Sub
    End Class
End Namespace
