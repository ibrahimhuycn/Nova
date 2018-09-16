Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddPackSizesTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.PackSizes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Size = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Items", "PackSize_Id", Function(c) c.Int())
            CreateIndex("dbo.Items", "PackSize_Id")
            AddForeignKey("dbo.Items", "PackSize_Id", "dbo.PackSizes", "Id")
            DropColumn("dbo.Items", "PackSizeId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Items", "PackSizeId", Function(c) c.Int(nullable := False))
            DropForeignKey("dbo.Items", "PackSize_Id", "dbo.PackSizes")
            DropIndex("dbo.Items", New String() { "PackSize_Id" })
            DropColumn("dbo.Items", "PackSize_Id")
            DropTable("dbo.PackSizes")
        End Sub
    End Class
End Namespace
