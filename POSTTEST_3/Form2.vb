Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = MemberNama
        Label2.Text = "Umur: " & MemberUmur & " Tahun"
        Label3.Text = "Tanggal Lahir: " & MemberTglLahir
        Label4.Text = "Jenis Kelamin: " & MemberGender
        Label5.Text = "Nomor Telepon: " & MemberTelp
        Label6.Text = "Hobby: " & MemberHobby
        Label7.Text = "Alamat: " & MemberAlamat

        If MemberFoto IsNot Nothing Then
            PictureBox1.Image = MemberFoto
        End If
    End Sub
End Class