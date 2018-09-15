Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations

    Partial Public Class AddTransactionTable
        Inherits DbMigration

        Public Overrides Sub Down()
            DropTable("dbo.Transactions")
        End Sub

        Public Overrides Sub Up()
            CreateTable(
                "dbo.Transactions",
                Function(c) New With
                    {
                        .Id = c.Int(nullable:=False, identity:=True),
                        .IsAccepted = c.Boolean(nullable:=False),
                        .ItemsId = c.Int(nullable:=False),
                        .ItemTypeId = c.Int(nullable:=False),
                        .LotId = c.String(),
                        .Notes = c.String(),
                        .TransectionDate = c.DateTime(nullable:=False),
                        .TypeId = c.Int(nullable:=False),
                        .UserId = c.Int(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id)

        End Sub

    End Class

End Namespace