Module dos_dos


    Sub main()


        Dim num1 As Integer = Console.ReadLine
        Dim num2 As Integer = Console.ReadLine
        Dim num3 As Integer = Console.ReadLine
        Dim nmen As Integer

        nmen = Math.Min(num2, num3)

        If nmen > num1 Then
            Console.WriteLine("el numero menor es: " & num1)
        Else
            Console.WriteLine("el numero menor es: " & nmen)
        End If



        Console.ReadKey()

    End Sub

End Module
