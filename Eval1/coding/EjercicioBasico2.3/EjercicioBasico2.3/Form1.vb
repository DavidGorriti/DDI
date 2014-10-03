Public Class Form1


    Private Sub btnComprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.Click
        Dim correct As Boolean = True
        For Each Control As TextBox In grpInputs.Controls
            If Control.Text.ToLower <> "x" And Control.Text.ToLower <> "1" And Control.Text.ToLower <> "2" Then
                correct = False
            End If
        Next

        For Each Control As TextBox In grpRes.Controls
            If Control.Text.ToLower <> "x" And Control.Text.ToLower <> "1" And Control.Text.ToLower <> "2" Then
                correct = False
            End If
        Next

        If correct = False Then
            MsgBox("Ha introducido uno o varios valores incorrectos")

        Else

            checkResultados()

        End If

    End Sub

    Private Sub checkResultados()

        Dim input(14) As TextBox
        Dim res(14) As TextBox


        For i As Integer = 0 To 14

        Next

    End Sub

End Class
