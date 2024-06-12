Public Class Reminder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formLogin As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim AddReminder As New AddReminder()
        AddReminder.Show()
        Me.Hide()
    End Sub
End Class