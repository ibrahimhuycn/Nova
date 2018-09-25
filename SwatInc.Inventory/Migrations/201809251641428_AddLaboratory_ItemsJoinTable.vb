Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddLaboratory_ItemsJoinTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Laboratory_Items",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Item_Id = c.Int(),
                        .Laboratory_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Items", Function(t) t.Item_Id) _
                .ForeignKey("dbo.Laboratories", Function(t) t.Laboratory_Id) _
                .Index(Function(t) t.Item_Id) _
                .Index(Function(t) t.Laboratory_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Laboratory_Items", "Laboratory_Id", "dbo.Laboratories")
            DropForeignKey("dbo.Laboratory_Items", "Item_Id", "dbo.Items")
            DropIndex("dbo.Laboratory_Items", New String() { "Laboratory_Id" })
            DropIndex("dbo.Laboratory_Items", New String() { "Item_Id" })
            DropTable("dbo.Laboratory_Items")
        End Sub
    End Class
End Namespace
