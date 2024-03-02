Imports MySql.Data.MySqlClient
Module Module1

    Public cn As New MySqlConnection
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand

    Public sql As String
    Public newLine As ListViewItem

    Public Sub dbconn()
        Try
            'cn.ConnectionString = "server=172.16.11.195;database=yaba;username=yaba;password=root;port=3306"
            cn.ConnectionString = "server=localhost;database=veterinary;username=root;password=root;port=3306"
            cn.Open()

        Catch ex As Exception
            MsgBox("Error occured while accessing the database!" & vbNewLine & "Error Message: " & ex.Message, vbCritical)
        End Try
    End Sub
End Module
