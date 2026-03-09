<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        btntambah = New Button()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label3 = New Label()
        DaftarBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.0F)
        Label1.Location = New Point(16, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.0F)
        Label2.Location = New Point(16, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(btntambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.SteelBlue
        GroupBox1.Location = New Point(44, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(296, 175)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "TAMBAH BUKU"
        ' 
        ' btntambah
        ' 
        btntambah.BackColor = Color.DodgerBlue
        btntambah.FlatStyle = FlatStyle.Flat
        btntambah.ForeColor = Color.White
        btntambah.Location = New Point(183, 124)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(94, 35)
        btntambah.TabIndex = 4
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 9.0F)
        txtGenre.Location = New Point(120, 77)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(157, 27)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Font = New Font("Segoe UI", 9.0F)
        txtJudulTambah.Location = New Point(120, 34)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(157, 27)
        txtJudulTambah.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MistyRose
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GroupBox2.ForeColor = Color.Crimson
        GroupBox2.Location = New Point(460, 28)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(296, 175)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "HAPUS BUKU"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.IndianRed
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(187, 124)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 35)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Font = New Font("Segoe UI", 9.0F)
        txtJudulHapus.Location = New Point(124, 37)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(157, 27)
        txtJudulHapus.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.0F)
        Label3.Location = New Point(18, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' DaftarBuku
        ' 
        DaftarBuku.BackColor = Color.WhiteSmoke
        DaftarBuku.BorderStyle = BorderStyle.FixedSingle
        DaftarBuku.Font = New Font("Consolas", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DaftarBuku.ForeColor = Color.DarkSlateGray
        DaftarBuku.FormattingEnabled = True
        DaftarBuku.Location = New Point(44, 225)
        DaftarBuku.Name = "DaftarBuku"
        DaftarBuku.Size = New Size(712, 163)
        DaftarBuku.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(800, 450)
        Controls.Add(DaftarBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents DaftarBuku As ListBox
End Class