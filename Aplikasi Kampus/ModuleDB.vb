Imports MySql.Data.MySqlClient 'untuk koneksi MySQL

Module ModuleDB
    Public conn As MySqlConnection 'untuk koneksi ke database
    Public cmd As MySqlCommand 'untuk eksekusi perintah SQL
    Public dr As MySqlDataReader 'untuk membaca data hasil query
    Public da As MySqlDataAdapter 'untuk mengisi dataset
    Public ds As DataSet 'untuk menyimpan data dalam memori

    Public strKoneksi As String = "Server=localhost;Database=db_kampus;Uid=root;"

    Public Sub Koneksi()
        Try
            conn = New MySqlConnection(strKoneksi)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Gagal Konek Database: " & ex.Message)
        End Try
    End Sub
End Module
