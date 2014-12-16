Module ModuleLingo
    Function SeleccionaPalabra() As String
        Try
            Dim conexion As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\lingo.mdb;Persist Security Info=False;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select count(*) from palabras"

            Dim n As Integer = cmd.ExecuteScalar()

            cmd.CommandText = "select * from palabras"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            Dim rnd As New Random()
            Dim limite As Integer = rnd.Next(1, n)

            For i = 1 To limite
                dr.Read()
            Next

            Return dr(0).ToString.ToUpper

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion")
            Return ""
            Application.Exit()

        End Try

    End Function

    Function letraEnPalabra(ByVal palabra As String, ByVal letra As Char) As Boolean
        For Each caracter In palabra
            If letra.Equals(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function


    Function existePalabra(ByVal palabra As String) As Boolean
        Try
            Dim conexion As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\lingo.mdb;Persist Security Info=False;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select count(*) from palabras WHERE palabra = '" & palabra + "'"

            Dim n As Integer = cmd.ExecuteScalar()


            conexion.Close()

            If n = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox("Error de conexion")
            Return ""
            Application.Exit()

        End Try
    End Function


    Public Sub saveRanking(ByVal name As String, ByVal time As Int16)
        Try
            Dim conexion As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\lingo.mdb;Persist Security Info=False;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO ranking(nombre, tiempo) VALUES ('" + name + "', '" + time.ToString() + "')"

            cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception
            MsgBox("Error de conexion")
            Application.Exit()

        End Try
    End Sub

End Module
