Public Class Form1
    Private Sub UpdateList(ByRef daftar As ListBox)
        daftar.Items.Clear()
        Dim i As Integer
        For i = 0 To isiSekarang - 1
            daftar.Items.Add(rakBuku(i, 0) & " (" & rakBuku(i, 1) & ")")
        Next
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtJudulTambah.Text <> "" And txtGenre.Text <> "" Then
            If isiSekarang < 100 Then
                rakBuku(isiSekarang, 0) = txtJudulTambah.Text
                rakBuku(isiSekarang, 1) = txtGenre.Text
                isiSekarang += 1

                UpdateList(DaftarBuku)

                txtJudulTambah.Clear()
                txtGenre.Clear()
                txtJudulTambah.Focus()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim cariNama As String = txtJudulHapus.Text
        Dim posisi As Integer = CariBuku(cariNama)

        If posisi <> -1 Then
            Dim j As Integer
            For j = posisi To isiSekarang - 2
                rakBuku(j, 0) = rakBuku(j + 1, 0)
                rakBuku(j, 1) = rakBuku(j + 1, 1)
            Next
            isiSekarang -= 1
            UpdateList(DaftarBuku)
            txtJudulHapus.Clear()
        Else
            MsgBox("Data tidak ditemukan!")
        End If
    End Sub
End Class