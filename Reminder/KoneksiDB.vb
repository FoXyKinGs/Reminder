Imports MySql.Data.MySqlClient

Module KoneksiDB
    Public Conn As MySqlConnection
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet

    Public Sub BukaDb()
        Dim SQLConn As String = "server=localhost;uid=root;Database=reminder;SSLMode=none"
        Conn = New MySqlConnection(SQLConn)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
