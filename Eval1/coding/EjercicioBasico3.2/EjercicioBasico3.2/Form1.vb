Public Class Form1

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        lblSimbolo.Text = "+"

        If IsNumeric(txtN1.Text) And IsNumeric(txtN2.Text) Then
            txtRes.Text = Val(txtN1.Text) + Val(txtN2.Text)
        End If
    End Sub

    Private Sub btnRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRest.Click
        lblSimbolo.Text = "-"

        If IsNumeric(txtN1.Text) And IsNumeric(txtN2.Text) Then
            txtRes.Text = Val(txtN1.Text) - Val(txtN2.Text)
        End If
    End Sub

    Private Sub bntMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntMult.Click
        lblSimbolo.Text = "x"

        If IsNumeric(txtN1.Text) And IsNumeric(txtN2.Text) Then
            txtRes.Text = Val(txtN1.Text) * Val(txtN2.Text)
        End If
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        lblSimbolo.Text = "/"

        If IsNumeric(txtN1.Text) And IsNumeric(txtN2.Text) Then
            txtRes.Text = Val(txtN1.Text) / Val(txtN2.Text)
        End If
    End Sub
End Class
