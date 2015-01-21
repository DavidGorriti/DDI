Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadPaises()
        loadCargos()
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

End Class
