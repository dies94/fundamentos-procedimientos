﻿Module tres_nueve
    Sub main()

        Dim l, b, v, a, h As Integer
        Dim opciones As Byte

        Console.WriteLine("1= cuadrado")
        Console.WriteLine("2= rectangulo")
        Console.WriteLine("3= trapecio")
        opciones = Console.ReadLine()

        Select Case opciones
            Case 1
                Console.WriteLine("ingresar valores lado: ")
                l = Console.ReadLine()
                Console.WriteLine("valor area: " & area(l))
            Case 2
                Console.WriteLine("ingresar valores base: ")
                b = Console.ReadLine()
                Console.WriteLine("ingresar valores altura: ")
                a = Console.ReadLine()
                Console.WriteLine("valor area: " & area(b, a))
            Case 3
                Console.WriteLine("ingresar valores base: ")
                b = Console.ReadLine()
                Console.WriteLine("ingresar valores b: ")
                v = Console.ReadLine()
                Console.WriteLine("ingresar valores h: ")
                h = Console.ReadLine()
                Console.WriteLine("valor area: " & area(b, v, h))
        End Select


        Console.ReadKey()

    End Sub

    Private Function area(l As Integer) As Integer

        Return l * l

    End Function

    Private Function area(b As Integer, a As Integer) As Integer

        Return b * a

    End Function

    Private Function area(b As Integer, a As Integer, h As Integer) As Integer

        Return ((b + a) / 2) * h

    End Function
End Module
