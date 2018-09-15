Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddStockLevelSettingsTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.StockLevelSettings",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Maximum = c.Int(nullable := False),
                        .Minimum = c.Int(nullable := False),
                        .Item_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .Index(Function(t) t.Item_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.StockLevelSettings", "Item_Id", "dbo.Items")
            DropIndex("dbo.StockLevelSettings", New String() { "Item_Id" })
            DropTable("dbo.StockLevelSettings")
        End Sub
    End Class
End Namespace
