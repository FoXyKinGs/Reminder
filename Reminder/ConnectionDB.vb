Imports MySql.Data.MySqlClient

Module KoneksiDB
    Public Conn As MySqlConnection
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet

    ' Connection string for MySQL database
    Private connectionString As String = "server=localhost;uid=root;Database=reminder;SSLMode=none"

    ' Function to open database connection
    Public Sub OpenDB()
        Conn = New MySqlConnection(connectionString)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            ' Handle connection errors here
            MsgBox("Failed to connect to database: " & ex.Message, MsgBoxStyle.Critical, "Database Connection Error")
        End Try
    End Sub
End Module
