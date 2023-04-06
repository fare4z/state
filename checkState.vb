 Public Function checkState(ByVal nric As String)

        Dim stateCode As String = nric.Substring(6, 2)
        Dim stateName As String

        Select Case stateCode
            Case "01", "21", "22", "23", "24"
                stateName = "Johor"
            Case "02", "25", "26", "27"
                stateName = "Kedah"
            Case "03", "28", "29"
                stateName = "Kelantan"
            Case "04", "30"
                stateName = "Melaka"
            Case "05", "31", "59"
                stateName = "Negeri Sembilan"
            Case "06", "32", "33"
                stateName = "Pahang"
            Case "07", "34", "35"
                stateName = "Pulau Pinang"
            Case "08", "36", "37", "38", "39"
                stateName = "Perak"
            Case "09", "40"
                stateName = "Perlis"
            Case "10", "41", "42", "43", "44"
                stateName = "Selangor"
            Case "11", "45", "46"
                stateName = "Terengganu"
            Case "12", "47", "48", "49"
                stateName = "Sabah"
            Case "13", "50", "51", "52", "53"
                stateName = "Sarawak"
            Case "14", "54", "55", "56", "57"
                stateName = "Wilayah Persekutuan (Kuala Lumpur)"
            Case "15", "58"
                stateName = "Wilayah Persekutuan (Labuan)"
            Case "16"
                stateName = "Wilayah Persekutuan (Putrajaya)"
            Case "82"
                stateName = "Negeri Tidak Diketahui"
            Case Else
                stateName = "Invalid State Code"
        End Select

        Return stateName

    End Function
