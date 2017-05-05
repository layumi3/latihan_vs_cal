Public Class Form2

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles txt_hasil.Click
        Dim num1, num2, hasil As Single
        num1 = Tb_a.Text
        num2 = tb_b.Text
        hasil = num1 + num2
        txt_hasil.Text = hasil
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, hasil As Single
        num1 = Tb_a.Text
        num2 = tb_b.Text
        hasil = num1 * num2
        txt_hasil = hasil
    End Sub
End Class