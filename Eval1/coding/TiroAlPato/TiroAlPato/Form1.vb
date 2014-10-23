Public Class Form1
    Dim patoActivo As PictureBox

    Dim patos() As PictureBox
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        reiniciaPato()
        Timer1.Start()

        txtScore.Text = 0

        btnStart.Enabled = False
        btnStop.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pctPatoLento.Visible = False
        pctPatoRapido.Visible = False
        btnStop.Enabled = False
        patos = {pctPatoLento, pctPatoRapido}
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If patoActivo.Location.X > pnlGame.Width - patoActivo.Width Then
            endGame()
        End If

        Dim pX As Integer = patoActivo.Location.X + Int(patoActivo.Tag)
        Dim pY As Integer = patoActivo.Location.Y

        patoActivo.Location = New Point(pX, pY)



    End Sub


    Private Sub reiniciaPato()
        Dim rnd As Random = New Random


        pctPatoLento.Location = New Point(0, rnd.Next(pnlGame.Height - pctPatoRapido.Height))
        pctPatoRapido.Location = New Point(0, rnd.Next(pnlGame.Height - pctPatoRapido.Height))


        Dim n = rnd.Next(10)

        If Not (n = 9) Then
            patoActivo = pctPatoLento
        Else
            patoActivo = pctPatoRapido
        End If

        patoActivo.Visible = True


    End Sub

    Private Sub pato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctPatoLento.Click, pctPatoRapido.Click

        If patoActivo.Name = "pctPatoLento" Then
            txtScore.Text = Int(txtScore.Text) + 1
        Else
            txtScore.Text = Int(txtScore.Text) + 5
        End If

        patoActivo.Visible = False
        reiniciaPato()

    End Sub

    Private Sub endGame()
        Timer1.Stop()
        MsgBox("Fin del juego. Puntuacion: " + txtScore.Text)

        btnStart.Enabled = True
        btnStop.Enabled = False


    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        endGame()

    End Sub
End Class
