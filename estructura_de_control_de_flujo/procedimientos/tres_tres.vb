﻿Module tres_tres

    Sub main()

        Dim numero As Integer = Console.ReadLine



        For x As Integer = 2 To 6

            Console.WriteLine(potenciacion(numero, x))

        Next

        Console.ReadLine()

    End Sub

    Private Function potenciacion(ByRef numero As Integer, ByRef x As Integer)

        Dim resultado As Integer

        resultado = numero ^ x

        Return resultado

    End Function

End Module
