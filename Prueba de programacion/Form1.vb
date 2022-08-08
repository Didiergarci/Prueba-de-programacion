Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVerde.Click
        txtColores.BackColor = Color.Green
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtColores.TextChanged

    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtColores.BackColor = Color.Red
    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        txtColores.BackColor = Color.Blue
    End Sub

    Private Sub btnAmarillo_Click(sender As Object, e As EventArgs) Handles btnAmarillo.Click
        txtColores.BackColor = Color.Yellow
    End Sub

    Private Sub btnRosado_Click(sender As Object, e As EventArgs) Handles btnRosado.Click
        txtColores.BackColor = Color.Pink
    End Sub
End Class
