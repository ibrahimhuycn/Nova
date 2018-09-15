Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddLocationsTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Locations",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Location = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Locations")
        End Sub
    End Class
End Namespace
