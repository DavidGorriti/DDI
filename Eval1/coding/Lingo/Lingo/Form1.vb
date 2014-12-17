Public Class Form1

    Dim palabra As String
    Dim palabraIntroducida As String = ""
    Dim tablaTextBox(,) As TextBox
    Dim currentLinea As Integer = 0
    Dim time As Double = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        palabra = SeleccionaPalabra()
        MsgBox(palabra)

        tablaTextBox = {{TextBox1, TextBox2, TextBox3, TextBox4, TextBox5},
                        {TextBox6, TextBox7, TextBox8, TextBox9, TextBox10},
                        {TextBox11, TextBox12, TextBox13, TextBox14, TextBox15},
                        {TextBox16, TextBox17, TextBox18, TextBox19, TextBox20},
                        {TextBox21, TextBox22, TextBox23, TextBox24, TextBox25}
                       }

        Timer1.Start()

    End Sub

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox16.TextChanged, TextBox17.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox21.TextChanged, TextBox22.TextChanged, TextBox23.TextChanged, TextBox24.TextChanged

        sender.Enabled = False
        Me.SelectNextControl(sender, True, True, True, True)

    End Sub

    Private Sub txtLast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged, TextBox10.TextChanged, TextBox15.TextChanged, TextBox20.TextChanged, TextBox25.TextChanged
        palabraIntroducida = ""
        For i = 0 To 4
            palabraIntroducida += tablaTextBox(currentLinea, i).Text.ToUpper
        Next

        If existePalabra(palabraIntroducida) Then
            cambiaColor()
        Else
            MsgBox("No existe")
        End If


        sender.Enabled = False


        If checkPalabra(palabraIntroducida) Then
            finalizaJuego()
        Else
            If currentLinea < 4 Then
                currentLinea += 1

            Else
                MsgBox("Se te acabó el chollo")
                Me.Close()

            End If
        End If

        Me.SelectNextControl(sender, True, True, True, True)

    End Sub


    Private Sub cambiaColor()
        Dim listaLetras(5) As Char
        For i = 0 To 4
            If palabraIntroducida(i) = palabra(i) Then
                tablaTextBox(currentLinea, i).BackColor = Color.LightGreen
                listaLetras(i) = palabraIntroducida(i)
            Else
                Dim yaPintada As Boolean = False
                For j = 0 To 4
                    If palabraIntroducida(i) = listaLetras(j) Then
                        yaPintada = True
                    End If
                Next

                For k = 0 To 4
                    If palabraIntroducida(i) = palabra(k) And yaPintada = False Then
                        tablaTextBox(currentLinea, i).BackColor = Color.Red
                    End If
                Next

            End If
        Next
    End Sub

    Function checkPalabra(ByVal palabraIntroducida As String) As Boolean
        If palabraIntroducida = palabra Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub finalizaJuego()
        Dim name As String = InputBox("Ha ganado! Introduzca su nombre")
        saveRanking(name, time)

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time += 1
    End Sub


    Private Sub RankingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RankingToolStripMenuItem.Click
        Ranking.show()
    End Sub


End Class
