Public Class Form1
    Dim aAlumnos() As String = {"Unai", "David"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each alumno In aAlumnos
            lstAlumnos.Items.Add(alumno)
        Next

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtNombre.Text.Trim = "" Then
            MsgBox("Debes introducir un nombre")
        Else
            txtNombre.Text = ""
        End If

        txtNombre.Focus()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click

        If lstAlumnos.SelectedIndex <> -1 Then
            lstParticipantes.Items.Add(lstAlumnos.SelectedItem)
            lstAlumnos.Items.Remove(lstAlumnos.SelectedItem)

        End If



    End Sub

    Private Sub lstAlumnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAlumnos.SelectedIndexChanged
        btnAnadir.Enabled = True
    End Sub



    Private Sub lstParticipantes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstParticipantes.SelectedIndexChanged
        btnQuitar.Enabled = True
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If lstParticipantes.SelectedIndex <> -1 Then
            lstAlumnos.Items.Add(lstParticipantes.SelectedItem)
            lstParticipantes.Items.Remove(lstParticipantes.SelectedItem)

        End If
    End Sub
End Class
