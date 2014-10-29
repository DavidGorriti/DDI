Public Class Form1

    Private Sub pct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctTijera.Click, pctPiedra.Click, pctPapel.Click

        Dim rnd As Random = New Random()
        Dim index As Int16 = rnd.Next(3)
        pctRival.Image = ImageList1.Images(rnd.Next(3))
        pctRival.Tag = index
        Dim clicked As PictureBox = sender

        Select Case index
            Case 0
                If Val(clicked.Tag) = 1 Then
                    txtScorePlayer.Text = Val(txtScorePlayer.Text) + 1
                ElseIf Val(clicked.Tag) = 2 Then
                    txtScoreRival.Text = Val(txtScoreRival.Text) + 1
                End If
            Case 1
                If Val(clicked.Tag) = 0 Then
                    txtScoreRival.Text = Val(txtScoreRival.Text) + 1
                ElseIf Val(clicked.Tag) = 2 Then
                    txtScorePlayer.Text = Val(txtScorePlayer.Text) + 1
                End If
            Case 2
                If Val(clicked.Tag) = 0 Then
                    txtScoreRival.Text = Val(txtScoreRival.Text) + 1
                ElseIf Int(clicked.Tag) = 1 Then
                    txtScorePlayer.Text = Val(txtScorePlayer.Text) + 1
                End If
        End Select


        checkFinal()


    End Sub

    Private Sub startGame()
        txtScorePlayer.Text = 0
        txtScoreRival.Text = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startGame()
    End Sub

    Private Sub checkFinal()

        If txtScorePlayer.Text = 10 Then
            MsgBox("HAS GANADO")
            startGame()
        ElseIf txtScoreRival.Text = 10 Then
            MsgBox("HAS PERDIDO")
            startGame()
        End If



    End Sub

End Class
