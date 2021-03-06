﻿Imports SwatIncNotifications

Public Class Authenticate

    'PENDING TASKS.
    'Use SwatIncCrypto to check whether user provided password and Hash retrieved from server match.
    Dim UserCredientials As New UserInformationEnteredEventArgs

    Public Shared Event OnUserAuthenticated(ByVal sender As Object, ByVal e As UserInformationEnteredEventArgs)

    Private Event OnBeginUserAuthentication(ByVal sender As Object, ByVal e As UserInformationEnteredEventArgs)

    Function AuthenticateUser(ByVal sender As Object, ByVal e As UserInformationEnteredEventArgs) Handles Me.OnBeginUserAuthentication
        If e.Authenticated = True Then
            RaiseEvent OnUserAuthenticated(Me, UserCredientials)
        ElseIf e.UserExists = False Then
            MsgBox("Username does not exist. Enter a different username or request for new a username.", vbInformation, "User Authentication")
        Else
            MsgBox("There was an error with your Username/Password combination. Please try again.", vbInformation, "Authentication")
        End If
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

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        RaiseEvent OnBeginUserAuthentication(Me, UserCredientials)
    End Sub

    Private Sub UserAuthenticated(ByVal sender As Object, ByVal e As UserInformationEnteredEventArgs) Handles Me.OnUserAuthenticated
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

        'Check whether password was entered.
        If Password.Text = "" Or Password.Text = "Password" Then
            Password.Text = "Password"
        Else
            UserCredientials.PassPhrase = Password.Text
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
            UserCredientials.EnteredUserName = UserName.Text
        End If
    End Sub

#End Region

End Class