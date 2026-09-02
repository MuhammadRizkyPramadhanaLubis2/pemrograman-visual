Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Pake Angka Woi")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Nilai hanya 1-100")
            txtNilai.Focus()
        End If

        If nilaiUjian <= 50 Then
            picImage.Image = Image.FromFile("assets\1.jpg")
        ElseIf nilaiUjian <= 75 Then
            picImage.Image = Image.FromFile("assets\2.jpg")
        Else
            picImage.Image = Image.FromFile("assets\3.jpg")
        End If

    End Sub


    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub

    Private Sub txtNilai_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged

    End Sub
End Class
