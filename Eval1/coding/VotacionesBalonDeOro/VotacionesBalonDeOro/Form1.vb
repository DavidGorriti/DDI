Public Class Form1
    Dim votanteID As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadPaises()
        loadCargos()
        loadJugadores()
    End Sub

    Private Sub loadPaises()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT DISTINCT Pais FROM Votantes"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            While dr.Read
                cmbPaises.Items.Add(dr(0))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub loadCargos()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT DISTINCT Puesto FROM Votantes"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            While dr.Read
                cmbCargos.Items.Add(dr(0))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub loadJugadores()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Apellido FROM Jugadores"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            While dr.Read
                cmbP1.Items.Add(dr(0))
                cmbP2.Items.Add(dr(0))
                cmbP3.Items.Add(dr(0))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub



    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtNombre.Text <> "" And cmbPaises.SelectedIndex <> -1 And cmbCargos.SelectedIndex <> -1 Then
            checkAcreditacion(txtNombre.Text, cmbPaises.SelectedItem, cmbCargos.SelectedItem)
        Else
            MsgBox("Todos los campos son requeridos")
        End If
    End Sub

    Private Sub checkAcreditacion(ByVal nombre As String, ByVal pais As String, ByVal cargo As String)
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Id FROM Votantes WHERE Nombre='" + nombre + "' AND Puesto='" + cargo + "' AND Pais='" + pais + "'"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            If dr.Read() Then
                votanteID = dr(0)
                startSegundaFase()
            Else
                btnLogin.BackColor = Color.Red
            End If


            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub startSegundaFase()
        cmbCargos.Enabled = False
        cmbPaises.Enabled = False
        txtNombre.Enabled = False
        btnLogin.Enabled = False
        btnLogin.BackColor = Color.LightGreen
        btnLogin.Text = "ACREDITADO"

        cmbP1.Enabled = True
        cmbP2.Enabled = True
        cmbP3.Enabled = True
        btnVotar.Enabled = True
    End Sub

    Private Sub btnVotar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVotar.Click
        If cmbP1.SelectedIndex = cmbP2.SelectedIndex Or cmbP1.SelectedIndex = cmbP3.SelectedIndex Or cmbP2.SelectedIndex = cmbP3.SelectedIndex Then
            MsgBox("No puede repetir jugador")
        ElseIf cmbP1.SelectedIndex <> -1 And cmbP2.SelectedIndex <> -1 And cmbP3.SelectedIndex <> -1 Then
            updateVotos(cmbP1.SelectedIndex + 1, cmbP2.SelectedIndex + 1, cmbP3.SelectedIndex + 1)
        Else
            MsgBox("Debe seleccionar tres jugadores")
        End If
    End Sub

    Private Sub updateVotos(ByVal p1 As Integer, ByVal p2 As Integer, ByVal p3 As Integer)
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Votantes SET Primero=" + p1.ToString + ", Segundo=" + p2.ToString + ", Tercero=" + p3.ToString + " WHERE Id=" + votanteID.ToString

            cmd.ExecuteNonQuery()
            btnVotar.BackColor = Color.LightGreen
            btnVotar.Text = "HAS VOTADO!"
            cmbP1.Enabled = False
            cmbP2.Enabled = False
            cmbP3.Enabled = False
            btnVotar.Enabled = False

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

End Class
