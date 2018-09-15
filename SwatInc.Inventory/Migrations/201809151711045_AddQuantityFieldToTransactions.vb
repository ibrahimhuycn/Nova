Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddQuantityFieldToTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Transactions", "Quantity", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Transactions", "Quantity")
        End Sub
    End Class
End Namespace
