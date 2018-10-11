Imports SwatInc.Inventory.Nova

Public Class AuthenticationEventArgs

    Inherits EventArgs
    Public dbContext As NovaContext = New NovaContext()
    Public Property AccessLevel As UserAccessLevel
    Public Property Designation As String
    Public Property FullName As String
    Public Property UserName As String
End Class