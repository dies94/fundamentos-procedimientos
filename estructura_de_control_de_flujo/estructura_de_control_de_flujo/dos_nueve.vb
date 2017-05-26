Module dos_nueve

    Enum mediadas As Integer

        yarda = 1
        pie = 3
        pulgada = 36
        cm = 91.44
        m = 9.84

    End Enum

    Sub main()

        Dim nummedida As Integer

        Console.WriteLine("pie = 1")
        Console.WriteLine("yarda = 2")
        Console.WriteLine("pulgadas = 3")
        Console.WriteLine("centimetros = 4")
        Console.WriteLine("metros = 5")

        Console.Write("ingrese una opcion: ")
        Dim opciones As Byte = Console.ReadLine()
        Console.Write("ingrese un numero: ")
        nummedida = Console.ReadLine()

        Select Case opciones
            Case 1
                Console.WriteLine("yardas: " & nummedida / mediadas.pie * mediadas.yarda)
                Console.WriteLine("pulgadas: " & nummedida / mediadas.pie * mediadas.pulgada)
                Console.WriteLine("centimeros: " & nummedida / mediadas.pie * mediadas.cm)
                Console.WriteLine("metros: " & nummedida / mediadas.pie * mediadas.m)

            Case 2
                Console.WriteLine("pies: " & nummedida / mediadas.yarda * mediadas.pie)
                Console.WriteLine("pulgadas: " & nummedida / mediadas.yarda * mediadas.pulgada)
                Console.WriteLine("centimeros: " & nummedida / mediadas.yarda * mediadas.cm)
                Console.WriteLine("metros: " & nummedida / mediadas.yarda * mediadas.m)

            Case 3
                Console.WriteLine("pies: " & nummedida / mediadas.pulgada * mediadas.pie)
                Console.WriteLine("yardas: " & nummedida / mediadas.pulgada * mediadas.yarda)
                Console.WriteLine("centimeros: " & nummedida / mediadas.pulgada * mediadas.cm)
                Console.WriteLine("metros: " & nummedida / mediadas.pulgada * mediadas.m)
            Case 4
                Console.WriteLine("pies: " & nummedida / mediadas.cm * mediadas.pie)
                Console.WriteLine("pulgadas: " & nummedida / mediadas.cm * mediadas.pulgada)
                Console.WriteLine("yardas: " & nummedida / mediadas.cm * mediadas.yarda)
                Console.WriteLine("metros: " & nummedida / mediadas.cm * mediadas.m)
            Case 5
                Console.WriteLine("pies: " & nummedida / mediadas.m * mediadas.pie)
                Console.WriteLine("pulgadas: " & nummedida / mediadas.m * mediadas.pulgada)
                Console.WriteLine("centimeros: " & nummedida / mediadas.m * mediadas.cm)
                Console.WriteLine("yardas: " & nummedida / mediadas.m * mediadas.yarda)

        End Select


        Console.ReadKey()
    End Sub

End Module
