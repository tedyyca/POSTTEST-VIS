<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlKartu = New Panel()
        pbFotoHasil = New PictureBox()
        lblHobiHasil = New Label()
        lblKontakHasil = New Label()
        lblPeranHasil = New Label()
        lblDivisiHasil = New Label()
        lblIDHasil = New Label()
        lblNamaHasil = New Label()
        lblJudulKartu = New Label()
        btnTutup = New Button()
        pnlKartu.SuspendLayout()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.WhiteSmoke
        pnlKartu.BorderStyle = BorderStyle.FixedSingle
        pnlKartu.Controls.Add(pbFotoHasil)
        pnlKartu.Controls.Add(lblHobiHasil)
        pnlKartu.Controls.Add(lblKontakHasil)
        pnlKartu.Controls.Add(lblPeranHasil)
        pnlKartu.Controls.Add(lblDivisiHasil)
        pnlKartu.Controls.Add(lblIDHasil)
        pnlKartu.Controls.Add(lblNamaHasil)
        pnlKartu.Controls.Add(lblJudulKartu)
        pnlKartu.Location = New Point(59, 47)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(656, 349)
        pnlKartu.TabIndex = 0
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.BorderStyle = BorderStyle.FixedSingle
        pbFotoHasil.Location = New Point(477, 65)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(140, 180)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoHasil.TabIndex = 7
        pbFotoHasil.TabStop = False
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.Location = New Point(24, 275)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(600, 50)
        lblHobiHasil.TabIndex = 8
        lblHobiHasil.Text = "Hobi: -"
        ' 
        ' lblKontakHasil
        ' 
        lblKontakHasil.AutoSize = True
        lblKontakHasil.Location = New Point(24, 235)
        lblKontakHasil.Name = "lblKontakHasil"
        lblKontakHasil.Size = New Size(68, 20)
        lblKontakHasil.TabIndex = 9
        lblKontakHasil.Text = "Kontak: -"
        ' 
        ' lblPeranHasil
        ' 
        lblPeranHasil.AutoSize = True
        lblPeranHasil.Location = New Point(24, 200)
        lblPeranHasil.Name = "lblPeranHasil"
        lblPeranHasil.Size = New Size(58, 20)
        lblPeranHasil.TabIndex = 10
        lblPeranHasil.Text = "Peran: -"
        ' 
        ' lblDivisiHasil
        ' 
        lblDivisiHasil.AutoSize = True
        lblDivisiHasil.Location = New Point(24, 165)
        lblDivisiHasil.Name = "lblDivisiHasil"
        lblDivisiHasil.Size = New Size(58, 20)
        lblDivisiHasil.TabIndex = 11
        lblDivisiHasil.Text = "Divisi: -"
        ' 
        ' lblIDHasil
        ' 
        lblIDHasil.AutoSize = True
        lblIDHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblIDHasil.Location = New Point(24, 130)
        lblIDHasil.Name = "lblIDHasil"
        lblIDHasil.Size = New Size(39, 20)
        lblIDHasil.TabIndex = 12
        lblIDHasil.Text = "ID: -"
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblNamaHasil.Location = New Point(24, 85)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(108, 32)
        lblNamaHasil.TabIndex = 13
        lblNamaHasil.Text = "[NAMA]"
        ' 
        ' lblJudulKartu
        ' 
        lblJudulKartu.AutoSize = True
        lblJudulKartu.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblJudulKartu.ForeColor = Color.Crimson
        lblJudulKartu.Location = New Point(24, 25)
        lblJudulKartu.Name = "lblJudulKartu"
        lblJudulKartu.Size = New Size(252, 28)
        lblJudulKartu.TabIndex = 14
        lblJudulKartu.Text = "KARTU ANGGOTA JMK48"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(621, 409)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 1
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 460)
        Controls.Add(btnTutup)
        Controls.Add(pnlKartu)
        Name = "FormHasil"
        Text = "Kartu Member JMK48"
        pnlKartu.ResumeLayout(False)
        pnlKartu.PerformLayout()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub


    Friend WithEvents pnlKartu As Panel
    Friend WithEvents lblHobiHasil As Label
    Friend WithEvents lblKontakHasil As Label
    Friend WithEvents lblPeranHasil As Label
    Friend WithEvents lblDivisiHasil As Label
    Friend WithEvents lblIDHasil As Label
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblJudulKartu As Label
    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents btnTutup As Button
End Class