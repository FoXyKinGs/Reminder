Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate user input
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill out all fields.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open database connection
            Call OpenDB()

            ' Query to retrieve hashed password, user ID, and name from database based on email
            Dim storedHashedPassword As String = Nothing
            Dim storedUserId As Integer = 0
            Dim storedUserName As String = Nothing
            Dim checkEmailQuery As String = "SELECT Password, id, Name FROM tb_user WHERE Email = @Email"

            ' Create MySqlCommand to execute query
            CMD = New MySqlCommand(checkEmailQuery, Conn)
            CMD.Parameters.AddWithValue("@Email", txtEmail.Text)

            ' Execute query and retrieve hashed password, user ID, and name
            Using reader As MySqlDataReader = CMD.ExecuteReader()
                If reader.Read() Then
                    storedHashedPassword = reader("Password").ToString()
                    storedUserId = Convert.ToInt32(reader("id"))
                    storedUserName = reader("Name").ToString()
                End If
            End Using

            ' If no password hash found, show error message
            If String.IsNullOrEmpty(storedHashedPassword) Then
                MessageBox.Show("Invalid email or password.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Verify input password with stored hashed password using BCrypt
                Dim inputPassword As String = txtPassword.Text
                Dim isPasswordCorrect As Boolean = BCrypt.Net.BCrypt.Verify(inputPassword, storedHashedPassword)

                ' If password is correct, proceed with login
                If isPasswordCorrect Then
                    ' Store user ID in settings
                    My.Settings.UserID = storedUserId
                    My.Settings.Save()

                    ' Show welcome message with user's name
                    Dim result As DialogResult = MessageBox.Show($"Welcome back, {storedUserName}! You've successfully logged in.", "Login Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If result = DialogResult.OK Then
                        ' Proceed to main form
                        Me.Hide() ' Hide the login form
                        Dim mainForm As New Reminder()
                        mainForm.Show()
                    End If
                Else
                    ' Show error message if password is incorrect
                    MessageBox.Show("Invalid email or password.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            ' Show error message for any exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
