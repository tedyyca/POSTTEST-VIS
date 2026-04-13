Public Class FormInput
    Public isEdit As Boolean = False
    Public IDLama As String = ""

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan item merk ke ComboBox jika masih kosong
        If cbMerk.Items.Count = 0 Then
            cbMerk.Items.AddRange(New String() {"Ortus", "Adidas", "Specs", "Nineten", "Nike"})
        End If

        If isEdit Then
            ' Mengisi form dengan data yang sudah ada untuk diedit
            Dim row As DataRow = dtSepatu.Select("ID = '" & IDLama & "'")(0)
            txtID.Text = row("ID")
            cbMerk.Text = row("Merk")
            mtbUkuran.Text = row("Ukuran")
            txtStok.Text = row("Stok")
        Else
            ' Mengosongkan form untuk data baru
            txtID.Clear() : txtStok.Clear() : mtbUkuran.Clear()
            cbMerk.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Membersihkan tanda error sebelumnya
        ErrorProvider1.Clear()

        ' Validasi sederhana: ID tidak boleh kosong
        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "ID wajib diisi")
            Return
        End If

        If isEdit Then
            ' Menyimpan perubahan pada data yang sudah ada
            Dim row As DataRow = dtSepatu.Select("ID = '" & IDLama & "'")(0)
            row("ID") = txtID.Text
            row("Merk") = cbMerk.Text
            row("Ukuran") = mtbUkuran.Text
            row("Stok") = txtStok.Text
        Else
            ' Menambahkan baris data baru ke tabel
            dtSepatu.Rows.Add(txtID.Text, cbMerk.Text, mtbUkuran.Text, txtStok.Text)
        End If

        MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class