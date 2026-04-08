Public Class FormHasil
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengambil data dari Module1
        lblNamaHasil.Text = MemberNama.ToUpper()
        lblIDHasil.Text = "ID: " & MemberID
        lblDivisiHasil.Text = "Team: " & MemberDivisi
        lblPeranHasil.Text = "Status: " & MemberPeran
        lblKontakHasil.Text = MemberTelp & " | " & MemberEmail
        lblHobiHasil.Text = "Minat: " & MemberHobby

        ' Menampilkan Foto
        If Not MemberFoto Is Nothing Then
            pbFotoHasil.Image = MemberFoto
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class