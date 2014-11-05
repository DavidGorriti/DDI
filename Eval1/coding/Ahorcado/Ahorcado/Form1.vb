Public Class Form1
    Dim word() As Char
    Dim displayWord() As Char
    Dim btnLetras() As Button
    Dim fallos As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pctImage.Image = ImageList1.Images(0)
        btnLetras = {btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnNN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ}

        startGame()
    End Sub

    Private Sub startGame()
        fallos = 0
        txtWord.Text = ""
        For Each b In btnLetras
            b.Enabled = True
        Next

        Dim pal As String = Diccionario.getWord()
        word = pal.ToCharArray
        ReDim displayWord(word.Length)
        Dim i As Integer = 0
        For i = 0 To word.Length - 1
            displayWord(i) = "_"

        Next

        For Each c In displayWord
            txtWord.Text = txtWord.Text + c.ToString
        Next

        Timer1.Start()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        startGame()
    End Sub

    Private Sub letter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnNN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        Dim b As Button = sender
        b.Enabled = False
        Dim selLet As Char = b.Text

        Dim found As Boolean = False
        For i = 0 To word.Length - 1
            If word(i) = selLet Then
                found = True
                displayWord(i) = selLet
            End If
        Next

        If Not found Then
            fallos += 1
            pctImage.Image = ImageList1.Images(fallos)
        End If

        txtWord.Text = ""
        For Each c In displayWord
            txtWord.Text = txtWord.Text + c.ToString
        Next


        checkWin()
    End Sub

    Private Sub checkWin()
        Dim finish As Boolean = True
        If fallos = 6 Then
            MsgBox("HAS PERDIDO")
            startGame()
        Else
            For Each c In displayWord
                If c = "_" Then
                    finish = False
                End If
            Next

            If finish Then
                MsgBox("HAS GANADO")
            End If
        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox("HAS PERDIDO")
        Timer1.Stop()
        startGame()
    End Sub
End Class
