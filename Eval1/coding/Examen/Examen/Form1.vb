Public Class frmExamen
    Dim ventas(4, 9) As billetes
    ' ventas(2,5).reducido --> billetes vendidos a precio reducido 
    ' en la tercera sesión de la sexta película.
    Dim cont As Integer = 0
    Dim precioCurrentUnidad As Double = 6
    Dim precioCurrentFinal As Double
    Dim diaEspec As Boolean = False
    Dim reducido As Boolean = False

    Private Sub frmExamen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cont = 0
        If Weekday(Date.Now) = 4 Then
            cbxEspectador.Checked = True
            diaEspec = True
        End If
        tmrMarquesina.Start()

    End Sub

    Private Sub lbxPelis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxPelis.SelectedIndexChanged
        ptbCartel.Image = ImageList1.Images(lbxPelis.SelectedIndex())

    End Sub

    Private Sub tmrMarquesina_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMarquesina.Tick

        If cont = 15 Then
            If lbxPelis.SelectedIndex <> 9 Then
                lbxPelis.SelectedIndex = lbxPelis.SelectedIndex + 1
            Else
                lbxPelis.SelectedIndex = 0
            End If
            tmrMarquesina.Stop()
            cont = 0
            tmrMarquesina.Start()
        End If

        cont = cont + 1


    End Sub

    Private Sub btnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenta.Click
        tmrMarquesina.Stop()

        If cbSesion.SelectedIndex >= 0 And lbxPelis.SelectedIndex >= 0 And txtEntradas.Text <> "" Then
            If saveCompra(cbSesion.SelectedIndex, lbxPelis.SelectedIndex, Int(txtEntradas.Text)) Then
                MsgBox("Compra realizada")
            Else
                MsgBox("La compra no se ha podido realizar, no quedan plazas libres")
            End If
        Else
            MsgBox("Debe seleccionar la sesion, la pelicula y la cantidad de entradas")
        End If

        cont = 0
        tmrMarquesina.Start()
    End Sub

    Private Sub options_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNormal.CheckedChanged, rbtGazteKutxa.CheckedChanged, rbtGazteTxartela.CheckedChanged, rbtJubilado.CheckedChanged

        Dim seleccion As RadioButton = sender
        If Not diaEspec Then
            If Int(seleccion.Tag) = 0 Then
                precioCurrentUnidad = 6
                reducido = False
            Else
                precioCurrentUnidad = 4.5
                reducido = True
            End If

            lblPrecioUnin.Text = precioCurrentUnidad
        End If
        calculaPrecioTot()
    End Sub

    Private Sub txtEntradas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntradas.TextChanged
        calculaPrecioTot()
    End Sub

    Private Sub cbxEspectador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEspectador.CheckedChanged
        
        If cbxEspectador.Checked Then
            precioCurrentUnidad = 4
            diaEspec = True
        Else
            If reducido Then
                precioCurrentUnidad = 4.5
            Else
                precioCurrentUnidad = 6
            End If
            diaEspec = False
        End If
        lblPrecioUnin.Text = precioCurrentUnidad
        calculaPrecioTot()
    End Sub

    'Comprueba si hay plazas y efectua la venta'
    Function saveCompra(ByVal sala As Integer, ByVal sesion As Integer, ByVal cantidad As Integer) As Boolean

        If (ventas(sala, sesion).normal + ventas(sala, sesion).reducido) + cantidad <= 25 Then
            If reducido Then
                ventas(sala, sesion).reducido = ventas(sala, sesion).reducido + cantidad
                Return True
            Else
                ventas(sala, sesion).normal = ventas(sala, sesion).normal + cantidad
                Return True
            End If
        End If
        Return False
    End Function

    'Calcula el precio total de la venta'
    Private Sub calculaPrecioTot()
        If txtEntradas.Text <> "" Then
            precioCurrentFinal = Int(txtEntradas.Text) * precioCurrentUnidad
            lblImporteTot.Text = precioCurrentFinal
        End If
    End Sub


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PelículaMasVistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelículaMasVistaToolStripMenuItem.Click
        Dim n As Integer = peliMasVista(ventas)
        MsgBox("La pelicula más vista ha sido " + lbxPelis.Items(n))


    End Sub

    Private Sub PorcentajeOcupaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorcentajeOcupaciónToolStripMenuItem.Click
        Dim result As String = "Porcentajes de ocupacion:\r\n"


        For j As Integer = 0 To 8
            Dim counter As Integer = porcentajeOcupacion(ventas, j)
            Dim temp As String = lbxPelis.Items(j) & " - " & counter & "%"
            result = result & vbCrLf & temp
        Next
        MsgBox(result)
    End Sub

    Private Sub CajaDelDíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaDelDíaToolStripMenuItem.Click
        Dim res As Double = cajaDelDia(ventas, diaEspec)
        MsgBox("La caja del dia es de " & res)
    End Sub
End Class
