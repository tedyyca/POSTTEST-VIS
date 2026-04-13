Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyiapkan tabel data saat aplikasi pertama kali dijalankan
        InisialisasiData()
        Me.Text = "Sistem Manajemen Sepatu Running"
    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.Click
        FormInput.isEdit = False
        FormInput.ShowDialog()
    End Sub

    Private Sub LihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataToolStripMenuItem.Click
        FormData.ModeForm = "Lihat"
        FormData.ShowDialog()
    End Sub

    Private Sub EditDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataToolStripMenuItem.Click
        FormData.ModeForm = "Edit"
        FormData.ShowDialog()
    End Sub

    Private Sub HapusDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataToolStripMenuItem.Click
        FormData.ModeForm = "Hapus"
        FormData.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class