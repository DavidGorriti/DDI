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
        Dim counter As Integer = 0
        Dim input(14) As TextBox
        Dim res(14) As TextBox

        input = New TextBox(14) {txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15}
        res = New TextBox(14) {txtRes1, txtRes2, txtRes3, txtRes4, txtRes5, txtRes6, txtRes7, txtRes8, txtRes9, txtRes10, txtRes11, txtRes12, txtRes13, txtRes14, txtRes15}

        For i As Integer = 0 To 14
            If input(i).Text = res(i).Text Then
                counter = counter + 1
            End If
        Next

        lblRes.Text = counter + " aciertos"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRes.Text = 0
    End Sub
End Class
