Public Class Form1
    Dim dimension As Integer
    Dim agenda() As contacto
    Dim i As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = False
        dimension = pedirDimension()
        ReDim agenda(dimension)
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        

        agenda(i).nombre = txtNombre.Text
        agenda(i).telefono = txtTelefono.Text
        i += 1
        If i >= dimension Then
            MsgBox("Has llenado la agenda")
            btnSiguiente.Enabled = False
            btnBuscar.Enabled = True
        End If
        txtNombre.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim nombre As String = pedirNombre()
        Dim pos As Integer = buscarNombre(agenda, dimension, nombre)

        If pos = -1 Then
            MsgBox("El nombre no está en la agenda")
        Else
            txtNombre.Text = agenda(pos).nombre
            txtTelefono.Text = agenda(pos).telefono
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
