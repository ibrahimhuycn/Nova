Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddLotsTableAndRelationships
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Lots",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .ExpirationDate = c.DateTime(nullable := False),
                        .Quantity = c.Int(nullable := False),
                        .Item_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .Index(Function(t) t.Item_Id)
            
            AddColumn("dbo.Transactions", "Lot_Id", Function(c) c.String(maxLength := 128))
            CreateIndex("dbo.Transactions", "Lot_Id")
            AddForeignKey("dbo.Transactions", "Lot_Id", "dbo.Lots", "Id")
            DropColumn("dbo.Transactions", "LotId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Transactions", "LotId", Function(c) c.String())
            DropForeignKey("dbo.Transactions", "Lot_Id", "dbo.Lots")
            DropForeignKey("dbo.Lots", "Item_Id", "dbo.Items")
            DropIndex("dbo.Lots", New String() { "Item_Id" })
            DropIndex("dbo.Transactions", New String() { "Lot_Id" })
            DropColumn("dbo.Transactions", "Lot_Id")
            DropTable("dbo.Lots")
        End Sub
    End Class
End Namespace
