Module ModHoroscopo

    Public Function fechaValida(ByVal mes As Integer, ByVal dia As Integer) As Boolean
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                If dia > 0 And dia <= 31 Then
                    Return True
                Else
                    Return False
                End If
            Case 4, 6, 9, 11
                If dia > 0 And dia <= 30 Then
                    Return True
                Else
                    Return False
                End If
            Case 2
                If dia > 0 And dia <= 28 Then
                    Return True
                Else
                    Return False
                End If
        End Select
    End Function


    Public Sub muestraHoroscopo(ByVal mes As Integer, ByVal dia As Integer, ByVal txtBox As TextBox)
        If fechaValida(mes, dia) Then
            txtBox.Text = getHoroscopoText(mes, dia)
        End If
    End Sub

    Private Function getHoroscopoText(ByVal mes As Integer, ByVal dia As Integer) As String
        Dim aries As String = "Personas fuertes, con energía, institivos y dinámicos... con coraje. a veces egocentristas, tienden a acaparar el liderazgo, signo vital asociado a grandes deportistas de competición."
        Dim tauro As String = "Personas resistentes, pacientes, que saben guardar la calma. Tienen como activo la inteligencia. Son personas muy realistas."
        Dim geminis As String = "Contradictorios y versátiles, cambian con facilidad. Pasan de ser serenos, y fascinantes, a pesimistas y amorfos. Fantasiosos, aman la libertad e independencia."
        Dim cancer As String = "Familares, tímidos, posesivos, imaginativos y románticos. Dulces que viajan entre la melancolía y la alegría."
        Dim leo As String = "Extrovertidos, autoritarios,libres, fuertes, pasionales y generosos. Optimistas y a veces un poco imprudentes."
        Dim virgo As String = "Meticulosos en los detalles, eficientes, severos y racionales en su vida y trabajo. Buenos ahorradores."
        Dim libra As String = "Diplomatico, encantador y sociable. Los libra son idealistas, pacíficos, optimistas y románticos."
        Dim escorpio As String = "Los más intuitivos, tienden a ser profundos y serios, autoritario, celoso, posesivo pero mutables y pasionales."
        Dim sagitario As String = "Confiados, alegres, sinceros, fieles amigos, amantes de la naturaleza y el aire libre."
        Dim capricornio As String = "Son introvertidos impulsivos... Rasgos en ellos son la timidez y la inseguridad; perfil ambicioso, frío, melancólico, pero son afectuosos."
        Dim acuario As String = "Sinceros, altruistas, simpáticos y activos, pero pasan por momentos de gran nerviosismo y tensión, vanidosos, muy creativos, agradables."
        Dim piscis As String = "Sutiles, dulces, tolerantes, imprevisibles, románticos pero quisquillosos e incluso infieles. Creen en la amistad y el amor."

        Select Case mes
            Case 1
                If mes <= 19 Then
                    Return capricornio
                Else
                    Return acuario
                End If
            Case 2
                If mes <= 18 Then
                    Return acuario
                Else
                    Return piscis
                End If
            Case 3
                If mes <= 19 Then
                    Return piscis
                Else
                    Return aries
                End If
            Case 4
                If mes <= 18 Then
                    Return aries
                Else
                    Return tauro
                End If
            Case 5
                If mes <= 19 Then
                    Return tauro
                Else
                    Return geminis
                End If
            Case 6
                If mes <= 20 Then
                    Return geminis
                Else
                    Return cancer
                End If

        End Select

    End Function

End Module
