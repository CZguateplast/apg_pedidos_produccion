Public Class splCargando

    Private Sub splEsperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub splEsperar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        For i = 0 To 10000
            Application.DoEvents()
            lbcCargando.Items.Add("AR01020" + i.ToString)
            lbcCargando.TopIndex = lbcCargando.Items.Count - 1
        Next
        Me.Close()
    End Sub
End Class