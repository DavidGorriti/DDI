Public Class FormDirectores

    Private Sub DirectoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DirectoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PelisDataSet)

    End Sub

    Private Sub FormDirectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PelisDataSet.directores' Puede moverla o quitarla según sea necesario.
        Me.DirectoresTableAdapter.Fill(Me.PelisDataSet.directores)

    End Sub
End Class