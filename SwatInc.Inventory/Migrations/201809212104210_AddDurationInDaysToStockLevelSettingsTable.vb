Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddDurationInDaysToStockLevelSettingsTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.StockLevelSettings", "DurationInDays", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.StockLevelSettings", "DurationInDays")
        End Sub
    End Class
End Namespace
