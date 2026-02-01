Imports MySql.Data.MySqlClient

Public Class FormDosen

    ' 1. Subrutin Tampil Data (Agar data muncul di tabel)
    Sub TampilData()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tbl_dosen", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_dosen")
        dgvDosen.DataSource = ds.Tables("tbl_dosen")
    End Sub

    ' 2. Subrutin Bersih (Mengosongkan Text Box)
    Sub Bersih()
        txtAryando3.Clear()
        txtAryando4.Clear()
        txtAryando5.Clear()
        txtAryando6.Clear()
        cbGender.Text = ""
        dtpLahir.Value = Now
        txtAryando3.Focus()
    End Sub

    ' 3. Saat Form Dosen Pertama Kali Muncul
    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Bersih()
        ' Mengisi pilihan ComboBox Gender otomatis
        If cbGender.Items.Count = 0 Then
            cbGender.Items.Add("Laki-laki")
            cbGender.Items.Add("Perempuan")
        End If
    End Sub

    ' ================= TOMBOL SIMPAN (CREATE) =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Cek agar tidak kosong
        If txtAryando3.Text = "" Or txtAryando4.Text = "" Then
            MsgBox("Data NIDN dan Nama wajib diisi!")
            Exit Sub
        End If

        Call Koneksi()
        ' Perintah SQL Insert
        Dim query As String = "INSERT INTO tbl_dosen VALUES ('" & txtAryando3.Text & "', '" & txtAryando4.Text & "', '" & Format(dtpLahir.Value, "yyyy-MM-dd") & "', '" & cbGender.Text & "', '" & txtAryando5.Text & "', '" & txtAryando6.Text & "')"
        cmd = New MySqlCommand(query, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            TampilData() ' Refresh tabel
            Bersih()     ' Kosongkan form
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    ' ================= TOMBOL EDIT (UPDATE) =================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtAryando3.Text = "" Then
            MsgBox("Pilih data yang akan diedit dari tabel dulu")
            Exit Sub
        End If

        Call Koneksi()
        ' Perintah SQL Update
        Dim query As String = "UPDATE tbl_dosen SET nama_dosen='" & txtAryando4.Text & "', tgl_lahir='" & Format(dtpLahir.Value, "yyyy-MM-dd") & "', jenis_kelamin='" & cbGender.Text & "', gaji_pokok='" & txtAryando5.Text & "', alamat='" & txtAryando6.Text & "' WHERE nidn='" & txtAryando3.Text & "'"
        cmd = New MySqlCommand(query, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")
            TampilData()
            Bersih()
        Catch ex As Exception
            MsgBox("Gagal Edit: " & ex.Message)
        End Try
    End Sub

    ' ================= TOMBOL HAPUS (DELETE) =================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtAryando3.Text = "" Then
            MsgBox("Pilih data yang akan dihapus")
            Exit Sub
        End If

        If MsgBox("Yakin ingin menghapus NIDN " & txtAryando3.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Koneksi()
            Dim query As String = "DELETE FROM tbl_dosen WHERE nidn='" & txtAryando3.Text & "'"
            cmd = New MySqlCommand(query, conn)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
                TampilData()
                Bersih()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' ================= TOMBOL BATAL =================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' ================= KLIK TABEL (Pindahkan data ke TextBox) =================
    Private Sub dgvDosen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDosen.CellClick
        Try
            Dim row As DataGridViewRow = dgvDosen.Rows(e.RowIndex)
            txtAryando3.Text = row.Cells(0).Value.ToString
            txtAryando4.Text = row.Cells(1).Value.ToString
            dtpLahir.Value = row.Cells(2).Value
            cbGender.Text = row.Cells(3).Value.ToString
            txtAryando5.Text = row.Cells(4).Value.ToString
            txtAryando6.Text = row.Cells(5).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

End Class