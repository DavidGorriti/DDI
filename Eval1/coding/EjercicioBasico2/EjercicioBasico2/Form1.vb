Public Class Form1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        txtTotal.Text = txtCantidad.Text * txtPVP.Text
        txtTotalDescuento.Text = txtTotal.Text * (txtDescuento.Text / 100)
        txtTotalIVA.Text = txtTotal.Text * (txtIVA.Text / 100)

        txtImporte.Text = txtTotal.Text - txtTotalDescuento.Text + txtTotalIVA.Text
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class