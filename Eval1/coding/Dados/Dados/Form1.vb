Public Class Form1

    Private Sub btnTirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTirar.Click



        Dim n1 As Integer = tiraDado(pctPlayer1)
        Dim n2 As Integer = tiraDado(pctPlayer2)

        If n1 > n2 Then
            txtScoreP1.Text = Val(txtScoreP1.Text) + 1
        ElseIf n1 < n2 Then
            txtScoreP2.Text = Val(txtScoreP2.Text) + 1
        End If

    End Sub

    Function tiraDado(ByVal c As PictureBox)

        Dim rnd As Random = New Random()
        Dim i As Integer = rnd.Next(6)

        c.Image = ImageList1.Images(i)
        Return i
    End Function
End Class
