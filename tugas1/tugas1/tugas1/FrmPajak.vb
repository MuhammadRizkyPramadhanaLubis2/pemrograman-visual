Public Class FrmPajak
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Decimal

        If Not Decimal.TryParse(txtPendapatan.Text.Trim(), pendapatan) Then
            MessageBox.Show("Masukkan nominal pendapatan yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        Dim tarif As Decimal = 0D
        If pendapatan > 100000000D Then
            tarif = 0.3D
        ElseIf pendapatan > 30000000D Then
            tarif = 0.2D
        ElseIf pendapatan > 5000000D Then
            tarif = 0.1D
        Else
            tarif = 0D
        End If

        Dim totalPajak As Decimal = pendapatan * tarif

        MessageBox.Show("Pajak yang perlu dibayarkan: Rp " & totalPajak.ToString("N0"), "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        txtPendapatan.Clear()
        Me.Close()
    End Sub

    Private Sub FrmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmPajak_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmLogin.Show()
    End Sub
End Class