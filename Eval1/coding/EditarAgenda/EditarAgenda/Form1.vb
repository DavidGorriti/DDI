Public Class Form1

    Private Sub AgendaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AgendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgendaDBDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgendaDBDataSet.Agenda' Puede moverla o quitarla según sea necesario.
        Me.AgendaTableAdapter.Fill(Me.AgendaDBDataSet.Agenda)

    End Sub
End Class
