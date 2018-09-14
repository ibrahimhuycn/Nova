Imports System.Data.Entity

Namespace Nova

    Public Class NovaContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("NovaConnectionString")
        End Sub

        Public Property Transections() As DbSet(Of Transections)
        Public Property Users() As DbSet(Of Users)

    End Class

End Namespace