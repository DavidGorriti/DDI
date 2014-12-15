Public Class FormPelis

    Private Sub PelisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PelisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PelisDataSet)

    End Sub

    Private Sub FormPelis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PelisDataSet.directores' Puede moverla o quitarla según sea necesario.
        Me.DirectoresTableAdapter.Fill(Me.PelisDataSet.directores)
        'TODO: esta línea de código carga datos en la tabla 'PelisDataSet.Pelis' Puede moverla o quitarla según sea necesario.
        Me.PelisTableAdapter.Fill(Me.PelisDataSet.Pelis)

    End Sub
End Class