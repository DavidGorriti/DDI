Public Class Form1



    Private Sub btnComprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.Click
        Dim aciertos As Integer = 0

        For Each numero As TextBox In grpNumbers.Controls
            For Each selects As CheckBox In grpSelection.Controls
                If numero.Text = selects.Text And selects.Checked Then
                    aciertos = aciertos + 1
                End If
            Next
        Next

        lblResultado.Text = aciertos

    End Sub
End Class
