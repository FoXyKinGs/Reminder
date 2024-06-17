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

            ' Close the reader and connection
            reader.Close()

            ' Load reminders for the user
            LoadReminders()

            ' Check and load upcoming events
            CheckAndLoadUpcomingReminders()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Loading User Profile")
        Finally
            ' Close the connection
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

    Private Sub LoadReminders()
        Try
            Call OpenDB()

            ' Query to select reminders based on UserID
            Dim selectRemindersQuery As String = "SELECT Title, Date, Note FROM tb_reminder WHERE created_by_id = @UserId ORDER BY Date DESC"
            CMD = New MySqlCommand(selectRemindersQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Create DataAdapter and DataSet
            Dim DA As New MySqlDataAdapter(CMD)
            Dim DS As New DataSet()

            ' Fill DataSet with data from DataAdapter
            DA.Fill(DS, "Reminders")

            ' Check if there are reminders
            If DS.Tables("Reminders").Rows.Count > 0 Then
                ' Bind DataSet to DataGridView dgListEvent
                dgListEvent.DataSource = DS.Tables("Reminders")

                ' Optionally, customize DataGridView appearance and behavior
                dgListEvent.Columns("Title").HeaderText = "Title"
                dgListEvent.Columns("Date").HeaderText = "Date"
                dgListEvent.Columns("Note").HeaderText = "Note"
                dgListEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Show the DataGridView
                dgListEvent.Show()
            Else
                ' No reminders found, hide the DataGridView
                dgListEvent.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Loading Reminders")
        Finally
            ' Close the connection
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub


    Private Sub CheckAndLoadUpcomingReminders()
        Try
            Call OpenDB()

            ' Query to select upcoming reminders based on current device time
            Dim selectUpcomingRemindersQuery As String = "SELECT Title, Date, Note FROM tb_reminder WHERE created_by_id = @UserId AND Date >= NOW() ORDER BY Date ASC LIMIT 1"
            CMD = New MySqlCommand(selectUpcomingRemindersQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute query and retrieve upcoming reminders
            Dim reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                ' Display upcoming reminder details in the label
                Dim title As String = reader("Title").ToString()
                Dim dateValue As DateTime = DateTime.Parse(reader("Date").ToString())
                Dim note As String = reader("Note").ToString()

                ' Format the upcoming reminder details
                txtTitle.Text = title
                txtTime.Text = dateValue.ToString("dd/MM/yyyy HH:mm")
                txtNote.Text = note

                ' Hide the stateNoUpcoming label since there is an upcoming reminder
                stateNoUpcoming.Hide()
            Else
                ' No upcoming reminders found, show the stateNoUpcoming label
                stateNoUpcoming.Show()
            End If

            ' Close the reader and connection
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Loading Upcoming Reminders")
        Finally
            ' Close the connection
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
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
