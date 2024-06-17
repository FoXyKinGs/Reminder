Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class ChangePassword

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' Validate input
        If txtOldPassword.Text = "" OrElse txtNewPassword.Text = "" OrElse txtConfirmNewPassword.Text = "" Then
            MessageBox.Show("Please fill out all fields.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm action with the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change your password?", "Confirm Password Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Check if new password and confirm new password match
            If txtNewPassword.Text <> txtConfirmNewPassword.Text Then
                MessageBox.Show("New password and confirm password do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if old password matches the current password in the database
            If CheckOldPassword() Then
                ' Update password
                UpdatePassword()
            Else
                MessageBox.Show("Incorrect old password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function CheckOldPassword() As Boolean
        Dim passwordMatch As Boolean = False

        Try
            Call OpenDB()

            ' Query to retrieve hashed password from the database based on UserID
            Dim selectPasswordQuery As String = "SELECT Password FROM tb_user WHERE id = @UserId"
            CMD = New MySqlCommand(selectPasswordQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute query and retrieve hashed password
            Dim storedHashedPassword As String = CMD.ExecuteScalar().ToString()

            ' Verify old password using BCrypt
            Dim oldPassword As String = txtOldPassword.Text
            passwordMatch = BCrypt.Net.BCrypt.Verify(oldPassword, storedHashedPassword)

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Checking Password")
        Finally
            Conn.Close()
        End Try

        Return passwordMatch
    End Function

    Private Sub UpdatePassword()
        Try
            Call OpenDB()

            ' Hash the new password using BCrypt
            Dim newPassword As String = txtNewPassword.Text
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword)

            ' Update query to change the password in the database
            Dim updatePasswordQuery As String = "UPDATE tb_user SET Password = @Password WHERE id = @UserId"
            CMD = New MySqlCommand(updatePasswordQuery, Conn)
            CMD.Parameters.AddWithValue("@Password", hashedPassword)
            CMD.Parameters.AddWithValue("@UserId", My.Settings.UserID)

            ' Execute the update query
            CMD.ExecuteNonQuery()

            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear password fields
            txtOldPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmNewPassword.Clear()

            ' Close the change password form
            Me.Hide()
            Dim MainForm As New Reminder()
            MainForm.Show()
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error Updating Password")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim MainForm As New Reminder()
        MainForm.Show()
    End Sub
End Class
