Public Class NovaSplash

    Sub New()
        InitializeComponent()
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

End Class