Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim jugadores(23) As Integer
        Dim i As Integer

        For i = 0 To 22
            jugadores(i) = 0
        Next

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Votantes"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            While dr.Read
                jugadores(dr("Primero") - 1) += 5
                jugadores(dr("Segundo") - 1) += 3
                jugadores(dr("Tercero") - 1) += 1
            End While

            dr.Close()

            Dim ds As New DataSet()
            Dim da As New OleDb.OleDbDataAdapter

            Dim com As New OleDb.OleDbCommand("SELECT * FROM Jugadores")
            da.SelectCommand = com
            da.SelectCommand.Connection = conexion

            'crear commandbuilder
            Dim cb As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(da)

            da.Fill(ds, "Jugadores")

            For i = 0 To 22
                ds.Tables("Jugadores")(i)("Votos") = jugadores(i)
            Next

            Dim dv As New DataView(ds.Tables("Jugadores"))
            dv.Sort = "Votos DESC"

            lblOro.Text = dv(0)("Apellido") & "-" & dv(0)("Votos")
            lblPlata.Text = dv(1)("Apellido") & "-" & dv(1)("Votos")
            lblBronce.Text = dv(2)("Apellido") & "-" & dv(2)("Votos")

            'ds.Tables("Jugadores").PrimaryKey = {ds.Tables("Jugadores").Columns("Id")}
            'cb.GetUpdateCommand()
            da.Update(ds, "Jugadores")

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try

    End Sub


End Class

