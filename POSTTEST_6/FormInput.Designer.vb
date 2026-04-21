<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormInput
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        cbMerk = New ComboBox()
        mtbUkuran = New MaskedTextBox()
        txtStok = New TextBox()
        btnSimpan = New Button()
        LabelMerk = New Label()
        LabelUkuran = New Label()
        LabelStok = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        cbKategori = New ComboBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbMerk
        ' 
        cbMerk.DropDownStyle = ComboBoxStyle.DropDownList
        cbMerk.Location = New Point(110, 33)
        cbMerk.Name = "cbMerk"
        cbMerk.Size = New Size(160, 28)
        cbMerk.TabIndex = 0
        ' 
        ' mtbUkuran
        ' 
        mtbUkuran.Location = New Point(110, 140)
        mtbUkuran.Mask = "00"
        mtbUkuran.Name = "mtbUkuran"
        mtbUkuran.Size = New Size(60, 27)
        mtbUkuran.TabIndex = 1
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(110, 186)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(100, 27)
        txtStok.TabIndex = 2
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DodgerBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(110, 250)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(100, 35)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' LabelMerk
        ' 
        LabelMerk.Location = New Point(20, 33)
        LabelMerk.Name = "LabelMerk"
        LabelMerk.Size = New Size(80, 23)
        LabelMerk.TabIndex = 2
        LabelMerk.Text = "Merk:"
        ' 
        ' LabelUkuran
        ' 
        LabelUkuran.Location = New Point(12, 140)
        LabelUkuran.Name = "LabelUkuran"
        LabelUkuran.Size = New Size(80, 23)
        LabelUkuran.TabIndex = 1
        LabelUkuran.Text = "Ukuran:"
        ' 
        ' LabelStok
        ' 
        LabelStok.Location = New Point(20, 186)
        LabelStok.Name = "LabelStok"
        LabelStok.Size = New Size(80, 23)
        LabelStok.TabIndex = 0
        LabelStok.Text = "Stok:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._8ce56836_8e01_41bd_aa96_2d955c77cbe7_jpg_tplv_aphluv4xwc_white_pad_v1_1600_1600
        PictureBox1.Location = New Point(632, 162)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(324, 252)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = My.Resources.Resources._0d5d591c45224401b38dfe78d3a987ec_tplv_aphluv4xwc_white_pad_v1_1600_1600
        PictureBox2.Location = New Point(583, -2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(252, 233)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 6
        Label1.Text = "Kategori:"
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Location = New Point(110, 90)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(151, 28)
        cbKategori.TabIndex = 7
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(914, 352)
        Controls.Add(cbKategori)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(LabelStok)
        Controls.Add(LabelUkuran)
        Controls.Add(LabelMerk)
        Controls.Add(btnSimpan)
        Controls.Add(txtStok)
        Controls.Add(mtbUkuran)
        Controls.Add(cbMerk)
        Name = "FormInput"
        Text = "Input Data"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbMerk As ComboBox
    Friend WithEvents mtbUkuran As MaskedTextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents LabelMerk As Label
    Friend WithEvents LabelUkuran As Label
    Friend WithEvents LabelStok As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents Label1 As Label
End Class