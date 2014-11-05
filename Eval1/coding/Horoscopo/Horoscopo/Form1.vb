Public Class Form1

 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDia.Text = 1
        txtMes.Text = 1
    End Sub

    Private Sub params_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDia.TextChanged, txtMes.TextChanged
        If fechaValida(Int(txtDia.Text), Int(txtMes.Text)) Then
            ModHoroscopo.muestraHoroscopo(Int(txtDia.Text), Int(txtMes.Text), txtHoroscopo)
        End If
    End Sub
End Class
