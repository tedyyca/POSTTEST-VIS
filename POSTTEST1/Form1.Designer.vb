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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        txtPREDIKAT = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnTAMBAH = New Button()
        btnRESET = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(151, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 38)
        Label1.TabIndex = 0
        Label1.Text = "IP SEMESTER"
        ' 
        ' txtIPS
        ' 
        txtIPS.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIPS.Location = New Point(346, 103)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(71, 38)
        txtIPS.TabIndex = 1
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.ButtonHighlight
        txtIPK.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIPK.Location = New Point(346, 179)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(71, 38)
        txtIPK.TabIndex = 2
        ' 
        ' txtPREDIKAT
        ' 
        txtPREDIKAT.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPREDIKAT.BackColor = SystemColors.ActiveCaption
        txtPREDIKAT.BorderStyle = BorderStyle.None
        txtPREDIKAT.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtPREDIKAT.Location = New Point(207, 325)
        txtPREDIKAT.Name = "txtPREDIKAT"
        txtPREDIKAT.ReadOnly = True
        txtPREDIKAT.Size = New Size(364, 36)
        txtPREDIKAT.TabIndex = 3
        txtPREDIKAT.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(131, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 38)
        Label2.TabIndex = 4
        Label2.Text = "IP KUMULATIF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(311, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 38)
        Label3.TabIndex = 5
        Label3.Text = "PREDIKAT"
        ' 
        ' btnTAMBAH
        ' 
        btnTAMBAH.BackColor = Color.Chartreuse
        btnTAMBAH.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTAMBAH.Location = New Point(452, 110)
        btnTAMBAH.Name = "btnTAMBAH"
        btnTAMBAH.Size = New Size(94, 29)
        btnTAMBAH.TabIndex = 6
        btnTAMBAH.Text = "TAMBAH"
        btnTAMBAH.UseVisualStyleBackColor = False
        ' 
        ' btnRESET
        ' 
        btnRESET.BackColor = Color.Gold
        btnRESET.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRESET.Location = New Point(563, 110)
        btnRESET.Name = "btnRESET"
        btnRESET.Size = New Size(94, 29)
        btnRESET.TabIndex = 7
        btnRESET.Text = "RESET"
        btnRESET.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnRESET)
        Controls.Add(btnTAMBAH)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPREDIKAT)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents txtPREDIKAT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTAMBAH As Button
    Friend WithEvents btnRESET As Button

End Class
