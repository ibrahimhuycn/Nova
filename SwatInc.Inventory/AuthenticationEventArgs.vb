Imports SwatInc.Inventory.Nova

Public Class AuthenticationEventArgs
    Inherits EventArgs
    Public Property AccessLevel As UserAccessLevel
    Public Property AuthenticatedUserName As String
    Public Property Designation As String
    Public Property FullName As String
End Class