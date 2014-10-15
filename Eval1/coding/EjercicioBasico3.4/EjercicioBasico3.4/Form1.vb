Public Class Form1
    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click
        Dim n As Integer = InputBox("Introduzca un numero")
        txtAns.Text = factorial(n)

    End Sub

    Function factorial(ByVal x As Long) As Long
        Dim b As Long = 1
        For a As Long = 2 To x
            b = b * a
        Next
        Return b
    End Function
End Class
