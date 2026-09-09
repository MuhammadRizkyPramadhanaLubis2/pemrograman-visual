Public Class FrmLogin

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem IsNot Nothing Then
            Dim selectedRole As String = cmbRole.SelectedItem.ToString()
            If selectedRole = "Staff" Then
                picImage.Image = Image.FromFile("image\ashley.png")
            ElseIf selectedRole = "Manager" Then
                picImage.Image = Image.FromFile("image\leon.png")
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        Dim isStaffValid As Boolean = (role = "Staff" AndAlso nama.ToLower() = "ashley" AndAlso nim = "54321")
        Dim isManagerValid As Boolean = (role = "Manager" AndAlso nama.ToLower() = "leon" AndAlso nim = "12345")

        If isStaffValid OrElse isManagerValid Then
            txtNama.Clear()
            txtNIM.Clear()
            Me.Hide()
            FrmPajak.Show()
        Else
            MessageBox.Show("Masukkan Nama dan NIM dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
        End If
    End Sub

End Class