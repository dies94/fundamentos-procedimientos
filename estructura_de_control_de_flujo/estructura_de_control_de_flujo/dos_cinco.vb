Module dos_cinco

    Sub main()


        Dim d As Integer = Console.ReadLine()


        Select Case d
            Case 1
                Console.WriteLine("el mes es Enero")
            Case 2
                Console.WriteLine("el mes es Febrero")
            Case 3
                Console.WriteLine("el mes es Marzo")
            Case 4
                Console.WriteLine("el mes es Abril")
            Case 5
                Console.WriteLine("el mes es mayo")
            Case 6
                Console.WriteLine("el mes es Junio")
            Case 7
                Console.WriteLine("el mes es Julio")
            Case 8
                Console.WriteLine("el mes es Agosto")
            Case 9
                Console.WriteLine("el mes es Sepiembre")
            Case 10
                Console.WriteLine("el mes es Octube")
            Case 11
                Console.WriteLine("el mes es Noviembre")
            Case 12
                Console.WriteLine("el mes es Diciembre")

        End Select

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' Dim meses As mes

        ' meses = CType(d, mes)

        'Select Case meses
        'Case meses
        ' Console.WriteLine("el mes es " & meses.ToString)
        '  End Select


        Console.ReadKey()

    End Sub


End Module
