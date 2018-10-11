Imports SwatIncNotifications

Public Class Authenticate
    'PENDING TASKS.
    'Use SwatIncCrypto to check whether user provided password and Hash retrieved from server match.

    Dim isPasswordEntered As Boolean
    Dim isUserAuthenticated As Boolean

    Dim UserCredientials As New AuthenticationEventArgs

    Public Shared Event OnBeginUserAuthentication(ByVal sender As Object, ByVal e As AuthenticationEventArgs)

    Public Shared Event OnUserAuthenticated(ByVal sender As Object, ByVal e As AuthenticationEventArgs)

    Public Shared Event OnUserInformationEntered(ByVal sender As Object, ByVal e As UserInformationEnteredEventArgs)

    Function AuthenticateUser()

        'Todo: USERNAME SHOULD BE AN INDEXED UNIQUE FIELD IN DB
        'After authentication
        isUserAuthenticated = True
        Return isUserAuthenticated
    End Function

    Private Sub Authenticate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'CENTER LOGIN FORM ONTO THE PARENT FORM, FormLisMini
        ParentCenter()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        On Error Resume Next
        Application.Exit()
        Environment.Exit(1)
    End Sub

    Private Sub GetherUserEnteredData(ByVal sender As Object, ByVal e As EventArgs) Handles Me.OnUserInformationEntered

    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click

        RaiseEvent OnBeginUserAuthentication(Me, UserCredientials)
        If isUserAuthenticated = True Then
            'Enabling Parent ribbon
            NovaUI.EnableRibbon(True)
            Dim notify As New Notification
            notify.ShowNotification(NotificationMessage:="User authenticated successfully!",
                NotificationTitle:="Authentication",
                NotficationPNG_IconName:="GreenTick",
                Heading:="Welcome USERNAME")
            'Notification.Show()
            Close()
            Dispose()
        End If
    End Sub

#Region "User Interface Setup"

    Public Sub ParentCenter()
        Dim ParentWidth As Single = (NovaUI.ClientSize.Width - Width) / 2
        Dim ParentHeight As Single = ((NovaUI.ClientSize.Height - Height) / 2) - 100
        SetBounds(ParentWidth, ParentHeight, Width, Height)
        MdiParent = NovaUI
    End Sub

    Private Sub Password_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Password.GotFocus
        'Clearing password field of default text

        If Password.Text = "Password" Then
            Password.Text = ""
        Else
            Password.SelectAll()

        End If
    End Sub

    Private Sub Password_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Password.LostFocus
        'Initialize IS_PASSWORD_ENTERED variable
        isPasswordEntered = False

        'Check whether password was entered.
        If Password.Text = "" Or Password.Text = "Password" Then
            isPasswordEntered = False
            Password.Text = "Password"
        Else
            isPasswordEntered = True
        End If

    End Sub

    Private Sub UserName_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles UserName.GotFocus
        'Clearing default text on GotFocus
        If UserName.Text = "Username" Then
            UserName.Text = ""
        Else
            UserName.SelectAll()
        End If

    End Sub

    Private Sub UserName_LostFocus(sender As Object, e As EventArgs) Handles UserName.LostFocus
        '1) Giving feedback on whether username was entered.
        '2) Setting default text if field is empty on lost focus.

        If UserName.Text = "" Or UserName.Text = "Username" Then
            UserName.Text = "Username"
        Else
            RaiseEvent OnUserInformationEntered(Me, New UserInformationEnteredEventArgs With {.EnteredUserName = UserName.Text})
        End If
    End Sub

#End Region

End Class