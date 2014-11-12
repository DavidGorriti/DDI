Module Module1
    Structure billetes
        Dim reducido As Integer
        Dim normal As Integer
    End Structure


    Function peliMasVista(ByVal ventas) As Integer
        Dim jmax As Integer
        Dim maxVent As Integer


        For j As Integer = 0 To 8
            Dim counter As Integer = 0
            For i As Integer = 0 To 3
                counter = counter + ventas(i, j).normal + ventas(i, j).reducido
            Next
            If counter > maxVent Then
                jmax = j
                maxVent = counter
            End If
        Next
        Return jmax
    End Function

    Function porcentajeOcupacion(ByVal ventas, ByVal j) As Integer

        Dim counter As Integer = 0
        For i As Integer = 0 To 3
            counter = counter + ventas(i, j).normal + ventas(i, j).reducido
        Next
        Return counter
    End Function


    Function cajaDelDia(ByVal ventas, ByVal isDiaEspectador) As Double
        Dim resRed As Integer = 0
        Dim resNorm As Integer = 0
        Dim res As Double = 0

        For j As Integer = 0 To 8
            For i As Integer = 0 To 3
                resNorm = resNorm + ventas(i, j).normal
                resRed = resRed + ventas(i, j).reducido
            Next
        Next

        If isDiaEspectador Then
            res = (resNorm + resRed) * 4
        Else
            res = (resNorm * 6) + (resRed * 4.5)
        End If

        Return res
    End Function
End Module
