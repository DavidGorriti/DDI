Public Class Form1

    Dim Capital(50) As String
    Dim State(50) As String
    Dim lista(4) As Integer
    Dim ans As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        State(1) = "Alabama" : Capital(1) = "Montgomery"
        State(2) = "Alaska" : Capital(2) = "Juneau"
        State(3) = "Arizona" : Capital(3) = "Phoenix"
        State(4) = "Arkansas" : Capital(4) = "Little Rock"
        State(5) = "California" : Capital(5) = "Sacramento"
        State(6) = "Colorado" : Capital(6) = "Denver"
        State(7) = "Connecticut" : Capital(7) = "Hartford"
        State(8) = "Delaware" : Capital(8) = "Dover"
        State(9) = "Florida" : Capital(9) = "Tallahassee"
        State(10) = "Georgia" : Capital(10) = "Atlanta"
        State(11) = "Hawaii" : Capital(11) = "Honolulu"
        State(12) = "Idaho" : Capital(12) = "Boise"
        State(13) = "Illinois" : Capital(13) = "Springfield"
        State(14) = "Indiana" : Capital(14) = "Indianapolis"
        State(15) = "Iowa" : Capital(15) = "Des Moines"
        State(16) = "Kansas" : Capital(16) = "Topeka"
        State(17) = "Kentucky" : Capital(17) = "Frankfort"
        State(18) = "Louisiana" : Capital(18) = "Baton Rouge"
        State(19) = "Maine" : Capital(19) = "Augusta"
        State(20) = "Maryland" : Capital(20) = "Annapolis"
        State(21) = "Massachusetts" : Capital(21) = "Boston"
        State(22) = "Michigan" : Capital(22) = "Lansing"
        State(23) = "Minnesota" : Capital(23) = "Saint Paul"
        State(24) = "Mississippi" : Capital(24) = "Jackson"
        State(25) = "Missouri" : Capital(25) = "Jefferson City"
        State(26) = "Montana" : Capital(26) = "Helena"
        State(27) = "Nebraska" : Capital(27) = "Lincoln"
        State(28) = "Nevada" : Capital(28) = "Carson City"
        State(29) = "New Hampshire" : Capital(29) = "Concord"
        State(30) = "New Jersey" : Capital(30) = "Trenton"
        State(31) = "New Mexico" : Capital(31) = "Santa Fe"
        State(32) = "New York" : Capital(32) = "Albany"
        State(33) = "North Carolina" : Capital(33) = "Raleigh"
        State(34) = "North Dakota" : Capital(34) = "Bismarck"
        State(35) = "Ohio" : Capital(35) = "Columbus"
        State(36) = "Oklahoma" : Capital(36) = "Oklahoma City"
        State(37) = "Oregon" : Capital(37) = "Salem"
        State(38) = "Pennsylvania" : Capital(38) = "Harrisburg"
        State(39) = "Rhode Island" : Capital(39) = "Providence"
        State(40) = "South Carolina" : Capital(40) = "Columbia"
        State(41) = "South Dakota" : Capital(41) = "Pierre"
        State(42) = "Tennessee" : Capital(42) = "Nashville"
        State(43) = "Texas" : Capital(43) = "Austin"
        State(44) = "Utah" : Capital(44) = "Salt Lake City"
        State(45) = "Vermont" : Capital(45) = "Montpelier"
        State(46) = "Virginia" : Capital(46) = "Richmond"
        State(47) = "Washington" : Capital(47) = "Olympia"
        State(48) = "West Virginia" : Capital(48) = "Charleston"
        State(49) = "Wisconsin" : Capital(49) = "Madison"
        State(50) = "Wyoming" : Capital(50) = "Cheyenne"
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        btnIniciar.Enabled = False

        inizializa()

    End Sub

    Private Sub lstItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstItems.SelectedIndexChanged
        If ans <> lstItems.SelectedIndex Then
            MsgBox("PUES NADA")
            txtFallos.Text += 1

        End If

        inizializa()

    End Sub

    Private Sub inizializa()
        ans = Obtener4numeros(lista)

        lstItems.Items.Clear()

        For i As Integer = 0 To 3
            lstItems.Items.Add(Capital(lista(i)))
        Next

        lblEstado.Text = State(lista(ans))
    End Sub

End Class
