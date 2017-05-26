Module dos_siete


    Sub main()

        'Dim angulo As Integer = 120
        Dim angulo As Integer = Console.ReadLine


        Select Case angulo
            Case 1 To 59
                Console.WriteLine("angulo AGUDO")
            Case 90
                Console.WriteLine("angulo RECTO")
            Case 91 To 179
                Console.WriteLine("angulo OBTUSO")
            Case 180
                Console.WriteLine("angulo LLANO")
            Case 181 To 359
                Console.WriteLine("angulo CONCAVO")
            Case Else
                Console.WriteLine("ERROR")
        End Select

        Console.ReadKey()

    End Sub

End Module
