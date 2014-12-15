Public Class Form1

    Private Sub btnPelis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPelis.Click
        Dim F As Form = New FormPelis
        F.Show()
    End Sub

    Private Sub btnDirectores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirectores.Click
        Dim F As Form = New FormDirectores
        F.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
