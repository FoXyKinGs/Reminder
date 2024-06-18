Imports MySql.Data.MySqlClient
Public Class AddReminder
    Inherits BaseForm

    Private notifyIcon As NotifyIcon
    Private eventCheckTimer As Timer

    Public Sub New()
        InitializeComponent()

        ' Initialize NotifyIcon
        notifyIcon = New NotifyIcon()
        notifyIcon.Icon = SystemIcons.Information
        notifyIcon.Text = "Reminder Application"
        notifyIcon.Visible = True

    End Sub

    Public Sub ClearForm()
        dtpDate.MinDate = DateTime.Now

        txtTitle.Text = ""
        txtbNote.Text = ""
    End Sub

    Private Sub AddReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearForm()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Reminder As New Reminder()
        Reminder.Show()
        Me.Close()
    End Sub

    Private Sub btnAddReminder_Click(sender As Object, e As EventArgs) Handles btnAddReminder.Click
        If txtTitle.Text = "" Or txtbNote.Text = "" Then
            MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Call OpenDB()

                ' SQL query to insert reminder with user ID
                Dim send As String = "INSERT INTO tb_reminder (Title, Date, Note, created_by_id) VALUES (@Title, @Date, @Note, @CreatedBy)"
                CMD = New MySqlCommand(send, Conn)
                CMD.Parameters.AddWithValue("@Title", txtTitle.Text)
                Dim dateTimeValue As DateTime = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay)
                CMD.Parameters.AddWithValue("@Date", dateTimeValue)
                CMD.Parameters.AddWithValue("@Note", txtbNote.Text)
                CMD.Parameters.AddWithValue("@CreatedBy", My.Settings.UserID)

                CMD.ExecuteNonQuery()

                MessageBox.Show("Reminder Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Get user name or nickname
                Dim userNameOrNickname As String = GetUserNameOrNickname()

                ' Format reminder details for notification
                Dim reminderDetails As String = $"Title: {txtTitle.Text}" & vbCrLf &
                                                $"Date & Time: {dateTimeValue.ToString("dd/MM/yyyy HH:mm")}" & vbCrLf &
                                                $"Note: {txtbNote.Text}"

                ' Show notification
                notifyIcon.BalloonTipTitle = "Reminder Added"
                notifyIcon.BalloonTipText = $"{userNameOrNickname}, your reminder has been successfully added." & vbCrLf & reminderDetails
                notifyIcon.ShowBalloonTip(3000) ' Show the balloon tip for 3 seconds
                Call ClearForm()
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error")
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Function GetUserNameOrNickname() As String
        Dim userNameOrNickname As String = ""

        Try
            Call OpenDB()

            ' Query to select user's name and nickname
            Dim selectUserQuery As String = "SELECT Name, Nickname FROM tb_user WHERE id = @UserId"
            CMD = New MySqlCommand(selectUserQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute query and retrieve user's name and nickname
            Dim reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                Dim name As String = reader("Name").ToString()
                Dim nickname As String = reader("Nickname").ToString()
                userNameOrNickname = If(String.IsNullOrEmpty(nickname), name, nickname)
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error")
        Finally
            Conn.Close()
        End Try

        Return userNameOrNickname
    End Function
End Class
