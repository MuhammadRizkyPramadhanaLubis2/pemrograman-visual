<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        btnLogin = New Button()
        lblRole = New Label()
        lblNama = New Label()
        lblNim = New Label()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(317, 52)
        picImage.Name = "picImage"
        picImage.Size = New Size(125, 115)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(364, 229)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(364, 292)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(151, 27)
        txtNama.TabIndex = 2
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(364, 353)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(151, 27)
        txtNIM.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(332, 433)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(262, 232)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(62, 20)
        lblRole.TabIndex = 5
        lblRole.Text = "Role     :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(262, 292)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(64, 20)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama   :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(266, 356)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(60, 20)
        lblNim.TabIndex = 7
        lblNim.Text = "NIM     :"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label

End Class
