Public Class Form1

    Dim Precio As Integer



    Private Sub CalcularPrecio()
        Precio = 300

        If RBi3.Checked Then
            Precio = Precio + 100
        End If
        If RBi5.Checked Then
            Precio = Precio + 200
        End If
        If RBAMD.Checked Then
            Precio = Precio + 150
        End If

        If CBAltavoces.Checked Then
            Precio = Precio + 50
        End If
        If CBMonitor.Checked Then
            Precio = Precio + 150
        End If

        If CBTarjetaG.Enabled Then
            If RBNVidia.Checked Then
                Precio = Precio + 200
            End If
            If RBintel.Checked Then
                Precio = Precio + 100
            End If
            If RBati.Checked Then
                Precio = Precio + 180
            End If
        End If

        TBPrecio.Text = Precio
    End Sub




    Private Sub CBTarjetaG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTarjetaG.CheckedChanged
        If CBTarjetaG.Checked Then
            GBTarjetaG.Enabled = True
        Else
            GBTarjetaG.Enabled = False
        End If
        CalcularPrecio()

    End Sub

    Private Sub RBi3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBi3.CheckedChanged
        CalcularPrecio()
    End Sub

    Private Sub RBi5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBi5.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub RBAMD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAMD.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub CBMonitor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMonitor.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub CBAltavoces_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAltavoces.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub RBNVidia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNVidia.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub RBintel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBintel.CheckedChanged
        CalcularPrecio()

    End Sub

    Private Sub RBati_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBati.CheckedChanged
        CalcularPrecio()

    End Sub
End Class
