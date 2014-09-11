Public Class Form1
    

    Dim ingredientes() As String = {"Ajo", "Brócoli", "Espagueti", "Funghi", "Parmesano", "Sal", "Salsa bolognesa"}


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each ing In ingredientes
            lstIngredientesOpc.Items.Add(ing)
        Next
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If lstIngredientesOpc.SelectedIndex <> -1 Then
            lstIngredientesAsign.Items.Add(lstIngredientesOpc.SelectedItem)
            lstIngredientesOpc.Items.Remove(lstIngredientesOpc.SelectedItem)
        End If

        If lstIngredientesOpc.Items.Count = 0 Then
            btnAnadir.Enabled = False
        End If
    End Sub



    Private Sub lstIngredientesOpc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIngredientesOpc.SelectedIndexChanged
        btnAnadir.Enabled = True
    End Sub

    Private Sub lstIngredientesAsign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIngredientesAsign.SelectedIndexChanged
        btnQuitar.Enabled = True
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        If lstIngredientesAsign.SelectedIndex <> -1 Then
            lstIngredientesOpc.Items.Add(lstIngredientesAsign.SelectedItem)
            lstIngredientesAsign.Items.Remove(lstIngredientesAsign.SelectedItem)
        End If

        If lstIngredientesAsign.Items.Count = 0 Then
            btnQuitar.Enabled = False
        End If
    End Sub

    Private Sub rbLlevar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLlevar.CheckedChanged
        If rbLlevar.Checked Then
            grpEnvase.Enabled = True
        Else
            grpEnvase.Enabled = False
        End If
    End Sub

    Private Sub btnEspecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEspecial.Click
        Dim tempIng As String = InputBox("Introduzca un ingrediente especial:", "")

        lstIngredientesAsign.Items.Add(tempIng)
    End Sub

    Private Sub btnNuevoPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPlato.Click
        If txtPlato.Text = "" Then
            MsgBox("Debe introducir un nombre para el plato!")
        Else
            lstIngredientesAsign.Items.Clear()
            lstIngredientesOpc.Items.Clear()
            For Each ing In ingredientes
                lstIngredientesOpc.Items.Add(ing)
            Next
        End If
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        MsgBox("Buen provecho!")
        Me.Close()

    End Sub
End Class
