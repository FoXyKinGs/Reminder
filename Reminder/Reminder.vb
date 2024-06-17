Public Class Reminder
    Dim upcomingEvent As Boolean = False
    Dim listEvent As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear stored user ID from settings
        My.Settings.UserID = 0
        My.Settings.Save()

        ' Show the login form again
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close() ' Close the current form (ReminderForm)
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim AddReminder As New AddReminder()
        AddReminder.Show()
        Me.Hide()
    End Sub

    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If upcomingEvent = False Then
            dgUpcomingEvent.Hide()
        End If

        If listEvent = False Then
            dgListEvent.Hide()
        End If
    End Sub
End Class