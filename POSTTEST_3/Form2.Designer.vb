<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Dim PanelCard As Panel = New Panel()
        Dim LabelHeader As Label = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelCard.SuspendLayout()
        SuspendLayout()

        PanelCard.BackColor = Color.White
        PanelCard.BorderStyle = BorderStyle.FixedSingle
        PanelCard.Controls.Add(LabelHeader)
        PanelCard.Controls.Add(PictureBox1)
        PanelCard.Controls.Add(Label1)
        PanelCard.Controls.Add(Label2)
        PanelCard.Controls.Add(Label3)
        PanelCard.Controls.Add(Label4)
        PanelCard.Controls.Add(Label5)
        PanelCard.Controls.Add(Label6)
        PanelCard.Controls.Add(Label7)
        PanelCard.Location = New Point(50, 50)
        PanelCard.Name = "PanelCard"
        PanelCard.Size = New Size(600, 380)

        LabelHeader.BackColor = Color.Crimson
        LabelHeader.Dock = DockStyle.Top
        LabelHeader.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        LabelHeader.ForeColor = Color.White
        LabelHeader.Location = New Point(0, 0)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(598, 45)
        LabelHeader.Text = "JMK48 OFFICIAL MEMBER CARD"
        LabelHeader.TextAlign = ContentAlignment.MiddleCenter

        PictureBox1.Location = New Point(25, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.BorderStyle = BorderStyle.FixedSingle

        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(200, 70)
        Label1.Name = "Label1"
        Label1.Text = "NAMA MEMBER"

        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label2.Location = New Point(200, 120)
        Label2.Name = "Label2"
        Label2.Text = "Umur:"

        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label3.Location = New Point(200, 150)
        Label3.Name = "Label3"
        Label3.Text = "Tanggal Lahir:"

        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label4.Location = New Point(200, 180)
        Label4.Name = "Label4"
        Label4.Text = "Jenis Kelamin:"

        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label5.Location = New Point(200, 210)
        Label5.Name = "Label5"
        Label5.Text = "Nomor Telepon:"

        Label6.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label6.Location = New Point(200, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(380, 50)
        Label6.Text = "Hobby:"

        Label7.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Label7.Location = New Point(200, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(380, 50)
        Label7.Text = "Alamat:"

        AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 240, 240)
        ClientSize = New Size(700, 480)
        Controls.Add(PanelCard)
        Name = "Form2"
        Text = "Kartu Member JMK48"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class