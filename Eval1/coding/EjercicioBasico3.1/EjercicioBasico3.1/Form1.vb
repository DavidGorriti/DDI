Public Class Form1


    Private Sub btnPesetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesetas.Click
        If IsNumeric(txtInput.Text) Then
            txtOutput.Text = txtInput.Text * 166
        End If
    End Sub

    Private Sub btnEuros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEuros.Click
        If IsNumeric(txtInput.Text) Then
            txtOutput.Text = txtInput.Text / 166
        End If
    End Sub
End Class
