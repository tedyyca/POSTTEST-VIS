<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        TambahDataToolStripMenuItem = New ToolStripMenuItem()
        LihatDataToolStripMenuItem = New ToolStripMenuItem()
        EditDataToolStripMenuItem = New ToolStripMenuItem()
        HapusDataToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SteelBlue
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TambahDataToolStripMenuItem, LihatDataToolStripMenuItem, EditDataToolStripMenuItem, HapusDataToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TambahDataToolStripMenuItem
        ' 
        TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
        TambahDataToolStripMenuItem.Size = New Size(111, 24)
        TambahDataToolStripMenuItem.Text = "Tambah Data"
        ' 
        ' LihatDataToolStripMenuItem
        ' 
        LihatDataToolStripMenuItem.Name = "LihatDataToolStripMenuItem"
        LihatDataToolStripMenuItem.Size = New Size(91, 24)
        LihatDataToolStripMenuItem.Text = "Lihat Data"
        ' 
        ' EditDataToolStripMenuItem
        ' 
        EditDataToolStripMenuItem.Name = "EditDataToolStripMenuItem"
        EditDataToolStripMenuItem.Size = New Size(85, 24)
        EditDataToolStripMenuItem.Text = "Edit Data"
        ' 
        ' HapusDataToolStripMenuItem
        ' 
        HapusDataToolStripMenuItem.Name = "HapusDataToolStripMenuItem"
        HapusDataToolStripMenuItem.Size = New Size(101, 24)
        HapusDataToolStripMenuItem.Text = "Hapus Data"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._0d5d591c45224401b38dfe78d3a987ec_tplv_aphluv4xwc_white_pad_v1_1600_1600
        PictureBox1.Location = New Point(-22, 162)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(315, 288)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2aba724b425b4660bb12e6a97ecefdc3_tplv_aphluv4xwc_resize_jpeg_700_0
        PictureBox2.Location = New Point(289, 258)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(224, 205)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._8ce56836_8e01_41bd_aa96_2d955c77cbe7_jpg_tplv_aphluv4xwc_white_pad_v1_1600_1600
        PictureBox3.Location = New Point(717, 33)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(197, 183)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.SPE110400010_1
        PictureBox4.Location = New Point(641, 177)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(273, 273)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(0, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(727, 50)
        Label1.TabIndex = 5
        Label1.Text = "SISTEM MANAJEMEN SEPATU RUNNING"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Sistem Manajemen Sepatu Running"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
End Class