Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTableLaboratory
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Laboratories",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Laboratories")
        End Sub
    End Class
End Namespace
