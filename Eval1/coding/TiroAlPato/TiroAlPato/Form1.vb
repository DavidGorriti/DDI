Public Class Form1
    Dim patos() As PictureBox
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pctPatoLento.Visible = False
        pctPatoRapido.Visible = False
        patos = {pctPatoLento, pctPatoRapido}
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rnd As Random = New Random

        Dim n = rnd.Next(10)

        If Not (n = 9) Then

        Else

        End If
    End Sub
End Class
