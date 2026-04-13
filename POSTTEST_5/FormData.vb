Public Class FormData
    Public ModeForm As String

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        If ModeForm = "Lihat" Then
            btnProses.Visible = False
        Else
            btnProses.Visible = True
            btnProses.Text = ModeForm
        End If
    End Sub

    Private Sub Tampil()
        dgvSepatu.DataSource = GetAllSepatu()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dgvSepatu.DataSource = SearchSepatu(txtCari.Text.Trim())
    End Sub

    Private Sub dgvSepatu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSepatu.CellClick
        If e.RowIndex >= 0 Then
            ' Baris terpilih secara otomatis menjadi CurrentRow
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs)
        If dgvSepatu.CurrentRow Is Nothing OrElse dgvSepatu.CurrentRow.Index < 0 Then
            MessageBox.Show("Pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id = dgvSepatu.CurrentRow.Cells(0).Value.ToString

        If ModeForm = "Edit" Then
            FormInput.isEdit = True
            FormInput.IDTerpilih = id
            FormInput.ShowDialog()
            Tampil()
        ElseIf ModeForm = "Hapus" Then
            Dim hasil = MessageBox.Show("Apakah data " & id & " ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If hasil = DialogResult.Yes Then
                If HapusSepatu(id) Then
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Tampil()
                End If
            End If
        End If
    End Sub
End Class