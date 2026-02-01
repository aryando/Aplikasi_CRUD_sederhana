Imports MySql.Data.MySqlClient

Public Class Form1 ' <--- Baris ini WAJIB ada di atas

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Panggil Sub Koneksi dari ModuleDB
        Call Koneksi()

        Try
            ' Perintah untuk cek username & password
            cmd = New MySqlCommand("SELECT * FROM tbl_user WHERE username='" & txtAryando1.Text & "' AND password='" & txtAryando2.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information)

                ' --- TAMBAHAN BARU ---
                FormMenu.Show()  ' Buka menu utama
                Me.Hide()        ' Sembunyikan form login
                ' ---------------------
                Me.Hide()
            Else
                MsgBox("Username atau Password Salah!", MsgBoxStyle.Critical)
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtAryando2.TextChanged

    End Sub
End Class ' <--- Baris ini WAJIB ada di bawah (Penutup)