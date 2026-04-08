<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataMenu = New ToolStripMenuItem()
        LihatKartuMenu = New ToolStripMenuItem()
        SimpanDataMenu = New ToolStripMenuItem()
        BukaDataMenu = New ToolStripMenuItem()
        KeluarMenu = New ToolStripMenuItem()
        lblJudul = New Label()
        pbLogo = New PictureBox()
        TabControl1 = New TabControl()
        t = New TabPage()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpTglLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        t1 = New TabPage()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelp = New MaskedTextBox()
        tMenu = New TabPage()
        btnSimpanCetak = New Button()
        btnBrowse = New Button()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        pbFotoProfil = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        t.SuspendLayout()
        t1.SuspendLayout()
        tMenu.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataMenu, LihatKartuMenu, SimpanDataMenu, BukaDataMenu, KeluarMenu})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataMenu
        ' 
        InputDataMenu.Name = "InputDataMenu"
        InputDataMenu.Size = New Size(93, 24)
        InputDataMenu.Text = "Input Data"
        ' 
        ' LihatKartuMenu
        ' 
        LihatKartuMenu.Name = "LihatKartuMenu"
        LihatKartuMenu.Size = New Size(94, 24)
        LihatKartuMenu.Text = "Lihat Kartu"
        ' 
        ' SimpanDataMenu
        ' 
        SimpanDataMenu.Name = "SimpanDataMenu"
        SimpanDataMenu.Size = New Size(109, 24)
        SimpanDataMenu.Text = "Simpan Data"
        ' 
        ' BukaDataMenu
        ' 
        BukaDataMenu.Name = "BukaDataMenu"
        BukaDataMenu.Size = New Size(91, 24)
        BukaDataMenu.Text = "Buka Data"
        ' 
        ' KeluarMenu
        ' 
        KeluarMenu.Name = "KeluarMenu"
        KeluarMenu.Size = New Size(65, 24)
        KeluarMenu.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Crimson
        lblJudul.Location = New Point(127, 35)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(318, 38)
        lblJudul.TabIndex = 1
        lblJudul.Text = "PENDAFTARAN JMK48"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = My.Resources.Resources._6324472bbc646ffd0a122fddfa0b9798
        pbLogo.Location = New Point(12, 80)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(100, 100)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 2
        pbLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(t)
        TabControl1.Controls.Add(t1)
        TabControl1.Controls.Add(tMenu)
        TabControl1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(127, 80)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(620, 330)
        TabControl1.TabIndex = 3
        ' 
        ' t
        ' 
        t.BackColor = Color.White
        t.Controls.Add(Label6)
        t.Controls.Add(Label5)
        t.Controls.Add(Label4)
        t.Controls.Add(Label3)
        t.Controls.Add(Label2)
        t.Controls.Add(cbDivisi)
        t.Controls.Add(rbPerempuan)
        t.Controls.Add(rbLaki)
        t.Controls.Add(dtpTglLahir)
        t.Controls.Add(txtID)
        t.Controls.Add(txtNama)
        t.Location = New Point(4, 29)
        t.Name = "t"
        t.Padding = New Padding(3)
        t.Size = New Size(612, 297)
        t.TabIndex = 0
        t.Text = "Data Utama"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label6.Location = New Point(20, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 0
        Label6.Text = "Divisi"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label5.Location = New Point(20, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 1
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label4.Location = New Point(20, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(20, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 3
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(20, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 23)
        Label2.TabIndex = 4
        Label2.Text = "Nama Lengkap"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Divisi A1", "Divisi A2", "Divisi A3", "Divisi A4", "Divisi A5"})
        cbDivisi.Location = New Point(150, 190)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(150, 28)
        cbDivisi.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(260, 150)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 6
        rbPerempuan.Text = "Perempuan"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(150, 150)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 7
        rbLaki.Text = "Laki-Laki"
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(150, 110)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(200, 27)
        dtpTglLahir.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(150, 70)
        txtID.Name = "txtID"
        txtID.Size = New Size(150, 27)
        txtID.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(150, 30)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 10
        ' 
        ' t1
        ' 
        t1.BackColor = Color.White
        t1.Controls.Add(Label9)
        t1.Controls.Add(Label8)
        t1.Controls.Add(Label7)
        t1.Controls.Add(txtAlamat)
        t1.Controls.Add(txtEmail)
        t1.Controls.Add(mtbTelp)
        t1.Location = New Point(4, 29)
        t1.Name = "t1"
        t1.Padding = New Padding(3)
        t1.Size = New Size(612, 297)
        t1.TabIndex = 1
        t1.Text = "Kontak & Info"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label9.Location = New Point(30, 120)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 0
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label8.Location = New Point(30, 80)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label7.Location = New Point(30, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 2
        Label7.Text = "Telepon"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Location = New Point(150, 120)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(300, 80)
        txtAlamat.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(150, 80)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 27)
        txtEmail.TabIndex = 4
        ' 
        ' mtbTelp
        ' 
        mtbTelp.BorderStyle = BorderStyle.FixedSingle
        mtbTelp.Location = New Point(150, 40)
        mtbTelp.Mask = "0000-0000-0000"
        mtbTelp.Name = "mtbTelp"
        mtbTelp.Size = New Size(150, 27)
        mtbTelp.TabIndex = 5
        ' 
        ' tMenu
        ' 
        tMenu.BackColor = Color.White
        tMenu.Controls.Add(btnSimpanCetak)
        tMenu.Controls.Add(btnBrowse)
        tMenu.Controls.Add(CheckBox8)
        tMenu.Controls.Add(CheckBox7)
        tMenu.Controls.Add(CheckBox6)
        tMenu.Controls.Add(CheckBox5)
        tMenu.Controls.Add(CheckBox4)
        tMenu.Controls.Add(CheckBox3)
        tMenu.Controls.Add(CheckBox2)
        tMenu.Controls.Add(CheckBox1)
        tMenu.Controls.Add(gbPeran)
        tMenu.Controls.Add(pbFotoProfil)
        tMenu.Location = New Point(4, 29)
        tMenu.Name = "tMenu"
        tMenu.Padding = New Padding(3)
        tMenu.Size = New Size(612, 297)
        tMenu.TabIndex = 2
        tMenu.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.Crimson
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(250, 225)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(292, 40)
        btnSimpanCetak.TabIndex = 0
        btnSimpanCetak.Text = "SIMPAN dan CETAK KARTU"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.WhiteSmoke
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Location = New Point(130, 20)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(100, 30)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' CheckBox8
        ' 
        CheckBox8.Location = New Point(380, 120)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(104, 24)
        CheckBox8.TabIndex = 2
        CheckBox8.Text = "Reading"
        ' 
        ' CheckBox7
        ' 
        CheckBox7.Location = New Point(380, 90)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(104, 24)
        CheckBox7.TabIndex = 3
        CheckBox7.Text = "Olahraga"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.Location = New Point(380, 60)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(104, 24)
        CheckBox6.TabIndex = 4
        CheckBox6.Text = "Gaming"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.Location = New Point(380, 30)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(104, 24)
        CheckBox5.TabIndex = 5
        CheckBox5.Text = "MC"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Location = New Point(250, 120)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(104, 24)
        CheckBox4.TabIndex = 6
        CheckBox4.Text = "Musik"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Location = New Point(250, 90)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(104, 24)
        CheckBox3.TabIndex = 7
        CheckBox3.Text = "Akting"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Location = New Point(250, 60)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(104, 24)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Menari"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Location = New Point(250, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(104, 24)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Menyanyi"
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.ForeColor = Color.Crimson
        gbPeran.Location = New Point(20, 150)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(180, 110)
        gbPeran.TabIndex = 10
        gbPeran.TabStop = False
        gbPeran.Text = "Pilihan Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.ForeColor = Color.Black
        rbAdmin.Location = New Point(10, 75)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(104, 24)
        rbAdmin.TabIndex = 0
        rbAdmin.Text = "Admin"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.ForeColor = Color.Black
        rbAnggota.Location = New Point(10, 50)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(104, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.Text = "Anggota"
        ' 
        ' rbKetua
        ' 
        rbKetua.ForeColor = Color.Black
        rbKetua.Location = New Point(10, 25)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(104, 24)
        rbKetua.TabIndex = 2
        rbKetua.Text = "Ketua"
        ' 
        ' pbFotoProfil
        ' 
        pbFotoProfil.BackColor = Color.WhiteSmoke
        pbFotoProfil.BorderStyle = BorderStyle.FixedSingle
        pbFotoProfil.Location = New Point(20, 20)
        pbFotoProfil.Name = "pbFotoProfil"
        pbFotoProfil.Size = New Size(100, 120)
        pbFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoProfil.TabIndex = 11
        pbFotoProfil.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(pbLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Registrasi Member JMK48"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        t.ResumeLayout(False)
        t.PerformLayout()
        t1.ResumeLayout(False)
        t1.PerformLayout()
        tMenu.ResumeLayout(False)
        gbPeran.ResumeLayout(False)
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataMenu As ToolStripMenuItem
    Friend WithEvents LihatKartuMenu As ToolStripMenuItem
    Friend WithEvents SimpanDataMenu As ToolStripMenuItem
    Friend WithEvents BukaDataMenu As ToolStripMenuItem
    Friend WithEvents KeluarMenu As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents t As TabPage
    Friend WithEvents t1 As TabPage
    Friend WithEvents tMenu As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelp As MaskedTextBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents pbFotoProfil As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class