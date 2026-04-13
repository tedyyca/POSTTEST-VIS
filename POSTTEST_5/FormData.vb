Public Class FormData
    Public ModeForm As String

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menghubungkan tabel data ke DataGridView
        dgvSepatu.DataSource = dtSepatu

        ' Mengatur tampilan tombol berdasarkan pilihan menu
        If ModeForm = "Lihat" Then
            btnProses.Visible = False
        Else
            btnProses.Visible = True
            btnProses.Text = ModeForm
        End If
    End Sub

    ' Fitur Mencari Data Sepatu
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ' Menyaring data berdasarkan Merk yang diketikkan pada txtCari
        dtSepatu.DefaultView.RowFilter = String.Format("Merk LIKE '%{0}%'", txtCari.Text)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        ' Memastikan ada baris yang dipilih di tabel
        If dgvSepatu.CurrentRow Is Nothing Then Return

        If ModeForm = "Edit" Then
            ' Membuka form input dengan membawa data lama untuk diupdate
            FormInput.isEdit = True
            FormInput.IDLama = dgvSepatu.CurrentRow.Cells(0).Value.ToString()
            FormInput.ShowDialog()
            Me.Close()
        ElseIf ModeForm = "Hapus" Then
            ' Konfirmasi penghapusan data
            Dim hasil As DialogResult = MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If hasil = DialogResult.Yes Then
                dgvSepatu.Rows.Remove(dgvSepatu.CurrentRow)
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class