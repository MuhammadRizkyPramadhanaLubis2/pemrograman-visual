<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnKeluar = New Button()
        btnHitung = New Button()
        txtPendapatan = New TextBox()
        lblGaji = New Label()
        lblPajak0 = New Label()
        lblPajak10 = New Label()
        lblPajak20 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(325, 387)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 0
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(325, 335)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 1
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(311, 246)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(125, 27)
        txtPendapatan.TabIndex = 2
        ' 
        ' lblGaji
        ' 
        lblGaji.AutoSize = True
        lblGaji.Location = New Point(273, 214)
        lblGaji.Name = "lblGaji"
        lblGaji.Size = New Size(211, 20)
        lblGaji.TabIndex = 3
        lblGaji.Text = "Masukkan Nominal Gaji Anda :"
        ' 
        ' lblPajak0
        ' 
        lblPajak0.AutoSize = True
        lblPajak0.Location = New Point(240, 38)
        lblPajak0.Name = "lblPajak0"
        lblPajak0.Size = New Size(300, 20)
        lblPajak0.TabIndex = 4
        lblPajak0.Text = "Penghasilan dibawah Rp,5.000.000, Pajak 0%"
        ' 
        ' lblPajak10
        ' 
        lblPajak10.AutoSize = True
        lblPajak10.Location = New Point(206, 66)
        lblPajak10.Name = "lblPajak10"
        lblPajak10.Size = New Size(367, 20)
        lblPajak10.TabIndex = 5
        lblPajak10.Text = "Penghasilan Rp.5.000.000 s/d Rp.30.000.000, Pajak 10%"
        ' 
        ' lblPajak20
        ' 
        lblPajak20.AutoSize = True
        lblPajak20.Location = New Point(199, 97)
        lblPajak20.Name = "lblPajak20"
        lblPajak20.Size = New Size(383, 20)
        lblPajak20.TabIndex = 6
        lblPajak20.Text = "Penghasilan Rp.30.000.001 s/d Rp.100.000.000, Pajak 20%"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 20)
        Label1.TabIndex = 7
        Label1.Text = "Penghasilan diatas Rp.100.000.000, Pajak 30%"
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblPajak20)
        Controls.Add(lblPajak10)
        Controls.Add(lblPajak0)
        Controls.Add(lblGaji)
        Controls.Add(txtPendapatan)
        Controls.Add(btnHitung)
        Controls.Add(btnKeluar)
        Name = "FrmPajak"
        Text = "Hitung Pajak Penghasilanmu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents lblGaji As Label
    Friend WithEvents lblPajak0 As Label
    Friend WithEvents lblPajak10 As Label
    Friend WithEvents lblPajak20 As Label
    Friend WithEvents Label1 As Label
End Class
