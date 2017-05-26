Module Module1

    Sub Main()

        Dim num1 As Integer = Console.ReadLine
        Dim num2 As Integer = Console.ReadLine

        If num1 > num2 Then
            Console.WriteLine("numero1: {0} es mayor a numero2: {1} ", num1, num2)
        ElseIf num1 < num2 Then
            Console.WriteLine("numero1: {0} es menor a numero2: {1} ", num1, num2)
        Else
            Console.WriteLine("numero1: {0} es igual a numero2: {1} ", num1, num2)
        End If



        Console.ReadKey()
    End Sub

End Module
