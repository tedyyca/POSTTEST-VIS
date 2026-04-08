Public Class Form1

    ' Validasi Nama (Hanya Huruf dan Spasi)
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi ID (Hanya Angka)
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Tombol Ambil Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFotoProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' Tombol Simpan & Cetak
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ErrorProvider1.Clear()

        ' Mengumpulkan data Hobi dari CheckBox
        Dim hobi As String = ""
        If CheckBox1.Checked Then hobi &= CheckBox1.Text & ", "
        If CheckBox2.Checked Then hobi &= CheckBox2.Text & ", "
        If CheckBox3.Checked Then hobi &= CheckBox3.Text & ", "
        If CheckBox4.Checked Then hobi &= CheckBox4.Text & ", "
        If CheckBox5.Checked Then hobi &= CheckBox5.Text & ", "
        If CheckBox6.Checked Then hobi &= CheckBox6.Text & ", "
        If CheckBox7.Checked Then hobi &= CheckBox7.Text & ", "
        If CheckBox8.Checked Then hobi &= CheckBox8.Text & ", "

        ' Validasi Input Kosong (Ketentuan 1)
        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong")
        ElseIf txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "ID tidak boleh kosong")
        ElseIf pbFotoProfil.Image Is Nothing Then
            MessageBox.Show("Silakan pilih foto profil!")
        Else
            ' Memindahkan data ke Module
            MemberNama = txtNama.Text
            MemberID = txtID.Text
            MemberTglLahir = dtpTglLahir.Value.ToShortDateString()
            MemberGender = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
            MemberDivisi = cbDivisi.Text
            MemberTelp = mtbTelp.Text
            MemberEmail = txtEmail.Text
            MemberAlamat = txtAlamat.Text
            MemberFoto = pbFotoProfil.Image
            MemberHobby = hobi.TrimEnd(", ".ToCharArray())

            ' Cek Peran
            If rbKetua.Checked Then MemberPeran = "Ketua"
            If rbAnggota.Checked Then MemberPeran = "Anggota"
            If rbAdmin.Checked Then MemberPeran = "Admin"

            ' Tampilkan Form Hasil
            FormHasil.Show()
        End If
    End Sub

    ' Navigasi Menu Strip
    Private Sub KeluarMenu_Click(sender As Object, e As EventArgs) Handles KeluarMenu.Click
        Me.Close()
    End Sub

    Private Sub SimpanDataMenu_Click(sender As Object, e As EventArgs) Handles SimpanDataMenu.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim content As String = "Data Anggota JMK48" & vbCrLf & "Nama: " & txtNama.Text & vbCrLf & "ID: " & txtID.Text
            IO.File.WriteAllText(SaveFileDialog1.FileName, content)
            MessageBox.Show("Data Berhasil Disimpan!")
        End If
    End Sub
End Class