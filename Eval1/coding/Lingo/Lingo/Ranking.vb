Public Class Ranking

    Private Sub Ranking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getRanking()

    End Sub



    Public Sub getRanking()
        Try
            Dim conexion As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\lingo.mdb;Persist Security Info=False;")
            conexion.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TOP 10 nombre, tiempo FROM ranking ORDER BY tiempo"

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                dgvRanking.Rows.Add(dr(0), dr(1))
            End While

                conexion.Close()

        Catch ex As Exception
            MsgBox("Error de conexion")


        End Try
    End Sub
End Class