Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations

    Partial Public Class AddCurrentStockLevelsTable
        Inherits DbMigration

        Public Overrides Sub Down()
            DropForeignKey("dbo.CurrentStockLevels", "Item_Id", "dbo.Items")
            DropIndex("dbo.CurrentStockLevels", New String() {"Item_Id"})
            DropTable("dbo.CurrentStockLevels")
        End Sub

        Public Overrides Sub Up()
            CreateTable(
                "dbo.CurrentStockLevels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable:=False, identity:=True),
                        .Present = c.Int(nullable:=False),
                        .Item_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .Index(Function(t) t.Item_Id)

        End Sub

    End Class

End Namespace