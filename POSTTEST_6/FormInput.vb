Public Class FormInput
    Public isEdit As Boolean = False
    Public IDTerpilih As String = ""

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()

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
            If cbKategori.Items.Count > 0 Then cbKategori.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadKategori()
        Try
            Dim dt As DataTable = GetAllKategori()


            cbKategori.DataSource = Nothing

            cbKategori.DataSource = dt
            cbKategori.DisplayMember = "nama_kategori"
            cbKategori.ValueMember = "id_kategori"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If cbMerk.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbMerk, "Pilih merk")
            Return
        End If

        If cbKategori.SelectedValue Is Nothing Then
            ErrorProvider1.SetError(cbKategori, "Pilih kategori")
            Return
        End If

        Dim idKat As Integer = Convert.ToInt32(cbKategori.SelectedValue)
        Dim Berhasil As Boolean

        If isEdit Then
            Berhasil = UbahSepatu(IDTerpilih, cbMerk.Text, idKat, CInt(mtbUkuran.Text), CInt(txtStok.Text))
        Else
            Berhasil = SimpanSepatu(cbMerk.Text, idKat, CInt(mtbUkuran.Text), CInt(txtStok.Text))
        End If

        If Berhasil Then
            MessageBox.Show("Data Berhasil Disimpan")
            Me.Close()
        End If
    End Sub

End Class