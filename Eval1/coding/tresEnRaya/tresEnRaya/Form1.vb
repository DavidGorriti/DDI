Public Class Form1
    Dim turn As Integer
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        initialization()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialization()

    End Sub

    Private Sub initialization()
        turn = 1
        For Each ctrlActual As PictureBox In grpbJuego.Controls
            ctrlActual.Tag = 0
            ctrlActual.Image = ImageList.Images(0)
        Next
    End Sub



    Private Sub pic_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click
        Dim picBoxActual As PictureBox = sender
        cardAction(picBoxActual)
        checkEnd()
    End Sub


    Private Sub cardAction(ByVal picBoxActual As PictureBox)

        If picBoxActual.Tag = 0 Then
            picBoxActual.Image = ImageList.Images(turn)
            picBoxActual.Tag = turn
            cambioTurno()
        End If
    End Sub

    Private Sub cambioTurno()
        If turn = 1 Then
            turn = 2
        Else
            turn = 1
        End If
    End Sub


    Private Sub checkEnd()


        If PictureBox1.Tag = 1 And PictureBox2.Tag = 1 And PictureBox3.Tag = 1 Or _
            PictureBox1.Tag = 1 And PictureBox4.Tag = 1 And PictureBox7.Tag = 1 Or _
            PictureBox1.Tag = 1 And PictureBox5.Tag = 1 And PictureBox9.Tag = 1 Or _
            PictureBox2.Tag = 1 And PictureBox5.Tag = 1 And PictureBox8.Tag = 1 Or _
            PictureBox7.Tag = 1 And PictureBox8.Tag = 1 And PictureBox9.Tag = 1 Or _
            PictureBox4.Tag = 1 And PictureBox5.Tag = 1 And PictureBox6.Tag = 1 Or _
            PictureBox7.Tag = 1 And PictureBox5.Tag = 1 And PictureBox3.Tag = 1 Or _
            PictureBox3.Tag = 1 And PictureBox6.Tag = 1 And PictureBox9.Tag = 1 Then

            MsgBox("Ha ganado el jugador 1")
            initialization()

        End If

        If PictureBox1.Tag = 2 And PictureBox2.Tag = 2 And PictureBox3.Tag = 2 Or _
            PictureBox1.Tag = 2 And PictureBox4.Tag = 2 And PictureBox7.Tag = 2 Or _
            PictureBox1.Tag = 2 And PictureBox5.Tag = 2 And PictureBox9.Tag = 2 Or _
            PictureBox2.Tag = 2 And PictureBox5.Tag = 2 And PictureBox8.Tag = 2 Or _
            PictureBox7.Tag = 2 And PictureBox8.Tag = 2 And PictureBox9.Tag = 2 Or _
            PictureBox4.Tag = 2 And PictureBox5.Tag = 2 And PictureBox6.Tag = 2 Or _
            PictureBox7.Tag = 2 And PictureBox5.Tag = 2 And PictureBox3.Tag = 2 Or _
            PictureBox3.Tag = 2 And PictureBox6.Tag = 2 And PictureBox9.Tag = 2 Then

            MsgBox("Ha ganado el jugador 2")
            initialization()

        End If

    End Sub
End Class
