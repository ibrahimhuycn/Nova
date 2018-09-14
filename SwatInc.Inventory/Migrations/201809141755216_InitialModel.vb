Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialModel
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Transections",
                Function(c) New With
                    {
                        .TransectionsId = c.Int(nullable := False, identity := True),
                        .IsAccepted = c.Boolean(nullable := False),
                        .ItemsId = c.Int(nullable := False),
                        .ItemTypeId = c.Int(nullable := False),
                        .LotId = c.String(),
                        .Notes = c.String(),
                        .TransectionDate = c.DateTime(nullable := False),
                        .TypeId = c.Int(nullable := False),
                        .UserId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.TransectionsId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Transections")
        End Sub
    End Class
End Namespace
