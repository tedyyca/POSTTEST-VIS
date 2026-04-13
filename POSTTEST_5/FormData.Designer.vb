<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormData
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
        dgvSepatu = New DataGridView()
        txtCari = New TextBox()
        btnCari = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(dgvSepatu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSepatu
        ' 
        dgvSepatu.BackgroundColor = Color.White
        dgvSepatu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSepatu.Location = New Point(12, 51)
        dgvSepatu.Name = "dgvSepatu"
        dgvSepatu.RowHeadersWidth = 51
        dgvSepatu.Size = New Size(560, 250)
        dgvSepatu.TabIndex = 0
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(92, 15)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(363, 27)
        txtCari.TabIndex = 1
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.LightSkyBlue
        btnCari.FlatStyle = FlatStyle.Flat
        btnCari.Location = New Point(480, 14)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(92, 30)
        btnCari.TabIndex = 2
        btnCari.Text = "Cari Merk"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 4
        Label1.Text = "Cari Data:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources._2aba724b425b4660bb12e6a97ecefdc3_tplv_aphluv4xwc_resize_jpeg_700_0
        PictureBox1.Location = New Point(194, 320)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = My.Resources.Resources._0d5d591c45224401b38dfe78d3a987ec_tplv_aphluv4xwc_white_pad_v1_1600_1600
        PictureBox2.Location = New Point(356, 320)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(261, 156)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' FormData
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(584, 552)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnCari)
        Controls.Add(txtCari)
        Controls.Add(dgvSepatu)
        Name = "FormData"
        Text = "Data Sepatu Running"
        CType(dgvSepatu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSepatu As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class