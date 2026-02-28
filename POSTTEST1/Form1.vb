Public Class Form1
    Private Sub btnTAMBAH_Click(sender As Object, e As EventArgs) Handles btnTAMBAH.Click
        Dim ips, ipkLama, ipkBaru As Double
        Dim jumlahSmt As Integer

        If Double.TryParse(txtIPS.Text, ips) Then
            If ips > 4 Or ips < 0 Then
                MessageBox.Show("Nilai IP harus di antara 0 sampai 4.00")
                Exit Sub
            End If

            Double.TryParse(txtIPK.Text, ipkLama)

            Integer.TryParse(Convert.ToString(Me.Tag), jumlahSmt)

            jumlahSmt = jumlahSmt + 1
            Me.Tag = jumlahSmt.ToString()

            ipkBaru = ((ipkLama * (jumlahSmt - 1)) + ips) / jumlahSmt
            txtIPK.Text = ipkBaru.ToString("0.00")

            If ipkBaru >= 3.01 Then
                txtPREDIKAT.Text = "SANGAT MEMUASKAN"
            ElseIf ipkBaru >= 2.76 Then
                txtPREDIKAT.Text = "MEMUASKAN"
            ElseIf ipkBaru >= 2.0 Then
                txtPREDIKAT.Text = "CUKUP"
            Else
                txtPREDIKAT.Text = "KURENG"
            End If

            txtIPS.Clear()
            txtIPS.Focus()
        Else
            MessageBox.Show("Input harus angka!")
            txtIPS.Clear()
            txtIPS.Focus()
        End If
    End Sub

    Private Sub btnRESET_Click(sender As Object, e As EventArgs) Handles btnRESET.Click
        txtIPS.Clear()
        txtIPK.Clear()
        txtPREDIKAT.Clear()
        Me.Tag = "0"
        txtIPS.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub
End Class