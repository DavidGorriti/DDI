Public Class Form1

    Dim precioRaw As Integer
    Dim precioOpciones As Integer
    Dim descuentoOpciones As Integer

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




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pctCar.Location = New Point(pctCar.Location.X - 20, pctCar.Location.Y)

        If pctCar.Location.X <= Me.Width / 2 - pctCar.Width / 2 Then
            Timer1.Stop()

        End If

    End Sub
End Class
