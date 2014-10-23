Module GuiaTelefono

    Structure contacto
        Dim nombre As String
        Dim telefono As String
    End Structure

    Function pedirDimension() As Integer
        Dim longit As Integer = InputBox("Escriba el número de contactos")
        Return longit
    End Function

    Function pedirNombre() As String
        Dim name As String = InputBox("Escriba el nombre del contacto")
        Return name
    End Function

    Function buscarNombre(ByVal agenda() As contacto, ByVal agendaLenght As Integer, ByVal nameToSeek As String) As Integer
        Dim found As Boolean = False
        Dim i As Integer = 0
        While Not found And i < agendaLenght
            If agenda(i).nombre = nameToSeek Then
                found = True
            Else
                i += 1
            End If
        End While
        If found Then
            Return i
        Else
            Return -1
        End If
    End Function


End Module
