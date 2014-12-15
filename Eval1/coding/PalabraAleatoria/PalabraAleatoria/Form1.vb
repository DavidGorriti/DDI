Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LingoDataSet.palabras' Puede moverla o quitarla según sea necesario.
        Me.PalabrasTableAdapter.Fill(Me.LingoDataSet.palabras)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim rnd As New Random
        n = rnd.Next(PalabrasBindingSource.Count) + 1
        PalabrasBindingSource.Position = n

    End Sub
End Class
