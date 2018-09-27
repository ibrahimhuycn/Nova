Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddColumnTypeToItemTypes
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Items", "Type_Id", Function(c) c.Int())
            CreateIndex("dbo.Items", "Type_Id")
            AddForeignKey("dbo.Items", "Type_Id", "dbo.ItemTypes", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Items", "Type_Id", "dbo.ItemTypes")
            DropIndex("dbo.Items", New String() { "Type_Id" })
            DropColumn("dbo.Items", "Type_Id")
        End Sub
    End Class
End Namespace
