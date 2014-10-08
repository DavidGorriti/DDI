Public Class Form1

    Private Sub btnVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerde.Click
        txtText.ForeColor = Color.Green
    End Sub

    Private Sub btnRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRojo.Click
        txtText.ForeColor = Color.Red
    End Sub

    Private Sub btnAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAzul.Click
        txtText.ForeColor = Color.Blue
    End Sub

    Private Sub btnNegro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegro.Click
        txtText.ForeColor = Color.Black
    End Sub

    Private Sub btnArial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArial.Click
        Dim f As New System.Drawing.Font("Arial", txtText.Font.Size)
        txtText.Font = f
    End Sub

    Private Sub btnCourier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourier.Click
        Dim f As New System.Drawing.Font("Courier", txtText.Font.Size)
        txtText.Font = f
    End Sub


    Private Sub btnMasTam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasTam.Click
        Dim f As New System.Drawing.Font(txtText.Font.Name, txtText.Font.Size + 1)
        txtText.Font = f
    End Sub

    Private Sub btnMenosTam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosTam.Click
        Dim f As New System.Drawing.Font(txtText.Font.Name, txtText.Font.Size - 1)
        txtText.Font = f
    End Sub

    Private Sub btnNegrita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegrita.Click

    End Sub
End Class
