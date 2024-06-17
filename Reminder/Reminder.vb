Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Reminder
    Private greetingName As String = ""

    Private Sub LoadUserProfile()
        Try
            Call OpenDB()

            ' Query to select user details based on UserID
            Dim selectUserQuery As String = "SELECT Name, Nickname, Email FROM tb_user WHERE id = @UserId"
            CMD = New MySqlCommand(selectUserQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute query and retrieve user details
            Dim reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                ' Assign retrieved values to TextBoxes
                greetingName = reader("Name").ToString()
                Dim userName As String = reader("Name").ToString()
                Dim nickname As String = reader("Nickname").ToString()
                If Not String.IsNullOrEmpty(nickname) Then
                    greetingName = nickname
                End If
                txtName.Text = userName
                txtNickname.Text = nickname
                txtEmail.Text = reader("Email").ToString()

                ' Update greeting label with user's name
                UpdateGreeting(greetingName)
            Else
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Loading User Profile")
        Finally
            ' Close the reader and connection
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub UpdateGreeting(greetingName As String)
        ' Determine time of day
        Dim timeOfDay As String = ""
        Dim hour As Integer = DateTime.Now.Hour

        If hour >= 5 AndAlso hour < 12 Then
            timeOfDay = "Morning"
        ElseIf hour >= 12 AndAlso hour < 18 Then
            timeOfDay = "Afternoon"
        ElseIf hour >= 18 OrElse hour < 5 Then
            timeOfDay = "Evening"
        End If

        ' Update greeting label
        lblGreeting.Text = $"Good {timeOfDay}. Welcome back, {greetingName}!"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Clear stored user ID from settings
            My.Settings.UserID = 0
            My.Settings.Save()

            ' Show the login form again
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close() ' Close the current form (ReminderForm)
        End If
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addReminderForm As New AddReminder()
        addReminderForm.Show()
        Me.Hide()
    End Sub

    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()

        ' Set initial greeting based on current time
        UpdateGreeting(greetingName)
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        Dim saveChanges = MessageBox.Show("Save Changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If saveChanges = DialogResult.Yes Then
            Try
                Call OpenDB()

                ' Query to update user details based on UserID
                Dim updateQuery As String = "UPDATE tb_user SET Name = @Name, Nickname = @Nickname WHERE id = @UserId"
                CMD = New MySqlCommand(updateQuery, Conn)
                CMD.Parameters.AddWithValue("@Name", txtName.Text)
                CMD.Parameters.AddWithValue("@Nickname", txtNickname.Text)
                CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

                ' Execute the update query
                CMD.ExecuteNonQuery()

                Dim confirm = MessageBox.Show("Profile saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If confirm = DialogResult.OK Then
                    LoadUserProfile()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Saving Profile")
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Me.Hide()
        Dim ChangePassword As New changePassword()
        ChangePassword.Show()
    End Sub
End Class
