Module Diccionario
    Dim words() As String = {"CODIGO", "GITHUB", "FRAMEWORK", "BASIC"}


    Function getWord() As String
        Dim rnd As New Random()

        Return words(rnd.Next(4))
    End Function
End Module
