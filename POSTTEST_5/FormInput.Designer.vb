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
        txtID = New TextBox()
        cbMerk = New ComboBox()
        mtbUkuran = New MaskedTextBox()
        txtStok = New TextBox()
        btnSimpan = New Button()
        LabelID = New Label()
        LabelMerk = New Label()
        LabelUkuran = New Label()
        LabelStok = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(100, 20)
        txtID.Name = "txtID"
        txtID.Size = New Size(150, 27)
        txtID.TabIndex = 0
        ' 
        ' cbMerk
        ' 
        cbMerk.FormattingEnabled = True
        cbMerk.Location = New Point(100, 60)
        cbMerk.Name = "cbMerk"
        cbMerk.Size = New Size(150, 28)
        cbMerk.TabIndex = 1
        ' 
        ' mtbUkuran
        ' 
        mtbUkuran.Location = New Point(100, 100)
        mtbUkuran.Mask = "00"
        mtbUkuran.Name = "mtbUkuran"
        mtbUkuran.Size = New Size(50, 27)
        mtbUkuran.TabIndex = 2
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(100, 140)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(100, 27)
        txtStok.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DodgerBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(100, 180)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(100, 35)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' LabelID
        ' 
        LabelID.Location = New Point(20, 23)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(74, 23)
        LabelID.TabIndex = 3
        LabelID.Text = "ID Sepatu:"
        ' 
        ' LabelMerk
        ' 
        LabelMerk.Location = New Point(20, 63)
        LabelMerk.Name = "LabelMerk"
        LabelMerk.Size = New Size(74, 23)
        LabelMerk.TabIndex = 2
        LabelMerk.Text = "Merk:"
        ' 
        ' LabelUkuran
        ' 
        LabelUkuran.Location = New Point(20, 103)
        LabelUkuran.Name = "LabelUkuran"
        LabelUkuran.Size = New Size(74, 23)
        LabelUkuran.TabIndex = 1
        LabelUkuran.Text = "Ukuran:"
        ' 
        ' LabelStok
        ' 
        LabelStok.Location = New Point(20, 143)
        LabelStok.Name = "LabelStok"
        LabelStok.Size = New Size(74, 23)
        LabelStok.TabIndex = 0
        LabelStok.Text = "Stok:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(300, 250)
        Controls.Add(LabelStok)
        Controls.Add(LabelUkuran)
        Controls.Add(LabelMerk)
        Controls.Add(LabelID)
        Controls.Add(btnSimpan)
        Controls.Add(txtStok)
        Controls.Add(mtbUkuran)
        Controls.Add(cbMerk)
        Controls.Add(txtID)
        Name = "FormInput"
        Text = "Input Data Sepatu"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents cbMerk As ComboBox
    Friend WithEvents mtbUkuran As MaskedTextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelMerk As Label
    Friend WithEvents LabelUkuran As Label
    Friend WithEvents LabelStok As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class