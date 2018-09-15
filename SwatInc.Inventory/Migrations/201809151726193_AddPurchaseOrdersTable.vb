Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddPurchaseOrdersTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.PurchaseOrders",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .PoDate = c.DateTime(nullable := False),
                        .Quantity = c.Int(nullable := False),
                        .Item_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .Index(Function(t) t.Item_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.PurchaseOrders", "Item_Id", "dbo.Items")
            DropIndex("dbo.PurchaseOrders", New String() { "Item_Id" })
            DropTable("dbo.PurchaseOrders")
        End Sub
    End Class
End Namespace
