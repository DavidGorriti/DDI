Public Class Form1


    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim a, b, c As Integer

        a = Int(txtA.Text)
        b = Int(txtB.Text)
        c = Int(txtC.Text)

        Dim x1, x2 As Double

        Try
            x1 = (-b + Math.Sqrt((b ^ 2) - 4 * a * c)) / 2 * a
            x2 = (-b + Math.Sqrt((b ^ 2) - 4 * a * c)) / 2 * a


        Catch ex As Exception


        End Try
        


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtA.Text = 0
        txtB.Text = 0
        txtC.Text = 0
    End Sub
End Class
