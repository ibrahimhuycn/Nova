Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTimeFieldToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Transactions", "Time", Function(c) c.DateTime(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Transactions", "Time")
        End Sub
    End Class
End Namespace
