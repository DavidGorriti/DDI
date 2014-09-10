Public Class Form1
    Dim aAlumnos() As String = {"Unai", "David"}
    Dim aParticipantes() As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loadData()

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
            'TODO'
        End If
        lstParticipantes.Items.Add(lstAlumnos.SelectedIndex)


        loadData()

    End Sub

    Private Sub lstAlumnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAlumnos.SelectedIndexChanged
        btnAnadir.Enabled = True
    End Sub

    Private Sub loadData()
        For Each alumno In aAlumnos
            lstAlumnos.Items.Add(alumno)
        Next

        For Each participante In aParticipantes
            lstParticipantes.Items.Add(participante)
        Next
    End Sub

    Private Sub lstParticipantes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstParticipantes.SelectedIndexChanged
        btnQuitar.Enabled = True
    End Sub
End Class
