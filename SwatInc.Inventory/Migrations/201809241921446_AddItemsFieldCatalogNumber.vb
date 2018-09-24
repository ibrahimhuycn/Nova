Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddItemsFieldCatalogNumber
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Items", "CatalogNumber", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Items", "CatalogNumber")
        End Sub
    End Class
End Namespace
