Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formLogin As New Login()
        Login.Show()
        Me.Hide()
    End Sub
End Class