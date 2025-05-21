Public Class splPrincipal

    Private Sub splPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temsplPrincipal.Interval = 10000
        temsplPrincipal.Start()
        lbcVersion.Text = "Versión: " + My.Application.Info.Version.ToString

       
    End Sub

    Private Sub temsplPrincipal_Tick(sender As Object, e As EventArgs) Handles temsplPrincipal.Tick
        If temsplPrincipal.Interval = 10000 Then
            temsplPrincipal.Stop()
        End If
    End Sub

End Class