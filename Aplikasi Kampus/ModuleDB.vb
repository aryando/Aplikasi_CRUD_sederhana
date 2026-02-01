Imports MySql.Data.MySqlClient

Module ModuleDB
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    ' PENTING: Ganti "PASSWORD_ANDA" dengan password yang Anda pakai di MySQL Workbench tadi.
    ' Jika di Workbench tidak pakai password, hapus tulisan PASSWORD_ANDA (biarkan setelah sama dengan kosong).
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
