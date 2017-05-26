Module dos_tres

    Sub main()

        Dim num1 As Integer = Console.ReadLine
        Dim num2 As Integer = Console.ReadLine
        Dim num3 As Integer = Console.ReadLine
        Dim num4 As Integer = Console.ReadLine
        Dim num5 As Integer = Console.ReadLine
        Dim nummax1 As Integer
        Dim nummax2 As Integer

        nummax1 = Math.Max(num2, num3)
        nummax2 = Math.Max(num3, num4)

        If nummax1 > nummax2 Then
            Console.WriteLine("mayor numero ingresado: " & Math.Max(nummax1, num5))
        Else
            Console.WriteLine("mayor numero ingresado: " & Math.Max(nummax2, num5))
        End If

        Console.ReadKey()


    End Sub

End Module
