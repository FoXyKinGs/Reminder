Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formReminder As New Reminder()
        formReminder.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formRegister As New Register()
        formRegister.Show()
        Me.Hide()
    End Sub
End Class
