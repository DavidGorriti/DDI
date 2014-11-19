Public Class Form1
    Dim arr(1, 1) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReDim arr(PedirValores("X"), PedirValores("Y"))

        'rellenar array


    End Sub



    Function PedirValores(ByVal mode) As Integer
        Dim X As Integer = -1
        Dim Y As Integer = -1

        If mode = "X" Then
            While X = -1
                Dim xT As String = InputBox("Introduzca valor horizontal de la matriz", "Valor Horizontal", -1)
                If IsNumeric(xT) And xT <> -1 Then
                    X = Val(xT)
                    Return X
                End If
            End While
        End If

        If mode = "Y" Then
            While Y = -1
                Dim yT As String = InputBox("Introduzca valor vertical de la matriz", "Valor Vertical", -1)
                If IsNumeric(yT) And yT <> -1 Then
                    Y = Val(yT)
                    Return Y
                End If
            End While
        End If

    End Function
End Class
