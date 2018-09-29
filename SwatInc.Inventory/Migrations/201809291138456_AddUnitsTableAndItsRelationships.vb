Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddUnitsTableAndItsRelationships
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Units",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Unit = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Items", "Unit_Id", Function(c) c.Int())
            CreateIndex("dbo.Items", "Unit_Id")
            AddForeignKey("dbo.Items", "Unit_Id", "dbo.Units", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Items", "Unit_Id", "dbo.Units")
            DropIndex("dbo.Items", New String() { "Unit_Id" })
            DropColumn("dbo.Items", "Unit_Id")
            DropTable("dbo.Units")
        End Sub
    End Class
End Namespace
