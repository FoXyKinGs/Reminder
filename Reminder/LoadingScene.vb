Imports MySql.Data.MySqlClient

Public Class LoadingScene
    Private Sub LoadingScene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the progress bar
        pbLoading.Value = 0

        ' Check if a user ID is stored in settings
        Dim storedUserId As Integer = My.Settings.UserID
        pbLoading.Value = 20 ' Update progress bar

        If storedUserId <> 0 Then
            ' Check if the stored user ID exists in the database
            pbLoading.Value = 40 ' Update progress bar
            If CheckUserExists(storedUserId) Then
                ' User exists, proceed to main form after a delay
                pbLoading.Value = 60 ' Update progress bar
                Dim delayTimer As New Timer()
                delayTimer.Interval = 3000

                ' Event handler for the delay timer
                AddHandler delayTimer.Tick, Sub()
                                                ' Stop the timer
                                                delayTimer.Stop()

                                                ' Update progress bar
                                                pbLoading.Value = 80

                                                ' Close the current form (LoadingScene)
                                                Me.Hide()

                                                ' Show the main form (Reminder)
                                                Dim mainForm As New Reminder()
                                                mainForm.Show()

                                                ' Update progress bar
                                                pbLoading.Value = 100
                                            End Sub

                ' Start the delay timer
                delayTimer.Start()

                ' Exit the Load event handler
                Return
            Else
                ' User does not exist or invalid, clear stored user ID
                My.Settings.UserID = 0
                My.Settings.Save()
            End If
        End If

        ' If no stored user ID or user not found, show the login form after a delay
        pbLoading.Value = 60 ' Update progress bar
        Dim delayTimer2 As New Timer()
        delayTimer2.Interval = 3000

        ' Event handler for the delay timer
        AddHandler delayTimer2.Tick, Sub()
                                         ' Stop the timer
                                         delayTimer2.Stop()

                                         ' Update progress bar
                                         pbLoading.Value = 80

                                         ' Close the current form (LoadingScene)
                                         Me.Hide()

                                         ' Show the login form
                                         Dim loginForm As New Login()
                                         loginForm.Show()

                                         ' Update progress bar
                                         pbLoading.Value = 100
                                     End Sub

        ' Start the delay timer
        delayTimer2.Start()
    End Sub

    Private Function CheckUserExists(userId As Integer) As Boolean
        ' Function to check if user exists in the database
        Dim userExists As Boolean = False

        Try
            Call OpenDB()

            ' Query to check if user exists based on user ID
            Dim checkUserQuery As String = "SELECT COUNT(*) FROM tb_user WHERE id = @UserId"
            CMD = New MySqlCommand(checkUserQuery, Conn)
            CMD.Parameters.AddWithValue("@UserId", userId)

            ' Execute query and check if user exists
            Dim count As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            If count > 0 Then
                userExists = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Error")
        Finally
            Conn.Close()
        End Try

        Return userExists
    End Function
End Class
