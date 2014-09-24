Public Class Form1

    Private Sub checked(ByVal sender As Object, ByVal e As EventArgs) Handles _
        chk1.CheckedChanged, chk2.CheckedChanged, chk3.CheckedChanged, chk4.CheckedChanged, chk5.CheckedChanged


        Dim contador As Integer = 0
        Dim chkControl As CheckBox

        For Each chkControl In grp1.Controls
            If chkControl.Checked Then
                contador = contador + 1
            End If
        Next


        If contador > 3 Then
            chkControl = sender
            chkControl.Checked = False
        End If

    End Sub
End Class
