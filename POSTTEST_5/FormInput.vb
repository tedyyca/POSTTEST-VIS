Public Class FormInput
    Public isEdit As Boolean = False
    Public IDTerpilih As String = ""

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbMerk.Items.Count = 0 Then
            cbMerk.Items.AddRange(New String() {"Ortus", "Adidas", "Specs", "Nineten", "Nike"})
        End If

        If isEdit Then
            Me.Text = "Edit Data - ID: " & IDTerpilih
        Else
            Me.Text = "Tambah Data"
            txtStok.Clear()
            mtbUkuran.Clear()
            cbMerk.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If cbMerk.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbMerk, "Pilih merk")
            Return
        End If

        Dim Berhasil As Boolean
        If isEdit Then
            Berhasil = UbahSepatu(IDTerpilih, cbMerk.Text, CInt(mtbUkuran.Text), CInt(txtStok.Text))
        Else
            Berhasil = SimpanSepatu(cbMerk.Text, CInt(mtbUkuran.Text), CInt(txtStok.Text))
        End If

        If Berhasil Then
            MessageBox.Show("Data Berhasil Disimpan")
            Me.Close()
        End If
    End Sub
End Class