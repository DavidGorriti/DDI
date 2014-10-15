Public Class Form1

    Private Sub hscBarra_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscBarra.Scroll
        Dim bar As HScrollBar = sender

        txtC.Text = bar.Value
        txtF.Text = bar.Value * 1.8 + 32

        If bar.Value < -10 Then
            Me.BackColor = Color.Blue
        ElseIf bar.Value > 10 Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Orange
        End If
    End Sub
End Class
