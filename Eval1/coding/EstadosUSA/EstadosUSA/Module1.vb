Module Module1
    Public Function Obtener4numeros(ByRef lista() As Integer) As Integer
        Dim ans As Integer
        Dim rnd As Random = New Random

        For i As Integer = 0 To 3
            lista(i) = rnd.Next(50)
        Next

        ans = rnd.Next(4)
        Return ans
    End Function

End Module
