Imports BCrypt.Net
Imports MySql.Data.MySqlClient

Public Class Register
    Public Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim formLogin As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtName.Text = "" Or txtEmail.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("The form cannot be empty. Fill out the entire form.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Your password doesn't match.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Call OpenDB()

                    Dim checkEmail = "SELECT COUNT(*) FROM tb_user WHERE Email = @Email"
                    CMD = New MySqlCommand(checkEmail, Conn)
                    CMD.Parameters.AddWithValue("@Email", txtEmail.Text)
                    Dim emailCount As Integer = Convert.ToInt32(CMD.ExecuteScalar())

                    If emailCount > 0 Then
                        MessageBox.Show("This email is already in use. Please use a different email.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim send = "INSERT INTO tb_user (Name, Email, Password) VALUES (@Name, @Email, @Password)"
                        CMD = New MySqlCommand(send, Conn)
                        CMD.Parameters.AddWithValue("@Name", txtName.Text)
                        CMD.Parameters.AddWithValue("@Email", txtEmail.Text)
                        CMD.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text))
                        CMD.ExecuteNonQuery()

                        Dim result As DialogResult = MessageBox.Show("Your account has been successfully created.", "Account Created Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If result = DialogResult.OK Then
                            Me.Hide()
                            Dim loginForm As New Login()
                            loginForm.Show()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "There's an error")
                End Try
            End If
        End If

    End Sub
End Class