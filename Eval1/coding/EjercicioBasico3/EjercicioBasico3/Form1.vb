Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()

    End Sub
    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            lblBase.Text = lblBase.Text + 1
        End If

        If e.KeyCode = Keys.Down Then
            lblBase.Text = lblBase.Text - 1
        End If

        reload()

    End Sub

    Private Sub reload()
        lblRes.Text = Math.Pow(lblNum.Text, lblBase.Text)
    End Sub

End Class
