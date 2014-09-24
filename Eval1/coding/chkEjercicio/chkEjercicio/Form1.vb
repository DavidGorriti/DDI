Public Class Form1
    Dim contador As Integer = 0

    Private Sub checked(ByVal sender As Object, ByVal e As EventArgs) Handles _
        chk1.CheckedChanged, chk2.CheckedChanged, chk3.CheckedChanged, chk4.CheckedChanged, chk5.CheckedChanged



        Dim chkControl As CheckBox



        chkControl = sender
        If chkControl.Checked Then
            contador = contador + 1
        Else
            contador = contador - 1
        End If


        If contador > 3 Then
            chkControl.Checked = False
        End If

    End Sub
End Class
