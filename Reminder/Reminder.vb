Imports System.Numerics
Imports MySql.Data.MySqlClient

Public Class Reminder
    Private greetingName As String = ""

    Private notifyIcon As NotifyIcon
    Private eventCheckTimer, userProfileTimer As Timer
    Private eventUpcomingSoon As Boolean = True
    Private Const OneMinuteInterval As Integer = 60000
    Private Const OneSecondInterval As Integer = 1000

    Public Sub New()
        InitializeComponent()

        ' Initialize NotifyIcon
        notifyIcon = New NotifyIcon()
        notifyIcon.Icon = SystemIcons.Information ' Use a system icon as a placeholder
        notifyIcon.Text = "Reminder Application"
        notifyIcon.Visible = True

        ' Initialize Timer
        eventCheckTimer = New Timer()
        eventCheckTimer.Interval = OneMinuteInterval
        AddHandler eventCheckTimer.Tick, AddressOf CheckForUpcomingEvents
        eventCheckTimer.Start()

        ' Initialize User Profile Timer
        userProfileTimer = New Timer()
        userProfileTimer.Interval = 60000 ' 1 minute
        AddHandler userProfileTimer.Tick, AddressOf LoadUserProfile
        userProfileTimer.Start()
    End Sub

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
            Dim selectRemindersQuery As String = "SELECT id, Title, Date, Note FROM tb_reminder WHERE created_by_id = @UserId ORDER BY Date DESC"
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
                dgListEvent.Columns("id").Visible = False ' Hide the id column
                dgListEvent.Columns("Title").HeaderText = "Title"
                dgListEvent.Columns("Date").HeaderText = "Date"
                dgListEvent.Columns("Note").HeaderText = "Note"
                dgListEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Show the DataGridView
                dgListEvent.Show()
                btnDeleteEvent.Show()
            Else
                ' No reminders found, hide the DataGridView
                dgListEvent.Hide()
                btnDeleteEvent.Hide()
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

    Private Sub btnDeleteEvent_Click(sender As Object, e As EventArgs) Handles btnDeleteEvent.Click
        If dgListEvent.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected event?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Dim selectedRow As DataGridViewRow = dgListEvent.SelectedRows(0)
                    Dim reminderId As Integer = selectedRow.Cells("id").Value

                    Call OpenDB()

                    ' SQL query to delete the selected reminder
                    Dim deleteQuery As String = "DELETE FROM tb_reminder WHERE id = @ReminderId"
                    CMD = New MySqlCommand(deleteQuery, Conn)
                    CMD.Parameters.AddWithValue("@ReminderId", reminderId)

                    ' Execute the delete query
                    CMD.ExecuteNonQuery()

                    MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh the DataGridView to reflect the changes
                    LoadUserProfile()
                Catch ex As Exception
                    MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Deleting Event")
                Finally
                    If Conn.State = ConnectionState.Open Then Conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select an event to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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

    Private Sub CheckForUpcomingEvents(sender As Object, e As EventArgs)
        Try
            Call OpenDB()

            ' Query to select reminders within the next 5 minutes or exactly at the current time
            Dim selectUpcomingRemindersQuery As String = "SELECT id, Title, Date, Note FROM tb_reminder WHERE created_by_id = @UserId AND Date >= NOW() AND Date <= DATE_ADD(NOW(), INTERVAL 5 MINUTE)"
            CMD = New MySqlCommand(selectUpcomingRemindersQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute query and retrieve upcoming reminders
            Dim reader As MySqlDataReader = CMD.ExecuteReader()
            While reader.Read()
                ' Display upcoming reminder details in the notification
                Dim id As Integer = reader("id")
                Dim title As String = reader("Title").ToString()
                Dim dateValue As DateTime = DateTime.Parse(reader("Date").ToString())
                Dim note As String = reader("Note").ToString()

                ' Format the upcoming reminder details
                Dim reminderDetails As String = $"Title: {title}" & vbCrLf &
                                                $"Date & Time: {dateValue.ToString("dd/MM/yyyy HH:mm")}" & vbCrLf &
                                                $"Note: {note}"

                ' Check if the user was notified 5 minutes before
                If eventUpcomingSoon Then
                    If dateValue <= DateTime.Now.AddMinutes(5) AndAlso dateValue > DateTime.Now Then
                        ' Show notification for upcoming reminder
                        notifyIcon.BalloonTipTitle = "Upcoming Reminder"
                        notifyIcon.BalloonTipText = reminderDetails
                        notifyIcon.ShowBalloonTip(3000) ' Show the balloon tip for 3 seconds

                        ' Set flag to indicate an upcoming reminder has been notified
                        eventUpcomingSoon = False

                        ' Change interval to 1 second
                        eventCheckTimer.Interval = OneSecondInterval
                        eventCheckTimer.Stop()
                        eventCheckTimer.Start()
                    End If
                Else
                    If dateValue <= DateTime.Now Then
                        ' Show notification for exact match and play sound
                        notifyIcon.BalloonTipTitle = "Reminder Alert"
                        notifyIcon.BalloonTipText = reminderDetails
                        notifyIcon.ShowBalloonTip(3000) ' Show the balloon tip for 3 seconds

                        ' Set flag to indicate no upcoming reminders within 5 minutes after this one
                        eventUpcomingSoon = True

                        ' Change interval back to 1 minute
                        eventCheckTimer.Interval = OneMinuteInterval
                        eventCheckTimer.Stop()
                        eventCheckTimer.Start()

                    End If
                End If
            End While

            LoadUserProfile() ' update the newest upcoming event

            ' Close the reader and connection
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Checking Upcoming Events")
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Me.Hide()
        Dim ChangePassword As New ChangePassword()
        ChangePassword.Show()
    End Sub
End Class
