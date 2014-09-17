Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim nX As Integer = pctMushStatic.Location.X + 2
        Dim nY As Integer = pctMushStatic.Location.Y + 2

        pctMushStatic.Location = New Point(nX, nY)

    End Sub

End Class
