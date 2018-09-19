Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class EditPurchaseOrderTableToIncludeRequiredDate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.PurchaseOrders", "RequiredOn", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.PurchaseOrders", "Timestamp", Function(c) c.DateTime(nullable := False))
            DropColumn("dbo.PurchaseOrders", "PoDate")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.PurchaseOrders", "PoDate", Function(c) c.DateTime(nullable := False))
            DropColumn("dbo.PurchaseOrders", "Timestamp")
            DropColumn("dbo.PurchaseOrders", "RequiredOn")
        End Sub
    End Class
End Namespace
