Public Class Form1

    Dim opciones() As CheckBox

    Dim precioCoche As Integer = 0
    Dim isDiesel As Boolean = False


    Private Sub calculaPrecioCoche()


        If rbtCoupe.Checked Then
            If isDiesel Then
                precioCoche = 17280
            Else
                precioCoche = 18580
            End If
        ElseIf rbtMonovolumen.Checked Then
            If isDiesel Then
                precioCoche = 18100
            Else
                precioCoche = 18900
            End If
        ElseIf rbtFamiliar.Checked Then
            If isDiesel Then
                precioCoche = 19350
            Else
                precioCoche = 20350
            End If
        End If
    End Sub

    Private Sub model_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCoupe.CheckedChanged, rbtFamiliar.CheckedChanged, rbtMonovolumen.CheckedChanged
        Dim button As RadioButton = sender
        If button.Checked Then
            Dim i As Integer = Val(button.Tag)
            If button.Tag = 0 Then
                pctCar.Image = ImageList1.Images(0)
            ElseIf (button.Tag = 1) Then
                pctCar.Image = ImageList1.Images(1)
            ElseIf button.Tag = 2 Then
                pctCar.Image = ImageList1.Images(2)
            End If

            Timer1.Start()
        End If
        pctCar.Location = New Point(Me.Width, 34)

        calculaPrecioCoche()
        calcular()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pctCar.Location = New Point(pctCar.Location.X - 20, pctCar.Location.Y)

        If pctCar.Location.X <= Me.Width / 2 - pctCar.Width / 2 Then
            Timer1.Stop()

        End If

    End Sub

    Private Sub opciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbs.CheckedChanged, chkAirbag.CheckedChanged, chkAire.CheckedChanged, chkAlarma.CheckedChanged, chkAsientosCuero.CheckedChanged, chkCambioAuto.CheckedChanged, chkGps.CheckedChanged, chkPintura.CheckedChanged
        calcular()

    End Sub

    Private Sub calcular()
        Dim descMinimo As Integer = 0
        Dim checked As Integer = 0
        Dim precioOpciones As Integer

        txtPrecioSinOp.Text = precioCoche


        precioOpciones = 0
        For Each opcion In opciones
            If opcion.Checked Then
                precioOpciones += Int(opcion.Tag)
                checked += 1
            End If
        Next

        If checked > 1 Then
            For Each opcion In opciones
                If opcion.Checked Then
                    If descMinimo = 0 Or Int(opcion.Tag) < descMinimo Then
                        descMinimo = Int(opcion.Tag)
                    End If
                End If
            Next
        End If

        txtDescuento.Text = descMinimo
        txtPrecioOpciones.Text = precioOpciones


        txtPrecioFinal.Text = precioCoche + precioOpciones - descMinimo

    End Sub


    Private Sub motor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDiesel.CheckedChanged, rbtGasolina.CheckedChanged

        Dim button As RadioButton = sender

        If button.Text = "Diesel" Then
            isDiesel = True
        Else
            isDiesel = False
        End If

        calculaPrecioCoche()

        calcular()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opciones = {chkAbs, chkAirbag, chkAire, chkAlarma, chkAsientosCuero, chkCambioAuto, chkGps, chkPintura}
    End Sub
End Class
