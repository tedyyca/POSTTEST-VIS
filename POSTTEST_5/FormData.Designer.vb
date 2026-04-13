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
        btnProses = New Button()
        Label1 = New Label()
        CType(dgvSepatu, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnProses
        ' 
        btnProses.BackColor = Color.MediumSeaGreen
        btnProses.FlatStyle = FlatStyle.Flat
        btnProses.ForeColor = Color.White
        btnProses.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnProses.Location = New Point(12, 310)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(120, 35)
        btnProses.TabIndex = 3
        btnProses.Text = "Aksi"
        btnProses.UseVisualStyleBackColor = False
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
        ' FormData
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(584, 361)
        Controls.Add(Label1)
        Controls.Add(btnProses)
        Controls.Add(btnCari)
        Controls.Add(txtCari)
        Controls.Add(dgvSepatu)
        Name = "FormData"
        Text = "Data Sepatu Running"
        CType(dgvSepatu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSepatu As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnProses As Button
    Friend WithEvents Label1 As Label
End Class