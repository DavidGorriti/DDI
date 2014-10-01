Public Class Form1

    Private Sub checked(ByVal sender As Object, ByVal e As EventArgs) Handles chkEstudiante.CheckedChanged, chkFamilia.CheckedChanged

        Dim pulsado As CheckBox = sender

        If pulsado.Tag = "fmln" Then
            If pulsado.Checked Then
                lblResultado.Text = lblResultado.Text * 0.8
            Else
                lblResultado.Text = lblResultado.Text / 0.8
            End If

        End If

        If pulsado.Tag = "est" Then
            If pulsado.Checked Then
                lblResultado.Text = lblResultado.Text * 0.9
            Else
                lblResultado.Text = lblResultado.Text / 0.9
            End If

        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResultado.Text = 10
    End Sub

    Private Sub rbChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIndividual.CheckedChanged, rbInfantil.CheckedChanged, rbJoven.CheckedChanged, rbJubilados.CheckedChanged
        Dim pulsado As RadioButton = sender


        calculateDisctount()

    End Sub

    Private Sub calculateDisctount()

        If chkEstudiante.Checked Then
            lblResultado.Text = lblResultado.Text * 0.8

        End If



        If chkFamilia.Checked Then
            lblResultado.Text = lblResultado.Text * 0.8

        End If

    End Sub
End Class
