Public Class Form1

    Dim Xi As Integer
    Dim Yi As Integer

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub pnlPlayground_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPlayground.MouseEnter
        Cursor.Hide()
    End Sub

    Private Sub pnlPlayground_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPlayground.MouseLeave
        Cursor.Show()
    End Sub


    Private Sub pnlPlayground_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlPlayground.MouseMove
        If e.Y > pnlPlayground.Height - pctPaddle.Height Then

            pctPaddle.Location = New Point(pctPaddle.Location.X, pnlPlayground.Height - pctPaddle.Height)

        Else

            pctPaddle.Location = New Point(pctPaddle.Location.X, e.Y)

        End If


    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        pctPaddle.Location = New Point(pctPaddle.Location.X, (pnlPlayground.Height / 2) - (pctPaddle.Height / 2))

        btnStart.Enabled = False
        btnStop.Enabled = True

        Dim rnd As Random = New Random
        Dim direction As Integer

        pctBall.Location = New Point(10, rnd.Next(pnlPlayground.Height - pctBall.Height))

        Xi = 10
        direction = rnd.Next(3)

        Select Case direction
            Case 0
                Yi = -10
            Case 1
                Yi = 0
            Case 2
                Yi = 10
        End Select


        Timer1.Start()





    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False

        Timer1.Stop()

    End Sub




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If pctBall.Location.Y > pnlPlayground.Height - pctBall.Height Then
            Yi = -10
        ElseIf pctBall.Location.Y < 0 Then
            Yi = 10
        End If

        If pctBall.Location.X > pctPaddle.Location.X - pctBall.Width Then

            If pctBall.Location.Y >= pctPaddle.Location.Y And pctBall.Location.Y + pctBall.Height < pctPaddle.Location.Y + pctPaddle.Height Then


                Xi = -10
                lblScore.Text = Val(lblScore.Text) + 1

            Else
                Timer1.Stop()
                MsgBox("JUEGO TERMINADO!")
                btnStart.Enabled = True
                btnStop.Enabled = False



            End If
        ElseIf pctBall.Location.X < 0 Then
            Xi = 10
        End If

        pctBall.Location = New Point(pctBall.Location.X + Xi, pctBall.Location.Y + Yi)
    End Sub
End Class
