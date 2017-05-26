Module dos_ocho

    Enum mes As Integer

        enero = 1
        feberero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12

    End Enum

    Sub main()

        Dim anio As Integer
        Dim resto_de_400 As Integer
        Dim resto_de_4 As Integer
        Dim resto_de_100 As Integer

        Console.Write("numero de mes: ")
        Dim numero_mes = Console.ReadLine()

        If mes.feberero = numero_mes Then

            Console.Write("numero de año: ")
            anio = Console.ReadLine()

            resto_de_100 = anio Mod 100
            resto_de_400 = anio Mod 400
            resto_de_4 = anio Mod 4

            If resto_de_100 <> 0 And resto_de_4 = 0 Or resto_de_400 = 0 Then
                Console.WriteLine("mes de febrero tiene 29 dias")
            Else
                Console.WriteLine("mes de febrero tiene 28 dias")
            End If


        Else

            Select Case numero_mes
                Case mes.enero
                    Console.WriteLine("enero tiene 31 dias")
                Case mes.marzo
                    Console.WriteLine("mes de marzo tiene 31 dias")
                Case mes.abril
                    Console.WriteLine("mes de abril tiene 30 dias")
                Case mes.mayo
                    Console.WriteLine("mes de mayo tiene 31 dias")
                Case mes.junio
    
                    Console.WriteLine("mes de junio tiene 30 dias")
                Case mes.julio
                    Console.WriteLine("mes de julio tiene 31 dias")
                Case mes.agosto
                    Console.WriteLine("mes de agosto tiene 31 dias")
                Case mes.septiembre
                    Console.WriteLine("mes de septiembre tiene 30 dias")
                Case mes.octubre
                    Console.WriteLine("mes de octubre tiene 31 dias")
                Case mes.noviembre
                    Console.WriteLine("mes de noviembre tiene 30 dias")
                Case mes.diciembre
                    Console.WriteLine("mes de diciembre tiene 31 dias")
            End Select

        End If



        Console.ReadKey()
    End Sub

End Module
