Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "JMK48 - Pendaftaran Member Baru"
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFile.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFile.FileName)
            MemberFoto = PictureBox1.Image
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or PictureBox1.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jk As String = ""
        If RadioButton1.Checked Then
            jk = "Laki-Laki"
        ElseIf RadioButton2.Checked Then
            jk = "Perempuan"
        Else
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hobi As String = ""
        Dim checkboxes() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10}

        For Each cb In checkboxes
            If cb.Checked Then
                hobi &= cb.Text & ", "
            End If
        Next

        If hobi = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MemberNama = TextBox1.Text
        MemberUmur = TextBox2.Text
        MemberTelp = TextBox3.Text
        MemberAlamat = TextBox4.Text
        MemberTglLahir = DateTimePicker1.Value.ToString("dd MMMM yyyy")
        MemberGender = jk
        MemberHobby = hobi.TrimEnd(", ".ToCharArray())

        Form2.Show()
    End Sub
End Class