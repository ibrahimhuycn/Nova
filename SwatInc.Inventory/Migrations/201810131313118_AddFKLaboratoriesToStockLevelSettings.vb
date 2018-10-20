Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations

    Partial Public Class AddFKLaboratoriesToStockLevelSettings
        Inherits DbMigration

        Public Overrides Sub Down()
            DropForeignKey("dbo.StockLevelSettings", "Laboratory_Id", "dbo.Laboratories")
            DropIndex("dbo.StockLevelSettings", New String() {"Laboratory_Id"})
            DropColumn("dbo.StockLevelSettings", "Laboratory_Id")
        End Sub

        Public Overrides Sub Up()
            AddColumn("dbo.StockLevelSettings", "Laboratory_Id", Function(c) c.Int())
            CreateIndex("dbo.StockLevelSettings", "Laboratory_Id")
            AddForeignKey("dbo.StockLevelSettings", "Laboratory_Id", "dbo.Laboratories", "Id")
        End Sub

    End Class

End Namespace