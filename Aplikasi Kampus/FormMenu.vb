Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMasterToolStripMenuItem.Click

    End Sub

    Private Sub DataDosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDosenToolStripMenuItem.Click
        FormDosen.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.Hide()


        Form1.Show()


        Form1.txtAryando1.Clear()
        Form1.txtAryando2.Clear()
        Form1.txtAryando1.Focus()
    End Sub


    Private Sub KeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeToolStripMenuItem.Click
        If MsgBox("Yakin ingin menutup aplikasi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class