Imports MySql.Data.MySqlClient

Public Class AddReminder
    Public Sub ClearForm()
        dtpDate.MinDate = DateTime.Now
        dtpTime.MinDate = DateTime.Now

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
            MessageBox.Show("Fulfiled all the form, Thanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Call OpenDB()
                Dim send = "INSERT INTO tb_reminder (Title, Date, Note) VALUES (@Title, @Date, @Note)"
                CMD = New MySqlCommand(send, Conn)
                CMD.Parameters.AddWithValue("@Title", txtTitle.Text)
                Dim dateTimeValue As DateTime = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay)
                CMD.Parameters.AddWithValue("@Date", dateTimeValue)
                CMD.Parameters.AddWithValue("@Note", txtbNote.Text)
                CMD.ExecuteNonQuery()
                Call ClearForm()
                MessageBox.Show("Reminder Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "There's an error")
            End Try
        End If
    End Sub
End Class